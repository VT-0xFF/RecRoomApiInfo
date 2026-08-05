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
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x8917860", Offset = "0x8916660", VA = "0x188917860")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8917760", Offset = "0x8916560", VA = "0x188917760", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x891E860", Offset = "0x891D660", VA = "0x18891E860", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Preferences
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AccountPreferenceBackingStoreTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CLOUD,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		DISK
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class PBJRSEFGKAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(TJYNFXDVXDS backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89190F0", Offset = "0x8917EF0", VA = "0x1889190F0")]
		private static void XEQEAMEQPZV(TJYNFXDVXDS a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8918B90", Offset = "0x8917990", VA = "0x188918B90")]
		public static bool LGRPSTDKYZT(this TJYNFXDVXDS a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8918900", Offset = "0x8917700", VA = "0x188918900")]
		public static SetResult KCKEMMYUIBK(this TJYNFXDVXDS a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8918A50", Offset = "0x8917850", VA = "0x188918A50")]
		public static SetResult KZEMHOZYDVO(this TJYNFXDVXDS a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89187C0", Offset = "0x89175C0", VA = "0x1889187C0")]
		public static SetResult IASHPOFJVDP(this TJYNFXDVXDS a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8918E60", Offset = "0x8917C60", VA = "0x188918E60")]
		public static SetResult PWWFGTVCBYD(this TJYNFXDVXDS a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8918CF0", Offset = "0x8917AF0", VA = "0x188918CF0")]
		public static SetResult NJRGYCNUBJS(this TJYNFXDVXDS a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8918FB0", Offset = "0x8917DB0", VA = "0x188918FB0")]
		public static SetResult UZTPQDWQPUH(this TJYNFXDVXDS a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class INJZRJQMWHX : HAZDFAKKFFT, TJYNFXDVXDS
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log LWDSNBKPQHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ISFELIJWYUE DWRLVWIXTCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> VAIUULQMNMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> RUKEFABTPSA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> EWVMXUCHIES
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8913AE0", Offset = "0x89128E0", VA = "0x188913AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action RUENXCKVSBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8914450", Offset = "0x8913250", VA = "0x188914450")]
		[UnityEngine.Scripting.Preserve]
		public INJZRJQMWHX([Inject(null)] ISFELIJWYUE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "8")]
		public void RPJGEDVAPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x89121C0", Offset = "0x8910FC0", VA = "0x1889121C0")]
		private DirectoryInfo COBBFZFOKJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8912130", Offset = "0x8910F30", VA = "0x188912130", Slot = "6")]
		public Task CNQOYIKJSMI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89122B0", Offset = "0x89110B0", VA = "0x1889122B0", Slot = "14")]
		public float FMSENFPRTOW(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8912320", Offset = "0x8911120", VA = "0x188912320", Slot = "13")]
		public void GKCIRPGFEYQ(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89140F0", Offset = "0x8912EF0", VA = "0x1889140F0", Slot = "12")]
		public bool YAPATREBKPW(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8912390", Offset = "0x8911190", VA = "0x188912390", Slot = "10")]
		public int GQEEKBEZGCZ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8913BD0", Offset = "0x89129D0", VA = "0x188913BD0", Slot = "18")]
		public DateTime RZYNLGIFBGB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8912640", Offset = "0x8911440", VA = "0x188912640", Slot = "19")]
		public void LIQWMCAZGDP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8913430", Offset = "0x8912230", VA = "0x188913430", Slot = "15")]
		public void MRKPAPHBQES(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8913FF0", Offset = "0x8912DF0", VA = "0x188913FF0", Slot = "11")]
		public void TWJVUMNFURH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8913F80", Offset = "0x8912D80", VA = "0x188913F80", Slot = "20")]
		public long TBNLXKZRVNE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8912460", Offset = "0x8911260", VA = "0x188912460", Slot = "21")]
		public void IRAWYIKHQYO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37DEFA0", Offset = "0x37DDDA0", VA = "0x1837DEFA0", Slot = "22")]
		public a JJJEGSQSVID<a>(string a, a b, XJDIQSDJBRI<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x37DF180", Offset = "0x37DDF80", VA = "0x1837DF180", Slot = "23")]
		public void LDSIPOZFOPF<b>(string a, b b, XJDIQSDJBRI<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8913B20", Offset = "0x8912920", VA = "0x188913B20", Slot = "16")]
		public string QJWYOJSOHIZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8911F50", Offset = "0x8910D50", VA = "0x188911F50", Slot = "17")]
		public void ATPXCBPSNUV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8911FC0", Offset = "0x8910DC0", VA = "0x188911FC0", Slot = "24")]
		public void CKVCRSPLILE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8914060", Offset = "0x8912E60", VA = "0x188914060", Slot = "9")]
		public bool WOFCNRDZEQX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8913C40", Offset = "0x8912A40", VA = "0x188913C40", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89134A0", Offset = "0x89122A0", VA = "0x1889134A0")]
		private void NCEEHCZMEXM(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x89141C0", Offset = "0x8912FC0", VA = "0x1889141C0")]
		private static string ZFGXTGXCBJR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8912540", Offset = "0x8911340", VA = "0x188912540")]
		private static string JYBFNZPWWOQ(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37DD830", Offset = "0x37DC630", VA = "0x1837DD830")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XJDIQSDJBRI<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37DF320", Offset = "0x37DE120", VA = "0x1837DF320")]
		private void Set<T>(string propertyName, T value, [Optional] XJDIQSDJBRI<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89126B0", Offset = "0x89114B0", VA = "0x1889126B0")]
		private Dictionary<string, string> MDZYFFDADUS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8912400", Offset = "0x8911200", VA = "0x188912400")]
		private void ILPWSCGITPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89124D0", Offset = "0x89112D0", VA = "0x1889124D0")]
		private void JFBTLWVWMXP(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class GJRXIZHYRLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log LWDSNBKPQHM;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8911D10", Offset = "0x8910B10", VA = "0x188911D10")]
		[AUEAKLYJEMA.Root]
		internal static void AUEAKLYJEMA(TNEKCCANHHI a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class VLGGPHIYKRY : TVLUKIPLFUT
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x891CA90", Offset = "0x891B890", VA = "0x18891CA90")]
		[UnityEngine.Scripting.Preserve]
		public VLGGPHIYKRY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class BYOMASAEUKM : HAZDFAKKFFT, TJYNFXDVXDS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly ISFELIJWYUE DWRLVWIXTCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> ZTZTXMGDLKK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action RUENXCKVSBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8911C70", Offset = "0x8910A70", VA = "0x188911C70")]
		[UnityEngine.Scripting.Preserve]
		public BYOMASAEUKM([Inject(null)] ISFELIJWYUE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8911610", Offset = "0x8910410", VA = "0x188911610", Slot = "6")]
		public Task CNQOYIKJSMI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "8")]
		public void RPJGEDVAPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8911BA0", Offset = "0x89109A0", VA = "0x188911BA0", Slot = "9")]
		public bool WOFCNRDZEQX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8911780", Offset = "0x8910580", VA = "0x188911780", Slot = "10")]
		public int GQEEKBEZGCZ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8911B30", Offset = "0x8910930", VA = "0x188911B30", Slot = "11")]
		public void TWJVUMNFURH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8911C00", Offset = "0x8910A00", VA = "0x188911C00", Slot = "12")]
		public bool YAPATREBKPW(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8911710", Offset = "0x8910510", VA = "0x188911710", Slot = "13")]
		public void GKCIRPGFEYQ(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89116A0", Offset = "0x89104A0", VA = "0x1889116A0", Slot = "14")]
		public float FMSENFPRTOW(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89118D0", Offset = "0x89106D0", VA = "0x1889118D0", Slot = "15")]
		public void MRKPAPHBQES(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8911940", Offset = "0x8910740", VA = "0x188911940", Slot = "16")]
		public string QJWYOJSOHIZ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8911510", Offset = "0x8910310", VA = "0x188911510", Slot = "17")]
		public void ATPXCBPSNUV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89119C0", Offset = "0x89107C0", VA = "0x1889119C0", Slot = "18")]
		public DateTime RZYNLGIFBGB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8911860", Offset = "0x8910660", VA = "0x188911860", Slot = "19")]
		public void LIQWMCAZGDP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8911AC0", Offset = "0x89108C0", VA = "0x188911AC0", Slot = "20")]
		public long TBNLXKZRVNE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x89117F0", Offset = "0x89105F0", VA = "0x1889117F0", Slot = "21")]
		public void IRAWYIKHQYO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3459500", Offset = "0x3458300", VA = "0x183459500", Slot = "22")]
		public a JJJEGSQSVID<a>(string a, a b, XJDIQSDJBRI<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x34597D0", Offset = "0x34585D0", VA = "0x1834597D0", Slot = "23")]
		public void LDSIPOZFOPF<b>(string a, b b, XJDIQSDJBRI<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8911580", Offset = "0x8910380", VA = "0x188911580", Slot = "24")]
		public void CKVCRSPLILE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8911A30", Offset = "0x8910830", VA = "0x188911A30", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3457BF0", Offset = "0x34569F0", VA = "0x183457BF0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XJDIQSDJBRI<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3459970", Offset = "0x3458770", VA = "0x183459970")]
		private void Set<T>(string propertyName, T value, [Optional] XJDIQSDJBRI<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class TVLUKIPLFUT : HAZDFAKKFFT, TJYNFXDVXDS, VLGCKDYVRAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> LCRAHUAQQRP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action RUENXCKVSBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "8")]
		public void RPJGEDVAPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x891C4F0", Offset = "0x891B2F0", VA = "0x18891C4F0", Slot = "6")]
		public Task CNQOYIKJSMI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x891C9D0", Offset = "0x891B7D0", VA = "0x18891C9D0", Slot = "9")]
		public bool WOFCNRDZEQX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x891C640", Offset = "0x891B440", VA = "0x18891C640", Slot = "10")]
		public int GQEEKBEZGCZ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x891C970", Offset = "0x891B770", VA = "0x18891C970", Slot = "11")]
		public void TWJVUMNFURH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x891CA30", Offset = "0x891B830", VA = "0x18891CA30", Slot = "12")]
		public bool YAPATREBKPW(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x891C5E0", Offset = "0x891B3E0", VA = "0x18891C5E0", Slot = "13")]
		public void GKCIRPGFEYQ(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x891C580", Offset = "0x891B380", VA = "0x18891C580", Slot = "14")]
		public float FMSENFPRTOW(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x891C760", Offset = "0x891B560", VA = "0x18891C760", Slot = "15")]
		public void MRKPAPHBQES(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x891C7C0", Offset = "0x891B5C0", VA = "0x18891C7C0", Slot = "16")]
		public string QJWYOJSOHIZ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x891C430", Offset = "0x891B230", VA = "0x18891C430", Slot = "17")]
		public void ATPXCBPSNUV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x891C820", Offset = "0x891B620", VA = "0x18891C820", Slot = "18")]
		public DateTime RZYNLGIFBGB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x891C700", Offset = "0x891B500", VA = "0x18891C700", Slot = "19")]
		public void LIQWMCAZGDP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x891C910", Offset = "0x891B710", VA = "0x18891C910", Slot = "20")]
		public long TBNLXKZRVNE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x891C6A0", Offset = "0x891B4A0", VA = "0x18891C6A0", Slot = "21")]
		public void IRAWYIKHQYO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B3D770", Offset = "0x3B3C570", VA = "0x183B3D770", Slot = "22")]
		public a JJJEGSQSVID<a>(string a, a b, XJDIQSDJBRI<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3B3DC00", Offset = "0x3B3CA00", VA = "0x183B3DC00", Slot = "23")]
		public void LDSIPOZFOPF<b>(string a, b b, XJDIQSDJBRI<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3B3CC00", Offset = "0x3B3BA00", VA = "0x183B3CC00")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3B3DE00", Offset = "0x3B3CC00", VA = "0x183B3DE00")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x891C490", Offset = "0x891B290", VA = "0x18891C490", Slot = "24")]
		public void CKVCRSPLILE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x891C880", Offset = "0x891B680", VA = "0x18891C880", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x891CA90", Offset = "0x891B890", VA = "0x18891CA90")]
		public TVLUKIPLFUT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class NQOWCCXVLPU<a> where a : TJYNFXDVXDS
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<NQOWCCXVLPU<a>> CGILTLTKTTJ;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x59FA530", Offset = "0x59F9330", VA = "0x1859FA530")]
		protected NQOWCCXVLPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void TURZNWLSOWK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x59F98A0", Offset = "0x59F86A0", VA = "0x1859F98A0")]
		public static void TYDWERXOKIE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x59FA050", Offset = "0x59F8E50", VA = "0x1859FA050")]
		public static void UDKATFLQQCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class NQJPEWDYCEL<a, b> : NQOWCCXVLPU<a> where a : TJYNFXDVXDS
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly NQJPEWDYCEL<a, b> CJGYMEELLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> LNYAGDXKJTG;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x59F8FE0", Offset = "0x59F7DE0", VA = "0x1859F8FE0")]
		public bool KJZUPXKVGOU(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x59F91D0", Offset = "0x59F7FD0", VA = "0x1859F91D0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
		public IEnumerable<KeyValuePair<string, b>> VAVNVJATUNV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4E90800", Offset = "0x4E8F600", VA = "0x184E90800", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x59F9380", Offset = "0x59F8180", VA = "0x1859F9380", Slot = "5")]
		protected override void TURZNWLSOWK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x59F96F0", Offset = "0x59F84F0", VA = "0x1859F96F0")]
		public NQJPEWDYCEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface TJYNFXDVXDS
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RPJGEDVAPHM();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool WOFCNRDZEQX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int GQEEKBEZGCZ(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TWJVUMNFURH(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YAPATREBKPW(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GKCIRPGFEYQ(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float FMSENFPRTOW(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MRKPAPHBQES(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string QJWYOJSOHIZ(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ATPXCBPSNUV(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime RZYNLGIFBGB(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LIQWMCAZGDP(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long TBNLXKZRVNE(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void IRAWYIKHQYO(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a JJJEGSQSVID<a>(string a, a b, XJDIQSDJBRI<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void LDSIPOZFOPF<b>(string a, b b, XJDIQSDJBRI<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void CKVCRSPLILE(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface HAZDFAKKFFT : TJYNFXDVXDS
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action RUENXCKVSBO;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task CNQOYIKJSMI(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface VLGCKDYVRAN : TJYNFXDVXDS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IYNUYMLCLRJ : HAZDFAKKFFT, TJYNFXDVXDS
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <Save>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IYNUYMLCLRJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x891D380", Offset = "0x891C180", VA = "0x18891D380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x891D740", Offset = "0x891C540", VA = "0x18891D740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class SLHWOESZFZP : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public IYNUYMLCLRJ FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public SLHWOESZFZP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x891C2A0", Offset = "0x891B0A0", VA = "0x18891C2A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x891C310", Offset = "0x891B110", VA = "0x18891C310", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log LWDSNBKPQHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ISFELIJWYUE DWRLVWIXTCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool PWKYNPHXGWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool GESQYICMEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private SPRKFJGZVXG YYJGUBRGQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JHHJDZQKJVL QAQKMBJQYUH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action RUENXCKVSBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x89171D0", Offset = "0x8915FD0", VA = "0x1889171D0")]
		[UnityEngine.Scripting.Preserve]
		public IYNUYMLCLRJ([Inject(null)] ISFELIJWYUE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "8")]
		public void RPJGEDVAPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8914760", Offset = "0x8913560", VA = "0x188914760", Slot = "6")]
		public Task CNQOYIKJSMI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1C62A60", Offset = "0x1C61860", VA = "0x181C62A60")]
		private static int JFVEQELMBQO(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8916E40", Offset = "0x8915C40", VA = "0x188916E40", Slot = "9")]
		public bool WOFCNRDZEQX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8914B90", Offset = "0x8913990", VA = "0x188914B90", Slot = "10")]
		public int GQEEKBEZGCZ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8916CE0", Offset = "0x8915AE0", VA = "0x188916CE0", Slot = "11")]
		public void TWJVUMNFURH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8917010", Offset = "0x8915E10", VA = "0x188917010", Slot = "12")]
		public bool YAPATREBKPW(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8914AB0", Offset = "0x89138B0", VA = "0x188914AB0", Slot = "13")]
		public void GKCIRPGFEYQ(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8914850", Offset = "0x8913650", VA = "0x188914850", Slot = "14")]
		public float FMSENFPRTOW(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x89167D0", Offset = "0x89155D0", VA = "0x1889167D0", Slot = "15")]
		public void MRKPAPHBQES(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8916B10", Offset = "0x8915910", VA = "0x188916B10", Slot = "18")]
		public DateTime RZYNLGIFBGB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8914E10", Offset = "0x8913C10", VA = "0x188914E10", Slot = "19")]
		public void LIQWMCAZGDP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8916C70", Offset = "0x8915A70", VA = "0x188916C70", Slot = "20")]
		public long TBNLXKZRVNE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8914D30", Offset = "0x8913B30", VA = "0x188914D30", Slot = "21")]
		public void IRAWYIKHQYO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x37E6CB0", Offset = "0x37E5AB0", VA = "0x1837E6CB0", Slot = "22")]
		public a JJJEGSQSVID<a>(string a, a b, XJDIQSDJBRI<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x37E6FB0", Offset = "0x37E5DB0", VA = "0x1837E6FB0", Slot = "23")]
		public void LDSIPOZFOPF<b>(string a, b b, XJDIQSDJBRI<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x37E5B20", Offset = "0x37E4920", VA = "0x1837E5B20")]
		private c JGVAVWPIWES<c>(string a, c b, [Optional] XJDIQSDJBRI<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x37E7260", Offset = "0x37E6060", VA = "0x1837E7260")]
		private void LTORZKBXPRY<d>(string a, d b, [Optional] XJDIQSDJBRI<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8916900", Offset = "0x8915700", VA = "0x188916900", Slot = "16")]
		public string QJWYOJSOHIZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x89145A0", Offset = "0x89133A0", VA = "0x1889145A0", Slot = "17")]
		public void ATPXCBPSNUV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8914980", Offset = "0x8913780", VA = "0x188914980")]
		private void FNNFQANYRQA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8916E60", Offset = "0x8915C60", VA = "0x188916E60")]
		private string XTGQYQLBISE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89146D0", Offset = "0x89134D0", VA = "0x1889146D0", Slot = "24")]
		public void CKVCRSPLILE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8916DA0", Offset = "0x8915BA0", VA = "0x188916DA0")]
		private string VPJCFPYUWOK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8914E80", Offset = "0x8913C80", VA = "0x188914E80")]
		public void MRCOWWVZKKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8916AB0", Offset = "0x89158B0", VA = "0x188916AB0", Slot = "26")]
		public void RUWMPREPNKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8916B80", Offset = "0x8915980", VA = "0x188916B80", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8916890", Offset = "0x8915690", VA = "0x188916890")]
		[IteratorStateMachine(typeof(SLHWOESZFZP))]
		private IEnumerator<NCPAWUBDFGC> ONXGDQTBCYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x89147F0", Offset = "0x89135F0", VA = "0x1889147F0")]
		private void FCOOZQZVEQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8914CC0", Offset = "0x8913AC0", VA = "0x188914CC0")]
		private void ILPWSCGITPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8914DA0", Offset = "0x8913BA0", VA = "0x188914DA0")]
		private void JFBTLWVWMXP(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class OSYRROPUOIL : HAZDFAKKFFT, TJYNFXDVXDS
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct KVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public string k;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public string v;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private struct KVPs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KVP[] kvps;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Dictionary<string, string> RUKEFABTPSA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string XZROKQVDAAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8918730", Offset = "0x8917530", VA = "0x188918730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string LLDLKGMEPWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8918540", Offset = "0x8917340", VA = "0x188918540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> EWVMXUCHIES
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x89180A0", Offset = "0x8916EA0", VA = "0x1889180A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action RUENXCKVSBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		[UnityEngine.Scripting.Preserve]
		public OSYRROPUOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "8")]
		public void RPJGEDVAPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8917A40", Offset = "0x8916840", VA = "0x188917A40", Slot = "6")]
		public Task CNQOYIKJSMI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8917AD0", Offset = "0x89168D0", VA = "0x188917AD0", Slot = "14")]
		public float FMSENFPRTOW(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8917B40", Offset = "0x8916940", VA = "0x188917B40", Slot = "13")]
		public void GKCIRPGFEYQ(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8918660", Offset = "0x8917460", VA = "0x188918660", Slot = "12")]
		public bool YAPATREBKPW(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8917BB0", Offset = "0x89169B0", VA = "0x188917BB0", Slot = "10")]
		public int GQEEKBEZGCZ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8918190", Offset = "0x8916F90", VA = "0x188918190", Slot = "18")]
		public DateTime RZYNLGIFBGB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8917C90", Offset = "0x8916A90", VA = "0x188917C90", Slot = "19")]
		public void LIQWMCAZGDP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8918030", Offset = "0x8916E30", VA = "0x188918030", Slot = "15")]
		public void MRKPAPHBQES(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x89184D0", Offset = "0x89172D0", VA = "0x1889184D0", Slot = "11")]
		public void TWJVUMNFURH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8918460", Offset = "0x8917260", VA = "0x188918460", Slot = "20")]
		public long TBNLXKZRVNE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8917C20", Offset = "0x8916A20", VA = "0x188917C20", Slot = "21")]
		public void IRAWYIKHQYO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x397A210", Offset = "0x3979010", VA = "0x18397A210", Slot = "22")]
		public a JJJEGSQSVID<a>(string a, a b, XJDIQSDJBRI<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x397A3F0", Offset = "0x39791F0", VA = "0x18397A3F0", Slot = "23")]
		public void LDSIPOZFOPF<b>(string a, b b, XJDIQSDJBRI<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x89180E0", Offset = "0x8916EE0", VA = "0x1889180E0", Slot = "16")]
		public string QJWYOJSOHIZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x89178E0", Offset = "0x89166E0", VA = "0x1889178E0", Slot = "17")]
		public void ATPXCBPSNUV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8917980", Offset = "0x8916780", VA = "0x188917980", Slot = "24")]
		public void CKVCRSPLILE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x89185D0", Offset = "0x89173D0", VA = "0x1889185D0", Slot = "9")]
		public bool WOFCNRDZEQX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8918200", Offset = "0x8917000", VA = "0x188918200", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3978A20", Offset = "0x3977820", VA = "0x183978A20")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XJDIQSDJBRI<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x397A590", Offset = "0x3979390", VA = "0x18397A590")]
		private void Set<T>(string propertyName, T value, [Optional] XJDIQSDJBRI<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8917D00", Offset = "0x8916B00", VA = "0x188917D00")]
		private Dictionary<string, string> MDZYFFDADUS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface VIUQBVAXUUP
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action RUENXCKVSBO;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RPJGEDVAPHM();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task QTHOOCQGJPS(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RFTEWGOJRIA(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MGUBETWXXWW(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NZADFBUWCDH(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string TSJTYYARCRU(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult RFNFECKFRDI(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int NGPFXAPUTMA(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult FTONQKUMXHG(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool NBGKAVPBXPF(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult HKGHFZUETAX(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float NYARQBFILBZ(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult VRYQXBQNWBZ(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime MFTBFSQWCLI(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult EZVPJIXBOCG(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long KUFPFIFVHVP(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult ENGXKSYXZND(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a BWCENXBRUOM<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult SANIGLKKLAQ<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool QMIARAIBDNC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool DRIFFHSDXHH(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string RBMSZVCXQCU(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult SSSBPORYNWE(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int CFFPLVFPUDQ(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult EAZNCUPEVUO(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool DNFLTNVSDFH(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult EZTIGMNWYUR(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float LWGLKGXHKHX(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult ZVRIVWQUVHH(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime MFXZPTHZQXK(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult AUNAQOVHOMM(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long BKIONSTSRHR(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult ZYWNMQRNLAD(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void OSTMOQQSBHQ<e>(XJDIQSDJBRI<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void FNOFYHUWCDH<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable CMNHRHPDPXQ();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void QYBFLILERTL(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task FCOOZQZVEQS([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum SetResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Unchanged,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Changed
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class Preferences : VIUQBVAXUUP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class ZFEYGBUHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<ZFEYGBUHHDL> YBVJFTVYYGU;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x891E690", Offset = "0x891D490", VA = "0x18891E690")]
			public static void UDKATFLQQCQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			protected ZFEYGBUHHDL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class IXMEXMBKCWO<a> : ZFEYGBUHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly IXMEXMBKCWO<a> PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public XJDIQSDJBRI<a> REXNHFVWPPN
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> BTQURUFWKQT
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool HBGQPCSCVZS
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xC6FA20", Offset = "0xC6E820", VA = "0x180C6FA20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5114920", Offset = "0x5113720", VA = "0x185114920")]
			private IXMEXMBKCWO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x5113C30", Offset = "0x5112A30", VA = "0x185113C30")]
			public void DELFABVRANX(XJDIQSDJBRI<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xE07220", Offset = "0xE06020", VA = "0x180E07220", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class TDWBPNTNTOV : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences LHLOHRGXQMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object UNRKYVDSWBW;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x891C380", Offset = "0x891B180", VA = "0x18891C380")]
			public TDWBPNTNTOV(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x891C350", Offset = "0x891B150", VA = "0x18891C350", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <InitializeForPlayerInternal>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public long playerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x891CB10", Offset = "0x891B910", VA = "0x18891CB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x891CDF0", Offset = "0x891BBF0", VA = "0x18891CDF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <Save>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public TJYNFXDVXDS backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x891D7A0", Offset = "0x891C5A0", VA = "0x18891D7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xB2AF10", Offset = "0xB29D10", VA = "0x180B2AF10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <SaveImmediate>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x891CE50", Offset = "0x891BC50", VA = "0x18891CE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x891D320", Offset = "0x891C120", VA = "0x18891D320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class UUAYDBWKOZV : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float KXNTNVINGCB;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public UUAYDBWKOZV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x891E1A0", Offset = "0x891CFA0", VA = "0x18891E1A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x891E230", Offset = "0x891D030", VA = "0x18891E230", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly HAZDFAKKFFT FXLCHFDJBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly HAZDFAKKFFT NLRKSHSWLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly VLGCKDYVRAN CLJMXCCISRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly SPRKFJGZVXG YYJGUBRGQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly PBJRSEFGKAE.CustomSaveHandler JPFIIHWFRWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly ZCWEIRQKNNA IOJBEXZUDUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<TJYNFXDVXDS> QIJIAWKSHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task QNVQCBKONLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> AEVEXYVHGLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JHHJDZQKJVL NYXUHTXJSBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object SZWKLVHFLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object EYSZYXWKANY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long JOJJQTUVNYO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool IMIUEAITAIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x183A180", Offset = "0x1838F80", VA = "0x18183A180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource OPEZMGDJGAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAC63D0", Offset = "0xAC51D0", VA = "0x180AC63D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action RUENXCKVSBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x891B860", Offset = "0x891A660", VA = "0x18891B860", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x891B250", Offset = "0x891A050", VA = "0x18891B250", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x891A260", Offset = "0x8919060", VA = "0x18891A260")]
		[AUEAKLYJEMA.Root]
		internal static void KDFVSNBBKHZ(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x891BF10", Offset = "0x891AD10", VA = "0x18891BF10")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] HAZDFAKKFFT localBackingStore, [Inject("Cloud")] HAZDFAKKFFT cloudBackingStore, [Inject(null)] VLGCKDYVRAN editorBackingStore, [Inject(null)] SPRKFJGZVXG scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x89196D0", Offset = "0x89184D0", VA = "0x1889196D0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x891BCA0", Offset = "0x891AAA0", VA = "0x18891BCA0")]
		private void YAEDGTCSFZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x891B0E0", Offset = "0x8919EE0", VA = "0x18891B0E0", Slot = "6")]
		public void RPJGEDVAPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x891AAC0", Offset = "0x89198C0", VA = "0x18891AAC0", Slot = "7")]
		public Task QTHOOCQGJPS(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x891B900", Offset = "0x891A700", VA = "0x18891B900")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task XFHWUFBGNHH(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x891B660", Offset = "0x891A460", VA = "0x18891B660")]
		private void WAAIRJZGHXO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8919FB0", Offset = "0x8918DB0", VA = "0x188919FB0")]
		private void HDVULHMUROZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x891A1A0", Offset = "0x8918FA0", VA = "0x18891A1A0")]
		private string IYEEGRTMRXC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x891ACA0", Offset = "0x8919AA0", VA = "0x18891ACA0")]
		private void QYLUBVEURVE(AccountPreferenceBackingStoreTypes a, string b, [Out] HAZDFAKKFFT c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8919350", Offset = "0x8918150", VA = "0x188919350")]
		private HAZDFAKKFFT CAZAPWBUEIC(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x891B030", Offset = "0x8919E30", VA = "0x18891B030", Slot = "8")]
		public bool RFTEWGOJRIA(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x891A4F0", Offset = "0x89192F0", VA = "0x18891A4F0", Slot = "9")]
		public bool MGUBETWXXWW(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x891A7A0", Offset = "0x89195A0", VA = "0x18891A7A0", Slot = "10")]
		public bool NZADFBUWCDH(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x891B2F0", Offset = "0x891A0F0", VA = "0x18891B2F0", Slot = "11")]
		public string TSJTYYARCRU(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x891AEB0", Offset = "0x8919CB0", VA = "0x18891AEB0", Slot = "12")]
		public SetResult RFNFECKFRDI(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x891A640", Offset = "0x8919440", VA = "0x18891A640", Slot = "13")]
		public int NGPFXAPUTMA(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8919E40", Offset = "0x8918C40", VA = "0x188919E40", Slot = "14")]
		public SetResult FTONQKUMXHG(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x891A590", Offset = "0x8919390", VA = "0x18891A590", Slot = "15")]
		public bool NBGKAVPBXPF(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x891A030", Offset = "0x8918E30", VA = "0x18891A030", Slot = "16")]
		public SetResult HKGHFZUETAX(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x891A6F0", Offset = "0x89194F0", VA = "0x18891A6F0", Slot = "17")]
		public float NYARQBFILBZ(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x891B4E0", Offset = "0x891A2E0", VA = "0x18891B4E0", Slot = "18")]
		public SetResult VRYQXBQNWBZ(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x891A3E0", Offset = "0x89191E0", VA = "0x18891A3E0", Slot = "19")]
		public DateTime MFTBFSQWCLI(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x89198E0", Offset = "0x89186E0", VA = "0x1889198E0", Slot = "20")]
		public SetResult EZVPJIXBOCG(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x891A2D0", Offset = "0x89190D0", VA = "0x18891A2D0", Slot = "21")]
		public long KUFPFIFVHVP(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8919740", Offset = "0x8918540", VA = "0x188919740", Slot = "22")]
		public SetResult ENGXKSYXZND(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x39A4B10", Offset = "0x39A3910", VA = "0x1839A4B10", Slot = "23")]
		public a BWCENXBRUOM<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x39A6B80", Offset = "0x39A5980", VA = "0x1839A6B80", Slot = "24")]
		public SetResult SANIGLKKLAQ<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x891AA60", Offset = "0x8919860", VA = "0x18891AA60", Slot = "25")]
		public bool QMIARAIBDNC(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x89196C0", Offset = "0x89184C0", VA = "0x1889196C0", Slot = "26")]
		public bool DRIFFHSDXHH(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x891AE40", Offset = "0x8919C40", VA = "0x18891AE40", Slot = "27")]
		public string RBMSZVCXQCU(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x891B150", Offset = "0x8919F50", VA = "0x18891B150", Slot = "28")]
		public SetResult SSSBPORYNWE(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x89193D0", Offset = "0x89181D0", VA = "0x1889193D0", Slot = "29")]
		public int CFFPLVFPUDQ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8919710", Offset = "0x8918510", VA = "0x188919710", Slot = "30")]
		public SetResult EAZNCUPEVUO(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8919650", Offset = "0x8918450", VA = "0x188919650", Slot = "31")]
		public bool DNFLTNVSDFH(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x89198B0", Offset = "0x89186B0", VA = "0x1889198B0", Slot = "32")]
		public SetResult EZTIGMNWYUR(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x891A370", Offset = "0x8919170", VA = "0x18891A370", Slot = "33")]
		public float LWGLKGXHKHX(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x891BEB0", Offset = "0x891ACB0", VA = "0x18891BEB0", Slot = "34")]
		public SetResult ZVRIVWQUVHH(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x891A480", Offset = "0x8919280", VA = "0x18891A480", Slot = "35")]
		public DateTime MFXZPTHZQXK(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8919170", Offset = "0x8917F70", VA = "0x188919170", Slot = "36")]
		public SetResult AUNAQOVHOMM(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x89192E0", Offset = "0x89180E0", VA = "0x1889192E0", Slot = "37")]
		public long BKIONSTSRHR(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x891BEE0", Offset = "0x891ACE0", VA = "0x18891BEE0", Slot = "38")]
		public SetResult ZYWNMQRNLAD(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x891A200", Offset = "0x8919000", VA = "0x18891A200")]
		private bool JMNXBZUJUIA(TJYNFXDVXDS a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8919A80", Offset = "0x8918880", VA = "0x188919A80")]
		private bool EZYMBIQVQQD(TJYNFXDVXDS a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x891B390", Offset = "0x891A190", VA = "0x18891B390")]
		private SetResult VGMNUQZCSJH(TJYNFXDVXDS a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x891A920", Offset = "0x8919720", VA = "0x18891A920")]
		private SetResult PMMESNNAWCF(TJYNFXDVXDS a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x89191A0", Offset = "0x8917FA0", VA = "0x1889191A0")]
		private SetResult BIHGRTRDCLC(TJYNFXDVXDS a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8919510", Offset = "0x8918310", VA = "0x188919510")]
		private SetResult CWNGRZTBLHI(TJYNFXDVXDS a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8919CD0", Offset = "0x8918AD0", VA = "0x188919CD0")]
		private SetResult FFHJRWNQPAB(TJYNFXDVXDS a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x891BCF0", Offset = "0x891AAF0", VA = "0x18891BCF0")]
		private SetResult YATIWBYMVZA(TJYNFXDVXDS a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x39A53E0", Offset = "0x39A41E0", VA = "0x1839A53E0")]
		private e GAVQKUXWGZF<e>(TJYNFXDVXDS a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x39A5DC0", Offset = "0x39A4BC0", VA = "0x1839A5DC0")]
		private SetResult IQYMSOWCZZF<f>(TJYNFXDVXDS a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x39A6840", Offset = "0x39A5640", VA = "0x1839A6840", Slot = "39")]
		public void OSTMOQQSBHQ<g>(XJDIQSDJBRI<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x39A5140", Offset = "0x39A3F40", VA = "0x1839A5140", Slot = "40")]
		public void FNOFYHUWCDH<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x891B180", Offset = "0x8919F80", VA = "0x18891B180")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(TJYNFXDVXDS backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8919BE0", Offset = "0x89189E0", VA = "0x188919BE0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task FCOOZQZVEQS([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x891B680", Offset = "0x891A480", VA = "0x18891B680")]
		private void WBYRTYUTGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8919440", Offset = "0x8918240", VA = "0x188919440", Slot = "41")]
		public IDisposable CMNHRHPDPXQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x891AC90", Offset = "0x8919A90", VA = "0x18891AC90", Slot = "42")]
		public void QYBFLILERTL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x891BA10", Offset = "0x891A810", VA = "0x18891BA10")]
		private void XGRZMGBPUIV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x891BE30", Offset = "0x891AC30", VA = "0x18891BE30")]
		[IteratorStateMachine(typeof(UUAYDBWKOZV))]
		private IEnumerator<NCPAWUBDFGC> YYHMHFGTMCT(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x891BC70", Offset = "0x891AA70", VA = "0x18891BC70")]
		[CompilerGenerated]
		private void XSUXEXOCGIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class VMXWSLHPQRH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x891E410", Offset = "0x891D210", VA = "0x18891E410")]
		public static string ESBTCDQTRCG(this VIUQBVAXUUP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x891E270", Offset = "0x891D070", VA = "0x18891E270")]
		public static byte[] CZHBNLTQZBY(this VIUQBVAXUUP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x891E580", Offset = "0x891D380", VA = "0x18891E580")]
		public static SetResult NOSTGIFFLCK(this VIUQBVAXUUP a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KEUTKJEULTS : RJQLTHPVVVO<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static KEUTKJEULTS PKFRARWZTTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8917640", Offset = "0x8916440", VA = "0x188917640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x89172D0", Offset = "0x89160D0", VA = "0x1889172D0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x89173C0", Offset = "0x89161C0", VA = "0x1889173C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8917720", Offset = "0x8916520", VA = "0x188917720")]
		public KEUTKJEULTS()
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
