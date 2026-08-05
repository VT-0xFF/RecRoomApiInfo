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
internal class CWHGVYTHLWE
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
	[Cpp2IlInjected.Address(RVA = "0x9C3CFA0", Offset = "0x9C3B9A0", VA = "0x189C3CFA0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
	public CWHGVYTHLWE()
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
		[Cpp2IlInjected.Address(RVA = "0x9C40E70", Offset = "0x9C3F870", VA = "0x189C40E70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : ARRWXPDNQBT
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class FJZMZBTRXGK<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<IPKHKLYTJOU, a> TFMLWRJTOYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a GESQOZKUAEJ;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public FJZMZBTRXGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x63026F0", Offset = "0x63010F0", VA = "0x1863026F0")]
			internal bool SSBDXAJZHXC(IPKHKLYTJOU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ECHDMADKOMH<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> MTUOKSYITQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<IPKHKLYTJOU, a> TFMLWRJTOYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a GESQOZKUAEJ;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ECHDMADKOMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5B247D0", Offset = "0x5B231D0", VA = "0x185B247D0")]
			internal bool HYKONAKAPWB(IPKHKLYTJOU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<IPKHKLYTJOU> CPHYFVFYQQQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<IPKHKLYTJOU> SOWPMNVCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C3F780", Offset = "0x9C3E180", VA = "0x189C3F780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FC80", Offset = "0x9C3E680", VA = "0x189C3FC80")]
		[BQDQKYYGTTM.Root.GameOnly]
		internal static void WDKFBDGKYRM(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D1B0", Offset = "0x9C3BBB0", VA = "0x189C3D1B0")]
		private bool CAQVWTOGCKI(Func<IPKHKLYTJOU, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E870", Offset = "0x9C3D270", VA = "0x189C3E870")]
		private bool MUCKQSGGBVH(Func<IPKHKLYTJOU, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D579A0", Offset = "0x3D563A0", VA = "0x183D579A0")]
		private bool DYNATAXWAPY<a>(a a, Func<IPKHKLYTJOU, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D57D00", Offset = "0x3D56700", VA = "0x183D57D00")]
		private bool OOSQORBEJUV<b>(b a, Func<IPKHKLYTJOU, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F240", Offset = "0x9C3DC40", VA = "0x189C3F240", Slot = "4")]
		public bool QWCUIWOFMGH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EFF0", Offset = "0x9C3D9F0", VA = "0x189C3EFF0", Slot = "5")]
		public bool QUUYYATLGUC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E750", Offset = "0x9C3D150", VA = "0x189C3E750", Slot = "6")]
		public bool MNSEHQONKME([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EC70", Offset = "0x9C3D670", VA = "0x189C3EC70", Slot = "7")]
		public bool OULFQVNHNHG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D490", Offset = "0x9C3BE90", VA = "0x189C3D490", Slot = "8")]
		public bool CWHYPNDACJM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E1A0", Offset = "0x9C3CBA0", VA = "0x189C3E1A0", Slot = "9")]
		public bool LJFPXHOPYSP(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F660", Offset = "0x9C3E060", VA = "0x189C3F660", Slot = "10")]
		public bool SGSSZBHALPW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FFC0", Offset = "0x9C3E9C0", VA = "0x189C3FFC0", Slot = "11")]
		public bool YGANZRKWUZP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FEA0", Offset = "0x9C3E8A0", VA = "0x189C3FEA0", Slot = "12")]
		public bool XLMGOKAGUQE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DE00", Offset = "0x9C3C800", VA = "0x189C3DE00", Slot = "13")]
		public bool JJCVYBHIOCF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EA00", Offset = "0x9C3D400", VA = "0x189C3EA00", Slot = "14")]
		public bool ODXVNQTBKEX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F540", Offset = "0x9C3DF40", VA = "0x189C3F540", Slot = "15")]
		public bool SBTRPQTCZKG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FB60", Offset = "0x9C3E560", VA = "0x189C3FB60", Slot = "16")]
		public bool VQQFJBEONRO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F110", Offset = "0x9C3DB10", VA = "0x189C3F110", Slot = "17")]
		public bool QVNVHKHRDTP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D940", Offset = "0x9C3C340", VA = "0x189C3D940", Slot = "18")]
		public bool IETKVOQKHBW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D080", Offset = "0x9C3BA80", VA = "0x189C3D080", Slot = "19")]
		public bool BQYSNCCMKXK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DF20", Offset = "0x9C3C920", VA = "0x189C3DF20", Slot = "20")]
		public bool JYRDFXXCYHX(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E3A0", Offset = "0x9C3CDA0", VA = "0x189C3E3A0", Slot = "21")]
		public bool MADBJFSBMVC(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FA30", Offset = "0x9C3E430", VA = "0x189C3FA30", Slot = "22")]
		public bool USPNCWCQULN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FD70", Offset = "0x9C3E770", VA = "0x189C3FD70", Slot = "23")]
		public bool WQJRILUJBJV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F410", Offset = "0x9C3DE10", VA = "0x189C3F410", Slot = "24")]
		public bool REFGDMZZQHM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E4F0", Offset = "0x9C3CEF0", VA = "0x189C3E4F0", Slot = "25")]
		public bool MHPBGKBZKKG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DCD0", Offset = "0x9C3C6D0", VA = "0x189C3DCD0", Slot = "26")]
		public bool JIQAMXUYITF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D810", Offset = "0x9C3C210", VA = "0x189C3D810", Slot = "27")]
		public bool IDDXRUOEIGP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D340", Offset = "0x9C3BD40", VA = "0x189C3D340", Slot = "28")]
		public bool CTEGNOFRFNM(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DBA0", Offset = "0x9C3C5A0", VA = "0x189C3DBA0", Slot = "29")]
		public bool IOYLIZSPZMS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EEC0", Offset = "0x9C3D8C0", VA = "0x189C3EEC0", Slot = "30")]
		public bool OXUZLHHPMFD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C400E0", Offset = "0x9C3EAE0", VA = "0x189C400E0", Slot = "31")]
		public bool ZNXLFWTMCXT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DA70", Offset = "0x9C3C470", VA = "0x189C3DA70", Slot = "32")]
		public bool IMSGXXKQTFA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EB20", Offset = "0x9C3D520", VA = "0x189C3EB20", Slot = "33")]
		public bool OMSFINFSMZK(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E070", Offset = "0x9C3CA70", VA = "0x189C3E070", Slot = "34")]
		public bool KSCAEHPHMUB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E620", Offset = "0x9C3D020", VA = "0x189C3E620", Slot = "35")]
		public bool MLXXKAZZDHP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D5B0", Offset = "0x9C3BFB0", VA = "0x189C3D5B0", Slot = "36")]
		public bool EVSEFHVADFU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D6E0", Offset = "0x9C3C0E0", VA = "0x189C3D6E0", Slot = "37")]
		public bool HNKKFZHWWPX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3ED90", Offset = "0x9C3D790", VA = "0x189C3ED90", Slot = "38")]
		public bool OXBQDGVTLCA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F360", Offset = "0x9C3DD60", VA = "0x189C3F360", Slot = "39")]
		public string QYLQAAZYFCU(OnlineRestrictionsSources a)
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
