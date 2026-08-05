using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC610", Offset = "0x2AFAC10", VA = "0x182AFC610")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.RecRoom.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum CircuitsDestinationTargetType
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		SubRoom,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		WelcomeMat
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum CircuitsRoomHUDElementType
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Title,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Subtitle,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		ProgressWheel,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Bar1,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Bar2,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		InventorySlot1,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		InventorySlot2,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		InventorySlot3
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CircuitsRoomHUDInventoryData : IEquatable<CircuitsRoomHUDInventoryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CircuitsRoomHUDElementType Slot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CircuitsRoomInventoryType InventoryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Guid ItemId;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC570", Offset = "0x2AFAB70", VA = "0x182AFC570", Slot = "4")]
		public bool Equals(CircuitsRoomHUDInventoryData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC490", Offset = "0x2AFAA90", VA = "0x182AFC490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC5D0", Offset = "0x2AFABD0", VA = "0x182AFC5D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class BAHEOHJPXZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly CircuitsRoomInventoryType HBBDMPYZVMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly Guid ZAUFCNFGCVQ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC450", Offset = "0x2AFAA50", VA = "0x182AFC450")]
		public BAHEOHJPXZR(CircuitsRoomInventoryType a, Guid b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CircuitsRoomInventoryType
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Currency,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Consumable,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		RoomInventoryItem
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface MREQMUGUMWF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		CircuitsDestinationTargetType VPWMTATYPWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string HUILVWXRKYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool OSXFSNMOCWE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool KUQEZPXTCDT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		RoomDoorData.NVAURJSHQDD.RoomDoorInviteMode IHXVPMHVJDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		string RCLTRCAKXFS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string VGVWYKWJPKK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string IXLAHUJGWJT
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface SXIWUQXLXHP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		string RCLTRCAKXFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		string TLUTKMXRTIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		List<string> EBWUQNIFMVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int DFLZPAFPKNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int OTEHYYLQDJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int EEHHGZNAUZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		int GXAARXWMWJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		AXIVUFQHUTP WDDOKSBXGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface JRGTEGCTGRS
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int VROUCEEXTQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool WTRECUPNTTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string YHRYJBCAKUU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		string PGJIQLWNOUO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool NTYGLNPCFFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool UGRHALMWMHF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float KCZMUXAIVSK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ObjectiveMarkerDestroyingHandler GZKVJYBQQZU;
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface AXIVUFQHUTP
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int ZKASHNAXQWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string KFPNWUKPRQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string MUIJVSKAGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string UAQOXOAQTPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int ANYANNWUTGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface CCKSZBEDJWO
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		string HUILVWXRKYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string AATUWTXQMDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		long NCFZLMXDGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface UOGSNRWBLTS
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Guid SNTOXKRGJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		IReadOnlyList<string> ZQVFUXBNWCO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface HSXCQAKJCFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int VSDJFRBPQYO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int ANCERZFXEAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		int GUQQRDCJPTI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		int DHNEJUQHKPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KJDGWMXXOQH();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ORFIYZFIIHS();

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DBRAWXNTTNX();

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void UMGYEOWJVVJ();

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JSDEYWMQPHZ();

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void JIUKNAUYOIE();

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BGKTZBFYJXX();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void XLMARJBLZFF();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void CHHAHZOMYAT(CircuitsRoomHUDInventoryData a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void FEGTKJSHCIL(CircuitsRoomHUDInventoryData a);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		BAHEOHJPXZR JXIJEWPXNHY(CircuitsRoomHUDElementType a);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyDictionary<CircuitsRoomHUDElementType, BAHEOHJPXZR> ZOFGPQJRMSL(CircuitsRoomInventoryType a, [In] Guid itemId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ENJYKGLCDRX
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int ZVAYOHEHOLL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int YACCMOEBZLT
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ASPYBHLIPKL
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		string WICTKPVRKRO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FVXNCDDGQUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MREQMUGUMWF? LMLJNJDGAOG(string? a, string? b, string? c, RoomDoorData.NVAURJSHQDD.RoomDoorInviteMode d, bool e);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		SXIWUQXLXHP LQTBRPQKPCQ(string a, string b, List<string> c, int d, int e, int f, int g, AXIVUFQHUTP h);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AXIVUFQHUTP JKNFNNLOMFA(int a, string b, string c, string d, string e, int f);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Obsolete("Do not add events to Circuits!")]
	public delegate void ObjectiveMarkerDestroyingHandler(JRGTEGCTGRS source);
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
