namespace LogParser
{
    partial class BeginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridViewLog = new System.Windows.Forms.DataGridView();
            this._watch = new System.IO.FileSystemWatcher();
            this.TimerAnimation = new System.Windows.Forms.Timer(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Azimut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satellite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ignition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rouming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExternalPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InternalPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._watch)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewLog
            // 
            this.DataGridViewLog.AllowUserToAddRows = false;
            this.DataGridViewLog.AllowUserToDeleteRows = false;
            this.DataGridViewLog.AllowUserToOrderColumns = true;
            this.DataGridViewLog.AllowUserToResizeRows = false;
            this.DataGridViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Coords,
            this.Speed,
            this.Azimut,
            this.hos,
            this.Satellite,
            this.Action,
            this.Ignition,
            this.Rouming,
            this.ExternalPower,
            this.InternalPower,
            this.KM,
            this.SLG});
            this.DataGridViewLog.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewLog.Name = "DataGridViewLog";
            this.DataGridViewLog.RowHeadersVisible = false;
            this.DataGridViewLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLog.Size = new System.Drawing.Size(1505, 442);
            this.DataGridViewLog.TabIndex = 0;
            // 
            // _watch
            // 
            this._watch.EnableRaisingEvents = true;
            this._watch.SynchronizingObject = this;
            this._watch.Changed += new System.IO.FileSystemEventHandler(this._watch_Changed);
            // 
            // TimerAnimation
            // 
            this.TimerAnimation.Interval = 10;
            this.TimerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 140;
            // 
            // Coords
            // 
            this.Coords.Frozen = true;
            this.Coords.HeaderText = "Координаты";
            this.Coords.Name = "Coords";
            this.Coords.ReadOnly = true;
            this.Coords.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Coords.Width = 140;
            // 
            // Speed
            // 
            this.Speed.Frozen = true;
            this.Speed.HeaderText = "Скорость";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Azimut
            // 
            this.Azimut.Frozen = true;
            this.Azimut.HeaderText = "Азимут";
            this.Azimut.Name = "Azimut";
            this.Azimut.ReadOnly = true;
            this.Azimut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hos
            // 
            this.hos.Frozen = true;
            this.hos.HeaderText = "ВНУМ";
            this.hos.Name = "hos";
            this.hos.ReadOnly = true;
            this.hos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Satellite
            // 
            this.Satellite.Frozen = true;
            this.Satellite.HeaderText = "Спутники";
            this.Satellite.Name = "Satellite";
            this.Satellite.ReadOnly = true;
            this.Satellite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Action
            // 
            this.Action.Frozen = true;
            this.Action.HeaderText = "Действие";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ignition
            // 
            this.Ignition.Frozen = true;
            this.Ignition.HeaderText = "Зажигание";
            this.Ignition.Name = "Ignition";
            this.Ignition.ReadOnly = true;
            this.Ignition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Rouming
            // 
            this.Rouming.Frozen = true;
            this.Rouming.HeaderText = "Роуминг";
            this.Rouming.Name = "Rouming";
            this.Rouming.ReadOnly = true;
            this.Rouming.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExternalPower
            // 
            this.ExternalPower.Frozen = true;
            this.ExternalPower.HeaderText = "Внешнее питание";
            this.ExternalPower.Name = "ExternalPower";
            this.ExternalPower.ReadOnly = true;
            // 
            // InternalPower
            // 
            this.InternalPower.Frozen = true;
            this.InternalPower.HeaderText = "Внутреннее питание";
            this.InternalPower.Name = "InternalPower";
            this.InternalPower.ReadOnly = true;
            this.InternalPower.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KM
            // 
            this.KM.Frozen = true;
            this.KM.HeaderText = "Километраж";
            this.KM.Name = "KM";
            this.KM.ReadOnly = true;
            this.KM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SLG
            // 
            this.SLG.HeaderText = "ДУТ";
            this.SLG.Name = "SLG";
            this.SLG.ReadOnly = true;
            this.SLG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 466);
            this.Controls.Add(this.DataGridViewLog);
            this.Name = "BeginForm";
            this.Text = "LogParser";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._watch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewLog;
        private System.IO.FileSystemWatcher _watch;
        private System.Windows.Forms.Timer TimerAnimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Azimut;
        private System.Windows.Forms.DataGridViewTextBoxColumn hos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satellite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ignition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rouming;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExternalPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn InternalPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLG;

    }
}

