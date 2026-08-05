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
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x864E980", Offset = "0x864D980", VA = "0x18864E980")]
		public ConfigPropertyDrawer(Type Type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x864E9C0", Offset = "0x864D9C0", VA = "0x18864E9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8167560", Offset = "0x8166560", VA = "0x188167560")]
		public ConfigPropertyDrawerBase(int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MatchPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8167560", Offset = "0x8166560", VA = "0x188167560")]
		public MatchPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MultiPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8167560", Offset = "0x8166560", VA = "0x188167560")]
		public MultiPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OBHYUJXHARD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool SDYQODCXKLO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		RRObject GWOKFAMLHAU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action WCTTUXPXALP;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Get(MutableRef value);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Set(ReadOnlyRef value);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KZIBICYAFKT
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3817990", Offset = "0x3816990", VA = "0x183817990")]
		public static T Get<T>(this OBHYUJXHARD property) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3818450", Offset = "0x3817450", VA = "0x183818450")]
		public static void Set<T>(this OBHYUJXHARD property, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3818350", Offset = "0x3817350", VA = "0x183818350")]
		public static a PVWZAUXDGGQ<a>(this OBHYUJXHARD a) where a : Enum
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3817920", Offset = "0x3816920", VA = "0x183817920")]
		public static void DDLAPDPTKOM<b>(this OBHYUJXHARD a, b b) where b : Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x864EC20", Offset = "0x864DC20", VA = "0x18864EC20")]
		public static Enum PVWZAUXDGGQ(this OBHYUJXHARD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x864EA10", Offset = "0x864DA10", VA = "0x18864EA10")]
		public static void DDLAPDPTKOM(this OBHYUJXHARD a, Enum b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface SVSMEFNUQEW
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeObjectLocalIdArray NCXNTMYUOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HFZXCMRTEYL(NativeObjectLocalIdArray a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface WCEEGISSBFD<a> : MKHADALCLBA
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
	public interface MKHADALCLBA
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
	public interface DTMIGTPTCBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GRLRHMOCTOZ(object a, object b, Action c);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PZBUBPSZEHW(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JPNKQHAKZDV();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DVACULVMXEY();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "5")]
		WCEEGISSBFD<bool> ZOHSDTWWGJB();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "6")]
		WCEEGISSBFD<float> HNKWCWNVLAH();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "7")]
		WCEEGISSBFD<int> CKPIWKWMNZS();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "8")]
		WCEEGISSBFD<string> KKDVZPJZBXW();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "9")]
		WCEEGISSBFD<int> DWPHDUIRDHE();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "10")]
		WCEEGISSBFD<Enum> UILYIEIDYOC(Type a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "11")]
		WCEEGISSBFD<Enum> BMYFABTXNBL(Type a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		WCEEGISSBFD<(int, int)> VBGRILLRQZU();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface NXKHFDMKJXR : DSFFAMYQGNU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		NetworkProperty[] DDIEFEEKCIT
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		NetworkProperty[] QHVRDVEFRTS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DPNMDIIUTVH(OBHYUJXHARD a, SVSMEFNUQEW b, NVEEAEOMCJO c, DTMIGTPTCBF d);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface DSFFAMYQGNU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QMIKLEXNCFU : ACVMUXEQEVM, DSFFAMYQGNU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		NetworkProperty OZXNKABXNMS
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VCJUOFWRGLN : ACVMUXEQEVM, DSFFAMYQGNU
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DABOANHFRZW(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ACVMUXEQEVM : DSFFAMYQGNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b);
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
