﻿using System;
using System.ComponentModel;

namespace SistemasTarefas.Enums
{
	public enum StatusTasks
	{
		[Description("A fazer")]
		AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3,
	}
}

