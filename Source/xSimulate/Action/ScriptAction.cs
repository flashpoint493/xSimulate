﻿using xSimulate.Configuration;

namespace xSimulate.Action
{
    public class ScriptAction : ActionBase
    {
        public ScriptAction(AutomationAction automationActionData)
            : base(automationActionData)
        {
            this.ScriptContent = GetAttributeValue<string>("script");
        }

        public override ActionType ActionType
        {
            get { return ActionType.ScriptAction; }
        }

        public string ScriptContent { get; set; }
    }
}