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
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8748F10", Offset = "0x8747D10", VA = "0x188748F10")]
		public ConfigPropertyDrawer(Type Type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8748F50", Offset = "0x8747D50", VA = "0x188748F50")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82917D0", Offset = "0x82905D0", VA = "0x1882917D0")]
		public ConfigPropertyDrawerBase(int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MatchPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82917D0", Offset = "0x82905D0", VA = "0x1882917D0")]
		public MatchPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MultiPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82917D0", Offset = "0x82905D0", VA = "0x1882917D0")]
		public MultiPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface FFDARHOGBEJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool HDBUMCCJOKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		RRObject SKBJBKLGHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action EAMAFNHRRNH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Get(MutableRef value);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Set(ReadOnlyRef value);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KCKCPQFHOCX
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39E42C0", Offset = "0x39E30C0", VA = "0x1839E42C0")]
		public static T Get<T>(this FFDARHOGBEJ property) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x39E4D80", Offset = "0x39E3B80", VA = "0x1839E4D80")]
		public static void Set<T>(this FFDARHOGBEJ property, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x39E4C80", Offset = "0x39E3A80", VA = "0x1839E4C80")]
		public static a SKLACFIFGUE<a>(this FFDARHOGBEJ a) where a : Enum
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x39E5640", Offset = "0x39E4440", VA = "0x1839E5640")]
		public static void TWISAGZBTBK<b>(this FFDARHOGBEJ a, b b) where b : Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8748FA0", Offset = "0x8747DA0", VA = "0x188748FA0")]
		public static Enum SKLACFIFGUE(this FFDARHOGBEJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87491B0", Offset = "0x8747FB0", VA = "0x1887491B0")]
		public static void TWISAGZBTBK(this FFDARHOGBEJ a, Enum b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface PZYWCASNVPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeObjectLocalIdArray WUEZEUAVBTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DNXEEPMKNJF(NativeObjectLocalIdArray a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface JPAWFGSZVHH<a> : UJRLIAAELXE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Func<a> QYYHGYKDWSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		Action<a> EVRLEDKJKFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Func<a> XZYWYZLWUOF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface UJRLIAAELXE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Func<bool> MDIOIIHSWUQ
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
	public interface PNYPUWDUCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RWFLESYWDGJ(object a, object b, Action c);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LNIIVGWCRDC(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CBCWKIUGCMH();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NWABGPGORKU();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "5")]
		JPAWFGSZVHH<bool> YWBLXTLEQIT();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "6")]
		JPAWFGSZVHH<float> HOVMCJTJVBF();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "7")]
		JPAWFGSZVHH<int> PBDOSPBEWBO();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "8")]
		JPAWFGSZVHH<string> JAHZQMYGDLO();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "9")]
		JPAWFGSZVHH<int> YQEEQPQTWTQ();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "10")]
		JPAWFGSZVHH<Enum> AGHRMJRXOIW(Type a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "11")]
		JPAWFGSZVHH<Enum> PNAJVURUGMB(Type a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		JPAWFGSZVHH<(int, int)> QYWZQKYADPE();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LKLPCTZBKTN : ZJVFGBLXYUO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		NetworkProperty[] NXMDWIHKVNV
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		NetworkProperty[] GDADGEWJWPG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UILISBYTLBX(FFDARHOGBEJ a, PZYWCASNVPM b, FMNNIKHOIUY c, PNYPUWDUCEP d);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ZJVFGBLXYUO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QTPTECFQKJU : SPOJVAXFSRE, ZJVFGBLXYUO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		NetworkProperty DETGYEJXBPU
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IYUNHAQBHDZ : SPOJVAXFSRE, ZJVFGBLXYUO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XMBHCAAIEEE(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface SPOJVAXFSRE : ZJVFGBLXYUO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b);
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
