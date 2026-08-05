using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.UnityContainers;
using RecRoom.Utils.PrefParsers;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x85F7890", Offset = "0x85F6C90", VA = "0x1885F7890")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85FD520", Offset = "0x85FC920", VA = "0x1885FD520", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Preferences
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum AccountPreferenceBackingStoreTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CLOUD,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		DISK
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class ISYNTORLNPQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal delegate void CustomSaveHandler(MFXQPIVSBQK backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85F6110", Offset = "0x85F5510", VA = "0x1885F6110")]
		private static void DANSBGMIRKB(MFXQPIVSBQK a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85F5E70", Offset = "0x85F5270", VA = "0x1885F5E70")]
		public static bool BTDPJZRPHBZ(this MFXQPIVSBQK a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85F6410", Offset = "0x85F5810", VA = "0x1885F6410")]
		public static SetResult MOZLFXPLRIO(this MFXQPIVSBQK a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85F5FD0", Offset = "0x85F53D0", VA = "0x1885F5FD0")]
		public static SetResult BVTIDPFHLSC(this MFXQPIVSBQK a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85F6190", Offset = "0x85F5590", VA = "0x1885F6190")]
		public static SetResult DLLCZGYRQNZ(this MFXQPIVSBQK a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85F66D0", Offset = "0x85F5AD0", VA = "0x1885F66D0")]
		public static SetResult ZCMOMPSHLBD(this MFXQPIVSBQK a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85F6560", Offset = "0x85F5960", VA = "0x1885F6560")]
		public static SetResult RWBYGRKOSAG(this MFXQPIVSBQK a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85F62D0", Offset = "0x85F56D0", VA = "0x1885F62D0")]
		public static SetResult GJHQJPODIRL(this MFXQPIVSBQK a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class EFAFUFTXSBZ : JNYUXRTZMPJ, MFXQPIVSBQK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly VSEDBODUMBI GAXLGLXPZAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, byte> SHJEASQEHRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Dictionary<string, string> GFZIQJPHFRQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> TJQSXXCROOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85F5BF0", Offset = "0x85F4FF0", VA = "0x1885F5BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action SRTQSICUJNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85F5DD0", Offset = "0x85F51D0", VA = "0x1885F5DD0")]
		[UnityEngine.Scripting.Preserve]
		public EFAFUFTXSBZ([Inject(null)] VSEDBODUMBI unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "8")]
		public void RILMXWJZBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B20", Offset = "0x85F3F20", VA = "0x1885F4B20")]
		private DirectoryInfo LYSRTMWAJEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85F5420", Offset = "0x85F4820", VA = "0x1885F5420", Slot = "6")]
		public Task PPPKTEMVUZU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85F5D60", Offset = "0x85F5160", VA = "0x1885F5D60", Slot = "14")]
		public float XNKHIULZGKA(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85F53B0", Offset = "0x85F47B0", VA = "0x1885F53B0", Slot = "13")]
		public void OSQBFTKBHGO(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85F5C30", Offset = "0x85F5030", VA = "0x1885F5C30", Slot = "12")]
		public bool WYMHUIPWDPA(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85F5B80", Offset = "0x85F4F80", VA = "0x1885F5B80", Slot = "10")]
		public int VLKAURBWOXB(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85F4820", Offset = "0x85F3C20", VA = "0x1885F4820", Slot = "18")]
		public DateTime HAYQHTDRWVZ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85F42F0", Offset = "0x85F36F0", VA = "0x1885F42F0", Slot = "19")]
		public void BKERMHOKXQT(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85F44D0", Offset = "0x85F38D0", VA = "0x1885F44D0", Slot = "15")]
		public void CTCBIXHMOPS(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85F5CF0", Offset = "0x85F50F0", VA = "0x1885F5CF0", Slot = "11")]
		public void XIIJLBSJNNN(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85F47B0", Offset = "0x85F3BB0", VA = "0x1885F47B0", Slot = "20")]
		public long GUDWPFWUGNO(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85F4740", Offset = "0x85F3B40", VA = "0x1885F4740", Slot = "21")]
		public void FMRFLLKMDRG(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35BC480", Offset = "0x35BB880", VA = "0x1835BC480", Slot = "22")]
		public a DTCAHHJQMKZ<a>(string a, a b, MZLJZYFRGEY<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35BDC80", Offset = "0x35BD080", VA = "0x1835BDC80", Slot = "23")]
		public void LFGHSGZRGAR<b>(string a, b b, MZLJZYFRGEY<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85F4540", Offset = "0x85F3940", VA = "0x1885F4540", Slot = "16")]
		public string EEUUGMVHCHJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85F4360", Offset = "0x85F3760", VA = "0x1885F4360", Slot = "17")]
		public void CCNDCYRXXIH(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85F45F0", Offset = "0x85F39F0", VA = "0x1885F45F0", Slot = "24")]
		public void EXOOYPRDBPS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A90", Offset = "0x85F3E90", VA = "0x1885F4A90", Slot = "9")]
		public bool LXAMKKIMAWF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85F5850", Offset = "0x85F4C50", VA = "0x1885F5850", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85F54B0", Offset = "0x85F48B0", VA = "0x1885F54B0")]
		private void PWUKHBZBTUM(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85F4890", Offset = "0x85F3C90", VA = "0x1885F4890")]
		private static string JEYCDSZIHWV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85F43D0", Offset = "0x85F37D0", VA = "0x1885F43D0")]
		private static string CNCFYAONXTE(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x35BC700", Offset = "0x35BBB00", VA = "0x1835BC700")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] MZLJZYFRGEY<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x35BDE90", Offset = "0x35BD290", VA = "0x1835BDE90")]
		private void Set<T>(string propertyName, T value, [Optional] MZLJZYFRGEY<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85F4C10", Offset = "0x85F4010", VA = "0x1885F4C10")]
		private Dictionary<string, string> ONGLZZRMREI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class ZVUQWHGXGXR
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85FD3D0", Offset = "0x85FC7D0", VA = "0x1885FD3D0")]
		[JKCTBFVRGVY.Root]
		internal static void JKCTBFVRGVY(NAWAUUZVKFS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class PHNMZNIDNIA : QSMZRIMQVND
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85F7910", Offset = "0x85F6D10", VA = "0x1885F7910")]
		[UnityEngine.Scripting.Preserve]
		public PHNMZNIDNIA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class QSMZRIMQVND : JNYUXRTZMPJ, MFXQPIVSBQK, NTQSXPNXRIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, object> MHDCZCKCKOP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action SRTQSICUJNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "8")]
		public void RILMXWJZBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85FAEE0", Offset = "0x85FA2E0", VA = "0x1885FAEE0", Slot = "6")]
		public Task PPPKTEMVUZU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85FAE20", Offset = "0x85FA220", VA = "0x1885FAE20", Slot = "9")]
		public bool LXAMKKIMAWF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85FB000", Offset = "0x85FA400", VA = "0x1885FB000", Slot = "10")]
		public int VLKAURBWOXB(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85FB0C0", Offset = "0x85FA4C0", VA = "0x1885FB0C0", Slot = "11")]
		public void XIIJLBSJNNN(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85FB060", Offset = "0x85FA460", VA = "0x1885FB060", Slot = "12")]
		public bool WYMHUIPWDPA(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85FAE80", Offset = "0x85FA280", VA = "0x1885FAE80", Slot = "13")]
		public void OSQBFTKBHGO(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85FB120", Offset = "0x85FA520", VA = "0x1885FB120", Slot = "14")]
		public float XNKHIULZGKA(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85FABE0", Offset = "0x85F9FE0", VA = "0x1885FABE0", Slot = "15")]
		public void CTCBIXHMOPS(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85FAC40", Offset = "0x85FA040", VA = "0x1885FAC40", Slot = "16")]
		public string EEUUGMVHCHJ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85FAB80", Offset = "0x85F9F80", VA = "0x1885FAB80", Slot = "17")]
		public void CCNDCYRXXIH(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85FADC0", Offset = "0x85FA1C0", VA = "0x1885FADC0", Slot = "18")]
		public DateTime HAYQHTDRWVZ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85FAB20", Offset = "0x85F9F20", VA = "0x1885FAB20", Slot = "19")]
		public void BKERMHOKXQT(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85FAD60", Offset = "0x85FA160", VA = "0x1885FAD60", Slot = "20")]
		public long GUDWPFWUGNO(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85FAD00", Offset = "0x85FA100", VA = "0x1885FAD00", Slot = "21")]
		public void FMRFLLKMDRG(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3941580", Offset = "0x3940980", VA = "0x183941580", Slot = "22")]
		public a DTCAHHJQMKZ<a>(string a, a b, MZLJZYFRGEY<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x39423C0", Offset = "0x39417C0", VA = "0x1839423C0", Slot = "23")]
		public void LFGHSGZRGAR<b>(string a, b b, MZLJZYFRGEY<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3941930", Offset = "0x3940D30", VA = "0x183941930")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3942620", Offset = "0x3941A20", VA = "0x183942620")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85FACA0", Offset = "0x85FA0A0", VA = "0x1885FACA0", Slot = "24")]
		public void EXOOYPRDBPS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85FAF70", Offset = "0x85FA370", VA = "0x1885FAF70", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85F7910", Offset = "0x85F6D10", VA = "0x1885F7910")]
		public QSMZRIMQVND()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class TTSQJAJTZXG<a> where a : MFXQPIVSBQK
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly HashSet<TTSQJAJTZXG<a>> QMJRJTPXXEN;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5F40", Offset = "0x5EC5340", VA = "0x185EC5F40")]
		protected TTSQJAJTZXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void KQITJAOKIEM(string a);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5620", Offset = "0x5EC4A20", VA = "0x185EC5620")]
		public static void IQLOCAWIEDE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5AB0", Offset = "0x5EC4EB0", VA = "0x185EC5AB0")]
		public static void NYOMYEAMBNI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class TUILAURMCFH<a, b> : TTSQJAJTZXG<a> where a : MFXQPIVSBQK
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly TUILAURMCFH<a, b> HGWXKXVBWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, b> SWTCGIQGPBM;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE350", Offset = "0x5EFD750", VA = "0x185EFE350")]
		public bool OEVDKWHYLOS(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE6E0", Offset = "0x5EFDAE0", VA = "0x185EFE6E0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE180", Offset = "0x5EFD580", VA = "0x185EFE180", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE210", Offset = "0x5EFD610", VA = "0x185EFE210", Slot = "5")]
		protected override void KQITJAOKIEM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE890", Offset = "0x5EFDC90", VA = "0x185EFE890")]
		public TUILAURMCFH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MFXQPIVSBQK
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RILMXWJZBNK();

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LXAMKKIMAWF(string a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int VLKAURBWOXB(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XIIJLBSJNNN(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool WYMHUIPWDPA(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OSQBFTKBHGO(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float XNKHIULZGKA(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CTCBIXHMOPS(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string EEUUGMVHCHJ(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void CCNDCYRXXIH(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime HAYQHTDRWVZ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void BKERMHOKXQT(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long GUDWPFWUGNO(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void FMRFLLKMDRG(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a DTCAHHJQMKZ<a>(string a, a b, MZLJZYFRGEY<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void LFGHSGZRGAR<b>(string a, b b, MZLJZYFRGEY<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void EXOOYPRDBPS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface JNYUXRTZMPJ : MFXQPIVSBQK
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action SRTQSICUJNY;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task PPPKTEMVUZU(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface NTQSXPNXRIH : MFXQPIVSBQK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RXYUOLNUVOF : JNYUXRTZMPJ, MFXQPIVSBQK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <Save>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public RXYUOLNUVOF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x85FC300", Offset = "0x85FB700", VA = "0x1885FC300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x85FC6C0", Offset = "0x85FBAC0", VA = "0x1885FC6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class XRAHZZMELFK : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public RXYUOLNUVOF ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public XRAHZZMELFK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x85FD360", Offset = "0x85FC760", VA = "0x1885FD360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85FD320", Offset = "0x85FC720", VA = "0x1885FD320", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly VSEDBODUMBI GAXLGLXPZAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool SDSRQMISEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool SUZBTYKDFEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TLYLZRCRVJA ARUZMIMYWWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ARAECGCQSWT SUJIMIGKKLH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action SRTQSICUJNY
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85FB980", Offset = "0x85FAD80", VA = "0x1885FB980")]
		[UnityEngine.Scripting.Preserve]
		public RXYUOLNUVOF([Inject(null)] VSEDBODUMBI unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "8")]
		public void RILMXWJZBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85FB5E0", Offset = "0x85FA9E0", VA = "0x1885FB5E0", Slot = "6")]
		public Task PPPKTEMVUZU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1B8DD10", Offset = "0x1B8D110", VA = "0x181B8DD10")]
		private static int CECTTOOUYEA(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85FB590", Offset = "0x85FA990", VA = "0x1885FB590", Slot = "9")]
		public bool LXAMKKIMAWF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85FB830", Offset = "0x85FAC30", VA = "0x1885FB830", Slot = "10")]
		public int VLKAURBWOXB(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85FB890", Offset = "0x85FAC90", VA = "0x1885FB890", Slot = "11")]
		public void XIIJLBSJNNN(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85FB860", Offset = "0x85FAC60", VA = "0x1885FB860", Slot = "12")]
		public bool WYMHUIPWDPA(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85FB5B0", Offset = "0x85FA9B0", VA = "0x1885FB5B0", Slot = "13")]
		public void OSQBFTKBHGO(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85FB8E0", Offset = "0x85FACE0", VA = "0x1885FB8E0", Slot = "14")]
		public float XNKHIULZGKA(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85FB2E0", Offset = "0x85FA6E0", VA = "0x1885FB2E0", Slot = "15")]
		public void CTCBIXHMOPS(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85FB4B0", Offset = "0x85FA8B0", VA = "0x1885FB4B0", Slot = "18")]
		public DateTime HAYQHTDRWVZ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85FB240", Offset = "0x85FA640", VA = "0x1885FB240", Slot = "19")]
		public void BKERMHOKXQT(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85FB440", Offset = "0x85FA840", VA = "0x1885FB440", Slot = "20")]
		public long GUDWPFWUGNO(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85FB3D0", Offset = "0x85FA7D0", VA = "0x1885FB3D0", Slot = "21")]
		public void FMRFLLKMDRG(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x39D39A0", Offset = "0x39D2DA0", VA = "0x1839D39A0", Slot = "22")]
		public a DTCAHHJQMKZ<a>(string a, a b, MZLJZYFRGEY<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x39D4AD0", Offset = "0x39D3ED0", VA = "0x1839D4AD0", Slot = "23")]
		public void LFGHSGZRGAR<b>(string a, b b, MZLJZYFRGEY<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x39D3C60", Offset = "0x39D3060", VA = "0x1839D3C60")]
		private c HNQPNPTNWSU<c>(string a, c b, [Optional] MZLJZYFRGEY<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x39D4D10", Offset = "0x39D4110", VA = "0x1839D4D10")]
		private void YTPVZQKSVTK<d>(string a, d b, [Optional] MZLJZYFRGEY<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85FB310", Offset = "0x85FA710", VA = "0x1885FB310", Slot = "16")]
		public string EEUUGMVHCHJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85FB2B0", Offset = "0x85FA6B0", VA = "0x1885FB2B0", Slot = "17")]
		public void CCNDCYRXXIH(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85FB8C0", Offset = "0x85FACC0", VA = "0x1885FB8C0")]
		private void XJBLBVPCKGG(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85FB180", Offset = "0x85FA580", VA = "0x1885FB180")]
		private string ADZNZBJOTNI(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85FB340", Offset = "0x85FA740", VA = "0x1885FB340", Slot = "24")]
		public void EXOOYPRDBPS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85FB1A0", Offset = "0x85FA5A0", VA = "0x1885FB1A0")]
		private string AUJKJLZZMXC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85FB740", Offset = "0x85FAB40", VA = "0x1885FB740", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85FB910", Offset = "0x85FAD10", VA = "0x1885FB910")]
		[IteratorStateMachine(typeof(XRAHZZMELFK))]
		private IEnumerator<QAEGIZFUAOU> YRXHYGLYAJW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85FB6E0", Offset = "0x85FAAE0", VA = "0x1885FB6E0")]
		private void SCZYXRQNAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85FB670", Offset = "0x85FAA70", VA = "0x1885FB670")]
		private void QSKHFMFAPBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85FB520", Offset = "0x85FA920", VA = "0x1885FB520")]
		private void LHHAYQJTKFB(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class MOUDDWVMKDL : JNYUXRTZMPJ, MFXQPIVSBQK
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct KVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public string k;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public string v;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct KVPs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public KVP[] kvps;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Dictionary<string, string> GFZIQJPHFRQ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string YTLUPOXLYLL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x85F73F0", Offset = "0x85F67F0", VA = "0x1885F73F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string UNRXOYHKERB
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x85F6890", Offset = "0x85F5C90", VA = "0x1885F6890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Dictionary<string, string> TJQSXXCROOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x85F74F0", Offset = "0x85F68F0", VA = "0x1885F74F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action SRTQSICUJNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		[UnityEngine.Scripting.Preserve]
		public MOUDDWVMKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "8")]
		public void RILMXWJZBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85F7100", Offset = "0x85F6500", VA = "0x1885F7100", Slot = "6")]
		public Task PPPKTEMVUZU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85F7660", Offset = "0x85F6A60", VA = "0x1885F7660", Slot = "14")]
		public float XNKHIULZGKA(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85F7090", Offset = "0x85F6490", VA = "0x1885F7090", Slot = "13")]
		public void OSQBFTKBHGO(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85F7530", Offset = "0x85F6930", VA = "0x1885F7530", Slot = "12")]
		public bool WYMHUIPWDPA(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85F7480", Offset = "0x85F6880", VA = "0x1885F7480", Slot = "10")]
		public int VLKAURBWOXB(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85F6C80", Offset = "0x85F6080", VA = "0x1885F6C80", Slot = "18")]
		public DateTime HAYQHTDRWVZ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85F6820", Offset = "0x85F5C20", VA = "0x1885F6820", Slot = "19")]
		public void BKERMHOKXQT(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85F69C0", Offset = "0x85F5DC0", VA = "0x1885F69C0", Slot = "15")]
		public void CTCBIXHMOPS(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85F75F0", Offset = "0x85F69F0", VA = "0x1885F75F0", Slot = "11")]
		public void XIIJLBSJNNN(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85F6C10", Offset = "0x85F6010", VA = "0x1885F6C10", Slot = "20")]
		public long GUDWPFWUGNO(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85F6BA0", Offset = "0x85F5FA0", VA = "0x1885F6BA0", Slot = "21")]
		public void FMRFLLKMDRG(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x35BC480", Offset = "0x35BB880", VA = "0x1835BC480", Slot = "22")]
		public a DTCAHHJQMKZ<a>(string a, a b, MZLJZYFRGEY<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x35BDC80", Offset = "0x35BD080", VA = "0x1835BDC80", Slot = "23")]
		public void LFGHSGZRGAR<b>(string a, b b, MZLJZYFRGEY<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85F6A30", Offset = "0x85F5E30", VA = "0x1885F6A30", Slot = "16")]
		public string EEUUGMVHCHJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85F6920", Offset = "0x85F5D20", VA = "0x1885F6920", Slot = "17")]
		public void CCNDCYRXXIH(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85F6AE0", Offset = "0x85F5EE0", VA = "0x1885F6AE0", Slot = "24")]
		public void EXOOYPRDBPS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85F6CF0", Offset = "0x85F60F0", VA = "0x1885F6CF0", Slot = "9")]
		public bool LXAMKKIMAWF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85F7190", Offset = "0x85F6590", VA = "0x1885F7190", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x37C9110", Offset = "0x37C8510", VA = "0x1837C9110")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] MZLJZYFRGEY<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x37CA7B0", Offset = "0x37C9BB0", VA = "0x1837CA7B0")]
		private void Set<T>(string propertyName, T value, [Optional] MZLJZYFRGEY<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85F6D80", Offset = "0x85F6180", VA = "0x1885F6D80")]
		private Dictionary<string, string> ONGLZZRMREI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface OSKIKKKCZRT
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action SRTQSICUJNY;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RILMXWJZBNK();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task GGSBZALCOYK(long a);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool FWUPFHDNQLI(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HGJTQYDQIHG(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MGRKYXOGWZB(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string IISMLTXJQOY(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult QXNJRVCNXTO(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int CBTJZPNVVJM(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult MMRSHHSJQTA(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool GWKOEAEIXTX(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult IPJMQFXMMJL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float WRWIEHGMDPH(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult OEGUJHMSXGV(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime VCFPWBGOIGQ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult FQNZNGWROOM(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long HFWBKMFOWJN(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult OKNUMOUTKXV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a DTJPNPPNUEK<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult PAUWUBETETQ<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool ILOCKYQMFJM(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool OCKNGGWPMJR(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string PBUGCRZKISW(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult PQOZWJEYOVU(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int GUMLWLDKTCQ(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult SNNKHQCBBQY(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool JPMFUMLXDRN(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult WSCUQRQCULR(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float ZFLDZGJJTST(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult HKJADQLQCST(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime CYSKSWITIHE(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult ZHFRJTQYRCW(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long AAJDJYEIGDD(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult LCTDYAVZCGZ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void FJKTKYLZVWI<e>(MZLJZYFRGEY<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void MFOHPYQXVTV<f>();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable ZRKNKCWQVYM();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void RPRAOCSGMTB(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task SCZYXRQNAIA([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum SetResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Unchanged,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Changed
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class Preferences : OSKIKKKCZRT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private abstract class NGAQLNASYNN
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			protected static readonly HashSet<NGAQLNASYNN> ZONBQWPTWCG;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x85F76D0", Offset = "0x85F6AD0", VA = "0x1885F76D0")]
			public static void NYOMYEAMBNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			protected NGAQLNASYNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private class FXKTSNPIWRC<a> : NGAQLNASYNN
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly FXKTSNPIWRC<a> ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public MZLJZYFRGEY<a> NHAFRPHRWFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IEqualityComparer<a> BQOMMLJUMVL
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SOQPRXPAMEW
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x4D6F7F0", Offset = "0x4D6EBF0", VA = "0x184D6F7F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x4D70090", Offset = "0x4D6F490", VA = "0x184D70090")]
			private FXKTSNPIWRC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4D6FBA0", Offset = "0x4D6EFA0", VA = "0x184D6FBA0")]
			public void MKOAUOREKWX(MZLJZYFRGEY<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F7A0", Offset = "0x4D6EBA0", VA = "0x184D6F7A0", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class WKJJFWBRCJJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private readonly Preferences EYQDSGONKQQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly object TGDSJCEYFDU;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x85FD270", Offset = "0x85FC670", VA = "0x1885FD270")]
			public WKJJFWBRCJJ(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x85FD240", Offset = "0x85FC640", VA = "0x1885FD240", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <InitializeForPlayerInternal>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public long playerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x85FBA80", Offset = "0x85FAE80", VA = "0x1885FBA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x85FBD70", Offset = "0x85FB170", VA = "0x1885FBD70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <Save>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public MFXQPIVSBQK backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x85FC720", Offset = "0x85FBB20", VA = "0x1885FC720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <SaveImmediate>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x85FBDD0", Offset = "0x85FB1D0", VA = "0x1885FBDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x85FC2A0", Offset = "0x85FB6A0", VA = "0x1885FC2A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class CQOVVFTXBDL : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Preferences ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float SOICNYYXJMD;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public CQOVVFTXBDL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x85F4260", Offset = "0x85F3660", VA = "0x1885F4260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x85F4220", Offset = "0x85F3620", VA = "0x1885F4220", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly JNYUXRTZMPJ VJYLZNBGBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly JNYUXRTZMPJ XNAWCONUPQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly NTQSXPNXRIH VXCZAYOKAWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly TLYLZRCRVJA ARUZMIMYWWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly ISYNTORLNPQ.CustomSaveHandler MZDWNFPIKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly JGNLWQGOMVG FFAHHOLKIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<MFXQPIVSBQK> NMFYCYCHHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task CFUAQLSRJWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<string, string> VMVCPOLCXAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private ARAECGCQSWT JJPMDUGDLIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly object OETLRIPTOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly object WDRTQQPKFPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private long EWXESHZACCM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool DFWZUFLBOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x17894D0", Offset = "0x17888D0", VA = "0x1817894D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CancellationTokenSource YSSHSFGVQPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA6650", Offset = "0xAA5A50", VA = "0x180AA6650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA68B0", Offset = "0xAA5CB0", VA = "0x180AA68B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action SRTQSICUJNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x85F8470", Offset = "0x85F7870", VA = "0x1885F8470", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x85FA3D0", Offset = "0x85F97D0", VA = "0x1885FA3D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85F89D0", Offset = "0x85F7DD0", VA = "0x1885F89D0")]
		[JKCTBFVRGVY.Root]
		internal static void HUWTROQPORD(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x85FA790", Offset = "0x85F9B90", VA = "0x1885FA790")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] JNYUXRTZMPJ localBackingStore, [Inject("Cloud")] JNYUXRTZMPJ cloudBackingStore, [Inject(null)] NTQSXPNXRIH editorBackingStore, [Inject(null)] TLYLZRCRVJA scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85F7CB0", Offset = "0x85F70B0", VA = "0x1885F7CB0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85FA0F0", Offset = "0x85F94F0", VA = "0x1885FA0F0")]
		private void WYBREOZFNJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85F9C00", Offset = "0x85F9000", VA = "0x1885F9C00", Slot = "6")]
		public void RILMXWJZBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85F8510", Offset = "0x85F7910", VA = "0x1885F8510", Slot = "7")]
		public Task GGSBZALCOYK(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85F8110", Offset = "0x85F7510", VA = "0x1885F8110")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task FRODCBBQUXV(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85F7A00", Offset = "0x85F6E00", VA = "0x1885F7A00")]
		private void APXQSLNTFCS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85F9D70", Offset = "0x85F9170", VA = "0x1885F9D70")]
		private void SEQZESBHOQH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85FA730", Offset = "0x85F9B30", VA = "0x1885FA730")]
		private string ZVNZYTILFSO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85F82D0", Offset = "0x85F76D0", VA = "0x1885F82D0")]
		private void FXYJAXBJQOQ(AccountPreferenceBackingStoreTypes a, string b, [Out] JNYUXRTZMPJ c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x85F8A40", Offset = "0x85F7E40", VA = "0x1885F8A40")]
		private JNYUXRTZMPJ HVUBICUAZMA(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x85F8220", Offset = "0x85F7620", VA = "0x1885F8220", Slot = "8")]
		public bool FWUPFHDNQLI(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85F8900", Offset = "0x85F7D00", VA = "0x1885F8900", Slot = "9")]
		public bool HGJTQYDQIHG(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85F8FC0", Offset = "0x85F83C0", VA = "0x1885F8FC0", Slot = "10")]
		public bool MGRKYXOGWZB(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85F8AC0", Offset = "0x85F7EC0", VA = "0x1885F8AC0", Slot = "11")]
		public string IISMLTXJQOY(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85F9A70", Offset = "0x85F8E70", VA = "0x1885F9A70", Slot = "12")]
		public SetResult QXNJRVCNXTO(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x85F7B90", Offset = "0x85F6F90", VA = "0x1885F7B90", Slot = "13")]
		public int CBTJZPNVVJM(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85F9140", Offset = "0x85F8540", VA = "0x1885F9140", Slot = "14")]
		public SetResult MMRSHHSJQTA(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85F8750", Offset = "0x85F7B50", VA = "0x1885F8750", Slot = "15")]
		public bool GWKOEAEIXTX(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85F8BC0", Offset = "0x85F7FC0", VA = "0x1885F8BC0", Slot = "16")]
		public SetResult IPJMQFXMMJL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85FA010", Offset = "0x85F9410", VA = "0x1885FA010", Slot = "17")]
		public float WRWIEHGMDPH(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85F92D0", Offset = "0x85F86D0", VA = "0x1885F92D0", Slot = "18")]
		public SetResult OEGUJHMSXGV(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x85F9F70", Offset = "0x85F9370", VA = "0x1885F9F70", Slot = "19")]
		public DateTime VCFPWBGOIGQ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85F7F70", Offset = "0x85F7370", VA = "0x1885F7F70", Slot = "20")]
		public SetResult FQNZNGWROOM(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x85F8860", Offset = "0x85F7C60", VA = "0x1885F8860", Slot = "21")]
		public long HFWBKMFOWJN(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x85F9480", Offset = "0x85F8880", VA = "0x1885F9480", Slot = "22")]
		public SetResult OKNUMOUTKXV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x38DA110", Offset = "0x38D9510", VA = "0x1838DA110", Slot = "23")]
		public a DTJPNPPNUEK<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x38DAE50", Offset = "0x38DA250", VA = "0x1838DAE50", Slot = "24")]
		public SetResult PAUWUBETETQ<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x85F8B60", Offset = "0x85F7F60", VA = "0x1885F8B60", Slot = "25")]
		public bool ILOCKYQMFJM(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x85F92C0", Offset = "0x85F86C0", VA = "0x1885F92C0", Slot = "26")]
		public bool OCKNGGWPMJR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x85F9870", Offset = "0x85F8C70", VA = "0x1885F9870", Slot = "27")]
		public string PBUGCRZKISW(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x85F9A40", Offset = "0x85F8E40", VA = "0x1885F9A40", Slot = "28")]
		public SetResult PQOZWJEYOVU(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85F86E0", Offset = "0x85F7AE0", VA = "0x1885F86E0", Slot = "29")]
		public int GUMLWLDKTCQ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x85F9E70", Offset = "0x85F9270", VA = "0x1885F9E70", Slot = "30")]
		public SetResult SNNKHQCBBQY(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85F8D40", Offset = "0x85F8140", VA = "0x1885F8D40", Slot = "31")]
		public bool JPMFUMLXDRN(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85FA0C0", Offset = "0x85F94C0", VA = "0x1885FA0C0", Slot = "32")]
		public SetResult WSCUQRQCULR(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85FA5C0", Offset = "0x85F99C0", VA = "0x1885FA5C0", Slot = "33")]
		public float ZFLDZGJJTST(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x85F89A0", Offset = "0x85F7DA0", VA = "0x1885F89A0", Slot = "34")]
		public SetResult HKJADQLQCST(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C40", Offset = "0x85F7040", VA = "0x1885F7C40", Slot = "35")]
		public DateTime CYSKSWITIHE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85FA630", Offset = "0x85F9A30", VA = "0x1885FA630", Slot = "36")]
		public SetResult ZHFRJTQYRCW(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85F7990", Offset = "0x85F6D90", VA = "0x1885F7990", Slot = "37")]
		public long AAJDJYEIGDD(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x85F8F90", Offset = "0x85F8390", VA = "0x1885F8F90", Slot = "38")]
		public SetResult LCTDYAVZCGZ(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85F8800", Offset = "0x85F7C00", VA = "0x1885F8800")]
		private bool GYSMFUZVVRE(MFXQPIVSBQK a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85F98E0", Offset = "0x85F8CE0", VA = "0x1885F98E0")]
		private bool PKHYHWJNZOV(MFXQPIVSBQK a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85FA280", Offset = "0x85F9680", VA = "0x1885FA280")]
		private SetResult YNAEXLGTUZR(MFXQPIVSBQK a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85FA140", Offset = "0x85F9540", VA = "0x1885FA140")]
		private SetResult YBJTKXEHCRJ(MFXQPIVSBQK a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x85F7E30", Offset = "0x85F7230", VA = "0x1885F7E30")]
		private SetResult EWNXECICCFM(MFXQPIVSBQK a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x85FA470", Offset = "0x85F9870", VA = "0x1885FA470")]
		private SetResult ZDZFUUSTDGI(MFXQPIVSBQK a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85F7A20", Offset = "0x85F6E20", VA = "0x1885F7A20")]
		private SetResult BSKEMKPIQBV(MFXQPIVSBQK a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85F7CF0", Offset = "0x85F70F0", VA = "0x1885F7CF0")]
		private SetResult EQQECATHNJG(MFXQPIVSBQK a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x38DA870", Offset = "0x38D9C70", VA = "0x1838DA870")]
		private e LYPVSEQQDZX<e>(MFXQPIVSBQK a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x38D94C0", Offset = "0x38D88C0", VA = "0x1838D94C0")]
		private SetResult ANPMTQFBOIJ<f>(MFXQPIVSBQK a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x38DA690", Offset = "0x38D9A90", VA = "0x1838DA690", Slot = "39")]
		public void FJKTKYLZVWI<g>(MZLJZYFRGEY<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x38DADC0", Offset = "0x38DA1C0", VA = "0x1838DADC0", Slot = "40")]
		public void MFOHPYQXVTV<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x85F9EA0", Offset = "0x85F92A0", VA = "0x1885F9EA0")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(MFXQPIVSBQK backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x85F9C80", Offset = "0x85F9080", VA = "0x1885F9C80", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task SCZYXRQNAIA([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x85F8DB0", Offset = "0x85F81B0", VA = "0x1885F8DB0")]
		private void JQBIABDJSSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x85FA660", Offset = "0x85F9A60", VA = "0x1885FA660", Slot = "41")]
		public IDisposable ZRKNKCWQVYM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x85F9C70", Offset = "0x85F9070", VA = "0x1885F9C70", Slot = "42")]
		public void RPRAOCSGMTB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85F9600", Offset = "0x85F8A00", VA = "0x1885F9600")]
		private void OYBJKVNCLFZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x85F9DF0", Offset = "0x85F91F0", VA = "0x1885F9DF0")]
		[IteratorStateMachine(typeof(CQOVVFTXBDL))]
		private IEnumerator<QAEGIZFUAOU> SFTCUEMECGJ(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85F9450", Offset = "0x85F8850", VA = "0x1885F9450")]
		[CompilerGenerated]
		private void OFRADVXUMLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class VXKZZRATGFR
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x85FCC40", Offset = "0x85FC040", VA = "0x1885FCC40")]
		public static string NXMLEESZZLG(this OSKIKKKCZRT a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85FCAA0", Offset = "0x85FBEA0", VA = "0x1885FCAA0")]
		public static byte[] HDTWCVCEIAE(this OSKIKKKCZRT a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85FC990", Offset = "0x85FBD90", VA = "0x1885FC990")]
		public static SetResult DMFEUINWYSY(this OSKIKKKCZRT a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class WGYNRUEPEXI : LORNUUFMEZY<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static WGYNRUEPEXI ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x85FCDB0", Offset = "0x85FC1B0", VA = "0x1885FCDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85FCE00", Offset = "0x85FC200", VA = "0x1885FCE00", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x85FCEF0", Offset = "0x85FC2F0", VA = "0x1885FCEF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85FD200", Offset = "0x85FC600", VA = "0x1885FD200")]
		public WGYNRUEPEXI()
		{
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
