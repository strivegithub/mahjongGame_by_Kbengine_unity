/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Account.def
	public class EntityBaseEntityCall_AccountBase : EntityCall
	{

		public EntityBaseEntityCall_AccountBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

		public void baseCallTest()
		{
			Bundle pBundle = newCall("baseCallTest", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}

	public class EntityCellEntityCall_AccountBase : EntityCall
	{

		public EntityCellEntityCall_AccountBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

	}
	}
