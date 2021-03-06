
namespace Project_work
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cropping = new System.Windows.Forms.Button();
            this.create_area = new System.Windows.Forms.Button();
            this.moving_instr = new System.Windows.Forms.Button();
            this.brush = new System.Windows.Forms.Button();
            this.pipette = new System.Windows.Forms.Button();
            this.Apply_button = new System.Windows.Forms.Button();
            this.workSpace = new System.Windows.Forms.PictureBox();
            this.contextPicBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьНаНовыйСлойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьНаНовыйСлойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_from_file = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПрямоугольнуюОбластьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обрезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кистьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ластикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пипеткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветокоррекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.насыщенностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветовойТонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветовойБалансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Scale = new System.Windows.Forms.TrackBar();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.Prop_panel = new System.Windows.Forms.Panel();
            this.TransparencyUpDown = new System.Windows.Forms.NumericUpDown();
            this.TransparencyLabel = new System.Windows.Forms.Label();
            this.colorButtonChoose = new System.Windows.Forms.Button();
            this.current_color_label = new System.Windows.Forms.Label();
            this.opacity_UpDown = new System.Windows.Forms.NumericUpDown();
            this.brush_width_label = new System.Windows.Forms.Label();
            this.Brush_label = new System.Windows.Forms.Label();
            this.HeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.scale_changing_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Eraser_button = new System.Windows.Forms.Button();
            this.Color_correction_button = new System.Windows.Forms.Button();
            this.Color_balance_button = new System.Windows.Forms.Button();
            this.LayerAddButton = new System.Windows.Forms.Button();
            this.LayerDeleteButton = new System.Windows.Forms.Button();
            this.LayerDownButton = new System.Windows.Forms.Button();
            this.LayerUpButton = new System.Windows.Forms.Button();
            this.colorChoose = new System.Windows.Forms.ColorDialog();
            this.layerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.workSpace)).BeginInit();
            this.contextPicBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).BeginInit();
            this.Prop_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cropping
            // 
            this.cropping.BackColor = System.Drawing.Color.DimGray;
            this.cropping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cropping.BackgroundImage")));
            this.cropping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cropping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cropping.FlatAppearance.BorderSize = 0;
            this.cropping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cropping.Location = new System.Drawing.Point(12, 113);
            this.cropping.Name = "cropping";
            this.cropping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cropping.Size = new System.Drawing.Size(30, 30);
            this.cropping.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cropping, "Инструмент \"Обрезка\". Выделяет прямоугольную область и удаляет всё, что выходит з" +
        "а её пределы.");
            this.cropping.UseVisualStyleBackColor = false;
            this.cropping.Click += new System.EventHandler(this.CroppingClick);
            // 
            // create_area
            // 
            this.create_area.BackColor = System.Drawing.Color.DimGray;
            this.create_area.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("create_area.BackgroundImage")));
            this.create_area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.create_area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_area.FlatAppearance.BorderSize = 0;
            this.create_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_area.Location = new System.Drawing.Point(12, 77);
            this.create_area.Name = "create_area";
            this.create_area.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.create_area.Size = new System.Drawing.Size(30, 30);
            this.create_area.TabIndex = 1;
            this.toolTip1.SetToolTip(this.create_area, "Инструмент \"Выделение\". Позволяет выделить прямоугольную область на экране.");
            this.create_area.UseVisualStyleBackColor = false;
            this.create_area.Click += new System.EventHandler(this.CreateAreaClick);
            // 
            // moving_instr
            // 
            this.moving_instr.BackColor = System.Drawing.Color.DimGray;
            this.moving_instr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moving_instr.BackgroundImage")));
            this.moving_instr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moving_instr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moving_instr.FlatAppearance.BorderSize = 0;
            this.moving_instr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moving_instr.ForeColor = System.Drawing.Color.Black;
            this.moving_instr.Location = new System.Drawing.Point(12, 41);
            this.moving_instr.Name = "moving_instr";
            this.moving_instr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moving_instr.Size = new System.Drawing.Size(30, 30);
            this.moving_instr.TabIndex = 2;
            this.toolTip1.SetToolTip(this.moving_instr, "Инструмент \"Перемещение\". Позволяет смещать изображение.\r\nПри смещении изображени" +
        "я за границы рабочего поля оно не обрезается и не искажается.");
            this.moving_instr.UseVisualStyleBackColor = false;
            this.moving_instr.Click += new System.EventHandler(this.MovingInstrClick);
            // 
            // brush
            // 
            this.brush.BackColor = System.Drawing.Color.DimGray;
            this.brush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brush.BackgroundImage")));
            this.brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brush.FlatAppearance.BorderSize = 0;
            this.brush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brush.Location = new System.Drawing.Point(12, 163);
            this.brush.Name = "brush";
            this.brush.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brush.Size = new System.Drawing.Size(30, 30);
            this.brush.TabIndex = 3;
            this.toolTip1.SetToolTip(this.brush, "Инструмент \"Кисть\". Позволяет нарисовать линию заданной толщины и цвета.");
            this.brush.UseVisualStyleBackColor = false;
            this.brush.Click += new System.EventHandler(this.BrushClick);
            // 
            // pipette
            // 
            this.pipette.BackColor = System.Drawing.Color.DimGray;
            this.pipette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipette.BackgroundImage")));
            this.pipette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pipette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pipette.FlatAppearance.BorderSize = 0;
            this.pipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipette.Location = new System.Drawing.Point(12, 199);
            this.pipette.Name = "pipette";
            this.pipette.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pipette.Size = new System.Drawing.Size(30, 30);
            this.pipette.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pipette, "Инструмент \"Пипетка\". Позволяет выбрать нужный цвет с изображения. \r\nДля удобства" +
        " кнопка подсвечивается тем цветом, над которым сейчас находится курсор.");
            this.pipette.UseVisualStyleBackColor = false;
            this.pipette.Click += new System.EventHandler(this.ClickPipette);
            // 
            // Apply_button
            // 
            this.Apply_button.BackColor = System.Drawing.Color.DimGray;
            this.Apply_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Apply_button.BackgroundImage")));
            this.Apply_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Apply_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Apply_button.FlatAppearance.BorderSize = 0;
            this.Apply_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply_button.Location = new System.Drawing.Point(12, 512);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Apply_button.Size = new System.Drawing.Size(30, 30);
            this.Apply_button.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Apply_button, "Инструмент \"Подтвердить\". Выполняет подтверждение внесенных изменений на изображе" +
        "нии.");
            this.Apply_button.UseVisualStyleBackColor = false;
            this.Apply_button.Click += new System.EventHandler(this.ClickApplyButton);
            // 
            // workSpace
            // 
            this.workSpace.BackColor = System.Drawing.Color.Black;
            this.workSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("workSpace.BackgroundImage")));
            this.workSpace.ContextMenuStrip = this.contextPicBox;
            this.workSpace.Cursor = System.Windows.Forms.Cursors.Default;
            this.workSpace.Location = new System.Drawing.Point(0, 0);
            this.workSpace.Name = "workSpace";
            this.workSpace.Size = new System.Drawing.Size(675, 504);
            this.workSpace.TabIndex = 6;
            this.workSpace.TabStop = false;
            this.workSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownWorkSpace);
            this.workSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveWorkSpace);
            this.workSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpWorkSpace);
            // 
            // contextPicBox
            // 
            this.contextPicBox.BackColor = System.Drawing.Color.Gray;
            this.contextPicBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextPicBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.скопироватьНаНовыйСлойToolStripMenuItem,
            this.вырезатьНаНовыйСлойToolStripMenuItem});
            this.contextPicBox.Name = "contextMenuStrip1";
            this.contextPicBox.ShowImageMargin = false;
            this.contextPicBox.Size = new System.Drawing.Size(253, 124);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.ClickCutToolStripMenuItem);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.ClickCopyToolStripMenuItem);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // скопироватьНаНовыйСлойToolStripMenuItem
            // 
            this.скопироватьНаНовыйСлойToolStripMenuItem.Name = "скопироватьНаНовыйСлойToolStripMenuItem";
            this.скопироватьНаНовыйСлойToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.скопироватьНаНовыйСлойToolStripMenuItem.Text = "Скопировать на новый слой";
            this.скопироватьНаНовыйСлойToolStripMenuItem.Click += new System.EventHandler(this.CopyToNewLayerContextClick);
            // 
            // вырезатьНаНовыйСлойToolStripMenuItem
            // 
            this.вырезатьНаНовыйСлойToolStripMenuItem.Name = "вырезатьНаНовыйСлойToolStripMenuItem";
            this.вырезатьНаНовыйСлойToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.вырезатьНаНовыйСлойToolStripMenuItem.Text = "Вырезать на новый слой";
            this.вырезатьНаНовыйСлойToolStripMenuItem.Click += new System.EventHandler(this.CutToNewLayerContextClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.рисованиеToolStripMenuItem,
            this.цветокоррекцияToolStripMenuItem,
            this.видToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_from_file,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Open_from_file
            // 
            this.Open_from_file.Name = "Open_from_file";
            this.Open_from_file.Size = new System.Drawing.Size(201, 26);
            this.Open_from_file.Text = "Открыть";
            this.Open_from_file.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переместитьToolStripMenuItem,
            this.создатьПрямоугольнуюОбластьToolStripMenuItem,
            this.обрезатьToolStripMenuItem});
            this.редактированиеToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            this.переместитьToolStripMenuItem.Click += new System.EventHandler(this.MovingInstrClick);
            // 
            // создатьПрямоугольнуюОбластьToolStripMenuItem
            // 
            this.создатьПрямоугольнуюОбластьToolStripMenuItem.Name = "создатьПрямоугольнуюОбластьToolStripMenuItem";
            this.создатьПрямоугольнуюОбластьToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.создатьПрямоугольнуюОбластьToolStripMenuItem.Text = "Создать прямоугольную область";
            this.создатьПрямоугольнуюОбластьToolStripMenuItem.Click += new System.EventHandler(this.CreateAreaClick);
            // 
            // обрезатьToolStripMenuItem
            // 
            this.обрезатьToolStripMenuItem.Name = "обрезатьToolStripMenuItem";
            this.обрезатьToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.обрезатьToolStripMenuItem.Text = "Обрезать";
            this.обрезатьToolStripMenuItem.Click += new System.EventHandler(this.CroppingClick);
            // 
            // рисованиеToolStripMenuItem
            // 
            this.рисованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кистьToolStripMenuItem,
            this.ластикToolStripMenuItem,
            this.пипеткаToolStripMenuItem,
            this.заливкаToolStripMenuItem});
            this.рисованиеToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.рисованиеToolStripMenuItem.Name = "рисованиеToolStripMenuItem";
            this.рисованиеToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.рисованиеToolStripMenuItem.Text = "Рисование";
            // 
            // кистьToolStripMenuItem
            // 
            this.кистьToolStripMenuItem.Name = "кистьToolStripMenuItem";
            this.кистьToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.кистьToolStripMenuItem.Text = "Кисть";
            this.кистьToolStripMenuItem.Click += new System.EventHandler(this.BrushClick);
            // 
            // ластикToolStripMenuItem
            // 
            this.ластикToolStripMenuItem.Name = "ластикToolStripMenuItem";
            this.ластикToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.ластикToolStripMenuItem.Text = "Ластик";
            this.ластикToolStripMenuItem.Click += new System.EventHandler(this.EraserButtonClick);
            // 
            // пипеткаToolStripMenuItem
            // 
            this.пипеткаToolStripMenuItem.Name = "пипеткаToolStripMenuItem";
            this.пипеткаToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.пипеткаToolStripMenuItem.Text = "Пипетка";
            this.пипеткаToolStripMenuItem.Click += new System.EventHandler(this.ClickPipette);
            // 
            // заливкаToolStripMenuItem
            // 
            this.заливкаToolStripMenuItem.Name = "заливкаToolStripMenuItem";
            this.заливкаToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.заливкаToolStripMenuItem.Text = "Заливка";
            // 
            // цветокоррекцияToolStripMenuItem
            // 
            this.цветокоррекцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.насыщенностьToolStripMenuItem,
            this.яркостьToolStripMenuItem,
            this.цветовойТонToolStripMenuItem,
            this.цветовойБалансToolStripMenuItem});
            this.цветокоррекцияToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.цветокоррекцияToolStripMenuItem.Name = "цветокоррекцияToolStripMenuItem";
            this.цветокоррекцияToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.цветокоррекцияToolStripMenuItem.Text = "Цветокоррекция";
            // 
            // насыщенностьToolStripMenuItem
            // 
            this.насыщенностьToolStripMenuItem.Name = "насыщенностьToolStripMenuItem";
            this.насыщенностьToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.насыщенностьToolStripMenuItem.Text = "Насыщенность";
            this.насыщенностьToolStripMenuItem.Click += new System.EventHandler(this.ClickColorCorrectionButton);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.яркостьToolStripMenuItem.Text = "Яркость";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.ClickColorCorrectionButton);
            // 
            // цветовойТонToolStripMenuItem
            // 
            this.цветовойТонToolStripMenuItem.Name = "цветовойТонToolStripMenuItem";
            this.цветовойТонToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.цветовойТонToolStripMenuItem.Text = "Цветовой тон";
            // 
            // цветовойБалансToolStripMenuItem
            // 
            this.цветовойБалансToolStripMenuItem.Name = "цветовойБалансToolStripMenuItem";
            this.цветовойБалансToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.цветовойБалансToolStripMenuItem.Text = "Цветовой баланс";
            this.цветовойБалансToolStripMenuItem.Click += new System.EventHandler(this.ClickColorBalanceButton);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // Scale
            // 
            this.Scale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Scale.Location = new System.Drawing.Point(755, 623);
            this.Scale.Maximum = 500;
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(253, 56);
            this.Scale.TabIndex = 8;
            this.Scale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Scale.Value = 100;
            this.Scale.Scroll += new System.EventHandler(this.ScrollScale);
            // 
            // scaleLabel
            // 
            this.scaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scaleLabel.ForeColor = System.Drawing.Color.White;
            this.scaleLabel.Location = new System.Drawing.Point(952, 648);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(56, 20);
            this.scaleLabel.TabIndex = 9;
            this.scaleLabel.Text = "100 %";
            // 
            // Prop_panel
            // 
            this.Prop_panel.AutoSize = true;
            this.Prop_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Prop_panel.Controls.Add(this.TransparencyUpDown);
            this.Prop_panel.Controls.Add(this.TransparencyLabel);
            this.Prop_panel.Controls.Add(this.colorButtonChoose);
            this.Prop_panel.Controls.Add(this.current_color_label);
            this.Prop_panel.Controls.Add(this.opacity_UpDown);
            this.Prop_panel.Controls.Add(this.brush_width_label);
            this.Prop_panel.Controls.Add(this.Brush_label);
            this.Prop_panel.Controls.Add(this.HeightUpDown);
            this.Prop_panel.Controls.Add(this.label3);
            this.Prop_panel.Controls.Add(this.label2);
            this.Prop_panel.Controls.Add(this.label1);
            this.Prop_panel.Controls.Add(this.WidthUpDown);
            this.Prop_panel.ForeColor = System.Drawing.Color.Transparent;
            this.Prop_panel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Prop_panel.Location = new System.Drawing.Point(756, 41);
            this.Prop_panel.Name = "Prop_panel";
            this.Prop_panel.Size = new System.Drawing.Size(252, 256);
            this.Prop_panel.TabIndex = 13;
            // 
            // TransparencyUpDown
            // 
            this.TransparencyUpDown.BackColor = System.Drawing.Color.DimGray;
            this.TransparencyUpDown.Location = new System.Drawing.Point(164, 183);
            this.TransparencyUpDown.Name = "TransparencyUpDown";
            this.TransparencyUpDown.Size = new System.Drawing.Size(81, 22);
            this.TransparencyUpDown.TabIndex = 17;
            this.TransparencyUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TransparencyUpDown.ValueChanged += new System.EventHandler(this.ChangeValueTransparencyUpDown);
            // 
            // TransparencyLabel
            // 
            this.TransparencyLabel.AutoSize = true;
            this.TransparencyLabel.Location = new System.Drawing.Point(5, 185);
            this.TransparencyLabel.Name = "TransparencyLabel";
            this.TransparencyLabel.Size = new System.Drawing.Size(106, 17);
            this.TransparencyLabel.TabIndex = 16;
            this.TransparencyLabel.Text = "Прозрачность:";
            // 
            // colorButtonChoose
            // 
            this.colorButtonChoose.BackColor = System.Drawing.Color.DarkOrange;
            this.colorButtonChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colorButtonChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButtonChoose.FlatAppearance.BorderSize = 0;
            this.colorButtonChoose.Location = new System.Drawing.Point(117, 219);
            this.colorButtonChoose.Name = "colorButtonChoose";
            this.colorButtonChoose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorButtonChoose.Size = new System.Drawing.Size(130, 20);
            this.colorButtonChoose.TabIndex = 15;
            this.colorButtonChoose.UseVisualStyleBackColor = false;
            this.colorButtonChoose.Click += new System.EventHandler(this.ClickChooseColorButton);
            // 
            // current_color_label
            // 
            this.current_color_label.AutoSize = true;
            this.current_color_label.Location = new System.Drawing.Point(7, 222);
            this.current_color_label.Name = "current_color_label";
            this.current_color_label.Size = new System.Drawing.Size(104, 17);
            this.current_color_label.TabIndex = 14;
            this.current_color_label.Text = "Текущий цвет:";
            // 
            // opacity_UpDown
            // 
            this.opacity_UpDown.BackColor = System.Drawing.Color.DimGray;
            this.opacity_UpDown.Location = new System.Drawing.Point(166, 144);
            this.opacity_UpDown.Maximum = new decimal(new int[] {
            8400,
            0,
            0,
            0});
            this.opacity_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.opacity_UpDown.Name = "opacity_UpDown";
            this.opacity_UpDown.Size = new System.Drawing.Size(81, 22);
            this.opacity_UpDown.TabIndex = 13;
            this.opacity_UpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.opacity_UpDown.ValueChanged += new System.EventHandler(this.ChangeValueOpacityUpDown);
            // 
            // brush_width_label
            // 
            this.brush_width_label.AutoSize = true;
            this.brush_width_label.Location = new System.Drawing.Point(7, 146);
            this.brush_width_label.Name = "brush_width_label";
            this.brush_width_label.Size = new System.Drawing.Size(157, 17);
            this.brush_width_label.TabIndex = 12;
            this.brush_width_label.Text = "Толщина (в пикселях):";
            // 
            // Brush_label
            // 
            this.Brush_label.AutoSize = true;
            this.Brush_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brush_label.Location = new System.Drawing.Point(7, 121);
            this.Brush_label.Name = "Brush_label";
            this.Brush_label.Size = new System.Drawing.Size(56, 17);
            this.Brush_label.TabIndex = 11;
            this.Brush_label.Text = "Кисть:";
            // 
            // HeightUpDown
            // 
            this.HeightUpDown.BackColor = System.Drawing.Color.DimGray;
            this.HeightUpDown.Location = new System.Drawing.Point(166, 79);
            this.HeightUpDown.Maximum = new decimal(new int[] {
            8400,
            0,
            0,
            0});
            this.HeightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightUpDown.Name = "HeightUpDown";
            this.HeightUpDown.Size = new System.Drawing.Size(81, 22);
            this.HeightUpDown.TabIndex = 4;
            this.HeightUpDown.Value = new decimal(new int[] {
            504,
            0,
            0,
            0});
            this.HeightUpDown.ValueChanged += new System.EventHandler(this.ChangeValueHeightUpDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Высота (в пикселях):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина (в пикселях):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Свойства проекта:";
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.BackColor = System.Drawing.Color.DimGray;
            this.WidthUpDown.Location = new System.Drawing.Point(166, 43);
            this.WidthUpDown.Maximum = new decimal(new int[] {
            8400,
            0,
            0,
            0});
            this.WidthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthUpDown.Name = "WidthUpDown";
            this.WidthUpDown.Size = new System.Drawing.Size(81, 22);
            this.WidthUpDown.TabIndex = 0;
            this.WidthUpDown.Value = new decimal(new int[] {
            675,
            0,
            0,
            0});
            this.WidthUpDown.ValueChanged += new System.EventHandler(this.ChangeValueWidthUpDown);
            // 
            // scale_changing_label
            // 
            this.scale_changing_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scale_changing_label.AutoSize = true;
            this.scale_changing_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scale_changing_label.Location = new System.Drawing.Point(764, 585);
            this.scale_changing_label.Name = "scale_changing_label";
            this.scale_changing_label.Size = new System.Drawing.Size(184, 17);
            this.scale_changing_label.TabIndex = 10;
            this.scale_changing_label.Text = "Масштаб изображения:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.workSpace);
            this.panel2.Location = new System.Drawing.Point(48, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 508);
            this.panel2.TabIndex = 14;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.Tag = "toolTip";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Информация";
            // 
            // Eraser_button
            // 
            this.Eraser_button.BackColor = System.Drawing.Color.DimGray;
            this.Eraser_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eraser_button.BackgroundImage")));
            this.Eraser_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Eraser_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eraser_button.FlatAppearance.BorderSize = 0;
            this.Eraser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eraser_button.Location = new System.Drawing.Point(12, 235);
            this.Eraser_button.Name = "Eraser_button";
            this.Eraser_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Eraser_button.Size = new System.Drawing.Size(30, 30);
            this.Eraser_button.TabIndex = 15;
            this.toolTip1.SetToolTip(this.Eraser_button, "Инструмент \"Ластик\". При наведении стирает пиксели изображения, делая их прозрачн" +
        "ыми.");
            this.Eraser_button.UseVisualStyleBackColor = false;
            this.Eraser_button.Click += new System.EventHandler(this.EraserButtonClick);
            // 
            // Color_correction_button
            // 
            this.Color_correction_button.BackColor = System.Drawing.Color.DimGray;
            this.Color_correction_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Color_correction_button.BackgroundImage")));
            this.Color_correction_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Color_correction_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color_correction_button.FlatAppearance.BorderSize = 0;
            this.Color_correction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color_correction_button.Location = new System.Drawing.Point(12, 286);
            this.Color_correction_button.Name = "Color_correction_button";
            this.Color_correction_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Color_correction_button.Size = new System.Drawing.Size(30, 30);
            this.Color_correction_button.TabIndex = 20;
            this.toolTip1.SetToolTip(this.Color_correction_button, "Инструмент \"Цветокоррекция\". Позволяет изменять яркость и насыщенность выбранного" +
        " слоя.");
            this.Color_correction_button.UseVisualStyleBackColor = false;
            this.Color_correction_button.Click += new System.EventHandler(this.ClickColorCorrectionButton);
            // 
            // Color_balance_button
            // 
            this.Color_balance_button.BackColor = System.Drawing.Color.DimGray;
            this.Color_balance_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Color_balance_button.BackgroundImage")));
            this.Color_balance_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Color_balance_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color_balance_button.FlatAppearance.BorderSize = 0;
            this.Color_balance_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color_balance_button.Location = new System.Drawing.Point(12, 322);
            this.Color_balance_button.Name = "Color_balance_button";
            this.Color_balance_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Color_balance_button.Size = new System.Drawing.Size(30, 30);
            this.Color_balance_button.TabIndex = 21;
            this.toolTip1.SetToolTip(this.Color_balance_button, "Инструмент \"Цветовой баланс\".");
            this.Color_balance_button.UseVisualStyleBackColor = false;
            this.Color_balance_button.Click += new System.EventHandler(this.ClickColorBalanceButton);
            // 
            // LayerAddButton
            // 
            this.LayerAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LayerAddButton.BackColor = System.Drawing.Color.DimGray;
            this.LayerAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LayerAddButton.BackgroundImage")));
            this.LayerAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LayerAddButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LayerAddButton.FlatAppearance.BorderSize = 0;
            this.LayerAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerAddButton.Location = new System.Drawing.Point(965, 550);
            this.LayerAddButton.Name = "LayerAddButton";
            this.LayerAddButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LayerAddButton.Size = new System.Drawing.Size(20, 16);
            this.LayerAddButton.TabIndex = 23;
            this.toolTip1.SetToolTip(this.LayerAddButton, "Создать новый слой");
            this.LayerAddButton.UseVisualStyleBackColor = false;
            this.LayerAddButton.Click += new System.EventHandler(this.ClickAddLayerButton);
            // 
            // LayerDeleteButton
            // 
            this.LayerDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LayerDeleteButton.BackColor = System.Drawing.Color.DimGray;
            this.LayerDeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LayerDeleteButton.BackgroundImage")));
            this.LayerDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LayerDeleteButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LayerDeleteButton.FlatAppearance.BorderSize = 0;
            this.LayerDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerDeleteButton.Location = new System.Drawing.Point(990, 550);
            this.LayerDeleteButton.Name = "LayerDeleteButton";
            this.LayerDeleteButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LayerDeleteButton.Size = new System.Drawing.Size(17, 16);
            this.LayerDeleteButton.TabIndex = 24;
            this.toolTip1.SetToolTip(this.LayerDeleteButton, "Удалить выбранный слой");
            this.LayerDeleteButton.UseVisualStyleBackColor = false;
            this.LayerDeleteButton.Click += new System.EventHandler(this.ClickLayerDeleteButton);
            // 
            // LayerDownButton
            // 
            this.LayerDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LayerDownButton.BackColor = System.Drawing.Color.DimGray;
            this.LayerDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LayerDownButton.BackgroundImage")));
            this.LayerDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LayerDownButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LayerDownButton.FlatAppearance.BorderSize = 0;
            this.LayerDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerDownButton.Location = new System.Drawing.Point(922, 550);
            this.LayerDownButton.Name = "LayerDownButton";
            this.LayerDownButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LayerDownButton.Size = new System.Drawing.Size(20, 16);
            this.LayerDownButton.TabIndex = 25;
            this.toolTip1.SetToolTip(this.LayerDownButton, "Переместить слой ниже");
            this.LayerDownButton.UseVisualStyleBackColor = false;
            this.LayerDownButton.Click += new System.EventHandler(this.ClickLayerButtonDown);
            // 
            // LayerUpButton
            // 
            this.LayerUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LayerUpButton.BackColor = System.Drawing.Color.DimGray;
            this.LayerUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LayerUpButton.BackgroundImage")));
            this.LayerUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LayerUpButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LayerUpButton.FlatAppearance.BorderSize = 0;
            this.LayerUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerUpButton.Location = new System.Drawing.Point(896, 550);
            this.LayerUpButton.Name = "LayerUpButton";
            this.LayerUpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LayerUpButton.Size = new System.Drawing.Size(20, 16);
            this.LayerUpButton.TabIndex = 26;
            this.toolTip1.SetToolTip(this.LayerUpButton, "Переместить слой выше");
            this.LayerUpButton.UseVisualStyleBackColor = false;
            this.LayerUpButton.Click += new System.EventHandler(this.ClickLayerButtonUp);
            // 
            // layerPanel
            // 
            this.layerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.layerPanel.AutoScroll = true;
            this.layerPanel.BackColor = System.Drawing.Color.Transparent;
            this.layerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layerPanel.Location = new System.Drawing.Point(755, 317);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Size = new System.Drawing.Size(253, 227);
            this.layerPanel.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1039, 677);
            this.Controls.Add(this.LayerUpButton);
            this.Controls.Add(this.LayerDownButton);
            this.Controls.Add(this.LayerDeleteButton);
            this.Controls.Add(this.LayerAddButton);
            this.Controls.Add(this.scale_changing_label);
            this.Controls.Add(this.Color_balance_button);
            this.Controls.Add(this.Color_correction_button);
            this.Controls.Add(this.Eraser_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.Prop_panel);
            this.Controls.Add(this.Apply_button);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.pipette);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.moving_instr);
            this.Controls.Add(this.create_area);
            this.Controls.Add(this.cropping);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.layerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1050, 720);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Graphics Editor";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.workSpace)).EndInit();
            this.contextPicBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).EndInit();
            this.Prop_panel.ResumeLayout(false);
            this.Prop_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button cropping;
        private System.Windows.Forms.Button create_area;
        private System.Windows.Forms.Button moving_instr;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.Button pipette;
        private System.Windows.Forms.Button Apply_button;
        private System.Windows.Forms.PictureBox workSpace;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветокоррекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_from_file;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переместитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПрямоугольнуюОбластьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обрезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кистьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ластикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пипеткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem насыщенностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветовойТонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветовойБалансToolStripMenuItem;
        private System.Windows.Forms.TrackBar Scale;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextPicBox;
        private System.Windows.Forms.ToolStripMenuItem скопироватьНаНовыйСлойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьНаНовыйСлойToolStripMenuItem;
        private System.Windows.Forms.Panel Prop_panel;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HeightUpDown;
        private System.Windows.Forms.Label scale_changing_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label current_color_label;
        private System.Windows.Forms.NumericUpDown opacity_UpDown;
        private System.Windows.Forms.Label brush_width_label;
        private System.Windows.Forms.Label Brush_label;
        private System.Windows.Forms.Button colorButtonChoose;
        private System.Windows.Forms.ColorDialog colorChoose;
        private System.Windows.Forms.Button Eraser_button;
        private System.Windows.Forms.Button Color_correction_button;
        private System.Windows.Forms.Button Color_balance_button;
        private System.Windows.Forms.Panel layerPanel;
        private System.Windows.Forms.Button LayerAddButton;
        private System.Windows.Forms.Button LayerDeleteButton;
        private System.Windows.Forms.Button LayerDownButton;
        private System.Windows.Forms.Button LayerUpButton;
        private System.Windows.Forms.NumericUpDown TransparencyUpDown;
        private System.Windows.Forms.Label TransparencyLabel;
    }
}

