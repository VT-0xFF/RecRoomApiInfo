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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C5B420", Offset = "0x9C59E20", VA = "0x189C5B420")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C5B320", Offset = "0x9C59D20", VA = "0x189C5B320", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C662B0", Offset = "0x9C64CB0", VA = "0x189C662B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
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
	internal static class IJGKOMYSXWW
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(PYQSKSPCKVI backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A840", Offset = "0x9C59240", VA = "0x189C5A840")]
		private static void QDGYUYKSGDX(PYQSKSPCKVI a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A460", Offset = "0x9C58E60", VA = "0x189C5A460")]
		public static bool LXGPKWNGMRB(this PYQSKSPCKVI a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A310", Offset = "0x9C58D10", VA = "0x189C5A310")]
		public static SetResult GOMWJHKHVLU(this PYQSKSPCKVI a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AB80", Offset = "0x9C59580", VA = "0x189C5AB80")]
		public static SetResult ZSWZICWKLZY(this PYQSKSPCKVI a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A700", Offset = "0x9C59100", VA = "0x189C5A700")]
		public static SetResult MXWRLVLMLLN(this PYQSKSPCKVI a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AA30", Offset = "0x9C59430", VA = "0x189C5AA30")]
		public static SetResult TELLNZHCATX(this PYQSKSPCKVI a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A8C0", Offset = "0x9C592C0", VA = "0x189C5A8C0")]
		public static SetResult QQFBVDTKJNU(this PYQSKSPCKVI a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A5C0", Offset = "0x9C58FC0", VA = "0x189C5A5C0")]
		public static SetResult MXUVGCSGKWF(this PYQSKSPCKVI a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class USVFKHIHFJJ : WDYPFXOLCML, PYQSKSPCKVI
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log NQKYKJZBGHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly AJZDCBGXGDY CJSCNYMYFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> TFVPKOGNEQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> HFYUIRFMHMW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> EOQLBVWOGVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9C62600", Offset = "0x9C61000", VA = "0x189C62600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C63110", Offset = "0x9C61B10", VA = "0x189C63110")]
		[UnityEngine.Scripting.Preserve]
		public USVFKHIHFJJ([Inject(null)] AJZDCBGXGDY unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C62510", Offset = "0x9C60F10", VA = "0x189C62510")]
		private DirectoryInfo LGREARUMZYW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C62B40", Offset = "0x9C61540", VA = "0x189C62B40", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C62210", Offset = "0x9C60C10", VA = "0x189C62210", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C626B0", Offset = "0x9C610B0", VA = "0x189C626B0", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C62D40", Offset = "0x9C61740", VA = "0x189C62D40", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C62AD0", Offset = "0x9C614D0", VA = "0x189C62AD0", Slot = "10")]
		public int UDVENIWAVAX(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C62F80", Offset = "0x9C61980", VA = "0x189C62F80", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C62280", Offset = "0x9C60C80", VA = "0x189C62280", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C62720", Offset = "0x9C61120", VA = "0x189C62720", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C62F10", Offset = "0x9C61910", VA = "0x189C62F10", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C62110", Offset = "0x9C60B10", VA = "0x189C62110", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C61320", Offset = "0x9C5FD20", VA = "0x189C61320", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4091F70", Offset = "0x4090970", VA = "0x184091F70", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4092150", Offset = "0x4090B50", VA = "0x184092150", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C62FF0", Offset = "0x9C619F0", VA = "0x189C62FF0", Slot = "16")]
		public string ZCKLFKVEXWD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C61250", Offset = "0x9C5FC50", VA = "0x189C61250", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C62BD0", Offset = "0x9C615D0", VA = "0x189C62BD0", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C62180", Offset = "0x9C60B80", VA = "0x189C62180", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C62790", Offset = "0x9C61190", VA = "0x189C62790", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C60C10", Offset = "0x9C5F610", VA = "0x189C60C10")]
		private void BPBJDXWGRPS(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C622F0", Offset = "0x9C60CF0", VA = "0x189C622F0")]
		private static string KVKXRBWLBAV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C62E10", Offset = "0x9C61810", VA = "0x189C62E10")]
		private static string WTGMVNKPGCG(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4090780", Offset = "0x408F180", VA = "0x184090780")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] NFGIDDCCSWQ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40922F0", Offset = "0x4090CF0", VA = "0x1840922F0")]
		private void Set<T>(string propertyName, T value, [Optional] NFGIDDCCSWQ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C61390", Offset = "0x9C5FD90", VA = "0x189C61390")]
		private Dictionary<string, string> IKLZHHGTRWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C612C0", Offset = "0x9C5FCC0", VA = "0x189C612C0")]
		private void EJYSASWOGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C62640", Offset = "0x9C61040", VA = "0x189C62640")]
		private void PUOJPACIOBF(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class VFHNQGUTPXJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log NQKYKJZBGHW;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C63260", Offset = "0x9C61C60", VA = "0x189C63260")]
		[BQDQKYYGTTM.Root]
		internal static void BQDQKYYGTTM(TFZCSWYZDKY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HRZDRFYUQKU : IRQWHSMOFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C59E00", Offset = "0x9C58800", VA = "0x189C59E00")]
		[UnityEngine.Scripting.Preserve]
		public HRZDRFYUQKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class DZHHMAYRGIO : WDYPFXOLCML, PYQSKSPCKVI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly AJZDCBGXGDY CJSCNYMYFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> RPNJEHRYOBW;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C59940", Offset = "0x9C58340", VA = "0x189C59940")]
		[UnityEngine.Scripting.Preserve]
		public DZHHMAYRGIO([Inject(null)] AJZDCBGXGDY unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C59650", Offset = "0x9C58050", VA = "0x189C59650", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C59330", Offset = "0x9C57D30", VA = "0x189C59330", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C595E0", Offset = "0x9C57FE0", VA = "0x189C595E0", Slot = "10")]
		public int UDVENIWAVAX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C597E0", Offset = "0x9C581E0", VA = "0x189C597E0", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C59770", Offset = "0x9C58170", VA = "0x189C59770", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C59470", Offset = "0x9C57E70", VA = "0x189C59470", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C59390", Offset = "0x9C57D90", VA = "0x189C59390", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C594E0", Offset = "0x9C57EE0", VA = "0x189C594E0", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9C598C0", Offset = "0x9C582C0", VA = "0x189C598C0", Slot = "16")]
		public string ZCKLFKVEXWD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9C591E0", Offset = "0x9C57BE0", VA = "0x189C591E0", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9C59850", Offset = "0x9C58250", VA = "0x189C59850", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9C59400", Offset = "0x9C57E00", VA = "0x189C59400", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9C592C0", Offset = "0x9C57CC0", VA = "0x189C592C0", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9C59250", Offset = "0x9C57C50", VA = "0x189C59250", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x38D6440", Offset = "0x38D4E40", VA = "0x1838D6440", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x38D6620", Offset = "0x38D5020", VA = "0x1838D6620", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C596E0", Offset = "0x9C580E0", VA = "0x189C596E0", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9C59550", Offset = "0x9C57F50", VA = "0x189C59550", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x38D4C50", Offset = "0x38D3650", VA = "0x1838D4C50")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] NFGIDDCCSWQ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x38D67C0", Offset = "0x38D51C0", VA = "0x1838D67C0")]
		private void Set<T>(string propertyName, T value, [Optional] NFGIDDCCSWQ<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class IRQWHSMOFGN : WDYPFXOLCML, PYQSKSPCKVI, VIVQKJHYKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> GZYXHQOZTNB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B0B0", Offset = "0x9C59AB0", VA = "0x189C5B0B0", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9C5ADE0", Offset = "0x9C597E0", VA = "0x189C5ADE0", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B050", Offset = "0x9C59A50", VA = "0x189C5B050", Slot = "10")]
		public int UDVENIWAVAX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B200", Offset = "0x9C59C00", VA = "0x189C5B200", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B1A0", Offset = "0x9C59BA0", VA = "0x189C5B1A0", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AF00", Offset = "0x9C59900", VA = "0x189C5AF00", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AE40", Offset = "0x9C59840", VA = "0x189C5AE40", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AF60", Offset = "0x9C59960", VA = "0x189C5AF60", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B2C0", Offset = "0x9C59CC0", VA = "0x189C5B2C0", Slot = "16")]
		public string ZCKLFKVEXWD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C5ACC0", Offset = "0x9C596C0", VA = "0x189C5ACC0", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B260", Offset = "0x9C59C60", VA = "0x189C5B260", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AEA0", Offset = "0x9C598A0", VA = "0x189C5AEA0", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AD80", Offset = "0x9C59780", VA = "0x189C5AD80", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AD20", Offset = "0x9C59720", VA = "0x189C5AD20", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B33190", Offset = "0x3B31B90", VA = "0x183B33190", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3B33630", Offset = "0x3B32030", VA = "0x183B33630", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3B32610", Offset = "0x3B31010", VA = "0x183B32610")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3B33830", Offset = "0x3B32230", VA = "0x183B33830")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B140", Offset = "0x9C59B40", VA = "0x189C5B140", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AFC0", Offset = "0x9C599C0", VA = "0x189C5AFC0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C59E00", Offset = "0x9C58800", VA = "0x189C59E00")]
		public IRQWHSMOFGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class EUQWTMUWARK<a> where a : PYQSKSPCKVI
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<EUQWTMUWARK<a>> ZDLUQYBSDVX;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5BADBC0", Offset = "0x5BAC5C0", VA = "0x185BADBC0")]
		protected EUQWTMUWARK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void SFFKZCEBKPC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5BACFD0", Offset = "0x5BAB9D0", VA = "0x185BACFD0")]
		public static void HANOIVHBKDQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5BAD720", Offset = "0x5BAC120", VA = "0x185BAD720")]
		public static void MORIYKYEBXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class EVGRLHCOCZL<a, b> : EUQWTMUWARK<a> where a : PYQSKSPCKVI
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly EVGRLHCOCZL<a, b> AESEIRAUIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> PQLWIMCROEO;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE3B0", Offset = "0x5BACDB0", VA = "0x185BAE3B0")]
		public bool RRJZBUUOGPY(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE570", Offset = "0x5BACF70", VA = "0x185BAE570")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
		public IEnumerable<KeyValuePair<string, b>> ISEDUTWFMIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE240", Offset = "0x5BACC40", VA = "0x185BAE240", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE470", Offset = "0x5BACE70", VA = "0x185BAE470", Slot = "5")]
		protected override void SFFKZCEBKPC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5BAEA80", Offset = "0x5BAD480", VA = "0x185BAEA80")]
		public EVGRLHCOCZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface PYQSKSPCKVI
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PHWUDBISDHK();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IPEUDAFQGXP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int UDVENIWAVAX(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XWJIOOWMOQH(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool VQYKIOKGIEG(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QFKNTVYPFFU(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float JGCNNUQWZNK(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RWEOJJLGHNW(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string ZCKLFKVEXWD(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BQVFQSHJWPJ(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime YYMDFFIYMWD(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void JLQQAVQFARZ(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long INHLJWPXJPK(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void GMKLJPPEXGA(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VLUDUYRYGAQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface WDYPFXOLCML : PYQSKSPCKVI
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action UUBVZCRJDUG;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task VALPMQVEWCG(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface VIVQKJHYKGD : PYQSKSPCKVI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ZVKNACGIEDT : WDYPFXOLCML, PYQSKSPCKVI
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
			public ZVKNACGIEDT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9C5FDF0", Offset = "0x9C5E7F0", VA = "0x189C5FDF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9C601B0", Offset = "0x9C5EBB0", VA = "0x189C601B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class BZAFKLTONSD : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ZVKNACGIEDT IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public BZAFKLTONSD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9C58F60", Offset = "0x9C57960", VA = "0x189C58F60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9C58FD0", Offset = "0x9C579D0", VA = "0x189C58FD0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log NQKYKJZBGHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly AJZDCBGXGDY CJSCNYMYFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool EOWXZZNFGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool LZIUNTMSTZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private GUZFZPTTQMS TIZXXEFOSPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private NDLSPIRTFEP DWBCCALSJPH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C661B0", Offset = "0x9C64BB0", VA = "0x189C661B0")]
		[UnityEngine.Scripting.Preserve]
		public ZVKNACGIEDT([Inject(null)] AJZDCBGXGDY unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9C65AF0", Offset = "0x9C644F0", VA = "0x189C65AF0", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E86370", Offset = "0x1E84D70", VA = "0x181E86370")]
		private static int TVRHWGGTRFG(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9C651B0", Offset = "0x9C63BB0", VA = "0x189C651B0", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9C65810", Offset = "0x9C64210", VA = "0x189C65810", Slot = "10")]
		public int UDVENIWAVAX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9C65E00", Offset = "0x9C64800", VA = "0x189C65E00", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9C65C10", Offset = "0x9C64610", VA = "0x189C65C10", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C65580", Offset = "0x9C63F80", VA = "0x189C65580", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C651D0", Offset = "0x9C63BD0", VA = "0x189C651D0", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C65660", Offset = "0x9C64060", VA = "0x189C65660", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C65EC0", Offset = "0x9C648C0", VA = "0x189C65EC0", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C65300", Offset = "0x9C63D00", VA = "0x189C65300", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C65140", Offset = "0x9C63B40", VA = "0x189C65140", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C650D0", Offset = "0x9C63AD0", VA = "0x189C650D0", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4142AF0", Offset = "0x41414F0", VA = "0x184142AF0", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4143ED0", Offset = "0x41428D0", VA = "0x184143ED0", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4142CF0", Offset = "0x41416F0", VA = "0x184142CF0")]
		private c JWLWHOLEECY<c>(string a, c b, [Optional] NFGIDDCCSWQ<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4141E60", Offset = "0x4140860", VA = "0x184141E60")]
		private void FKGYLRVHSQY<d>(string a, d b, [Optional] NFGIDDCCSWQ<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F30", Offset = "0x9C64930", VA = "0x189C65F30", Slot = "16")]
		public string ZCKLFKVEXWD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C63580", Offset = "0x9C61F80", VA = "0x189C63580", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C653E0", Offset = "0x9C63DE0", VA = "0x189C653E0")]
		private void PIWJBGDIWXY(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C65940", Offset = "0x9C64340", VA = "0x189C65940")]
		private string UXDCOFALOHU(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C65B80", Offset = "0x9C64580", VA = "0x189C65B80", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C65D60", Offset = "0x9C64760", VA = "0x189C65D60")]
		private string WQVNAUXFKIE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C63780", Offset = "0x9C62180", VA = "0x189C63780")]
		public void FQOMIGJEPDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C636B0", Offset = "0x9C620B0", VA = "0x189C636B0", Slot = "26")]
		public void DBOCBRRTJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C65720", Offset = "0x9C64120", VA = "0x189C65720", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C65370", Offset = "0x9C63D70", VA = "0x189C65370")]
		[IteratorStateMachine(typeof(BZAFKLTONSD))]
		private IEnumerator<KHZACSYKHRO> OHZZDZBUPZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C660E0", Offset = "0x9C64AE0", VA = "0x189C660E0")]
		private void ZCZXZMLKKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C63710", Offset = "0x9C62110", VA = "0x189C63710")]
		private void EJYSASWOGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C65510", Offset = "0x9C63F10", VA = "0x189C65510")]
		private void PUOJPACIOBF(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class RPQFPUYKCTP : WDYPFXOLCML, PYQSKSPCKVI
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
		private Dictionary<string, string> HFYUIRFMHMW;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string CEZWGVWVPKV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C5F420", Offset = "0x9C5DE20", VA = "0x189C5F420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string IPYENWJKBAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9C5ED10", Offset = "0x9C5D710", VA = "0x189C5ED10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> EOQLBVWOGVO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9C5EBF0", Offset = "0x9C5D5F0", VA = "0x189C5EBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		public RPQFPUYKCTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F070", Offset = "0x9C5DA70", VA = "0x189C5F070", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9C5EB10", Offset = "0x9C5D510", VA = "0x189C5EB10", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9C5EC30", Offset = "0x9C5D630", VA = "0x189C5EC30", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F1C0", Offset = "0x9C5DBC0", VA = "0x189C5F1C0", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F000", Offset = "0x9C5DA00", VA = "0x189C5F000", Slot = "10")]
		public int UDVENIWAVAX(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F300", Offset = "0x9C5DD00", VA = "0x189C5F300", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9C5EB80", Offset = "0x9C5D580", VA = "0x189C5EB80", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9C5ECA0", Offset = "0x9C5D6A0", VA = "0x189C5ECA0", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F290", Offset = "0x9C5DC90", VA = "0x189C5F290", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C5EA10", Offset = "0x9C5D410", VA = "0x189C5EA10", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E670", Offset = "0x9C5D070", VA = "0x189C5E670", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E16280", Offset = "0x3E14C80", VA = "0x183E16280", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E16460", Offset = "0x3E14E60", VA = "0x183E16460", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F370", Offset = "0x9C5DD70", VA = "0x189C5F370", Slot = "16")]
		public string ZCKLFKVEXWD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E5D0", Offset = "0x9C5CFD0", VA = "0x189C5E5D0", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C5F100", Offset = "0x9C5DB00", VA = "0x189C5F100", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9C5EA80", Offset = "0x9C5D480", VA = "0x189C5EA80", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C5EDA0", Offset = "0x9C5D7A0", VA = "0x189C5EDA0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E14A90", Offset = "0x3E13490", VA = "0x183E14A90")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] NFGIDDCCSWQ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E16600", Offset = "0x3E15000", VA = "0x183E16600")]
		private void Set<T>(string propertyName, T value, [Optional] NFGIDDCCSWQ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E6E0", Offset = "0x9C5D0E0", VA = "0x189C5E6E0")]
		private Dictionary<string, string> IKLZHHGTRWA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface UIWDEIEQMSB
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action UUBVZCRJDUG;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PHWUDBISDHK();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task NTCBVJLCNVA(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ELMPPNLZHDY(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BXBYAASNMXS(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HACXTEHLFDF(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string JCPFNFFEMDC(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult CWIUQYNWRUA(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int AISBLGIPWAW(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult FYMBCCVNNWK(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool BPHRHKHPQOR(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult GKISCBSHBPP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float HPCUGOXOFTL(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult UBRHHCWQVWZ(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime XJYQZCLIMCU(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult LEQSHAEFYIU(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long FHFLUYCPBDR(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult GTUFINTNAFF(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a WGDTYUBKHES<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult LASTHBZAVWK<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool VAGESRBEKYG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool LFWFYLFPNFR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string BMDJDPGDVZI(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult ZEAYAPEJNTQ(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int NLVLLHAFUWA(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult YABGJYCIRJS(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool BTUMYXKXVGX(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult NGBWZEBFLHR(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float IIFAROCDNRJ(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult FTHAWEKCEMD(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime XXPVLIPXNFA(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult DVVBXLHIKFI(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long QFGFPMIDTNP(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult BRCXNZVPQAR(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void MEYFXLTFYVK<e>(NFGIDDCCSWQ<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void MXKMSIEWSXF<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable HPBBLVUNJYQ();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void CSHKHRJJXWL(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task ZCZXZMLKKAM([Optional] CancellationToken a);
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
	public class Preferences : UIWDEIEQMSB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class DZCBGKMNDPR
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<DZCBGKMNDPR> RSBLDOHJQJE;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9C59010", Offset = "0x9C57A10", VA = "0x189C59010")]
			public static void MORIYKYEBXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			protected DZCBGKMNDPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class ZPUXQUNTMGM<a> : DZCBGKMNDPR
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly ZPUXQUNTMGM<a> LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public NFGIDDCCSWQ<a> SNZHPHXBUJP
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> CBQUQCFEEMR
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool NFAKAKPSAWG
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xE71EE0", Offset = "0xE708E0", VA = "0x180E71EE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x510E740", Offset = "0x510D140", VA = "0x18510E740")]
			private ZPUXQUNTMGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x510DFE0", Offset = "0x510C9E0", VA = "0x18510DFE0")]
			public void GZVUEGYMGMP(NFGIDDCCSWQ<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1018B40", Offset = "0x1017540", VA = "0x181018B40", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class WVSCYYHNPIL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences YNJBBYYDOSY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object DUBCNYDORSC;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9C634D0", Offset = "0x9C61ED0", VA = "0x189C634D0")]
			public WVSCYYHNPIL(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9C634A0", Offset = "0x9C61EA0", VA = "0x189C634A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C5F580", Offset = "0x9C5DF80", VA = "0x189C5F580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9C5F860", Offset = "0x9C5E260", VA = "0x189C5F860", Slot = "5")]
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
			public PYQSKSPCKVI backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9C60210", Offset = "0x9C5EC10", VA = "0x189C60210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD39FE0", Offset = "0xD389E0", VA = "0x180D39FE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C5F8C0", Offset = "0x9C5E2C0", VA = "0x189C5F8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9C5FD90", Offset = "0x9C5E790", VA = "0x189C5FD90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class THSZPXONWYB : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float LGUNYXIWFMH;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public THSZPXONWYB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9C5F4B0", Offset = "0x9C5DEB0", VA = "0x189C5F4B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9C5F540", Offset = "0x9C5DF40", VA = "0x189C5F540", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly WDYPFXOLCML CDLPOKOMSHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly WDYPFXOLCML RQHELFLIKDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly VIVQKJHYKGD BFZQLWHOFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly GUZFZPTTQMS TIZXXEFOSPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IJGKOMYSXWW.CustomSaveHandler JGVZIGNINIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly WFSYYVMEPOE XZMKSNPZLGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<PYQSKSPCKVI> OGKHQULZVAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task EQBERTGEYXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> ACDZRGIHCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private NDLSPIRTFEP CFWYWMXRRVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object JCPAYASQTVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object SPCBQCKTZYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long XUCUVDEJBCE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool HTSUPBXZXPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A5E390", Offset = "0x1A5CD90", VA = "0x181A5E390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource EIILWHWCTQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DF0", Offset = "0xCD57F0", VA = "0x180CD6DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9C5D220", Offset = "0x9C5BC20", VA = "0x189C5D220", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9C5C4D0", Offset = "0x9C5AED0", VA = "0x189C5C4D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DB50", Offset = "0x9C5C550", VA = "0x189C5DB50")]
		[BQDQKYYGTTM.Root]
		internal static void TRWAHLHDOMR(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E240", Offset = "0x9C5CC40", VA = "0x189C5E240")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] WDYPFXOLCML localBackingStore, [Inject("Cloud")] WDYPFXOLCML cloudBackingStore, [Inject(null)] VIVQKJHYKGD editorBackingStore, [Inject(null)] GUZFZPTTQMS scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BEF0", Offset = "0x9C5A8F0", VA = "0x189C5BEF0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D400", Offset = "0x9C5BE00", VA = "0x189C5D400")]
		private void MONKTZVHRBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D6C0", Offset = "0x9C5C0C0", VA = "0x189C5D6C0", Slot = "6")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D4F0", Offset = "0x9C5BEF0", VA = "0x189C5D4F0", Slot = "7")]
		public Task NTCBVJLCNVA(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D970", Offset = "0x9C5C370", VA = "0x189C5D970")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task SKDOGBAWANN(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DF40", Offset = "0x9C5C940", VA = "0x189C5DF40")]
		private void WWYNFQCMNBI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BE40", Offset = "0x9C5A840", VA = "0x189C5BE40")]
		private void DQDJZSOAEED(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D1C0", Offset = "0x9C5BBC0", VA = "0x189C5D1C0")]
		private string LGAHUZHHXOC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9C5CB50", Offset = "0x9C5B550", VA = "0x189C5CB50")]
		private void HXJDARXTDUM(AccountPreferenceBackingStoreTypes a, string b, [Out] WDYPFXOLCML c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D7A0", Offset = "0x9C5C1A0", VA = "0x189C5D7A0")]
		private WDYPFXOLCML RDTDVLWLVDO(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BF30", Offset = "0x9C5A930", VA = "0x189C5BF30", Slot = "8")]
		public bool ELMPPNLZHDY(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B9B0", Offset = "0x9C5A3B0", VA = "0x189C5B9B0", Slot = "9")]
		public bool BXBYAASNMXS(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C850", Offset = "0x9C5B250", VA = "0x189C5C850", Slot = "10")]
		public bool HACXTEHLFDF(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9C5CF40", Offset = "0x9C5B940", VA = "0x189C5CF40", Slot = "11")]
		public string JCPFNFFEMDC(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BCC0", Offset = "0x9C5A6C0", VA = "0x189C5BCC0", Slot = "12")]
		public SetResult CWIUQYNWRUA(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B4A0", Offset = "0x9C59EA0", VA = "0x189C5B4A0", Slot = "13")]
		public int AISBLGIPWAW(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C360", Offset = "0x9C5AD60", VA = "0x189C5C360", Slot = "14")]
		public SetResult FYMBCCVNNWK(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B860", Offset = "0x9C5A260", VA = "0x189C5B860", Slot = "15")]
		public bool BPHRHKHPQOR(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C570", Offset = "0x9C5AF70", VA = "0x189C5C570", Slot = "16")]
		public SetResult GKISCBSHBPP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5CAA0", Offset = "0x9C5B4A0", VA = "0x189C5CAA0", Slot = "17")]
		public float HPCUGOXOFTL(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DBC0", Offset = "0x9C5C5C0", VA = "0x189C5DBC0", Slot = "18")]
		public SetResult UBRHHCWQVWZ(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DF60", Offset = "0x9C5C960", VA = "0x189C5DF60", Slot = "19")]
		public DateTime XJYQZCLIMCU(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D010", Offset = "0x9C5BA10", VA = "0x189C5D010", Slot = "20")]
		public SetResult LEQSHAEFYIU(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C120", Offset = "0x9C5AB20", VA = "0x189C5C120", Slot = "21")]
		public long FHFLUYCPBDR(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C6E0", Offset = "0x9C5B0E0", VA = "0x189C5C6E0", Slot = "22")]
		public SetResult GTUFINTNAFF(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CFA0", Offset = "0x3D7B9A0", VA = "0x183D7CFA0", Slot = "23")]
		public a WGDTYUBKHES<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B2B0", Offset = "0x3D79CB0", VA = "0x183D7B2B0", Slot = "24")]
		public SetResult LASTHBZAVWK<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DEE0", Offset = "0x9C5C8E0", VA = "0x189C5DEE0", Slot = "25")]
		public bool VAGESRBEKYG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D1B0", Offset = "0x9C5BBB0", VA = "0x189C5D1B0", Slot = "26")]
		public bool LFWFYLFPNFR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B7F0", Offset = "0x9C5A1F0", VA = "0x189C5B7F0", Slot = "27")]
		public string BMDJDPGDVZI(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E190", Offset = "0x9C5CB90", VA = "0x189C5E190", Slot = "28")]
		public SetResult ZEAYAPEJNTQ(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D480", Offset = "0x9C5BE80", VA = "0x189C5D480", Slot = "29")]
		public int NLVLLHAFUWA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E070", Offset = "0x9C5CA70", VA = "0x189C5E070", Slot = "30")]
		public SetResult YABGJYCIRJS(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B940", Offset = "0x9C5A340", VA = "0x189C5B940", Slot = "31")]
		public bool BTUMYXKXVGX(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D450", Offset = "0x9C5BE50", VA = "0x189C5D450", Slot = "32")]
		public SetResult NGBWZEBFLHR(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5CED0", Offset = "0x9C5B8D0", VA = "0x189C5CED0", Slot = "33")]
		public float IIFAROCDNRJ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C330", Offset = "0x9C5AD30", VA = "0x189C5C330", Slot = "34")]
		public SetResult FTHAWEKCEMD(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E000", Offset = "0x9C5CA00", VA = "0x189C5E000", Slot = "35")]
		public DateTime XXPVLIPXNFA(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BEC0", Offset = "0x9C5A8C0", VA = "0x189C5BEC0", Slot = "36")]
		public SetResult DVVBXLHIKFI(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D730", Offset = "0x9C5C130", VA = "0x189C5D730", Slot = "37")]
		public long QFGFPMIDTNP(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B910", Offset = "0x9C5A310", VA = "0x189C5B910", Slot = "38")]
		public SetResult BRCXNZVPQAR(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DE80", Offset = "0x9C5C880", VA = "0x189C5DE80")]
		private bool UXOTZAGVALY(PYQSKSPCKVI a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B550", Offset = "0x9C59F50", VA = "0x189C5B550")]
		private bool AKPHUQITFPH(PYQSKSPCKVI a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D820", Offset = "0x9C5C220", VA = "0x189C5D820")]
		private SetResult SJPMSINCPGH(PYQSKSPCKVI a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BFE0", Offset = "0x9C5A9E0", VA = "0x189C5BFE0")]
		private SetResult FFXDEIDADBJ(PYQSKSPCKVI a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9C5D2C0", Offset = "0x9C5BCC0", VA = "0x189C5D2C0")]
		private SetResult MLXPDZNIPDY(PYQSKSPCKVI a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DD40", Offset = "0x9C5C740", VA = "0x189C5DD40")]
		private SetResult UIRLBBEJFHC(PYQSKSPCKVI a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C1C0", Offset = "0x9C5ABC0", VA = "0x189C5C1C0")]
		private SetResult FOMYEXZNQQL(PYQSKSPCKVI a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B6B0", Offset = "0x9C5A0B0", VA = "0x189C5B6B0")]
		private SetResult ANGWXWEMQYQ(PYQSKSPCKVI a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C970", Offset = "0x3D7B370", VA = "0x183D7C970")]
		private e UGYOKYPVDWZ<e>(PYQSKSPCKVI a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3D7BD80", Offset = "0x3D7A780", VA = "0x183D7BD80")]
		private SetResult PIWDOOOVCBT<f>(PYQSKSPCKVI a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B580", Offset = "0x3D79F80", VA = "0x183D7B580", Slot = "39")]
		public void MEYFXLTFYVK<g>(NFGIDDCCSWQ<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B790", Offset = "0x3D7A190", VA = "0x183D7B790", Slot = "40")]
		public void MXKMSIEWSXF<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DA80", Offset = "0x9C5C480", VA = "0x189C5DA80")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(PYQSKSPCKVI backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E0A0", Offset = "0x9C5CAA0", VA = "0x189C5E0A0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task ZCZXZMLKKAM([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9C5CCF0", Offset = "0x9C5B6F0", VA = "0x189C5CCF0")]
		private void HXZTVWKUQPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C9D0", Offset = "0x9C5B3D0", VA = "0x189C5C9D0", Slot = "41")]
		public IDisposable HPBBLVUNJYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BCB0", Offset = "0x9C5A6B0", VA = "0x189C5BCB0", Slot = "42")]
		public void CSHKHRJJXWL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BA50", Offset = "0x9C5A450", VA = "0x189C5BA50")]
		private void CSGXUVBTDTR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9C5E1C0", Offset = "0x9C5CBC0", VA = "0x189C5E1C0")]
		[IteratorStateMachine(typeof(THSZPXONWYB))]
		private IEnumerator<KHZACSYKHRO> ZJLFWWOEZHP(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9C5CFE0", Offset = "0x9C5B9E0", VA = "0x189C5CFE0")]
		[CompilerGenerated]
		private void JWEEVAOEASG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class GTZKCZYGVRZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9C59AF0", Offset = "0x9C584F0", VA = "0x189C59AF0")]
		public static string IWASTSPRTNG(this UIWDEIEQMSB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9C59C60", Offset = "0x9C58660", VA = "0x189C59C60")]
		public static byte[] PLPMXLBIILC(this UIWDEIEQMSB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9C599E0", Offset = "0x9C583E0", VA = "0x189C599E0")]
		public static SetResult HBNOWDRAFIU(this UIWDEIEQMSB a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HXRFUALBBLI : UDKPKAVGNYS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HXRFUALBBLI LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9C59E80", Offset = "0x9C58880", VA = "0x189C59E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C59ED0", Offset = "0x9C588D0", VA = "0x189C59ED0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9C59FC0", Offset = "0x9C589C0", VA = "0x189C59FC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A2D0", Offset = "0x9C58CD0", VA = "0x189C5A2D0")]
		public HXRFUALBBLI()
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
