//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_BD_PushMessageConfig
    {
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the userid.
        /// </summary>
        /// <value>
        /// The userid.
        /// </value>
        public Nullable<int> Userid { get; set; }
        /// <summary>
        /// Gets or sets the type of the MSG.
        /// </summary>
        /// <value>
        /// The type of the MSG.
        /// </value>
        public int MsgType { get; set; }
        /// <summary>
        /// Gets or sets the update time.
        /// </summary>
        /// <value>
        /// The update time.
        /// </value>
        public System.DateTime UpdateTime { get; set; }
        /// <summary>
        /// Updator
        /// </summary>
        public Nullable<int> Updator { get; set; }
    

    }
}
