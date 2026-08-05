using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ConfigPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9B80870", Offset = "0x9B7F270", VA = "0x189B80870")]
		public ConfigPropertyDrawer(Type Type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9B808B0", Offset = "0x9B7F2B0", VA = "0x189B808B0")]
		public ConfigPropertyDrawer(Type Type, int Priority)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class)]
	public abstract class ConfigPropertyDrawerBase : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x967AB20", Offset = "0x9679520", VA = "0x18967AB20")]
		public ConfigPropertyDrawerBase(int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MatchPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x967AB20", Offset = "0x9679520", VA = "0x18967AB20")]
		public MatchPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MultiPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x967AB20", Offset = "0x9679520", VA = "0x18967AB20")]
		public MultiPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface EFSRNAMUUKX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool TKCLWUCJLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		RRObject EECHEESZWMK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action PVIQOTRYGPZ;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Get(MutableRef value);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Set(ReadOnlyRef value);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BBLWWPYATZX
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x375E6C0", Offset = "0x375D0C0", VA = "0x18375E6C0")]
		public static T Get<T>(this EFSRNAMUUKX property) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x375F260", Offset = "0x375DC60", VA = "0x18375F260")]
		public static void Set<T>(this EFSRNAMUUKX property, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x375F160", Offset = "0x375DB60", VA = "0x18375F160")]
		public static a PLFUPNFYNFM<a>(this EFSRNAMUUKX a) where a : Enum
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x375F040", Offset = "0x375DA40", VA = "0x18375F040")]
		public static void OYMSDBMYMAG<b>(this EFSRNAMUUKX a, b b) where b : Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9B80660", Offset = "0x9B7F060", VA = "0x189B80660")]
		public static Enum PLFUPNFYNFM(this EFSRNAMUUKX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9B80450", Offset = "0x9B7EE50", VA = "0x189B80450")]
		public static void OYMSDBMYMAG(this EFSRNAMUUKX a, Enum b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface RLGFHYWFQMI
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeObjectLocalIdArray DITMLTUQTZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UVQBYUIKFQV(NativeObjectLocalIdArray a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface QDUDIDLXOOH<a> : LXTIMKXBYZO
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Func<a> ValueGetter
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		Action<a> ValueSetter
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Func<a> Preview
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface LXTIMKXBYZO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Func<bool> IsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Refresh();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface KXNTIHEZPWZ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RKCBVVMJUOD(object a, object b, Action c);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SSFMFLDTZRM(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JUWWIMMPYKV();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ACAFQXIFCWC();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "5")]
		QDUDIDLXOOH<bool> GVIVUDUWDHX();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "6")]
		QDUDIDLXOOH<float> LGYXGSGMFZT();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "7")]
		QDUDIDLXOOH<int> KRHRXCYGTYO();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "8")]
		QDUDIDLXOOH<string> GOXOQVTYFKC();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "9")]
		QDUDIDLXOOH<int> RSXSAZUDMKA();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "10")]
		QDUDIDLXOOH<Enum> ZJHPXJZRJZO(Type a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "11")]
		QDUDIDLXOOH<Enum> FOILXEMSGZV(Type a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		QDUDIDLXOOH<(int, int)> RKELOEXSUNG();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface NEFKBHGBRDD : TPQLDRBRGAM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		NetworkProperty[] ORPRLWXOEND
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		NetworkProperty[] HBIUSKSOFHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NMFIASHFGKT(EFSRNAMUUKX a, RLGFHYWFQMI b, JALXIPKYOPE c, KXNTIHEZPWZ d);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface TPQLDRBRGAM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface TPUPLHIGUTW : SEMWBKXPSCA, TPQLDRBRGAM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		NetworkProperty OPNSYIBLXMY
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface YBMOHIVCIWV : SEMWBKXPSCA, TPQLDRBRGAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool INGXCVFWEJY(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface SEMWBKXPSCA : TPQLDRBRGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b);
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
