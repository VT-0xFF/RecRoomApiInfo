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
internal class DZISONAGUEP
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
	[Cpp2IlInjected.Address(RVA = "0x8E22240", Offset = "0x8E20E40", VA = "0x188E22240")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
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
		[Cpp2IlInjected.Address(RVA = "0x8E26110", Offset = "0x8E24D10", VA = "0x188E26110", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : EJOQRXHTGDS
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class QGNULOAGNVP<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<SMJMQHRNBQB, a> ZEYHLRYXPDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a UPVGGEVLAIE;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QGNULOAGNVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x62176D0", Offset = "0x62162D0", VA = "0x1862176D0")]
			internal bool GZIUPYQUAEN(SMJMQHRNBQB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DZJZXVJRVIA<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> CTYPFAOGYTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<SMJMQHRNBQB, a> ZEYHLRYXPDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a UPVGGEVLAIE;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public DZJZXVJRVIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x468C990", Offset = "0x468B590", VA = "0x18468C990")]
			internal bool TFDJQWLQJMQ(SMJMQHRNBQB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<SMJMQHRNBQB> UJVYXQVRGCJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<SMJMQHRNBQB> IXIHRWDJONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8E240E0", Offset = "0x8E22CE0", VA = "0x188E240E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E24590", Offset = "0x8E23190", VA = "0x188E24590")]
		[IFIZWETSKCB.Root.GameOnly]
		internal static void QPCYIHMTSNL(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E23BD0", Offset = "0x8E227D0", VA = "0x188E23BD0")]
		private bool MANCURYUJTN(Func<SMJMQHRNBQB, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E24BE0", Offset = "0x8E237E0", VA = "0x188E24BE0")]
		private bool TCPELMCCXFA(Func<SMJMQHRNBQB, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AF10", Offset = "0x3E09B10", VA = "0x183E0AF10")]
		private bool OYFMWSYJLWL<a>(a a, Func<SMJMQHRNBQB, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AC60", Offset = "0x3E09860", VA = "0x183E0AC60")]
		private bool EDXNJOARYCU<b>(b a, Func<SMJMQHRNBQB, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8E23390", Offset = "0x8E21F90", VA = "0x188E23390", Slot = "4")]
		public bool HQSOPKRQXVE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8E22DC0", Offset = "0x8E219C0", VA = "0x188E22DC0", Slot = "5")]
		public bool EETIRROUVAB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8E22B70", Offset = "0x8E21770", VA = "0x188E22B70", Slot = "6")]
		public bool DYOZKCWCXYN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8E226D0", Offset = "0x8E212D0", VA = "0x188E226D0", Slot = "7")]
		public bool BYHHWCSNYMF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8E23D60", Offset = "0x8E22960", VA = "0x188E23D60", Slot = "8")]
		public bool MHNVHDKSCZT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E24390", Offset = "0x8E22F90", VA = "0x188E24390", Slot = "9")]
		public bool QLYKAPTWEHI(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E24FF0", Offset = "0x8E23BF0", VA = "0x188E24FF0", Slot = "10")]
		public bool WXSBOJNXNRB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8E23010", Offset = "0x8E21C10", VA = "0x188E23010", Slot = "11")]
		public bool FOCXSNGVOQS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8E24680", Offset = "0x8E23280", VA = "0x188E24680", Slot = "12")]
		public bool QTNZENCSAAN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E25240", Offset = "0x8E23E40", VA = "0x188E25240", Slot = "13")]
		public bool YDRTKMBMBRE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E23830", Offset = "0x8E22430", VA = "0x188E23830", Slot = "14")]
		public bool JOASMMWNQCI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E235E0", Offset = "0x8E221E0", VA = "0x188E235E0", Slot = "15")]
		public bool IVTGYRQQPMD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E227F0", Offset = "0x8E213F0", VA = "0x188E227F0", Slot = "16")]
		public bool CKMMCWWVENN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E22450", Offset = "0x8E21050", VA = "0x188E22450", Slot = "17")]
		public bool ANRURAQQJWE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E23700", Offset = "0x8E22300", VA = "0x188E23700", Slot = "18")]
		public bool JJJVKRIMWFZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8E23E80", Offset = "0x8E22A80", VA = "0x188E23E80", Slot = "19")]
		public bool NPDRWXNIZKF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8E22580", Offset = "0x8E21180", VA = "0x188E22580", Slot = "20")]
		public bool BARLVAUFAWI(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E25360", Offset = "0x8E23F60", VA = "0x188E25360", Slot = "21")]
		public bool ZVOMWCVEJLR(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E22C90", Offset = "0x8E21890", VA = "0x188E22C90", Slot = "22")]
		public bool EASNHPEVCCI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8E234B0", Offset = "0x8E220B0", VA = "0x188E234B0", Slot = "23")]
		public bool IIOBZNTPKJK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E23FB0", Offset = "0x8E22BB0", VA = "0x188E23FB0", Slot = "24")]
		public bool NPRNOEFGHCJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E24EC0", Offset = "0x8E23AC0", VA = "0x188E24EC0", Slot = "25")]
		public bool TSEFENKPGRJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E23260", Offset = "0x8E21E60", VA = "0x188E23260", Slot = "26")]
		public bool HODGKQVTNBI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E24AB0", Offset = "0x8E236B0", VA = "0x188E24AB0", Slot = "27")]
		public bool SKUZTGVIIVY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E23950", Offset = "0x8E22550", VA = "0x188E23950", Slot = "28")]
		public bool KMHJKYOOGEL(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8E22A40", Offset = "0x8E21640", VA = "0x188E22A40", Slot = "29")]
		public bool DUZOIHTYYSN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E23AA0", Offset = "0x8E226A0", VA = "0x188E23AA0", Slot = "30")]
		public bool LVFCHOBXAMW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E247A0", Offset = "0x8E233A0", VA = "0x188E247A0", Slot = "31")]
		public bool RTKICPHHCIE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8E22EE0", Offset = "0x8E21AE0", VA = "0x188E22EE0", Slot = "32")]
		public bool FNEHGFXPBKT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8E24D70", Offset = "0x8E23970", VA = "0x188E24D70", Slot = "33")]
		public bool TMVNVZULQND(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E24980", Offset = "0x8E23580", VA = "0x188E24980", Slot = "34")]
		public bool SBKAVRTEWCU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E22910", Offset = "0x8E21510", VA = "0x188E22910", Slot = "35")]
		public bool COAGSETGRLO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E25110", Offset = "0x8E23D10", VA = "0x188E25110", Slot = "36")]
		public bool XKJYCXPLFFN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E22320", Offset = "0x8E20F20", VA = "0x188E22320", Slot = "37")]
		public bool AIKRPUMHHRE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E23130", Offset = "0x8E21D30", VA = "0x188E23130", Slot = "38")]
		public bool GHWWWVVDTWB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E248D0", Offset = "0x8E234D0", VA = "0x188E248D0", Slot = "39")]
		public string RTTHTZMJGTT(OnlineRestrictionsSources a)
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
