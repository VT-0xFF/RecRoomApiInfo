using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Transforms;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.DataStructures.Runtime.Caching;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FSMSTBWVATW
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x907EF30", Offset = "0x907DD30", VA = "0x18907EF30")]
	public static int SKLULEGTWOI(this DateTime a)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x907E920", Offset = "0x907D720", VA = "0x18907E920")]
	public static int IURVBUGISNX(int a, int b, int c)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x907ECC0", Offset = "0x907DAC0", VA = "0x18907ECC0")]
	public static bool NVVCCIPZRWJ(this DateTime a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x907ED80", Offset = "0x907DB80", VA = "0x18907ED80")]
	public static bool PNTBIQTHMPR(this DateTime a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x907F340", Offset = "0x907E140", VA = "0x18907F340")]
	public static string ZNBNNNBFLKE(DateTime a, bool b = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x907E730", Offset = "0x907D530", VA = "0x18907E730")]
	public static string ELQHKSDSFSD(this DateTime a, [Optional] CultureInfo b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x907EA10", Offset = "0x907D810", VA = "0x18907EA10")]
	public static string KEKTUDTJGCN(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x907E870", Offset = "0x907D670", VA = "0x18907E870")]
	private static string FTWXCPDWNXB(int a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x907F2B0", Offset = "0x907E0B0", VA = "0x18907F2B0")]
	public static string ZGMRZQDSQFU(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x907EE60", Offset = "0x907DC60", VA = "0x18907EE60")]
	public static string SCFDQMJOABH(this float a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x907E600", Offset = "0x907D400", VA = "0x18907E600")]
	public static string CXWACTBTHBM(this int a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x907EFE0", Offset = "0x907DDE0", VA = "0x18907EFE0")]
	public static string XLPORPPMGBD(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x907F220", Offset = "0x907E020", VA = "0x18907F220")]
	[CompilerGenerated]
	internal static string ZFGLJKPQBSF(int a, string b)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FGEPVXTQSRL
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x907E300", Offset = "0x907D100", VA = "0x18907E300")]
	public static Rect TMIECNMCNFY(this RectTransform a, Camera b, [Optional] Vector3[] c)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JPNNSKUOGJG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static float FUXORPLJAVD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90808D0", Offset = "0x907F6D0", VA = "0x1890808D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static float DXWOXXDUEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB8DB10", Offset = "0xB8C910", VA = "0x180B8DB10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static float PIIUTBMVIRG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x90808E0", Offset = "0x907F6E0", VA = "0x1890808E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x90808A0", Offset = "0x907F6A0", VA = "0x1890808A0")]
	public static float BSMSEAIZRVY(float a)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DOYOAZHXJHS
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x907B3E0", Offset = "0x907A1E0", VA = "0x18907B3E0")]
	public static bool XQEVHFAWRBH(this DateTime a, TimeSpan b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x907B500", Offset = "0x907A300", VA = "0x18907B500")]
	public static string YANUKRUHOBI(this TimeSpan a, string b = "minute", bool c = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9079EE0", Offset = "0x9078CE0", VA = "0x189079EE0")]
	public static string LFMQZOPIEVO(this TimeSpan a, string b = "minute", bool c = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x907B460", Offset = "0x907A260", VA = "0x18907B460")]
	private static string XVTKNUJQQUY(string a, double b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x907AC20", Offset = "0x9079A20", VA = "0x18907AC20")]
	public static string WODSOLBVIFI(this TimeSpan a, bool b = false, bool c = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x907A5F0", Offset = "0x90793F0", VA = "0x18907A5F0")]
	public static string TGWPWUOGGXO(this TimeSpan a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x907A350", Offset = "0x9079150", VA = "0x18907A350")]
	public static string RDWHPATURYE(this TimeSpan a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9079E80", Offset = "0x9078C80", VA = "0x189079E80")]
	public static string DVSAQLLOYPN(this TimeSpan a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x907A2F0", Offset = "0x90790F0", VA = "0x18907A2F0")]
	private static string QPVXKNYLKUE(string a, int b)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class XMKWZBKZPTR
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x908A4A0", Offset = "0x90892A0", VA = "0x18908A4A0")]
	public static string ESQRVRGMMMY(this Type a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9E330", Offset = "0x3C9D130", VA = "0x183C9E330")]
	public static bool KARTBXEYPJK<a>(this Type a, [Out] a b, bool c = true) where a : Attribute
	{
		return default(bool);
	}
}
namespace _LogRegistration.RecRoom_Unityextensions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x90832F0", Offset = "0x90820F0", VA = "0x1890832F0", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Unityextensions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9092830", Offset = "0x9091630", VA = "0x189092830", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ZKJPSZMMKVW
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x90926A0", Offset = "0x90914A0", VA = "0x1890926A0")]
		public static float EFJDQVKBDKL(this AnimationCurve a, float b)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ZGCKCGBTVQJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CLBNUKTSEYG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public int NZGXSEGARGK;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public CLBNUKTSEYG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9078AB0", Offset = "0x90778B0", VA = "0x189078AB0")]
			internal bool XRFRALQVRVZ(AnimatorControllerParameter a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9091D00", Offset = "0x9090B00", VA = "0x189091D00")]
		public static void JHKOENYELSI(this Animator a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9091D80", Offset = "0x9090B80", VA = "0x189091D80")]
		public static void RHKJLNHUBBT(this Animator a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9091EC0", Offset = "0x9090CC0", VA = "0x189091EC0")]
		public static void WAZODIEXEWL(this Animator a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9091DE0", Offset = "0x9090BE0", VA = "0x189091DE0")]
		public static bool UDELTXHSHRZ(this Animator a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class KYUALLARAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3842B00", Offset = "0x3841900", VA = "0x183842B00")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3842A30", Offset = "0x3841830", VA = "0x183842A30")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FFVQLBZODIY
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PFPHQMMHMBL<a> where a : AsyncOperation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> MUBUFWHQGRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public a GDSSYCOVGYV;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public PFPHQMMHMBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5C3ECF0", Offset = "0x5C3DAF0", VA = "0x185C3ECF0")]
			internal void HKRPTMAKWFE(AsyncOperation a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37617E0", Offset = "0x37605E0", VA = "0x1837617E0")]
		public static Task<a> WFIIFWTXLAZ<a>(this a a) where a : AsyncOperation
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class ECKQKERVUEQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x907CA80", Offset = "0x907B880", VA = "0x18907CA80")]
		public static Bounds QSVASKGBSWK(IList<Bounds> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x907C870", Offset = "0x907B670", VA = "0x18907C870")]
		public static Bounds AJTSGBIMTUC(this GameObject a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x907C690", Offset = "0x907B490", VA = "0x18907C690")]
		public static Bounds AJTSGBIMTUC(this GameObject a, [In] List<Renderer> renderers)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MAYNLJFXPGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal enum SearchType
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Self,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Parent,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			Children
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		internal struct CacheParameters : IEquatable<CacheParameters>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private WeakReference<GameObject> gameObjectWeakReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public readonly bool includeMultiple;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public readonly SearchType searchType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public readonly bool includeInactive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly Type type;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public GameObject NKLBEGPZYIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x9079410", Offset = "0x9078210", VA = "0x189079410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9079750", Offset = "0x9078550", VA = "0x189079750")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9079110", Offset = "0x9077F10", VA = "0x189079110", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9079260", Offset = "0x9078060", VA = "0x189079260", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9079300", Offset = "0x9078100", VA = "0x189079300", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x90794B0", Offset = "0x90782B0", VA = "0x1890794B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly List<CacheParameters> TJMYYHXTRHY;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Dictionary<CacheParameters, ICollection> ILRPIHQWZKO;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static int JXGCWLYVABQ;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9083370", Offset = "0x9082170", VA = "0x189083370")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3878500", Offset = "0x3877300", VA = "0x183878500")]
		public static a SVMYZSMLZWV<a>(this GameObject a, bool b = false)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x38789D0", Offset = "0x38777D0", VA = "0x1838789D0")]
		public static b XIUXSLVBLAC<b>(this GameObject a, bool b = true, bool c = false)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3877860", Offset = "0x3876660", VA = "0x183877860")]
		public static c GROMKJAGSQZ<c>(this GameObject a, bool b = true, bool c = false)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3878270", Offset = "0x3877070", VA = "0x183878270")]
		public static IReadOnlyList<e> QAIDSHZIKYV<e>(this GameObject a, bool b = true, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x38775C0", Offset = "0x38763C0", VA = "0x1838775C0")]
		public static IReadOnlyList<f> FFVMEGQYUVA<f>(this GameObject a, bool b = true, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x38772F0", Offset = "0x38760F0", VA = "0x1838772F0")]
		private static g DUMVGXBDZDO<g>(CacheParameters a, bool b = false)
		{
			return (g)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3877B30", Offset = "0x3876930", VA = "0x183877B30")]
		private static IReadOnlyList<h> JJGSIEMPTXN<h>(CacheParameters a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9083910", Offset = "0x9082710", VA = "0x189083910")]
		private static void UMGXAYPEDVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9083400", Offset = "0x9082200", VA = "0x189083400")]
		private static void LKVTNMZOAOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3877FE0", Offset = "0x3876DE0", VA = "0x183877FE0")]
		private static IReadOnlyList<i> KTGTIBASOBE<i>(CacheParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3878710", Offset = "0x3877510", VA = "0x183878710")]
		private static IReadOnlyList<j> VMNHXNORADR<j>(CacheParameters a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class FBLMRLWTAZI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x907D730", Offset = "0x907C530", VA = "0x18907D730")]
		public static float CGOZUUPKWSD(this Camera a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x907DEF0", Offset = "0x907CCF0", VA = "0x18907DEF0")]
		public static float PXCEDHIRSPW(this Camera a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x907DB70", Offset = "0x907C970", VA = "0x18907DB70")]
		public static float IPCQMYHMQKI(this Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x907E290", Offset = "0x907D090", VA = "0x18907E290")]
		private static float ZDCASQSSIBX(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x907E2C0", Offset = "0x907D0C0", VA = "0x18907E2C0")]
		private static float ZDCASQSSIBX(Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x907DF60", Offset = "0x907CD60", VA = "0x18907DF60")]
		private static float SABDNKDKCGW(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x907DFA0", Offset = "0x907CDA0", VA = "0x18907DFA0")]
		private static float SABDNKDKCGW(Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x907DA40", Offset = "0x907C840", VA = "0x18907DA40")]
		public static float EWWZARJRDLC(float a, float b, float c = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x907D980", Offset = "0x907C780", VA = "0x18907D980")]
		public static float EWWZARJRDLC(this Camera a, float b, float c = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x907D800", Offset = "0x907C600", VA = "0x18907D800")]
		public static float EWWZARJRDLC(this Camera a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x907E040", Offset = "0x907CE40", VA = "0x18907E040")]
		public static float WXFWWSJRJEU(float a, float b, Vector2 c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x907DBE0", Offset = "0x907C9E0", VA = "0x18907DBE0")]
		public static float JYTMJJZUZKU(this Camera a, Vector2 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x907D6A0", Offset = "0x907C4A0", VA = "0x18907D6A0")]
		private static float CCSYOJPUXWF(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x907DE40", Offset = "0x907CC40", VA = "0x18907DE40")]
		private static float LDRXZULWOCV(float a, float b, float c, float d = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x907D780", Offset = "0x907C580", VA = "0x18907D780")]
		public static void CJDXPOTUFFJ(this Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x907E000", Offset = "0x907CE00", VA = "0x18907E000")]
		public static bool UHMHSPIBNYS(this Camera a, Bounds b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x907DAF0", Offset = "0x907C8F0", VA = "0x18907DAF0")]
		public static bool GSMDRCPNMDO(this Camera a, Vector3 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class LJOMOJFCGMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class HLJRTZRPZIO<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public ICollection<a> ELGHOICNEES;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HLJRTZRPZIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5006990", Offset = "0x5005790", VA = "0x185006990")]
			internal bool IUKBNUGIQEG(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3847BC0", Offset = "0x38469C0", VA = "0x183847BC0")]
		public static a QGRSLAVZGUH<a>(this ICollection<a> a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x38462C0", Offset = "0x38450C0", VA = "0x1838462C0")]
		public static bool FFWCUREJWTK<b>(this ICollection<b> a, IEnumerable<b> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class QLMWWCKFSNV
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static RaycastHit[] XPFKHTHQDMR;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9084230", Offset = "0x9083030", VA = "0x189084230")]
		public static bool XKWCZGIMSTC(this Collider a, Vector3 b, Vector3 c, float d, Vector3 e, float f, [Out] RaycastHit g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9083FB0", Offset = "0x9082DB0", VA = "0x189083FB0")]
		public static int RBJYBECNKPR(this BoxCollider a, int b, QueryTriggerInteraction c, Collider[] d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9084610", Offset = "0x9083410", VA = "0x189084610")]
		public static bool YILRWZSEIAL(this BoxCollider a, int b, QueryTriggerInteraction c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9083C40", Offset = "0x9082A40", VA = "0x189083C40")]
		public static int GANDWAQEPSD(this BoxCollider a, Collider[] b, int c, QueryTriggerInteraction d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9083AB0", Offset = "0x90828B0", VA = "0x189083AB0")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9084870", Offset = "0x9083670", VA = "0x189084870")]
		public static bool YILRWZSEIAL(this CapsuleCollider a, int b, QueryTriggerInteraction c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x90844F0", Offset = "0x90832F0", VA = "0x1890844F0")]
		public static Vector3 XTLULBCQHWL(this BoxCollider a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9084580", Offset = "0x9083380", VA = "0x189084580")]
		public static Vector3 XTLULBCQHWL(this SphereCollider a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9083EC0", Offset = "0x9082CC0", VA = "0x189083EC0")]
		public static Vector3 KDPUKRYAZFF(this BoxCollider a)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class WEDWAISOKZA
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Color MHRBZNAMONW;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9089E40", Offset = "0x9088C40", VA = "0x189089E40")]
		public static Color ZWLTYJBPJAI(this Color a, float b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9089D80", Offset = "0x9088B80", VA = "0x189089D80")]
		public static Vector3 VYSEQLZUKXM(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9089D10", Offset = "0x9088B10", VA = "0x189089D10")]
		public static Color VYSEQLZUKXM(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9089940", Offset = "0x9088740", VA = "0x189089940")]
		public static Color DTGVDQLKGSI(this Color a, float b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9089870", Offset = "0x9088670", VA = "0x189089870")]
		public static Color CBWRWXMTZHY(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90899E0", Offset = "0x90887E0", VA = "0x1890899E0")]
		public static Color JVTQUUVCVFZ(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28B34C0", Offset = "0x28B22C0", VA = "0x1828B34C0")]
		public static float HHQUVGXFIBW([In] Color start, [In] Color end, [In] Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9089950", Offset = "0x9088750", VA = "0x189089950")]
		public static float GJKYFBBHOPH([In] Color start, [In] Color end, [In] Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9089DF0", Offset = "0x9088BF0", VA = "0x189089DF0")]
		public static float YXGHPNNYWKE([In] Color color)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class DCZUNPXAXKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Dictionary<Type, FieldInfo[]> ARQYOZZPEIW;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x35ECDC0", Offset = "0x35EBBC0", VA = "0x1835ECDC0")]
		public static a GWPLUZBWPHS<a>(this Component a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9079810", Offset = "0x9078610", VA = "0x189079810")]
		public static void DHUBREKOAGN(this Component a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9079B30", Offset = "0x9078930", VA = "0x189079B30")]
		public static bool UQYXPTAXUAN(this Component a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x35ECD80", Offset = "0x35EBB80", VA = "0x1835ECD80")]
		public static List<f> GAZBMPKFSXF<f>(this Component a) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x35ECD10", Offset = "0x35EBB10", VA = "0x1835ECD10")]
		public static g BGEPEXYBXME<g>(this Component a, bool b) where g : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class XBXVTAPCNSY
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DPSFEYEZNLK<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private a LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int QZMPRZMGFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private GameObject[] NVGDTVNWOYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private int NVAWWOTZFNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private a[] NVQROJBRHVB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int NVLKRCHTYJS;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private a KBETMWONPWP
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public DPSFEYEZNLK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4191C20", Offset = "0x4190A20", VA = "0x184191C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1D80", Offset = "0x3DD0B80", VA = "0x183DD1D80", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4191DF0", Offset = "0x4190BF0", VA = "0x184191DF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> WSRFZTQRMOY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x4191B70", Offset = "0x4190970", VA = "0x184191B70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3C97490", Offset = "0x3C96290", VA = "0x183C97490")]
		[IteratorStateMachine(typeof(DPSFEYEZNLK<>))]
		public static IEnumerable<a> TFAIUXUCPEF<a>() where a : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class FHPOFOJWOAR
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class YGMDZGRHQKH : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private object LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action EADFRJBYSJQ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object DZQDAJVCBUJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
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
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public YGMDZGRHQKH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x908AC50", Offset = "0x9089A50", VA = "0x18908AC50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x908AD00", Offset = "0x9089B00", VA = "0x18908AD00", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class VSPCEBTGYRQ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private object LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float HTSHNPBKNOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Action EADFRJBYSJQ;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object DZQDAJVCBUJ
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public VSPCEBTGYRQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9089780", Offset = "0x9088580", VA = "0x189089780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9089830", Offset = "0x9088630", VA = "0x189089830", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static WaitForEndOfFrame ZDHUBSLRCMV;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x907E500", Offset = "0x907D300", VA = "0x18907E500")]
		[IteratorStateMachine(typeof(VSPCEBTGYRQ))]
		public static IEnumerator RGKGYBPBMZV(float a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x907E490", Offset = "0x907D290", VA = "0x18907E490")]
		[IteratorStateMachine(typeof(YGMDZGRHQKH))]
		public static IEnumerator IHUSSSOBPTZ(Action a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class EditorDirtyStateExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly Log ZRWLDOZYDLX;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log CSYYWSSPOCC;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly Log YKUPGMPJGNX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class DJJKELPDWAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class PFPHQMMHMBL<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Func<a, string> YMOPLZZKQYE;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public PFPHQMMHMBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5C3EC90", Offset = "0x5C3DA90", VA = "0x185C3EC90")]
			internal string FJLQSLDAOFW(int a, a b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class HLJRTZRPZIO<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public string SSTNUBZXKCQ;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HLJRTZRPZIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5006800", Offset = "0x5005600", VA = "0x185006800")]
			internal string FJLQSLDAOFW(string a, string b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class YASXXDOSCHM<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private a LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private a RASYCYKFSFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public a VZDHRYFAPFQ;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a KBETMWONPWP
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x3EE1FD0", Offset = "0x3EE0DD0", VA = "0x183EE1FD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public YASXXDOSCHM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3EE1DF0", Offset = "0x3EE0BF0", VA = "0x183EE1DF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1D80", Offset = "0x3DD0B80", VA = "0x183DD1D80", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3EE20B0", Offset = "0x3EE0EB0", VA = "0x183EE20B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> WSRFZTQRMOY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3EE1D40", Offset = "0x3EE0B40", VA = "0x183EE1D40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x35F45F0", Offset = "0x35F33F0", VA = "0x1835F45F0")]
		public static string JWXINRGPFMH<a>(this IEnumerable<a> a, [Optional] Func<a, string> b, string c = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x35F4160", Offset = "0x35F2F60", VA = "0x1835F4160")]
		public static string JWXINRGPFMH<b>(this IList<b> a, [Optional] Func<int, b, string> b, string c = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x35F06A0", Offset = "0x35EF4A0", VA = "0x1835F06A0")]
		[IteratorStateMachine(typeof(YASXXDOSCHM<>))]
		public static IEnumerable<c> IGUIBQUMAYZ<c>(c a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class UVRZCISCVBW
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly Regex DKUJCNNTATC;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x35ED200", Offset = "0x35EC000", VA = "0x1835ED200")]
		public static IEnumerable<string> UOVXQPRICGY<c>(this IEnumerable<c> a) where c : Enum
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class YBVSQOKEPBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <ReadAllBytesAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public string filePath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private FileStream <stream>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private byte[] <bytes>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x90890C0", Offset = "0x9087EC0", VA = "0x1890890C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9089560", Offset = "0x9088360", VA = "0x189089560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x908A7A0", Offset = "0x90895A0", VA = "0x18908A7A0")]
		public static string HTVMPCKIQLZ(this FileInfo a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x908A990", Offset = "0x9089790", VA = "0x18908A990")]
		public static string HTVMPCKIQLZ(this FileInfo a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x908AB30", Offset = "0x9089930", VA = "0x18908AB30")]
		[AsyncStateMachine(typeof(<ReadAllBytesAsync>d__2))]
		public static Task<byte[]> SWRHJPNQQXA(string a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class IBSTCGEUNSR
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x90807B0", Offset = "0x907F5B0", VA = "0x1890807B0")]
		public static bool TTLIQXDXMMS(this float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9080750", Offset = "0x907F550", VA = "0x189080750")]
		public static float KPTXLIFKEEK(this float a, float b)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class ZBWEYRHTEPK
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class XTMJMDQXGYK<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private a LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private GameObject ELGHOICNEES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public GameObject BPUAIYNAWVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private Transform HISZICCZXEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int QZRWPGGDOWV;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private a KBETMWONPWP
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public XTMJMDQXGYK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB6B0", Offset = "0x3EDA4B0", VA = "0x183EDB6B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1D80", Offset = "0x3DD0B80", VA = "0x183DD1D80", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB800", Offset = "0x3EDA600", VA = "0x183EDB800", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> WSRFZTQRMOY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB5F0", Offset = "0x3EDA3F0", VA = "0x183EDB5F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class EIQOBIMBRQN : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private string LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private GameObject GGSNDNNGKPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public GameObject SUOXALIPRAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private Transform DZHAUIPEENR;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private string NIKLBOMTNZR
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public EIQOBIMBRQN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x907D0A0", Offset = "0x907BEA0", VA = "0x18907D0A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x907D1B0", Offset = "0x907BFB0", VA = "0x18907D1B0", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x907D000", Offset = "0x907BE00", VA = "0x18907D000", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> GZIMJFDXMSY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x907D000", Offset = "0x907BE00", VA = "0x18907D000", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static Dictionary<int, int> NNDZZJLTHRP;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x90907A0", Offset = "0x908F5A0", VA = "0x1890907A0")]
		public static void MGPXTAHAGHP(Transform a, HideFlags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x138D0A0", Offset = "0x138BEA0", VA = "0x18138D0A0")]
		public static void WTZGACTWUSP(this GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3678DB0", Offset = "0x3677BB0", VA = "0x183678DB0")]
		[IteratorStateMachine(typeof(XTMJMDQXGYK<>))]
		public static IEnumerable<a> JLAHTCBHSLT<a>(this GameObject a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD8A0", Offset = "0x3CBC6A0", VA = "0x183CBD8A0")]
		public static b UNUMTHXLWRK<b>(this GameObject a) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD620", Offset = "0x3CBC420", VA = "0x183CBD620")]
		public static c BGEPEXYBXME<c>(this GameObject a, bool b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDC40", Offset = "0x3CBCA40", VA = "0x183CBDC40")]
		public static d XIISEIORJBZ<d>(this GameObject a) where d : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDB90", Offset = "0x3CBC990", VA = "0x183CBDB90")]
		public static e XIISEIORJBZ<e>(this Component a) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDAD0", Offset = "0x3CBC8D0", VA = "0x183CBDAD0")]
		public static void UNWOPSBKMLV<f>(this GameObject a, List<f> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CBDA10", Offset = "0x3CBC810", VA = "0x183CBDA10")]
		public static void UNWOPSBKMLV<g>(this Component a, List<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD7D0", Offset = "0x3CBC5D0", VA = "0x183CBD7D0")]
		public static void UJQOPNPLNFR<h>(this GameObject a, bool b, List<h> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x90908F0", Offset = "0x908F6F0", VA = "0x1890908F0")]
		public static void ZQCZXHOLHQH(this GameObject a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9090610", Offset = "0x908F410", VA = "0x189090610")]
		public static string JEODVHYBFZK(this GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9090870", Offset = "0x908F670", VA = "0x189090870")]
		[IteratorStateMachine(typeof(EIQOBIMBRQN))]
		private static IEnumerable<string> QNCBQPSJQSE(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9090430", Offset = "0x908F230", VA = "0x189090430")]
		public static int BXMCBZTONJH(this GameObject a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class EDIFLVNNXNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3678BA0", Offset = "0x36779A0", VA = "0x183678BA0")]
		public static bool GTMCFXAGYKK<a>(string a, [Out] a b, [Optional] Func<a> c, params JsonConverter[] converters)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct Torus
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float majorRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float minorRadius;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xE0FD20", Offset = "0xE0EB20", VA = "0x180E0FD20")]
		public Torus(float majorRadius, float minorRadius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x90887F0", Offset = "0x90875F0", VA = "0x1890887F0")]
		private bool TISGZGARAKD([In] Ray ray, [Out] float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9088E90", Offset = "0x9087C90", VA = "0x189088E90")]
		public bool TISGZGARAKD([In] Ray ray, [Out] Vector3 a, [Out] Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9088F60", Offset = "0x9087D60", VA = "0x189088F60")]
		public bool TISGZGARAKD(Transform a, [In] Ray ray, [Out] Vector3 b, [Out] Vector3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x90885F0", Offset = "0x90873F0", VA = "0x1890885F0")]
		private Vector3 Normal([In] Vector3 pos)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class WNZYOPCRGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9089EA0", Offset = "0x9088CA0", VA = "0x189089EA0")]
		public static string ZNPWZNSKZGW(this int a, int b = 99)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class USWHJGNIDKU
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C482B0", Offset = "0x3C470B0", VA = "0x183C482B0")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C47CF0", Offset = "0x3C46AF0", VA = "0x183C47CF0")]
		public static T Random<T>(this IReadOnlyList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C47B60", Offset = "0x3C46960", VA = "0x183C47B60")]
		public static void LTAOXFQYYMS<a>(this List<a> a) where a : UnityEngine.Object
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class BLCJFNKMTPW
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x90772C0", Offset = "0x90760C0", VA = "0x1890772C0")]
		public static void NVOLHRDXVWI(this Material a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3455420", Offset = "0x3454220", VA = "0x183455420")]
		public static TEnum JFFCCEXXBXR<TEnum>(this Material a, int b) where TEnum : struct, Enum
		{
			return (TEnum)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class LFVJVZXEWXH
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<float> VKUZBDUPRAQ;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<float> YMIWDSXQYBQ;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9081FA0", Offset = "0x9080DA0", VA = "0x189081FA0")]
		public static bool LDNGBVNBUYW(int a, int b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9082DF0", Offset = "0x9081BF0", VA = "0x189082DF0")]
		public static float XUCYJDSYGRR(this IList<float> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9080A90", Offset = "0x907F890", VA = "0x189080A90")]
		public static float BKFPVNFOQSF(this IList<float> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9082190", Offset = "0x9080F90", VA = "0x189082190")]
		public static void RJIZCVRFZFU(Vector3 a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x90809B0", Offset = "0x907F7B0", VA = "0x1890809B0")]
		public static void BEUUTGPWKFL(Vector3 a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9082580", Offset = "0x9081380", VA = "0x189082580")]
		public static Vector3 USSYAIWDCKA(float a, float b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9081FC0", Offset = "0x9080DC0", VA = "0x189081FC0")]
		public static Vector3 LHHFAAYBETX(float a, float b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9081CF0", Offset = "0x9080AF0", VA = "0x189081CF0")]
		public static Vector3 HRPWCNRTIQO(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9082140", Offset = "0x9080F40", VA = "0x189082140")]
		public static bool OJYZBVZNOFA(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9080B80", Offset = "0x907F980", VA = "0x189080B80")]
		public static Vector3 BOWPDNULMFH(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x90812E0", Offset = "0x90800E0", VA = "0x1890812E0")]
		public static float DZTASWYUITI(Ray a, Ray b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9082940", Offset = "0x9081740", VA = "0x189082940")]
		private static float XUCYJDSYGRR(this IList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9081F30", Offset = "0x9080D30", VA = "0x189081F30")]
		public static bool JPWXNQCXFGZ(float a, float b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9081DD0", Offset = "0x9080BD0", VA = "0x189081DD0")]
		public static Vector3 IVGFWPOXHAP(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9082780", Offset = "0x9081580", VA = "0x189082780")]
		public static Vector3 XKZDJENINVO(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x90819E0", Offset = "0x90807E0", VA = "0x1890819E0")]
		public static void GOMTHOZOFQQ(RRTransform a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9080CC0", Offset = "0x907FAC0", VA = "0x189080CC0")]
		public static Vector3 DWGNXVSGOEV(Vector3 a, Vector3 b, float c, float d, [Out] float e)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9082200", Offset = "0x9081000", VA = "0x189082200")]
		public static Vector3 SCDEXUANUQA(Vector3 a, Vector3 b, float c, [Out] float d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x90815E0", Offset = "0x90803E0", VA = "0x1890815E0")]
		private static float ENHJZNTGNRU(Vector3 a, Vector3 b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x90820C0", Offset = "0x9080EC0", VA = "0x1890820C0")]
		public static float MLXOXHEVPZG(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9082120", Offset = "0x9080F20", VA = "0x189082120")]
		public static float ODZSLDGHPCO(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9082620", Offset = "0x9081420", VA = "0x189082620")]
		public static float VBRDOIFJTCC(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x90826F0", Offset = "0x90814F0", VA = "0x1890826F0")]
		public static void XHBTQZMEFTP(float a, float b, float c, [Out] float d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9082540", Offset = "0x9081340", VA = "0x189082540")]
		public static float USMSQNMQAZQ(this float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9081F50", Offset = "0x9080D50", VA = "0x189081F50")]
		public static float KAMVJFJNALM(this float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x90820E0", Offset = "0x9080EE0", VA = "0x1890820E0")]
		public static float MTXAWTBZVJQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x284CA00", Offset = "0x284B800", VA = "0x18284CA00")]
		public static float MFPSVHXDTNA(this float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9081950", Offset = "0x9080750", VA = "0x189081950")]
		public static float GMAINYKBSUD(int a = 30)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9081100", Offset = "0x907FF00", VA = "0x189081100")]
		public static Vector3 DYZGGFQBBRQ(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9081F10", Offset = "0x9080D10", VA = "0x189081F10")]
		public static bool JJGTZNUEDVB(this float a, float b, float c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class RFAIONOTZIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9087140", Offset = "0x9085F40", VA = "0x189087140")]
		public static IDisposable LMJMOTIDYBZ(this Mesh a, int b, [Out] List<Vector2> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9087640", Offset = "0x9086440", VA = "0x189087640")]
		public static IDisposable YWOPODTQCPF(this Mesh a, [Out] List<Vector3> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x90874D0", Offset = "0x90862D0", VA = "0x1890874D0")]
		public static IDisposable WGXUCPFPXUV(this Mesh a, [Out] List<Vector4> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x90872D0", Offset = "0x90860D0", VA = "0x1890872D0")]
		public static IDisposable OHYQWVBDWHK(this Mesh a, [Out] List<Matrix4x4> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9087450", Offset = "0x9086250", VA = "0x189087450")]
		public static int SOGXINHCXOL(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9086EF0", Offset = "0x9085CF0", VA = "0x189086EF0")]
		public static int AUNGCMRJOTI(this Mesh a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9087440", Offset = "0x9086240", VA = "0x189087440")]
		public static int QCXNUGIUNUS(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x90872C0", Offset = "0x90860C0", VA = "0x1890872C0")]
		public static int NDSGZLCRFIP(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x90874C0", Offset = "0x90862C0", VA = "0x1890874C0")]
		public static int UGRHXRLNXKQ(this Mesh a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class LUWAKOOIFUV
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5309440", Offset = "0x5308240", VA = "0x185309440")]
		public static bool FMNIZRKJATW(this MonoBehaviour a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9083270", Offset = "0x9082070", VA = "0x189083270")]
		public static void SZWOWXOYPUR(this MonoBehaviour a, Coroutine b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9083220", Offset = "0x9082020", VA = "0x189083220")]
		public static void STRPGGKRXAY(this MonoBehaviour a, IDisposable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9083150", Offset = "0x9081F50", VA = "0x189083150")]
		public static Coroutine RGKGYBPBMZV(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9083050", Offset = "0x9081E50", VA = "0x189083050")]
		public static Coroutine IHUSSSOBPTZ(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9083110", Offset = "0x9081F10", VA = "0x189083110")]
		public static bool LTNGHXNPOTO(this MonoBehaviour a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class KRZVOLCWPYG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3841F60", Offset = "0x3840D60", VA = "0x183841F60")]
		public static bool UOBHZOZYUIP<a>(this a a) where a : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3841EB0", Offset = "0x3840CB0", VA = "0x183841EB0")]
		public static bool GPWBJASFKJR<b>(this b a) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9080910", Offset = "0x907F710", VA = "0x189080910")]
		public static string DSXJSGVZWFS(this UnityEngine.Object a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class CGCIUOBAUIQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class WPAPEHYSWLT<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<Collider, float, a> DAVRNFRCIPS;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public WPAPEHYSWLT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6871EB0", Offset = "0x6870CB0", VA = "0x186871EB0")]
			internal bool DYCPGAWAVCQ(RaycastHit a, float b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class KISYCCSQWES<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Func<Collider, a> DAVRNFRCIPS;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public KISYCCSQWES()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5386ED0", Offset = "0x5385CD0", VA = "0x185386ED0")]
			internal bool LYSDWOGIGOP(RaycastHit a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly Collider[] JQKTUCSKYMF;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly RaycastHit[] BTLHKCMYNOQ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly RaycastHit[] LVTYDCSWVCF;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x90772F0", Offset = "0x90760F0", VA = "0x1890772F0")]
		[CleanupBetweenRooms]
		internal static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x35115B0", Offset = "0x35103B0", VA = "0x1835115B0")]
		public static a CTPDKYYWJUH<a>(Vector3 a, Vector3 b, float c, int d, QueryTriggerInteraction e, [Out] Vector3 f, [Out] Collider g, Func<Collider, a> h)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9078350", Offset = "0x9077150", VA = "0x189078350")]
		public static bool XNQIQHCUCKK(Ray a, float b, [Out] RaycastHit c, Func<RaycastHit, bool> d, int e, QueryTriggerInteraction f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3512170", Offset = "0x3510F70", VA = "0x183512170")]
		public static b HYFWBSWFKOS<b>(Vector3 a, float b, Vector3 c, int d, float e, [Out] Vector3 f, [Out] Collider g, Func<Collider, float, b> h, QueryTriggerInteraction i)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9077A00", Offset = "0x9076800", VA = "0x189077A00")]
		public static Vector3 RRKMFCLLRQL([In] RaycastHit hit, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9077AF0", Offset = "0x90768F0", VA = "0x189077AF0")]
		public static Vector3 SLPAOPATWBX([In] RaycastHit hit, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9077D40", Offset = "0x9076B40", VA = "0x189077D40")]
		public static Vector3 SLPAOPATWBX(this Collider a, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x90775E0", Offset = "0x90763E0", VA = "0x1890775E0")]
		private static float GEEUODJOWQC(Vector3 a, RaycastHit b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x90785A0", Offset = "0x90773A0", VA = "0x1890785A0")]
		public static bool XUAXTYIWORX(Ray a, float b, float c, [Out] RaycastHit d, Func<RaycastHit, float, bool> e, int f, QueryTriggerInteraction g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x90773B0", Offset = "0x90761B0", VA = "0x1890773B0")]
		public static void DDARJXMWQBU(this RaycastHit[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9077E80", Offset = "0x9076C80", VA = "0x189077E80")]
		public static void SONYZEUJMKF(this Collision a, [Out] Vector3 b, [Out] Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9077730", Offset = "0x9076530", VA = "0x189077730")]
		public static PhysicsMaterialCombine KZISEHDLHWD(PhysicsMaterialCombine a, PhysicsMaterialCombine b)
		{
			return default(PhysicsMaterialCombine);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9077770", Offset = "0x9076570", VA = "0x189077770")]
		public static float LZGLXKEPJHS(this PhysicsMaterial a, PhysicsMaterial b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9077830", Offset = "0x9076630", VA = "0x189077830")]
		public static float LZGLXKEPJHS(this PhysicsMaterial a, PhysicsMaterial b, PhysicsMaterialCombine c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9078980", Offset = "0x9077780", VA = "0x189078980")]
		private static float XYSMHCMUZVM(float a, float b, PhysicsMaterialCombine c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x90774A0", Offset = "0x90762A0", VA = "0x1890774A0")]
		public static float3x3 DYFYOEBTZJI(this Rigidbody a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x90780D0", Offset = "0x9076ED0", VA = "0x1890780D0")]
		public static Vector3 TWRJOFAAUDJ(Vector3 a, float b, ForceMode c, ForceMode d)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class VAKESXGNYSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3C76F30", Offset = "0x3C75D30", VA = "0x183C76F30")]
		public static ProfilerMarker.AutoScope KJFTVGOYYHO<a>([Optional][CallerMemberName] string callerName)
		{
			return default(ProfilerMarker.AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
		public static ProfilerMarker.AutoScope KJFTVGOYYHO(Type a, [Optional][CallerMemberName] string callerName)
		{
			return default(ProfilerMarker.AutoScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class ZDORAWAKRIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly float KJVZFOXTFZW;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly float YJRYTFGHWPP;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9090EF0", Offset = "0x908FCF0", VA = "0x189090EF0")]
		public static Vector3 EAMGTLZXNMP(this Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9091440", Offset = "0x9090240", VA = "0x189091440")]
		public static Quaternion IEHTHZGPZGG(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9091980", Offset = "0x9090780", VA = "0x189091980")]
		public static Quaternion RZEVMNOWYXB(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x90916C0", Offset = "0x90904C0", VA = "0x1890916C0")]
		public static Quaternion MDAKMBVQFEP(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9091AC0", Offset = "0x90908C0", VA = "0x189091AC0")]
		public static bool UYRSSAAWBHD(this Quaternion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9090CC0", Offset = "0x908FAC0", VA = "0x189090CC0")]
		public static bool ARMBDSZMBWE(this Quaternion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9090B30", Offset = "0x908F930", VA = "0x189090B30")]
		public static Quaternion AMRYASCVWKS(this Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9091810", Offset = "0x9090610", VA = "0x189091810")]
		public static Quaternion ORBMZTOHRCC(this Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9091BE0", Offset = "0x90909E0", VA = "0x189091BE0")]
		public static Quaternion WGEEDOSJYWH(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9091470", Offset = "0x9090270", VA = "0x189091470")]
		public static Quaternion JHFYRMVBAUT(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9091A30", Offset = "0x9090830", VA = "0x189091A30")]
		public static Quaternion UVXXDAIAOAF(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x90910B0", Offset = "0x908FEB0", VA = "0x1890910B0")]
		public static Vector3 HEDLRLJNXYY(Quaternion a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9090D00", Offset = "0x908FB00", VA = "0x189090D00")]
		public static Quaternion CFBRSUVXSQI(Quaternion a, Quaternion b, Vector3 c, float d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9091610", Offset = "0x9090410", VA = "0x189091610")]
		public static bool JJGTZNUEDVB(this Quaternion a, Quaternion b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9091B00", Offset = "0x9090900", VA = "0x189091B00")]
		public static bool WEOTFJBPYTB(this Quaternion a, Quaternion b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9091280", Offset = "0x9090080", VA = "0x189091280")]
		public static Quaternion HFTLWSCLRGO(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class IQXFPZYOWOR
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9080800", Offset = "0x907F600", VA = "0x189080800")]
		public static Rect PQGEOIMGIUZ(this Rect a, Vector2 b)
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9080880", Offset = "0x907F680", VA = "0x189080880")]
		public static Vector2 XEJTPHFUZJQ(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90807C0", Offset = "0x907F5C0", VA = "0x1890807C0")]
		public static Vector2 BOXGTKVDICZ(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x90807E0", Offset = "0x907F5E0", VA = "0x1890807E0")]
		public static Vector2 ETWHRNVOVDL(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9080860", Offset = "0x907F660", VA = "0x189080860")]
		public static Vector2 WXFFFCKGVTG(this Rect a)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class RATYXMIYLFU
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int VUEQWUOHKWB;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly MaterialPropertyBlock ERUVVXZRAFZ;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9086660", Offset = "0x9085460", VA = "0x189086660")]
		public static Mesh HTXQNUACNFT(this Renderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9086800", Offset = "0x9085600", VA = "0x189086800")]
		public static Mesh HTXQNUACNFT(this SkinnedMeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x90865E0", Offset = "0x90853E0", VA = "0x1890865E0")]
		public static Mesh HTXQNUACNFT(this MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x90863B0", Offset = "0x90851B0", VA = "0x1890863B0")]
		public static int CRALBTRBQEG(this Renderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9086820", Offset = "0x9085620", VA = "0x189086820")]
		public static void XZYAYMZOHAQ(this Renderer a, int b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9086A90", Offset = "0x9085890", VA = "0x189086A90")]
		public static void XZYAYMZOHAQ(this Renderer a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x90868F0", Offset = "0x90856F0", VA = "0x1890868F0")]
		public static void XZYAYMZOHAQ(this Renderer a, int b, Vector4 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x90869C0", Offset = "0x90857C0", VA = "0x1890869C0")]
		public static void XZYAYMZOHAQ(this Renderer a, int b, Texture2D c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x90865C0", Offset = "0x90853C0", VA = "0x1890865C0")]
		public static void GTSRORAOTBD(this Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9086030", Offset = "0x9084E30", VA = "0x189086030")]
		public static void AVWEZROVMFH(this Renderer a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9086210", Offset = "0x9085010", VA = "0x189086210")]
		public static void AVWEZROVMFH(this Renderer a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class YTDRYFTWAVT
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x908D6E0", Offset = "0x908C4E0", VA = "0x18908D6E0")]
		public static void PJZZABZARLW(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x908D620", Offset = "0x908C420", VA = "0x18908D620")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x908D560", Offset = "0x908C360", VA = "0x18908D560")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class RBJOOVXBJXT
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool FPWGVVZUUBT
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x9086CB0", Offset = "0x9085AB0", VA = "0x189086CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static bool SFFXSWDHVTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9086C60", Offset = "0x9085A60", VA = "0x189086C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static bool TOQBYBWARUV
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9086E50", Offset = "0x9085C50", VA = "0x189086E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9086C10", Offset = "0x9085A10", VA = "0x189086C10")]
		private static float JISCXDLDFAI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9086DB0", Offset = "0x9085BB0", VA = "0x189086DB0")]
		private static float WYSCLYEKHVA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9086DA0", Offset = "0x9085BA0", VA = "0x189086DA0")]
		private static float MSKBYOAURIX()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class QZVRZMYWQKU
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <>c__DisplayClass18_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public string self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public bool noCharLimit;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int charsPerSubstring;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public bool noLineLimit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int lineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int maxLinesPerSubstring;
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly Regex JMMJECDLMOB;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly Regex CPHZBIGSTKO;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9084C50", Offset = "0x9083A50", VA = "0x189084C50")]
		public static string AUVXIYVWWNV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x90853C0", Offset = "0x90841C0", VA = "0x1890853C0")]
		public static string PCVUPYKPISU(string a, char b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x90855D0", Offset = "0x90843D0", VA = "0x1890855D0")]
		public static bool PPJVRUTZNUD(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9085640", Offset = "0x9084440", VA = "0x189085640")]
		public static bool PZOLNTFAKXC(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9085090", Offset = "0x9083E90", VA = "0x189085090")]
		public static bool EFOBRYAGYAT(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x90851F0", Offset = "0x9083FF0", VA = "0x1890851F0")]
		public static bool IKUHDIMBWEB(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9085020", Offset = "0x9083E20", VA = "0x189085020")]
		public static bool DWFQGFRPCAH(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9084F90", Offset = "0x9083D90", VA = "0x189084F90")]
		public static bool DWFQGFRPCAH(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9085160", Offset = "0x9083F60", VA = "0x189085160")]
		public static bool FBSYUXQBCBP(this string a, string b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9085E60", Offset = "0x9084C60", VA = "0x189085E60")]
		public static bool UCMHVHJSRMQ(this string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9085E90", Offset = "0x9084C90", VA = "0x189085E90")]
		public static bool WUCXXDBBECK(this string a, string[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9085200", Offset = "0x9084000", VA = "0x189085200")]
		public static bool MFSHZFVAXZZ(string a, string b, StringComparison c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9085190", Offset = "0x9083F90", VA = "0x189085190")]
		public static string IGJCNLEBMJD(this string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9085720", Offset = "0x9084520", VA = "0x189085720")]
		public static string QPVXKNYLKUE(this string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9084E40", Offset = "0x9083C40", VA = "0x189084E40")]
		public static string COFJUFHKAWT(this string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x90857D0", Offset = "0x90845D0", VA = "0x1890857D0")]
		public static List<string> SAQVTCAOMYW(this string a, int b, int c = 2147483647)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9085260", Offset = "0x9084060", VA = "0x189085260")]
		public static string PCABWFWXXDB(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9085440", Offset = "0x9084240", VA = "0x189085440")]
		public static string PJTTVLOMNTY(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x90854C0", Offset = "0x90842C0", VA = "0x1890854C0")]
		public static bool PNMDVZSYFFV(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xF752C0", Offset = "0xF740C0", VA = "0x180F752C0")]
		public static string NESNVKJHAWQ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9085140", Offset = "0x9083F40", VA = "0x189085140")]
		public static string EIEUDUHMFCE(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9084F70", Offset = "0x9083D70", VA = "0x189084F70")]
		public static int DIKRQRYDMSF(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x90856D0", Offset = "0x90844D0", VA = "0x1890856D0")]
		[CompilerGenerated]
		internal static bool QAHQUFUNJTL(int a, <>c__DisplayClass18_0 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class XCVZEUGRGLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public Color[] CPMNIQVYTEV;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x90925E0", Offset = "0x90913E0", VA = "0x1890925E0")]
			internal void JCRNFNDWLCC(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9089F10", Offset = "0x9088D10", VA = "0x189089F10")]
		public static void LRAKDRCAIXO(this Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x908A050", Offset = "0x9088E50", VA = "0x18908A050")]
		public static void XLAXXQSHRIN(this RenderTexture a, Texture2D b, bool c = false, bool d = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class VAXIIOVVORH
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public delegate string ExceptionMessageBuilder();

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public delegate TEx ExceptionBuilder<out TEx>(TimeSpan timeoutSpan);

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C78850", Offset = "0x3C77650", VA = "0x183C78850")]
		public static TaskCompletionSource<a> BWMJFVPHILN<a>(this TaskCompletionSource<a> a, TimeSpan b, [Optional] ExceptionMessageBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C76F90", Offset = "0x3C75D90", VA = "0x183C76F90")]
		public static TaskCompletionSource<b> BWMJFVPHILN<b, c>(this TaskCompletionSource<b> a, TimeSpan b, ExceptionBuilder<c> c) where c : TcsTimeoutException
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x90896E0", Offset = "0x90884E0", VA = "0x1890896E0")]
		private static void VJPTFYSLOYT(TimeSpan a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class TcsTimeoutException : TimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly TimeSpan Timeout;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9087FD0", Offset = "0x9086DD0", VA = "0x189087FD0")]
		private static FormattableString NQUWIVUDFUY(TimeSpan a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9087ED0", Offset = "0x9086CD0", VA = "0x189087ED0")]
		private static string EXJVVQAQBHV(TimeSpan a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x90884E0", Offset = "0x90872E0", VA = "0x1890884E0")]
		public TcsTimeoutException(TimeSpan timeout, string message, bool prependTime = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class HEKUYJYADTV
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly Vector3[] VXAYDKVODFA;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x90800C0", Offset = "0x907EEC0", VA = "0x1890800C0")]
		public static Vector3 WLQIAOUBTQU(this Transform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x907FF20", Offset = "0x907ED20", VA = "0x18907FF20")]
		public static Vector3 VCWSGFSWVKF(this Transform a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x907FBC0", Offset = "0x907E9C0", VA = "0x18907FBC0")]
		public static Vector3 VCWSGFSWVKF(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x907F9B0", Offset = "0x907E7B0", VA = "0x18907F9B0")]
		public static Vector3 PQLRYJUYFAL(this RectTransform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9080620", Offset = "0x907F420", VA = "0x189080620")]
		public static Vector2 ZKYRTSZBGNG(this RectTransform a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x90802B0", Offset = "0x907F0B0", VA = "0x1890802B0")]
		public static float WTLISGMAWJO(this RectTransform a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x907F780", Offset = "0x907E580", VA = "0x18907F780")]
		public static Vector3 CVHOXGHQZZV(this RectTransform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9080040", Offset = "0x907EE40", VA = "0x189080040")]
		public static Vector3[] VDKYSJJVHLC(this RectTransform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x907F870", Offset = "0x907E670", VA = "0x18907F870")]
		public static Transform IBVJGPAJSJT(this Transform a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x907FA90", Offset = "0x907E890", VA = "0x18907FA90")]
		public static bool SBOVGFLTFVC(this Transform a, Transform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x907FB40", Offset = "0x907E940", VA = "0x18907FB40")]
		public static int SIIOGPMGMCP(this Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9080420", Offset = "0x907F220", VA = "0x189080420")]
		public static void XOXGBPUZOOY(this RectTransform a, Vector3[] b, [Optional] Canvas c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class XQIPCAENNBU
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Vector2 TYIKJSLQVSC
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x908A790", Offset = "0x9089590", VA = "0x18908A790")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static float REEHTMNQLKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x908A760", Offset = "0x9089560", VA = "0x18908A760")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Quaternion KIBJQUYACPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x908A730", Offset = "0x9089530", VA = "0x18908A730")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static Vector3 IMRXJTRINZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x908A6C0", Offset = "0x90894C0", VA = "0x18908A6C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static Vector3 LQFTWWVIAHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x908A6F0", Offset = "0x90894F0", VA = "0x18908A6F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x908A780", Offset = "0x9089580", VA = "0x18908A780")]
		public static float Range(float minInclusive, float maxInclusive)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x908A770", Offset = "0x9089570", VA = "0x18908A770")]
		public static int Range(int minInclusive, int maxExclusive)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x908A720", Offset = "0x9089520", VA = "0x18908A720")]
		public static void HCKOKPVVMST(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class ZGEAICNRTAP
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly Vector2 ETZCCFTENSZ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly Vector2 LMOQXERFESP;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly Vector2 RDASNYZRHHM;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xE8D3D0", Offset = "0xE8C1D0", VA = "0x180E8D3D0")]
		public static Vector2 PUNILMBSYXK(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9092020", Offset = "0x9090E20", VA = "0x189092020")]
		public static Vector2 BPNNMJQJMZL(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9092430", Offset = "0x9091230", VA = "0x189092430")]
		public static Vector2 URWCAVGFRQA(this Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9092180", Offset = "0x9090F80", VA = "0x189092180")]
		public static bool LFPMABCWVLY(this Vector2 a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x90921B0", Offset = "0x9090FB0", VA = "0x1890921B0")]
		public static float OUOTMGWSJAO(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9092400", Offset = "0x9091200", VA = "0x189092400")]
		public static bool TTLIQXDXMMS(this Vector2 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9092520", Offset = "0x9091320", VA = "0x189092520")]
		public static Vector2 XNROTMBCTLG(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9092540", Offset = "0x9091340", VA = "0x189092540")]
		public static Vector2 XNWVQSVACWP(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9091F20", Offset = "0x9090D20", VA = "0x189091F20")]
		public static Vector2 BAPYERTDCOH(this Vector2 a, float b, float c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9091FC0", Offset = "0x9090DC0", VA = "0x189091FC0")]
		public static Vector2 BAPYERTDCOH(this Vector2 a, float b, float c, float d, float e)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class YJIHEHVJALB
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public enum Axis
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Up = 1,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Down = -1,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			Right = 2,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Left = -2,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Forward = 3,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Back = -3
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly float ADJPWEWXLJG;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x908AEB0", Offset = "0x9089CB0", VA = "0x18908AEB0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1C77C70", Offset = "0x1C76A70", VA = "0x181C77C70")]
		public static float KCUFASUFUTF(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x908B860", Offset = "0x908A660", VA = "0x18908B860")]
		public static Vector3 LVGHBHWLGFS(this Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x908B7D0", Offset = "0x908A5D0", VA = "0x18908B7D0")]
		public static Vector3 LVGHBHWLGFS(this Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x908B720", Offset = "0x908A520", VA = "0x18908B720")]
		public static Vector3 LVGHBHWLGFS(this Vector3 a, Vector3 b, Quaternion c, Vector3 d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x908C4A0", Offset = "0x908B2A0", VA = "0x18908C4A0")]
		public static Vector3 SWSSGLDCVHW(this Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x908C8E0", Offset = "0x908B6E0", VA = "0x18908C8E0")]
		public static void VAVLFAIPTIO(Vector3 a, Quaternion b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x908C810", Offset = "0x908B610", VA = "0x18908C810")]
		public static void VAVLFAIPTIO(Vector3 a, Quaternion b, Vector3 c, float d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x908BBA0", Offset = "0x908A9A0", VA = "0x18908BBA0")]
		public static bool MWALEAORSLK(this Vector3 a, float b = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x908BC40", Offset = "0x908AA40", VA = "0x18908BC40")]
		public static bool OUKRZWBWTQU(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x908BE50", Offset = "0x908AC50", VA = "0x18908BE50")]
		public static bool OWHPBVSEYTC(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x844A5B0", Offset = "0x84493B0", VA = "0x18844A5B0")]
		public static float LPGIXIEAMAF(this Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x908B700", Offset = "0x908A500", VA = "0x18908B700")]
		public static float LJNTQYVOCTN(this Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x908C060", Offset = "0x908AE60", VA = "0x18908C060")]
		public static Vector3 PRHUQTXMUSU(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x908B950", Offset = "0x908A750", VA = "0x18908B950")]
		public static Vector3 MIOCJRGXDKT(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x908B170", Offset = "0x9089F70", VA = "0x18908B170")]
		public static Vector3 BPNNMJQJMZL(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x908C7B0", Offset = "0x908B5B0", VA = "0x18908C7B0")]
		public static bool TTLIQXDXMMS(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x908C7E0", Offset = "0x908B5E0", VA = "0x18908C7E0")]
		public static bool UYRSSAAWBHD(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x908AD60", Offset = "0x9089B60", VA = "0x18908AD60")]
		public static bool ARMBDSZMBWE(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x908C770", Offset = "0x908B570", VA = "0x18908C770")]
		public static Vector3 TJLKZZEGEVK(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x908CCE0", Offset = "0x908BAE0", VA = "0x18908CCE0")]
		public static Vector3 WGBXGQPFLTL(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x908BC80", Offset = "0x908AA80", VA = "0x18908BC80")]
		public static float OUUAJNQPSLX(this Vector3 a, Vector3 b, [Optional] Vector3? c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x908AD40", Offset = "0x9089B40", VA = "0x18908AD40")]
		public static Vector3 AMXSZXWTWSF(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x28B3600", Offset = "0x28B2400", VA = "0x1828B3600")]
		public static float HHQUVGXFIBW(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x908B490", Offset = "0x908A290", VA = "0x18908B490")]
		public static float GJKYFBBHOPH(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x908CD20", Offset = "0x908BB20", VA = "0x18908CD20")]
		public static Vector3 XDMTXWOHPMO(Vector3 a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x908C0A0", Offset = "0x908AEA0", VA = "0x18908C0A0")]
		public static Axis PSQOOZUBGJN(Transform a, Vector3 b, [Out] Vector3 c)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x908B6D0", Offset = "0x908A4D0", VA = "0x18908B6D0")]
		public static Vector3 KCGTTYQGEIQ(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x908B6E0", Offset = "0x908A4E0", VA = "0x18908B6E0")]
		public static Vector3 KCMARFKDNTZ(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x908B6F0", Offset = "0x908A4F0", VA = "0x18908B6F0")]
		public static Vector3 KCRHOMEAXFI(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x908C040", Offset = "0x908AE40", VA = "0x18908C040")]
		public static Vector3 POONJWYCPPB(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x908CFB0", Offset = "0x908BDB0", VA = "0x18908CFB0")]
		public static Vector3 XNROTMBCTLG(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x908CFD0", Offset = "0x908BDD0", VA = "0x18908CFD0")]
		public static Vector3 XNWVQSVACWP(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x908CFF0", Offset = "0x908BDF0", VA = "0x18908CFF0")]
		public static Vector3 XOCCNZOXMHY(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x908BB10", Offset = "0x908A910", VA = "0x18908BB10")]
		public static Vector3 MTMCURZXVOR(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x908BA80", Offset = "0x908A880", VA = "0x18908BA80")]
		public static Vector3 MTGVXLGAMDI(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x908B9F0", Offset = "0x908A7F0", VA = "0x18908B9F0")]
		public static Vector3 MTBPAEMDCRZ(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x908BF20", Offset = "0x908AD20", VA = "0x18908BF20")]
		public static Vector3 PEAOTNPUYPQ(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x908BFB0", Offset = "0x908ADB0", VA = "0x18908BFB0")]
		public static Vector3 PEFVQUJSIAZ(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x908BE90", Offset = "0x908AC90", VA = "0x18908BE90")]
		public static Vector3 PDQAZACAFSY(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x908AD90", Offset = "0x9089B90", VA = "0x18908AD90")]
		public static Vector3 AYVVFVGHOSG(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x908AE20", Offset = "0x9089C20", VA = "0x18908AE20")]
		public static Vector3 AZBCDCAEYDP(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x908C560", Offset = "0x908B360", VA = "0x18908C560")]
		public static Vector3 TEACARBBNYJ(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x908D010", Offset = "0x908BE10", VA = "0x18908D010")]
		public static Vector3 XVWRJSWVBJF(Vector3 a, Vector3 b, Vector3 c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x908D1C0", Offset = "0x908BFC0", VA = "0x18908D1C0")]
		public static float ZYOYPPBJIXS(this Vector3 a, Vector3 b, Vector3 c, bool d = false)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x908B5F0", Offset = "0x908A3F0", VA = "0x18908B5F0")]
		public static bool JJGTZNUEDVB(this Vector3 a, Vector3 b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x908BBF0", Offset = "0x908A9F0", VA = "0x18908BBF0")]
		public static bool NMMDPGKYINJ(this Vector3 a, Vector3 b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x908C6A0", Offset = "0x908B4A0", VA = "0x18908C6A0")]
		public static byte[] THDCOOXVWRN([In] this Vector3 vec)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x908CB10", Offset = "0x908B910", VA = "0x18908CB10")]
		public static int VRTCQHCYNVA(Vector3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x908B370", Offset = "0x908A170", VA = "0x18908B370")]
		public static Vector3 GDOKSGEAQWB(int a)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct ActiveRenderTextureScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly RenderTexture originalActiveRenderTexture;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9077280", Offset = "0x9076080", VA = "0x189077280")]
		public ActiveRenderTextureScope(RenderTexture newActiveRenderTexture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9077270", Offset = "0x9076070", VA = "0x189077270", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class EAHCRNARMHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Dictionary<int, float> QBGHLGNACTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly Dictionary<int, Color> SWBAEFBZHYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Dictionary<int, Vector4> DWLIQABQRLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly Dictionary<int, Matrix4x4> SUXIIGCKUNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly Dictionary<int, Texture> QUWDLVLSFHQ;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static ProfilerMarker QNDNIUJAJFT;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool HRETGMQRAAY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAF4620", Offset = "0xAF3420", VA = "0x180AF4620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAF4630", Offset = "0xAF3430", VA = "0x180AF4630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x907BBC0", Offset = "0x907A9C0", VA = "0x18907BBC0")]
		public void SetFloat(int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x907BA80", Offset = "0x907A880", VA = "0x18907BA80")]
		public void SRJBLYTTFCX(int a, Vector4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x907B980", Offset = "0x907A780", VA = "0x18907B980")]
		public void GSSWZKYCHZN(int a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x907BC80", Offset = "0x907AA80", VA = "0x18907BC80")]
		public void XMGZWNDFZWI(Material a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x907C500", Offset = "0x907B300", VA = "0x18907C500")]
		public EAHCRNARMHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class TWLEZCZIELK
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static FOXNGVSQMSF<List<int>> EWQVKWKSPPA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9087C00", Offset = "0x9086A00", VA = "0x189087C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static FOXNGVSQMSF<List<Vector2>> CGGYKTDVKJC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x9087AC0", Offset = "0x90868C0", VA = "0x189087AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static FOXNGVSQMSF<List<Vector3>> PZLKWOHQELX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9087A70", Offset = "0x9086870", VA = "0x189087A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static FOXNGVSQMSF<List<Vector4>> ZNUXXXQOXIW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x9087BB0", Offset = "0x90869B0", VA = "0x189087BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static FOXNGVSQMSF<List<BoneWeight>> WPIJJZMZAWX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x9087B60", Offset = "0x9086960", VA = "0x189087B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static FOXNGVSQMSF<List<Matrix4x4>> DFTUVHQLBOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x9087B10", Offset = "0x9086910", VA = "0x189087B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x90877B0", Offset = "0x90865B0", VA = "0x1890877B0")]
		public static void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class YVBRGKHCTZA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x908FF60", Offset = "0x908ED60", VA = "0x18908FF60")]
		public static long KHDVTGOJEZR(Vector2 a, Vector2 b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x908D7A0", Offset = "0x908C5A0", VA = "0x18908D7A0")]
		public static long CGOLNFENFKU(float a, float b, float c, float d)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x908FFB0", Offset = "0x908EDB0", VA = "0x18908FFB0")]
		public static float WODKDSPZBGB(Matrix4x4 a, Vector2 b, float c, float d = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x908FEC0", Offset = "0x908ECC0", VA = "0x18908FEC0")]
		private static float JMFUSKPDVLS(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x908D7D0", Offset = "0x908C5D0", VA = "0x18908D7D0")]
		public static void CLULKWNURRY(List<Vector3> a, Matrix4x4 b, Vector3 c, Vector2 d, float e, [Out] bool f, float g = 0f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class EXBEUHVUMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x907D340", Offset = "0x907C140", VA = "0x18907D340")]
		public static int SQJTCCGFERD(LODGroup a, LOD[] b, Camera c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x907D3B0", Offset = "0x907C1B0", VA = "0x18907D3B0")]
		private static float YFRVPBIKFZJ(LODGroup a, Camera b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x907D270", Offset = "0x907C070", VA = "0x18907D270")]
		private static float CWFSEQCAVLV(LODGroup a, Transform b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x907D1F0", Offset = "0x907BFF0", VA = "0x18907D1F0")]
		private static float AZITCLDLFMZ(Camera a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x907D2F0", Offset = "0x907C0F0", VA = "0x18907D2F0")]
		private static float IHOANFKVTYA(Transform a)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Rendering.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class CTRJEIOYPYY
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9078AE0", Offset = "0x90778E0", VA = "0x189078AE0")]
		public static Texture2DArray NUBEOPVQRAB(string a, IReadOnlyList<Texture2D> b, Vector2? c, TextureFormat d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9079070", Offset = "0x9077E70", VA = "0x189079070")]
		private static void UXEEEQCVDUA(Texture2D a, Texture2DArray b, int c)
		{
		}
	}
}
namespace RecRoom.MathUtils
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ZTSJSSXBOXB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a REEHTMNQLKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xB8D7D0", Offset = "0xB8C5D0", VA = "0x180B8D7D0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xBC5E60", Offset = "0xBC4C60", VA = "0x180BC5E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public a KGRKXIUXULL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCA8380", Offset = "0xCA7180", VA = "0x180CA8380")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xCA8AB0", Offset = "0xCA78B0", VA = "0x180CA8AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract a GHOVMJMDJVT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xCA8AB0", Offset = "0xCA78B0", VA = "0x180CA8AB0")]
		public void UMWKMRIDZCB(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4017920", Offset = "0x4016720", VA = "0x184017920")]
		public void SRYSRRWYXJC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xBC5E60", Offset = "0xBC4C60", VA = "0x180BC5E60")]
		public void YAIOPLRHBMB(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x40176A0", Offset = "0x40164A0", VA = "0x1840176A0")]
		public a Apply(float moveTime, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4017560", Offset = "0x4016360", VA = "0x184017560")]
		public a Apply(float moveTime, float maxSpeed, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool LNZLWNAGFRP(a a);

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract a IMOWFSLIDDP(float a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected ZTSJSSXBOXB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class CNBQQRLXRGF : ZTSJSSXBOXB<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override float GHOVMJMDJVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x90929F0", Offset = "0x90917F0", VA = "0x1890929F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9092BF0", Offset = "0x90919F0", VA = "0x189092BF0", Slot = "5")]
		public override bool LNZLWNAGFRP(float a = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9092A90", Offset = "0x9091890", VA = "0x189092A90", Slot = "6")]
		protected override float IMOWFSLIDDP(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9092C30", Offset = "0x9091A30", VA = "0x189092C30")]
		public CNBQQRLXRGF()
		{
		}
	}
}
namespace RecRoom.MathUtils.Springs
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class OYBLWZBCHWU : UMCJHDJNJNL<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override float GHOVMJMDJVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x9092FA0", Offset = "0x9091DA0", VA = "0x189092FA0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override float XERGSLGUFWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x9092FF0", Offset = "0x9091DF0", VA = "0x189092FF0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9093040", Offset = "0x9091E40", VA = "0x189093040", Slot = "6")]
		protected override float ZFGODVOKFHP(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9093090", Offset = "0x9091E90", VA = "0x189093090")]
		public OYBLWZBCHWU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class XMABKVZRFLN : UMCJHDJNJNL<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override float GHOVMJMDJVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9094780", Offset = "0x9093580", VA = "0x189094780", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override float XERGSLGUFWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x9094820", Offset = "0x9093620", VA = "0x189094820", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9094850", Offset = "0x9093650", VA = "0x189094850", Slot = "6")]
		protected override float ZFGODVOKFHP(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x90948A0", Offset = "0x90936A0", VA = "0x1890948A0")]
		public XMABKVZRFLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class DELYOSWAJXA : UMCJHDJNJNL<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Vector2 GHOVMJMDJVT
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x9092C70", Offset = "0x9091A70", VA = "0x189092C70", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override Vector2 XERGSLGUFWR
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x9092CD0", Offset = "0x9091AD0", VA = "0x189092CD0", Slot = "5")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9092D30", Offset = "0x9091B30", VA = "0x189092D30", Slot = "6")]
		protected override Vector2 ZFGODVOKFHP(Vector2 a, Vector2 b, Vector2 c, float d, float e, float f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9092D80", Offset = "0x9091B80", VA = "0x189092D80")]
		public DELYOSWAJXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class IXCPFSPEAHF : UMCJHDJNJNL<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override Vector3 GHOVMJMDJVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x9092DC0", Offset = "0x9091BC0", VA = "0x189092DC0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override Vector3 XERGSLGUFWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x9092E40", Offset = "0x9091C40", VA = "0x189092E40", Slot = "5")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x9092EC0", Offset = "0x9091CC0", VA = "0x189092EC0", Slot = "6")]
		protected override Vector3 ZFGODVOKFHP(Vector3 a, Vector3 b, Vector3 c, float d, float e, float f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9092F60", Offset = "0x9091D60", VA = "0x189092F60")]
		public IXCPFSPEAHF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class UMCJHDJNJNL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public const float SKYGEIYNUDW = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public a REEHTMNQLKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xB8D7D0", Offset = "0xB8C5D0", VA = "0x180B8D7D0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xBC5E60", Offset = "0xBC4C60", VA = "0x180BC5E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public a KGRKXIUXULL
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xCA8380", Offset = "0xCA7180", VA = "0x180CA8380")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xCA8AB0", Offset = "0xCA78B0", VA = "0x180CA8AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public a CSVXVTKJKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xB1F7E0", Offset = "0xB1E5E0", VA = "0x180B1F7E0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x11D0E60", Offset = "0x11CFC60", VA = "0x1811D0E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public abstract a GHOVMJMDJVT
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract a XERGSLGUFWR
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCA8AB0", Offset = "0xCA78B0", VA = "0x180CA8AB0")]
		public void UMWKMRIDZCB(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x63B3DB0", Offset = "0x63B2BB0", VA = "0x1863B3DB0")]
		public void SRYSRRWYXJC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x63B3E30", Offset = "0x63B2C30", VA = "0x1863B3E30")]
		public void YAIOPLRHBMB(a a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x63B3440", Offset = "0x63B2240", VA = "0x1863B3440")]
		public a Apply(float smoothTime, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x63B34C0", Offset = "0x63B22C0", VA = "0x1863B34C0")]
		public a Apply(float smoothTime, float maxSpeed, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract a ZFGODVOKFHP(a a, a b, a c, float d, float e, float f);

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected UMCJHDJNJNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class PJMQZGEJSVC
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public const float SKYGEIYNUDW = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Quaternion REEHTMNQLKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xCDB8A0", Offset = "0xCDA6A0", VA = "0x180CDB8A0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xCDB8C0", Offset = "0xCDA6C0", VA = "0x180CDB8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Quaternion KGRKXIUXULL
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xCC0160", Offset = "0xCBEF60", VA = "0x180CC0160")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xD773B0", Offset = "0xD761B0", VA = "0x180D773B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float CSVXVTKJKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xC43170", Offset = "0xC41F70", VA = "0x180C43170")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xE810F0", Offset = "0xE7FEF0", VA = "0x180E810F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xD773B0", Offset = "0xD761B0", VA = "0x180D773B0")]
		public void UMWKMRIDZCB(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9093450", Offset = "0x9092250", VA = "0x189093450")]
		public void SRYSRRWYXJC(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9093290", Offset = "0x9092090", VA = "0x189093290")]
		public Quaternion Apply(float smoothTime, float deltaTime)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x90930D0", Offset = "0x9091ED0", VA = "0x1890930D0")]
		public Quaternion Apply(float smoothTime, float maxSpeed, float deltaTime)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9093470", Offset = "0x9092270", VA = "0x189093470")]
		private static Quaternion ZFGODVOKFHP(Quaternion a, Quaternion b, float c, float d, float e, float f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public PJMQZGEJSVC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class SimpleSpringConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float stiffness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float damping;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9093EC0", Offset = "0x9092CC0", VA = "0x189093EC0")]
		public SimpleSpringConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class UBVFANLZJBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly SimpleSpringConfig WGIOSXOWBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Vector2 OTERXFAYJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Vector2 TSZUKVFTJMX;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public UBVFANLZJBT(SimpleSpringConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x90946E0", Offset = "0x90934E0", VA = "0x1890946E0")]
		public Vector2 ZFGODVOKFHP(Vector2 a, float b)
		{
			return default(Vector2);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class SimpleSpring6DConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public float spring;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public float damping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float maxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float angularSpring;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public float angularDamping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float maxAngularSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Add angular acceleration caused by linear acceleration")]
		public Vector3 waggleAxis;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9093E40", Offset = "0x9092C40", VA = "0x189093E40")]
		public SimpleSpring6DConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class UAQLKKGUTLT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private SimpleSpring6DConfig WGIOSXOWBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Vector3 TSZUKVFTJMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Vector3 VMJNHDYZFJP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 RSLTEECADAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x179CEC0", Offset = "0x179BCC0", VA = "0x18179CEC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x179CEE0", Offset = "0x179BCE0", VA = "0x18179CEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 IIYQCROBXLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1AC7000", Offset = "0x1AC5E00", VA = "0x181AC7000")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x186D840", Offset = "0x186C640", VA = "0x18186D840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion BUKHKNIAYGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xD20AD0", Offset = "0xD1F8D0", VA = "0x180D20AD0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xD21730", Offset = "0xD20530", VA = "0x180D21730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion LPLELFIJVOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xE66DD0", Offset = "0xE65BD0", VA = "0x180E66DD0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xE66DC0", Offset = "0xE65BC0", VA = "0x180E66DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float QOBQUNPJDEN
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x9094610", Offset = "0x9093410", VA = "0x189094610")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9094640", Offset = "0x9093440", VA = "0x189094640")]
		public UAQLKKGUTLT(SimpleSpring6DConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9093F20", Offset = "0x9092D20", VA = "0x189093F20")]
		public void AAOXBVORFUO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
		public void TFZACFGOFMK(SimpleSpring6DConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9093EE0", Offset = "0x9092CE0", VA = "0x189093EE0")]
		public void AAOXBVORFUO()
		{
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class FDRGVMVUGTM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3761050", Offset = "0x375FE50", VA = "0x183761050")]
		public static void QNYLTSYJPNK<a>(NativeArray<a> a, int b, Allocator c) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x37612E0", Offset = "0x37600E0", VA = "0x1837612E0")]
		public static e[] VWPBFCFVSRE<e>(NativeArray<e> a, int b) where e : struct
		{
			return null;
		}
	}
}
namespace RecRoom.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class SPOGHZDTKWO
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly int[] RLLAQZBKOCR;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x9093D10", Offset = "0x9092B10", VA = "0x189093D10")]
		public static void UXLENGHILKZ(this IncrementalHash a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9093D70", Offset = "0x9092B70", VA = "0x189093D70")]
		public static void XFNWLVCUIDP(this IncrementalHash a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9093930", Offset = "0x9092730", VA = "0x189093930")]
		public static void TQDOEDYPAUO(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9093B20", Offset = "0x9092920", VA = "0x189093B20")]
		public static void UTTKFYQRKMZ(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x90935E0", Offset = "0x90923E0", VA = "0x1890935E0")]
		public static void OEOGWPPNFJM(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x90937D0", Offset = "0x90925D0", VA = "0x1890937D0")]
		public static void OJFGRCKRHKC(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1930", Offset = "0x3AF0730", VA = "0x183AF1930")]
		public static void PVHRVRPRFPT<a>(this IncrementalHash a, short b) where a : Enum
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
