﻿using System.Globalization;
using System.Windows.Forms;

namespace ICSharpCode.TextEditor
{
    public partial class GotoForm : Form
    {
        private int _firstLineNumber;
        public int FirstLineNumber
        {
            get { return _firstLineNumber; }
            set
            {
                _firstLineNumber = value;
                UpdateLineNumberLabel();
            }
        }

        private int _lastLineNumber;
        public int LastLineNumber
        {
            get { return _lastLineNumber; }
            set
            {
                _lastLineNumber = value;
                UpdateLineNumberLabel();
            }
        }

        public int SelectedLineNumber
        {
            get
            {
                return int.Parse(txtLineNumber.Text);
            }

            set
            {
                txtLineNumber.Text = value.ToString(CultureInfo.InvariantCulture);
            }
        }

        public GotoForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx()
        {
            txtLineNumber.Min = _firstLineNumber;
            txtLineNumber.Max = _lastLineNumber;

            return ShowDialog();
        }

        private void UpdateLineNumberLabel()
        {
            lblLineNumber.Text = string.Format("Line number ({0} - {1}):", _firstLineNumber, _lastLineNumber);
        }
    }
}