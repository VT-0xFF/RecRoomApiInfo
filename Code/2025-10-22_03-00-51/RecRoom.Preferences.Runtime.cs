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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88FC290", Offset = "0x88FA890", VA = "0x1888FC290")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		[Cpp2IlInjected.Address(RVA = "0x8901970", Offset = "0x88FFF70", VA = "0x188901970", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
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
	internal static class CDVJEUBDKIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal delegate void CustomSaveHandler(PUYYYWQIUWI backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88F9300", Offset = "0x88F7900", VA = "0x1888F9300")]
		private static void OEOSNUJKCVR(PUYYYWQIUWI a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88F94C0", Offset = "0x88F7AC0", VA = "0x1888F94C0")]
		public static bool SZUQPUNBMND(this PUYYYWQIUWI a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88F9040", Offset = "0x88F7640", VA = "0x1888F9040")]
		public static SetResult IZAUJTSGFSM(this PUYYYWQIUWI a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88F8F00", Offset = "0x88F7500", VA = "0x1888F8F00")]
		public static SetResult ESQMEASTKWQ(this PUYYYWQIUWI a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88F8C70", Offset = "0x88F7270", VA = "0x1888F8C70")]
		public static SetResult APUMEENRRAN(this PUYYYWQIUWI a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88F8DB0", Offset = "0x88F73B0", VA = "0x1888F8DB0")]
		public static SetResult CEPMBALDEYP(this PUYYYWQIUWI a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88F9190", Offset = "0x88F7790", VA = "0x1888F9190")]
		public static SetResult NMZYSUFQEUI(this PUYYYWQIUWI a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88F9380", Offset = "0x88F7980", VA = "0x1888F9380")]
		public static SetResult PWQEQLDNWKX(this PUYYYWQIUWI a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class JGZTDZRYWEV : OGWQRXNLIPL, PUYYYWQIUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly URUZRICFKHG ASNPMVJRFZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, byte> JYXIWHGSNSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Dictionary<string, string> WTYGWIDKXPW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> QETQPUEMOXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x88FAF40", Offset = "0x88F9540", VA = "0x1888FAF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IQYRCEIWXCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88FB810", Offset = "0x88F9E10", VA = "0x1888FB810")]
		[UnityEngine.Scripting.Preserve]
		public JGZTDZRYWEV([Inject(null)] URUZRICFKHG unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public void ZAQXIFEHIUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88FA380", Offset = "0x88F8980", VA = "0x1888FA380")]
		private DirectoryInfo EMAGVQZZDBW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88FB6A0", Offset = "0x88F9CA0", VA = "0x1888FB6A0", Slot = "6")]
		public Task WPEMQDQHRAU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88FB270", Offset = "0x88F9870", VA = "0x1888FB270", Slot = "14")]
		public float PSVIDHNOCLA(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88FAF80", Offset = "0x88F9580", VA = "0x1888FAF80", Slot = "13")]
		public void JFLOTDPLZXW(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88FB0D0", Offset = "0x88F96D0", VA = "0x1888FB0D0", Slot = "12")]
		public bool LAQJKUKAHFO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88FB190", Offset = "0x88F9790", VA = "0x1888FB190", Slot = "10")]
		public int NBKKJJNMVWN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88FAFF0", Offset = "0x88F95F0", VA = "0x1888FAFF0", Slot = "18")]
		public DateTime KETQRKUVITT(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88FB7A0", Offset = "0x88F9DA0", VA = "0x1888FB7A0", Slot = "19")]
		public void ZFQCYGPTECR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88FB200", Offset = "0x88F9800", VA = "0x1888FB200", Slot = "15")]
		public void PPWDDJJLKTU(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88F9D00", Offset = "0x88F8300", VA = "0x1888F9D00", Slot = "11")]
		public void AHQBTUVTKKV(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88FB730", Offset = "0x88F9D30", VA = "0x1888FB730", Slot = "20")]
		public long WUBIAQMDGDE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88FA1C0", Offset = "0x88F87C0", VA = "0x1888FA1C0", Slot = "21")]
		public void DOIXXSUIBLU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37ECA80", Offset = "0x37EB080", VA = "0x1837ECA80", Slot = "22")]
		public a FNBAKVXDRFJ<a>(string a, a b, XEMGIITTIKS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37EE2C0", Offset = "0x37EC8C0", VA = "0x1837EE2C0", Slot = "23")]
		public void PZISRUNOEBR<b>(string a, b b, XEMGIITTIKS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88F9D70", Offset = "0x88F8370", VA = "0x1888F9D70", Slot = "16")]
		public string CABXOKJZAOR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88FB060", Offset = "0x88F9660", VA = "0x1888FB060", Slot = "17")]
		public void KJYZBMJCJHX(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88FA230", Offset = "0x88F8830", VA = "0x1888FA230", Slot = "24")]
		public void EHTVBIHYLDA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88FB2E0", Offset = "0x88F98E0", VA = "0x1888FB2E0", Slot = "9")]
		public bool RSCFFNPLZUL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88FB370", Offset = "0x88F9970", VA = "0x1888FB370", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88F9E20", Offset = "0x88F8420", VA = "0x1888F9E20")]
		private void DEXAVVINTLQ(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88FAD40", Offset = "0x88F9340", VA = "0x1888FAD40")]
		private static string JAKOENBYWQX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88FAC40", Offset = "0x88F9240", VA = "0x1888FAC40")]
		private static string GJTBULXMOFK(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x397D980", Offset = "0x397BF80", VA = "0x18397D980")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XEMGIITTIKS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x397EF90", Offset = "0x397D590", VA = "0x18397EF90")]
		private void Set<T>(string propertyName, T value, [Optional] XEMGIITTIKS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88FA470", Offset = "0x88F8A70", VA = "0x1888FA470")]
		private Dictionary<string, string> EQMKEBFUOJE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class ADTVFOENFQZ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88F8700", Offset = "0x88F6D00", VA = "0x1888F8700")]
		[ZOKCDQOPSGU.Root]
		internal static void ZOKCDQOPSGU(KUXAUVMITFU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SVZSRKITVPI : HGNOWWIXZVZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88F9C80", Offset = "0x88F8280", VA = "0x1888F9C80")]
		[UnityEngine.Scripting.Preserve]
		public SVZSRKITVPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class HGNOWWIXZVZ : OGWQRXNLIPL, PUYYYWQIUWI, BEDDDBTTNNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, object> RLIIEUVPOUB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action IQYRCEIWXCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public void ZAQXIFEHIUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88F9B30", Offset = "0x88F8130", VA = "0x1888F9B30", Slot = "6")]
		public Task WPEMQDQHRAU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88F9A40", Offset = "0x88F8040", VA = "0x1888F9A40", Slot = "9")]
		public bool RSCFFNPLZUL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88F9920", Offset = "0x88F7F20", VA = "0x1888F9920", Slot = "10")]
		public int NBKKJJNMVWN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88F9620", Offset = "0x88F7C20", VA = "0x1888F9620", Slot = "11")]
		public void AHQBTUVTKKV(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88F98C0", Offset = "0x88F7EC0", VA = "0x1888F98C0", Slot = "12")]
		public bool LAQJKUKAHFO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88F97A0", Offset = "0x88F7DA0", VA = "0x1888F97A0", Slot = "13")]
		public void JFLOTDPLZXW(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88F99E0", Offset = "0x88F7FE0", VA = "0x1888F99E0", Slot = "14")]
		public float PSVIDHNOCLA(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88F9980", Offset = "0x88F7F80", VA = "0x1888F9980", Slot = "15")]
		public void PPWDDJJLKTU(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88F9680", Offset = "0x88F7C80", VA = "0x1888F9680", Slot = "16")]
		public string CABXOKJZAOR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88F9860", Offset = "0x88F7E60", VA = "0x1888F9860", Slot = "17")]
		public void KJYZBMJCJHX(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88F9800", Offset = "0x88F7E00", VA = "0x1888F9800", Slot = "18")]
		public DateTime KETQRKUVITT(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88F9C20", Offset = "0x88F8220", VA = "0x1888F9C20", Slot = "19")]
		public void ZFQCYGPTECR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88F9BC0", Offset = "0x88F81C0", VA = "0x1888F9BC0", Slot = "20")]
		public long WUBIAQMDGDE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88F96E0", Offset = "0x88F7CE0", VA = "0x1888F96E0", Slot = "21")]
		public void DOIXXSUIBLU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38F3C10", Offset = "0x38F2210", VA = "0x1838F3C10", Slot = "22")]
		public a FNBAKVXDRFJ<a>(string a, a b, XEMGIITTIKS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38F4A70", Offset = "0x38F3070", VA = "0x1838F4A70", Slot = "23")]
		public void PZISRUNOEBR<b>(string a, b b, XEMGIITTIKS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x38F3FD0", Offset = "0x38F25D0", VA = "0x1838F3FD0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x38F4CE0", Offset = "0x38F32E0", VA = "0x1838F4CE0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88F9740", Offset = "0x88F7D40", VA = "0x1888F9740", Slot = "24")]
		public void EHTVBIHYLDA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88F9AA0", Offset = "0x88F80A0", VA = "0x1888F9AA0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88F9C80", Offset = "0x88F8280", VA = "0x1888F9C80")]
		public HGNOWWIXZVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class CXWYIIUXMYG<a> where a : PUYYYWQIUWI
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly HashSet<CXWYIIUXMYG<a>> AYYPBFWSTLJ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4113570", Offset = "0x4111B70", VA = "0x184113570")]
		protected CXWYIIUXMYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void XNVSSGSJWCK(string a);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4112D00", Offset = "0x4111300", VA = "0x184112D00")]
		public static void UJVQVNSNFZW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4112EF0", Offset = "0x41114F0", VA = "0x184112EF0")]
		public static void UPBVKBGPLUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CXRRLCBADMX<a, b> : CXWYIIUXMYG<a> where a : PUYYYWQIUWI
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly CXRRLCBADMX<a, b> AMLVLGFTEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, b> OVXNWTAELQM;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x41124F0", Offset = "0x4110AF0", VA = "0x1841124F0")]
		public bool ZKJFYFPTSEI(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4112100", Offset = "0x4110700", VA = "0x184112100")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x41120A0", Offset = "0x41106A0", VA = "0x1841120A0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x41123E0", Offset = "0x41109E0", VA = "0x1841123E0", Slot = "5")]
		protected override void XNVSSGSJWCK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x41128C0", Offset = "0x4110EC0", VA = "0x1841128C0")]
		public CXRRLCBADMX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PUYYYWQIUWI
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZAQXIFEHIUO();

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RSCFFNPLZUL(string a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int NBKKJJNMVWN(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AHQBTUVTKKV(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LAQJKUKAHFO(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JFLOTDPLZXW(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float PSVIDHNOCLA(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void PPWDDJJLKTU(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string CABXOKJZAOR(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KJYZBMJCJHX(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime KETQRKUVITT(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ZFQCYGPTECR(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long WUBIAQMDGDE(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void DOIXXSUIBLU(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a FNBAKVXDRFJ<a>(string a, a b, XEMGIITTIKS<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void PZISRUNOEBR<b>(string a, b b, XEMGIITTIKS<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void EHTVBIHYLDA(string a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface OGWQRXNLIPL : PUYYYWQIUWI
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action IQYRCEIWXCY;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task WPEMQDQHRAU(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BEDDDBTTNNL : PUYYYWQIUWI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JRUJXZWBZOX : OGWQRXNLIPL, PUYYYWQIUWI
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
			public JRUJXZWBZOX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8900FA0", Offset = "0x88FF5A0", VA = "0x188900FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8901360", Offset = "0x88FF960", VA = "0x188901360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class YYCYXBWJAXU : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JRUJXZWBZOX CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public YYCYXBWJAXU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x89018C0", Offset = "0x88FFEC0", VA = "0x1889018C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8901930", Offset = "0x88FFF30", VA = "0x188901930", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly URUZRICFKHG ASNPMVJRFZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool SATZKFYDVDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool ZLRJGLHCYVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HYPGBLDUZXO HLSDDDLLWHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private RBEAVUYSDOZ HSGREESIWTZ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action IQYRCEIWXCY
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88FC0B0", Offset = "0x88FA6B0", VA = "0x1888FC0B0")]
		[UnityEngine.Scripting.Preserve]
		public JRUJXZWBZOX([Inject(null)] URUZRICFKHG unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public void ZAQXIFEHIUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88FBF20", Offset = "0x88FA520", VA = "0x1888FBF20", Slot = "6")]
		public Task WPEMQDQHRAU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E825D0", Offset = "0x1E80BD0", VA = "0x181E825D0")]
		private static int TTWFLOJLYFY(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88FBE10", Offset = "0x88FA410", VA = "0x1888FBE10", Slot = "9")]
		public bool RSCFFNPLZUL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88FBC80", Offset = "0x88FA280", VA = "0x1888FBC80", Slot = "10")]
		public int NBKKJJNMVWN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88FB8D0", Offset = "0x88F9ED0", VA = "0x1888FB8D0", Slot = "11")]
		public void AHQBTUVTKKV(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88FBC50", Offset = "0x88FA250", VA = "0x1888FBC50", Slot = "12")]
		public bool LAQJKUKAHFO(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x88FBB10", Offset = "0x88FA110", VA = "0x1888FBB10", Slot = "13")]
		public void JFLOTDPLZXW(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88FBD40", Offset = "0x88FA340", VA = "0x1888FBD40", Slot = "14")]
		public float PSVIDHNOCLA(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88FBD10", Offset = "0x88FA310", VA = "0x1888FBD10", Slot = "15")]
		public void PPWDDJJLKTU(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x88FBB40", Offset = "0x88FA140", VA = "0x1888FBB40", Slot = "18")]
		public DateTime KETQRKUVITT(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88FC040", Offset = "0x88FA640", VA = "0x1888FC040", Slot = "19")]
		public void ZFQCYGPTECR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x88FBFB0", Offset = "0x88FA5B0", VA = "0x1888FBFB0", Slot = "20")]
		public long WUBIAQMDGDE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88FB930", Offset = "0x88F9F30", VA = "0x1888FB930", Slot = "21")]
		public void DOIXXSUIBLU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3981AE0", Offset = "0x39800E0", VA = "0x183981AE0", Slot = "22")]
		public a FNBAKVXDRFJ<a>(string a, a b, XEMGIITTIKS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x39825F0", Offset = "0x3980BF0", VA = "0x1839825F0", Slot = "23")]
		public void PZISRUNOEBR<b>(string a, b b, XEMGIITTIKS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3982840", Offset = "0x3980E40", VA = "0x183982840")]
		private c VGKVVUDBPOC<c>(string a, c b, [Optional] XEMGIITTIKS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3981DA0", Offset = "0x39803A0", VA = "0x183981DA0")]
		private void KSRHHUTHNKW<d>(string a, d b, [Optional] XEMGIITTIKS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x88FB900", Offset = "0x88F9F00", VA = "0x1888FB900", Slot = "16")]
		public string CABXOKJZAOR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x88FBC20", Offset = "0x88FA220", VA = "0x1888FBC20", Slot = "17")]
		public void KJYZBMJCJHX(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x88FB8B0", Offset = "0x88F9EB0", VA = "0x1888FB8B0")]
		private void AHGCDLHESJS(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x88FC020", Offset = "0x88FA620", VA = "0x1888FC020")]
		private string YBWOXSHSFEU(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88FB9A0", Offset = "0x88F9FA0", VA = "0x1888FB9A0", Slot = "24")]
		public void EHTVBIHYLDA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x88FBD70", Offset = "0x88FA370", VA = "0x1888FBD70")]
		private string QQXCKTFXXBQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x88FBE30", Offset = "0x88FA430", VA = "0x1888FBE30", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88FBAA0", Offset = "0x88FA0A0", VA = "0x1888FBAA0")]
		[IteratorStateMachine(typeof(YYCYXBWJAXU))]
		private IEnumerator<SGCTHXNJFVM> HGGQHKFKYMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x88FBCB0", Offset = "0x88FA2B0", VA = "0x1888FBCB0")]
		private void PJGLYAMDEYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x88FBBB0", Offset = "0x88FA1B0", VA = "0x1888FBBB0")]
		private void KJVNFWLHEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x88FBA30", Offset = "0x88FA030", VA = "0x1888FBA30")]
		private void FYXJLNARDHL(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class QVHBCYTGDTJ : OGWQRXNLIPL, PUYYYWQIUWI
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
		private Dictionary<string, string> WTYGWIDKXPW;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string XJWRXVLQQQP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x88FFCC0", Offset = "0x88FE2C0", VA = "0x1888FFCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string TEVKYUDJJUF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x88FF940", Offset = "0x88FDF40", VA = "0x1888FF940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Dictionary<string, string> QETQPUEMOXE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x88FF9D0", Offset = "0x88FDFD0", VA = "0x1888FF9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action IQYRCEIWXCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		[UnityEngine.Scripting.Preserve]
		public QVHBCYTGDTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public void ZAQXIFEHIUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8900120", Offset = "0x88FE720", VA = "0x188900120", Slot = "6")]
		public Task WPEMQDQHRAU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x88FFDC0", Offset = "0x88FE3C0", VA = "0x1888FFDC0", Slot = "14")]
		public float PSVIDHNOCLA(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x88FFA10", Offset = "0x88FE010", VA = "0x1888FFA10", Slot = "13")]
		public void JFLOTDPLZXW(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x88FFB90", Offset = "0x88FE190", VA = "0x1888FFB90", Slot = "12")]
		public bool LAQJKUKAHFO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x88FFC50", Offset = "0x88FE250", VA = "0x1888FFC50", Slot = "10")]
		public int NBKKJJNMVWN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x88FFA80", Offset = "0x88FE080", VA = "0x1888FFA80", Slot = "18")]
		public DateTime KETQRKUVITT(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8900220", Offset = "0x88FE820", VA = "0x188900220", Slot = "19")]
		public void ZFQCYGPTECR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88FFD50", Offset = "0x88FE350", VA = "0x1888FFD50", Slot = "15")]
		public void PPWDDJJLKTU(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x88FF440", Offset = "0x88FDA40", VA = "0x1888FF440", Slot = "11")]
		public void AHQBTUVTKKV(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89001B0", Offset = "0x88FE7B0", VA = "0x1889001B0", Slot = "20")]
		public long WUBIAQMDGDE(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x88FF560", Offset = "0x88FDB60", VA = "0x1888FF560", Slot = "21")]
		public void DOIXXSUIBLU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x37ECA80", Offset = "0x37EB080", VA = "0x1837ECA80", Slot = "22")]
		public a FNBAKVXDRFJ<a>(string a, a b, XEMGIITTIKS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x37EE2C0", Offset = "0x37EC8C0", VA = "0x1837EE2C0", Slot = "23")]
		public void PZISRUNOEBR<b>(string a, b b, XEMGIITTIKS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x88FF4B0", Offset = "0x88FDAB0", VA = "0x1888FF4B0", Slot = "16")]
		public string CABXOKJZAOR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x88FFAF0", Offset = "0x88FE0F0", VA = "0x1888FFAF0", Slot = "17")]
		public void KJYZBMJCJHX(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x88FF5D0", Offset = "0x88FDBD0", VA = "0x1888FF5D0", Slot = "24")]
		public void EHTVBIHYLDA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x88FFE30", Offset = "0x88FE430", VA = "0x1888FFE30", Slot = "9")]
		public bool RSCFFNPLZUL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x88FFEC0", Offset = "0x88FE4C0", VA = "0x1888FFEC0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C37AE0", Offset = "0x3C360E0", VA = "0x183C37AE0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XEMGIITTIKS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C39170", Offset = "0x3C37770", VA = "0x183C39170")]
		private void Set<T>(string propertyName, T value, [Optional] XEMGIITTIKS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x88FF690", Offset = "0x88FDC90", VA = "0x1888FF690")]
		private Dictionary<string, string> EQMKEBFUOJE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface WQEISMLFQPB
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action IQYRCEIWXCY;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZAQXIFEHIUO();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task FQFAEYONUYE(long a);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool WGMCODYCASY(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KAHYYUVJTQC(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JWCWIZAFJLD(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string ZEUBPUTVDHE(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult FIJYCJPBQAK(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int NEVPAIXCBJG(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult ISUPFWNHQRW(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool DBJRAKBBNRZ(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult CZEEDZLKQHN(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float VQVOLMEXINF(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ZYPKKBSMAGX(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime JKOVTGFEGYG(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult WRIORUXILTA(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long RMVJQYYHLYR(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult UDZMHEOYKAJ(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a YLXHXLDPIQY<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult ZAJRAUBUCUM<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool KMASJWLCYIY(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool NZJNDQHSUEZ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string BLWWKFUTLXG(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult QLDXOHKZPEY(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int MMHZPDFKMLI(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult RCSWKLQJLIW(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool KWCBDIHDGUN(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult PSCDMQOIXYN(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float QWWEBKXNFOF(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult EDZMBUXPASV(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime OEVHWOKCPGQ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult YIMYBNIBMAM(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long QRGIZREKFIX(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult NOFVVBTEXNJ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void IHJFFMCGPJE<e>(XEMGIITTIKS<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void HMEVRICNJGF<f>();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable INGQQGTAVCS();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void FDMINYKQWDH(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task PJGLYAMDEYC([Optional] CancellationToken a);
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
	public class Preferences : WQEISMLFQPB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private abstract class UKXBWTYMNDL
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			protected static readonly HashSet<UKXBWTYMNDL> JBRVUZFOOAI;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8901630", Offset = "0x88FFC30", VA = "0x188901630")]
			public static void UPBVKBGPLUI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			protected UKXBWTYMNDL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private class NXQHVUPNJZM<a> : UKXBWTYMNDL
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly NXQHVUPNJZM<a> ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public XEMGIITTIKS<a> RUOHSWDHYAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IEqualityComparer<a> GWDXJXHEARR
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool OCIRMPPYHNC
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x5A8FDC0", Offset = "0x5A8E3C0", VA = "0x185A8FDC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5A90550", Offset = "0x5A8EB50", VA = "0x185A90550")]
			private NXQHVUPNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x5A8FFB0", Offset = "0x5A8E5B0", VA = "0x185A8FFB0")]
			public void KQPXXDZDTRT(XEMGIITTIKS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5A8FD70", Offset = "0x5A8E370", VA = "0x185A8FD70", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class LBPNVPLZNZP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private readonly Preferences SKCFQLHZXMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly object IXASHPFLJSI;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x88FC1E0", Offset = "0x88FA7E0", VA = "0x1888FC1E0")]
			public LBPNVPLZNZP(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x88FC1B0", Offset = "0x88FA7B0", VA = "0x1888FC1B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8900720", Offset = "0x88FED20", VA = "0x188900720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8900A10", Offset = "0x88FF010", VA = "0x188900A10", Slot = "5")]
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
			public PUYYYWQIUWI backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x89013C0", Offset = "0x88FF9C0", VA = "0x1889013C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8900A70", Offset = "0x88FF070", VA = "0x188900A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8900F40", Offset = "0x88FF540", VA = "0x188900F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WKCRLDQFQDR : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Preferences CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float XLWRPXTMLKV;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public WKCRLDQFQDR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x89017F0", Offset = "0x88FFDF0", VA = "0x1889017F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8901880", Offset = "0x88FFE80", VA = "0x188901880", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly OGWQRXNLIPL RISCYUKKQOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly OGWQRXNLIPL GUFCYTDTSCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly BEDDDBTTNNL GMNHQWQJLRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly HYPGBLDUZXO HLSDDDLLWHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly CDVJEUBDKIM.CustomSaveHandler NQMOBDVUTNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly ZCBRZWUWSEW DJBUMSNRSSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<PUYYYWQIUWI> MEMIXTAPDAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task NTGHHNRKOZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<string, string> ZVGEHOSSRRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private RBEAVUYSDOZ SOHSIANALVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly object BEHOPCIUOUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly object LPDPNVJUJYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private long OJRJVMUVKGO;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool QLLRGQFKVXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1A8E250", Offset = "0x1A8C850", VA = "0x181A8E250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CancellationTokenSource SNJTPQYHTZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action IQYRCEIWXCY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x88FC740", Offset = "0x88FAD40", VA = "0x1888FC740", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x88FDEF0", Offset = "0x88FC4F0", VA = "0x1888FDEF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x88FCEF0", Offset = "0x88FB4F0", VA = "0x1888FCEF0")]
		[ZOKCDQOPSGU.Root]
		internal static void GVEUOOVHRBJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x88FF0B0", Offset = "0x88FD6B0", VA = "0x1888FF0B0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] OGWQRXNLIPL localBackingStore, [Inject("Cloud")] OGWQRXNLIPL cloudBackingStore, [Inject(null)] BEDDDBTTNNL editorBackingStore, [Inject(null)] HYPGBLDUZXO scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x88FC860", Offset = "0x88FAE60", VA = "0x1888FC860", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x88FDCC0", Offset = "0x88FC2C0", VA = "0x1888FDCC0")]
		private void PUUDYSRTYFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x88FEB80", Offset = "0x88FD180", VA = "0x1888FEB80", Slot = "6")]
		public void ZAQXIFEHIUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x88FCD20", Offset = "0x88FB320", VA = "0x1888FCD20", Slot = "7")]
		public Task FQFAEYONUYE(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x88FC3B0", Offset = "0x88FA9B0", VA = "0x1888FC3B0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task CARXYWVWPOJ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x88FD670", Offset = "0x88FBC70", VA = "0x1888FD670")]
		private void KXHIWUPUPYE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x88FC7E0", Offset = "0x88FADE0", VA = "0x1888FC7E0")]
		private void DYYONKCDLQF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x88FC6E0", Offset = "0x88FACE0", VA = "0x1888FC6E0")]
		private string DCTFTNMZSWA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x88FED10", Offset = "0x88FD310", VA = "0x1888FED10")]
		private void ZLYLFMWPLIW(AccountPreferenceBackingStoreTypes a, string b, [Out] OGWQRXNLIPL c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x88FEEB0", Offset = "0x88FD4B0", VA = "0x1888FEEB0")]
		private OGWQRXNLIPL ZUEGBSWONHY(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x88FE900", Offset = "0x88FCF00", VA = "0x1888FE900", Slot = "8")]
		public bool WGMCODYCASY(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x88FD500", Offset = "0x88FBB00", VA = "0x1888FD500", Slot = "9")]
		public bool KAHYYUVJTQC(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x88FD380", Offset = "0x88FB980", VA = "0x1888FD380", Slot = "10")]
		public bool JWCWIZAFJLD(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x88FEBF0", Offset = "0x88FD1F0", VA = "0x1888FEBF0", Slot = "11")]
		public string ZEUBPUTVDHE(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x88FCBA0", Offset = "0x88FB1A0", VA = "0x1888FCBA0", Slot = "12")]
		public SetResult FIJYCJPBQAK(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x88FD700", Offset = "0x88FBD00", VA = "0x1888FD700", Slot = "13")]
		public int NEVPAIXCBJG(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x88FD170", Offset = "0x88FB770", VA = "0x1888FD170", Slot = "14")]
		public SetResult ISUPFWNHQRW(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x88FC630", Offset = "0x88FAC30", VA = "0x1888FC630", Slot = "15")]
		public bool DBJRAKBBNRZ(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x88FC4C0", Offset = "0x88FAAC0", VA = "0x1888FC4C0", Slot = "16")]
		public SetResult CZEEDZLKQHN(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x88FE5D0", Offset = "0x88FCBD0", VA = "0x1888FE5D0", Slot = "17")]
		public float VQVOLMEXINF(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x88FEF30", Offset = "0x88FD530", VA = "0x1888FEF30", Slot = "18")]
		public SetResult ZYPKKBSMAGX(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x88FD2E0", Offset = "0x88FB8E0", VA = "0x1888FD2E0", Slot = "19")]
		public DateTime JKOVTGFEGYG(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x88FE9B0", Offset = "0x88FCFB0", VA = "0x1888FE9B0", Slot = "20")]
		public SetResult WRIORUXILTA(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x88FDE50", Offset = "0x88FC450", VA = "0x1888FDE50", Slot = "21")]
		public long RMVJQYYHLYR(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x88FE1A0", Offset = "0x88FC7A0", VA = "0x1888FE1A0", Slot = "22")]
		public SetResult UDZMHEOYKAJ(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3BC78A0", Offset = "0x3BC5EA0", VA = "0x183BC78A0", Slot = "23")]
		public a YLXHXLDPIQY<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8410", Offset = "0x3BC6A10", VA = "0x183BC8410", Slot = "24")]
		public SetResult ZAJRAUBUCUM<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x88FD5A0", Offset = "0x88FBBA0", VA = "0x1888FD5A0", Slot = "25")]
		public bool KMASJWLCYIY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x88FD9C0", Offset = "0x88FBFC0", VA = "0x1888FD9C0", Slot = "26")]
		public bool NZJNDQHSUEZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x88FC340", Offset = "0x88FA940", VA = "0x1888FC340", Slot = "27")]
		public string BLWWKFUTLXG(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x88FDD10", Offset = "0x88FC310", VA = "0x1888FDD10", Slot = "28")]
		public SetResult QLDXOHKZPEY(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x88FD690", Offset = "0x88FBC90", VA = "0x1888FD690", Slot = "29")]
		public int MMHZPDFKMLI(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x88FDE20", Offset = "0x88FC420", VA = "0x1888FDE20", Slot = "30")]
		public SetResult RCSWKLQJLIW(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x88FD600", Offset = "0x88FBC00", VA = "0x1888FD600", Slot = "31")]
		public bool KWCBDIHDGUN(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x88FDC90", Offset = "0x88FC290", VA = "0x1888FDC90", Slot = "32")]
		public SetResult PSCDMQOIXYN(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x88FDDB0", Offset = "0x88FC3B0", VA = "0x1888FDDB0", Slot = "33")]
		public float QWWEBKXNFOF(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x88FC8A0", Offset = "0x88FAEA0", VA = "0x1888FC8A0", Slot = "34")]
		public SetResult EDZMBUXPASV(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x88FD9D0", Offset = "0x88FBFD0", VA = "0x1888FD9D0", Slot = "35")]
		public DateTime OEVHWOKCPGQ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x88FEB50", Offset = "0x88FD150", VA = "0x1888FEB50", Slot = "36")]
		public SetResult YIMYBNIBMAM(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x88FDD40", Offset = "0x88FC340", VA = "0x1888FDD40", Slot = "37")]
		public long QRGIZREKFIX(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x88FD990", Offset = "0x88FBF90", VA = "0x1888FD990", Slot = "38")]
		public SetResult NOFVVBTEXNJ(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x88FC8D0", Offset = "0x88FAED0", VA = "0x1888FC8D0")]
		private bool EMMZUODOSBG(PUYYYWQIUWI a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x88FDA40", Offset = "0x88FC040", VA = "0x1888FDA40")]
		private bool OYSOTFGEUDN(PUYYYWQIUWI a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x88FE480", Offset = "0x88FCA80", VA = "0x1888FE480")]
		private SetResult VPWGWLOIBAV(PUYYYWQIUWI a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x88FE7C0", Offset = "0x88FCDC0", VA = "0x1888FE7C0")]
		private SetResult WDFJWIGHLPX(PUYYYWQIUWI a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x88FCF60", Offset = "0x88FB560", VA = "0x1888FCF60")]
		private SetResult IIMRHNTFXNK(PUYYYWQIUWI a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x88FE680", Offset = "0x88FCC80", VA = "0x1888FE680")]
		private SetResult VYRUOVNJFSC(PUYYYWQIUWI a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x88FE310", Offset = "0x88FC910", VA = "0x1888FE310")]
		private SetResult VNMYERKUNSF(PUYYYWQIUWI a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x88FE060", Offset = "0x88FC660", VA = "0x1888FE060")]
		private SetResult TQYLVASLUOK(PUYYYWQIUWI a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7EB0", Offset = "0x3BC64B0", VA = "0x183BC7EB0")]
		private e YVWGRPNMVBJ<e>(PUYYYWQIUWI a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6C60", Offset = "0x3BC5260", VA = "0x183BC6C60")]
		private SetResult XLFTIAIXMSH<f>(PUYYYWQIUWI a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6A80", Offset = "0x3BC5080", VA = "0x183BC6A80", Slot = "39")]
		public void IHJFFMCGPJE<g>(XEMGIITTIKS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC69F0", Offset = "0x3BC4FF0", VA = "0x183BC69F0", Slot = "40")]
		public void HMEVRICNJGF<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x88FDF90", Offset = "0x88FC590", VA = "0x1888FDF90")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(PUYYYWQIUWI backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x88FDBA0", Offset = "0x88FC1A0", VA = "0x1888FDBA0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task PJGLYAMDEYC([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x88FD7B0", Offset = "0x88FBDB0", VA = "0x1888FD7B0")]
		private void NIJAHHGMXQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x88FD0A0", Offset = "0x88FB6A0", VA = "0x1888FD0A0", Slot = "41")]
		public IDisposable INGQQGTAVCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x88FCB90", Offset = "0x88FB190", VA = "0x1888FCB90", Slot = "42")]
		public void FDMINYKQWDH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x88FC930", Offset = "0x88FAF30", VA = "0x1888FC930")]
		private void ENXFWHRJFYB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x88FEC90", Offset = "0x88FD290", VA = "0x1888FEC90")]
		[IteratorStateMachine(typeof(WKCRLDQFQDR))]
		private IEnumerator<SGCTHXNJFVM> ZFHRQPJKBQL(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x88FC310", Offset = "0x88FA910", VA = "0x1888FC310")]
		[CompilerGenerated]
		private void AICVYIQKAUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class AZMCFABODGB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x88F8B00", Offset = "0x88F7100", VA = "0x1888F8B00")]
		public static string TKGKBNTHFRA(this WQEISMLFQPB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x88F8960", Offset = "0x88F6F60", VA = "0x1888F8960")]
		public static byte[] KPKMMBUWONM(this WQEISMLFQPB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x88F8850", Offset = "0x88F6E50", VA = "0x1888F8850")]
		public static SetResult CVHDLYFFZGK(this WQEISMLFQPB a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class TDRFMMXWGEM : ADFSYRSKXAQ<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static TDRFMMXWGEM ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8900290", Offset = "0x88FE890", VA = "0x188900290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8900560", Offset = "0x88FEB60", VA = "0x188900560", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x89002E0", Offset = "0x88FE8E0", VA = "0x1889002E0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x89006E0", Offset = "0x88FECE0", VA = "0x1889006E0")]
		public TDRFMMXWGEM()
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
