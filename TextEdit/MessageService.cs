﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEdit
{
    public interface IMessageService
    {
        void ShowMessage(string massage);
        void ShowExclamation(string exclamation);
        void ShowError(string error);
    }
    public class MessageService:IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
