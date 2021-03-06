﻿namespace EngeniousUI.Controls
{
    /// <summary>
    /// Ein einfacher Container für Steuerelemente
    /// </summary>
    public class Panel : ContainerControl
    {
        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Panel
        /// </summary>
        /// <param name="manager">Der verwendete <see cref="BaseScreenComponent"/></param>
        public Panel(BaseScreenComponent manager) : base(manager)
        {
            ApplySkin(typeof(Panel));
        }
    }
}
