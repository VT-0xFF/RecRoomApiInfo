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
internal class TSDLEFRRTSA
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
	[Cpp2IlInjected.Address(RVA = "0x85DB970", Offset = "0x85DAD70", VA = "0x1885DB970")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
	public TSDLEFRRTSA()
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
		[Cpp2IlInjected.Address(RVA = "0x85DC6B0", Offset = "0x85DBAB0", VA = "0x1885DC6B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : KDQLNOARXAF
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class UCTLHNLLFRY<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<RTFIJBQWSOM, a> KIUCYJYYKFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a OUHOTGSOHNP;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public UCTLHNLLFRY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x60EE450", Offset = "0x60ED850", VA = "0x1860EE450")]
			internal bool PAQNIVVJMAA(RTFIJBQWSOM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FHLQZJRXIBB<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> UJSUFBXVMHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<RTFIJBQWSOM, a> KIUCYJYYKFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a OUHOTGSOHNP;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public FHLQZJRXIBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4D5F4D0", Offset = "0x4D5E8D0", VA = "0x184D5F4D0")]
			internal bool JHIWNDOXATH(RTFIJBQWSOM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<RTFIJBQWSOM> LZCDKGRRLGU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<RTFIJBQWSOM> MTSMVKHGVTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x85D8B50", Offset = "0x85D7F50", VA = "0x1885D8B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85D97D0", Offset = "0x85D8BD0", VA = "0x1885D97D0")]
		[JKCTBFVRGVY.Root.GameOnly]
		internal static void GYUZIXOGRLY(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85DA270", Offset = "0x85D9670", VA = "0x1885DA270")]
		private bool KKDKOVLIJDG(Func<RTFIJBQWSOM, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85DA650", Offset = "0x85D9A50", VA = "0x1885DA650")]
		private bool KPNZWEACBCR(Func<RTFIJBQWSOM, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x38BA140", Offset = "0x38B9540", VA = "0x1838BA140")]
		private bool WTTSEBIMLXY<a>(a a, Func<RTFIJBQWSOM, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x38B9E90", Offset = "0x38B9290", VA = "0x1838B9E90")]
		private bool OWTGETHXHJX<b>(b a, Func<RTFIJBQWSOM, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85DA9B0", Offset = "0x85D9DB0", VA = "0x1885DA9B0", Slot = "4")]
		public bool LKTZLIXLHEL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85DA540", Offset = "0x85D9940", VA = "0x1885DA540", Slot = "5")]
		public bool KKVOWCJPYCS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85DB510", Offset = "0x85DA910", VA = "0x1885DB510", Slot = "6")]
		public bool XGTMGFOCJDG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85D9120", Offset = "0x85D8520", VA = "0x1885D9120", Slot = "7")]
		public bool EPDNIISEOXG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85D96C0", Offset = "0x85D8AC0", VA = "0x1885D96C0", Slot = "8")]
		public bool GIFJXMIJMFY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85D9AF0", Offset = "0x85D8EF0", VA = "0x1885D9AF0", Slot = "9")]
		public bool IUYHCNKZRUL(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85D9370", Offset = "0x85D8770", VA = "0x1885D9370", Slot = "10")]
		public bool FNZWUFHXGWA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85D9010", Offset = "0x85D8410", VA = "0x1885D9010", Slot = "11")]
		public bool EOTIFDYWQGB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85D99E0", Offset = "0x85D8DE0", VA = "0x1885D99E0", Slot = "12")]
		public bool IAPEQXYDJZS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85DB860", Offset = "0x85DAC60", VA = "0x1885DB860", Slot = "13")]
		public bool ZNYPNIYUBGF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85D8DE0", Offset = "0x85D81E0", VA = "0x1885D8DE0", Slot = "14")]
		public bool CQUMEYVFJAX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85DABE0", Offset = "0x85D9FE0", VA = "0x1885DABE0", Slot = "15")]
		public bool PCKJWTNWUCW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85DA030", Offset = "0x85D9430", VA = "0x1885DA030", Slot = "16")]
		public bool JTUBKXDYLQM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85DB090", Offset = "0x85DA490", VA = "0x1885DB090", Slot = "17")]
		public bool UPHAQSBYCCJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85D9CD0", Offset = "0x85D90D0", VA = "0x1885D9CD0", Slot = "18")]
		public bool JDSASWLQJIM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85DA150", Offset = "0x85D9550", VA = "0x1885DA150", Slot = "19")]
		public bool KAYJXOAVEOY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85DA400", Offset = "0x85D9800", VA = "0x1885DA400", Slot = "20")]
		public bool KKQDHVMUBGR(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85DAF50", Offset = "0x85DA350", VA = "0x1885DAF50", Slot = "21")]
		public bool UNMSGNJPZLO(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85D9F10", Offset = "0x85D9310", VA = "0x1885D9F10", Slot = "22")]
		public bool JLTJOLDUSXJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85D9480", Offset = "0x85D8880", VA = "0x1885D9480", Slot = "23")]
		public bool FOECCDPYWLZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85DB3F0", Offset = "0x85DA7F0", VA = "0x1885DB3F0", Slot = "24")]
		public bool WRNXUUDYJBY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85DA890", Offset = "0x85D9C90", VA = "0x1885DA890", Slot = "25")]
		public bool KZEMAAQYDRQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85DB740", Offset = "0x85DAB40", VA = "0x1885DB740", Slot = "26")]
		public bool YPPFHBHLYVV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85DB2D0", Offset = "0x85DA6D0", VA = "0x1885DB2D0", Slot = "27")]
		public bool WDBEBDNBPJR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85DAE10", Offset = "0x85DA210", VA = "0x1885DAE10", Slot = "28")]
		public bool SMLNCSFVPJI(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85DB620", Offset = "0x85DAA20", VA = "0x1885DB620", Slot = "29")]
		public bool YAXDTIZTKBI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85D8EF0", Offset = "0x85D82F0", VA = "0x1885D8EF0", Slot = "30")]
		public bool DRKETXLUBTH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85D9DF0", Offset = "0x85D91F0", VA = "0x1885D9DF0", Slot = "31")]
		public bool JGFNAMZLREZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85DB1B0", Offset = "0x85DA5B0", VA = "0x1885DB1B0", Slot = "32")]
		public bool VEURLAZWUTE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85D9230", Offset = "0x85D8630", VA = "0x1885D9230", Slot = "33")]
		public bool EPFECMSDWYI(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85D8A30", Offset = "0x85D7E30", VA = "0x1885D8A30", Slot = "34")]
		public bool AKQGYSNZFCF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85D95A0", Offset = "0x85D89A0", VA = "0x1885D95A0", Slot = "35")]
		public bool GGPQRHEUPKN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85D98C0", Offset = "0x85D8CC0", VA = "0x1885D98C0", Slot = "36")]
		public bool HJKSWWDENPM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85DAAC0", Offset = "0x85D9EC0", VA = "0x1885DAAC0", Slot = "37")]
		public bool NEQFAVXFKGF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85DACF0", Offset = "0x85DA0F0", VA = "0x1885DACF0", Slot = "38")]
		public bool SGJEUQZQBSE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85DA7E0", Offset = "0x85D9BE0", VA = "0x1885DA7E0", Slot = "39")]
		public string KPRJRPACZWY(OnlineRestrictionsSources a)
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
