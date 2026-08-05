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
internal class ODSEWVGQSIN
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
	[Cpp2IlInjected.Address(RVA = "0x86C49A0", Offset = "0x86C31A0", VA = "0x1886C49A0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
	public ODSEWVGQSIN()
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
		[Cpp2IlInjected.Address(RVA = "0x86C8620", Offset = "0x86C6E20", VA = "0x1886C8620", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : NOWXTHPZPLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class UQBYSOARQED<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<LAXFXHTLWBV, a> PJYYBWCUEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a KFCEXCIBGDU;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public UQBYSOARQED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x61A48B0", Offset = "0x61A30B0", VA = "0x1861A48B0")]
			internal bool QQMAYDKPVDF(LAXFXHTLWBV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class SMJDMPUPIPA<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> GEUNURJBVJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<LAXFXHTLWBV, a> PJYYBWCUEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a KFCEXCIBGDU;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public SMJDMPUPIPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8960", Offset = "0x5EA7160", VA = "0x185EA8960")]
			internal bool PYAHYVLBAVA(LAXFXHTLWBV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<LAXFXHTLWBV> AYSPSHCFLAX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<LAXFXHTLWBV> QRAMDUWSVNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x86C6800", Offset = "0x86C5000", VA = "0x1886C6800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86C5790", Offset = "0x86C3F90", VA = "0x1886C5790")]
		[SLGIUIECCXF.Root.GameOnly]
		internal static void FQVHXEQTTOD(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86C6180", Offset = "0x86C4980", VA = "0x1886C6180")]
		private bool MQQBOPQSAAZ(Func<LAXFXHTLWBV, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86C6670", Offset = "0x86C4E70", VA = "0x1886C6670")]
		private bool QLMRFYECUYM(Func<LAXFXHTLWBV, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x38EA4A0", Offset = "0x38E8CA0", VA = "0x1838EA4A0")]
		private bool TRRMJBGFDHL<a>(a a, Func<LAXFXHTLWBV, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x38EA800", Offset = "0x38E9000", VA = "0x1838EA800")]
		private bool ZVEZKSFJXFQ<b>(b a, Func<LAXFXHTLWBV, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4D80", Offset = "0x86C3580", VA = "0x1886C4D80", Slot = "4")]
		public bool BTMRMKBYTVS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86C6CD0", Offset = "0x86C54D0", VA = "0x1886C6CD0", Slot = "5")]
		public bool SWPGHYNQTQL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86C5F60", Offset = "0x86C4760", VA = "0x1886C5F60", Slot = "6")]
		public bool KSBMTCPHFBB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86C50F0", Offset = "0x86C38F0", VA = "0x1886C50F0", Slot = "7")]
		public bool CDYGERBCOYX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86C70E0", Offset = "0x86C58E0", VA = "0x1886C70E0", Slot = "8")]
		public bool UXQKUKKHWVR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86C4A80", Offset = "0x86C3280", VA = "0x1886C4A80", Slot = "9")]
		public bool APIZHQWBWNC(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86C5880", Offset = "0x86C4080", VA = "0x1886C5880", Slot = "10")]
		public bool HDFCPVBJEZL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D30", Offset = "0x86C4530", VA = "0x1886C5D30", Slot = "11")]
		public bool KFENJNAHMQA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86C71F0", Offset = "0x86C59F0", VA = "0x1886C71F0", Slot = "12")]
		public bool VIHJXTTKDNV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86C6FD0", Offset = "0x86C57D0", VA = "0x1886C6FD0", Slot = "13")]
		public bool UMLRACJNFVK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86C5200", Offset = "0x86C3A00", VA = "0x1886C5200", Slot = "14")]
		public bool CTMSULXLVPU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86C6070", Offset = "0x86C4870", VA = "0x1886C6070", Slot = "15")]
		public bool LWOTWVXYOKR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86C5430", Offset = "0x86C3C30", VA = "0x1886C5430", Slot = "16")]
		public bool DTTVLVDVYNT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86C7300", Offset = "0x86C5B00", VA = "0x1886C7300", Slot = "17")]
		public bool VLQJUPCORWW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86C5550", Offset = "0x86C3D50", VA = "0x1886C5550", Slot = "18")]
		public bool FGDFVDVUTZX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86C6550", Offset = "0x86C4D50", VA = "0x1886C6550", Slot = "19")]
		public bool QBGXVRLLQDB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4E90", Offset = "0x86C3690", VA = "0x1886C4E90", Slot = "20")]
		public bool BUEXAYSKSDM(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86C5990", Offset = "0x86C4190", VA = "0x1886C5990", Slot = "21")]
		public bool HYFQTGYTGVT(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86C6430", Offset = "0x86C4C30", VA = "0x1886C6430", Slot = "22")]
		public bool PYQHLZWOYXE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86C7780", Offset = "0x86C5F80", VA = "0x1886C7780", Slot = "23")]
		public bool XMGCJYXMFDY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86C7540", Offset = "0x86C5D40", VA = "0x1886C7540", Slot = "24")]
		public bool WGOUZPFWBZF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86C6310", Offset = "0x86C4B10", VA = "0x1886C6310", Slot = "25")]
		public bool PGFSAYQZIDL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86C7420", Offset = "0x86C5C20", VA = "0x1886C7420", Slot = "26")]
		public bool VXSMPQAUWLS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86C5310", Offset = "0x86C3B10", VA = "0x1886C5310", Slot = "27")]
		public bool DSWTHXELRGE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86C6DE0", Offset = "0x86C55E0", VA = "0x1886C6DE0", Slot = "28")]
		public bool TLCGXKFNJUN(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86C5AD0", Offset = "0x86C42D0", VA = "0x1886C5AD0", Slot = "29")]
		public bool INORNJPOHJB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86C7660", Offset = "0x86C5E60", VA = "0x1886C7660", Slot = "30")]
		public bool XAFPNLUEISE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86C4FD0", Offset = "0x86C37D0", VA = "0x1886C4FD0", Slot = "31")]
		public bool CCVYLXLTWFQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86C6A90", Offset = "0x86C5290", VA = "0x1886C6A90", Slot = "32")]
		public bool SEFSFQNCXXT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86C5BF0", Offset = "0x86C43F0", VA = "0x1886C5BF0", Slot = "33")]
		public bool JKGVPPCWGXV(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86C5E40", Offset = "0x86C4640", VA = "0x1886C5E40", Slot = "34")]
		public bool KFWLRZRLHLY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86C78A0", Offset = "0x86C60A0", VA = "0x1886C78A0", Slot = "35")]
		public bool YFUUSEMQRTU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4C60", Offset = "0x86C3460", VA = "0x1886C4C60", Slot = "36")]
		public bool BETPBZFPHVH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86C5670", Offset = "0x86C3E70", VA = "0x1886C5670", Slot = "37")]
		public bool FQNJNGSCNHW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86C6BB0", Offset = "0x86C53B0", VA = "0x1886C6BB0", Slot = "38")]
		public bool SPYEUBXSXLB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86C6F20", Offset = "0x86C5720", VA = "0x1886C6F20", Slot = "39")]
		public string TNEUQHGSQFN(OnlineRestrictionsSources a)
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
