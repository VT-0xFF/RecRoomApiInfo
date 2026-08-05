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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PBNSTOCCDIY
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA5663C0", Offset = "0xA5653C0", VA = "0x18A5663C0")]
	public static int KPZXKNICEEU(this DateTime a)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA566840", Offset = "0xA565840", VA = "0x18A566840")]
	public static int SIPSTJKTEDD(int a, int b, int c)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA566780", Offset = "0xA565780", VA = "0x18A566780")]
	public static bool QLEPBZZIYBP(this DateTime a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA565D80", Offset = "0xA564D80", VA = "0x18A565D80")]
	public static bool EETHOFWCPED(this DateTime a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA565E60", Offset = "0xA564E60", VA = "0x18A565E60")]
	public static string HJAONDUZVAI(DateTime a, bool b = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA565990", Offset = "0xA564990", VA = "0x18A565990")]
	public static string BVDJGAWFCLV(this DateTime a, [Optional] CultureInfo b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA565AD0", Offset = "0xA564AD0", VA = "0x18A565AD0")]
	public static string BVKHZHCTUQB(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA566A60", Offset = "0xA565A60", VA = "0x18A566A60")]
	private static string WSPBVYGZPHZ(int a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA5662A0", Offset = "0xA5652A0", VA = "0x18A5662A0")]
	public static string HMJRTVEJPLM(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA5666B0", Offset = "0xA5656B0", VA = "0x18A5666B0")]
	public static string METUNWFIGXL(this float a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA566930", Offset = "0xA565930", VA = "0x18A566930")]
	public static string VZOHESNZYYK(this int a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA566470", Offset = "0xA565470", VA = "0x18A566470")]
	public static string LONJAPJNYQV(this DateTime a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA566330", Offset = "0xA565330", VA = "0x18A566330")]
	[CompilerGenerated]
	internal static string IKNEOZJIYTX(int a, string b)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class VGJJTBBJELP
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA56BBC0", Offset = "0xA56ABC0", VA = "0x18A56BBC0")]
	public static Rect WAMEYMSAUCS(this RectTransform a, Camera b, [Optional] Vector3[] c)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GADUVAZIQNO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static float NNNGWVHVPSN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA55C710", Offset = "0xA55B710", VA = "0x18A55C710")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static float UMWUMIYFFYP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDB5CF0", Offset = "0xDB4CF0", VA = "0x180DB5CF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static float TMUXLYZBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA55C720", Offset = "0xA55B720", VA = "0x18A55C720")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA55C750", Offset = "0xA55B750", VA = "0x18A55C750")]
	public static float NSAFUWTGLGW(float a)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ZPRPRBMXVLS
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA56F160", Offset = "0xA56E160", VA = "0x18A56F160")]
	public static bool MHBOSJKNDMR(this DateTime a, TimeSpan b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA56FA30", Offset = "0xA56EA30", VA = "0x18A56FA30")]
	public static string YXOHIJKJFOC(this TimeSpan a, string b = "minute", bool c = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA56ED50", Offset = "0xA56DD50", VA = "0x18A56ED50")]
	public static string HQJLKTCXQQQ(this TimeSpan a, string b = "minute", bool c = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA56E3D0", Offset = "0xA56D3D0", VA = "0x18A56E3D0")]
	private static string AILZPGAKUII(string a, double b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xA56F240", Offset = "0xA56E240", VA = "0x18A56F240")]
	public static string TWYOVGMQBLI(this TimeSpan a, bool b = false, bool c = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA56E470", Offset = "0xA56D470", VA = "0x18A56E470")]
	public static string FDRLACBAQAU(this TimeSpan a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA56EAB0", Offset = "0xA56DAB0", VA = "0x18A56EAB0")]
	public static string FPUVDENXOEI(this TimeSpan a, bool b = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA56F1E0", Offset = "0xA56E1E0", VA = "0x18A56F1E0")]
	public static string RCBIZPXVERZ(this TimeSpan a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xA56FEB0", Offset = "0xA56EEB0", VA = "0x18A56FEB0")]
	private static string ZGWELTURONC(string a, int b)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BCZNJIHAAZR
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA554970", Offset = "0xA553970", VA = "0x18A554970")]
	public static string ACKQSXTRZAM(this Type a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x373DFB0", Offset = "0x373CFB0", VA = "0x18373DFB0")]
	public static bool XYEIHAXNQDS<a>(this Type a, [Out] a b, bool c = true) where a : Attribute
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
		[Cpp2IlInjected.Address(RVA = "0xA561390", Offset = "0xA560390", VA = "0x18A561390", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56FF10", Offset = "0xA56EF10", VA = "0x18A56FF10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class DFXWOSYNBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA558670", Offset = "0xA557670", VA = "0x18A558670")]
		public static float UCCMBACAMWP(this AnimationCurve a, float b)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class DYHAIWOOFBP
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BFGCHHTGJIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public int ZSEQBLKHDHY;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BFGCHHTGJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA554B90", Offset = "0xA553B90", VA = "0x18A554B90")]
			internal bool TGAZPBDDWRF(AnimatorControllerParameter a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA55ACE0", Offset = "0xA559CE0", VA = "0x18A55ACE0")]
		public static void VNPUKCIEKPS(this Animator a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA55AC80", Offset = "0xA559C80", VA = "0x18A55AC80")]
		public static void EPMPGDIQWHL(this Animator a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA55AC20", Offset = "0xA559C20", VA = "0x18A55AC20")]
		public static void AXSDTQEPQMX(this Animator a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA55AD60", Offset = "0xA559D60", VA = "0x18A55AD60")]
		public static bool YLFNXKLHADR(this Animator a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MDLCESECZXP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C337C0", Offset = "0x3C327C0", VA = "0x183C337C0")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C338D0", Offset = "0x3C328D0", VA = "0x183C338D0")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class VHQJIXYDTBO
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class TALFOLXVHMJ<a> where a : AsyncOperation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> PLZJFTPUTWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public a DXUVVKYICEN;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public TALFOLXVHMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7BDA820", Offset = "0x7BD9820", VA = "0x187BDA820")]
			internal void WZDVQAKDSUO(AsyncOperation a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x40D6C60", Offset = "0x40D5C60", VA = "0x1840D6C60")]
		public static Task<a> EXDRCWJZDGV<a>(this a a) where a : AsyncOperation
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class OZYNJJJIJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA565410", Offset = "0xA564410", VA = "0x18A565410")]
		public static Bounds ILODSAYYPWG(IList<Bounds> a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA565020", Offset = "0xA564020", VA = "0x18A565020")]
		public static Bounds EEBFWYMPTWO(this GameObject a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA565230", Offset = "0xA564230", VA = "0x18A565230")]
		public static Bounds EEBFWYMPTWO(this GameObject a, [In] List<Renderer> renderers)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NEWZXGPNMTY
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
			public GameObject DCEMLZFKLGR
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xA558510", Offset = "0xA557510", VA = "0x18A558510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA5585B0", Offset = "0xA5575B0", VA = "0x18A5585B0")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA557F70", Offset = "0xA556F70", VA = "0x18A557F70", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA5580C0", Offset = "0xA5570C0", VA = "0x18A5580C0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA558160", Offset = "0xA557160", VA = "0x18A558160", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA558270", Offset = "0xA557270", VA = "0x18A558270", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly List<CacheParameters> EWHDUXJAHXA;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Dictionary<CacheParameters, ICollection> UHJPLKXPPXU;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static int QEVMYFQDXXA;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA561DC0", Offset = "0xA560DC0", VA = "0x18A561DC0")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D44560", Offset = "0x3D43560", VA = "0x183D44560")]
		public static a ADKLUAZKSPX<a>(this GameObject a, bool b = false)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D447F0", Offset = "0x3D437F0", VA = "0x183D447F0")]
		public static b AHLYSZQXNGG<b>(this GameObject a, bool b = true, bool c = false)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3D45CF0", Offset = "0x3D44CF0", VA = "0x183D45CF0")]
		public static c ZKQZYEOIVKR<c>(this GameObject a, bool b = true, bool c = false)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3D44C30", Offset = "0x3D43C30", VA = "0x183D44C30")]
		public static IReadOnlyList<e> DZHGKKZVKGZ<e>(this GameObject a, bool b = true, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3D44A10", Offset = "0x3D43A10", VA = "0x183D44A10")]
		public static IReadOnlyList<f> APFJBZPLTIW<f>(this GameObject a, bool b = true, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D44F70", Offset = "0x3D43F70", VA = "0x183D44F70")]
		private static g PTGESPPOOHS<g>(CacheParameters a, bool b = false)
		{
			return (g)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D45530", Offset = "0x3D44530", VA = "0x183D45530")]
		private static IReadOnlyList<h> SUAXAFPSGVV<h>(CacheParameters a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA561E50", Offset = "0xA560E50", VA = "0x18A561E50")]
		private static void WUWLXYHHLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA5618B0", Offset = "0xA5608B0", VA = "0x18A5618B0")]
		private static void AUWSMWSJYPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D459E0", Offset = "0x3D449E0", VA = "0x183D459E0")]
		private static IReadOnlyList<i> WSSJHLDZZTU<i>(CacheParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D45240", Offset = "0x3D44240", VA = "0x183D45240")]
		private static IReadOnlyList<j> SMAXMVPYTQT<j>(CacheParameters a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class DSVSLNIWKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA558F00", Offset = "0xA557F00", VA = "0x18A558F00")]
		public static float MVAXTCRAALZ(this Camera a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA558C40", Offset = "0xA557C40", VA = "0x18A558C40")]
		public static float JLLESOGONJW(this Camera a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA559060", Offset = "0xA558060", VA = "0x18A559060")]
		public static float THWYZGUAPUA(this Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA558C10", Offset = "0xA557C10", VA = "0x18A558C10")]
		private static float FIVUSDFZPJL(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA558BD0", Offset = "0xA557BD0", VA = "0x18A558BD0")]
		private static float FIVUSDFZPJL(Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5590D0", Offset = "0xA5580D0", VA = "0x18A5590D0")]
		private static float USLZEWDJORY(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA559110", Offset = "0xA558110", VA = "0x18A559110")]
		private static float USLZEWDJORY(Camera a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA5593B0", Offset = "0xA5583B0", VA = "0x18A5593B0")]
		public static float YMWTPFRNBMY(float a, float b, float c = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA5592F0", Offset = "0xA5582F0", VA = "0x18A5592F0")]
		public static float YMWTPFRNBMY(this Camera a, float b, float c = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA559170", Offset = "0xA558170", VA = "0x18A559170")]
		public static float YMWTPFRNBMY(this Camera a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA558CB0", Offset = "0xA557CB0", VA = "0x18A558CB0")]
		public static float KIAXQAFGGWM(float a, float b, Vector2 c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA558930", Offset = "0xA557930", VA = "0x18A558930")]
		public static float CWUQOZTTHJW(this Camera a, Vector2 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA558FD0", Offset = "0xA557FD0", VA = "0x18A558FD0")]
		private static float SWDKUFVRYJT(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA558800", Offset = "0xA557800", VA = "0x18A558800")]
		private static float CKBZPYBIGKN(float a, float b, float c, float d = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA558F50", Offset = "0xA557F50", VA = "0x18A558F50")]
		public static void SIEKEFZVZRR(this Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA558B90", Offset = "0xA557B90", VA = "0x18A558B90")]
		public static bool EPVIWOKNVBQ(this Camera a, Bounds b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA5588B0", Offset = "0xA5578B0", VA = "0x18A5588B0")]
		public static bool CPLIPNARCRS(this Camera a, Vector3 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class FVPYMDZMGBV
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class XCJTOHJAGEC<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public ICollection<a> XAKEAQHIEYK;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XCJTOHJAGEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x510B6B0", Offset = "0x510A6B0", VA = "0x18510B6B0")]
			internal bool BOCGLTUUHES(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADABD0", Offset = "0x3AD9BD0", VA = "0x183ADABD0")]
		public static a CMDLMSDCEUP<a>(this ICollection<a> a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA8E0", Offset = "0x3AD98E0", VA = "0x183ADA8E0")]
		public static bool AKTWAPNUMCM<b>(this ICollection<b> a, IEnumerable<b> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class FLWMACTWMMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static RaycastHit[] SNWZRFRVQCR;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA55BDF0", Offset = "0xA55ADF0", VA = "0x18A55BDF0")]
		public static bool DLAEZKLMRKY(this Collider a, Vector3 b, Vector3 c, float d, Vector3 e, float f, [Out] RaycastHit g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA55C330", Offset = "0xA55B330", VA = "0x18A55C330")]
		public static int YEEVOMAXJTV(this BoxCollider a, int b, QueryTriggerInteraction c, Collider[] d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA55B690", Offset = "0xA55A690", VA = "0x18A55B690")]
		public static bool CAHNOZXSEID(this BoxCollider a, int b, QueryTriggerInteraction c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA55C0B0", Offset = "0xA55B0B0", VA = "0x18A55C0B0")]
		public static int MVCWNNUUMJB(this BoxCollider a, Collider[] b, int c, QueryTriggerInteraction d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA55BC60", Offset = "0xA55AC60", VA = "0x18A55BC60")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA55B8F0", Offset = "0xA55A8F0", VA = "0x18A55B8F0")]
		public static bool CAHNOZXSEID(this CapsuleCollider a, int b, QueryTriggerInteraction c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA55B600", Offset = "0xA55A600", VA = "0x18A55B600")]
		public static Vector3 AFHSXRJWDOT(this BoxCollider a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA55B570", Offset = "0xA55A570", VA = "0x18A55B570")]
		public static Vector3 AFHSXRJWDOT(this SphereCollider a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA55C5B0", Offset = "0xA55B5B0", VA = "0x18A55C5B0")]
		public static Vector3 ZMENYGQURTR(this BoxCollider a)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class EPCLBWAOQVI
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Color KWEUUVTQYIY;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA55B410", Offset = "0xA55A410", VA = "0x18A55B410")]
		public static Color QLEZHGZVUWY(this Color a, float b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA55B2D0", Offset = "0xA55A2D0", VA = "0x18A55B2D0")]
		public static Vector3 IVVVDEXXGDE(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA55B260", Offset = "0xA55A260", VA = "0x18A55B260")]
		public static Color IVVVDEXXGDE(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA55B250", Offset = "0xA55A250", VA = "0x18A55B250")]
		public static Color HLRRDCOCBAI(this Color a, float b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA55B340", Offset = "0xA55A340", VA = "0x18A55B340")]
		public static Color KLCVWGIXUOO(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA55AE90", Offset = "0xA559E90", VA = "0x18A55AE90")]
		public static Color DFEOFRKNGZN(this Color a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E680", Offset = "0x2B0D680", VA = "0x182B0E680")]
		public static float ZXGHIEJQBMU([In] Color start, [In] Color end, [In] Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA55B1C0", Offset = "0xA55A1C0", VA = "0x18A55B1C0")]
		public static float ELZADFGCDFH([In] Color start, [In] Color end, [In] Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA55AE40", Offset = "0xA559E40", VA = "0x18A55AE40")]
		public static float CIWSCHCLGVG([In] Color color)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class WIIKVRGRIEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Dictionary<Type, FieldInfo[]> GHBYVUJSNPM;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x411AFA0", Offset = "0x4119FA0", VA = "0x18411AFA0")]
		public static a CKIPCHHFDXC<a>(this Component a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA56C6D0", Offset = "0xA56B6D0", VA = "0x18A56C6D0")]
		public static void TMAPLLTILWZ(this Component a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA56C410", Offset = "0xA56B410", VA = "0x18A56C410")]
		public static bool QRBGENCDKEF(this Component a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x411B0C0", Offset = "0x411A0C0", VA = "0x18411B0C0")]
		public static List<f> IOJWBAJOFJF<f>(this Component a) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x411B050", Offset = "0x411A050", VA = "0x18411B050")]
		public static g CTDGIPRGBKQ<g>(this Component a, bool b) where g : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class ZTVULNUAFYE
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class TYEZUJMMXQA<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private a PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int LPBUJELINTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private GameObject[] MOYBGRHAKDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private int MOSUJKNDARU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private a[] MPIPBEUVCZV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int MPDIDYAXTOM;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private a AREJNBRCORV
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public TYEZUJMMXQA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1EF0", Offset = "0x7BF0EF0", VA = "0x187BF1EF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1DA0", Offset = "0x7BF0DA0", VA = "0x187BF1DA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CTAZIZCYNRG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1E40", Offset = "0x7BF0E40", VA = "0x187BF1E40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4153A20", Offset = "0x4152A20", VA = "0x184153A20")]
		[IteratorStateMachine(typeof(TYEZUJMMXQA<>))]
		public static IEnumerable<a> FTGRAWFQQAB<a>() where a : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class PMMSEYAMXFT
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MYSPIVFHJOD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Action GGMTSJNJOKG;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
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
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public MYSPIVFHJOD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA561800", Offset = "0xA560800", VA = "0x18A561800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA5617C0", Offset = "0xA5607C0", VA = "0x18A5617C0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class YOXANWLUCDM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float PBOZNTOACRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Action GGMTSJNJOKG;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public YOXANWLUCDM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA56D340", Offset = "0xA56C340", VA = "0x18A56D340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA56D300", Offset = "0xA56C300", VA = "0x18A56D300", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static WaitForEndOfFrame IVIPBAJEUEN;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA566B80", Offset = "0xA565B80", VA = "0x18A566B80")]
		[IteratorStateMachine(typeof(YOXANWLUCDM))]
		public static IEnumerator RYDDKKWRKHJ(float a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA566C00", Offset = "0xA565C00", VA = "0x18A566C00")]
		[IteratorStateMachine(typeof(MYSPIVFHJOD))]
		public static IEnumerator WHVPDHOLUFJ(Action a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class EditorDirtyStateExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly Log WXAUINFXHGJ;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log VNSLGNJYVNI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly Log SXUZNVJUSCV;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class NJNKTNMRBDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class TALFOLXVHMJ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Func<a, string> ULMPXYLNHLK;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public TALFOLXVHMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7BDA620", Offset = "0x7BD9620", VA = "0x187BDA620")]
			internal string IDPLXMFADGQ(int a, a b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class XCJTOHJAGEC<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public string NJQDVZAPOXW;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XCJTOHJAGEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x510B8E0", Offset = "0x510A8E0", VA = "0x18510B8E0")]
			internal string IDPLXMFADGQ(string a, string b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class BVBFJBXHSVA<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private a PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private a SLYCVCLRLCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public a WQSIBILHCCC;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a AREJNBRCORV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x4FFB2A0", Offset = "0x4FFA2A0", VA = "0x184FFB2A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public BVBFJBXHSVA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x4FFB3B0", Offset = "0x4FFA3B0", VA = "0x184FFB3B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x4FFB150", Offset = "0x4FFA150", VA = "0x184FFB150", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CTAZIZCYNRG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4FFB2D0", Offset = "0x4FFA2D0", VA = "0x184FFB2D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3D47F50", Offset = "0x3D46F50", VA = "0x183D47F50")]
		public static string DFNYLZNWDAH<a>(this IEnumerable<a> a, [Optional] Func<a, string> b, string c = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3D47AC0", Offset = "0x3D46AC0", VA = "0x183D47AC0")]
		public static string DFNYLZNWDAH<b>(this IList<b> a, [Optional] Func<int, b, string> b, string c = ", ")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BC40", Offset = "0x3D4AC40", VA = "0x183D4BC40")]
		[IteratorStateMachine(typeof(BVBFJBXHSVA<>))]
		public static IEnumerable<c> GLEXZIYVXDP<c>(c a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class QFRHIYHXGWQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly Regex NLGKKEXVLJC;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F200", Offset = "0x3D4E200", VA = "0x183D4F200")]
		public static IEnumerable<string> XOGAOOZONLC<c>(this IEnumerable<c> a) where c : Enum
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class IZIUGTRAKIN
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
			[Cpp2IlInjected.Address(RVA = "0xA568B60", Offset = "0xA567B60", VA = "0x18A568B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA569000", Offset = "0xA568000", VA = "0x18A569000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA560810", Offset = "0xA55F810", VA = "0x18A560810")]
		public static string OUCMOMMCGMP(this FileInfo a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA560A00", Offset = "0xA55FA00", VA = "0x18A560A00")]
		public static string OUCMOMMCGMP(this FileInfo a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5606F0", Offset = "0xA55F6F0", VA = "0x18A5606F0")]
		[AsyncStateMachine(typeof(<ReadAllBytesAsync>d__2))]
		public static Task<byte[]> LQNJJNYYXFA(string a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class PFHIXAYWCHT
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA566B70", Offset = "0xA565B70", VA = "0x18A566B70")]
		public static bool YGOZSFLXYAC(this float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA566B10", Offset = "0xA565B10", VA = "0x18A566B10")]
		public static float PUWLLRTUYGO(this float a, float b)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class RBNASEDRVDW
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class WBUOCXIUUNQ<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private a PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private GameObject XAKEAQHIEYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public GameObject XQMFOTBVTGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private Transform MOQGHUPPRBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int LPHBGLFFXFD;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private a AREJNBRCORV
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public WBUOCXIUUNQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8762EA0", Offset = "0x8761EA0", VA = "0x188762EA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x65AED30", Offset = "0x65ADD30", VA = "0x1865AED30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CTAZIZCYNRG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8762DE0", Offset = "0x8761DE0", VA = "0x188762DE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class UZQONGDQSPT : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private string PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private GameObject OGBZRGYATAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public GameObject PGWECIIQOYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private Transform MFJKHOSEFXB;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private string QJFOWEFJHUT
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public UZQONGDQSPT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA56BAB0", Offset = "0xA56AAB0", VA = "0x18A56BAB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xA56BA70", Offset = "0xA56AA70", VA = "0x18A56BA70", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA56B9D0", Offset = "0xA56A9D0", VA = "0x18A56B9D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> JXOSTSWOHUY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xA56B9D0", Offset = "0xA56A9D0", VA = "0x18A56B9D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static Dictionary<int, int> OFDVWEQMIFT;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA566D80", Offset = "0xA565D80", VA = "0x18A566D80")]
		public static void ACVLJQMMNTT(Transform a, HideFlags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x15D3970", Offset = "0x15D2970", VA = "0x1815D3970")]
		public static void CHYEBWADRCL(this GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x33A4DD0", Offset = "0x33A3DD0", VA = "0x1833A4DD0")]
		[IteratorStateMachine(typeof(WBUOCXIUUNQ<>))]
		public static IEnumerable<a> SCDAVISOWRH<a>(this GameObject a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E54930", Offset = "0x3E53930", VA = "0x183E54930")]
		public static b TJPWVHZHXEQ<b>(this GameObject a) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E546B0", Offset = "0x3E536B0", VA = "0x183E546B0")]
		public static c CTDGIPRGBKQ<c>(this GameObject a, bool b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E54580", Offset = "0x3E53580", VA = "0x183E54580")]
		public static d AYQXDLOPUJV<d>(this GameObject a) where d : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E54600", Offset = "0x3E53600", VA = "0x183E54600")]
		public static e AYQXDLOPUJV<e>(this Component a) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E54B60", Offset = "0x3E53B60", VA = "0x183E54B60")]
		public static void WJFKMEVEUET<f>(this GameObject a, List<f> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E54AA0", Offset = "0x3E53AA0", VA = "0x183E54AA0")]
		public static void WJFKMEVEUET<g>(this Component a, List<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E54860", Offset = "0x3E53860", VA = "0x183E54860")]
		public static void IWAKTMTFZVJ<h>(this GameObject a, bool b, List<h> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA567240", Offset = "0xA566240", VA = "0x18A567240")]
		public static void YGHLGQHSHTJ(this GameObject a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA567030", Offset = "0xA566030", VA = "0x18A567030")]
		public static string JNMYPJZUGVO(this GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5671C0", Offset = "0xA5661C0", VA = "0x18A5671C0")]
		[IteratorStateMachine(typeof(UZQONGDQSPT))]
		private static IEnumerable<string> VEABOJWKXUU(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA566E50", Offset = "0xA565E50", VA = "0x18A566E50")]
		public static int GVFGTUBABWN(this GameObject a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class PLPFSOBZSYM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7E30", Offset = "0x3DA6E30", VA = "0x183DA7E30")]
		public static bool CHRPCGANKTY<a>(string a, [Out] a b, [Optional] Func<a> c, params JsonConverter[] converters)
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
		[Cpp2IlInjected.Address(RVA = "0x1053820", Offset = "0x1052820", VA = "0x181053820")]
		public Torus(float majorRadius, float minorRadius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA568090", Offset = "0xA567090", VA = "0x18A568090")]
		private bool EDIDKVZKRDF([In] Ray ray, [Out] float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA568890", Offset = "0xA567890", VA = "0x18A568890")]
		public bool EDIDKVZKRDF([In] Ray ray, [Out] Vector3 a, [Out] Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA568730", Offset = "0xA567730", VA = "0x18A568730")]
		public bool EDIDKVZKRDF(Transform a, [In] Ray ray, [Out] Vector3 b, [Out] Vector3 c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA568960", Offset = "0xA567960", VA = "0x18A568960")]
		private Vector3 Normal([In] Vector3 pos)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class GKYBIXMHHAU
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA55C780", Offset = "0xA55B780", VA = "0x18A55C780")]
		public static string UKUDXWBYZUS(this int a, int b = 99)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class UAMBLEOYBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x40A32E0", Offset = "0x40A22E0", VA = "0x1840A32E0")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x40A2D80", Offset = "0x40A1D80", VA = "0x1840A2D80")]
		public static T Random<T>(this IReadOnlyList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x40A3670", Offset = "0x40A2670", VA = "0x1840A3670")]
		public static void YOWRENULTBE<a>(this List<a> a) where a : UnityEngine.Object
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class AWBCBNVVKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5548F0", Offset = "0xA5538F0", VA = "0x18A5548F0")]
		public static void PGHXDVVIUAY(this Material a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x337FF40", Offset = "0x337EF40", VA = "0x18337FF40")]
		public static TEnum NCMILOAEGBZ<TEnum>(this Material a, int b) where TEnum : struct, Enum
		{
			return (TEnum)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class BPFGIIPSWHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<float> UONJOWGKYOI;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<float> VLCBGIOPHKK;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA554BC0", Offset = "0xA553BC0", VA = "0x18A554BC0")]
		public static bool CCXGXDAZTKO(int a, int b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA556020", Offset = "0xA555020", VA = "0x18A556020")]
		public static float PTMKWWDEYZB(this IList<float> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5570A0", Offset = "0xA5560A0", VA = "0x18A5570A0")]
		public static float ZNWUGMSXCFP(this IList<float> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA555500", Offset = "0xA554500", VA = "0x18A555500")]
		public static void NZITPPGBHFU(Vector3 a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA554E80", Offset = "0xA553E80", VA = "0x18A554E80")]
		public static void GBXXLWSJRYB(Vector3 a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA555460", Offset = "0xA554460", VA = "0x18A555460")]
		public static Vector3 NKIHWPCTCZC(float a, float b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA554FD0", Offset = "0xA553FD0", VA = "0x18A554FD0")]
		public static Vector3 IMKTZFQXCMN(float a, float b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA5565F0", Offset = "0xA5555F0", VA = "0x18A5565F0")]
		public static Vector3 RTAVAPYZBJY(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA556A10", Offset = "0xA555A10", VA = "0x18A556A10")]
		public static bool TAHCXDMGNCC(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA5564B0", Offset = "0xA5554B0", VA = "0x18A5564B0")]
		public static Vector3 QUAFRCQSPSJ(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5561B0", Offset = "0xA5551B0", VA = "0x18A5561B0")]
		public static float PYNLQFMGBVY(Ray a, Ray b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA555B70", Offset = "0xA554B70", VA = "0x18A555B70")]
		private static float PTMKWWDEYZB(this IList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA556E20", Offset = "0xA555E20", VA = "0x18A556E20")]
		public static bool VOKRPIVEHHH(float a, float b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA554CB0", Offset = "0xA553CB0", VA = "0x18A554CB0")]
		public static Vector3 DBYHJFPHLOL(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5559B0", Offset = "0xA5549B0", VA = "0x18A5559B0")]
		public static Vector3 PMDSVOGWJPS(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA556A80", Offset = "0xA555A80", VA = "0x18A556A80")]
		public static void UTVYXXPDERK(RRTransform a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA555570", Offset = "0xA554570", VA = "0x18A555570")]
		public static Vector3 PJIXLHZOHCN(Vector3 a, Vector3 b, float c, float d, [Out] float e)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5566D0", Offset = "0xA5556D0", VA = "0x18A5566D0")]
		public static Vector3 SXQXRPDDVOI(Vector3 a, Vector3 b, float c, [Out] float d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5550F0", Offset = "0xA5540F0", VA = "0x18A5550F0")]
		private static float LNHLUCEPAEK(Vector3 a, Vector3 b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5550D0", Offset = "0xA5540D0", VA = "0x18A5550D0")]
		public static float ISVRNQTXBBG(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA554F60", Offset = "0xA553F60", VA = "0x18A554F60")]
		public static float GZYMKTQVQEO(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA554BE0", Offset = "0xA553BE0", VA = "0x18A554BE0")]
		public static float CNMXEFPYNDQ(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA556D90", Offset = "0xA555D90", VA = "0x18A556D90")]
		public static void VGYDXPTZRPH(float a, float b, float c, [Out] float d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA557020", Offset = "0xA556020", VA = "0x18A557020")]
		public static float WNFZCISRXZE(this float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA554F80", Offset = "0xA553F80", VA = "0x18A554F80")]
		public static float HZGOGUXOYLM(this float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA557060", Offset = "0xA556060", VA = "0x18A557060")]
		public static float XATKMSBXNGG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5580", Offset = "0x2AA4580", VA = "0x182AA5580")]
		public static float MKUOAFIBEVU(this float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA554DF0", Offset = "0xA553DF0", VA = "0x18A554DF0")]
		public static float ELJKRPSNSYD(int a = 30)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA556E40", Offset = "0xA555E40", VA = "0x18A556E40")]
		public static Vector3 VPLPRZHTIBM(Vector3 a, Vector3 b, float c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA556A60", Offset = "0xA555A60", VA = "0x18A556A60")]
		public static bool TFRRDNFKZCP(this float a, float b, float c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class YSKGPFJMSRS
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA56DC90", Offset = "0xA56CC90", VA = "0x18A56DC90")]
		public static IDisposable ILTPTCWATKD(this Mesh a, int b, [Out] List<Vector2> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA56E1F0", Offset = "0xA56D1F0", VA = "0x18A56E1F0")]
		public static IDisposable LZTQFGYEFTJ(this Mesh a, [Out] List<Vector3> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA56DB20", Offset = "0xA56CB20", VA = "0x18A56DB20")]
		public static IDisposable CTUGLNRLHLX(this Mesh a, [Out] List<Vector4> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA56E060", Offset = "0xA56D060", VA = "0x18A56E060")]
		public static IDisposable JXTAWMZXSFG(this Mesh a, [Out] List<Matrix4x4> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA56E360", Offset = "0xA56D360", VA = "0x18A56E360")]
		public static int ZFRCTCLCRFV(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA56DE10", Offset = "0xA56CE10", VA = "0x18A56DE10")]
		public static int JMLZBMAKFKW(this Mesh a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA56DB10", Offset = "0xA56CB10", VA = "0x18A56DB10")]
		public static int CEEIWAEFMUW(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA56E1D0", Offset = "0xA56D1D0", VA = "0x18A56E1D0")]
		public static int KCDOSJMKBDB(this Mesh a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA56E1E0", Offset = "0xA56D1E0", VA = "0x18A56E1E0")]
		public static int KLPIBKVDLNK(this Mesh a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class RJAOBXYQVVT
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67E0BE0", Offset = "0x67DFBE0", VA = "0x1867E0BE0")]
		public static bool UDMXZUSPTTS(this MonoBehaviour a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA567480", Offset = "0xA566480", VA = "0x18A567480")]
		public static void EXTMLSFLHIZ(this MonoBehaviour a, Coroutine b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA567500", Offset = "0xA566500", VA = "0x18A567500")]
		public static void NAEKBIJKTTK(this MonoBehaviour a, IDisposable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA567550", Offset = "0xA566550", VA = "0x18A567550")]
		public static Coroutine RYDDKKWRKHJ(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA567620", Offset = "0xA566620", VA = "0x18A567620")]
		public static Coroutine WHVPDHOLUFJ(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA5676E0", Offset = "0xA5666E0", VA = "0x18A5676E0")]
		public static bool WJWUQQBDHWU(this MonoBehaviour a, int b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class OKTKWUFGAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D99D10", Offset = "0x3D98D10", VA = "0x183D99D10")]
		public static bool SNALXYYRDVB<a>(this a a) where a : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3D99DB0", Offset = "0x3D98DB0", VA = "0x183D99DB0")]
		public static bool YOKUFGKYOGP<b>(this b a) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA562BD0", Offset = "0xA561BD0", VA = "0x18A562BD0")]
		public static string GGEEWPTQOCQ(this UnityEngine.Object a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class DXEYRSRGKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class KSHGJDAFIRP<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<Collider, float, a> AFZKBSRDMPC;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public KSHGJDAFIRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6887600", Offset = "0x6886600", VA = "0x186887600")]
			internal bool HPJCQAXQHLG(RaycastHit a, float b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class EJSPVTERKYK<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Func<Collider, a> AFZKBSRDMPC;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public EJSPVTERKYK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5BD3AE0", Offset = "0x5BD2AE0", VA = "0x185BD3AE0")]
			internal bool CZPVWFKKUYL(RaycastHit a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly Collider[] OQMCZLPWGMF;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly RaycastHit[] WLDEUEOUCUI;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly RaycastHit[] XTRNOBABTKN;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA559840", Offset = "0xA558840", VA = "0x18A559840")]
		[CleanupBetweenRooms]
		internal static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x38FB6F0", Offset = "0x38FA6F0", VA = "0x1838FB6F0")]
		public static a DYKAKEMHAYD<a>(Vector3 a, Vector3 b, float c, int d, QueryTriggerInteraction e, [Out] Vector3 f, [Out] Collider g, Func<Collider, a> h)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA55A690", Offset = "0xA559690", VA = "0x18A55A690")]
		public static bool WNEQQPKPEDI(Ray a, float b, [Out] RaycastHit c, Func<RaycastHit, bool> d, int e, QueryTriggerInteraction f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x38FC2B0", Offset = "0x38FB2B0", VA = "0x1838FC2B0")]
		public static b LZQLKTFZWTI<b>(Vector3 a, float b, Vector3 c, int d, float e, [Out] Vector3 f, [Out] Collider g, Func<Collider, float, b> h, QueryTriggerInteraction i)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA55A1D0", Offset = "0xA5591D0", VA = "0x18A55A1D0")]
		public static Vector3 QWJSMKWHZKP([In] RaycastHit hit, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA55A300", Offset = "0xA559300", VA = "0x18A55A300")]
		public static Vector3 UJXNBTHIEXT([In] RaycastHit hit, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA55A550", Offset = "0xA559550", VA = "0x18A55A550")]
		public static Vector3 UJXNBTHIEXT(this Collider a, [In] Vector3 origin)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA559F50", Offset = "0xA558F50", VA = "0x18A559F50")]
		private static float HUVSQFFUCVY(Vector3 a, RaycastHit b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA559460", Offset = "0xA558460", VA = "0x18A559460")]
		public static bool CQIGUHSOGHT(Ray a, float b, float c, [Out] RaycastHit d, Func<RaycastHit, float, bool> e, int f, QueryTriggerInteraction g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA55A0E0", Offset = "0xA5590E0", VA = "0x18A55A0E0")]
		public static void JWVQIKJGHNI(this RaycastHit[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA55A8E0", Offset = "0xA5598E0", VA = "0x18A55A8E0")]
		public static void ZIBPFTIWZND(this Collision a, [Out] Vector3 b, [Out] Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA55A2C0", Offset = "0xA5592C0", VA = "0x18A55A2C0")]
		public static PhysicsMaterialCombine RHQWPURTJOT(PhysicsMaterialCombine a, PhysicsMaterialCombine b)
		{
			return default(PhysicsMaterialCombine);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA559B80", Offset = "0xA558B80", VA = "0x18A559B80")]
		public static float EBUCCQZHVMI(this PhysicsMaterial a, PhysicsMaterial b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA559C40", Offset = "0xA558C40", VA = "0x18A559C40")]
		public static float EBUCCQZHVMI(this PhysicsMaterial a, PhysicsMaterial b, PhysicsMaterialCombine c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA55A0A0", Offset = "0xA5590A0", VA = "0x18A55A0A0")]
		private static float IAVBXWIVHDY(float a, float b, PhysicsMaterialCombine c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA559E10", Offset = "0xA558E10", VA = "0x18A559E10")]
		public static float3x3 FUBIODDWBFA(this Rigidbody a)
		{
			return default(float3x3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA559900", Offset = "0xA558900", VA = "0x18A559900")]
		public static Vector3 DARAYKIGAJF(Vector3 a, float b, ForceMode c, ForceMode d)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class XSSKHMFOPQN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x41435E0", Offset = "0x41425E0", VA = "0x1841435E0")]
		public static ProfilerMarker.AutoScope BMULGEKPLCE<a>([Optional][CallerMemberName] string callerName)
		{
			return default(ProfilerMarker.AutoScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0")]
		public static ProfilerMarker.AutoScope BMULGEKPLCE(Type a, [Optional][CallerMemberName] string callerName)
		{
			return default(ProfilerMarker.AutoScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class IOVDCUCPOYL
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly float XCNBEAIMRRG;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly float YVCPYSTVOJT;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA55FAF0", Offset = "0xA55EAF0", VA = "0x18A55FAF0")]
		public static Vector3 GYKJHKZTYRJ(this Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA5600E0", Offset = "0xA55F0E0", VA = "0x18A5600E0")]
		public static Quaternion RKOJCMJCCJU(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA55F880", Offset = "0xA55E880", VA = "0x18A55F880")]
		public static Quaternion DTFKOGUDVAT(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA55FF10", Offset = "0xA55EF10", VA = "0x18A55FF10")]
		public static Quaternion NHXGVQCPGVB(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA560060", Offset = "0xA55F060", VA = "0x18A560060")]
		public static bool ORFODGGDJYZ(this Quaternion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA5600A0", Offset = "0xA55F0A0", VA = "0x18A5600A0")]
		public static bool RFXRVTWZOEU(this Quaternion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA560110", Offset = "0xA55F110", VA = "0x18A560110")]
		public static Quaternion SBJISESSHQS(this Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA55F520", Offset = "0xA55E520", VA = "0x18A55F520")]
		public static Quaternion BQNBWNNLPMO(this Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA5605D0", Offset = "0xA55F5D0", VA = "0x18A5605D0")]
		public static Quaternion YUAHMLEYSSX(this Quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA5602A0", Offset = "0xA55F2A0", VA = "0x18A5602A0")]
		public static Quaternion SRDISEJOJVV(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA55FE80", Offset = "0xA55EE80", VA = "0x18A55FE80")]
		public static Quaternion LZTWOGNUBTD(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA55FCB0", Offset = "0xA55ECB0", VA = "0x18A55FCB0")]
		public static Vector3 LFMMCYGHYRC(Quaternion a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA55F690", Offset = "0xA55E690", VA = "0x18A55F690")]
		public static Quaternion DONPCMPORIM(Quaternion a, Quaternion b, Vector3 c, float d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA560440", Offset = "0xA55F440", VA = "0x18A560440")]
		public static bool TFRRDNFKZCP(this Quaternion a, Quaternion b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA5604F0", Offset = "0xA55F4F0", VA = "0x18A5604F0")]
		public static bool XTIMRWJNRNR(this Quaternion a, Quaternion b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA55F930", Offset = "0xA55E930", VA = "0x18A55F930")]
		public static Quaternion GNMREIEPEXQ(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class JXKYDHLMURD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA560BE0", Offset = "0xA55FBE0", VA = "0x18A560BE0")]
		public static Rect PIVIAEMDTXP(this Rect a, Vector2 b)
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA560BC0", Offset = "0xA55FBC0", VA = "0x18A560BC0")]
		public static Vector2 MZUWJHAOHBA(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA560BA0", Offset = "0xA55FBA0", VA = "0x18A560BA0")]
		public static Vector2 ACRIUUQJDPT(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA560C40", Offset = "0xA55FC40", VA = "0x18A560C40")]
		public static Vector2 QYHEGJGWLXT(this Rect a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA560C60", Offset = "0xA55FC60", VA = "0x18A560C60")]
		public static Vector2 XNYBITKMFYM(this Rect a)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class OALDWKKFXYW
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int TRQXAIFFUMF;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly MaterialPropertyBlock ODRFAMEOHYP;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA562580", Offset = "0xA561580", VA = "0x18A562580")]
		public static Mesh NCJGGKTRFVT(this Renderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA5627A0", Offset = "0xA5617A0", VA = "0x18A5627A0")]
		public static Mesh NCJGGKTRFVT(this SkinnedMeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA562720", Offset = "0xA561720", VA = "0x18A562720")]
		public static Mesh NCJGGKTRFVT(this MeshRenderer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA562370", Offset = "0xA561370", VA = "0x18A562370")]
		public static int JRCRHDUHKKK(this Renderer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA562980", Offset = "0xA561980", VA = "0x18A562980")]
		public static void ROZBBAQJTJG(this Renderer a, int b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA5628B0", Offset = "0xA5618B0", VA = "0x18A5628B0")]
		public static void ROZBBAQJTJG(this Renderer a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA5627E0", Offset = "0xA5617E0", VA = "0x18A5627E0")]
		public static void ROZBBAQJTJG(this Renderer a, int b, Vector4 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA562A50", Offset = "0xA561A50", VA = "0x18A562A50")]
		public static void ROZBBAQJTJG(this Renderer a, int b, Texture2D c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA5627C0", Offset = "0xA5617C0", VA = "0x18A5627C0")]
		public static void QUPEHJTEHVT(this Renderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA562190", Offset = "0xA561190", VA = "0x18A562190")]
		public static void AUXSDCXTPSB(this Renderer a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA561FF0", Offset = "0xA560FF0", VA = "0x18A561FF0")]
		public static void AUXSDCXTPSB(this Renderer a, float b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class STVWISPVRJX
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA5678A0", Offset = "0xA5668A0", VA = "0x18A5678A0")]
		public static void OWEWKGZSRKI(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA5677E0", Offset = "0xA5667E0", VA = "0x18A5677E0")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA567720", Offset = "0xA566720", VA = "0x18A567720")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class WZRFHLRNRDT
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool GKRJVNUMNDT
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xA56CB90", Offset = "0xA56BB90", VA = "0x18A56CB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static bool VHHIHMYBXKT
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xA56CB40", Offset = "0xA56BB40", VA = "0x18A56CB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private static bool GZSASNSDNRT
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA56CA90", Offset = "0xA56BA90", VA = "0x18A56CA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA56CC80", Offset = "0xA56BC80", VA = "0x18A56CC80")]
		private static float SLNQAHCVPRO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA56CCD0", Offset = "0xA56BCD0", VA = "0x18A56CCD0")]
		private static float ZXHOFAYCJCO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA56CB30", Offset = "0xA56BB30", VA = "0x18A56CB30")]
		private static float EGKICNLZKEL()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class OQKZNBWGAOE
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
		private static readonly Regex DEAZIXTDFJH;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly Regex HNARNWNKUNU;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA563DC0", Offset = "0xA562DC0", VA = "0x18A563DC0")]
		public static string FGXVCKYGWGD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA564C40", Offset = "0xA563C40", VA = "0x18A564C40")]
		public static string UZPMVXLITBC(string a, char b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA564490", Offset = "0xA563490", VA = "0x18A564490")]
		public static bool SEWALNVLJKP(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA564CC0", Offset = "0xA563CC0", VA = "0x18A564CC0")]
		public static bool XDRDFBQBDLG(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA564080", Offset = "0xA563080", VA = "0x18A564080")]
		public static bool IKKIWVNPSPV(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA564070", Offset = "0xA563070", VA = "0x18A564070")]
		public static bool IHPIJBLINHX(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA564340", Offset = "0xA563340", VA = "0x18A564340")]
		public static bool LTCKSSDIHBJ(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA5642B0", Offset = "0xA5632B0", VA = "0x18A5642B0")]
		public static bool LTCKSSDIHBJ(this char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA564E60", Offset = "0xA563E60", VA = "0x18A564E60")]
		public static bool ZBNGHBOWKFX(this string a, string b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA564500", Offset = "0xA563500", VA = "0x18A564500")]
		public static bool TBWKYBDTMEE(this string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA563FB0", Offset = "0xA562FB0", VA = "0x18A563FB0")]
		public static bool HKXFPBCSAMG(this string a, string[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA564430", Offset = "0xA563430", VA = "0x18A564430")]
		public static bool REFEFNSQQFV(string a, string b, StringComparison c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA5643D0", Offset = "0xA5633D0", VA = "0x18A5643D0")]
		public static string QGLGESRWQIN(this string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA564E90", Offset = "0xA563E90", VA = "0x18A564E90")]
		public static string ZGWELTURONC(this string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA563C40", Offset = "0xA562C40", VA = "0x18A563C40")]
		public static string CYCDDPDMQYX(this string a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA5645B0", Offset = "0xA5635B0", VA = "0x18A5645B0")]
		public static List<string> UDAKBPMXICC(this string a, int b, int c = 2147483647)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA564130", Offset = "0xA563130", VA = "0x18A564130")]
		public static string JWCQLVEFCED(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA564530", Offset = "0xA563530", VA = "0x18A564530")]
		public static string TERCRTJXNHA(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA564D50", Offset = "0xA563D50", VA = "0x18A564D50")]
		public static bool XKKJOIIEQCP(this string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1183F80", Offset = "0x1182F80", VA = "0x181183F80")]
		public static string PCBGJZMKLPK(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA564290", Offset = "0xA563290", VA = "0x18A564290")]
		public static string LSOBPEWCNQQ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA5643B0", Offset = "0xA5633B0", VA = "0x18A5643B0")]
		public static int LTIDIUOWFVT(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA563D70", Offset = "0xA562D70", VA = "0x18A563D70")]
		[CompilerGenerated]
		internal static bool FBFJEWRSOVD(int a, <>c__DisplayClass18_0 b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class YDJGWBSZJGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public Color[] UKVSSFAEEQR;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xA5690F0", Offset = "0xA5680F0", VA = "0x18A5690F0")]
			internal void OZYPHUNMAEC(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA56D1C0", Offset = "0xA56C1C0", VA = "0x18A56D1C0")]
		public static void IMHMSGMUGMM(this Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA56CD70", Offset = "0xA56BD70", VA = "0x18A56CD70")]
		public static void HCCXLLXOJMF(this RenderTexture a, Texture2D b, bool c = false, bool d = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class HCVUHHAGOZX
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public delegate string ExceptionMessageBuilder();

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public delegate TEx ExceptionBuilder<out TEx>(TimeSpan timeoutSpan);

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3B04370", Offset = "0x3B03370", VA = "0x183B04370")]
		public static TaskCompletionSource<a> WPGQONSOKWH<a>(this TaskCompletionSource<a> a, TimeSpan b, [Optional] ExceptionMessageBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3B02AB0", Offset = "0x3B01AB0", VA = "0x183B02AB0")]
		public static TaskCompletionSource<b> WPGQONSOKWH<b, c>(this TaskCompletionSource<b> a, TimeSpan b, ExceptionBuilder<c> c) where c : TcsTimeoutException
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA55F480", Offset = "0xA55E480", VA = "0x18A55F480")]
		private static void SURZHLAXMKP(TimeSpan a)
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
		[Cpp2IlInjected.Address(RVA = "0xA567960", Offset = "0xA566960", VA = "0x18A567960")]
		private static FormattableString CLGVMGBOUPO(TimeSpan a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA567E80", Offset = "0xA566E80", VA = "0x18A567E80")]
		private static string QJVCHTHBGHR(TimeSpan a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA567F80", Offset = "0xA566F80", VA = "0x18A567F80")]
		public TcsTimeoutException(TimeSpan timeout, string message, bool prependTime = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class ONDGKOEGUHR
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly Vector3[] YCMRUPVIEOK;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA563010", Offset = "0xA562010", VA = "0x18A563010")]
		public static Vector3 DYUPSMQYPKA(this Transform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA563360", Offset = "0xA562360", VA = "0x18A563360")]
		public static Vector3 LKYFYTYJQHX(this Transform a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA563480", Offset = "0xA562480", VA = "0x18A563480")]
		public static Vector3 LKYFYTYJQHX(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA563200", Offset = "0xA562200", VA = "0x18A563200")]
		public static Vector3 HKNOMZSBLBJ(this RectTransform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA563B10", Offset = "0xA562B10", VA = "0x18A563B10")]
		public static Vector2 YNKUFLHINCY(this RectTransform a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA563920", Offset = "0xA562920", VA = "0x18A563920")]
		public static float XBJYMQNGFOY(this RectTransform a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA562E70", Offset = "0xA561E70", VA = "0x18A562E70")]
		public static Vector3 BHWLCYDCMVJ(this RectTransform a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5632E0", Offset = "0xA5622E0", VA = "0x18A5632E0")]
		public static Vector3[] JQCJANOSBWM(this RectTransform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA5637E0", Offset = "0xA5627E0", VA = "0x18A5637E0")]
		public static Transform OFCMASWLMYN(this Transform a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA562F60", Offset = "0xA561F60", VA = "0x18A562F60")]
		public static bool DOFZZALFMLC(this Transform a, Transform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA563A90", Offset = "0xA562A90", VA = "0x18A563A90")]
		public static int YIREDXMTYJJ(this Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA562C70", Offset = "0xA561C70", VA = "0x18A562C70")]
		public static void ABMQBCVSRFW(this RectTransform a, Vector3[] b, [Optional] Canvas c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class JZDSGYCSLPQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Vector2 WQZCDKYDKAC
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA560CC0", Offset = "0xA55FCC0", VA = "0x18A560CC0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static float BGRSASFVZVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA560D20", Offset = "0xA55FD20", VA = "0x18A560D20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static Quaternion LZVYIIEOUFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA560D30", Offset = "0xA55FD30", VA = "0x18A560D30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static Vector3 MSFBRQSBRNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA560C80", Offset = "0xA55FC80", VA = "0x18A560C80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static Vector3 UBLNAVDBCGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA560CD0", Offset = "0xA55FCD0", VA = "0x18A560CD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA560D00", Offset = "0xA55FD00", VA = "0x18A560D00")]
		public static float Range(float minInclusive, float maxInclusive)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA560D10", Offset = "0xA55FD10", VA = "0x18A560D10")]
		public static int Range(int minInclusive, int maxExclusive)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA560CB0", Offset = "0xA55FCB0", VA = "0x18A560CB0")]
		public static void DGIZHWAMYLJ(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class VUYOOUYLFOD
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly Vector2 VFHLBGYTCSV;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly Vector2 SMREJCFVGID;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly Vector2 NFZFPGJRFVA;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x10C7930", Offset = "0x10C6930", VA = "0x1810C7930")]
		public static Vector2 SINWBJFSHAM(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA56BEA0", Offset = "0xA56AEA0", VA = "0x18A56BEA0")]
		public static Vector2 JYMQRXVXAGR(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA56C270", Offset = "0xA56B270", VA = "0x18A56C270")]
		public static Vector2 NRXGZWYAHYI(this Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA56BE50", Offset = "0xA56AE50", VA = "0x18A56BE50")]
		public static bool HEZYKCXDLGC(this Vector2 a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA56C020", Offset = "0xA56B020", VA = "0x18A56C020")]
		public static float NESEMABADUG(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA56C360", Offset = "0xA56B360", VA = "0x18A56C360")]
		public static bool YGOZSFLXYAC(this Vector2 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA56BE80", Offset = "0xA56AE80", VA = "0x18A56BE80")]
		public static Vector2 JYKJRKTFVHW(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA56C000", Offset = "0xA56B000", VA = "0x18A56C000")]
		public static Vector2 JYPQORNDETF(this Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA56BD50", Offset = "0xA56AD50", VA = "0x18A56BD50")]
		public static Vector2 BCITNUAAAPV(this Vector2 a, float b, float c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA56BDF0", Offset = "0xA56ADF0", VA = "0x18A56BDF0")]
		public static Vector2 BCITNUAAAPV(this Vector2 a, float b, float c, float d, float e)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class UQYDJDRHFJJ
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
		public static readonly float QOEYKRQRIOI;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5691B0", Offset = "0xA5681B0", VA = "0x18A5691B0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA330", Offset = "0x1EB9330", VA = "0x181EBA330")]
		public static float MMWABPMWEIT(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA56A240", Offset = "0xA569240", VA = "0x18A56A240")]
		public static Vector3 LRQOQSIAGFS(this Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 e)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA56A330", Offset = "0xA569330", VA = "0x18A56A330")]
		public static Vector3 LRQOQSIAGFS(this Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA56A3C0", Offset = "0xA5693C0", VA = "0x18A56A3C0")]
		public static Vector3 LRQOQSIAGFS(this Vector3 a, Vector3 b, Quaternion c, Vector3 d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA56B760", Offset = "0xA56A760", VA = "0x18A56B760")]
		public static Vector3 ZAXKBCYTBDO(this Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5698F0", Offset = "0xA5688F0", VA = "0x18A5698F0")]
		public static void EJZCKFNCIPE(Vector3 a, Quaternion b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA569820", Offset = "0xA568820", VA = "0x18A569820")]
		public static void EJZCKFNCIPE(Vector3 a, Quaternion b, Vector3 c, float d, Vector3 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA56AC80", Offset = "0xA569C80", VA = "0x18A56AC80")]
		public static bool QXBBUQQCQJW(this Vector3 a, float b = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA56AD00", Offset = "0xA569D00", VA = "0x18A56AD00")]
		public static bool SDJMEFEUEMQ(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA569CA0", Offset = "0xA568CA0", VA = "0x18A569CA0")]
		public static bool GZNAUWCZLMM(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9913E20", Offset = "0x9912E20", VA = "0x189913E20")]
		public static float BBKCPCINVAB(this Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA569C80", Offset = "0xA568C80", VA = "0x18A569C80")]
		public static float EVCELVIXTKT(this Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA56AC40", Offset = "0xA569C40", VA = "0x18A56AC40")]
		public static Vector3 PQADFIVQQCM(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5695D0", Offset = "0xA5685D0", VA = "0x18A5695D0")]
		public static Vector3 DYHVUSAKAFB(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA569F90", Offset = "0xA568F90", VA = "0x18A569F90")]
		public static Vector3 JYMQRXVXAGR(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA56B580", Offset = "0xA56A580", VA = "0x18A56B580")]
		public static bool YGOZSFLXYAC(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA56A810", Offset = "0xA569810", VA = "0x18A56A810")]
		public static bool ORFODGGDJYZ(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA56ACD0", Offset = "0xA569CD0", VA = "0x18A56ACD0")]
		public static bool RFXRVTWZOEU(this Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA56A1D0", Offset = "0xA5691D0", VA = "0x18A56A1D0")]
		public static Vector3 KHCQKWNOLFW(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA56B820", Offset = "0xA56A820", VA = "0x18A56B820")]
		public static Vector3 ZFLSMZWIGSZ(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA56A640", Offset = "0xA569640", VA = "0x18A56A640")]
		public static float NEXLJGUXNFP(this Vector3 a, Vector3 b, [Optional] Vector3? c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA56B210", Offset = "0xA56A210", VA = "0x18A56B210")]
		public static Vector3 YBTIOJGHMMB(this Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E590", Offset = "0x2B0D590", VA = "0x182B0E590")]
		public static float ZXGHIEJQBMU(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA569B20", Offset = "0xA568B20", VA = "0x18A569B20")]
		public static float ELZADFGCDFH(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA569CE0", Offset = "0xA568CE0", VA = "0x18A569CE0")]
		public static Vector3 HASMNPWNQPE(Vector3 a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA56A840", Offset = "0xA569840", VA = "0x18A56A840")]
		public static Axis PODTAQZATHN(Transform a, Vector3 b, [Out] Vector3 c)
		{
			return default(Axis);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA56A210", Offset = "0xA569210", VA = "0x18A56A210")]
		public static Vector3 KNJQIUYZONG(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA56A220", Offset = "0xA569220", VA = "0x18A56A220")]
		public static Vector3 KNOXGBSWXYP(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA56A230", Offset = "0xA569230", VA = "0x18A56A230")]
		public static Vector3 KNUEDIMUHJY(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5695B0", Offset = "0xA5685B0", VA = "0x18A5695B0")]
		public static Vector3 CONUVSXCYQL(float a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA569F70", Offset = "0xA568F70", VA = "0x18A569F70")]
		public static Vector3 JYKJRKTFVHW(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA56A190", Offset = "0xA569190", VA = "0x18A56A190")]
		public static Vector3 JYPQORNDETF(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA56A1B0", Offset = "0xA5691B0", VA = "0x18A56A1B0")]
		public static Vector3 JYUXLYHAOEO(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA56B6D0", Offset = "0xA56A6D0", VA = "0x18A56B6D0")]
		public static Vector3 YRFYLZSNRND(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA56B640", Offset = "0xA56A640", VA = "0x18A56B640")]
		public static Vector3 YRAROSYQIBU(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA56B5B0", Offset = "0xA56A5B0", VA = "0x18A56B5B0")]
		public static Vector3 YQVKRMESYQL(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA56AEA0", Offset = "0xA569EA0", VA = "0x18A56AEA0")]
		public static Vector3 SWYEVWJTQQG(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA56AF30", Offset = "0xA569F30", VA = "0x18A56AF30")]
		public static Vector3 SXDLTDDRABP(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA56AE10", Offset = "0xA569E10", VA = "0x18A56AE10")]
		public static Vector3 SWNRBIVYXTO(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA56B0A0", Offset = "0xA56A0A0", VA = "0x18A56B0A0")]
		public static Vector3 TXSTFHZDZVE(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA56B130", Offset = "0xA56A130", VA = "0x18A56B130")]
		public static Vector3 TXYACOTBJGN(this Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA569470", Offset = "0xA568470", VA = "0x18A569470")]
		public static Vector3 CJECHASUVHT(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA569670", Offset = "0xA568670", VA = "0x18A569670")]
		public static Vector3 EBNFJUQQORB(Vector3 a, Vector3 b, Vector3 c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA56B230", Offset = "0xA56A230", VA = "0x18A56B230")]
		public static float YBUERIYUTGQ(this Vector3 a, Vector3 b, Vector3 c, bool d = false)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA56AFC0", Offset = "0xA569FC0", VA = "0x18A56AFC0")]
		public static bool TFRRDNFKZCP(this Vector3 a, Vector3 b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA56B1C0", Offset = "0xA56A1C0", VA = "0x18A56B1C0")]
		public static bool WCGPDYGOYZZ(this Vector3 a, Vector3 b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA56AD40", Offset = "0xA569D40", VA = "0x18A56AD40")]
		public static byte[] SHZWPQEXDJR([In] this Vector3 vec)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA56A470", Offset = "0xA569470", VA = "0x18A56A470")]
		public static int MGNGUXTBOUG(Vector3 a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA56B860", Offset = "0xA56A860", VA = "0x18A56B860")]
		public static Vector3 ZHEAKIJRIHX(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA554930", Offset = "0xA553930", VA = "0x18A554930")]
		public ActiveRenderTextureScope(RenderTexture newActiveRenderTexture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA554920", Offset = "0xA553920", VA = "0x18A554920", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class BUYHTLAZHGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Dictionary<int, float> EFJJSLQDEJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly Dictionary<int, Color> STTDZTLSKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Dictionary<int, Vector4> WOIAWCQJEZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly Dictionary<int, Matrix4x4> BFWIMVLMEJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly Dictionary<int, Texture> XRKAKOZMRJU;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static ProfilerMarker LAHXYISBUNX;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KGOGGEAAGGE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xD37900", Offset = "0xD36900", VA = "0x180D37900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xD37910", Offset = "0xD36910", VA = "0x180D37910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA557CC0", Offset = "0xA556CC0", VA = "0x18A557CC0")]
		public void SetFloat(int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA557260", Offset = "0xA556260", VA = "0x18A557260")]
		public void CCJZKIQAFXV(int a, Vector4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA557BC0", Offset = "0xA556BC0", VA = "0x18A557BC0")]
		public void LVWEDUGZUZJ(int a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA5573A0", Offset = "0xA5563A0", VA = "0x18A5573A0")]
		public void GEMOKDQBFVK(Material a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA557DE0", Offset = "0xA556DE0", VA = "0x18A557DE0")]
		public BUYHTLAZHGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class YPBDNBJTBKQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static TVMTNALAYAB<List<int>> MOYPUJWAOQS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xA56D3F0", Offset = "0xA56C3F0", VA = "0x18A56D3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static TVMTNALAYAB<List<Vector2>> ZRBSRUGFOZK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xA56D840", Offset = "0xA56C840", VA = "0x18A56D840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static TVMTNALAYAB<List<Vector3>> AMVZHSGFECR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA56D490", Offset = "0xA56C490", VA = "0x18A56D490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static TVMTNALAYAB<List<Vector4>> VHLPBCBLPQW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA56D7A0", Offset = "0xA56C7A0", VA = "0x18A56D7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static TVMTNALAYAB<List<BoneWeight>> RFOXJHIHUJR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA56D7F0", Offset = "0xA56C7F0", VA = "0x18A56D7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static TVMTNALAYAB<List<Matrix4x4>> TNKAPVLZOQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA56D440", Offset = "0xA56C440", VA = "0x18A56D440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA56D4E0", Offset = "0xA56C4E0", VA = "0x18A56D4E0")]
		public static void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class GTIIUZHTBLU
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA55CD10", Offset = "0xA55BD10", VA = "0x18A55CD10")]
		public static long NRFEFFVJLIX(Vector2 a, Vector2 b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA55CD60", Offset = "0xA55BD60", VA = "0x18A55CD60")]
		public static long SRCNDOYJQHO(float a, float b, float c, float d)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA55C890", Offset = "0xA55B890", VA = "0x18A55C890")]
		public static float JYCFVSFOWYZ(Matrix4x4 a, Vector2 b, float c, float d = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA55C7F0", Offset = "0xA55B7F0", VA = "0x18A55C7F0")]
		private static float GGVBVCMXBNG(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA55CD90", Offset = "0xA55BD90", VA = "0x18A55CD90")]
		public static void YHUCLIKKXCO(List<Vector3> a, Matrix4x4 b, Vector3 c, Vector2 d, float e, [Out] bool f, float g = 0f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class MKKVPNRZFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA5616D0", Offset = "0xA5606D0", VA = "0x18A5616D0")]
		public static int UTQTSOUYXIB(LODGroup a, LOD[] b, Camera c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5614E0", Offset = "0xA5604E0", VA = "0x18A5614E0")]
		private static float QWLROYAZHXV(LODGroup a, Camera b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA561410", Offset = "0xA560410", VA = "0x18A561410")]
		private static float ICNEQVUHSRV(LODGroup a, Transform b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA561740", Offset = "0xA560740", VA = "0x18A561740")]
		private static float XMDKADHLMXX(Camera a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA561490", Offset = "0xA560490", VA = "0x18A561490")]
		private static float NGXTYNXAMPG(Transform a)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Rendering.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class LIJZINRWVKU
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xA560D60", Offset = "0xA55FD60", VA = "0x18A560D60")]
		public static Texture2DArray EBJHKSZAPFP(string a, IReadOnlyList<Texture2D> b, Vector2? c, TextureFormat d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5612F0", Offset = "0xA5602F0", VA = "0x18A5612F0")]
		private static void REAMKQOZIIM(Texture2D a, Texture2DArray b, int c)
		{
		}
	}
}
namespace RecRoom.MathUtils
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class PMMCBKITZZZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public a BGRSASFVZVT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xDB43E0", Offset = "0xDB33E0", VA = "0x180DB43E0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xE08660", Offset = "0xE07660", VA = "0x180E08660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public a OJSHIYWFHYV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xED7570", Offset = "0xED6570", VA = "0x180ED7570")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xED71D0", Offset = "0xED61D0", VA = "0x180ED71D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract a CHBKEATDNYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xED71D0", Offset = "0xED61D0", VA = "0x180ED71D0")]
		public void DEFARRTBKFX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7501480", Offset = "0x7500480", VA = "0x187501480")]
		public void WODJSHQATJK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xE08660", Offset = "0xE07660", VA = "0x180E08660")]
		public void HZFSEGQIMHH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7501050", Offset = "0x7500050", VA = "0x187501050")]
		public a Apply(float moveTime, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7500FF0", Offset = "0x74FFFF0", VA = "0x187500FF0")]
		public a Apply(float moveTime, float maxSpeed, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool OUBHURYKPNH(a a);

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract a YTHOFDHTKWV(float a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected PMMCBKITZZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class NJFQBCKCVLT : PMMCBKITZZZ<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override float CHBKEATDNYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xA570CB0", Offset = "0xA56FCB0", VA = "0x18A570CB0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA570C70", Offset = "0xA56FC70", VA = "0x18A570C70", Slot = "5")]
		public override bool OUBHURYKPNH(float a = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA570D50", Offset = "0xA56FD50", VA = "0x18A570D50", Slot = "6")]
		protected override float YTHOFDHTKWV(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA570EB0", Offset = "0xA56FEB0", VA = "0x18A570EB0")]
		public NJFQBCKCVLT()
		{
		}
	}
}
namespace RecRoom.MathUtils.Springs
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class VCANWNCEDOM : GKREMTRDFVT<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override float CHBKEATDNYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xA571540", Offset = "0xA570540", VA = "0x18A571540", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override float DQTUZGQYHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xA5714A0", Offset = "0xA5704A0", VA = "0x18A5714A0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA5714F0", Offset = "0xA5704F0", VA = "0x18A5714F0", Slot = "6")]
		protected override float UNTSSHUWROR(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA571590", Offset = "0xA570590", VA = "0x18A571590")]
		public VCANWNCEDOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class HMNDJWNOKPR : GKREMTRDFVT<float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override float CHBKEATDNYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xA570330", Offset = "0xA56F330", VA = "0x18A570330", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override float DQTUZGQYHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA5702B0", Offset = "0xA56F2B0", VA = "0x18A5702B0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA5702E0", Offset = "0xA56F2E0", VA = "0x18A5702E0", Slot = "6")]
		protected override float UNTSSHUWROR(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA5703D0", Offset = "0xA56F3D0", VA = "0x18A5703D0")]
		public HMNDJWNOKPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class XLHFDJBEHDY : GKREMTRDFVT<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Vector2 CHBKEATDNYN
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA571680", Offset = "0xA570680", VA = "0x18A571680", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override Vector2 DQTUZGQYHEF
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xA5715D0", Offset = "0xA5705D0", VA = "0x18A5715D0", Slot = "5")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA571630", Offset = "0xA570630", VA = "0x18A571630", Slot = "6")]
		protected override Vector2 UNTSSHUWROR(Vector2 a, Vector2 b, Vector2 c, float d, float e, float f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA5716E0", Offset = "0xA5706E0", VA = "0x18A5716E0")]
		public XLHFDJBEHDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class EDVUHQTIJKL : GKREMTRDFVT<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override Vector3 CHBKEATDNYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA5701F0", Offset = "0xA56F1F0", VA = "0x18A5701F0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override Vector3 DQTUZGQYHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA5700D0", Offset = "0xA56F0D0", VA = "0x18A5700D0", Slot = "5")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA570150", Offset = "0xA56F150", VA = "0x18A570150", Slot = "6")]
		protected override Vector3 UNTSSHUWROR(Vector3 a, Vector3 b, Vector3 c, float d, float e, float f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA570270", Offset = "0xA56F270", VA = "0x18A570270")]
		public EDVUHQTIJKL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class GKREMTRDFVT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public const float UMLTXGGYKSI = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public a BGRSASFVZVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xDB43E0", Offset = "0xDB33E0", VA = "0x180DB43E0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xE08660", Offset = "0xE07660", VA = "0x180E08660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public a OJSHIYWFHYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xED7570", Offset = "0xED6570", VA = "0x180ED7570")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xED71D0", Offset = "0xED61D0", VA = "0x180ED71D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public a SPMVCXJZPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xD632C0", Offset = "0xD622C0", VA = "0x180D632C0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1415550", Offset = "0x1414550", VA = "0x181415550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public abstract a CHBKEATDNYN
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract a DQTUZGQYHEF
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xED71D0", Offset = "0xED61D0", VA = "0x180ED71D0")]
		public void DEFARRTBKFX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x644C690", Offset = "0x644B690", VA = "0x18644C690")]
		public void WODJSHQATJK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x644C220", Offset = "0x644B220", VA = "0x18644C220")]
		public void HZFSEGQIMHH(a a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x644BAD0", Offset = "0x644AAD0", VA = "0x18644BAD0")]
		public a Apply(float smoothTime, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x644BFC0", Offset = "0x644AFC0", VA = "0x18644BFC0")]
		public a Apply(float smoothTime, float maxSpeed, float deltaTime)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract a UNTSSHUWROR(a a, a b, a c, float d, float e, float f);

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected GKREMTRDFVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class SLOVACZTVRW
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public const float UMLTXGGYKSI = 0.0001f;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Quaternion BGRSASFVZVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xF1C290", Offset = "0xF1B290", VA = "0x180F1C290")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xF1C2B0", Offset = "0xF1B2B0", VA = "0x180F1C2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Quaternion OJSHIYWFHYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xEEF550", Offset = "0xEEE550", VA = "0x180EEF550")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xFD6150", Offset = "0xFD5150", VA = "0x180FD6150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float SPMVCXJZPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xE856D0", Offset = "0xE846D0", VA = "0x180E856D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x10AB300", Offset = "0x10AA300", VA = "0x1810AB300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xFD6150", Offset = "0xFD5150", VA = "0x180FD6150")]
		public void DEFARRTBKFX(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA5713E0", Offset = "0xA5703E0", VA = "0x18A5713E0")]
		public void WODJSHQATJK(Quaternion a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA5710B0", Offset = "0xA5700B0", VA = "0x18A5710B0")]
		public Quaternion Apply(float smoothTime, float deltaTime)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA570EF0", Offset = "0xA56FEF0", VA = "0x18A570EF0")]
		public Quaternion Apply(float smoothTime, float maxSpeed, float deltaTime)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA571270", Offset = "0xA570270", VA = "0x18A571270")]
		private static Quaternion UNTSSHUWROR(Quaternion a, Quaternion b, float c, float d, float e, float f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public SLOVACZTVRW()
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
		[Cpp2IlInjected.Address(RVA = "0xA571480", Offset = "0xA570480", VA = "0x18A571480")]
		public SimpleSpringConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class YOEYHXGQNNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly SimpleSpringConfig JBCVUOXOEPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Vector2 OEZVVDQFOZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private Vector2 ZWUMVCGUCFJ;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public YOEYHXGQNNL(SimpleSpringConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA571F20", Offset = "0xA570F20", VA = "0x18A571F20")]
		public Vector2 UNTSSHUWROR(Vector2 a, float b)
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
		[Cpp2IlInjected.Address(RVA = "0xA571400", Offset = "0xA570400", VA = "0x18A571400")]
		public SimpleSpring6DConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class YNAERUBLXXL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private SimpleSpring6DConfig JBCVUOXOEPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Vector3 ZWUMVCGUCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Vector3 UMQPUGFSLIB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 IFTRXQVBHBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x19DDF30", Offset = "0x19DCF30", VA = "0x1819DDF30")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x19DDE90", Offset = "0x19DCE90", VA = "0x1819DDE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 LWKWIDIZVNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1D0D9D0", Offset = "0x1D0C9D0", VA = "0x181D0D9D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1AA11A0", Offset = "0x1AA01A0", VA = "0x181AA11A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion FZMTJGPGPWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xF7CED0", Offset = "0xF7BED0", VA = "0x180F7CED0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xF7CF50", Offset = "0xF7BF50", VA = "0x180F7CF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion KGAYDLOYNUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x10B2810", Offset = "0x10B1810", VA = "0x1810B2810")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x10B27F0", Offset = "0x10B17F0", VA = "0x1810B27F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float XKFICRPOWXD
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA571720", Offset = "0xA570720", VA = "0x18A571720")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xA571E80", Offset = "0xA570E80", VA = "0x18A571E80")]
		public YNAERUBLXXL(SimpleSpring6DConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xA571750", Offset = "0xA570750", VA = "0x18A571750")]
		public void HDKZXCQEFBM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
		public void SWFIYAXFZAC(SimpleSpring6DConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA571E40", Offset = "0xA570E40", VA = "0x18A571E40")]
		public void HDKZXCQEFBM()
		{
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class VXVIRSRCYNY
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x40E0600", Offset = "0x40DF600", VA = "0x1840E0600")]
		public static void TOGLCTJEZLG<a>(NativeArray<a> a, int b, Allocator c) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x40E02A0", Offset = "0x40DF2A0", VA = "0x1840E02A0")]
		public static e[] RGNKFQEHCNU<e>(NativeArray<e> a, int b) where e : struct
		{
			return null;
		}
	}
}
namespace RecRoom.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class KGIPLEQSZGS
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly int[] GRCVBTNWZEJ;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA570410", Offset = "0xA56F410", VA = "0x18A570410")]
		public static void QKDOQRRYDKB(this IncrementalHash a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA5707C0", Offset = "0xA56F7C0", VA = "0x18A5707C0")]
		public static void SXLVYLBDIPH(this IncrementalHash a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA5709F0", Offset = "0xA56F9F0", VA = "0x18A5709F0")]
		public static void YBJPMBRAIAW(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA570800", Offset = "0xA56F800", VA = "0x18A570800")]
		public static void WSVGJKADGUB(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA570470", Offset = "0xA56F470", VA = "0x18A570470")]
		public static void SJMXWOYPEZI(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA570660", Offset = "0xA56F660", VA = "0x18A570660")]
		public static void SMYZVDAWEOW(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDD70", Offset = "0x3BFCD70", VA = "0x183BFDD70")]
		public static void STGCFYDMGPP<a>(this IncrementalHash a, short b) where a : Enum
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
