using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Core;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class BPPOHFDGFBF<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class JCBKMCAPDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::BPPOHFDGFBF<T> NPGJHBIKAMG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] GFPNMODDJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public JCBKMCAPDIF(global::BPPOHFDGFBF<T> NPGJHBIKAMG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class AEHLHIJDFJO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::BPPOHFDGFBF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <count>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[DebuggerHidden]
		public AEHLHIJDFJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const int EBMBIKLLJHG = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> IMKIJFLMCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int IFPBFJEGEFN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool MPMONFPIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool OHBIGFKPDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool MEDFCKONKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OAFOLGMAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	public BPPOHFDGFBF(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public BPPOHFDGFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void JKONPOGPOHJ(int ALJOMNDNEBM, T FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void BLHADIBIAOF(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] BBOEFAOBLKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void HABOACIDDEG(NativeArray<T> HPOICFFOIAP, int IEPKLEKMEFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::BPPOHFDGFBF<>.AEHLHIJDFJO))]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	public int LODPMCNLMAH(T FPEJLKINELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool HEOHJOBENDL(T FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void HLNKFBLICPP(int KHCDJECBMLE, int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void ECABODKMDEI(int KHCDJECBMLE, int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void KLLIKHMBOMP(int KHCDJECBMLE, int FAOFKPMBKFB, int HGMGPFAJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int HIGPCJEMMLJ(int ALJOMNDNEBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T ANGCHCCNGFP(int ALJOMNDNEBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void GKLKCJEEHJJ(int ALJOMNDNEBM, T FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void PBAJCDENJEF(int ALJOMNDNEBM, T FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void PCPKJCEFNMC(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int CBAJBLNAOKO(int MFBGAMJDOKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int CLFIINLFEAD(int MFBGAMJDOKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void APLHJDOHHEA(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void JMEKFOAOPOF(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T IDJPKFMMJJE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T NGIOBOCKBPC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void HNKBDBBODKD(int ALJOMNDNEBM, IReadOnlyCollection<T> PJLNFOKAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void JDKJIKAMICP(int ALJOMNDNEBM, int PIMBDEAPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void KGLAMIMPJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void ILHHKENJNCM(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void IBDMMGOBEBO(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void HMHADINNIJG(int FAOFKPMBKFB, int HGMGPFAJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T FDOOJMLAKJI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T FCKJOBFLALO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LNDIBHKHMOM]
public static class BKPCNHNJHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CFC0", Offset = "0x3E7B9C0", VA = "0x183E7CFC0")]
	static BKPCNHNJHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38432E0", Offset = "0x3841CE0", VA = "0x1838432E0")]
	public static void PHBFOKPHOPN<T>(T EHFHEFGEMIO, ref T KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CE30", Offset = "0x3E7B830", VA = "0x183E7CE30")]
	public static void PHBFOKPHOPN(FixedString32 EHFHEFGEMIO, ref string KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CDF0", Offset = "0x3E7B7F0", VA = "0x183E7CDF0")]
	public static void PHBFOKPHOPN(string EHFHEFGEMIO, ref FixedString32 KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CF30", Offset = "0x3E7B930", VA = "0x183E7CF30")]
	public static void PHBFOKPHOPN(FixedString64 EHFHEFGEMIO, ref string KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CED0", Offset = "0x3E7B8D0", VA = "0x183E7CED0")]
	public static void PHBFOKPHOPN(string EHFHEFGEMIO, ref FixedString64 KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CDC0", Offset = "0x3E7B7C0", VA = "0x183E7CDC0")]
	public static void PHBFOKPHOPN(NNHPGFABMDE EHFHEFGEMIO, ref Vector3 KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CC50", Offset = "0x3E7B650", VA = "0x183E7CC50")]
	public static void PHBFOKPHOPN(Vector3 EHFHEFGEMIO, ref NNHPGFABMDE KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CD20", Offset = "0x3E7B720", VA = "0x183E7CD20")]
	public static void PHBFOKPHOPN(KMJGGLPBPDE EHFHEFGEMIO, ref Vector4 KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CCB0", Offset = "0x3E7B6B0", VA = "0x183E7CCB0")]
	public static void PHBFOKPHOPN(Vector4 EHFHEFGEMIO, ref KMJGGLPBPDE KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CD20", Offset = "0x3E7B720", VA = "0x183E7CD20")]
	public static void PHBFOKPHOPN(KMJGGLPBPDE EHFHEFGEMIO, ref Quaternion KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CCB0", Offset = "0x3E7B6B0", VA = "0x183E7CCB0")]
	public static void PHBFOKPHOPN(Quaternion EHFHEFGEMIO, ref KMJGGLPBPDE KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CD90", Offset = "0x3E7B790", VA = "0x183E7CD90")]
	public static void PHBFOKPHOPN(NNHPGFABMDE EHFHEFGEMIO, ref float3 KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CC50", Offset = "0x3E7B650", VA = "0x183E7CC50")]
	public static void PHBFOKPHOPN(float3 EHFHEFGEMIO, ref NNHPGFABMDE KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CD50", Offset = "0x3E7B750", VA = "0x183E7CD50")]
	public static void PHBFOKPHOPN(KMJGGLPBPDE EHFHEFGEMIO, ref float4 KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CCB0", Offset = "0x3E7B6B0", VA = "0x183E7CCB0")]
	public static void PHBFOKPHOPN(float4 EHFHEFGEMIO, ref KMJGGLPBPDE KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CD50", Offset = "0x3E7B750", VA = "0x183E7CD50")]
	public static void PHBFOKPHOPN(KMJGGLPBPDE EHFHEFGEMIO, ref quaternion KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CE60", Offset = "0x3E7B860", VA = "0x183E7CE60")]
	public static void PHBFOKPHOPN(quaternion EHFHEFGEMIO, ref KMJGGLPBPDE KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CF80", Offset = "0x3E7B980", VA = "0x183E7CF80")]
	public static void PHBFOKPHOPN(Entity EHFHEFGEMIO, ref KHDONFLOJOC KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CF60", Offset = "0x3E7B960", VA = "0x183E7CF60")]
	public static void PHBFOKPHOPN(KHDONFLOJOC EHFHEFGEMIO, ref Entity KHLDFPNJEFH, CBHAKBPJLFK DJHHBMBBPIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IGKLDKDLNIM]
public class NFAGBEHKONK : ComponentSystem, HNADMPPHDEF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IBDMDNNFKPL LHGMMJHJKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BDHPOBELMCM AGGKBGIFNMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB60", Offset = "0x7D9560", VA = "0x1807DAB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE07E0", Offset = "0x3DDF1E0", VA = "0x183DE07E0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	public NFAGBEHKONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[IGKLDKDLNIM]
[UpdateInGroup(typeof(HNLMKBGMPHI))]
internal class KBNHLMOHCOC : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41D0F30", Offset = "0x41CF930", VA = "0x1841D0F30", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41D0EB0", Offset = "0x41CF8B0", VA = "0x1841D0EB0")]
	[Preserve]
	private void BCHLDNDHJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public KBNHLMOHCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[IGKLDKDLNIM]
[UpdateInGroup(typeof(HNLMKBGMPHI))]
internal class CAPBDBHINNM : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E80210", Offset = "0x3E7EC10", VA = "0x183E80210", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public CAPBDBHINNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9710", Offset = "0x3DE8110", VA = "0x183DE9710")]
		public static ObjectModelConfigAsset GOMNDBLPPBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x95FF20", VA = "0x180961520")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int CJDCPGONDDE = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly NNLEPLPFODN DPMCBMJDHJK;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x47CBB30", Offset = "0x47CA530", VA = "0x1847CBB30")]
			public static ANIMKGBLAIA BJMNFPOLJFD(int PCPFJBDMGNP)
			{
				return default(ANIMKGBLAIA);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x47CC170", Offset = "0x47CAB70", VA = "0x1847CC170")]
			private static void PGHEKFNFCNI(GEEJJFIMDNA OODKPAJOGKG, GEEJJFIMDNA DBPEBKNHKGH, ANIMKGBLAIA BBILPABEHHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x47CBF20", Offset = "0x47CA920", VA = "0x1847CBF20")]
			public static int FEJAGHCKLCB(GameObject OJBDJCCAFCN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x47CC0F0", Offset = "0x47CAAF0", VA = "0x1847CC0F0")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void HMIIALAKCFF(GEEJJFIMDNA BJLPLHMBBOJ, int PCPFJBDMGNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static DPALDOJEBJE GCADPHBJBBM;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static DILAHLBHIHJ GHJONFLCPJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static DPALDOJEBJE KFFFHLBOMDG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAFF0", Offset = "0x3DE99F0", VA = "0x183DEAFF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3DE97B0", Offset = "0x3DE81B0", VA = "0x183DE97B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DILAHLBHIHJ FACFIIINDNF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9890", Offset = "0x3DE8290", VA = "0x183DE9890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9DB0", Offset = "0x3DE87B0", VA = "0x183DE9DB0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool ICFPBEHOBAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3DE99B0", Offset = "0x3DE83B0", VA = "0x183DE99B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IBDMDNNFKPL LHGMMJHJKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3DEADF0", Offset = "0x3DE97F0", VA = "0x183DEADF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static BDHPOBELMCM AGGKBGIFNMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB050", Offset = "0x3DE9A50", VA = "0x183DEB050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static BFJCJFMHLPG MENCMLPHANC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA1B0", Offset = "0x3DE8BB0", VA = "0x183DEA1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static NLFGNBOEMBJ FDBECKJOFLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA7A0", Offset = "0x3DE91A0", VA = "0x183DEA7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HLNKJMLPBIB MOLFCDPLHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB220", Offset = "0x3DE9C20", VA = "0x183DEB220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static AJDBIBIKOCB HHNHIPIOBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAE90", Offset = "0x3DE9890", VA = "0x183DEAE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool MOFHLJKHIPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAB30", Offset = "0x3DE9530", VA = "0x183DEAB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool APDECCANOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA520", Offset = "0x3DE8F20", VA = "0x183DEA520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool FDLKEBLJBDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA820", Offset = "0x3DE9220", VA = "0x183DEA820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool BAPGGJOECHB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA150", Offset = "0x3DE8B50", VA = "0x183DEA150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA4C0", Offset = "0x3DE8EC0", VA = "0x183DEA4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool IGJBDDABKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9FD0", Offset = "0x3DE89D0", VA = "0x183DE9FD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA460", Offset = "0x3DE8E60", VA = "0x183DEA460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action MGPMICPPGPB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA230", Offset = "0x3DE8C30", VA = "0x183DEA230")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3DEACF0", Offset = "0x3DE96F0", VA = "0x183DEACF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB130", Offset = "0x3DE9B30", VA = "0x183DEB130")]
		public static GEEJJFIMDNA ONPEFMCCMDC(GameObject OJBDJCCAFCN)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB0D0", Offset = "0x3DE9AD0", VA = "0x183DEB0D0")]
		public static bool OGMEMNEAHNA(ByteString CEMHLJHECJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAA10", Offset = "0x3DE9410", VA = "0x183DEAA10")]
		public static GAIECBKNDJB INPLPEHOACP(ANIMKGBLAIA BBILPABEHHM)
		{
			return default(GAIECBKNDJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA650", Offset = "0x3DE9050", VA = "0x183DEA650")]
		public static (ByteString, IDisposable) HGLHKADDNFF()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB2A0", Offset = "0x3DE9CA0", VA = "0x183DEB2A0")]
		public static (ByteString, IDisposable) PNHMCPNGMNF(IEnumerable<GEEJJFIMDNA> NACGECFJEKF)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA330", Offset = "0x3DE8D30", VA = "0x183DEA330")]
		public static bool GAFKBPKBCOH(GameObject OJBDJCCAFCN, out ANIMKGBLAIA BBILPABEHHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA030", Offset = "0x3DE8A30", VA = "0x183DEA030")]
		public static bool EJAFDEINJBC(IEnumerable<OOFJJCAIBIL> KCFFMLPOBOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAF10", Offset = "0x3DE9910", VA = "0x183DEAF10")]
		public static void LIKPJBLCAPE(bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9C30", Offset = "0x3DE8630", VA = "0x183DE9C30")]
		public static Task DMNICBPAEHF(bool CABHIPNEIGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAC10", Offset = "0x3DE9610", VA = "0x183DEAC10")]
		private static DILAHLBHIHJ KAANCILNCLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9B10", Offset = "0x3DE8510", VA = "0x183DE9B10")]
		private static bool DCLMMPGAPBA()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0290", Offset = "0x3DEEC90", VA = "0x183DF0290")]
		public static bool CJGNIKPCJKK(MABFCBAKEGH APOOKLFEMEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFD70", Offset = "0x3DEE770", VA = "0x183DEFD70")]
		public static MABFCBAKEGH AIDBCCOFMIA(GameObject OJBDJCCAFCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFFA0", Offset = "0x3DEE9A0", VA = "0x183DEFFA0")]
		public static MABFCBAKEGH AIDBCCOFMIA(GameObject OJBDJCCAFCN, ANIMKGBLAIA BBILPABEHHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0340", Offset = "0x3DEED40", VA = "0x183DF0340")]
		public static bool LGJFOPNHJHE(GameObject LNBPLDMMKPA, string OFPFFILADCG, bool LCCDIBNFGNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFB70", Offset = "0x3DEE570", VA = "0x183DEFB70")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void AHGNPOIDIDC(GameObject LNBPLDMMKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3DF01A0", Offset = "0x3DEEBA0", VA = "0x183DF01A0")]
		[CompilerGenerated]
		internal static string CCPPKINEFPC((GameObject go, string prefabName) LIKLGHJBPPH)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, NNBALKKOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool FFCJMMOGLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GEEJJFIMDNA PAGAMJKGOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(GEEJJFIMDNA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x927480", Offset = "0x925E80", VA = "0x180927480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[KEFMDJAGLBH(IGKCNDFEDMC.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, MABFCBAKEGH, NNBALKKOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string NAHBHPJPCFC = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private BCAJFADIEBJ GFHEAAHHEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GEEJJFIMDNA AGGJCDBCIGG;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public GEEJJFIMDNA PAGAMJKGOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x41BBF90", Offset = "0x41BA990", VA = "0x1841BBF90", Slot = "15")]
			get
			{
				return default(GEEJJFIMDNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public GAIECBKNDJB HMIBJCBNLDB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x41BC040", Offset = "0x41BAA40", VA = "0x1841BC040", Slot = "6")]
			get
			{
				return default(GAIECBKNDJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool FFCJMMOGLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x41BBF80", Offset = "0x41BA980", VA = "0x1841BBF80", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public BCAJFADIEBJ OHGHBJNJDJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9486B0", Offset = "0x9470B0", VA = "0x1809486B0", Slot = "7")]
			get
			{
				return default(BCAJFADIEBJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private BDHPOBELMCM AGGKBGIFNMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x41BB780", Offset = "0x41BA180", VA = "0x1841BB780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private FADNPGGGOHC IECDECKBDHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x41BB630", Offset = "0x41BA030", VA = "0x1841BB630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool MFDNFHGACPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> FKALKNDIOJB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x41BBE40", Offset = "0x41BA840", VA = "0x1841BBE40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x41BC070", Offset = "0x41BAA70", VA = "0x1841BC070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<MABFCBAKEGH> IGPCNEKLODK
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x41BBEE0", Offset = "0x41BA8E0", VA = "0x1841BBEE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x41BC110", Offset = "0x41BAB10", VA = "0x1841BC110", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x41BB4B0", Offset = "0x41B9EB0", VA = "0x1841BB4B0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x41BBCA0", Offset = "0x41BA6A0", VA = "0x1841BBCA0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x41BB950", Offset = "0x41BA350", VA = "0x1841BB950", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x41BBC10", Offset = "0x41BA610", VA = "0x1841BBC10", Slot = "10")]
		public void OnEmbody(BJJPOMIINDM ENGIGCMGHCJ, GEEJJFIMDNA AGGJCDBCIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x41BBC90", Offset = "0x41BA690", VA = "0x1841BBC90", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x41BBA00", Offset = "0x41BA400", VA = "0x1841BBA00", Slot = "12")]
		public void OnDisembody(bool NIEBFBJBENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x41BB3B0", Offset = "0x41B9DB0", VA = "0x1841BB3B0")]
		private void AGHABHFGCPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x41BB860", Offset = "0x41BA260", VA = "0x1841BB860")]
		private void NKILAKLBNAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x41BB690", Offset = "0x41BA090", VA = "0x1841BB690")]
		private void GJHJLCDCDPI(bool CNFALJGNOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x41BB8F0", Offset = "0x41BA2F0", VA = "0x1841BB8F0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x16D1F10", Offset = "0x16D0910", VA = "0x1816D1F10", Slot = "9")]
		private GameObject FIENGLIGOEL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[KEFMDJAGLBH(IGKCNDFEDMC.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override IMJFJJBFBGO GNAMFIEKOJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3D1D510", Offset = "0x3D1BF10", VA = "0x183D1D510", Slot = "6")]
			get
			{
				return default(IMJFJJBFBGO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D4B0", Offset = "0x3D1BEB0", VA = "0x183D1D4B0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[KEFMDJAGLBH(IGKCNDFEDMC.Registration)]
	public class TransformEntity : MonoBehaviour, NNBALKKOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private IMJFJJBFBGO prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GEEJJFIMDNA BJLPLHMBBOJ;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual IMJFJJBFBGO GNAMFIEKOJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550", Slot = "6")]
			get
			{
				return default(IMJFJJBFBGO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x767540", Offset = "0x765F40", VA = "0x180767540", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GEEJJFIMDNA PAGAMJKGOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x94C330", Offset = "0x94AD30", VA = "0x18094C330", Slot = "5")]
			get
			{
				return default(GEEJJFIMDNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool FFCJMMOGLGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x83BFA0", Offset = "0x83A9A0", VA = "0x18083BFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity ODKCGNNLJHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal HLNKJMLPBIB MOLFCDPLHOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal FADNPGGGOHC DMMLNFPPBEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3D2BA50", Offset = "0x3D2A450", VA = "0x183D2BA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B950", Offset = "0x3D2A350", VA = "0x183D2B950")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B960", Offset = "0x3D2A360", VA = "0x183D2B960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BB60", Offset = "0x3D2A560", VA = "0x183D2BB60")]
		internal void NCBKDFJCMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BAC0", Offset = "0x3D2A4C0", VA = "0x183D2BAC0")]
		private bool JHOJKBIKDOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BE70", Offset = "0x3D2A870", VA = "0x183D2BE70")]
		private void OFIDGOFDOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B960", Offset = "0x3D2A360", VA = "0x183D2B960")]
		internal void CFLDMNJOPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BEA0", Offset = "0x3D2A8A0", VA = "0x183D2BEA0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BF80", Offset = "0x3D2A980", VA = "0x183D2BF80")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[LHOECCIDBFM(typeof(DILAHLBHIHJ), new string[] { })]
[LDLOFIJMJIF(typeof(DPFFGIGBPCD))]
public class BNBODMLFEEL : DILAHLBHIHJ, LKLIJPNGPEG, DPFFGIGBPCD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private BHMKMNJJKHN CFMBBKOCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BDHPOBELMCM DILFFHKMEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OGJECELGDOJ FAMLIKPHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KMHGJLFLHBE DDBABGPNIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KFBIJLDIPKJ BAOOFNPBDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NMKFHPDLPMA DJJMBHDOIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public BHMKMNJJKHN LHGMMJHJKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public OGJECELGDOJ CNLJCAAJBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BDHPOBELMCM AGGKBGIFNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KFBIJLDIPKJ JOPHFIDCFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NMKFHPDLPMA ODCHEONMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FKIMOIOBPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84CCD0", Offset = "0x84B6D0", VA = "0x18084CCD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CFHHAFMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DAF0", Offset = "0x3E7C4F0", VA = "0x183E7DAF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KHAIGNDBJNC FJBFKNJMOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xDD13C0", Offset = "0xDCFDC0", VA = "0x180DD13C0", Slot = "10")]
		get
		{
			return default(KHAIGNDBJNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DC50", Offset = "0x3E7C650", VA = "0x183E7DC50")]
	public static BNBODMLFEEL KMLFLFAGFOK(BHMKMNJJKHN CFMBBKOCIHK, ECPHGMOFBIF HHNNPAGKLBL = ECPHGMOFBIF.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void FPAABEGDOBO(BHMKMNJJKHN CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void JPLHJAGGDFC(BHMKMNJJKHN CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DB00", Offset = "0x3E7C500", VA = "0x183E7DB00", Slot = "11")]
	public void JBEIDPFKLNB(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x327B8F0", Offset = "0x327A2F0", VA = "0x18327B8F0")]
	private void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DD40", Offset = "0x3E7C740", VA = "0x183E7DD40")]
	private void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DA90", Offset = "0x3E7C490", VA = "0x183E7DA90", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public BNBODMLFEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ELCLGDNJOIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x41B9CF0", Offset = "0x41B86F0", VA = "0x1841B9CF0")]
	public static GAIECBKNDJB LGBJNNJPIFB(this DILAHLBHIHJ GHJONFLCPJJ, ANIMKGBLAIA BBILPABEHHM, IMJFJJBFBGO FPPOGBDGFJM)
	{
		return default(GAIECBKNDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x41B9BD0", Offset = "0x41B85D0", VA = "0x1841B9BD0")]
	public static GCEOCEIHGKK HGCGALMGNBK(this DILAHLBHIHJ GHJONFLCPJJ)
	{
		return default(GCEOCEIHGKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x41B9F60", Offset = "0x41B8960", VA = "0x1841B9F60")]
	public static GEEJJFIMDNA ONPEFMCCMDC(this DILAHLBHIHJ GHJONFLCPJJ, Entity OOGAMDNOHNH)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x41B9E30", Offset = "0x41B8830", VA = "0x1841B9E30")]
	public static GEEJJFIMDNA ONPEFMCCMDC(this DILAHLBHIHJ GHJONFLCPJJ, ANIMKGBLAIA BBILPABEHHM)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x41B9AB0", Offset = "0x41B84B0", VA = "0x1841B9AB0")]
	public static ANIMKGBLAIA GNIDCGFLOEL(this DILAHLBHIHJ GHJONFLCPJJ, GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(ANIMKGBLAIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum ECPHGMOFBIF
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[LHOECCIDBFM(typeof(NMKFHPDLPMA), new string[] { })]
public class HKDLBKCLENJ : NMKFHPDLPMA, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[JLCJNHHCBDK]
	private DPFFGIGBPCD OPAHKFOPLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private BHMKMNJJKHN CFMBBKOCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private KBKLGJJJAII BAOOFNPBDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private KMHGJLFLHBE DDBABGPNIJD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action LJIAJGPPOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x41C5C60", Offset = "0x41C4660", VA = "0x1841C5C60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x41C5F70", Offset = "0x41C4970", VA = "0x1841C5F70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x41C6070", Offset = "0x41C4A70", VA = "0x1841C6070", Slot = "16")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x41C5F30", Offset = "0x41C4930", VA = "0x1841C5F30", Slot = "13")]
	public void HONPKNDJMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "6")]
	public void AJHPNAGEAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x41C5C10", Offset = "0x41C4610", VA = "0x1841C5C10", Slot = "7")]
	public void ACPMCNDFCDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x41C5EB0", Offset = "0x41C48B0", VA = "0x1841C5EB0", Slot = "8")]
	public void HLDHLLEJONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x19E4AD0", Offset = "0x19E34D0", VA = "0x1819E4AD0", Slot = "9")]
	public void KKCLIMBKMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x41C5E60", Offset = "0x41C4860", VA = "0x1841C5E60", Slot = "10")]
	public void GBIONFMEDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x41C5DA0", Offset = "0x41C47A0", VA = "0x1841C5DA0", Slot = "11")]
	public bool EJAFDEINJBC(IEnumerable<OOFJJCAIBIL> KCFFMLPOBOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x41C5D00", Offset = "0x41C4700", VA = "0x1841C5D00", Slot = "12")]
	public void CBPHENPICMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x41C5D50", Offset = "0x41C4750", VA = "0x1841C5D50", Slot = "14")]
	public void DECDBMFBECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x41C6010", Offset = "0x41C4A10", VA = "0x1841C6010", Slot = "15")]
	public void MFMHHOICKCE(bool MIIMMBAPGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x41C6120", Offset = "0x41C4B20", VA = "0x1841C6120")]
	private void NALBAAKMDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public HKDLBKCLENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[LHOECCIDBFM(typeof(KFBIJLDIPKJ), new string[] { })]
public class DOIOJJKMALM : KFBIJLDIPKJ, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[JLCJNHHCBDK]
	private DPFFGIGBPCD OPAHKFOPLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BHMKMNJJKHN CFMBBKOCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KBKLGJJJAII BAOOFNPBDNG;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E912A0", Offset = "0x3E8FCA0", VA = "0x183E912A0", Slot = "6")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E911E0", Offset = "0x3E8FBE0", VA = "0x183E911E0", Slot = "4")]
	public ByteString HGLHKADDNFF(out IDisposable EEFLDHEOOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E910C0", Offset = "0x3E8FAC0", VA = "0x183E910C0", Slot = "5")]
	public void AIBDMMJCKEC(ByteString MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public DOIOJJKMALM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class MHDDDLDPKOK<T> : global::DDEOEODMEDC<T>, global::PGLJFENHHHK<ANIMKGBLAIA, T>, global::MANFACHOAEB<ANIMKGBLAIA>, CIMCFICPKBP, IDisposable, LEECANKHNKH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::MANFACHOAEB<Entity> EELLPGLCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate PMELEFEKLKE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string KPDCCEJPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF1D0", Offset = "0x4EADBD0", VA = "0x184EAF1D0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type EFFMKCNPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4EB6C40", Offset = "0x4EB5640", VA = "0x184EB6C40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JPCNDAPLHKB FCBCGNBDHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2C60", Offset = "0x4EB1660", VA = "0x184EB2C60", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int HMBLLKPMBML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2800", Offset = "0x4EB1200", VA = "0x184EB2800", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LFKCGKDLEAH KJGMJKEEHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4EBC1B0", Offset = "0x4EBABB0", VA = "0x184EBC1B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2691170", Offset = "0x268FB70", VA = "0x182691170", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4EBC590", Offset = "0x4EBAF90", VA = "0x184EBC590", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::IFBOCMEHDCC<ANIMKGBLAIA> MGPMICPPGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2330", Offset = "0x4EB0D30", VA = "0x184EB2330", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2FF0", Offset = "0x4EB19F0", VA = "0x184EB2FF0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4524690", Offset = "0x4523090", VA = "0x184524690")]
	public MHDDDLDPKOK(global::MANFACHOAEB<Entity> EELLPGLCOLL, HLNKJMLPBIB BMDIGEODPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4EC1680", Offset = "0x4EC0080", VA = "0x184EC1680")]
	private Entity PLBJOAHNOPL(ANIMKGBLAIA BBILPABEHHM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4EC1330", Offset = "0x4EBFD30", VA = "0x184EC1330")]
	private ANIMKGBLAIA PLBJOAHNOPL(Entity OOGAMDNOHNH)
	{
		return default(ANIMKGBLAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4EA9520", Offset = "0x4EA7F20", VA = "0x184EA9520", Slot = "4")]
	public T ABMJNALEGDK(ANIMKGBLAIA BBILPABEHHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD750", Offset = "0x4EAC150", VA = "0x184EAD750")]
	public bool CKIEIOOCMAM(ANIMKGBLAIA BBILPABEHHM, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5840", Offset = "0x4EB4240", VA = "0x184EB5840")]
	public bool LLDALNCOJAF(ANIMKGBLAIA BBILPABEHHM, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4EC12A0", Offset = "0x4EBFCA0", VA = "0x184EC12A0", Slot = "9")]
	public bool OJCAMDKMMGI(ANIMKGBLAIA BBILPABEHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF400", Offset = "0x4EADE00", VA = "0x184EAF400", Slot = "26")]
	public object FCHAOJGHKLO(ANIMKGBLAIA BBILPABEHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3640", Offset = "0x4EC2040", VA = "0x184EC3640")]
	public bool PPIIPILIAIB(ANIMKGBLAIA BBILPABEHHM, in object LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8020", Offset = "0x4EA6A20", VA = "0x184EA8020")]
	public void ABMJNALEGDK(ANIMKGBLAIA BBILPABEHHM, in PGINEPENLDH MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD1E0", Offset = "0x4EABBE0", VA = "0x184EAD1E0")]
	public bool CKIEIOOCMAM(ANIMKGBLAIA BBILPABEHHM, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4EB59E0", Offset = "0x4EB43E0", VA = "0x184EB59E0")]
	public bool LLDALNCOJAF(ANIMKGBLAIA BBILPABEHHM, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x451C9D0", Offset = "0x451B3D0", VA = "0x18451C9D0", Slot = "22")]
	public void MDLBBNFEBPN(EOLIEJMIFHF FDBMBDCEONF, [Optional] object BKJKDPLKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8640", Offset = "0x4EB7040", VA = "0x184EB8640", Slot = "15")]
	public void MDLBBNFEBPN(ANIMKGBLAIA IGFDDANAMMH, ODPNBOHGFMI FDBMBDCEONF, object BKJKDPLKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3B20", Offset = "0x4EB2520", VA = "0x184EB3B20", Slot = "14")]
	public bool KCMGAHNKFOP(ANIMKGBLAIA KHLDFPNJEFH, ANIMKGBLAIA EHFHEFGEMIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x347CDC0", Offset = "0x347B7C0", VA = "0x18347CDC0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4EC4240", Offset = "0x4EC2C40", VA = "0x184EC4240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4EB41D0", Offset = "0x4EB2BD0", VA = "0x184EB41D0")]
	public string KJFLIDJFKCI(in ABKAKFBNEMO HFPCICJINOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC2C0", Offset = "0x4EAACC0", VA = "0x184EAC2C0")]
	private void BNNAOPMLJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4EAFBD0", Offset = "0x4EAE5D0", VA = "0x184EAFBD0")]
	private void FNLFAOIBFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4EBCF70", Offset = "0x4EBB970", VA = "0x184EBCF70")]
	private void OGEJNBJDCNB(Entity OOGAMDNOHNH, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4630", Offset = "0x4EB3030", VA = "0x184EB4630")]
	private void KOKJPGEBJEA(Entity OOGAMDNOHNH, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA810", Offset = "0x4EB9210", VA = "0x184EBA810")]
	[Conditional("DEBUG_BUILD")]
	private static void MDMKKCBLGOG(Entity OOGAMDNOHNH, ANIMKGBLAIA BBILPABEHHM, string IDLOFIFEDHN, string LLAHCDOPJLF, [CallerMemberName] string CLHMOFNICGC = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x46B47A0", Offset = "0x46B31A0", VA = "0x1846B47A0", Slot = "5")]
	private bool KDIKMGENIBA(ANIMKGBLAIA IGFDDANAMMH, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x46B4C00", Offset = "0x46B3600", VA = "0x1846B4C00", Slot = "6")]
	private bool NKAAOOMFHFD(ANIMKGBLAIA IGFDDANAMMH, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x32BCD30", Offset = "0x32BB730", VA = "0x1832BCD30", Slot = "10")]
	private bool NKKHEODPCGB(ANIMKGBLAIA IGFDDANAMMH, in object LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4EACFE0", Offset = "0x4EAB9E0", VA = "0x184EACFE0", Slot = "11")]
	private void CFEFGFDEFOD(ANIMKGBLAIA IGFDDANAMMH, in PGINEPENLDH MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD010", Offset = "0x4EABA10", VA = "0x184EAD010", Slot = "12")]
	private bool CICALMPBHNN(ANIMKGBLAIA IGFDDANAMMH, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC520", Offset = "0x4EBAF20", VA = "0x184EBC520", Slot = "13")]
	private bool NMKIBEMIJMI(ANIMKGBLAIA IGFDDANAMMH, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4522340", Offset = "0x4520D40", VA = "0x184522340", Slot = "16")]
	private string NDLFIHFABBK(in ABKAKFBNEMO MFBGAMJDOKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class MMEKELGLLBO<T> : global::KOCKALKNOHE<T>, global::PGLJFENHHHK<GEEJJFIMDNA, T>, global::MANFACHOAEB<GEEJJFIMDNA>, CIMCFICPKBP, IDisposable, KHBNAMDANEI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::MANFACHOAEB<Entity> EELLPGLCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate PMELEFEKLKE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string KPDCCEJPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x59D6400", Offset = "0x59D4E00", VA = "0x1859D6400", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type EFFMKCNPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x59DEF00", Offset = "0x59DD900", VA = "0x1859DEF00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public JPCNDAPLHKB FCBCGNBDHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x59DA9F0", Offset = "0x59D93F0", VA = "0x1859DA9F0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int HMBLLKPMBML
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x59DA130", Offset = "0x59D8B30", VA = "0x1859DA130", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LFKCGKDLEAH KJGMJKEEHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x59E14F0", Offset = "0x59DFEF0", VA = "0x1859E14F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4515CF0", Offset = "0x45146F0", VA = "0x184515CF0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x451E2D0", Offset = "0x451CCD0", VA = "0x18451E2D0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::IFBOCMEHDCC<GEEJJFIMDNA> MGPMICPPGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x59D9AC0", Offset = "0x59D84C0", VA = "0x1859D9AC0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x59DB040", Offset = "0x59D9A40", VA = "0x1859DB040", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4524690", Offset = "0x4523090", VA = "0x184524690")]
	public MMEKELGLLBO(global::MANFACHOAEB<Entity> EELLPGLCOLL, HLNKJMLPBIB BMDIGEODPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F5E0", Offset = "0x2F0DFE0", VA = "0x182F0F5E0")]
	private Entity PLBJOAHNOPL(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4522370", Offset = "0x4520D70", VA = "0x184522370")]
	private GEEJJFIMDNA PLBJOAHNOPL(Entity OOGAMDNOHNH)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x59CEB90", Offset = "0x59CD590", VA = "0x1859CEB90", Slot = "4")]
	public T ABMJNALEGDK(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x59D4890", Offset = "0x59D3290", VA = "0x1859D4890")]
	public bool CKIEIOOCMAM(GEEJJFIMDNA BJLPLHMBBOJ, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x59DD5F0", Offset = "0x59DBFF0", VA = "0x1859DD5F0")]
	public bool LLDALNCOJAF(GEEJJFIMDNA BJLPLHMBBOJ, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x59E6EC0", Offset = "0x59E58C0", VA = "0x1859E6EC0", Slot = "9")]
	public bool OJCAMDKMMGI(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4515A20", Offset = "0x4514420", VA = "0x184515A20", Slot = "26")]
	public object FCHAOJGHKLO(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x59E89D0", Offset = "0x59E73D0", VA = "0x1859E89D0")]
	public bool PPIIPILIAIB(GEEJJFIMDNA BJLPLHMBBOJ, in object LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x59CF490", Offset = "0x59CDE90", VA = "0x1859CF490")]
	public void ABMJNALEGDK(GEEJJFIMDNA BJLPLHMBBOJ, in PGINEPENLDH MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4514190", Offset = "0x4512B90", VA = "0x184514190")]
	public bool CKIEIOOCMAM(GEEJJFIMDNA BJLPLHMBBOJ, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x451AC20", Offset = "0x4519620", VA = "0x18451AC20")]
	public bool LLDALNCOJAF(GEEJJFIMDNA BJLPLHMBBOJ, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x451C9D0", Offset = "0x451B3D0", VA = "0x18451C9D0", Slot = "22")]
	public void MDLBBNFEBPN(EOLIEJMIFHF FDBMBDCEONF, [Optional] object BKJKDPLKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x59E0800", Offset = "0x59DF200", VA = "0x1859E0800", Slot = "15")]
	public void MDLBBNFEBPN(GEEJJFIMDNA IGFDDANAMMH, ODPNBOHGFMI FDBMBDCEONF, object BKJKDPLKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4519570", Offset = "0x4517F70", VA = "0x184519570", Slot = "14")]
	public bool KCMGAHNKFOP(GEEJJFIMDNA KHLDFPNJEFH, GEEJJFIMDNA EHFHEFGEMIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x59D1DF0", Offset = "0x59D07F0", VA = "0x1859D1DF0")]
	private void BNNAOPMLJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x59D8450", Offset = "0x59D6E50", VA = "0x1859D8450")]
	private void FNLFAOIBFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x59E3E20", Offset = "0x59E2820", VA = "0x1859E3E20")]
	private void OGEJNBJDCNB(Entity OOGAMDNOHNH, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x59DC3E0", Offset = "0x59DADE0", VA = "0x1859DC3E0")]
	private void KOKJPGEBJEA(Entity OOGAMDNOHNH, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4515940", Offset = "0x4514340", VA = "0x184515940", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x59EA3E0", Offset = "0x59E8DE0", VA = "0x1859EA3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4EB41D0", Offset = "0x4EB2BD0", VA = "0x184EB41D0")]
	public string KJFLIDJFKCI(in ABKAKFBNEMO HFPCICJINOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4515970", Offset = "0x4514370", VA = "0x184515970", Slot = "5")]
	private bool EIDHMKJMHPK(GEEJJFIMDNA IGFDDANAMMH, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x451DE00", Offset = "0x451C800", VA = "0x18451DE00", Slot = "6")]
	private bool MFDDCAOLFOI(GEEJJFIMDNA IGFDDANAMMH, in T LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x451E250", Offset = "0x451CC50", VA = "0x18451E250", Slot = "10")]
	private bool OBFOCHGODIC(GEEJJFIMDNA IGFDDANAMMH, in object LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x451A8F0", Offset = "0x45192F0", VA = "0x18451A8F0", Slot = "11")]
	private void LIHDMOKJOKD(GEEJJFIMDNA IGFDDANAMMH, in PGINEPENLDH MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x451C990", Offset = "0x451B390", VA = "0x18451C990", Slot = "12")]
	private bool LOMONIFOEDP(GEEJJFIMDNA IGFDDANAMMH, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4511D30", Offset = "0x4510730", VA = "0x184511D30", Slot = "13")]
	private bool BIKCBMDHLMC(GEEJJFIMDNA IGFDDANAMMH, in ABKAKFBNEMO LMBBEFCIFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4522340", Offset = "0x4520D40", VA = "0x184522340", Slot = "16")]
	private string PBLJPNMDLIP(in ABKAKFBNEMO MFBGAMJDOKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FMBDLOIJKOL : IDisposable, OEIOFGPKKAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> FEODMODAEDI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> JGAINCLKIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8B9650", Offset = "0x8B8050", VA = "0x1808B9650", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1A6E300", Offset = "0x1A6CD00", VA = "0x181A6E300")]
	public FMBDLOIJKOL(NativeArray<EntityRemapUtility.EntityRemapInfo> FEODMODAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x41C25E0", Offset = "0x41C0FE0", VA = "0x1841C25E0", Slot = "6")]
	public GEEJJFIMDNA NJABMKLDCPK(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x41C2630", Offset = "0x41C1030", VA = "0x1841C2630", Slot = "7")]
	public Entity NJABMKLDCPK(Entity OOGAMDNOHNH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x41C2640", Offset = "0x41C1040", VA = "0x1841C2640", Slot = "8")]
	public IEnumerable<GEEJJFIMDNA> NJABMKLDCPK(IEnumerable<GEEJJFIMDNA> NACGECFJEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x41C2580", Offset = "0x41C0F80", VA = "0x1841C2580", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly NNLEPLPFODN PMKIGGGFLMH;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int BHKIDJHCINB;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static OEIOFGPKKAF KDHEAEHHPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool EHLNJADOFMP;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> JGAINCLKIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x3D241B0", Offset = "0x3D22BB0", VA = "0x183D241B0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool OKEHHLKIOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x3D23FB0", Offset = "0x3D229B0", VA = "0x183D23FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3D24150", Offset = "0x3D22B50", VA = "0x183D24150")]
		public static SerializationRemapScope HGJPBPDDPPG()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3D245E0", Offset = "0x3D22FE0", VA = "0x183D245E0")]
		public SerializationRemapScope(OEIOFGPKKAF PFMOKPGJJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3D24040", Offset = "0x3D22A40", VA = "0x183D24040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3D243F0", Offset = "0x3D22DF0", VA = "0x183D243F0")]
		public static GEEJJFIMDNA NJABMKLDCPK(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3D242C0", Offset = "0x3D22CC0", VA = "0x183D242C0")]
		public static Entity NJABMKLDCPK(Entity OOGAMDNOHNH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[POJCHFKPLOJ(PFPBFPDNLIO.Application)]
[LHOECCIDBFM(typeof(BOCINCLMFIH), new string[] { "Editor" })]
public sealed class BOCINCLMFIH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void BFLMIKJBNJL(ANIMKGBLAIA BOBFJDPJKIF, PKJIFCGPPAP MNILNHMNKJK, bool CLCICFECGID);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void EFABJKFJNAC(ANIMKGBLAIA BOBFJDPJKIF, bool CLCICFECGID);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void NPBDFPAGKII(ANIMKGBLAIA BOBFJDPJKIF, KOPBFNLIDKA EELLPGLCOLL, in ABKAKFBNEMO MFBGAMJDOKA, bool CLCICFECGID);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BFLMIKJBNJL HLNBBDLCIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DEF0", Offset = "0x3E7C8F0", VA = "0x183E7DEF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E060", Offset = "0x3E7CA60", VA = "0x183E7E060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event EFABJKFJNAC ONJKKNFGLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E100", Offset = "0x3E7CB00", VA = "0x183E7E100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DF90", Offset = "0x3E7C990", VA = "0x183E7DF90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event NPBDFPAGKII DGNGJKIPMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E240", Offset = "0x3E7CC40", VA = "0x183E7E240")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E1A0", Offset = "0x3E7CBA0", VA = "0x183E7E1A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DED0", Offset = "0x3E7C8D0", VA = "0x183E7DED0")]
	[Conditional("UNITY_EDITOR")]
	public void BIFEMDNOGON(ANIMKGBLAIA BOBFJDPJKIF, in PKJIFCGPPAP MNILNHMNKJK, bool CLCICFECGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DEB0", Offset = "0x3E7C8B0", VA = "0x183E7DEB0")]
	[Conditional("UNITY_EDITOR")]
	public void BCPIFEDKJDD(ANIMKGBLAIA BOBFJDPJKIF, bool CLCICFECGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E030", Offset = "0x3E7CA30", VA = "0x183E7E030")]
	[Conditional("UNITY_EDITOR")]
	public void DFNIFJOPAAB(ANIMKGBLAIA BOBFJDPJKIF, KOPBFNLIDKA EELLPGLCOLL, in ABKAKFBNEMO MFBGAMJDOKA, bool CLCICFECGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public BOCINCLMFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[LHOECCIDBFM(typeof(INPDPGIAJAM), new string[] { "Editor" })]
[POJCHFKPLOJ(PFPBFPDNLIO.Application)]
public sealed class INPDPGIAJAM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void ECDJNAONMGB(ANIMKGBLAIA BBILPABEHHM, PKJIFCGPPAP MNILNHMNKJK, bool CLCICFECGID);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void HJNBLMNCIFE(ANIMKGBLAIA BBILPABEHHM, bool CLCICFECGID);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void BPOFGPCGPKL(ANIMKGBLAIA BBILPABEHHM, KOPBFNLIDKA EELLPGLCOLL, in ABKAKFBNEMO MFBGAMJDOKA, bool CLCICFECGID, bool DNJHAFHGBHD);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void OPMFBJDJIIL(ANIMKGBLAIA BBILPABEHHM, KOPBFNLIDKA EELLPGLCOLL, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void CIGHCBIPPBF(JOMAPBNPCNH IGFDDANAMMH, ReadOnlyMemory<byte> CBBKOHPGNJD);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> PAGOKBAPJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x41CACD0", Offset = "0x41C96D0", VA = "0x1841CACD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x41CB4E0", Offset = "0x41C9EE0", VA = "0x1841CB4E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> PMNIKJIJCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x41CAF30", Offset = "0x41C9930", VA = "0x1841CAF30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x41CB640", Offset = "0x41CA040", VA = "0x1841CB640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event ECDJNAONMGB HLNBBDLCIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x41CAD90", Offset = "0x41C9790", VA = "0x1841CAD90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x41CB290", Offset = "0x41C9C90", VA = "0x1841CB290")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event HJNBLMNCIFE ONJKKNFGLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x41CB440", Offset = "0x41C9E40", VA = "0x1841CB440")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x41CAE30", Offset = "0x41C9830", VA = "0x1841CAE30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event ECDJNAONMGB MLNMLGHNEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x41CB330", Offset = "0x41C9D30", VA = "0x1841CB330")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x41CBA80", Offset = "0x41CA480", VA = "0x1841CBA80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event HJNBLMNCIFE IOKCONAMKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x41CB730", Offset = "0x41CA130", VA = "0x1841CB730")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x41CB800", Offset = "0x41CA200", VA = "0x1841CB800")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event BPOFGPCGPKL DGNGJKIPMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x41CB9E0", Offset = "0x41CA3E0", VA = "0x1841CB9E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x41CB940", Offset = "0x41CA340", VA = "0x1841CB940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event OPMFBJDJIIL JKCOLDPLIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x41CABE0", Offset = "0x41C95E0", VA = "0x1841CABE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x41CB1F0", Offset = "0x41C9BF0", VA = "0x1841CB1F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> DGFDIKJALOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x41CB120", Offset = "0x41C9B20", VA = "0x1841CB120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x41CB8A0", Offset = "0x41CA2A0", VA = "0x1841CB8A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event CIGHCBIPPBF PCMLONKPADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x41CB080", Offset = "0x41C9A80", VA = "0x1841CB080")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x41CB5A0", Offset = "0x41C9FA0", VA = "0x1841CB5A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x41CB700", Offset = "0x41CA100", VA = "0x1841CB700")]
	[Conditional("UNITY_EDITOR")]
	public void MDNJJOIPIPO(ANIMKGBLAIA BBILPABEHHM, in PKJIFCGPPAP MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x41CABC0", Offset = "0x41C95C0", VA = "0x1841CABC0")]
	[Conditional("UNITY_EDITOR")]
	public void AEEIAGOBKHB(ANIMKGBLAIA BBILPABEHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x41CB7D0", Offset = "0x41CA1D0", VA = "0x1841CB7D0")]
	[Conditional("UNITY_EDITOR")]
	public void NJIHCLEEOFL(ANIMKGBLAIA BBILPABEHHM, in PKJIFCGPPAP MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x41CAC80", Offset = "0x41C9680", VA = "0x1841CAC80")]
	[Conditional("UNITY_EDITOR")]
	public void BGDDLLLJEDE(ANIMKGBLAIA BBILPABEHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x41CACA0", Offset = "0x41C96A0", VA = "0x1841CACA0")]
	[Conditional("UNITY_EDITOR")]
	public void BMPBKJBMAOB(ANIMKGBLAIA BBILPABEHHM, KOPBFNLIDKA EELLPGLCOLL, in ABKAKFBNEMO MFBGAMJDOKA, bool DNJHAFHGBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x41CAFF0", Offset = "0x41C99F0", VA = "0x1841CAFF0")]
	[Conditional("UNITY_EDITOR")]
	public void DHPFHNGGAKI(ANIMKGBLAIA BBILPABEHHM, KOPBFNLIDKA EELLPGLCOLL, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x41CAED0", Offset = "0x41C98D0", VA = "0x1841CAED0")]
	[Conditional("UNITY_EDITOR")]
	public void DBLBFDEKHOP(string KMEGKECOLPJ, object CBBKOHPGNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x41CB1C0", Offset = "0x41C9BC0", VA = "0x1841CB1C0")]
	[Conditional("UNITY_EDITOR")]
	public void GENBODOBBKG(JOMAPBNPCNH IGFDDANAMMH, ReadOnlyMemory<byte> CBBKOHPGNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x41CB010", Offset = "0x41C9A10", VA = "0x1841CB010")]
	[Conditional("UNITY_EDITOR")]
	public void EECKOLEDECG(World ENGIGCMGHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x41CB3D0", Offset = "0x41C9DD0", VA = "0x1841CB3D0")]
	[Conditional("UNITY_EDITOR")]
	public void KIEJNPAOCPC(World ENGIGCMGHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public INPDPGIAJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[LHOECCIDBFM(typeof(EDCEKGOPOAA), new string[] { })]
public class CENMBNPIBKN : EDCEKGOPOAA
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3E813E0", Offset = "0x3E7FDE0", VA = "0x183E813E0", Slot = "5")]
	public void EDCCCOFLBBL(object MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3E812F0", Offset = "0x3E7FCF0", VA = "0x183E812F0", Slot = "6")]
	public void CKAGHIACGNG(object MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3E814D0", Offset = "0x3E7FED0", VA = "0x183E814D0", Slot = "7")]
	public void FKCANDBGJGO(object MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3E811D0", Offset = "0x3E7FBD0", VA = "0x183E811D0", Slot = "4")]
	public IDisposable CGNGKOODJPA(object MDEEJIBNIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public CENMBNPIBKN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	[LHOECCIDBFM(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	internal class BulkInstantiateSceneObjectService : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string BEBIDOGMHNN = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[JLCJNHHCBDK]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[JLCJNHHCBDK]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[JLCJNHHCBDK]
		private FADNPGGGOHC FBHAGLEGMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery JKIHANNFJJI;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3E7E770", Offset = "0x3E7D170", VA = "0x183E7E770")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FE10", Offset = "0x3E7E810", VA = "0x183E7FE10", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EB20", Offset = "0x3E7D520", VA = "0x183E7EB20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EBD0", Offset = "0x3E7D5D0", VA = "0x183E7EBD0")]
		public bool EJAFDEINJBC(IEnumerable<OOFJJCAIBIL> DBGLNKGFJPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E660", Offset = "0x3E7D060", VA = "0x183E7E660")]
		public static bool CAPNIAJACML(OOFJJCAIBIL CEKCHJKLGMA, out ANIMKGBLAIA BBILPABEHHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E2E0", Offset = "0x3E7CCE0", VA = "0x183E7E2E0")]
		private void BGJNDHFMNPM(Dictionary<ANIMKGBLAIA, OOFJJCAIBIL> IAGLEADCODA, IEnumerable<OOFJJCAIBIL> DBGLNKGFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7FF90", Offset = "0x3E7E990", VA = "0x183E7FF90")]
		private void NLOMECNMAFB(Dictionary<ANIMKGBLAIA, OOFJJCAIBIL> IAGLEADCODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EF20", Offset = "0x3E7D920", VA = "0x183E7EF20")]
		private void IGMJHLMFFIK(Dictionary<ANIMKGBLAIA, OOFJJCAIBIL> IAGLEADCODA, ANIMKGBLAIA BBILPABEHHM, string KMEGKECOLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E7C0", Offset = "0x3E7D1C0", VA = "0x183E7E7C0")]
		private void DLFGOLCGAJE(Dictionary<ANIMKGBLAIA, OOFJJCAIBIL> IAGLEADCODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F570", Offset = "0x3E7DF70", VA = "0x183E7F570")]
		private void JEFIHBCHAIG(Dictionary<ANIMKGBLAIA, OOFJJCAIBIL> IAGLEADCODA, List<OOFJJCAIBIL> GIJFOBBKHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F3A0", Offset = "0x3E7DDA0", VA = "0x183E7F3A0")]
		private NativeList<ANIMKGBLAIA> IKDKPGEPHPC(Dictionary<ANIMKGBLAIA, OOFJJCAIBIL> IAGLEADCODA)
		{
			return default(NativeList<ANIMKGBLAIA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3E7ED50", Offset = "0x3E7D750", VA = "0x183E7ED50")]
		private NativeArray<Entity> EJHDMEKLMPM(NativeList<ANIMKGBLAIA> APAOHHKGPHG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EB30", Offset = "0x3E7D530", VA = "0x183E7EB30")]
		private static void ECBMGCECELI(Dictionary<ANIMKGBLAIA, OOFJJCAIBIL> IAGLEADCODA, ANIMKGBLAIA BBILPABEHHM, OOFJJCAIBIL CEKCHJKLGMA, string KMEGKECOLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[POJCHFKPLOJ(PFPBFPDNLIO.Application)]
	[LHOECCIDBFM(typeof(DebugWorldsService), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool CFHHAFMAFEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3E91A40", Offset = "0x3E90440", VA = "0x183E91A40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x3E91B00", Offset = "0x3E90500", VA = "0x183E91B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool IFDLHLBAFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3E91A80", Offset = "0x3E90480", VA = "0x183E91A80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3E91AC0", Offset = "0x3E904C0", VA = "0x183E91AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public void BGHDJGLNOJL(string KMEGKECOLPJ, EntityManager IMCLABBJAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public static void PDOAHDCGLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LHOECCIDBFM(typeof(KMHGJLFLHBE), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.Application)]
internal class KMHGJLFLHBE
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool CFHHAFMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6AC0", Offset = "0x7E54C0", VA = "0x1807E6AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool DDHLDALIADP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x85E260", Offset = "0x85CC60", VA = "0x18085E260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x957110", Offset = "0x955B10", VA = "0x180957110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KMHGJLFLHBE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[LHOECCIDBFM(typeof(KBKLGJJJAII), new string[] { })]
	[LDLOFIJMJIF(typeof(SerializationService))]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	internal class SerializationService : KBKLGJJJAII, IDisposable, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly NNLEPLPFODN CCJFDKFMPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[JLCJNHHCBDK]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[JLCJNHHCBDK]
		private FHLGOPCDKON EHMMKOFECKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[JLCJNHHCBDK]
		private KMHGJLFLHBE DDBABGPNIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private IBBGAKLJKHN FFEFKJILIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private NMOHGIPDICN FKIOBHIDFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope EEFLDHEOOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? KKICEPAFFPB;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool EKNILOCJCNC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1896C40", Offset = "0x1895640", VA = "0x181896C40", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3D25500", Offset = "0x3D23F00", VA = "0x183D25500", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool LJLMLKABCMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xC00D40", Offset = "0xBFF740", VA = "0x180C00D40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x8303A0", Offset = "0x82EDA0", VA = "0x1808303A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public NMOHGIPDICN NOPJMPGDMGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D261F0", Offset = "0x3D24BF0", VA = "0x183D261F0", Slot = "16")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D24F80", Offset = "0x3D23980", VA = "0x183D24F80", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D26290", Offset = "0x3D24C90", VA = "0x183D26290")]
		public static bool OGMEMNEAHNA(ByteString CEMHLJHECJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB60", Offset = "0x7D9560", VA = "0x1807DAB60")]
		public void CCJPFFKPJLO(IBBGAKLJKHN HFLLMJOKBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D25AF0", Offset = "0x3D244F0", VA = "0x183D25AF0", Slot = "5")]
		public void JAOHAAJBCNJ(bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D25200", Offset = "0x3D23C00", VA = "0x183D25200", Slot = "6")]
		public Task FHBLNMIPOBK(bool CABHIPNEIGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D25830", Offset = "0x3D24230", VA = "0x183D25830", Slot = "7")]
		public ByteString HGLHKADDNFF(out IDisposable EEFLDHEOOBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D25910", Offset = "0x3D24310", VA = "0x183D25910", Slot = "19")]
		public ByteString HGLHKADDNFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D24900", Offset = "0x3D23300", VA = "0x183D24900", Slot = "9")]
		public bool AIBDMMJCKEC(ByteString MFBACCMIPHF, ALBPLHAPEFH HHNNPAGKLBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D25510", Offset = "0x3D23F10", VA = "0x183D25510")]
		private bool HFGPDBMNPLL(ByteString MFBACCMIPHF, ALBPLHAPEFH HHNNPAGKLBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D24BE0", Offset = "0x3D235E0", VA = "0x183D24BE0", Slot = "8")]
		public void CJGBFCBPFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D25290", Offset = "0x3D23C90", VA = "0x183D25290", Slot = "10")]
		public bool GBIONFMEDDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D24F90", Offset = "0x3D23990", VA = "0x183D24F90", Slot = "11")]
		public bool EJAFDEINJBC(IEnumerable<OOFJJCAIBIL> KCFFMLPOBOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D25EB0", Offset = "0x3D248B0", VA = "0x183D25EB0")]
		public bool KNNEFJHIIFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D24960", Offset = "0x3D23360", VA = "0x183D24960", Slot = "12")]
		public bool CBPHENPICMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D24670", Offset = "0x3D23070", VA = "0x183D24670")]
		public void ACBNCDDAMIE(NMOHGIPDICN.HIAKKPGAFDH.JBLPGJNDGHO KJGCDDIEGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D25C20", Offset = "0x3D24620", VA = "0x183D25C20")]
		private bool KKPBFNBJAOL(ByteString MFBACCMIPHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D24B90", Offset = "0x3D23590", VA = "0x183D24B90")]
		private void CGPGPIFLMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D25BC0", Offset = "0x3D245C0", VA = "0x183D25BC0")]
		private ByteString JHNPJEABHCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D25F90", Offset = "0x3D24990", VA = "0x183D25F90")]
		private ByteString LHGMOKKOOCC(ByteString CEMHLJHECJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D260A0", Offset = "0x3D24AA0", VA = "0x183D260A0")]
		private NMOHGIPDICN.HIAKKPGAFDH.JBLPGJNDGHO LJCHAIBFFCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D26590", Offset = "0x3D24F90", VA = "0x183D26590")]
		private void PHMDGLOHBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D24DB0", Offset = "0x3D237B0", VA = "0x183D24DB0", Slot = "13")]
		public bool DECDBMFBECK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D26140", Offset = "0x3D24B40", VA = "0x183D26140", Slot = "14")]
		public void MFMHHOICKCE(bool MIIMMBAPGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D263C0", Offset = "0x3D24DC0", VA = "0x183D263C0")]
		private void PDOAHDCGLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LHOECCIDBFM(typeof(CPIGIOMNEPF), new string[] { })]
[LDLOFIJMJIF(typeof(FHLGOPCDKON))]
internal class FHLGOPCDKON : CPIGIOMNEPF
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action ACPMCNDFCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x41C18C0", Offset = "0x41C02C0", VA = "0x1841C18C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x41C1B90", Offset = "0x41C0590", VA = "0x1841C1B90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<OEIOFGPKKAF> HKODNAJOOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x41C1780", Offset = "0x41C0180", VA = "0x1841C1780", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x41C1AF0", Offset = "0x41C04F0", VA = "0x1841C1AF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action INIAEDMIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x41C1D20", Offset = "0x41C0720", VA = "0x1841C1D20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x41C1C80", Offset = "0x41C0680", VA = "0x1841C1C80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action PIEOPOGAPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x41C1820", Offset = "0x41C0220", VA = "0x1841C1820", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x41C1DC0", Offset = "0x41C07C0", VA = "0x1841C1DC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<OEIOFGPKKAF> HJJAIJFNNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x41C1960", Offset = "0x41C0360", VA = "0x1841C1960", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x41C1A50", Offset = "0x41C0450", VA = "0x1841C1A50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE310", Offset = "0x1DBCD10", VA = "0x181DBE310")]
	public void CJGBFCBPFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x22320F0", Offset = "0x2230AF0", VA = "0x1822320F0")]
	public void JOMDAFNDOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F43F20", Offset = "0x1F42920", VA = "0x181F43F20")]
	public void MEJBHHBEOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x41C1C30", Offset = "0x41C0630", VA = "0x1841C1C30")]
	public void JKDGJEAMCPP(OEIOFGPKKAF KDHEAEHHPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x41C1A00", Offset = "0x41C0400", VA = "0x1841C1A00")]
	public void FNJLJGPEIMB(OEIOFGPKKAF KDHEAEHHPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public FHLGOPCDKON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[LHOECCIDBFM(typeof(AJDBIBIKOCB), new string[] { })]
public class JFDNCECGDFH : AJDBIBIKOCB, NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents GEPCFDIHMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private EGMGODHDCJJ HGICKBJDBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService KDNKFCLFKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::KOCKALKNOHE<GEEJJFIMDNA> NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x878100", Offset = "0x876B00", VA = "0x180878100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager GMCADEOGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x41CD2D0", Offset = "0x41CBCD0", VA = "0x1841CD2D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xA085F0", Offset = "0xA06FF0", VA = "0x180A085F0", Slot = "14")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x41CDEB0", Offset = "0x41CC8B0", VA = "0x1841CDEB0", Slot = "15")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x41CDBC0", Offset = "0x41CC5C0", VA = "0x1841CDBC0", Slot = "16")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FF5880", Offset = "0x1FF4280", VA = "0x181FF5880", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6B60", Offset = "0x3DE5560", VA = "0x183DE6B60")]
	private GEEJJFIMDNA HJKDKJAFMLK(Entity OOGAMDNOHNH)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x41CDE50", Offset = "0x41CC850", VA = "0x1841CDE50", Slot = "4")]
	public GEEJJFIMDNA MHAMLAHOFJF(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x41CD440", Offset = "0x41CBE40", VA = "0x1841CD440", Slot = "19")]
	public void DHDHEGNNJAD(ref List<GEEJJFIMDNA> LAPGMJGKFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x41CD700", Offset = "0x41CC100", VA = "0x1841CD700", Slot = "20")]
	public IEnumerable<GEEJJFIMDNA> FGIDOIJCHJN(GEEJJFIMDNA BJLPLHMBBOJ, bool APAIFOINEEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x41CD7D0", Offset = "0x41CC1D0", VA = "0x1841CD7D0", Slot = "21")]
	public GEEJJFIMDNA FKOMLICCHDO(GEEJJFIMDNA BJLPLHMBBOJ, int ALJOMNDNEBM)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x41CDA70", Offset = "0x41CC470", VA = "0x1841CDA70", Slot = "22")]
	public int GICOAGINPJH(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x41CE240", Offset = "0x41CCC40", VA = "0x1841CE240", Slot = "8")]
	public int PEOFEJABMDB(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x41CDF80", Offset = "0x41CC980", VA = "0x1841CDF80", Slot = "9")]
	public ACDEDGBHHIP OCMADGOGPGE(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(ACDEDGBHHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x41CE070", Offset = "0x41CCA70", VA = "0x1841CE070", Slot = "23")]
	public bool ONIKKJLLEHO(GEEJJFIMDNA BJLPLHMBBOJ, out ACDEDGBHHIP IJDAKCDPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x41CDCB0", Offset = "0x41CC6B0", VA = "0x1841CDCB0", Slot = "24")]
	public IEnumerable<GEEJJFIMDNA> ILCFHAPNAEK(GEEJJFIMDNA BJLPLHMBBOJ, bool APAIFOINEEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x41CDD80", Offset = "0x41CC780", VA = "0x1841CDD80", Slot = "12")]
	public GEEJJFIMDNA JEEHDEPPMGK(GEEJJFIMDNA NJJNIDPJHBF, GEEJJFIMDNA GEIIKIOFPCG)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x41CD9A0", Offset = "0x41CC3A0", VA = "0x1841CD9A0", Slot = "13")]
	public bool GCEPIHEHFPE(GEEJJFIMDNA NJJNIDPJHBF, GEEJJFIMDNA GEIIKIOFPCG, out GEEJJFIMDNA NPNKNKHBGOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x41CD660", Offset = "0x41CC060", VA = "0x1841CD660", Slot = "5")]
	public GEEJJFIMDNA EOCIMCBAGPH(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x41CDB90", Offset = "0x41CC590", VA = "0x1841CDB90", Slot = "11")]
	public bool HDIAMLJKEPG(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA NLHHFBGKIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x41CE3E0", Offset = "0x41CCDE0", VA = "0x1841CE3E0", Slot = "25")]
	public bool PNIELCDHNAH(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA PGDGHENJBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x41CD2A0", Offset = "0x41CBCA0", VA = "0x1841CD2A0", Slot = "10")]
	public bool AOKMHKIMGCA(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA NJJNIDPJHBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x41CD390", Offset = "0x41CBD90", VA = "0x1841CD390", Slot = "6")]
	public bool CLOBJFNMHGM(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA EOBFGLJBCIJ, bool ANNPIPIEPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x41CD320", Offset = "0x41CBD20", VA = "0x1841CD320", Slot = "7")]
	public bool CGJOPAHPCKK(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA EOBFGLJBCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public JFDNCECGDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[LHOECCIDBFM(typeof(JJAKPFHGEID), new string[] { })]
internal class JJAKPFHGEID : HNADMPPHDEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[JLCJNHHCBDK]
	private IALPALJEAJO PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, ADANANCGCCD> CDDFKBBMOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x41D0090", Offset = "0x41CEA90", VA = "0x1841D0090", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x41CFF40", Offset = "0x41CE940", VA = "0x1841CFF40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x41CFBE0", Offset = "0x41CE5E0", VA = "0x1841CFBE0")]
	public ADANANCGCCD DCHNDCCMJCO(ELPOGHCFKOG IDLOFIFEDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x41CFDF0", Offset = "0x41CE7F0", VA = "0x1841CFDF0")]
	public ADANANCGCCD DCHNDCCMJCO(KOPBFNLIDKA OAOKPGOEMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x41D00E0", Offset = "0x41CEAE0", VA = "0x1841D00E0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x41D0200", Offset = "0x41CEC00", VA = "0x1841D0200")]
	public JJAKPFHGEID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class ADANANCGCCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<AGGAKKNHJCN> OAKAHKPPCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<HAGEPIIBIHO> DOANLMCCNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<GEJEHFLELMJ> PGCICLMODDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<HAGEPIIBIHO> NJMIMEMNEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<AGGAKKNHJCN> NGOCJKPOELO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B9650", Offset = "0x8B8050", VA = "0x1808B9650")]
		get
		{
			return default(NativeList<AGGAKKNHJCN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<HAGEPIIBIHO> ANLKELHLNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x94C330", Offset = "0x94AD30", VA = "0x18094C330")]
		get
		{
			return default(NativeList<HAGEPIIBIHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<GEJEHFLELMJ> EGJNJPIAJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x84E040", Offset = "0x84CA40", VA = "0x18084E040")]
		get
		{
			return default(NativeList<GEJEHFLELMJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<HAGEPIIBIHO> EDDGABMHNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA14000", Offset = "0xA12A00", VA = "0x180A14000")]
		get
		{
			return default(NativeList<HAGEPIIBIHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle FNJGLBBOEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x94C200", Offset = "0x94AC00", VA = "0x18094C200")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xD14760", Offset = "0xD13160", VA = "0x180D14760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FKIMOIOBPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8F20E0", Offset = "0x8F0AE0", VA = "0x1808F20E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool IEFLJCGDFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3E76D40", Offset = "0x3E75740", VA = "0x183E76D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3E772F0", Offset = "0x3E75CF0", VA = "0x183E772F0")]
	public ADANANCGCCD(Allocator APPJGCOGPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3E77260", Offset = "0x3E75C60", VA = "0x183E77260")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3E77130", Offset = "0x3E75B30", VA = "0x183E77130")]
	public void NOOJKGDANLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3E76DF0", Offset = "0x3E757F0", VA = "0x183E76DF0")]
	public void IFPOOIAJHAI(Entity OOGAMDNOHNH, Entity GEFNMBFCONH, Entity KLJNAJJPMKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[LHOECCIDBFM(typeof(IIHFLMJCIJO), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
public class IIHFLMJCIJO : HNADMPPHDEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[JLCJNHHCBDK]
	private SceneService KIMBBFMGFGO;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x41CA7D0", Offset = "0x41C91D0", VA = "0x1841CA7D0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x41CA7B0", Offset = "0x41C91B0", VA = "0x1841CA7B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public IIHFLMJCIJO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[LHOECCIDBFM(typeof(PhotonInstanceCleanupService), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Lifecycle)]
	[POJCHFKPLOJ(PFPBFPDNLIO.PhotonRoom)]
	public class PhotonInstanceCleanupService : HNADMPPHDEF, NMGDKBIHJIB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private NMKFHPDLPMA EAHHABIHLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private DPFFGIGBPCD OPAHKFOPLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> MNCNCCDEBMK;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5BF0", Offset = "0x3DF45F0", VA = "0x183DF5BF0", Slot = "5")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5CF0", Offset = "0x3DF46F0", VA = "0x183DF5CF0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5C50", Offset = "0x3DF4650", VA = "0x183DF5C50")]
		public void IEKFIHLPDKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5B00", Offset = "0x3DF4500", VA = "0x183DF5B00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5D60", Offset = "0x3DF4760", VA = "0x183DF5D60")]
		public void NHEEODHAEJD(global::CLBLKBMEDCN<int> EDINADCBPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5F70", Offset = "0x3DF4970", VA = "0x183DF5F70")]
		public void NOPBAKCOLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class FJLGHPMHLDK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint BKHHODCMLKO;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint IDFMOOCMKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA809E0", Offset = "0xA7F3E0", VA = "0x180A809E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x41C1E60", Offset = "0x41C0860", VA = "0x1841C1E60")]
	public ANIMKGBLAIA BLAFMNMDCMN()
	{
		return default(ANIMKGBLAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x41C1EB0", Offset = "0x41C08B0", VA = "0x1841C1EB0")]
	public void CFAIPKLBKLC(ANIMKGBLAIA BBILPABEHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "6")]
	public virtual void CIPJLEDKNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected FJLGHPMHLDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[LHOECCIDBFM(typeof(COGEAAMAACK), new string[] { })]
internal sealed class COGEAAMAACK : FJLGHPMHLDK, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[JLCJNHHCBDK]
	private OGJECELGDOJ FAMLIKPHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint IPCLKHGHEJH;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint IDFMOOCMKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3E83EA0", Offset = "0x3E828A0", VA = "0x183E83EA0", Slot = "7")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3E83DF0", Offset = "0x3E827F0", VA = "0x183E83DF0")]
	private void CGKAEPCILNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3E83E40", Offset = "0x3E82840", VA = "0x183E83E40", Slot = "6")]
	public override void CIPJLEDKNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	public COGEAAMAACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LHOECCIDBFM(typeof(CDLKGHKEIBO), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
internal sealed class CDLKGHKEIBO : FJLGHPMHLDK
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint IDFMOOCMKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	public CDLKGHKEIBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[LHOECCIDBFM(typeof(JFBPDEPPPOH), new string[] { })]
internal sealed class JFBPDEPPPOH : NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[JLCJNHHCBDK]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery GPGLMIFLPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery BEKBMEDIAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery HOGPGFCMKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery FINFENCGOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery GAMAIMPDOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery FIOCEFODLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager GMCADEOGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x41CC9F0", Offset = "0x41CB3F0", VA = "0x1841CC9F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery OIPOIDCEFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery HEKKHEICMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8C38B0", Offset = "0x8C22B0", VA = "0x1808C38B0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery OGHCCNIFEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x882970", Offset = "0x881370", VA = "0x180882970")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery DEBBDFGMMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x94C200", Offset = "0x94AC00", VA = "0x18094C200")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery DNCFJOHNDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x94C2F0", Offset = "0x94ACF0", VA = "0x18094C2F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery GLKBGEBOMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x41CCAE0", Offset = "0x41CB4E0", VA = "0x1841CCAE0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int BLJAODKLBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x41CD1E0", Offset = "0x41CBBE0", VA = "0x1841CD1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int NLHDBCCOJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x41CCCC0", Offset = "0x41CB6C0", VA = "0x1841CCCC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int CHHDEOBMHON
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x41CCA40", Offset = "0x41CB440", VA = "0x1841CCA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int IMOAIDGBNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x41CD250", Offset = "0x41CBC50", VA = "0x1841CD250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int BCDGFJAOHBN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x41CD270", Offset = "0x41CBC70", VA = "0x1841CD270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HBOKNDGDIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x41CCAC0", Offset = "0x41CB4C0", VA = "0x1841CCAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "4")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x41CD200", Offset = "0x41CBC00", VA = "0x1841CD200", Slot = "5")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x41CCCE0", Offset = "0x41CB6E0", VA = "0x1841CCCE0", Slot = "6")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x41CD180", Offset = "0x41CBB80", VA = "0x1841CD180")]
	private EntityQueryDesc JPDIKGGPFII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x41CCA60", Offset = "0x41CB460", VA = "0x1841CCA60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x41CCC10", Offset = "0x41CB610", VA = "0x1841CCC10")]
	public MCKEIPAGEPJ FMAIHPGELDD(GEEJJFIMDNA AGGJCDBCIGG)
	{
		return default(MCKEIPAGEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x41CCB60", Offset = "0x41CB560", VA = "0x1841CCB60")]
	public MCKEIPAGEPJ FMAIHPGELDD(Entity OOGAMDNOHNH)
	{
		return default(MCKEIPAGEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x41CC940", Offset = "0x41CB340", VA = "0x1841CC940")]
	public IMJFJJBFBGO BMFKKEJNBMK(Entity OOGAMDNOHNH)
	{
		return default(IMJFJJBFBGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x41CD290", Offset = "0x41CBC90", VA = "0x1841CD290")]
	public JFBPDEPPPOH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[KEFMDJAGLBH(IGKCNDFEDMC.All)]
	[LHOECCIDBFM(typeof(HLNKJMLPBIB), new string[] { })]
	public class ObjectService : HNADMPPHDEF, HLNKJMLPBIB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly NNLEPLPFODN HLBFHIHGAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[JLCJNHHCBDK]
		private BDHPOBELMCM DILFFHKMEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[JLCJNHHCBDK]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[JLCJNHHCBDK]
		private ObjectLifecycleService PADNNEGLENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[JLCJNHHCBDK]
		private ObjectEmbodimentService KDNKFCLFKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[JLCJNHHCBDK]
		private ObjectInstantiationService DKNCGBIHPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[JLCJNHHCBDK]
		private JFBPDEPPPOH HGICKBJDBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService ALLIEBFHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public BDHPOBELMCM AGGKBGIFNMF
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int BLJAODKLBEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF070", Offset = "0x3DEDA70", VA = "0x183DEF070", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int NLHDBCCOJPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE510", Offset = "0x3DECF10", VA = "0x183DEE510", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int CHHDEOBMHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE000", Offset = "0x3DECA00", VA = "0x183DEE000", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int IMOAIDGBNHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF6B0", Offset = "0x3DEE0B0", VA = "0x183DEF6B0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int BCDGFJAOHBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x3DEFAD0", Offset = "0x3DEE4D0", VA = "0x183DEFAD0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int HBOKNDGDIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE480", Offset = "0x3DECE80", VA = "0x183DEE480", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<GEEJJFIMDNA, IMJFJJBFBGO> LMMFNCFKHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEA10", Offset = "0x3DED410", VA = "0x183DEEA10", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF950", Offset = "0x3DEE350", VA = "0x183DEF950", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<GEEJJFIMDNA> EMDAHONPKMF
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEB20", Offset = "0x3DED520", VA = "0x183DEEB20", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x3DEDCA0", Offset = "0x3DEC6A0", VA = "0x183DEDCA0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF260", Offset = "0x3DEDC60", VA = "0x183DEF260", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE240", Offset = "0x3DECC40", VA = "0x183DEE240", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF530", Offset = "0x3DEDF30", VA = "0x183DEF530")]
		private void NEGNBMMPLLL(Entity OOGAMDNOHNH, IMJFJJBFBGO FPPOGBDGFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE5D0", Offset = "0x3DECFD0", VA = "0x183DEE5D0")]
		private void HCLEDLMJLND(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE720", Offset = "0x3DED120", VA = "0x183DEE720")]
		internal GEEJJFIMDNA HJKDKJAFMLK(Entity OOGAMDNOHNH)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF9F0", Offset = "0x3DEE3F0", VA = "0x183DEF9F0", Slot = "41")]
		public ACDEDGBHHIP PGHKIPAPBDM()
		{
			return default(ACDEDGBHHIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEC10", Offset = "0x3DED610", VA = "0x183DEEC10", Slot = "42")]
		public ACDEDGBHHIP KOGCMINPDIP()
		{
			return default(ACDEDGBHHIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF730", Offset = "0x3DEE130", VA = "0x183DEF730", Slot = "43")]
		public ACDEDGBHHIP OIOLDOBEMHE()
		{
			return default(ACDEDGBHHIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE4E0", Offset = "0x3DECEE0", VA = "0x183DEE4E0", Slot = "10")]
		public MCKEIPAGEPJ FMAIHPGELDD(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(MCKEIPAGEPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDDC0", Offset = "0x3DEC7C0", VA = "0x183DEDDC0", Slot = "11")]
		public IMJFJJBFBGO BMFKKEJNBMK(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(IMJFJJBFBGO);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE190", Offset = "0x3DECB90", VA = "0x183DEE190")]
		private ACDEDGBHHIP DNAGEKACLBB(EntityQuery IOEGIOMNPHI)
		{
			return default(ACDEDGBHHIP);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF7D0", Offset = "0x3DEE1D0", VA = "0x183DEF7D0", Slot = "33")]
		public bool OJCAMDKMMGI(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE3C0", Offset = "0x3DECDC0", VA = "0x183DEE3C0", Slot = "29")]
		public void EDLFOMBBBBL(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF6D0", Offset = "0x3DEE0D0", VA = "0x183DEF6D0", Slot = "30")]
		public void NPDNJOJOBPP(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDC00", Offset = "0x3DEC600", VA = "0x183DEDC00", Slot = "31")]
		public void BGKEGMHOBPA(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEF00", Offset = "0x3DED900", VA = "0x183DEEF00", Slot = "22")]
		public GAIECBKNDJB LKMKADFFOOH(IMJFJJBFBGO FPPOGBDGFJM, bool JADIDGGBPCE)
		{
			return default(GAIECBKNDJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEFC0", Offset = "0x3DED9C0", VA = "0x183DEEFC0", Slot = "23")]
		public GAIECBKNDJB LKMKADFFOOH(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(GAIECBKNDJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF1D0", Offset = "0x3DEDBD0", VA = "0x183DEF1D0", Slot = "24")]
		public GAIECBKNDJB LPBHBECHMDM(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(GAIECBKNDJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3DEED30", Offset = "0x3DED730", VA = "0x183DEED30", Slot = "25")]
		public GAIECBKNDJB LGBJNNJPIFB(ANIMKGBLAIA BBILPABEHHM, IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(GAIECBKNDJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEAB0", Offset = "0x3DED4B0", VA = "0x183DEEAB0", Slot = "44")]
		public GAIECBKNDJB JEAHFJLEJFB(int MCPKHCOHIOC, IMJFJJBFBGO FPPOGBDGFJM, GameObject OJBDJCCAFCN)
		{
			return default(GAIECBKNDJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE660", Offset = "0x3DED060", VA = "0x183DEE660", Slot = "26")]
		public GCEOCEIHGKK HGCGALMGNBK()
		{
			return default(GCEOCEIHGKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE020", Offset = "0x3DECA20", VA = "0x183DEE020", Slot = "45")]
		public PNJKBFKMBAD CLLCDGNKMBE(MPCFEHACDMF EMKINACMDLO)
		{
			return default(PNJKBFKMBAD);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF5D0", Offset = "0x3DEDFD0", VA = "0x183DEF5D0", Slot = "27")]
		public HGBLPDMDPII NLMJGLMLMIP()
		{
			return default(HGBLPDMDPII);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF090", Offset = "0x3DEDA90", VA = "0x183DEF090", Slot = "28")]
		public ADKHIDCJKPN LOJJJPGLHCF(BFFEGPGDBEI EMKINACMDLO)
		{
			return default(ADKHIDCJKPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDB60", Offset = "0x3DEC560", VA = "0x183DEDB60", Slot = "12")]
		public void AIDBCCOFMIA(ANIMKGBLAIA BBILPABEHHM, MABFCBAKEGH LCHJMMBJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDE00", Offset = "0x3DEC800", VA = "0x183DEDE00", Slot = "13")]
		public GAIECBKNDJB BNDPAOHGHJG(GEEJJFIMDNA BJLPLHMBBOJ, [Optional] object HMAOAMDKNDD)
		{
			return default(GAIECBKNDJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE950", Offset = "0x3DED350", VA = "0x183DEE950", Slot = "14")]
		public bool ILGPCLHAMEC(GEEJJFIMDNA BJLPLHMBBOJ, out MABFCBAKEGH MIMDGHHHHPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEBC0", Offset = "0x3DED5C0", VA = "0x183DEEBC0", Slot = "46")]
		public Transform KODIOKMOMKD(GEEJJFIMDNA BJLPLHMBBOJ, [Optional] object HMAOAMDKNDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE140", Offset = "0x3DECB40", VA = "0x183DEE140", Slot = "16")]
		public bool DDBBPDDJDDO(GEEJJFIMDNA BJLPLHMBBOJ, out Transform DBMMOFPNJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDFB0", Offset = "0x3DEC9B0", VA = "0x183DEDFB0", Slot = "17")]
		public bool CFECPBDNIEP(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE920", Offset = "0x3DED320", VA = "0x183DEE920")]
		public bool IECCGCLPDPH(MABFCBAKEGH MFBGAMJDOKA, [Optional] object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE8F0", Offset = "0x3DED2F0", VA = "0x183DEE8F0", Slot = "47")]
		public bool IECCGCLPDPH(GEEJJFIMDNA BJLPLHMBBOJ, [Optional] object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE9F0", Offset = "0x3DED3F0", VA = "0x183DEE9F0", Slot = "48")]
		public void INHMMJGGOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE740", Offset = "0x3DED140", VA = "0x183DEE740", Slot = "15")]
		public void ICDKAMIAOFA(MABFCBAKEGH OMHIFHKMIMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFA90", Offset = "0x3DEE490", VA = "0x183DEFA90", Slot = "49")]
		public void PNNKGABBLLP(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDB80", Offset = "0x3DEC580", VA = "0x183DEDB80", Slot = "18")]
		public bool BEDNNMDNELJ(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDD40", Offset = "0x3DEC740", VA = "0x183DEDD40", Slot = "19")]
		public bool BHOPDHAGJNE(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3DEECC0", Offset = "0x3DED6C0", VA = "0x183DEECC0", Slot = "50")]
		public bool LGBEGCFDINL(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE410", Offset = "0x3DECE10", VA = "0x183DEE410", Slot = "51")]
		public bool EEEOIIPFJBL(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF4D0", Offset = "0x3DEDED0", VA = "0x183DEF4D0", Slot = "32")]
		public NativeArray<(GEEJJFIMDNA, GEEJJFIMDNA)> NBNDBJHEGMK(NativeArray<GEEJJFIMDNA> LFONLDBPOBG, Allocator APPJGCOGPBM)
		{
			return default(NativeArray<(GEEJJFIMDNA, GEEJJFIMDNA)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE530", Offset = "0x3DECF30", VA = "0x183DEE530", Slot = "21")]
		public ANIMKGBLAIA GNIDCGFLOEL(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(ANIMKGBLAIA);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF860", Offset = "0x3DEE260", VA = "0x183DEF860", Slot = "20")]
		public GEEJJFIMDNA ONPEFMCCMDC(ANIMKGBLAIA BBILPABEHHM)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE4A0", Offset = "0x3DECEA0", VA = "0x183DEE4A0")]
		private void FEEBGFECIOF(IMJFJJBFBGO FPPOGBDGFJM, GEEJJFIMDNA BJLPLHMBBOJ, ANIMKGBLAIA BBILPABEHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[LHOECCIDBFM(typeof(ELIMEPABHMM), new string[] { })]
internal sealed class ELIMEPABHMM : HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService DKNCGBIHPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[JLCJNHHCBDK]
	private JFBPDEPPPOH HGICKBJDBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[JLCJNHHCBDK]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x41BA810", Offset = "0x41B9210", VA = "0x1841BA810", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x41BA8A0", Offset = "0x41B92A0", VA = "0x1841BA8A0")]
	public NativeArray<(GEEJJFIMDNA, GEEJJFIMDNA)> NBNDBJHEGMK(NativeArray<GEEJJFIMDNA> LFONLDBPOBG, Allocator APPJGCOGPBM)
	{
		return default(NativeArray<(GEEJJFIMDNA, GEEJJFIMDNA)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x41BA1A0", Offset = "0x41B8BA0", VA = "0x1841BA1A0")]
	private void HLICMAGDDEA(NativeMultiHashMap<int, (GEEJJFIMDNA src, GEEJJFIMDNA dst)> PELEGCFFBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x41BA380", Offset = "0x41B8D80", VA = "0x1841BA380")]
	private void KKIGEMDLMPP(NativeMultiHashMap<int, (GEEJJFIMDNA src, GEEJJFIMDNA dst)> PELEGCFFBAB, int FPPOGBDGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x41BA010", Offset = "0x41B8A10", VA = "0x1841BA010")]
	private void GJNINBCLKNO(NativeMultiHashMap<int, (GEEJJFIMDNA src, GEEJJFIMDNA dst)> PELEGCFFBAB, int FPPOGBDGFJM, DPCOGLJGJDC PILEKMCPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x41BA9A0", Offset = "0x41B93A0", VA = "0x1841BA9A0")]
	private NativeMultiHashMap<int, (GEEJJFIMDNA, GEEJJFIMDNA)> PILPECDGDCC(Allocator APPJGCOGPBM, NativeArray<GEEJJFIMDNA> LFONLDBPOBG, out NativeArray<(GEEJJFIMDNA src, GEEJJFIMDNA dst)> DGPEINKMPKM)
	{
		return default(NativeMultiHashMap<int, (GEEJJFIMDNA, GEEJJFIMDNA)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public ELIMEPABHMM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[KEFMDJAGLBH(IGKCNDFEDMC.TransformSyncing)]
	[LDLOFIJMJIF(typeof(TransformService))]
	[LHOECCIDBFM(typeof(FADNPGGGOHC), new string[] { })]
	public class TransformService : FADNPGGGOHC, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly NNLEPLPFODN HCJBBGMHBIF;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly NNLEPLPFODN IIKENPDCKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private EEDIDAECHEO NJADCKCLHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private AJDBIBIKOCB ILCFADBMBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase GACCEFPBEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService JMHKMIOCNFD;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x3D2C550", Offset = "0x3D2AF50", VA = "0x183D2C550")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private PJIOIOLLAAE CMOPJKDIAEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x3D2C200", Offset = "0x3D2AC00", VA = "0x183D2C200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F6F0", Offset = "0x3D2E0F0", VA = "0x183D2F6F0", Slot = "33")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DC40", Offset = "0x3D2C640", VA = "0x183D2DC40", Slot = "34")]
		public bool IHMMDCFOEDB(Transform DBMMOFPNJHL, out GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D240", Offset = "0x3D2BC40", VA = "0x183D2D240", Slot = "35")]
		public Transform GEEMINMGLOA(Entity OOGAMDNOHNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C8E0", Offset = "0x3D2B2E0", VA = "0x183D2C8E0", Slot = "30")]
		public bool DDBBPDDJDDO(Entity OOGAMDNOHNH, out Transform DBMMOFPNJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F510", Offset = "0x3D2DF10", VA = "0x183D2F510")]
		private void LMMKCLGDHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D0F0", Offset = "0x3D2BAF0", VA = "0x183D2D0F0", Slot = "29")]
		public void FJNBNFJAGNK(Entity OOGAMDNOHNH, out Matrix4x4 HHOLBHDBGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FCC0", Offset = "0x3D2E6C0", VA = "0x183D2FCC0", Slot = "4")]
		public void NKILAKLBNAK(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E3F0", Offset = "0x3D2CDF0", VA = "0x183D2E3F0")]
		public void KIOPABMGOBM(Entity OOGAMDNOHNH, Vector3 OPILFLDGFGA, Quaternion PLKNLINIEJP, Vector3 GCOHMBGKIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C7D0", Offset = "0x3D2B1D0", VA = "0x183D2C7D0")]
		public void CMBHOAGADHA(Entity OOGAMDNOHNH, Vector3 OPILFLDGFGA, Quaternion PLKNLINIEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D5B0", Offset = "0x3D2BFB0", VA = "0x183D2D5B0", Slot = "27")]
		public void HMAHHCMPGEA(Entity OOGAMDNOHNH, out Matrix4x4 DNHFBHOILLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EAE0", Offset = "0x3D2D4E0", VA = "0x183D2EAE0")]
		public void LAIPPBKMPPO(Entity OOGAMDNOHNH, in Matrix4x4 HHOLBHDBGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3D30260", Offset = "0x3D2EC60", VA = "0x183D30260")]
		public void PDCBNNJAODF(Entity OOGAMDNOHNH, in Matrix4x4 HHOLBHDBGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E030", Offset = "0x3D2CA30", VA = "0x183D2E030")]
		public void JENHKFEBBJI(Entity OOGAMDNOHNH, in Matrix4x4 PGMBNGOGADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CC70", Offset = "0x3D2B670", VA = "0x183D2CC70", Slot = "5")]
		public void EGKMOCALEBJ(Entity OOGAMDNOHNH, Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CFE0", Offset = "0x3D2B9E0", VA = "0x183D2CFE0", Slot = "6")]
		public Vector3 FIJNLKGJBHA(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D4B0", Offset = "0x3D2BEB0", VA = "0x183D2D4B0", Slot = "7")]
		public void HFAOKGBEHGM(Entity OOGAMDNOHNH, Quaternion MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E200", Offset = "0x3D2CC00", VA = "0x183D2E200", Slot = "8")]
		public Quaternion JNLBKHBHAAK(Entity OOGAMDNOHNH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E2F0", Offset = "0x3D2CCF0", VA = "0x183D2E2F0", Slot = "12")]
		public void JNNDGJCLLHG(Entity OOGAMDNOHNH, Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FFA0", Offset = "0x3D2E9A0", VA = "0x183D2FFA0", Slot = "11")]
		public Vector3 OEICANEOFBI(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FC20", Offset = "0x3D2E620", VA = "0x183D2FC20")]
		public void NEPALMPOPME(Entity OOGAMDNOHNH, Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F650", Offset = "0x3D2E050", VA = "0x183D2F650")]
		private Vector3 MHNMJFCGNDB(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3D301C0", Offset = "0x3D2EBC0", VA = "0x183D301C0", Slot = "14")]
		public float OMFJDENDHMI(Entity OOGAMDNOHNH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3D300B0", Offset = "0x3D2EAB0", VA = "0x183D300B0", Slot = "13")]
		public void OHKPFJOHMKD(Entity OOGAMDNOHNH, float MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C9D0", Offset = "0x3D2B3D0", VA = "0x183D2C9D0")]
		private float DKCNNDJHBDC(Entity OOGAMDNOHNH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F240", Offset = "0x3D2DC40", VA = "0x183D2F240")]
		public void LCHJPCIDFHN(Entity OOGAMDNOHNH, float JCEFIPALCBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C6F0", Offset = "0x3D2B0F0", VA = "0x183D2C6F0", Slot = "16")]
		public Vector3 CIKKMAFCDOB(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3D305C0", Offset = "0x3D2EFC0", VA = "0x183D305C0", Slot = "15")]
		public void PIOKGHJKENB(Entity OOGAMDNOHNH, Vector3 NHLPOEGEAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F800", Offset = "0x3D2E200", VA = "0x183D2F800")]
		private Vector3 MNHAKIGKLAL(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CAC0", Offset = "0x3D2B4C0", VA = "0x183D2CAC0")]
		public void DPMKKCCKJDP(Entity OOGAMDNOHNH, Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F930", Offset = "0x3D2E330", VA = "0x183D2F930")]
		[Conditional("DEBUG_BUILD")]
		private void MPDKPAKELBF(Entity OOGAMDNOHNH, Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CE80", Offset = "0x3D2B880", VA = "0x183D2CE80", Slot = "36")]
		public void FIBEMAOALKI(Entity OOGAMDNOHNH, Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3D30E70", Offset = "0x3D2F870", VA = "0x183D30E70", Slot = "9")]
		public void PJGCIONIOOP(Entity OOGAMDNOHNH, out Vector3 LHCEFCJDGIJ, out Quaternion FDBNIAOOEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E4C0", Offset = "0x3D2CEC0", VA = "0x183D2E4C0", Slot = "10")]
		public void KMCLKONGDPC(Entity OOGAMDNOHNH, out Vector3 LHCEFCJDGIJ, out Quaternion FDBNIAOOEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D5C0", Offset = "0x3D2BFC0", VA = "0x183D2D5C0", Slot = "37")]
		public void HPNMIGHJDIM(Entity OOGAMDNOHNH, Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C040", Offset = "0x3D2AA40", VA = "0x183D2C040")]
		public void APNFAMLKEGA(Entity OOGAMDNOHNH, Vector3 LHCEFCJDGIJ, Quaternion FDBNIAOOEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DE00", Offset = "0x3D2C800", VA = "0x183D2DE00", Slot = "17")]
		public void JEDAKBINKII(Entity OOGAMDNOHNH, Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CB90", Offset = "0x3D2B590", VA = "0x183D2CB90", Slot = "18")]
		public Vector3 EFDLNMCEEBN(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F2D0", Offset = "0x3D2DCD0", VA = "0x183D2F2D0", Slot = "19")]
		public void LFEFENHELJN(Entity OOGAMDNOHNH, Quaternion MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FEB0", Offset = "0x3D2E8B0", VA = "0x183D2FEB0", Slot = "20")]
		public Quaternion OAKFKBPBLJE(Entity OOGAMDNOHNH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D7E0", Offset = "0x3D2C1E0", VA = "0x183D2D7E0", Slot = "22")]
		public void IFAANCDHOIJ(Entity OOGAMDNOHNH, Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CD90", Offset = "0x3D2B790", VA = "0x183D2CD90", Slot = "21")]
		public Vector3 FBMOLFENGKB(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C2C0", Offset = "0x3D2ACC0", VA = "0x183D2C2C0", Slot = "23")]
		public void CAEAEGFBMGP(Entity OOGAMDNOHNH, float GJNGBELHLEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C430", Offset = "0x3D2AE30", VA = "0x183D2C430", Slot = "24")]
		public float CAMPCKMMFHB(Entity OOGAMDNOHNH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E5F0", Offset = "0x3D2CFF0", VA = "0x183D2E5F0", Slot = "25")]
		public void KPDLKOBMHDA(Entity OOGAMDNOHNH, Vector3 HPGGMOACAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FAE0", Offset = "0x3D2E4E0", VA = "0x183D2FAE0", Slot = "26")]
		public Vector3 NAOGPCMOPKI(Entity OOGAMDNOHNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D307D0", Offset = "0x3D2F1D0", VA = "0x183D307D0", Slot = "31")]
		public void PJEDLKNNADA(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C5A0", Offset = "0x3D2AFA0", VA = "0x183D2C5A0")]
		private GEEJJFIMDNA CHBBKKMJONI(Transform DBMMOFPNJHL)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D30390", Offset = "0x3D2ED90", VA = "0x183D30390")]
		private static TransformEntity PEMHLIIBHON(IMJFJJBFBGO EMKINACMDLO, GameObject LNBPLDMMKPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F530", Offset = "0x3D2DF30", VA = "0x183D2F530", Slot = "32")]
		public void MHLAPHFOIFH(Entity OOGAMDNOHNH, Entity GEFNMBFCONH, Entity KLJNAJJPMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D30FC0", Offset = "0x3D2F9C0", VA = "0x183D30FC0")]
		private KMFNDODAPBC PJGCIONIOOP(Entity OOGAMDNOHNH)
		{
			return default(KMFNDODAPBC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D306F0", Offset = "0x3D2F0F0", VA = "0x183D306F0")]
		private bool PJDBECPMNCO(Entity OOGAMDNOHNH, out Entity EOBFGLJBCIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D300", Offset = "0x3D2BD00", VA = "0x183D2D300")]
		private void GKKNOAFOLPG(Entity OOGAMDNOHNH, out Matrix4x4 HHOLBHDBGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EEA0", Offset = "0x3D2D8A0", VA = "0x183D2EEA0")]
		private void LBEBACDMEHG(Entity OOGAMDNOHNH, out Matrix4x4 PGMBNGOGADD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E1F0", Offset = "0x3D2CBF0", VA = "0x183D2E1F0", Slot = "28")]
		private void JIPDECJNAFI(Entity OOGAMDNOHNH, in Matrix4x4 DNHFBHOILLE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
[LHOECCIDBFM(typeof(DBBBFBJLKDJ), new string[] { })]
internal sealed class DBBBFBJLKDJ : HNADMPPHDEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[JLCJNHHCBDK]
	private OGJECELGDOJ FAMLIKPHPAP;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F2E0", Offset = "0x3E8DCE0", VA = "0x183E8F2E0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F270", Offset = "0x3E8DC70", VA = "0x183E8F270", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public DBBBFBJLKDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[LHOECCIDBFM(typeof(LOGDFEGPILN), new string[] { })]
public class LOGDFEGPILN
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct HMNMKCEFCOL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly LOGDFEGPILN EOBFGLJBCIJ;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x47C3E50", Offset = "0x47C2850", VA = "0x1847C3E50")]
		public HMNMKCEFCOL(LOGDFEGPILN EOBFGLJBCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x47C3E30", Offset = "0x47C2830", VA = "0x1847C3E30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int EHKILEDLBMJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool MHOILOINFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x209DAC0", Offset = "0x209C4C0", VA = "0x18209DAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action ONGMDCHGEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE280", Offset = "0x3DDCC80", VA = "0x183DDE280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE320", Offset = "0x3DDCD20", VA = "0x183DDE320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE3E0", Offset = "0x3DDCDE0", VA = "0x183DDE3E0")]
	public HMNMKCEFCOL MPCCGBJELDN()
	{
		return default(HMNMKCEFCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x113E4C0", Offset = "0x113CEC0", VA = "0x18113E4C0")]
	public void MOGDAADJEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE3C0", Offset = "0x3DDCDC0", VA = "0x183DDE3C0")]
	public void JEHJNELMGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public LOGDFEGPILN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[LHOECCIDBFM(typeof(DEGDDDMDDKA), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
public class DEGDDDMDDKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int EHKILEDLBMJ;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool CFHHAFMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xC61AD0", Offset = "0xC604D0", VA = "0x180C61AD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xC61B60", Offset = "0xC60560", VA = "0x180C61B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public DEGDDDMDDKA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[LHOECCIDBFM(typeof(EnableComponentSystemsInScope), new string[] { })]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[KEFMDJAGLBH(IGKCNDFEDMC.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : HNADMPPHDEF, DLLJBMPPILM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct HGLADAOJIGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> NNPFNFBHPNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> CPMFGOIFOOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> CGHMIMFGHII;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x47C3540", Offset = "0x47C1F40", VA = "0x1847C3540")]
			public HGLADAOJIGB(NativeArray<int> NNPFNFBHPNJ, NativeArray<int> CPMFGOIFOOJ, Dictionary<ComponentSystemBase, int> CGHMIMFGHII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x47C32C0", Offset = "0x47C1CC0", VA = "0x1847C32C0")]
			public void DHJIICNKGJD(IEnumerable<ComponentSystemBase> DILFFHKMEHB, PFPBFPDNLIO OHAONGFFAIB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class PFHMEGMPCKE : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
			[DebuggerHidden]
			public PFHMEGMPCKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x47CB140", Offset = "0x47C9B40", VA = "0x1847CB140", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x47CB310", Offset = "0x47C9D10", VA = "0x1847CB310", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x47CB260", Offset = "0x47C9C60", VA = "0x1847CB260", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x47CB260", Offset = "0x47C9C60", VA = "0x1847CB260", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const PFPBFPDNLIO NJADBMKOGON = PFPBFPDNLIO.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly NNLEPLPFODN KCFAOEMEFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private IBDMDNNFKPL CFMBBKOCIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> HMLDCCJLBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> MHLGLNEDNCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int LHIPGOMOMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private PFPBFPDNLIO IPALFDNJIIM;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x41BD150", Offset = "0x41BBB50", VA = "0x1841BD150", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x41BC2F0", Offset = "0x41BACF0", VA = "0x1841BC2F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x41BC260", Offset = "0x41BAC60", VA = "0x1841BC260")]
		[IteratorStateMachine(typeof(PFHMEGMPCKE))]
		private IEnumerable<ComponentSystemBase> DGADIODCLAB(int ONAOKOFPGLK, int PCPMBKDCIED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x41BD020", Offset = "0x41BBA20", VA = "0x1841BD020", Slot = "5")]
		public void KLPPJGGFAKI(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x41BCE50", Offset = "0x41BB850", VA = "0x1841BCE50")]
		private void JAAGFLMGAFA(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x41BCD50", Offset = "0x41BB750", VA = "0x1841BCD50")]
		public void JAAGFLMGAFA(PFPBFPDNLIO ALLOKFHFKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x41BC380", Offset = "0x41BAD80", VA = "0x1841BC380")]
		private void FNMBHHEPHBN(PFPBFPDNLIO ALLOKFHFKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x41BD270", Offset = "0x41BBC70", VA = "0x1841BD270")]
		private void NHCPDMKDEGK(PFPBFPDNLIO ALLOKFHFKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x41BD300", Offset = "0x41BBD00", VA = "0x1841BD300")]
		private void PLKPAAMDONG(PFPBFPDNLIO ALLOKFHFKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x41BC610", Offset = "0x41BB010", VA = "0x1841BC610")]
		private void HEMFLHKBLAL(int ONAOKOFPGLK, int PCPMBKDCIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x41BD090", Offset = "0x41BBA90", VA = "0x1841BD090")]
		private void LIKPJBLCAPE(int ONAOKOFPGLK, int PCPMBKDCIED, bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x41BCFA0", Offset = "0x41BB9A0", VA = "0x1841BCFA0")]
		private int JGHKKKJLPGO(PFPBFPDNLIO ALLOKFHFKOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x41BC7C0", Offset = "0x41BB1C0", VA = "0x1841BC7C0")]
		private bool HLAACCEONPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x41BC6D0", Offset = "0x41BB0D0", VA = "0x1841BC6D0")]
		private Dictionary<ComponentSystemBase, int> HGOIBFLFOFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x41BD230", Offset = "0x41BBC30", VA = "0x1841BD230")]
		private void NEBPFBNCFNO(NativeArray<int> NNPFNFBHPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x41BC1B0", Offset = "0x41BABB0", VA = "0x1841BC1B0")]
		private void CNGNNMILHHI(NativeArray<int> CPMFGOIFOOJ, NativeArray<int> NNPFNFBHPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x41BCFC0", Offset = "0x41BB9C0", VA = "0x1841BCFC0")]
		private static PFPBFPDNLIO JKJMIPDPNLC(Type EMKINACMDLO, PFPBFPDNLIO NEHANGBEOBM)
		{
			return default(PFPBFPDNLIO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x41BD3F0", Offset = "0x41BBDF0", VA = "0x1841BD3F0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x41BD1D0", Offset = "0x41BBBD0", VA = "0x1841BD1D0")]
		[CompilerGenerated]
		private void NDMMKENEBLL(HNADMPPHDEF PJNBPHIGENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x41BD030", Offset = "0x41BBA30", VA = "0x1841BD030")]
		[CompilerGenerated]
		private void LDEGGLHODIH(BCGODABHHDD PJNBPHIGENH)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[KEFMDJAGLBH(IGKCNDFEDMC.WorldService)]
	[LHOECCIDBFM(typeof(MCKELHDHOFN), new string[] { })]
	public class TickService : HNADMPPHDEF, MCKELHDHOFN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker PCGCAJKBKDG;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker IKHCEBIHFKK;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker CJAAGGMMGMK;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker HIJHCKOPKHA;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker EKNLICHPIDE;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker PIOEKNBMMFD;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker EPKLKFBALDM;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker POKNKONHOAB;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker FGEHJPHENCG;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker BGGLKFBMOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[JLCJNHHCBDK]
		private KBKLGJJJAII BAOOFNPBDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[JLCJNHHCBDK]
		private KMHGJLFLHBE FLGMLEMANND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[JLCJNHHCBDK]
		private TransformOwnershipPhase NIBJDNICPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[JLCJNHHCBDK]
		private TimeService APNACMJJDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private BKKHAMMBGFF ENGIGCMGHCJ;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool GPHDIBKLFFO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x3D2AB90", Offset = "0x3D29590", VA = "0x183D2AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool KBNLPMDNAIL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x3D2A4F0", Offset = "0x3D28EF0", VA = "0x183D2A4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool PMBJDJCBBKL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x3D2AB90", Offset = "0x3D29590", VA = "0x183D2AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool JINBLFBICBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3D2AB90", Offset = "0x3D29590", VA = "0x183D2AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ADF0", Offset = "0x3D297F0", VA = "0x183D2ADF0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A280", Offset = "0x3D28C80", VA = "0x183D2A280", Slot = "14")]
		public void BFKCKIIIGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AC00", Offset = "0x3D29600", VA = "0x183D2AC00", Slot = "15")]
		public void KNHFLGMEHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AF60", Offset = "0x3D29960", VA = "0x183D2AF60", Slot = "5")]
		public void NMIILJOIBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AA10", Offset = "0x3D29410", VA = "0x183D2AA10", Slot = "6")]
		public void GKEGKJBHDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A590", Offset = "0x3D28F90", VA = "0x183D2A590", Slot = "7")]
		public void EJFACGOJJIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A710", Offset = "0x3D29110", VA = "0x183D2A710", Slot = "8")]
		public void GEMCPGIKDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A890", Offset = "0x3D29290", VA = "0x183D2A890", Slot = "9")]
		public void GIPFPBOLDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B030", Offset = "0x3D29A30", VA = "0x183D2B030", Slot = "10")]
		public void PAKMCKNDKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AD20", Offset = "0x3D29720", VA = "0x183D2AD20", Slot = "11")]
		public void MALFPNDCOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
		public void IDDMOCFDIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A3A0", Offset = "0x3D28DA0", VA = "0x183D2A3A0", Slot = "12")]
		public void CENCOCMLNHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[LHOECCIDBFM(typeof(BJJPOMIINDM), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.WorldService)]
	public class WorldService : BJJPOMIINDM, IDisposable, NMGDKBIHJIB, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private BKKHAMMBGFF ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private INPDPGIAJAM AFLONPELFOL;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public BKKHAMMBGFF FPKDMGAMAMN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public PJIOIOLLAAE CMOPJKDIAEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x12109A0", Offset = "0x120F3A0", VA = "0x1812109A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x3D390E0", Offset = "0x3D37AE0", VA = "0x183D390E0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool FKIMOIOBPDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D39350", Offset = "0x3D37D50", VA = "0x183D39350", Slot = "10")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D39570", Offset = "0x3D37F70", VA = "0x183D39570", Slot = "11")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D39460", Offset = "0x3D37E60", VA = "0x183D39460")]
		private void KMLFLFAGFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D39120", Offset = "0x3D37B20", VA = "0x183D39120", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D39100", Offset = "0x3D37B00", VA = "0x183D39100", Slot = "8")]
		public ComponentSystemBase CJEEICHLDKK(Type EMKINACMDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[LHOECCIDBFM(typeof(FJMMLNOOMII), new string[] { })]
public sealed class LJAJBHAHCCF : FJMMLNOOMII, NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class JNPEEHOMDKM : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x47C5330", Offset = "0x47C3D30", VA = "0x1847C5330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x95A0C0", Offset = "0x958AC0", VA = "0x18095A0C0")]
		[DebuggerHidden]
		public JNPEEHOMDKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x47C5020", Offset = "0x47C3A20", VA = "0x1847C5020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x47C52F0", Offset = "0x47C3CF0", VA = "0x1847C52F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x47C5250", Offset = "0x47C3C50", VA = "0x1847C5250", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x47C5250", Offset = "0x47C3C50", VA = "0x1847C5250", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[JLCJNHHCBDK]
	private IADMOPFMJCJ PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly AHAHOFIBDGF OMBOMCLDNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, EHIHNHAGEHH> BGJHJNHAIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, BEFPJHEDGEB> MHBBGFOFAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<KHBNAMDANEI> KHNKBGFCOOC;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public BEFPJHEDGEB GOABDJIDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD8F0", Offset = "0x3DDC2F0", VA = "0x183DDD8F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<KHBNAMDANEI> DIMPJOFNPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD950", Offset = "0x3DDC350", VA = "0x183DDD950", Slot = "8")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD1F0", Offset = "0x3DDBBF0", VA = "0x183DDD1F0", Slot = "9")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCE50", Offset = "0x3DDB850", VA = "0x183DDCE50", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD050", Offset = "0x3DDBA50", VA = "0x183DDD050", Slot = "6")]
	public bool HLGNMBLCMDH(KHBNAMDANEI EELLPGLCOLL, out BEFPJHEDGEB HGPMMCNKFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD2F0", Offset = "0x3DDBCF0", VA = "0x183DDD2F0")]
	private void KLHKPKCMNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCCB0", Offset = "0x3DDB6B0", VA = "0x183DDCCB0")]
	private void DLOLMCGMJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD9B0", Offset = "0x3DDC3B0", VA = "0x183DDD9B0")]
	private EHIHNHAGEHH NNJPNBFJIPI(string DHFMGEAAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD8F0", Offset = "0x3DDC2F0", VA = "0x183DDD8F0")]
	private EHIHNHAGEHH LMKPHLIAEEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD680", Offset = "0x3DDC080", VA = "0x183DDD680")]
	private EHIHNHAGEHH KMLPEJCBBPK(string DHFMGEAAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD0E0", Offset = "0x3DDBAE0", VA = "0x183DDD0E0")]
	private EHIHNHAGEHH HMAIPDPECLE(string KEADNAEDGGE, string HMAOAMDKNDD, [Optional] EHIHNHAGEHH DBINCMGCEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCFE0", Offset = "0x3DDB9E0", VA = "0x183DDCFE0")]
	[IteratorStateMachine(typeof(JNPEEHOMDKM))]
	private IEnumerable<(string, string)> HFHFLFMAOBF(string DHFMGEAAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCC10", Offset = "0x3DDB610", VA = "0x183DDCC10")]
	private bool DADILKEIBGM(KHBNAMDANEI EELLPGLCOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD210", Offset = "0x3DDBC10", VA = "0x183DDD210")]
	private AHAHOFIBDGF JELJDKFJMFN(KHBNAMDANEI EELLPGLCOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCC60", Offset = "0x3DDB660", VA = "0x183DDCC60")]
	private AHAHOFIBDGF DKDKEFLFEOE(KHBNAMDANEI EELLPGLCOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCEE0", Offset = "0x3DDB8E0", VA = "0x183DDCEE0")]
	private AHAHOFIBDGF FPAANHBGAFB(KHBNAMDANEI EELLPGLCOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x36FFD20", Offset = "0x36FE720", VA = "0x1836FFD20")]
	private T FGHEIKBMOIO<T>(KHBNAMDANEI EELLPGLCOLL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCF70", Offset = "0x3DDB970", VA = "0x183DDCF70")]
	private FieldInfo GCFFNKFOLMB(KHBNAMDANEI EELLPGLCOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDA10", Offset = "0x3DDC410", VA = "0x183DDDA10")]
	public LJAJBHAHCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCB80", Offset = "0x3DDB580", VA = "0x183DDCB80")]
	[CompilerGenerated]
	private int BPLMHNEMEMD(KHBNAMDANEI MGFKDMJBGAK, KHBNAMDANEI LPDJCHOFJLE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class EHIHNHAGEHH : BEFPJHEDGEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string NELEAFOILDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly EHIHNHAGEHH DBINCMGCEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<EHIHNHAGEHH> PDBLCDIIKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<KHBNAMDANEI> PILEKMCPEGL;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string FDKJJFGADMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BEFPJHEDGEB LMLEOFGGNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<BEFPJHEDGEB> ADNDDOGAMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<KHBNAMDANEI> GGFKHOBKBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3E93AE0", Offset = "0x3E924E0", VA = "0x183E93AE0")]
	public EHIHNHAGEHH(string KMEGKECOLPJ, EHIHNHAGEHH EOBFGLJBCIJ)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[LHOECCIDBFM(typeof(NLFGNBOEMBJ), new string[] { })]
	[LDLOFIJMJIF(typeof(HistoryService))]
	[KEFMDJAGLBH(IGKCNDFEDMC.History)]
	public class HistoryService : HNADMPPHDEF, IDisposable, NLFGNBOEMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum MBDBAMFHICB
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct LHHCEHHMCOI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly MBDBAMFHICB GDOMLANFCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService LMACCHFJBFE;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x47C6EA0", Offset = "0x47C58A0", VA = "0x1847C6EA0")]
			public LHHCEHHMCOI(HistoryService LMACCHFJBFE, bool PDKEKIHJBDF, uint LHIPGOMOMEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x47C6E70", Offset = "0x47C5870", VA = "0x1847C6E70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class DNOEHLEEIAD
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct EDPMKBFNKAH : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly DNOEHLEEIAD KPLFGOOOGNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool EOLBHPJLGNF;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x47C1D80", Offset = "0x47C0780", VA = "0x1847C1D80")]
				public EDPMKBFNKAH(DNOEHLEEIAD KPLFGOOOGNJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x47BF370", Offset = "0x47BDD70", VA = "0x1847BF370", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct BBFMMGLCLFL : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly DNOEHLEEIAD KPLFGOOOGNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool EOLBHPJLGNF;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x47BF3A0", Offset = "0x47BDDA0", VA = "0x1847BF3A0")]
				public BBFMMGLCLFL(DNOEHLEEIAD KPLFGOOOGNJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x47BF370", Offset = "0x47BDD70", VA = "0x1847BF370", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService EHAAMKHMDDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool HOMLHELBAGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int FDKIPKDOLFK;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x47C1820", Offset = "0x47C0220", VA = "0x1847C1820")]
			public DNOEHLEEIAD(HistoryService EHAAMKHMDDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x47C1750", Offset = "0x47C0150", VA = "0x1847C1750")]
			public bool FFCCLKGMFIK(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x47C1780", Offset = "0x47C0180", VA = "0x1847C1780")]
			public BBFMMGLCLFL OLBANDEGMDC()
			{
				return default(BBFMMGLCLFL);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x47C17D0", Offset = "0x47C01D0", VA = "0x1847C17D0")]
			public EDPMKBFNKAH PAAIIPHJJCO()
			{
				return default(EDPMKBFNKAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class OBNLJHBKLGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public OBNLJHBKLGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x47CA0F0", Offset = "0x47C8AF0", VA = "0x1847CA0F0")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class MCBKDCFOKJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public MCBKDCFOKJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x47C8BD0", Offset = "0x47C75D0", VA = "0x1847C8BD0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class FOBEGMCOKLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public FOBEGMCOKLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x47C2780", Offset = "0x47C1180", VA = "0x1847C2780")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction ICIILJIPBDL;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction MIOFPDNNDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private FJODDPIOIFN GOHEDFABPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer EGGOLLIPBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer NNCLIJJPFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private LFKALHOJJHM MONKPIKAIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase NIBJDNICPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService KBECBEIHHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private DMNIOAOADAO FGGHHPPAGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private MBDBAMFHICB MOJGFHPOEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private DNOEHLEEIAD KPLFGOOOGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private DICONAJFMFK CNOHBONCFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IALPALJEAJO GBMNEHCEMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private KOPBFNLIDKA BBHKCBLOHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete BLMBLOCDLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint MEMEKDHDBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint NHJGNKFGEPH;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private DNOEHLEEIAD EDHNCABEPHC
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool MJOGMNLMPKG
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x41C6490", Offset = "0x41C4E90", VA = "0x1841C6490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool PLMJLPCPOKE
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x41C67B0", Offset = "0x41C51B0", VA = "0x1841C67B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool PGMABGADLLO
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x41C6780", Offset = "0x41C5180", VA = "0x1841C6780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int LNJBCNCHEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x41C7490", Offset = "0x41C5E90", VA = "0x1841C7490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int IKBGFGGCKOO
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x41C6850", Offset = "0x41C5250", VA = "0x1841C6850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool BLLCAIOAFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x41C8430", Offset = "0x41C6E30", VA = "0x1841C8430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool PCEJCDLFOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x41C6F40", Offset = "0x41C5940", VA = "0x1841C6F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool FPGLIADEEEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x10F1750", Offset = "0x10F0150", VA = "0x1810F1750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x10F1780", Offset = "0x10F0180", VA = "0x1810F1780", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer FCHGNFEGBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x41C79D0", Offset = "0x41C63D0", VA = "0x1841C79D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action AHMNKPCOICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x41C7530", Offset = "0x41C5F30", VA = "0x1841C7530", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x41C66E0", Offset = "0x41C50E0", VA = "0x1841C66E0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action PILPHOKNOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x41C6970", Offset = "0x41C5370", VA = "0x1841C6970")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x41C6CB0", Offset = "0x41C56B0", VA = "0x1841C6CB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x41C7CC0", Offset = "0x41C66C0", VA = "0x1841C7CC0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x41C6A10", Offset = "0x41C5410", VA = "0x1841C6A10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x41C8700", Offset = "0x41C7100", VA = "0x1841C8700")]
		private void PCCJKNMAFCK(ANIMKGBLAIA AGGJCDBCIGG, PKJIFCGPPAP GHPOPHGMALI, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x41C7230", Offset = "0x41C5C30", VA = "0x1841C7230")]
		private void IDJIEDNNPOJ(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO LOEHEMFAONC, ABKAKFBNEMO LMBBEFCIFMN, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x41C6F50", Offset = "0x41C5950", VA = "0x1841C6F50")]
		private void GOPELDOKBPP(ANIMKGBLAIA AGGJCDBCIGG, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x41C7430", Offset = "0x41C5E30", VA = "0x1841C7430", Slot = "14")]
		public IDisposable IGBDNEOOEDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x41C6520", Offset = "0x41C4F20", VA = "0x1841C6520", Slot = "9")]
		public IDisposable BBEEILHHNGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x41C8880", Offset = "0x41C7280", VA = "0x1841C8880", Slot = "6")]
		public UndoAction PDLDFMMEGKD()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x41C8370", Offset = "0x41C6D70", VA = "0x1841C8370", Slot = "15")]
		public RedoAction NKAFKPMHCKK()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x41C7370", Offset = "0x41C5D70", VA = "0x1841C7370", Slot = "16")]
		public UndoAction IFBJNHFHFPA()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x41C8250", Offset = "0x41C6C50", VA = "0x1841C8250", Slot = "7")]
		public RedoAction NKAFKPMHCKK(UndoAction BJCKADBMKDM)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x41C7250", Offset = "0x41C5C50", VA = "0x1841C7250", Slot = "8")]
		public UndoAction IFBJNHFHFPA(RedoAction BJCKADBMKDM)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x41C6ED0", Offset = "0x41C58D0", VA = "0x1841C6ED0")]
		public bool FFHIHIMNAFE(GCILNCEEAAG MEDDANPKJCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x41C8940", Offset = "0x41C7340", VA = "0x1841C8940", Slot = "17")]
		public void PDOAHDCGLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x41C79E0", Offset = "0x41C63E0", VA = "0x1841C79E0")]
		public void LKMKADFFOOH(ANIMKGBLAIA AGGJCDBCIGG, PKJIFCGPPAP GHPOPHGMALI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x41C75D0", Offset = "0x41C5FD0", VA = "0x1841C75D0")]
		public void KHMCCGMMCKH(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH, in ABKAKFBNEMO LMBBEFCIFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x41C8580", Offset = "0x41C6F80", VA = "0x1841C8580")]
		public void OECFJIPCLJJ(ANIMKGBLAIA AGGJCDBCIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x41C89F0", Offset = "0x41C73F0", VA = "0x1841C89F0")]
		private void PHPMMIACFCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x41C8A50", Offset = "0x41C7450", VA = "0x1841C8A50")]
		private void PMKGHJPBDCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x41C7210", Offset = "0x41C5C10", VA = "0x1841C7210")]
		private void HDFGDDBBFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x41C6870", Offset = "0x41C5270", VA = "0x1841C6870")]
		private GHHOGALHDGI DLPACPHCNLL()
		{
			return default(GHHOGALHDGI);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x41C6500", Offset = "0x41C4F00", VA = "0x1841C6500")]
		private uint APJDMNMMCNG()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x41C8A30", Offset = "0x41C7430", VA = "0x1841C8A30")]
		private bool PIOGDEDHCPP(out GHHOGALHDGI DJJNLDOINEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x41C8230", Offset = "0x41C6C30", VA = "0x1841C8230")]
		private bool NFEGNMKCBIN(out GHHOGALHDGI DJJNLDOINEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x41C8520", Offset = "0x41C6F20", VA = "0x1841C8520")]
		private RedoAction ODFDCEFJLDE(GHHOGALHDGI DJJNLDOINEG)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x41C8990", Offset = "0x41C7390", VA = "0x1841C8990")]
		private UndoAction PFFGCMFMFAO(GHHOGALHDGI DJJNLDOINEG)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x41C7710", Offset = "0x41C6110", VA = "0x1841C7710")]
		private GHHOGALHDGI LBIMOOCBIFL(GHHOGALHDGI DJJNLDOINEG, ActionBuffer GCCENLCFCNC, bool PDKEKIHJBDF)
		{
			return default(GHHOGALHDGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x41C8440", Offset = "0x41C6E40", VA = "0x1841C8440")]
		private void NPPMNADOHII(Action DJJNLDOINEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x323C6D0", Offset = "0x323B0D0", VA = "0x18323C6D0")]
		private T NPPMNADOHII<T>(Func<T> MLPLHCKADLH)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x41C6F10", Offset = "0x41C5910", VA = "0x1841C6F10")]
		private LHHCEHHMCOI FMJEMDCBAEJ(bool PDKEKIHJBDF, uint LHIPGOMOMEB)
		{
			return default(LHHCEHHMCOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x41C8B70", Offset = "0x41C7570", VA = "0x1841C8B70")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x41C7B70", Offset = "0x41C6570", VA = "0x1841C7B70")]
		[CompilerGenerated]
		private UndoAction LMNMMNBANMC()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x41C6D50", Offset = "0x41C5750", VA = "0x1841C6D50")]
		[CompilerGenerated]
		private RedoAction EGCGHMKGGBK()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x41C6580", Offset = "0x41C4F80", VA = "0x1841C6580")]
		[CompilerGenerated]
		private UndoAction BBKKPNKEEAJ()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LFBNINGGGOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> HPOICFFOIAP;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int ANNFCHOJNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1A6E300", Offset = "0x1A6CD00", VA = "0x181A6E300")]
	public LFBNINGGGOJ(NativeArray<byte> HPOICFFOIAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC480", Offset = "0x3DDAE80", VA = "0x183DDC480")]
	public static LFBNINGGGOJ EHMKDPHHPBI(NativeArray<byte> HPOICFFOIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T BANODLNDDJF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> LHAHKABKDOM<T>(int GIDABKFIKCN, Allocator APPJGCOGPBM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> HGKHANELDNJ<T>(Allocator APPJGCOGPBM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class MNGMBMLPIFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> HPOICFFOIAP;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int ANNFCHOJNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x1A6E300", Offset = "0x1A6CD00", VA = "0x181A6E300")]
	public MNGMBMLPIFL(NativeArray<byte> HPOICFFOIAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3DE02B0", Offset = "0x3DDECB0", VA = "0x183DE02B0")]
	public static MNGMBMLPIFL EHMKDPHHPBI(NativeArray<byte> HPOICFFOIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x37D8050", Offset = "0x37D6A50", VA = "0x1837D8050")]
	public T BANODLNDDJF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> LHAHKABKDOM<T>(int GIDABKFIKCN, Allocator APPJGCOGPBM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class ANMINICEOKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> HPOICFFOIAP;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int ANNFCHOJNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x1A6E300", Offset = "0x1A6CD00", VA = "0x181A6E300")]
	public ANMINICEOKG(NativeArray<byte> HPOICFFOIAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3E77E40", Offset = "0x3E76840", VA = "0x183E77E40")]
	public static ANMINICEOKG EHMKDPHHPBI(NativeArray<byte> HPOICFFOIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BC50", Offset = "0x3B9A650", VA = "0x183B9BC50")]
	public void KHKKGLPBKEH<T>(in T MFBGAMJDOKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BB50", Offset = "0x3B9A550", VA = "0x183B9BB50")]
	public void AIHPNNOODGC<T>(NativeArray<T> EHFHEFGEMIO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void ABAOIIMPDPK<T>(NativeArray<T> MFBGAMJDOKA) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KCOOALBAPKG
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x41D1890", Offset = "0x41D0290", VA = "0x1841D1890")]
	public static Span<byte> ICMBLLMELJH(this NativeArray<byte> HPOICFFOIAP)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x41D1690", Offset = "0x41D0090", VA = "0x1841D1690")]
	public static ReadOnlySpan<byte> EDKBFJLIHDN(this NativeArray<byte> HPOICFFOIAP)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x41D1920", Offset = "0x41D0320", VA = "0x1841D1920")]
	public static NativeArray<byte> IJPIJGIKHKB(this NativeArray<byte> HPOICFFOIAP, int ONAOKOFPGLK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x41D19A0", Offset = "0x41D03A0", VA = "0x1841D19A0")]
	public static NativeArray<byte> NBFJHLLDONA(this NativeArray<byte> HPOICFFOIAP, int HGMGPFAJPJI = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x38E27F0", Offset = "0x38E11F0", VA = "0x1838E27F0")]
	public static NativeArray<byte> NBFJHLLDONA<T>(this NativeArray<byte> HPOICFFOIAP, int HGMGPFAJPJI = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x41D1A20", Offset = "0x41D0420", VA = "0x1841D1A20")]
	public static NativeArray<byte> NJBJKBNNGAB(this NativeArray<byte> HPOICFFOIAP, int HGMGPFAJPJI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x38E2850", Offset = "0x38E1250", VA = "0x1838E2850")]
	public static NativeArray<byte> NJBJKBNNGAB<T>(this NativeArray<byte> HPOICFFOIAP, int HGMGPFAJPJI = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x41D1810", Offset = "0x41D0210", VA = "0x1841D1810")]
	public static NativeArray<byte> FEOKJHCEHMN(this NativeArray<byte> HPOICFFOIAP, int HGMGPFAJPJI = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x38E12B0", Offset = "0x38DFCB0", VA = "0x1838E12B0")]
	public static NativeArray<byte> FEOKJHCEHMN<T>(this NativeArray<byte> HPOICFFOIAP, int HGMGPFAJPJI = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BEBMBEIGCEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> ECNPNAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1A6E300", Offset = "0x1A6CD00", VA = "0x181A6E300")]
	public BEBMBEIGCEH(NativeList<byte> ECNPNAMGIHB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B870", Offset = "0x3E7A270", VA = "0x183E7B870")]
	public static BEBMBEIGCEH EHMKDPHHPBI(NativeList<byte> HPOICFFOIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void KHKKGLPBKEH<T>(in T MFBGAMJDOKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void AIHPNNOODGC<T>(NativeArray<T> MFBGAMJDOKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void ABAOIIMPDPK<T>(NativeArray<T> MFBGAMJDOKA) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.PropertyChanges)]
	public class PropertyChangeNetworkRouter : NMGDKBIHJIB, HNADMPPHDEF, EOLIEJMIFHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[JLCJNHHCBDK]
		private CGJENFCNODL GDCNFEACGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[JLCJNHHCBDK]
		private NPCKMHCNIEO PILEKMCPEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[JLCJNHHCBDK]
		private LOGDFEGPILN FJMPMGDNDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[JLCJNHHCBDK]
		private PropertyChangeRouterService KBECBEIHHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private FJODDPIOIFN DLGOBANMMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private AFIABGGOFDK JNEEPMMBIKJ;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public FJODDPIOIFN DBAEKOGFGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBE70", Offset = "0x3DFA870", VA = "0x183DFBE70")]
		public FJODDPIOIFN.LOHECJEMEDH MPCCGBJELDN()
		{
			return default(FJODDPIOIFN.LOHECJEMEDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB9D0", Offset = "0x3DFA3D0", VA = "0x183DFB9D0", Slot = "4")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBBD0", Offset = "0x3DFA5D0", VA = "0x183DFBBD0", Slot = "5")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB7B0", Offset = "0x3DFA1B0", VA = "0x183DFB7B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC220", Offset = "0x3DFAC20", VA = "0x183DFC220")]
		public void PDLDFMMEGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC330", Offset = "0x3DFAD30", VA = "0x183DFC330")]
		public void PDOAHDCGLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBBA0", Offset = "0x3DFA5A0", VA = "0x183DFBBA0")]
		private void MEBIKJJFODD(ANIMKGBLAIA AGGJCDBCIGG, PKJIFCGPPAP GHPOPHGMALI, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB740", Offset = "0x3DFA140", VA = "0x183DFB740")]
		private void ABILAKMBJII(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO LOEHEMFAONC, ABKAKFBNEMO LMBBEFCIFMN, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB780", Offset = "0x3DFA180", VA = "0x183DFB780")]
		private void CGIDAOFPDGN(ANIMKGBLAIA AGGJCDBCIGG, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBF30", Offset = "0x3DFA930", VA = "0x183DFBF30")]
		private void PDBOJIDHFLO(AFIABGGOFDK BMKGEKNDEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBA30", Offset = "0x3DFA430", VA = "0x183DFBA30")]
		private void IGPDFFKGJLB(AFIABGGOFDK BMKGEKNDEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC350", Offset = "0x3DFAD50", VA = "0x183DFC350")]
		private void PJANICBLJEE(AFIABGGOFDK BMKGEKNDEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBE50", Offset = "0x3DFA850", VA = "0x183DFBE50")]
		private void MOGDAADJEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBB60", Offset = "0x3DFA560", VA = "0x183DFBB60")]
		private void JEHJNELMGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBE90", Offset = "0x3DFA890", VA = "0x183DFBE90")]
		private void OLALLKIENCC(AFIABGGOFDK BMKGEKNDEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x47272F0", Offset = "0x4725CF0", VA = "0x1847272F0", Slot = "6")]
		private void ENINJCOANKF<TKey, T>(global::PGLJFENHHHK<TKey, T> EELLPGLCOLL, object BKJKDPLKCNE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[KEFMDJAGLBH(IGKCNDFEDMC.History)]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void IHDEJGFOKAP(ANIMKGBLAIA AGGJCDBCIGG, PKJIFCGPPAP GHPOPHGMALI, bool BFBIBHMCKGJ);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void HPCFHMIHDOB(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO LOEHEMFAONC, ABKAKFBNEMO LMBBEFCIFMN, bool BFBIBHMCKGJ);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void DGNDMDLIAAO(ANIMKGBLAIA AGGJCDBCIGG, bool BFBIBHMCKGJ);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IHDEJGFOKAP KMLFLFAGFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HPCFHMIHDOB GKDLGNGDDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public DGNDMDLIAAO EDLFOMBBBBL;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC4D0", Offset = "0x3DFAED0", VA = "0x183DFC4D0")]
		public void LKMKADFFOOH(ANIMKGBLAIA AGGJCDBCIGG, PKJIFCGPPAP GHPOPHGMALI, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC460", Offset = "0x3DFAE60", VA = "0x183DFC460")]
		public void KHMCCGMMCKH(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH, in ABKAKFBNEMO LOEHEMFAONC, in ABKAKFBNEMO LMBBEFCIFMN, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC4F0", Offset = "0x3DFAEF0", VA = "0x183DFC4F0")]
		public void OECFJIPCLJJ(ANIMKGBLAIA AGGJCDBCIGG, bool BFBIBHMCKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(IBOBHKEDOGO))]
	[KEFMDJAGLBH(IGKCNDFEDMC.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class IBOBHKEDOGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer CKDPLHPNFKM;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int GNKNLJGDNJB
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x3D1B5E0", Offset = "0x3D19FE0", VA = "0x183D1B5E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public ODJEFAJNIEB[] JJFDCEHGPCF
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x3D1B720", Offset = "0x3D1A120", VA = "0x183D1B720")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
			public IBOBHKEDOGO(ActionBuffer IFCOKMJPKNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B630", Offset = "0x3D1A030", VA = "0x183D1B630")]
			[CompilerGenerated]
			private ODJEFAJNIEB EMKIBNBMOFP(GHHOGALHDGI DJJNLDOINEG)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class ODJEFAJNIEB : EOLIEJMIFHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer CKDPLHPNFKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly GHHOGALHDGI DJJNLDOINEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(AFIABGGOFDK, string, object)> EHMMKOFECKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private MNGMBMLPIFL GNAHIECKPBK;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int GNKNLJGDNJB
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x3D1C980", Offset = "0x3D1B380", VA = "0x183D1C980")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(AFIABGGOFDK, string, object)> OGPAGLIELBB
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x3D1CE10", Offset = "0x3D1B810", VA = "0x183D1CE10")]
			public ODJEFAJNIEB(ActionBuffer IFCOKMJPKNL, GHHOGALHDGI DJJNLDOINEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x3D1C9D0", Offset = "0x3D1B3D0", VA = "0x183D1C9D0")]
			private string JENIPGNDEEI(AFIABGGOFDK JNEEPMMBIKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x3D1CAD0", Offset = "0x3D1B4D0", VA = "0x183D1CAD0")]
			private void LFPDFEJCFOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x3A4FA70", Offset = "0x3A4E470", VA = "0x183A4FA70", Slot = "4")]
			public void OFDECHGBDFD<TKey, T>(global::PGLJFENHHHK<TKey, T> EELLPGLCOLL, [Optional] object BKJKDPLKCNE) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> JBCBBGBMKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<GHHOGALHDGI> PMCDLKFEOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly HOPPGHHFMFA PGCOCOOEHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly DICONAJFMFK CNOHBONCFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly NPCKMHCNIEO PILEKMCPEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool LIIOCAKFMFB;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public BMLGNDFCPPC LEJKACPKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x3E785B0", Offset = "0x3E76FB0", VA = "0x183E785B0")]
			get
			{
				return default(BMLGNDFCPPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int GNKNLJGDNJB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x3E78570", Offset = "0x3E76F70", VA = "0x183E78570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E79210", Offset = "0x3E77C10", VA = "0x183E79210")]
		public ActionBuffer(DICONAJFMFK CNOHBONCFPD, NPCKMHCNIEO PILEKMCPEGL, bool LIIOCAKFMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E78880", Offset = "0x3E77280", VA = "0x183E78880")]
		public bool FCKOHIBHNFB(out GHHOGALHDGI DJJNLDOINEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E78F50", Offset = "0x3E77950", VA = "0x183E78F50")]
		public void PDOAHDCGLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E78E10", Offset = "0x3E77810", VA = "0x183E78E10")]
		public GHHOGALHDGI PDLDFMMEGKD(GELIACAFDDO EHMMKOFECKO, DMNIOAOADAO FGGHHPPAGMM, uint LCKDJOHGGCE)
		{
			return default(GHHOGALHDGI);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E785F0", Offset = "0x3E76FF0", VA = "0x183E785F0")]
		public bool DEAHFHOKFLC(uint LCKDJOHGGCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E78620", Offset = "0x3E77020", VA = "0x183E78620")]
		public bool DHEFCIAAAPE(uint LCKDJOHGGCE, out GHHOGALHDGI BJCKADBMKDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E78CA0", Offset = "0x3E776A0", VA = "0x183E78CA0")]
		public void PANLBPHLBNI(GHHOGALHDGI BJCKADBMKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E78FC0", Offset = "0x3E779C0", VA = "0x183E78FC0")]
		[Conditional("DEBUG_BUILD")]
		private void PGLLILKDOIN(GHHOGALHDGI BJCKADBMKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E78910", Offset = "0x3E77310", VA = "0x183E78910")]
		private void LBIMOOCBIFL(GHHOGALHDGI OLLEDAPBLCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E78A20", Offset = "0x3E77420", VA = "0x183E78A20")]
		private void LDGAEMBLHOK(MNGMBMLPIFL JGCAHALAOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E78510", Offset = "0x3E76F10", VA = "0x183E78510")]
		private void BHLPHFLLLKI(GHHOGALHDGI DJJNLDOINEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E79100", Offset = "0x3E77B00", VA = "0x183E79100")]
		private MNGMBMLPIFL PNPOONAJCPH(GHHOGALHDGI DJJNLDOINEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E78810", Offset = "0x3E77210", VA = "0x183E78810", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class HOPPGHHFMFA : EOLIEJMIFHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly DICONAJFMFK CNOHBONCFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly NPCKMHCNIEO PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private ANIMKGBLAIA AGGJCDBCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private MNGMBMLPIFL AIFNOJEHMMD;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x84CDF0", Offset = "0x84B7F0", VA = "0x18084CDF0")]
	public HOPPGHHFMFA(DICONAJFMFK CNOHBONCFPD, NPCKMHCNIEO PILEKMCPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x30E04F0", Offset = "0x30DEEF0", VA = "0x1830E04F0", Slot = "4")]
	public void OFDECHGBDFD<TKey, T>(global::PGLJFENHHHK<TKey, T> DIMPHKEFLJC, [Optional] object BKJKDPLKCNE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x41C6230", Offset = "0x41C4C30", VA = "0x1841C6230")]
	public void MDLBBNFEBPN(AFIABGGOFDK JNEEPMMBIKJ, ref MNGMBMLPIFL JGCAHALAOHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FJODDPIOIFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct LOHECJEMEDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly FJODDPIOIFN EOBFGLJBCIJ;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x47C85F0", Offset = "0x47C6FF0", VA = "0x1847C85F0")]
		public LOHECJEMEDH(FJODDPIOIFN EOBFGLJBCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x47C85D0", Offset = "0x47C6FD0", VA = "0x1847C85D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected GELIACAFDDO EHMMKOFECKO;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public GELIACAFDDO OGPAGLIELBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x4124920", Offset = "0x4123320", VA = "0x184124920")]
		get
		{
			return default(GELIACAFDDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool CFLDIBKDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x41C21F0", Offset = "0x41C0BF0", VA = "0x1841C21F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x41C2420", Offset = "0x41C0E20", VA = "0x1841C2420")]
	public FJODDPIOIFN(GELIACAFDDO.POMFODBEJKE HJDEGMKEHHI = GELIACAFDDO.POMFODBEJKE.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x41C2410", Offset = "0x41C0E10", VA = "0x1841C2410")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x41C2100", Offset = "0x41C0B00", VA = "0x1841C2100")]
	public void LKMKADFFOOH(ANIMKGBLAIA AGGJCDBCIGG, PKJIFCGPPAP GHPOPHGMALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x41C2070", Offset = "0x41C0A70", VA = "0x1841C2070")]
	public void KHMCCGMMCKH(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x41C2330", Offset = "0x41C0D30", VA = "0x1841C2330")]
	public void OECFJIPCLJJ(ANIMKGBLAIA AGGJCDBCIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x41C2200", Offset = "0x41C0C00", VA = "0x1841C2200")]
	public void MOGDAADJEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x41C1F70", Offset = "0x41C0970", VA = "0x1841C1F70")]
	public void JEHJNELMGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x41C1F60", Offset = "0x41C0960", VA = "0x1841C1F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x41C2300", Offset = "0x41C0D00", VA = "0x1841C2300")]
	public LOHECJEMEDH MPCCGBJELDN()
	{
		return default(LOHECJEMEDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct AFIABGGOFDK : IComparable<AFIABGGOFDK>, IEquatable<AFIABGGOFDK>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly AFIABGGOFDK CJDCPGONDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public ANIMKGBLAIA AGGJCDBCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public KOPBFNLIDKA OAOKPGOEMMH;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool GGNGOEANAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E77550", Offset = "0x3E75F50", VA = "0x183E77550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x9480E0", Offset = "0x946AE0", VA = "0x1809480E0")]
	public AFIABGGOFDK(ANIMKGBLAIA AGGJCDBCIGG, KOPBFNLIDKA OAOKPGOEMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E775F0", Offset = "0x3E75FF0", VA = "0x183E775F0")]
	public void KPKEANDJOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E773E0", Offset = "0x3E75DE0", VA = "0x183E773E0", Slot = "4")]
	public int CompareTo(AFIABGGOFDK EHBPAFKHADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E77600", Offset = "0x3E76000", VA = "0x183E77600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E77460", Offset = "0x3E75E60", VA = "0x183E77460", Slot = "0")]
	public override bool Equals(object OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E77500", Offset = "0x3E75F00", VA = "0x183E77500", Slot = "5")]
	public bool Equals(AFIABGGOFDK EHBPAFKHADK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E77420", Offset = "0x3E75E20", VA = "0x183E77420")]
	public static bool ENMIHMCKBEN(AFIABGGOFDK OLGHNLLKLDL, AFIABGGOFDK JPDHFMDKHGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E775A0", Offset = "0x3E75FA0", VA = "0x183E775A0")]
	public static bool IDBOJBLCJLG(AFIABGGOFDK OLGHNLLKLDL, AFIABGGOFDK JPDHFMDKHGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E77560", Offset = "0x3E75F60", VA = "0x183E77560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[KEFMDJAGLBH(IGKCNDFEDMC.History)]
	public class GatherPropertiesForUndelete : ODPNBOHGFMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private DICONAJFMFK CNOHBONCFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private ANIMKGBLAIA AGGJCDBCIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService EHAAMKHMDDE;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x41C5330", Offset = "0x41C3D30", VA = "0x1841C5330")]
		public void HMBHGJLHAIG(ANIMKGBLAIA AGGJCDBCIGG, DICONAJFMFK CNOHBONCFPD, HistoryService EHAAMKHMDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x41C5260", Offset = "0x41C3C60", VA = "0x1841C5260", Slot = "4")]
		private void GHPLGHAGKNC(CIMCFICPKBP EELLPGLCOLL, in ABKAKFBNEMO MFBGAMJDOKA, object BKJKDPLKCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class CEPDPNJFBMK
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E81680", Offset = "0x3E80080", VA = "0x183E81680")]
	public static void IGPDFFKGJLB(GELIACAFDDO EHMMKOFECKO, AFIABGGOFDK JNEEPMMBIKJ, PKJIFCGPPAP GHPOPHGMALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E815C0", Offset = "0x3E7FFC0", VA = "0x183E815C0")]
	public static void BBCEAFKMMDF(GELIACAFDDO EHMMKOFECKO, AFIABGGOFDK JNEEPMMBIKJ, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E818D0", Offset = "0x3E802D0", VA = "0x183E818D0")]
	public static void PJANICBLJEE(GELIACAFDDO EHMMKOFECKO, AFIABGGOFDK JNEEPMMBIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E81780", Offset = "0x3E80180", VA = "0x183E81780")]
	public static void KDMDNIFIEAA(GELIACAFDDO EHMMKOFECKO, AFIABGGOFDK JNEEPMMBIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3E81830", Offset = "0x3E80230", VA = "0x183E81830")]
	public static PKJIFCGPPAP PIHDDOKKKOF(GELIACAFDDO EHMMKOFECKO, AFIABGGOFDK JNEEPMMBIKJ)
	{
		return default(PKJIFCGPPAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3451A90", Offset = "0x3450490", VA = "0x183451A90")]
	public static T IIDNGDHOKGB<T>(GELIACAFDDO EHMMKOFECKO, AFIABGGOFDK JNEEPMMBIKJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3451A60", Offset = "0x3450460", VA = "0x183451A60")]
	public static T IIDNGDHOKGB<T>(ref MNGMBMLPIFL MNILNHMNKJK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3E81880", Offset = "0x3E80280", VA = "0x183E81880")]
	public static PKJIFCGPPAP PIHDDOKKKOF(ref MNGMBMLPIFL MNILNHMNKJK)
	{
		return default(PKJIFCGPPAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct GELIACAFDDO : IEnumerable<AFIABGGOFDK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum POMFODBEJKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct LEGCIMPHNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly GELIACAFDDO ECNPNAMGIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DMNIOAOADAO FGGHHPPAGMM;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x47C6960", Offset = "0x47C5360", VA = "0x1847C6960")]
		public LEGCIMPHNKL(GELIACAFDDO ECNPNAMGIHB, DMNIOAOADAO FGGHHPPAGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x47C6420", Offset = "0x47C4E20", VA = "0x1847C6420")]
		public void JHJBFMCBCJH(NativeList<byte> PDPOBLJIPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x47C66C0", Offset = "0x47C50C0", VA = "0x1847C66C0")]
		private void NBEHGHIMHBE(AFIABGGOFDK JNEEPMMBIKJ, ref ANMINICEOKG MGDOHGPILLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x47C6390", Offset = "0x47C4D90", VA = "0x1847C6390")]
		private void GEOLAPBELEE(AFIABGGOFDK JNEEPMMBIKJ, ref ANMINICEOKG MGDOHGPILLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x47C62A0", Offset = "0x47C4CA0", VA = "0x1847C62A0")]
		private NativeArray<byte> FCFPLOEJBMC(NativeList<byte> PDPOBLJIPNK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x47C61B0", Offset = "0x47C4BB0", VA = "0x1847C61B0")]
		private NativeArray<byte> EOHDJPEEPHF(NativeList<byte> PDPOBLJIPNK, int GIDABKFIKCN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x47C6710", Offset = "0x47C5110", VA = "0x1847C6710")]
		private int OIOIJKLEOGP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x47C6050", Offset = "0x47C4A50", VA = "0x1847C6050")]
		private bool CHBIHKMDMLF(AFIABGGOFDK JNEEPMMBIKJ, out NativeArray<byte> PMACOOFCCJI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ICDMAJEJICD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> MNILNHMNKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private GELIACAFDDO ECNPNAMGIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly AFIABGGOFDK BMKGEKNDEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int ONAOKOFPGLK;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x47C4860", Offset = "0x47C3260", VA = "0x1847C4860")]
		internal ICDMAJEJICD(GELIACAFDDO ECNPNAMGIHB, AFIABGGOFDK BMKGEKNDEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x47C4640", Offset = "0x47C3040", VA = "0x1847C4640", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x47C4800", Offset = "0x47C3200", VA = "0x1847C4800")]
		public void OICKHPLGCBL(NativeArray<byte> MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x47C45E0", Offset = "0x47C2FE0", VA = "0x1847C45E0")]
		public void BFPJJPLJIAO(NativeArray<byte> MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x47C4670", Offset = "0x47C3070", VA = "0x1847C4670")]
		public void GEOLAPBELEE(in ABKAKFBNEMO MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1810", Offset = "0x3BF0210", VA = "0x183BF1810")]
		public void GEOLAPBELEE<T>(T MFBGAMJDOKA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x47C4790", Offset = "0x47C3190", VA = "0x1847C4790")]
		private void NHOCEDMMEPH(int MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x47C4680", Offset = "0x47C3080", VA = "0x1847C4680")]
		private void NHOCEDMMEPH(in ABKAKFBNEMO MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x47C4730", Offset = "0x47C3130", VA = "0x1847C4730")]
		private unsafe void NHOCEDMMEPH(void* OFEEEPECGLA, int GIDABKFIKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x47C4800", Offset = "0x47C3200", VA = "0x1847C4800")]
		private void NHOCEDMMEPH(NativeArray<byte> EHFHEFGEMIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LIHJLBJEALA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private GELIACAFDDO ECNPNAMGIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> MNILNHMNKJK;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x47C71D0", Offset = "0x47C5BD0", VA = "0x1847C71D0")]
		internal LIHJLBJEALA(GELIACAFDDO ECNPNAMGIHB, NativeArray<byte> MNILNHMNKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x47C7010", Offset = "0x47C5A10", VA = "0x1847C7010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x47C7110", Offset = "0x47C5B10", VA = "0x1847C7110")]
		public NativeArray<byte> LHAHKABKDOM(int GIDABKFIKCN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x47C7020", Offset = "0x47C5A20", VA = "0x1847C7020")]
		public NativeArray<byte> HGKHANELDNJ()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3C03140", Offset = "0x3C01B40", VA = "0x183C03140")]
		public T BANODLNDDJF<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x47C6F10", Offset = "0x47C5910", VA = "0x1847C6F10")]
		public void BANODLNDDJF(in PGINEPENLDH MFBGAMJDOKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct IMMLBGPLNJE : IEnumerator<AFIABGGOFDK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<AFIABGGOFDK> HPOICFFOIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int ALJOMNDNEBM;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public AFIABGGOFDK LEJKACPKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x47C4B40", Offset = "0x47C3540", VA = "0x1847C4B40", Slot = "4")]
			get
			{
				return default(AFIABGGOFDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x47C4B00", Offset = "0x47C3500", VA = "0x1847C4B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x4123230", Offset = "0x4121C30", VA = "0x184123230")]
		internal IMMLBGPLNJE(NativeList<AFIABGGOFDK> EHFHEFGEMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x47C49C0", Offset = "0x47C33C0", VA = "0x1847C49C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x47C4AC0", Offset = "0x47C34C0", VA = "0x1847C4AC0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct AEPHNCOANBG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int JPLCEECICBE = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int DGLJHCKEMCG = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int ODCDFJAIOJE = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> MNILNHMNKJK;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool DBBBFNFEPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x47BE4B0", Offset = "0x47BCEB0", VA = "0x1847BE4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int PGMPGEPPKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x47BE450", Offset = "0x47BCE50", VA = "0x1847BE450")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x47BE3D0", Offset = "0x47BCDD0", VA = "0x1847BE3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public POMFODBEJKE FGMOGJOFMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x47BE520", Offset = "0x47BCF20", VA = "0x1847BE520")]
			get
			{
				return default(POMFODBEJKE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x47BE4A0", Offset = "0x47BCEA0", VA = "0x1847BE4A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool CFLDIBKDGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x47BE4F0", Offset = "0x47BCEF0", VA = "0x1847BE4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x47BE500", Offset = "0x47BCF00", VA = "0x1847BE500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool AFLEMPPILGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x47BE440", Offset = "0x47BCE40", VA = "0x1847BE440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x47BE3E0", Offset = "0x47BCDE0", VA = "0x1847BE3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x47BE530", Offset = "0x47BCF30", VA = "0x1847BE530")]
		public AEPHNCOANBG(POMFODBEJKE HJDEGMKEHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x47BE3A0", Offset = "0x47BCDA0", VA = "0x1847BE3A0")]
		private int ABMJNALEGDK(int FAOFKPMBKFB, int GHLILHNHHNJ = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x47BE400", Offset = "0x47BCE00", VA = "0x1847BE400")]
		private void CKIEIOOCMAM(int FAOFKPMBKFB, int MFBGAMJDOKA, int GHLILHNHHNJ = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x47BE460", Offset = "0x47BCE60", VA = "0x1847BE460", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int JAJDJPAOCIN = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int HHNLBDGFHMB = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly AFIABGGOFDK GKDOFDLPHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<AFIABGGOFDK, int> HBKOJODLDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<AFIABGGOFDK> EHMMKOFECKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> MHLGLNEDNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> BBEFLJIMIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> MNILNHMNKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private AEPHNCOANBG PJBJFAJEGCC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CFLDIBKDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x41C34A0", Offset = "0x41C1EA0", VA = "0x1841C34A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool IEFLJCGDFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x41C2F40", Offset = "0x41C1940", VA = "0x1841C2F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int PGMPGEPPKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x41C2E10", Offset = "0x41C1810", VA = "0x1841C2E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int OCOBLIHJDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x41C2F00", Offset = "0x41C1900", VA = "0x1841C2F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool DBBBFNFEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x41C3140", Offset = "0x41C1B40", VA = "0x1841C3140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x41C3180", Offset = "0x41C1B80", VA = "0x1841C3180")]
	public static GELIACAFDDO KMLFLFAGFOK(POMFODBEJKE HJDEGMKEHHI = POMFODBEJKE.Last, int PLKEDEDJNED = 16, int HMLEIJGFOOA = 256)
	{
		return default(GELIACAFDDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x41C3AB0", Offset = "0x41C24B0", VA = "0x1841C3AB0")]
	private GELIACAFDDO(POMFODBEJKE HJDEGMKEHHI, int PLKEDEDJNED, int HMLEIJGFOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x41C2E20", Offset = "0x41C1820", VA = "0x1841C2E20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x41C3840", Offset = "0x41C2240", VA = "0x1841C3840")]
	public ICDMAJEJICD PDBOJIDHFLO(AFIABGGOFDK BMKGEKNDEIG)
	{
		return default(ICDMAJEJICD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x41C34B0", Offset = "0x41C1EB0", VA = "0x1841C34B0")]
	public LIHJLBJEALA NBIKCGCONDL(AFIABGGOFDK BMKGEKNDEIG)
	{
		return default(LIHJLBJEALA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x41C32B0", Offset = "0x41C1CB0", VA = "0x1841C32B0")]
	public bool MBBBMOJMNMN(AFIABGGOFDK BMKGEKNDEIG, out LIHJLBJEALA KHIBGIIIKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x41C2DC0", Offset = "0x41C17C0", VA = "0x1841C2DC0")]
	public bool AMECPEFPCHA(AFIABGGOFDK BMKGEKNDEIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x41C3540", Offset = "0x41C1F40", VA = "0x1841C3540")]
	public bool NLABJCMEDNJ(AFIABGGOFDK BMKGEKNDEIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x41C2F60", Offset = "0x41C1960", VA = "0x1841C2F60")]
	public void FAJPNOGECCC(NativeList<byte> PDPOBLJIPNK, DMNIOAOADAO FGGHHPPAGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x30CB0F0", Offset = "0x30C9AF0", VA = "0x1830CB0F0")]
	public T JILIAHNOHMA<T>(AFIABGGOFDK BMKGEKNDEIG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x41C38D0", Offset = "0x41C22D0", VA = "0x1841C38D0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x41C3610", Offset = "0x41C2010", VA = "0x1841C3610")]
	public IMMLBGPLNJE ODEOKNNCFHI()
	{
		return default(IMMLBGPLNJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x41C3650", Offset = "0x41C2050", VA = "0x1841C3650")]
	private void OFLLDELGNPK(AFIABGGOFDK BMKGEKNDEIG, int ONAOKOFPGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x41C31C0", Offset = "0x41C1BC0", VA = "0x1841C31C0")]
	private void KPKEANDJOLG(int BNFGGPMGGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x41C3050", Offset = "0x41C1A50", VA = "0x1841C3050")]
	private void GFPFIAICMGJ(AFIABGGOFDK BMKGEKNDEIG, int ONAOKOFPGLK, int GIDABKFIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x30CB070", Offset = "0x30C9A70", VA = "0x1830CB070")]
	private static T JILIAHNOHMA<T>(NativeArray<byte> HPOICFFOIAP, int FAOFKPMBKFB = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x41C39F0", Offset = "0x41C23F0", VA = "0x1841C39F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x41C39B0", Offset = "0x41C23B0", VA = "0x1841C39B0", Slot = "4")]
	private IEnumerator<AFIABGGOFDK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class PNLBANMMMMA<T> : HIEJFMJLCNL where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x43E9CD0", Offset = "0x43E86D0", VA = "0x1843E9CD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x43E9D60", Offset = "0x43E8760", VA = "0x1843E9D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x43E9DD0", Offset = "0x43E87D0", VA = "0x1843E9DD0")]
	public PNLBANMMMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x3166830", Offset = "0x3165230", VA = "0x183166830", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	internal class CleanupRigidbodyExImpl : HIEJFMJLCNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery IOEGIOMNPHI;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x3E85BE0", Offset = "0x3E845E0", VA = "0x183E85BE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x3E85C80", Offset = "0x3E84680", VA = "0x183E85C80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class NHAGDIJOGPC : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery AHIAPCNDKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0850", Offset = "0x3DDF250", VA = "0x183DE0850", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x3DE08A0", Offset = "0x3DDF2A0", VA = "0x183DE08A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0930", Offset = "0x3DDF330", VA = "0x183DE0930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public NHAGDIJOGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal class MAFFHAJKIJI : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService HAMHCCLCCBC;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEEC0", Offset = "0x3DDD8C0", VA = "0x183DDEEC0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEF10", Offset = "0x3DDD910", VA = "0x183DDEF10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public MAFFHAJKIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery IOEGIOMNPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService NJADCKCLHFK;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x3E92260", Offset = "0x3E90C60", VA = "0x183E92260", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3E922B0", Offset = "0x3E90CB0", VA = "0x183E922B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x3E92340", Offset = "0x3E90D40", VA = "0x183E92340", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
	[LHOECCIDBFM(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<NJMOENBKENH>> ALGDCDLMPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F150", Offset = "0x3E8DB50", VA = "0x183E8F150", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x3E8EB00", Offset = "0x3E8D500", VA = "0x183E8EB00")]
		public void ALJECANCEBJ(NativeListAsync<NJMOENBKENH> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x3E8ECE0", Offset = "0x3E8D6E0", VA = "0x183E8ECE0")]
		public void LNBOJGALCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8EB70", Offset = "0x3E8D570", VA = "0x183E8EB70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F1F0", Offset = "0x3E8DBF0", VA = "0x183E8F1F0")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[LHOECCIDBFM(typeof(PDPFABKPIDL), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public class PhysicsService : HNADMPPHDEF, BCGODABHHDD, PDPFABKPIDL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly NNLEPLPFODN LMAFOAMNLMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager IMCLABBJAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private PGLCALCJHHL DMFEGBKOECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService NGCEPKOKHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::HBNHJLIDJBP<ILDDBNLCALM> LMEALELNEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<GEEJJFIMDNA, ILDDBNLCALM> LOEFGGKBNAA
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8FC0", Offset = "0x3DF79C0", VA = "0x183DF8FC0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x3DF9060", Offset = "0x3DF7A60", VA = "0x183DF9060", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9100", Offset = "0x3DF7B00", VA = "0x183DF9100", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8B90", Offset = "0x3DF7590", VA = "0x183DF8B90", Slot = "5")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8970", Offset = "0x3DF7370", VA = "0x183DF8970", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8E30", Offset = "0x3DF7830", VA = "0x183DF8E30", Slot = "8")]
		public bool IELJFEGGAHC(GEEJJFIMDNA BJLPLHMBBOJ, out Collider JFHMOLIAPLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8AD0", Offset = "0x3DF74D0", VA = "0x183DF8AD0")]
		private void ECIGMBFFLPG(Entity OOGAMDNOHNH, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO GFPNEMALIHE, ABKAKFBNEMO JOOHHAMJDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8F00", Offset = "0x3DF7900", VA = "0x183DF8F00", Slot = "9")]
		public void JDAFLDOBBPI(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[LHOECCIDBFM(typeof(CEILNDOCFMN), new string[] { })]
	public class RbexService : HNADMPPHDEF, CEILNDOCFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private JJHOHFFKOJA BOCABFIDKKN;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x3D1DBC0", Offset = "0x3D1C5C0", VA = "0x183D1DBC0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FFB0", Offset = "0x3D1E9B0", VA = "0x183D1FFB0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F180", Offset = "0x3D1DB80", VA = "0x183D1F180", Slot = "6")]
		public CBHBHIBBFBM JPKPHLGMLAP(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x3D20890", Offset = "0x3D1F290", VA = "0x183D20890", Slot = "5")]
		public void PJOMFGFKKMJ(GEEJJFIMDNA BJLPLHMBBOJ, CBHBHIBBFBM MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D520", Offset = "0x3D1BF20", VA = "0x183D1D520", Slot = "34")]
		public CollisionDetectionMode AAKLDLBNIJK(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DF20", Offset = "0x3D1C920", VA = "0x183D1DF20", Slot = "35")]
		public void ECJGKPPCPHL(GEEJJFIMDNA BJLPLHMBBOJ, CollisionDetectionMode MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EEA0", Offset = "0x3D1D8A0", VA = "0x183D1EEA0", Slot = "36")]
		public AIFDGFHGOFL IHCKEGCBPDP(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(AIFDGFHGOFL);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D960", Offset = "0x3D1C360", VA = "0x183D1D960", Slot = "37")]
		public void BMOBADHOMNN(GEEJJFIMDNA BJLPLHMBBOJ, AIFDGFHGOFL MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E5E0", Offset = "0x3D1CFE0", VA = "0x183D1E5E0", Slot = "38")]
		public bool FMADGJAAPMN(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x3D200E0", Offset = "0x3D1EAE0", VA = "0x183D200E0", Slot = "39")]
		public void MKMGEAMIENK(GEEJJFIMDNA BJLPLHMBBOJ, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FEB0", Offset = "0x3D1E8B0", VA = "0x183D1FEB0", Slot = "40")]
		public GEEJJFIMDNA MHAMLAHOFJF(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x3D202B0", Offset = "0x3D1ECB0", VA = "0x183D202B0", Slot = "41")]
		public void NBAEKPGOBNP(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E0A0", Offset = "0x3D1CAA0", VA = "0x183D1E0A0", Slot = "42")]
		public GEEJJFIMDNA EOCIMCBAGPH(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DD40", Offset = "0x3D1C740", VA = "0x183D1DD40", Slot = "43")]
		public void CLOBJFNMHGM(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D850", Offset = "0x3D1C250", VA = "0x183D1D850", Slot = "7")]
		public void BMKFLEEHJJC(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E640", Offset = "0x3D1D040", VA = "0x183D1E640", Slot = "8")]
		public void FMALHNNINDF(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x3D207A0", Offset = "0x3D1F1A0", VA = "0x183D207A0", Slot = "9")]
		public int PEOFEJABMDB(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E4C0", Offset = "0x3D1CEC0", VA = "0x183D1E4C0", Slot = "10")]
		public GEEJJFIMDNA FKOMLICCHDO(GEEJJFIMDNA BJLPLHMBBOJ, int ALJOMNDNEBM)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EBA0", Offset = "0x3D1D5A0", VA = "0x183D1EBA0", Slot = "11")]
		public void HNAPBJMGIGN(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D640", Offset = "0x3D1C040", VA = "0x183D1D640", Slot = "12")]
		public void APIMOBIEGLA(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD, GEEJJFIMDNA MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F060", Offset = "0x3D1DA60", VA = "0x183D1F060", Slot = "13")]
		public void JDPAOPOEJJL(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x3D20640", Offset = "0x3D1F040", VA = "0x183D20640", Slot = "14")]
		public bool PCOEEDNOLNJ(GEEJJFIMDNA BJLPLHMBBOJ, out GEEJJFIMDNA MFBGAMJDOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DF90", Offset = "0x3D1C990", VA = "0x183D1DF90", Slot = "15")]
		public void EGKFBBABION(GEEJJFIMDNA BJLPLHMBBOJ, float3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E1D0", Offset = "0x3D1CBD0", VA = "0x183D1E1D0", Slot = "16")]
		public bool FALENLIAOEG(GEEJJFIMDNA BJLPLHMBBOJ, out float3 MFBGAMJDOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F7D0", Offset = "0x3D1E1D0", VA = "0x183D1F7D0", Slot = "17")]
		public void LEMCGNJKMKF(GEEJJFIMDNA BJLPLHMBBOJ, float3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F610", Offset = "0x3D1E010", VA = "0x183D1F610", Slot = "18")]
		public bool KKBMHNBACAB(GEEJJFIMDNA BJLPLHMBBOJ, out float3 MFBGAMJDOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E150", Offset = "0x3D1CB50", VA = "0x183D1E150", Slot = "26")]
		public float3 EOFDNIBPCAA(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FF30", Offset = "0x3D1E930", VA = "0x183D1FF30", Slot = "27")]
		public void MIFGEBHLHAH(GEEJJFIMDNA BJLPLHMBBOJ, float3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DB60", Offset = "0x3D1C560", VA = "0x183D1DB60", Slot = "28")]
		public float CCBLOEBEMJG(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D770", Offset = "0x3D1C170", VA = "0x183D1D770", Slot = "29")]
		public void BCFECMBGIMK(GEEJJFIMDNA BJLPLHMBBOJ, float MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E330", Offset = "0x3D1CD30", VA = "0x183D1E330", Slot = "30")]
		public float FHADNDIFINM(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x3D204A0", Offset = "0x3D1EEA0", VA = "0x183D204A0", Slot = "31")]
		public void OJFGCJEFEBN(GEEJJFIMDNA BJLPLHMBBOJ, float MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EAE0", Offset = "0x3D1D4E0", VA = "0x183D1EAE0", Slot = "32")]
		public bool HDNAANIBHBD(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F8B0", Offset = "0x3D1E2B0", VA = "0x183D1F8B0", Slot = "33")]
		public void LNCKBGLJHAO(GEEJJFIMDNA BJLPLHMBBOJ, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3D20060", Offset = "0x3D1EA60", VA = "0x183D20060", Slot = "19")]
		public void MKKPBGILIGD(GEEJJFIMDNA BJLPLHMBBOJ, float3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DA00", Offset = "0x3D1C400", VA = "0x183D1DA00", Slot = "20")]
		public bool BOOJODJDNHK(GEEJJFIMDNA BJLPLHMBBOJ, out float3 MFBGAMJDOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EE30", Offset = "0x3D1D830", VA = "0x183D1EE30", Slot = "21")]
		public void IDGNJEEMFFF(GEEJJFIMDNA BJLPLHMBBOJ, quaternion MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E980", Offset = "0x3D1D380", VA = "0x183D1E980", Slot = "22")]
		public bool HAFHKKMGPEL(GEEJJFIMDNA BJLPLHMBBOJ, out quaternion MFBGAMJDOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FA10", Offset = "0x3D1E410", VA = "0x183D1FA10", Slot = "23")]
		public bool MBKNPPDPJAD(GEEJJFIMDNA BJLPLHMBBOJ, out float3 IHKFEOOMLFB, out quaternion FKKNNGMIAPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D580", Offset = "0x3D1BF80", VA = "0x183D1D580", Slot = "44")]
		public INDOICOKDMJ AIECAIHKJEO(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(INDOICOKDMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DEB0", Offset = "0x3D1C8B0", VA = "0x183D1DEB0", Slot = "45")]
		public void EBINHNFNEGC(GEEJJFIMDNA BJLPLHMBBOJ, INDOICOKDMJ MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F0F0", Offset = "0x3D1DAF0", VA = "0x183D1F0F0", Slot = "72")]
		public void JKPGOJDNBBA(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EFD0", Offset = "0x3D1D9D0", VA = "0x183D1EFD0", Slot = "73")]
		public void IICLCBPIFNP(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EDB0", Offset = "0x3D1D7B0", VA = "0x183D1EDB0", Slot = "74")]
		public bool ICLNCCFIEMJ(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E010", Offset = "0x3D1CA10", VA = "0x183D1E010", Slot = "81")]
		public void EHBHDCAHCKD(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F920", Offset = "0x3D1E320", VA = "0x183D1F920", Slot = "82")]
		public void LNEPKKOHAAP(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x3D20330", Offset = "0x3D1ED30", VA = "0x183D20330", Slot = "83")]
		public bool NJAGDDEPCEB(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F510", Offset = "0x3D1DF10", VA = "0x183D1F510", Slot = "84")]
		public IEnumerable<object> KJAPGBAGEKK(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F3E0", Offset = "0x3D1DDE0", VA = "0x183D1F3E0", Slot = "46")]
		public bool KDKNGOGLFIB(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E390", Offset = "0x3D1CD90", VA = "0x183D1E390", Slot = "47")]
		public void FJMLJKGBABC(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F440", Offset = "0x3D1DE40", VA = "0x183D1F440", Slot = "48")]
		public bool KFJPCEFJPGE(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E8B0", Offset = "0x3D1D2B0", VA = "0x183D1E8B0", Slot = "49")]
		public void GKBFJCECIJH(GEEJJFIMDNA BJLPLHMBBOJ, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D5E0", Offset = "0x3D1BFE0", VA = "0x183D1D5E0", Slot = "50")]
		public bool AOGOPNIEGID(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DDC0", Offset = "0x3D1C7C0", VA = "0x183D1DDC0", Slot = "51")]
		public void DBJMLKAFNLE(GEEJJFIMDNA BJLPLHMBBOJ, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x3D20250", Offset = "0x3D1EC50", VA = "0x183D20250", Slot = "52")]
		public RigidbodyConstraints NAGECPHLNOM(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FCE0", Offset = "0x3D1E6E0", VA = "0x183D1FCE0", Slot = "53")]
		public void MGEFLAMJNJL(GEEJJFIMDNA BJLPLHMBBOJ, RigidbodyConstraints MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EB40", Offset = "0x3D1D540", VA = "0x183D1EB40", Slot = "54")]
		public float HHBMPMGHPNH(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E840", Offset = "0x3D1D240", VA = "0x183D1E840", Slot = "55")]
		public void GFEKAEHEDIB(GEEJJFIMDNA BJLPLHMBBOJ, float MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F770", Offset = "0x3D1E170", VA = "0x183D1F770", Slot = "56")]
		public float LBLKJMBBJBM(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F4A0", Offset = "0x3D1DEA0", VA = "0x183D1F4A0", Slot = "57")]
		public void KGCLLHGHBKN(GEEJJFIMDNA BJLPLHMBBOJ, float MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E7E0", Offset = "0x3D1D1E0", VA = "0x183D1E7E0", Slot = "58")]
		public bool GAHMGOHJJNJ(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F370", Offset = "0x3D1DD70", VA = "0x183D1F370", Slot = "59")]
		public void KAPPFCAONKJ(GEEJJFIMDNA BJLPLHMBBOJ, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FC80", Offset = "0x3D1E680", VA = "0x183D1FC80", Slot = "60")]
		public bool MDNIGCOFEHE(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x3D205A0", Offset = "0x3D1EFA0", VA = "0x183D205A0", Slot = "61")]
		public void ONNCFMMOPFH(GEEJJFIMDNA BJLPLHMBBOJ, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F9B0", Offset = "0x3D1E3B0", VA = "0x183D1F9B0", Slot = "62")]
		public int LNJIMABIPLA(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x3D20150", Offset = "0x3D1EB50", VA = "0x183D20150", Slot = "63")]
		public void MMEFMEALPBI(GEEJJFIMDNA BJLPLHMBBOJ, int MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x3D201C0", Offset = "0x3D1EBC0", VA = "0x183D201C0", Slot = "64")]
		public Rigidbody MNCPBNHLFJI(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F210", Offset = "0x3D1DC10", VA = "0x183D1F210", Slot = "65")]
		public void KANNOIGEGNE(GEEJJFIMDNA BJLPLHMBBOJ, Rigidbody MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3D203B0", Offset = "0x3D1EDB0", VA = "0x183D203B0", Slot = "75")]
		public void OCFIHCFGOOJ(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1ED20", Offset = "0x3D1D720", VA = "0x183D1ED20", Slot = "76")]
		public void IADKKHMCBAO(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DE30", Offset = "0x3D1C830", VA = "0x183D1DE30", Slot = "77")]
		public bool DIHGOKEECLM(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x3D20510", Offset = "0x3D1EF10", VA = "0x183D20510", Slot = "66")]
		public object OJKOPACMMAG(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DBE0", Offset = "0x3D1C5E0", VA = "0x183D1DBE0", Slot = "67")]
		public void CDNGIHNLMOL(GEEJJFIMDNA BJLPLHMBBOJ, object MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EF40", Offset = "0x3D1D940", VA = "0x183D1EF40", Slot = "68")]
		public object IHPPEBCBCEK(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FD50", Offset = "0x3D1E750", VA = "0x183D1FD50", Slot = "69")]
		public void MHAAFELMHJD(GEEJJFIMDNA BJLPLHMBBOJ, object MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E920", Offset = "0x3D1D320", VA = "0x183D1E920", Slot = "70")]
		public float GPENMGPJFPA(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D7E0", Offset = "0x3D1C1E0", VA = "0x183D1D7E0", Slot = "71")]
		public void BHOAJPBFJEB(GEEJJFIMDNA BJLPLHMBBOJ, float MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E750", Offset = "0x3D1D150", VA = "0x183D1E750", Slot = "78")]
		public void FMMHBBBCONG(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EC90", Offset = "0x3D1D690", VA = "0x183D1EC90", Slot = "79")]
		public void HNMMGLEDBCK(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D20940", Offset = "0x3D1F340", VA = "0x183D20940", Slot = "80")]
		public bool PMFPOCAICNI(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D20440", Offset = "0x3D1EE40", VA = "0x183D20440", Slot = "24")]
		public void ODPFILOFCIN(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F850", Offset = "0x3D1E250", VA = "0x183D1F850", Slot = "25")]
		public void LLJNNHBJKLP(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x46E5CA0", Offset = "0x46E46A0", VA = "0x1846E5CA0")]
		private void IDGKEENDGII<T>(GEEJJFIMDNA BJLPLHMBBOJ, bool MFBGAMJDOKA) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x46E5690", Offset = "0x46E4090", VA = "0x1846E5690")]
		private bool FHINOHHOGNH<T>(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x46E56F0", Offset = "0x46E40F0", VA = "0x1846E56F0")]
		private void HEOHJOBENDL<T>(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x46E4E30", Offset = "0x46E3830", VA = "0x1846E4E30")]
		private bool EGJJGICMKAD<TC, TV>(GEEJJFIMDNA BJLPLHMBBOJ, Func<TC, TV> MLPLHCKADLH, out TV MFBGAMJDOKA) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x46E4EE0", Offset = "0x46E38E0", VA = "0x1846E4EE0")]
		private bool EGJJGICMKAD<T>(GEEJJFIMDNA BJLPLHMBBOJ, out T MFBGAMJDOKA) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x46E5D50", Offset = "0x46E4750", VA = "0x1846E5D50")]
		private T LMIEOLDMFKI<T>(GEEJJFIMDNA BJLPLHMBBOJ) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x46E5750", Offset = "0x46E4150", VA = "0x1846E5750")]
		private void HOOPPLENJGE<T>(GEEJJFIMDNA BJLPLHMBBOJ, T MFBGAMJDOKA) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x46E5030", Offset = "0x46E3A30", VA = "0x1846E5030")]
		private void EGPHBPNPCLO<T>(GEEJJFIMDNA BJLPLHMBBOJ, T MFBGAMJDOKA) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x46E4EE0", Offset = "0x46E38E0", VA = "0x1846E4EE0")]
		private bool KOANDFCDLHB<T>(GEEJJFIMDNA BJLPLHMBBOJ, out T MFBGAMJDOKA) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x46E5CF0", Offset = "0x46E46F0", VA = "0x1846E5CF0")]
		private T KKONNDJOFHJ<T>(GEEJJFIMDNA BJLPLHMBBOJ) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x46E4EE0", Offset = "0x46E38E0", VA = "0x1846E4EE0")]
		private void IHLMOADBKCL<T>(GEEJJFIMDNA BJLPLHMBBOJ, T MFBGAMJDOKA) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x46E61A0", Offset = "0x46E4BA0", VA = "0x1846E61A0")]
		private void MEALLOHDLCJ<T>(GEEJJFIMDNA BJLPLHMBBOJ, T MFBGAMJDOKA) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D20610", Offset = "0x3D1F010", VA = "0x183D20610")]
		private GEEJJFIMDNA PCNIAJBAOEC(Entity OOGAMDNOHNH)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E3F0", Offset = "0x3D1CDF0", VA = "0x183D1E3F0")]
		private DynamicBuffer<Entity> FKNNGJJLEBE(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x46E6250", Offset = "0x46E4C50", VA = "0x1846E6250")]
		private void MGFBGCMKDNO<T>(GEEJJFIMDNA BJLPLHMBBOJ, object MFBGAMJDOKA, Func<object, T> MLPLHCKADLH) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void LFPDFEJCFOP<T>(ref global::NPAIFDLKEKJ<T> GJLENILPINE) where T : struct, MJEMKHPIPGA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void LFPDFEJCFOP<TC, TV>(ref global::BMCEMPIECED<TC, TV> GJLENILPINE) where TC : struct, MJEMKHPIPGA
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
	[LHOECCIDBFM(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class NHMOIPFKGIF : IEnumerable<CBHBHIBBFBM>, IEnumerable, IEnumerator<CBHBHIBBFBM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private CBHBHIBBFBM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			private CBHBHIBBFBM System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
			[DebuggerHidden]
			public NHMOIPFKGIF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x47C9B10", Offset = "0x47C8510", VA = "0x1847C9B10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x47C9830", Offset = "0x47C8230", VA = "0x1847C9830", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x47C9B90", Offset = "0x47C8590", VA = "0x1847C9B90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x47C9AD0", Offset = "0x47C84D0", VA = "0x1847C9AD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x47C9A20", Offset = "0x47C8420", VA = "0x1847C9A20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CBHBHIBBFBM> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x47C9A20", Offset = "0x47C8420", VA = "0x1847C9A20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> CMKEKOIPBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x41D3B80", Offset = "0x41D2580", VA = "0x1841D3B80", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x41D2EB0", Offset = "0x41D18B0", VA = "0x1841D2EB0")]
		public void ALJECANCEBJ(NativeArray<Entity> AJMHFNCBOJK, bool MLOMFIAJHBH, bool BAECMBAPNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x41D3970", Offset = "0x41D2370", VA = "0x1841D3970")]
		public void LNBOJGALCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x41D31B0", Offset = "0x41D1BB0", VA = "0x1841D31B0")]
		private void KJAKKIAENKN(NativeArray<Entity> AJMHFNCBOJK, bool MLOMFIAJHBH, bool BAECMBAPNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x41D2FD0", Offset = "0x41D19D0", VA = "0x1841D2FD0")]
		[IteratorStateMachine(typeof(NHMOIPFKGIF))]
		private IEnumerable<CBHBHIBBFBM> DPNJKLMAFGM(NativeArray<Entity> AJMHFNCBOJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x41D3060", Offset = "0x41D1A60", VA = "0x1841D3060", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x41D3C20", Offset = "0x41D2620", VA = "0x1841D3C20")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[LHOECCIDBFM(typeof(IALPALJEAJO), new string[] { })]
public class BBEGPIEMDGC : IALPALJEAJO, IEnumerable<HMBIKFADCFA>, IEnumerable, NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[JLCJNHHCBDK]
	private OJNMEFHLIGF PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> IGKBEMBDJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private JPGJEDNAMKP NFBJAAEHOOM;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E79F00", Offset = "0x3E78900", VA = "0x183E79F00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HMBIKFADCFA KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E79F70", Offset = "0x3E78970", VA = "0x183E79F70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public HMBIKFADCFA KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E79F70", Offset = "0x3E78970", VA = "0x183E79F70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E79F20", Offset = "0x3E78920", VA = "0x183E79F20", Slot = "11")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A450", Offset = "0x3E78E50", VA = "0x183E7A450", Slot = "12")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A4D0", Offset = "0x3E78ED0", VA = "0x183E7A4D0")]
	private void PBOBIGFLDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x33FC2A0", Offset = "0x33FACA0", VA = "0x1833FC2A0")]
	private string LONMEJLPPKC(string KMEGKECOLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A0C0", Offset = "0x3E78AC0", VA = "0x183E7A0C0", Slot = "7")]
	public HMBIKFADCFA IEJEFFFFMHC(ELPOGHCFKOG IDLOFIFEDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A1A0", Offset = "0x3E78BA0", VA = "0x183E7A1A0")]
	private bool LLKOCDPNAKB(Type KEHJLNIPGPM, string KMEGKECOLPJ, out HMBIKFADCFA LHICEFGLEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E79FB0", Offset = "0x3E789B0", VA = "0x183E79FB0", Slot = "8")]
	public KOPBFNLIDKA HMMGHMOMKKF(ELPOGHCFKOG IDLOFIFEDHN)
	{
		return default(KOPBFNLIDKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E79F90", Offset = "0x3E78990", VA = "0x183E79F90", Slot = "9")]
	public IEnumerator<HMBIKFADCFA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3E79F90", Offset = "0x3E78990", VA = "0x183E79F90", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A770", Offset = "0x3E79170", VA = "0x183E7A770")]
	public BBEGPIEMDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[DefaultMember("Item")]
public interface DMNIOAOADAO
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCIPFOLPJAH(KOPBFNLIDKA BEEBALICHLA, out int IMMPKDAEONJ);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[LHOECCIDBFM(typeof(DMNIOAOADAO), new string[] { })]
public class EHPBIBFPJIM : HNADMPPHDEF, BCGODABHHDD, DMNIOAOADAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[JLCJNHHCBDK]
	private NPCKMHCNIEO PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<KOPBFNLIDKA, int> CAOMFLNDHKO;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x41B7800", Offset = "0x41B6200", VA = "0x1841B7800", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x41B7AE0", Offset = "0x41B64E0", VA = "0x1841B7AE0", Slot = "6")]
	public bool MCIPFOLPJAH(KOPBFNLIDKA BEEBALICHLA, out int IMMPKDAEONJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x41B7B50", Offset = "0x41B6550", VA = "0x1841B7B50", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x41B7AD0", Offset = "0x41B64D0", VA = "0x1841B7AD0", Slot = "5")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x41B7860", Offset = "0x41B6260", VA = "0x1841B7860")]
	private void HEJFJENDBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x41B7BB0", Offset = "0x41B65B0", VA = "0x1841B7BB0")]
	public EHPBIBFPJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[LHOECCIDBFM(typeof(NPCKMHCNIEO), new string[] { })]
[DefaultMember("Item")]
public class PGAGLPLJCPC : NPCKMHCNIEO, IEnumerable<LEECANKHNKH>, IEnumerable, NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD, EOLIEJMIFHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[JLCJNHHCBDK]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[JLCJNHHCBDK]
	private IALPALJEAJO GBMNEHCEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private LEECANKHNKH[] BMNNAENACLN;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xDDDB20", Offset = "0xDDC520", VA = "0x180DDDB20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public LEECANKHNKH KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2A70", Offset = "0x3DF1470", VA = "0x183DF2A70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LEECANKHNKH KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2A70", Offset = "0x3DF1470", VA = "0x183DF2A70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "10")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2D90", Offset = "0x3DF1790", VA = "0x183DF2D90", Slot = "11")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "12")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2C60", Offset = "0x3DF1660", VA = "0x183DF2C60", Slot = "6")]
	public LEECANKHNKH IEJEFFFFMHC(ELPOGHCFKOG IDLOFIFEDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2B90", Offset = "0x3DF1590", VA = "0x183DF2B90", Slot = "7")]
	public KOPBFNLIDKA HMMGHMOMKKF(ELPOGHCFKOG IDLOFIFEDHN)
	{
		return default(KOPBFNLIDKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2AB0", Offset = "0x3DF14B0", VA = "0x183DF2AB0", Slot = "8")]
	public IEnumerator<LEECANKHNKH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3030", Offset = "0x3DF1A30", VA = "0x183DF3030", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x393CB70", Offset = "0x393B570", VA = "0x18393CB70", Slot = "13")]
	public void OFDECHGBDFD<TKey, T>(global::PGLJFENHHHK<TKey, T> EELLPGLCOLL, [Optional] object BKJKDPLKCNE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2930", Offset = "0x3DF1330", VA = "0x183DF2930", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public PGAGLPLJCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2A70", Offset = "0x3DF1470", VA = "0x183DF2A70")]
	[CompilerGenerated]
	private LEECANKHNKH INFNAJABPMM(int HLFOHCODFGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[LHOECCIDBFM(typeof(IADMOPFMJCJ), new string[] { })]
public class JJIGEFMLJAD : IADMOPFMJCJ, IEnumerable<KHBNAMDANEI>, IEnumerable, HNADMPPHDEF, BCGODABHHDD, EOLIEJMIFHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[JLCJNHHCBDK]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[JLCJNHHCBDK]
	private IALPALJEAJO GBMNEHCEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private KHBNAMDANEI[] BMNNAENACLN;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x41D0700", Offset = "0x41CF100", VA = "0x1841D0700", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public KHBNAMDANEI KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x41D07F0", Offset = "0x41CF1F0", VA = "0x1841D07F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KHBNAMDANEI KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x41D07F0", Offset = "0x41CF1F0", VA = "0x1841D07F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x41D0E40", Offset = "0x41CF840", VA = "0x1841D0E40", Slot = "9")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x41D0B00", Offset = "0x41CF500", VA = "0x1841D0B00", Slot = "10")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x41D0D60", Offset = "0x41CF760", VA = "0x1841D0D60")]
	private KHBNAMDANEI LNLNEMHGFKF(int ALJOMNDNEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x41D09E0", Offset = "0x41CF3E0", VA = "0x1841D09E0", Slot = "6")]
	public KHBNAMDANEI IEJEFFFFMHC(ELPOGHCFKOG IDLOFIFEDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x41D0910", Offset = "0x41CF310", VA = "0x1841D0910", Slot = "14")]
	public KOPBFNLIDKA HMMGHMOMKKF(ELPOGHCFKOG IDLOFIFEDHN)
	{
		return default(KOPBFNLIDKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x41D0800", Offset = "0x41CF200", VA = "0x1841D0800", Slot = "7")]
	public IEnumerator<KHBNAMDANEI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x41D0800", Offset = "0x41CF200", VA = "0x1841D0800", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x39DABA0", Offset = "0x39D95A0", VA = "0x1839DABA0", Slot = "11")]
	public void OFDECHGBDFD<TKey, T>(global::PGLJFENHHHK<TKey, T> EELLPGLCOLL, [Optional] object BKJKDPLKCNE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x41D0750", Offset = "0x41CF150", VA = "0x1841D0750", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public JJIGEFMLJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x41D07F0", Offset = "0x41CF1F0", VA = "0x1841D07F0")]
	[CompilerGenerated]
	private KHBNAMDANEI INFNAJABPMM(int HLFOHCODFGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[LHOECCIDBFM(typeof(OJNMEFHLIGF), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
internal class OJNMEFHLIGF : HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private IALPALJEAJO GBMNEHCEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private IADMOPFMJCJ KPHKIGBABOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private NPCKMHCNIEO NPOBFCNMOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::BPPLLIHONDM<DPCOGLJGJDC> IJLOFJODKBL;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public JPGJEDNAMKP HFHJIJDJOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8464B0", Offset = "0x844EB0", VA = "0x1808464B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3DB0", Offset = "0x3DE27B0", VA = "0x183DE3DB0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3CC0", Offset = "0x3DE26C0", VA = "0x183DE3CC0")]
	private void JNEHMPGENAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x3686410", Offset = "0x3684E10", VA = "0x183686410")]
	public T KLFICDNJEEI<T>() where T : DPCOGLJGJDC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3EE0", Offset = "0x3DE28E0", VA = "0x183DE3EE0")]
	public HMBIKFADCFA PLFOEIDKGEJ(ELPOGHCFKOG KMEGKECOLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::HBNHJLIDJBP<T> PLFOEIDKGEJ<T>(ELPOGHCFKOG KMEGKECOLPJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3B20", Offset = "0x3DE2520", VA = "0x183DE3B20")]
	public KHBNAMDANEI GLIEFEGDFJF(ELPOGHCFKOG KMEGKECOLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x3686390", Offset = "0x3684D90", VA = "0x183686390")]
	public global::MMEKELGLLBO<T> GLIEFEGDFJF<T>(ELPOGHCFKOG KMEGKECOLPJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3BF0", Offset = "0x3DE25F0", VA = "0x183DE3BF0")]
	public LEECANKHNKH GMBOKFFNMCG(ELPOGHCFKOG KMEGKECOLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::MHDDDLDPKOK<T> GMBOKFFNMCG<T>(ELPOGHCFKOG KMEGKECOLPJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public OJNMEFHLIGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class KEMGLHNKGDH
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x38E3800", Offset = "0x38E2200", VA = "0x1838E3800")]
	public static global::HBNHJLIDJBP<T> PLFOEIDKGEJ<T>(this OJNMEFHLIGF OCNJOCPCLED, global::KLCCANBKHMJ<T> KMEGKECOLPJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::MMEKELGLLBO<T> GLIEFEGDFJF<T>(this OJNMEFHLIGF OCNJOCPCLED, global::KLCCANBKHMJ<T> KMEGKECOLPJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::MHDDDLDPKOK<T> GMBOKFFNMCG<T>(this OJNMEFHLIGF OCNJOCPCLED, global::KLCCANBKHMJ<T> KMEGKECOLPJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[LHOECCIDBFM(typeof(DJELFFMGFLB), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
public class DJELFFMGFLB : HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private DICONAJFMFK CNOHBONCFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private KOPBFNLIDKA[] AFBNHMGCGPN;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x3E90450", Offset = "0x3E8EE50", VA = "0x183E90450", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x3E90330", Offset = "0x3E8ED30", VA = "0x183E90330")]
	public void GJHJLCDCDPI(ANIMKGBLAIA BBILPABEHHM, bool CNFALJGNOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public DJELFFMGFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[LHOECCIDBFM(typeof(EKIOGIIBOMH), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
public sealed class EKIOGIIBOMH : HNADMPPHDEF, BCGODABHHDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class FPJJINFCELB : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		[DebuggerHidden]
		public FPJJINFCELB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x47C2B60", Offset = "0x47C1560", VA = "0x1847C2B60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x47C27B0", Offset = "0x47C11B0", VA = "0x1847C27B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x47C2BE0", Offset = "0x47C15E0", VA = "0x1847C2BE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x47C2B20", Offset = "0x47C1520", VA = "0x1847C2B20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x47C2A90", Offset = "0x47C1490", VA = "0x1847C2A90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x47C2A90", Offset = "0x47C1490", VA = "0x1847C2A90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string LNPPHEEMDIC = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, BOCABFGBJBC> EHPFEKMHFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> PJEEHANBLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> DKNCGBIHPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private IADMOPFMJCJ PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private OGJECELGDOJ FAMLIKPHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private CPIGIOMNEPF BAOOFNPBDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private PJIOIOLLAAE LMLFCMLPFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::KOCKALKNOHE<BOCABFGBJBC> CIDJOFBMEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject HDFMABDMDLJ;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x41B93C0", Offset = "0x41B7DC0", VA = "0x1841B93C0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x41B91F0", Offset = "0x41B7BF0", VA = "0x1841B91F0", Slot = "5")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x41B8780", Offset = "0x41B7180", VA = "0x1841B8780", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x41B8E50", Offset = "0x41B7850", VA = "0x1841B8E50")]
	private void GCIEPJBGOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x41B8920", Offset = "0x41B7320", VA = "0x1841B8920")]
	internal void EHFLKGBDOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x41B83C0", Offset = "0x41B6DC0", VA = "0x1841B83C0")]
	private void BMDHOLFHCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x41B8D50", Offset = "0x41B7750", VA = "0x1841B8D50")]
	private void EOEKNKLOMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x41B9960", Offset = "0x41B8360", VA = "0x1841B9960")]
	[IteratorStateMachine(typeof(FPJJINFCELB))]
	private IEnumerable<RRCustomPropTag> PEGDOGIEHFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x41B9490", Offset = "0x41B7E90", VA = "0x1841B9490")]
	private void OABCEGIDCEN(GEEJJFIMDNA BJLPLHMBBOJ, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x41B8280", Offset = "0x41B6C80", VA = "0x1841B8280")]
	private void AIDBCCOFMIA(SerializableGuid GDCMPFDFIDH, GameObject OJBDJCCAFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x41B8E60", Offset = "0x41B7860", VA = "0x1841B8E60")]
	private void HKIMLCJFCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x41B85A0", Offset = "0x41B6FA0", VA = "0x1841B85A0")]
	private bool BPKBAPLGGHP(BOCABFGBJBC HPNKFKNPKNI, Transform EOBFGLJBCIJ, out GameObject JCJDNADEMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x41B9910", Offset = "0x41B8310", VA = "0x1841B9910")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x41B99B0", Offset = "0x41B83B0", VA = "0x1841B99B0")]
	public EKIOGIIBOMH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public SerializableGuid MKMIMABKHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D430", Offset = "0x3D1BE30", VA = "0x183D1D430")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[LHOECCIDBFM(typeof(NAOIKNFONJN), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
public class NAOIKNFONJN : HNADMPPHDEF
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string BKOILIDDGKD = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService KIMBBFMGFGO;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0750", Offset = "0x3DDF150", VA = "0x183DE0750", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NAOIKNFONJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[LHOECCIDBFM(typeof(MNLFDDKOMPB), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
public class MNLFDDKOMPB : HNADMPPHDEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[JLCJNHHCBDK]
	private EnableComponentSystemsInScope EJHEKFDICGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[JLCJNHHCBDK]
	private SceneService KIMBBFMGFGO;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x3DE03A0", Offset = "0x3DDEDA0", VA = "0x183DE03A0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0340", Offset = "0x3DDED40", VA = "0x183DE0340", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0380", Offset = "0x3DDED80", VA = "0x183DE0380")]
	private void LOEIBJNBDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0310", Offset = "0x3DDED10", VA = "0x183DE0310")]
	private void BEJALBCLLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public MNLFDDKOMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[LHOECCIDBFM(typeof(BFJCJFMHLPG), new string[] { })]
public class CDMFMCEKPHJ : HNADMPPHDEF, BCGODABHHDD, BFJCJFMHLPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private AJDBIBIKOCB ILCFADBMBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private HGFENIMGBMC GKADGBHAELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService NGCEPKOKHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem EPBOPKAPLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int ENJKOMKFDJO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool MOFHLJKHIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x3E80D80", Offset = "0x3E7F780", VA = "0x183E80D80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public GEEJJFIMDNA JDAOPGAHDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x3E80ED0", Offset = "0x3E7F8D0", VA = "0x183E80ED0", Slot = "9")]
		get
		{
			return default(GEEJJFIMDNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x3E807B0", Offset = "0x3E7F1B0", VA = "0x183E807B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GAIECBKNDJB OHDPFHBFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x3E80900", Offset = "0x3E7F300", VA = "0x183E80900", Slot = "11")]
		get
		{
			return default(GAIECBKNDJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x3E807B0", Offset = "0x3E7F1B0", VA = "0x183E807B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GAIECBKNDJB KKAPNLHFCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x3E80760", Offset = "0x3E7F160", VA = "0x183E80760", Slot = "13")]
		get
		{
			return default(GAIECBKNDJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint IOGEHIBPPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3E81080", Offset = "0x3E7FA80", VA = "0x183E81080")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EKJMDKCMPLC KLPPJGGFAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x3E80FE0", Offset = "0x3E7F9E0", VA = "0x183E80FE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3E81130", Offset = "0x3E7FB30", VA = "0x183E81130", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x3E80F10", Offset = "0x3E7F910", VA = "0x183E80F10", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x3E80BE0", Offset = "0x3E7F5E0", VA = "0x183E80BE0", Slot = "5")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x3E80850", Offset = "0x3E7F250", VA = "0x183E80850", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x3E80360", Offset = "0x3E7ED60", VA = "0x183E80360")]
	private void BMCNJKOGMFE(Entity OOGAMDNOHNH, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO GFPNEMALIHE, ABKAKFBNEMO JOOHHAMJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x3E80DC0", Offset = "0x3E7F7C0", VA = "0x183E80DC0", Slot = "14")]
	public GEEJJFIMDNA JEEHDEPPMGK(GEEJJFIMDNA NJJNIDPJHBF, GEEJJFIMDNA GEIIKIOFPCG)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x3E80950", Offset = "0x3E7F350", VA = "0x183E80950", Slot = "15")]
	public bool GCEPIHEHFPE(GEEJJFIMDNA NJJNIDPJHBF, GEEJJFIMDNA GEIIKIOFPCG, out GEEJJFIMDNA NPNKNKHBGOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x3E80A50", Offset = "0x3E7F450", VA = "0x183E80A50", Slot = "16")]
	public void HOFIIIOLFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x3E80560", Offset = "0x3E7EF60", VA = "0x183E80560", Slot = "17")]
	public void BNGBNAEHNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x3E80600", Offset = "0x3E7F000", VA = "0x183E80600", Slot = "18")]
	public bool BNNFHNAOLKE(GEEJJFIMDNA BJCKADBMKDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x3E807B0", Offset = "0x3E7F1B0", VA = "0x183E807B0")]
	private void NLGJINNOEBC(GEEJJFIMDNA ALMKNLGOCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public CDMFMCEKPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[LHOECCIDBFM(typeof(HBJIENGODMB), new string[] { })]
public class EDOPOLBELPJ : HNADMPPHDEF, HBJIENGODMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager IMCLABBJAOB;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x3E928A0", Offset = "0x3E912A0", VA = "0x183E928A0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x3E92920", Offset = "0x3E91320", VA = "0x183E92920", Slot = "5")]
	public void PEECGJCJBCA(GEEJJFIMDNA AGGJCDBCIGG, bool MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x3217E10", Offset = "0x3216810", VA = "0x183217E10")]
	private void CKIEIOOCMAM<T>(GEEJJFIMDNA AGGJCDBCIGG, bool MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EDOPOLBELPJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[LHOECCIDBFM(typeof(CIMADFPBKAJ), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.RenderEffects)]
	public class SelectionService : HNADMPPHDEF, CIMADFPBKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager IMCLABBJAOB;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x3D23E70", Offset = "0x3D22870", VA = "0x183D23E70", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x3D23E00", Offset = "0x3D22800", VA = "0x183D23E00", Slot = "5")]
		public void KPDICMNBLMF(GEEJJFIMDNA AGGJCDBCIGG, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x3D23EF0", Offset = "0x3D228F0", VA = "0x183D23EF0", Slot = "6")]
		public void OEBOJDANIFJ(GEEJJFIMDNA AGGJCDBCIGG, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x3217E10", Offset = "0x3216810", VA = "0x183217E10")]
		private void CKIEIOOCMAM<T>(GEEJJFIMDNA AGGJCDBCIGG, bool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
[LHOECCIDBFM(typeof(DLADNMEABEN), new string[] { })]
internal sealed class DLADNMEABEN : HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[JLCJNHHCBDK]
	private ObjectEmbodimentService KDNKFCLFKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[JLCJNHHCBDK]
	private BJJPOMIINDM HFELLKINAGM;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x3E906E0", Offset = "0x3E8F0E0", VA = "0x183E906E0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public DLADNMEABEN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
	[LHOECCIDBFM(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : HNADMPPHDEF, IBBGAKLJKHN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly NNLEPLPFODN CCJFDKFMPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[JLCJNHHCBDK]
		private MCKELHDHOFN DCKGKAIMOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[JLCJNHHCBDK]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[JLCJNHHCBDK]
		private SerializationService BAOOFNPBDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[JLCJNHHCBDK]
		private FHLGOPCDKON EHMMKOFECKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[JLCJNHHCBDK]
		private DebugWorldsService FHCBNEFGHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[JLCJNHHCBDK]
		private BulkInstantiateSceneObjectService BFKPAMBOPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private IBDMDNNFKPL CFMBBKOCIHK;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private NMOHGIPDICN NOPJMPGDMGL
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xCE0550", Offset = "0xCDEF50", VA = "0x180CE0550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x3D38700", Offset = "0x3D37100", VA = "0x183D38700", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL EJNKOAHOJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x3D38010", Offset = "0x3D36A10", VA = "0x183D38010", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x3D385A0", Offset = "0x3D36FA0", VA = "0x183D385A0", Slot = "6")]
		public bool IJINPNONFDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x3D38B50", Offset = "0x3D37550", VA = "0x183D38B50", Slot = "7")]
		public bool OFOGFKALCNE(IEnumerable<OOFJJCAIBIL> KCFFMLPOBOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x3D38110", Offset = "0x3D36B10", VA = "0x183D38110", Slot = "5")]
		public ByteString GCLNOHIFIPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x3D38850", Offset = "0x3D37250", VA = "0x183D38850")]
		private void MKKIOOPDCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3D38040", Offset = "0x3D36A40", VA = "0x183D38040")]
		private void FKLFDCNDILJ(FMBDLOIJKOL KDHEAEHHPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3D38B70", Offset = "0x3D37570", VA = "0x183D38B70")]
		private void OGABIKLIBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x3D38870", Offset = "0x3D37270", VA = "0x183D38870")]
		private void OCKOANBHDEH(OEIOFGPKKAF KDHEAEHHPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x3D37F20", Offset = "0x3D36920", VA = "0x183D37F20", Slot = "8")]
		public void CBPHENPICMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x3D37F70", Offset = "0x3D36970", VA = "0x183D37F70")]
		private FMBDLOIJKOL CENALFLPDIF(EntityManager NIFGALLBNNK, EntityManager NKFNOKODGJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[LHOECCIDBFM(typeof(IFKAGNAGNDM), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
public class IFKAGNAGNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<BFFEGPGDBEI, string> HPHNCADMINP;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x41C9210", Offset = "0x41C7C10", VA = "0x1841C9210")]
	public GameObject OLHEMACOCNK(BFFEGPGDBEI ILPCKJBOHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x41C92E0", Offset = "0x41C7CE0", VA = "0x1841C92E0")]
	public IFKAGNAGNDM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(TimeService), new string[] { })]
	public class TimeService : NMGDKBIHJIB, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[JLCJNHHCBDK]
		private SingletonComponentService LAIMNDJEGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool BGJOCDKDHJF;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData EOBHIBKCOME
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B890", Offset = "0x3D2A290", VA = "0x183D2B890")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x3D2B700", Offset = "0x3D2A100", VA = "0x183D2B700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool HIPGNCNHPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x80A4B0", Offset = "0x808EB0", VA = "0x18080A4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xDB9650", Offset = "0xDB8050", VA = "0x180DB9650", Slot = "4")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B840", Offset = "0x3D2A240", VA = "0x183D2B840", Slot = "5")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B780", Offset = "0x3D2A180", VA = "0x183D2B780")]
		public void DODGOHHPJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[KEFMDJAGLBH(IGKCNDFEDMC.TransformSyncing)]
	[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
	[LHOECCIDBFM(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : HNADMPPHDEF, BCGODABHHDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private FADNPGGGOHC FBHAGLEGMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::HBNHJLIDJBP<Entity> EOBFGLJBCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService JMHKMIOCNFD;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x3D27A50", Offset = "0x3D26450", VA = "0x183D27A50", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3D27920", Offset = "0x3D26320", VA = "0x183D27920", Slot = "5")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x3D27880", Offset = "0x3D26280", VA = "0x183D27880", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x3D27AC0", Offset = "0x3D264C0", VA = "0x183D27AC0")]
		private void OMFANKFICLP(Entity OOGAMDNOHNH, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Services)]
	[LHOECCIDBFM(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[JLCJNHHCBDK]
		private DEGDDDMDDKA CABHIPNEIGC;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private DHEIAMOLICF DKOKAGBLGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x41BD420", Offset = "0x41BBE20", VA = "0x1841BD420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private AKAMOGIJAEB AMDEEKHBIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x41BD470", Offset = "0x41BBE70", VA = "0x1841BD470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x41BD4C0", Offset = "0x41BBEC0", VA = "0x1841BD4C0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x41BD400", Offset = "0x41BBE00", VA = "0x1841BD400", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[LHOECCIDBFM(typeof(GKBADCADPMI), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
public class GKBADCADPMI : LKLIJPNGPEG, NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class LBIJJLEMHJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public IBDMDNNFKPL services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public LBIJJLEMHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x47C59E0", Offset = "0x47C43E0", VA = "0x1847C59E0")]
		internal void <InitReferences>b__0(HNADMPPHDEF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ENGAIKDNGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public IBDMDNNFKPL services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ENGAIKDNGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x47C1EE0", Offset = "0x47C08E0", VA = "0x1847C1EE0")]
		internal void <InitExternal>b__0(BCGODABHHDD svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[JLCJNHHCBDK]
	private BJJPOMIINDM HFELLKINAGM;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public KHAIGNDBJNC FJBFKNJMOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xDD13C0", Offset = "0xDCFDC0", VA = "0x180DD13C0", Slot = "4")]
		get
		{
			return default(KHAIGNDBJNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private BKKHAMMBGFF FPKDMGAMAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x41C41E0", Offset = "0x41C2BE0", VA = "0x1841C41E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x41C40B0", Offset = "0x41C2AB0", VA = "0x1841C40B0", Slot = "5")]
	public void JBEIDPFKLNB(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x41C3EA0", Offset = "0x41C28A0", VA = "0x1841C3EA0", Slot = "6")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x41C4100", Offset = "0x41C2B00", VA = "0x1841C4100", Slot = "7")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x41C3FD0", Offset = "0x41C29D0", VA = "0x1841C3FD0", Slot = "8")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x41C3D70", Offset = "0x41C2770", VA = "0x1841C3D70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x30D4100", Offset = "0x30D2B00", VA = "0x1830D4100")]
	private void KDIOJOALALC<T>(Action<T> PBHDPPDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public GKBADCADPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class MCJEMAINGJN<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> NBBCAFHJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> LPJAJCIHLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> CKDPLHPNFKM;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public MCJEMAINGJN(Func<From, To> NBBCAFHJANO, Func<To, From> LPJAJCIHLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To FPEJLKINELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int ALJOMNDNEBM, To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class KIAOMNHGPFC<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> NBBCAFHJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> LPJAJCIHLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> ECNPNAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x3804640", Offset = "0x3803040", VA = "0x183804640", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x38046A0", Offset = "0x38030A0", VA = "0x1838046A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x3804610", Offset = "0x3803010", VA = "0x183804610", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3804580", Offset = "0x3802F80", VA = "0x183804580")]
	public KIAOMNHGPFC(Func<From, To> NBBCAFHJANO, Func<To, From> LPJAJCIHLAP, bool HMMIOMHIJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x3804170", Offset = "0x3802B70", VA = "0x183804170", Slot = "11")]
	public void Add(To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x32C2BF0", Offset = "0x32C15F0", VA = "0x1832C2BF0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x38041D0", Offset = "0x3802BD0", VA = "0x1838041D0", Slot = "13")]
	public bool Contains(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x3804230", Offset = "0x3802C30", VA = "0x183804230", Slot = "14")]
	public void CopyTo(To[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x3804340", Offset = "0x3802D40", VA = "0x183804340", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x3804410", Offset = "0x3802E10", VA = "0x183804410", Slot = "6")]
	public int IndexOf(To FPEJLKINELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x3804470", Offset = "0x3802E70", VA = "0x183804470", Slot = "7")]
	public void Insert(int ALJOMNDNEBM, To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x3804520", Offset = "0x3802F20", VA = "0x183804520", Slot = "15")]
	public bool Remove(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x38044F0", Offset = "0x3802EF0", VA = "0x1838044F0", Slot = "8")]
	public void RemoveAt(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x327A4E0", Offset = "0x3278EE0", VA = "0x18327A4E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class MGJIPJBDEAL<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> NBBCAFHJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> LPJAJCIHLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> HPOICFFOIAP;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x4EA79D0", Offset = "0x4EA63D0", VA = "0x184EA79D0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7A20", Offset = "0x4EA6420", VA = "0x184EA7A20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7990", Offset = "0x4EA6390", VA = "0x184EA7990", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x37130B0", Offset = "0x3711AB0", VA = "0x1837130B0")]
	public MGJIPJBDEAL(Func<From, To> NBBCAFHJANO, Func<To, From> LPJAJCIHLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x4EA75A0", Offset = "0x4EA5FA0", VA = "0x184EA75A0", Slot = "11")]
	public void Add(To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x4EA75E0", Offset = "0x4EA5FE0", VA = "0x184EA75E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7620", Offset = "0x4EA6020", VA = "0x184EA7620", Slot = "13")]
	public bool Contains(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA60E0", VA = "0x184EA76E0", Slot = "14")]
	public void CopyTo(To[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x4EA77A0", Offset = "0x4EA61A0", VA = "0x184EA77A0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7860", Offset = "0x4EA6260", VA = "0x184EA7860", Slot = "6")]
	public int IndexOf(To FPEJLKINELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EA78D0", Offset = "0x4EA62D0", VA = "0x184EA78D0", Slot = "7")]
	public void Insert(int ALJOMNDNEBM, To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7950", Offset = "0x4EA6350", VA = "0x184EA7950", Slot = "15")]
	public bool Remove(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7910", Offset = "0x4EA6310", VA = "0x184EA7910", Slot = "8")]
	public void RemoveAt(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x34E8C50", Offset = "0x34E7650", VA = "0x1834E8C50", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class CKLEMJHBJLB<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> NBBCAFHJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> LPJAJCIHLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> ECNPNAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public CKLEMJHBJLB(Func<From, To> NBBCAFHJANO, Func<To, From> LPJAJCIHLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To FPEJLKINELB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int ALJOMNDNEBM, To FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class AEIEMNCPJEB
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string AJEBGIFNAJG = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string OHLHHMKMCNF = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string LJNCCCIILPE = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string OJNAKAJMPMM = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string FLHBCODDPKK = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string GHCKAEABLGC = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string AFKEDHPAFFD = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string IPMFPEOOJCH = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class ENMKHEPCAMG
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class GEFMAHPAOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public IBDMDNNFKPL services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public GEFMAHPAOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x47C2D10", Offset = "0x47C1710", VA = "0x1847C2D10")]
		internal void <InitServices>b__1(HNADMPPHDEF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x47C2D70", Offset = "0x47C1770", VA = "0x1847C2D70")]
		internal void <InitServices>b__2(BCGODABHHDD svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x41BAD00", Offset = "0x41B9700", VA = "0x1841BAD00")]
	public static void JOMPLFEKCJD(this BKKHAMMBGFF ENGIGCMGHCJ, IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x3223D50", Offset = "0x3222750", VA = "0x183223D50")]
	public static void KDIOJOALALC<T>(this BKKHAMMBGFF ENGIGCMGHCJ, Action<T> PBHDPPDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x32240E0", Offset = "0x3222AE0", VA = "0x1832240E0")]
	public static void MNNIEMMKLDO<T>(this BKKHAMMBGFF ENGIGCMGHCJ, Action<T> PBHDPPDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x32239F0", Offset = "0x32223F0", VA = "0x1832239F0")]
	public static void HKBBPLCFMNJ<T>(this BKKHAMMBGFF ENGIGCMGHCJ, Action<T> PBHDPPDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x3223BA0", Offset = "0x32225A0", VA = "0x183223BA0")]
	public static void JFFKLFAFDGB<T>(this BKKHAMMBGFF ENGIGCMGHCJ, Action<T> PBHDPPDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x3223DC0", Offset = "0x32227C0", VA = "0x183223DC0")]
	public static void LOICAOBOPML<T>(this BKKHAMMBGFF ENGIGCMGHCJ, Action<T> PBHDPPDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x3223F70", Offset = "0x3222970", VA = "0x183223F70")]
	public static void MNNIEMMKLDO<T>(IEnumerable<ComponentSystemBase> DILFFHKMEHB, Action<T> PBHDPPDBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x3223930", Offset = "0x3222330", VA = "0x183223930")]
	private static void GKDALJCBLGD<T>(object APCKCJOBOPP, Action<T> PBHDPPDBGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EELEJAECDLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class DNHDIFMOBIF
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3E907A0", Offset = "0x3E8F1A0", VA = "0x183E907A0")]
	public static void NJLBCAGPGIE(ComponentSystemBase APCKCJOBOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class DJEEIGOCOKF
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool PPANOBOMAMB<T>(ref T MGFKDMJBGAK, ref T LPDJCHOFJLE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class ANCBMAALPGF
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class DPPNIEAHKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public DPPNIEAHKEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E77D70", Offset = "0x3E76770", VA = "0x183E77D70")]
	public static string BCJOIDAACGA(Transform DBMMOFPNJHL, Transform BJCKADBMKDM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D26700", Offset = "0x3D25100", VA = "0x183D26700")]
		public static void DCGFCAGLEEJ(this BHMKMNJJKHN CFMBBKOCIHK, ECPHGMOFBIF HHNNPAGKLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D26EB0", Offset = "0x3D258B0", VA = "0x183D26EB0")]
		public static void PNGNPNHJNON(this BHMKMNJJKHN CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D26930", Offset = "0x3D25330", VA = "0x183D26930")]
		public static void DCGFCAGLEEJ(this BHMKMNJJKHN CFMBBKOCIHK, [Optional] string[] BIGIMFCGPMO, [Optional] string[] ENFMBMPOEIH, [Optional] string[] OJFOOKJFMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D26C00", Offset = "0x3D25600", VA = "0x183D26C00")]
		public static void FLCJDDGJDEK(this BHMKMNJJKHN CFMBBKOCIHK, params string[] IMIPOPIMEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D26650", Offset = "0x3D25050", VA = "0x183D26650")]
		public static void AFBGOODPLGJ(this BHMKMNJJKHN CFMBBKOCIHK, params string[] IMIPOPIMEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D26CB0", Offset = "0x3D256B0", VA = "0x183D26CB0")]
		private static string[] HLLEOBHCNHG(ECPHGMOFBIF HHNNPAGKLBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D26A40", Offset = "0x3D25440", VA = "0x183D26A40")]
		private static bool DLFLEICFNLN(ECPHGMOFBIF HHNNPAGKLBL, out string[] CBLMKBJFEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0")]
		private static bool NNKNLPILCLN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class LEHBOJNIDDG : ELJGEMBGPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo FJEAJLLDIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] LIKLGHJBPPH;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC3D0", Offset = "0x3DDADD0", VA = "0x183DDC3D0")]
	public LEHBOJNIDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action LOCCAEDMOCG();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC390", Offset = "0x3DDAD90", VA = "0x183DDC390")]
	public MethodInfo GBHFLHAEFMN(Action DJJNLDOINEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC1E0", Offset = "0x3DDABE0", VA = "0x183DDC1E0", Slot = "4")]
	public void AIDBCCOFMIA(Type EMKINACMDLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class DGFFOFELDLP : LEHBOJNIDDG
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum BFGDMCMKOKO
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F780", Offset = "0x3E8E180", VA = "0x183E8F780", Slot = "5")]
	public override Action LOCCAEDMOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BPEJBPLGJKO<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F6F0", Offset = "0x3E8E0F0", VA = "0x183E8F6F0")]
	[Preserve]
	public void AJCKOOJBEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F810", Offset = "0x3E8E210", VA = "0x183E8F810")]
	protected DGFFOFELDLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class DOEGJIIAMKJ : LEHBOJNIDDG
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x3E91030", Offset = "0x3E8FA30", VA = "0x183E91030", Slot = "5")]
	public override Action LOCCAEDMOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void ELDAMFOBCPP<T>() where T : EBILCGEECNE;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3E90FA0", Offset = "0x3E8F9A0", VA = "0x183E90FA0")]
	[Preserve]
	public void AJCKOOJBEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F810", Offset = "0x3E8E210", VA = "0x183E8F810")]
	protected DOEGJIIAMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class ONBMHJILAOD : LEHBOJNIDDG
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4140", Offset = "0x3DE2B40", VA = "0x183DE4140", Slot = "5")]
	public override Action LOCCAEDMOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EEHKPMOEPNP<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x3DE40B0", Offset = "0x3DE2AB0", VA = "0x183DE40B0")]
	[Preserve]
	public void AJCKOOJBEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC3D0", Offset = "0x3DDADD0", VA = "0x183DDC3D0")]
	protected ONBMHJILAOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class MOGEPDKLGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0650", Offset = "0x3DDF050", VA = "0x183DE0650")]
	public static Entity MDABCGGGOIE(this EntityManager IMCLABBJAOB)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[KEFMDJAGLBH(IGKCNDFEDMC.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class MPBGEOKCELI : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0x1C45710", Offset = "0x1C44110", VA = "0x181C45710", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0x47C97E0", Offset = "0x47C81E0", VA = "0x1847C97E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x47C6E40", Offset = "0x47C5840", VA = "0x1847C6E40")]
			[DebuggerHidden]
			public MPBGEOKCELI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x47C9610", Offset = "0x47C8010", VA = "0x1847C9610", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x47C97A0", Offset = "0x47C81A0", VA = "0x1847C97A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x47C96F0", Offset = "0x47C80F0", VA = "0x1847C96F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x47C96F0", Offset = "0x47C80F0", VA = "0x1847C96F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class MFLFDKGJIFF : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600062E")]
				[Cpp2IlInjected.Address(RVA = "0x1C45710", Offset = "0x1C44110", VA = "0x181C45710", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000630")]
				[Cpp2IlInjected.Address(RVA = "0x47C9190", Offset = "0x47C7B90", VA = "0x1847C9190", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x47C6E40", Offset = "0x47C5840", VA = "0x1847C6E40")]
			[DebuggerHidden]
			public MFLFDKGJIFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x47C91E0", Offset = "0x47C7BE0", VA = "0x1847C91E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x47C8EB0", Offset = "0x47C78B0", VA = "0x1847C8EB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x47C9270", Offset = "0x47C7C70", VA = "0x1847C9270")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x47C9150", Offset = "0x47C7B50", VA = "0x1847C9150", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x47C90A0", Offset = "0x47C7AA0", VA = "0x1847C90A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x47C90A0", Offset = "0x47C7AA0", VA = "0x1847C90A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class PFGOIGMAPFE : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000638")]
				[Cpp2IlInjected.Address(RVA = "0x1C45710", Offset = "0x1C44110", VA = "0x181C45710", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600063A")]
				[Cpp2IlInjected.Address(RVA = "0x47CAF80", Offset = "0x47C9980", VA = "0x1847CAF80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x47C6E40", Offset = "0x47C5840", VA = "0x1847C6E40")]
			[DebuggerHidden]
			public PFGOIGMAPFE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x47CAFD0", Offset = "0x47C99D0", VA = "0x1847CAFD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x47CAB70", Offset = "0x47C9570", VA = "0x1847CAB70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x47CB0A0", Offset = "0x47C9AA0", VA = "0x1847CB0A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x47CB0F0", Offset = "0x47C9AF0", VA = "0x1847CB0F0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x47CAF40", Offset = "0x47C9940", VA = "0x1847CAF40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x47CAEA0", Offset = "0x47C98A0", VA = "0x1847CAEA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x47CAEA0", Offset = "0x47C98A0", VA = "0x1847CAEA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x41BFDF0", Offset = "0x41BE7F0", VA = "0x1841BFDF0")]
		public static Entity EMGALAGFHIC(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x41C0150", Offset = "0x41BEB50", VA = "0x1841C0150")]
		public static DynamicBuffer<ChildrenData> FMJCNLAPIFL(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x41BFA80", Offset = "0x41BE480", VA = "0x1841BFA80")]
		public static DynamicBuffer<ChildrenData> DKLBCPKDAGG(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x41C0AF0", Offset = "0x41BF4F0", VA = "0x1841C0AF0")]
		public static NativeArray<Entity> KKGKLDMHJNN(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, Allocator APPJGCOGPBM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x41C0DA0", Offset = "0x41BF7A0", VA = "0x1841C0DA0")]
		public static bool MHJMLCKPLPA(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, Allocator APPJGCOGPBM, out NativeArray<Entity> LBDMDOFKIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x41C0990", Offset = "0x41BF390", VA = "0x1841C0990")]
		public static NativeArray<Entity> IPCBEOJBGJF(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x41C0020", Offset = "0x41BEA20", VA = "0x1841C0020")]
		public static Entity FKOMLICCHDO(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, int ALJOMNDNEBM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x41C10B0", Offset = "0x41BFAB0", VA = "0x1841C10B0")]
		public static int PEOFEJABMDB(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x41BFB90", Offset = "0x41BE590", VA = "0x1841BFB90")]
		public static void DOLGKHGKDPH(NativeArray<Entity> GEPCFDIHMBJ, NativeArray<Entity> GFIGBAPMFPP, EntityManager IMCLABBJAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x41BFF70", Offset = "0x41BE970", VA = "0x1841BFF70")]
		public static int FIMHDFCFDLH(this EntityManager IMCLABBJAOB, Entity EOBFGLJBCIJ, Entity PGDGHENJBJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x41C0520", Offset = "0x41BEF20", VA = "0x1841C0520")]
		public static bool HDIAMLJKEPG(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, Entity NLHHFBGKIOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x41BFE60", Offset = "0x41BE860", VA = "0x1841BFE60")]
		public static IEnumerable<Entity> FGIDOIJCHJN(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, bool APAIFOINEEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x41C11C0", Offset = "0x41BFBC0", VA = "0x1841C11C0")]
		public static bool PNIELCDHNAH(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, Entity PGDGHENJBJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x41BF860", Offset = "0x41BE260", VA = "0x1841BF860")]
		public static bool AOKMHKIMGCA(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, Entity NJJNIDPJHBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x41C0EA0", Offset = "0x41BF8A0", VA = "0x1841C0EA0")]
		public static NativeList<Entity> NFFCOOEMKMD(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, bool APAIFOINEEK = false, Allocator APPJGCOGPBM = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x41C0810", Offset = "0x41BF210", VA = "0x1841C0810")]
		public static IEnumerable<Entity> ILCFHAPNAEK(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, bool APAIFOINEEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x41C0CA0", Offset = "0x41BF6A0", VA = "0x1841C0CA0")]
		public static Entity MHAMLAHOFJF(this EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x41C01E0", Offset = "0x41BEBE0", VA = "0x1841C01E0")]
		public static bool GCEPIHEHFPE(this EntityManager IMCLABBJAOB, Entity NJJNIDPJHBF, Entity GEIIKIOFPCG, out Entity NPNKNKHBGOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x41C0C20", Offset = "0x41BF620", VA = "0x1841C0C20")]
		internal static void MCFFPELCFAK(EntityManager IMCLABBJAOB, Entity EOBFGLJBCIJ, Entity PGDGHENJBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x41C0680", Offset = "0x41BF080", VA = "0x1841C0680")]
		internal static void HFFLLHGCBOD(EntityManager IMCLABBJAOB, Entity EOBFGLJBCIJ, Entity PGDGHENJBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x41C0780", Offset = "0x41BF180", VA = "0x1841C0780")]
		[IteratorStateMachine(typeof(MPBGEOKCELI))]
		private static IEnumerable<Entity> IGJEFKPNNCG(EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, bool APAIFOINEEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x41BF9F0", Offset = "0x41BE3F0", VA = "0x1841BF9F0")]
		[IteratorStateMachine(typeof(MFLFDKGJIFF))]
		private static IEnumerable<Entity> CJKLGBOCIBD(EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, bool APAIFOINEEK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x41BFB10", Offset = "0x41BE510", VA = "0x1841BFB10")]
		[IteratorStateMachine(typeof(PFGOIGMAPFE))]
		private static IEnumerable<Entity> DOACHBBAGBP(EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x41C0440", Offset = "0x41BEE40", VA = "0x1841C0440")]
		private static bool GILINNOADGJ(EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, Entity NLHHFBGKIOA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[LHOECCIDBFM(typeof(BDHPOBELMCM), new string[] { })]
public class IOKGIIIFDOP : BDHPOBELMCM, LKLIJPNGPEG, DLLJBMPPILM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private IBDMDNNFKPL CFMBBKOCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private OGJECELGDOJ FAMLIKPHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private MCKELHDHOFN DCKGKAIMOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private DILAHLBHIHJ GHJONFLCPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private AJDBIBIKOCB ILCFADBMBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private FADNPGGGOHC FBHAGLEGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private KBKLGJJJAII BAOOFNPBDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private NFNDLMPOBLH NKFNHGNJMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IADMOPFMJCJ PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private FLBHDHBFMJK EDOFICLPGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private KBIBABDHAJN AIJKKPKKHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private BFJCJFMHLPG KHIBGIIIKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private NLFGNBOEMBJ EHAAMKHMDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private PDPFABKPIDL JDLEBGGBCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private HBJIENGODMB EKJJANIBNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private CIMADFPBKAJ FFNILPOEGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private BOBHNBKKIJM GFENNPGBGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private FADGHEDABFI BKLPNJCHOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private CEILNDOCFMN PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public IBDMDNNFKPL LHGMMJHJKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public OGJECELGDOJ CNLJCAAJBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BJJPOMIINDM FPKDMGAMAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public MCKELHDHOFN IBFAHGFFBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DILAHLBHIHJ FACFIIINDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public HLNKJMLPBIB MOLFCDPLHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public AJDBIBIKOCB HHNHIPIOBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public FADNPGGGOHC DMMLNFPPBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public KBKLGJJJAII JOPHFIDCFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public NFNDLMPOBLH MAKPAFKKIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IADMOPFMJCJ GGFKHOBKBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FLBHDHBFMJK DDAOCKADHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public KBIBABDHAJN KDMKOBJOGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B40", Offset = "0x7D6540", VA = "0x1807D7B40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BFJCJFMHLPG MENCMLPHANC
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7D67B0", Offset = "0x7D51B0", VA = "0x1807D67B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NLFGNBOEMBJ FDBECKJOFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7D5680", Offset = "0x7D4080", VA = "0x1807D5680", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public PDPFABKPIDL IEFHLGHPIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A30", Offset = "0x7D6430", VA = "0x1807D7A30", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HBJIENGODMB JDECLJGLGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7D5630", Offset = "0x7D4030", VA = "0x1807D5630", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public CIMADFPBKAJ JKOPLLPLHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7D6740", Offset = "0x7D5140", VA = "0x1807D6740", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BOBHNBKKIJM EOGGNKNGEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7D70B0", Offset = "0x7D5AB0", VA = "0x1807D70B0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public FADGHEDABFI AJCAOKNEFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x7D6780", Offset = "0x7D5180", VA = "0x1807D6780", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public CEILNDOCFMN KHJADMFINDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x7D6730", Offset = "0x7D5130", VA = "0x1807D6730", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public KHAIGNDBJNC FJBFKNJMOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7373E0", Offset = "0x735DE0", VA = "0x1807373E0", Slot = "21")]
		get
		{
			return default(KHAIGNDBJNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x41CBB20", Offset = "0x41CA520", VA = "0x1841CBB20", Slot = "22")]
	public void JBEIDPFKLNB(IBDMDNNFKPL EJNKOAHOJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x31AC8D0", Offset = "0x31AB2D0", VA = "0x1831AC8D0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x41CBE10", Offset = "0x41CA810", VA = "0x1841CBE10", Slot = "23")]
	public void KLPPJGGFAKI(IBDMDNNFKPL EJNKOAHOJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public IOKGIIIFDOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class GNJOKDIHLGB : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OPHGGPJNOBI : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public GNJOKDIHLGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x80B660", Offset = "0x80A060", VA = "0x18080B660", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x47CA590", Offset = "0x47C8F90", VA = "0x1847CA590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
		[DebuggerHidden]
		public OPHGGPJNOBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x47CA3E0", Offset = "0x47C8DE0", VA = "0x1847CA3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x47CA550", Offset = "0x47C8F50", VA = "0x1847CA550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong CCKDKHCGAFA = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong EMGMONBNGHK = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int HIKPFMGPGCI = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int DIKMPAFLKCN = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int IAHMKPAEJIE = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int FGKLCPPELAK = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> CPGNEAPGBPB;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x767540", Offset = "0x765F40", VA = "0x180767540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int OBCCIHPOOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x7E5640", Offset = "0x7E4040", VA = "0x1807E5640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7E5630", Offset = "0x7E4030", VA = "0x1807E5630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x41C4730", Offset = "0x41C3130", VA = "0x1841C4730")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x41C4C30", Offset = "0x41C3630", VA = "0x1841C4C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x41C5100", Offset = "0x41C3B00", VA = "0x1841C5100")]
	public GNJOKDIHLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x41C4FC0", Offset = "0x41C39C0", VA = "0x1841C4FC0")]
	public GNJOKDIHLGB(int BBHHGPEIFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x41C45D0", Offset = "0x41C2FD0", VA = "0x1841C45D0")]
	public bool DDIFFJPLHBB(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x41C4B40", Offset = "0x41C3540", VA = "0x1841C4B40")]
	public bool OCICCDHAKGE(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x41C46B0", Offset = "0x41C30B0", VA = "0x1841C46B0")]
	public bool FEDIOEIBEJL(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x41C47D0", Offset = "0x41C31D0", VA = "0x1841C47D0")]
	public bool GGNGOEANAEK(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x41C47E0", Offset = "0x41C31E0", VA = "0x1841C47E0")]
	public void GGPELIFFPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x41C4230", Offset = "0x41C2C30", VA = "0x1841C4230")]
	public void AIMCNDPKEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x41C44E0", Offset = "0x41C2EE0", VA = "0x1841C44E0")]
	public void CKIEIOOCMAM(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x41C4DE0", Offset = "0x41C37E0", VA = "0x1841C4DE0")]
	public void PDOAHDCGLGB(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x41C4F30", Offset = "0x41C3930", VA = "0x1841C4F30")]
	public bool PLGNHPCLDMP(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x41C4870", Offset = "0x41C3270", VA = "0x1841C4870")]
	public void GODIAHNCEBI(int FAOFKPMBKFB, int HGMGPFAJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x41C4320", Offset = "0x41C2D20", VA = "0x1841C4320")]
	public void AMLNDKEHNOI(int EMHGFHLKKCB, int CCAKDIALPDH, int HGMGPFAJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x41C4A00", Offset = "0x41C3400", VA = "0x1841C4A00")]
	public int IFPOOIAJHAI(int HGMGPFAJPJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x41C4AD0", Offset = "0x41C34D0", VA = "0x1841C4AD0")]
	public int IFPOOIAJHAI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x41C4EE0", Offset = "0x41C38E0", VA = "0x1841C4EE0")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x41C4990", Offset = "0x41C3390", VA = "0x1841C4990", Slot = "4")]
	[IteratorStateMachine(typeof(OPHGGPJNOBI))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x41C4990", Offset = "0x41C3390", VA = "0x1841C4990", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class KMGJKCMHKFK<T> : global::FNDENOGMNOF<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::LNAJEOGGKHI<T> CDNCJKHHMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::KCCACFEFJEJ<T> CMDCDCFPIIE;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x25114D0", Offset = "0x250FED0", VA = "0x1825114D0")]
	public KMGJKCMHKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x3BBFC10", Offset = "0x3BBE610", VA = "0x183BBFC10")]
	public KMGJKCMHKFK(global::LNAJEOGGKHI<T> CDNCJKHHMKI, global::KCCACFEFJEJ<T> CMDCDCFPIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF520", Offset = "0x3BBDF20", VA = "0x183BBF520", Slot = "11")]
	public override T AIBDMMJCKEC(JOFAGGFHODA HKBKIOGINEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF860", Offset = "0x3BBE260", VA = "0x183BBF860", Slot = "12")]
	public override void HGLHKADDNFF(JOFAGGFHODA HKBKIOGINEL, T MFBGAMJDOKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class KGPFFFCJEPE
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x36F5FE0", Offset = "0x36F49E0", VA = "0x1836F5FE0")]
	public static KOPBFNLIDKA AIDBCCOFMIA<T>(this ELCCCBPFNLA PILEKMCPEGL, global::KLCCANBKHMJ<T> KMEGKECOLPJ, global::LNAJEOGGKHI<T> CDNCJKHHMKI, global::KCCACFEFJEJ<T> CMDCDCFPIIE) where T : struct
	{
		return default(KOPBFNLIDKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class JOJLDOHILDE<T> : global::KMGJKCMHKFK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x3756190", Offset = "0x3754B90", VA = "0x183756190")]
	public JOJLDOHILDE(T IPPOHHHCAKI, T JJNBFMOBAFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class NBFNLDCDIOO<T> : global::FNDENOGMNOF<T> where T : struct, EBILCGEECNE
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x390B860", Offset = "0x390A260", VA = "0x18390B860", Slot = "11")]
	public override T AIBDMMJCKEC(JOFAGGFHODA HKBKIOGINEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x390B8F0", Offset = "0x390A2F0", VA = "0x18390B8F0", Slot = "12")]
	public override void HGLHKADDNFF(JOFAGGFHODA HKBKIOGINEL, T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x269E220", Offset = "0x269CC20", VA = "0x18269E220")]
	public NBFNLDCDIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class BKOOIOOEPCK : MPBMOLLPGKG
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type JMCGNMKINCE
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void AIBDMMJCKEC(JOFAGGFHODA HKBKIOGINEL, in PGINEPENLDH MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HGLHKADDNFF(JOFAGGFHODA HKBKIOGINEL, in ABKAKFBNEMO MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void MDLBBNFEBPN(JOFAGGFHODA HKBKIOGINEL, GCKODEDKALM FDBMBDCEONF, [Optional] object BKJKDPLKCNE);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected BKOOIOOEPCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class FNDENOGMNOF<T> : BKOOIOOEPCK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type JMCGNMKINCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x36220E0", Offset = "0x3620AE0", VA = "0x1836220E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T AIBDMMJCKEC(JOFAGGFHODA HKBKIOGINEL);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void HGLHKADDNFF(JOFAGGFHODA HKBKIOGINEL, T MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x3620270", Offset = "0x361EC70", VA = "0x183620270", Slot = "8")]
	public override void AIBDMMJCKEC(JOFAGGFHODA HKBKIOGINEL, in PGINEPENLDH BJCKADBMKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x3620710", Offset = "0x361F110", VA = "0x183620710", Slot = "9")]
	public override void HGLHKADDNFF(JOFAGGFHODA HKBKIOGINEL, in ABKAKFBNEMO BMKGEKNDEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x36214F0", Offset = "0x361FEF0", VA = "0x1836214F0", Slot = "10")]
	public override void MDLBBNFEBPN(JOFAGGFHODA HKBKIOGINEL, GCKODEDKALM FDBMBDCEONF, object BKJKDPLKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x3166830", Offset = "0x3165230", VA = "0x183166830")]
	protected FNDENOGMNOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class NMPJCCKFJPK
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class CHPJHEFLFFM
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class CMGJJOIMCDG<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
			public CMGJJOIMCDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x39C1D10", Offset = "0x39C0710", VA = "0x1839C1D10")]
			internal void <RegisterFixedString>b__0(JOFAGGFHODA p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x39C1F80", Offset = "0x39C0980", VA = "0x1839C1F80")]
			internal T <RegisterFixedString>b__1(JOFAGGFHODA p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x47C00D0", Offset = "0x47BEAD0", VA = "0x1847C00D0")]
		public static void POJEDNLCFEH(NFCGAOFKOGI GIAFGFGMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5C90", Offset = "0x3BE4690", VA = "0x183BE5C90")]
		private static void OCGDKBFEMHK<T>(NFCGAOFKOGI GIAFGFGMCGP, int JJNBFMOBAFD) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x3BE55B0", Offset = "0x3BE3FB0", VA = "0x183BE55B0")]
		private static void HBDLMNBOEMI<T>(JOFAGGFHODA KAONFFKIECC, T PKKHHJKMKKB, int JJNBFMOBAFD) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5640", Offset = "0x3BE4040", VA = "0x183BE5640")]
		private static T OAEICGDBCOC<T>(JOFAGGFHODA KAONFFKIECC, int JJNBFMOBAFD) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public CHPJHEFLFFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class GLKMKCEODLI : DGFFOFELDLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private NFCGAOFKOGI GIAFGFGMCGP;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1530", Offset = "0x3BEFF30", VA = "0x183BF1530", Slot = "6")]
		public override void BPEJBPLGJKO<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x47C2DD0", Offset = "0x47C17D0", VA = "0x1847C2DD0")]
		public static void OECHNCIIMGL(NFCGAOFKOGI GIAFGFGMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x47C2E80", Offset = "0x47C1880", VA = "0x1847C2E80")]
		public GLKMKCEODLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1050", Offset = "0x3DDFA50", VA = "0x183DE1050")]
	public static void KODJKLOPGOI(NFCGAOFKOGI GIAFGFGMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x367CF70", Offset = "0x367B970", VA = "0x18367CF70")]
	public static void CCGAIGHFGFA<T>(NFCGAOFKOGI GIAFGFGMCGP, global::LNAJEOGGKHI<T> CDNCJKHHMKI, global::KCCACFEFJEJ<T> CMDCDCFPIIE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x367D000", Offset = "0x367BA00", VA = "0x18367D000")]
	public static void LHHKIHJNMFL<T>(NFCGAOFKOGI JBOFELLLEJF) where T : struct, EBILCGEECNE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
public interface NFCGAOFKOGI : global::FDAAFCNDEBE<NFCGAOFKOGI>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIDBCCOFMIA(Type EMKINACMDLO, MPBMOLLPGKG JBOFELLLEJF);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDMJPHIOICO(Type EMKINACMDLO, out MPBMOLLPGKG JBOFELLLEJF);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class OLEMHKFNGNK
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3FB0", Offset = "0x3DE29B0", VA = "0x183DE3FB0")]
	public static void AIDBCCOFMIA(this NFCGAOFKOGI LMACCHFJBFE, MPBMOLLPGKG JBOFELLLEJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[LHOECCIDBFM(typeof(ELCCCBPFNLA), new string[] { })]
public sealed class PFOPNIHCGLE : ELCCCBPFNLA, global::FDAAFCNDEBE<ELCCCBPFNLA>, NMGDKBIHJIB, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<KOPBFNLIDKA, MPBMOLLPGKG> GIAFGFGMCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private NFCGAOFKOGI MANJBADNAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private NPCKMHCNIEO PILEKMCPEGL;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool MBEMPBJIALD
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DF27F0", Offset = "0x3DF11F0", VA = "0x183DF27F0")]
	public PFOPNIHCGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2870", Offset = "0x3DF1270", VA = "0x183DF2870")]
	public PFOPNIHCGLE(Dictionary<KOPBFNLIDKA, MPBMOLLPGKG> GIAFGFGMCGP, bool IOEBKDHFHBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2220", Offset = "0x3DF0C20", VA = "0x183DF2220", Slot = "7")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2720", Offset = "0x3DF1120", VA = "0x183DF2720", Slot = "8")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3DF27A0", Offset = "0x3DF11A0", VA = "0x183DF27A0", Slot = "9")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x3DF24A0", Offset = "0x3DF0EA0", VA = "0x183DF24A0", Slot = "4")]
	public KOPBFNLIDKA HMMGHMOMKKF(ELPOGHCFKOG KMEGKECOLPJ)
	{
		return default(KOPBFNLIDKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x3DF20B0", Offset = "0x3DF0AB0", VA = "0x183DF20B0", Slot = "5")]
	public void AIDBCCOFMIA(KOPBFNLIDKA BEEBALICHLA, MPBMOLLPGKG JBOFELLLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2360", Offset = "0x3DF0D60", VA = "0x183DF2360")]
	[Conditional("DEBUG_BUILD")]
	private void GLDOBMFAIFC(KOPBFNLIDKA BEEBALICHLA, Type EMKINACMDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2570", Offset = "0x3DF0F70", VA = "0x183DF2570", Slot = "6")]
	public bool MDMJPHIOICO(KOPBFNLIDKA BEEBALICHLA, out MPBMOLLPGKG JBOFELLLEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2280", Offset = "0x3DF0C80", VA = "0x183DF2280", Slot = "10")]
	public ELCCCBPFNLA GKKBNGJCNEO()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[LHOECCIDBFM(typeof(NFCGAOFKOGI), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.TypeSerializer)]
	public sealed class TypeSerializerService : NMGDKBIHJIB, NFCGAOFKOGI, global::FDAAFCNDEBE<NFCGAOFKOGI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, MPBMOLLPGKG> GIAFGFGMCGP;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool MBEMPBJIALD
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x80A4B0", Offset = "0x808EB0", VA = "0x18080A4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D31540", Offset = "0x3D2FF40", VA = "0x183D31540")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D315C0", Offset = "0x3D2FFC0", VA = "0x183D315C0")]
		public TypeSerializerService(Dictionary<Type, MPBMOLLPGKG> GIAFGFGMCGP, bool IOEBKDHFHBJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D312D0", Offset = "0x3D2FCD0", VA = "0x183D312D0", Slot = "4")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D311B0", Offset = "0x3D2FBB0", VA = "0x183D311B0", Slot = "5")]
		public void AIDBCCOFMIA(Type EMKINACMDLO, MPBMOLLPGKG JBOFELLLEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D31410", Offset = "0x3D2FE10", VA = "0x183D31410", Slot = "6")]
		public bool MDMJPHIOICO(Type EMKINACMDLO, out MPBMOLLPGKG JBOFELLLEJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D31330", Offset = "0x3D2FD30", VA = "0x183D31330", Slot = "7")]
		public NFCGAOFKOGI GKKBNGJCNEO()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[LHOECCIDBFM(typeof(NOMFLOOPPBO), new string[] { })]
internal sealed class DNPEAJDFJAA : NOMFLOOPPBO, NMGDKBIHJIB, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<KOPBFNLIDKA, BPLADCEECNF> LNMJAAECGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private NPCKMHCNIEO PILEKMCPEGL;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x3E90C10", Offset = "0x3E8F610", VA = "0x183E90C10", Slot = "6")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x3E90CD0", Offset = "0x3E8F6D0", VA = "0x183E90CD0", Slot = "7")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E90BA0", Offset = "0x3E8F5A0", VA = "0x183E90BA0", Slot = "4")]
	public void AIDBCCOFMIA(KOPBFNLIDKA OAOKPGOEMMH, Type PKKPBKIEAHC, BPLADCEECNF NEBOFNHLOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E90C60", Offset = "0x3E8F660", VA = "0x183E90C60", Slot = "5")]
	public bool MHJLBBCJHOA(KOPBFNLIDKA OAOKPGOEMMH, out BPLADCEECNF NEBOFNHLOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E90D30", Offset = "0x3E8F730", VA = "0x183E90D30")]
	[Conditional("DEBUG_BUILD")]
	private void PMOBBEFMPPB(KOPBFNLIDKA OAOKPGOEMMH, Type PKKPBKIEAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x3E90F20", Offset = "0x3E8F920", VA = "0x183E90F20")]
	public DNPEAJDFJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[LHOECCIDBFM(typeof(HPKNMJNPDKH), new string[] { })]
internal sealed class EEHFKNCPGPG : HPKNMJNPDKH, NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly GNJOKDIHLGB PAOIPBACBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<ANIMKGBLAIA, int> IIEHEJDOKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> NKKOJBCBKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[JLCJNHHCBDK]
	private NPCKMHCNIEO PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[JLCJNHHCBDK]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int ODFJAOLFAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E92CC0", Offset = "0x3E916C0", VA = "0x183E92CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool CFHHAFMAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x878090", Offset = "0x876A90", VA = "0x180878090", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x878110", Offset = "0x876B10", VA = "0x180878110", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E92990", Offset = "0x3E91390", VA = "0x183E92990", Slot = "6")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E92F20", Offset = "0x3E91920", VA = "0x183E92F20", Slot = "7")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E92D10", Offset = "0x3E91710", VA = "0x183E92D10", Slot = "8")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E92E80", Offset = "0x3E91880", VA = "0x183E92E80")]
	private void KNPONNKELGA(GEEJJFIMDNA BJLPLHMBBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E92DC0", Offset = "0x3E917C0", VA = "0x183E92DC0", Slot = "4")]
	public bool JGHEPEFIMDB(ANIMKGBLAIA BBILPABEHHM, KOPBFNLIDKA EELLPGLCOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E92AA0", Offset = "0x3E914A0", VA = "0x183E92AA0", Slot = "5")]
	public void GCFBGEPGDCF(ANIMKGBLAIA BBILPABEHHM, Span<KOPBFNLIDKA> PILEKMCPEGL, bool AEOPPLDLFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E92990", Offset = "0x3E91390", VA = "0x183E92990", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E92FA0", Offset = "0x3E919A0", VA = "0x183E92FA0")]
	public EEHFKNCPGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class DNJLJMGEBOG
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E907F0", Offset = "0x3E8F1F0", VA = "0x183E907F0")]
	public static void AOKHKKODFHA(this JOFAGGFHODA HKBKIOGINEL, ReadOnlyMemory<byte> EDGHKLJCCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x320BF30", Offset = "0x320A930", VA = "0x18320BF30")]
	public static void HPLMGCLEHBJ<T>(this JOFAGGFHODA HKBKIOGINEL, in T MFBGAMJDOKA) where T : struct, EBILCGEECNE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x320C060", Offset = "0x320AA60", VA = "0x18320C060")]
	public static T OMAAFJOGMAB<T>(this JOFAGGFHODA HKBKIOGINEL) where T : struct, EBILCGEECNE
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E908A0", Offset = "0x3E8F2A0", VA = "0x183E908A0")]
	public static void HPLMGCLEHBJ(this JOFAGGFHODA HKBKIOGINEL, KIFMGABIGHN NNBGNGKALEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E90870", Offset = "0x3E8F270", VA = "0x183E90870")]
	public static KIFMGABIGHN FHCCLENDKOL(this JOFAGGFHODA HKBKIOGINEL)
	{
		return default(KIFMGABIGHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E909F0", Offset = "0x3E8F3F0", VA = "0x183E909F0")]
	public static void JKGNBFNPHHE(this JOFAGGFHODA GDCNFEACGCO, uint NPPJLOBADEJ, bool HOLMGEHPOIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E908D0", Offset = "0x3E8F2D0", VA = "0x183E908D0")]
	public static uint ILOINLDCEBI(this JOFAGGFHODA GNAHIECKPBK, bool HOLMGEHPOIE = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class CELBJLEGPID
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class PHMEDDBJEIE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public PHMEDDBJEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x43D5920", Offset = "0x43D4320", VA = "0x1843D5920")]
		internal void <GetByteEnumDelegates>b__0(JOFAGGFHODA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x43D5990", Offset = "0x43D4390", VA = "0x1843D5990")]
		internal T <GetByteEnumDelegates>b__1(JOFAGGFHODA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class KIGCGJMOELG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public KIGCGJMOELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x3804B80", Offset = "0x3803580", VA = "0x183804B80")]
		internal void <GetSByteEnumDelegates>b__0(JOFAGGFHODA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x3804BF0", Offset = "0x38035F0", VA = "0x183804BF0")]
		internal T <GetSByteEnumDelegates>b__1(JOFAGGFHODA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class PNOIDPNDIMB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public PNOIDPNDIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x43E9E70", Offset = "0x43E8870", VA = "0x1843E9E70")]
		internal void <GetShortEnumDelegates>b__0(JOFAGGFHODA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x43E9EE0", Offset = "0x43E88E0", VA = "0x1843E9EE0")]
		internal T <GetShortEnumDelegates>b__1(JOFAGGFHODA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class PMABCADGHCH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public PMABCADGHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x43E19E0", Offset = "0x43E03E0", VA = "0x1843E19E0")]
		internal void <GetUShortEnumDelegates>b__0(JOFAGGFHODA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x43E1A50", Offset = "0x43E0450", VA = "0x1843E1A50")]
		internal T <GetUShortEnumDelegates>b__1(JOFAGGFHODA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class LILDPMLEBMM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public LILDPMLEBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x443FA70", Offset = "0x443E470", VA = "0x18443FA70")]
		internal void <GetIntEnumDelegates>b__0(JOFAGGFHODA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x443FAD0", Offset = "0x443E4D0", VA = "0x18443FAD0")]
		internal T <GetIntEnumDelegates>b__1(JOFAGGFHODA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class HJCCJDKLPBM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public HJCCJDKLPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x4734020", Offset = "0x4732A20", VA = "0x184734020")]
		internal void <GetUIntEnumDelegates>b__0(JOFAGGFHODA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x4734080", Offset = "0x4732A80", VA = "0x184734080")]
		internal T <GetUIntEnumDelegates>b__1(JOFAGGFHODA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x344EFD0", Offset = "0x344D9D0", VA = "0x18344EFD0")]
	public static void KCFIEJGLLDK<T>(T IPPOHHHCAKI, T JJNBFMOBAFD, out global::LNAJEOGGKHI<T> AHFGNMOENKI, out global::KCCACFEFJEJ<T> ICGLNKOFNKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x344EE80", Offset = "0x344D880", VA = "0x18344EE80")]
	private static void JCFGONABKLI<T>(T IPPOHHHCAKI, T JJNBFMOBAFD, out global::LNAJEOGGKHI<T> AHFGNMOENKI, out global::KCCACFEFJEJ<T> ICGLNKOFNKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x344EE80", Offset = "0x344D880", VA = "0x18344EE80")]
	private static void KKNAHOMFACA<T>(T IPPOHHHCAKI, T JJNBFMOBAFD, out global::LNAJEOGGKHI<T> AHFGNMOENKI, out global::KCCACFEFJEJ<T> ICGLNKOFNKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x344EBE0", Offset = "0x344D5E0", VA = "0x18344EBE0")]
	private static void JAKHJBBFKOA<T>(T IPPOHHHCAKI, T JJNBFMOBAFD, out global::LNAJEOGGKHI<T> AHFGNMOENKI, out global::KCCACFEFJEJ<T> ICGLNKOFNKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x344EBE0", Offset = "0x344D5E0", VA = "0x18344EBE0")]
	private static void CIGFIOGMHGB<T>(T IPPOHHHCAKI, T JJNBFMOBAFD, out global::LNAJEOGGKHI<T> AHFGNMOENKI, out global::KCCACFEFJEJ<T> ICGLNKOFNKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x344ED30", Offset = "0x344D730", VA = "0x18344ED30")]
	private static void IIPMHDFMKFL<T>(T IPPOHHHCAKI, T JJNBFMOBAFD, out global::LNAJEOGGKHI<T> AHFGNMOENKI, out global::KCCACFEFJEJ<T> ICGLNKOFNKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x344ED30", Offset = "0x344D730", VA = "0x18344ED30")]
	private static void GHEADPGFNDO<T>(T IPPOHHHCAKI, T JJNBFMOBAFD, out global::LNAJEOGGKHI<T> AHFGNMOENKI, out global::KCCACFEFJEJ<T> ICGLNKOFNKJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class BGCJJOEAJOI : MGBMFCFIAMC, BCGODABHHDD
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BC60", Offset = "0x3E7A660", VA = "0x183E7BC60", Slot = "4")]
	private void KIKKBJCILGB(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void GDEDHLMMFLG(ELCCCBPFNLA PILEKMCPEGL);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	protected BGCJJOEAJOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[JIGFCOCIBKO(typeof(LocalPoseData))]
public sealed class PGGHCPNMJMO : BGCJJOEAJOI
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3050", Offset = "0x3DF1A50", VA = "0x183DF3050", Slot = "5")]
	protected override void GDEDHLMMFLG(ELCCCBPFNLA PILEKMCPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	public PGGHCPNMJMO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	internal class CopyAuthorityToEntity : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery FBACDKEKDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery OCNHBOBHAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery HPEFIHBEICE;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BE90", Offset = "0x3E8A890", VA = "0x183E8BE90", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C380", Offset = "0x3E8AD80", VA = "0x183E8C380", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C500", Offset = "0x3E8AF00", VA = "0x183E8C500", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C4D0", Offset = "0x3E8AED0", VA = "0x183E8C4D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BB50", Offset = "0x3E8A550", VA = "0x183E8BB50")]
		private void LPPBBHIDHJF(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C1E0", Offset = "0x3E8ABE0", VA = "0x183E8C1E0")]
		private void OKAPFIPFEKD(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BF00", Offset = "0x3E8A900", VA = "0x183E8BF00")]
		private void OHMCMLAEGHM(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B790", Offset = "0x3E8A190", VA = "0x183E8B790")]
		private void KBDJOMNOFDC(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B940", Offset = "0x3E8A340", VA = "0x183E8B940")]
		private void KNNCDNHIJPO(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B6B0", Offset = "0x3E8A0B0", VA = "0x183E8B6B0")]
		private void CCKILEBLFBF(GEEJJFIMDNA BJLPLHMBBOJ, int IPCLKHGHEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class KJGFFLJHAMJ : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private OGJECELGDOJ FAMLIKPHPAP;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x41D1AF0", Offset = "0x41D04F0", VA = "0x1841D1AF0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x41D1B40", Offset = "0x41D0540", VA = "0x1841D1B40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x41D1C00", Offset = "0x41D0600", VA = "0x1841D1C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x41D1FD0", Offset = "0x41D09D0", VA = "0x1841D1FD0")]
	private void PAMFFBDJEIB(NativeArray<Entity> AJMHFNCBOJK, NativeList<Entity> ALGDCDLMPIH, ComponentDataFromEntity<MBDJNINKOFB> IJMHGKNOMBB, BufferFromEntity<ChildrenData> JBHBOOHIAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public KJGFFLJHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class AHOKDLMNAFN : ParentSystemBase<AuthoredParentData, LEOKMENFMEB, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x3E77750", Offset = "0x3E76150", VA = "0x183E77750", Slot = "14")]
	protected override EntityQueryDesc IEGLPBPAOMN(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0xA1A940", Offset = "0xA19340", VA = "0x180A1A940", Slot = "15")]
	protected override EntityQueryDesc KAAJFLCLHGM(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x3E77710", Offset = "0x3E76110", VA = "0x183E77710", Slot = "16")]
	protected override EntityQueryDesc EOBJKMCCBNG(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x3E776D0", Offset = "0x3E760D0", VA = "0x183E776D0", Slot = "17")]
	protected override EntityQueryDesc BOKAFEECAIF(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x3E777D0", Offset = "0x3E761D0", VA = "0x183E777D0")]
	public AHOKDLMNAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x3E77790", Offset = "0x3E76190", VA = "0x183E77790", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class FDBBCEPMJLO : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object AOHOKMKMJMO;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x41C13E0", Offset = "0x41BFDE0", VA = "0x1841C13E0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x41C1460", Offset = "0x41BFE60", VA = "0x1841C1460", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x41C1500", Offset = "0x41BFF00", VA = "0x1841C1500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public FDBBCEPMJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class MINDJNDOMGF : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object AOHOKMKMJMO;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFBE0", Offset = "0x3DDE5E0", VA = "0x183DDFBE0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFC60", Offset = "0x3DDE660", VA = "0x183DDFC60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFD00", Offset = "0x3DDE700", VA = "0x183DDFD00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public MINDJNDOMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct MJBLLEGKHNH : ISystemStateBufferElementData, IBufferElementData, IEquatable<MJBLLEGKHNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public CKFIMJDPCLG DFKGNJHDLAL;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFF80", Offset = "0x3DDE980", VA = "0x183DDFF80", Slot = "4")]
	public bool Equals(MJBLLEGKHNH EHBPAFKHADK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0")]
	public static MJBLLEGKHNH EHMKDPHHPBI(CKFIMJDPCLG DFKGNJHDLAL)
	{
		return default(MJBLLEGKHNH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct PEDPIDIHNFG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public CKFIMJDPCLG DFKGNJHDLAL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0")]
	public static PEDPIDIHNFG EHMKDPHHPBI(CKFIMJDPCLG DFKGNJHDLAL)
	{
		return default(PEDPIDIHNFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class CHKOJBIHPOF : FPAEPNIDENB
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x3E81A70", Offset = "0x3E80470", VA = "0x183E81A70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x3E81C00", Offset = "0x3E80600", VA = "0x183E81C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0640", Offset = "0x3DDF040", VA = "0x183DE0640")]
	protected CHKOJBIHPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[PAOJICDMIEO]
internal abstract class FPAEPNIDENB : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected CEILNDOCFMN PALOPBGAJFN;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract LKEMJBFOHHC LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x41C2C50", Offset = "0x41C1650", VA = "0x1841C2C50", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x41C2960", Offset = "0x41C1360", VA = "0x1841C2960")]
	protected void DJIFBDACDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x41C26E0", Offset = "0x41C10E0", VA = "0x1841C26E0")]
	protected void BIINEACEKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x41C2BE0", Offset = "0x41C15E0", VA = "0x1841C2BE0")]
	protected ACDEDGBHHIP DNAGEKACLBB()
	{
		return default(ACDEDGBHHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	protected FPAEPNIDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class MOCGNGEDKHG : FPAEPNIDENB
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0410", Offset = "0x3DDEE10", VA = "0x183DE0410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE05A0", Offset = "0x3DDEFA0", VA = "0x183DE05A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0640", Offset = "0x3DDF040", VA = "0x183DE0640")]
	protected MOCGNGEDKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class APJBGCICLNO : FPAEPNIDENB
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x3E77EA0", Offset = "0x3E768A0", VA = "0x183E77EA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x3E77FB0", Offset = "0x3E769B0", VA = "0x183E77FB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0640", Offset = "0x3DDF040", VA = "0x183DE0640")]
	protected APJBGCICLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class MGNNEJMLPDH : CHKOJBIHPOF
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override LKEMJBFOHHC LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3DDFB60", Offset = "0x3DDE560", VA = "0x183DDFB60", Slot = "15")]
		get
		{
			return default(LKEMJBFOHHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFBD0", Offset = "0x3DDE5D0", VA = "0x183DDFBD0")]
	public MGNNEJMLPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class FACAPPMFMLJ : MOCGNGEDKHG
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override LKEMJBFOHHC LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x41C1300", Offset = "0x41BFD00", VA = "0x1841C1300", Slot = "15")]
		get
		{
			return default(LKEMJBFOHHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFBD0", Offset = "0x3DDE5D0", VA = "0x183DDFBD0")]
	public FACAPPMFMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class HJACFLMKDEE : APJBGCICLNO
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override LKEMJBFOHHC LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x41C5BA0", Offset = "0x41C45A0", VA = "0x1841C5BA0", Slot = "15")]
		get
		{
			return default(LKEMJBFOHHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFBD0", Offset = "0x3DDE5D0", VA = "0x183DDFBD0")]
	public HJACFLMKDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class BEJOIANMPNG : CHKOJBIHPOF
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override LKEMJBFOHHC LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B8D0", Offset = "0x3E7A2D0", VA = "0x183E7B8D0", Slot = "15")]
		get
		{
			return default(LKEMJBFOHHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0640", Offset = "0x3DDF040", VA = "0x183DE0640")]
	public BEJOIANMPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class FKEEHAFJILK : MOCGNGEDKHG
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override LKEMJBFOHHC LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x41C2510", Offset = "0x41C0F10", VA = "0x1841C2510", Slot = "15")]
		get
		{
			return default(LKEMJBFOHHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFBD0", Offset = "0x3DDE5D0", VA = "0x183DDFBD0")]
	public FKEEHAFJILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class FCMIOJBJIDN : APJBGCICLNO
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override LKEMJBFOHHC LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x41C1370", Offset = "0x41BFD70", VA = "0x1841C1370", Slot = "15")]
		get
		{
			return default(LKEMJBFOHHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFBD0", Offset = "0x3DDE5D0", VA = "0x183DDFBD0")]
	public FCMIOJBJIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct EDOMAMCBPCE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct ONLIHMKIIOF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct CHNPKBADCLA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct LKEMJBFOHHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType OFOOCJNMFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType NJMFJIGMBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object HMAOAMDKNDD;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDB80", Offset = "0x3DDC580", VA = "0x183DDDB80")]
	public LKEMJBFOHHC(ComponentType OFOOCJNMFKL, ComponentType NJMFJIGMBPE, object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x3700030", Offset = "0x36FEA30", VA = "0x183700030")]
	public static LKEMJBFOHHC PLBJOAHNOPL<TReq, TTag>(object HMAOAMDKNDD)
	{
		return default(LKEMJBFOHHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class GPGGCEBKCPD
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string HCEHKOOMNMG = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string KLHIGOIJIHK = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly LKEMJBFOHHC JKOPLLPLHFO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly LKEMJBFOHHC DLDPBHECCDA;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct CKFIMJDPCLG : global::EIJDEJKCJCH<CKFIMJDPCLG>, LFLEFMNCAPN, IEquatable<CKFIMJDPCLG>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int EOGKCECFNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x8650A0", Offset = "0x863AA0", VA = "0x1808650A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int GGPKANELEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x865090", Offset = "0x863A90", VA = "0x180865090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x865100", Offset = "0x863B00", VA = "0x180865100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool GGNGOEANAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x3E81DD0", Offset = "0x3E807D0", VA = "0x183E81DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x3E81D80", Offset = "0x3E80780", VA = "0x183E81D80", Slot = "8")]
	public bool Equals(CKFIMJDPCLG EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x3E81E10", Offset = "0x3E80810", VA = "0x183E81E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[PAOJICDMIEO]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Connectables)]
	public class UpdateConnectableVisuals : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct CCBMBOBOOPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public CKFIMJDPCLG DFKGNJHDLAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 LHCEFCJDGIJ;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x47BFDB0", Offset = "0x47BE7B0", VA = "0x1847BFDB0")]
			public CCBMBOBOOPG(CKFIMJDPCLG DFKGNJHDLAL, float3 LHCEFCJDGIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x47BFD90", Offset = "0x47BE790", VA = "0x1847BFD90")]
			public void NIELGFEEDGF(out CKFIMJDPCLG DFKGNJHDLAL, out float3 LHCEFCJDGIJ)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct JIGMIBNCHFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<CCBMBOBOOPG> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
			public JIGMIBNCHFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<PEDPIDIHNFG> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct HLDIGBJEDDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<CCBMBOBOOPG> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
			public HLDIGBJEDDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<MJBLLEGKHNH> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct EKKFCIJLGPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<CCBMBOBOOPG> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
			public EKKFCIJLGPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in JBHPJMIDAKJ com, in DynamicBuffer<MJBLLEGKHNH> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct FLEENMFCCDN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct KHDINBJPBLN
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct DOPIPIJKOPE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DIOMLGHOOFG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<PEDPIDIHNFG>.Runtime AKPAOPLCPPP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> EDBBMKKJPIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<PEDPIDIHNFG> LNNKAIMBBAI;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x47C5520", Offset = "0x47C3F20", VA = "0x1847C5520")]
				public void GOEDFNFGIMK(UpdateConnectableVisuals PNPLHMJCODG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x47C5460", Offset = "0x47C3E60", VA = "0x1847C5460")]
				public DOPIPIJKOPE AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
				{
					return default(DOPIPIJKOPE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals CELNPACHKFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<CCBMBOBOOPG> ECNPNAMGIHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private KHDINBJPBLN EOMBGLIAFHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KHDINBJPBLN.DOPIPIJKOPE* GEPGJELPJPI;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x47C2320", Offset = "0x47C0D20", VA = "0x1847C2320")]
			internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, WorldPoseData DEFIGPBNJBA, in DynamicBuffer<PEDPIDIHNFG> GFHEAAHHEHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x47C2710", Offset = "0x47C1110", VA = "0x1847C2710", Slot = "5")]
			public void ReadFromDisplayClass(ref JIGMIBNCHFO BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x47C2740", Offset = "0x47C1140", VA = "0x1847C2740", Slot = "6")]
			public void WriteToDisplayClass(ref JIGMIBNCHFO BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x47C2200", Offset = "0x47C0C00", VA = "0x1847C2200", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x47C25D0", Offset = "0x47C0FD0", VA = "0x1847C25D0")]
			public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, ref KHDINBJPBLN.DOPIPIJKOPE MCBIPMIEJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x47C22E0", Offset = "0x47C0CE0", VA = "0x1847C22E0")]
			public void GOEDFNFGIMK(UpdateConnectableVisuals PNPLHMJCODG, ref JIGMIBNCHFO BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x47C2560", Offset = "0x47C0F60", VA = "0x1847C2560")]
			public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MLIOBBONDPC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct HIOHGPAGMMN
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct PLGGMBLELHF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DIOMLGHOOFG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<MJBLLEGKHNH>.Runtime AKPAOPLCPPP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> EDBBMKKJPIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<MJBLLEGKHNH> LNNKAIMBBAI;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x47C3960", Offset = "0x47C2360", VA = "0x1847C3960")]
				public void GOEDFNFGIMK(UpdateConnectableVisuals PNPLHMJCODG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x47C38C0", Offset = "0x47C22C0", VA = "0x1847C38C0")]
				public PLGGMBLELHF AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
				{
					return default(PLGGMBLELHF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<CCBMBOBOOPG> ECNPNAMGIHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private HIOHGPAGMMN EOMBGLIAFHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HIOHGPAGMMN.PLGGMBLELHF* GEPGJELPJPI;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x47C9430", Offset = "0x47C7E30", VA = "0x1847C9430")]
			internal void HMFDLPJJJOE(in WorldPoseData DEFIGPBNJBA, in DynamicBuffer<MJBLLEGKHNH> GFHEAAHHEHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xCE0800", Offset = "0xCDF200", VA = "0x180CE0800", Slot = "5")]
			public void ReadFromDisplayClass(ref HLDIGBJEDDM BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x47C92C0", Offset = "0x47C7CC0", VA = "0x1847C92C0", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x47C9540", Offset = "0x47C7F40", VA = "0x1847C9540")]
			public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref HIOHGPAGMMN.PLGGMBLELHF MCBIPMIEJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x47C9390", Offset = "0x47C7D90", VA = "0x1847C9390")]
			public void GOEDFNFGIMK(UpdateConnectableVisuals PNPLHMJCODG, ref HLDIGBJEDDM BBMIICOMDHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct JDOOHEDELLE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct BJIPNNLLFMG
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct GBDGFDFDBBL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime DIOMLGHOOFG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<JBHPJMIDAKJ>.Runtime PAGPKFOHEPO;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<MJBLLEGKHNH>.Runtime AKPAOPLCPPP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> EDBBMKKJPIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<JBHPJMIDAKJ> NGPNCLJLPFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<MJBLLEGKHNH> LNNKAIMBBAI;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x47BF860", Offset = "0x47BE260", VA = "0x1847BF860")]
				public void GOEDFNFGIMK(UpdateConnectableVisuals PNPLHMJCODG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x47BF790", Offset = "0x47BE190", VA = "0x1847BF790")]
				public GBDGFDFDBBL AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
				{
					return default(GBDGFDFDBBL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<CCBMBOBOOPG> ECNPNAMGIHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private BJIPNNLLFMG EOMBGLIAFHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BJIPNNLLFMG.GBDGFDFDBBL* GEPGJELPJPI;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x47C4C50", Offset = "0x47C3650", VA = "0x1847C4C50")]
			internal void HMFDLPJJJOE(in WorldPoseData DEFIGPBNJBA, in JBHPJMIDAKJ GLNIAJLPINN, in DynamicBuffer<MJBLLEGKHNH> GFHEAAHHEHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xCE0800", Offset = "0xCDF200", VA = "0x180CE0800", Slot = "5")]
			public void ReadFromDisplayClass(ref EKKFCIJLGPG BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x47C4B90", Offset = "0x47C3590", VA = "0x1847C4B90", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x47C4DB0", Offset = "0x47C37B0", VA = "0x1847C4DB0")]
			public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref BJIPNNLLFMG.GBDGFDFDBBL MCBIPMIEJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x47C4C10", Offset = "0x47C3610", VA = "0x1847C4C10")]
			public void GOEDFNFGIMK(UpdateConnectableVisuals PNPLHMJCODG, ref EKKFCIJLGPG BBMIICOMDHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery LCMGHFHNLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery GCDNONIJGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery GCCFLFCNKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery DKPPOEFAJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery HADHILJCECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery PIJMAAJPKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery GEIMHJICGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery OPLCMKIKPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery JPBFEANHBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery AAOOEABCBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::DDHALPPBFJD<CKFIMJDPCLG, LFFGGCFFMHP> IMGCGOLMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private FADGHEDABFI BKLPNJCHOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private BFJCJFMHLPG KHIBGIIIKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private FOOJKCOEHCG PAJGOKFKGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery FHLBLGKLNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker HOLPDIGNFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery EEDCILCFDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery HBAODOFGHON;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int GNKNLJGDNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x3D31EB0", Offset = "0x3D308B0", VA = "0x183D31EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x3D34510", Offset = "0x3D32F10", VA = "0x183D34510")]
		internal LFFGGCFFMHP IGHGLNFOGDB(CKFIMJDPCLG DFKGNJHDLAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x3D35520", Offset = "0x3D33F20", VA = "0x183D35520", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x3D359B0", Offset = "0x3D343B0", VA = "0x183D359B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x3D35C30", Offset = "0x3D34630", VA = "0x183D35C30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x3D35DC0", Offset = "0x3D347C0", VA = "0x183D35DC0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x3D35BF0", Offset = "0x3D345F0", VA = "0x183D35BF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x3D34BE0", Offset = "0x3D335E0", VA = "0x183D34BE0")]
		private void JPMJCDAMONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x3D34EF0", Offset = "0x3D338F0", VA = "0x183D34EF0")]
		private void KOHPJGKJNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x3D32AE0", Offset = "0x3D314E0", VA = "0x183D32AE0")]
		private void EJAGIEEEOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x3D35E00", Offset = "0x3D34800", VA = "0x183D35E00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x3D35040", Offset = "0x3D33A40", VA = "0x183D35040")]
		private void LHJKKDLNDBN(EntityQuery FBACDKEKDEM, EntityQuery MGLBNGMEPMB, EntityQuery OCNHBOBHAFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x3D34160", Offset = "0x3D32B60", VA = "0x183D34160")]
		private void HEOHJOBENDL(EntityQuery OCNHBOBHAFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x3D34230", Offset = "0x3D32C30", VA = "0x183D34230")]
		private void HHLDAEBIEAL(NativeArrayAsync<Entity> IGDLJNCHFJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x3D31EF0", Offset = "0x3D308F0", VA = "0x183D31EF0")]
		private void CCCFPDLOFNN(NativeArrayAsync<Entity> DLMHALNGHGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x3D32780", Offset = "0x3D31180", VA = "0x183D32780")]
		private void DPBIKNHOCGO(NativeArrayAsync<Entity> CCMILCKEFDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x3D31D40", Offset = "0x3D30740", VA = "0x183D31D40")]
		private void AJKDOMHPJOK(NativeList<CKFIMJDPCLG> DCILGEEJONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x3D32000", Offset = "0x3D30A00", VA = "0x183D32000")]
		private NativeList<CKFIMJDPCLG> CFLJOBGNLON(NativeArray<Entity> AJMHFNCBOJK)
		{
			return default(NativeList<CKFIMJDPCLG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x3D333C0", Offset = "0x3D31DC0", VA = "0x183D333C0")]
		private void FEPPBIGMJBG(NativeArray<Entity> AJMHFNCBOJK, NativeList<CKFIMJDPCLG> DCILGEEJONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x3D32E90", Offset = "0x3D31890", VA = "0x183D32E90")]
		private void FEAPJODCPKN(NativeArray<Entity> NLEHKKJLEEH, NativeArray<Entity> BOMCANMKHFH, NativeList<CKFIMJDPCLG> NKKOJBCBKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x3D34730", Offset = "0x3D33130", VA = "0x183D34730")]
		private void JDFDIJJMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x3D34560", Offset = "0x3D32F60", VA = "0x183D34560")]
		private NativeListAsync<CCBMBOBOOPG> JAIBLGPMOAH(EntityQuery IOEGIOMNPHI, Func<NativeList<CCBMBOBOOPG>, JobHandle> PBEAPOKFLFL)
		{
			return default(NativeListAsync<CCBMBOBOOPG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x3D339E0", Offset = "0x3D323E0", VA = "0x183D339E0")]
		private JobHandle GBKKOHINFIO(NativeList<CCBMBOBOOPG> ECNPNAMGIHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x3D35F90", Offset = "0x3D34990", VA = "0x183D35F90")]
		private JobHandle PGNPNPMCABD(NativeList<CCBMBOBOOPG> ECNPNAMGIHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x3D31C10", Offset = "0x3D30610", VA = "0x183D31C10")]
		private JobHandle AILEGGCCIAI(NativeList<CCBMBOBOOPG> ECNPNAMGIHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x3D33ED0", Offset = "0x3D328D0", VA = "0x183D33ED0")]
		private void HAKHJLIPOIB(NativeListAsync<CCBMBOBOOPG> ECNPNAMGIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x3D33B70", Offset = "0x3D32570", VA = "0x183D33B70")]
		private void GCADOPINLEG(NativeListAsync<CCBMBOBOOPG> ECNPNAMGIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x3D35F30", Offset = "0x3D34930", VA = "0x183D35F30")]
		private bool PEFDBJKCGNC(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x3D33E00", Offset = "0x3D32800", VA = "0x183D33E00")]
		private NativeArray<Entity> GPMBOIMCLBC(Entity OOGAMDNOHNH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x3D32920", Offset = "0x3D31320", VA = "0x183D32920")]
		private CKFIMJDPCLG EIICGJKOLCP(NativeList<CKFIMJDPCLG> NKKOJBCBKEN)
		{
			return default(CKFIMJDPCLG);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x3D346A0", Offset = "0x3D330A0", VA = "0x183D346A0")]
		private void JCANDGLMCCA(CKFIMJDPCLG DFKGNJHDLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x3D35850", Offset = "0x3D34250", VA = "0x183D35850", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x3D34CF0", Offset = "0x3D336F0", VA = "0x183D34CF0")]
		public static EntityQuery KHCOHGDNGMP(ComponentSystemBase PNPLHMJCODG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x3D32520", Offset = "0x3D30F20", VA = "0x183D32520")]
		public static EntityQuery COODIDCHIOM(ComponentSystemBase PNPLHMJCODG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x3D355E0", Offset = "0x3D33FE0", VA = "0x183D355E0")]
		public static EntityQuery NHPFEOBFJNH(ComponentSystemBase PNPLHMJCODG)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery IOEGIOMNPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private AJDBIBIKOCB ILCFADBMBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private FABDCPGOAMJ NBEJPNKHHPJ;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAE70", Offset = "0x3DF9870", VA = "0x183DFAE70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DFADE0", Offset = "0x3DF97E0", VA = "0x183DFADE0", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAF70", Offset = "0x3DF9970", VA = "0x183DFAF70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class KKPIIKGPNHE : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public MABFCBAKEGH KDNKFCLFKBG;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KKPIIKGPNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	public KKPIIKGPNHE(MABFCBAKEGH KDNKFCLFKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x41D25B0", Offset = "0x41D0FB0", VA = "0x1841D25B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class OIPEFOKDJNB : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService JMHKMIOCNFD;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3A70", Offset = "0x3DE2470", VA = "0x183DE3A70", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3AD0", Offset = "0x3DE24D0", VA = "0x183DE3AD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3B00", Offset = "0x3DE2500", VA = "0x183DE3B00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	protected OIPEFOKDJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class BJDJDGCPCKJ : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery HDDJJLOFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery JPNFKGDFIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery LEFFNBCHBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery ODCLAPCOIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService LCFKIPCEGKA;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int LIGJKEPAOEH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C100", Offset = "0x3E7AB00", VA = "0x183E7C100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int CLAHPAPIJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C230", Offset = "0x3E7AC30", VA = "0x183E7C230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C600", Offset = "0x3E7B000", VA = "0x183E7C600", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C7B0", Offset = "0x3E7B1B0", VA = "0x183E7C7B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C9B0", Offset = "0x3E7B3B0", VA = "0x183E7C9B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C790", Offset = "0x3E7B190", VA = "0x183E7C790")]
	public int OFFJNMKKNIB(SceneTag OPCKNOAJELE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C770", Offset = "0x3E7B170", VA = "0x183E7C770")]
	public int NNGIMDNINAK(SceneTag OPCKNOAJELE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C310", Offset = "0x3E7AD10", VA = "0x183E7C310")]
	protected void KJPKHOPPENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C660", Offset = "0x3E7B060", VA = "0x183E7C660")]
	protected void NFNAHFFGKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C0B0", Offset = "0x3E7AAB0", VA = "0x183E7C0B0")]
	public NativeArrayAsync<Entity> AILAAHNCHGC(SceneTag OPCKNOAJELE, Allocator APPJGCOGPBM = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C170", Offset = "0x3E7AB70", VA = "0x183E7C170")]
	public NativeArrayAsync<Entity> EANOLPOFDHN(SceneTag OPCKNOAJELE, Allocator APPJGCOGPBM = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C530", Offset = "0x3E7AF30", VA = "0x183E7C530")]
	public bool LCIOMHCFLJA(SceneTag OPCKNOAJELE, out NativeArrayAsync<Entity> KDNKFCLFKBG, Allocator APPJGCOGPBM = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C110", Offset = "0x3E7AB10", VA = "0x183E7C110")]
	public bool CFECPBDNIEP(Entity OOGAMDNOHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C1C0", Offset = "0x3E7ABC0", VA = "0x183E7C1C0")]
	public MABFCBAKEGH FMPLBFNIBKK(Entity OOGAMDNOHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C2A0", Offset = "0x3E7ACA0", VA = "0x183E7C2A0")]
	public bool ILGPCLHAMEC(Entity OOGAMDNOHNH, out KKPIIKGPNHE KDNKFCLFKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C5C0", Offset = "0x3E7AFC0", VA = "0x183E7C5C0")]
	public void LKPGFFHIKHI(Entity OOGAMDNOHNH, KKPIIKGPNHE KDNKFCLFKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C240", Offset = "0x3E7AC40", VA = "0x183E7C240")]
	public bool IBIBMMCPFNG(Entity OOGAMDNOHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void HBCHMKGKIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public BJDJDGCPCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class EOICKHBIMIG : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery PAMNMHPAKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private OGJECELGDOJ FAMLIKPHPAP;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x41BAFC0", Offset = "0x41B99C0", VA = "0x1841BAFC0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x41BB010", Offset = "0x41B9A10", VA = "0x1841BB010", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x41BB0D0", Offset = "0x41B9AD0", VA = "0x1841BB0D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x32243B0", Offset = "0x3222DB0", VA = "0x1832243B0")]
	private bool OPNCGECHJNH<TComponentData>(EntityQuery IOEGIOMNPHI, out NativeArray<Entity> AJMHFNCBOJK, out NativeArray<TComponentData> HNJADIDOPMA) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x41BAF50", Offset = "0x41B9950", VA = "0x1841BAF50")]
	public MABFCBAKEGH FMPLBFNIBKK(Entity OOGAMDNOHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public EOICKHBIMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery PIELNAKJICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery MKKMCEDGIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery KHMCHAKLOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery HPEFIHBEICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D27480", Offset = "0x3D25E80", VA = "0x183D27480", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D274D0", Offset = "0x3D25ED0", VA = "0x183D274D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D27700", Offset = "0x3D26100", VA = "0x183D27700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D270B0", Offset = "0x3D25AB0", VA = "0x183D270B0")]
		private void IFPOOIAJHAI(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D27040", Offset = "0x3D25A40", VA = "0x183D27040")]
		private void HEOHJOBENDL(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D27690", Offset = "0x3D26090", VA = "0x183D27690", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D27120", Offset = "0x3D25B20", VA = "0x183D27120")]
		private void JBHAJKJLGKG(EntityQuery IOEGIOMNPHI, bool DKMFIFCJODD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class BDGNPBNECBM : HIEJFMJLCNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct JBOKCOEFDJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public JBOKCOEFDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JDKLEDAENGP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct CCPKMAADCKI
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct LHICKDKKHGD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime IAOELOHEBLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime BPPAGOHOICJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime EODNDBLHAAB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CPJDDECNIGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> NGIGJPLEJOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> HGNMDDABELF;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x47BFE90", Offset = "0x47BE890", VA = "0x1847BFE90")]
			public void GOEDFNFGIMK(BDGNPBNECBM PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x47BFDD0", Offset = "0x47BE7D0", VA = "0x1847BFDD0")]
			public LHICKDKKHGD AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(LHICKDKKHGD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private CCPKMAADCKI EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CCPKMAADCKI.LHICKDKKHGD* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B880", Offset = "0x3D1A280", VA = "0x183D1B880")]
		internal void HMFDLPJJJOE(Entity BBNCDKBJCLG, SplineShapeData NHAGEBCMLPC, DynamicBuffer<LinkedEntityGroup> CKDPLHPNFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B7F0", Offset = "0x3D1A1F0", VA = "0x183D1B7F0", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B8E0", Offset = "0x3D1A2E0", VA = "0x183D1B8E0")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref CCPKMAADCKI.LHICKDKKHGD MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B870", Offset = "0x3D1A270", VA = "0x183D1B870")]
		public void GOEDFNFGIMK(BDGNPBNECBM PNPLHMJCODG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CDGIBKCLECA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct CDNCDBFEOHP
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct HGOBHHOCJHO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime DDJPHNEMKOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime GAEFGICPOPE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LMAOPPADDJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> OIHNOIEBEGM;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x47BFF90", Offset = "0x47BE990", VA = "0x1847BFF90")]
			public void GOEDFNFGIMK(BDGNPBNECBM PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x47BFF10", Offset = "0x47BE910", VA = "0x1847BFF10")]
			public HGOBHHOCJHO AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(HGOBHHOCJHO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> OPMNHEBACFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private CDNCDBFEOHP EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CDNCDBFEOHP.HGOBHHOCJHO* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AEA0", Offset = "0x3D198A0", VA = "0x183D1AEA0")]
		internal void HMFDLPJJJOE(Entity ELPGBLPAGPI, SplinePointParentData FOIPEEGFCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x1BAB950", Offset = "0x1BAA350", VA = "0x181BAB950", Slot = "5")]
		public void ReadFromDisplayClass(ref JBOKCOEFDJM BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D1ADF0", Offset = "0x3D197F0", VA = "0x183D1ADF0", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AF30", Offset = "0x3D19930", VA = "0x183D1AF30")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref CDNCDBFEOHP.HGOBHHOCJHO MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AE60", Offset = "0x3D19860", VA = "0x183D1AE60")]
		public void GOEDFNFGIMK(BDGNPBNECBM PNPLHMJCODG, ref JBOKCOEFDJM BBMIICOMDHE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery IFLEMNNLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery ENNPGCBDIAL;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AD90", Offset = "0x3E79790", VA = "0x183E7AD90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AE40", Offset = "0x3E79840", VA = "0x183E7AE40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public BDGNPBNECBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AAF0", Offset = "0x3E794F0", VA = "0x183E7AAF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A950", Offset = "0x3E79350", VA = "0x183E7A950")]
	public static EntityQuery LGCJJMNPBLG(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A7F0", Offset = "0x3E791F0", VA = "0x183E7A7F0")]
	public static EntityQuery GIIOKBLOBDB(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
public sealed class OHPPCLPKJLP : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private JJAKPFHGEID KBBOPDEEDJG;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3680", Offset = "0x3DE2080", VA = "0x183DE3680", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x3DE36E0", Offset = "0x3DE20E0", VA = "0x183DE36E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public OHPPCLPKJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class LBALNMDBJLJ : HIEJFMJLCNL, BCGODABHHDD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct EONFDLFLHFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<HAGEPIIBIHO> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<GEJEHFLELMJ> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<HAGEPIIBIHO> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public EONFDLFLHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, KAJDMPKAIDI previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__2(Entity entity, KAJDMPKAIDI previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct PGGEPOCJDDP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct NJBHGJMNFOI
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct AHLKHCLIIOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LPBDPLLPDKO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> EPDOOFMDBKO;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x47C9C60", Offset = "0x47C8660", VA = "0x1847C9C60")]
			public void GOEDFNFGIMK(LBALNMDBJLJ PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x47C9BE0", Offset = "0x47C85E0", VA = "0x1847C9BE0")]
			public AHLKHCLIIOK AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(AHLKHCLIIOK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<HAGEPIIBIHO> DOANLMCCNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private NJBHGJMNFOI EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NJBHGJMNFOI.AHLKHCLIIOK* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x47CB480", Offset = "0x47C9E80", VA = "0x1847CB480")]
		internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, ParentData DLGOBANMMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0xCE0800", Offset = "0xCDF200", VA = "0x180CE0800", Slot = "5")]
		public void ReadFromDisplayClass(ref EONFDLFLHFO BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x47CB350", Offset = "0x47C9D50", VA = "0x1847CB350", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x47CB500", Offset = "0x47C9F00", VA = "0x1847CB500")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref NJBHGJMNFOI.AHLKHCLIIOK MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x47CB3F0", Offset = "0x47C9DF0", VA = "0x1847CB3F0")]
		public void GOEDFNFGIMK(LBALNMDBJLJ PNPLHMJCODG, ref EONFDLFLHFO BBMIICOMDHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FDFNICIFCHF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct PGLLODFONCO
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct JAOBAPINDBG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LPBDPLLPDKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<KAJDMPKAIDI>.Runtime NBANEKFJNMI;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> EPDOOFMDBKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<KAJDMPKAIDI> JGBMIIEDEIN;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x47CB650", Offset = "0x47CA050", VA = "0x1847CB650")]
			public void GOEDFNFGIMK(LBALNMDBJLJ PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x47CB5B0", Offset = "0x47C9FB0", VA = "0x1847CB5B0")]
			public JAOBAPINDBG AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(JAOBAPINDBG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<GEJEHFLELMJ> PGCICLMODDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private PGLLODFONCO EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PGLLODFONCO.JAOBAPINDBG* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x47C2050", Offset = "0x47C0A50", VA = "0x1847C2050")]
		internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, ParentData DLGOBANMMLN, KAJDMPKAIDI CPMGOPFMMHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x47C21F0", Offset = "0x47C0BF0", VA = "0x1847C21F0", Slot = "5")]
		public void ReadFromDisplayClass(ref EONFDLFLHFO BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x47C1F40", Offset = "0x47C0940", VA = "0x1847C1F40", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x47C2110", Offset = "0x47C0B10", VA = "0x1847C2110")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref PGLLODFONCO.JAOBAPINDBG MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x47C2010", Offset = "0x47C0A10", VA = "0x1847C2010")]
		public void GOEDFNFGIMK(LBALNMDBJLJ PNPLHMJCODG, ref EONFDLFLHFO BBMIICOMDHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct AFELLMPHKOF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct KFIEODKEFJG
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct CGNAIBHMABF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<KAJDMPKAIDI>.Runtime NBANEKFJNMI;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<KAJDMPKAIDI> JGBMIIEDEIN;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x47C5400", Offset = "0x47C3E00", VA = "0x1847C5400")]
			public void GOEDFNFGIMK(LBALNMDBJLJ PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x47C5380", Offset = "0x47C3D80", VA = "0x1847C5380")]
			public CGNAIBHMABF AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(CGNAIBHMABF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<HAGEPIIBIHO> NJMIMEMNEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private KFIEODKEFJG EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KFIEODKEFJG.CGNAIBHMABF* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x47BE6E0", Offset = "0x47BD0E0", VA = "0x1847BE6E0")]
		internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, KAJDMPKAIDI CPMGOPFMMHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x47BE810", Offset = "0x47BD210", VA = "0x1847BE810", Slot = "5")]
		public void ReadFromDisplayClass(ref EONFDLFLHFO BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x47BE5B0", Offset = "0x47BCFB0", VA = "0x1847BE5B0", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x47BE760", Offset = "0x47BD160", VA = "0x1847BE760")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref KFIEODKEFJG.CGNAIBHMABF MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x47BE650", Offset = "0x47BD050", VA = "0x1847BE650")]
		public void GOEDFNFGIMK(LBALNMDBJLJ PNPLHMJCODG, ref EONFDLFLHFO BBMIICOMDHE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private ADANANCGCCD DBDOHKBNJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery OCEGACPLLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery OFJHGMMBBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery CKKNIAKHNJK;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x41D5C90", Offset = "0x41D4690", VA = "0x1841D5C90", Slot = "14")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x41D5DD0", Offset = "0x41D47D0", VA = "0x1841D5DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public LBALNMDBJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x41D5D70", Offset = "0x41D4770", VA = "0x1841D5D70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x41D5A30", Offset = "0x41D4430", VA = "0x1841D5A30")]
	public static EntityQuery GCBPHCGPDIN(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x41D6090", Offset = "0x41D4A90", VA = "0x1841D6090")]
	public static EntityQuery PMCDMFFLHBH(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x41D5830", Offset = "0x41D4230", VA = "0x1841D5830")]
	public static EntityQuery CLDHNDBGLFO(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Connectables)]
	public class InitializeRigidbodyExHierarchy : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery IOEGIOMNPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private ALPMEKNKNOD FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x41CBEA0", Offset = "0x41CA8A0", VA = "0x1841CBEA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x41CBE30", Offset = "0x41CA830", VA = "0x1841CBE30", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x41CBF30", Offset = "0x41CA930", VA = "0x1841CBF30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class ACPJEHBGFBA : ParentSystemBase<ParentData, KAJDMPKAIDI, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x3E76C80", Offset = "0x3E75680", VA = "0x183E76C80", Slot = "14")]
	protected override EntityQueryDesc IEGLPBPAOMN(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0xA1A940", Offset = "0xA19340", VA = "0x180A1A940", Slot = "15")]
	protected override EntityQueryDesc KAAJFLCLHGM(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x3E76C40", Offset = "0x3E75640", VA = "0x183E76C40", Slot = "16")]
	protected override EntityQueryDesc EOBJKMCCBNG(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x3E76C00", Offset = "0x3E75600", VA = "0x183E76C00", Slot = "17")]
	protected override EntityQueryDesc BOKAFEECAIF(EntityQueryDesc IOEGIOMNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x3E76D00", Offset = "0x3E75700", VA = "0x183E76D00")]
	public ACPJEHBGFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x3E76CC0", Offset = "0x3E756C0", VA = "0x183E76CC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : HIEJFMJLCNL where ParentData : struct, IComponentData, OKEONJCOHFE where PreviousParentData : struct, IComponentData, OKEONJCOHFE where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, OKEONJCOHFE
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct ONGEHECMHNK : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter ADJNJMHKKEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter FFIJIFPCLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter BBNDFIIFJEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> FGMNILGDNJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> EOLPCFONIMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType BNMFANBLLGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint CMHGACECNIK;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x3B3F680", Offset = "0x3B3E080", VA = "0x183B3F680", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct NPEEANJIBPO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> BBNDFIIFJEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> IHFABFKFOEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> DAJHOOPPJKD;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x328B1B0", Offset = "0x3289BB0", VA = "0x18328B1B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct DLJNIEBIJPO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> ADJNJMHKKEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> FFIJIFPCLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> BBNDFIIFJEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> IHFABFKFOEE;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x3B876C0", Offset = "0x3B860C0", VA = "0x183B876C0")]
			private int DPCEAPEBCDE(DynamicBuffer<ChildrenData> GFIGBAPMFPP, Entity OOGAMDNOHNH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x3B87D00", Offset = "0x3B86700", VA = "0x183B87D00")]
			private void LIOLDDNFDPJ(Entity EOBFGLJBCIJ, DynamicBuffer<ChildrenData> GFIGBAPMFPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x3B87E60", Offset = "0x3B86860", VA = "0x183B87E60")]
			private void OBGNIBDBMFM(Entity EOBFGLJBCIJ, DynamicBuffer<ChildrenData> GFIGBAPMFPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x3B87A40", Offset = "0x3B86440", VA = "0x183B87A40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct HEOJJDPKAFF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> JPAMKHNGHMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> PLEEMIOGEJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> IHFABFKFOEE;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x45570E0", Offset = "0x4555AE0", VA = "0x1845570E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery GLKGOBPHGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery DMDOEBADEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery JHLIAEMPNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery NJICOMBGEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker GDIPJHMHOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker FOABAIDMNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker FPFKOHDFKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker JAOLLOGNGHJ;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x371AC10", Offset = "0x3719610", VA = "0x18371AC10")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x37191B0", Offset = "0x3717BB0", VA = "0x1837191B0")]
		private int DPCEAPEBCDE(DynamicBuffer<ChildrenData> GFIGBAPMFPP, Entity OOGAMDNOHNH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x3719690", Offset = "0x3718090", VA = "0x183719690")]
		private void EIDLGAHKNGO(Entity EDICKKEDHMM, Entity LFMIOBJLOLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xA1A940", Offset = "0xA19340", VA = "0x180A1A940", Slot = "14")]
		protected virtual EntityQueryDesc IEGLPBPAOMN(EntityQueryDesc IOEGIOMNPHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xA1A940", Offset = "0xA19340", VA = "0x180A1A940", Slot = "15")]
		protected virtual EntityQueryDesc KAAJFLCLHGM(EntityQueryDesc IOEGIOMNPHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA1A940", Offset = "0xA19340", VA = "0x180A1A940", Slot = "16")]
		protected virtual EntityQueryDesc EOBJKMCCBNG(EntityQueryDesc IOEGIOMNPHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc BOKAFEECAIF(EntityQueryDesc IOEGIOMNPHI);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x371A870", Offset = "0x3719270", VA = "0x18371A870", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x3719460", Offset = "0x3717E60", VA = "0x183719460")]
		private void EAOCBNOLHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x37197F0", Offset = "0x37181F0", VA = "0x1837197F0")]
		private void JKMNJJKCFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x371A0A0", Offset = "0x3718AA0", VA = "0x18371A0A0")]
		private JobHandle OBDBBMGCMJH(JobHandle GNKABAKGOAD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x3718BF0", Offset = "0x37175F0", VA = "0x183718BF0")]
		private void BFDFCCOLCAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x371AB40", Offset = "0x3719540", VA = "0x18371AB40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x371AB10", Offset = "0x3719510", VA = "0x18371AB10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x3166830", Offset = "0x3165230", VA = "0x183166830", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
public abstract class JGMIFFIGEFH : HIEJFMJLCNL, BCGODABHHDD
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct HMJIIPDBGLF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> OHFBPIEIAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> INPFMLMEHIK;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x47C3D40", Offset = "0x47C2740", VA = "0x1847C3D40")]
		public HMJIIPDBGLF(NativeList<Entity> OHFBPIEIAMN, NativeList<Entity> INPFMLMEHIK, JobHandle CJDKHEEAEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x47C3CC0", Offset = "0x47C26C0", VA = "0x1847C3CC0")]
		public JobHandle OLIFMKOJDLI(JobHandle GNKABAKGOAD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x47C3C30", Offset = "0x47C2630", VA = "0x1847C3C30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct DMAKAIHEPCF : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum LGHCPCJJPHK
		{
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		[WriteOnly]
		public NativeList<Entity> NOFFHEEJKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> EMFEFGIBHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> HIBOBFIBEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> KLGJMCLIDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity ELELGHNFGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity GJCBLAHINAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> JOAHOPPIGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int KNCJFICGHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int KJACPPJCJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private LGHCPCJJPHK AJLEGAJMBED;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x47C0E20", Offset = "0x47BF820", VA = "0x1847C0E20", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x47C12A0", Offset = "0x47BFCA0", VA = "0x1847C12A0")]
		private void KCFCANIJNGJ(Entity OOGAMDNOHNH, bool IAPINLCOKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x47C1030", Offset = "0x47BFA30", VA = "0x1847C1030")]
		private void GAABPKIGCFH(Entity OOGAMDNOHNH, bool IAPINLCOKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x47C1140", Offset = "0x47BFB40", VA = "0x1847C1140")]
		public HMJIIPDBGLF HGNJJGBNAKB(NativeArray<Entity> LAPGMJGKFPP, JobHandle GNKABAKGOAD)
		{
			return default(HMJIIPDBGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x47C0FB0", Offset = "0x47BF9B0", VA = "0x1847C0FB0")]
		public HMJIIPDBGLF FBGMLJPMKAH(NativeArray<Entity> LAPGMJGKFPP, JobHandle GNKABAKGOAD)
		{
			return default(HMJIIPDBGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x47C1330", Offset = "0x47BFD30", VA = "0x1847C1330")]
		public HMJIIPDBGLF KPGBIPECLDP(NativeList<HAGEPIIBIHO> ECNPNAMGIHB, JobHandle GNKABAKGOAD)
		{
			return default(HMJIIPDBGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x47C1670", Offset = "0x47C0070", VA = "0x1847C1670")]
		public HMJIIPDBGLF PGCJAEMHOMH(NativeList<HAGEPIIBIHO> ECNPNAMGIHB, JobHandle GNKABAKGOAD)
		{
			return default(HMJIIPDBGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x47C11C0", Offset = "0x47BFBC0", VA = "0x1847C11C0")]
		public HMJIIPDBGLF IIJEPJBBIOD(NativeList<GEJEHFLELMJ> ECNPNAMGIHB, JobHandle GNKABAKGOAD)
		{
			return default(HMJIIPDBGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8400", Offset = "0x3BE6E00", VA = "0x183BE8400")]
		private HMJIIPDBGLF OHHGHADHHBN<T>(NativeList<T> ECNPNAMGIHB, int GNGNIBEFAAA, int LEACFCMODAH, LGHCPCJJPHK DPFIFMCONAA, JobHandle GNKABAKGOAD) where T : struct
		{
			return default(HMJIIPDBGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x47C1410", Offset = "0x47BFE10", VA = "0x1847C1410")]
		private HMJIIPDBGLF OHHGHADHHBN(NativeArray<Entity> AJMHFNCBOJK, int GNGNIBEFAAA, int LEACFCMODAH, LGHCPCJJPHK DPFIFMCONAA, JobHandle GNKABAKGOAD)
		{
			return default(HMJIIPDBGLF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly NNLEPLPFODN DPMCBMJDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery OIEKICELIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery KFDBIMJKNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private ADANANCGCCD MMKGGEBPJGC;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType HOLCOIGLHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType INJMBFPJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType KIGCLKPMBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x41CFBA0", Offset = "0x41CE5A0", VA = "0x1841CFBA0")]
	protected JGMIFFIGEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x41CE6C0", Offset = "0x41CD0C0", VA = "0x1841CE6C0", Slot = "14")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x41CEA90", Offset = "0x41CD490", VA = "0x1841CEA90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x41CECC0", Offset = "0x41CD6C0", VA = "0x1841CECC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xB9BE80", Offset = "0xB9A880", VA = "0x180B9BE80", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x41CE410", Offset = "0x41CCE10", VA = "0x1841CE410")]
	private void FFIDCFFLAIF(NativeArray<Entity> ECNPNAMGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x41CE9F0", Offset = "0x41CD3F0", VA = "0x1841CE9F0")]
	private void NJEFCKBLHID(NativeArray<Entity> ECNPNAMGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x41CE470", Offset = "0x41CCE70", VA = "0x1841CE470")]
	private void IDBHACDLBKE(HMJIIPDBGLF CKLMMHOOPBC, string DNFMGLNNHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x41CE5B0", Offset = "0x41CCFB0", VA = "0x1841CE5B0")]
	private void IDBHACDLBKE(NativeListAsync<Entity> DAPHPFIOJHP, string DNFMGLNNHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x41CE7A0", Offset = "0x41CD1A0", VA = "0x1841CE7A0")]
	private void JLFJKLBCOPE(HMJIIPDBGLF CKLMMHOOPBC, string DNFMGLNNHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x41CE8E0", Offset = "0x41CD2E0", VA = "0x1841CE8E0")]
	private void JLFJKLBCOPE(NativeListAsync<Entity> DAPHPFIOJHP, string DNFMGLNNHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x41CFB30", Offset = "0x41CE530", VA = "0x1841CFB30")]
	private bool PGNNPPJKKOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
public class MAGAHIDGKKN : HIEJFMJLCNL, HNADMPPHDEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct JEJDDBOGFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public MAGAHIDGKKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public JEJDDBOGFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct NJDJHOINDMF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct HLHFKIJKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct NPBDPGGOBBE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime IBIBDAHHKNL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity KIHLMFMCEEF;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x47C3A80", Offset = "0x47C2480", VA = "0x1847C3A80")]
			public void GOEDFNFGIMK(MAGAHIDGKKN PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x47C3A70", Offset = "0x47C2470", VA = "0x1847C3A70")]
			public NPBDPGGOBBE AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(NPBDPGGOBBE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public MAGAHIDGKKN CELNPACHKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer ICOBJEIMJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private HLHFKIJKMPH EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HLHFKIJKMPH.NPBDPGGOBBE* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x47C9D50", Offset = "0x47C8750", VA = "0x1847C9D50")]
		internal void HMFDLPJJJOE(Entity GMPDCLNOOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C910", Offset = "0x3D1B310", VA = "0x183D1C910", Slot = "5")]
		public void ReadFromDisplayClass(ref JEJDDBOGFPF BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C940", Offset = "0x3D1B340", VA = "0x183D1C940", Slot = "6")]
		public void WriteToDisplayClass(ref JEJDDBOGFPF BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x47C9CC0", Offset = "0x47C86C0", VA = "0x1847C9CC0", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x47C9ED0", Offset = "0x47C88D0", VA = "0x1847C9ED0")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, ref HLHFKIJKMPH.NPBDPGGOBBE MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x47C9D10", Offset = "0x47C8710", VA = "0x1847C9D10")]
		public void GOEDFNFGIMK(MAGAHIDGKKN PNPLHMJCODG, ref JEJDDBOGFPF BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x47C9E60", Offset = "0x47C8860", VA = "0x1847C9E60")]
		public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private LNPBBEADBMI LCPALDBFBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private PGLCALCJHHL HAJNDDCJMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery DOJCEGAOKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker EIJBMCHIHLF;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF290", Offset = "0x3DDDC90", VA = "0x183DDF290", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF150", Offset = "0x3DDDB50", VA = "0x183DDF150", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF2F0", Offset = "0x3DDDCF0", VA = "0x183DDF2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public MAGAHIDGKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF1B0", Offset = "0x3DDDBB0", VA = "0x183DDF1B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEF80", Offset = "0x3DDD980", VA = "0x183DDEF80")]
	public static EntityQuery IEKAKJGOJKJ(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[PAOJICDMIEO]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
public class IFNABMFKNHF : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private PGLCALCJHHL HAJNDDCJMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService NJADCKCLHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x41C9920", Offset = "0x41C8320", VA = "0x1841C9920", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x41C9990", Offset = "0x41C8390", VA = "0x1841C9990", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x41C9A30", Offset = "0x41C8430", VA = "0x1841C9A30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public IFNABMFKNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct CBBCNEGGIOA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public EHCADCKGLFN DFKGNJHDLAL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x875BB0", Offset = "0x8745B0", VA = "0x180875BB0")]
	public static CBBCNEGGIOA EHMKDPHHPBI(in EHCADCKGLFN PCHDAFPLMJI)
	{
		return default(CBBCNEGGIOA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x875BB0", Offset = "0x8745B0", VA = "0x180875BB0")]
	public static EHCADCKGLFN EHMKDPHHPBI(in CBBCNEGGIOA OAEIOMNFDAC)
	{
		return default(EHCADCKGLFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class LNPBBEADBMI : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE250", Offset = "0x3DDCC50", VA = "0x183DDE250", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	public LNPBBEADBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
public class APLMINCPLAK : HIEJFMJLCNL, HNADMPPHDEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct FHNEHDHBMJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public APLMINCPLAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public FHNEHDHBMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__0(Entity e, CBBCNEGGIOA ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OCOGBIAEMKP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct OPLABPICIEC
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct AJHNFPKMJAA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime IBIBDAHHKNL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<CBBCNEGGIOA>.Runtime PDBIALCJNLM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity KIHLMFMCEEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<CBBCNEGGIOA> HINJILIDKCK;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x47CA660", Offset = "0x47C9060", VA = "0x1847CA660")]
			public void GOEDFNFGIMK(APLMINCPLAK PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x47CA5E0", Offset = "0x47C8FE0", VA = "0x1847CA5E0")]
			public AJHNFPKMJAA AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(AJHNFPKMJAA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public APLMINCPLAK CELNPACHKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer ICOBJEIMJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private OPLABPICIEC EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OPLABPICIEC.AJHNFPKMJAA* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C6F0", Offset = "0x3D1B0F0", VA = "0x183D1C6F0")]
		internal void HMFDLPJJJOE(Entity GMPDCLNOOMA, CBBCNEGGIOA HHIPIAJMJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C910", Offset = "0x3D1B310", VA = "0x183D1C910", Slot = "5")]
		public void ReadFromDisplayClass(ref FHNEHDHBMJF BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C940", Offset = "0x3D1B340", VA = "0x183D1C940", Slot = "6")]
		public void WriteToDisplayClass(ref FHNEHDHBMJF BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C640", Offset = "0x3D1B040", VA = "0x183D1C640", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C860", Offset = "0x3D1B260", VA = "0x183D1C860")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, ref OPLABPICIEC.AJHNFPKMJAA MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C6B0", Offset = "0x3D1B0B0", VA = "0x183D1C6B0")]
		public void GOEDFNFGIMK(APLMINCPLAK PNPLHMJCODG, ref FHNEHDHBMJF BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C7F0", Offset = "0x3D1B1F0", VA = "0x183D1C7F0")]
		public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private LNPBBEADBMI LCPALDBFBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private PGLCALCJHHL HAJNDDCJMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery LCGICDJLNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker EDMBCPBJOJI;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x3E78350", Offset = "0x3E76D50", VA = "0x183E78350", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x3E78040", Offset = "0x3E76A40", VA = "0x183E78040", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x3E783B0", Offset = "0x3E76DB0", VA = "0x183E783B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public APLMINCPLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x3E78270", Offset = "0x3E76C70", VA = "0x183E78270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x3E780A0", Offset = "0x3E76AA0", VA = "0x183E780A0")]
	public static EntityQuery ONLJONBNGBJ(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct EMEJCPAOJGB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public OIAINGCNGGF FBHAGLEGMDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, LEKKGHCNCEK> AJMHFNCBOJK;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x47C1E40", Offset = "0x47C0840", VA = "0x1847C1E40")]
			public EMEJCPAOJGB(int ICKPJJPJOOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x47C1DC0", Offset = "0x47C07C0", VA = "0x1847C1DC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct HLNEALGOIBA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> FKBJFKFADIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> GDOECCCFIHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> BPECJCKADNO;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x47C3A90", Offset = "0x47C2490", VA = "0x1847C3A90", Slot = "4")]
			public void Execute(int ALJOMNDNEBM, TransformAccess DBMMOFPNJHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct LFBBLANPLFD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> FKBJFKFADIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> BPECJCKADNO;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x47C69A0", Offset = "0x47C53A0", VA = "0x1847C69A0", Slot = "4")]
			public void Execute(int ALJOMNDNEBM, TransformAccess DBMMOFPNJHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private PGLCALCJHHL HAJNDDCJMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery HIIGAMBNDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery KFBFJCEEAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery NLHPAAHNFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery OKGOPACPLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery FGDFNEMMJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle ADIEOOOJHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private EMEJCPAOJGB GGDEIJPJDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private EMEJCPAOJGB IPIFGEOEBPF;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7A80", Offset = "0x3DF6480", VA = "0x183DF7A80", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7C20", Offset = "0x3DF6620", VA = "0x183DF7C20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7A40", Offset = "0x3DF6440", VA = "0x183DF7A40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7EE0", Offset = "0x3DF68E0", VA = "0x183DF7EE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7AE0", Offset = "0x3DF64E0", VA = "0x183DF7AE0")]
		private void OMFKAAMEGBK(EntityQuery IOEGIOMNPHI, out (NativeArrayAsync<CBBCNEGGIOA> handles, NativeArrayAsync<PKKHHCLHNOE> bounds) MNILNHMNKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x3DF73C0", Offset = "0x3DF5DC0", VA = "0x183DF73C0")]
		private void BMONIFJBEDD((NativeArrayAsync<CBBCNEGGIOA> handles, NativeArrayAsync<PKKHHCLHNOE> bounds) MNILNHMNKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7A40", Offset = "0x3DF6440", VA = "0x183DF7A40")]
		private void IAGCEJJMIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x3DF87E0", Offset = "0x3DF71E0", VA = "0x183DF87E0")]
		private void POJPLGMEELF(EntityQuery IOEGIOMNPHI, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<CBBCNEGGIOA> handles) MNILNHMNKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7750", Offset = "0x3DF6150", VA = "0x183DF7750")]
		private void FPAPAIFKPJN((NativeArrayAsync<Entity> entities, NativeArrayAsync<CBBCNEGGIOA> handles) MNILNHMNKJK, EMEJCPAOJGB POGHGGJFFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8680", Offset = "0x3DF7080", VA = "0x183DF8680")]
		private JobHandle PEDINNCNKBB(EMEJCPAOJGB POGHGGJFFJI, ComponentDataFromEntity<WorldPoseData> FKBJFKFADIJ, ComponentDataFromEntity<WorldUniformScaleData> BPECJCKADNO, ComponentDataFromEntity<WorldDeformableScaleData> GDOECCCFIHC)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7620", Offset = "0x3DF6020", VA = "0x183DF7620")]
		private JobHandle CFMJFPAGGPD(EMEJCPAOJGB POGHGGJFFJI, ComponentDataFromEntity<WorldPoseData> FKBJFKFADIJ, ComponentDataFromEntity<WorldUniformScaleData> BPECJCKADNO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct HHBCPJOCFAM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[PAOJICDMIEO]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public class SplineLocalBoundsSystem : HIEJFMJLCNL
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct HDBAHOCAKBO : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> GPPOFBBAFHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> IENKFCDNAFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<PKKHHCLHNOE> KAEPENFCAEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, LEKKGHCNCEK>.ParallelWriter LPJGEJBEHHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter MIFNDDNNPMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter MMAPABCPJJP;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x47C3200", Offset = "0x47C1C00", VA = "0x1847C3200", Slot = "4")]
			public void Execute(int ALJOMNDNEBM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct OKDCAJADHMO : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> LCDAMFIBCFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> MMBEEJPNOKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> GNMBEBCMKKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> MGFODKKPOGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<PKKHHCLHNOE> NJEIEPBEAJF;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x47CA150", Offset = "0x47C8B50", VA = "0x1847CA150", Slot = "4")]
			public void Execute(int ALJOMNDNEBM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery ECODEHJCGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery PNFKAJFECDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery MIJADLMKIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery LGHOFIIDMOL;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x3D29B00", Offset = "0x3D28500", VA = "0x183D29B00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x3D29D10", Offset = "0x3D28710", VA = "0x183D29D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x3D29A20", Offset = "0x3D28420", VA = "0x183D29A20")]
		private JobHandle NJNKFDOOJHG(NativeArrayAsync<Entity> HPOICFFOIAP, int GIDABKFIKCN, JobHandle GNKABAKGOAD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x3D29840", Offset = "0x3D28240", VA = "0x183D29840")]
		private JobHandle NJNKFDOOJHG(NativeArray<Entity> MHFEBOOHLLA, int GIDABKFIKCN, [Optional] JobHandle GNKABAKGOAD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x3D28DB0", Offset = "0x3D277B0", VA = "0x183D28DB0")]
		private NativeArrayAsync<Entity> DOKJNICAOFL(EntityQuery IOEGIOMNPHI)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x3D290C0", Offset = "0x3D27AC0", VA = "0x183D290C0")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) JFALEKHDDFF(NativeArrayAsync<Entity> OMFKJEHPNOP)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x3D28D20", Offset = "0x3D27720", VA = "0x183D28D20")]
		private void BJICPIHAPEH(out NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3D28E30", Offset = "0x3D27830", VA = "0x183D28E30")]
		private void FIJFOJCJMOM(NativeList<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x3D28EC0", Offset = "0x3D278C0", VA = "0x183D28EC0")]
		private void FIJFOJCJMOM(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x3D28F90", Offset = "0x3D27990", VA = "0x183D28F90")]
		private void HDLABKIKPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private static void BKNDELFFFHM(int DPLBDLILEAF, int CDCLMJGCDGO, int HAEICCKNPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x3D29510", Offset = "0x3D27F10", VA = "0x183D29510")]
		private static PKKHHCLHNOE LPDIGLCECNG(NativeArray<Entity> LMNPHNNANEL, ComponentDataFromEntity<SplinePointPositionData> GNMBEBCMKKN, ComponentDataFromEntity<SplinePointScaleData> MGFODKKPOGG)
		{
			return default(PKKHHCLHNOE);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct IFMFDPIOIJG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[PAOJICDMIEO]
	[KEFMDJAGLBH(IGKCNDFEDMC.Lifecycle)]
	public class DestroyLocalObjects : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[JLCJNHHCBDK]
		private ObjectNetworkToLocalMapService ALLIEBFHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[JLCJNHHCBDK]
		private ObjectLifecycleService PADNNEGLENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery JCLNGNFLGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery ACFAPLOGNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery HPEFIHBEICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E91F30", Offset = "0x3E90930", VA = "0x183E91F30", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E91B40", Offset = "0x3E90540", VA = "0x183E91B40")]
		public bool ADLPADNMGGM(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E920C0", Offset = "0x3E90AC0", VA = "0x183E920C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E91D30", Offset = "0x3E90730", VA = "0x183E91D30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E921F0", Offset = "0x3E90BF0", VA = "0x183E921F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x258B8B0", Offset = "0x258A2B0", VA = "0x18258B8B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E91D30", Offset = "0x3E90730", VA = "0x183E91D30")]
		private void GNKIAMFHIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E91E80", Offset = "0x3E90880", VA = "0x183E91E80")]
		private void KHFDJGLFGOO(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E91BF0", Offset = "0x3E905F0", VA = "0x183E91BF0")]
		private void FPJELGPNEFK(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E91D70", Offset = "0x3E90770", VA = "0x183E91D70")]
		private void HKFCFNMALAB(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E91FA0", Offset = "0x3E909A0", VA = "0x183E91FA0")]
		private void OCEIDCIGEJL(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[KEFMDJAGLBH(IGKCNDFEDMC.NetworkSend)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static AMLOFAHKBFL[] CGNCPMDGFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private BCHPAOAKNKC CJEMCBIJBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private IALPALJEAJO EFNFKMCKEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService HPPMFDJJMOO;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x41BF170", Offset = "0x41BDB70", VA = "0x1841BF170", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x41BF220", Offset = "0x41BDC20", VA = "0x1841BF220", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x41BEBE0", Offset = "0x41BD5E0", VA = "0x1841BEBE0")]
		private void IJAAMELCELP(AMLOFAHKBFL LMGMOPNOCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private void KGBAABFEAFE(Entity OOGAMDNOHNH, ANIMKGBLAIA BBILPABEHHM, HMBIKFADCFA LHICEFGLEJC, IIALMMAFGKL DMLCDECHMGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Callbacks)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public sealed class PropertyEventCallbacks : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService KONLJOKGCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService HPPMFDJJMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase LMGMOPNOCBJ;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE050", Offset = "0x3DFCA50", VA = "0x183DFE050", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE0E0", Offset = "0x3DFCAE0", VA = "0x183DFE0E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[KEFMDJAGLBH(IGKCNDFEDMC.NetworkSend)]
	internal class TransmitNetworkDataSystem : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private NFNDLMPOBLH NKFNHGNJMMP;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D31110", Offset = "0x3D2FB10", VA = "0x183D31110", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D31160", Offset = "0x3D2FB60", VA = "0x183D31160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[PAOJICDMIEO]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public class CalculateCullingBandChanges : HIEJFMJLCNL, NMGDKBIHJIB, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct PHOMOANLFIL : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType PBJMFOBICMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> NDLMMNBLKGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<NJMOENBKENH>.ParallelWriter OGKEOMDGGGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<HBBMAJHNMOM> PGCPDDAPFAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 BJCKADBMKDM;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 JMAKGKKGGCP;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 MAEECCIHHMD;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 PGDMDBFNMLD;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x3D1CED0", Offset = "0x3D1B8D0", VA = "0x183D1CED0", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int DMDHIGBFIGN = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double NFIFKBEODHH = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery BLBFDOCHAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery HDBHANNEPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double JNGJDBGDCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService MHJCMFABKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService APNACMJJDKJ;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E83F40", Offset = "0x3E82940", VA = "0x183E83F40", Slot = "14")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E83FC0", Offset = "0x3E829C0", VA = "0x183E83FC0", Slot = "15")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E84390", Offset = "0x3E82D90", VA = "0x183E84390", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E844E0", Offset = "0x3E82EE0", VA = "0x183E844E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E83F50", Offset = "0x3E82950", VA = "0x183E83F50")]
		private bool MEHFPJKNAHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E84050", Offset = "0x3E82A50", VA = "0x183E84050")]
		private void NNBDNFALOCP(EntityQuery IOEGIOMNPHI, float3 EOOCPCBAMHF, string KMEGKECOLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct NJMOENBKENH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity OOGAMDNOHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public CDOKOIKGOFB GFPNEMALIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public CDOKOIKGOFB JOOHHAMJDLM;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public class ProcessCullingBandChangeCallbacks : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService MHJCMFABKFM;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAD00", Offset = "0x3DF9700", VA = "0x183DFAD00", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAD50", Offset = "0x3DF9750", VA = "0x183DFAD50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Connectables)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public class UpdateInertialProperties : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery DKEPNODBCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private ENPBFGLEBMA EOIGCHLLHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D37B80", Offset = "0x3D36580", VA = "0x183D37B80", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D37BF0", Offset = "0x3D365F0", VA = "0x183D37BF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D37C80", Offset = "0x3D36680", VA = "0x183D37C80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[PAOJICDMIEO]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KMHKJNOPFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LNKPKELNKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MPOGKJKHPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService KHACDBFAEGE;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x41BE330", Offset = "0x41BCD30", VA = "0x1841BE330", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x41BE590", Offset = "0x41BCF90", VA = "0x1841BE590", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x41BDE80", Offset = "0x41BC880", VA = "0x1841BDE80")]
		private void IMMOPOJEEOF(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ECNPNAMGIHB, EntityQueryDesc OLAFHLFLLHK, bool LHAKPCGHEAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x41BDF90", Offset = "0x41BC990", VA = "0x1841BDF90")]
		private void IMMOPOJEEOF(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ECNPNAMGIHB, EntityQueryDesc OLAFHLFLLHK, bool LHAKPCGHEAG, bool PBLNDACCBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x41BE7F0", Offset = "0x41BD1F0", VA = "0x1841BE7F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x41BDAB0", Offset = "0x41BC4B0", VA = "0x1841BDAB0")]
		private void FKCCMPCDICG(EntityQuery IOEGIOMNPHI, bool FFGDMHNGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x41BE380", Offset = "0x41BCD80", VA = "0x1841BE380")]
		private void NHFILKCALDC(EntityQuery IOEGIOMNPHI, bool BAECMBAPNAJ, bool FFGDMHNGJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x41BE0D0", Offset = "0x41BCAD0", VA = "0x1841BE0D0")]
		private void KJBEJHJOOHP(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x41BD820", Offset = "0x41BC220", VA = "0x1841BD820")]
		private void EAKBFIJFAHJ(NativeList<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x41BD990", Offset = "0x41BC390", VA = "0x1841BD990")]
		private void EPHINFDDBCA(NativeArray<Entity> AJMHFNCBOJK, bool BAECMBAPNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x41BD590", Offset = "0x41BBF90", VA = "0x1841BD590")]
		private NativeList<Entity> CMOHBANNEGI(NativeArray<Entity> AJMHFNCBOJK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x41BE2F0", Offset = "0x41BCCF0", VA = "0x1841BE2F0")]
		private NativeList<Entity> LNKEFMMDGDN(NativeArray<Entity> AJMHFNCBOJK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x41BDCA0", Offset = "0x41BC6A0", VA = "0x1841BDCA0")]
		private NativeList<Entity> GHIHBGAGPPM(NativeArray<Entity> AJMHFNCBOJK)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x41BDCE0", Offset = "0x41BC6E0", VA = "0x1841BDCE0")]
		private NativeList<Entity> HHDHPNNIFBE(NativeArray<Entity> AJMHFNCBOJK, bool IGEKLHGFMBE)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x41BD790", Offset = "0x41BC190", VA = "0x1841BD790")]
		private LBPIMADBOIF DPNJKLMAFGM(NativeArray<Entity> AJMHFNCBOJK)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LBPIMADBOIF);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x41BEB10", Offset = "0x41BD510", VA = "0x1841BEB10")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService KHACDBFAEGE;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAD70", Offset = "0x3DF9770", VA = "0x183DFAD70", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x3DFADC0", Offset = "0x3DF97C0", VA = "0x183DFADC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : BFPKHLNEKPC
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery MKOGCMBNCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery NHJMDKGHFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery AJDJKBMAEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery AJFOCPEDDOK;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E917B0", Offset = "0x3E901B0", VA = "0x183E917B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E91970", Offset = "0x3E90370", VA = "0x183E91970", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E91330", Offset = "0x3E8FD30", VA = "0x183E91330")]
		private void AKJMJAAFDPH(EntityQuery IOEGIOMNPHI, bool IIOKLBJAFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x3E91570", Offset = "0x3E8FF70", VA = "0x183E91570")]
		private void KHKBMOGEKHD(EntityQuery IOEGIOMNPHI, bool IIOKLBJAFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	internal class AssignPlayerIdsSystem : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery LJGFMCMDEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery GOOGLADDCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService KIMBBFMGFGO;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E799F0", Offset = "0x3E783F0", VA = "0x183E799F0", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E79D80", Offset = "0x3E78780", VA = "0x183E79D80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x3E79E90", Offset = "0x3E78890", VA = "0x183E79E90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x3E794C0", Offset = "0x3E77EC0", VA = "0x183E794C0")]
		private void CKIHBGNDDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E79880", Offset = "0x3E78280", VA = "0x183E79880")]
		private void MJEAMCDBFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E79A60", Offset = "0x3E78460", VA = "0x183E79A60")]
		private void OMIDHLKLOMM(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E796E0", Offset = "0x3E780E0", VA = "0x183E796E0")]
		private void GNAFCKOHNLF(NativeArray<Entity> AJMHFNCBOJK, int JPHOOIIBFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E795D0", Offset = "0x3E77FD0", VA = "0x183E795D0")]
		private void CNAHIJOBOEA(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E79820", Offset = "0x3E78220", VA = "0x183E79820")]
		private void LIPLJIMNDBL(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private static void DLJBMCKCPGM(int IPCLKHGHEJH, Transform DBMMOFPNJHL, Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class GEJPJEKMIEO
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x41C2D30", Offset = "0x41C1730", VA = "0x1841C2D30")]
	public static bool NKODNJEAAKB(this SystemBase APCKCJOBOPP, out Entity OOGAMDNOHNH)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery HHHHMHFIIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private BFJCJFMHLPG BLIEJPIGDFE;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x3E86030", Offset = "0x3E84A30", VA = "0x183E86030", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x3E86080", Offset = "0x3E84A80", VA = "0x183E86080", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x3E86140", Offset = "0x3E84B40", VA = "0x183E86140", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<CMALIHMDLDB>, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string KONPNALCCEN = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private HBJIENGODMB EKJJANIBNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery JHGDOHCJHKJ;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity DFJAPIGEEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE410", Offset = "0x3DDCE10", VA = "0x183DDE410")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x3DDEA90", Offset = "0x3DDD490", VA = "0x183DDEA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity BGIMDBLCKIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE560", Offset = "0x3DDCF60", VA = "0x183DDE560")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public GEEJJFIMDNA EGEOLJDJGGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE5F0", Offset = "0x3DDCFF0", VA = "0x183DDE5F0")]
			get
			{
				return default(GEEJJFIMDNA);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE4F0", Offset = "0x3DDCEF0", VA = "0x183DDE4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public GEEJJFIMDNA EDBICMHDEHF
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x3DDEDA0", Offset = "0x3DDD7A0", VA = "0x183DDEDA0")]
			get
			{
				return default(GEEJJFIMDNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEC80", Offset = "0x3DDD680", VA = "0x183DDEC80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEA20", Offset = "0x3DDD420", VA = "0x183DDEA20", Slot = "15")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDED20", Offset = "0x3DDD720", VA = "0x183DDED20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEAF0", Offset = "0x3DDD4F0", VA = "0x183DDEAF0", Slot = "14")]
		protected override void ONJFHEIBGKN(NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> LMODJFANELC, NativeArray<Entity> PDBLCGKFHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE940", Offset = "0x3DDD340", VA = "0x183DDE940")]
		private void MICHFOMDDBA(NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> PDBLCGKFHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE680", Offset = "0x3DDD080", VA = "0x183DDE680")]
		private void JEOCAJJCADN(Entity OOGAMDNOHNH, Entity EGMEPCFGBID, Entity CDLOCIOKBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x370F5A0", Offset = "0x370DFA0", VA = "0x18370F5A0")]
		private bool MDMJPHIOICO<T>(out T MFBGAMJDOKA) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x370F4E0", Offset = "0x370DEE0", VA = "0x18370F4E0")]
		private void BPHKCHFMHEA<T>(T MFBGAMJDOKA) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE470", Offset = "0x3DDCE70", VA = "0x183DDE470")]
		public bool BNOAHICKBGC(GEEJJFIMDNA COBGBIGJLBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE5C0", Offset = "0x3DDCFC0", VA = "0x183DDE5C0")]
		private static bool GHIBLAGKCKL(GEEJJFIMDNA NIBLJKJKHKL, GEEJJFIMDNA ADHLILJDNHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEE80", Offset = "0x3DDD880", VA = "0x183DDEE80")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEC40", Offset = "0x3DDD640", VA = "0x183DDEC40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery IOEGIOMNPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E570", Offset = "0x3E8CF70", VA = "0x183E8E570", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E5C0", Offset = "0x3E8CFC0", VA = "0x183E8E5C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E660", Offset = "0x3E8D060", VA = "0x183E8E660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E420", Offset = "0x3E8CE20", VA = "0x183E8E420")]
		private NativeArray<Entity> LMKPKJGMLHF(int HGMGPFAJPJI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8E310", Offset = "0x3E8CD10", VA = "0x183E8E310")]
		private void CGIKFIMDOMF(NativeArray<Entity> APOPEAJIELO, NativeArray<Entity> NCONHJDEKJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	internal class HideRemotePivotsNotInScope : HIEJFMJLCNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery AGNFOJIPEEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery CCAJDPFNKIM;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x41C6300", Offset = "0x41C4D00", VA = "0x1841C6300", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x41C63F0", Offset = "0x41C4DF0", VA = "0x1841C63F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class IKJKNCCPJLM
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string EOBOOKKIJCF = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x3462270", Offset = "0x3460C70", VA = "0x183462270")]
	public static NativeArray<T> OHHGHADHHBN<T>(NativeArray<Entity> AJMHFNCBOJK, EntityManager IMCLABBJAOB) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x41CAA80", Offset = "0x41C9480", VA = "0x1841CAA80")]
	public static void LIKNJIOBMHJ(EntityQuery IOEGIOMNPHI, EntityManager IMCLABBJAOB, HLNKJMLPBIB BMDIGEODPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x41CA950", Offset = "0x41C9350", VA = "0x1841CA950")]
	public static void HOGCNFFEDKL(NativeArray<Entity> APOPEAJIELO, HLNKJMLPBIB BMDIGEODPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x41CA820", Offset = "0x41C9220", VA = "0x1841CA820")]
	public static void CMIOFPKADFN(NativeArray<Entity> APOPEAJIELO, HLNKJMLPBIB BMDIGEODPAI)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery IOEGIOMNPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService FBHAGLEGMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService PADNNEGLENL;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x3D378E0", Offset = "0x3D362E0", VA = "0x183D378E0", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x3D37A80", Offset = "0x3D36480", VA = "0x183D37A80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x3D37B20", Offset = "0x3D36520", VA = "0x183D37B20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x3D36120", Offset = "0x3D34B20", VA = "0x183D36120")]
		private void AEEIFIGBPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x3D37970", Offset = "0x3D36370", VA = "0x183D37970")]
		private void OOAHNGMDCED(NativeArray<Entity> APOPEAJIELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x3D36DC0", Offset = "0x3D357C0", VA = "0x183D36DC0")]
		private void BEHFFJCJENM(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3D37690", Offset = "0x3D36090", VA = "0x183D37690")]
		private void FOACBODJDDP(NativeArray<Entity> NCONHJDEKJF, NativeArray<RigidTransform> BHCGIPJHNHG, NativeArray<RigidTransform> FLHAPDJNFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x3D36930", Offset = "0x3D35330", VA = "0x183D36930")]
		private void BALFHOPHCAK(NativeArray<RigidTransform> FLHAPDJNFME, NativeArray<Entity> NCONHJDEKJF, NativeList<Entity> GKDIFJFLCAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	internal class PostGameplayOnScopeChange : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery HHHHMHFIIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery HJENFNIOJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9320", Offset = "0x3DF7D20", VA = "0x183DF9320", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9390", Offset = "0x3DF7D90", VA = "0x183DF9390", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x3DF94E0", Offset = "0x3DF7EE0", VA = "0x183DF94E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x3DF92B0", Offset = "0x3DF7CB0", VA = "0x183DF92B0")]
		private void GCFGMEEJOKF(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	internal class PreventDisembodiedScopesSystem : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery KBFLDKHKNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents GEPCFDIHMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private BFJCJFMHLPG BLIEJPIGDFE;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAB70", Offset = "0x3DF9570", VA = "0x183DFAB70", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAC00", Offset = "0x3DF9600", VA = "0x183DFAC00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x3DFACA0", Offset = "0x3DF96A0", VA = "0x183DFACA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA9E0", Offset = "0x3DF93E0", VA = "0x183DFA9E0")]
		private void JNPFJDFLBEC(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<HHDBLAHJIKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x3D21ED0", Offset = "0x3D208D0", VA = "0x183D21ED0", Slot = "14")]
		protected override void ONJFHEIBGKN(NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> LMODJFANELC, NativeArray<Entity> PDBLCGKFHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x3D21E00", Offset = "0x3D20800", VA = "0x183D21E00")]
		[BurstCompile]
		private static void ONJFHEIBGKN(NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> PDBLCGKFHHL, ComponentDataFromEntity<global::BIGDGMDEBOA> HDOPFLMGLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x3D22060", Offset = "0x3D20A60", VA = "0x183D22060")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x3D22020", Offset = "0x3D20A20", VA = "0x183D22020", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : HIEJFMJLCNL where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery JKCKFPLAOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery NDGKCNDGCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery PPHANKJDHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery LDDGABILEHG;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x46AEC10", Offset = "0x46AD610", VA = "0x1846AEC10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x46AEFE0", Offset = "0x46AD9E0", VA = "0x1846AEFE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x46AEFB0", Offset = "0x46AD9B0", VA = "0x1846AEFB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x46AD750", Offset = "0x46AC150", VA = "0x1846AD750")]
		private void DADECLLLHDJ(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x46AE820", Offset = "0x46AD220", VA = "0x1846AE820")]
		private void EFCMAFLCFBH(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x46ADB90", Offset = "0x46AC590", VA = "0x1846ADB90")]
		private void DHFAFCCIGNP(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void ONJFHEIBGKN(NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> LMODJFANELC, NativeArray<Entity> PDBLCGKFHHL);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x43E9DD0", Offset = "0x43E87D0", VA = "0x1843E9DD0")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x3166830", Offset = "0x3165230", VA = "0x183166830", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class EJLDIJBGLHN : HIEJFMJLCNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> HGICKBJDBHA;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x41B7C30", Offset = "0x41B6630", VA = "0x1841B7C30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x41B7E30", Offset = "0x41B6830", VA = "0x1841B7E30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x41B7F80", Offset = "0x41B6980", VA = "0x1841B7F80")]
	public EJLDIJBGLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct HLAAMNLHOFA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int EOGKCECFNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int GGPKANELEKJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C8A0", Offset = "0x1B4B2A0", VA = "0x181B4C8A0")]
	public static Entity EHMKDPHHPBI(HLAAMNLHOFA MNILNHMNKJK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C8A0", Offset = "0x1B4B2A0", VA = "0x181B4C8A0")]
	public static HLAAMNLHOFA EHMKDPHHPBI(Entity OOGAMDNOHNH)
	{
		return default(HLAAMNLHOFA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct OEAGOMFNIAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct AMABHDCNCJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType EPNDONNEBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> CPMFGOIFOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> MJKJNNFKAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> AJMHFNCBOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> BGLBEGPIAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> CPMGOPFMMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> DLGOBANMMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int CLHGMFAJODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int DEAOKFKCNBF;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool LGAMLFFACFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x3E77A70", Offset = "0x3E76470", VA = "0x183E77A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x3E77D10", Offset = "0x3E76710", VA = "0x183E77D10")]
	public AMABHDCNCJE(ComponentType EPNDONNEBFB, NativeList<int> CPMFGOIFOOJ, NativeList<int> MJKJNNFKAFP, NativeArray<Entity> AJMHFNCBOJK, NativeArray<Entity> BGLBEGPIAKL, NativeArray<byte> CPMGOPFMMHI, NativeArray<byte> DLGOBANMMLN, int CLHGMFAJODO, int DEAOKFKCNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x3E77AF0", Offset = "0x3E764F0", VA = "0x183E77AF0")]
	private ABKAKFBNEMO HJODIFJBBDL(NativeArray<byte> HPOICFFOIAP, int ALJOMNDNEBM)
	{
		return default(ABKAKFBNEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T HJODIFJBBDL<T>(NativeArray<byte> HPOICFFOIAP, int ALJOMNDNEBM) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x3E77A20", Offset = "0x3E76420", VA = "0x183E77A20")]
	public ABKAKFBNEMO GDOADMLAMOF(int ALJOMNDNEBM)
	{
		return default(ABKAKFBNEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T GDOADMLAMOF<T>(int ALJOMNDNEBM) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x3E778F0", Offset = "0x3E762F0", VA = "0x183E778F0")]
	public ABKAKFBNEMO AMMBNNFKPOP(int ALJOMNDNEBM)
	{
		return default(ABKAKFBNEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T AMMBNNFKPOP<T>(int ALJOMNDNEBM) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x3E77940", Offset = "0x3E76340", VA = "0x183E77940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct BNNAJMCLMKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<GBEJKPDFMEH> PILEKMCPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType EPNDONNEBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int CLHGMFAJODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int DEAOKFKCNBF;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DE80", Offset = "0x3E7C880", VA = "0x183E7DE80")]
	public BNNAJMCLMKJ(ComponentType EPNDONNEBFB, int CLHGMFAJODO, int DEAOKFKCNBF, EntityQuery IOEGIOMNPHI, NativeArray<GBEJKPDFMEH> PILEKMCPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DE30", Offset = "0x3E7C830", VA = "0x183E7DE30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct GPCCNKDGBGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int ALJOMNDNEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int COBEKOEEEPJ;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x9480E0", Offset = "0x946AE0", VA = "0x1809480E0")]
	public GPCCNKDGBGD(int ALJOMNDNEBM, int COBEKOEEEPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct GBEJKPDFMEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int FAOFKPMBKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int IMMPKDAEONJ;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x9480E0", Offset = "0x946AE0", VA = "0x1809480E0")]
	public GBEJKPDFMEH(int FAOFKPMBKFB, int IMMPKDAEONJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct IIALMMAFGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly KOPBFNLIDKA BEEBALICHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int CLHGMFAJODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* CPMGOPFMMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* DLGOBANMMLN;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool GGNGOEANAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x41CA5A0", Offset = "0x41C8FA0", VA = "0x1841CA5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public KOPBFNLIDKA LMACIDEDPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120")]
		get
		{
			return default(KOPBFNLIDKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x41CA5B0", Offset = "0x41C8FB0", VA = "0x1841CA5B0")]
	public ABKAKFBNEMO JALPJELOFKJ(Type EMKINACMDLO)
	{
		return default(ABKAKFBNEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x41CA6A0", Offset = "0x41C90A0", VA = "0x1841CA6A0")]
	public ABKAKFBNEMO JIOKMCMPLHO(Type EMKINACMDLO)
	{
		return default(ABKAKFBNEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x34617A0", Offset = "0x34601A0", VA = "0x1834617A0")]
	public T JALPJELOFKJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x34617C0", Offset = "0x34601C0", VA = "0x1834617C0")]
	public T JIOKMCMPLHO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x41CA790", Offset = "0x41C9190", VA = "0x1841CA790")]
	public unsafe IIALMMAFGKL(KOPBFNLIDKA BEEBALICHLA, int IMMPKDAEONJ, byte* CPMGOPFMMHI, byte* DLGOBANMMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class BEKHDMJBHHK : EKOAMPPHLGH, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService HPPMFDJJMOO;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract AMLOFAHKBFL NNFDCMPGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BB80", Offset = "0x3E7A580", VA = "0x183E7BB80", Slot = "17")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BBD0", Offset = "0x3E7A5D0", VA = "0x183E7BBD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B940", Offset = "0x3E7A340", VA = "0x183E7B940", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	protected BEKHDMJBHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class LHKAGIKAIBM
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] KBLHJLLANKJ;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class PELHPHDIANP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly NNLEPLPFODN DPMCBMJDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, BNNAJMCLMKJ> PJBNGPJFEAK;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public BNNAJMCLMKJ KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1D50", Offset = "0x3DF0750", VA = "0x183DF1D50")]
		get
		{
			return default(BNNAJMCLMKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1710", Offset = "0x3DF0110", VA = "0x183DF1710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1F90", Offset = "0x3DF0990", VA = "0x183DF1F90")]
	public PELHPHDIANP(BJJPOMIINDM HFELLKINAGM, NNLEPLPFODN DPMCBMJDHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1DE0", Offset = "0x3DF07E0", VA = "0x183DF1DE0")]
	public bool JBPBACKGAAO(ComponentType EPNDONNEBFB, out BNNAJMCLMKJ KJGCDDIEGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1F00", Offset = "0x3DF0900", VA = "0x183DF1F00")]
	public Dictionary<ComponentType, BNNAJMCLMKJ>.Enumerator ODEOKNNCFHI()
	{
		return default(Dictionary<ComponentType, BNNAJMCLMKJ>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1760", Offset = "0x3DF0160", VA = "0x183DF1760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x3DF18F0", Offset = "0x3DF02F0", VA = "0x183DF18F0")]
	private void ENHNDLAAFLF(IEnumerable<DPCOGLJGJDC> GBKMAKENLBI, EntityManager IMCLABBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1E50", Offset = "0x3DF0850", VA = "0x183DF1E50")]
	private static int JILCNCNGBCK(DPCOGLJGJDC IJLOFJODKBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF14C0", Offset = "0x3DEFEC0", VA = "0x183DF14C0")]
	private static NativeArray<GBEJKPDFMEH> BDNNDBDJKHN(DPCOGLJGJDC IJLOFJODKBL, Allocator APPJGCOGPBM = Allocator.Persistent)
	{
		return default(NativeArray<GBEJKPDFMEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface PGHENGEHMNP
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool LGAMLFFACFI
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World EAMNELNJNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJNMMFGNAAM(out NativeArray<int> DBFMPPECKDH, Allocator APPJGCOGPBM);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NOJLELCMOKH(ComponentType EPNDONNEBFB, out AMABHDCNCJE KFOKNGGHCED, out BNNAJMCLMKJ HFKBPOPIAIF);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NOJLELCMOKH(ComponentType EPNDONNEBFB, out AMABHDCNCJE KFOKNGGHCED);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AMABHDCNCJE PCNEJCHCANI(ComponentType EPNDONNEBFB);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NNCACHALMCM BAHLELFBEIC();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGHOPGOHDED(JobHandle CJDKHEEAEFK);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
internal interface MNOIPPEKGPC
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World EAMNELNJNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	PELHPHDIANP ODEOOMFLPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	NKFLGMBHNDD ICGDKLBLFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, IIALMMAFGKL> FFICNNCBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle PPBMCNHDHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LFPDFEJCFOP();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDOAHDCGLGB();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ANEGABIBDLJ(ComponentType EPNDONNEBFB, in AMABHDCNCJE NIEIJHJPDIP);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MKKIIIAFBMM(IMJFJJBFBGO FPPOGBDGFJM, out Entity INOMEBNKFPO);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct NNCACHALMCM
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct BAMHJEKBAHM : IEnumerator<IIALMMAFGKL>, IEnumerator, IDisposable, IEnumerable<IIALMMAFGKL>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, IIALMMAFGKL> IAGLEADCODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity OOGAMDNOHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> PKKKJILCGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IIALMMAFGKL DLGOBANMMLN;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public IIALMMAFGKL LEJKACPKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x921220", Offset = "0x91FC20", VA = "0x180921220", Slot = "4")]
			get
			{
				return default(IIALMMAFGKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x47BF220", Offset = "0x47BDC20", VA = "0x1847BF220", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x47BF270", Offset = "0x47BDC70", VA = "0x1847BF270")]
		internal BAMHJEKBAHM(NativeMultiHashMap<Entity, IIALMMAFGKL> IAGLEADCODA, Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x47BEFE0", Offset = "0x47BD9E0", VA = "0x1847BEFE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x47BF0B0", Offset = "0x47BDAB0", VA = "0x1847BF0B0")]
		public BAMHJEKBAHM ODEOKNNCFHI()
		{
			return default(BAMHJEKBAHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x47BF0E0", Offset = "0x47BDAE0", VA = "0x1847BF0E0", Slot = "9")]
		private IEnumerator<IIALMMAFGKL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x47BF180", Offset = "0x47BDB80", VA = "0x1847BF180", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly MNOIPPEKGPC GFHEAAHHEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle JOFNLFCCFIB;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int MLLNPBJNNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2F60", Offset = "0x3DE1960", VA = "0x183DE2F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool DBBBFNFEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2D10", Offset = "0x3DE1710", VA = "0x183DE2D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x29FF800", Offset = "0x29FE200", VA = "0x1829FF800")]
	public NNCACHALMCM(MNOIPPEKGPC GFHEAAHHEHC, JobHandle JOFNLFCCFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x3DE2AB0", Offset = "0x3DE14B0", VA = "0x183DE2AB0")]
	public bool ACLONAMPOCL(Allocator APPJGCOGPBM, out NativeKeyValueArrays<Entity, IIALMMAFGKL> MIMDGHHHHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x3DE2DF0", Offset = "0x3DE17F0", VA = "0x183DE2DF0")]
	public bool IOEKFILPFME(Allocator APPJGCOGPBM, out (NativeArray<Entity> entities, int uniqueCount) MIMDGHHHHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3DE2BF0", Offset = "0x3DE15F0", VA = "0x183DE2BF0")]
	public BAMHJEKBAHM CHFCBBIFHPN(Entity OOGAMDNOHNH)
	{
		return default(BAMHJEKBAHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class NKFLGMBHNDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly NNLEPLPFODN DPMCBMJDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<BNNAJMCLMKJ> ECNPNAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public BNNAJMCLMKJ KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0E60", Offset = "0x3DDF860", VA = "0x183DE0E60")]
		get
		{
			return default(BNNAJMCLMKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0970", Offset = "0x3DDF370", VA = "0x183DE0970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0F70", Offset = "0x3DDF970", VA = "0x183DE0F70")]
	public NKFLGMBHNDD(PELHPHDIANP PJBNGPJFEAK, BJJPOMIINDM HFELLKINAGM, NNLEPLPFODN DPMCBMJDHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0EF0", Offset = "0x3DDF8F0", VA = "0x183DE0EF0")]
	public List<BNNAJMCLMKJ>.Enumerator ODEOKNNCFHI()
	{
		return default(List<BNNAJMCLMKJ>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x3DE09B0", Offset = "0x3DDF3B0", VA = "0x183DE09B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0B30", Offset = "0x3DDF530", VA = "0x183DE0B30")]
	private void ENHNDLAAFLF(PELHPHDIANP PJBNGPJFEAK, EntityManager IMCLABBJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class CLHJLGPICBJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly NNLEPLPFODN DPMCBMJDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService DKNCGBIHPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::BPPLLIHONDM<DPCOGLJGJDC> NFBJAAEHOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World PEPBPKOJIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager IMCLABBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> GCPDIGECKNP;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E836D0", Offset = "0x3E820D0", VA = "0x183E836D0")]
	public CLHJLGPICBJ(ObjectInstantiationService DKNCGBIHPEI, BJJPOMIINDM HFELLKINAGM, NNLEPLPFODN DPMCBMJDHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E82630", Offset = "0x3E81030", VA = "0x183E82630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E83140", Offset = "0x3E81B40", VA = "0x183E83140")]
	public bool KOKGCAMDPIH(IMJFJJBFBGO FPPOGBDGFJM, out Entity INOMEBNKFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x3E81FD0", Offset = "0x3E809D0", VA = "0x183E81FD0")]
	private void CDIIKPAPIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x3E831A0", Offset = "0x3E81BA0", VA = "0x183E831A0")]
	private EntityArchetype MINABJMHJBH(EntityArchetype GLDJJGMGKML)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x3E828B0", Offset = "0x3E812B0", VA = "0x183E828B0")]
	public static void IIEAIBGALNC(EntityManager NIFGALLBNNK, EntityManager NKFNOKODGJB, NativeArray<Entity> OAMHHOPCFDF, NativeArray<EntityArchetype> HMNMLAKHOLM, [Optional] NativeArray<Entity> ALEJKJJHBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x3E81E60", Offset = "0x3E80860", VA = "0x183E81E60")]
	[Conditional("DEBUG_BUILD")]
	private static void BMPEEDPIOAI(NativeArray<EntityArchetype> FHFEGNAJEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x3E82F00", Offset = "0x3E81900", VA = "0x183E82F00")]
	private static string KJFLIDJFKCI(EntityArchetype FFCMEKBDBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x3E82DC0", Offset = "0x3E817C0", VA = "0x183E82DC0")]
	[CompilerGenerated]
	internal static void KICHPOJLDPJ(ref Span<ComponentType> LOIKEJJMJOH, ComponentType MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E82700", Offset = "0x3E81100", VA = "0x183E82700")]
	[CompilerGenerated]
	internal static void EFPFCOAEJBB(Span<ComponentType> HPOICFFOIAP, ref Span<ComponentType> LOIKEJJMJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E82CE0", Offset = "0x3E816E0", VA = "0x183E82CE0")]
	[CompilerGenerated]
	internal static void KDAONONMFLM(Span<ComponentType> HPOICFFOIAP, ref Span<ComponentType> LOIKEJJMJOH, ComponentType OFOOCJNMFKL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[KEFMDJAGLBH(IGKCNDFEDMC.PropertyChanges)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld LJOMELLOBCD;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E79350", Offset = "0x3E77D50", VA = "0x183E79350", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E79410", Offset = "0x3E77E10", VA = "0x183E79410", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[KEFMDJAGLBH(IGKCNDFEDMC.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : HIEJFMJLCNL, HNADMPPHDEF, BCGODABHHDD
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct IBDJCBCCPLD : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> LJNEGAPFKHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> BIDALOAFFKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<GBEJKPDFMEH> GGFKHOBKBJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<GPCCNKDGBGD>.ParallelWriter MLBACECEGKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int BCKENEBEHMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int EAEMMHICHAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker BEJIJANPHEK;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B410", Offset = "0x3D19E10", VA = "0x183D1B410", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B550", Offset = "0x3D19F50", VA = "0x183D1B550")]
			private unsafe int MMPENKEMFPA(byte* FADAICOCDHM, byte* DHGNJCDIFDM)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct BFDAMHDCDNP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> CPMFGOIFOOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> GBJGOHJAJNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<GPCCNKDGBGD> ALGDCDLMPIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker BEJIJANPHEK;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x3D1A930", Offset = "0x3D19330", VA = "0x183D1A930", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct JNJNPENPGLI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> OCJNKIIEIMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity HJHCAPCHMMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int CLHGMFAJODO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker BEJIJANPHEK;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x47C4ED0", Offset = "0x47C38D0", VA = "0x1847C4ED0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct MFJAKPHPFCF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, IIALMMAFGKL> CFDILLKJNMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> CPMGOPFMMHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> DLGOBANMMLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<GBEJKPDFMEH> JPBDMIOCFCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> MJKJNNFKAFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> CPMFGOIFOOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int KJMFKOLHJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int DEAOKFKCNBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker BEJIJANPHEK;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x47C8C30", Offset = "0x47C7630", VA = "0x1847C8C30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker OGDBFODLKMD;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker HMEJNCCOBNA;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker BPBLEEAOAHE;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker AILIEGAEEAM;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker CNGGHLOJPLA;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker IIMEPJEINGK;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker DCPBGLLHOKE;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker HOGDJBKJPPB;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker KPDCOJFNFEI;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker IOLEIHENLKO;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker IEEECKAJJKF;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker JAMJODMLBGI;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker BLFNAPINELD;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker AOFAJLGBLMC;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker ODJKNKOPCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService HPPMFDJJMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery FBACDKEKDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery OCNHBOBHAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery HPEFIHBEICE;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World EAMNELNJNBP
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x3E87780", Offset = "0x3E86180", VA = "0x183E87780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private MNOIPPEKGPC OHGHBJNJDJL
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x3E893C0", Offset = "0x3E87DC0", VA = "0x183E893C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E87BB0", Offset = "0x3E865B0", VA = "0x183E87BB0", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "15")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E890C0", Offset = "0x3E87AC0", VA = "0x183E890C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E89280", Offset = "0x3E87C80", VA = "0x183E89280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E89210", Offset = "0x3E87C10", VA = "0x183E89210", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E878F0", Offset = "0x3E862F0", VA = "0x183E878F0")]
		private void LPOEKOAEPCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E87760", Offset = "0x3E86160", VA = "0x183E87760")]
		internal void HAFBMLKFIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E86F90", Offset = "0x3E85990", VA = "0x183E86F90")]
		private void HAFBMLKFIDD(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E88E80", Offset = "0x3E87880", VA = "0x183E88E80")]
		private void OMAMGMCBKCJ(NativeArray<Entity> OAMHHOPCFDF, NativeArray<RRObjectPrefabData> CGDIKMOKGEH, ref NativeArray<Entity> KKNJMHDJFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E866F0", Offset = "0x3E850F0", VA = "0x183E866F0")]
		internal void CPKMBGPHMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E86710", Offset = "0x3E85110", VA = "0x183E86710")]
		private void CPKMBGPHMEE(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x3E88560", Offset = "0x3E86F60", VA = "0x183E88560")]
		internal void NIACKCCJCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E86200", Offset = "0x3E84C00", VA = "0x183E86200")]
		private void BGGJCGKGNFN(MNOIPPEKGPC GFHEAAHHEHC, BNNAJMCLMKJ HFKBPOPIAIF, bool GKLGFFABJHF, ref JobHandle KNCHBLINDJM, ref JobHandle AKIJPJCOHBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E87C00", Offset = "0x3E86600", VA = "0x183E87C00")]
		internal bool NDJGHKLANJC(in BNNAJMCLMKJ DHGNJCDIFDM, out JobHandle DFKGNJHDLAL, out AMABHDCNCJE BLLLEEJFJBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E87C30", Offset = "0x3E86630", VA = "0x183E87C30")]
		private bool NDJGHKLANJC(in BNNAJMCLMKJ DHGNJCDIFDM, bool GKLGFFABJHF, out JobHandle DFKGNJHDLAL, out AMABHDCNCJE BLLLEEJFJBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E88CC0", Offset = "0x3E876C0", VA = "0x183E88CC0")]
		internal (NativeList<int>, NativeList<int>) OGBFGIBPPLL(NativeList<GPCCNKDGBGD> ALGDCDLMPIH, int ICKPJJPJOOC, JobHandle GNKABAKGOAD, out JobHandle CJDKHEEAEFK, Allocator APPJGCOGPBM = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E87840", Offset = "0x3E86240", VA = "0x183E87840")]
		internal static NativeArray<Entity> KKFEHBMIPMD(EntityQuery IOEGIOMNPHI, out JobHandle PDFABJAPGCO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E86670", Offset = "0x3E85070", VA = "0x183E86670")]
		internal static NativeArray<byte> CCFAHIJKBPC(int AHIMNOMEIMA, out JobHandle OIIPKOIHKAJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E86E80", Offset = "0x3E85880", VA = "0x183E86E80")]
		internal static NativeArray<byte> GNMLEKNMPNK(EntityQuery IOEGIOMNPHI, int CKHJBBKEJPM, out JobHandle OIIPKOIHKAJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E86B10", Offset = "0x3E85510", VA = "0x183E86B10")]
		internal static NativeArray<Entity> DOKJNICAOFL(EntityQuery IOEGIOMNPHI, out JobHandle LMJMFADJKDB)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E86C10", Offset = "0x3E85610", VA = "0x183E86C10")]
		internal NativeArray<byte> GKMLDGMEEMH(NativeArray<Entity> AJMHFNCBOJK, BNNAJMCLMKJ HFKBPOPIAIF, JobHandle GNKABAKGOAD, out JobHandle CJDKHEEAEFK, Allocator APPJGCOGPBM = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E864E0", Offset = "0x3E84EE0", VA = "0x183E864E0")]
		internal JobHandle CBHKFIHMMJF(in AMABHDCNCJE MNILNHMNKJK, in BNNAJMCLMKJ HFKBPOPIAIF, NativeMultiHashMap<Entity, IIALMMAFGKL> CFDILLKJNMA, JobHandle GNKABAKGOAD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1B20550", Offset = "0x1B1EF50", VA = "0x181B20550")]
		private JobHandle PBONCLKGJHG(JobHandle EPJIPJJGNHP, JobHandle LCGBJEKCELG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1B20550", Offset = "0x1B1EF50", VA = "0x181B20550")]
		private JobHandle PBONCLKGJHG(JobHandle EPJIPJJGNHP, JobHandle LCGBJEKCELG, JobHandle JCIIKMMIDDH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[KEFMDJAGLBH(IGKCNDFEDMC.RenderEffects)]
	internal class PropagateHoverRootTag : JGMIFFIGEFH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct LMOHPILFNDP : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType HOLCOIGLHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB5B0", Offset = "0x3DF9FB0", VA = "0x183DFB5B0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType INJMBFPJOPD
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB580", Offset = "0x3DF9F80", VA = "0x183DFB580", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType KIGCLKPMBPH
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB5E0", Offset = "0x3DF9FE0", VA = "0x183DFB5E0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB610", Offset = "0x3DFA010", VA = "0x183DFB610")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[KEFMDJAGLBH(IGKCNDFEDMC.RenderEffects)]
	internal class PropagateSelectionRootTag : JGMIFFIGEFH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct HNJCOEFMKKE : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType HOLCOIGLHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB650", Offset = "0x3DFA050", VA = "0x183DFB650", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType INJMBFPJOPD
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB620", Offset = "0x3DFA020", VA = "0x183DFB620", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType KIGCLKPMBPH
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB680", Offset = "0x3DFA080", VA = "0x183DFB680", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB610", Offset = "0x3DFA010", VA = "0x183DFB610")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[PAOJICDMIEO]
public class KLBEHDILGKA : BFPKHLNEKPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x41D2620", Offset = "0x41D1020", VA = "0x1841D2620", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x41D26B0", Offset = "0x41D10B0", VA = "0x1841D26B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public KLBEHDILGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[PAOJICDMIEO]
public class HGJPFNHFHHP : BFPKHLNEKPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct PMIHMGKMNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public PMIHMGKMNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct PKKNCPJLDGM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct BFKFPOBCOHD
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct NIGAPEEPEBD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime NGKAPFIOANM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> EOFIEPGBIME;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x47BF730", Offset = "0x47BE130", VA = "0x1847BF730")]
			public void GOEDFNFGIMK(HGJPFNHFHHP PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x47BF6B0", Offset = "0x47BE0B0", VA = "0x1847BF6B0")]
			public NIGAPEEPEBD AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(NIGAPEEPEBD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager IMCLABBJAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> EPJCFGBAHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private BFKFPOBCOHD EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BFKFPOBCOHD.NIGAPEEPEBD* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IAMBMDHMNDC;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x47CB980", Offset = "0x47CA380", VA = "0x1847CB980")]
		internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, SplinePointParentData GHLCFEHGEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x47CBB10", Offset = "0x47CA510", VA = "0x1847CBB10", Slot = "5")]
		public void ReadFromDisplayClass(ref PMIHMGKMNPM BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x47CBB20", Offset = "0x47CA520", VA = "0x1847CBB20", Slot = "6")]
		public void WriteToDisplayClass(ref PMIHMGKMNPM BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x47CB850", Offset = "0x47CA250", VA = "0x1847CB850", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x47CBA60", Offset = "0x47CA460", VA = "0x1847CBA60")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref BFKFPOBCOHD.NIGAPEEPEBD MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x47CB8F0", Offset = "0x47CA2F0", VA = "0x1847CB8F0")]
		public void GOEDFNFGIMK(HGJPFNHFHHP PNPLHMJCODG, ref PMIHMGKMNPM BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x47CB9F0", Offset = "0x47CA3F0", VA = "0x1847CB9F0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery IFLEMNNLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker ECIFKNPMDAJ;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x41C58E0", Offset = "0x41C42E0", VA = "0x1841C58E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public HGJPFNHFHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x41C56B0", Offset = "0x41C40B0", VA = "0x1841C56B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x41C5550", Offset = "0x41C3F50", VA = "0x1841C5550")]
	public static EntityQuery LGCJJMNPBLG(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[PAOJICDMIEO]
public class GFELMHOKGMH : BFPKHLNEKPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery DGDANCIHGAP;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x41C3C20", Offset = "0x41C2620", VA = "0x1841C3C20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x41C3CB0", Offset = "0x41C26B0", VA = "0x1841C3CB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public GFELMHOKGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(KLBEHDILGKA))]
public class DGLFBDLGMLM : HIEJFMJLCNL
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F820", Offset = "0x3E8E220", VA = "0x183E8F820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public DGLFBDLGMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class LBAFBDOHKNG : BFPKHLNEKPC, HNADMPPHDEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct MDADLANFDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<ANIMKGBLAIA, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public MDADLANFDIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BDPJEKEGBKL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct CHMLFLGGMPK
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct KDEJDKOJINO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime MDADKCANKPB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> JKJFBMEFKCE;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x47C0070", Offset = "0x47BEA70", VA = "0x1847C0070")]
			public void GOEDFNFGIMK(LBAFBDOHKNG PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x47BFFF0", Offset = "0x47BE9F0", VA = "0x1847BFFF0")]
			public KDEJDKOJINO AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(KDEJDKOJINO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<ANIMKGBLAIA, Entity> IAGLEADCODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private CHMLFLGGMPK EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CHMLFLGGMPK.KDEJDKOJINO* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x47BF510", Offset = "0x47BDF10", VA = "0x1847BF510")]
		internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, ObjectNetworkIdComponentData PGKDFMKPODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xCE0800", Offset = "0xCDF200", VA = "0x180CE0800", Slot = "5")]
		public void ReadFromDisplayClass(ref MDADLANFDIC BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x3347E30", Offset = "0x3346830", VA = "0x183347E30", Slot = "6")]
		public void WriteToDisplayClass(ref MDADLANFDIC BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x47BF3E0", Offset = "0x47BDDE0", VA = "0x1847BF3E0", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x47BF600", Offset = "0x47BE000", VA = "0x1847BF600")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, ref CHMLFLGGMPK.KDEJDKOJINO MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x47BF480", Offset = "0x47BDE80", VA = "0x1847BF480")]
		public void GOEDFNFGIMK(LBAFBDOHKNG PNPLHMJCODG, ref MDADLANFDIC BBMIICOMDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x47BF590", Offset = "0x47BDF90", VA = "0x1847BF590")]
		public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService ALLIEBFHEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery IFLEMNNLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker ECIFKNPMDAJ;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x41D5490", Offset = "0x41D3E90", VA = "0x1841D5490", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x41D56F0", Offset = "0x41D40F0", VA = "0x1841D56F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public LBAFBDOHKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x41D54F0", Offset = "0x41D3EF0", VA = "0x1841D54F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x41D5330", Offset = "0x41D3D30", VA = "0x1841D5330")]
	public static EntityQuery LGCJJMNPBLG(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class BDHOGMLDMKH : BFPKHLNEKPC, HNADMPPHDEF
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct AMNHGCHBEIJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct BBDDHMPIPIB
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct BEPIAFLPLLH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime EKGLKEIKJAJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> PGKDFEEEHPI;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x47BF310", Offset = "0x47BDD10", VA = "0x1847BF310")]
			public void GOEDFNFGIMK(BDHOGMLDMKH PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x47BF290", Offset = "0x47BDC90", VA = "0x1847BF290")]
			public BEPIAFLPLLH AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
			{
				return default(BEPIAFLPLLH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public BDHOGMLDMKH BEIBJIHNLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private BBDDHMPIPIB EOMBGLIAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BBDDHMPIPIB.BEPIAFLPLLH* GEPGJELPJPI;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A7F0", Offset = "0x3D191F0", VA = "0x183D1A7F0")]
		public void HMFDLPJJJOE(Entity OOGAMDNOHNH, ParentData MNDAHIBFADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A740", Offset = "0x3D19140", VA = "0x183D1A740", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A880", Offset = "0x3D19280", VA = "0x183D1A880")]
		public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, ref BBDDHMPIPIB.BEPIAFLPLLH MCBIPMIEJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A7B0", Offset = "0x3D191B0", VA = "0x183D1A7B0")]
		public void GOEDFNFGIMK(BDHOGMLDMKH PNPLHMJCODG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A810", Offset = "0x3D19210", VA = "0x183D1A810")]
		public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery IFLEMNNLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker ECIFKNPMDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B3D0", Offset = "0x3E79DD0", VA = "0x183E7B3D0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B630", Offset = "0x3E7A030", VA = "0x183E7B630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public BDHOGMLDMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B080", Offset = "0x3E79A80", VA = "0x183E7B080")]
	[CompilerGenerated]
	private void FKKDAIGMFEK(Entity OOGAMDNOHNH, ParentData MNDAHIBFADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B430", Offset = "0x3E79E30", VA = "0x183E7B430", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B270", Offset = "0x3E79C70", VA = "0x183E7B270")]
	public static EntityQuery LGCJJMNPBLG(ComponentSystemBase PNPLHMJCODG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class LNOKDLCMMDG : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int MEJGMMDCAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery IOEGIOMNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs DKNCGBIHPEI;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDBA0", Offset = "0x3DDC5A0", VA = "0x183DDDBA0", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDF90", Offset = "0x3DDC990", VA = "0x183DDDF90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE070", Offset = "0x3DDCA70", VA = "0x183DDE070", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDBF0", Offset = "0x3DDC5F0", VA = "0x183DDDBF0")]
	private void OACCGPKCPLP(Entity OOGAMDNOHNH, IMJFJJBFBGO FPPOGBDGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public LNOKDLCMMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	[UpdateBefore(typeof(LNOKDLCMMDG))]
	public class PostLoadAddSceneTagEntity : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService KIMBBFMGFGO;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF95F0", Offset = "0x3DF7FF0", VA = "0x183DF95F0", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9640", Offset = "0x3DF8040", VA = "0x183DF9640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[KLEAGPOIIPF(PFPBFPDNLIO.OMRoom)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	public class PostLoadInitializeNetworkId : HIEJFMJLCNL, HNADMPPHDEF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct NHOGIELAPJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<ANIMKGBLAIA, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
			public NHOGIELAPJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct HIFFIGNHBPL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct LGMLKAHPGMH
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct GPHEOCKCLKE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime CHCMGPFOPCA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime MDADKCANKPB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex GHEHCDPAAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> JKJFBMEFKCE;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x47C6BA0", Offset = "0x47C55A0", VA = "0x1847C6BA0")]
				public void GOEDFNFGIMK(PostLoadInitializeNetworkId PNPLHMJCODG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x47C6AF0", Offset = "0x47C54F0", VA = "0x1847C6AF0")]
				public GPHEOCKCLKE AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
				{
					return default(GPHEOCKCLKE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<ANIMKGBLAIA, Entity> IAGLEADCODA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private LGMLKAHPGMH EOMBGLIAFHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LGMLKAHPGMH.GPHEOCKCLKE* GEPGJELPJPI;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IAMBMDHMNDC;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x47C36F0", Offset = "0x47C20F0", VA = "0x1847C36F0")]
			internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, int MLCDBDIBMJF, ref ObjectNetworkIdComponentData PGKDFMKPODP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xCE0800", Offset = "0xCDF200", VA = "0x180CE0800", Slot = "5")]
			public void ReadFromDisplayClass(ref NHOGIELAPJI BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x3347E30", Offset = "0x3346830", VA = "0x183347E30", Slot = "6")]
			public void WriteToDisplayClass(ref NHOGIELAPJI BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x47C3560", Offset = "0x47C1F60", VA = "0x1847C3560", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x47C37F0", Offset = "0x47C21F0", VA = "0x1847C37F0")]
			public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref LGMLKAHPGMH.GPHEOCKCLKE MCBIPMIEJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x47C3650", Offset = "0x47C2050", VA = "0x1847C3650")]
			public void GOEDFNFGIMK(PostLoadInitializeNetworkId PNPLHMJCODG, ref NHOGIELAPJI BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x47C3780", Offset = "0x47C2180", VA = "0x1847C3780")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[JLCJNHHCBDK]
		private ObjectNetworkToLocalMapService ALLIEBFHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[JLCJNHHCBDK]
		private SceneService NJADCKCLHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery IOEGIOMNPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery AMIDMPDIKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker CJEPDHKKGPH;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9E70", Offset = "0x3DF8870", VA = "0x183DF9E70", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA570", Offset = "0x3DF8F70", VA = "0x183DFA570", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9DA0", Offset = "0x3DF87A0", VA = "0x183DF9DA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9DA0", Offset = "0x3DF87A0", VA = "0x183DF9DA0")]
		public void DKPIBACIMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9850", Offset = "0x3DF8250", VA = "0x183DF9850")]
		private void AONLPPCNBBF(NativeHashMap<ANIMKGBLAIA, Entity> IAGLEADCODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA080", Offset = "0x3DF8A80", VA = "0x183DFA080")]
		private void NPMCJHGKJNG(NativeHashMap<ANIMKGBLAIA, Entity> IAGLEADCODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA2E0", Offset = "0x3DF8CE0", VA = "0x183DFA2E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9EE0", Offset = "0x3DF88E0", VA = "0x183DF9EE0")]
		public static EntityQuery MKAIJNJJHFI(ComponentSystemBase PNPLHMJCODG)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class BEBDNBEALIM : HIEJFMJLCNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery HDDJJLOFPCD;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B740", Offset = "0x3E7A140", VA = "0x183E7B740", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B7D0", Offset = "0x3E7A1D0", VA = "0x183E7B7D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public BEBDNBEALIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class PPNOIGBAPCB : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::BPPLLIHONDM<LAAHJLIKAHN> GGCBFMAGFHB;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5650", Offset = "0x3DF4050", VA = "0x183DF5650", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x3DF57C0", Offset = "0x3DF41C0", VA = "0x183DF57C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5380", Offset = "0x3DF3D80", VA = "0x183DF5380")]
	private void JEOGJFKBALO(NativeList<EntityArchetype> FHFEGNAJEIJ, NativeHashMap<int, LEKKGHCNCEK> ELOFBGOGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5510", Offset = "0x3DF3F10", VA = "0x183DF5510")]
	private Span<int> MEKCEHJOIKG(EntityArchetype FFCMEKBDBJH)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF56F0", Offset = "0x3DF40F0", VA = "0x183DF56F0")]
	private bool MPEKMHCIEDO(int CKHJBBKEJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4D80", Offset = "0x3DF3780", VA = "0x183DF4D80")]
	private void GMHKHPEHPIB(NativeHashMap<int, LEKKGHCNCEK> ELOFBGOGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public PPNOIGBAPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Serialization)]
	public class PreSerializeRemoveEntities : HIEJFMJLCNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery INLHGLIKJGA;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA660", Offset = "0x3DF9060", VA = "0x183DFA660", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA8E0", Offset = "0x3DF92E0", VA = "0x183DFA8E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[KEFMDJAGLBH(IGKCNDFEDMC.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : HIEJFMJLCNL, HNADMPPHDEF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct LPGEKIHEGAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public ComponentDataFromEntity dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
			public LPGEKIHEGAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x3D1B400", Offset = "0x3D19E00", VA = "0x183D1B400")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct EDPJALKDMPI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> CPMFGOIFOOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> BGLBEGPIAKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity LLMDKEMLKMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> DLGOBANMMLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int CLHGMFAJODO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType EPNDONNEBFB;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x47C1B80", Offset = "0x47C0580", VA = "0x1847C1B80")]
			internal void HMFDLPJJJOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x47C1D40", Offset = "0x47C0740", VA = "0x1847C1D40", Slot = "5")]
			public void ReadFromDisplayClass(ref LPGEKIHEGAB BBMIICOMDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x47C1B50", Offset = "0x47C0550", VA = "0x1847C1B50", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x47C1B60", Offset = "0x47C0560", VA = "0x1847C1B60")]
			public void GOEDFNFGIMK(ShadowWorldApplyPropertyDifferencesToShadowWorld PNPLHMJCODG, ref LPGEKIHEGAB BBMIICOMDHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService HPPMFDJJMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle KAKCMNIAMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle PPINIBOMDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private PGHENGEHMNP GFHEAAHHEHC;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x3D27FA0", Offset = "0x3D269A0", VA = "0x183D27FA0", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x3D27C50", Offset = "0x3D26650", VA = "0x183D27C50")]
		public JobHandle CGNAHECDKKB(JobHandle GNKABAKGOAD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x3D28000", Offset = "0x3D26A00", VA = "0x183D28000", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x3D27C90", Offset = "0x3D26690", VA = "0x183D27C90")]
		private bool JKLHHHPDILI(JobHandle GNKABAKGOAD, int CKHJBBKEJPM, out JobHandle KCNAHCNIAMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[IGKLDKDLNIM]
[ExecuteAlways]
[UpdateInGroup(typeof(NHHNNEJLIGC))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class CHPAIOAFBGH : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x3E81CA0", Offset = "0x3E806A0", VA = "0x183E81CA0", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public CHPAIOAFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[IGKLDKDLNIM]
[ExecuteAlways]
[UpdateInGroup(typeof(PNHBMAAPKAJ))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class CHEIBNGEHEC : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x3E81920", Offset = "0x3E80320", VA = "0x183E81920", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public CHEIBNGEHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[IGKLDKDLNIM]
[ExecuteAlways]
[UpdateInGroup(typeof(IKHJBFCIMDC))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class MKEJDPCFAAO : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFF90", Offset = "0x3DDE990", VA = "0x183DDFF90", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public MKEJDPCFAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[IGKLDKDLNIM]
[ExecuteAlways]
[UpdateInGroup(typeof(KGMJDNHONFF))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class DHEIAMOLICF : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F930", Offset = "0x3E8E330", VA = "0x183E8F930", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public DHEIAMOLICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class PFJGGAOLMDE : BEKHDMJBHHK
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override AMLOFAHKBFL NNFDCMPGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x7373E0", Offset = "0x735DE0", VA = "0x1807373E0", Slot = "18")]
		get
		{
			return default(AMLOFAHKBFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF20A0", Offset = "0x3DF0AA0", VA = "0x183DF20A0")]
	public PFJGGAOLMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[IGKLDKDLNIM]
[ExecuteAlways]
[UpdateInGroup(typeof(EPJHNENDAPM))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class IHECPPNKGGH : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x41C9D80", Offset = "0x41C8780", VA = "0x1841C9D80", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public IHECPPNKGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class FAAFDBNIAEM : CHOEGOEDAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public FAAFDBNIAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class DFLMGGOHMNO : BEKHDMJBHHK
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override AMLOFAHKBFL NNFDCMPGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "18")]
		get
		{
			return default(AMLOFAHKBFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public DFLMGGOHMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[IGKLDKDLNIM]
[ExecuteAlways]
[UpdateInGroup(typeof(GKMGABENHON))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class PAPKFNLDHBO : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF04D0", Offset = "0x3DEEED0", VA = "0x183DF04D0", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public PAPKFNLDHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class OCJIOCADOOB : CHOEGOEDAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public OCJIOCADOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class OIJAOMEKBPE : CHOEGOEDAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public OIJAOMEKBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class OFIPOPDANKL : HIEJFMJLCNL
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public OFIPOPDANKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[PAOJICDMIEO]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
public class KLGDHICFHAA : HIEJFMJLCNL, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService APNACMJJDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x41D2D40", Offset = "0x41D1740", VA = "0x1841D2D40", Slot = "14")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x41D2D90", Offset = "0x41D1790", VA = "0x1841D2D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public KLGDHICFHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct HBCJKENPOMC : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float BHKEIEEGLKD = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> MGBACOMANEF;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x47C2F90", Offset = "0x47C1990", VA = "0x1847C2F90", Slot = "4")]
			public void Execute(int ALJOMNDNEBM, TransformAccess DBMMOFPNJHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x47C31C0", Offset = "0x47C1BC0", VA = "0x1847C31C0")]
			private bool KHAFIMHJAFG(float3 JOOHHAMJDLM, float3 GFPNEMALIHE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x47C3150", Offset = "0x47C1B50", VA = "0x1847C3150")]
			private bool FBPLAKLPOGA(quaternion JOOHHAMJDLM, quaternion GFPNEMALIHE)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct KIOCBINKEHG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> OPCJDJPAJNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> CACAHCGJHFF;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x47C55A0", Offset = "0x47C3FA0", VA = "0x1847C55A0", Slot = "4")]
			public void Execute(int ALJOMNDNEBM, TransformAccess DBMMOFPNJHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly NNLEPLPFODN IOMHLLGHLKP;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly NNLEPLPFODN JCBIIANEGBP;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly NNLEPLPFODN IJFFDGKKGCI;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker GDADHFCBJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private KICBBFNOGMD LEGPOJHBOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C590", Offset = "0x3E8AF90", VA = "0x183E8C590", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C600", Offset = "0x3E8B000", VA = "0x183E8C600", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C630", Offset = "0x3E8B030", VA = "0x183E8C630", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[KEFMDJAGLBH(IGKCNDFEDMC.TransformSyncing)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public class RegisterTransforms : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct AAPJAGNDLII : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct OBLHANBJMJK
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct PHPFCCLADPM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<OMPEAOLGBFG>.Runtime BIIKGPFHNMG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime BCLPDJADDFP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<OMPEAOLGBFG> CIEOKDMIJJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> KCOCBHHFFEB;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x47CA070", Offset = "0x47C8A70", VA = "0x1847CA070")]
				public void GOEDFNFGIMK(RegisterTransforms PNPLHMJCODG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x47C9FB0", Offset = "0x47C89B0", VA = "0x1847C9FB0")]
				public PHPFCCLADPM AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
				{
					return default(PHPFCCLADPM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private OBLHANBJMJK EOMBGLIAFHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe OBLHANBJMJK.PHPFCCLADPM* GEPGJELPJPI;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JEPNDADDKBM;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x47BE150", Offset = "0x47BCB50", VA = "0x1847BE150")]
			internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, OMPEAOLGBFG IEPKLEKMEFP, Transform DBMMOFPNJHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x47BE050", Offset = "0x47BCA50", VA = "0x1847BE050", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x47BE2C0", Offset = "0x47BCCC0", VA = "0x1847BE2C0")]
			public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, ref OBLHANBJMJK.PHPFCCLADPM MCBIPMIEJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x47BE140", Offset = "0x47BCB40", VA = "0x1847BE140")]
			public void GOEDFNFGIMK(RegisterTransforms PNPLHMJCODG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x47BE250", Offset = "0x47BCC50", VA = "0x1847BE250")]
			public unsafe static void OCDHLMDBKPH(ArchetypeChunkIterator* KFAMNDDEKEM, void* HIPAEHEAMJE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct KMBGDOPHPBK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct HPADPIBMEME
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct FCLLIPCEIHD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime LIGDJDILEOL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<OMPEAOLGBFG>.Runtime BIIKGPFHNMG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity FBNEHJLOJCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<OMPEAOLGBFG> CIEOKDMIJJB;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x47C3F00", Offset = "0x47C2900", VA = "0x1847C3F00")]
				public void GOEDFNFGIMK(RegisterTransforms PNPLHMJCODG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x47C3E80", Offset = "0x47C2880", VA = "0x1847C3E80")]
				public FCLLIPCEIHD AACNHINGMMD(ref ArchetypeChunk OGMIFCJDOJM, int LGKICKDKIKO, int NOMCAIFGKNP)
				{
					return default(FCLLIPCEIHD);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private HPADPIBMEME EOMBGLIAFHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HPADPIBMEME.FCLLIPCEIHD* GEPGJELPJPI;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x47C5850", Offset = "0x47C4250", VA = "0x1847C5850")]
			internal void HMFDLPJJJOE(Entity OOGAMDNOHNH, OMPEAOLGBFG IEPKLEKMEFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x47C57C0", Offset = "0x47C41C0", VA = "0x1847C57C0", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int KDLJIOFICIF, int DBHFEAJHHAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x47C5930", Offset = "0x47C4330", VA = "0x1847C5930")]
			public void ODEAHNOKPKJ(ref ArchetypeChunk PIKNKOLCJFP, [NoAlias] ref HPADPIBMEME.FCLLIPCEIHD MCBIPMIEJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x47C3F00", Offset = "0x47C2900", VA = "0x1847C3F00")]
			public void GOEDFNFGIMK(RegisterTransforms PNPLHMJCODG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private KICBBFNOGMD LEGPOJHBOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery IOBHAAKKJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery APHLNNKALKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery EPGKBICHEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery OOAAOJGDBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery NEPJDOJADPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker LNMNJPGIJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery ALINAJBFBHO;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x3D21810", Offset = "0x3D20210", VA = "0x183D21810", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x3D21AD0", Offset = "0x3D204D0", VA = "0x183D21AD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x3D21CE0", Offset = "0x3D206E0", VA = "0x183D21CE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x3D215D0", Offset = "0x3D1FFD0", VA = "0x183D215D0")]
		private void MIHBKOFFJLP(EntityQuery IOEGIOMNPHI, OIAINGCNGGF IKMEDOMHCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x3D20FE0", Offset = "0x3D1F9E0", VA = "0x183D20FE0")]
		private void FLEPFLKDNPO(EntityQuery IOEGIOMNPHI, OIAINGCNGGF IKMEDOMHCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x3D21C80", Offset = "0x3D20680", VA = "0x183D21C80", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x3D20CD0", Offset = "0x3D1F6D0", VA = "0x183D20CD0")]
		private void BBFLICICEAH(NativeArray<Entity> AJMHFNCBOJK, OIAINGCNGGF IKMEDOMHCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x3D209C0", Offset = "0x3D1F3C0", VA = "0x183D209C0")]
		[BurstCompile]
		internal static void AMPKGDAKJHE(NativeArray<OMPEAOLGBFG> EFLKAJHKHFN, ComponentDataFromEntity<OMPEAOLGBFG> ODKPHAGLEHO, OIAINGCNGGF IKMEDOMHCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private static void JAEPJKGLALI(Transform DBMMOFPNJHL, Entity OOGAMDNOHNH, int ALJOMNDNEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private static void JFEEDMAHNMC(Entity OOGAMDNOHNH, int ALJOMNDNEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private static void BENMJNPNMJA(int ALJOMNDNEBM, OIAINGCNGGF IKMEDOMHCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x3D21250", Offset = "0x3D1FC50", VA = "0x183D21250")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void GDLLEBFJPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x3D21860", Offset = "0x3D20260", VA = "0x183D21860", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x3D21430", Offset = "0x3D1FE30", VA = "0x183D21430")]
		public static EntityQuery KPJAENKGBHH(ComponentSystemBase PNPLHMJCODG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x3D20E10", Offset = "0x3D1F810", VA = "0x183D20E10")]
		public static EntityQuery EBKNPJHDAGO(ComponentSystemBase PNPLHMJCODG)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	[KEFMDJAGLBH(IGKCNDFEDMC.TransformSyncing)]
	public class CopyTransformDataToGameObjects : HIEJFMJLCNL, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct GAGMGJNIGMN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> MGBACOMANEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x47C2C30", Offset = "0x47C1630", VA = "0x1847C2C30", Slot = "4")]
			public void Execute(int ALJOMNDNEBM, TransformAccess DBMMOFPNJHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct LJNIKCMADBP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OPCJDJPAJNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x47C7210", Offset = "0x47C5C10", VA = "0x1847C7210", Slot = "4")]
			public void Execute(int ALJOMNDNEBM, TransformAccess DBMMOFPNJHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct GMJMDCFMGMF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OPCJDJPAJNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> CACAHCGJHFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> AJMHFNCBOJK;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x47C2E90", Offset = "0x47C1890", VA = "0x1847C2E90", Slot = "4")]
			public void Execute(int ALJOMNDNEBM, TransformAccess DBMMOFPNJHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly NNLEPLPFODN IOMHLLGHLKP;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly NNLEPLPFODN JCBIIANEGBP;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly NNLEPLPFODN IJFFDGKKGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private KICBBFNOGMD LEGPOJHBOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery CCKBNGLKPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery NPKPHHELDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery BAGDJEHHIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray CEFFBLKOHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray KJDHBLMMKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray HOEHNALAGNK;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CC60", Offset = "0x3E8B660", VA = "0x183E8CC60", Slot = "14")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CCB0", Offset = "0x3E8B6B0", VA = "0x183E8CCB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CEA0", Offset = "0x3E8B8A0", VA = "0x183E8CEA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CF30", Offset = "0x3E8B930", VA = "0x183E8CF30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CF60", Offset = "0x3E8B960", VA = "0x183E8CF60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CAE0", Offset = "0x3E8B4E0", VA = "0x183E8CAE0")]
		private NativeArray<Entity> FGKGLCLNKDL(NativeArray<OMPEAOLGBFG> CPMFGOIFOOJ, NativeList<Entity> OAMHHOPCFDF, TransformAccessArray BBDFGCAMHFN, TransformAccessArray EBALNIKBOKL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[KEFMDJAGLBH(IGKCNDFEDMC.TransformSyncing)]
	[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
	public class CopyTransformParentsToGameObjects : HIEJFMJLCNL, BCGODABHHDD
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private JJAKPFHGEID KBBOPDEEDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private ADANANCGCCD ACPBNDAJKOM;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x3DFACA0", Offset = "0x3DF96A0", VA = "0x183DFACA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x3E8DAB0", Offset = "0x3E8C4B0", VA = "0x183E8DAB0", Slot = "14")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x3E8DBC0", Offset = "0x3E8C5C0", VA = "0x183E8DBC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D890", Offset = "0x3E8C290", VA = "0x183E8D890")]
		private static void DALEIFKIIJJ(EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, Entity EOBFGLJBCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x3E8DA10", Offset = "0x3E8C410", VA = "0x183E8DA10")]
		private static bool DDBBPDDJDDO(EntityManager IMCLABBJAOB, Entity OOGAMDNOHNH, out Transform DBMMOFPNJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[KEFMDJAGLBH(IGKCNDFEDMC.TransformSyncing)]
	public class L2PToL2WHierarchy : HIEJFMJLCNL
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct AOCJMGPCGII : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> KKCINCFAIBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> BJKFCKKHNHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> KLGJMCLIDHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> DAOJLDELPFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> IPADBJJHFEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> KFCFDFLGEHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint CMHGACECNIK;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x47BE820", Offset = "0x47BD220", VA = "0x1847BE820")]
			[Conditional("DEBUG_BUILD")]
			private void ACCMBBDECCP(Entity OOGAMDNOHNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x47BE8F0", Offset = "0x47BD2F0", VA = "0x1847BE8F0", Slot = "4")]
			public void Execute(ArchetypeChunk PIKNKOLCJFP, int ALJOMNDNEBM, int FHEGGBGFJDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x47BEBE0", Offset = "0x47BD5E0", VA = "0x1847BEBE0")]
			private void MKIGBKMFFEB(float4x4 BBJKNFFBFOF, Entity OOGAMDNOHNH, bool EPNGIIAOGBM, int DJANDDPCBEN = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery PNCCCLNKDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery OJMAILPFBEA;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x41D3CA0", Offset = "0x41D26A0", VA = "0x1841D3CA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x41D3DC0", Offset = "0x41D27C0", VA = "0x1841D3DC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class JJCELJGKJDN : LBCEAGCCIOE
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct PHKLCFDFDKK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> KKCINCFAIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> IPADBJJHFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint CMHGACECNIK;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x47CB6D0", Offset = "0x47CA0D0", VA = "0x1847CB6D0", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int ALJOMNDNEBM, int FHEGGBGFJDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x47CB7D0", Offset = "0x47CA1D0", VA = "0x1847CB7D0")]
		public bool PPANOBOMAMB(ArchetypeChunk PIKNKOLCJFP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery PNCCCLNKDLK;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x41D0280", Offset = "0x41CEC80", VA = "0x1841D0280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x41D03B0", Offset = "0x41CEDB0", VA = "0x1841D03B0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle EEDDHODDKGF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public JJCELJGKJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class EJOEBNNLFEK : LBCEAGCCIOE
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct CJAHLAIAIMH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> JJMGELLCAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> PGMABOBEKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> JBPBDJLFCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> ADAHNABKINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint CMHGACECNIK;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x47C0560", Offset = "0x47BEF60", VA = "0x1847C0560", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int ALJOMNDNEBM, int FHEGGBGFJDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x47C0910", Offset = "0x47BF310", VA = "0x1847C0910")]
		public bool PPANOBOMAMB(ArchetypeChunk PIKNKOLCJFP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery FBHAGLEGMDE;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x41B8000", Offset = "0x41B6A00", VA = "0x1841B8000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x41B8110", Offset = "0x41B6B10", VA = "0x1841B8110", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle EEDDHODDKGF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public EJOEBNNLFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class BIPHJJNMIIG : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct LDFFBMKIMKG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> EEBNLNAPPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> LCNOIHCMIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> CDBOGIKJLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> OPDENMPFJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint CMHGACECNIK;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BA00", Offset = "0x3D1A400", VA = "0x183D1BA00", Slot = "4")]
		public void Execute(ArchetypeChunk PIKNKOLCJFP, int ALJOMNDNEBM, int FHEGGBGFJDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C110", Offset = "0x3D1AB10", VA = "0x183D1C110")]
		public bool PPANOBOMAMB(ArchetypeChunk PIKNKOLCJFP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery FBHAGLEGMDE;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BE10", Offset = "0x3E7A810", VA = "0x183E7BE10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BF40", Offset = "0x3E7A940", VA = "0x183E7BF40", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle EEDDHODDKGF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0")]
	public BIPHJJNMIIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[KEFMDJAGLBH(IGKCNDFEDMC.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : JGMIFFIGEFH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct AKEOENODOGM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType HOLCOIGLHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB6E0", Offset = "0x3DFA0E0", VA = "0x183DFB6E0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType INJMBFPJOPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB6B0", Offset = "0x3DFA0B0", VA = "0x183DFB6B0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType KIGCLKPMBPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x3DFB710", Offset = "0x3DFA110", VA = "0x183DFB710", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB610", Offset = "0x3DFA010", VA = "0x183DFB610")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C0", Offset = "0x7FCBC0", VA = "0x1807FE1C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[MMLKNPGAEIO(ECHGPOCMBHL.Game)]
public class JEOMIEMBAIE : IIFKKHPGHMD
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type MMNCNAGHADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x41CC260", Offset = "0x41CAC60", VA = "0x1841CC260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] AIOCAPAAKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x41CC2D0", Offset = "0x41CACD0", VA = "0x1841CC2D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public JEOMIEMBAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[MMLKNPGAEIO(ECHGPOCMBHL.Loading)]
public class JDBFLKIAPDE : IIFKKHPGHMD
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type MMNCNAGHADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] AIOCAPAAKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x41CC170", Offset = "0x41CAB70", VA = "0x1841CC170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public JDBFLKIAPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class DDFJCFCPAGO : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F3B0", Offset = "0x3E8DDB0", VA = "0x183E8F3B0", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public DDFJCFCPAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[MMLKNPGAEIO(ECHGPOCMBHL.Saving)]
public class EBAKHOIDICM : IIFKKHPGHMD
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type MMNCNAGHADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] AIOCAPAAKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x3E927B0", Offset = "0x3E911B0", VA = "0x183E927B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EBAKHOIDICM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class MNDMFEEHOGO : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x3DE00E0", Offset = "0x3DDEAE0", VA = "0x183DE00E0", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public MNDMFEEHOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[MMLKNPGAEIO(ECHGPOCMBHL.Simulation)]
public class PIDLJJMBKAG : IIFKKHPGHMD
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type MMNCNAGHADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x3DF32A0", Offset = "0x3DF1CA0", VA = "0x183DF32A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] AIOCAPAAKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3310", Offset = "0x3DF1D10", VA = "0x183DF3310", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public PIDLJJMBKAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[LHOECCIDBFM(typeof(LGCKPFILJME), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
internal class LGCKPFILJME : BCGODABHHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::AIENCKMNNKI<AuthoredParentData, LEOKMENFMEB, ADOKHJAGFFP, AuthoredChildrenData> MDCHEJANFJI;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC970", Offset = "0x3DDB370", VA = "0x183DDC970", Slot = "4")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public LGCKPFILJME()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(EntityHierarchyParents), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.HierarchySystems)]
	internal sealed class EntityHierarchyParents : HNADMPPHDEF, BCGODABHHDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[JLCJNHHCBDK]
		private FADNPGGGOHC FBHAGLEGMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[JLCJNHHCBDK]
		private PropertyChangeNetworkRouter MHKGFCIMMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::HBNHJLIDJBP<Entity> EELLPGLCOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::AIENCKMNNKI<ParentData, KAJDMPKAIDI, LDOOCHBFJCP, ChildrenData> MDCHEJANFJI;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x41BF7A0", Offset = "0x41BE1A0", VA = "0x1841BF7A0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x41BF6A0", Offset = "0x41BE0A0", VA = "0x1841BF6A0", Slot = "5")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x41BF470", Offset = "0x41BDE70", VA = "0x1841BF470")]
		public Entity EOCIMCBAGPH(Entity OOGAMDNOHNH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x41BF370", Offset = "0x41BDD70", VA = "0x1841BF370")]
		public bool CGJOPAHPCKK(Entity OOGAMDNOHNH, Entity KLJNAJJPMKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x41BF3D0", Offset = "0x41BDDD0", VA = "0x1841BF3D0")]
		public bool CLOBJFNMHGM(Entity OOGAMDNOHNH, Entity KLJNAJJPMKN, bool ANNPIPIEPOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x41BF4C0", Offset = "0x41BDEC0", VA = "0x1841BF4C0")]
		private bool HAMBEPPKOEC(Entity OOGAMDNOHNH, Entity KLJNAJJPMKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[LHOECCIDBFM(typeof(EGMGODHDCJJ), new string[] { })]
internal sealed class EGMGODHDCJJ : HNADMPPHDEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[JLCJNHHCBDK]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery GKHINNGNAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager GMCADEOGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x3E93310", Offset = "0x3E91D10", VA = "0x183E93310")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x3E93840", Offset = "0x3E92240", VA = "0x183E93840", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x3E933B0", Offset = "0x3E91DB0", VA = "0x183E933B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x3E93610", Offset = "0x3E92010", VA = "0x183E93610")]
	public bool HDIAMLJKEPG(Entity OOGAMDNOHNH, Entity NLHHFBGKIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x3E93480", Offset = "0x3E91E80", VA = "0x183E93480")]
	public IEnumerable<Entity> FGIDOIJCHJN(Entity OOGAMDNOHNH, bool APAIFOINEEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x3E93A20", Offset = "0x3E92420", VA = "0x183E93A20")]
	public bool PNIELCDHNAH(Entity OOGAMDNOHNH, Entity PGDGHENJBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x3E93250", Offset = "0x3E91C50", VA = "0x183E93250")]
	public bool AOKMHKIMGCA(Entity OOGAMDNOHNH, Entity NJJNIDPJHBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x3E93940", Offset = "0x3E92340", VA = "0x183E93940")]
	public NativeList<Entity> NFFCOOEMKMD(Entity OOGAMDNOHNH, bool APAIFOINEEK = false, Allocator APPJGCOGPBM = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x3E936D0", Offset = "0x3E920D0", VA = "0x183E936D0")]
	public IEnumerable<Entity> ILCFHAPNAEK(Entity OOGAMDNOHNH, bool APAIFOINEEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x3E93790", Offset = "0x3E92190", VA = "0x183E93790")]
	public Entity MHAMLAHOFJF(Entity OOGAMDNOHNH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x3E93360", Offset = "0x3E91D60", VA = "0x183E93360")]
	public NativeArray<Entity> DHDHEGNNJAD()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x3E93540", Offset = "0x3E91F40", VA = "0x183E93540")]
	public bool GCEPIHEHFPE(Entity NJJNIDPJHBF, Entity GEIIKIOFPCG, out Entity NPNKNKHBGOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x3E933D0", Offset = "0x3E91DD0", VA = "0x183E933D0")]
	private Entity EMGALAGFHIC(Entity OOGAMDNOHNH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EGMGODHDCJJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[KEFMDJAGLBH(IGKCNDFEDMC.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x3955790", Offset = "0x3954190", VA = "0x183955790")]
		public static void LFPDFEJCFOP<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(IBDMDNNFKPL CFMBBKOCIHK, global::KLCCANBKHMJ<Entity> IDLOFIFEDHN, out global::AIENCKMNNKI<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> DDHJNAKOPJH) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, OKEONJCOHFE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, OKEONJCOHFE, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5AC0", Offset = "0x3DF44C0", VA = "0x183DF5AC0")]
		public static bool OJANKHNGIKJ(GAIECBKNDJB IHJOFIPFCMM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class AIENCKMNNKI<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, OKEONJCOHFE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, OKEONJCOHFE, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly NNLEPLPFODN DPMCBMJDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::HBNHJLIDJBP<Entity> EELLPGLCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly JFBPDEPPPOH EEGFHCKDFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly LEECANKHNKH EOBFGLJBCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager IMCLABBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly ADANANCGCCD ACPBNDAJKOM;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x3CA45F0", Offset = "0x3CA2FF0", VA = "0x183CA45F0")]
	public AIENCKMNNKI(IBDMDNNFKPL CFMBBKOCIHK, global::KLCCANBKHMJ<Entity> IDLOFIFEDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x3CA37B0", Offset = "0x3CA21B0", VA = "0x183CA37B0")]
	private bool JHJGLAIAMJK(Entity OOGAMDNOHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3BB0", Offset = "0x3CA25B0", VA = "0x183CA3BB0")]
	private bool NMEBOCIGAOE(Entity OOGAMDNOHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x3CA33A0", Offset = "0x3CA1DA0", VA = "0x183CA33A0")]
	public bool CGJOPAHPCKK(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3C00", Offset = "0x3CA2600", VA = "0x183CA3C00")]
	public bool NMMKBGMJDKI(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3C30", Offset = "0x3CA2630", VA = "0x183CA3C30")]
	private bool NMMKBGMJDKI(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN, bool AABHCBEIJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void DAHGGDPDAPH(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void OIAFEIMKPJJ(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void KFKIGEBNKJL(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void GDNJFDLCHAP(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void NOAEJPELOFK(Entity OOGAMDNOHNH, in Entity KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA35F0", Offset = "0x3CA1FF0", VA = "0x183CA35F0")]
	private bool HDIAMLJKEPG(Entity OOGAMDNOHNH, Entity NLHHFBGKIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3500", Offset = "0x3CA1F00", VA = "0x183CA3500")]
	private void FOHDLMNEPCK(Entity OOGAMDNOHNH, in Entity GEFNMBFCONH, in Entity KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3870", Offset = "0x3CA2270", VA = "0x183CA3870")]
	private void NFFFCDCKBPD(Entity OOGAMDNOHNH, in Entity GEFNMBFCONH, in Entity KLJNAJJPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4070", Offset = "0x3CA2A70", VA = "0x183CA4070")]
	private bool OJLMICLKMAM(JCIDHHHPCHN GHLLKLHAFPK, in ANIMKGBLAIA MIDPFOLKLLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x3CA33D0", Offset = "0x3CA1DD0", VA = "0x183CA33D0")]
	private void FMALHNNINDF(Entity EOBFGLJBCIJ, Entity PGDGHENJBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3280", Offset = "0x3CA1C80", VA = "0x183CA3280")]
	private void BMKFLEEHJJC(Entity EOBFGLJBCIJ, Entity PGDGHENJBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private void BENMJNPNMJA(Entity OOGAMDNOHNH, Entity GEFNMBFCONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private void JAEPJKGLALI(Entity OOGAMDNOHNH, Entity KLJNAJJPMKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct JOCKHHHGOKK : MJEMKHPIPGA, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public GIFDPGCIHLK FICIADCAIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x875BB0", Offset = "0x8745B0", VA = "0x180875BB0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GIFDPGCIHLK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x882B40", Offset = "0x881540", VA = "0x180882B40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[LHOECCIDBFM(typeof(ObjectEmbodimentService), new string[] { })]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[KEFMDJAGLBH(IGKCNDFEDMC.Embodiment)]
	internal sealed class ObjectEmbodimentService : NMKGMGALGMP, NMGDKBIHJIB, HNADMPPHDEF, BCGODABHHDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService PADNNEGLENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[JLCJNHHCBDK]
		private FADNPGGGOHC FBHAGLEGMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[JLCJNHHCBDK]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[JLCJNHHCBDK]
		private CPIGIOMNEPF BAOOFNPBDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[JLCJNHHCBDK]
		private JJHOHFFKOJA IKNPAAMPCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[JLCJNHHCBDK]
		private TransformOwnershipPhase LMGMOPNOCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<ANIMKGBLAIA, MABFCBAKEGH> NAPAPEICLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private BJDJDGCPCKJ JOKMJFEFOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4870", Offset = "0x3DE3270", VA = "0x183DE4870")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int LIGJKEPAOEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4850", Offset = "0x3DE3250", VA = "0x183DE4850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int CLAHPAPIJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5740", Offset = "0x3DE4140", VA = "0x183DE5740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x21BAB20", Offset = "0x21B9520", VA = "0x1821BAB20", Slot = "4")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7220", Offset = "0x3DE5C20", VA = "0x183DE7220", Slot = "5")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6510", Offset = "0x3DE4F10", VA = "0x183DE6510")]
		public void IHLOAKHHEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE63C0", Offset = "0x3DE4DC0", VA = "0x183DE63C0", Slot = "6")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4D20", Offset = "0x3DE3720", VA = "0x183DE4D20", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7680", Offset = "0x3DE6080", VA = "0x183DE7680")]
		public int OFFJNMKKNIB(SceneTag OPCKNOAJELE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7660", Offset = "0x3DE6060", VA = "0x183DE7660")]
		public int NNGIMDNINAK(SceneTag OPCKNOAJELE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4E50", Offset = "0x3DE3850", VA = "0x183DE4E50")]
		public bool EBBLBDOHKIJ(Entity OOGAMDNOHNH, Allocator APPJGCOGPBM, out NativeList<Entity> JKHHLFFEBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6910", Offset = "0x3DE5310", VA = "0x183DE6910")]
		public bool JPFLPNIICHO(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x3DE48C0", Offset = "0x3DE32C0", VA = "0x183DE48C0")]
		public bool CFECPBDNIEP(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6560", Offset = "0x3DE4F60", VA = "0x183DE6560")]
		public bool ILGPCLHAMEC(Entity OOGAMDNOHNH, out MABFCBAKEGH KDNKFCLFKBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x3DE65D0", Offset = "0x3DE4FD0", VA = "0x183DE65D0")]
		private bool ILGPCLHAMEC(Transform DBMMOFPNJHL, out MABFCBAKEGH KDNKFCLFKBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7190", Offset = "0x3DE5B90", VA = "0x183DE7190")]
		private void LKPGFFHIKHI(Entity OOGAMDNOHNH, MABFCBAKEGH KDNKFCLFKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5C10", Offset = "0x3DE4610", VA = "0x183DE5C10")]
		private bool IBIBMMCPFNG(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE41D0", Offset = "0x3DE2BD0", VA = "0x183DE41D0")]
		public void AIDBCCOFMIA(ANIMKGBLAIA BBILPABEHHM, MABFCBAKEGH LCHJMMBJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE51B0", Offset = "0x3DE3BB0", VA = "0x183DE51B0")]
		public bool EDPCLNLPFKO(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5C30", Offset = "0x3DE4630", VA = "0x183DE5C30")]
		public bool IECCGCLPDPH(GEEJJFIMDNA BJLPLHMBBOJ, object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5FE0", Offset = "0x3DE49E0", VA = "0x183DE5FE0")]
		public bool IECCGCLPDPH(Entity OOGAMDNOHNH, [Optional] object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE63A0", Offset = "0x3DE4DA0", VA = "0x183DE63A0")]
		public bool IECCGCLPDPH(MABFCBAKEGH IHJOFIPFCMM, object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7BA0", Offset = "0x3DE65A0", VA = "0x183DE7BA0")]
		public bool PNNKGABBLLP(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7F70", Offset = "0x3DE6970", VA = "0x183DE7F70")]
		public bool PNNKGABBLLP(MABFCBAKEGH KDNKFCLFKBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6030", Offset = "0x3DE4A30", VA = "0x183DE6030")]
		public bool IECCGCLPDPH(MABFCBAKEGH KDNKFCLFKBG, [Optional] object HMAOAMDKNDD, bool BFIMHHIKINE = false, bool BPAPCEGHEAH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6B90", Offset = "0x3DE5590", VA = "0x183DE6B90")]
		public Transform KODIOKMOMKD(Entity OOGAMDNOHNH, [Optional] object HMAOAMDKNDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4B00", Offset = "0x3DE3500", VA = "0x183DE4B00")]
		public bool DDBBPDDJDDO(Entity OOGAMDNOHNH, out Transform DBMMOFPNJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4760", Offset = "0x3DE3160", VA = "0x183DE4760")]
		public MABFCBAKEGH BNDPAOHGHJG(Entity OOGAMDNOHNH, [Optional] object HMAOAMDKNDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6680", Offset = "0x3DE5080", VA = "0x183DE6680")]
		public void INHMMJGGOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5760", Offset = "0x3DE4160", VA = "0x183DE5760")]
		public void HEDKILGDKOP(SceneTag OPCKNOAJELE, bool IBHJMDEAAIG, global::CLBLKBMEDCN<int> MNHGHDPFNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x3DE76A0", Offset = "0x3DE60A0", VA = "0x183DE76A0")]
		private void PFPAAEMLECL(Entity OOGAMDNOHNH, bool IBHJMDEAAIG, bool KHKCPJCANNL, global::CLBLKBMEDCN<int> MNHGHDPFNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x3DE55C0", Offset = "0x3DE3FC0", VA = "0x183DE55C0")]
		private void FBMPGPGABNB(Entity OOGAMDNOHNH, MABFCBAKEGH KDNKFCLFKBG, bool IBHJMDEAAIG, bool KHKCPJCANNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7FA0", Offset = "0x3DE69A0", VA = "0x183DE7FA0")]
		public MABFCBAKEGH PPALOAMMPJE(Entity OOGAMDNOHNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE45C0", Offset = "0x3DE2FC0", VA = "0x183DE45C0")]
		public bool BEDNNMDNELJ(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4640", Offset = "0x3DE3040", VA = "0x183DE4640")]
		public bool BHOPDHAGJNE(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5550", Offset = "0x3DE3F50", VA = "0x183DE5550")]
		public bool EEEOIIPFJBL(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7000", Offset = "0x3DE5A00", VA = "0x183DE7000")]
		public bool LGBEGCFDINL(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6F30", Offset = "0x3DE5930", VA = "0x183DE6F30")]
		public bool LGBEGCFDINL(GIFDPGCIHLK DFKGNJHDLAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void HBCHMKGKIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4BD0", Offset = "0x3DE35D0", VA = "0x183DE4BD0")]
		private void DLLKMFLOGHB(bool KGDFIPGCODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4C90", Offset = "0x3DE3690", VA = "0x183DE4C90")]
		private bool DLLLFBOMFHG(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x3DE46C0", Offset = "0x3DE30C0", VA = "0x183DE46C0")]
		private MABFCBAKEGH BKIBHFDJMJD(Entity OOGAMDNOHNH, object HMAOAMDKNDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x3DE43D0", Offset = "0x3DE2DD0", VA = "0x183DE43D0")]
		private MABFCBAKEGH BCEKJNHNOCJ(Entity OOGAMDNOHNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x3DE48E0", Offset = "0x3DE32E0", VA = "0x183DE48E0")]
		private (Vector3, Quaternion, Vector3) CLNPPJONEIE(Entity OOGAMDNOHNH)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x3DE50A0", Offset = "0x3DE3AA0", VA = "0x183DE50A0")]
		private void EDOCENLGKHM(Entity OOGAMDNOHNH, IMJFJJBFBGO FPPOGBDGFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5B50", Offset = "0x3DE4550", VA = "0x183DE5B50")]
		private void HFNOFDMNAJB(GEEJJFIMDNA BJLPLHMBBOJ, MABFCBAKEGH LCHJMMBJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7070", Offset = "0x3DE5A70", VA = "0x183DE7070")]
		private void LKHIBKIGJHL(MABFCBAKEGH LCHJMMBJPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6D00", Offset = "0x3DE5700", VA = "0x183DE6D00")]
		private void KOKAKCGFICH(MABFCBAKEGH KDNKFCLFKBG, Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7350", Offset = "0x3DE5D50", VA = "0x183DE7350")]
		private void MKLABJOEAKI(Entity OOGAMDNOHNH, MABFCBAKEGH KDNKFCLFKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5660", Offset = "0x3DE4060", VA = "0x183DE5660")]
		private void FMBKPFENFAE(Entity OOGAMDNOHNH, Transform DBMMOFPNJHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6B60", Offset = "0x3DE5560", VA = "0x183DE6B60")]
		private GEEJJFIMDNA KJMJGGKIKPB(Entity OOGAMDNOHNH)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8040", Offset = "0x3DE6A40", VA = "0x183DE8040")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7590", Offset = "0x3DE5F90", VA = "0x183DE7590")]
		[CompilerGenerated]
		private void MNCCCAHCBKM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class HGDBLCNGDJO
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x41C5530", Offset = "0x41C3F30", VA = "0x1841C5530")]
	public static MABFCBAKEGH BNDPAOHGHJG(this ObjectEmbodimentService JMHKMIOCNFD, GEEJJFIMDNA BJLPLHMBBOJ, [Optional] object HMAOAMDKNDD)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[LHOECCIDBFM(typeof(ObjectLifecycleService), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Lifecycle)]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	internal sealed class ObjectLifecycleService : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService KDNKFCLFKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private INPDPGIAJAM AFLONPELFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects ENJODMCKNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x3DE88B0", Offset = "0x3DE72B0", VA = "0x183DE88B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, IMJFJJBFBGO> LMMFNCFKHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8E60", Offset = "0x3DE7860", VA = "0x183DE8E60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9620", Offset = "0x3DE8020", VA = "0x183DE9620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> MBHCGMGENBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8780", Offset = "0x3DE7180", VA = "0x183DE8780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8F00", Offset = "0x3DE7900", VA = "0x183DE8F00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9260", Offset = "0x3DE7C60", VA = "0x183DE9260", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5880", Offset = "0x1FF4280", VA = "0x181FF5880", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x3DE95A0", Offset = "0x3DE7FA0", VA = "0x183DE95A0")]
		public bool OJCAMDKMMGI(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9540", Offset = "0x3DE7F40", VA = "0x183DE9540")]
		internal void OCPPKGMMHHF(Entity OOGAMDNOHNH, IMJFJJBFBGO FPPOGBDGFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9340", Offset = "0x3DE7D40", VA = "0x183DE9340")]
		public void NPDNJOJOBPP(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8B60", Offset = "0x3DE7560", VA = "0x183DE8B60")]
		public void ELNPFHKPBMI(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8FA0", Offset = "0x3DE79A0", VA = "0x183DE8FA0")]
		private bool KMGACAAEEMC(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8960", Offset = "0x3DE7360", VA = "0x183DE8960")]
		public void EDLFOMBBBBL(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9380", Offset = "0x3DE7D80", VA = "0x183DE9380")]
		private bool NPMFOKNBFJH(Entity OOGAMDNOHNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8820", Offset = "0x3DE7220", VA = "0x183DE8820")]
		public void BGKEGMHOBPA(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8900", Offset = "0x3DE7300", VA = "0x183DE8900")]
		private void CFNMGFEBCCE(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8BB0", Offset = "0x3DE75B0", VA = "0x183DE8BB0")]
		private void FDNBCHBELKO(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8E10", Offset = "0x3DE7810", VA = "0x183DE8E10")]
		public void HKFCFNMALAB(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private void EMEOCFBCOBK(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9060", Offset = "0x3DE7A60", VA = "0x183DE9060")]
		private void LFGMHPIKOEN(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(ObjectPrefabs), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Prefabs)]
	internal class ObjectPrefabs : AHOBDEDDKCC, HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class LHCIKKLCKFD : IEnumerable<(BFFEGPGDBEI, IMJFJJBFBGO)>, IEnumerable, IEnumerator<(BFFEGPGDBEI, IMJFJJBFBGO)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (BFFEGPGDBEI primitiveType, IMJFJJBFBGO prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700013A")]
			private (BFFEGPGDBEI, IMJFJJBFBGO) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x1C45710", Offset = "0x1C44110", VA = "0x181C45710", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((BFFEGPGDBEI, IMJFJJBFBGO));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x47C6DF0", Offset = "0x47C57F0", VA = "0x1847C6DF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x47C6E40", Offset = "0x47C5840", VA = "0x1847C6E40")]
			[DebuggerHidden]
			public LHCIKKLCKFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x47C6C10", Offset = "0x47C5610", VA = "0x1847C6C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x47C6DB0", Offset = "0x47C57B0", VA = "0x1847C6DB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x47C6D10", Offset = "0x47C5710", VA = "0x1847C6D10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(BFFEGPGDBEI, IMJFJJBFBGO)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x47C6D10", Offset = "0x47C5710", VA = "0x1847C6D10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<IMJFJJBFBGO, Entity> DKNCGBIHPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<IMJFJJBFBGO, EntityArchetype> FHFEGNAJEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<BFFEGPGDBEI, IMJFJJBFBGO> PKLEDBDMBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<MPCFEHACDMF, IMJFJJBFBGO> JKLNHODGAPB;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int GNKNLJGDNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBD00", Offset = "0x3DEA700", VA = "0x183DEBD00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBF70", Offset = "0x3DEA970", VA = "0x183DEBF70")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x3DECF60", Offset = "0x3DEB960", VA = "0x183DECF60", Slot = "5")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBFF0", Offset = "0x3DEA9F0", VA = "0x183DEBFF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x3DECF00", Offset = "0x3DEB900", VA = "0x183DECF00")]
		internal IEnumerable<Type> MADEDHFHDHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x3DECE90", Offset = "0x3DEB890", VA = "0x183DECE90")]
		internal JFECPFAKGNJ LIBCFKJIPPK(Type EMKINACMDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x3DED450", Offset = "0x3DEBE50", VA = "0x183DED450")]
		public EntityArchetype NKPFALIELHN(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x3DECB10", Offset = "0x3DEB510", VA = "0x183DECB10")]
		public NativeHashMap<int, EntityArchetype> IGJENLEIBHA(Allocator APPJGCOGPBM = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x3DECDB0", Offset = "0x3DEB7B0", VA = "0x183DECDB0")]
		public bool JGLOGCNKFOJ(IMJFJJBFBGO FPPOGBDGFJM, out EntityArchetype FFCMEKBDBJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x3DED4B0", Offset = "0x3DEBEB0", VA = "0x183DED4B0", Slot = "4")]
		[IteratorStateMachine(typeof(LHCIKKLCKFD))]
		public IEnumerable<(BFFEGPGDBEI, IMJFJJBFBGO)> OCFKHGMJOPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x3DED340", Offset = "0x3DEBD40", VA = "0x183DED340")]
		public Entity NBNDBJHEGMK(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBDB0", Offset = "0x3DEA7B0", VA = "0x183DEBDB0")]
		public IMJFJJBFBGO BMFKKEJNBMK(MPCFEHACDMF EMKINACMDLO)
		{
			return default(IMJFJJBFBGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBD50", Offset = "0x3DEA750", VA = "0x183DEBD50")]
		public IMJFJJBFBGO BMFKKEJNBMK(BFFEGPGDBEI EMKINACMDLO)
		{
			return default(IMJFJJBFBGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC320", Offset = "0x3DEAD20", VA = "0x183DEC320")]
		public NativeHashMap<int, Entity> FGHCGECEJFP(Allocator APPJGCOGPBM = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x3DED520", Offset = "0x3DEBF20", VA = "0x183DED520")]
		public IEnumerable<IMJFJJBFBGO> OMLIFGHPCMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBF90", Offset = "0x3DEA990", VA = "0x183DEBF90")]
		public Entity DHMEFIBLKGC(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x3DECE20", Offset = "0x3DEB820", VA = "0x183DECE20")]
		public bool KOKGCAMDPIH(IMJFJJBFBGO FPPOGBDGFJM, out Entity INOMEBNKFPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC6C0", Offset = "0x3DEB0C0", VA = "0x183DEC6C0")]
		private void GAODLIDOFDF(JFECPFAKGNJ LPBPAFPFMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC490", Offset = "0x3DEAE90", VA = "0x183DEC490")]
		internal void FPONFHDMJOK(IMJFJJBFBGO FPPOGBDGFJM, ComponentTypeList EPIEJCBMEIH, LKCGAGIHLIC LOBALHHLAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBE10", Offset = "0x3DEA810", VA = "0x183DEBE10")]
		private void CBMOCODMOPJ(IMJFJJBFBGO FPPOGBDGFJM, ComponentTypeList HNJADIDOPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x3DECC90", Offset = "0x3DEB690", VA = "0x183DECC90")]
		internal Entity JDFNJGJDIMN(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x3DED5C0", Offset = "0x3DEBFC0", VA = "0x183DED5C0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum AMLOFAHKBFL
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface IGEFGKKEMFB
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World EAMNELNJNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	PELHPHDIANP ODEOOMFLPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class POPKLEKOFFA : MNOIPPEKGPC, PGHENGEHMNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly HANMOAONPMA HGIIEBHLJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly AMLOFAHKBFL LMGMOPNOCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<AMABHDCNCJE> NLBHDACMBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, IIALMMAFGKL> ODHGDHPFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> JMEPMBKPMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle CDMHNBFEPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle APEDJKEIHDF;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World HECLLNGBIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF49C0", Offset = "0x3DF33C0", VA = "0x183DF49C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private PELHPHDIANP HJKMHBDHGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x12109A0", Offset = "0x120F3A0", VA = "0x1812109A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private NKFLGMBHNDD ICLAMIKMNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x945500", Offset = "0x943F00", VA = "0x180945500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, IIALMMAFGKL> JHMHKJCIDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x8C38B0", Offset = "0x8C22B0", VA = "0x1808C38B0", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, IIALMMAFGKL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle ANOODIEEMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x94C320", Offset = "0x94AD20", VA = "0x18094C320", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x10F17A0", Offset = "0x10F01A0", VA = "0x1810F17A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool LGFILAHDMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3E50", Offset = "0x3DF2850", VA = "0x183DF3E50", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World LFNNINFOAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x3DF46E0", Offset = "0x3DF30E0", VA = "0x183DF46E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4CD0", Offset = "0x3DF36D0", VA = "0x183DF4CD0")]
	public POPKLEKOFFA(HANMOAONPMA HGIIEBHLJGH, AMLOFAHKBFL LMGMOPNOCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x3DF43B0", Offset = "0x3DF2DB0", VA = "0x183DF43B0", Slot = "11")]
	private void FBMDPBIKELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4740", Offset = "0x3DF3140", VA = "0x183DF4740", Slot = "10")]
	private bool JEEAOOOKJJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4890", Offset = "0x3DF3290", VA = "0x183DF4890", Slot = "12")]
	private void KKPJMKNJDLO(ComponentType EPNDONNEBFB, in AMABHDCNCJE NIEIJHJPDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4860", Offset = "0x3DF3260", VA = "0x183DF4860", Slot = "13")]
	private bool KICKFGCGOJE(IMJFJJBFBGO FPPOGBDGFJM, out Entity INOMEBNKFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4640", Offset = "0x3DF3040", VA = "0x183DF4640", Slot = "16")]
	private bool ILCLJNLHIDJ(out NativeArray<int> DBFMPPECKDH, Allocator APPJGCOGPBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF41F0", Offset = "0x3DF2BF0", VA = "0x183DF41F0", Slot = "17")]
	private bool EGHGGHLMFON(ComponentType EPNDONNEBFB, out AMABHDCNCJE KFOKNGGHCED, out BNNAJMCLMKJ HFKBPOPIAIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF40C0", Offset = "0x3DF2AC0", VA = "0x183DF40C0", Slot = "18")]
	private bool EGHGGHLMFON(ComponentType EPNDONNEBFB, out AMABHDCNCJE KFOKNGGHCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF43C0", Offset = "0x3DF2DC0", VA = "0x183DF43C0", Slot = "19")]
	private AMABHDCNCJE FNGLCFKBBLA(ComponentType EPNDONNEBFB)
	{
		return default(AMABHDCNCJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4980", Offset = "0x3DF3380", VA = "0x183DF4980", Slot = "20")]
	private NNCACHALMCM KOCJHNOHNFC()
	{
		return default(NNCACHALMCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3E60", Offset = "0x3DF2860", VA = "0x183DF3E60", Slot = "21")]
	private void BGAFIGBPGBC(JobHandle CJDKHEEAEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4A20", Offset = "0x3DF3420", VA = "0x183DF4A20")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3EA0", Offset = "0x3DF28A0", VA = "0x183DF3EA0")]
	private bool DFILMOHGBPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x3DF44B0", Offset = "0x3DF2EB0", VA = "0x183DF44B0")]
	private int HFBMOIAPFOA()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class HANMOAONPMA : IGEFGKKEMFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public BJJPOMIINDM HFELLKINAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService DKNCGBIHPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public PELHPHDIANP PJBNGPJFEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public NKFLGMBHNDD NNALFMHPMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public CLHJLGPICBJ GCPDIGECKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World EAMNELNJNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x41C54D0", Offset = "0x41C3ED0", VA = "0x1841C54D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public PELHPHDIANP ODEOOMFLPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public HANMOAONPMA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(PropertyDiffStateService), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.PropertyChanges)]
	internal class PropertyDiffStateService : HNADMPPHDEF, BCGODABHHDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct PCMMCOMNGJL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly AMLOFAHKBFL DCDFGCHLKIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService LMACCHFJBFE;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x47CAB20", Offset = "0x47C9520", VA = "0x1847CAB20")]
			public PCMMCOMNGJL(PropertyDiffStateService LMACCHFJBFE, AMLOFAHKBFL BMFHHLIMPEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x47CAB00", Offset = "0x47C9500", VA = "0x1847CAB00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly HANMOAONPMA HGIIEBHLJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly POPKLEKOFFA[] PDHMJINNJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private AMLOFAHKBFL LGJOHPLHJCB;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public IGEFGKKEMFB GOKIFJMAJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public PGHENGEHMNP BDNKCCKAIPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC560", Offset = "0x3DFAF60", VA = "0x183DFC560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public MNOIPPEKGPC HPFNGAMMIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC560", Offset = "0x3DFAF60", VA = "0x183DFC560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x115F7B0", Offset = "0x115E1B0", VA = "0x18115F7B0")]
		public PGHENGEHMNP MCILFABDGJL(AMLOFAHKBFL LMGMOPNOCBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x115F7B0", Offset = "0x115E1B0", VA = "0x18115F7B0")]
		public MNOIPPEKGPC CDPBBMFJGMG(AMLOFAHKBFL LMGMOPNOCBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCAF0", Offset = "0x3DFB4F0", VA = "0x183DFCAF0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC680", Offset = "0x3DFB080", VA = "0x183DFC680", Slot = "5")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCB70", Offset = "0x3DFB570", VA = "0x183DFCB70")]
		public void PDOAHDCGLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC5A0", Offset = "0x3DFAFA0", VA = "0x183DFC5A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCAD0", Offset = "0x3DFB4D0", VA = "0x183DFCAD0")]
		public PCMMCOMNGJL KCPEMAFDMEP(AMLOFAHKBFL LMGMOPNOCBJ)
		{
			return default(PCMMCOMNGJL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCC20", Offset = "0x3DFB620", VA = "0x183DFCC20")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[KEFMDJAGLBH(IGKCNDFEDMC.HierarchySystems)]
	[LHOECCIDBFM(typeof(SceneService), new string[] { })]
	internal class SceneService : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag ODAIGNNFMEC;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string HHDHKNHCHLA = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string IOBPIDALNLA = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[JLCJNHHCBDK]
		private MCKELHDHOFN DCKGKAIMOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[JLCJNHHCBDK]
		private ObjectEmbodimentService KDNKFCLFKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[JLCJNHHCBDK]
		private JFBPDEPPPOH HGICKBJDBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[JLCJNHHCBDK]
		private SingletonComponentService HECJCMJHILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[JLCJNHHCBDK]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[JLCJNHHCBDK]
		private PhotonInstanceCleanupService CLOJHFJKCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery DHJACHMMJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery FPPIJHECDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery GHOFMIHMOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity NLKNGFLHHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool IPJNPLCNLLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x3D233B0", Offset = "0x3D21DB0", VA = "0x183D233B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> LIBGBNNJNOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0xD53650", Offset = "0xD52050", VA = "0x180D53650")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0xD53760", Offset = "0xD52160", VA = "0x180D53760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity BAIOOLHLHLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x3D22DF0", Offset = "0x3D217F0", VA = "0x183D22DF0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag GMIJFEIJOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x3D22360", Offset = "0x3D20D60", VA = "0x183D22360")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity IPDKIGIMALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x3D22360", Offset = "0x3D20D60", VA = "0x183D22360")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x3D22950", Offset = "0x3D21350", VA = "0x183D22950")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x3D22590", Offset = "0x3D20F90", VA = "0x183D22590")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x3D23290", Offset = "0x3D21C90", VA = "0x183D23290", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x3D22900", Offset = "0x3D21300", VA = "0x183D22900", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x3D22C80", Offset = "0x3D21680", VA = "0x183D22C80")]
		public void IBBDKONNLGJ(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x3D22DC0", Offset = "0x3D217C0", VA = "0x183D22DC0")]
		public NativeArray<Entity> IMMCHPAAMDE(Allocator APPJGCOGPBM = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x3D22CC0", Offset = "0x3D216C0", VA = "0x183D22CC0")]
		public void ILBMFMBAHFP(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x3D23070", Offset = "0x3D21A70", VA = "0x183D23070")]
		public Entity KPFFPDJFGGN(string KMEGKECOLPJ = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x3D23CC0", Offset = "0x3D226C0", VA = "0x183D23CC0")]
		public void OHKDBIPOGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x3D23190", Offset = "0x3D21B90", VA = "0x183D23190")]
		public void LOEIBJNBDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x3D229D0", Offset = "0x3D213D0", VA = "0x183D229D0")]
		public void FNKBMNBHPIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x3D23CB0", Offset = "0x3D226B0", VA = "0x183D23CB0")]
		public void OBOIMJFOMNM(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x3D23CE0", Offset = "0x3D226E0", VA = "0x183D23CE0")]
		public bool PGPIBAINFJM(Entity OPCKNOAJELE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x3D229C0", Offset = "0x3D213C0", VA = "0x183D229C0")]
		public void ENHLNKGMBOP(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x3D22F60", Offset = "0x3D21960", VA = "0x183D22F60")]
		public string KIEOCKHNFFN(Entity OPCKNOAJELE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		public void EPKLEHIGHCN(Entity OPCKNOAJELE, string KMEGKECOLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x3D22F40", Offset = "0x3D21940", VA = "0x183D22F40")]
		public bool JNKIEPPLILI(string KMEGKECOLPJ, out Entity OPCKNOAJELE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x3D22A60", Offset = "0x3D21460", VA = "0x183D22A60")]
		public void GNMNCFPLEPC(Entity OPCKNOAJELE, bool HONAPACDAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x3D223B0", Offset = "0x3D20DB0", VA = "0x183D223B0")]
		public void BFBJAPNPCGD(Entity OOGAMDNOHNH, bool BBGENIPIPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x3D22430", Offset = "0x3D20E30", VA = "0x183D22430")]
		public void BFBJAPNPCGD(NativeArray<Entity> AJMHFNCBOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x3D224A0", Offset = "0x3D20EA0", VA = "0x183D224A0")]
		public void BFBJAPNPCGD(EntityQuery IOEGIOMNPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x3D23A40", Offset = "0x3D22440", VA = "0x183D23A40")]
		public void NNLFBPKDDIO(Entity OOGAMDNOHNH, Entity OPCKNOAJELE, bool BBGENIPIPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x3D23860", Offset = "0x3D22260", VA = "0x183D23860")]
		public void NNLFBPKDDIO(NativeArray<Entity> AJMHFNCBOJK, Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x3D237B0", Offset = "0x3D221B0", VA = "0x183D237B0")]
		public void NNLFBPKDDIO(EntityQuery IOEGIOMNPHI, Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x3D22750", Offset = "0x3D21150", VA = "0x183D22750")]
		private void DFPFOKPFEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x3D23260", Offset = "0x3D21C60", VA = "0x183D23260")]
		private void MIJEKBLHBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x3D22DF0", Offset = "0x3D217F0", VA = "0x183D22DF0")]
		private Entity JHLGFBCFKKK()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x3D22BD0", Offset = "0x3D215D0", VA = "0x183D22BD0")]
		private void HMNNOOOANGC(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x3D23400", Offset = "0x3D21E00", VA = "0x183D23400")]
		private void NNHBABINIML(EntityQuery CCGMBIMCCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x3D234D0", Offset = "0x3D21ED0", VA = "0x183D234D0")]
		private void NNHBABINIML(NativeArray<Entity> NJADCKCLHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x3D231B0", Offset = "0x3D21BB0", VA = "0x183D231B0")]
		private void MDDHMLFKJMB(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x3D22230", Offset = "0x3D20C30", VA = "0x183D22230")]
		private void AJIPKKPEKLI(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x3D225E0", Offset = "0x3D20FE0", VA = "0x183D225E0")]
		private void CDJBPIDMDHH(SceneTag ANCGMDMOMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x3D23C70", Offset = "0x3D22670", VA = "0x183D23C70")]
		private void OADEGHFGNGP(SceneTag ANCGMDMOMAF, global::CLBLKBMEDCN<int> MNHGHDPFNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x3D220A0", Offset = "0x3D20AA0", VA = "0x183D220A0")]
		private void AEEHEDAGGBK(SceneTag ANCGMDMOMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x3D230F0", Offset = "0x3D21AF0", VA = "0x183D230F0")]
		private void LLGLMCAFHMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x5232D80", Offset = "0x5231780", VA = "0x185232D80")]
		private void DMNALOBAGGN<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LLMLLBDKEDD(SceneTag ANCGMDMOMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x3D22B70", Offset = "0x3D21570", VA = "0x183D22B70")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void HIBIBBOAKEJ(EntityQuery IOEGIOMNPHI, string KMEGKECOLPJ, SceneTag ANCGMDMOMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x3D22A30", Offset = "0x3D21430", VA = "0x183D22A30")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GLJOGJIDGMN(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void ACELBPNOIBF(Entity OPCKNOAJELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[POJCHFKPLOJ(PFPBFPDNLIO.PhotonRoom)]
	[LHOECCIDBFM(typeof(EEDIDAECHEO), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.HierarchySystems)]
	internal class UnitySceneService : HNADMPPHDEF, EEDIDAECHEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[JLCJNHHCBDK]
		private SceneService NJADCKCLHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> OGGDIDCBGEN;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x3D318D0", Offset = "0x3D302D0", VA = "0x183D318D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x3D31B00", Offset = "0x3D30500", VA = "0x183D31B00", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x3D31990", Offset = "0x3D30390", VA = "0x183D31990", Slot = "5")]
		public void IBBDKONNLGJ(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x3D316E0", Offset = "0x3D300E0", VA = "0x183D316E0", Slot = "6")]
		public bool BDAAKKIBDNK(GEEJJFIMDNA BJLPLHMBBOJ, Transform DBMMOFPNJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x3D31920", Offset = "0x3D30320", VA = "0x183D31920")]
		private bool CHLIOAENLMB(Scene OPCKNOAJELE, out Entity ADECFEAEPMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x3D31B90", Offset = "0x3D30590", VA = "0x183D31B90")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ComponentSystemTypes)]
	[LHOECCIDBFM(typeof(SingletonComponentService), new string[] { })]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	internal sealed class SingletonComponentService : HNADMPPHDEF, BCGODABHHDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[JLCJNHHCBDK]
		private JFBPDEPPPOH HGICKBJDBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity OOGAMDNOHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList HNJADIDOPMA;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int GNKNLJGDNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x3D283F0", Offset = "0x3D26DF0", VA = "0x183D283F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity ODKCGNNLJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager GMCADEOGFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x3D28400", Offset = "0x3D26E00", VA = "0x183D28400")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x5234510", Offset = "0x5232F10", VA = "0x185234510")]
		public T ABMJNALEGDK<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x52345D0", Offset = "0x5232FD0", VA = "0x1852345D0")]
		public void CKIEIOOCMAM<T>(T MFBGAMJDOKA) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x3D28BC0", Offset = "0x3D275C0", VA = "0x183D28BC0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x3D28720", Offset = "0x3D27120", VA = "0x183D28720", Slot = "5")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x3D28720", Offset = "0x3D27120", VA = "0x183D28720")]
		private void IEKGFDBEOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x3D28450", Offset = "0x3D26E50", VA = "0x183D28450", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x3D288C0", Offset = "0x3D272C0", VA = "0x183D288C0")]
		private ComponentTypeList KEHKNCKKNEP()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private static void PJJPIIJLKPE(int HGMGPFAJPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		private static void HFDMPDDIFAL(Type EMKINACMDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x3D28C30", Offset = "0x3D27630", VA = "0x183D28C30")]
		private static void NLNFMMHPDEH(Type EMKINACMDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct HIMBHFEIIDM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
[LHOECCIDBFM(typeof(JJHOHFFKOJA), new string[] { })]
internal sealed class JJHOHFFKOJA : HNADMPPHDEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[JLCJNHHCBDK]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::BMCEMPIECED<JKDNDJCDOOM, Entity> KGNMHDDJMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::NPAIFDLKEKJ<FOACHOPGFKK> DGELNKDODKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::NPAIFDLKEKJ<MODBHMNMJEI> EMKODDDCMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::NPAIFDLKEKJ<DMDCFIGNDHO> OONCDFHLPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::NPAIFDLKEKJ<NOFCPAACCBG> OHLGELBBKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::NPAIFDLKEKJ<JOCKHHHGOKK> JMHKMIOCNFD;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::IFMDKBEKNAG<Entity> ABOLCMBIAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public FIBIKGKDKJA ODLNIOBJPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public FIBIKGKDKJA ANGCBKLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public FIBIKGKDKJA ODKEDICPCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public FIBIKGKDKJA PDGHNEDBEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public FIBIKGKDKJA HGLNHCCHGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager GMCADEOGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x41D04B0", Offset = "0x41CEEB0", VA = "0x1841D04B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x41D05F0", Offset = "0x41CEFF0", VA = "0x1841D05F0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x41D0500", Offset = "0x41CEF00", VA = "0x1841D0500", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x39DAB10", Offset = "0x39D9510", VA = "0x1839DAB10")]
	private void LFPDFEJCFOP<T>(ref global::NPAIFDLKEKJ<T> GJLENILPINE) where T : struct, MJEMKHPIPGA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x39DAB10", Offset = "0x39D9510", VA = "0x1839DAB10")]
	private void LFPDFEJCFOP<TC, TV>(ref global::BMCEMPIECED<TC, TV> GJLENILPINE) where TC : struct, MJEMKHPIPGA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public JJHOHFFKOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[LHOECCIDBFM(typeof(KICBBFNOGMD), new string[] { })]
[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
internal sealed class KICBBFNOGMD : NMGDKBIHJIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private OIAINGCNGGF GDCILBBJFJH;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public OIAINGCNGGF DKCAMFKOECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x15D6610", Offset = "0x15D5010", VA = "0x1815D6610")]
		get
		{
			return default(OIAINGCNGGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x41D1AA0", Offset = "0x41D04A0", VA = "0x1841D1AA0", Slot = "4")]
	public void FECFGPJJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x41D1A90", Offset = "0x41D0490", VA = "0x1841D1A90", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KICBBFNOGMD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(TransformOwnershipPhase), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum CFPNPJNCPLL
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct NPKMHINMLJE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private CFPNPJNCPLL JBBICKLMJIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase EOBFGLJBCIJ;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x47C9F60", Offset = "0x47C8960", VA = "0x1847C9F60")]
			public NPKMHINMLJE(TransformOwnershipPhase EOBFGLJBCIJ, CFPNPJNCPLL LMGMOPNOCBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x47C9F40", Offset = "0x47C8940", VA = "0x1847C9F40", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CFPNPJNCPLL LMGMOPNOCBJ;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public CFPNPJNCPLL NBIJNDACHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00")]
			get
			{
				return default(CFPNPJNCPLL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x80B370", Offset = "0x809D70", VA = "0x18080B370")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool IPPBNDFENFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x1785EA0", Offset = "0x17848A0", VA = "0x181785EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool LNFLIDKJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x33B5360", Offset = "0x33B3D60", VA = "0x1833B5360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BFC0", Offset = "0x3D2A9C0", VA = "0x183D2BFC0")]
		public NPKMHINMLJE LIJFAJFBFLA()
		{
			return default(NPKMHINMLJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BF90", Offset = "0x3D2A990", VA = "0x183D2BF90")]
		public NPKMHINMLJE CGNIKOEOPIH()
		{
			return default(NPKMHINMLJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[LHOECCIDBFM(typeof(BOBHNBKKIJM), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Circuits)]
	public class CircuitsService : HNADMPPHDEF, BOBHNBKKIJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[JLCJNHHCBDK]
		private LEKBEEJFJBD FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager IMCLABBJAOB;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x3E85890", Offset = "0x3E84290", VA = "0x183E85890", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x3E85100", Offset = "0x3E83B00", VA = "0x183E85100", Slot = "5")]
		public bool EOBCKHLPHPL(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x3E84D00", Offset = "0x3E83700", VA = "0x183E84D00", Slot = "7")]
		public bool DOIHGEEOIFG(GEEJJFIMDNA BJLPLHMBBOJ, out Guid HPEIPIPPKPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x3E853C0", Offset = "0x3E83DC0", VA = "0x183E853C0", Slot = "8")]
		public Guid JFLGOMCOCPO(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x3E84EA0", Offset = "0x3E838A0", VA = "0x183E84EA0", Slot = "9")]
		public void EEFGIIJJBAA(GEEJJFIMDNA BJLPLHMBBOJ, Guid HPEIPIPPKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x3E85200", Offset = "0x3E83C00", VA = "0x183E85200", Slot = "10")]
		public bool FFDMONOHEKC(GEEJJFIMDNA BJLPLHMBBOJ, out Guid EEKEBONOBOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x3E85930", Offset = "0x3E84330", VA = "0x183E85930", Slot = "11")]
		public Guid NBFFIEGOEMN(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x3E848E0", Offset = "0x3E832E0", VA = "0x183E848E0", Slot = "12")]
		public void ANFLBMOFNDP(GEEJJFIMDNA BJLPLHMBBOJ, Guid EEKEBONOBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x3E84CB0", Offset = "0x3E836B0", VA = "0x183E84CB0", Slot = "13")]
		public bool DNMAEINIGHM(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x3E85350", Offset = "0x3E83D50", VA = "0x183E85350", Slot = "14")]
		public void HIEDNIAONJI(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x3E854D0", Offset = "0x3E83ED0", VA = "0x183E854D0", Slot = "15")]
		public void KFEHLHLJLOE(GEEJJFIMDNA BJCKADBMKDM, GEEJJFIMDNA EOBFGLJBCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x3E84B40", Offset = "0x3E83540", VA = "0x183E84B40")]
		private void BOBCJMICEAC(EGAKBJMAEDL NLMMJMBJDIH, GEEJJFIMDNA EOBFGLJBCIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x3E84750", Offset = "0x3E83150", VA = "0x183E84750")]
		private void AIDPDOKMOPK(EGAKBJMAEDL NLMMJMBJDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x3E85A40", Offset = "0x3E84440", VA = "0x183E85A40")]
		private bool PJNBANPEFNJ(GAIECBKNDJB OMHIFHKMIMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x3E84DF0", Offset = "0x3E837F0", VA = "0x183E84DF0")]
		private bool EAFABLNOPNO(GAIECBKNDJB OMHIFHKMIMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x3E852F0", Offset = "0x3E83CF0", VA = "0x183E852F0", Slot = "6")]
		public bool GKFMONDEHBE(GEEJJFIMDNA AGGJCDBCIGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[LHOECCIDBFM(typeof(FADGHEDABFI), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Connectables)]
	internal class ConnectableService : FADGHEDABFI, HNADMPPHDEF, BCGODABHHDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class MBOMECBJGAN : IEnumerable<GEEJJFIMDNA>, IEnumerable, IEnumerator<GEEJJFIMDNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private GEEJJFIMDNA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private GEEJJFIMDNA localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public GEEJJFIMDNA <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private GEEJJFIMDNA System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(GEEJJFIMDNA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x47C8A10", Offset = "0x47C7410", VA = "0x1847C8A10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x95A0C0", Offset = "0x958AC0", VA = "0x18095A0C0")]
			[DebuggerHidden]
			public MBOMECBJGAN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x47C8A60", Offset = "0x47C7460", VA = "0x1847C8A60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x47C8620", Offset = "0x47C7020", VA = "0x1847C8620", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x47C8B30", Offset = "0x47C7530", VA = "0x1847C8B30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x47C8B80", Offset = "0x47C7580", VA = "0x1847C8B80")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x47C89D0", Offset = "0x47C73D0", VA = "0x1847C89D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x47C8920", Offset = "0x47C7320", VA = "0x1847C8920", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GEEJJFIMDNA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x47C8920", Offset = "0x47C7320", VA = "0x1847C8920", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly NNLEPLPFODN LMAFOAMNLMK;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int BBHOMPHANIL = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int BDELJLDLNHO = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private FADNPGGGOHC FBHAGLEGMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private OGJECELGDOJ FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService NGCEPKOKHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::HBNHJLIDJBP<Entity> MJIACAEDLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::HBNHJLIDJBP<float3> POBMPDEGPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::HBNHJLIDJBP<quaternion> KFAENAJPELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::HBNHJLIDJBP<Entity> EOBFGLJBCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::HBNHJLIDJBP<float3> OPILFLDGFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::HBNHJLIDJBP<quaternion> PLKNLINIEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> DGACFMNGKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> PIJPPOLCILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery GKHINNGNAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<LFFGGCFFMHP> NHEKKBIOPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x7D6730", Offset = "0x7D5130", VA = "0x1807D6730", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x7D6790", Offset = "0x7D5190", VA = "0x1807D6790", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<GEEJJFIMDNA, GEEJJFIMDNA> KDOBMINMPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x3E89FD0", Offset = "0x3E889D0", VA = "0x183E89FD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x3E89920", Offset = "0x3E88320", VA = "0x183E89920", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<GEEJJFIMDNA, GEEJJFIMDNA> PNOEIAAIEAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x3E8A7F0", Offset = "0x3E891F0", VA = "0x183E8A7F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x3E8AC40", Offset = "0x3E89640", VA = "0x183E8AC40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<GEEJJFIMDNA, GEEJJFIMDNA, GEEJJFIMDNA> KLJABMBFJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x3E8B2C0", Offset = "0x3E89CC0", VA = "0x183E8B2C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x3E8AA50", Offset = "0x3E89450", VA = "0x183E8AA50", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<GEEJJFIMDNA> COBHPIBHMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x3E8A6F0", Offset = "0x3E890F0", VA = "0x183E8A6F0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x3E8B360", Offset = "0x3E89D60", VA = "0x183E8B360", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8ACE0", Offset = "0x3E896E0", VA = "0x183E8ACE0", Slot = "25")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A250", Offset = "0x3E88C50", VA = "0x183E8A250", Slot = "26")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x3E899C0", Offset = "0x3E883C0", VA = "0x183E899C0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A790", Offset = "0x3E89190", VA = "0x183E8A790")]
		private void IKIHLJKDPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B400", Offset = "0x3E89E00", VA = "0x183E8B400")]
		private void POMGGMJCCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A890", Offset = "0x3E89290", VA = "0x183E8A890")]
		private void JGNEHAHEJAB(Entity OOGAMDNOHNH, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO GFPNEMALIHE, ABKAKFBNEMO JOOHHAMJDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x3E89CF0", Offset = "0x3E886F0", VA = "0x183E89CF0")]
		private void GACKMKOFGDP(Entity OOGAMDNOHNH, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO GFPNEMALIHE, ABKAKFBNEMO JOOHHAMJDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1B20550", Offset = "0x1B1EF50", VA = "0x181B20550", Slot = "14")]
		public GEEJJFIMDNA LAPAEIOAHGC(GEEJJFIMDNA BJLPLHMBBOJ, int NCHOALDJOIN)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x2453F30", Offset = "0x2452930", VA = "0x182453F30", Slot = "15")]
		public Color OCDFBOLEBKL(GEEJJFIMDNA BJLPLHMBBOJ, int NCHOALDJOIN)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AE60", Offset = "0x3E89860", VA = "0x183E8AE60", Slot = "16")]
		public float3 NMILCKAPAIC(GEEJJFIMDNA BJLPLHMBBOJ, int NCHOALDJOIN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AAF0", Offset = "0x3E894F0", VA = "0x183E8AAF0", Slot = "17")]
		public bool MCFELAOHIHF(GEEJJFIMDNA BJLPLHMBBOJ, GEEJJFIMDNA OKGJDJPHJBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x3E89F20", Offset = "0x3E88920", VA = "0x183E89F20", Slot = "18")]
		public GEEJJFIMDNA GDFOLIGGKHP(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A100", Offset = "0x3E88B00", VA = "0x183E8A100", Slot = "21")]
		public void HKCGANAILLK(GEEJJFIMDNA BJLPLHMBBOJ, Vector3 GGFLEJDEFLC, Quaternion MCIDGFMPGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x3E8ABA0", Offset = "0x3E895A0", VA = "0x183E8ABA0", Slot = "23")]
		public float3 MEBDLAKJIFM(FKIMAECOPJA EPEKIJLJAIG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A070", Offset = "0x3E88A70", VA = "0x183E8A070", Slot = "24")]
		public quaternion HEBLFMFHBOG(FKIMAECOPJA EPEKIJLJAIG)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x3E89790", Offset = "0x3E88190", VA = "0x183E89790", Slot = "28")]
		public RigidTransform BEEJJKNGKGL(FKIMAECOPJA EPEKIJLJAIG)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x3E89B70", Offset = "0x3E88570", VA = "0x183E89B70", Slot = "22")]
		public bool FAHBJDBGOFK(GEEJJFIMDNA BJLPLHMBBOJ, out RigidTransform NGDDBGILABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x3E89890", Offset = "0x3E88290", VA = "0x183E89890", Slot = "19")]
		[IteratorStateMachine(typeof(MBOMECBJGAN))]
		public IEnumerable<GEEJJFIMDNA> BNGHHOOPJFE(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B160", Offset = "0x3E89B60", VA = "0x183E8B160", Slot = "20")]
		public GEEJJFIMDNA OEAIEOIBBDO(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x3E89D50", Offset = "0x3E88750", VA = "0x183E89D50", Slot = "29")]
		public void GCNMOKFOJAP(ref List<GEEJJFIMDNA> LAPGMJGKFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B040", Offset = "0x3E89A40", VA = "0x183E8B040")]
		private Entity OEAIEOIBBDO(Entity OOGAMDNOHNH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B600", Offset = "0x3E8A000", VA = "0x183E8B600")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Prefabs)]
	[LHOECCIDBFM(typeof(ObjectInstantiationService), new string[] { })]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	internal sealed class ObjectInstantiationService : HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM ENGIGCMGHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[JLCJNHHCBDK]
		private CDLKGHKEIBO DPOHPMOILCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[JLCJNHHCBDK]
		private COGEAAMAACK NCHJBGKCGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[JLCJNHHCBDK]
		private ObjectNetworkToLocalMapService ALLIEBFHEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[JLCJNHHCBDK]
		private ObjectLifecycleService PADNNEGLENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[JLCJNHHCBDK]
		private ObjectPrefabs DKNCGBIHPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[JLCJNHHCBDK]
		private ELIMEPABHMM CAPDOAMLJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private INPDPGIAJAM AFLONPELFOL;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int NLHDBCCOJPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8360", Offset = "0x3DE6D60", VA = "0x183DE8360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x3DE84C0", Offset = "0x3DE6EC0", VA = "0x183DE84C0", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x3DE84A0", Offset = "0x3DE6EA0", VA = "0x183DE84A0")]
		public Entity LPBHBECHMDM(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x3DE83B0", Offset = "0x3DE6DB0", VA = "0x183DE83B0")]
		public Entity LGBJNNJPIFB(ANIMKGBLAIA BBILPABEHHM, IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x3DE82B0", Offset = "0x3DE6CB0", VA = "0x183DE82B0")]
		public Entity LKMKADFFOOH(IMJFJJBFBGO FPPOGBDGFJM, bool JADIDGGBPCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8150", Offset = "0x3DE6B50", VA = "0x183DE8150")]
		public Entity LKMKADFFOOH(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x3DE86A0", Offset = "0x3DE70A0", VA = "0x183DE86A0")]
		public Entity NLMJGLMLMIP()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8410", Offset = "0x3DE6E10", VA = "0x183DE8410")]
		public Entity LOJJJPGLHCF(BFFEGPGDBEI EMKINACMDLO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x3DE80C0", Offset = "0x3DE6AC0", VA = "0x183DE80C0")]
		public Entity CLLCDGNKMBE(MPCFEHACDMF EMKINACMDLO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x3DE85F0", Offset = "0x3DE6FF0", VA = "0x183DE85F0")]
		public NativeArray<(GEEJJFIMDNA, GEEJJFIMDNA)> NBNDBJHEGMK(NativeArray<GEEJJFIMDNA> LFONLDBPOBG, Allocator APPJGCOGPBM)
		{
			return default(NativeArray<(GEEJJFIMDNA, GEEJJFIMDNA)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE86E0", Offset = "0x3DE70E0", VA = "0x183DE86E0")]
		public IEnumerable<IMJFJJBFBGO> OMLIFGHPCMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8640", Offset = "0x3DE7040", VA = "0x183DE8640")]
		public EntityArchetype NKPFALIELHN(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8300", Offset = "0x3DE6D00", VA = "0x183DE8300")]
		public Entity DHMEFIBLKGC(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8150", Offset = "0x3DE6B50", VA = "0x183DE8150")]
		private Entity DCBIFFACEGB(IMJFJJBFBGO FPPOGBDGFJM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE82B0", Offset = "0x3DE6CB0", VA = "0x183DE82B0")]
		private Entity DCBIFFACEGB(IMJFJJBFBGO FPPOGBDGFJM, bool JADIDGGBPCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8190", Offset = "0x3DE6B90", VA = "0x183DE8190")]
		private Entity DCBIFFACEGB(IMJFJJBFBGO FPPOGBDGFJM, ANIMKGBLAIA BBILPABEHHM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[LHOECCIDBFM(typeof(PGLCALCJHHL), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public sealed class PhysicsSceneColliderService : PGLCALCJHHL, EIEOECFHECJ, NMGDKBIHJIB, HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string PBEBMOOMMDF = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int AMGEJOJCAIO = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int NHNBIDJIGPO = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[JLCJNHHCBDK]
		private CPIGIOMNEPF BAOOFNPBDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] JOOABOLONBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] AIKLEKOCPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::DDHALPPBFJD<EHCADCKGLFN, BoxCollider> IFFPBNEBNCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene OPCKNOAJELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene CJALLGLNCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject INOMEBNKFPO;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int IDCPHBKDBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x3DF7030", Offset = "0x3DF5A30", VA = "0x183DF7030", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x3DF65C0", Offset = "0x3DF4FC0", VA = "0x183DF65C0", Slot = "9")]
		public void FECFGPJJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7070", Offset = "0x3DF5A70", VA = "0x183DF7070", Slot = "10")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6470", Offset = "0x3DF4E70", VA = "0x183DF6470", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x3DF62E0", Offset = "0x3DF4CE0", VA = "0x183DF62E0", Slot = "4")]
		public EHCADCKGLFN CLMNAEHEDGI(Entity OOGAMDNOHNH)
		{
			return default(EHCADCKGLFN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6050", Offset = "0x3DF4A50", VA = "0x183DF6050", Slot = "5")]
		public void BJFHHFFGHAE(NativeArray<EHCADCKGLFN> IMKAAFPDJPJ, NativeArray<PKKHHCLHNOE> FPIHAEEIAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6DA0", Offset = "0x3DF57A0", VA = "0x183DF6DA0", Slot = "6")]
		public void JHGMDFELMNG(EHCADCKGLFN DFKGNJHDLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6F90", Offset = "0x3DF5990", VA = "0x183DF6F90", Slot = "7")]
		public bool KFDKOGIHKPC(EHCADCKGLFN DFKGNJHDLAL, out Collider JFHMOLIAPLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6770", Offset = "0x3DF5170", VA = "0x183DF6770")]
		public bool HGEIEIBAKPJ(in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, float AGKAIFMKLLP, Allocator APPJGCOGPBM, out NativeArray<Entity> AJMHFNCBOJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6570", Offset = "0x3DF4F70", VA = "0x183DF6570")]
		private void EMHOEJNJOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x8818D0", Offset = "0x8802D0", VA = "0x1808818D0")]
		private void EJHDGGGOOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7130", Offset = "0x3DF5B30", VA = "0x183DF7130")]
		private void NBBFKOILNID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x12ED1C0", Offset = "0x12EBBC0", VA = "0x1812ED1C0")]
		private void MBBPIHPCACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6E70", Offset = "0x3DF5870", VA = "0x183DF6E70")]
		private BoxCollider JIEALFGMGKK(Entity OOGAMDNOHNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6260", Offset = "0x3DF4C60", VA = "0x183DF6260")]
		private void CGCBDNIKOAD(BoxCollider LNGNOOOLJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6730", Offset = "0x3DF5130", VA = "0x183DF6730")]
		[Conditional("UNITY_EDITOR")]
		private void GLBHOJAAKDK(GameObject OJBDJCCAFCN, Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7180", Offset = "0x3DF5B80", VA = "0x183DF7180")]
		private void NDGKGEHMLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6A80", Offset = "0x3DF5480", VA = "0x183DF6A80")]
		private void IKODKBJEGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6B90", Offset = "0x3DF5590", VA = "0x183DF6B90")]
		private void JFMLELCBNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6020", Offset = "0x3DF4A20", VA = "0x183DF6020")]
		private void ANMDLDAFHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6000", Offset = "0x3DF4A00", VA = "0x183DF6000")]
		private void AGFLNOGHANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6430", Offset = "0x3DF4E30", VA = "0x183DF6430")]
		private void DCIAKBAGOBI(Scene FHLIEIJOCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6010", Offset = "0x3DF4A10", VA = "0x183DF6010", Slot = "8")]
		private bool AKPMJNNICJE(in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, float AGKAIFMKLLP, Allocator APPJGCOGPBM, out NativeArray<Entity> AJMHFNCBOJK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[LHOECCIDBFM(typeof(KBIBABDHAJN), new string[] { })]
public sealed class CMGEMHOJNFG : KBIBABDHAJN, HNADMPPHDEF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct BDGLLMAFJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float OBKODMBMJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint BIFJNDBGKPI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private EIEOECFHECJ EHIHBGNADKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private EPBMJPPFLEA ADOEFMPEHGN;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x3E83C80", Offset = "0x3E82680", VA = "0x183E83C80", Slot = "5")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x3E837F0", Offset = "0x3E821F0", VA = "0x183E837F0")]
	public bool HGEIEIBAKPJ(in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, float AGKAIFMKLLP, out MCPIANOHONP JNIKFJBCLEM, out Entity IPIMKKJOKIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x3E83CF0", Offset = "0x3E826F0", VA = "0x183E83CF0")]
	public static bool PADFAEPJEGK(in Span<MCPIANOHONP> MOBOGDIECOJ, float AGKAIFMKLLP, out int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x3E837C0", Offset = "0x3E821C0", VA = "0x183E837C0")]
	public static float EOHPLEDGIOP(float OBKODMBMJDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public CMGEMHOJNFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x3E83C70", Offset = "0x3E82670", VA = "0x183E83C70", Slot = "4")]
	private bool JMDJKEFGFHI(in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, float AGKAIFMKLLP, out MCPIANOHONP JNIKFJBCLEM, out Entity IPIMKKJOKIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[LHOECCIDBFM(typeof(EPBMJPPFLEA), new string[] { })]
public sealed class PJMJDFJNPFO : EPBMJPPFLEA, HNADMPPHDEF
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct LNOFAOBDNPE : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> AJMHFNCBOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 DNIMAHCLACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 EMGHPODOIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> ODPAOOGINBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> CDAJCEBDJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> MMBEEJPNOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> CNDEKBFBALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> MGFODKKPOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<MCPIANOHONP> NENCOPMIAJM;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly MCPIANOHONP JFNNIMPOPHE;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x47C77C0", Offset = "0x47C61C0", VA = "0x1847C77C0", Slot = "4")]
		public void Execute(int ALJOMNDNEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x47C8490", Offset = "0x47C6E90", VA = "0x1847C8490")]
		private static float3 IHOKNDBFPKJ(in float4x4 CEIBJGPKCNI, in float3 KAONFFKIECC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x47C72B0", Offset = "0x47C5CB0", VA = "0x1847C72B0")]
		private static float3 ANIIMNMAGJM(in float4x4 CEIBJGPKCNI, in float3 EAOEDNDMMKN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x47C7CC0", Offset = "0x47C66C0", VA = "0x1847C7CC0")]
		private static float3 GPODCDJMBNH(in float4x4 CEIBJGPKCNI, in float3 KAONFFKIECC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x47C7AA0", Offset = "0x47C64A0", VA = "0x1847C7AA0")]
		private static float3 GGOAKDKKEDA(in float4x4 CEIBJGPKCNI, in float3 EAOEDNDMMKN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x47C7470", Offset = "0x47C5E70", VA = "0x1847C7470")]
		private bool EGACDANHEMO(in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, in NativeArray<Entity> DAEKJPLFIGD, out float3 JNIKFJBCLEM, out float3 DGILHLOCJDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x47C7DC0", Offset = "0x47C67C0", VA = "0x1847C7DC0")]
		public static bool ICBICFEGHHD(in float3 HNJKMIJIPBB, in float3 DDCLOOBAOJJ, in float3 OFEIIOBDCHK, in float3 JEPJEHJCKDE, float LLICNLGFBOA, float LGLHNOLCGAC, out float ENLKJOJFGLO, out float3 DPNLIGMIFFI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager IMCLABBJAOB;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3DD0", Offset = "0x3DF27D0", VA = "0x183DF3DD0", Slot = "5")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x3DF38F0", Offset = "0x3DF22F0", VA = "0x183DF38F0")]
	public void HGEIEIBAKPJ(in NativeArray<Entity> AJMHFNCBOJK, in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, in NativeArray<MCPIANOHONP> KAOIDOCIPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public PJMJDFJNPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x3DF38E0", Offset = "0x3DF22E0", VA = "0x183DF38E0", Slot = "4")]
	private void FMKCKEMENJO(in NativeArray<Entity> AJMHFNCBOJK, in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, in NativeArray<MCPIANOHONP> KAOIDOCIPLE)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Embodiment)]
	[POJCHFKPLOJ(PFPBFPDNLIO.OMRoom)]
	[LHOECCIDBFM(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[JLCJNHHCBDK]
		private BJJPOMIINDM HFELLKINAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[JLCJNHHCBDK]
		private CDLKGHKEIBO HHLHFOOLCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[JLCJNHHCBDK]
		private COGEAAMAACK MPPKFFHHAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private HLNKJMLPBIB BMDIGEODPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<ANIMKGBLAIA, Entity> FEKAOIMDDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager IMCLABBJAOB;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<ANIMKGBLAIA, Entity> IFGNLJKPHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x84E040", Offset = "0x84CA40", VA = "0x18084E040")]
			get
			{
				return default(NativeHashMap<ANIMKGBLAIA, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint LGNKBDNEPNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBB20", Offset = "0x3DEA520", VA = "0x183DEBB20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool FKIMOIOBPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x899750", Offset = "0x898150", VA = "0x180899750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0x899C40", Offset = "0x898640", VA = "0x180899C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBA00", Offset = "0x3DEA400", VA = "0x183DEBA00", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB5C0", Offset = "0x3DE9FC0", VA = "0x183DEB5C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBC30", Offset = "0x3DEA630", VA = "0x183DEBC30")]
		public void PDOAHDCGLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB7B0", Offset = "0x3DEA1B0", VA = "0x183DEB7B0")]
		public void JFJECKOCOCL(ANIMKGBLAIA BBILPABEHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB970", Offset = "0x3DEA370", VA = "0x183DEB970")]
		private GEEJJFIMDNA KJMJGGKIKPB(Entity OOGAMDNOHNH)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBB50", Offset = "0x3DEA550", VA = "0x183DEBB50")]
		public GEEJJFIMDNA ONPEFMCCMDC(ANIMKGBLAIA BBILPABEHHM)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB720", Offset = "0x3DEA120", VA = "0x183DEB720")]
		public ANIMKGBLAIA GNIDCGFLOEL(GEEJJFIMDNA BJLPLHMBBOJ)
		{
			return default(ANIMKGBLAIA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB630", Offset = "0x3DEA030", VA = "0x183DEB630")]
		public void EHNCPNJGLKF(Entity OOGAMDNOHNH, ANIMKGBLAIA BBILPABEHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB6C0", Offset = "0x3DEA0C0", VA = "0x183DEB6C0")]
		public void GCGGOCDAHCC(Entity OOGAMDNOHNH, ANIMKGBLAIA BBILPABEHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB9A0", Offset = "0x3DEA3A0", VA = "0x183DEB9A0")]
		public void MFOGHIJKJOE(Entity OOGAMDNOHNH, ANIMKGBLAIA BBILPABEHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB4F0", Offset = "0x3DE9EF0", VA = "0x183DEB4F0")]
		public void CHECJEMINEH(Entity OOGAMDNOHNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
	[LHOECCIDBFM(typeof(PropertyEventCallbacksService), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Callbacks)]
	public class PropertyEventCallbacksService : HNADMPPHDEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct KOINMOEIOFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public LBKBFPHMFPL KFICNKMCGGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type EMKINACMDLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int IMMPKDAEONJ;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct CCNAHOGNBIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public KOINMOEIOFK[] PILEKMCPEGL;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void LBKBFPHMFPL(Entity OOGAMDNOHNH, KOPBFNLIDKA OAOKPGOEMMH, ABKAKFBNEMO GFPNEMALIHE, ABKAKFBNEMO JOOHHAMJDLM);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<KOPBFNLIDKA, LBKBFPHMFPL> JDJGEKOCHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, CCNAHOGNBIB> HELPEELMILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private IALPALJEAJO PILEKMCPEGL;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action JCBHBEFLNDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDC20", Offset = "0x3DFC620", VA = "0x183DFDC20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDCC0", Offset = "0x3DFC6C0", VA = "0x183DFDCC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action PNKJNBADGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDB80", Offset = "0x3DFC580", VA = "0x183DFDB80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDEA0", Offset = "0x3DFC8A0", VA = "0x183DFDEA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDE50", Offset = "0x3DFC850", VA = "0x183DFDE50", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCF20", Offset = "0x3DFB920", VA = "0x183DFCF20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCCC0", Offset = "0x3DFB6C0", VA = "0x183DFCCC0")]
		public void AIDBCCOFMIA(KOPBFNLIDKA OAOKPGOEMMH, LBKBFPHMFPL KFICNKMCGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDD60", Offset = "0x3DFC760", VA = "0x183DFDD60")]
		public void MJBHNMADCHO(KOPBFNLIDKA OAOKPGOEMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD230", Offset = "0x3DFBC30", VA = "0x183DFD230")]
		internal void GBLMOPILLCK(PGHENGEHMNP GFHEAAHHEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD640", Offset = "0x3DFC040", VA = "0x183DFD640")]
		private void IGAGKBDPMJO(PGHENGEHMNP GFHEAAHHEHC, int CKHJBBKEJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCFB0", Offset = "0x3DFB9B0", VA = "0x183DFCFB0")]
		private void FKJOFCFMOCH(HMBIKFADCFA LHICEFGLEJC, JPCNDAPLHKB PIOPBEIBJFA, KOINMOEIOFK MMAGKKNJDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD4C0", Offset = "0x3DFBEC0", VA = "0x183DFD4C0")]
		private CCNAHOGNBIB HLMCPIIJEOJ(HMBIKFADCFA LHICEFGLEJC, JPCNDAPLHKB PIOPBEIBJFA)
		{
			return default(CCNAHOGNBIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCE30", Offset = "0x3DFB830", VA = "0x183DFCE30")]
		private KOINMOEIOFK BAKLDMAKJEC(CCNAHOGNBIB HFKBPOPIAIF, HMBIKFADCFA LHICEFGLEJC, JPCNDAPLHKB PIOPBEIBJFA)
		{
			return default(KOINMOEIOFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDF90", Offset = "0x3DFC990", VA = "0x183DFDF90")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[LHOECCIDBFM(typeof(FLBHDHBFMJK), new string[] { })]
public class LAJJNHMGAAK : HNADMPPHDEF, BCGODABHHDD, FLBHDHBFMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class CPCONFMGNEC : IEnumerable<GEEJJFIMDNA>, IEnumerable, IEnumerator<GEEJJFIMDNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private GEEJJFIMDNA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public LAJJNHMGAAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private GEEJJFIMDNA splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public GEEJJFIMDNA <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private GEEJJFIMDNA System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GEEJJFIMDNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x47C0B40", Offset = "0x47BF540", VA = "0x1847C0B40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x95A0C0", Offset = "0x958AC0", VA = "0x18095A0C0")]
		[DebuggerHidden]
		public CPCONFMGNEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x47C0990", Offset = "0x47BF390", VA = "0x1847C0990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x47C0B00", Offset = "0x47BF500", VA = "0x1847C0B00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x47C0A50", Offset = "0x47BF450", VA = "0x1847C0A50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GEEJJFIMDNA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x47C0A50", Offset = "0x47BF450", VA = "0x1847C0A50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private HLNKJMLPBIB BMDIGEODPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private GIAEFGMJPFB NNGOIOBHGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService DKNCGBIHPEI;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager GMCADEOGFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x41D4370", Offset = "0x41D2D70", VA = "0x1841D4370")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private PJIOIOLLAAE CMOPJKDIAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x41D4180", Offset = "0x41D2B80", VA = "0x1841D4180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x41D4D90", Offset = "0x41D3790", VA = "0x1841D4D90", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x41D4990", Offset = "0x41D3390", VA = "0x1841D4990", Slot = "5")]
	public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x41D4480", Offset = "0x41D2E80", VA = "0x1841D4480", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x41D4620", Offset = "0x41D3020", VA = "0x1841D4620")]
	private void GGJOEODLKMN(Entity CPFDKFMMAOK, in ABKAKFBNEMO AMNGHBPOOHL, in ABKAKFBNEMO LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x41D4FD0", Offset = "0x41D39D0", VA = "0x1841D4FD0", Slot = "14")]
	public GEEJJFIMDNA NLMJGLMLMIP()
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x41D4530", Offset = "0x41D2F30", VA = "0x1841D4530", Slot = "10")]
	public void GFDGOJMBOMO(GEEJJFIMDNA BJLPLHMBBOJ, NCCBOCJKPDI PJBJFAJEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x41D4EE0", Offset = "0x41D38E0", VA = "0x1841D4EE0", Slot = "9")]
	public NCCBOCJKPDI NECAHLHMKMJ(GEEJJFIMDNA BJLPLHMBBOJ)
	{
		return default(NCCBOCJKPDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x41D5030", Offset = "0x41D3A30", VA = "0x1841D5030", Slot = "11")]
	public GEEJJFIMDNA PLGJHMAOHLI(GEEJJFIMDNA BBNCDKBJCLG, [Optional] Vector3? LHCEFCJDGIJ, [Optional] Quaternion? FDBNIAOOEMB, [Optional] Vector3? EADEBIPFPFD)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x41D4D50", Offset = "0x41D3750", VA = "0x1841D4D50", Slot = "15")]
	public GEEJJFIMDNA LEOMLMMJIJJ(GEEJJFIMDNA NGIOHIIDDGP, int ALJOMNDNEBM, [Optional] Vector3? LHCEFCJDGIJ, [Optional] Quaternion? FDBNIAOOEMB, [Optional] Vector3? EADEBIPFPFD)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x41D48A0", Offset = "0x41D32A0", VA = "0x1841D48A0", Slot = "7")]
	public GEEJJFIMDNA HEBEEIOADBO(GEEJJFIMDNA NGIOHIIDDGP, int ALJOMNDNEBM)
	{
		return default(GEEJJFIMDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x41D43C0", Offset = "0x41D2DC0", VA = "0x1841D43C0", Slot = "16")]
	public void CJDILOHCANE(GEEJJFIMDNA NGIOHIIDDGP, GEEJJFIMDNA ELPGBLPAGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x41D4A90", Offset = "0x41D3490", VA = "0x1841D4A90", Slot = "12")]
	public void KEAIFELFOOE(GEEJJFIMDNA NGIOHIIDDGP, int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x41D41D0", Offset = "0x41D2BD0", VA = "0x1841D41D0", Slot = "17")]
	public void CCACKMKFMBB(GEEJJFIMDNA NGIOHIIDDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x41D40E0", Offset = "0x41D2AE0", VA = "0x1841D40E0", Slot = "8")]
	public int AGHDNGKOCCO(GEEJJFIMDNA NGIOHIIDDGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x41D4C30", Offset = "0x41D3630", VA = "0x1841D4C30", Slot = "6")]
	[IteratorStateMachine(typeof(CPCONFMGNEC))]
	public IEnumerable<GEEJJFIMDNA> LANFBGPEEEK(GEEJJFIMDNA NGIOHIIDDGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x41D4CC0", Offset = "0x41D36C0", VA = "0x1841D4CC0")]
	private bool LDEMJIKMOBI(GEEJJFIMDNA NGIOHIIDDGP, out NativeArray<Entity> GFIGBAPMFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x41D4E20", Offset = "0x41D3820", VA = "0x1841D4E20")]
	private NativeArray<Entity> MMGOLMONIMO(GEEJJFIMDNA NGIOHIIDDGP)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public LAJJNHMGAAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[POJCHFKPLOJ(PFPBFPDNLIO.LoadInstance)]
[LHOECCIDBFM(typeof(LFKALHOJJHM), new string[] { })]
internal sealed class LFKALHOJJHM : HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private BJJPOMIINDM ENGIGCMGHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase NIBJDNICPFE;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private BKKHAMMBGFF FPKDMGAMAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC920", Offset = "0x3DDB320", VA = "0x183DDC920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC8A0", Offset = "0x3DDB2A0", VA = "0x183DDC8A0", Slot = "4")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC7B0", Offset = "0x3DDB1B0", VA = "0x183DDC7B0")]
	public void LFFJFFBEJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC4E0", Offset = "0x3DDAEE0", VA = "0x183DDC4E0")]
	public void DMGCPLAPECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public LFKALHOJJHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct BKOHFEAELHP : IEquatable<BKOHFEAELHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int CKHJBBKEJPM;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type EFFMKCNPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CB00", Offset = "0x3E7B500", VA = "0x183E7CB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CBE0", Offset = "0x3E7B5E0", VA = "0x183E7CBE0")]
	public BKOHFEAELHP(Type EMKINACMDLO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C9D0", Offset = "0x3E7B3D0", VA = "0x183E7C9D0")]
	public static BKOHFEAELHP EHMKDPHHPBI(Type EMKINACMDLO)
	{
		return default(BKOHFEAELHP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CA30", Offset = "0x3E7B430", VA = "0x183E7CA30")]
	public static Type EHMKDPHHPBI(BKOHFEAELHP DFKGNJHDLAL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x95B8C0", Offset = "0x95A2C0", VA = "0x18095B8C0")]
	public static bool ENMIHMCKBEN(BKOHFEAELHP MGFKDMJBGAK, BKOHFEAELHP LPDJCHOFJLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x95B8C0", Offset = "0x95A2C0", VA = "0x18095B8C0")]
	public static bool IDBOJBLCJLG(BKOHFEAELHP MGFKDMJBGAK, BKOHFEAELHP LPDJCHOFJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x95B480", Offset = "0x959E80", VA = "0x18095B480", Slot = "4")]
	public bool Equals(BKOHFEAELHP EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CA80", Offset = "0x3E7B480", VA = "0x183E7CA80", Slot = "0")]
	public override bool Equals(object OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CB60", Offset = "0x3E7B560", VA = "0x183E7CB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class ICCJGDBOJME
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> MDFCOJOPECK;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> FDIJEEOJJLN;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x41C90A0", Offset = "0x41C7AA0", VA = "0x1841C90A0")]
	static ICCJGDBOJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x3243DC0", Offset = "0x32427C0", VA = "0x183243DC0")]
	public static bool IFPOOIAJHAI<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x41C8E70", Offset = "0x41C7870", VA = "0x1841C8E70")]
	public static bool IFPOOIAJHAI(Type EMKINACMDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x41C8D00", Offset = "0x41C7700", VA = "0x1841C8D00")]
	private static bool IFPOOIAJHAI(Type EMKINACMDLO, out int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x3243D30", Offset = "0x3242730", VA = "0x183243D30")]
	public static int BFOGGBOBEAH<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x41C8C90", Offset = "0x41C7690", VA = "0x1841C8C90")]
	public static int BFOGGBOBEAH(Type EMKINACMDLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x3243E50", Offset = "0x3242850", VA = "0x183243E50")]
	public static bool MDMJPHIOICO<T>(out int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x41C8EE0", Offset = "0x41C78E0", VA = "0x1841C8EE0")]
	public static bool MDMJPHIOICO(Type EMKINACMDLO, out int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x41C8BF0", Offset = "0x41C75F0", VA = "0x1841C8BF0")]
	public static Type ABMJNALEGDK(int ALJOMNDNEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x41C8F80", Offset = "0x41C7980", VA = "0x1841C8F80")]
	public static bool MDMJPHIOICO(int ALJOMNDNEBM, out Type EMKINACMDLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct DAAJBNBHADE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] MNILNHMNKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int GIDABKFIKCN;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int ANNFCHOJNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x737300", Offset = "0x735D00", VA = "0x180737300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x30DE170", Offset = "0x30DCB70", VA = "0x1830DE170")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> LLGFONCKIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x4358700", Offset = "0x4357100", VA = "0x184358700")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool DBBBFNFEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0xC611F0", Offset = "0xC5FBF0", VA = "0x180C611F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x43587A0", Offset = "0x43571A0", VA = "0x1843587A0")]
	public DAAJBNBHADE(int GIDABKFIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x4358650", Offset = "0x4357050", VA = "0x184358650")]
	public int LODPMCNLMAH(T MFBGAMJDOKA, int ONAOKOFPGLK, int HGMGPFAJPJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x4358590", Offset = "0x4356F90", VA = "0x184358590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct MLAOIFPAANE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::DAAJBNBHADE<T> MNILNHMNKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int GIDABKFIKCN;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3670", Offset = "0x3AE2070", VA = "0x183AE3670")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int ANNFCHOJNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4050", Offset = "0x3AE2A50", VA = "0x183AE4050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int OAFOLGMAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x3AE46B0", Offset = "0x3AE30B0", VA = "0x183AE46B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x3AE31B0", Offset = "0x3AE1BB0", VA = "0x183AE31B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool DBBBFNFEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3E80", Offset = "0x3AE2880", VA = "0x183AE3E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> LLGFONCKIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4130", Offset = "0x3AE2B30", VA = "0x183AE4130")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x3AE4A90", Offset = "0x3AE3490", VA = "0x183AE4A90")]
	public MLAOIFPAANE(int GIDABKFIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3EC0", Offset = "0x3AE28C0", VA = "0x183AE3EC0")]
	public T IHPJFBHEGHA(int ALJOMNDNEBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3420", Offset = "0x3AE1E20", VA = "0x183AE3420")]
	public void DLMICIHNBDB(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x3AE4280", Offset = "0x3AE2C80", VA = "0x183AE4280")]
	public void MPPPJMANKFA(Span<T> ECNPNAMGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3D70", Offset = "0x3AE2770", VA = "0x183AE3D70")]
	public void IFPOOIAJHAI(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x3AE43F0", Offset = "0x3AE2DF0", VA = "0x183AE43F0")]
	private void NDBNMOMBFBP(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x3AE37C0", Offset = "0x3AE21C0", VA = "0x183AE37C0")]
	public void GDFLELNAEGM(Span<T> KNIJIHCLOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3610", Offset = "0x3AE2010", VA = "0x183AE3610")]
	public void FCBCAONOLNP(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3200", Offset = "0x3AE1C00", VA = "0x183AE3200")]
	public void DIEBINIFPEB(int BDACPGDMPPJ, int PCPMBKDCIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3150", Offset = "0x3AE1B50", VA = "0x183AE3150")]
	public void BLHADIBIAOF(int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3B60", Offset = "0x3AE2560", VA = "0x183AE3B60")]
	public void HMHADINNIJG(int BDACPGDMPPJ, int PCPMBKDCIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3700", Offset = "0x3AE2100", VA = "0x183AE3700")]
	public void FLAMKIOJLIC(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3550", Offset = "0x3AE1F50", VA = "0x183AE3550")]
	public void EPJJCJKFACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x3AE40A0", Offset = "0x3AE2AA0", VA = "0x183AE40A0")]
	public int LODPMCNLMAH(T MFBGAMJDOKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x3AE30F0", Offset = "0x3AE1AF0", VA = "0x183AE30F0")]
	public bool AAFBPIPDPOL(T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3490", Offset = "0x3AE1E90", VA = "0x183AE3490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x3AE4A20", Offset = "0x3AE3420", VA = "0x183AE4A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x3AE34E0", Offset = "0x3AE1EE0", VA = "0x183AE34E0")]
	public static Span<T> EHMKDPHHPBI(global::MLAOIFPAANE<T> ECNPNAMGIHB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x3AE4570", Offset = "0x3AE2F70", VA = "0x183AE4570")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NNMIKNLHMKE(int MFBGAMJDOKA, int GIDABKFIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void GODPIDMFLCA(int GIDABKFIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3A00", Offset = "0x3AE2400", VA = "0x183AE3A00")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GODPIDMFLCA(int GIDABKFIKCN, int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x3AE48E0", Offset = "0x3AE32E0", VA = "0x183AE48E0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void PKFOHFOHABH(int MFBGAMJDOKA, int GIDABKFIKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE46E0", Offset = "0x3AE30E0", VA = "0x183AE46E0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void PHFJLHFDHEB(int BDACPGDMPPJ, int PCPMBKDCIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3F10", Offset = "0x3AE2910", VA = "0x183AE3F10")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void IPEEIAGAIMB(int MFBGAMJDOKA, int GIDABKFIKCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct OIAINGCNGGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int PJKILEDFIKJ = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> AJMHFNCBOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray FBHAGLEGMDE;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3700", Offset = "0x3DE2100", VA = "0x183DE3700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> MAKAIHOBKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0x883600", Offset = "0x882000", VA = "0x180883600")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray AFCKIPBNAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool FKIMOIOBPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3710", Offset = "0x3DE2110", VA = "0x183DE3710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE39F0", Offset = "0x3DE23F0", VA = "0x183DE39F0")]
	public OIAINGCNGGF(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3890", Offset = "0x3DE2290", VA = "0x183DE3890")]
	public Entity GNCKMACHKHP(int ALJOMNDNEBM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3880", Offset = "0x3DE2280", VA = "0x183DE3880")]
	public Transform GEEMINMGLOA(int ALJOMNDNEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3730", Offset = "0x3DE2130", VA = "0x183DE3730")]
	public void BMHKPFJKODB(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3920", Offset = "0x3DE2320", VA = "0x183DE3920")]
	public int IFPOOIAJHAI(Transform DBMMOFPNJHL, Entity OOGAMDNOHNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3800", Offset = "0x3DE2200", VA = "0x183DE3800")]
	public int FCBCAONOLNP(int ALJOMNDNEBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3780", Offset = "0x3DE2180", VA = "0x183DE3780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x3DE38E0", Offset = "0x3DE22E0", VA = "0x183DE38E0")]
	private void HHPEPPPLJHD(int JHMIBCAPGFD = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class DHOJJOFFBAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<BKOHFEAELHP, int2> CHBOHAGJMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> CKDPLHPNFKM;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x3E90290", Offset = "0x3E8EC90", VA = "0x183E90290")]
	public DHOJJOFFBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x3E90230", Offset = "0x3E8EC30", VA = "0x183E90230")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void CKIEIOOCMAM<T>(T MFBGAMJDOKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T ABMJNALEGDK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x3E8FD40", Offset = "0x3E8E740", VA = "0x183E8FD40")]
	public void CKIEIOOCMAM(Type EMKINACMDLO, ABKAKFBNEMO MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x3E8FAB0", Offset = "0x3E8E4B0", VA = "0x183E8FAB0")]
	public ABKAKFBNEMO ABMJNALEGDK(Type EMKINACMDLO)
	{
		return default(ABKAKFBNEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x3E90190", Offset = "0x3E8EB90", VA = "0x183E90190")]
	private NativeArray<byte> NJHBNHHLFCB(int2 COLHIHLJDJC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x3E8FFD0", Offset = "0x3E8E9D0", VA = "0x183E8FFD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x3E90070", Offset = "0x3E8EA70", VA = "0x183E90070", Slot = "1")]
	~DHOJJOFFBAO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct DLCGCBDHMNF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::DLCGCBDHMNF<T> EHMKDPHHPBI(T MFBGAMJDOKA)
	{
		return default(global::DLCGCBDHMNF<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T EHMKDPHHPBI(global::DLCGCBDHMNF<T> NEHANGBEOBM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class PIPLAPDFFNM
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly DHOJJOFFBAO BFEDKMDMJFN;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3800", Offset = "0x3DF2200", VA = "0x183DF3800")]
	internal static void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void CKIEIOOCMAM<T>(T MFBGAMJDOKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3760", Offset = "0x3DF2160", VA = "0x183DF3760")]
	public static void CKIEIOOCMAM(Type EMKINACMDLO, ABKAKFBNEMO MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T ABMJNALEGDK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x3DF36C0", Offset = "0x3DF20C0", VA = "0x183DF36C0")]
	public static ABKAKFBNEMO ABMJNALEGDK(Type EMKINACMDLO)
	{
		return default(ABKAKFBNEMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class KPHMFJCAPIJ : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly KPHMFJCAPIJ NHIBPFHOELB;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x41D2DB0", Offset = "0x41D17B0", VA = "0x1841D2DB0", Slot = "4")]
	public bool Equals(LinkedEntityGroup KCAHJOFJKBP, LinkedEntityGroup NBBBAMBDAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x41D2DD0", Offset = "0x41D17D0", VA = "0x1841D2DD0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup OMHIFHKMIMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KPHMFJCAPIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class EFFEBFEDKDO
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	public static void PJALGINBCBK(in Vector3 LHCEFCJDGIJ, in Quaternion FDBNIAOOEMB, in Vector3 EADEBIPFPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	public static void GPNLEDBBBGF(in Vector3 MOJKCNCODJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	public static void AFMLDKJJNMC(in Quaternion FDBNIAOOEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	public static void HLJJGCDAGFC(in Vector3 CHBFBAMNMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	public static void HJNHNBNJPFI(in Vector3 CHBFBAMNMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	public static void MDGPHEMDGJJ(in float BDEINNLJOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x3E930A0", Offset = "0x3E91AA0", VA = "0x183E930A0")]
	[Conditional("DEBUG_BUILD")]
	public static void CICDJBDCBDN(in float3 MFBGAMJDOKA, string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	[Conditional("DEBUG_BUILD")]
	public static void EBLKKPDNNOH(in float MFBGAMJDOKA, string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x3E931D0", Offset = "0x3E91BD0", VA = "0x183E931D0")]
	[Conditional("DEBUG_BUILD")]
	public static void EBLKKPDNNOH(in Vector3 MFBGAMJDOKA, string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x3E93220", Offset = "0x3E91C20", VA = "0x183E93220")]
	[Conditional("DEBUG_BUILD")]
	public static void EBLKKPDNNOH(in Quaternion MFBGAMJDOKA, string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x3E93150", Offset = "0x3E91B50", VA = "0x183E93150")]
	[Conditional("DEBUG_BUILD")]
	public static void DDCLCBBIKNN(in float MFBGAMJDOKA, string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x3E93190", Offset = "0x3E91B90", VA = "0x183E93190")]
	[Conditional("DEBUG_BUILD")]
	public static void DDCLCBBIKNN(in Vector3 MFBGAMJDOKA, string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x3E93160", Offset = "0x3E91B60", VA = "0x183E93160")]
	[Conditional("DEBUG_BUILD")]
	public static void DDCLCBBIKNN(in Quaternion MFBGAMJDOKA, string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EFFEBFEDKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct GEJEHFLELMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity OOGAMDNOHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity GEFNMBFCONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity KLJNAJJPMKN;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x41C2D20", Offset = "0x41C1720", VA = "0x1841C2D20")]
	public GEJEHFLELMJ(Entity OOGAMDNOHNH, Entity GEFNMBFCONH, Entity KLJNAJJPMKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x41C2CC0", Offset = "0x41C16C0", VA = "0x1841C2CC0")]
	public static GEJEHFLELMJ EHMKDPHHPBI((Entity entity, Entity oldParent, Entity newParent) COFPDGLMGCB)
	{
		return default(GEJEHFLELMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x41C2D00", Offset = "0x41C1700", VA = "0x1841C2D00")]
	public void NIELGFEEDGF(out Entity OOGAMDNOHNH, out Entity GEFNMBFCONH, out Entity KLJNAJJPMKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct HAGEPIIBIHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity OOGAMDNOHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity EOBFGLJBCIJ;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xC61740", Offset = "0xC60140", VA = "0x180C61740")]
	public HAGEPIIBIHO(Entity OOGAMDNOHNH, Entity EOBFGLJBCIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x41C5490", Offset = "0x41C3E90", VA = "0x1841C5490")]
	public static HAGEPIIBIHO EHMKDPHHPBI((Entity entity, Entity parent) COFPDGLMGCB)
	{
		return default(HAGEPIIBIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x41C54C0", Offset = "0x41C3EC0", VA = "0x1841C54C0")]
	public void NIELGFEEDGF(out Entity OOGAMDNOHNH, out Entity EOBFGLJBCIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct OLBFFGIPFBM<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle DFKGNJHDLAL;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool LLOHFPMCJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x3E77550", Offset = "0x3E75F50", VA = "0x183E77550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0FE0", Offset = "0x3EDF9E0", VA = "0x183EE0FE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x3EE10B0", Offset = "0x3EDFAB0", VA = "0x183EE10B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1170", Offset = "0x3EDFB70", VA = "0x183EE1170")]
	public OLBFFGIPFBM(T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1080", Offset = "0x3EDFA80", VA = "0x183EE1080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum ICCGGKHMCOG
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct AGGAKKNHJCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public ICCGGKHMCOG DNKACKAGOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int BNFGGPMGGAO;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x9480E0", Offset = "0x946AE0", VA = "0x1809480E0")]
	public AGGAKKNHJCN(ICCGGKHMCOG DNKACKAGOGL, int BNFGGPMGGAO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C8A0", Offset = "0x1B4B2A0", VA = "0x181B4C8A0")]
	public static AGGAKKNHJCN EHMKDPHHPBI((ICCGGKHMCOG eventType, int eventIndex) KCAHJOFJKBP)
	{
		return default(AGGAKKNHJCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x3E776C0", Offset = "0x3E760C0", VA = "0x183E776C0")]
	public void NIELGFEEDGF(out ICCGGKHMCOG DNKACKAGOGL, out int BNFGGPMGGAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[LHOECCIDBFM(typeof(EIEOECFHECJ), new string[] { })]
public sealed class BMADBIGOLIB : EIEOECFHECJ, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private PGLCALCJHHL HAJNDDCJMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DA40", Offset = "0x3E7C440", VA = "0x183E7DA40", Slot = "5")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7D9A0", Offset = "0x3E7C3A0", VA = "0x183E7D9A0")]
	public bool HGEIEIBAKPJ(in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, float AGKAIFMKLLP, Allocator APPJGCOGPBM, out NativeArray<Entity> AJMHFNCBOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public BMADBIGOLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7D9A0", Offset = "0x3E7C3A0", VA = "0x183E7D9A0", Slot = "4")]
	private bool AKPMJNNICJE(in float3 OCNOPGJFBCJ, in float3 GNIANLFIOCO, float AGKAIFMKLLP, Allocator APPJGCOGPBM, out NativeArray<Entity> AJMHFNCBOJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[IGKLDKDLNIM]
[UpdateInGroup(typeof(FJHFCANGJLJ))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class KCBPODPIJBP : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x41D1170", Offset = "0x41CFB70", VA = "0x1841D1170", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public KCBPODPIJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[IGKLDKDLNIM]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
[UpdateInGroup(typeof(GCIHEOBMDCE))]
public sealed class HMIAPMCHDGG : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x41C6150", Offset = "0x41C4B50", VA = "0x1841C6150", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public HMIAPMCHDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[IGKLDKDLNIM]
[UpdateInGroup(typeof(BIOCJGPCCDI))]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
internal sealed class MGAMILAPCKN : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF440", Offset = "0x3DDDE40", VA = "0x183DDF440", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public MGAMILAPCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class NOACIFCEPCB : CHOEGOEDAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public NOACIFCEPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[IGKLDKDLNIM]
[ExecuteAlways]
[KLEAGPOIIPF(PFPBFPDNLIO.LoadInstance)]
[UpdateInGroup(typeof(KKPJPIMDEAK))]
internal sealed class AKAMOGIJAEB : EKOAMPPHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x3E77810", Offset = "0x3E76210", VA = "0x183E77810", Slot = "16")]
	protected override ComponentSystemBase KHGOPPHJAIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFB50", Offset = "0x3DDE550", VA = "0x183DDFB50")]
	public AKAMOGIJAEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[FIIJIGCKEPD(typeof(AuthoredLocalPoseData))]
public sealed class BGOEOPDEHEE : PIPODMCMABG
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BCC0", Offset = "0x3E7A6C0", VA = "0x183E7BCC0", Slot = "8")]
	protected override bool EIDBDMHGFME(ReadOnlySpan<AuthoredLocalPoseData> KNIJIHCLOLF, CBHAKBPJLFK DJHHBMBBPIE, out ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BD40", Offset = "0x3E7A740", VA = "0x183E7BD40", Slot = "9")]
	protected override bool EKHCLMLBEGC(int LHIPGOMOMEB, Span<AuthoredLocalPoseData> KNIJIHCLOLF, in ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7BE00", Offset = "0x3E7A800", VA = "0x183E7BE00")]
	public BGOEOPDEHEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[FIIJIGCKEPD(typeof(LocalPoseData))]
public sealed class ABBMJFEBEBM : GENIBFIFPKA
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x3E76AB0", Offset = "0x3E754B0", VA = "0x183E76AB0", Slot = "8")]
	protected override bool EIDBDMHGFME(ReadOnlySpan<LocalPoseData> KNIJIHCLOLF, CBHAKBPJLFK DJHHBMBBPIE, out ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x3E76B30", Offset = "0x3E75530", VA = "0x183E76B30", Slot = "9")]
	protected override bool EKHCLMLBEGC(int LHIPGOMOMEB, Span<LocalPoseData> KNIJIHCLOLF, in ReadOnlySpan<byte> CEMHLJHECJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x3E76BF0", Offset = "0x3E755F0", VA = "0x183E76BF0")]
	public ABBMJFEBEBM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : IAAKGJNKLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A0E0", Offset = "0x3D38AE0", VA = "0x183D3A0E0", Slot = "6")]
		public sealed override void DCGFCAGLEEJ(FOBODKDCELK KFICNKMCGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x3D39610", Offset = "0x3D38010", VA = "0x183D39610", Slot = "4")]
		public sealed override void BGMNFOJPGJK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3050", Offset = "0x3DE1A50", VA = "0x183DE3050")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3160", Offset = "0x3DE1B60", VA = "0x183DE3160")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001ED")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
