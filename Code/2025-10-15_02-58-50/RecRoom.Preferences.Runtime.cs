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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8876E70", Offset = "0x8875C70", VA = "0x188876E70")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x887C330", Offset = "0x887B130", VA = "0x18887C330", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
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
	internal static class TABUXMOXBMT
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal delegate void CustomSaveHandler(ZSUZLPYTZDD backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x887A160", Offset = "0x8878F60", VA = "0x18887A160")]
		private static void AELKEOBXEJS(ZSUZLPYTZDD a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x887A320", Offset = "0x8879120", VA = "0x18887A320")]
		public static bool BQISEYJHWKO(this ZSUZLPYTZDD a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x887A730", Offset = "0x8879530", VA = "0x18887A730")]
		public static SetResult PKLQKKHBYUZ(this ZSUZLPYTZDD a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x887A1E0", Offset = "0x8878FE0", VA = "0x18887A1E0")]
		public static SetResult AHXLLAZBYFZ(this ZSUZLPYTZDD a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x887A9D0", Offset = "0x88797D0", VA = "0x18887A9D0")]
		public static SetResult YSLDBUCPLSI(this ZSUZLPYTZDD a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x887A880", Offset = "0x8879680", VA = "0x18887A880")]
		public static SetResult SGIYWJOUIFW(this ZSUZLPYTZDD a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x887A5C0", Offset = "0x88793C0", VA = "0x18887A5C0")]
		public static SetResult KZUOJDLGGSV(this ZSUZLPYTZDD a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x887A480", Offset = "0x8879280", VA = "0x18887A480")]
		public static SetResult HJPQWBTDDQO(this ZSUZLPYTZDD a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class EWRSTBIJFOS : FFEEMLFPXTQ, ZSUZLPYTZDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly YDLOTZZQUCP SGJWOBGAWMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, byte> NWPFFZXHCIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Dictionary<string, string> PKYUSKLFOAP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> EUSDSRNIAMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8873830", Offset = "0x8872630", VA = "0x188873830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OSGFYEKIHJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88751E0", Offset = "0x8873FE0", VA = "0x1888751E0")]
		[UnityEngine.Scripting.Preserve]
		public EWRSTBIJFOS([Inject(null)] YDLOTZZQUCP unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "8")]
		public void QHMEFFCKKKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8873A20", Offset = "0x8872820", VA = "0x188873A20")]
		private DirectoryInfo IWDHNNSLJPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8873E60", Offset = "0x8872C60", VA = "0x188873E60", Slot = "6")]
		public Task QUHRAYDNAEF(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8875000", Offset = "0x8873E00", VA = "0x188875000", Slot = "14")]
		public float ZBRXOSQDDKJ(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8875170", Offset = "0x8873F70", VA = "0x188875170", Slot = "13")]
		public void ZUGSAPWMBLL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8873870", Offset = "0x8872670", VA = "0x188873870", Slot = "12")]
		public bool FRRVSXYXABH(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8873B10", Offset = "0x8872910", VA = "0x188873B10", Slot = "10")]
		public int KMAFLQSQVVE(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8873940", Offset = "0x8872740", VA = "0x188873940", Slot = "18")]
		public DateTime HGLSRWKGRUI(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8874B80", Offset = "0x8873980", VA = "0x188874B80", Slot = "19")]
		public void VBMPAJHPJSA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88739B0", Offset = "0x88727B0", VA = "0x1888739B0", Slot = "15")]
		public void HVUDLARRIRD(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8873B80", Offset = "0x8872980", VA = "0x188873B80", Slot = "11")]
		public void MQWFAJQMPFQ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8874B10", Offset = "0x8873910", VA = "0x188874B10", Slot = "20")]
		public long USPSXOBHZNJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8873DF0", Offset = "0x8872BF0", VA = "0x188873DF0", Slot = "21")]
		public void PYPKPTYEEWX(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x36EF950", Offset = "0x36EE750", VA = "0x1836EF950", Slot = "22")]
		public a ZALEQZPHEOO<a>(string a, a b, MLGBGFQUWCP<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x36EF740", Offset = "0x36EE540", VA = "0x1836EF740", Slot = "23")]
		public void UDXTEMSBQTI<b>(string a, b b, MLGBGFQUWCP<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8873F80", Offset = "0x8872D80", VA = "0x188873F80", Slot = "16")]
		public string RLTBLLZRBWM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8874F90", Offset = "0x8873D90", VA = "0x188874F90", Slot = "17")]
		public void YBXDJLSWMKE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88736E0", Offset = "0x88724E0", VA = "0x1888736E0", Slot = "24")]
		public void ACGPSJHUBYX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8873EF0", Offset = "0x8872CF0", VA = "0x188873EF0", Slot = "9")]
		public bool RIXVYVKFGLG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88747D0", Offset = "0x88735D0", VA = "0x1888747D0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8874BF0", Offset = "0x88739F0", VA = "0x188874BF0")]
		private void XURTEDZPTNB(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8873BF0", Offset = "0x88729F0", VA = "0x188873BF0")]
		private static string MRZEVHXIIKS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8875070", Offset = "0x8873E70", VA = "0x188875070")]
		private static string ZNBXQOIDSHB(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x380CD70", Offset = "0x380BB70", VA = "0x18380CD70")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] MLGBGFQUWCP<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x380E340", Offset = "0x380D140", VA = "0x18380E340")]
		private void Set<T>(string propertyName, T value, [Optional] MLGBGFQUWCP<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8874030", Offset = "0x8872E30", VA = "0x188874030")]
		private Dictionary<string, string> SEWSHWMQALV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class HAHSMJUPRHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8875280", Offset = "0x8874080", VA = "0x188875280")]
		[XNELNNYDNRZ.Root]
		internal static void XNELNNYDNRZ(MQNVASDZCUX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SOSQVXXXTLX : BQIYLYPTLJS
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8873660", Offset = "0x8872460", VA = "0x188873660")]
		[UnityEngine.Scripting.Preserve]
		public SOSQVXXXTLX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BQIYLYPTLJS : FFEEMLFPXTQ, ZSUZLPYTZDD, IQKSUBZIUMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, object> FXNDSXQYNEM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action OSGFYEKIHJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "8")]
		public void QHMEFFCKKKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88732A0", Offset = "0x88720A0", VA = "0x1888732A0", Slot = "6")]
		public Task QUHRAYDNAEF(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8873330", Offset = "0x8872130", VA = "0x188873330", Slot = "9")]
		public bool RIXVYVKFGLG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8873180", Offset = "0x8871F80", VA = "0x188873180", Slot = "10")]
		public int KMAFLQSQVVE(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88731E0", Offset = "0x8871FE0", VA = "0x1888731E0", Slot = "11")]
		public void MQWFAJQMPFQ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8873060", Offset = "0x8871E60", VA = "0x188873060", Slot = "12")]
		public bool FRRVSXYXABH(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8873600", Offset = "0x8872400", VA = "0x188873600", Slot = "13")]
		public void ZUGSAPWMBLL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88735A0", Offset = "0x88723A0", VA = "0x1888735A0", Slot = "14")]
		public float ZBRXOSQDDKJ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8873120", Offset = "0x8871F20", VA = "0x188873120", Slot = "15")]
		public void HVUDLARRIRD(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8873390", Offset = "0x8872190", VA = "0x188873390", Slot = "16")]
		public string RLTBLLZRBWM(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8873540", Offset = "0x8872340", VA = "0x188873540", Slot = "17")]
		public void YBXDJLSWMKE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88730C0", Offset = "0x8871EC0", VA = "0x1888730C0", Slot = "18")]
		public DateTime HGLSRWKGRUI(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88734E0", Offset = "0x88722E0", VA = "0x1888734E0", Slot = "19")]
		public void VBMPAJHPJSA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8873480", Offset = "0x8872280", VA = "0x188873480", Slot = "20")]
		public long USPSXOBHZNJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8873240", Offset = "0x8872040", VA = "0x188873240", Slot = "21")]
		public void PYPKPTYEEWX(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x362E250", Offset = "0x362D050", VA = "0x18362E250", Slot = "22")]
		public a ZALEQZPHEOO<a>(string a, a b, MLGBGFQUWCP<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x362DFF0", Offset = "0x362CDF0", VA = "0x18362DFF0", Slot = "23")]
		public void UDXTEMSBQTI<b>(string a, b b, MLGBGFQUWCP<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x362CFF0", Offset = "0x362BDF0", VA = "0x18362CFF0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x362DA40", Offset = "0x362C840", VA = "0x18362DA40")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8873000", Offset = "0x8871E00", VA = "0x188873000", Slot = "24")]
		public void ACGPSJHUBYX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88733F0", Offset = "0x88721F0", VA = "0x1888733F0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8873660", Offset = "0x8872460", VA = "0x188873660")]
		public BQIYLYPTLJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class AMQCSGDGTCH<a> where a : ZSUZLPYTZDD
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly HashSet<AMQCSGDGTCH<a>> PFALOAWRDDO;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x558B020", Offset = "0x5589E20", VA = "0x18558B020")]
		protected AMQCSGDGTCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void ILHUOCQTVXF(string a);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x558AB80", Offset = "0x5589980", VA = "0x18558AB80")]
		public static void LDPRKKRILLF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x558A450", Offset = "0x5589250", VA = "0x18558A450")]
		public static void BRVICTDOPXB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AMVJPMXECNQ<a, b> : AMQCSGDGTCH<a> where a : ZSUZLPYTZDD
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly AMVJPMXECNQ<a, b> SNTFEPMFQUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, b> MLINMVSLIDV;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5623630", Offset = "0x5622430", VA = "0x185623630")]
		public bool HHYTRHIEAWJ(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x56237A0", Offset = "0x56225A0", VA = "0x1856237A0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x56234C0", Offset = "0x56222C0", VA = "0x1856234C0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x56236C0", Offset = "0x56224C0", VA = "0x1856236C0", Slot = "5")]
		protected override void ILHUOCQTVXF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5623CC0", Offset = "0x5622AC0", VA = "0x185623CC0")]
		public AMVJPMXECNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ZSUZLPYTZDD
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QHMEFFCKKKV();

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RIXVYVKFGLG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int KMAFLQSQVVE(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MQWFAJQMPFQ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool FRRVSXYXABH(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZUGSAPWMBLL(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float ZBRXOSQDDKJ(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void HVUDLARRIRD(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string RLTBLLZRBWM(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YBXDJLSWMKE(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime HGLSRWKGRUI(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void VBMPAJHPJSA(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long USPSXOBHZNJ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PYPKPTYEEWX(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a ZALEQZPHEOO<a>(string a, a b, MLGBGFQUWCP<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void UDXTEMSBQTI<b>(string a, b b, MLGBGFQUWCP<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ACGPSJHUBYX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface FFEEMLFPXTQ : ZSUZLPYTZDD
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action OSGFYEKIHJX;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task QUHRAYDNAEF(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IQKSUBZIUMM : ZSUZLPYTZDD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class YWVQSOOGJLY : FFEEMLFPXTQ, ZSUZLPYTZDD
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
			public YWVQSOOGJLY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x887B390", Offset = "0x887A190", VA = "0x18887B390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x887B760", Offset = "0x887A560", VA = "0x18887B760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HIJHUICVKRP : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public YWVQSOOGJLY SVDPBWSVAHX;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public HIJHUICVKRP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8875420", Offset = "0x8874220", VA = "0x188875420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x88753E0", Offset = "0x88741E0", VA = "0x1888753E0", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly YDLOTZZQUCP SGJWOBGAWMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool GRIXACXFWIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool HTDDERNTZYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private WNUSNYDCKEP AVTSRNMEBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private RYHDNSZFVTC WAMUVECBFSS;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OSGFYEKIHJX
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x887C230", Offset = "0x887B030", VA = "0x18887C230")]
		[UnityEngine.Scripting.Preserve]
		public YWVQSOOGJLY([Inject(null)] YDLOTZZQUCP unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "8")]
		public void QHMEFFCKKKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x887BE60", Offset = "0x887AC60", VA = "0x18887BE60", Slot = "6")]
		public Task QUHRAYDNAEF(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E88660", Offset = "0x1E87460", VA = "0x181E88660")]
		private static int ZQEIIHFURMH(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x887BEF0", Offset = "0x887ACF0", VA = "0x18887BEF0", Slot = "9")]
		public bool RIXVYVKFGLG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x887BD90", Offset = "0x887AB90", VA = "0x18887BD90", Slot = "10")]
		public int KMAFLQSQVVE(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x887BDC0", Offset = "0x887ABC0", VA = "0x18887BDC0", Slot = "11")]
		public void MQWFAJQMPFQ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x887BC50", Offset = "0x887AA50", VA = "0x18887BC50", Slot = "12")]
		public bool FRRVSXYXABH(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x887C200", Offset = "0x887B000", VA = "0x18887C200", Slot = "13")]
		public void ZUGSAPWMBLL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x887C1D0", Offset = "0x887AFD0", VA = "0x18887C1D0", Slot = "14")]
		public float ZBRXOSQDDKJ(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x887BD60", Offset = "0x887AB60", VA = "0x18887BD60", Slot = "15")]
		public void HVUDLARRIRD(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x887BCF0", Offset = "0x887AAF0", VA = "0x18887BCF0", Slot = "18")]
		public DateTime HGLSRWKGRUI(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x887C110", Offset = "0x887AF10", VA = "0x18887C110", Slot = "19")]
		public void VBMPAJHPJSA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x887C0A0", Offset = "0x887AEA0", VA = "0x18887C0A0", Slot = "20")]
		public long USPSXOBHZNJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x887BDF0", Offset = "0x887ABF0", VA = "0x18887BDF0", Slot = "21")]
		public void PYPKPTYEEWX(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6430", Offset = "0x3EF5230", VA = "0x183EF6430", Slot = "22")]
		public a ZALEQZPHEOO<a>(string a, a b, MLGBGFQUWCP<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF61F0", Offset = "0x3EF4FF0", VA = "0x183EF61F0", Slot = "23")]
		public void UDXTEMSBQTI<b>(string a, b b, MLGBGFQUWCP<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3EF49A0", Offset = "0x3EF37A0", VA = "0x183EF49A0")]
		private c LYDCAKFBKHR<c>(string a, c b, [Optional] MLGBGFQUWCP<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5840", Offset = "0x3EF4640", VA = "0x183EF5840")]
		private void SVFVYHGGUZZ<d>(string a, d b, [Optional] MLGBGFQUWCP<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x887BF10", Offset = "0x887AD10", VA = "0x18887BF10", Slot = "16")]
		public string RLTBLLZRBWM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x887C1A0", Offset = "0x887AFA0", VA = "0x18887C1A0", Slot = "17")]
		public void YBXDJLSWMKE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x887C180", Offset = "0x887AF80", VA = "0x18887C180")]
		private void XBYENZMNNGR(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x887BAC0", Offset = "0x887A8C0", VA = "0x18887BAC0")]
		private string BBCMURUOKSB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x887BA30", Offset = "0x887A830", VA = "0x18887BA30", Slot = "24")]
		public void ACGPSJHUBYX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x887BB50", Offset = "0x887A950", VA = "0x18887BB50")]
		private string CZGNKEKZPZF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x887BFB0", Offset = "0x887ADB0", VA = "0x18887BFB0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x887BF40", Offset = "0x887AD40", VA = "0x18887BF40")]
		[IteratorStateMachine(typeof(HIJHUICVKRP))]
		private IEnumerator<XTKXCVTPKYX> RVCTWORHYRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x887BBF0", Offset = "0x887A9F0", VA = "0x18887BBF0")]
		private void DZNTIKSIIPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x887BAE0", Offset = "0x887A8E0", VA = "0x18887BAE0")]
		private void BRAFCLAZSLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x887BC80", Offset = "0x887AA80", VA = "0x18887BC80")]
		private void GEKHITJJXDC(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JRDFILYDTMY : FFEEMLFPXTQ, ZSUZLPYTZDD
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
		private Dictionary<string, string> PKYUSKLFOAP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string VTVZRHPQXJS
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8876190", Offset = "0x8874F90", VA = "0x188876190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string DRKRRBXVTXU
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8875890", Offset = "0x8874690", VA = "0x188875890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Dictionary<string, string> EUSDSRNIAMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8875550", Offset = "0x8874350", VA = "0x188875550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OSGFYEKIHJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		[UnityEngine.Scripting.Preserve]
		public JRDFILYDTMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "8")]
		public void QHMEFFCKKKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8875920", Offset = "0x8874720", VA = "0x188875920", Slot = "6")]
		public Task QUHRAYDNAEF(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8876220", Offset = "0x8875020", VA = "0x188876220", Slot = "14")]
		public float ZBRXOSQDDKJ(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8876290", Offset = "0x8875090", VA = "0x188876290", Slot = "13")]
		public void ZUGSAPWMBLL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8875590", Offset = "0x8874390", VA = "0x188875590", Slot = "12")]
		public bool FRRVSXYXABH(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8875740", Offset = "0x8874540", VA = "0x188875740", Slot = "10")]
		public int KMAFLQSQVVE(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8875660", Offset = "0x8874460", VA = "0x188875660", Slot = "18")]
		public DateTime HGLSRWKGRUI(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8876080", Offset = "0x8874E80", VA = "0x188876080", Slot = "19")]
		public void VBMPAJHPJSA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88756D0", Offset = "0x88744D0", VA = "0x1888756D0", Slot = "15")]
		public void HVUDLARRIRD(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x88757B0", Offset = "0x88745B0", VA = "0x1888757B0", Slot = "11")]
		public void MQWFAJQMPFQ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8876010", Offset = "0x8874E10", VA = "0x188876010", Slot = "20")]
		public long USPSXOBHZNJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8875820", Offset = "0x8874620", VA = "0x188875820", Slot = "21")]
		public void PYPKPTYEEWX(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x36EF950", Offset = "0x36EE750", VA = "0x1836EF950", Slot = "22")]
		public a ZALEQZPHEOO<a>(string a, a b, MLGBGFQUWCP<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x36EF740", Offset = "0x36EE540", VA = "0x1836EF740", Slot = "23")]
		public void UDXTEMSBQTI<b>(string a, b b, MLGBGFQUWCP<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8875A40", Offset = "0x8874840", VA = "0x188875A40", Slot = "16")]
		public string RLTBLLZRBWM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x88760F0", Offset = "0x8874EF0", VA = "0x1888760F0", Slot = "17")]
		public void YBXDJLSWMKE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8875490", Offset = "0x8874290", VA = "0x188875490", Slot = "24")]
		public void ACGPSJHUBYX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x88759B0", Offset = "0x88747B0", VA = "0x1888759B0", Slot = "9")]
		public bool RIXVYVKFGLG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8875DB0", Offset = "0x8874BB0", VA = "0x188875DB0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3987730", Offset = "0x3986530", VA = "0x183987730")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] MLGBGFQUWCP<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3988D00", Offset = "0x3987B00", VA = "0x183988D00")]
		private void Set<T>(string propertyName, T value, [Optional] MLGBGFQUWCP<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8875AF0", Offset = "0x88748F0", VA = "0x188875AF0")]
		private Dictionary<string, string> SEWSHWMQALV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface TFFUOHKAKFW
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action OSGFYEKIHJX;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QHMEFFCKKKV();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task HPSUVBGHBNB(long a);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool VKLMBFTIVGX(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool EIMYELSJAAL(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool BBUCMHQIFFE(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string IMJRMOKPAHT(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult HSOJKNZPTCF(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int PMTVZSGXINP(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult SNFCAEFLRQJ(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TUVGGJETNYM(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult MHSQIHUEGBC(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float KVPZILFHLXY(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult RTZNWZQHQZM(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime RMDQJZIPKFL(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult MNSBHOFGCMB(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long NPTPTNWNRDM(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult EDDVRWUFHRM(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a DVWPMYWSYSH<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult NZEFRQLVOEH<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool SBHFTPEGGBB(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool HAAWVGOQDOU(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string TVLLVZFORHX(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult HMAAEZNLYMN(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int WBMLVUGNHHP(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult JAIORJZIQOZ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool BBBVNHGLGPC(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult GSMPZIJDKSQ(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float YSMNIASCZOS(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult WNCAZUWAJAK(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime OPAVHFPFJMJ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult DVMIMEBXQON(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long IEWTWXJUDRA(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult ZXKCURDLNWS(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void YAECTVDAXTH<e>(MLGBGFQUWCP<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void UUBLRWNINLQ<f>();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable KSQVSBSVTLZ();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void FSHGQARXYQE(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task DZNTIKSIIPV([Optional] CancellationToken a);
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
	public class Preferences : TFFUOHKAKFW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private abstract class MSOXATVBLUK
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			protected static readonly HashSet<MSOXATVBLUK> YPQKSOJNXIJ;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8876BC0", Offset = "0x88759C0", VA = "0x188876BC0")]
			public static void BRVICTDOPXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			protected MSOXATVBLUK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private class QAJJNHOQHAN<a> : MSOXATVBLUK
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly QAJJNHOQHAN<a> VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public MLGBGFQUWCP<a> RKAIRQKZJTG
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IEqualityComparer<a> CZTRPXPPWKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool KSOLIYHDLJJ
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x5CFA080", Offset = "0x5CF8E80", VA = "0x185CFA080")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5CFA3D0", Offset = "0x5CF91D0", VA = "0x185CFA3D0")]
			private QAJJNHOQHAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x5CF9F50", Offset = "0x5CF8D50", VA = "0x185CF9F50")]
			public void IPFDCTVTWHM(MLGBGFQUWCP<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5CF9B80", Offset = "0x5CF8980", VA = "0x185CF9B80", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class NMRIQIRQJYO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private readonly Preferences HFIRYMQICVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly object JFAOMBFNHAZ;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8876DC0", Offset = "0x8875BC0", VA = "0x188876DC0")]
			public NMRIQIRQJYO(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8876D90", Offset = "0x8875B90", VA = "0x188876D90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887AB20", Offset = "0x8879920", VA = "0x18887AB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x887AE00", Offset = "0x8879C00", VA = "0x18887AE00", Slot = "5")]
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
			public ZSUZLPYTZDD backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x887B7C0", Offset = "0x887A5C0", VA = "0x18887B7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x887AE60", Offset = "0x8879C60", VA = "0x18887AE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x887B330", Offset = "0x887A130", VA = "0x18887B330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class RPXDOIJOBYU : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Preferences SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float DJKYQCPOSTW;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public RPXDOIJOBYU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x887A0D0", Offset = "0x8878ED0", VA = "0x18887A0D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x887A090", Offset = "0x8878E90", VA = "0x18887A090", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly FFEEMLFPXTQ NIZTTREUTEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly FFEEMLFPXTQ SPRPJXVZLDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly IQKSUBZIUMM OSQFDFHZMMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly WNUSNYDCKEP AVTSRNMEBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly TABUXMOXBMT.CustomSaveHandler HDGKDNYVVOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly NTWXEAAFYGD BATICBFPHLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<ZSUZLPYTZDD> SECBXQZOVWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task FGNHEBLDUIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<string, string> QICBGVAYGHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private RYHDNSZFVTC HDZBMKZIJQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly object SNVFECEEYWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly object NNWPOAGABHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private long KQKCXGMVXBD;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool UVOARKKVPJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1A92450", Offset = "0x1A91250", VA = "0x181A92450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CancellationTokenSource WMKVZCPWLRS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA19B0", Offset = "0xAA07B0", VA = "0x180AA19B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OSGFYEKIHJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x88780B0", Offset = "0x8876EB0", VA = "0x1888780B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8878800", Offset = "0x8877600", VA = "0x188878800", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8879070", Offset = "0x8877E70", VA = "0x188879070")]
		[XNELNNYDNRZ.Root]
		internal static void RZIXSWHMNAI(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8879D00", Offset = "0x8878B00", VA = "0x188879D00")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] FFEEMLFPXTQ localBackingStore, [Inject("Cloud")] FFEEMLFPXTQ cloudBackingStore, [Inject(null)] IQKSUBZIUMM editorBackingStore, [Inject(null)] WNUSNYDCKEP scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x88773C0", Offset = "0x88761C0", VA = "0x1888773C0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8878D90", Offset = "0x8877B90", VA = "0x188878D90")]
		private void PYLVYEUILED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8878DE0", Offset = "0x8877BE0", VA = "0x188878DE0", Slot = "6")]
		public void QHMEFFCKKKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8877B00", Offset = "0x8876900", VA = "0x188877B00", Slot = "7")]
		public Task HPSUVBGHBNB(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8877620", Offset = "0x8876420", VA = "0x188877620")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task FAHMCIDMAIA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x88778B0", Offset = "0x88766B0", VA = "0x1888778B0")]
		private void GJXQUTBTYQV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8877250", Offset = "0x8876050", VA = "0x188877250")]
		private void DZEBIVVKBAE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8879C00", Offset = "0x8878A00", VA = "0x188879C00")]
		private string WOEOWWPDDNB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8878660", Offset = "0x8877460", VA = "0x188878660")]
		private void LWPTOHVDGKH(AccountPreferenceBackingStoreTypes a, string b, [Out] FFEEMLFPXTQ c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8877A50", Offset = "0x8876850", VA = "0x188877A50")]
		private FFEEMLFPXTQ HKPHZSWEJWL(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8879AB0", Offset = "0x88788B0", VA = "0x188879AB0", Slot = "8")]
		public bool VKLMBFTIVGX(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8877580", Offset = "0x8876380", VA = "0x188877580", Slot = "9")]
		public bool EIMYELSJAAL(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x88770A0", Offset = "0x8875EA0", VA = "0x1888770A0", Slot = "10")]
		public bool BBUCMHQIFFE(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8878150", Offset = "0x8876F50", VA = "0x188878150", Slot = "11")]
		public string IMJRMOKPAHT(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8877CD0", Offset = "0x8876AD0", VA = "0x188877CD0", Slot = "12")]
		public SetResult HSOJKNZPTCF(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8878CE0", Offset = "0x8877AE0", VA = "0x188878CE0", Slot = "13")]
		public int PMTVZSGXINP(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x88791A0", Offset = "0x8877FA0", VA = "0x1888791A0", Slot = "14")]
		public SetResult SNFCAEFLRQJ(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8879990", Offset = "0x8878790", VA = "0x188879990", Slot = "15")]
		public bool TUVGGJETNYM(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x88788A0", Offset = "0x88776A0", VA = "0x1888788A0", Slot = "16")]
		public SetResult MHSQIHUEGBC(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x88785B0", Offset = "0x88773B0", VA = "0x1888785B0", Slot = "17")]
		public float KVPZILFHLXY(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8878EF0", Offset = "0x8877CF0", VA = "0x188878EF0", Slot = "18")]
		public SetResult RTZNWZQHQZM(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8878E50", Offset = "0x8877C50", VA = "0x188878E50", Slot = "19")]
		public DateTime RMDQJZIPKFL(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8878A20", Offset = "0x8877820", VA = "0x188878A20", Slot = "20")]
		public SetResult MNSBHOFGCMB(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8878BD0", Offset = "0x88779D0", VA = "0x188878BD0", Slot = "21")]
		public long NPTPTNWNRDM(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8877400", Offset = "0x8876200", VA = "0x188877400", Slot = "22")]
		public SetResult EDDVRWUFHRM(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3BC91B0", Offset = "0x3BC7FB0", VA = "0x183BC91B0", Slot = "23")]
		public a DVWPMYWSYSH<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3BC9730", Offset = "0x3BC8530", VA = "0x183BC9730", Slot = "24")]
		public SetResult NZEFRQLVOEH<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x88790E0", Offset = "0x8877EE0", VA = "0x1888790E0", Slot = "25")]
		public bool SBHFTPEGGBB(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8877A40", Offset = "0x8876840", VA = "0x188877A40", Slot = "26")]
		public bool HAAWVGOQDOU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8879A40", Offset = "0x8878840", VA = "0x188879A40", Slot = "27")]
		public string TVLLVZFORHX(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8877AD0", Offset = "0x88768D0", VA = "0x188877AD0", Slot = "28")]
		public SetResult HMAAEZNLYMN(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8879B60", Offset = "0x8878960", VA = "0x188879B60", Slot = "29")]
		public int WBMLVUGNHHP(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8878360", Offset = "0x8877160", VA = "0x188878360", Slot = "30")]
		public SetResult JAIORJZIQOZ(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8877030", Offset = "0x8875E30", VA = "0x188877030", Slot = "31")]
		public bool BBBVNHGLGPC(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x88778D0", Offset = "0x88766D0", VA = "0x1888778D0", Slot = "32")]
		public SetResult GSMPZIJDKSQ(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8879C60", Offset = "0x8878A60", VA = "0x188879C60", Slot = "33")]
		public float YSMNIASCZOS(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8879BD0", Offset = "0x88789D0", VA = "0x188879BD0", Slot = "34")]
		public SetResult WNCAZUWAJAK(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8878C70", Offset = "0x8877A70", VA = "0x188878C70", Slot = "35")]
		public DateTime OPAVHFPFJMJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8877220", Offset = "0x8876020", VA = "0x188877220", Slot = "36")]
		public SetResult DVMIMEBXQON(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8878040", Offset = "0x8876E40", VA = "0x188878040", Slot = "37")]
		public long IEWTWXJUDRA(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8879CD0", Offset = "0x8878AD0", VA = "0x188879CD0", Slot = "38")]
		public SetResult ZXKCURDLNWS(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8879140", Offset = "0x8877F40", VA = "0x188879140")]
		private bool SITQZHGAEQN(ZSUZLPYTZDD a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8879320", Offset = "0x8878120", VA = "0x188879320")]
		private bool STDUIMEMQSY(ZSUZLPYTZDD a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8879550", Offset = "0x8878350", VA = "0x188879550")]
		private SetResult THNVBXJOBHG(ZSUZLPYTZDD a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8877900", Offset = "0x8876700", VA = "0x188877900")]
		private SetResult GSPFALMLSGK(ZSUZLPYTZDD a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8877770", Offset = "0x8876570", VA = "0x188877770")]
		private SetResult GHNCSJSVFIR(ZSUZLPYTZDD a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8878390", Offset = "0x8877190", VA = "0x188878390")]
		private SetResult KBFFEETPFZP(ZSUZLPYTZDD a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x88781F0", Offset = "0x8876FF0", VA = "0x1888781F0")]
		private SetResult IPMXWPJPOQI(ZSUZLPYTZDD a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8876EF0", Offset = "0x8875CF0", VA = "0x188876EF0")]
		private SetResult AIIKHCWFKLN(ZSUZLPYTZDD a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8C60", Offset = "0x3BC7A60", VA = "0x183BC8C60")]
		private e DHIVLSXDMXU<e>(ZSUZLPYTZDD a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3BC9A70", Offset = "0x3BC8870", VA = "0x183BC9A70")]
		private SetResult XHQGBIMTSOK<f>(ZSUZLPYTZDD a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA6C0", Offset = "0x3BC94C0", VA = "0x183BCA6C0", Slot = "39")]
		public void YAECTVDAXTH<g>(MLGBGFQUWCP<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC99E0", Offset = "0x3BC87E0", VA = "0x183BC99E0", Slot = "40")]
		public void UUBLRWNINLQ<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8879480", Offset = "0x8878280", VA = "0x188879480")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(ZSUZLPYTZDD backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x88772D0", Offset = "0x88760D0", VA = "0x1888772D0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task DZNTIKSIIPV([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8877E60", Offset = "0x8876C60", VA = "0x188877E60")]
		private void IDWKETJYOFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x88784E0", Offset = "0x88772E0", VA = "0x1888784E0", Slot = "41")]
		public IDisposable KSQVSBSVTLZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8877730", Offset = "0x8876530", VA = "0x188877730", Slot = "42")]
		public void FSHGQARXYQE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x88796A0", Offset = "0x88784A0", VA = "0x1888796A0")]
		private void TKTSOBAQKMY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8879910", Offset = "0x8878710", VA = "0x188879910")]
		[IteratorStateMachine(typeof(RPXDOIJOBYU))]
		private IEnumerator<XTKXCVTPKYX> TLDQBBKXSHU(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8877740", Offset = "0x8876540", VA = "0x188877740")]
		[CompilerGenerated]
		private void FXGWTTZEDOR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class MQDFPXTNYSS
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x88768A0", Offset = "0x88756A0", VA = "0x1888768A0")]
		public static string LVLJLRKRTAR(this TFFUOHKAKFW a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8876A10", Offset = "0x8875810", VA = "0x188876A10")]
		public static byte[] OUGJNZDNMOP(this TFFUOHKAKFW a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8876790", Offset = "0x8875590", VA = "0x188876790")]
		public static SetResult IHHZFYLWPID(this TFFUOHKAKFW a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class LGEBUJTAIAP : GWIWWXKWCSX<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static LGEBUJTAIAP VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8876580", Offset = "0x8875380", VA = "0x188876580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x88765D0", Offset = "0x88753D0", VA = "0x1888765D0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8876300", Offset = "0x8875100", VA = "0x188876300", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8876750", Offset = "0x8875550", VA = "0x188876750")]
		public LGEBUJTAIAP()
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
