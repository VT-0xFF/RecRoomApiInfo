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
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83C0D40", Offset = "0x83C0140", VA = "0x1883C0D40")]
		public ConfigPropertyDrawer(Type Type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83C0D80", Offset = "0x83C0180", VA = "0x1883C0D80")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EF75F0", Offset = "0x7EF69F0", VA = "0x187EF75F0")]
		public ConfigPropertyDrawerBase(int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MatchPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EF75F0", Offset = "0x7EF69F0", VA = "0x187EF75F0")]
		public MatchPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class MultiPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7EF75F0", Offset = "0x7EF69F0", VA = "0x187EF75F0")]
		public MultiPropertyDrawer(int Priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface WCFXHQZFKMS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool XHGDOZFMMRF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		RRObject KJCIQJFXADZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Type FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action ZNDFOXAYFTE;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Get(MutableRef value);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Set(ReadOnlyRef value);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class YCTGJFRFIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE7F0", Offset = "0x3BFDBF0", VA = "0x183BFE7F0")]
		public static T Get<T>(this WCFXHQZFKMS property) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF220", Offset = "0x3BFE620", VA = "0x183BFF220")]
		public static void Set<T>(this WCFXHQZFKMS property, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE6F0", Offset = "0x3BFDAF0", VA = "0x183BFE6F0")]
		public static a DKGJBIUFQNV<a>(this WCFXHQZFKMS a) where a : Enum
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF1B0", Offset = "0x3BFE5B0", VA = "0x183BFF1B0")]
		public static void OFWIHXWMZUH<b>(this WCFXHQZFKMS a, b b) where b : Enum
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83C0DD0", Offset = "0x83C01D0", VA = "0x1883C0DD0")]
		public static Enum DKGJBIUFQNV(this WCFXHQZFKMS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83C0FE0", Offset = "0x83C03E0", VA = "0x1883C0FE0")]
		public static void OFWIHXWMZUH(this WCFXHQZFKMS a, Enum b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface WTFTJTGJFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		NativeObjectLocalIdArray BGYWSGITCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IUHNPPLYJDQ(NativeObjectLocalIdArray a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface PAGFYDZFXVS<a> : TRQKWHTYNUH
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
	public interface TRQKWHTYNUH
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
	public interface KPTNYUMGSYY
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HGSJECSPXBK(object a, object b, Action c);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CGAJPADLRGV(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LLJPYNAHETQ();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PCGXRXSWNHF();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "5")]
		PAGFYDZFXVS<bool> ZODPRPKLUDY();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "6")]
		PAGFYDZFXVS<float> RWBROTBHRDS();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "7")]
		PAGFYDZFXVS<int> VVARWGJQDWP();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "8")]
		PAGFYDZFXVS<string> MGJOVOGQZUJ();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "9")]
		PAGFYDZFXVS<int> VBUPEUYINJL();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "10")]
		PAGFYDZFXVS<Enum> TYFRMVYOJRJ(Type a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "11")]
		PAGFYDZFXVS<Enum> ERTGFSREKAW(Type a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		PAGFYDZFXVS<(int, int)> DUPJUHFCLHX();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface ZFKCUXNIICW : IPWXNTSHTRL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		NetworkProperty[] XUFBTHCTMUM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		NetworkProperty[] IAUEHFFTGYR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EVOXFDZYKMQ(WCFXHQZFKMS a, WTFTJTGJFOJ b, ACCKBPMCUMR c, KPTNYUMGSYY d);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IPWXNTSHTRL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface KUVHYZJBRKN : FFEMWDIZMDL, IPWXNTSHTRL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		NetworkProperty SVLTXAFSJGH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface XCLLDWGFPFQ : FFEMWDIZMDL, IPWXNTSHTRL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MOJZQPYPJXJ(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface FFEMWDIZMDL : IPWXNTSHTRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EVOXFDZYKMQ(WCFXHQZFKMS a, KPTNYUMGSYY b);
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
