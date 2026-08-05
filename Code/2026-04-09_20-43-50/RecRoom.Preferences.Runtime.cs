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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DF2FE0", Offset = "0x9DF1FE0", VA = "0x189DF2FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DF2E00", Offset = "0x9DF1E00", VA = "0x189DF2E00", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DFB270", Offset = "0x9DFA270", VA = "0x189DFB270", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
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
	internal static class JBUYDEPBVXS
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(FWDDJKISYCY backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF9C0", Offset = "0x9DEE9C0", VA = "0x189DEF9C0")]
		private static void HAHSIKQFJUP(FWDDJKISYCY a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DEFCC0", Offset = "0x9DEECC0", VA = "0x189DEFCC0")]
		public static bool LOQJIKUUIYF(this FWDDJKISYCY a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF720", Offset = "0x9DEE720", VA = "0x189DEF720")]
		public static SetResult DQUASEVGJQY(this FWDDJKISYCY a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9DEFE20", Offset = "0x9DEEE20", VA = "0x189DEFE20")]
		public static SetResult TTQPDBMXDYA(this FWDDJKISYCY a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9DEFB80", Offset = "0x9DEEB80", VA = "0x189DEFB80")]
		public static SetResult KWNWBJAWSZP(this FWDDJKISYCY a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF870", Offset = "0x9DEE870", VA = "0x189DEF870")]
		public static SetResult DVSHGBDNWMX(this FWDDJKISYCY a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DEFF60", Offset = "0x9DEEF60", VA = "0x189DEFF60")]
		public static SetResult XKPLZKNFTNS(this FWDDJKISYCY a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DEFA40", Offset = "0x9DEEA40", VA = "0x189DEFA40")]
		public static SetResult IRATEJICQAD(this FWDDJKISYCY a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SDYIORZXWBT : ZFDAPHSPYER, FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HPYGNHKGIYE ZOUJREVDJSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> BHBYUWGMVYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> UUMBNIIEWCU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> MNOCALOZIOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9DF67F0", Offset = "0x9DF57F0", VA = "0x189DF67F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8CF0", Offset = "0x9DF7CF0", VA = "0x189DF8CF0")]
		[UnityEngine.Scripting.Preserve]
		public SDYIORZXWBT([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8520", Offset = "0x9DF7520", VA = "0x189DF8520")]
		private DirectoryInfo RUVOVUJNGRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DF7580", Offset = "0x9DF6580", VA = "0x189DF7580", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6830", Offset = "0x9DF5830", VA = "0x189DF6830", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF74A0", Offset = "0x9DF64A0", VA = "0x189DF74A0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6CB0", Offset = "0x9DF5CB0", VA = "0x189DF6CB0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8A30", Offset = "0x9DF7A30", VA = "0x189DF8A30", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8C10", Offset = "0x9DF7C10", VA = "0x189DF8C10", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF84B0", Offset = "0x9DF74B0", VA = "0x189DF84B0", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DF7510", Offset = "0x9DF6510", VA = "0x189DF7510", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8950", Offset = "0x9DF7950", VA = "0x189DF8950", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DF89C0", Offset = "0x9DF79C0", VA = "0x189DF89C0", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8390", Offset = "0x9DF7390", VA = "0x189DF8390", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F19150", Offset = "0x3F18150", VA = "0x183F19150", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F16240", Offset = "0x3F15240", VA = "0x183F16240", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8400", Offset = "0x9DF7400", VA = "0x189DF8400", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6D80", Offset = "0x9DF5D80", VA = "0x189DF6D80", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8AA0", Offset = "0x9DF7AA0", VA = "0x189DF8AA0", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6A00", Offset = "0x9DF5A00", VA = "0x189DF6A00", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8610", Offset = "0x9DF7610", VA = "0x189DF8610", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6DF0", Offset = "0x9DF5DF0", VA = "0x189DF6DF0")]
		private void MHUZKQVUBVE(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6A90", Offset = "0x9DF5A90", VA = "0x189DF6A90")]
		private static string LHAEHSQOMNF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6900", Offset = "0x9DF5900", VA = "0x189DF6900")]
		private static string FXLGVDTHUKA(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F163E0", Offset = "0x3F153E0", VA = "0x183F163E0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F17BD0", Offset = "0x3F16BD0", VA = "0x183F17BD0")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DF7610", Offset = "0x9DF6610", VA = "0x189DF7610")]
		private Dictionary<string, string> PCFYDYHEZKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DF68A0", Offset = "0x9DF58A0", VA = "0x189DF68A0")]
		private void DJQPSCLEWQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DF7430", Offset = "0x9DF6430", VA = "0x189DF7430")]
		private void MUOOFQELMJL(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class VLTMCAKRULX
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DFAC10", Offset = "0x9DF9C10", VA = "0x189DFAC10")]
		[GEPWJNEAFDW.Root]
		internal static void GEPWJNEAFDW(VIGMLMXVCUS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EQDAPTMPDRU : ORGZOGVYTFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF6A0", Offset = "0x9DEE6A0", VA = "0x189DEF6A0")]
		[UnityEngine.Scripting.Preserve]
		public EQDAPTMPDRU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CJWDCSUVBTO : ZFDAPHSPYER, FWDDJKISYCY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HPYGNHKGIYE ZOUJREVDJSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> PHZBIKWWZRM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE670", Offset = "0x9DED670", VA = "0x189DEE670")]
		[UnityEngine.Scripting.Preserve]
		public CJWDCSUVBTO([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE1A0", Offset = "0x9DED1A0", VA = "0x189DEE1A0", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DEDF80", Offset = "0x9DECF80", VA = "0x189DEDF80", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE500", Offset = "0x9DED500", VA = "0x189DEE500", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE420", Offset = "0x9DED420", VA = "0x189DEE420", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DEDFE0", Offset = "0x9DECFE0", VA = "0x189DEDFE0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE0C0", Offset = "0x9DED0C0", VA = "0x189DEE0C0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DEDF10", Offset = "0x9DECF10", VA = "0x189DEDF10", Slot = "14")]
		public float BICZAKOTTES(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE130", Offset = "0x9DED130", VA = "0x189DEE130", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE2A0", Offset = "0x9DED2A0", VA = "0x189DEE2A0", Slot = "16")]
		public string QGOSMAICKCR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE050", Offset = "0x9DED050", VA = "0x189DEE050", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE600", Offset = "0x9DED600", VA = "0x189DEE600", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE320", Offset = "0x9DED320", VA = "0x189DEE320", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE490", Offset = "0x9DED490", VA = "0x189DEE490", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE230", Offset = "0x9DED230", VA = "0x189DEE230", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37FE050", Offset = "0x37FD050", VA = "0x1837FE050", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37FB570", Offset = "0x37FA570", VA = "0x1837FB570", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE570", Offset = "0x9DED570", VA = "0x189DEE570", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE390", Offset = "0x9DED390", VA = "0x189DEE390", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37FB710", Offset = "0x37FA710", VA = "0x1837FB710")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x37FCF00", Offset = "0x37FBF00", VA = "0x1837FCF00")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ORGZOGVYTFB : ZFDAPHSPYER, FWDDJKISYCY, OKZZSQTUEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> WTRDIUDPCBX;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF32A0", Offset = "0x9DF22A0", VA = "0x189DF32A0", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF30C0", Offset = "0x9DF20C0", VA = "0x189DF30C0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF35A0", Offset = "0x9DF25A0", VA = "0x189DF35A0", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DF34E0", Offset = "0x9DF24E0", VA = "0x189DF34E0", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3120", Offset = "0x9DF2120", VA = "0x189DF3120", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DF31E0", Offset = "0x9DF21E0", VA = "0x189DF31E0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3060", Offset = "0x9DF2060", VA = "0x189DF3060", Slot = "14")]
		public float BICZAKOTTES(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3240", Offset = "0x9DF2240", VA = "0x189DF3240", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3390", Offset = "0x9DF2390", VA = "0x189DF3390", Slot = "16")]
		public string QGOSMAICKCR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3180", Offset = "0x9DF2180", VA = "0x189DF3180", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3660", Offset = "0x9DF2660", VA = "0x189DF3660", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DF33F0", Offset = "0x9DF23F0", VA = "0x189DF33F0", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3540", Offset = "0x9DF2540", VA = "0x189DF3540", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3330", Offset = "0x9DF2330", VA = "0x189DF3330", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FD60", Offset = "0x3D9ED60", VA = "0x183D9FD60", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EA00", Offset = "0x3D9DA00", VA = "0x183D9EA00", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EC00", Offset = "0x3D9DC00", VA = "0x183D9EC00")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F690", Offset = "0x3D9E690", VA = "0x183D9F690")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3600", Offset = "0x9DF2600", VA = "0x189DF3600", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3450", Offset = "0x9DF2450", VA = "0x189DF3450", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF6A0", Offset = "0x9DEE6A0", VA = "0x189DEF6A0")]
		public ORGZOGVYTFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class TLLHFJLEYRM<a> where a : FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<TLLHFJLEYRM<a>> VIMUXTOMENJ;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4050", Offset = "0x7BE3050", VA = "0x187BE4050")]
		protected TLLHFJLEYRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void GXLNJFYYQBM(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3B50", Offset = "0x7BE2B50", VA = "0x187BE3B50")]
		public static void QMAPDNOOLBO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BE33C0", Offset = "0x7BE23C0", VA = "0x187BE33C0")]
		public static void IEEYZUXTILW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TLGAICRHPGD<a, b> : TLLHFJLEYRM<a> where a : FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly TLGAICRHPGD<a, b> FYIBPTBKDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> SOWLQBALBPO;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2EE0", Offset = "0x7BE1EE0", VA = "0x187BE2EE0")]
		public bool XXTFUCBFMWE(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2C90", Offset = "0x7BE1C90", VA = "0x187BE2C90")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
		public IEnumerable<KeyValuePair<string, b>> IXJYSGURNKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x77B5A00", Offset = "0x77B4A00", VA = "0x1877B5A00", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2A30", Offset = "0x7BE1A30", VA = "0x187BE2A30", Slot = "5")]
		protected override void GXLNJFYYQBM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3230", Offset = "0x7BE2230", VA = "0x187BE3230")]
		public TLGAICRHPGD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UBYRWVAVOXQ();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KDMDMFGWMYX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int XFGLJJICOSJ(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UOLRMCBBXKJ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LMYOCXVGACQ(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MVYOWXFBYQY(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float BICZAKOTTES(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void NGBXFFZTZDQ(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string QGOSMAICKCR(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void LSGQKGXBITT(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void RMLSZBSDALP(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long VACXPISJHOK(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PCZCIJFSIAO(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YXHJXTPLZOK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ZFDAPHSPYER : FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action XRKISDBTAJO;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task OROICLDNWEA(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface OKZZSQTUEMJ : FWDDJKISYCY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LQVCURLRAAP : ZFDAPHSPYER, FWDDJKISYCY
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
			public LQVCURLRAAP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9DF9D20", Offset = "0x9DF8D20", VA = "0x189DF9D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9DFA0E0", Offset = "0x9DF90E0", VA = "0x189DFA0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class DKNLFUMVHSF : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public LQVCURLRAAP DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public DKNLFUMVHSF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9DEE750", Offset = "0x9DED750", VA = "0x189DEE750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9DEE710", Offset = "0x9DED710", VA = "0x189DEE710", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly HPYGNHKGIYE ZOUJREVDJSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool YJILUJQMUXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BLIEJHCKJUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private YDHSMJLFZLP FHCSOXXHYDB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2D00", Offset = "0x9DF1D00", VA = "0x189DF2D00")]
		[UnityEngine.Scripting.Preserve]
		public LQVCURLRAAP([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0780", Offset = "0x9DEF780", VA = "0x189DF0780", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9140", Offset = "0x1EA8140", VA = "0x181EA9140")]
		private static int EZPKYWBBFLQ(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF02D0", Offset = "0x9DEF2D0", VA = "0x189DF02D0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2930", Offset = "0x9DF1930", VA = "0x189DF2930", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2790", Offset = "0x9DF1790", VA = "0x189DF2790", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF02F0", Offset = "0x9DEF2F0", VA = "0x189DF02F0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF05E0", Offset = "0x9DEF5E0", VA = "0x189DF05E0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF00D0", Offset = "0x9DEF0D0", VA = "0x189DF00D0", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF06C0", Offset = "0x9DEF6C0", VA = "0x189DF06C0", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2C20", Offset = "0x9DF1C20", VA = "0x189DF2C20", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0BE0", Offset = "0x9DEFBE0", VA = "0x189DF0BE0", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2850", Offset = "0x9DF1850", VA = "0x189DF2850", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0810", Offset = "0x9DEF810", VA = "0x189DF0810", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C084F0", Offset = "0x3C074F0", VA = "0x183C084F0", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C076B0", Offset = "0x3C066B0", VA = "0x183C076B0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C086F0", Offset = "0x3C076F0", VA = "0x183C086F0")]
		private c ZGENTANSZVU<c>(string a, c b, [Optional] BILDKLRZYOS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C07870", Offset = "0x3C06870", VA = "0x183C07870")]
		private void FCGKPNQRPEC<d>(string a, d b, [Optional] BILDKLRZYOS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0880", Offset = "0x9DEF880", VA = "0x189DF0880", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0440", Offset = "0x9DEF440", VA = "0x189DF0440", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2A60", Offset = "0x9DF1A60", VA = "0x189DF2A60")]
		private void YEMIURUMHWE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0A30", Offset = "0x9DEFA30", VA = "0x189DF0A30")]
		private string RKRMRLIRNBC(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2B90", Offset = "0x9DF1B90", VA = "0x189DF2B90", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF26F0", Offset = "0x9DF16F0", VA = "0x189DF26F0")]
		private string UKOLEHHHOUO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0CB0", Offset = "0x9DEFCB0", VA = "0x189DF0CB0")]
		public void SHVISIUNHZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0270", Offset = "0x9DEF270", VA = "0x189DF0270", Slot = "26")]
		public void GFGFUMRQURE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF2600", Offset = "0x9DF1600", VA = "0x189DF2600", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF28C0", Offset = "0x9DF18C0", VA = "0x189DF28C0")]
		[IteratorStateMachine(typeof(DKNLFUMVHSF))]
		private IEnumerator<NVIJVYVFXPY> XAZORADDEIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0C50", Offset = "0x9DEFC50", VA = "0x189DF0C50")]
		private void RPINLRKAUNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0200", Offset = "0x9DEF200", VA = "0x189DF0200")]
		private void DJQPSCLEWQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9DF0570", Offset = "0x9DEF570", VA = "0x189DF0570")]
		private void MUOOFQELMJL(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class EERKMDWMGNB : ZFDAPHSPYER, FWDDJKISYCY
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
		private Dictionary<string, string> UUMBNIIEWCU;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string HGXJPZZGYPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9DEE900", Offset = "0x9DED900", VA = "0x189DEE900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string LEIDNZQQNOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9DEE870", Offset = "0x9DED870", VA = "0x189DEE870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> MNOCALOZIOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9DEE7C0", Offset = "0x9DED7C0", VA = "0x189DEE7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		[UnityEngine.Scripting.Preserve]
		public EERKMDWMGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9DEEC70", Offset = "0x9DEDC70", VA = "0x189DEEC70", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE800", Offset = "0x9DED800", VA = "0x189DEE800", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DEEB90", Offset = "0x9DEDB90", VA = "0x189DEEB90", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DEEA20", Offset = "0x9DEDA20", VA = "0x189DEEA20", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF500", Offset = "0x9DEE500", VA = "0x189DEF500", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF630", Offset = "0x9DEE630", VA = "0x189DEF630", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF150", Offset = "0x9DEE150", VA = "0x189DEF150", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9DEEC00", Offset = "0x9DEDC00", VA = "0x189DEEC00", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF420", Offset = "0x9DEE420", VA = "0x189DEF420", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF490", Offset = "0x9DEE490", VA = "0x189DEF490", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF030", Offset = "0x9DEE030", VA = "0x189DEF030", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x394CF50", Offset = "0x394BF50", VA = "0x18394CF50", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x394A3E0", Offset = "0x39493E0", VA = "0x18394A3E0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF0A0", Offset = "0x9DEE0A0", VA = "0x189DEF0A0", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DEEAF0", Offset = "0x9DEDAF0", VA = "0x189DEEAF0", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF570", Offset = "0x9DEE570", VA = "0x189DEF570", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DEE990", Offset = "0x9DED990", VA = "0x189DEE990", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DEF1C0", Offset = "0x9DEE1C0", VA = "0x189DEF1C0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x394A580", Offset = "0x3949580", VA = "0x18394A580")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x394BD70", Offset = "0x394AD70", VA = "0x18394BD70")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9DEED00", Offset = "0x9DEDD00", VA = "0x189DEED00")]
		private Dictionary<string, string> PCFYDYHEZKG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LLJFKJJXSMP
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action XRKISDBTAJO;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UBYRWVAVOXQ();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task GBCTPUKMHXS(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool QLHKIWLUYDW(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JLHTCBFCYUW(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NCLRDYKOUKR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string ILAFEQKASKK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult LNFBOLAXHNU(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int NJOOZPZHNUY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult WRYJMMZJDUU(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool KAHGEFYOKQP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult LSBTWOVNQUL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float MKFVSXYVZMT(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ZAQKSRDDFCL(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime UPFBRKOZXFQ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult XMTOQFCOTVE(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long QSYOPTZLYGJ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult ADCULKPXVNL(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a JYTIGQBWZNS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult OXNHEWAMGZS<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool BVSKIFANOTC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool OKBBAVGFMZH(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string SMCDNJOWTEE(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult SQZNZFNFZWU(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int IOTSQCRZYTI(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult GAYHJOYWCFY(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool FRHGLHQVNFP(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult EIVRXBDIQZX(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float UDSAUUSGIOZ(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult VUSLVFTVXVT(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime EBYGQYKDLEU(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult UKWCCRNPUNC(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long SIFWJINOHCT(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult JCYHONYVQNF(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void XPXIDRBOXOK<e>(BILDKLRZYOS<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void XJBMXOWBEHH<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable DZEIWCNNNLY();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void ZZDYWQWGVRH(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task RPINLRKAUNA([Optional] CancellationToken a);
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
	public class Preferences : LLJFKJJXSMP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class TIXQYVBTFIZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<TIXQYVBTFIZ> NAENLTJDUQA;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9DF92D0", Offset = "0x9DF82D0", VA = "0x189DF92D0")]
			public static void IEEYZUXTILW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			protected TIXQYVBTFIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class AJULTQXDILE<a> : TIXQYVBTFIZ
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly AJULTQXDILE<a> UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public BILDKLRZYOS<a> VHXLUUGKSBV
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> CXRGVNSOHIH
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool JLIIVGUMTJC
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xEB20A0", Offset = "0xEB10A0", VA = "0x180EB20A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x72EAC50", Offset = "0x72E9C50", VA = "0x1872EAC50")]
			private AJULTQXDILE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x72EA100", Offset = "0x72E9100", VA = "0x1872EA100")]
			public void SIFQFAPRLAF(BILDKLRZYOS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x104ABF0", Offset = "0x1049BF0", VA = "0x18104ABF0", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class MFUJGKSUHZX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences LNDCSVWIATM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object CDEYAHSIJZS;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9DF2F30", Offset = "0x9DF1F30", VA = "0x189DF2F30")]
			public MFUJGKSUHZX(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9DF2F00", Offset = "0x9DF1F00", VA = "0x189DF2F00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF94A0", Offset = "0x9DF84A0", VA = "0x189DF94A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9DF9790", Offset = "0x9DF8790", VA = "0x189DF9790", Slot = "5")]
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
			public FWDDJKISYCY backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9DFA140", Offset = "0x9DF9140", VA = "0x189DFA140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD6E050", Offset = "0xD6D050", VA = "0x180D6E050", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF97F0", Offset = "0x9DF87F0", VA = "0x189DF97F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF9CC0", Offset = "0x9DF8CC0", VA = "0x189DF9CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class UOZCEVSWGOL : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float UGBWVKUXDFX;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public UOZCEVSWGOL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9DFAB80", Offset = "0x9DF9B80", VA = "0x189DFAB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9DFAB40", Offset = "0x9DF9B40", VA = "0x189DFAB40", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ZFDAPHSPYER DFSHVXVKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly ZFDAPHSPYER ZHYDBIGGKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly OKZZSQTUEMJ WZFCGTGJTCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly JBUYDEPBVXS.CustomSaveHandler DXFTFCGRJYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly SMMLEVHGFEC RSNORQBMWXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<FWDDJKISYCY> LJHKDUJIZDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task QJIUXMQVARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> MWYWRXXCTAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private YDHSMJLFZLP HTKBCBETTUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object ZGKJDVJZIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object IFTLVIGKAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long ZVCANGRGCNY;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool BLTVTAHLKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A80D20", Offset = "0x1A7FD20", VA = "0x181A80D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource NACYWWYCXOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD09170", Offset = "0xD08170", VA = "0x180D09170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9DF4570", Offset = "0x9DF3570", VA = "0x189DF4570", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9DF4360", Offset = "0x9DF3360", VA = "0x189DF4360", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9DF48A0", Offset = "0x9DF38A0", VA = "0x189DF48A0")]
		[GEPWJNEAFDW.Root]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6460", Offset = "0x9DF5460", VA = "0x189DF6460")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ZFDAPHSPYER localBackingStore, [Inject("Cloud")] ZFDAPHSPYER cloudBackingStore, [Inject(null)] OKZZSQTUEMJ editorBackingStore, [Inject(null)] EIGPTYHGYCM scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3CC0", Offset = "0x9DF2CC0", VA = "0x189DF3CC0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5800", Offset = "0x9DF4800", VA = "0x189DF5800")]
		private void TDBLUHKFZPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF59C0", Offset = "0x9DF49C0", VA = "0x189DF59C0", Slot = "6")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4190", Offset = "0x9DF3190", VA = "0x189DF4190", Slot = "7")]
		public Task GBCTPUKMHXS(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4610", Offset = "0x9DF3610", VA = "0x189DF4610")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task IRHAIJQJJFL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5B70", Offset = "0x9DF4B70", VA = "0x189DF5B70")]
		private void UXABHOCEJDW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5E70", Offset = "0x9DF4E70", VA = "0x189DF5E70")]
		private void WXLFPPTREYJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6090", Offset = "0x9DF5090", VA = "0x189DF6090")]
		private string YFDXEUZBBTK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3A50", Offset = "0x9DF2A50", VA = "0x189DF3A50")]
		private void DRGRWMFHGCO(AccountPreferenceBackingStoreTypes a, string b, [Out] ZFDAPHSPYER c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3FA0", Offset = "0x9DF2FA0", VA = "0x189DF3FA0")]
		private ZFDAPHSPYER FSWCTLNOULM(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5150", Offset = "0x9DF4150", VA = "0x189DF5150", Slot = "8")]
		public bool QLHKIWLUYDW(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4750", Offset = "0x9DF3750", VA = "0x189DF4750", Slot = "9")]
		public bool JLHTCBFCYUW(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4F10", Offset = "0x9DF3F10", VA = "0x189DF4F10", Slot = "10")]
		public bool NCLRDYKOUKR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4460", Offset = "0x9DF3460", VA = "0x189DF4460", Slot = "11")]
		public string ILAFEQKASKK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4910", Offset = "0x9DF3910", VA = "0x189DF4910", Slot = "12")]
		public SetResult LNFBOLAXHNU(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5090", Offset = "0x9DF4090", VA = "0x189DF5090", Slot = "13")]
		public int NJOOZPZHNUY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5D00", Offset = "0x9DF4D00", VA = "0x189DF5D00", Slot = "14")]
		public SetResult WRYJMMZJDUU(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF47F0", Offset = "0x9DF37F0", VA = "0x189DF47F0", Slot = "15")]
		public bool KAHGEFYOKQP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4A90", Offset = "0x9DF3A90", VA = "0x189DF4A90", Slot = "16")]
		public SetResult LSBTWOVNQUL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4C00", Offset = "0x9DF3C00", VA = "0x189DF4C00", Slot = "17")]
		public float MKFVSXYVZMT(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF62D0", Offset = "0x9DF52D0", VA = "0x189DF62D0", Slot = "18")]
		public SetResult ZAQKSRDDFCL(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5AD0", Offset = "0x9DF4AD0", VA = "0x189DF5AD0", Slot = "19")]
		public DateTime UPFBRKOZXFQ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5EF0", Offset = "0x9DF4EF0", VA = "0x189DF5EF0", Slot = "20")]
		public SetResult XMTOQFCOTVE(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5340", Offset = "0x9DF4340", VA = "0x189DF5340", Slot = "21")]
		public long QSYOPTZLYGJ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9DF36C0", Offset = "0x9DF26C0", VA = "0x189DF36C0", Slot = "22")]
		public SetResult ADCULKPXVNL(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA7C0", Offset = "0x3DE97C0", VA = "0x183DEA7C0", Slot = "23")]
		public a JYTIGQBWZNS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAE90", Offset = "0x3DE9E90", VA = "0x183DEAE90", Slot = "24")]
		public SetResult OXNHEWAMGZS<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9DF39F0", Offset = "0x9DF29F0", VA = "0x189DF39F0", Slot = "25")]
		public bool BVSKIFANOTC(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5140", Offset = "0x9DF4140", VA = "0x189DF5140", Slot = "26")]
		public bool OKBBAVGFMZH(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5690", Offset = "0x9DF4690", VA = "0x189DF5690", Slot = "27")]
		public string SMCDNJOWTEE(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5700", Offset = "0x9DF4700", VA = "0x189DF5700", Slot = "28")]
		public SetResult SQZNZFNFZWU(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4500", Offset = "0x9DF3500", VA = "0x189DF4500", Slot = "29")]
		public int IOTSQCRZYTI(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4160", Offset = "0x9DF3160", VA = "0x189DF4160", Slot = "30")]
		public SetResult GAYHJOYWCFY(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3F30", Offset = "0x9DF2F30", VA = "0x189DF3F30", Slot = "31")]
		public bool FRHGLHQVNFP(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3D70", Offset = "0x9DF2D70", VA = "0x189DF3D70", Slot = "32")]
		public SetResult EIVRXBDIQZX(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5A30", Offset = "0x9DF4A30", VA = "0x189DF5A30", Slot = "33")]
		public float UDSAUUSGIOZ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5CD0", Offset = "0x9DF4CD0", VA = "0x189DF5CD0", Slot = "34")]
		public SetResult VUSLVFTVXVT(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3D00", Offset = "0x9DF2D00", VA = "0x189DF3D00", Slot = "35")]
		public DateTime EBYGQYKDLEU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5AA0", Offset = "0x9DF4AA0", VA = "0x189DF5AA0", Slot = "36")]
		public SetResult UKWCCRNPUNC(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5620", Offset = "0x9DF4620", VA = "0x189DF5620", Slot = "37")]
		public long SIFWJINOHCT(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4720", Offset = "0x9DF3720", VA = "0x189DF4720", Slot = "38")]
		public SetResult JCYHONYVQNF(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4400", Offset = "0x9DF3400", VA = "0x189DF4400")]
		private bool GYDVJFQCIHK(FWDDJKISYCY a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3DD0", Offset = "0x9DF2DD0", VA = "0x189DF3DD0")]
		private bool EPPCIVKZRFV(FWDDJKISYCY a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9DF54D0", Offset = "0x9DF44D0", VA = "0x189DF54D0")]
		private SetResult SCVTJAYEAAR(FWDDJKISYCY a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9DF38B0", Offset = "0x9DF28B0", VA = "0x189DF38B0")]
		private SetResult BNCXYCVGRYV(FWDDJKISYCY a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5200", Offset = "0x9DF4200", VA = "0x189DF5200")]
		private SetResult QLTTPTVZXQE(FWDDJKISYCY a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4020", Offset = "0x9DF3020", VA = "0x189DF4020")]
		private SetResult FWFMSKVNZXY(FWDDJKISYCY a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5850", Offset = "0x9DF4850", VA = "0x189DF5850")]
		private SetResult TRNAHHCRLUJ(FWDDJKISYCY a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5B90", Offset = "0x9DF4B90", VA = "0x189DF5B90")]
		private SetResult UYHFGPCGUKC(FWDDJKISYCY a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA1A0", Offset = "0x3DE91A0", VA = "0x183DEA1A0")]
		private e EIEXTZRXLVZ<e>(FWDDJKISYCY a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE95C0", Offset = "0x3DE85C0", VA = "0x183DE95C0")]
		private SetResult DQGXREVJDQH<f>(FWDDJKISYCY a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB1F0", Offset = "0x3DEA1F0", VA = "0x183DEB1F0", Slot = "39")]
		public void XPXIDRBOXOK<g>(BILDKLRZYOS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB0B0", Offset = "0x3DEA0B0", VA = "0x183DEB0B0", Slot = "40")]
		public void XJBMXOWBEHH<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5730", Offset = "0x9DF4730", VA = "0x189DF5730")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(FWDDJKISYCY backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9DF53E0", Offset = "0x9DF43E0", VA = "0x189DF53E0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task RPINLRKAUNA([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9DF60F0", Offset = "0x9DF50F0", VA = "0x189DF60F0")]
		private void YSFFUJNMVRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3BF0", Offset = "0x9DF2BF0", VA = "0x189DF3BF0", Slot = "41")]
		public IDisposable DZEIWCNNNLY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6450", Offset = "0x9DF5450", VA = "0x189DF6450", Slot = "42")]
		public void ZZDYWQWGVRH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9DF4CB0", Offset = "0x9DF3CB0", VA = "0x189DF4CB0")]
		private void MQEPSBJCPUB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3830", Offset = "0x9DF2830", VA = "0x189DF3830")]
		[IteratorStateMachine(typeof(UOZCEVSWGOL))]
		private IEnumerator<NVIJVYVFXPY> AHVTFFJRHHN(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9DF3DA0", Offset = "0x9DF2DA0", VA = "0x189DF3DA0")]
		[CompilerGenerated]
		private void EJZUZFVLVCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class WTJFSRGMPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9DFAFF0", Offset = "0x9DF9FF0", VA = "0x189DFAFF0")]
		public static string IOZJRACKAHI(this LLJFKJJXSMP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DFAE50", Offset = "0x9DF9E50", VA = "0x189DFAE50")]
		public static byte[] IHZLKOZPYQW(this LLJFKJJXSMP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DFB160", Offset = "0x9DFA160", VA = "0x189DFB160")]
		public static SetResult ZFGXUFKPKIK(this LLJFKJJXSMP a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SXFKOKFITKU : NVNXNDGEDVG<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static SXFKOKFITKU UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9DF8E40", Offset = "0x9DF7E40", VA = "0x189DF8E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8E90", Offset = "0x9DF7E90", VA = "0x189DF8E90", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8F80", Offset = "0x9DF7F80", VA = "0x189DF8F80", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DF9290", Offset = "0x9DF8290", VA = "0x189DF9290")]
		public SXFKOKFITKU()
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
