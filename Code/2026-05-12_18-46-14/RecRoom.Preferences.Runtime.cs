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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D91510", Offset = "0x9D8FF10", VA = "0x189D91510")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D91410", Offset = "0x9D8FE10", VA = "0x189D91410", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D9D2B0", Offset = "0x9D9BCB0", VA = "0x189D9D2B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
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
	internal static class YPCNBRBNUJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(MAEDEWEATHO backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C900", Offset = "0x9D9B300", VA = "0x189D9C900")]
		private static void BWXCGZHDMIP(MAEDEWEATHO a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CEA0", Offset = "0x9D9B8A0", VA = "0x189D9CEA0")]
		public static bool QHBBPJKQROZ(this MAEDEWEATHO a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CAC0", Offset = "0x9D9B4C0", VA = "0x189D9CAC0")]
		public static SetResult FGOFAWVMRQM(this MAEDEWEATHO a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CC10", Offset = "0x9D9B610", VA = "0x189D9CC10")]
		public static SetResult HLKNKFVJXIU(this MAEDEWEATHO a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C980", Offset = "0x9D9B380", VA = "0x189D9C980")]
		public static SetResult DQQNPLREEJL(this MAEDEWEATHO a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CD50", Offset = "0x9D9B750", VA = "0x189D9CD50")]
		public static SetResult QGPBYDGUJFN(this MAEDEWEATHO a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D000", Offset = "0x9D9BA00", VA = "0x189D9D000")]
		public static SetResult UQRAELGAPSE(this MAEDEWEATHO a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D170", Offset = "0x9D9BB70", VA = "0x189D9D170")]
		public static SetResult VAZMVLNCTLV(this MAEDEWEATHO a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WWXNSMKQVLH : ZYZGCDYIPRX, MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log YPBIFIZOQDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ZMWNMZQDNPW TRQELRXZZIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> DHIBJTBECRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> AMCMDPKWVAA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> SIMYHTLYCSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9D9C030", Offset = "0x9D9AA30", VA = "0x189D9C030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C7B0", Offset = "0x9D9B1B0", VA = "0x189D9C7B0")]
		[UnityEngine.Scripting.Preserve]
		public WWXNSMKQVLH([Inject(null)] ZMWNMZQDNPW unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B930", Offset = "0x9D9A330", VA = "0x189D9B930")]
		private DirectoryInfo JFYELQRHWWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF30", Offset = "0x9D9A930", VA = "0x189D9BF30", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A3E0", Offset = "0x9D98DE0", VA = "0x189D9A3E0", Slot = "14")]
		public float BLTYKOCWILM(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B780", Offset = "0x9D9A180", VA = "0x189D9B780", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B6C0", Offset = "0x9D9A0C0", VA = "0x189D9B6C0", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A6C0", Offset = "0x9D990C0", VA = "0x189D9A6C0", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A650", Offset = "0x9D99050", VA = "0x189D9A650", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A5E0", Offset = "0x9D98FE0", VA = "0x189D9A5E0", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BFC0", Offset = "0x9D9A9C0", VA = "0x189D9BFC0", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B430", Offset = "0x9D99E30", VA = "0x189D9B430", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B8C0", Offset = "0x9D9A2C0", VA = "0x189D9B8C0", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A370", Offset = "0x9D98D70", VA = "0x189D9A370", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41230A0", Offset = "0x4121AA0", VA = "0x1841230A0", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4125C80", Offset = "0x4124680", VA = "0x184125C80", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C690", Offset = "0x9D9B090", VA = "0x189D9C690", Slot = "16")]
		public string ZXWWRLSIAEB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B850", Offset = "0x9D9A250", VA = "0x189D9B850", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BA20", Offset = "0x9D9A420", VA = "0x189D9BA20", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A550", Offset = "0x9D98F50", VA = "0x189D9A550", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BC00", Offset = "0x9D9A600", VA = "0x189D9BC00", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C070", Offset = "0x9D9AA70", VA = "0x189D9C070")]
		private void YBWZTRFNQEO(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B4A0", Offset = "0x9D99EA0", VA = "0x189D9B4A0")]
		private static string GJDSCYIXJPJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A450", Offset = "0x9D98E50", VA = "0x189D9A450")]
		private static string BWBYTFGCGGM(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4123280", Offset = "0x4121C80", VA = "0x184123280")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XMNUSNLGNCS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x41249D0", Offset = "0x41233D0", VA = "0x1841249D0")]
		private void Set<T>(string propertyName, T value, [Optional] XMNUSNLGNCS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A730", Offset = "0x9D99130", VA = "0x189D9A730")]
		private Dictionary<string, string> DVEZTXWCVTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B7F0", Offset = "0x9D9A1F0", VA = "0x189D9B7F0")]
		private void HYJETOENGSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BB90", Offset = "0x9D9A590", VA = "0x189D9BB90")]
		private void RQAPUUWYNQN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class RPXHNFLXAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log YPBIFIZOQDI;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9D94720", Offset = "0x9D93120", VA = "0x189D94720")]
		[ONTQUCAGRJW.Root]
		internal static void ONTQUCAGRJW(KLUMUBWDFVY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EFZWFKEXIAG : VKJUBLFJXQP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D90130", Offset = "0x9D8EB30", VA = "0x189D90130")]
		[UnityEngine.Scripting.Preserve]
		public EFZWFKEXIAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KYAEHXPLDXK : ZYZGCDYIPRX, MAEDEWEATHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly ZMWNMZQDNPW TRQELRXZZIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> CTEJUTFNQBE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9D91370", Offset = "0x9D8FD70", VA = "0x189D91370")]
		[UnityEngine.Scripting.Preserve]
		public KYAEHXPLDXK([Inject(null)] ZMWNMZQDNPW unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9D911F0", Offset = "0x9D8FBF0", VA = "0x189D911F0", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9D90CF0", Offset = "0x9D8F6F0", VA = "0x189D90CF0", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9D90E30", Offset = "0x9D8F830", VA = "0x189D90E30", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9D90EA0", Offset = "0x9D8F8A0", VA = "0x189D90EA0", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9D90F10", Offset = "0x9D8F910", VA = "0x189D90F10", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9D90F80", Offset = "0x9D8F980", VA = "0x189D90F80", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9D90C80", Offset = "0x9D8F680", VA = "0x189D90C80", Slot = "14")]
		public float BLTYKOCWILM(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9D91280", Offset = "0x9D8FC80", VA = "0x189D91280", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9D912F0", Offset = "0x9D8FCF0", VA = "0x189D912F0", Slot = "16")]
		public string ZXWWRLSIAEB(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9D90FF0", Offset = "0x9D8F9F0", VA = "0x189D90FF0", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9D90DC0", Offset = "0x9D8F7C0", VA = "0x189D90DC0", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9D90D50", Offset = "0x9D8F750", VA = "0x189D90D50", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9D91060", Offset = "0x9D8FA60", VA = "0x189D91060", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9D90C10", Offset = "0x9D8F610", VA = "0x189D90C10", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C13A40", Offset = "0x3C12440", VA = "0x183C13A40", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C16650", Offset = "0x3C15050", VA = "0x183C16650", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9D910D0", Offset = "0x9D8FAD0", VA = "0x189D910D0", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9D91160", Offset = "0x9D8FB60", VA = "0x189D91160", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C13C20", Offset = "0x3C12620", VA = "0x183C13C20")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XMNUSNLGNCS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C153F0", Offset = "0x3C13DF0", VA = "0x183C153F0")]
		private void Set<T>(string propertyName, T value, [Optional] XMNUSNLGNCS<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class VKJUBLFJXQP : ZYZGCDYIPRX, MAEDEWEATHO, BLNIGADNRIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> LORTIRDGEBL;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9D97570", Offset = "0x9D95F70", VA = "0x189D97570", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9D97120", Offset = "0x9D95B20", VA = "0x189D97120", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9D97240", Offset = "0x9D95C40", VA = "0x189D97240", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9D972A0", Offset = "0x9D95CA0", VA = "0x189D972A0", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9D97300", Offset = "0x9D95D00", VA = "0x189D97300", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9D97360", Offset = "0x9D95D60", VA = "0x189D97360", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9D970C0", Offset = "0x9D95AC0", VA = "0x189D970C0", Slot = "14")]
		public float BLTYKOCWILM(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9D97600", Offset = "0x9D96000", VA = "0x189D97600", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9D97660", Offset = "0x9D96060", VA = "0x189D97660", Slot = "16")]
		public string ZXWWRLSIAEB(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9D973C0", Offset = "0x9D95DC0", VA = "0x189D973C0", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9D971E0", Offset = "0x9D95BE0", VA = "0x189D971E0", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9D97180", Offset = "0x9D95B80", VA = "0x189D97180", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9D97420", Offset = "0x9D95E20", VA = "0x189D97420", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9D97060", Offset = "0x9D95A60", VA = "0x189D97060", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x40DE890", Offset = "0x40DD290", VA = "0x1840DE890", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x40DFD40", Offset = "0x40DE740", VA = "0x1840DFD40", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x40DEC40", Offset = "0x40DD640", VA = "0x1840DEC40")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x40DF6A0", Offset = "0x40DE0A0", VA = "0x1840DF6A0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9D97480", Offset = "0x9D95E80", VA = "0x189D97480", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9D974E0", Offset = "0x9D95EE0", VA = "0x189D974E0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9D90130", Offset = "0x9D8EB30", VA = "0x189D90130")]
		public VKJUBLFJXQP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class IOWRIQBSCBQ<a> where a : MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<IOWRIQBSCBQ<a>> ERSQILJRVCX;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x66BEC60", Offset = "0x66BD660", VA = "0x1866BEC60")]
		protected IOWRIQBSCBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void GJMZXSSBIYC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x66BE850", Offset = "0x66BD250", VA = "0x1866BE850")]
		public static void SFDZQFVYKZO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x66BE0D0", Offset = "0x66BCAD0", VA = "0x1866BE0D0")]
		public static void LSHXAWTPNQE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class IORKLJHUSQH<a, b> : IOWRIQBSCBQ<a> where a : MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly IORKLJHUSQH<a, b> KLCPKUHGTRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> GHLCWCVFKTG;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66BD990", Offset = "0x66BC390", VA = "0x1866BD990")]
		public bool IAMPTCAGJIA(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x66BDB40", Offset = "0x66BC540", VA = "0x1866BDB40")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
		public IEnumerable<KeyValuePair<string, b>> FIYPYJVWDLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x659A8C0", Offset = "0x65992C0", VA = "0x18659A8C0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66BD760", Offset = "0x66BC160", VA = "0x1866BD760", Slot = "5")]
		protected override void GJMZXSSBIYC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x66BDF40", Offset = "0x66BC940", VA = "0x1866BDF40")]
		public IORKLJHUSQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GMLBQBLZGSG();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CIJSKEHSURZ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DLJDDQLZGLD(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EUCLLYCLDJH(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GPSPSLKAWSU(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HAKOZGCKHXS(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float BLTYKOCWILM(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WSSXJXKYWXA(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string ZXWWRLSIAEB(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void HYSXEIUJEAV(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime DILRHLWPVEB(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void CQXSJVOXZKB(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long IVXTURTHPRA(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AFIBUOWSLBU(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MIMDBFUEDMS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ZYZGCDYIPRX : MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action XZCGNIXOVPK;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task UAOGRKUGASA(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface BLNIGADNRIJ : MAEDEWEATHO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class WEQPTAPCPYH : ZYZGCDYIPRX, MAEDEWEATHO
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
			public WEQPTAPCPYH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9D96240", Offset = "0x9D94C40", VA = "0x189D96240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9D96600", Offset = "0x9D95000", VA = "0x189D96600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class DZFKNIHRFWB : IEnumerator<PESYKSMCDNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private PESYKSMCDNI AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public WEQPTAPCPYH AFKVCRAYCVS;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private PESYKSMCDNI TPPDVWBUFIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
			[DebuggerHidden]
			public DZFKNIHRFWB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9D90080", Offset = "0x9D8EA80", VA = "0x189D90080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9D900F0", Offset = "0x9D8EAF0", VA = "0x189D900F0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log YPBIFIZOQDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ZMWNMZQDNPW TRQELRXZZIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool AURPNQOXFAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool AKVITEZZJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HIVJVEKFYXO KYNXOFCTFQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private AMGSXYCAQOJ YSFHOZSDUML;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A270", Offset = "0x9D98C70", VA = "0x189D9A270")]
		[UnityEngine.Scripting.Preserve]
		public WEQPTAPCPYH([Inject(null)] ZMWNMZQDNPW unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9D99E00", Offset = "0x9D98800", VA = "0x189D99E00", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA6E10", Offset = "0x1EA5810", VA = "0x181EA6E10")]
		private static int NDOOHOTYCNM(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9D99170", Offset = "0x9D97B70", VA = "0x189D99170", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9D992E0", Offset = "0x9D97CE0", VA = "0x189D992E0", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9D99520", Offset = "0x9D97F20", VA = "0x189D99520", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9D997D0", Offset = "0x9D981D0", VA = "0x189D997D0", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9D99920", Offset = "0x9D98320", VA = "0x189D99920", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9D97730", Offset = "0x9D96130", VA = "0x189D97730", Slot = "14")]
		public float BLTYKOCWILM(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9D99EF0", Offset = "0x9D988F0", VA = "0x189D99EF0", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9D99270", Offset = "0x9D97C70", VA = "0x189D99270", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9D99190", Offset = "0x9D97B90", VA = "0x189D99190", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9D99BA0", Offset = "0x9D985A0", VA = "0x189D99BA0", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9D976C0", Offset = "0x9D960C0", VA = "0x189D976C0", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x411AEE0", Offset = "0x41198E0", VA = "0x18411AEE0", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x411CBC0", Offset = "0x411B5C0", VA = "0x18411CBC0", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x411BA70", Offset = "0x411A470", VA = "0x18411BA70")]
		private c MFOENVWMTWW<c>(string a, c b, [Optional] XMNUSNLGNCS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x411B0E0", Offset = "0x4119AE0", VA = "0x18411B0E0")]
		private void EKEBARERRIO<d>(string a, d b, [Optional] XMNUSNLGNCS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9D9A050", Offset = "0x9D98A50", VA = "0x189D9A050", Slot = "16")]
		public string ZXWWRLSIAEB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9D99A70", Offset = "0x9D98470", VA = "0x189D99A70", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9D99400", Offset = "0x9D97E00", VA = "0x189D99400")]
		private void DLSGPFVINOY(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9D99630", Offset = "0x9D98030", VA = "0x189D99630")]
		private string FCAPXCDEUUE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9D99C10", Offset = "0x9D98610", VA = "0x189D99C10", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9D99FB0", Offset = "0x9D989B0", VA = "0x189D99FB0")]
		private string YGMECAREDCK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9D97860", Offset = "0x9D96260", VA = "0x189D97860")]
		public void CHTBKJBCALH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9D99E90", Offset = "0x9D98890", VA = "0x189D99E90", Slot = "26")]
		public void USYWXECIYRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9D99D10", Offset = "0x9D98710", VA = "0x189D99D10", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9D99200", Offset = "0x9D97C00", VA = "0x189D99200")]
		[IteratorStateMachine(typeof(DZFKNIHRFWB))]
		private IEnumerator<PESYKSMCDNI> DICHDMZSSLU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9D995D0", Offset = "0x9D97FD0", VA = "0x189D995D0")]
		private void EWTIOQWAWCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9D99A00", Offset = "0x9D98400", VA = "0x189D99A00")]
		private void HYJETOENGSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9D99CA0", Offset = "0x9D986A0", VA = "0x189D99CA0")]
		private void RQAPUUWYNQN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SFHEUVAHGYP : ZYZGCDYIPRX, MAEDEWEATHO
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
		private Dictionary<string, string> AMCMDPKWVAA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string HMETGHEOROT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9D949D0", Offset = "0x9D933D0", VA = "0x189D949D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string BXLRRSHFPYB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9D94FC0", Offset = "0x9D939C0", VA = "0x189D94FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> SIMYHTLYCSK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9D95720", Offset = "0x9D94120", VA = "0x189D95720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		[UnityEngine.Scripting.Preserve]
		public SFHEUVAHGYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9D95620", Offset = "0x9D94020", VA = "0x189D95620", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9D94A60", Offset = "0x9D93460", VA = "0x189D94A60", Slot = "14")]
		public float BLTYKOCWILM(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9D95180", Offset = "0x9D93B80", VA = "0x189D95180", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9D950C0", Offset = "0x9D93AC0", VA = "0x189D950C0", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9D94C40", Offset = "0x9D93640", VA = "0x189D94C40", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9D94BD0", Offset = "0x9D935D0", VA = "0x189D94BD0", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9D94B60", Offset = "0x9D93560", VA = "0x189D94B60", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9D956B0", Offset = "0x9D940B0", VA = "0x189D956B0", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9D95050", Offset = "0x9D93A50", VA = "0x189D95050", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9D95290", Offset = "0x9D93C90", VA = "0x189D95290", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9D94960", Offset = "0x9D93360", VA = "0x189D94960", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F24E10", Offset = "0x3F23810", VA = "0x183F24E10", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F279C0", Offset = "0x3F263C0", VA = "0x183F279C0", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9D95760", Offset = "0x9D94160", VA = "0x189D95760", Slot = "16")]
		public string ZXWWRLSIAEB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9D951F0", Offset = "0x9D93BF0", VA = "0x189D951F0", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9D95300", Offset = "0x9D93D00", VA = "0x189D95300", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9D94AD0", Offset = "0x9D934D0", VA = "0x189D94AD0", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9D953C0", Offset = "0x9D93DC0", VA = "0x189D953C0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F24FF0", Offset = "0x3F239F0", VA = "0x183F24FF0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XMNUSNLGNCS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F267C0", Offset = "0x3F251C0", VA = "0x183F267C0")]
		private void Set<T>(string propertyName, T value, [Optional] XMNUSNLGNCS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9D94CB0", Offset = "0x9D936B0", VA = "0x189D94CB0")]
		private Dictionary<string, string> DVEZTXWCVTA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface STAKPLUPOSH
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action XZCGNIXOVPK;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GMLBQBLZGSG();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task TEAIKVUKCBW(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BONJATKWTZK(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ICZAQRUVMNI(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DYMVMNNRAAZ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string KYDAKNFLOAK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult MTNGMPZFSIW(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int DRZZEBAXMYY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult STJNHIVICVS(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool YCHEJHZSZXB(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult DGVOBEZJIIP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float QHTVVNRRVSL(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ATAYPUGNJBB(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime JFQRVBQZRYW(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult TACYQKNDZDM(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long MNIEYDUDEQB(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult UEEZCHWYXOV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a KHTZNUADIBS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult KOIGJQRIZLG<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool ZCFMTRZVSAU(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool JWNXNXMNZMR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string JBQQHZDEQRS(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult ZWMTZYLZACM(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int CJLEDTSQXGK(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult OZHIKCMRVIS(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool YLJIBDHBWYB(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult BYRAFCRYUNL(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float NWBYZUNXKFH(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult KJLBCFVUZFP(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime SWZHRUAPJGE(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult RCRRBVYDRAU(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long VXUIFIHCIEH(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult BLIORKEOAJZ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ZCKLZZKBCFU<e>(XMNUSNLGNCS<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void DWCUHRRDROR<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable DJAVXWAWGUO();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void UTTDISFDWVP(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task EWTIOQWAWCC([Optional] CancellationToken a);
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
	public class Preferences : STAKPLUPOSH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class TEUFJUZEPQV
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<TEUFJUZEPQV> VAFCXYUOWUU;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9D95810", Offset = "0x9D94210", VA = "0x189D95810")]
			public static void LSHXAWTPNQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			protected TEUFJUZEPQV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class VBAPZYZWYVE<a> : TEUFJUZEPQV
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly VBAPZYZWYVE<a> IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public XMNUSNLGNCS<a> NPRFJTSKYLV
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> AZVXEEDKYQP
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xD11E10", Offset = "0xD10810", VA = "0x180D11E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool FQLONXFJXEQ
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xEA4E10", Offset = "0xEA3810", VA = "0x180EA4E10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x800EA40", Offset = "0x800D440", VA = "0x18800EA40")]
			private VBAPZYZWYVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x800E040", Offset = "0x800CA40", VA = "0x18800E040")]
			public void QCIVJGOFOSZ(XMNUSNLGNCS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1057720", Offset = "0x1056120", VA = "0x181057720", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class GTHVIRLPBSZ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences PYOUHBOYEAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object WRMCSTIDWGY;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9D901E0", Offset = "0x9D8EBE0", VA = "0x189D901E0")]
			public GTHVIRLPBSZ(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9D901B0", Offset = "0x9D8EBB0", VA = "0x189D901B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9D959D0", Offset = "0x9D943D0", VA = "0x189D959D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9D95CB0", Offset = "0x9D946B0", VA = "0x189D95CB0", Slot = "5")]
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
			public MAEDEWEATHO backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9D96660", Offset = "0x9D95060", VA = "0x189D96660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD6DE70", Offset = "0xD6C870", VA = "0x180D6DE70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9D95D10", Offset = "0x9D94710", VA = "0x189D95D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9D961E0", Offset = "0x9D94BE0", VA = "0x189D961E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class GXSIOZAIKLV : IEnumerator<PESYKSMCDNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private PESYKSMCDNI AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float KLPMZWMRNIN;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private PESYKSMCDNI TPPDVWBUFIZ
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
			[DebuggerHidden]
			public GXSIOZAIKLV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9D90290", Offset = "0x9D8EC90", VA = "0x189D90290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9D90320", Offset = "0x9D8ED20", VA = "0x189D90320", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ZYZGCDYIPRX SDCKZJNVLOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly ZYZGCDYIPRX MZPTOIPSCUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly BLNIGADNRIJ VGPCLHYFTDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly HIVJVEKFYXO KYNXOFCTFQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly YPCNBRBNUJO.CustomSaveHandler VZSPWAEABRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly OZHUFMCFCAS MSBMJONYQYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<MAEDEWEATHO> ELLKCWLGDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task KXDPJRTIISR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> VZWVHWVVMMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AMGSXYCAQOJ WBUEMDMYRYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object GOICUSRMALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object CCRPTWDLWYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long TLKWEISWSIG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool LBGXLUHNURO
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A86EE0", Offset = "0x1A858E0", VA = "0x181A86EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource CKTQPPFOULH
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xD0E930", Offset = "0xD0D330", VA = "0x180D0E930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD0E910", Offset = "0xD0D310", VA = "0x180D0E910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9D91B60", Offset = "0x9D90560", VA = "0x189D91B60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9D93E90", Offset = "0x9D92890", VA = "0x189D93E90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9D931A0", Offset = "0x9D91BA0", VA = "0x189D931A0")]
		[ONTQUCAGRJW.Root]
		internal static void NVOLZDRLLVN(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9D94390", Offset = "0x9D92D90", VA = "0x189D94390")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ZYZGCDYIPRX localBackingStore, [Inject("Cloud")] ZYZGCDYIPRX cloudBackingStore, [Inject(null)] BLNIGADNRIJ editorBackingStore, [Inject(null)] HIVJVEKFYXO scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9D922E0", Offset = "0x9D90CE0", VA = "0x189D922E0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9D93AF0", Offset = "0x9D924F0", VA = "0x189D93AF0")]
		private void TBMRSXPLMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9D92410", Offset = "0x9D90E10", VA = "0x189D92410", Slot = "6")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9D93B40", Offset = "0x9D92540", VA = "0x189D93B40", Slot = "7")]
		public Task TEAIKVUKCBW(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9D93090", Offset = "0x9D91A90", VA = "0x189D93090")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task NLIIDWVWNYJ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9D91880", Offset = "0x9D90280", VA = "0x189D91880")]
		private void BBQXQRYTPTK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9D925F0", Offset = "0x9D90FF0", VA = "0x189D925F0")]
		private void HMOBKCELSKR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9D93F40", Offset = "0x9D92940", VA = "0x189D93F40")]
		private string VTAAVCFYDPG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9D92710", Offset = "0x9D91110", VA = "0x189D92710")]
		private void INZMRNIVMDQ(AccountPreferenceBackingStoreTypes a, string b, [Out] ZYZGCDYIPRX c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9D94160", Offset = "0x9D92B60", VA = "0x189D94160")]
		private ZYZGCDYIPRX XTQKAEWVWFE(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9D91AB0", Offset = "0x9D904B0", VA = "0x189D91AB0", Slot = "8")]
		public bool BONJATKWTZK(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9D92670", Offset = "0x9D91070", VA = "0x189D92670", Slot = "9")]
		public bool ICZAQRUVMNI(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9D92160", Offset = "0x9D90B60", VA = "0x189D92160", Slot = "10")]
		public bool DYMVMNNRAAZ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9D92C70", Offset = "0x9D91670", VA = "0x189D92C70", Slot = "11")]
		public string KYDAKNFLOAK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9D92F00", Offset = "0x9D91900", VA = "0x189D92F00", Slot = "12")]
		public SetResult MTNGMPZFSIW(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9D92050", Offset = "0x9D90A50", VA = "0x189D92050", Slot = "13")]
		public int DRZZEBAXMYY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9D93690", Offset = "0x9D92090", VA = "0x189D93690", Slot = "14")]
		public SetResult STJNHIVICVS(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9D941E0", Offset = "0x9D92BE0", VA = "0x189D941E0", Slot = "15")]
		public bool YCHEJHZSZXB(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9D91CA0", Offset = "0x9D906A0", VA = "0x189D91CA0", Slot = "16")]
		public SetResult DGVOBEZJIIP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9D93530", Offset = "0x9D91F30", VA = "0x189D93530", Slot = "17")]
		public float QHTVVNRRVSL(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9D91590", Offset = "0x9D8FF90", VA = "0x189D91590", Slot = "18")]
		public SetResult ATAYPUGNJBB(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9D92920", Offset = "0x9D91320", VA = "0x189D92920", Slot = "19")]
		public DateTime JFQRVBQZRYW(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9D93950", Offset = "0x9D92350", VA = "0x189D93950", Slot = "20")]
		public SetResult TACYQKNDZDM(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9D92E60", Offset = "0x9D91860", VA = "0x189D92E60", Slot = "21")]
		public long MNIEYDUDEQB(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9D93D10", Offset = "0x9D92710", VA = "0x189D93D10", Slot = "22")]
		public SetResult UEEZCHWYXOV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4750", Offset = "0x3DE3150", VA = "0x183DE4750", Slot = "23")]
		public a KHTZNUADIBS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4E30", Offset = "0x3DE3830", VA = "0x183DE4E30", Slot = "24")]
		public SetResult KOIGJQRIZLG<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9D94300", Offset = "0x9D92D00", VA = "0x189D94300", Slot = "25")]
		public bool ZCFMTRZVSAU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9D929C0", Offset = "0x9D913C0", VA = "0x189D929C0", Slot = "26")]
		public bool JWNXNXMNZMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9D928B0", Offset = "0x9D912B0", VA = "0x189D928B0", Slot = "27")]
		public string JBQQHZDEQRS(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9D94360", Offset = "0x9D92D60", VA = "0x189D94360", Slot = "28")]
		public SetResult ZWMTZYLZACM(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9D91C30", Offset = "0x9D90630", VA = "0x189D91C30", Slot = "29")]
		public int CJLEDTSQXGK(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9D933C0", Offset = "0x9D91DC0", VA = "0x189D933C0", Slot = "30")]
		public SetResult OZHIKCMRVIS(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9D94290", Offset = "0x9D92C90", VA = "0x189D94290", Slot = "31")]
		public bool YLJIBDHBWYB(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9D91C00", Offset = "0x9D90600", VA = "0x189D91C00", Slot = "32")]
		public SetResult BYRAFCRYUNL(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9D93210", Offset = "0x9D91C10", VA = "0x189D93210", Slot = "33")]
		public float NWBYZUNXKFH(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9D92C40", Offset = "0x9D91640", VA = "0x189D92C40", Slot = "34")]
		public SetResult KJLBCFVUZFP(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9D93810", Offset = "0x9D92210", VA = "0x189D93810", Slot = "35")]
		public DateTime SWZHRUAPJGE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9D93660", Offset = "0x9D92060", VA = "0x189D93660", Slot = "36")]
		public SetResult RCRRBVYDRAU(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9D93FA0", Offset = "0x9D929A0", VA = "0x189D93FA0", Slot = "37")]
		public long VXUIFIHCIEH(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9D91A80", Offset = "0x9D90480", VA = "0x189D91A80", Slot = "38")]
		public SetResult BLIORKEOAJZ(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9D92100", Offset = "0x9D90B00", VA = "0x189D92100")]
		private bool DTXJSDPVZFW(MAEDEWEATHO a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9D91EF0", Offset = "0x9D908F0", VA = "0x189D91EF0")]
		private bool DORHBOWXNDV(MAEDEWEATHO a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9D92D10", Offset = "0x9D91710", VA = "0x189D92D10")]
		private SetResult MEXEFCADRZX(MAEDEWEATHO a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9D933F0", Offset = "0x9D91DF0", VA = "0x189D933F0")]
		private SetResult PZGLGRZWIQV(MAEDEWEATHO a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9D92480", Offset = "0x9D90E80", VA = "0x189D92480")]
		private SetResult GMRXDEWOSEE(MAEDEWEATHO a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9D94010", Offset = "0x9D92A10", VA = "0x189D94010")]
		private SetResult XROPQRIREJE(MAEDEWEATHO a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9D91710", Offset = "0x9D90110", VA = "0x189D91710")]
		private SetResult AXPDCJQIYCV(MAEDEWEATHO a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9D93280", Offset = "0x9D91C80", VA = "0x189D93280")]
		private SetResult ORWHKLRVQJI(MAEDEWEATHO a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4090", Offset = "0x3DE2A90", VA = "0x183DE4090")]
		private e CUPIOKCAQDN<e>(MAEDEWEATHO a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5820", Offset = "0x3DE4220", VA = "0x183DE5820")]
		private SetResult ZTXWNJTTUTZ<f>(MAEDEWEATHO a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE50F0", Offset = "0x3DE3AF0", VA = "0x183DE50F0", Slot = "39")]
		public void ZCKLZZKBCFU<g>(XMNUSNLGNCS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4530", Offset = "0x3DE2F30", VA = "0x183DE4530", Slot = "40")]
		public void DWCUHRRDROR<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9D93880", Offset = "0x9D92280", VA = "0x189D93880")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(MAEDEWEATHO backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9D92320", Offset = "0x9D90D20", VA = "0x189D92320", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task EWTIOQWAWCC([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9D918A0", Offset = "0x9D902A0", VA = "0x189D918A0")]
		private void BJIJVARXANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9D91E20", Offset = "0x9D90820", VA = "0x189D91E20", Slot = "41")]
		public IDisposable DJAVXWAWGUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9D93F30", Offset = "0x9D92930", VA = "0x189D93F30", Slot = "42")]
		public void UTTDISFDWVP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9D929D0", Offset = "0x9D913D0", VA = "0x189D929D0")]
		private void KCZZAUSBHXH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9D935E0", Offset = "0x9D91FE0", VA = "0x189D935E0")]
		[IteratorStateMachine(typeof(GXSIOZAIKLV))]
		private IEnumerator<PESYKSMCDNI> QSLAKUXSETV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9D925C0", Offset = "0x9D90FC0", VA = "0x189D925C0")]
		[CompilerGenerated]
		private void HCLPUALJGTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class IWVKLSHGGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9D90AA0", Offset = "0x9D8F4A0", VA = "0x189D90AA0")]
		public static string VZHQQVXKFIW(this STAKPLUPOSH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9D907F0", Offset = "0x9D8F1F0", VA = "0x189D907F0")]
		public static byte[] IMWCTDKCFPQ(this STAKPLUPOSH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9D90990", Offset = "0x9D8F390", VA = "0x189D90990")]
		public static SetResult LPCVDHIWZTU(this STAKPLUPOSH a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HQWSNDABMLK : DCDRIKKOMXS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HQWSNDABMLK IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9D90360", Offset = "0x9D8ED60", VA = "0x189D90360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9D903B0", Offset = "0x9D8EDB0", VA = "0x189D903B0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9D904A0", Offset = "0x9D8EEA0", VA = "0x189D904A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9D907B0", Offset = "0x9D8F1B0", VA = "0x189D907B0")]
		public HQWSNDABMLK()
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
