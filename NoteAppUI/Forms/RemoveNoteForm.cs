using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI.Forms
{
	public partial class RemoveNoteForm : Form
	{
		public RemoveNoteForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Возвращает и задает заметку.
		/// </summary>
		public Note Note { get; set; }

		/// <summary>
		/// Обновляет сообщение об удалении заметки.
		/// </summary>
		public void UpdateInfo()
		{
			RemoveLabel.Text = $"Do you really want to remove this note: {Note.Title}?";
		}

		private void AcceptRemovingButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelRemovingButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
