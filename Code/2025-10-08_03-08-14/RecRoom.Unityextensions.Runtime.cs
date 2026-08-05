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
using System.Text;
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GYQLRCYBJDX
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x90C5FF0", Offset = "0x90C4DF0", VA = "0x1890C5FF0")]
	public static int GVCDJSYCTIZ(this DateTime a)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x90C6650", Offset = "0x90C5450", VA = "0x1890C6650")]
	public static int PHNJWPACOMW(int a, int b, int c)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x90C69D0", Offset = "0x90C57D0", VA = "0x1890C69D0")]
	public static bool VYQUVGSUQGY(this DateTime a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x90C64E0", Offset = "0x90C52E0", VA = "0x1890C64E0")]
	public static bool JJHUVHSZJKM(this DateTime a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x90C60A0", Offset = "0x90C4EA0", VA = "0x1890C60A0")]
	public static string IRCKRVPAEAL(DateTime a, bool b = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x90C5EB0", Offset = "0x90C4CB0", VA = "0x1890C5EB0")]
	public static string GJRWZRTRTPW(this DateTime a, [Optional] CultureInfo b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x90C6D80", Offset = "0x90C5B80", VA = "0x1890C6D80")]
	public static string ZFHEYGQLLBK(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x90C6A90", Offset = "0x90C5890", VA = "0x1890C6A90")]
	private static string WSDKDSLAWDS(int a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x90C65C0", Offset = "0x90C53C0", VA = "0x1890C65C0")]
	public static string KTPATSXUXAP(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x90C6900", Offset = "0x90C5700", VA = "0x1890C6900")]
	public static string UEIPCDLGLVY(this float a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x90C67D0", Offset = "0x90C55D0", VA = "0x1890C67D0")]
	public static string SPIJAYJYYEX(this int a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x90C6B40", Offset = "0x90C5940", VA = "0x1890C6B40")]
	public static string YVFHXPDHSIW(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x90C6740", Offset = "0x90C5540", VA = "0x1890C6740")]
	[CompilerGenerated]
	internal static string RFCACRIJRYW(int a, string b)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LAGXYEXBWVQ
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x90CE670", Offset = "0x90CD470", VA = "0x1890CE670")]
	public static Rect JOXUBXDBHOX(this RectTransform a, Camera b, [Optional] Vector3[] c)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BNYXMKMKEQF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static float XNWGXBYLWTE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90C2120", Offset = "0x90C0F20", VA = "0x1890C2120")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static float STEJRSIWHYY
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC56CC0", Offset = "0xC55AC0", VA = "0x180C56CC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static float AYKGUORBEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x90C2130", Offset = "0x90C0F30", VA = "0x1890C2130")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x90C20F0", Offset = "0x90C0EF0", VA = "0x1890C20F0")]
	public static float CKVMTYMUHAH(float a)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MDIPPKPYIFL
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x90D00E0", Offset = "0x90CEEE0", VA = "0x1890D00E0")]
	public static bool QWKHTAHSYHE(this DateTime a, TimeSpan b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x90CF1C0", Offset = "0x90CDFC0", VA = "0x1890CF1C0")]
	public static string EONBTKWNVQZ(this TimeSpan a, string b = "minute", bool c = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x90CF640", Offset = "0x90CE440", VA = "0x1890CF640")]
	public static string JNVODPZIMOV(this TimeSpan a, string b = "minute", bool c = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x90CF120", Offset = "0x90CDF20", VA = "0x1890CF120")]
	private static string BAOOONUNTQJ(string a, double b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x90D0160", Offset = "0x90CEF60", VA = "0x1890D0160")]
	public static string SAFBJUVFGOX(this TimeSpan a, bool b = false, bool c = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x90CFAB0", Offset = "0x90CE8B0", VA = "0x1890CFAB0")]
	public static string OCUCYYPHTON(this TimeSpan a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x90D0940", Offset = "0x90CF740", VA = "0x1890D0940")]
	public static string SFNJOOXVYHD(this TimeSpan a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x90CFA50", Offset = "0x90CE850", VA = "0x1890CFA50")]
	public static string NJXQIRJRHTG(this TimeSpan a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x90D0BE0", Offset = "0x90CF9E0", VA = "0x1890D0BE0")]
	private static string YMGAFCDJDDP(string a, int b)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IFFCTMBRZJM
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x90C98F0", Offset = "0x90C86F0", VA = "0x1890C98F0")]
	public static string LGXMJIJFOKF(this Type a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39653A0", Offset = "0x39641A0", VA = "0x1839653A0")]
	public static bool LQJIGWJRSAV<a>(this Type a, [Out] a b, bool c = true) where a : Attribute
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
		[Cpp2IlInjected.Address(RVA = "0x90CF0A0", Offset = "0x90CDEA0", VA = "0x1890CF0A0", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x90DD7A0", Offset = "0x90DC5A0", VA = "0x1890DD7A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class GPINXMLQMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x90C5D20", Offset = "0x90C4B20", VA = "0x1890C5D20")]
		public static float PEVMYJLTXWW(this AnimationCurve a, float b)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class SYVKEXXYFOS
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MVKUZKRYUYD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public int BPJMJIDBWCT;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MVKUZKRYUYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x90D22F0", Offset = "0x90D10F0", VA = "0x1890D22F0")]
			internal bool PILWBOZVQXO(AnimatorControllerParameter a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x90D6890", Offset = "0x90D5690", VA = "0x1890D6890")]
		public static void ECCTWRZJVSP(this Animator a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x90D6910", Offset = "0x90D5710", VA = "0x1890D6910")]
		public static void FTLNBMPHLWQ(this Animator a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x90D6970", Offset = "0x90D5770", VA = "0x1890D6970")]
		public static void WBTCKRLYAYI(this Animator a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x90D67B0", Offset = "0x90D55B0", VA = "0x1890D67B0")]
		public static bool DBIEIJCWITC(this Animator a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class DNELBKVNQKU
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37A5700", Offset = "0x37A4500", VA = "0x1837A5700")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37A5810", Offset = "0x37A4610", VA = "0x1837A5810")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class TFJGNGXDSEZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class YLAONGPGXVE<a> where a : AsyncOperation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> MLJCJPZPQME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public a ZMTOKQICYCG;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public YLAONGPGXVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x409FF20", Offset = "0x409ED20", VA = "0x18409FF20")]
			internal void WCZJZESSACB(AsyncOperation a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D30CB0", Offset = "0x3D2FAB0", VA = "0x183D30CB0")]
		public static Task<a> AZITBKHUMYS<a>(this a a) where a : AsyncOperation
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class NXGBYSJUDJT
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90D3350", Offset = "0x90D2150", VA = "0x1890D3350")]
		public static Bounds ASNCTADLLLF(IList<Bounds> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x90D3870", Offset = "0x90D2670", VA = "0x1890D3870")]
		public static Bounds OWLHBMILSLZ(this GameObject a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x90D3A80", Offset = "0x90D2880", VA = "0x1890D3A80")]
		public static Bounds OWLHBMILSLZ(this GameObject a, [In] List<Renderer> renderers)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MLWUPCEDYGN
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
			public GameObject FEVRUSAGTIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x90C2460", Offset = "0x90C1260", VA = "0x1890C2460")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x90C27A0", Offset = "0x90C15A0", VA = "0x1890C27A0")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x90C2160", Offset = "0x90C0F60", VA = "0x1890C2160", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x90C22B0", Offset = "0x90C10B0", VA = "0x1890C22B0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x90C2350", Offset = "0x90C1150", VA = "0x1890C2350", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x90C2500", Offset = "0x90C1300", VA = "0x1890C2500", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly List<CacheParameters> IUUKKCFPKNT;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Dictionary<CacheParameters, ICollection> OUNYRNGRYGD;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static int TFKJYGCQSWD;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x90D0EE0", Offset = "0x90CFCE0", VA = "0x1890D0EE0")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EB30", Offset = "0x3A2D930", VA = "0x183A2EB30")]
		public static a JMHEWLKVQBI<a>(this GameObject a, bool b = false)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F5B0", Offset = "0x3A2E3B0", VA = "0x183A2F5B0")]
		public static b ZUPOWOUQLEZ<b>(this GameObject a, bool b = true, bool c = false)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E8A0", Offset = "0x3A2D6A0", VA = "0x183A2E8A0")]
		public static c HEPUXYRTMQK<c>(this GameObject a, bool b = true, bool c = false)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A2ED40", Offset = "0x3A2DB40", VA = "0x183A2ED40")]
		public static IReadOnlyList<e> OUCXLLHZUDC<e>(this GameObject a, bool b = true, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E1B0", Offset = "0x3A2CFB0", VA = "0x183A2E1B0")]
		public static IReadOnlyList<f> COQFQPBAOEX<f>(this GameObject a, bool b = true, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F8F0", Offset = "0x3A2E6F0", VA = "0x183A2F8F0")]
		private static g ZVRXRMFDUUX<g>(CacheParameters a, bool b = false)
		{
			return (g)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E470", Offset = "0x3A2D270", VA = "0x183A2E470")]
		private static IReadOnlyList<h> EAGKYSJIEKG<h>(CacheParameters a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x90D0F70", Offset = "0x90CFD70", VA = "0x1890D0F70")]
		private static void NVEHFRNDZCY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x90D1000", Offset = "0x90CFE00", VA = "0x1890D1000")]
		private static void ZBDOCAXZGCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F2A0", Offset = "0x3A2E0A0", VA = "0x183A2F2A0")]
		private static IReadOnlyList<i> WGJNKRNLSZR<i>(CacheParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EF60", Offset = "0x3A2DD60", VA = "0x183A2EF60")]
		private static IReadOnlyList<j> SZPLFWQZIQE<j>(CacheParameters a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class OKLTTMZVIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x90D4830", Offset = "0x90D3630", VA = "0x1890D4830")]
		public static float GQGAXICFYPO(this Camera a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x90D4980", Offset = "0x90D3780", VA = "0x1890D4980")]
		public static float NCCBZEYYGOB(this Camera a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90D4DD0", Offset = "0x90D3BD0", VA = "0x1890D4DD0")]
		public static float ZPZDWIXDIZZ(this Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x90D4DA0", Offset = "0x90D3BA0", VA = "0x1890D4DA0")]
		private static float SNGCEVINFZY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x90D4D60", Offset = "0x90D3B60", VA = "0x1890D4D60")]
		private static float SNGCEVINFZY(Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x90D4260", Offset = "0x90D3060", VA = "0x1890D4260")]
		private static float CKKLDZERSAH(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x90D42A0", Offset = "0x90D30A0", VA = "0x1890D42A0")]
		private static float CKKLDZERSAH(Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x90D4530", Offset = "0x90D3330", VA = "0x1890D4530")]
		public static float CYRKPSYMZAD(float a, float b, float c = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x90D4300", Offset = "0x90D3100", VA = "0x1890D4300")]
		public static float CYRKPSYMZAD(this Camera a, float b, float c = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x90D43C0", Offset = "0x90D31C0", VA = "0x1890D43C0")]
		public static float CYRKPSYMZAD(this Camera a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A90", Offset = "0x90D3890", VA = "0x1890D4A90")]
		public static float OEODEDCAUFB(float a, float b, Vector2 c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x90D45E0", Offset = "0x90D33E0", VA = "0x1890D45E0")]
		public static float DNQSSSBMYOV(this Camera a, Vector2 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x90D4CD0", Offset = "0x90D3AD0", VA = "0x1890D4CD0")]
		private static float QHXUSOJJXQK(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x90D49F0", Offset = "0x90D37F0", VA = "0x1890D49F0")]
		private static float NVBWEMZXJAI(float a, float b, float c, float d = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x90D4900", Offset = "0x90D3700", VA = "0x1890D4900")]
		public static void LLZRCUOFGFW(this Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x90D4220", Offset = "0x90D3020", VA = "0x1890D4220")]
		public static bool AJUZICFSQJR(this Camera a, Bounds b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x90D4880", Offset = "0x90D3680", VA = "0x1890D4880")]
		public static bool HCBHMZJNDOJ(this Camera a, Vector3 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class FLREWJLADGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class SQTKEGTTCEN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public ICollection<a> UVNLJQGIEQJ;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public SQTKEGTTCEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x60F9B40", Offset = "0x60F8940", VA = "0x1860F9B40")]
			internal bool BADRKASLHJV(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x38E7730", Offset = "0x38E6530", VA = "0x1838E7730")]
		public static a YVNDKDLDREW<a>(this ICollection<a> a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x38E5EA0", Offset = "0x38E4CA0", VA = "0x1838E5EA0")]
		public static bool IIDFQVXUJRP<b>(this ICollection<b> a, IEnumerable<b> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class XYQZQWBIAVE
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static RaycastHit[] DNRRNFXOUYY;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x90DC870", Offset = "0x90DB670", VA = "0x1890DC870")]
		public static bool IJRHVHVKUPD(this Collider a, Vector3 b, Vector3 c, float d, Vector3 e, float f, [Out] RaycastHit g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x90DC5F0", Offset = "0x90DB3F0", VA = "0x1890DC5F0")]
		public static int FWEKFLOWDOM(this BoxCollider a, int b, QueryTriggerInteraction c, Collider[] d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x90DCB20", Offset = "0x90DB920", VA = "0x1890DCB20")]
		public static bool JYMENBWNBQI(this BoxCollider a, int b, QueryTriggerInteraction c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90DD0E0", Offset = "0x90DBEE0", VA = "0x1890DD0E0")]
		public static int VZWCEUBLDDQ(this BoxCollider a, Collider[] b, int c, QueryTriggerInteraction d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x90DC340", Offset = "0x90DB140", VA = "0x1890DC340")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x90DCD80", Offset = "0x90DBB80", VA = "0x1890DCD80")]
		public static bool JYMENBWNBQI(this CapsuleCollider a, int b, QueryTriggerInteraction c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x90DC4D0", Offset = "0x90DB2D0", VA = "0x1890DC4D0")]
		public static Vector3 FGMNNHLTVHO(this BoxCollider a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x90DC560", Offset = "0x90DB360", VA = "0x1890DC560")]
		public static Vector3 FGMNNHLTVHO(this SphereCollider a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x90DD360", Offset = "0x90DC160", VA = "0x1890DD360")]
		public static Vector3 XFKQCRFWKLG(this BoxCollider a)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class JBHICQTEJMZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Color UCVHGFFCUQD;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x90CDC90", Offset = "0x90CCA90", VA = "0x1890CDC90")]
		public static Color DMWUNRZMOCF(this Color a, float b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x90CDEE0", Offset = "0x90CCCE0", VA = "0x1890CDEE0")]
		public static Vector3 ZSCUPQUBFEP(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x90CDE70", Offset = "0x90CCC70", VA = "0x1890CDE70")]
		public static Color ZSCUPQUBFEP(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x90CDE60", Offset = "0x90CCC60", VA = "0x1890CDE60")]
		public static Color WCXMEBQPLDD(this Color a, float b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x90CDCB0", Offset = "0x90CCAB0", VA = "0x1890CDCB0")]
		public static Color FOVCHKDRGCX(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90CD960", Offset = "0x90CC760", VA = "0x1890CD960")]
		public static Color AUYKSCNHPSK(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A62D80", Offset = "0x2A61B80", VA = "0x182A62D80")]
		public static float VOJKREMLVNR([In] Color start, [In] Color end, [In] Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x90CDDD0", Offset = "0x90CCBD0", VA = "0x1890CDDD0")]
		public static float OFDAWIFPKPO([In] Color start, [In] Color end, [In] Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x90CDD80", Offset = "0x90CCB80", VA = "0x1890CDD80")]
		public static float NZZPZHFYDHD([In] Color color)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class IICBOEJIJHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Dictionary<Type, FieldInfo[]> RAZXTZXMCIR;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3967220", Offset = "0x3966020", VA = "0x183967220")]
		public static a QGSIJWQSEPF<a>(this Component a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x90C9DB0", Offset = "0x90C8BB0", VA = "0x1890C9DB0")]
		public static void SWMKMGGZZCW(this Component a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x90C9B00", Offset = "0x90C8900", VA = "0x1890C9B00")]
		public static bool IXEWCWGKHEW(this Component a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3967170", Offset = "0x3965F70", VA = "0x183967170")]
		public static List<f> IAYHJQWAGUQ<f>(this Component a) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x39671B0", Offset = "0x3965FB0", VA = "0x1839671B0")]
		public static g LGKJPHAAYDN<g>(this Component a, bool b) where g : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class PCHTGVDFSDB
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class QXYXUMDEQZR<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private a QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int ZTWVKUQIWZR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private GameObject[] ZQOYYDJZEJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private int ZQUFVKDWNVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private a[] ZQZMSQXTXGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int ZRETPXRRGRV;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private a QAORDEUFUHM
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public QXYXUMDEQZR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E42060", Offset = "0x5E40E60", VA = "0x185E42060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E41FC0", Offset = "0x5E40DC0", VA = "0x185E41FC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> BDJRHOPGRSB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E42230", Offset = "0x5E41030", VA = "0x185E42230", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3B18B70", Offset = "0x3B17970", VA = "0x183B18B70")]
		[IteratorStateMachine(typeof(QXYXUMDEQZR<>))]
		public static IEnumerable<a> YJWWVCNKAVE<a>() where a : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class LODEBCEMDFM
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class VSBYPSDEBHQ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action EPDNLWJBQOJ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public VSBYPSDEBHQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x90DA180", Offset = "0x90D8F80", VA = "0x1890DA180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x90DA140", Offset = "0x90D8F40", VA = "0x1890DA140", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class ICKOEQNSRWX : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float YRFCYJWKKAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Action EPDNLWJBQOJ;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public ICKOEQNSRWX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x90C9840", Offset = "0x90C8640", VA = "0x1890C9840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x90C9800", Offset = "0x90C8600", VA = "0x1890C9800", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static WaitForEndOfFrame RANTTRAKBXM;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x90CEDC0", Offset = "0x90CDBC0", VA = "0x1890CEDC0")]
		[IteratorStateMachine(typeof(ICKOEQNSRWX))]
		public static IEnumerator WLFTASELEFM(float a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x90CED50", Offset = "0x90CDB50", VA = "0x1890CED50")]
		[IteratorStateMachine(typeof(VSBYPSDEBHQ))]
		public static IEnumerator VOHREZGIVGO(Action a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class EditorDirtyStateExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly Log BPZENQYEUFK;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log RJJBDRSQZWF;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly Log WJWOTNFCVSM;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class AMQPVKFMJIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class YLAONGPGXVE<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Func<a, string> FZXIRERUKYJ;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public YLAONGPGXVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x409E910", Offset = "0x409D710", VA = "0x18409E910")]
			internal string GOYPRCGMNMH(int a, a b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class SQTKEGTTCEN<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public string JZEUMDEOOFX;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public SQTKEGTTCEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x60FA1E0", Offset = "0x60F8FE0", VA = "0x1860FA1E0")]
			internal string GOYPRCGMNMH(string a, string b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class GFCSLOTNWQB<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private a QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private a TRCZVHNQMBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public a VGGEVMATCEX;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a QAORDEUFUHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x4A5DFF0", Offset = "0x4A5CDF0", VA = "0x184A5DFF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public GFCSLOTNWQB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x4A5D920", Offset = "0x4A5C720", VA = "0x184A5D920", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x4A5D6D0", Offset = "0x4A5C4D0", VA = "0x184A5D6D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> BDJRHOPGRSB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4A5DD70", Offset = "0x4A5CB70", VA = "0x184A5DD70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x327DC90", Offset = "0x327CA90", VA = "0x18327DC90")]
		public static string DHBQQANNYLK<a>(this IEnumerable<a> a, [Optional] Func<a, string> b, string c = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x327DF00", Offset = "0x327CD00", VA = "0x18327DF00")]
		public static string DHBQQANNYLK<b>(this IList<b> a, [Optional] Func<int, b, string> b, string c = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3289980", Offset = "0x3288780", VA = "0x183289980")]
		[IteratorStateMachine(typeof(GFCSLOTNWQB<>))]
		public static IEnumerable<c> XNLDVZNHENA<c>(c a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class HWYOLLXQQPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly Regex GJBILTNKHRD;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3282B50", Offset = "0x3281950", VA = "0x183282B50")]
		public static IEnumerable<string> XWKLFTZTOMD<c>(this IEnumerable<c> a) where c : Enum
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class LBYUFLLRCUY
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
			[Cpp2IlInjected.Address(RVA = "0x90D8350", Offset = "0x90D7150", VA = "0x1890D8350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x90D87F0", Offset = "0x90D75F0", VA = "0x1890D87F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x90CE9C0", Offset = "0x90CD7C0", VA = "0x1890CE9C0")]
		public static string GFFMHJYEHQK(this FileInfo a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x90CEBB0", Offset = "0x90CD9B0", VA = "0x1890CEBB0")]
		public static string GFFMHJYEHQK(this FileInfo a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x90CE8A0", Offset = "0x90CD6A0", VA = "0x1890CE8A0")]
		[AsyncStateMachine(typeof(<ReadAllBytesAsync>d__2))]
		public static Task<byte[]> EXGZYWEBPXV(string a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class NUQGLQPAZJQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x90D2380", Offset = "0x90D1180", VA = "0x1890D2380")]
		public static bool TICRWOTVFMZ(this float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x90D2320", Offset = "0x90D1120", VA = "0x1890D2320")]
		public static float JFBINJOOHPP(this float a, float b)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class FATIBECWSZX
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class BDCZEZVVVGH<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private a QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private GameObject UVNLJQGIEQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public GameObject IKXRLHKYTXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private Transform JPTOVYVGEQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int ZTRONNWLNOI;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private a QAORDEUFUHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public BDCZEZVVVGH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x70E9630", Offset = "0x70E8430", VA = "0x1870E9630", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x4A5D570", Offset = "0x4A5C370", VA = "0x184A5D570", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> BDJRHOPGRSB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x70E9780", Offset = "0x70E8580", VA = "0x1870E9780", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class LOVVLRESHCU : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private string QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private GameObject PUWFZHFAMZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public GameObject TZCEGDQHYFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private Transform PAKVLFZTIEO;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private string OKRCHDZTANI
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public LOVVLRESHCU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x90CEEF0", Offset = "0x90CDCF0", VA = "0x1890CEEF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x90CEEB0", Offset = "0x90CDCB0", VA = "0x1890CEEB0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x90CF000", Offset = "0x90CDE00", VA = "0x1890CF000", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> RBKDWSRDIQZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x90CF000", Offset = "0x90CDE00", VA = "0x1890CF000", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static Dictionary<int, int> FIOHBWATRFQ;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x90C3050", Offset = "0x90C1E50", VA = "0x1890C3050")]
		public static void ERONZDOMGRW(Transform a, HideFlags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x15B0BB0", Offset = "0x15AF9B0", VA = "0x1815B0BB0")]
		public static void WKZCWDPDYKU(this GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3857F90", Offset = "0x3856D90", VA = "0x183857F90")]
		[IteratorStateMachine(typeof(BDCZEZVVVGH<>))]
		public static IEnumerable<a> SVJHOOPGRAE<a>(this GameObject a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x38D6C20", Offset = "0x38D5A20", VA = "0x1838D6C20")]
		public static b RHRAHZOTGOV<b>(this GameObject a) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x38D6770", Offset = "0x38D5570", VA = "0x1838D6770")]
		public static c LGKJPHAAYDN<c>(this GameObject a, bool b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x38D6D90", Offset = "0x38D5B90", VA = "0x1838D6D90")]
		public static d UBPUJLCICAO<d>(this GameObject a) where d : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x38D6CE0", Offset = "0x38D5AE0", VA = "0x1838D6CE0")]
		public static e UBPUJLCICAO<e>(this Component a) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x38D69D0", Offset = "0x38D57D0", VA = "0x1838D69D0")]
		public static void QIJQBMSISAS<f>(this GameObject a, List<f> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x38D6910", Offset = "0x38D5710", VA = "0x1838D6910")]
		public static void QIJQBMSISAS<g>(this Component a, List<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x38D6B50", Offset = "0x38D5950", VA = "0x1838D6B50")]
		public static void QSWYGWYYHSC<h>(this GameObject a, bool b, List<h> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x90C2E10", Offset = "0x90C1C10", VA = "0x1890C2E10")]
		public static void CSRQHNBUCUO(this GameObject a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x90C3360", Offset = "0x90C2160", VA = "0x1890C3360")]
		public static string UMMTDPAKBVN(this GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x90C32E0", Offset = "0x90C20E0", VA = "0x1890C32E0")]
		[IteratorStateMachine(typeof(LOVVLRESHCU))]
		private static IEnumerable<string> QBAVAAMGDIL(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x90C3120", Offset = "0x90C1F20", VA = "0x1890C3120")]
		public static int IDNIAZYJXJG(this GameObject a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class VQFOMBWUEZR
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DD00", Offset = "0x3E7CB00", VA = "0x183E7DD00")]
		public static bool LUNQZXOWALF<a>(string a, [Out] a b, [Optional] Func<a> c, params JsonConverter[] converters)
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
		[Cpp2IlInjected.Address(RVA = "0x102FDC0", Offset = "0x102EBC0", VA = "0x18102FDC0")]
		public Torus(float majorRadius, float minorRadius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x90D7B50", Offset = "0x90D6950", VA = "0x1890D7B50")]
		private bool SWJKCPDIBOY([In] Ray ray, [Out] float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x90D7A80", Offset = "0x90D6880", VA = "0x1890D7A80")]
		public bool SWJKCPDIBOY([In] Ray ray, [Out] Vector3 a, [Out] Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x90D81F0", Offset = "0x90D6FF0", VA = "0x1890D81F0")]
		public bool SWJKCPDIBOY(Transform a, [In] Ray ray, [Out] Vector3 b, [Out] Vector3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x90D7880", Offset = "0x90D6680", VA = "0x1890D7880")]
		private Vector3 Normal([In] Vector3 pos)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class HICKKYZCICH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x90C9700", Offset = "0x90C8500", VA = "0x1890C9700")]
		public static string IDWREYLWQVL(this int a, int b = 99)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class ICTSZAZMZLV
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3961CA0", Offset = "0x3960AA0", VA = "0x183961CA0")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3961810", Offset = "0x3960610", VA = "0x183961810")]
		public static T Random<T>(this IReadOnlyList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3961F10", Offset = "0x3960D10", VA = "0x183961F10")]
		public static void YQXXTQQSBHN<a>(this List<a> a) where a : UnityEngine.Object
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class NYZDBZNKRIZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x90D3C60", Offset = "0x90D2A60", VA = "0x1890D3C60")]
		public static void XLEHXZFRARL(this Material a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2C60", Offset = "0x3AD1A60", VA = "0x183AD2C60")]
		public static TEnum QRXHKRQCDZG<TEnum>(this Material a, int b) where TEnum : struct, Enum
		{
			return (TEnum)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class HDNFXEKMSPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<float> UIYWYGLHCOX;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<float> LEODGWMAMVB;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x90C73F0", Offset = "0x90C61F0", VA = "0x1890C73F0")]
		public static bool DDQAAUURUJH(int a, int b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x90C9150", Offset = "0x90C7F50", VA = "0x1890C9150")]
		public static float XFHNBTBTQIY(this IList<float> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x90C7930", Offset = "0x90C6730", VA = "0x1890C7930")]
		public static float HYTRZTFYVPC(this IList<float> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x90C7A20", Offset = "0x90C6820", VA = "0x1890C7A20")]
		public static void IJQTIOIHNJH(Vector3 a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x90C7850", Offset = "0x90C6650", VA = "0x1890C7850")]
		public static void GJMDBHOMJHY(Vector3 a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x90C7030", Offset = "0x90C5E30", VA = "0x1890C7030")]
		public static Vector3 ADUMXVLPAGH(float a, float b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x90C7DE0", Offset = "0x90C6BE0", VA = "0x1890C7DE0")]
		public static Vector3 JRPAKNSUJLA(float a, float b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x90C9550", Offset = "0x90C8350", VA = "0x1890C9550")]
		public static Vector3 ZGROHXPOPSP(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x90C82C0", Offset = "0x90C70C0", VA = "0x1890C82C0")]
		public static bool OXIPPGSCZTL(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x90C86C0", Offset = "0x90C74C0", VA = "0x1890C86C0")]
		public static Vector3 VIHUMUKMFZA(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x90C70D0", Offset = "0x90C5ED0", VA = "0x1890C70D0")]
		public static float BWPWKDFLFGT(Ray a, Ray b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x90C8CD0", Offset = "0x90C7AD0", VA = "0x1890C8CD0")]
		private static float XFHNBTBTQIY(this IList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x90C7EE0", Offset = "0x90C6CE0", VA = "0x1890C7EE0")]
		public static bool KAVFCTGUMSM(float a, float b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x90C8310", Offset = "0x90C7110", VA = "0x1890C8310")]
		public static Vector3 QLLEMWUNBUG(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x90C92E0", Offset = "0x90C80E0", VA = "0x1890C92E0")]
		public static Vector3 YDUSKLWNZIJ(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x90C7AD0", Offset = "0x90C68D0", VA = "0x1890C7AD0")]
		public static void IXPHLRBBATN(RRTransform a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x90C8800", Offset = "0x90C7600", VA = "0x1890C8800")]
		public static Vector3 WLNVENIDXJI(Vector3 a, Vector3 b, float c, float d, [Out] float e)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x90C7F50", Offset = "0x90C6D50", VA = "0x1890C7F50")]
		public static Vector3 MIWMUYAJVQH(Vector3 a, Vector3 b, float c, [Out] float d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x90C7410", Offset = "0x90C6210", VA = "0x1890C7410")]
		private static float DZJJXXIQSRF(Vector3 a, Vector3 b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x90C73D0", Offset = "0x90C61D0", VA = "0x1890C73D0")]
		public static float DBDCSXBUHRH(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x90C9530", Offset = "0x90C8330", VA = "0x1890C9530")]
		public static float ZBCMKAMIXJN(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x90C7780", Offset = "0x90C6580", VA = "0x1890C7780")]
		public static float GAUKJBURTUR(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x90C8C40", Offset = "0x90C7A40", VA = "0x1890C8C40")]
		public static void WWUAJMBIKDM(float a, float b, float c, [Out] float d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x90C8280", Offset = "0x90C7080", VA = "0x1890C8280")]
		public static float MUVIGACKOSB(this float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x90C7F00", Offset = "0x90C6D00", VA = "0x1890C7F00")]
		public static float LPVBBLIBVWP(this float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x90C7A90", Offset = "0x90C6890", VA = "0x1890C7A90")]
		public static float ISDGLWLHDKT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x29FA660", Offset = "0x29F9460", VA = "0x1829FA660")]
		public static float MRWRKHXSIDB(this float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x90C94A0", Offset = "0x90C82A0", VA = "0x1890C94A0")]
		public static float YSXWIEVIXKY(int a = 30)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x90C8450", Offset = "0x90C7250", VA = "0x1890C8450")]
		public static Vector3 QNORNWPUFJB(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7A06880", Offset = "0x7A05680", VA = "0x187A06880")]
		public static bool JIVKFRBCCVW(this float a, float b, float c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class XESUEQNTZWJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x90DC1C0", Offset = "0x90DAFC0", VA = "0x1890DC1C0")]
		public static IDisposable YWMJDPOVLUI(this Mesh a, int b, [Out] List<Vector2> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x90DC050", Offset = "0x90DAE50", VA = "0x1890DC050")]
		public static IDisposable WPMTPJTJEAB(this Mesh a, [Out] List<Vector3> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x90DB8B0", Offset = "0x90DA6B0", VA = "0x1890DB8B0")]
		public static IDisposable HSKVMTROMXO(this Mesh a, [Out] List<Vector3> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x90DB740", Offset = "0x90DA540", VA = "0x1890DB740")]
		public static IDisposable CYBGWDJNVBG(this Mesh a, [Out] List<Vector4> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x90DBEE0", Offset = "0x90DACE0", VA = "0x1890DBEE0")]
		public static IDisposable SUEGDEFXCKH(this Mesh a, [Out] List<Matrix4x4> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x90DBA50", Offset = "0x90DA850", VA = "0x1890DBA50")]
		public static int RZLAOJQYRGW(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x90DB6D0", Offset = "0x90DA4D0", VA = "0x1890DB6D0")]
		public static int CHGCZYOZRUS(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x90DBC90", Offset = "0x90DAA90", VA = "0x1890DBC90")]
		public static int SSLXULDLIEN(this Mesh a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x90DBA20", Offset = "0x90DA820", VA = "0x1890DBA20")]
		public static int OPFSYUGOMHF(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x90DBA40", Offset = "0x90DA840", VA = "0x1890DBA40")]
		public static int ROKZTPMRUTI(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x90DBA30", Offset = "0x90DA830", VA = "0x1890DBA30")]
		public static int QASCQDQKZVH(this Mesh a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class MJHXFHLJHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5474DC0", Offset = "0x5473BC0", VA = "0x185474DC0")]
		public static bool YZHHATHCYBD(this MonoBehaviour a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x90D0C40", Offset = "0x90CFA40", VA = "0x1890D0C40")]
		public static void AHLCLXJVDUQ(this MonoBehaviour a, Coroutine b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x90D0E90", Offset = "0x90CFC90", VA = "0x1890D0E90")]
		public static void YRYSMFCOOWL(this MonoBehaviour a, IDisposable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x90D0DC0", Offset = "0x90CFBC0", VA = "0x1890D0DC0")]
		public static Coroutine WLFTASELEFM(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x90D0D00", Offset = "0x90CFB00", VA = "0x1890D0D00")]
		public static Coroutine VOHREZGIVGO(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x90D0CC0", Offset = "0x90CFAC0", VA = "0x1890D0CC0")]
		public static bool UPYMGIGCIUH(this MonoBehaviour a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class LAKMSRFPNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x39EDCB0", Offset = "0x39ECAB0", VA = "0x1839EDCB0")]
		public static bool NXZJIEEDLSS<a>(this a a) where a : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x39ED9C0", Offset = "0x39EC7C0", VA = "0x1839ED9C0")]
		public static bool AURCHPLFRYG<b>(this b a) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x90CE800", Offset = "0x90CD600", VA = "0x1890CE800")]
		public static string KFXDEHJKFYZ(this UnityEngine.Object a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class VAEGNNOHRVR
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class TMCMCQXYUYY<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<Collider, float, a> NLXUTBYXTJF;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public TMCMCQXYUYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6227120", Offset = "0x6225F20", VA = "0x186227120")]
			internal bool JTFVUKGFSSF(RaycastHit a, float b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class TUENBCSOENL<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Func<Collider, a> NLXUTBYXTJF;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public TUENBCSOENL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6236620", Offset = "0x6235420", VA = "0x186236620")]
			internal bool YNKTPKGWBZO(RaycastHit a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly Collider[] IPZONFQHFNW;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly RaycastHit[] BLGABPJXOZB;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly RaycastHit[] JCTDVDXAFIG;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x90D9280", Offset = "0x90D8080", VA = "0x1890D9280")]
		[CleanupBetweenRooms]
		internal static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D270", Offset = "0x3E6C070", VA = "0x183E6D270")]
		public static a BUWXULUPPYY<a>(Vector3 a, Vector3 b, float c, int d, QueryTriggerInteraction e, [Out] Vector3 f, [Out] Collider g, Func<Collider, a> h)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x90D9880", Offset = "0x90D8680", VA = "0x1890D9880")]
		public static bool JXJTTPDTWEL(Ray a, float b, [Out] RaycastHit c, Func<RaycastHit, bool> d, int e, QueryTriggerInteraction f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3E6DE20", Offset = "0x3E6CC20", VA = "0x183E6DE20")]
		public static b JQLSVOIRRXN<b>(Vector3 a, float b, Vector3 c, int d, float e, [Out] Vector3 f, [Out] Collider g, Func<Collider, float, b> h, QueryTriggerInteraction i)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x90D9C50", Offset = "0x90D8A50", VA = "0x1890D9C50")]
		public static Vector3 MZPJBARGAGK([In] RaycastHit hit, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x90D8E10", Offset = "0x90D7C10", VA = "0x1890D8E10")]
		public static Vector3 CNLIJZFCEQO([In] RaycastHit hit, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x90D9050", Offset = "0x90D7E50", VA = "0x1890D9050")]
		public static Vector3 CNLIJZFCEQO(this Collider a, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x90D88E0", Offset = "0x90D76E0", VA = "0x1890D88E0")]
		private static float AGVXGWMKKHL(Vector3 a, RaycastHit b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x90D8A30", Offset = "0x90D7830", VA = "0x1890D8A30")]
		public static bool AKUWLAOJJKO(Ray a, float b, float c, [Out] RaycastHit d, Func<RaycastHit, float, bool> e, int f, QueryTriggerInteraction g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x90D9190", Offset = "0x90D7F90", VA = "0x1890D9190")]
		public static void CXIJPSDEIGV(this RaycastHit[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x90D9D40", Offset = "0x90D8B40", VA = "0x1890D9D40")]
		public static void TGUGSVSBQCK(this Collision a, [Out] Vector3 b, [Out] Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x90D9C10", Offset = "0x90D8A10", VA = "0x1890D9C10")]
		public static PhysicsMaterialCombine MLTFPIBLADO(PhysicsMaterialCombine a, PhysicsMaterialCombine b)
		{
			return default(PhysicsMaterialCombine);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x90D97C0", Offset = "0x90D85C0", VA = "0x1890D97C0")]
		public static float IERJNNLFREH(this PhysicsMaterial a, PhysicsMaterial b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x90D95F0", Offset = "0x90D83F0", VA = "0x1890D95F0")]
		public static float IERJNNLFREH(this PhysicsMaterial a, PhysicsMaterial b, PhysicsMaterialCombine c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x90D9330", Offset = "0x90D8130", VA = "0x1890D9330")]
		private static float EJSVJWJAXTT(float a, float b, PhysicsMaterialCombine c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x90D9AD0", Offset = "0x90D88D0", VA = "0x1890D9AD0")]
		public static float3x3 MDZBEBCCMAX(this Rigidbody a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x90D9370", Offset = "0x90D8170", VA = "0x1890D9370")]
		public static Vector3 HGDGSPFQORW(Vector3 a, float b, ForceMode c, ForceMode d)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class YBGXEFMKTMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0070", Offset = "0x3E9EE70", VA = "0x183EA0070")]
		public static ProfilerMarker.AutoScope OCSHLPKLLFR<a>([Optional][CallerMemberName] string callerName)
		{
			return default(ProfilerMarker.AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		public static ProfilerMarker.AutoScope OCSHLPKLLFR(Type a, [Optional][CallerMemberName] string callerName)
		{
			return default(ProfilerMarker.AutoScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class DONZNCOMWKR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Quaternion FLPTGURBWSM;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x10F2410", Offset = "0x10F1210", VA = "0x1810F2410")]
		public DONZNCOMWKR(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x90C2C10", Offset = "0x90C1A10", VA = "0x1890C2C10")]
		public static implicit operator Quaternion(DONZNCOMWKR q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x90C2C30", Offset = "0x90C1A30", VA = "0x1890C2C30")]
		public static implicit operator DONZNCOMWKR(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class QENGZIZROUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly float PMSKIEINXAD;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly float CPSTZGUYVMU;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x90D5A80", Offset = "0x90D4880", VA = "0x1890D5A80")]
		public static Vector3 RGUTEKAHXSO(this Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x90D5340", Offset = "0x90D4140", VA = "0x1890D5340")]
		public static Quaternion HWAWECZIZLJ(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x90D59D0", Offset = "0x90D47D0", VA = "0x1890D59D0")]
		public static Quaternion NFLJZMBRVWS(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x90D5020", Offset = "0x90D3E20", VA = "0x1890D5020")]
		public static Quaternion FGGHRJHWKNC(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x90D4E40", Offset = "0x90D3C40", VA = "0x1890D4E40")]
		public static bool AIFQAZUSMGA(this Quaternion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x90D5D00", Offset = "0x90D4B00", VA = "0x1890D5D00")]
		public static bool WRCVTKAVDVV(this Quaternion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x90D55F0", Offset = "0x90D43F0", VA = "0x1890D55F0")]
		public static Quaternion JPLNDMTEGOF(this Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x90D5860", Offset = "0x90D4660", VA = "0x1890D5860")]
		public static Quaternion MTFZOAPAYFJ(this Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x90D5C30", Offset = "0x90D4A30", VA = "0x1890D5C30")]
		public static Quaternion RPKYNXGNLAQ(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x90D4E80", Offset = "0x90D3C80", VA = "0x1890D4E80")]
		public static Quaternion DETINDMKMPG(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x90D5370", Offset = "0x90D4170", VA = "0x1890D5370")]
		public static Quaternion JHZSCNQJEII(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x90D5170", Offset = "0x90D3F70", VA = "0x1890D5170")]
		public static Vector3 FJIHHLZGETD(Quaternion a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x90D5400", Offset = "0x90D4200", VA = "0x1890D5400")]
		public static Quaternion JPDLQTYIEDF(Quaternion a, Quaternion b, Vector3 c, float d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7A068A0", Offset = "0x7A056A0", VA = "0x187A068A0")]
		public static bool JIVKFRBCCVW(this Quaternion a, Quaternion b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90D5780", Offset = "0x90D4580", VA = "0x1890D5780")]
		public static bool KYAQPAHVINM(this Quaternion a, Quaternion b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x90D5D40", Offset = "0x90D4B40", VA = "0x1890D5D40")]
		public static Quaternion ZEIMBEGRPHR(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class VBBMODLGUWE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x90DA0A0", Offset = "0x90D8EA0", VA = "0x1890DA0A0")]
		public static Rect HHUIBEJLEPK(this Rect a, Vector2 b)
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x90DA080", Offset = "0x90D8E80", VA = "0x1890DA080")]
		public static Vector2 GGKXZHWCNWZ(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x90DA120", Offset = "0x90D8F20", VA = "0x1890DA120")]
		public static Vector2 VAWZHUSKAKY(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x90DA060", Offset = "0x90D8E60", VA = "0x1890DA060")]
		public static Vector2 DCCHTPSDRJA(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x90DA100", Offset = "0x90D8F00", VA = "0x1890DA100")]
		public static Vector2 PUNPJAXADOF(this Rect a)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class IXCAHWWBSAL
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int TNMTLUTHFKW;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly MaterialPropertyBlock HIUNFDCZXAO;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x90CD010", Offset = "0x90CBE10", VA = "0x1890CD010")]
		public static Mesh RXRRUEQFOTK(this Renderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x90CD1A0", Offset = "0x90CBFA0", VA = "0x1890CD1A0")]
		public static Mesh RXRRUEQFOTK(this SkinnedMeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x90CD1C0", Offset = "0x90CBFC0", VA = "0x1890CD1C0")]
		public static Mesh RXRRUEQFOTK(this MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x90CCDE0", Offset = "0x90CBBE0", VA = "0x1890CCDE0")]
		public static int BMOPWGHLPGX(this Renderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x90CD240", Offset = "0x90CC040", VA = "0x1890CD240")]
		public static void TRSELGCQKTL(this Renderer a, int b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x90CD310", Offset = "0x90CC110", VA = "0x1890CD310")]
		public static void TRSELGCQKTL(this Renderer a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x90CD3D0", Offset = "0x90CC1D0", VA = "0x1890CD3D0")]
		public static void TRSELGCQKTL(this Renderer a, int b, Vector4 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x90CD4A0", Offset = "0x90CC2A0", VA = "0x1890CD4A0")]
		public static void TRSELGCQKTL(this Renderer a, int b, Texture2D c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x90CCFF0", Offset = "0x90CBDF0", VA = "0x1890CCFF0")]
		public static void DPYSIAIGOLG(this Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x90CD560", Offset = "0x90CC360", VA = "0x1890CD560")]
		public static void XZDPULHINAQ(this Renderer a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x90CD730", Offset = "0x90CC530", VA = "0x1890CD730")]
		public static void XZDPULHINAQ(this Renderer a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class QYNPJOSYTJG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x90D60C0", Offset = "0x90D4EC0", VA = "0x1890D60C0")]
		public static void HSOOTBXZNEN(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x90D6000", Offset = "0x90D4E00", VA = "0x1890D6000")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x90D5F40", Offset = "0x90D4D40", VA = "0x1890D5F40")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class ZGRXJVBLEEU
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool BOMKFQWFYAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x90DD6A0", Offset = "0x90DC4A0", VA = "0x1890DD6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static bool CTIDCGCIINA
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x90DD560", Offset = "0x90DC360", VA = "0x1890DD560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static bool HTYUMUJLFSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x90DD600", Offset = "0x90DC400", VA = "0x1890DD600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x90DD5B0", Offset = "0x90DC3B0", VA = "0x1890DD5B0")]
		private static float LWPGLBWJAMX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x90DD4C0", Offset = "0x90DC2C0", VA = "0x1890DD4C0")]
		private static float BSMVOPWFNVF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x90DD790", Offset = "0x90DC590", VA = "0x1890DD790")]
		private static float VOZZCOXPPFW()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class WERPVJTZMYR
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct <>c__DisplayClass18_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public string self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public bool noCharLimit;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int charsPerSubstring;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public bool noLineLimit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int lineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int maxLinesPerSubstring;
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly Regex NBJIQQFUXGC;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static readonly Regex BZYUQQPJRPR;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x90DB160", Offset = "0x90D9F60", VA = "0x1890DB160")]
		public static string TRUAUZZFLLG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x90DB090", Offset = "0x90D9E90", VA = "0x1890DB090")]
		public static string ROJPPVFFVJV(string a, char b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x90DA9D0", Offset = "0x90D97D0", VA = "0x1890DA9D0")]
		public static bool DZSTBFGRPTA(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x90DA940", Offset = "0x90D9740", VA = "0x1890DA940")]
		public static bool CPUDMEIXFVL(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x90DAC10", Offset = "0x90D9A10", VA = "0x1890DAC10")]
		public static bool FUYAXAYIJMI(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x90DACF0", Offset = "0x90D9AF0", VA = "0x1890DACF0")]
		public static bool JNVAXYURFPA(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x90DAFC0", Offset = "0x90D9DC0", VA = "0x1890DAFC0")]
		public static bool QALZSVYJPNK(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x90DAF30", Offset = "0x90D9D30", VA = "0x1890DAF30")]
		public static bool QALZSVYJPNK(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x90DAEE0", Offset = "0x90D9CE0", VA = "0x1890DAEE0")]
		public static bool NRPIDQMKWWK(this string a, string b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x90DACC0", Offset = "0x90D9AC0", VA = "0x1890DACC0")]
		public static bool IIHYTKCCREN(this string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x90DAB50", Offset = "0x90D9950", VA = "0x1890DAB50")]
		public static bool EJOAACILJHP(this string a, string[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x90DB030", Offset = "0x90D9E30", VA = "0x1890DB030")]
		public static bool QHEWKVFCHMY(string a, string b, StringComparison c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x90DA230", Offset = "0x90D9030", VA = "0x1890DA230")]
		public static string AQKNJWMSPII(this string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x90DB480", Offset = "0x90DA280", VA = "0x1890DB480")]
		public static string YMGAFCDJDDP(this string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x90DB350", Offset = "0x90DA150", VA = "0x1890DB350")]
		public static string UALBSFNGGWW(this string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x90DA2B0", Offset = "0x90D90B0", VA = "0x1890DA2B0")]
		public static List<string> CILGHMAVZTF(this string a, int b, int c = 2147483647)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x90DAD80", Offset = "0x90D9B80", VA = "0x1890DAD80")]
		public static string MDEYXWINDYS(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x90DAD00", Offset = "0x90D9B00", VA = "0x1890DAD00")]
		public static string LFSUYWRMVOV(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x90DAA40", Offset = "0x90D9840", VA = "0x1890DAA40")]
		public static bool EHDUPEETZZK(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1184CD0", Offset = "0x1183AD0", VA = "0x181184CD0")]
		public static string JKFTLMZGLJT(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x90DAF10", Offset = "0x90D9D10", VA = "0x1890DAF10")]
		public static string OJGWTXXAQNP(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x90DA290", Offset = "0x90D9090", VA = "0x1890DA290")]
		public static int CDCXJHSMSQY(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x90DB110", Offset = "0x90D9F10", VA = "0x1890DB110")]
		[CompilerGenerated]
		internal static bool RQGFTHYZVBC(int a, <>c__DisplayClass18_0 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class OCBNAQZPPJH
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Color[] BAENWNTWBCS;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x90DB610", Offset = "0x90DA410", VA = "0x1890DB610")]
			internal void VNSWYJDZJXD(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x90D3C90", Offset = "0x90D2A90", VA = "0x1890D3C90")]
		public static void DJTIPPTHMZR(this Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x90D3DD0", Offset = "0x90D2BD0", VA = "0x1890D3DD0")]
		public static void PDALYUCNCHA(this RenderTexture a, Texture2D b, bool c = false, bool d = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class EXFOKUWLILK
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public delegate string ExceptionMessageBuilder();

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public delegate TEx ExceptionBuilder<out TEx>(TimeSpan timeoutSpan);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x37FE920", Offset = "0x37FD720", VA = "0x1837FE920")]
		public static TaskCompletionSource<a> UPBARXQOHMM<a>(this TaskCompletionSource<a> a, TimeSpan b, [Optional] ExceptionMessageBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x37FCCE0", Offset = "0x37FBAE0", VA = "0x1837FCCE0")]
		public static TaskCompletionSource<b> UPBARXQOHMM<b, c>(this TaskCompletionSource<b> a, TimeSpan b, ExceptionBuilder<c> c) where c : TcsTimeoutException
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x90C2C90", Offset = "0x90C1A90", VA = "0x1890C2C90")]
		private static void EHOYIZFJSHC(TimeSpan a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class TcsTimeoutException : TimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly TimeSpan Timeout;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x90D7250", Offset = "0x90D6050", VA = "0x1890D7250")]
		private static FormattableString IVQCDUEFBYF(TimeSpan a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x90D7150", Offset = "0x90D5F50", VA = "0x1890D7150")]
		private static string FPYIQIINAAU(TimeSpan a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x90D7770", Offset = "0x90D6570", VA = "0x1890D7770")]
		public TcsTimeoutException(TimeSpan timeout, string message, bool prependTime = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class NVEFTADWWMA
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly Vector3[] EJKQAWCRJGL;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x90D2900", Offset = "0x90D1700", VA = "0x1890D2900")]
		public static Vector3 QBDOHDHUSZN(this Transform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x90D2C30", Offset = "0x90D1A30", VA = "0x1890D2C30")]
		public static Vector3 VPVVARSZMXI(this Transform a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x90D2D50", Offset = "0x90D1B50", VA = "0x1890D2D50")]
		public static Vector3 VPVVARSZMXI(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x90D2490", Offset = "0x90D1290", VA = "0x1890D2490")]
		public static Vector3 GYIKGSCYELK(this RectTransform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x90D30B0", Offset = "0x90D1EB0", VA = "0x1890D30B0")]
		public static Vector2 XJJGHPHKHEX(this RectTransform a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x90D3170", Offset = "0x90D1F70", VA = "0x1890D3170")]
		public static float YSQLQCNCEYX(this RectTransform a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x90D2560", Offset = "0x90D1360", VA = "0x1890D2560")]
		public static Vector3 IVNDFRELKFG(this RectTransform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x90D2410", Offset = "0x90D1210", VA = "0x1890D2410")]
		public static Vector3[] FHPZQBVVJXB(this RectTransform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x90D2AF0", Offset = "0x90D18F0", VA = "0x1890D2AF0")]
		public static Transform QNNGUIODCTQ(this Transform a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x90D2650", Offset = "0x90D1450", VA = "0x1890D2650")]
		public static bool MGSTXVDYFSV(this Transform a, Transform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x90D2390", Offset = "0x90D1190", VA = "0x1890D2390")]
		public static int EVYJWLYTBSI(this Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x90D2700", Offset = "0x90D1500", VA = "0x1890D2700")]
		public static void NJYENALTGSN(this RectTransform a, Vector3[] b, [Optional] Canvas c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class TAEYWVXMDGT
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Vector2 CKWWHEMRGHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x90D70A0", Offset = "0x90D5EA0", VA = "0x1890D70A0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static float MBOOQWZPTSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x90D7110", Offset = "0x90D5F10", VA = "0x1890D7110")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Quaternion QQFZRKBAJSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x90D70C0", Offset = "0x90D5EC0", VA = "0x1890D70C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static Vector3 QROGFTKFPCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x90D7070", Offset = "0x90D5E70", VA = "0x1890D7070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static Vector3 AQFZJHYYXMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x90D7120", Offset = "0x90D5F20", VA = "0x1890D7120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x90D70F0", Offset = "0x90D5EF0", VA = "0x1890D70F0")]
		public static float Range(float minInclusive, float maxInclusive)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x90D7100", Offset = "0x90D5F00", VA = "0x1890D7100")]
		public static int Range(int minInclusive, int maxExclusive)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x90D70B0", Offset = "0x90D5EB0", VA = "0x1890D70B0")]
		public static void GEBUHCBLYQK(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class SYVXXNGRAFE
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly Vector2 RVCVDNKYDWS;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly Vector2 YZEMEVRPPWA;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly Vector2 ZJGCCJHAEGZ;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x10BF3B0", Offset = "0x10BE1B0", VA = "0x1810BF3B0")]
		public static Vector2 DNVRHUPOEHV(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x90D69D0", Offset = "0x90D57D0", VA = "0x1890D69D0")]
		public static Vector2 CZEEWVVQTZO(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x90D6EB0", Offset = "0x90D5CB0", VA = "0x1890D6EB0")]
		public static Vector2 NGPFXZWUJKJ(this Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x90D6FD0", Offset = "0x90D5DD0", VA = "0x1890D6FD0")]
		public static bool WVQLRJDWVHL(this Vector2 a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x90D6C70", Offset = "0x90D5A70", VA = "0x1890D6C70")]
		public static float MVRBVINVEZX(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x90D6FA0", Offset = "0x90D5DA0", VA = "0x1890D6FA0")]
		public static bool TICRWOTVFMZ(this Vector2 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x90D6B50", Offset = "0x90D5950", VA = "0x1890D6B50")]
		public static Vector2 DENDOLHQTOH(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x90D6B30", Offset = "0x90D5930", VA = "0x1890D6B30")]
		public static Vector2 DEHWRENTKCY(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x90D6BD0", Offset = "0x90D59D0", VA = "0x1890D6BD0")]
		public static Vector2 KQZUBDACECW(this Vector2 a, float b, float c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x90D6B70", Offset = "0x90D5970", VA = "0x1890D6B70")]
		public static Vector2 KQZUBDACECW(this Vector2 a, float b, float c, float d, float e)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class FVZHZFCPWVS
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum Axis
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Up = 1,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			Down = -1,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Right = 2,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Left = -2,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Forward = 3,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Back = -3
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly float YLMCJRSWQUX;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x90C36B0", Offset = "0x90C24B0", VA = "0x1890C36B0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C720", Offset = "0x1E2B520", VA = "0x181E2C720")]
		public static float PVYXIIWWOSE(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x90C3FC0", Offset = "0x90C2DC0", VA = "0x1890C3FC0")]
		public static Vector3 FBBMDKHTONJ(this Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x90C3F30", Offset = "0x90C2D30", VA = "0x1890C3F30")]
		public static Vector3 FBBMDKHTONJ(this Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x90C3E80", Offset = "0x90C2C80", VA = "0x1890C3E80")]
		public static Vector3 FBBMDKHTONJ(this Vector3 a, Vector3 b, Quaternion c, Vector3 d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x90C4610", Offset = "0x90C3410", VA = "0x1890C4610")]
		public static Vector3 IVDENZWGQRP(this Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x90C49A0", Offset = "0x90C37A0", VA = "0x1890C49A0")]
		public static void LZHZSAZBAPP(Vector3 a, Quaternion b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x90C48D0", Offset = "0x90C36D0", VA = "0x1890C48D0")]
		public static void LZHZSAZBAPP(Vector3 a, Quaternion b, Vector3 c, float d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x90C4F30", Offset = "0x90C3D30", VA = "0x1890C4F30")]
		public static bool QQBSRUKNLEZ(this Vector3 a, float b = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x90C44B0", Offset = "0x90C32B0", VA = "0x1890C44B0")]
		public static bool HBSZQYSYSNN(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x90C5920", Offset = "0x90C4720", VA = "0x1890C5920")]
		public static bool XNFPDYAKMGP(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x84B56C0", Offset = "0x84B44C0", VA = "0x1884B56C0")]
		public static float PMGBQCJPJZE(this Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x90C54F0", Offset = "0x90C42F0", VA = "0x1890C54F0")]
		public static float TTPMLKADODO(this Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x90C5480", Offset = "0x90C4280", VA = "0x1890C5480")]
		public static Vector3 STLCIXZRXVT(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x90C3970", Offset = "0x90C2770", VA = "0x1890C3970")]
		public static Vector3 CNNXJSCBBGU(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x90C3A10", Offset = "0x90C2810", VA = "0x1890C3A10")]
		public static Vector3 CZEEWVVQTZO(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x90C54C0", Offset = "0x90C42C0", VA = "0x1890C54C0")]
		public static bool TICRWOTVFMZ(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x90C34B0", Offset = "0x90C22B0", VA = "0x1890C34B0")]
		public static bool AIFQAZUSMGA(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x90C5770", Offset = "0x90C4570", VA = "0x1890C5770")]
		public static bool WRCVTKAVDVV(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x90C57A0", Offset = "0x90C45A0", VA = "0x1890C57A0")]
		public static Vector3 XGOVIRNKCRB(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x90C3C70", Offset = "0x90C2A70", VA = "0x1890C3C70")]
		public static Vector3 DJSABEKQPDQ(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x90C4BD0", Offset = "0x90C39D0", VA = "0x1890C4BD0")]
		public static float MVLUYBTXVOO(this Vector3 a, Vector3 b, [Optional] Vector3? c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x90C3690", Offset = "0x90C2490", VA = "0x1890C3690")]
		public static Vector3 AOYGTVLDSTC(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A62EC0", Offset = "0x2A61CC0", VA = "0x182A62EC0")]
		public static float VOJKREMLVNR(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x90C4DD0", Offset = "0x90C3BD0", VA = "0x1890C4DD0")]
		public static float OFDAWIFPKPO(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x90C5980", Offset = "0x90C4780", VA = "0x1890C5980")]
		public static Vector3 YDIAEVCTVOJ(Vector3 a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x90C40B0", Offset = "0x90C2EB0", VA = "0x1890C40B0")]
		public static Axis FTQJDDDEXOO(Transform a, Vector3 b, [Out] Vector3 c)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x90C4DC0", Offset = "0x90C3BC0", VA = "0x1890C4DC0")]
		public static Vector3 MXRTPCDVEZX(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x90C4DB0", Offset = "0x90C3BB0", VA = "0x1890C4DB0")]
		public static Vector3 MXMMRVJXVOO(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x90C4DA0", Offset = "0x90C3BA0", VA = "0x1890C4DA0")]
		public static Vector3 MXHFUOQAMDF(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x90C5960", Offset = "0x90C4760", VA = "0x1890C5960")]
		public static Vector3 YASSWQUQWBM(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x90C3C30", Offset = "0x90C2A30", VA = "0x1890C3C30")]
		public static Vector3 DENDOLHQTOH(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x90C3C10", Offset = "0x90C2A10", VA = "0x1890C3C10")]
		public static Vector3 DEHWRENTKCY(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x90C3C50", Offset = "0x90C2A50", VA = "0x1890C3C50")]
		public static Vector3 DEXRIYVLMKZ(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x90C3570", Offset = "0x90C2370", VA = "0x1890C3570")]
		public static Vector3 ANKCMTTGQXY(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x90C3600", Offset = "0x90C2400", VA = "0x1890C3600")]
		public static Vector3 ANPJKANEAJH(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x90C34E0", Offset = "0x90C22E0", VA = "0x1890C34E0")]
		public static Vector3 AMZOSGFLYBG(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x90C53F0", Offset = "0x90C41F0", VA = "0x1890C53F0")]
		public static Vector3 RMRRRZAFBVL(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x90C5360", Offset = "0x90C4160", VA = "0x1890C5360")]
		public static Vector3 RMMKUSGHSKC(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x90C52D0", Offset = "0x90C40D0", VA = "0x1890C52D0")]
		public static Vector3 RMHDXLMKIYT(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x90C4840", Offset = "0x90C3640", VA = "0x1890C4840")]
		public static Vector3 JQQDKNBBZEZ(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x90C47B0", Offset = "0x90C35B0", VA = "0x1890C47B0")]
		public static Vector3 JQKWNGHEPTQ(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x90C57E0", Offset = "0x90C45E0", VA = "0x1890C57E0")]
		public static Vector3 XKRATAOIPWI(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x90C5510", Offset = "0x90C4310", VA = "0x1890C5510")]
		public static Vector3 UEMAPPRDJZG(Vector3 a, Vector3 b, Vector3 c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x90C4F80", Offset = "0x90C3D80", VA = "0x1890C4F80")]
		public static float QQVMWHIYUKP(this Vector3 a, Vector3 b, Vector3 c, bool d = false)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x90C46D0", Offset = "0x90C34D0", VA = "0x1890C46D0")]
		public static bool JIVKFRBCCVW(this Vector3 a, Vector3 b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7A06950", Offset = "0x7A05750", VA = "0x187A06950")]
		public static bool ZYXIYVQYRWO(this Vector3 a, Vector3 b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x90C5C00", Offset = "0x90C4A00", VA = "0x1890C5C00")]
		public static byte[] ZEBHRTIUUAI([In] this Vector3 vec)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x90C3CB0", Offset = "0x90C2AB0", VA = "0x1890C3CB0")]
		public static int EAJLWXVKMEL(Vector3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x90C44F0", Offset = "0x90C32F0", VA = "0x1890C44F0")]
		public static Vector3 HKCCMYYENTW(int a)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct ActiveRenderTextureScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly RenderTexture originalActiveRenderTexture;

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x90C20B0", Offset = "0x90C0EB0", VA = "0x1890C20B0")]
		public ActiveRenderTextureScope(RenderTexture newActiveRenderTexture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x90C20A0", Offset = "0x90C0EA0", VA = "0x1890C20A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class MOOINAMWHWT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly Dictionary<int, float> GXLFTTUQHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Dictionary<int, Color> YNGZQLGNRRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly Dictionary<int, Vector4> LEPDBLCPUDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly Dictionary<int, Matrix4x4> GVDIWRZCWTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly Dictionary<int, Texture> NYYIJOAWSED;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static ProfilerMarker SQGMXVWMONG;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SIIKWASRCMR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xAEBAB0", Offset = "0xAEA8B0", VA = "0x180AEBAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAEBA10", Offset = "0xAEA810", VA = "0x180AEBA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x90D2040", Offset = "0x90D0E40", VA = "0x1890D2040")]
		public void SetFloat(int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x90D15E0", Offset = "0x90D03E0", VA = "0x1890D15E0")]
		public void AZSXHLPELPY(int a, Vector4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x90D1F40", Offset = "0x90D0D40", VA = "0x1890D1F40")]
		public void LBTRLNRJYTW(int a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x90D1720", Offset = "0x90D0520", VA = "0x1890D1720")]
		public void DYILPOBNZTH(Material a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x90D2160", Offset = "0x90D0F60", VA = "0x1890D2160")]
		public MOOINAMWHWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class KBSOPIQKNKZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static NLGYHJPYMPG<List<int>> OWHYHGCYEON
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x90CE290", Offset = "0x90CD090", VA = "0x1890CE290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static NLGYHJPYMPG<List<Vector2>> LWBLVIWKDET
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x90CE2E0", Offset = "0x90CD0E0", VA = "0x1890CE2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static NLGYHJPYMPG<List<Vector3>> JWUDXZWOXOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x90CE330", Offset = "0x90CD130", VA = "0x1890CE330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static NLGYHJPYMPG<List<Vector4>> WQOGUMKMJHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x90CE380", Offset = "0x90CD180", VA = "0x1890CE380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static NLGYHJPYMPG<List<BoneWeight>> AGLTEZDBCPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x90CE3D0", Offset = "0x90CD1D0", VA = "0x1890CE3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static NLGYHJPYMPG<List<Matrix4x4>> OZTFBAWJDLR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x90CE240", Offset = "0x90CD040", VA = "0x1890CE240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x90CDF90", Offset = "0x90CCD90", VA = "0x1890CDF90")]
		public static void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class IRHQJWJYXVZ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x90CCD90", Offset = "0x90CBB90", VA = "0x1890CCD90")]
		public static long ZIVJDSNDCLY(Vector2 a, Vector2 b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x90CCCC0", Offset = "0x90CBAC0", VA = "0x1890CCCC0")]
		public static long JDRDSCUHYGD(float a, float b, float c, float d)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x90CC840", Offset = "0x90CB640", VA = "0x1890CC840")]
		public static float IFBCIFRFZLM(Matrix4x4 a, Vector2 b, float c, float d = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x90CCCF0", Offset = "0x90CBAF0", VA = "0x1890CCCF0")]
		private static float YESHYWHIGBZ(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x90CA150", Offset = "0x90C8F50", VA = "0x1890CA150")]
		public static void COSFADKSGIT(List<Vector3> a, Matrix4x4 b, Vector3 c, Vector2 d, float e, [Out] bool f, float g = 0f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class DJNSLNBATAS
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x90C28E0", Offset = "0x90C16E0", VA = "0x1890C28E0")]
		public static int WVNKJJODFRK(LODGroup a, LOD[] b, Camera c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x90C2A20", Offset = "0x90C1820", VA = "0x1890C2A20")]
		private static float YWTHDDUSSMW(LODGroup a, Camera b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x90C2860", Offset = "0x90C1660", VA = "0x1890C2860")]
		private static float DZGXNGUXRIG(LODGroup a, Transform b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x90C2950", Offset = "0x90C1750", VA = "0x1890C2950")]
		private static float YBBWDNDRFNQ(Camera a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x90C29D0", Offset = "0x90C17D0", VA = "0x1890C29D0")]
		private static float YCNCYIFKYNZ(Transform a)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Rendering.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class SNLETQPXTVL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x90D6180", Offset = "0x90D4F80", VA = "0x1890D6180")]
		public static Texture2DArray JLTIZYEQUHY(string a, IReadOnlyList<Texture2D> b, Vector2? c, TextureFormat d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x90D6710", Offset = "0x90D5510", VA = "0x1890D6710")]
		private static void QTDGUXXWZWN(Texture2D a, Texture2DArray b, int c)
		{
		}
	}
}
namespace RecRoom.MathUtils
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class XAGPOSMITFM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a MBOOQWZPTSE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xD97BD0", Offset = "0xD969D0", VA = "0x180D97BD0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public a HAAZRAGVUFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xEBF250", Offset = "0xEBE050", VA = "0x180EBF250")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract a YBBSZVUYXSY
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
		public void WUICNFONICU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x406E050", Offset = "0x406CE50", VA = "0x18406E050")]
		public void RHQNQBYJAIT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
		public void APHDVYOAPNW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x406DAF0", Offset = "0x406C8F0", VA = "0x18406DAF0")]
		public a Apply(float moveTime, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x406DCC0", Offset = "0x406CAC0", VA = "0x18406DCC0")]
		public a Apply(float moveTime, float maxSpeed, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool UTOSENYKAOI(a a);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract a OUZFKRJNTZK(float a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected XAGPOSMITFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class JLBHYPNZPWG : XAGPOSMITFM<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override float YBBSZVUYXSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x90DE8A0", Offset = "0x90DD6A0", VA = "0x1890DE8A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x90DE860", Offset = "0x90DD660", VA = "0x1890DE860", Slot = "5")]
		public override bool UTOSENYKAOI(float a = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x90DE700", Offset = "0x90DD500", VA = "0x1890DE700", Slot = "6")]
		protected override float OUZFKRJNTZK(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x90DE940", Offset = "0x90DD740", VA = "0x1890DE940")]
		public JLBHYPNZPWG()
		{
		}
	}
}
namespace RecRoom.MathUtils.Springs
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class LEQADCCAOMP : WLBJHQQMWZE<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override float YBBSZVUYXSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x90DEAC0", Offset = "0x90DD8C0", VA = "0x1890DEAC0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override float BEMDSWXOGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x90DE9D0", Offset = "0x90DD7D0", VA = "0x1890DE9D0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x90DEA20", Offset = "0x90DD820", VA = "0x1890DEA20", Slot = "6")]
		public override bool UTOSENYKAOI(float a = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x90DE980", Offset = "0x90DD780", VA = "0x1890DE980", Slot = "7")]
		protected override float FDFJFEGCNXG(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x90DEB10", Offset = "0x90DD910", VA = "0x1890DEB10")]
		public LEQADCCAOMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class RQYLYRMHYXI : WLBJHQQMWZE<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override float YBBSZVUYXSY
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x90DEC50", Offset = "0x90DDA50", VA = "0x1890DEC50", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override float BEMDSWXOGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x90DEBA0", Offset = "0x90DD9A0", VA = "0x1890DEBA0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x90DEBD0", Offset = "0x90DD9D0", VA = "0x1890DEBD0", Slot = "6")]
		public override bool UTOSENYKAOI(float a = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x90DEB50", Offset = "0x90DD950", VA = "0x1890DEB50", Slot = "7")]
		protected override float FDFJFEGCNXG(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x90DECF0", Offset = "0x90DDAF0", VA = "0x1890DECF0")]
		public RQYLYRMHYXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class GWJDOTWEMSF : WLBJHQQMWZE<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Vector2 YBBSZVUYXSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x90DE660", Offset = "0x90DD460", VA = "0x1890DE660", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override Vector2 BEMDSWXOGIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x90DE520", Offset = "0x90DD320", VA = "0x1890DE520", Slot = "5")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x90DE580", Offset = "0x90DD380", VA = "0x1890DE580", Slot = "6")]
		public override bool UTOSENYKAOI(Vector2 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x90DE4D0", Offset = "0x90DD2D0", VA = "0x1890DE4D0", Slot = "7")]
		protected override Vector2 FDFJFEGCNXG(Vector2 a, Vector2 b, Vector2 c, float d, float e, float f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x90DE6C0", Offset = "0x90DD4C0", VA = "0x1890DE6C0")]
		public GWJDOTWEMSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ACELGKAVMYY : WLBJHQQMWZE<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override Vector3 YBBSZVUYXSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x90DDBB0", Offset = "0x90DC9B0", VA = "0x1890DDBB0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override Vector3 BEMDSWXOGIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x90DDA00", Offset = "0x90DC800", VA = "0x1890DDA00", Slot = "5")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x90DDA80", Offset = "0x90DC880", VA = "0x1890DDA80", Slot = "6")]
		public override bool UTOSENYKAOI(Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x90DD960", Offset = "0x90DC760", VA = "0x1890DD960", Slot = "7")]
		protected override Vector3 FDFJFEGCNXG(Vector3 a, Vector3 b, Vector3 c, float d, float e, float f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x90DDC30", Offset = "0x90DCA30", VA = "0x1890DDC30")]
		public ACELGKAVMYY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public abstract class WLBJHQQMWZE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const float NPRQNTFZJWR = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public a MBOOQWZPTSE
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xD97BD0", Offset = "0xD969D0", VA = "0x180D97BD0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xE284C0", Offset = "0xE272C0", VA = "0x180E284C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public a HAAZRAGVUFA
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xEBF250", Offset = "0xEBE050", VA = "0x180EBF250")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public a CMTDHNSUIMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0xB1A960", Offset = "0xB19760", VA = "0x180B1A960")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEA0", Offset = "0x13E9CA0", VA = "0x1813EAEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public abstract a YBBSZVUYXSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract a BEMDSWXOGIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xEBF2B0", Offset = "0xEBE0B0", VA = "0x180EBF2B0")]
		public void WUICNFONICU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x68F8A80", Offset = "0x68F7880", VA = "0x1868F8A80")]
		public void RHQNQBYJAIT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x68F7EF0", Offset = "0x68F6CF0", VA = "0x1868F7EF0")]
		public void APHDVYOAPNW(a a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x68F8170", Offset = "0x68F6F70", VA = "0x1868F8170")]
		public a Apply(float smoothTime, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x68F80F0", Offset = "0x68F6EF0", VA = "0x1868F80F0")]
		public a Apply(float smoothTime, float maxSpeed, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract bool UTOSENYKAOI(a a);

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract a FDFJFEGCNXG(a a, a b, a c, float d, float e, float f);

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected WLBJHQQMWZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class VJQDRPOWOSD
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public const float NPRQNTFZJWR = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Quaternion MBOOQWZPTSE
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xEC6880", Offset = "0xEC5680", VA = "0x180EC6880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Quaternion HAAZRAGVUFA
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xED04F0", Offset = "0xECF2F0", VA = "0x180ED04F0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xFAD4B0", Offset = "0xFAC2B0", VA = "0x180FAD4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float CMTDHNSUIMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xE8CCC0", Offset = "0xE8BAC0", VA = "0x180E8CCC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x10AC270", Offset = "0x10AB070", VA = "0x1810AC270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xFAD4B0", Offset = "0xFAC2B0", VA = "0x180FAD4B0")]
		public void WUICNFONICU(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x90DFC40", Offset = "0x90DEA40", VA = "0x1890DFC40")]
		public void RHQNQBYJAIT(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x90DF910", Offset = "0x90DE710", VA = "0x1890DF910")]
		public Quaternion Apply(float smoothTime, float deltaTime)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x90DF750", Offset = "0x90DE550", VA = "0x1890DF750")]
		public Quaternion Apply(float smoothTime, float maxSpeed, float deltaTime)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x90DFAD0", Offset = "0x90DE8D0", VA = "0x1890DFAD0")]
		private static Quaternion FDFJFEGCNXG(Quaternion a, Quaternion b, float c, float d, float e, float f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public VJQDRPOWOSD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class SimpleSpringConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float stiffness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float damping;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x90DEDB0", Offset = "0x90DDBB0", VA = "0x1890DEDB0")]
		public SimpleSpringConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class UWIVNKCIJUW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly SimpleSpringConfig SARRDALHDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Vector2 AAJWDTSVLXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Vector2 WBBWNCGQIJG;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public UWIVNKCIJUW(SimpleSpringConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x90DF6B0", Offset = "0x90DE4B0", VA = "0x1890DF6B0")]
		public Vector2 FDFJFEGCNXG(Vector2 a, float b)
		{
			return default(Vector2);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class SimpleSpring6DConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public float spring;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float damping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float maxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public float angularSpring;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float angularDamping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public float maxAngularSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("Add angular acceleration caused by linear acceleration")]
		public Vector3 waggleAxis;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x90DED30", Offset = "0x90DDB30", VA = "0x1890DED30")]
		public SimpleSpring6DConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class URXVPCQTZFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private SimpleSpring6DConfig SARRDALHDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Vector3 WBBWNCGQIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Vector3 EVWWPZVKWMM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 XUQPYIHEIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x19B73E0", Offset = "0x19B61E0", VA = "0x1819B73E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x19B73D0", Offset = "0x19B61D0", VA = "0x1819B73D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 VQBBPYBXSGY
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1CA2A70", Offset = "0x1CA1870", VA = "0x181CA2A70")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1A75870", Offset = "0x1A74670", VA = "0x181A75870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion VLFCSIWRKXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xF782C0", Offset = "0xF770C0", VA = "0x180F782C0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xF782D0", Offset = "0xF770D0", VA = "0x180F782D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion JZOPJQMDSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x108B4B0", Offset = "0x108A2B0", VA = "0x18108B4B0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x108B5F0", Offset = "0x108A3F0", VA = "0x18108B5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float XQZYQWKTWIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x90DEEB0", Offset = "0x90DDCB0", VA = "0x1890DEEB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x90DF610", Offset = "0x90DE410", VA = "0x1890DF610")]
		public URXVPCQTZFI(SimpleSpring6DConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x90DEF20", Offset = "0x90DDD20", VA = "0x1890DEF20")]
		public void Simulate(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
		public void CFQNUEWYVAL(SimpleSpring6DConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x90DEEE0", Offset = "0x90DDCE0", VA = "0x1890DEEE0")]
		public void Simulate()
		{
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class BJAERHEFOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x361BCC0", Offset = "0x361AAC0", VA = "0x18361BCC0")]
		public static void VKFBARTBBEL<a>(NativeArray<a> a, int b, Allocator c) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x361BF50", Offset = "0x361AD50", VA = "0x18361BF50")]
		public static e[] WEVGSAKUGVH<e>(NativeArray<e> a, int b) where e : struct
		{
			return null;
		}
	}
}
namespace RecRoom.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class CDQJFLDNWKP
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly int[] KLPXYZWNILE;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x90DDC70", Offset = "0x90DCA70", VA = "0x1890DDC70")]
		public static void EPGMGLMCDRU(this IncrementalHash a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x90DE0B0", Offset = "0x90DCEB0", VA = "0x1890DE0B0")]
		public static void PENOOFRLQFA(this IncrementalHash a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x90DDEC0", Offset = "0x90DCCC0", VA = "0x1890DDEC0")]
		public static void JPKVQVGPMHL(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x90DDCD0", Offset = "0x90DCAD0", VA = "0x1890DDCD0")]
		public static void HWRIQWTEKEQ(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x90DE250", Offset = "0x90DD050", VA = "0x1890DE250")]
		public static void ZHTZDXQKZOX(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x90DE0F0", Offset = "0x90DCEF0", VA = "0x1890DE0F0")]
		public static void YXTYGGYHRWF(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x36D27D0", Offset = "0x36D15D0", VA = "0x1836D27D0")]
		public static void CNVFFARRZBO<a>(this IncrementalHash a, short b) where a : Enum
		{
		}
	}
}
namespace RecRoom.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class TRZDFUIPPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x90DEDD0", Offset = "0x90DDBD0", VA = "0x1890DEDD0")]
		public static void WHBJNYFDVOF(this Exception a, StringBuilder b, int c = 2, int d = 5)
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
