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
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A145E0", Offset = "0x9A12FE0", VA = "0x189A145E0")]
		public ConfigPropertyDrawer(Type Type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A14620", Offset = "0x9A13020", VA = "0x189A14620")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECB10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9511870", Offset = "0x9510270", VA = "0x189511870")]
		public ConfigPropertyDrawerBase(int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MatchPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9511870", Offset = "0x9510270", VA = "0x189511870")]
		public MatchPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MultiPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9511870", Offset = "0x9510270", VA = "0x189511870")]
		public MultiPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface MZEXCYTGDUA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool CXRGWAGXVPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		RRObject OGMCZHCYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action AWRUUXEIWDO;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Get(MutableRef value);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Set(ReadOnlyRef value);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class LGZAEKBEITA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC290", Offset = "0x3BEAC90", VA = "0x183BEC290")]
		public static T Get<T>(this MZEXCYTGDUA property) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BECB40", Offset = "0x3BEB540", VA = "0x183BECB40")]
		public static void Set<T>(this MZEXCYTGDUA property, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BED3E0", Offset = "0x3BEBDE0", VA = "0x183BED3E0")]
		public static a XQFVNRTHHPP<a>(this MZEXCYTGDUA a) where a : Enum
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC220", Offset = "0x3BEAC20", VA = "0x183BEC220")]
		public static void GHOQKDRILRX<b>(this MZEXCYTGDUA a, b b) where b : Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A14880", Offset = "0x9A13280", VA = "0x189A14880")]
		public static Enum XQFVNRTHHPP(this MZEXCYTGDUA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A14670", Offset = "0x9A13070", VA = "0x189A14670")]
		public static void GHOQKDRILRX(this MZEXCYTGDUA a, Enum b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface HVXZROXIITZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeObjectLocalIdArray FRROUIGHYTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YDKNOKRPSNS(NativeObjectLocalIdArray a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface RPPGFKESHGW<a> : WVPUCKMDXCR
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
	public interface WVPUCKMDXCR
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
	public interface UYLYJABWQJU
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WNCQWZWPKZY(object a, object b, Action c);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZJTJQHHPGTB(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RBNVATQWXYQ();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OINSZGFXMKZ();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RPPGFKESHGW<bool> WLGMPEBZGSM();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RPPGFKESHGW<float> FPIQQVHIVEK();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "7")]
		RPPGFKESHGW<int> SAAPPHALNKN();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RPPGFKESHGW<string> MXHBVQXPKAD();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "9")]
		RPPGFKESHGW<int> MUBNEJGARVF();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RPPGFKESHGW<Enum> HNAGAWSDANX(Type a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "11")]
		RPPGFKESHGW<Enum> ETSHYOHMAEA(Type a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		RPPGFKESHGW<(int, int)> NTUIXWTLIQH();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface SXAYRTSQJMM : TXRZSTPMAZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		NetworkProperty[] NLJCDRULUUK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		NetworkProperty[] NYGDHSDPIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZNMWNVUQKVU(MZEXCYTGDUA a, HVXZROXIITZ b, LISNGJFWSIP c, UYLYJABWQJU d);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface TXRZSTPMAZR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface YYETYGZKQLR : GWBYPVMBYQL, TXRZSTPMAZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		NetworkProperty IFWWVKYBDVT
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FUGCORJLEGM : GWBYPVMBYQL, TXRZSTPMAZR
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HEHUHCHHXSN(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface GWBYPVMBYQL : TXRZSTPMAZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b);
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
