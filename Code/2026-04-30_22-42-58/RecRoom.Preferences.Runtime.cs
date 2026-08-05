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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B86AD0", Offset = "0x9B85ED0", VA = "0x189B86AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B869D0", Offset = "0x9B85DD0", VA = "0x189B869D0", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B918A0", Offset = "0x9B90CA0", VA = "0x189B918A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B85EF0", Offset = "0x9B852F0", VA = "0x189B85EF0")]
		private static void QDGYUYKSGDX(PYQSKSPCKVI a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B85B00", Offset = "0x9B84F00", VA = "0x189B85B00")]
		public static bool LXGPKWNGMRB(this PYQSKSPCKVI a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B859B0", Offset = "0x9B84DB0", VA = "0x189B859B0")]
		public static SetResult GOMWJHKHVLU(this PYQSKSPCKVI a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B86230", Offset = "0x9B85630", VA = "0x189B86230")]
		public static SetResult ZSWZICWKLZY(this PYQSKSPCKVI a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B85DA0", Offset = "0x9B851A0", VA = "0x189B85DA0")]
		public static SetResult MXWRLVLMLLN(this PYQSKSPCKVI a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9B860E0", Offset = "0x9B854E0", VA = "0x189B860E0")]
		public static SetResult TELLNZHCATX(this PYQSKSPCKVI a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B85F70", Offset = "0x9B85370", VA = "0x189B85F70")]
		public static SetResult QQFBVDTKJNU(this PYQSKSPCKVI a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9B85C60", Offset = "0x9B85060", VA = "0x189B85C60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> EOQLBVWOGVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9B8DC60", Offset = "0x9B8D060", VA = "0x189B8DC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E750", Offset = "0x9B8DB50", VA = "0x189B8E750")]
		[UnityEngine.Scripting.Preserve]
		public USVFKHIHFJJ([Inject(null)] AJZDCBGXGDY unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9B8DB70", Offset = "0x9B8CF70", VA = "0x189B8DB70")]
		private DirectoryInfo LGREARUMZYW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E190", Offset = "0x9B8D590", VA = "0x189B8E190", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8D870", Offset = "0x9B8CC70", VA = "0x189B8D870", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8DD10", Offset = "0x9B8D110", VA = "0x189B8DD10", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E390", Offset = "0x9B8D790", VA = "0x189B8E390", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E120", Offset = "0x9B8D520", VA = "0x189B8E120", Slot = "10")]
		public int UDVENIWAVAX(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E5C0", Offset = "0x9B8D9C0", VA = "0x189B8E5C0", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8D8E0", Offset = "0x9B8CCE0", VA = "0x189B8D8E0", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B8DD80", Offset = "0x9B8D180", VA = "0x189B8DD80", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E550", Offset = "0x9B8D950", VA = "0x189B8E550", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B8D770", Offset = "0x9B8CB70", VA = "0x189B8D770", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B8CA00", Offset = "0x9B8BE00", VA = "0x189B8CA00", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4086E90", Offset = "0x4086290", VA = "0x184086E90", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4087070", Offset = "0x4086470", VA = "0x184087070", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E630", Offset = "0x9B8DA30", VA = "0x189B8E630", Slot = "16")]
		public string ZCKLFKVEXWD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9B8C930", Offset = "0x9B8BD30", VA = "0x189B8C930", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E220", Offset = "0x9B8D620", VA = "0x189B8E220", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B8D7E0", Offset = "0x9B8CBE0", VA = "0x189B8D7E0", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8DDF0", Offset = "0x9B8D1F0", VA = "0x189B8DDF0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8C310", Offset = "0x9B8B710", VA = "0x189B8C310")]
		private void BPBJDXWGRPS(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B8D950", Offset = "0x9B8CD50", VA = "0x189B8D950")]
		private static string KVKXRBWLBAV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8E450", Offset = "0x9B8D850", VA = "0x189B8E450")]
		private static string WTGMVNKPGCG(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40856A0", Offset = "0x4084AA0", VA = "0x1840856A0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] NFGIDDCCSWQ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4087210", Offset = "0x4086610", VA = "0x184087210")]
		private void Set<T>(string propertyName, T value, [Optional] NFGIDDCCSWQ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B8CA70", Offset = "0x9B8BE70", VA = "0x189B8CA70")]
		private Dictionary<string, string> IKLZHHGTRWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9B8C9A0", Offset = "0x9B8BDA0", VA = "0x189B8C9A0")]
		private void EJYSASWOGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B8DCA0", Offset = "0x9B8D0A0", VA = "0x189B8DCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8E8A0", Offset = "0x9B8DCA0", VA = "0x189B8E8A0")]
		[BQDQKYYGTTM.Root]
		internal static void BQDQKYYGTTM(TFZCSWYZDKY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HRZDRFYUQKU : IRQWHSMOFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B854A0", Offset = "0x9B848A0", VA = "0x189B854A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9B84FD0", Offset = "0x9B843D0", VA = "0x189B84FD0")]
		[UnityEngine.Scripting.Preserve]
		public DZHHMAYRGIO([Inject(null)] AJZDCBGXGDY unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B84CE0", Offset = "0x9B840E0", VA = "0x189B84CE0", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9B849C0", Offset = "0x9B83DC0", VA = "0x189B849C0", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B84C70", Offset = "0x9B84070", VA = "0x189B84C70", Slot = "10")]
		public int UDVENIWAVAX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B84E70", Offset = "0x9B84270", VA = "0x189B84E70", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B84E00", Offset = "0x9B84200", VA = "0x189B84E00", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B84B00", Offset = "0x9B83F00", VA = "0x189B84B00", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B84A20", Offset = "0x9B83E20", VA = "0x189B84A20", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B84B70", Offset = "0x9B83F70", VA = "0x189B84B70", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B84F50", Offset = "0x9B84350", VA = "0x189B84F50", Slot = "16")]
		public string ZCKLFKVEXWD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B84870", Offset = "0x9B83C70", VA = "0x189B84870", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B84EE0", Offset = "0x9B842E0", VA = "0x189B84EE0", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B84A90", Offset = "0x9B83E90", VA = "0x189B84A90", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B84950", Offset = "0x9B83D50", VA = "0x189B84950", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B848E0", Offset = "0x9B83CE0", VA = "0x189B848E0", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x38C8190", Offset = "0x38C7590", VA = "0x1838C8190", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x38C8370", Offset = "0x38C7770", VA = "0x1838C8370", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9B84D70", Offset = "0x9B84170", VA = "0x189B84D70", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9B84BE0", Offset = "0x9B83FE0", VA = "0x189B84BE0", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x38C69A0", Offset = "0x38C5DA0", VA = "0x1838C69A0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] NFGIDDCCSWQ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x38C8510", Offset = "0x38C7910", VA = "0x1838C8510")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B86760", Offset = "0x9B85B60", VA = "0x189B86760", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9B86490", Offset = "0x9B85890", VA = "0x189B86490", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9B86700", Offset = "0x9B85B00", VA = "0x189B86700", Slot = "10")]
		public int UDVENIWAVAX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9B868B0", Offset = "0x9B85CB0", VA = "0x189B868B0", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9B86850", Offset = "0x9B85C50", VA = "0x189B86850", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B865B0", Offset = "0x9B859B0", VA = "0x189B865B0", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9B864F0", Offset = "0x9B858F0", VA = "0x189B864F0", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9B86610", Offset = "0x9B85A10", VA = "0x189B86610", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9B86970", Offset = "0x9B85D70", VA = "0x189B86970", Slot = "16")]
		public string ZCKLFKVEXWD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9B86370", Offset = "0x9B85770", VA = "0x189B86370", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B86910", Offset = "0x9B85D10", VA = "0x189B86910", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9B86550", Offset = "0x9B85950", VA = "0x189B86550", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9B86430", Offset = "0x9B85830", VA = "0x189B86430", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9B863D0", Offset = "0x9B857D0", VA = "0x189B863D0", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B26140", Offset = "0x3B25540", VA = "0x183B26140", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3B265D0", Offset = "0x3B259D0", VA = "0x183B265D0", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3B255D0", Offset = "0x3B249D0", VA = "0x183B255D0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3B267D0", Offset = "0x3B25BD0", VA = "0x183B267D0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B867F0", Offset = "0x9B85BF0", VA = "0x189B867F0", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9B86670", Offset = "0x9B85A70", VA = "0x189B86670", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B854A0", Offset = "0x9B848A0", VA = "0x189B854A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B2A340", Offset = "0x5B29740", VA = "0x185B2A340")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B29760", Offset = "0x5B28B60", VA = "0x185B29760")]
		public static void HANOIVHBKDQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5B29EB0", Offset = "0x5B292B0", VA = "0x185B29EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B2AB30", Offset = "0x5B29F30", VA = "0x185B2AB30")]
		public bool RRJZBUUOGPY(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5B2ACF0", Offset = "0x5B2A0F0", VA = "0x185B2ACF0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
		public IEnumerable<KeyValuePair<string, b>> ISEDUTWFMIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A9C0", Offset = "0x5B29DC0", VA = "0x185B2A9C0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5B2ABF0", Offset = "0x5B29FF0", VA = "0x185B2ABF0", Slot = "5")]
		protected override void SFFKZCEBKPC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5B2B1E0", Offset = "0x5B2A5E0", VA = "0x185B2B1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8B4E0", Offset = "0x9B8A8E0", VA = "0x189B8B4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9B8B8B0", Offset = "0x9B8ACB0", VA = "0x189B8B8B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public BZAFKLTONSD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9B84600", Offset = "0x9B83A00", VA = "0x189B84600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9B84670", Offset = "0x9B83A70", VA = "0x189B84670", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B917A0", Offset = "0x9B90BA0", VA = "0x189B917A0")]
		[UnityEngine.Scripting.Preserve]
		public ZVKNACGIEDT([Inject(null)] AJZDCBGXGDY unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9B910F0", Offset = "0x9B904F0", VA = "0x189B910F0", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F490", Offset = "0x1E8E890", VA = "0x181E8F490")]
		private static int TVRHWGGTRFG(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9B907E0", Offset = "0x9B8FBE0", VA = "0x189B907E0", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B90E30", Offset = "0x9B90230", VA = "0x189B90E30", Slot = "10")]
		public int UDVENIWAVAX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B91400", Offset = "0x9B90800", VA = "0x189B91400", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B91210", Offset = "0x9B90610", VA = "0x189B91210", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B90BA0", Offset = "0x9B8FFA0", VA = "0x189B90BA0", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B90800", Offset = "0x9B8FC00", VA = "0x189B90800", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9B90C80", Offset = "0x9B90080", VA = "0x189B90C80", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9B914B0", Offset = "0x9B908B0", VA = "0x189B914B0", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B90930", Offset = "0x9B8FD30", VA = "0x189B90930", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B90770", Offset = "0x9B8FB70", VA = "0x189B90770", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B90700", Offset = "0x9B8FB00", VA = "0x189B90700", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41373D0", Offset = "0x41367D0", VA = "0x1841373D0", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x41387A0", Offset = "0x4137BA0", VA = "0x1841387A0", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x41375D0", Offset = "0x41369D0", VA = "0x1841375D0")]
		private c JWLWHOLEECY<c>(string a, c b, [Optional] NFGIDDCCSWQ<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4136750", Offset = "0x4135B50", VA = "0x184136750")]
		private void FKGYLRVHSQY<d>(string a, d b, [Optional] NFGIDDCCSWQ<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B91520", Offset = "0x9B90920", VA = "0x189B91520", Slot = "16")]
		public string ZCKLFKVEXWD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9B8EBC0", Offset = "0x9B8DFC0", VA = "0x189B8EBC0", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9B90A10", Offset = "0x9B8FE10", VA = "0x189B90A10")]
		private void PIWJBGDIWXY(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9B90F50", Offset = "0x9B90350", VA = "0x189B90F50")]
		private string UXDCOFALOHU(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9B91180", Offset = "0x9B90580", VA = "0x189B91180", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9B91360", Offset = "0x9B90760", VA = "0x189B91360")]
		private string WQVNAUXFKIE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8EDC0", Offset = "0x9B8E1C0", VA = "0x189B8EDC0")]
		public void FQOMIGJEPDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9B8ECF0", Offset = "0x9B8E0F0", VA = "0x189B8ECF0", Slot = "26")]
		public void DBOCBRRTJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D40", Offset = "0x9B90140", VA = "0x189B90D40", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9B909A0", Offset = "0x9B8FDA0", VA = "0x189B909A0")]
		[IteratorStateMachine(typeof(BZAFKLTONSD))]
		private IEnumerator<KHZACSYKHRO> OHZZDZBUPZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9B916D0", Offset = "0x9B90AD0", VA = "0x189B916D0")]
		private void ZCZXZMLKKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9B8ED50", Offset = "0x9B8E150", VA = "0x189B8ED50")]
		private void EJYSASWOGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B90B30", Offset = "0x9B8FF30", VA = "0x189B90B30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string CEZWGVWVPKV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9B8AB10", Offset = "0x9B89F10", VA = "0x189B8AB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string IPYENWJKBAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9B8A410", Offset = "0x9B89810", VA = "0x189B8A410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> EOQLBVWOGVO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9B8A2F0", Offset = "0x9B896F0", VA = "0x189B8A2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		[UnityEngine.Scripting.Preserve]
		public RPQFPUYKCTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A770", Offset = "0x9B89B70", VA = "0x189B8A770", Slot = "6")]
		public Task VALPMQVEWCG(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A210", Offset = "0x9B89610", VA = "0x189B8A210", Slot = "14")]
		public float JGCNNUQWZNK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A330", Offset = "0x9B89730", VA = "0x189B8A330", Slot = "13")]
		public void QFKNTVYPFFU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A8C0", Offset = "0x9B89CC0", VA = "0x189B8A8C0", Slot = "12")]
		public bool VQYKIOKGIEG(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A700", Offset = "0x9B89B00", VA = "0x189B8A700", Slot = "10")]
		public int UDVENIWAVAX(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A9F0", Offset = "0x9B89DF0", VA = "0x189B8A9F0", Slot = "18")]
		public DateTime YYMDFFIYMWD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A280", Offset = "0x9B89680", VA = "0x189B8A280", Slot = "19")]
		public void JLQQAVQFARZ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A3A0", Offset = "0x9B897A0", VA = "0x189B8A3A0", Slot = "15")]
		public void RWEOJJLGHNW(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A980", Offset = "0x9B89D80", VA = "0x189B8A980", Slot = "11")]
		public void XWJIOOWMOQH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A110", Offset = "0x9B89510", VA = "0x189B8A110", Slot = "20")]
		public long INHLJWPXJPK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B89D90", Offset = "0x9B89190", VA = "0x189B89D90", Slot = "21")]
		public void GMKLJPPEXGA(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F290", Offset = "0x3E0E690", VA = "0x183E0F290", Slot = "22")]
		public a IPGRHCRETPP<a>(string a, a b, NFGIDDCCSWQ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F470", Offset = "0x3E0E870", VA = "0x183E0F470", Slot = "23")]
		public void LVUIAIIAIZD<b>(string a, b b, NFGIDDCCSWQ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B8AA60", Offset = "0x9B89E60", VA = "0x189B8AA60", Slot = "16")]
		public string ZCKLFKVEXWD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B89CF0", Offset = "0x9B890F0", VA = "0x189B89CF0", Slot = "17")]
		public void BQVFQSHJWPJ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A800", Offset = "0x9B89C00", VA = "0x189B8A800", Slot = "24")]
		public void VLUDUYRYGAQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A180", Offset = "0x9B89580", VA = "0x189B8A180", Slot = "9")]
		public bool IPEUDAFQGXP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A4A0", Offset = "0x9B898A0", VA = "0x189B8A4A0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DAA0", Offset = "0x3E0CEA0", VA = "0x183E0DAA0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] NFGIDDCCSWQ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F610", Offset = "0x3E0EA10", VA = "0x183E0F610")]
		private void Set<T>(string propertyName, T value, [Optional] NFGIDDCCSWQ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B89E00", Offset = "0x9B89200", VA = "0x189B89E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B846B0", Offset = "0x9B83AB0", VA = "0x189B846B0")]
			public static void MORIYKYEBXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> CBQUQCFEEMR
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool NFAKAKPSAWG
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xE8D450", Offset = "0xE8C850", VA = "0x180E8D450")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x508DD20", Offset = "0x508D120", VA = "0x18508DD20")]
			private ZPUXQUNTMGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x508D5E0", Offset = "0x508C9E0", VA = "0x18508D5E0")]
			public void GZVUEGYMGMP(NFGIDDCCSWQ<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x102E920", Offset = "0x102DD20", VA = "0x18102E920", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8EB10", Offset = "0x9B8DF10", VA = "0x189B8EB10")]
			public WVSCYYHNPIL(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9B8EAE0", Offset = "0x9B8DEE0", VA = "0x189B8EAE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8AC70", Offset = "0x9B8A070", VA = "0x189B8AC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9B8AF50", Offset = "0x9B8A350", VA = "0x189B8AF50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8B910", Offset = "0x9B8AD10", VA = "0x189B8B910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD58120", Offset = "0xD57520", VA = "0x180D58120", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8AFB0", Offset = "0x9B8A3B0", VA = "0x189B8AFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9B8B480", Offset = "0x9B8A880", VA = "0x189B8B480", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public THSZPXONWYB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9B8ABA0", Offset = "0x9B89FA0", VA = "0x189B8ABA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9B8AC30", Offset = "0x9B8A030", VA = "0x189B8AC30", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A6BAB0", Offset = "0x1A6AEB0", VA = "0x181A6BAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource EIILWHWCTQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E00", Offset = "0xCF4200", VA = "0x180CF4E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action UUBVZCRJDUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9B88930", Offset = "0x9B87D30", VA = "0x189B88930", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9B87BB0", Offset = "0x9B86FB0", VA = "0x189B87BB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9B89260", Offset = "0x9B88660", VA = "0x189B89260")]
		[BQDQKYYGTTM.Root]
		internal static void TRWAHLHDOMR(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9B89960", Offset = "0x9B88D60", VA = "0x189B89960")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] WDYPFXOLCML localBackingStore, [Inject("Cloud")] WDYPFXOLCML cloudBackingStore, [Inject(null)] VIVQKJHYKGD editorBackingStore, [Inject(null)] GUZFZPTTQMS scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9B875C0", Offset = "0x9B869C0", VA = "0x189B875C0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9B88B10", Offset = "0x9B87F10", VA = "0x189B88B10")]
		private void MONKTZVHRBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9B88DD0", Offset = "0x9B881D0", VA = "0x189B88DD0", Slot = "6")]
		public void PHWUDBISDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9B88C00", Offset = "0x9B88000", VA = "0x189B88C00", Slot = "7")]
		public Task NTCBVJLCNVA(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9B89080", Offset = "0x9B88480", VA = "0x189B89080")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task SKDOGBAWANN(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9B89660", Offset = "0x9B88A60", VA = "0x189B89660")]
		private void WWYNFQCMNBI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9B87510", Offset = "0x9B86910", VA = "0x189B87510")]
		private void DQDJZSOAEED(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B888D0", Offset = "0x9B87CD0", VA = "0x189B888D0")]
		private string LGAHUZHHXOC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B88250", Offset = "0x9B87650", VA = "0x189B88250")]
		private void HXJDARXTDUM(AccountPreferenceBackingStoreTypes a, string b, [Out] WDYPFXOLCML c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9B88EB0", Offset = "0x9B882B0", VA = "0x189B88EB0")]
		private WDYPFXOLCML RDTDVLWLVDO(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9B87600", Offset = "0x9B86A00", VA = "0x189B87600", Slot = "8")]
		public bool ELMPPNLZHDY(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9B87060", Offset = "0x9B86460", VA = "0x189B87060", Slot = "9")]
		public bool BXBYAASNMXS(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9B87F50", Offset = "0x9B87350", VA = "0x189B87F50", Slot = "10")]
		public bool HACXTEHLFDF(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9B88640", Offset = "0x9B87A40", VA = "0x189B88640", Slot = "11")]
		public string JCPFNFFEMDC(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9B87380", Offset = "0x9B86780", VA = "0x189B87380", Slot = "12")]
		public SetResult CWIUQYNWRUA(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9B86B50", Offset = "0x9B85F50", VA = "0x189B86B50", Slot = "13")]
		public int AISBLGIPWAW(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9B87A30", Offset = "0x9B86E30", VA = "0x189B87A30", Slot = "14")]
		public SetResult FYMBCCVNNWK(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9B86F10", Offset = "0x9B86310", VA = "0x189B86F10", Slot = "15")]
		public bool BPHRHKHPQOR(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9B87C50", Offset = "0x9B87050", VA = "0x189B87C50", Slot = "16")]
		public SetResult GKISCBSHBPP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9B881A0", Offset = "0x9B875A0", VA = "0x189B881A0", Slot = "17")]
		public float HPCUGOXOFTL(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B892D0", Offset = "0x9B886D0", VA = "0x189B892D0", Slot = "18")]
		public SetResult UBRHHCWQVWZ(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9B89680", Offset = "0x9B88A80", VA = "0x189B89680", Slot = "19")]
		public DateTime XJYQZCLIMCU(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9B88710", Offset = "0x9B87B10", VA = "0x189B88710", Slot = "20")]
		public SetResult LEQSHAEFYIU(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9B877F0", Offset = "0x9B86BF0", VA = "0x189B877F0", Slot = "21")]
		public long FHFLUYCPBDR(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9B87DD0", Offset = "0x9B871D0", VA = "0x189B87DD0", Slot = "22")]
		public SetResult GTUFINTNAFF(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3D75430", Offset = "0x3D74830", VA = "0x183D75430", Slot = "23")]
		public a WGDTYUBKHES<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3D73780", Offset = "0x3D72B80", VA = "0x183D73780", Slot = "24")]
		public SetResult LASTHBZAVWK<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9B89600", Offset = "0x9B88A00", VA = "0x189B89600", Slot = "25")]
		public bool VAGESRBEKYG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9B888C0", Offset = "0x9B87CC0", VA = "0x189B888C0", Slot = "26")]
		public bool LFWFYLFPNFR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9B86EA0", Offset = "0x9B862A0", VA = "0x189B86EA0", Slot = "27")]
		public string BMDJDPGDVZI(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9B898B0", Offset = "0x9B88CB0", VA = "0x189B898B0", Slot = "28")]
		public SetResult ZEAYAPEJNTQ(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9B88B90", Offset = "0x9B87F90", VA = "0x189B88B90", Slot = "29")]
		public int NLVLLHAFUWA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9B89790", Offset = "0x9B88B90", VA = "0x189B89790", Slot = "30")]
		public SetResult YABGJYCIRJS(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9B86FF0", Offset = "0x9B863F0", VA = "0x189B86FF0", Slot = "31")]
		public bool BTUMYXKXVGX(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9B88B60", Offset = "0x9B87F60", VA = "0x189B88B60", Slot = "32")]
		public SetResult NGBWZEBFLHR(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9B885D0", Offset = "0x9B879D0", VA = "0x189B885D0", Slot = "33")]
		public float IIFAROCDNRJ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9B87A00", Offset = "0x9B86E00", VA = "0x189B87A00", Slot = "34")]
		public SetResult FTHAWEKCEMD(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9B89720", Offset = "0x9B88B20", VA = "0x189B89720", Slot = "35")]
		public DateTime XXPVLIPXNFA(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9B87590", Offset = "0x9B86990", VA = "0x189B87590", Slot = "36")]
		public SetResult DVVBXLHIKFI(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9B88E40", Offset = "0x9B88240", VA = "0x189B88E40", Slot = "37")]
		public long QFGFPMIDTNP(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9B86FC0", Offset = "0x9B863C0", VA = "0x189B86FC0", Slot = "38")]
		public SetResult BRCXNZVPQAR(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9B895A0", Offset = "0x9B889A0", VA = "0x189B895A0")]
		private bool UXOTZAGVALY(PYQSKSPCKVI a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9B86C00", Offset = "0x9B86000", VA = "0x189B86C00")]
		private bool AKPHUQITFPH(PYQSKSPCKVI a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9B88F30", Offset = "0x9B88330", VA = "0x189B88F30")]
		private SetResult SJPMSINCPGH(PYQSKSPCKVI a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9B876B0", Offset = "0x9B86AB0", VA = "0x189B876B0")]
		private SetResult FFXDEIDADBJ(PYQSKSPCKVI a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9B889D0", Offset = "0x9B87DD0", VA = "0x189B889D0")]
		private SetResult MLXPDZNIPDY(PYQSKSPCKVI a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9B89450", Offset = "0x9B88850", VA = "0x189B89450")]
		private SetResult UIRLBBEJFHC(PYQSKSPCKVI a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9B87890", Offset = "0x9B86C90", VA = "0x189B87890")]
		private SetResult FOMYEXZNQQL(PYQSKSPCKVI a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9B86D60", Offset = "0x9B86160", VA = "0x189B86D60")]
		private SetResult ANGWXWEMQYQ(PYQSKSPCKVI a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3D74E10", Offset = "0x3D74210", VA = "0x183D74E10")]
		private e UGYOKYPVDWZ<e>(PYQSKSPCKVI a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3D74200", Offset = "0x3D73600", VA = "0x183D74200")]
		private SetResult PIWDOOOVCBT<f>(PYQSKSPCKVI a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3D73A40", Offset = "0x3D72E40", VA = "0x183D73A40", Slot = "39")]
		public void MEYFXLTFYVK<g>(NFGIDDCCSWQ<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D73C20", Offset = "0x3D73020", VA = "0x183D73C20", Slot = "40")]
		public void MXKMSIEWSXF<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9B89190", Offset = "0x9B88590", VA = "0x189B89190")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(PYQSKSPCKVI backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9B897C0", Offset = "0x9B88BC0", VA = "0x189B897C0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task ZCZXZMLKKAM([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9B883F0", Offset = "0x9B877F0", VA = "0x189B883F0")]
		private void HXZTVWKUQPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9B880D0", Offset = "0x9B874D0", VA = "0x189B880D0", Slot = "41")]
		public IDisposable HPBBLVUNJYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9B87370", Offset = "0x9B86770", VA = "0x189B87370", Slot = "42")]
		public void CSHKHRJJXWL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9B87100", Offset = "0x9B86500", VA = "0x189B87100")]
		private void CSGXUVBTDTR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9B898E0", Offset = "0x9B88CE0", VA = "0x189B898E0")]
		[IteratorStateMachine(typeof(THSZPXONWYB))]
		private IEnumerator<KHZACSYKHRO> ZJLFWWOEZHP(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9B886E0", Offset = "0x9B87AE0", VA = "0x189B886E0")]
		[CompilerGenerated]
		private void JWEEVAOEASG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class GTZKCZYGVRZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9B85180", Offset = "0x9B84580", VA = "0x189B85180")]
		public static string IWASTSPRTNG(this UIWDEIEQMSB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9B852F0", Offset = "0x9B846F0", VA = "0x189B852F0")]
		public static byte[] PLPMXLBIILC(this UIWDEIEQMSB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9B85070", Offset = "0x9B84470", VA = "0x189B85070")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B85520", Offset = "0x9B84920", VA = "0x189B85520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9B85570", Offset = "0x9B84970", VA = "0x189B85570", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9B85660", Offset = "0x9B84A60", VA = "0x189B85660", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9B85970", Offset = "0x9B84D70", VA = "0x189B85970")]
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
