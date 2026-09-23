Things to review
- CustomerDto nullable properties
- ...




CustomerName = order.Customer?.Name

هنا أنت بتجيب اسم الـ Customer من الـ navigation property، لكن باستخدام ?..

يعني:

Order
 ↓
Customer
 ↓
Name

ولو Customer كانت null:

CustomerName = null

وده يفسر ليه أنت عامل CustomerName في OrderDto nullable:

public string? CustomerName { get; set; }

فـ هنا الـ nullable له سبب فعلي في الكود، بعكس CustomerDto اللي لسه مش شايفين سبب يخلي Name وPhone nullable.

ودي نقطة مهمة جدًا إننا اكتشفناها أثناء التوثيق.

كمان الـ Items

أنت بتعمل:

Items = order.Items.Select(oi => new OrderItemDto
{
    ...
}).ToList()

يعني OrderMapping بيعمل mapping للـ OrderItem داخله مباشرة بدل ما يستدعي:

OrderItemMapping.ToDto(oi)

وده معناه إن عندك حاليًا تكرار في mapping logic.

عندك:

OrderItemMapping
    ↓
OrderItem → OrderItemDto

وفي نفس الوقت:

OrderMapping
    ↓
Order.Items
    ↓
Select(...)
    ↓
OrderItemDto

مش لازم نصلحه دلوقتي. إحنا في مرحلة فهم وتوثيق المشروع، فنسجل الملاحظة ونقرر بعد ما نخلص المراجعة


وفيه 3 ملاحظات سجلناها أثناء المراجعة
مش نصلحهم دلوقتي؛ بس نحتفظ بيهم لمرحلة مراجعة المشروع:

CustomerDto.Name وPhone معمولين nullable رغم إن Customer نفسه non-nullable.
OrderMapping بيكرر منطق OrderItem → OrderItemDto الموجود أصلًا في OrderItemMapping.
ProductDto.Id يستخدم init بينما باقي الـ DTOs تستخدم set..



وفيه كام ملاحظة نحطهم في Review Later بدل ما نعدل دلوقتي:

DataBaseSeeding اسمها يوحي إنها بتعمل Database Seeding، لكن الكود المعروض فعليًا بيجيب products من API ويرجعهم فقط؛ لسه محتاجين نشوف مين بيستدعيها وهل بيحفظ الـ products في DB.
HttpClient متعمل مباشرة بـ new HttpClient()؛ هنشوف بعدين هل المشروع فيه DI وازاي بيتعامل معاه.
AppDbContext عنده constructor بـ options + parameterless constructor؛ هنشوف استخدامهم الفعلي قبل ما نحكم إن واحد منهم زائد.
OnConfiguring() بيقرأ appsettings.json مباشرة. هنشوف بعدين هل فيه configuration تاني أو DI بيضبط الـ Context.

وده مهم جدًا: ما نوثّقش دلوقتي إن DataBaseSeeding فعلًا بيعمل seeding للـ database. الاسم بيقول كده، لكن الكود اللي شوفناه لحد الآن لا يثبت ده. هنستنتج الـ flow الحقيقي لما نشوف الـ Services وProgram.cs/UI.