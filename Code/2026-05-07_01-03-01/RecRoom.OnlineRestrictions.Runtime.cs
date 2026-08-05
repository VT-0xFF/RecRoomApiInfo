using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TMRYTQGXOHE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9C18EE0", Offset = "0x9C178E0", VA = "0x189C18EE0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
	public TMRYTQGXOHE()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_OnlineRestrictions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9C19C20", Offset = "0x9C18620", VA = "0x189C19C20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : LWCSZZPQTXV
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MXADJLHPKKM<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<DSRLWIHHTBI, a> XRWGOVHXGBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a XHLSMLWWHCX;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public MXADJLHPKKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F932D0", Offset = "0x6F91CD0", VA = "0x186F932D0")]
			internal bool NIPPUNBUOFE(DSRLWIHHTBI a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XKMSFCDUWSV<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> KOVRIKTEMVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<DSRLWIHHTBI, a> XRWGOVHXGBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a XHLSMLWWHCX;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public XKMSFCDUWSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5076410", Offset = "0x5074E10", VA = "0x185076410")]
			internal bool VEBVCRZKTNZ(DSRLWIHHTBI a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<DSRLWIHHTBI> KKMNGIZFEHI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<DSRLWIHHTBI> GUBMDYZSYCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C18780", Offset = "0x9C17180", VA = "0x189C18780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C18420", Offset = "0x9C16E20", VA = "0x189C18420")]
		[ONTQUCAGRJW.Root.GameOnly]
		internal static void YITSWWEJPVO(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C16830", Offset = "0x9C15230", VA = "0x189C16830")]
		private bool DUXBTYGSUFE(Func<DSRLWIHHTBI, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C17120", Offset = "0x9C15B20", VA = "0x189C17120")]
		private bool NXNSOQHIBTZ(Func<DSRLWIHHTBI, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D62670", Offset = "0x3D61070", VA = "0x183D62670")]
		private bool BCWCJOZRLSY<a>(a a, Func<DSRLWIHHTBI, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D629D0", Offset = "0x3D613D0", VA = "0x183D629D0")]
		private bool RNMPGHUYCMX<b>(b a, Func<DSRLWIHHTBI, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C16210", Offset = "0x9C14C10", VA = "0x189C16210", Slot = "4")]
		public bool BBKLWMEDLSB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C18C90", Offset = "0x9C17690", VA = "0x189C18C90", Slot = "5")]
		public bool ZUTOKEOINAI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C173E0", Offset = "0x9C15DE0", VA = "0x189C173E0", Slot = "6")]
		public bool ORLRJHORXFE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C16330", Offset = "0x9C14D30", VA = "0x189C16330", Slot = "7")]
		public bool BCINBKOHQUS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C17E50", Offset = "0x9C16850", VA = "0x189C17E50", Slot = "8")]
		public bool WATTFQRUMYU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C16630", Offset = "0x9C15030", VA = "0x189C16630", Slot = "9")]
		public bool DPDXZWBFSUR(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C160F0", Offset = "0x9C14AF0", VA = "0x189C160F0", Slot = "10")]
		public bool BBFQOWJRNEK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C17C10", Offset = "0x9C16610", VA = "0x189C17C10", Slot = "11")]
		public bool UVWZJNNBPID([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C181D0", Offset = "0x9C16BD0", VA = "0x189C181D0", Slot = "12")]
		public bool XFZRFNCPQSO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C17D30", Offset = "0x9C16730", VA = "0x189C17D30", Slot = "13")]
		public bool UWTKYWJFGVV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C18660", Offset = "0x9C17060", VA = "0x189C18660", Slot = "14")]
		public bool YPQHJTOVGCN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C17630", Offset = "0x9C16030", VA = "0x189C17630", Slot = "15")]
		public bool QRNBQGGHFAI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C15EA0", Offset = "0x9C148A0", VA = "0x189C15EA0", Slot = "16")]
		public bool ARSAWDAHUOO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C16FF0", Offset = "0x9C159F0", VA = "0x189C16FF0", Slot = "17")]
		public bool NCMOXLHXCPF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C17F70", Offset = "0x9C16970", VA = "0x189C17F70", Slot = "18")]
		public bool WCSDGRDAOCS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C17750", Offset = "0x9C16150", VA = "0x189C17750", Slot = "19")]
		public bool QRUDYAUVAFQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C16EA0", Offset = "0x9C158A0", VA = "0x189C16EA0", Slot = "20")]
		public bool JBHZPOXETOL(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C16D50", Offset = "0x9C15750", VA = "0x189C16D50", Slot = "21")]
		public bool IFUGIMHYGMO(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C16AF0", Offset = "0x9C154F0", VA = "0x189C16AF0", Slot = "22")]
		public bool HAKIOFGCTEV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C18DB0", Offset = "0x9C177B0", VA = "0x189C18DB0", Slot = "23")]
		public bool ZYBRHRMXXBL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C18A30", Offset = "0x9C17430", VA = "0x189C18A30", Slot = "24")]
		public bool ZCFZWADLTFG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C17500", Offset = "0x9C15F00", VA = "0x189C17500", Slot = "25")]
		public bool PAKLXIPIGRO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C182F0", Offset = "0x9C16CF0", VA = "0x189C182F0", Slot = "26")]
		public bool XJOIKCHMFCN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C17AE0", Offset = "0x9C164E0", VA = "0x189C17AE0", Slot = "27")]
		public bool TTICXESCFGF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9C15D50", Offset = "0x9C14750", VA = "0x189C15D50", Slot = "28")]
		public bool APGODWXHZLW(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C16500", Offset = "0x9C14F00", VA = "0x189C16500", Slot = "29")]
		public bool BWPIBHESLGE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C169C0", Offset = "0x9C153C0", VA = "0x189C169C0", Slot = "30")]
		public bool GEAWWGHQWVN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C18B60", Offset = "0x9C17560", VA = "0x189C18B60", Slot = "31")]
		public bool ZMAEFIZKPLV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C179B0", Offset = "0x9C163B0", VA = "0x189C179B0", Slot = "32")]
		public bool TBUEIPJKDEE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C18510", Offset = "0x9C16F10", VA = "0x189C18510", Slot = "33")]
		public bool YOEIOFOSPHY(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C15FC0", Offset = "0x9C149C0", VA = "0x189C15FC0", Slot = "34")]
		public bool BAXKRVAWQHN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C180A0", Offset = "0x9C16AA0", VA = "0x189C180A0", Slot = "35")]
		public bool WXHEJBHXQYX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C17880", Offset = "0x9C16280", VA = "0x189C17880", Slot = "36")]
		public bool RCZIPOIUIXO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C16C20", Offset = "0x9C15620", VA = "0x189C16C20", Slot = "37")]
		public bool HKAXRZCYGNZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C172B0", Offset = "0x9C15CB0", VA = "0x189C172B0", Slot = "38")]
		public bool ODMVHXODIGO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C16450", Offset = "0x9C14E50", VA = "0x189C16450", Slot = "39")]
		public string BMEWEWHUWUC(OnlineRestrictionsSources a)
		{
			return null;
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
