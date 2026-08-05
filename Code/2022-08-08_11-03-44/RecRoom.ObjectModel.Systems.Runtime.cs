using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class AFNLMCECKCD<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class KJNGNMNLGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::AFNLMCECKCD<T> HLDDHCMNKKM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] LPKNDHHPDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public KJNGNMNLGBE(global::AFNLMCECKCD<T> HLDDHCMNKKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class AMEJFLIFAKM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::AFNLMCECKCD<T> <>4__this;

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
		public AMEJFLIFAKM(int <>1__state)
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
	private const int BODECOCLDOE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> PDDDOIBMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int MLAICNLEMLJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T AGGGNHPHDIN
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
	private bool IJGLOCIIHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool KANAAEDIAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool JKDHOIIILKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OHMIEBEANAK
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
	public int HJCHDLKJEJK
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
	public AFNLMCECKCD(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public AFNLMCECKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void AEKIKDHBOHP(int IIHEDPBOLFE, T PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void LPJGPILEEAO(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] EMJOBPCJJFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void MNAMHNMLEAM(NativeArray<T> DNAEDFOPGEJ, int JECAFEIBOGA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::AFNLMCECKCD<>.AMEJFLIFAKM))]
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
	public int HDJBEKJPMMO(T PFENDKKONNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool DKCILJPFPEA(T PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void BIOFOFLLAJA(int PACDOBJBGEM, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void ICJLEEECECA(int PACDOBJBGEM, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void NGADBFPCBBE(int PACDOBJBGEM, int KDGOCEAMMLM, int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int OHHHHOHGLLL(int IIHEDPBOLFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T OGFEICMAMKE(int IIHEDPBOLFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void AJLPCAGJDLK(int IIHEDPBOLFE, T PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void IKODCGBAMFE(int IIHEDPBOLFE, T PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void IIEIMJNJBBI(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int MLMPKDPLLLN(int JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int INLPPGFPOJF(int JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void HPCPKIADJDK(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void MKGKDFNPHAH(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T LOKOLNFIBNN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T OMDMJIBOHCF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void MHMJOFGHKON(int IIHEDPBOLFE, IReadOnlyCollection<T> HOJBOBADEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void FEDMNHMMGDM(int IIHEDPBOLFE, int DPGKJLJMFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void GBCPEGCJICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void CIOEMEGLFDC(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void EKCMOBMFBOM(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void PFILIDLDHOE(int KDGOCEAMMLM, int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T CNEACAPJBLB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T NNKJGMFFEHD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DKBGLDDIENF]
public static class GOPMFDMHENH
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x22DC1F0", Offset = "0x22DB1F0", VA = "0x1822DC1F0")]
	static GOPMFDMHENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2F67030", Offset = "0x2F66030", VA = "0x182F67030")]
	public static void GONMIDPMMIB<T>(T LCEEDPEAPOI, ref T JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x22DC040", Offset = "0x22DB040", VA = "0x1822DC040")]
	public static void GONMIDPMMIB(FixedString32 LCEEDPEAPOI, ref string JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x22DC110", Offset = "0x22DB110", VA = "0x1822DC110")]
	public static void GONMIDPMMIB(string LCEEDPEAPOI, ref FixedString32 JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x22DC160", Offset = "0x22DB160", VA = "0x1822DC160")]
	public static void GONMIDPMMIB(FixedString64 LCEEDPEAPOI, ref string JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22DC0A0", Offset = "0x22DB0A0", VA = "0x1822DC0A0")]
	public static void GONMIDPMMIB(string LCEEDPEAPOI, ref FixedString64 JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5940", Offset = "0x1FA4940", VA = "0x181FA5940")]
	public static void GONMIDPMMIB(EKFHNOCHFJI LCEEDPEAPOI, ref Vector3 JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF20", Offset = "0x22DAF20", VA = "0x1822DBF20")]
	public static void GONMIDPMMIB(Vector3 LCEEDPEAPOI, ref EKFHNOCHFJI JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22DC010", Offset = "0x22DB010", VA = "0x1822DC010")]
	public static void GONMIDPMMIB(BCOOPMIPDNP LCEEDPEAPOI, ref Vector4 JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF80", Offset = "0x22DAF80", VA = "0x1822DBF80")]
	public static void GONMIDPMMIB(Vector4 LCEEDPEAPOI, ref BCOOPMIPDNP JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22DC010", Offset = "0x22DB010", VA = "0x1822DC010")]
	public static void GONMIDPMMIB(BCOOPMIPDNP LCEEDPEAPOI, ref Quaternion JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF80", Offset = "0x22DAF80", VA = "0x1822DBF80")]
	public static void GONMIDPMMIB(Quaternion LCEEDPEAPOI, ref BCOOPMIPDNP JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22DBFD0", Offset = "0x22DAFD0", VA = "0x1822DBFD0")]
	public static void GONMIDPMMIB(EKFHNOCHFJI LCEEDPEAPOI, ref float3 JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF20", Offset = "0x22DAF20", VA = "0x1822DBF20")]
	public static void GONMIDPMMIB(float3 LCEEDPEAPOI, ref EKFHNOCHFJI JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF00", Offset = "0x22DAF00", VA = "0x1822DBF00")]
	public static void GONMIDPMMIB(BCOOPMIPDNP LCEEDPEAPOI, ref float4 JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF80", Offset = "0x22DAF80", VA = "0x1822DBF80")]
	public static void GONMIDPMMIB(float4 LCEEDPEAPOI, ref BCOOPMIPDNP JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF00", Offset = "0x22DAF00", VA = "0x1822DBF00")]
	public static void GONMIDPMMIB(BCOOPMIPDNP LCEEDPEAPOI, ref quaternion JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x22DC070", Offset = "0x22DB070", VA = "0x1822DC070")]
	public static void GONMIDPMMIB(quaternion LCEEDPEAPOI, ref BCOOPMIPDNP JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x22DC190", Offset = "0x22DB190", VA = "0x1822DC190")]
	public static void GONMIDPMMIB(Entity LCEEDPEAPOI, ref PLJMPMPCDFO JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x22DC1D0", Offset = "0x22DB1D0", VA = "0x1822DC1D0")]
	public static void GONMIDPMMIB(PLJMPMPCDFO LCEEDPEAPOI, ref Entity JNOBOEIAMPB, HDKJKHCKAFP PEEOAAMJPAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FOLFFNLGEBO : BKMMLEGBFNN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int NMPKODJNJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FPCCMOMDDEG FADDPAAALDF(Entity CLCJGDKEGGN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLBNHFHMNFM(NativeArray<FPCCMOMDDEG> PHCNLGFIAMJ, NativeArray<LLHKPPBKIID> CPMOCNNLOMN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPOGJIGPDHM(FPCCMOMDDEG BFJMCAAKMNM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBDMKKGOJFP(FPCCMOMDDEG BFJMCAAKMNM, out Collider PIGJAIJJEON);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ILJNJGIAJDG]
public class MFEOMAMFIAE : ComponentSystem, JLLBLNFOFFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CAJHOBCLJCD KOKBOCCBKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LPPOJAOPNMP FALFHKCLHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x25E7AD0", Offset = "0x25E6AD0", VA = "0x1825E7AD0", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	public MFEOMAMFIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CreateAssetMenu]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x25EE7C0", Offset = "0x25ED7C0", VA = "0x1825EE7C0")]
		public static ObjectModelConfigAsset BGOMOEEDECH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDD5560", Offset = "0xDD4560", VA = "0x180DD5560")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DOKDCAPODCB(PBFEFLGCHAA.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[DOKDCAPODCB(PBFEFLGCHAA.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int LDPEBGGGOAP = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly LOBJLOAJGBA NMFPNEPNNOP;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x25F0B20", Offset = "0x25EFB20", VA = "0x1825F0B20")]
			public static LEPNJELBIPF EFMGLMKGHJG(int NGFBNCNAHHE)
			{
				return default(LEPNJELBIPF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x25F0CB0", Offset = "0x25EFCB0", VA = "0x1825F0CB0")]
			public static int LFAIAKJKKAF(GameObject PKGBHIMGLPM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x25F0A90", Offset = "0x25EFA90", VA = "0x1825F0A90")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("DEBUG_BUILD")]
			private static void CLCCNGHANOM(KOHKPOMNCDA FCJPDBMFAED, int NGFBNCNAHHE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static LKDGJLJGLMB KIKNDHMFIHG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static PGHIEJGMCBH BPIFLDGJGJA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static LKDGJLJGLMB OMPHCPJEGDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x25EFFF0", Offset = "0x25EEFF0", VA = "0x1825EFFF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x25EEB00", Offset = "0x25EDB00", VA = "0x1825EEB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static PGHIEJGMCBH MDOKLCGPPGB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x25EFDC0", Offset = "0x25EEDC0", VA = "0x1825EFDC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x25EF490", Offset = "0x25EE490", VA = "0x1825EF490")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool IACNHGGFAIF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x25EF0E0", Offset = "0x25EE0E0", VA = "0x1825EF0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static LPPOJAOPNMP FALFHKCLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x25EEFA0", Offset = "0x25EDFA0", VA = "0x1825EEFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static IIMPHEBOFIN AKHNFEIIFMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x25EFB60", Offset = "0x25EEB60", VA = "0x1825EFB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static JGGCCENAKDL CEECAILOCMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x25EFF20", Offset = "0x25EEF20", VA = "0x1825EFF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NPGLNNOGMJJ CNENPJIDLLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x25EEED0", Offset = "0x25EDED0", VA = "0x1825EEED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IHJGKBGCMLD DMOJLFMKCHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x25EF010", Offset = "0x25EE010", VA = "0x1825EF010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool PKMIMJMPKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x25EF830", Offset = "0x25EE830", VA = "0x1825EF830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x25EFA70", Offset = "0x25EEA70", VA = "0x1825EFA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool MBMACPOOOBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x25EF5E0", Offset = "0x25EE5E0", VA = "0x1825EF5E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x25EF640", Offset = "0x25EE640", VA = "0x1825EF640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool GJCMPACJPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x25EF7D0", Offset = "0x25EE7D0", VA = "0x1825EF7D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x25EF2C0", Offset = "0x25EE2C0", VA = "0x1825EF2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action MCCKANCIHHL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x25EE840", Offset = "0x25ED840", VA = "0x1825EE840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x25EF970", Offset = "0x25EE970", VA = "0x1825EF970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x25EF6A0", Offset = "0x25EE6A0", VA = "0x1825EF6A0")]
		public static KOHKPOMNCDA KMPFPHIPBGN(GameObject PKGBHIMGLPM)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x25EE940", Offset = "0x25ED940", VA = "0x1825EE940")]
		public static LEPNJELBIPF BEPHKEGICMG(GameObject PKGBHIMGLPM)
		{
			return default(LEPNJELBIPF);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x25EE9F0", Offset = "0x25ED9F0", VA = "0x1825EE9F0")]
		public static AANBNAJPLKI CKGKGODCJAO(LEPNJELBIPF POJMBOCFKCO)
		{
			return default(AANBNAJPLKI);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x25EE9B0", Offset = "0x25ED9B0", VA = "0x1825EE9B0")]
		public static AANBNAJPLKI CKGKGODCJAO(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default(AANBNAJPLKI);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x25EFC30", Offset = "0x25EEC30", VA = "0x1825EFC30")]
		public static (ByteString, IDisposable) NJADPKHDAEC()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x25EEBD0", Offset = "0x25EDBD0", VA = "0x1825EEBD0")]
		public static (ByteString, IDisposable) EABMDLOOPJE(IEnumerable<KOHKPOMNCDA> FMNOOKPHPNI)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x25EED60", Offset = "0x25EDD60", VA = "0x1825EED60")]
		public static bool FCNDMFGEPOG(GameObject PKGBHIMGLPM, out LEPNJELBIPF POJMBOCFKCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x25EF320", Offset = "0x25EE320", VA = "0x1825EF320")]
		public static bool JELJBLLOKDN(GameObject PKGBHIMGLPM, out bool PMPODOPFKAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x25EF1A0", Offset = "0x25EE1A0", VA = "0x1825EF1A0")]
		private static PGHIEJGMCBH IEPGINDPFBE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LCCAOCECDFN
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x22EBCE0", Offset = "0x22EACE0", VA = "0x1822EBCE0")]
	public static PHJBPPLEHIN HCCDLMMPDLB(GameObject PKGBHIMGLPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x22EBB00", Offset = "0x22EAB00", VA = "0x1822EBB00")]
	public static PHJBPPLEHIN HCCDLMMPDLB(GameObject PKGBHIMGLPM, LEPNJELBIPF POJMBOCFKCO)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DisembodiedObjectView : MonoBehaviour, BJAJILHGNBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public KOHKPOMNCDA GOBFONMMIPN
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(KOHKPOMNCDA);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x25E3A00", Offset = "0x25E2A00", VA = "0x1825E3A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	[DOKDCAPODCB(PBFEFLGCHAA.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, PHJBPPLEHIN, BJAJILHGNBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string PIKKJCHJIHG = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KOHKPOMNCDA DOMFNFDEEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private DDEEKPDALFC LKOJKOJNBBK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KOHKPOMNCDA GOBFONMMIPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8F6A50", Offset = "0x8F5A50", VA = "0x1808F6A50", Slot = "11")]
			get
			{
				return default(KOHKPOMNCDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public AANBNAJPLKI JPJOKGKJCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x25E4510", Offset = "0x25E3510", VA = "0x1825E4510", Slot = "4")]
			get
			{
				return default(AANBNAJPLKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private LPPOJAOPNMP FALFHKCLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x25E3BE0", Offset = "0x25E2BE0", VA = "0x1825E3BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private INJCNOHDGPO LONMMBCGJFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x25E3A90", Offset = "0x25E2A90", VA = "0x1825E3A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public DDEEKPDALFC EKNOOKLPFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6360F0", Offset = "0x6350F0", VA = "0x1806360F0", Slot = "5")]
			get
			{
				return default(DDEEKPDALFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool OBCMGGMPJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7D6E70", Offset = "0x7D5E70", VA = "0x1807D6E70", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7D6EF0", Offset = "0x7D5EF0", VA = "0x1807D6EF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> JONFJJPFPDE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x25E4470", Offset = "0x25E3470", VA = "0x1825E4470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x25E4540", Offset = "0x25E3540", VA = "0x1825E4540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x25E3B10", Offset = "0x25E2B10", VA = "0x1825E3B10")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x25E4320", Offset = "0x25E3320", VA = "0x1825E4320", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x25E3F80", Offset = "0x25E2F80", VA = "0x1825E3F80", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x25E4290", Offset = "0x25E3290", VA = "0x1825E4290", Slot = "8")]
		public void OnEmbody(GDEFGFJPJEE BICCGEMNLEI, KOHKPOMNCDA DOMFNFDEEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x25E4310", Offset = "0x25E3310", VA = "0x1825E4310", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x25E4040", Offset = "0x25E3040", VA = "0x1825E4040", Slot = "10")]
		public void OnDisembody(bool EIFIELIGOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x25E3CF0", Offset = "0x25E2CF0", VA = "0x1825E3CF0")]
		private void MODGKBJKCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x25E3C30", Offset = "0x25E2C30", VA = "0x1825E3C30")]
		private void MACPAJNOKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x25E3E00", Offset = "0x25E2E00", VA = "0x1825E3E00")]
		private void OOBLOBJBPOI(bool IMHDCCBLKLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x12B92F0", Offset = "0x12B82F0", VA = "0x1812B92F0", Slot = "7")]
		private GameObject CPMNBBCENFH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	[DOKDCAPODCB(PBFEFLGCHAA.Registration)]
	public sealed class TransformEntity : MonoBehaviour, BJAJILHGNBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private DAGBJECOPFG prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private KOHKPOMNCDA FCJPDBMFAED;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DAGBJECOPFG PPLNAJCEMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x670670", VA = "0x180671670")]
			get
			{
				return default(DAGBJECOPFG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x737910", Offset = "0x736910", VA = "0x180737910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public KOHKPOMNCDA GOBFONMMIPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8F6A50", Offset = "0x8F5A50", VA = "0x1808F6A50", Slot = "4")]
			get
			{
				return default(KOHKPOMNCDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity HFANCMABCJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal NPGLNNOGMJJ CNENPJIDLLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal INJCNOHDGPO JPDGOBOCCDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x576FEF0", Offset = "0x576EEF0", VA = "0x18576FEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x576FEE0", Offset = "0x576EEE0", VA = "0x18576FEE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x576FF60", Offset = "0x576EF60", VA = "0x18576FF60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x576FC70", Offset = "0x576EC70", VA = "0x18576FC70")]
		internal void AICHPOAHICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x576FF60", Offset = "0x576EF60", VA = "0x18576FF60")]
		internal void LNFINCFCIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5770060", Offset = "0x576F060", VA = "0x185770060")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5770180", Offset = "0x576F180", VA = "0x185770180")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Flags]
public enum JDJPKEAIHJD
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	IncludeMock = 4,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	IncludeEditor = 8,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AJHJJBJAJKN(typeof(PGHIEJGMCBH), new string[] { })]
public class OHKBJDIEAPH : PGHIEJGMCBH, IDisposable, MFCCKGHBMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public CAJHOBCLJCD KOKBOCCBKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public PBNGMJECOGA FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public LPPOJAOPNMP FALFHKCLHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PKMIMJMPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x25ED8B0", Offset = "0x25EC8B0", VA = "0x1825ED8B0", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x25EDAE0", Offset = "0x25ECAE0", VA = "0x1825EDAE0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public IHJMMPGMNNH DHPKHCPBFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x60E720", Offset = "0x60D720", VA = "0x18060E720", Slot = "15")]
		get
		{
			return default(IHJMMPGMNNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x25ED080", Offset = "0x25EC080", VA = "0x1825ED080")]
	public static OHKBJDIEAPH FBMLCAAKPML(GIIGFAJCCFO HNBMHDKILBK, JDJPKEAIHJD AANEECAEOLG = JDJPKEAIHJD.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25ED910", Offset = "0x25EC910", VA = "0x1825ED910")]
	private static void LNDKFAKIIJJ(GIIGFAJCCFO HNBMHDKILBK, JDJPKEAIHJD AANEECAEOLG = JDJPKEAIHJD.ExcludeIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x25ED530", Offset = "0x25EC530", VA = "0x1825ED530")]
	private static void HBKENJIDLCO(GIIGFAJCCFO HNBMHDKILBK, JDJPKEAIHJD AANEECAEOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x25ECDD0", Offset = "0x25EBDD0", VA = "0x1825ECDD0")]
	private static string[] BGGNKBOMFIF(JDJPKEAIHJD AANEECAEOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x25ED340", Offset = "0x25EC340", VA = "0x1825ED340")]
	private static bool GGEFDKIHBKA(JDJPKEAIHJD AANEECAEOLG, out string[] AKHENNGJPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x25ED470", Offset = "0x25EC470", VA = "0x1825ED470")]
	private static void GLLLHHBEHBG(GIIGFAJCCFO HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x25ED260", Offset = "0x25EC260", VA = "0x1825ED260", Slot = "16")]
	public void GFHDCIJAIAN(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x10D1570", Offset = "0x10D0570", VA = "0x1810D1570")]
	private void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25EDC40", Offset = "0x25ECC40", VA = "0x1825EDC40")]
	private void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	private void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x25ECF80", Offset = "0x25EBF80", VA = "0x1825ECF80", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x25EDA00", Offset = "0x25ECA00", VA = "0x1825EDA00", Slot = "19")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x25EDA70", Offset = "0x25ECA70", VA = "0x1825EDA70", Slot = "9")]
	public void MCOMHNMOOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "10")]
	public void DBFMEJHHDLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25EDCC0", Offset = "0x25ECCC0", VA = "0x1825EDCC0", Slot = "11")]
	public void OCIFGHECBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x25ED7C0", Offset = "0x25EC7C0", VA = "0x1825ED7C0", Slot = "7")]
	public void HIDKAFCIGIB(ByteString JEJGBICCBLN, ELIOLIHHMNH AANEECAEOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x25ED010", Offset = "0x25EC010", VA = "0x1825ED010", Slot = "8")]
	public void FACFGOLJGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x25ED1F0", Offset = "0x25EC1F0", VA = "0x1825ED1F0", Slot = "12")]
	public void FGEIEBCGEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x25ECF10", Offset = "0x25EBF10", VA = "0x1825ECF10", Slot = "13")]
	public void CKMKAGGNKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x25EDB60", Offset = "0x25ECB60", VA = "0x1825EDB60", Slot = "20")]
	public ByteString NJADPKHDAEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0")]
	private static bool DKMBMCOAPLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public OHKBJDIEAPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LFBMHOBIEPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x22F0B40", Offset = "0x22EFB40", VA = "0x1822F0B40")]
	public static AANBNAJPLKI NOOPGDGEFHO(this PGHIEJGMCBH BPIFLDGJGJA, LEPNJELBIPF POJMBOCFKCO, DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(AANBNAJPLKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22F0790", Offset = "0x22EF790", VA = "0x1822F0790")]
	public static EJAMINLFEBK AEMLADDGEBB(this PGHIEJGMCBH BPIFLDGJGJA)
	{
		return default(EJAMINLFEBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x22F0990", Offset = "0x22EF990", VA = "0x1822F0990")]
	public static KOHKPOMNCDA KMPFPHIPBGN(this PGHIEJGMCBH BPIFLDGJGJA, Entity CLCJGDKEGGN)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x22F0A30", Offset = "0x22EFA30", VA = "0x1822F0A30")]
	public static KOHKPOMNCDA KMPFPHIPBGN(this PGHIEJGMCBH BPIFLDGJGJA, LEPNJELBIPF POJMBOCFKCO)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22F0890", Offset = "0x22EF890", VA = "0x1822F0890")]
	public static LEPNJELBIPF BEPHKEGICMG(this PGHIEJGMCBH BPIFLDGJGJA, KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(LEPNJELBIPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class HPOCEEOKAHH<T> : global::EMJLGMJKCFN<T>, global::FGMALPJKBFM<LEPNJELBIPF, T>, global::KLCGNIDLOLD<LEPNJELBIPF>, AMHPDEDGIBB, IDisposable, PNEIOOPEEOE where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::KLCGNIDLOLD<Entity> KIMANJPEJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate CFHAEEIIPOD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string CNNFDLMHGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x47FD870", Offset = "0x47FC870", VA = "0x1847FD870", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type NLKEOENNEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x47F8980", Offset = "0x47F7980", VA = "0x1847F8980", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ENCFKNPILEO NAMCMDKGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x47FDB40", Offset = "0x47FCB40", VA = "0x1847FDB40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PAEFFAGDNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4804B50", Offset = "0x4803B50", VA = "0x184804B50", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HBEOBMPCBAG ICGAPGNLPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4804F60", Offset = "0x4803F60", VA = "0x184804F60", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x287D570", Offset = "0x287C570", VA = "0x18287D570", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x47F8AB0", Offset = "0x47F7AB0", VA = "0x1847F8AB0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::CNFBDHGMAFD<LEPNJELBIPF> HPKCEGIOBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x48039C0", Offset = "0x48029C0", VA = "0x1848039C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x47F7860", Offset = "0x47F6860", VA = "0x1847F7860", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E840", Offset = "0x3A9D840", VA = "0x183A9E840")]
	public HPOCEEOKAHH(global::KLCGNIDLOLD<Entity> KIMANJPEJBL, NPGLNNOGMJJ IPPOOBMDIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x47F8400", Offset = "0x47F7400", VA = "0x1847F8400")]
	private Entity BFHBCOPOEIO(LEPNJELBIPF POJMBOCFKCO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x47F80B0", Offset = "0x47F70B0", VA = "0x1847F80B0")]
	private LEPNJELBIPF BFHBCOPOEIO(Entity CLCJGDKEGGN)
	{
		return default(LEPNJELBIPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x47FA680", Offset = "0x47F9680", VA = "0x1847FA680", Slot = "4")]
	public T FGPHONIFMEK(LEPNJELBIPF POJMBOCFKCO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x47FBAC0", Offset = "0x47FAAC0", VA = "0x1847FBAC0")]
	public bool GALDMPBHILF(LEPNJELBIPF POJMBOCFKCO, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4801510", Offset = "0x4800510", VA = "0x184801510")]
	public bool MFPCHEGGNIA(LEPNJELBIPF POJMBOCFKCO, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x47F9160", Offset = "0x47F8160", VA = "0x1847F9160", Slot = "9")]
	public bool EFMFIFBCNEK(LEPNJELBIPF POJMBOCFKCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x47FDD60", Offset = "0x47FCD60", VA = "0x1847FDD60", Slot = "26")]
	public object KLKPBFOJPIG(LEPNJELBIPF POJMBOCFKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x47FC8D0", Offset = "0x47FB8D0", VA = "0x1847FC8D0")]
	public bool HFLHLPEEOHN(LEPNJELBIPF POJMBOCFKCO, in object CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x47FA230", Offset = "0x47F9230", VA = "0x1847FA230")]
	public void FGPHONIFMEK(LEPNJELBIPF POJMBOCFKCO, in PFFLIKLDNNB JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x47FC360", Offset = "0x47FB360", VA = "0x1847FC360")]
	public bool GALDMPBHILF(LEPNJELBIPF POJMBOCFKCO, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x48012F0", Offset = "0x48002F0", VA = "0x1848012F0")]
	public bool MFPCHEGGNIA(LEPNJELBIPF POJMBOCFKCO, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D5A0", Offset = "0x3A9C5A0", VA = "0x183A9D5A0", Slot = "21")]
	public void ONBNIDHNIKA(FPDLPCMACEI PNCDHJKGIFC, [Optional] object GENOAILOCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4804920", Offset = "0x4803920", VA = "0x184804920", Slot = "15")]
	public void ONBNIDHNIKA(LEPNJELBIPF GGLJFLNJABJ, CGLEDAGBEON PNCDHJKGIFC, object GENOAILOCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x47FF060", Offset = "0x47FE060", VA = "0x1847FF060", Slot = "14")]
	public bool LKIMLIILGCE(LEPNJELBIPF JNOBOEIAMPB, LEPNJELBIPF LCEEDPEAPOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x21C7AA0", Offset = "0x21C6AA0", VA = "0x1821C7AA0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4805050", Offset = "0x4804050", VA = "0x184805050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x47F7E80", Offset = "0x47F6E80", VA = "0x1847F7E80")]
	public string ALHMIFEGFAE(in JHBOMEIKHGC HIKBCINGNOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x47FE1B0", Offset = "0x47FD1B0", VA = "0x1847FE1B0")]
	private void KNAAKDDFIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x47F9430", Offset = "0x47F8430", VA = "0x1847F9430")]
	private void EMPJHLKCPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x48004F0", Offset = "0x47FF4F0", VA = "0x1848004F0")]
	private void MEKFGHAFDBO(Entity CLCJGDKEGGN, in JHBOMEIKHGC LONPLGOFNDA, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47F8B30", Offset = "0x47F7B30", VA = "0x1847F8B30")]
	private void DKHAJNCFMFG(Entity CLCJGDKEGGN, in JHBOMEIKHGC LONPLGOFNDA, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x48025D0", Offset = "0x48015D0", VA = "0x1848025D0")]
	[Conditional("DEBUG_BUILD")]
	private static void NHAACLOGDPH(Entity CLCJGDKEGGN, LEPNJELBIPF POJMBOCFKCO, string JPOEBAHCHNJ, string PDGGIMGFKPH, [CallerMemberName] string ODKANHNKPIL = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x287D510", Offset = "0x287C510", VA = "0x18287D510", Slot = "5")]
	private bool JDGOBOAPPGH(LEPNJELBIPF GGLJFLNJABJ, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B77250", Offset = "0x2B76250", VA = "0x182B77250", Slot = "6")]
	private bool KJMCPCININA(LEPNJELBIPF GGLJFLNJABJ, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x27C22B0", Offset = "0x27C12B0", VA = "0x1827C22B0", Slot = "23")]
	private string FGDMJMNDHGC(in JHBOMEIKHGC JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x27C22E0", Offset = "0x27C12E0", VA = "0x1827C22E0", Slot = "10")]
	private bool IEINANKPPAL(LEPNJELBIPF GGLJFLNJABJ, in object CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27C1DD0", Offset = "0x27C0DD0", VA = "0x1827C1DD0", Slot = "11")]
	private void IFEPIMAGMDI(LEPNJELBIPF GGLJFLNJABJ, in PFFLIKLDNNB JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4803830", Offset = "0x4802830", VA = "0x184803830", Slot = "12")]
	private bool ODHIJDEAGDD(LEPNJELBIPF GGLJFLNJABJ, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x217A660", Offset = "0x2179660", VA = "0x18217A660", Slot = "13")]
	private bool DLJBPHOFKOP(LEPNJELBIPF GGLJFLNJABJ, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class MBEEMLIGNHG<T> : global::AFCDMLCBFJK<T>, global::FGMALPJKBFM<KOHKPOMNCDA, T>, global::KLCGNIDLOLD<KOHKPOMNCDA>, AMHPDEDGIBB, IDisposable, KIOJMOHAOIF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::KLCGNIDLOLD<Entity> KIMANJPEJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate CFHAEEIIPOD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string CNNFDLMHGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A99880", Offset = "0x3A98880", VA = "0x183A99880", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type NLKEOENNEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A956F0", Offset = "0x3A946F0", VA = "0x183A956F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ENCFKNPILEO NAMCMDKGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A99A10", Offset = "0x3A98A10", VA = "0x183A99A10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int PAEFFAGDNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E170", Offset = "0x3A9D170", VA = "0x183A9E170", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HBEOBMPCBAG ICGAPGNLPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E260", Offset = "0x3A9D260", VA = "0x183A9E260", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A99B60", Offset = "0x3A98B60", VA = "0x183A99B60", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3A958F0", Offset = "0x3A948F0", VA = "0x183A958F0", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::CNFBDHGMAFD<KOHKPOMNCDA> HPKCEGIOBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D440", Offset = "0x3A9C440", VA = "0x183A9D440", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A951E0", Offset = "0x3A941E0", VA = "0x183A951E0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E840", Offset = "0x3A9D840", VA = "0x183A9E840")]
	public MBEEMLIGNHG(global::KLCGNIDLOLD<Entity> KIMANJPEJBL, NPGLNNOGMJJ IPPOOBMDIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1B56960", Offset = "0x1B55960", VA = "0x181B56960")]
	private Entity BFHBCOPOEIO(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A95600", Offset = "0x3A94600", VA = "0x183A95600")]
	private KOHKPOMNCDA BFHBCOPOEIO(Entity CLCJGDKEGGN)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A97610", Offset = "0x3A96610", VA = "0x183A97610", Slot = "4")]
	public T FGPHONIFMEK(KOHKPOMNCDA FCJPDBMFAED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A97E70", Offset = "0x3A96E70", VA = "0x183A97E70")]
	public bool GALDMPBHILF(KOHKPOMNCDA FCJPDBMFAED, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CC30", Offset = "0x3A9BC30", VA = "0x183A9CC30")]
	public bool MFPCHEGGNIA(KOHKPOMNCDA FCJPDBMFAED, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A95E60", Offset = "0x3A94E60", VA = "0x183A95E60", Slot = "9")]
	public bool EFMFIFBCNEK(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A99E10", Offset = "0x3A98E10", VA = "0x183A99E10", Slot = "25")]
	public object KLKPBFOJPIG(KOHKPOMNCDA FCJPDBMFAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A99130", Offset = "0x3A98130", VA = "0x183A99130")]
	public bool HFLHLPEEOHN(KOHKPOMNCDA FCJPDBMFAED, in object CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A96BE0", Offset = "0x3A95BE0", VA = "0x183A96BE0")]
	public void FGPHONIFMEK(KOHKPOMNCDA FCJPDBMFAED, in PFFLIKLDNNB JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A984D0", Offset = "0x3A974D0", VA = "0x183A984D0")]
	public bool GALDMPBHILF(KOHKPOMNCDA FCJPDBMFAED, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D010", Offset = "0x3A9C010", VA = "0x183A9D010")]
	public bool MFPCHEGGNIA(KOHKPOMNCDA FCJPDBMFAED, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D5A0", Offset = "0x3A9C5A0", VA = "0x183A9D5A0", Slot = "21")]
	public void ONBNIDHNIKA(FPDLPCMACEI PNCDHJKGIFC, [Optional] object GENOAILOCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DE90", Offset = "0x3A9CE90", VA = "0x183A9DE90", Slot = "15")]
	public void ONBNIDHNIKA(KOHKPOMNCDA GGLJFLNJABJ, CGLEDAGBEON PNCDHJKGIFC, object GENOAILOCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AD50", Offset = "0x3A99D50", VA = "0x183A9AD50", Slot = "14")]
	public bool LKIMLIILGCE(KOHKPOMNCDA JNOBOEIAMPB, KOHKPOMNCDA LCEEDPEAPOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A3C0", Offset = "0x3A993C0", VA = "0x183A9A3C0")]
	private void KNAAKDDFIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3A96460", Offset = "0x3A95460", VA = "0x183A96460")]
	private void EMPJHLKCPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AE90", Offset = "0x3A99E90", VA = "0x183A9AE90")]
	private void MEKFGHAFDBO(Entity CLCJGDKEGGN, in JHBOMEIKHGC LONPLGOFNDA, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3A95930", Offset = "0x3A94930", VA = "0x183A95930")]
	private void DKHAJNCFMFG(Entity CLCJGDKEGGN, in JHBOMEIKHGC LONPLGOFNDA, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3A95CF0", Offset = "0x3A94CF0", VA = "0x183A95CF0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E660", Offset = "0x3A9D660", VA = "0x183A9E660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3A95870", Offset = "0x3A94870", VA = "0x183A95870", Slot = "5")]
	private bool DCFFBPIIAFP(KOHKPOMNCDA GGLJFLNJABJ, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AE50", Offset = "0x3A99E50", VA = "0x183A9AE50", Slot = "6")]
	private bool MEHNHPALCCG(KOHKPOMNCDA GGLJFLNJABJ, in T CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D140", Offset = "0x3A9C140", VA = "0x183A9D140", Slot = "10")]
	private bool OHJFDBIKGMC(KOHKPOMNCDA GGLJFLNJABJ, in object CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E040", Offset = "0x3A9D040", VA = "0x183A9E040", Slot = "11")]
	private void PAKGBEPEAPE(KOHKPOMNCDA GGLJFLNJABJ, in PFFLIKLDNNB JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E440", Offset = "0x3A9D440", VA = "0x183A9E440", Slot = "12")]
	private bool PPJGEEHKNJF(KOHKPOMNCDA GGLJFLNJABJ, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3A97DA0", Offset = "0x3A96DA0", VA = "0x183A97DA0", Slot = "13")]
	private bool FJMNBBPGFJP(KOHKPOMNCDA GGLJFLNJABJ, in JHBOMEIKHGC CACEPBECNCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[AJHJJBJAJKN(typeof(IIMPHEBOFIN), new string[] { })]
public class MHNNDPMMGHK : JLLBLNFOFFK, IIMPHEBOFIN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const string DGJODKOKMGE = "ScopeService";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EJAMINLFEBK FCPNDPIDFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private IHJGKBGCMLD ELOOMINKHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HMEAGJMDJCO AFPNBEIOIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private ObjectEmbodimentService INGBFIDDJOP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KOHKPOMNCDA MMGDPBIPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "7")]
		get
		{
			return default(KOHKPOMNCDA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x25E7BC0", Offset = "0x25E6BC0", VA = "0x1825E7BC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EJAMINLFEBK KACMNEKIHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "9")]
		get
		{
			return default(EJAMINLFEBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x25E7BC0", Offset = "0x25E6BC0", VA = "0x1825E7BC0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JIBGDBFAFMN LHKHOFMDHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x25E7E70", Offset = "0x25E6E70", VA = "0x1825E7E70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x25E7DD0", Offset = "0x25E6DD0", VA = "0x1825E7DD0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x25E8470", Offset = "0x25E7470", VA = "0x1825E8470", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x25E7D00", Offset = "0x25E6D00", VA = "0x1825E7D00", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x25E8640", Offset = "0x25E7640", VA = "0x1825E8640", Slot = "11")]
	public KOHKPOMNCDA OFDALCHCMPA(KOHKPOMNCDA DEKOLLLDDAM, KOHKPOMNCDA PGJCGJKNAPB)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x25E8540", Offset = "0x25E7540", VA = "0x1825E8540", Slot = "12")]
	public bool ODLGFFKEGJI(KOHKPOMNCDA DEKOLLLDDAM, KOHKPOMNCDA PGJCGJKNAPB, out KOHKPOMNCDA MIBLCIFEPBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x25E7BE0", Offset = "0x25E6BE0", VA = "0x1825E7BE0", Slot = "13")]
	public void BBPBLBMJJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25E8750", Offset = "0x25E7750", VA = "0x1825E8750", Slot = "14")]
	public void PMEFFMPPGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x25E8350", Offset = "0x25E7350", VA = "0x1825E8350", Slot = "15")]
	public bool NBKCFMOLGBJ(KOHKPOMNCDA GBMKJAJEAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x25E7F10", Offset = "0x25E6F10", VA = "0x1825E7F10")]
	private bool LCAAGDNDPFC(KOHKPOMNCDA JHEGJDDGMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x25E8180", Offset = "0x25E7180", VA = "0x1825E8180")]
	private void LCCCCDOPLEN(AANBNAJPLKI MDAEAKFNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public MHNNDPMMGHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AJHJJBJAJKN(typeof(HMEAGJMDJCO), new string[] { })]
public class HJOJPPNGBON : JLLBLNFOFFK, HMEAGJMDJCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityManager EFLHIHFKEDM;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x22DE490", Offset = "0x22DD490", VA = "0x1822DE490", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x22DE430", Offset = "0x22DD430", VA = "0x1822DE430", Slot = "5")]
	public void IBCANKFCMPB(KOHKPOMNCDA DOMFNFDEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x22DE3D0", Offset = "0x22DD3D0", VA = "0x1822DE3D0", Slot = "6")]
	public void FNDPKLIBEIJ(KOHKPOMNCDA DOMFNFDEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public HJOJPPNGBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OAOHFOPDGKM : IDisposable, HGONJGDBLML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> LACJOLCCAOA;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> OHGHBKDEKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A40", Offset = "0x8F5A40", VA = "0x1808F6A40", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD5DB80", Offset = "0xD5CB80", VA = "0x180D5DB80")]
	public OAOHFOPDGKM(NativeArray<EntityRemapUtility.EntityRemapInfo> LACJOLCCAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x25EBD70", Offset = "0x25EAD70", VA = "0x1825EBD70", Slot = "6")]
	public KOHKPOMNCDA PLMFJBJBCHH(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x25EBE50", Offset = "0x25EAE50", VA = "0x1825EBE50", Slot = "7")]
	public Entity PLMFJBJBCHH(Entity CLCJGDKEGGN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x25EBDC0", Offset = "0x25EADC0", VA = "0x1825EBDC0", Slot = "8")]
	public IEnumerable<KOHKPOMNCDA> PLMFJBJBCHH(IEnumerable<KOHKPOMNCDA> FMNOOKPHPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x25EBD10", Offset = "0x25EAD10", VA = "0x1825EBD10", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DOKDCAPODCB(PBFEFLGCHAA.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string NPMLKDMCAOL = "Remap";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly LOBJLOAJGBA MAJOBHCPPNF;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static int DMGBBKMNCNN;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static HGONJGDBLML FFPCMEINODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool EDPOKJKJCLM;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> OHGHBKDEKLK
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x25F1810", Offset = "0x25F0810", VA = "0x1825F1810")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static bool NNDMLCCNIMP
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x25F1970", Offset = "0x25F0970", VA = "0x1825F1970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x25F1910", Offset = "0x25F0910", VA = "0x1825F1910")]
		public static SerializationRemapScope KPGJPKALNOG()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x25F1D00", Offset = "0x25F0D00", VA = "0x1825F1D00")]
		public SerializationRemapScope(HGONJGDBLML ADNGGIEFFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x25F1710", Offset = "0x25F0710", VA = "0x1825F1710", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x25F1B30", Offset = "0x25F0B30", VA = "0x1825F1B30")]
		public static KOHKPOMNCDA PLMFJBJBCHH(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x25F1A00", Offset = "0x25F0A00", VA = "0x1825F1A00")]
		public static Entity PLMFJBJBCHH(Entity CLCJGDKEGGN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[AJHJJBJAJKN(typeof(IHJGKBGCMLD), new string[] { })]
public class GFJBHFJGLPC : IHJGKBGCMLD, LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityHierarchyParents HEPFDPEAIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityHierarchyChildren DGKOICOAPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ANFBMLMNOPH DJBJNOPKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ObjectEmbodimentService INGBFIDDJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public global::AFCDMLCBFJK<KOHKPOMNCDA> COCJCFDPJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D70", Offset = "0x5F7D70", VA = "0x1805F8D70", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x67FFC0", Offset = "0x67EFC0", VA = "0x18067FFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xC755E0", Offset = "0xC745E0", VA = "0x180C755E0", Slot = "12")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x245CE30", Offset = "0x245BE30", VA = "0x18245CE30", Slot = "13")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x245D1E0", Offset = "0x245C1E0", VA = "0x18245D1E0", Slot = "14")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x245CC70", Offset = "0x245BC70", VA = "0x18245CC70")]
	private KOHKPOMNCDA NDKHJCMPBCP(Entity CLCJGDKEGGN)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x245C890", Offset = "0x245B890", VA = "0x18245C890", Slot = "17")]
	public KOHKPOMNCDA CPDDCBADJAO(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x245C9E0", Offset = "0x245B9E0", VA = "0x18245C9E0", Slot = "18")]
	public void FGIAMLJJIIA(ref List<KOHKPOMNCDA> HKLPHEJENOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x245CCA0", Offset = "0x245BCA0", VA = "0x18245CCA0", Slot = "19")]
	public IEnumerable<KOHKPOMNCDA> NLFHAONJPJD(KOHKPOMNCDA FCJPDBMFAED, bool BDFHGDMNBNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x245CF00", Offset = "0x245BF00", VA = "0x18245CF00", Slot = "20")]
	public KOHKPOMNCDA OAJJPFNHHFL(KOHKPOMNCDA FCJPDBMFAED, int IIHEDPBOLFE)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x245C930", Offset = "0x245B930", VA = "0x18245C930", Slot = "21")]
	public int EANFCPEKCOB(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x245CBA0", Offset = "0x245BBA0", VA = "0x18245CBA0", Slot = "6")]
	public int HPLFBALIGMC(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x245CC00", Offset = "0x245BC00", VA = "0x18245CC00", Slot = "7")]
	public OLEFECDLOJC MOMIIJGOAKH(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x245C6D0", Offset = "0x245B6D0", VA = "0x18245C6D0", Slot = "22")]
	public IEnumerable<KOHKPOMNCDA> BGCIPFHEMCN(KOHKPOMNCDA FCJPDBMFAED, bool BDFHGDMNBNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x245D180", Offset = "0x245C180", VA = "0x18245D180", Slot = "10")]
	public KOHKPOMNCDA OFDALCHCMPA(KOHKPOMNCDA DEKOLLLDDAM, KOHKPOMNCDA PGJCGJKNAPB)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x245CF70", Offset = "0x245BF70", VA = "0x18245CF70", Slot = "11")]
	public bool ODLGFFKEGJI(KOHKPOMNCDA DEKOLLLDDAM, KOHKPOMNCDA PGJCGJKNAPB, out KOHKPOMNCDA MIBLCIFEPBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x245C590", Offset = "0x245B590", VA = "0x18245C590", Slot = "4")]
	public KOHKPOMNCDA AMDMBCDOPIK(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x245C860", Offset = "0x245B860", VA = "0x18245C860", Slot = "9")]
	public bool CPDCGLLJNJD(KOHKPOMNCDA FCJPDBMFAED, KOHKPOMNCDA IIJHPNIJLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x245C600", Offset = "0x245B600", VA = "0x18245C600", Slot = "23")]
	public bool BBAIDIENPKA(KOHKPOMNCDA FCJPDBMFAED, KOHKPOMNCDA GPFGJIGIKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x245CBD0", Offset = "0x245BBD0", VA = "0x18245CBD0", Slot = "8")]
	public bool JOMKOGLPFKL(KOHKPOMNCDA FCJPDBMFAED, KOHKPOMNCDA DEKOLLLDDAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x245C900", Offset = "0x245B900", VA = "0x18245C900", Slot = "5")]
	public bool DGGJLEKFKFN(KOHKPOMNCDA FCJPDBMFAED, KOHKPOMNCDA ACNNFDIAAFM, bool FBEEIDPLMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1264AB0", Offset = "0x1263AB0", VA = "0x181264AB0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GFJBHFJGLPC()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(BOGNDKOMFAC))]
	[DOKDCAPODCB(PBFEFLGCHAA.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal class BOGNDKOMFAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private readonly ActionBuffer AIKEPJOBOJF;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int HJCHDLKJEJK
			{
				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x25E0A30", Offset = "0x25DFA30", VA = "0x1825E0A30")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public HPJCBDABFCN[] CFCKOBICDAF
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x25E0990", Offset = "0x25DF990", VA = "0x1825E0990")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719660", VA = "0x18071A660")]
			public BOGNDKOMFAC(ActionBuffer LIBBFPLHJOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x25E08B0", Offset = "0x25DF8B0", VA = "0x1825E08B0")]
			[CompilerGenerated]
			private HPJCBDABFCN CJCHDACKMIO(OKBMOAJPKLI BBNMGAFNKKA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal class HPJCBDABFCN : FPDLPCMACEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private readonly ActionBuffer AIKEPJOBOJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private readonly OKBMOAJPKLI BBNMGAFNKKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private List<(AMNHDLMFHBF, string, object)> FDDDLALLBHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private CCBEPMNNDHK FDKCNEJMANN;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int HJCHDLKJEJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x25E4CA0", Offset = "0x25E3CA0", VA = "0x1825E4CA0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public List<(AMNHDLMFHBF, string, object)> CIBOBHAHKKG
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x25E4CF0", Offset = "0x25E3CF0", VA = "0x1825E4CF0")]
			public HPJCBDABFCN(ActionBuffer LIBBFPLHJOG, OKBMOAJPKLI BBNMGAFNKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x25E48D0", Offset = "0x25E38D0", VA = "0x1825E48D0")]
			private string BODILGPFAPK(AMNHDLMFHBF FBPLEBAGIGD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x25E49C0", Offset = "0x25E39C0", VA = "0x1825E49C0")]
			private void GICBDFIFCOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x243D6D0", Offset = "0x243C6D0", VA = "0x18243D6D0", Slot = "4")]
			public void CHEGJJPCLGL<TKey, T>(global::FGMALPJKBFM<TKey, T> KIMANJPEJBL, [Optional] object GENOAILOCON) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private NativeList<byte> KOEDNDNAKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Stack<OKBMOAJPKLI> KLAOOCKJEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly CCKJIDFNIAF IEMIIJDNBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly GENADPIHFPM KCDOCJCLLCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly MCABEJDLNDK BIPGBCJBJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly bool EOCEFEBNNFN;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ODKPHKHHKAH EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x25DEFB0", Offset = "0x25DDFB0", VA = "0x1825DEFB0")]
			get
			{
				return default(ODKPHKHHKAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int HJCHDLKJEJK
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x25DF2A0", Offset = "0x25DE2A0", VA = "0x1825DF2A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x25DF620", Offset = "0x25DE620", VA = "0x1825DF620")]
		public ActionBuffer(GENADPIHFPM KCDOCJCLLCA, MCABEJDLNDK BIPGBCJBJEE, bool EOCEFEBNNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x25DEF20", Offset = "0x25DDF20", VA = "0x1825DEF20")]
		public bool HJOJMBOAEDC(out OKBMOAJPKLI BBNMGAFNKKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x25DF240", Offset = "0x25DE240", VA = "0x1825DF240")]
		public void MCOHOPDDOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x25DE930", Offset = "0x25DD930", VA = "0x1825DE930")]
		public OKBMOAJPKLI AMHKMCJJPEN(KKBBGHNNMHL FDDDLALLBHL, HOGENMBOPJP OGLKJJCGNGG, uint PHGFABGKLDI)
		{
			return default(OKBMOAJPKLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x25DF210", Offset = "0x25DE210", VA = "0x1825DF210")]
		public bool KNFEOOOOIAC(uint PHGFABGKLDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x25DECA0", Offset = "0x25DDCA0", VA = "0x1825DECA0")]
		public bool BGJPLOFGNGC(uint PHGFABGKLDI, out OKBMOAJPKLI GBMKJAJEAAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x25DEFF0", Offset = "0x25DDFF0", VA = "0x1825DEFF0")]
		public void JFIPGILBAAN(OKBMOAJPKLI GBMKJAJEAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x25DF490", Offset = "0x25DE490", VA = "0x1825DF490")]
		[Conditional("DEBUG_BUILD")]
		private void PJCDDCDLDAM(OKBMOAJPKLI GBMKJAJEAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x25DEA90", Offset = "0x25DDA90", VA = "0x1825DEA90")]
		private void BCHGCNCAOCD(OKBMOAJPKLI ABLELKHPCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x25DF2E0", Offset = "0x25DE2E0", VA = "0x1825DF2E0")]
		private void PAIDCOHBJFJ(CCBEPMNNDHK JHLNAILCAJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x25DEE60", Offset = "0x25DDE60", VA = "0x1825DEE60")]
		private void DMBDDPFJDGN(OKBMOAJPKLI BBNMGAFNKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x25DF150", Offset = "0x25DE150", VA = "0x1825DF150")]
		private CCBEPMNNDHK KIHOLKNJAME(OKBMOAJPKLI BBNMGAFNKKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x25DEEC0", Offset = "0x25DDEC0", VA = "0x1825DEEC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CCKJIDFNIAF : FPDLPCMACEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GENADPIHFPM KCDOCJCLLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MCABEJDLNDK BIPGBCJBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private LEPNJELBIPF DOMFNFDEEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private CCBEPMNNDHK KCLCOEAIDMK;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5F8990", Offset = "0x5F7990", VA = "0x1805F8990")]
	public CCKJIDFNIAF(GENADPIHFPM KCDOCJCLLCA, MCABEJDLNDK BIPGBCJBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x227C670", Offset = "0x227B670", VA = "0x18227C670", Slot = "4")]
	public void CHEGJJPCLGL<TKey, T>(global::FGMALPJKBFM<TKey, T> MBAIDIIOKIK, [Optional] object GENOAILOCON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x24540D0", Offset = "0x24530D0", VA = "0x1824540D0")]
	public void ONBNIDHNIKA(AMNHDLMFHBF FBPLEBAGIGD, ref CCBEPMNNDHK JHLNAILCAJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FDIGLPDLAAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct AOBGCGAALPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly FDIGLPDLAAP ACNNFDIAAFM;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x244DB40", Offset = "0x244CB40", VA = "0x18244DB40")]
		public AOBGCGAALPI(FDIGLPDLAAP ACNNFDIAAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x244DA50", Offset = "0x244CA50", VA = "0x18244DA50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected KKBBGHNNMHL FDDDLALLBHL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KKBBGHNNMHL CIBOBHAHKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x21E59B0", Offset = "0x21E49B0", VA = "0x1821E59B0")]
		get
		{
			return default(KKBBGHNNMHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool JMDIBNPIEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x245B730", Offset = "0x245A730", VA = "0x18245B730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x245B8A0", Offset = "0x245A8A0", VA = "0x18245B8A0")]
	public FDIGLPDLAAP(KKBBGHNNMHL.LKJELABHFEP IDOOFJDLHKE = KKBBGHNNMHL.LKJELABHFEP.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x245B740", Offset = "0x245A740", VA = "0x18245B740")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x245B460", Offset = "0x245A460", VA = "0x18245B460")]
	public void AJLJIKOPIAK(LEPNJELBIPF DOMFNFDEEKP, GBLAHJLDAAO LNNIDEOEIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x245B830", Offset = "0x245A830", VA = "0x18245B830")]
	public void ONIPHEALBPA(LEPNJELBIPF DOMFNFDEEKP, IHCHEEIIPON FANBLFBADKJ, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x245B660", Offset = "0x245A660", VA = "0x18245B660")]
	public void KNBOODEBKCH(LEPNJELBIPF DOMFNFDEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x245B750", Offset = "0x245A750", VA = "0x18245B750")]
	public void OMDOGEMOOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x245B570", Offset = "0x245A570", VA = "0x18245B570")]
	public void APNCHJCOEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x245B650", Offset = "0x245A650", VA = "0x18245B650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x245B540", Offset = "0x245A540", VA = "0x18245B540")]
	public AOBGCGAALPI APIKBJLGFMK()
	{
		return default(AOBGCGAALPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct AMNHDLMFHBF : IComparable<AMNHDLMFHBF>, IEquatable<AMNHDLMFHBF>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly AMNHDLMFHBF LDPEBGGGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public LEPNJELBIPF DOMFNFDEEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IHCHEEIIPON FANBLFBADKJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x244CCF0", Offset = "0x244BCF0", VA = "0x18244CCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x76ED30", Offset = "0x76DD30", VA = "0x18076ED30")]
	public AMNHDLMFHBF(LEPNJELBIPF DOMFNFDEEKP, IHCHEEIIPON FANBLFBADKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x244CE30", Offset = "0x244BE30", VA = "0x18244CE30")]
	public void LHHPDLCPANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x244CCB0", Offset = "0x244BCB0", VA = "0x18244CCB0", Slot = "4")]
	public int CompareTo(AMNHDLMFHBF IJDAJAEAAKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x244CE40", Offset = "0x244BE40", VA = "0x18244CE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x244CD50", Offset = "0x244BD50", VA = "0x18244CD50", Slot = "0")]
	public override bool Equals(object MDAEAKFNGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x244CD00", Offset = "0x244BD00", VA = "0x18244CD00", Slot = "5")]
	public bool Equals(AMNHDLMFHBF IJDAJAEAAKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x244CC20", Offset = "0x244BC20", VA = "0x18244CC20")]
	public static bool ABFAIBNGIFN(AMNHDLMFHBF EPLBIHGPPPN, AMNHDLMFHBF PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x244CC60", Offset = "0x244BC60", VA = "0x18244CC60")]
	public static bool BHAIMGMLJDO(AMNHDLMFHBF EPLBIHGPPPN, AMNHDLMFHBF PLMIDHOPDAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x244CDF0", Offset = "0x244BDF0", VA = "0x18244CDF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DLNJCBHMFKD : CGLEDAGBEON
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GENADPIHFPM KCDOCJCLLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private LEPNJELBIPF DOMFNFDEEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private IAEOFMMJNGC JICGPMEJOKD;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2459420", Offset = "0x2458420", VA = "0x182459420")]
	public void IFHOFPKMJDO(LEPNJELBIPF DOMFNFDEEKP, GENADPIHFPM KCDOCJCLLCA, IAEOFMMJNGC JICGPMEJOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2459360", Offset = "0x2458360", VA = "0x182459360", Slot = "4")]
	private void DHHPPFCNPPP(AMHPDEDGIBB KIMANJPEJBL, in JHBOMEIKHGC JNLOLNFALGF, object GENOAILOCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DLNJCBHMFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class KHMIEBLHFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x22E9620", Offset = "0x22E8620", VA = "0x1822E9620")]
	public static void FJDDOAMPLAM(KKBBGHNNMHL FDDDLALLBHL, AMNHDLMFHBF FBPLEBAGIGD, GBLAHJLDAAO LNNIDEOEIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x22E9760", Offset = "0x22E8760", VA = "0x1822E9760")]
	public static void NJPGCIKELKA(KKBBGHNNMHL FDDDLALLBHL, AMNHDLMFHBF FBPLEBAGIGD, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x22E9960", Offset = "0x22E8960", VA = "0x1822E9960")]
	public static void OPGICPCMFBH(KKBBGHNNMHL FDDDLALLBHL, AMNHDLMFHBF FBPLEBAGIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x22E9870", Offset = "0x22E8870", VA = "0x1822E9870")]
	public static void OAMFODFIGJO(KKBBGHNNMHL FDDDLALLBHL, AMNHDLMFHBF FBPLEBAGIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x22E95D0", Offset = "0x22E85D0", VA = "0x1822E95D0")]
	public static GBLAHJLDAAO EPOMAMJEFGC(KKBBGHNNMHL FDDDLALLBHL, AMNHDLMFHBF FBPLEBAGIGD)
	{
		return default(GBLAHJLDAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x20BBAB0", Offset = "0x20BAAB0", VA = "0x1820BBAB0")]
	public static T GKHCOIGJEHO<T>(KKBBGHNNMHL FDDDLALLBHL, AMNHDLMFHBF FBPLEBAGIGD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x20BBAD0", Offset = "0x20BAAD0", VA = "0x1820BBAD0")]
	public static T GKHCOIGJEHO<T>(ref CCBEPMNNDHK JEJGBICCBLN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x22E9580", Offset = "0x22E8580", VA = "0x1822E9580")]
	public static GBLAHJLDAAO EPOMAMJEFGC(ref CCBEPMNNDHK JEJGBICCBLN)
	{
		return default(GBLAHJLDAAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[AJHJJBJAJKN(typeof(IAEOFMMJNGC), new string[] { })]
[AKDDBCMDICM(typeof(JGGCCENAKDL))]
public class IAEOFMMJNGC : JLLBLNFOFFK, IDisposable, JGGCCENAKDL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum BEKDAOBFBGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct PADHJJLIGBH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly BEKDAOBFBGM HCPLHADAOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly IAEOFMMJNGC MMMPDDBDDGF;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x22F1DA0", Offset = "0x22F0DA0", VA = "0x1822F1DA0")]
		public PADHJJLIGBH(IAEOFMMJNGC MMMPDDBDDGF, bool ODPGKHJOBHD, uint GDLEDDNCPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x22F1D70", Offset = "0x22F0D70", VA = "0x1822F1D70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class CJMIODGGEFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public struct FMICIABLPHE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private readonly CJMIODGGEFO OFFJFENHOGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly bool BHJNIPFMHOK;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x22DB8F0", Offset = "0x22DA8F0", VA = "0x1822DB8F0")]
			public FMICIABLPHE(CJMIODGGEFO OFFJFENHOGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x22DB8C0", Offset = "0x22DA8C0", VA = "0x1822DB8C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public struct NKOKGNPIEBH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly CJMIODGGEFO OFFJFENHOGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly bool BHJNIPFMHOK;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x22F1C90", Offset = "0x22F0C90", VA = "0x1822F1C90")]
			public NKOKGNPIEBH(CJMIODGGEFO OFFJFENHOGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x22DB8C0", Offset = "0x22DA8C0", VA = "0x1822DB8C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly IAEOFMMJNGC JICGPMEJOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private bool MOIDIKHFPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int BEHEODMFJAB;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x22DB2D0", Offset = "0x22DA2D0", VA = "0x1822DB2D0")]
		public CJMIODGGEFO(IAEOFMMJNGC JICGPMEJOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x22DB250", Offset = "0x22DA250", VA = "0x1822DB250")]
		public bool EJDGKJLDIGD(LEPNJELBIPF DOMFNFDEEKP, IHCHEEIIPON FANBLFBADKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x22DB280", Offset = "0x22DA280", VA = "0x1822DB280")]
		public NKOKGNPIEBH FDNAIDKCPKC()
		{
			return default(NKOKGNPIEBH);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x22DB200", Offset = "0x22DA200", VA = "0x1822DB200")]
		public FMICIABLPHE DFKKPDLDKPJ()
		{
			return default(FMICIABLPHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KMLMLDOFPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public IAEOFMMJNGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KMLMLDOFPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x22EAF00", Offset = "0x22E9F00", VA = "0x1822EAF00")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OKBGIMAPCEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public IAEOFMMJNGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OKBGIMAPCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x22F1D00", Offset = "0x22F0D00", VA = "0x1822F1D00")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OALOLDAAICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public OALOLDAAICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x22F1CD0", Offset = "0x22F0CD0", VA = "0x1822F1CD0")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly UndoAction DNPMHFACCHN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly RedoAction JNNAEEKIJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private FDIGLPDLAAP BHDLLCODKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private ActionBuffer JMBOILILPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private ActionBuffer ILMGFPHGOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private DNEKLGPFBJJ PLFMGNDCBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private AEIBKDJMAOL OHPLIINOKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private TransformOwnershipPhase KOCJCDHCNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HOGENMBOPJP OGLKJJCGNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private BEKDAOBFBGM BJKMPNCNFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private uint MELKNNFLKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private uint AAFFOHKJBJK;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private CJMIODGGEFO IHDKCELHFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB620", Offset = "0x5EA620", VA = "0x1805EB620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool BEJPKLCCNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x22DF670", Offset = "0x22DE670", VA = "0x1822DF670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EAMGBCOKDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x22DEC50", Offset = "0x22DDC50", VA = "0x1822DEC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KBHDBKHPFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x22DF470", Offset = "0x22DE470", VA = "0x1822DF470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int NODINCAHANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x22DFC60", Offset = "0x22DEC60", VA = "0x1822DFC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int BMCGPAEPFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x22DFC40", Offset = "0x22DEC40", VA = "0x1822DFC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool CNANHDAONDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x22DF370", Offset = "0x22DE370", VA = "0x1822DF370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private bool MBKELMBADLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x22E0110", Offset = "0x22DF110", VA = "0x1822E0110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool GOGDOHMLCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x740AB0", Offset = "0x73FAB0", VA = "0x180740AB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x740B00", Offset = "0x73FB00", VA = "0x180740B00", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private ActionBuffer AAEHMGFINNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22DF4C0", Offset = "0x22DE4C0", VA = "0x1822DF4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DDGBADIIBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x22DF0A0", Offset = "0x22DE0A0", VA = "0x1822DF0A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22DF6C0", Offset = "0x22DE6C0", VA = "0x1822DF6C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action HDEKOPLKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x22DF250", Offset = "0x22DE250", VA = "0x1822DF250")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x22DF1B0", Offset = "0x22DE1B0", VA = "0x1822DF1B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x22E04A0", Offset = "0x22DF4A0", VA = "0x1822E04A0")]
	public IAEOFMMJNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22DFF60", Offset = "0x22DEF60", VA = "0x1822DFF60", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x22DF380", Offset = "0x22DE380", VA = "0x1822DF380", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x22DFAA0", Offset = "0x22DEAA0", VA = "0x1822DFAA0", Slot = "14")]
	public IDisposable JLPMPOAMNFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x22DF2F0", Offset = "0x22DE2F0", VA = "0x1822DF2F0", Slot = "9")]
	public IDisposable DNOBAKACBPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x22DED50", Offset = "0x22DDD50", VA = "0x1822DED50", Slot = "6")]
	public UndoAction AMHKMCJJPEN()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x22DF870", Offset = "0x22DE870", VA = "0x1822DF870", Slot = "15")]
	public RedoAction IMGLIBKJBEK()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22E0340", Offset = "0x22DF340", VA = "0x1822E0340", Slot = "16")]
	public UndoAction OONHIAEPLAE()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x22DF780", Offset = "0x22DE780", VA = "0x1822DF780", Slot = "7")]
	public RedoAction IMGLIBKJBEK(UndoAction GBMKJAJEAAG)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x22E0250", Offset = "0x22DF250", VA = "0x1822E0250", Slot = "8")]
	public UndoAction OONHIAEPLAE(RedoAction GBMKJAJEAAG)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x22DF940", Offset = "0x22DE940", VA = "0x1822DF940")]
	public bool JEAGPHOCPHH(LGKAONPFABK KJDDCNNNJIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x22DFF10", Offset = "0x22DEF10", VA = "0x1822DFF10", Slot = "17")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x22DECA0", Offset = "0x22DDCA0", VA = "0x1822DECA0")]
	public void AJLJIKOPIAK(LEPNJELBIPF DOMFNFDEEKP, GBLAHJLDAAO LNNIDEOEIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x22E0120", Offset = "0x22DF120", VA = "0x1822E0120")]
	public void ONIPHEALBPA(LEPNJELBIPF DOMFNFDEEKP, IHCHEEIIPON FANBLFBADKJ, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x22DFD10", Offset = "0x22DED10", VA = "0x1822DFD10")]
	public void KNBOODEBKCH(LEPNJELBIPF DOMFNFDEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22DF900", Offset = "0x22DE900", VA = "0x1822DF900")]
	private void IMKLHIKFFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x22DFEB0", Offset = "0x22DEEB0", VA = "0x1822DFEB0")]
	private void LBBNIHNIOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x22DF760", Offset = "0x22DE760", VA = "0x1822DF760")]
	private void ILGIICLKEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x22DF580", Offset = "0x22DE580", VA = "0x1822DF580")]
	private OKBMOAJPKLI HOBGAGKIMKM()
	{
		return default(OKBMOAJPKLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x22DF4A0", Offset = "0x22DE4A0", VA = "0x1822DF4A0")]
	private uint EJMIFAKAPHO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x22DF6A0", Offset = "0x22DE6A0", VA = "0x1822DF6A0")]
	private bool IDGAKCFPMNM(out OKBMOAJPKLI BBNMGAFNKKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x22DFEF0", Offset = "0x22DEEF0", VA = "0x1822DFEF0")]
	private bool LNJAKHKJIDI(out OKBMOAJPKLI BBNMGAFNKKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22E01F0", Offset = "0x22DF1F0", VA = "0x1822E01F0")]
	private RedoAction ONMGHEBNKLF(OKBMOAJPKLI BBNMGAFNKKA)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x22DFCB0", Offset = "0x22DECB0", VA = "0x1822DFCB0")]
	private UndoAction KKMPIGEKDML(OKBMOAJPKLI BBNMGAFNKKA)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x22DEDE0", Offset = "0x22DDDE0", VA = "0x1822DEDE0")]
	private OKBMOAJPKLI BCHGCNCAOCD(OKBMOAJPKLI BBNMGAFNKKA, ActionBuffer FHPKLHEPCLM, bool ODPGKHJOBHD)
	{
		return default(OKBMOAJPKLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x22DF4D0", Offset = "0x22DE4D0", VA = "0x1822DF4D0")]
	private void GPGJOGFJDNI(Action BBNMGAFNKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x20B4E40", Offset = "0x20B3E40", VA = "0x1820B4E40")]
	private T GPGJOGFJDNI<T>(Func<T> AANJPPGPHEO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x22DF140", Offset = "0x22DE140", VA = "0x1822DF140")]
	private PADHJJLIGBH CDNJMDHFINC(bool ODPGKHJOBHD, uint GDLEDDNCPGJ)
	{
		return default(PADHJJLIGBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x22DFDB0", Offset = "0x22DEDB0", VA = "0x1822DFDB0")]
	[CompilerGenerated]
	private UndoAction KOEJEFHHLIK()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x22DFB20", Offset = "0x22DEB20", VA = "0x1822DFB20")]
	[CompilerGenerated]
	private RedoAction KGPEAFGCOMA()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x22DF990", Offset = "0x22DE990", VA = "0x1822DF990")]
	[CompilerGenerated]
	private UndoAction JHGOFIJGHMB()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KKBBGHNNMHL : IEnumerable<AMNHDLMFHBF>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum LKJELABHFEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct CDMLKNJLLIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly KKBBGHNNMHL DMCFFMAPNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly HOGENMBOPJP OGLKJJCGNGG;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x22DB1C0", Offset = "0x22DA1C0", VA = "0x1822DB1C0")]
		public CDMLKNJLLIC(KKBBGHNNMHL DMCFFMAPNPG, HOGENMBOPJP OGLKJJCGNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x22DADD0", Offset = "0x22D9DD0", VA = "0x1822DADD0")]
		public void PAIPCKMBAAG(NativeList<byte> GHCLMNIOMFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x22DA920", Offset = "0x22D9920", VA = "0x1822DA920")]
		private void CMPFBOCHKPM(AMNHDLMFHBF FBPLEBAGIGD, ref BDGHGDOFBAA KBMDIJPKDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x22DAB20", Offset = "0x22D9B20", VA = "0x1822DAB20")]
		private void NFGKNCOLFLO(AMNHDLMFHBF FBPLEBAGIGD, ref BDGHGDOFBAA KBMDIJPKDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x22DA970", Offset = "0x22D9970", VA = "0x1822DA970")]
		private NativeArray<byte> DDEKHLLFLMI(NativeList<byte> GHCLMNIOMFH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x22DAA50", Offset = "0x22D9A50", VA = "0x1822DAA50")]
		private NativeArray<byte> MKJGCKGFNFM(NativeList<byte> GHCLMNIOMFH, int BPGPLFOLHKN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x22DABB0", Offset = "0x22D9BB0", VA = "0x1822DABB0")]
		private int NNEAGOKCKGB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x22DB060", Offset = "0x22DA060", VA = "0x1822DB060")]
		private bool PCLAGPADHPK(AMNHDLMFHBF FBPLEBAGIGD, out NativeArray<byte> FJHBDGHDOPI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct KFHJHOLCNIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NativeList<byte> JEJGBICCBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private KKBBGHNNMHL DMCFFMAPNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly AMNHDLMFHBF LAAFNHPNJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly int HNIIDPMJKFI;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x22E93B0", Offset = "0x22E83B0", VA = "0x1822E93B0")]
		internal KFHJHOLCNIN(KKBBGHNNMHL DMCFFMAPNPG, AMNHDLMFHBF LAAFNHPNJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x22E9180", Offset = "0x22E8180", VA = "0x1822E9180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x22E91B0", Offset = "0x22E81B0", VA = "0x1822E91B0")]
		public void JJNFCECIIBN(NativeArray<byte> JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x22E9120", Offset = "0x22E8120", VA = "0x1822E9120")]
		public void DLOEJLBDAAE(NativeArray<byte> JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x22E93A0", Offset = "0x22E83A0", VA = "0x1822E93A0")]
		public void NFGKNCOLFLO(in JHBOMEIKHGC JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3482850", Offset = "0x3481850", VA = "0x183482850")]
		public void NFGKNCOLFLO<T>(T JNLOLNFALGF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x22E9330", Offset = "0x22E8330", VA = "0x1822E9330")]
		private void LHEEEAJKIGC(int JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x22E9270", Offset = "0x22E8270", VA = "0x1822E9270")]
		private void LHEEEAJKIGC(in JHBOMEIKHGC JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x22E9210", Offset = "0x22E8210", VA = "0x1822E9210")]
		private unsafe void LHEEEAJKIGC(void* FPOEEAAIAOF, int BPGPLFOLHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x22E91B0", Offset = "0x22E81B0", VA = "0x1822E91B0")]
		private void LHEEEAJKIGC(NativeArray<byte> LCEEDPEAPOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct DEPDIHHEDJE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KKBBGHNNMHL DMCFFMAPNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private NativeArray<byte> JEJGBICCBLN;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x22DB7C0", Offset = "0x22DA7C0", VA = "0x1822DB7C0")]
		internal DEPDIHHEDJE(KKBBGHNNMHL DMCFFMAPNPG, NativeArray<byte> JEJGBICCBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x22DB650", Offset = "0x22DA650", VA = "0x1822DB650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x22DB660", Offset = "0x22DA660", VA = "0x1822DB660")]
		public NativeArray<byte> IPLDAFHMJHE(int BPGPLFOLHKN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x22DB750", Offset = "0x22DA750", VA = "0x1822DB750")]
		public NativeArray<byte> PDAMFMNPHOD()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x20B15F0", Offset = "0x20B05F0", VA = "0x1820B15F0")]
		public T BIPIOFMHMKH<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x22DB5D0", Offset = "0x22DA5D0", VA = "0x1822DB5D0")]
		public void BIPIOFMHMKH(in PFFLIKLDNNB JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct GMLNALLBDPB : IEnumerator<AMNHDLMFHBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly NativeArray<AMNHDLMFHBF> DNAEDFOPGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int IIHEDPBOLFE;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public AMNHDLMFHBF EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x22DBD70", Offset = "0x22DAD70", VA = "0x1822DBD70", Slot = "4")]
			get
			{
				return default(AMNHDLMFHBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x22DBD10", Offset = "0x22DAD10", VA = "0x1822DBD10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x22DBD60", Offset = "0x22DAD60", VA = "0x1822DBD60")]
		internal GMLNALLBDPB(NativeArray<AMNHDLMFHBF> LCEEDPEAPOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x22DBC40", Offset = "0x22DAC40", VA = "0x1822DBC40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x22DBCC0", Offset = "0x22DACC0", VA = "0x1822DBCC0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct GPLOMMDBDHE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private const int FICBNBIFIJK = 0;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int NOOJCKLLBNN = 1;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const int DJMABCDMKLI = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private NativeArray<int> JEJGBICCBLN;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public int ACIMNGDKGJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x22DC7D0", Offset = "0x22DB7D0", VA = "0x1822DC7D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x22DC920", Offset = "0x22DB920", VA = "0x1822DC920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LKJELABHFEP IEGMPCHGFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x22DC8F0", Offset = "0x22DB8F0", VA = "0x1822DC8F0")]
			get
			{
				return default(LKJELABHFEP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x22DC900", Offset = "0x22DB900", VA = "0x1822DC900")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool JMDIBNPIEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x22DC8B0", Offset = "0x22DB8B0", VA = "0x1822DC8B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x22DC7E0", Offset = "0x22DB7E0", VA = "0x1822DC7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HIENEIBDNCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x22DC8C0", Offset = "0x22DB8C0", VA = "0x1822DC8C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x22DC8D0", Offset = "0x22DB8D0", VA = "0x1822DC8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x22DC930", Offset = "0x22DB930", VA = "0x1822DC930")]
		public GPLOMMDBDHE(LKJELABHFEP IDOOFJDLHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x22DC840", Offset = "0x22DB840", VA = "0x1822DC840")]
		private int FGPHONIFMEK(int KDGOCEAMMLM, int GLJICBGGBGH = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x22DC870", Offset = "0x22DB870", VA = "0x1822DC870")]
		private void GALDMPBHILF(int KDGOCEAMMLM, int JNLOLNFALGF, int GLJICBGGBGH = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x22DC800", Offset = "0x22DB800", VA = "0x1822DC800", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int IGPPAMKOICF = -1;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int IHBGMIEFMEN = 0;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly AMNHDLMFHBF OJFBPGEBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeHashMap<AMNHDLMFHBF, int> KKNJHCIOIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private NativeList<AMNHDLMFHBF> FDDDLALLBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<int> LJEMHLCKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<byte> OKFMMIEBPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private NativeList<byte> JEJGBICCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GPLOMMDBDHE JAGFDHABEOM;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool JMDIBNPIEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x22EA860", Offset = "0x22E9860", VA = "0x1822EA860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool LEKJNLDEGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x22EAAD0", Offset = "0x22E9AD0", VA = "0x1822EAAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int ACIMNGDKGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x22EA0B0", Offset = "0x22E90B0", VA = "0x1822EA0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int JNLPHIGKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA90", Offset = "0x22E9A90", VA = "0x1822EAA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x22EA4C0", Offset = "0x22E94C0", VA = "0x1822EA4C0")]
	public static KKBBGHNNMHL FBMLCAAKPML(LKJELABHFEP IDOOFJDLHKE = LKJELABHFEP.Last, int OGCINJDAJAD = 16, int MKPDLKHKECC = 256)
	{
		return default(KKBBGHNNMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x22EACB0", Offset = "0x22E9CB0", VA = "0x1822EACB0")]
	private KKBBGHNNMHL(LKJELABHFEP IDOOFJDLHKE, int OGCINJDAJAD, int MKPDLKHKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x22EA3F0", Offset = "0x22E93F0", VA = "0x1822EA3F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x22EA770", Offset = "0x22E9770", VA = "0x1822EA770")]
	public KFHJHOLCNIN HMKHODOKAIG(AMNHDLMFHBF LAAFNHPNJCJ)
	{
		return default(KFHJHOLCNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x22EA520", Offset = "0x22E9520", VA = "0x1822EA520")]
	public DEPDIHHEDJE GCEEFIJDLEH(AMNHDLMFHBF LAAFNHPNJCJ)
	{
		return default(DEPDIHHEDJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x22EA0C0", Offset = "0x22E90C0", VA = "0x1822EA0C0")]
	public bool BMCACDKAAEG(AMNHDLMFHBF LAAFNHPNJCJ, out DEPDIHHEDJE FCPNDPIDFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x22EA600", Offset = "0x22E9600", VA = "0x1822EA600")]
	public bool GEMHEEKLIGA(AMNHDLMFHBF LAAFNHPNJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x22EA650", Offset = "0x22E9650", VA = "0x1822EA650")]
	public bool GFDEKLBGFLC(AMNHDLMFHBF LAAFNHPNJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x22EA870", Offset = "0x22E9870", VA = "0x1822EA870")]
	public void LFACEBPMOPP(NativeList<byte> GHCLMNIOMFH, HOGENMBOPJP OGLKJJCGNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x20BC190", Offset = "0x20BB190", VA = "0x1820BC190")]
	public T KDDIPPKHHEK<T>(AMNHDLMFHBF LAAFNHPNJCJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x22EAA00", Offset = "0x22E9A00", VA = "0x1822EAA00")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x22EA700", Offset = "0x22E9700", VA = "0x1822EA700")]
	public GMLNALLBDPB GMHPDHEDPBP()
	{
		return default(GMLNALLBDPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x22EA230", Offset = "0x22E9230", VA = "0x1822EA230")]
	private void CPNCMBHOJLC(AMNHDLMFHBF LAAFNHPNJCJ, int HNIIDPMJKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x22EA940", Offset = "0x22E9940", VA = "0x1822EA940")]
	private void LHHPDLCPANN(int OEFFILJKDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x22EAAE0", Offset = "0x22E9AE0", VA = "0x1822EAAE0")]
	private void PEJBJAKPGNH(AMNHDLMFHBF LAAFNHPNJCJ, int HNIIDPMJKFI, int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x20BC110", Offset = "0x20BB110", VA = "0x1820BC110")]
	private static T KDDIPPKHHEK<T>(NativeArray<byte> DNAEDFOPGEJ, int KDGOCEAMMLM = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x22EABF0", Offset = "0x22E9BF0", VA = "0x1822EABF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x22EABA0", Offset = "0x22E9BA0", VA = "0x1822EABA0", Slot = "4")]
	private IEnumerator<AMNHDLMFHBF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BFEBPLODMOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private NativeArray<byte> DNAEDFOPGEJ;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x670670", VA = "0x180671670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xD5DB80", Offset = "0xD5CB80", VA = "0x180D5DB80")]
	public BFEBPLODMOK(NativeArray<byte> DNAEDFOPGEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2451CA0", Offset = "0x2450CA0", VA = "0x182451CA0")]
	public static BFEBPLODMOK BNLFJABIBKP(NativeArray<byte> DNAEDFOPGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	public T BIPIOFMHMKH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	public NativeArray<T> IPLDAFHMJHE<T>(int BPGPLFOLHKN, Allocator LKNIKCJFBFH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	public NativeArray<T> PDAMFMNPHOD<T>(Allocator LKNIKCJFBFH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class CCBEPMNNDHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private NativeArray<byte> DNAEDFOPGEJ;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x670670", VA = "0x180671670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xD5DB80", Offset = "0xD5CB80", VA = "0x180D5DB80")]
	public CCBEPMNNDHK(NativeArray<byte> DNAEDFOPGEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2454030", Offset = "0x2453030", VA = "0x182454030")]
	public static CCBEPMNNDHK BNLFJABIBKP(NativeArray<byte> DNAEDFOPGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3220D10", Offset = "0x321FD10", VA = "0x183220D10")]
	public T BIPIOFMHMKH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	public NativeArray<T> IPLDAFHMJHE<T>(int BPGPLFOLHKN, Allocator LKNIKCJFBFH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BDGHGDOFBAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NativeArray<byte> DNAEDFOPGEJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x670670", VA = "0x180671670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xD5DB80", Offset = "0xD5CB80", VA = "0x180D5DB80")]
	public BDGHGDOFBAA(NativeArray<byte> DNAEDFOPGEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x244E260", Offset = "0x244D260", VA = "0x18244E260")]
	public static BDGHGDOFBAA BNLFJABIBKP(NativeArray<byte> DNAEDFOPGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2279A70", Offset = "0x2278A70", VA = "0x182279A70")]
	public void BHCIBAKODMK<T>(in T JNLOLNFALGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2279AD0", Offset = "0x2278AD0", VA = "0x182279AD0")]
	public void CCEINOGIAPA<T>(NativeArray<T> LCEEDPEAPOI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	public void LKCBDKGHEOH<T>(NativeArray<T> JNLOLNFALGF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HEKLOGFALDB
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x22DCF90", Offset = "0x22DBF90", VA = "0x1822DCF90")]
	public static Span<byte> HAAIBMCFMIJ(this NativeArray<byte> DNAEDFOPGEJ)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x22DCDB0", Offset = "0x22DBDB0", VA = "0x1822DCDB0")]
	public static ReadOnlySpan<byte> BAFDJICAILF(this NativeArray<byte> DNAEDFOPGEJ)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x22DCF20", Offset = "0x22DBF20", VA = "0x1822DCF20")]
	public static NativeArray<byte> CEHEMIJGMLP(this NativeArray<byte> DNAEDFOPGEJ, int HNIIDPMJKFI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x22DD170", Offset = "0x22DC170", VA = "0x1822DD170")]
	public static NativeArray<byte> LGBAKICGFCC(this NativeArray<byte> DNAEDFOPGEJ, int FBKJALIBHGM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x35EC2A0", Offset = "0x35EB2A0", VA = "0x1835EC2A0")]
	public static NativeArray<byte> LGBAKICGFCC<T>(this NativeArray<byte> DNAEDFOPGEJ, int FBKJALIBHGM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x22DD100", Offset = "0x22DC100", VA = "0x1822DD100")]
	public static NativeArray<byte> JKNNJHONMPH(this NativeArray<byte> DNAEDFOPGEJ, int FBKJALIBHGM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x35EC240", Offset = "0x35EB240", VA = "0x1835EC240")]
	public static NativeArray<byte> JKNNJHONMPH<T>(this NativeArray<byte> DNAEDFOPGEJ, int FBKJALIBHGM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x22DD1E0", Offset = "0x22DC1E0", VA = "0x1822DD1E0")]
	public static NativeArray<byte> OPOOKJOPJPN(this NativeArray<byte> DNAEDFOPGEJ, int FBKJALIBHGM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x35EC300", Offset = "0x35EB300", VA = "0x1835EC300")]
	public static NativeArray<byte> OPOOKJOPJPN<T>(this NativeArray<byte> DNAEDFOPGEJ, int FBKJALIBHGM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class EAMAHAPINAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private NativeList<byte> DMCFFMAPNPG;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0xD5DB80", Offset = "0xD5CB80", VA = "0x180D5DB80")]
	public EAMAHAPINAI(NativeList<byte> DMCFFMAPNPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2459860", Offset = "0x2458860", VA = "0x182459860")]
	public static EAMAHAPINAI BNLFJABIBKP(NativeList<byte> DNAEDFOPGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	public void BHCIBAKODMK<T>(in T JNLOLNFALGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	public void CCEINOGIAPA<T>(NativeArray<T> JNLOLNFALGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	public void LKCBDKGHEOH<T>(NativeArray<T> JNLOLNFALGF) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[AJHJJBJAJKN(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.PropertyChanges)]
	public class PropertyChangeNetworkRouter : ICFGAFHALNE, JLLBLNFOFFK, FPDLPCMACEI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private FDIGLPDLAAP KFPPFLMHIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private PLOPIJBJNLI FDGBHFMGIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MCABEJDLNDK BIPGBCJBJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private OHFJMLDBPPF LIKJIIOLPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private AMNHDLMFHBF FBPLEBAGIGD;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public FDIGLPDLAAP OCKJCJMOKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x25F0FF0", Offset = "0x25EFFF0", VA = "0x1825F0FF0")]
		public FDIGLPDLAAP.AOBGCGAALPI APIKBJLGFMK()
		{
			return default(FDIGLPDLAAP.AOBGCGAALPI);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x25F14A0", Offset = "0x25F04A0", VA = "0x1825F14A0", Slot = "4")]
		public void LDGKFGFMALP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x25F1530", Offset = "0x25F0530", VA = "0x1825F1530", Slot = "5")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x25F0EA0", Offset = "0x25EFEA0", VA = "0x1825F0EA0")]
		public void AMHKMCJJPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x25F1240", Offset = "0x25F0240", VA = "0x1825F1240")]
		private void HMKHODOKAIG(AMNHDLMFHBF LAAFNHPNJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x25F1110", Offset = "0x25F0110", VA = "0x1825F1110")]
		private void FJDDOAMPLAM(AMNHDLMFHBF LAAFNHPNJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x25F15E0", Offset = "0x25F05E0", VA = "0x1825F15E0")]
		private void OPGICPCMFBH(AMNHDLMFHBF LAAFNHPNJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x25F15C0", Offset = "0x25F05C0", VA = "0x1825F15C0")]
		private void OMDOGEMOOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x25F1010", Offset = "0x25F0010", VA = "0x1825F1010")]
		private void APNCHJCOEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x25F1080", Offset = "0x25F0080", VA = "0x1825F1080")]
		private void EAMMMNGFHDB(AMNHDLMFHBF LAAFNHPNJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2443460", Offset = "0x2442460", VA = "0x182443460", Slot = "6")]
		private void ENBHOAABFKO<TKey, T>(global::FGMALPJKBFM<TKey, T> KIMANJPEJBL, object GENOAILOCON) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x25F1050", Offset = "0x25F0050", VA = "0x1825F1050", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[AJHJJBJAJKN(typeof(BGBAGCLIJGJ), new string[] { })]
public class BGBAGCLIJGJ : JLLBLNFOFFK, HLHBDIEKOND
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly DLNJCBHMFKD NCFPAGIALKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private GENADPIHFPM KCDOCJCLLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private ONNFHGLOINK BIPGBCJBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private IAEOFMMJNGC JICGPMEJOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private PropertyChangeNetworkRouter OCFJCIBMEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private IHCHEEIIPON BKMBMPIOIDN;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2452210", Offset = "0x2451210", VA = "0x182452210", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x24522C0", Offset = "0x24512C0", VA = "0x1824522C0", Slot = "5")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2451D00", Offset = "0x2450D00", VA = "0x182451D00")]
	public void AJLJIKOPIAK(LEPNJELBIPF DOMFNFDEEKP, GBLAHJLDAAO LNNIDEOEIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2452390", Offset = "0x2451390", VA = "0x182452390")]
	public void ONIPHEALBPA(LEPNJELBIPF DOMFNFDEEKP, IHCHEEIIPON FANBLFBADKJ, in JHBOMEIKHGC ABILOJCAOKC, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2451E40", Offset = "0x2450E40", VA = "0x182451E40")]
	public void KNBOODEBKCH(LEPNJELBIPF DOMFNFDEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2451E20", Offset = "0x2450E20", VA = "0x182451E20")]
	private void CCJHJNFAKOK(LEPNJELBIPF DOMFNFDEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2452070", Offset = "0x2451070", VA = "0x182452070")]
	public void MHFJPKMMEHA(LEPNJELBIPF DOMFNFDEEKP, IHCHEEIIPON FANBLFBADKJ, in JHBOMEIKHGC ABILOJCAOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x24520A0", Offset = "0x24510A0", VA = "0x1824520A0")]
	private void MJBMNFIAHHH(LEPNJELBIPF DOMFNFDEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2452460", Offset = "0x2451460", VA = "0x182452460")]
	public BGBAGCLIJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal abstract class EDEAGEMKMKN : JLLBLNFOFFK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private DNEKLGPFBJJ PLFMGNDCBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private uint EHELFOLBOHF;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract uint LKOHGJILAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2459A30", Offset = "0x2458A30", VA = "0x182459A30", Slot = "7")]
	public virtual void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2459930", Offset = "0x2458930", VA = "0x182459930", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x24598E0", Offset = "0x24588E0", VA = "0x1824598E0")]
	public LEPNJELBIPF AKMMFAIAEEF()
	{
		return default(LEPNJELBIPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x24599B0", Offset = "0x24589B0", VA = "0x1824599B0")]
	public void EOEOHDIMDFN(LEPNJELBIPF BHCDOJDBCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2459AD0", Offset = "0x2458AD0", VA = "0x182459AD0", Slot = "8")]
	public virtual void PJOAAHNBHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected EDEAGEMKMKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[AJHJJBJAJKN(typeof(NPENDFHJAMB), new string[] { })]
internal sealed class NPENDFHJAMB : EDEAGEMKMKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private uint PKMKIJMDLOD;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override uint LKOHGJILAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5E6390", Offset = "0x5E5390", VA = "0x1805E6390", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x25EBA10", Offset = "0x25EAA10", VA = "0x1825EBA10", Slot = "7")]
	public override void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x25EB9C0", Offset = "0x25EA9C0", VA = "0x1825EB9C0")]
	private void LLLEJNAFHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x25EBAB0", Offset = "0x25EAAB0", VA = "0x1825EBAB0", Slot = "8")]
	public override void PJOAAHNBHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	public NPENDFHJAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[AJHJJBJAJKN(typeof(EHLHIDEMKGD), new string[] { })]
internal sealed class EHLHIDEMKGD : EDEAGEMKMKN
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public override uint LKOHGJILAID
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x612E80", Offset = "0x611E80", VA = "0x180612E80", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EHLHIDEMKGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[AJHJJBJAJKN(typeof(OIMMLNOJGIH), new string[] { })]
public class LKHOMIGLOCD : OIMMLNOJGIH
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x25E51E0", Offset = "0x25E41E0", VA = "0x1825E51E0", Slot = "5")]
	public void DGKCKFFGBGH(object LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x25E52A0", Offset = "0x25E42A0", VA = "0x1825E52A0", Slot = "6")]
	public void FDJKJPGFFHO(object LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x25E5360", Offset = "0x25E4360", VA = "0x1825E5360", Slot = "7")]
	public void JEFDHGPPBJM(object LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x25E5420", Offset = "0x25E4420", VA = "0x1825E5420", Slot = "4")]
	public IDisposable LAENFJJODHK(object LPDLECBMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LKHOMIGLOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[AJHJJBJAJKN(typeof(NACHGIEDHED), new string[] { })]
[KBDAHOGMDPL(typeof(GDEFGFJPJEE))]
internal sealed class NACHGIEDHED : LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private EntityQuery AAONJAKBFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EntityQuery DHLBKBLGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EntityQuery GFKHFPLBGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x25E93C0", Offset = "0x25E83C0", VA = "0x1825E93C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EntityQuery JJCCJJBKLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xF57420", Offset = "0xF56420", VA = "0x180F57420")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public EntityQuery NDLOBHMGOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C70", Offset = "0x8E5C70", VA = "0x1808E6C70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityQuery EENBIDIAFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x25E9080", Offset = "0x25E8080", VA = "0x1825E9080")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int LNGJEDOBDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x25E9660", Offset = "0x25E8660", VA = "0x1825E9660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int ACNBOELAKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x25E9060", Offset = "0x25E8060", VA = "0x1825E9060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int MLAPKJGIAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x25E9300", Offset = "0x25E8300", VA = "0x1825E9300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "4")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x25E9410", Offset = "0x25E8410", VA = "0x1825E9410", Slot = "5")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x25E9490", Offset = "0x25E8490", VA = "0x1825E9490", Slot = "6")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x25E91B0", Offset = "0x25E81B0", VA = "0x1825E91B0")]
	public OLEFECDLOJC HLOPDOJKMPF()
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x25E8DC0", Offset = "0x25E7DC0", VA = "0x1825E8DC0")]
	public OLEFECDLOJC AFEPKNKFHKB()
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x25E9320", Offset = "0x25E8320", VA = "0x1825E9320")]
	public OLEFECDLOJC MBEEFBFIOBF()
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x25E8F70", Offset = "0x25E7F70", VA = "0x1825E8F70")]
	public DPLBJNFOOGD DNMIJANHDJP(KOHKPOMNCDA DOMFNFDEEKP)
	{
		return default(DPLBJNFOOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x25E8EC0", Offset = "0x25E7EC0", VA = "0x1825E8EC0")]
	public DPLBJNFOOGD DNMIJANHDJP(Entity CLCJGDKEGGN)
	{
		return default(DPLBJNFOOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x25E9100", Offset = "0x25E8100", VA = "0x1825E9100")]
	public DAGBJECOPFG GPKCJONBIJA(Entity CLCJGDKEGGN)
	{
		return default(DAGBJECOPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x25E9020", Offset = "0x25E8020", VA = "0x1825E9020", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x25E9250", Offset = "0x25E8250", VA = "0x1825E9250")]
	private OLEFECDLOJC IOHIILKMOFL(EntityQuery FHCACFJLPLH)
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x25E9680", Offset = "0x25E8680", VA = "0x1825E9680")]
	public NACHGIEDHED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[AJHJJBJAJKN(typeof(NPGLNNOGMJJ), new string[] { })]
public class ILNDGOAAKPM : JLLBLNFOFFK, NPGLNNOGMJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private ObjectLifecycleService HEPCCGNPEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private ObjectEmbodimentService INGBFIDDJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ObjectPrefabCreationService LMDAFICOHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private ObjectNetworkToLocalMapService KMJAKBJOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NACHGIEDHED DJBJNOPKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private DNEKLGPFBJJ PLFMGNDCBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LPPOJAOPNMP FALFHKCLHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x22E4790", Offset = "0x22E3790", VA = "0x1822E4790", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x22E5020", Offset = "0x22E4020", VA = "0x1822E5020")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int LNGJEDOBDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x22E57B0", Offset = "0x22E47B0", VA = "0x1822E57B0", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int ACNBOELAKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x22E4700", Offset = "0x22E3700", VA = "0x1822E4700", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int MLAPKJGIAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x22E4C50", Offset = "0x22E3C50", VA = "0x1822E4C50", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int OBJKPBJHGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x22E54D0", Offset = "0x22E44D0", VA = "0x1822E54D0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int FAICENAGFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x22E4720", Offset = "0x22E3720", VA = "0x1822E4720", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<KOHKPOMNCDA, DAGBJECOPFG> LNCEKBPPJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x22E4CB0", Offset = "0x22E3CB0", VA = "0x1822E4CB0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x22E5710", Offset = "0x22E4710", VA = "0x1822E5710", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<KOHKPOMNCDA> LEAEOMEIGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x22E57D0", Offset = "0x22E47D0", VA = "0x1822E57D0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x22E49D0", Offset = "0x22E39D0", VA = "0x1822E49D0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x22E51B0", Offset = "0x22E41B0", VA = "0x1822E51B0", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x22E4870", Offset = "0x22E3870", VA = "0x1822E4870")]
	private void GHLIEIGNDDH(Entity CLCJGDKEGGN, DAGBJECOPFG FMMJPPJOKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x22E4320", Offset = "0x22E3320", VA = "0x1822E4320")]
	private void DACKPNMMLLM(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x22E5070", Offset = "0x22E4070", VA = "0x1822E5070")]
	internal KOHKPOMNCDA NDKHJCMPBCP(Entity CLCJGDKEGGN)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x22E4E60", Offset = "0x22E3E60", VA = "0x1822E4E60", Slot = "36")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	private void KPICIFFJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x22E4450", Offset = "0x22E3450", VA = "0x1822E4450", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x22E4A90", Offset = "0x22E3A90", VA = "0x1822E4A90", Slot = "11")]
	public OLEFECDLOJC HLOPDOJKMPF()
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x22E40C0", Offset = "0x22E30C0", VA = "0x1822E40C0", Slot = "41")]
	public OLEFECDLOJC AFEPKNKFHKB()
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x22E4E20", Offset = "0x22E3E20", VA = "0x1822E4E20", Slot = "42")]
	public OLEFECDLOJC MBEEFBFIOBF()
	{
		return default(OLEFECDLOJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x22E4420", Offset = "0x22E3420", VA = "0x1822E4420", Slot = "12")]
	public DPLBJNFOOGD DNMIJANHDJP(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(DPLBJNFOOGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x22E4910", Offset = "0x22E3910", VA = "0x1822E4910", Slot = "13")]
	public DAGBJECOPFG GPKCJONBIJA(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(DAGBJECOPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x22E46D0", Offset = "0x22E36D0", VA = "0x1822E46D0", Slot = "35")]
	public bool EFMFIFBCNEK(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x22E4B30", Offset = "0x22E3B30", VA = "0x1822E4B30", Slot = "31")]
	public void IOLIAPLKMKF(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x22E43D0", Offset = "0x22E33D0", VA = "0x1822E43D0", Slot = "32")]
	public void DJOODIHFILB(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x22E4AD0", Offset = "0x22E3AD0", VA = "0x1822E4AD0", Slot = "33")]
	public void IIELMNGPPGF(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x22E4B00", Offset = "0x22E3B00", VA = "0x1822E4B00", Slot = "37")]
	public void ILENIMAGOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x22E4100", Offset = "0x22E3100", VA = "0x1822E4100", Slot = "25")]
	public AANBNAJPLKI AJLJIKOPIAK(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(AANBNAJPLKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x22E3F90", Offset = "0x22E2F90", VA = "0x1822E3F90", Slot = "26")]
	public AANBNAJPLKI ADKCLGNHFKO(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(AANBNAJPLKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x22E53F0", Offset = "0x22E43F0", VA = "0x1822E53F0", Slot = "27")]
	public AANBNAJPLKI NOOPGDGEFHO(LEPNJELBIPF POJMBOCFKCO, DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(AANBNAJPLKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x22E4010", Offset = "0x22E3010", VA = "0x1822E4010", Slot = "28")]
	public EJAMINLFEBK AEMLADDGEBB()
	{
		return default(EJAMINLFEBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x22E4180", Offset = "0x22E3180", VA = "0x1822E4180", Slot = "43")]
	public FFCIDFJJPCD BCMPONPKHEH(DGJNFBKJHDF GLKKDGLKBMK)
	{
		return default(FFCIDFJJPCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x22E4D50", Offset = "0x22E3D50", VA = "0x1822E4D50", Slot = "29")]
	public KBELILGODHB LMNIFMEEHLB()
	{
		return default(KBELILGODHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x22E4B80", Offset = "0x22E3B80", VA = "0x1822E4B80", Slot = "30")]
	public KPKHBNNAAFJ JLMKOLAGOCN(HHBAPNOMDDB GLKKDGLKBMK)
	{
		return default(KPKHBNNAAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x22E49B0", Offset = "0x22E39B0", VA = "0x1822E49B0", Slot = "15")]
	public void HCCDLMMPDLB(LEPNJELBIPF POJMBOCFKCO, PHJBPPLEHIN BOGFGFMBOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x22E50A0", Offset = "0x22E40A0", VA = "0x1822E50A0", Slot = "16")]
	public AANBNAJPLKI NGDCLNMLMAP(KOHKPOMNCDA FCJPDBMFAED, [Optional] object KGJPBGICHFN)
	{
		return default(AANBNAJPLKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x22E4740", Offset = "0x22E3740", VA = "0x1822E4740", Slot = "17")]
	public bool FGIFIJDGKBN(KOHKPOMNCDA FCJPDBMFAED, out PHJBPPLEHIN HCBFPGACPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x22E53A0", Offset = "0x22E43A0", VA = "0x1822E53A0", Slot = "45")]
	public Transform NOMJMALOIDD(KOHKPOMNCDA FCJPDBMFAED, [Optional] object KGJPBGICHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x22E42B0", Offset = "0x22E32B0", VA = "0x1822E42B0", Slot = "19")]
	public bool CEGPBCBCDIN(KOHKPOMNCDA FCJPDBMFAED, out Transform BCLIDGMJFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x22E4830", Offset = "0x22E3830", VA = "0x1822E4830", Slot = "20")]
	public bool GFPEMECKFMF(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x22E4230", Offset = "0x22E3230", VA = "0x1822E4230")]
	public bool BDIFMCBODED(PHJBPPLEHIN JNLOLNFALGF, [Optional] object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x22E4250", Offset = "0x22E3250", VA = "0x1822E4250", Slot = "46")]
	public bool BDIFMCBODED(KOHKPOMNCDA FCJPDBMFAED, [Optional] object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x22E43B0", Offset = "0x22E33B0", VA = "0x1822E43B0", Slot = "47")]
	public void DILGBHLLKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x22E54F0", Offset = "0x22E44F0", VA = "0x1822E54F0", Slot = "18")]
	public void OCGNEBKLGCG(PHJBPPLEHIN MDAEAKFNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x22E4950", Offset = "0x22E3950", VA = "0x1822E4950", Slot = "48")]
	public void HBOLAEKKJIO(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x22E4A70", Offset = "0x22E3A70", VA = "0x1822E4A70", Slot = "21")]
	public void HDDMGGPKOMP(Entity CLCJGDKEGGN, object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x22E4990", Offset = "0x22E3990", VA = "0x1822E4990", Slot = "22")]
	public bool HCAHFLNKCDN(Entity CLCJGDKEGGN, object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x22E5870", Offset = "0x22E4870", VA = "0x1822E5870", Slot = "49")]
	public bool PFFPPMPEKLJ(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x22E4300", Offset = "0x22E3300", VA = "0x1822E4300", Slot = "50")]
	public bool CKEPOEKMENG(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x22E47E0", Offset = "0x22E37E0", VA = "0x1822E47E0", Slot = "34")]
	public NativeArray<(KOHKPOMNCDA, KOHKPOMNCDA)> GFIIDEDDJDP(NativeArray<KOHKPOMNCDA> HPLGMMOLONA, Allocator LKNIKCJFBFH)
	{
		return default(NativeArray<(KOHKPOMNCDA, KOHKPOMNCDA)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x22E4280", Offset = "0x22E3280", VA = "0x1822E4280", Slot = "24")]
	public LEPNJELBIPF BEPHKEGICMG(KOHKPOMNCDA FCJPDBMFAED)
	{
		return default(LEPNJELBIPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x22E4C70", Offset = "0x22E3C70", VA = "0x1822E4C70", Slot = "23")]
	public KOHKPOMNCDA KMPFPHIPBGN(LEPNJELBIPF POJMBOCFKCO)
	{
		return default(KOHKPOMNCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public ILNDGOAAKPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AJHJJBJAJKN(typeof(DHEFEACOKOG), new string[] { })]
internal sealed class DHEFEACOKOG : JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private ObjectPrefabCreationService LMDAFICOHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private NACHGIEDHED DJBJNOPKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IEPEPKBAJCN BICCGEMNLEI;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x24583E0", Offset = "0x24573E0", VA = "0x1824583E0", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x24580B0", Offset = "0x24570B0", VA = "0x1824580B0")]
	public NativeArray<(KOHKPOMNCDA, KOHKPOMNCDA)> GFIIDEDDJDP(NativeArray<KOHKPOMNCDA> HPLGMMOLONA, Allocator LKNIKCJFBFH)
	{
		return default(NativeArray<(KOHKPOMNCDA, KOHKPOMNCDA)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2457B20", Offset = "0x2456B20", VA = "0x182457B20")]
	private void AGJJIPPHGJA(NativeMultiHashMap<int, (KOHKPOMNCDA src, KOHKPOMNCDA dst)> KDNMJDHAHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x24581E0", Offset = "0x24571E0", VA = "0x1824581E0")]
	private void MAOBIOEKHFK(NativeMultiHashMap<int, (KOHKPOMNCDA src, KOHKPOMNCDA dst)> KDNMJDHAHAK, int FMMJPPJOKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2457CB0", Offset = "0x2456CB0", VA = "0x182457CB0")]
	private void CAKEMHHGFAE(NativeMultiHashMap<int, (KOHKPOMNCDA src, KOHKPOMNCDA dst)> KDNMJDHAHAK, int FMMJPPJOKHJ, OIINEGGMHHI BIPGBCJBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2457E30", Offset = "0x2456E30", VA = "0x182457E30")]
	private NativeMultiHashMap<int, (KOHKPOMNCDA, KOHKPOMNCDA)> ELKKMGBEIJP(Allocator LKNIKCJFBFH, NativeArray<KOHKPOMNCDA> HPLGMMOLONA, out NativeArray<(KOHKPOMNCDA src, KOHKPOMNCDA dst)> BJDHDPKKBEL)
	{
		return default(NativeMultiHashMap<int, (KOHKPOMNCDA, KOHKPOMNCDA)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DHEFEACOKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[AJHJJBJAJKN(typeof(ECPIEEADKBG), new string[] { })]
public class KJOOKAFKHOA : JLLBLNFOFFK, ECPIEEADKBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private EntityManager EFLHIHFKEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private FOLFFNLGEBO JOPIDAAMFMP;

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x22E9F70", Offset = "0x22E8F70", VA = "0x1822E9F70", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x22EA000", Offset = "0x22E9000", VA = "0x1822EA000", Slot = "5")]
	public void OMNANJHPIFM(KOHKPOMNCDA FCJPDBMFAED, Vector3 JMDAEBODFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x22E9E50", Offset = "0x22E8E50", VA = "0x1822E9E50", Slot = "6")]
	public bool HDCOGHLAPJH(KOHKPOMNCDA FCJPDBMFAED, out Collider PIGJAIJJEON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KJOOKAFKHOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class JJDILOOPLML : DBNAIJNECBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly string CBMBABOOALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly JJDILOOPLML IFGNKMJNIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly List<JJDILOOPLML> FEOCCHJKAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly List<KIOJMOHAOIF> BIPGBCJBJEE;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public string NJHKIHEEACF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public DBNAIJNECBP EILGCMCOGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public IEnumerable<DBNAIJNECBP> IHINMCCIKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IEnumerable<KIOJMOHAOIF> NIMHCIPCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x22E7E60", Offset = "0x22E6E60", VA = "0x1822E7E60")]
	public JJDILOOPLML(string MBHNCPMPIFB, JJDILOOPLML ACNNFDIAAFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[KBDAHOGMDPL(typeof(GCAMLONMMPC))]
[AJHJJBJAJKN(typeof(NFDEIMDAILO), new string[] { })]
public sealed class HELPECLALAJ : NFDEIMDAILO, LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class NELOJCMFMBO : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x22F1820", Offset = "0x22F0820", VA = "0x1822F1820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7D0", Offset = "0xA0D7D0", VA = "0x180A0E7D0")]
		[DebuggerHidden]
		public NELOJCMFMBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x22F1520", Offset = "0x22F0520", VA = "0x1822F1520", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x22F17D0", Offset = "0x22F07D0", VA = "0x1822F17D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x22F1730", Offset = "0x22F0730", VA = "0x1822F1730", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x22F1730", Offset = "0x22F0730", VA = "0x1822F1730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly DKMNPOBAPGG ECLLBIKJBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<string, JJDILOOPLML> CDOAADBFHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private GCAMLONMMPC BIPGBCJBJEE;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DBNAIJNECBP AGPANFINBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x22DD4E0", Offset = "0x22DC4E0", VA = "0x1822DD4E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x22DDEA0", Offset = "0x22DCEA0", VA = "0x1822DDEA0", Slot = "6")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x22DDF00", Offset = "0x22DCF00", VA = "0x1822DDF00", Slot = "7")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x22DD2F0", Offset = "0x22DC2F0", VA = "0x1822DD2F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x22DDB50", Offset = "0x22DCB50", VA = "0x1822DDB50")]
	private void IDCOMJMLCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x22DD540", Offset = "0x22DC540", VA = "0x1822DD540")]
	private void GEIPOGLHNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x22DD340", Offset = "0x22DC340", VA = "0x1822DD340")]
	private JJDILOOPLML EAJFHPGLEPN(string NIFBEFJMEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x22DD4E0", Offset = "0x22DC4E0", VA = "0x1822DD4E0")]
	private JJDILOOPLML FKOKNGOELHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x22DD6C0", Offset = "0x22DC6C0", VA = "0x1822DD6C0")]
	private JJDILOOPLML HELLDJDIIGC(string NIFBEFJMEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x22DD9D0", Offset = "0x22DC9D0", VA = "0x1822DD9D0")]
	private JJDILOOPLML IAFMLDJLNCA(string LLBPEMIKGCJ, string KGJPBGICHFN, [Optional] JJDILOOPLML IFGNKMJNIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x22DD3A0", Offset = "0x22DC3A0", VA = "0x1822DD3A0")]
	[IteratorStateMachine(typeof(NELOJCMFMBO))]
	private IEnumerable<(string, string)> ENJCNKJLDKC(string NIFBEFJMEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x22DD2A0", Offset = "0x22DC2A0", VA = "0x1822DD2A0")]
	private bool CFMILDDFHII(KIOJMOHAOIF KIMANJPEJBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x22DD910", Offset = "0x22DC910", VA = "0x1822DD910")]
	private DKMNPOBAPGG HNGDBALDDAL(KIOJMOHAOIF KIMANJPEJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x22DD250", Offset = "0x22DC250", VA = "0x1822DD250")]
	private DKMNPOBAPGG BPMCCIGNLMO(KIOJMOHAOIF KIMANJPEJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x22DDE30", Offset = "0x22DCE30", VA = "0x1822DDE30")]
	private DKMNPOBAPGG ILMHEDEMOKL(KIOJMOHAOIF KIMANJPEJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x20B4560", Offset = "0x20B3560", VA = "0x1820B4560")]
	private T JIBAKGHJDPL<T>(KIOJMOHAOIF KIMANJPEJBL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x22DD410", Offset = "0x22DC410", VA = "0x1822DD410")]
	private FieldInfo FBBGHGNOBCG(KIOJMOHAOIF KIMANJPEJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x22DDFC0", Offset = "0x22DCFC0", VA = "0x1822DDFC0")]
	public HELPECLALAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x22DDF20", Offset = "0x22DCF20", VA = "0x1822DDF20")]
	[CompilerGenerated]
	private int OODBFPNHJOK(KIOJMOHAOIF KKHMNCLOHHK, KIOJMOHAOIF GMPKOOIGMDG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[KBDAHOGMDPL(typeof(BDBHLANIDEN))]
[AJHJJBJAJKN(typeof(ONNFHGLOINK), new string[] { })]
[DefaultMember("Item")]
public class ADPKHMGNIIL : ONNFHGLOINK, IEnumerable<FOHAFCOAAJF>, IEnumerable, LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Dictionary<(Type, string), int> BPFIPMJJKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BDBHLANIDEN BIPGBCJBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private FIOMBJHKMOL FKBOOGEEFKF;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x244B400", Offset = "0x244A400", VA = "0x18244B400", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public FOHAFCOAAJF AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x244AF40", Offset = "0x2449F40", VA = "0x18244AF40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public FOHAFCOAAJF AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x244AF40", Offset = "0x2449F40", VA = "0x18244AF40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x244B070", Offset = "0x244A070", VA = "0x18244B070", Slot = "11")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x244B0C0", Offset = "0x244A0C0", VA = "0x18244B0C0", Slot = "12")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "13")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x244B140", Offset = "0x244A140", VA = "0x18244B140")]
	private void OKJPJGMHKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D62B50", Offset = "0x1D61B50", VA = "0x181D62B50")]
	private string KIDNMGDNKHJ(string MBHNCPMPIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x244ABD0", Offset = "0x2449BD0", VA = "0x18244ABD0", Slot = "7")]
	public FOHAFCOAAJF EFHLHKJAKGM(KDOFIACDKKK JPOEBAHCHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x244ACD0", Offset = "0x2449CD0", VA = "0x18244ACD0")]
	private bool HBAFIOHELLE(Type GPBPHMJHPIL, string MBHNCPMPIFB, out FOHAFCOAAJF EDJOONFFAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x244AF60", Offset = "0x2449F60", VA = "0x18244AF60", Slot = "8")]
	public IHCHEEIIPON KKIECCDJOCP(KDOFIACDKKK JPOEBAHCHNJ)
	{
		return default(IHCHEEIIPON);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x244ACB0", Offset = "0x2449CB0", VA = "0x18244ACB0", Slot = "9")]
	public IEnumerator<FOHAFCOAAJF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x244ACB0", Offset = "0x2449CB0", VA = "0x18244ACB0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x244B420", Offset = "0x244A420", VA = "0x18244B420")]
	public ADPKHMGNIIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[DefaultMember("Item")]
public interface HOGENMBOPJP
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDMPILHAGFK(IHCHEEIIPON LGBAJKGIPMA, out int CCDDIFMMPAN);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
[AJHJJBJAJKN(typeof(HOGENMBOPJP), new string[] { })]
[KBDAHOGMDPL(typeof(MCABEJDLNDK))]
public class IHFNPBGEIEC : JLLBLNFOFFK, HLHBDIEKOND, HOGENMBOPJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<IHCHEEIIPON, int> IGHCDNDCDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private MCABEJDLNDK BIPGBCJBJEE;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x22E1870", Offset = "0x22E0870", VA = "0x1822E1870", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x22E1800", Offset = "0x22E0800", VA = "0x1822E1800", Slot = "6")]
	public bool FDMPILHAGFK(IHCHEEIIPON LGBAJKGIPMA, out int CCDDIFMMPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x22E18D0", Offset = "0x22E08D0", VA = "0x1822E18D0", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x22E1930", Offset = "0x22E0930", VA = "0x1822E1930", Slot = "5")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x22E15B0", Offset = "0x22E05B0", VA = "0x1822E15B0")]
	private void CLFFOIBHJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x22E1940", Offset = "0x22E0940", VA = "0x1822E1940")]
	public IHFNPBGEIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[AJHJJBJAJKN(typeof(MCABEJDLNDK), new string[] { })]
[KBDAHOGMDPL(typeof(ONNFHGLOINK))]
[DefaultMember("Item")]
public class OOGDIKJDPBB : MCABEJDLNDK, IEnumerable<PNEIOOPEEOE>, IEnumerable, LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, FPDLPCMACEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private ONNFHGLOINK GCBOGJMONDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private PNEIOOPEEOE[] EDHKJBGEKCE;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x25EE790", Offset = "0x25ED790", VA = "0x1825EE790", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PNEIOOPEEOE AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x25EE0D0", Offset = "0x25ED0D0", VA = "0x1825EE0D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public PNEIOOPEEOE AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x25EE0D0", Offset = "0x25ED0D0", VA = "0x1825EE0D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "10")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x25EE500", Offset = "0x25ED500", VA = "0x1825EE500", Slot = "11")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "12")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x25EE250", Offset = "0x25ED250", VA = "0x1825EE250", Slot = "6")]
	public PNEIOOPEEOE EFHLHKJAKGM(KDOFIACDKKK JPOEBAHCHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x25EE430", Offset = "0x25ED430", VA = "0x1825EE430", Slot = "7")]
	public IHCHEEIIPON KKIECCDJOCP(KDOFIACDKKK JPOEBAHCHNJ)
	{
		return default(IHCHEEIIPON);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x25EE380", Offset = "0x25ED380", VA = "0x1825EE380", Slot = "8")]
	public IEnumerator<PNEIOOPEEOE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x25EE7A0", Offset = "0x25ED7A0", VA = "0x1825EE7A0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D82950", Offset = "0x2D81950", VA = "0x182D82950", Slot = "13")]
	public void CHEGJJPCLGL<TKey, T>(global::FGMALPJKBFM<TKey, T> KIMANJPEJBL, [Optional] object GENOAILOCON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x25EE110", Offset = "0x25ED110", VA = "0x1825EE110", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public OOGDIKJDPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x25EE0D0", Offset = "0x25ED0D0", VA = "0x1825EE0D0")]
	[CompilerGenerated]
	private PNEIOOPEEOE DCPCLOHLAHN(int BJNKEHJJEBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
[KBDAHOGMDPL(typeof(ONNFHGLOINK))]
[AJHJJBJAJKN(typeof(GCAMLONMMPC), new string[] { })]
public class IHGGGAEDDBO : GCAMLONMMPC, IEnumerable<KIOJMOHAOIF>, IEnumerable, LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, FPDLPCMACEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private ONNFHGLOINK GCBOGJMONDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private KIOJMOHAOIF[] EDHKJBGEKCE;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x22E1E90", Offset = "0x22E0E90", VA = "0x1822E1E90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KIOJMOHAOIF AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x22E19B0", Offset = "0x22E09B0", VA = "0x1822E19B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KIOJMOHAOIF AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x22E19B0", Offset = "0x22E09B0", VA = "0x1822E19B0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x22E1E10", Offset = "0x22E0E10", VA = "0x1822E1E10", Slot = "8")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x22E1EE0", Offset = "0x22E0EE0", VA = "0x1822E1EE0", Slot = "9")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x22E1C60", Offset = "0x22E0C60", VA = "0x1822E1C60")]
	private KIOJMOHAOIF IMKNPGABBGH(int IIHEDPBOLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x22E1A60", Offset = "0x22E0A60", VA = "0x1822E1A60", Slot = "4")]
	public KIOJMOHAOIF EFHLHKJAKGM(KDOFIACDKKK JPOEBAHCHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x22E1D40", Offset = "0x22E0D40", VA = "0x1822E1D40", Slot = "15")]
	public IHCHEEIIPON KKIECCDJOCP(KDOFIACDKKK JPOEBAHCHNJ)
	{
		return default(IHCHEEIIPON);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x22E1B80", Offset = "0x22E0B80", VA = "0x1822E1B80", Slot = "5")]
	public IEnumerator<KIOJMOHAOIF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x22E1B80", Offset = "0x22E0B80", VA = "0x1822E1B80", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3477C40", Offset = "0x3476C40", VA = "0x183477C40", Slot = "10")]
	public void CHEGJJPCLGL<TKey, T>(global::FGMALPJKBFM<TKey, T> KIMANJPEJBL, [Optional] object GENOAILOCON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x22E19C0", Offset = "0x22E09C0", VA = "0x1822E19C0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public IHGGGAEDDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x22E19B0", Offset = "0x22E09B0", VA = "0x1822E19B0")]
	[CompilerGenerated]
	private KIOJMOHAOIF BEFNOAHBNMH(int BJNKEHJJEBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[AJHJJBJAJKN(typeof(BDBHLANIDEN), new string[] { })]
[KBDAHOGMDPL(typeof(GDEFGFJPJEE))]
internal class BDBHLANIDEN : JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private ONNFHGLOINK GCBOGJMONDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GCAMLONMMPC IDEEGOJBCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private MCABEJDLNDK PKABOHONCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private global::LCJIKJFODKN<OIINEGGMHHI> FBFPPNOCINM;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public FIOMBJHKMOL LCCNICFLDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6020", Offset = "0x5E5020", VA = "0x1805E6020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x244E160", Offset = "0x244D160", VA = "0x18244E160", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x244DE00", Offset = "0x244CE00", VA = "0x18244DE00")]
	private void ADFONNMLOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1CB27E0", Offset = "0x1CB17E0", VA = "0x181CB27E0")]
	public T MGDGJDMKMED<T>() where T : OIINEGGMHHI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x244DFC0", Offset = "0x244CFC0", VA = "0x18244DFC0")]
	public FOHAFCOAAJF LNEPKKJBGCK(KDOFIACDKKK MBHNCPMPIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	public global::PFPLEKPHCDD<T> LNEPKKJBGCK<T>(KDOFIACDKKK MBHNCPMPIFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x244DEF0", Offset = "0x244CEF0", VA = "0x18244DEF0")]
	public KIOJMOHAOIF JDBLICDGNEC(KDOFIACDKKK MBHNCPMPIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2607B20", Offset = "0x2606B20", VA = "0x182607B20")]
	public global::MBEEMLIGNHG<T> JDBLICDGNEC<T>(KDOFIACDKKK MBHNCPMPIFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x244E090", Offset = "0x244D090", VA = "0x18244E090")]
	public PNEIOOPEEOE NJJJLKINMJJ(KDOFIACDKKK MBHNCPMPIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	public global::HPOCEEOKAHH<T> NJJJLKINMJJ<T>(KDOFIACDKKK MBHNCPMPIFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public BDBHLANIDEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal static class MKNJHBHHLLB
{
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3F40", Offset = "0x2DE2F40", VA = "0x182DE3F40")]
	public static global::PFPLEKPHCDD<T> LNEPKKJBGCK<T>(this BDBHLANIDEN IEGBOFDKLDL, global::KBDGAEOCIJO<T> MBHNCPMPIFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	public static global::MBEEMLIGNHG<T> JDBLICDGNEC<T>(this BDBHLANIDEN IEGBOFDKLDL, global::KBDGAEOCIJO<T> MBHNCPMPIFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	public static global::HPOCEEOKAHH<T> NJJJLKINMJJ<T>(this BDBHLANIDEN IEGBOFDKLDL, global::KBDGAEOCIJO<T> MBHNCPMPIFB) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AJHJJBJAJKN(typeof(CADMDJPHMJB), new string[] { })]
public sealed class CADMDJPHMJB : JLLBLNFOFFK, HLHBDIEKOND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class PMJKKENKCHE : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public PMJKKENKCHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x24621D0", Offset = "0x24611D0", VA = "0x1824621D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2461E50", Offset = "0x2460E50", VA = "0x182461E50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2462270", Offset = "0x2461270", VA = "0x182462270")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2462180", Offset = "0x2461180", VA = "0x182462180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x24620F0", Offset = "0x24610F0", VA = "0x1824620F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x24620F0", Offset = "0x24610F0", VA = "0x1824620F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private const string DDHMMHIJLOG = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Dictionary<SerializableGuid, MMDFPOBNGDD> JBNLJNNCINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<SerializableGuid> JFBFKKMEBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Dictionary<SerializableGuid, GameObject> LMDAFICOHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private GCAMLONMMPC BIPGBCJBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private LNBNALGBLNP PCCGLMCDMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private PHHIOCMBCOD OPCFMFLMDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private global::AFCDMLCBFJK<MMDFPOBNGDD> GDOOJCNEKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private GameObject OKBKJILMFNG;

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2453950", Offset = "0x2452950", VA = "0x182453950", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2453A20", Offset = "0x2452A20", VA = "0x182453A20", Slot = "5")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2452CA0", Offset = "0x2451CA0", VA = "0x182452CA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2453B80", Offset = "0x2452B80", VA = "0x182453B80")]
	private void PJDAKHFGKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x24528C0", Offset = "0x24518C0", VA = "0x1824528C0")]
	internal void DNKGOJIKOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x24526F0", Offset = "0x24516F0", VA = "0x1824526F0")]
	private void CEODMGJADDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2453820", Offset = "0x2452820", VA = "0x182453820")]
	private void KJDNDPMEMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2452690", Offset = "0x2451690", VA = "0x182452690")]
	[IteratorStateMachine(typeof(PMJKKENKCHE))]
	private IEnumerable<RRCustomPropTag> ADNLJFMONPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x24533F0", Offset = "0x24523F0", VA = "0x1824533F0")]
	private void HEFOHMHDELN(KOHKPOMNCDA FCJPDBMFAED, in JHBOMEIKHGC LONPLGOFNDA, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x24532E0", Offset = "0x24522E0", VA = "0x1824532E0")]
	private void HCCDLMMPDLB(SerializableGuid BEAFCMKDKCM, GameObject PKGBHIMGLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2452FA0", Offset = "0x2451FA0", VA = "0x182452FA0")]
	private void GNDMNHGJALC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2452DF0", Offset = "0x2451DF0", VA = "0x182452DF0")]
	private bool FLDFIFFBOMG(MMDFPOBNGDD GNAGAJLCJEF, Transform ACNNFDIAAFM, out GameObject HBFLGBMAKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2453900", Offset = "0x2452900", VA = "0x182453900")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2453B90", Offset = "0x2452B90", VA = "0x182453B90")]
	public CADMDJPHMJB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public SerializableGuid CLOMADBLONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x25F1690", Offset = "0x25F0690", VA = "0x1825F1690")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[AJHJJBJAJKN(typeof(FNLCMFIELCM), new string[] { })]
public class AKLEFOHKKNI : FNLCMFIELCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool FILEONBOEAH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool PKMIMJMPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6107B0", Offset = "0x60F7B0", VA = "0x1806107B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x244C8C0", Offset = "0x244B8C0", VA = "0x18244C8C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<bool> BLGFPINPGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x244C820", Offset = "0x244B820", VA = "0x18244C820", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x244C780", Offset = "0x244B780", VA = "0x18244C780", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AKLEFOHKKNI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[AJHJJBJAJKN(typeof(LNBNALGBLNP), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.Serialization, new string[] { "Timing" })]
	public class SerializationService : JLLBLNFOFFK, LNBNALGBLNP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private struct COJOJLNKBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public JCLEHLLEPDD IEJMLMIKBLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public JCLEHLLEPDD FAFFEIEHHNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public JCLEHLLEPDD FGLILMFCPOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public JCLEHLLEPDD KPFOPNDFIKJ;

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x25E0A80", Offset = "0x25DFA80", VA = "0x1825E0A80")]
			public static COJOJLNKBFP GICBDFIFCOH()
			{
				return default(COJOJLNKBFP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			[Conditional("DEBUG_WORLDS")]
			public void BPKDLHEEJPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private struct JCLEHLLEPDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			public JCLEHLLEPDD(string EDHFNBOOHPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			public void LKIMLIILGCE(EntityManager EDHFNBOOHPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			public void BPKDLHEEJPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private const string HALEFLHPOGL = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly LOBJLOAJGBA CEFCPMDHDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private CAJHOBCLJCD HNBMHDKILBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private GDEFGFJPJEE BICCGEMNLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private FNLCMFIELCM LOBEAGCCMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private SerializationRemapScope POIOFCLFNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private NACHGIEDHED DJBJNOPKDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private EBDAILEDHGD FNFCCHLINDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private bool? AFPNNPBGPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private COJOJLNKBFP ODMAKKHBCIK;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool NHMHAOHGGNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x25F3F30", Offset = "0x25F2F30", VA = "0x1825F3F30", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x25F2DA0", Offset = "0x25F1DA0", VA = "0x1825F2DA0", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action OCIFGHECBGC
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x25F3DF0", Offset = "0x25F2DF0", VA = "0x1825F3DF0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x25F3E90", Offset = "0x25F2E90", VA = "0x1825F3E90", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<HGONJGDBLML> BNEGBLOLEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x25F4A80", Offset = "0x25F3A80", VA = "0x1825F4A80", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x25F3CB0", Offset = "0x25F2CB0", VA = "0x1825F3CB0", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action GPDLHBNPNLK
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x25F4890", Offset = "0x25F3890", VA = "0x1825F4890", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x25F3630", Offset = "0x25F2630", VA = "0x1825F3630", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action OLLHEEINIKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x25F2360", Offset = "0x25F1360", VA = "0x1825F2360", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x25F4BB0", Offset = "0x25F3BB0", VA = "0x1825F4BB0", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<HGONJGDBLML> JCEKAEOLNEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x25F2120", Offset = "0x25F1120", VA = "0x1825F2120", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x25F3A40", Offset = "0x25F2A40", VA = "0x1825F3A40", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x25F4790", Offset = "0x25F3790", VA = "0x1825F4790", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x25F4930", Offset = "0x25F3930", VA = "0x1825F4930", Slot = "11")]
		public void PHHOPNEJCJN(bool EOODJCKPPBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x25F42D0", Offset = "0x25F32D0", VA = "0x1825F42D0", Slot = "13")]
		public ByteString NJADPKHDAEC(out IDisposable POIOFCLFNHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x25F4530", Offset = "0x25F3530", VA = "0x1825F4530", Slot = "12")]
		public ByteString NJADPKHDAEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x25F3D50", Offset = "0x25F2D50", VA = "0x1825F3D50", Slot = "16")]
		public bool HIDKAFCIGIB(ByteString AJJEOGPCFEC, ELIOLIHHMNH AANEECAEOLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x25F2ED0", Offset = "0x25F1ED0", VA = "0x1825F2ED0", Slot = "17")]
		public bool FACFGOLJGDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x25F4290", Offset = "0x25F3290", VA = "0x1825F4290", Slot = "14")]
		public void MCOMHNMOOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x25F2C00", Offset = "0x25F1C00", VA = "0x1825F2C00", Slot = "27")]
		public void EALLKOGKNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x25F21C0", Offset = "0x25F11C0", VA = "0x1825F21C0", Slot = "15")]
		public void APJJEIFHEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x25F3410", Offset = "0x25F2410", VA = "0x1825F3410", Slot = "18")]
		public bool FGEIEBCGEFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x25F2400", Offset = "0x25F1400", VA = "0x1825F2400", Slot = "19")]
		public bool CKMKAGGNKLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x25F46E0", Offset = "0x25F36E0", VA = "0x1825F46E0")]
		private void NKPGBJEDPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xF419A0", Offset = "0xF409A0", VA = "0x180F419A0")]
		private void MNKEJHAHALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x25F2DB0", Offset = "0x25F1DB0", VA = "0x1825F2DB0")]
		private void EONKCMNBKCE(OAOHFOPDGKM FFPCMEINODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x25F3D90", Offset = "0x25F2D90", VA = "0x1825F3D90")]
		private ByteString HMNHLMDECME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x25F3FD0", Offset = "0x25F2FD0", VA = "0x1825F3FD0")]
		private ByteString KKBKHICFAGD(ByteString OBPMMCCMALJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x25F42A0", Offset = "0x25F32A0", VA = "0x1825F42A0")]
		private bool MMNAHACMHMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x25F36D0", Offset = "0x25F26D0", VA = "0x1825F36D0")]
		private void FLHGIEGBBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x25F1D90", Offset = "0x25F0D90", VA = "0x1825F1D90")]
		private void AGIIMJNABGJ(out ByteString OBPMMCCMALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x25F2650", Offset = "0x25F1650", VA = "0x1825F2650")]
		private bool CNCCIOABIDD(ByteString AJJEOGPCFEC, ELIOLIHHMNH AANEECAEOLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x25F2950", Offset = "0x25F1950", VA = "0x1825F2950")]
		private bool DFBBLPLJPIO(ByteString AJJEOGPCFEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x25F3AE0", Offset = "0x25F2AE0", VA = "0x1825F3AE0")]
		private bool GIKDBIFFKIC(EBDAILEDHGD.EPJJGEGOKGB.GIIMLFPKEKL ONBOLLJEEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x25F2FA0", Offset = "0x25F1FA0", VA = "0x1825F2FA0")]
		private void FFNGCCFPPHK(HGONJGDBLML FFPCMEINODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x25F3F40", Offset = "0x25F2F40", VA = "0x1825F3F40")]
		private OAOHFOPDGKM KABAIPGMAIN(EntityManager OAAKHOOJOIO, EntityManager CBANNNBOFKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x25F3250", Offset = "0x25F2250", VA = "0x1825F3250")]
		private void FGEAKJBPGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x25F40D0", Offset = "0x25F30D0", VA = "0x1825F40D0")]
		private void MCOHOPDDOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x25F20E0", Offset = "0x25F10E0", VA = "0x1825F20E0")]
		private void AHCDDHJHGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x25F4B20", Offset = "0x25F3B20", VA = "0x1825F4B20")]
		private EBDAILEDHGD.EPJJGEGOKGB.GIIMLFPKEKL PIACCBMHNHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AJHJJBJAJKN(typeof(JEGHEMFEFKE), new string[] { })]
public class JEGHEMFEFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Dictionary<HHBAPNOMDDB, string> HIBGMLGMMMB;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x22E7B50", Offset = "0x22E6B50", VA = "0x1822E7B50")]
	public GameObject OLKHLFMOHNO(HHBAPNOMDDB IPHLPPKIBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x22E7C00", Offset = "0x22E6C00", VA = "0x1822E7C00")]
	public JEGHEMFEFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[AJHJJBJAJKN(typeof(CILIJHOHMLN), new string[] { })]
public class EPPODLBOGAD : JLLBLNFOFFK, CILIJHOHMLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private ODLHGLDEJDN APDMJJFKEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private FNLCMFIELCM HODLHJHPHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private TransformOwnershipPhase KOCJCDHCNAO;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x245B120", Offset = "0x245A120", VA = "0x18245B120", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x245AE00", Offset = "0x2459E00", VA = "0x18245AE00", Slot = "6")]
	public void DKHMOAAPHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x245AF00", Offset = "0x2459F00", VA = "0x18245AF00", Slot = "5")]
	public void FCAINOGDHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x245B1D0", Offset = "0x245A1D0", VA = "0x18245B1D0", Slot = "7")]
	public void OJNIBIIPOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x245B360", Offset = "0x245A360", VA = "0x18245B360", Slot = "8")]
	public void PNLEHPKLAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x245B000", Offset = "0x245A000", VA = "0x18245B000", Slot = "9")]
	public void JCDONPMFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x245B2F0", Offset = "0x245A2F0", VA = "0x18245B2F0", Slot = "10")]
	public void PCKBACMCGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x245AD60", Offset = "0x2459D60", VA = "0x18245AD60", Slot = "11")]
	public void DDJAPHHFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EPPODLBOGAD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[AJHJJBJAJKN(typeof(INJCNOHDGPO), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.TransformSyncing)]
	public class TransformService : INJCNOHDGPO, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GDEFGFJPJEE BICCGEMNLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private IHJGKBGCMLD ELOOMINKHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TransformOwnershipPhase GONGAFDKIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private global::PFPLEKPHCDD<Entity> ACNNFDIAAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private ObjectEmbodimentService PIKHCAFAOHP;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private EntityManager OLPNKMBFBCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x57747F0", Offset = "0x57737F0", VA = "0x1857747F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private PHHIOCMBCOD NOINFEGLIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x5770E90", Offset = "0x576FE90", VA = "0x185770E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5774D10", Offset = "0x5773D10", VA = "0x185774D10", Slot = "32")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5775140", Offset = "0x5774140", VA = "0x185775140", Slot = "33")]
		public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5771EF0", Offset = "0x5770EF0", VA = "0x185771EF0", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5774850", Offset = "0x5773850", VA = "0x185774850", Slot = "35")]
		public bool NAJEHIEKMPO(Transform BCLIDGMJFFC, out KOHKPOMNCDA FCJPDBMFAED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x57735F0", Offset = "0x57725F0", VA = "0x1857735F0", Slot = "36")]
		public Transform IEDINKEFEBC(Entity CLCJGDKEGGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5770F50", Offset = "0x576FF50", VA = "0x185770F50", Slot = "30")]
		public bool CEGPBCBCDIN(Entity CLCJGDKEGGN, out Transform BCLIDGMJFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x57743D0", Offset = "0x57733D0", VA = "0x1857743D0")]
		private void MDLOGACMMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5773420", Offset = "0x5772420", VA = "0x185773420", Slot = "29")]
		public void HKLMIDIFLKB(Entity CLCJGDKEGGN, out Matrix4x4 JDLLDKJGGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x5773DF0", Offset = "0x5772DF0", VA = "0x185773DF0", Slot = "4")]
		public void MACPAJNOKJI(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5773C40", Offset = "0x5772C40", VA = "0x185773C40")]
		private void KOBBPNCAAPK(Entity CLCJGDKEGGN, Vector3 OOJHNKALAAE, Quaternion LOMDKHFBCEH, Vector3 AAJKCMOFKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x57754D0", Offset = "0x57744D0", VA = "0x1857754D0")]
		private void PFCEJKIMDOK(Entity CLCJGDKEGGN, Vector3 OOJHNKALAAE, Quaternion LOMDKHFBCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x57757B0", Offset = "0x57747B0", VA = "0x1857757B0", Slot = "27")]
		public void PFLHGBBDJEP(Entity CLCJGDKEGGN, out Matrix4x4 HMDIPICBOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5770230", Offset = "0x576F230", VA = "0x185770230")]
		public void AFFDABBPCJA(Entity CLCJGDKEGGN, in Matrix4x4 JDLLDKJGGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5774B00", Offset = "0x5773B00", VA = "0x185774B00")]
		private void NLBHEGIKGPF(Entity CLCJGDKEGGN, in Matrix4x4 FOFOAMPADMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5775620", Offset = "0x5774620", VA = "0x185775620", Slot = "5")]
		public void PFKFACOPMHK(Entity CLCJGDKEGGN, Vector3 JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5771840", Offset = "0x5770840", VA = "0x185771840", Slot = "6")]
		public Vector3 DHNCKHCPDCF(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5774500", Offset = "0x5773500", VA = "0x185774500", Slot = "7")]
		public void MFJPMPDDKCD(Entity CLCJGDKEGGN, Quaternion JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5771D30", Offset = "0x5770D30", VA = "0x185771D30", Slot = "8")]
		public Quaternion DPJFNMBIOBC(Entity CLCJGDKEGGN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5771F70", Offset = "0x5770F70", VA = "0x185771F70", Slot = "12")]
		public void EBIDGCDDIHL(Entity CLCJGDKEGGN, Vector3 JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5772A50", Offset = "0x5771A50", VA = "0x185772A50", Slot = "11")]
		public Vector3 FOKAODPFNKB(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x57708C0", Offset = "0x576F8C0", VA = "0x1857708C0")]
		private void AHNPLFIBPFL(Entity CLCJGDKEGGN, Vector3 JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5770960", Offset = "0x576F960", VA = "0x185770960")]
		private Vector3 AKLOFEHECFE(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x57743F0", Offset = "0x57733F0", VA = "0x1857743F0", Slot = "14")]
		public float MFJIIAMPCKG(Entity CLCJGDKEGGN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x57706E0", Offset = "0x576F6E0", VA = "0x1857706E0", Slot = "13")]
		public void AHHGGGNIOPC(Entity CLCJGDKEGGN, float JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5770C00", Offset = "0x576FC00", VA = "0x185770C00")]
		private float BGDBJIGKMFI(Entity CLCJGDKEGGN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x57717B0", Offset = "0x57707B0", VA = "0x1857717B0")]
		private void DCNLPPDOKPI(Entity CLCJGDKEGGN, float GAHKNMFPFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x57746B0", Offset = "0x57736B0", VA = "0x1857746B0", Slot = "16")]
		public Vector3 MIOGEJONKDA(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5770A30", Offset = "0x576FA30", VA = "0x185770A30", Slot = "15")]
		public void AMIDAJIDBAK(Entity CLCJGDKEGGN, Vector3 EDHJMIDHDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x57749E0", Offset = "0x57739E0", VA = "0x1857749E0")]
		private Vector3 NDGMKLJMBNN(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x5773710", Offset = "0x5772710", VA = "0x185773710")]
		private void KGENEBLNMAM(Entity CLCJGDKEGGN, Vector3 JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x57720E0", Offset = "0x57710E0", VA = "0x1857720E0")]
		[Conditional("DEBUG_BUILD")]
		private void EDKIAIBHAKI(Entity CLCJGDKEGGN, Vector3 JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5775840", Offset = "0x5774840", VA = "0x185775840", Slot = "9")]
		public void PMCIMNFOGHC(Entity CLCJGDKEGGN, out Vector3 IPACGOANALG, out Quaternion DJCGMNLFLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5772C00", Offset = "0x5771C00", VA = "0x185772C00", Slot = "10")]
		public void GHEPKAMAIKE(Entity CLCJGDKEGGN, out Vector3 IPACGOANALG, out Quaternion DJCGMNLFLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5774110", Offset = "0x5773110", VA = "0x185774110", Slot = "17")]
		public void MDFCEIAGOHN(Entity CLCJGDKEGGN, Vector3 JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5772890", Offset = "0x5771890", VA = "0x185772890", Slot = "18")]
		public Vector3 FNNJIHOKDGO(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x57730F0", Offset = "0x57720F0", VA = "0x1857730F0", Slot = "19")]
		public void HKDPLOEEELK(Entity CLCJGDKEGGN, Quaternion JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5772730", Offset = "0x5771730", VA = "0x185772730", Slot = "20")]
		public Quaternion FBIJIDHBFEC(Entity CLCJGDKEGGN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5770FF0", Offset = "0x576FFF0", VA = "0x185770FF0", Slot = "22")]
		public void CGKPGPMPKAF(Entity CLCJGDKEGGN, Vector3 JNLOLNFALGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5772E00", Offset = "0x5771E00", VA = "0x185772E00", Slot = "21")]
		public Vector3 HDLCLIANOIA(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5774DE0", Offset = "0x5773DE0", VA = "0x185774DE0", Slot = "23")]
		public void OGOADMLPFEB(Entity CLCJGDKEGGN, float GGGMPMHDJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5772F70", Offset = "0x5771F70", VA = "0x185772F70", Slot = "24")]
		public float HDOKEONIHJF(Entity CLCJGDKEGGN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x57722A0", Offset = "0x57712A0", VA = "0x1857722A0", Slot = "25")]
		public void EFHKNPGLCKB(Entity CLCJGDKEGGN, Vector3 NEFMHIFPMHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5770CE0", Offset = "0x576FCE0", VA = "0x185770CE0", Slot = "26")]
		public Vector3 BGLCIOHFNCM(Entity CLCJGDKEGGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x57737E0", Offset = "0x57727E0", VA = "0x1857737E0", Slot = "31")]
		public void KNCLBDIFINK(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5771500", Offset = "0x5770500", VA = "0x185771500")]
		private void CIKAOEHIDOM(Entity CLCJGDKEGGN, in JHBOMEIKHGC LONPLGOFNDA, in JHBOMEIKHGC CACEPBECNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x57715C0", Offset = "0x57705C0", VA = "0x1857715C0")]
		private void CIKAOEHIDOM(Entity CLCJGDKEGGN, in Entity JKLPNJODLAC, in Entity LGIBIGENFOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x57757C0", Offset = "0x57747C0", VA = "0x1857757C0")]
		private KELHDFKNJNA PMCIMNFOGHC(Entity CLCJGDKEGGN)
		{
			return default(KELHDFKNJNA);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5771420", Offset = "0x5770420", VA = "0x185771420")]
		private bool CHNHOJPIJGG(Entity CLCJGDKEGGN, out Entity ACNNFDIAAFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5775240", Offset = "0x5774240", VA = "0x185775240")]
		private void OONHENEAIIG(Entity CLCJGDKEGGN, out Matrix4x4 JDLLDKJGGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x57719B0", Offset = "0x57709B0", VA = "0x1857719B0")]
		public void DLLJCEGPCAC(Entity CLCJGDKEGGN, out Matrix4x4 FOFOAMPADMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5774840", Offset = "0x5773840", VA = "0x185774840", Slot = "28")]
		private void MNHMADDGNPC(Entity CLCJGDKEGGN, in Matrix4x4 HMDIPICBOLD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AJHJJBJAJKN(typeof(OHFJMLDBPPF), new string[] { })]
public class OHFJMLDBPPF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct BLJLAHIKLCM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly OHFJMLDBPPF ACNNFDIAAFM;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x25E0880", Offset = "0x25DF880", VA = "0x1825E0880")]
		public BLJLAHIKLCM(OHFJMLDBPPF ACNNFDIAAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x25E0840", Offset = "0x25DF840", VA = "0x1825E0840", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int JCHPMMEHPJJ;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CDMKDPFBNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1125FE0", Offset = "0x1124FE0", VA = "0x181125FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action BFKJCCIBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x25ECC90", Offset = "0x25EBC90", VA = "0x1825ECC90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x25ECD30", Offset = "0x25EBD30", VA = "0x1825ECD30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x25ECC30", Offset = "0x25EBC30", VA = "0x1825ECC30")]
	public BLJLAHIKLCM APIKBJLGFMK()
	{
		return default(BLJLAHIKLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x1092C90", Offset = "0x1091C90", VA = "0x181092C90")]
	public void OMDOGEMOOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x25ECC70", Offset = "0x25EBC70", VA = "0x1825ECC70")]
	public void APNCHJCOEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public OHFJMLDBPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AJHJJBJAJKN(typeof(GDEFGFJPJEE), new string[] { })]
[KBDAHOGMDPL(typeof(PGHIEJGMCBH))]
public class GHCOADODPDC : GDEFGFJPJEE, IDisposable, LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LHOOIPBILBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public CAJHOBCLJCD services;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LHOOIPBILBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x245FD50", Offset = "0x245ED50", VA = "0x18245FD50")]
		internal void <InitReferences>b__0(JLLBLNFOFFK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PJAGJAOALNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public CAJHOBCLJCD services;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PJAGJAOALNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2461DF0", Offset = "0x2460DF0", VA = "0x182461DF0")]
		internal void <InitExternal>b__0(HLHBDIEKOND svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly ProfilerMarker BAENPPFBFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly ProfilerMarker CLONMNOKIIK;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly ProfilerMarker KBACKPGKIIK;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly ProfilerMarker FJEPNCNKOAE;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly ProfilerMarker PNNIILINPIF;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly ProfilerMarker JJOMPKJKDDL;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly ProfilerMarker CBNNPBKIKJD;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly ProfilerMarker NCNBFKEJPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private IEPEPKBAJCN BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IEPEPKBAJCN NGCBAEGEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public PHHIOCMBCOD NOINFEGLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x245D360", Offset = "0x245C360", VA = "0x18245D360", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x245E0D0", Offset = "0x245D0D0", VA = "0x18245E0D0", Slot = "9")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LPPOJAOPNMP FALFHKCLHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action EMIDIJJCLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x245D2C0", Offset = "0x245C2C0", VA = "0x18245D2C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x245DBB0", Offset = "0x245CBB0", VA = "0x18245DBB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x245DE90", Offset = "0x245CE90", VA = "0x18245DE90", Slot = "21")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x245E120", Offset = "0x245D120", VA = "0x18245E120", Slot = "22")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x245E200", Offset = "0x245D200", VA = "0x18245E200", Slot = "23")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x245DD40", Offset = "0x245CD40", VA = "0x18245DD40", Slot = "11")]
	public void JFJEBMNFNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x245D560", Offset = "0x245C560", VA = "0x18245D560", Slot = "12")]
	public void DLOPFPKPKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x245D9D0", Offset = "0x245C9D0", VA = "0x18245D9D0", Slot = "14")]
	public void FFGAGNAHIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x245D470", Offset = "0x245C470", VA = "0x18245D470", Slot = "15")]
	public void CPNFEGENCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x245D380", Offset = "0x245C380", VA = "0x18245D380", Slot = "13")]
	public void CEJPIPPANEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x245E2B0", Offset = "0x245D2B0", VA = "0x18245E2B0", Slot = "16")]
	public void POIHOMGNDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x245DC50", Offset = "0x245CC50", VA = "0x18245DC50", Slot = "17")]
	public void IJNOEFFMPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x245DAC0", Offset = "0x245CAC0", VA = "0x18245DAC0", Slot = "18")]
	public void FIBBBELCDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x245E0F0", Offset = "0x245D0F0", VA = "0x18245E0F0", Slot = "19")]
	public void NHJAKHLNNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x245DE30", Offset = "0x245CE30", VA = "0x18245DE30", Slot = "24")]
	public void JJLINAGCMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x245D870", Offset = "0x245C870", VA = "0x18245D870")]
	private void FBMLCAAKPML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x245D650", Offset = "0x245C650", VA = "0x18245D650", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x245DE70", Offset = "0x245CE70", VA = "0x18245DE70", Slot = "10")]
	public ComponentSystemBase KKCKIKFBHJM(Type GLKKDGLKBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x245D840", Offset = "0x245C840", VA = "0x18245D840")]
	public bool FBGAGDKFMPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GHCOADODPDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public class FCDKBHJBECD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Func<From, To> EBEICGMKMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Func<To, From> CCKAJHEPPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public DynamicBuffer<From> AIKEPJOBOJF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public To AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	public FCDKBHJBECD(Func<From, To> EBEICGMKMCP, Func<To, From> CCKAJHEPPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To PFENDKKONNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int IIHEDPBOLFE, To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public class MDEIFCGLGMB<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly Func<From, To> EBEICGMKMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly Func<To, From> CCKAJHEPPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public List<From> DMCFFMAPNPG;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public To AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x48BDCE0", Offset = "0x48BCCE0", VA = "0x1848BDCE0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x48BDD40", Offset = "0x48BCD40", VA = "0x1848BDD40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x48BDCB0", Offset = "0x48BCCB0", VA = "0x1848BDCB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x666990", Offset = "0x665990", VA = "0x180666990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA34180", Offset = "0xA33180", VA = "0x180A34180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A17E40", Offset = "0x3A16E40", VA = "0x183A17E40")]
	public MDEIFCGLGMB(Func<From, To> EBEICGMKMCP, Func<To, From> CCKAJHEPPDK, bool NBHMHIMLODK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x48BD900", Offset = "0x48BC900", VA = "0x1848BD900", Slot = "11")]
	public void Add(To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1CB39D0", Offset = "0x1CB29D0", VA = "0x181CB39D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x48BD960", Offset = "0x48BC960", VA = "0x1848BD960", Slot = "13")]
	public bool Contains(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x48BD9C0", Offset = "0x48BC9C0", VA = "0x1848BD9C0", Slot = "14")]
	public void CopyTo(To[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x48BDAD0", Offset = "0x48BCAD0", VA = "0x1848BDAD0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x48BDB40", Offset = "0x48BCB40", VA = "0x1848BDB40", Slot = "6")]
	public int IndexOf(To PFENDKKONNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x48BDBA0", Offset = "0x48BCBA0", VA = "0x1848BDBA0", Slot = "7")]
	public void Insert(int IIHEDPBOLFE, To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x48BDC50", Offset = "0x48BCC50", VA = "0x1848BDC50", Slot = "15")]
	public bool Remove(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x48BDC20", Offset = "0x48BCC20", VA = "0x1848BDC20", Slot = "8")]
	public void RemoveAt(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x217E000", Offset = "0x217D000", VA = "0x18217E000", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DefaultMember("Item")]
public class HLCAGMBEBKD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Func<From, To> EBEICGMKMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly Func<To, From> CCKAJHEPPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NativeArray<From> DNAEDFOPGEJ;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public To AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x434AE00", Offset = "0x4349E00", VA = "0x18434AE00", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x434AE50", Offset = "0x4349E50", VA = "0x18434AE50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x434ADC0", Offset = "0x4349DC0", VA = "0x18434ADC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x27C2310", Offset = "0x27C1310", VA = "0x1827C2310")]
	public HLCAGMBEBKD(Func<From, To> EBEICGMKMCP, Func<To, From> CCKAJHEPPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x434A930", Offset = "0x4349930", VA = "0x18434A930", Slot = "11")]
	public void Add(To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x434A980", Offset = "0x4349980", VA = "0x18434A980", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x434A9D0", Offset = "0x43499D0", VA = "0x18434A9D0", Slot = "13")]
	public bool Contains(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x434AA90", Offset = "0x4349A90", VA = "0x18434AA90", Slot = "14")]
	public void CopyTo(To[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x434AB50", Offset = "0x4349B50", VA = "0x18434AB50", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x434AC60", Offset = "0x4349C60", VA = "0x18434AC60", Slot = "6")]
	public int IndexOf(To PFENDKKONNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x434ACD0", Offset = "0x4349CD0", VA = "0x18434ACD0", Slot = "7")]
	public void Insert(int IIHEDPBOLFE, To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x434AD70", Offset = "0x4349D70", VA = "0x18434AD70", Slot = "15")]
	public bool Remove(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x434AD20", Offset = "0x4349D20", VA = "0x18434AD20", Slot = "8")]
	public void RemoveAt(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4FD0", Offset = "0x1CC3FD0", VA = "0x181CC4FD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class AOKKGNEDDOH<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly Func<From, To> EBEICGMKMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly Func<To, From> CCKAJHEPPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeList<From> DMCFFMAPNPG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public To AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool HANJBFPBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	public AOKKGNEDDOH(Func<From, To> EBEICGMKMCP, Func<To, From> CCKAJHEPPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DNAEDFOPGEJ, int JECAFEIBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To PFENDKKONNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int IIHEDPBOLFE, To PFENDKKONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To PFENDKKONNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class OLCMNIIFACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public const string OBBHPGDANJC = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public const string GOEGHCOIDKN = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public const string HBPCHNHPPCA = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public const string EIFOJHNOLKJ = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public const string KGMIGMDKNEO = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public const string BMKGLHIKLJL = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public const string GKFGPCIHONM = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class HBKHGFKHDEH
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class EGPCFGPJMNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public CAJHOBCLJCD services;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EGPCFGPJMNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x22DB800", Offset = "0x22DA800", VA = "0x1822DB800")]
		internal void <InitServices>b__1(JLLBLNFOFFK svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x22DB860", Offset = "0x22DA860", VA = "0x1822DB860")]
		internal void <InitServices>b__2(HLHBDIEKOND svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x22DCB80", Offset = "0x22DBB80", VA = "0x1822DCB80")]
	public static void MINHMCIOGEP(this IEPEPKBAJCN BICCGEMNLEI, CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2F67C50", Offset = "0x2F66C50", VA = "0x182F67C50")]
	public static void HMALDIFCINA<T>(this IEPEPKBAJCN BICCGEMNLEI, Action<T> EPPKONDIPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2F678E0", Offset = "0x2F668E0", VA = "0x182F678E0")]
	public static void BLKLHDPOOMA<T>(this IEPEPKBAJCN BICCGEMNLEI, Action<T> EPPKONDIPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2F67E60", Offset = "0x2F66E60", VA = "0x182F67E60")]
	public static void KBFBGDEDAJL<T>(this IEPEPKBAJCN BICCGEMNLEI, Action<T> EPPKONDIPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2F67AB0", Offset = "0x2F66AB0", VA = "0x182F67AB0")]
	public static void EEIEHFHLLEF<T>(this IEPEPKBAJCN BICCGEMNLEI, Action<T> EPPKONDIPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2F67CC0", Offset = "0x2F66CC0", VA = "0x182F67CC0")]
	public static void JOMGOCMIINB<T>(this IEPEPKBAJCN BICCGEMNLEI, Action<T> EPPKONDIPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2F68000", Offset = "0x2F67000", VA = "0x182F68000")]
	private static void OIFPDCGDCCH<T>(object EIDKOILJGBL, Action<T> EPPKONDIPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class CFGAILHCNKO
{
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2454510", Offset = "0x2453510", VA = "0x182454510")]
	public static Quaternion NANMKEPLHNP(this in BCAIICIPIPG PJAFDIPMCLK, in Vector3 CMMBIAPMMCO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class IJDEEJEAMAA
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private const float BKPCKPPBAKP = 1E-05f;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x22E3450", Offset = "0x22E2450", VA = "0x1822E3450")]
	public static bool JEJKODADNIJ(this KBELILGODHB APJCEDCLHME, ShapeConfigData.Flags NHHOFJNBKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x22E3500", Offset = "0x22E2500", VA = "0x1822E3500")]
	public static bool JPBBIIFEOED(this KBELILGODHB APJCEDCLHME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x22E2130", Offset = "0x22E1130", VA = "0x1822E2130")]
	public static bool BJLAECPDHNK(this KBELILGODHB APJCEDCLHME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x22E26A0", Offset = "0x22E16A0", VA = "0x1822E26A0")]
	public static bool FLGELFBCKFE(Vector3 DPEJCADKBMG, Vector3 BIFADDACJNM, out Vector3 FJNPIDOBFEG, bool CELIALHJJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x22E21E0", Offset = "0x22E11E0", VA = "0x1822E21E0")]
	public static void BOMPLLAJECI(this KBELILGODHB APJCEDCLHME, Vector3 GNKHBOLNHHN, Quaternion FJLEBNILPOD, float JGMAHEPKPHA, bool AEDCKBMFGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x22E3320", Offset = "0x22E2320", VA = "0x1822E3320")]
	public static void IPMIPFALIFA(this KBELILGODHB APJCEDCLHME, int AFGBIGHHJLJ, Vector3 GNKHBOLNHHN, Quaternion FJLEBNILPOD, float JGMAHEPKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x22E2610", Offset = "0x22E1610", VA = "0x1822E2610")]
	public static void DNEHELPGBGN(this KBELILGODHB APJCEDCLHME, Vector3 KDDOKELDKOB, Quaternion FDDEKHGIIBE, float JGMAHEPKPHA, bool AEDCKBMFGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x22E28A0", Offset = "0x22E18A0", VA = "0x1822E28A0")]
	private static void HJKPJLHPAGN(this KBELILGODHB APJCEDCLHME, Vector3 IPACGOANALG, Quaternion DJCGMNLFLIO, float JGMAHEPKPHA, bool AEDCKBMFGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x22E35B0", Offset = "0x22E25B0", VA = "0x1822E35B0")]
	private static void KONPEJGMJJJ(this KBELILGODHB APJCEDCLHME, Vector3 OOJHNKALAAE, Quaternion LOMDKHFBCEH, float OGNOBIBONJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x22E2670", Offset = "0x22E1670", VA = "0x1822E2670")]
	private static bool DPOJBELFFFD(this KBELILGODHB APJCEDCLHME, int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x22E2310", Offset = "0x22E1310", VA = "0x1822E2310")]
	private static void CNBMGNMAEJG(this KBELILGODHB APJCEDCLHME, int IIHEDPBOLFE, Vector3 OOJHNKALAAE, Quaternion LOMDKHFBCEH, float OGNOBIBONJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x22E37D0", Offset = "0x22E27D0", VA = "0x1822E37D0")]
	public static Vector3 PFDJMEPIJOK(this KBELILGODHB APJCEDCLHME, int IIHEDPBOLFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x22E3730", Offset = "0x22E2730", VA = "0x1822E3730")]
	public static Quaternion PABLGNAFHMK(this KBELILGODHB APJCEDCLHME, int IIHEDPBOLFE)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class HLDIHACFBJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class HBLKFCBKAPO
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	public static bool FNOEPDJHNIA<T>(ref T KKHMNCLOHHK, ref T GMPKOOIGMDG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class OMDABHKAFEL
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class EEFLJPCIGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EEFLJPCIGEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x25EDFD0", Offset = "0x25ECFD0", VA = "0x1825EDFD0")]
	public static string EFDEHKNMOKH(Transform BCLIDGMJFFC, Transform GBMKJAJEAAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class LGFAJPMPEDD : MJIIOHDKLCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly MethodInfo GKHMPFEHNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Type[] OJDNPNIBMOA;

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x22DCAD0", Offset = "0x22DBAD0", VA = "0x1822DCAD0")]
	public LGFAJPMPEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action KLANPMOEPFL();

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x22F0DF0", Offset = "0x22EFDF0", VA = "0x1822F0DF0")]
	public MethodInfo KJKANMABKOJ(Action BBNMGAFNKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x22F0C60", Offset = "0x22EFC60", VA = "0x1822F0C60", Slot = "4")]
	public void HCCDLMMPDLB(Type GLKKDGLKBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class HAPNEHLBIBI : LGFAJPMPEDD
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private enum BJENKKDMDIM
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9D0", Offset = "0x22DB9D0", VA = "0x1822DC9D0", Slot = "5")]
	public override Action KLANPMOEPFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void FGICCHNOCFG<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x22DCA50", Offset = "0x22DBA50", VA = "0x1822DCA50")]
	[Preserve]
	public void OMKFHMONLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x22DCAD0", Offset = "0x22DBAD0", VA = "0x1822DCAD0")]
	protected HAPNEHLBIBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class PJDKAFCLDOK : LGFAJPMPEDD
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x25F0990", Offset = "0x25EF990", VA = "0x1825F0990", Slot = "5")]
	public override Action KLANPMOEPFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void JBGJPGMEMJK<T>() where T : BJGHIGICLOC;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x25F0A10", Offset = "0x25EFA10", VA = "0x1825F0A10")]
	[Preserve]
	public void OMKFHMONLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x245C580", Offset = "0x245B580", VA = "0x18245C580")]
	protected PJDKAFCLDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class GFGBHKCAGCN : LGFAJPMPEDD
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x245C480", Offset = "0x245B480", VA = "0x18245C480", Slot = "5")]
	public override Action KLANPMOEPFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void OKEGADMGIDL<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x245C500", Offset = "0x245B500", VA = "0x18245C500")]
	[Preserve]
	public void OMKFHMONLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x245C580", Offset = "0x245B580", VA = "0x18245C580")]
	protected GFGBHKCAGCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[AJHJJBJAJKN(typeof(LPPOJAOPNMP), new string[] { })]
public class LIPCKNNOEJK : MFCCKGHBMLA, LPPOJAOPNMP
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CAJHOBCLJCD KOKBOCCBKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PBNGMJECOGA FFBJLJHLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public GDEFGFJPJEE NGCBAEGEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public PGHIEJGMCBH MDOKLCGPPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public NPGLNNOGMJJ CNENPJIDLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IHJGKBGCMLD DMOJLFMKCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5E6020", Offset = "0x5E5020", VA = "0x1805E6020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public INJCNOHDGPO JPDGOBOCCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D70", Offset = "0x5F7D70", VA = "0x1805F8D70", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x67FFC0", Offset = "0x67EFC0", VA = "0x18067FFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LNBNALGBLNP FNJEEPOEDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x638130", Offset = "0x637130", VA = "0x180638130", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6729F0", Offset = "0x6719F0", VA = "0x1806729F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public ODLHGLDEJDN ONGPJKHAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x609720", Offset = "0x608720", VA = "0x180609720", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x672920", Offset = "0x671920", VA = "0x180672920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FNLCMFIELCM IMGOOECKALI
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x5F7220", Offset = "0x5F6220", VA = "0x1805F7220", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x67F370", Offset = "0x67E370", VA = "0x18067F370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GCAMLONMMPC NIMHCIPCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB630", Offset = "0x5EA630", VA = "0x1805EB630", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EE0", Offset = "0x5F7EE0", VA = "0x1805F8EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public EKJPKEGGEPL KFBDIADPHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB620", Offset = "0x5EA620", VA = "0x1805EB620", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x672B80", Offset = "0x671B80", VA = "0x180672B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JAIAOMAFFHB MLECOLCGFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x609660", Offset = "0x608660", VA = "0x180609660", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x5EB640", Offset = "0x5EA640", VA = "0x1805EB640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public IIMPHEBOFIN AKHNFEIIFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x609670", Offset = "0x608670", VA = "0x180609670", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5F7250", Offset = "0x5F6250", VA = "0x1805F7250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JGGCCENAKDL CEECAILOCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5F8EA0", Offset = "0x5F7EA0", VA = "0x1805F8EA0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5F7230", Offset = "0x5F6230", VA = "0x1805F7230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public ECPIEEADKBG HKEEAEJNPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x61F080", Offset = "0x61E080", VA = "0x18061F080", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6807E0", Offset = "0x67F7E0", VA = "0x1806807E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public CILIJHOHMLN GAEKKHBGJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x638140", Offset = "0x637140", VA = "0x180638140", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BF0", Offset = "0x7C4BF0", VA = "0x1807C5BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public IHJMMPGMNNH DHPKHCPBFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0390", Offset = "0x6AF390", VA = "0x1806B0390", Slot = "4")]
		get
		{
			return default(IHJMMPGMNNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x25E4FB0", Offset = "0x25E3FB0", VA = "0x1825E4FB0", Slot = "5")]
	public void GFHDCIJAIAN(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LIPCKNNOEJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DefaultMember("Item")]
public class CGAFLIDMHMB : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class NAIPJOFPGMF : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public CGAFLIDMHMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x609710", Offset = "0x608710", VA = "0x180609710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x2461810", Offset = "0x2460810", VA = "0x182461810", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
		[DebuggerHidden]
		public NAIPJOFPGMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2461650", Offset = "0x2460650", VA = "0x182461650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x24617C0", Offset = "0x24607C0", VA = "0x1824617C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected const ulong OAGCIJGCNJP = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	protected const ulong BEPJKKAPBBB = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected const int OIPGBCGPFEI = 8;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected const int KMACHBLNHNG = 6;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public const int KICAIDFGLNI = 64;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected const int DMGLOFEEMHF = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly List<ulong> KBEGEFKACKC;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x670670", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x737910", Offset = "0x736910", VA = "0x180737910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int CMNCNCLFFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7378D0", Offset = "0x7368D0", VA = "0x1807378D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x737900", Offset = "0x736900", VA = "0x180737900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2454D70", Offset = "0x2453D70", VA = "0x182454D70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2454700", Offset = "0x2453700", VA = "0x182454700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2455310", Offset = "0x2454310", VA = "0x182455310")]
	public CGAFLIDMHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2455380", Offset = "0x2454380", VA = "0x182455380")]
	public CGAFLIDMHMB(int FHKAJCFILHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x24549A0", Offset = "0x24539A0", VA = "0x1824549A0")]
	public bool EIPEBCEEFHF(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2454620", Offset = "0x2453620", VA = "0x182454620")]
	public bool CDGMOGLKOMG(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x24548A0", Offset = "0x24538A0", VA = "0x1824548A0")]
	public bool DLOLCPGOGJD(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x24550F0", Offset = "0x24540F0", VA = "0x1824550F0")]
	public bool NFKGIEPPODC(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2454920", Offset = "0x2453920", VA = "0x182454920")]
	public void EEFEECODOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2455100", Offset = "0x2454100", VA = "0x182455100")]
	public void NLDCILPNNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x2454A70", Offset = "0x2453A70", VA = "0x182454A70")]
	public void GALDMPBHILF(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2454EA0", Offset = "0x2453EA0", VA = "0x182454EA0")]
	public void MCOHOPDDOPF(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2454E10", Offset = "0x2453E10", VA = "0x182454E10")]
	public bool KMFAENLEIIE(int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2454FE0", Offset = "0x2453FE0", VA = "0x182454FE0")]
	public void MIHBCGDLPCD(int KDGOCEAMMLM, int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2454BD0", Offset = "0x2453BD0", VA = "0x182454BD0")]
	public void JDPIELAADGA(int AEOBOJAAIBB, int FFCIKCOFOFK, int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x24551E0", Offset = "0x24541E0", VA = "0x1824551E0")]
	public int PPCBFHPPBHE(int FBKJALIBHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x24552A0", Offset = "0x24542A0", VA = "0x1824552A0")]
	public int PPCBFHPPBHE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2454F90", Offset = "0x2453F90", VA = "0x182454F90")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2454B60", Offset = "0x2453B60", VA = "0x182454B60", Slot = "4")]
	[IteratorStateMachine(typeof(NAIPJOFPGMF))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2454B60", Offset = "0x2453B60", VA = "0x182454B60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class LPBEKINOAFA<T> : global::IAEBGHMFKJO<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected global::OFHDFIEHCNF<T> AJFHHFNLAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	protected global::IBIKOKBFELK<T> LKDNKNMPPIE;

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3CA0", Offset = "0x1CB2CA0", VA = "0x181CB3CA0")]
	public LPBEKINOAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x3A94200", Offset = "0x3A93200", VA = "0x183A94200")]
	public LPBEKINOAFA(global::OFHDFIEHCNF<T> AJFHHFNLAFI, global::IBIKOKBFELK<T> LKDNKNMPPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x3A93CF0", Offset = "0x3A92CF0", VA = "0x183A93CF0", Slot = "11")]
	public override T HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x27C1CE0", Offset = "0x27C0CE0", VA = "0x1827C1CE0", Slot = "12")]
	public override void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG, T JNLOLNFALGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class FPADCNEEAFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE2D0", Offset = "0x1DCD2D0", VA = "0x181DCE2D0")]
	public static IHCHEEIIPON HCCDLMMPDLB<T>(this DPMGMIHGDHM BIPGBCJBJEE, global::KBDGAEOCIJO<T> MBHNCPMPIFB, global::OFHDFIEHCNF<T> AJFHHFNLAFI, global::IBIKOKBFELK<T> LKDNKNMPPIE) where T : struct
	{
		return default(IHCHEEIIPON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public sealed class LHNNONFALCP<T> : global::LPBEKINOAFA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x47CDFF0", Offset = "0x47CCFF0", VA = "0x1847CDFF0")]
	public LHNNONFALCP(T PPBBNEGBIFF, T HGPCJMNKPMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class BEMLEMKMHPA<T> : global::IAEBGHMFKJO<T> where T : struct, BJGHIGICLOC
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x24C9E70", Offset = "0x24C8E70", VA = "0x1824C9E70", Slot = "11")]
	public override T HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x24C9F80", Offset = "0x24C8F80", VA = "0x1824C9F80", Slot = "12")]
	public override void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x200DC00", Offset = "0x200CC00", VA = "0x18200DC00")]
	public BEMLEMKMHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class NKPNBEAIPKH : JOEKHHFALNN
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public abstract Type EDOJEPOOFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG, in PFFLIKLDNNB JNLOLNFALGF);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG, in JHBOMEIKHGC JNLOLNFALGF);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ONBNIDHNIKA(FDIABGHMJIL GCDHDDNNKIG, JAOCBBFLDIG PNCDHJKGIFC, [Optional] object GENOAILOCON);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	protected NKPNBEAIPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class IAEBGHMFKJO<T> : NKPNBEAIPKH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public override Type EDOJEPOOFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x250C1F0", Offset = "0x250B1F0", VA = "0x18250C1F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG, T JNLOLNFALGF);

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x250B8D0", Offset = "0x250A8D0", VA = "0x18250B8D0", Slot = "8")]
	public override void HIDKAFCIGIB(FDIABGHMJIL GCDHDDNNKIG, in PFFLIKLDNNB GBMKJAJEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x250C6A0", Offset = "0x250B6A0", VA = "0x18250C6A0", Slot = "9")]
	public override void NJADPKHDAEC(FDIABGHMJIL GCDHDDNNKIG, in JHBOMEIKHGC LAAFNHPNJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x250CF30", Offset = "0x250BF30", VA = "0x18250CF30", Slot = "10")]
	public override void ONBNIDHNIKA(FDIABGHMJIL GCDHDDNNKIG, JAOCBBFLDIG PNCDHJKGIFC, object GENOAILOCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2000450", Offset = "0x1FFF450", VA = "0x182000450")]
	protected IAEBGHMFKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class NIGBMAEDKEG
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class FFFFPAOALAA
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class JKKGLGMEEEC<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
			public JKKGLGMEEEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x26E8920", Offset = "0x26E7920", VA = "0x1826E8920")]
			internal void <RegisterFixedString>b__0(FDIABGHMJIL p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x26E8A50", Offset = "0x26E7A50", VA = "0x1826E8A50")]
			internal T <RegisterFixedString>b__1(FDIABGHMJIL p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x25E45E0", Offset = "0x25E35E0", VA = "0x1825E45E0")]
		public static void HALMLPHMLKO(PNFGGJHOHCL NOJKDGAOHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D725E0", Offset = "0x2D715E0", VA = "0x182D725E0")]
		private static void OJGPNMOEAID<T>(PNFGGJHOHCL NOJKDGAOHNK, int HGPCJMNKPMC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D72550", Offset = "0x2D71550", VA = "0x182D72550")]
		private static void IOFFHFNFBKI<T>(FDIABGHMJIL BKLFBAMHBAG, T PHCLDIDKELI, int HGPCJMNKPMC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x20B1AD0", Offset = "0x20B0AD0", VA = "0x1820B1AD0")]
		private static T DOMGAEBGKFD<T>(FDIABGHMJIL BKLFBAMHBAG, int HGPCJMNKPMC) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public FFFFPAOALAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private class MGJGHDIHKBC : HAPNEHLBIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private PNFGGJHOHCL NOJKDGAOHNK;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D75230", Offset = "0x2D74230", VA = "0x182D75230", Slot = "6")]
		public override void FGICCHNOCFG<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x25E7B40", Offset = "0x25E6B40", VA = "0x1825E7B40")]
		public static void MJFLOKINBCK(PNFGGJHOHCL NOJKDGAOHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x245C580", Offset = "0x245B580", VA = "0x18245C580")]
		public MGJGHDIHKBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x25EA2D0", Offset = "0x25E92D0", VA = "0x1825EA2D0")]
	public static void HMKHMNMPAHB(PNFGGJHOHCL NOJKDGAOHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D7D2A0", Offset = "0x2D7C2A0", VA = "0x182D7D2A0")]
	public static void HOMABGNCHOA<T>(PNFGGJHOHCL NOJKDGAOHNK, global::OFHDFIEHCNF<T> AJFHHFNLAFI, global::IBIKOKBFELK<T> LKDNKNMPPIE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D7D230", Offset = "0x2D7C230", VA = "0x182D7D230")]
	public static void HCLLJKBCFBO<T>(PNFGGJHOHCL HAPPCNOAFNK) where T : struct, BJGHIGICLOC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface PNFGGJHOHCL : global::IKJLDAOHBOJ<PNFGGJHOHCL>
{
	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCCDLMMPDLB(Type GLKKDGLKBMK, JOEKHHFALNN HAPPCNOAFNK);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EAMIBAOAOOK(Type GLKKDGLKBMK, out JOEKHHFALNN HAPPCNOAFNK);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class MICGIHHAECF
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x25E8780", Offset = "0x25E7780", VA = "0x1825E8780")]
	public static void HCCDLMMPDLB(this PNFGGJHOHCL MMMPDDBDDGF, JOEKHHFALNN HAPPCNOAFNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[AJHJJBJAJKN(typeof(DPMGMIHGDHM), new string[] { })]
public sealed class DAJJECCJJGF : DPMGMIHGDHM, global::IKJLDAOHBOJ<DPMGMIHGDHM>, ICFGAFHALNE, JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<IHCHEEIIPON, JOEKHHFALNN> NOJKDGAOHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private PNFGGJHOHCL DDDDLNCAFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private MCABEJDLNDK BIPGBCJBJEE;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool DPELBEJGGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x666990", Offset = "0x665990", VA = "0x180666990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA34180", Offset = "0xA33180", VA = "0x180A34180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2455C70", Offset = "0x2454C70", VA = "0x182455C70")]
	public DAJJECCJJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2455BC0", Offset = "0x2454BC0", VA = "0x182455BC0")]
	public DAJJECCJJGF(Dictionary<IHCHEEIIPON, JOEKHHFALNN> NOJKDGAOHNK, bool DLMCHLFJGGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2455990", Offset = "0x2454990", VA = "0x182455990", Slot = "7")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2455B40", Offset = "0x2454B40", VA = "0x182455B40", Slot = "8")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2455AF0", Offset = "0x2454AF0", VA = "0x182455AF0", Slot = "9")]
	public void MCOHOPDDOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x24558C0", Offset = "0x24548C0", VA = "0x1824558C0", Slot = "4")]
	public IHCHEEIIPON KKIECCDJOCP(KDOFIACDKKK MBHNCPMPIFB)
	{
		return default(IHCHEEIIPON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x24556D0", Offset = "0x24546D0", VA = "0x1824556D0", Slot = "5")]
	public void HCCDLMMPDLB(IHCHEEIIPON LGBAJKGIPMA, JOEKHHFALNN HAPPCNOAFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x24559E0", Offset = "0x24549E0", VA = "0x1824559E0")]
	[Conditional("DEBUG_BUILD")]
	private void MCFFBPHANHD(IHCHEEIIPON LGBAJKGIPMA, Type GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2455550", Offset = "0x2454550", VA = "0x182455550", Slot = "6")]
	public bool EAMIBAOAOOK(IHCHEEIIPON LGBAJKGIPMA, out JOEKHHFALNN HAPPCNOAFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x24557F0", Offset = "0x24547F0", VA = "0x1824557F0", Slot = "10")]
	public DPMGMIHGDHM KDEDCHMMLEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AJHJJBJAJKN(typeof(PNFGGJHOHCL), new string[] { })]
public sealed class MPGPDLAENBA : ICFGAFHALNE, PNFGGJHOHCL, global::IKJLDAOHBOJ<PNFGGJHOHCL>
{
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly Dictionary<Type, JOEKHHFALNN> NOJKDGAOHNK;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool DPELBEJGGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x713FE0", Offset = "0x712FE0", VA = "0x180713FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CD0", Offset = "0x7B8CD0", VA = "0x1807B9CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x25E8D50", Offset = "0x25E7D50", VA = "0x1825E8D50")]
	public MPGPDLAENBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x25E8CA0", Offset = "0x25E7CA0", VA = "0x1825E8CA0")]
	public MPGPDLAENBA(Dictionary<Type, JOEKHHFALNN> NOJKDGAOHNK, bool DLMCHLFJGGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x25E8C00", Offset = "0x25E7C00", VA = "0x1825E8C00", Slot = "4")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x25E8A40", Offset = "0x25E7A40", VA = "0x1825E8A40", Slot = "5")]
	public void HCCDLMMPDLB(Type GLKKDGLKBMK, JOEKHHFALNN HAPPCNOAFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x25E8980", Offset = "0x25E7980", VA = "0x1825E8980", Slot = "6")]
	public bool EAMIBAOAOOK(Type GLKKDGLKBMK, out JOEKHHFALNN HAPPCNOAFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x25E8B30", Offset = "0x25E7B30", VA = "0x1825E8B30", Slot = "7")]
	public PNFGGJHOHCL KDEDCHMMLEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[AJHJJBJAJKN(typeof(MGIPPMDNKPK), new string[] { })]
internal sealed class HKKPKMJHDCN : MGIPPMDNKPK, ICFGAFHALNE, JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly Dictionary<IHCHEEIIPON, KFJNKOHFPDL> BKKFGBJPCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MCABEJDLNDK BIPGBCJBJEE;

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x22DE720", Offset = "0x22DD720", VA = "0x1822DE720", Slot = "6")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x22DE7E0", Offset = "0x22DD7E0", VA = "0x1822DE7E0", Slot = "7")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x22DE6B0", Offset = "0x22DD6B0", VA = "0x1822DE6B0", Slot = "4")]
	public void HCCDLMMPDLB(IHCHEEIIPON FANBLFBADKJ, Type ODLFGEBBEHA, KFJNKOHFPDL DECFFNJDMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x22DE770", Offset = "0x22DD770", VA = "0x1822DE770", Slot = "5")]
	public bool MMLNIEFLAEA(IHCHEEIIPON FANBLFBADKJ, out KFJNKOHFPDL DECFFNJDMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x22DE500", Offset = "0x22DD500", VA = "0x1822DE500")]
	[Conditional("DEBUG_BUILD")]
	private void BMIFEMBPPPL(IHCHEEIIPON FANBLFBADKJ, Type ODLFGEBBEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x22DE840", Offset = "0x22DD840", VA = "0x1822DE840")]
	public HKKPKMJHDCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[KBDAHOGMDPL(typeof(MCABEJDLNDK))]
[AJHJJBJAJKN(typeof(FDPOGHKCPBN), new string[] { })]
internal sealed class NHJMHLFIKFG : FDPOGHKCPBN, LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly CGAFLIDMHMB CIFGFFDHCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private readonly Dictionary<LEPNJELBIPF, int> JLLFNPJKFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly Stack<int> GBDKGBJKNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private MCABEJDLNDK BIPGBCJBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private int MAKDPDKBNJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x25EA000", Offset = "0x25E9000", VA = "0x1825EA000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool BPGDLIICONH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6678B0", Offset = "0x6668B0", VA = "0x1806678B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x735890", Offset = "0x734890", VA = "0x180735890", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x25E9C90", Offset = "0x25E8C90", VA = "0x1825E9C90", Slot = "6")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x25EA0F0", Offset = "0x25E90F0", VA = "0x1825EA0F0", Slot = "7")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x25EA170", Offset = "0x25E9170", VA = "0x1825EA170", Slot = "8")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x25EA050", Offset = "0x25E9050", VA = "0x1825EA050")]
	private void MJBELKNCEJH(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x25E9F50", Offset = "0x25E8F50", VA = "0x1825E9F50", Slot = "4")]
	public bool LLFKNJGJNPA(LEPNJELBIPF POJMBOCFKCO, IHCHEEIIPON KIMANJPEJBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x25E9D60", Offset = "0x25E8D60", VA = "0x1825E9D60", Slot = "5")]
	public void FCKKDEGMENO(LEPNJELBIPF POJMBOCFKCO, Span<IHCHEEIIPON> BIPGBCJBJEE, bool DECMJKLKEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x25E9C90", Offset = "0x25E8C90", VA = "0x1825E9C90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x25EA200", Offset = "0x25E9200", VA = "0x1825EA200")]
	public NHJMHLFIKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class GILIGHNOOKL
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x245E660", Offset = "0x245D660", VA = "0x18245E660")]
	public static void JHEIDFMPEEJ(this FDIABGHMJIL GCDHDDNNKIG, ReadOnlyMemory<byte> BAAMAKPMNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2F66F30", Offset = "0x2F65F30", VA = "0x182F66F30")]
	public static void BOFGKMKKGCI<T>(this FDIABGHMJIL GCDHDDNNKIG, in T JNLOLNFALGF) where T : struct, BJGHIGICLOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x20B3420", Offset = "0x20B2420", VA = "0x1820B3420")]
	public static T KFGDILHEFIG<T>(this FDIABGHMJIL GCDHDDNNKIG) where T : struct, BJGHIGICLOC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x245E510", Offset = "0x245D510", VA = "0x18245E510")]
	public static void BOFGKMKKGCI(this FDIABGHMJIL GCDHDDNNKIG, OOADFNEFKAP DDDOJNJDILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x245E6E0", Offset = "0x245D6E0", VA = "0x18245E6E0")]
	public static OOADFNEFKAP OFPPFNBPJIB(this FDIABGHMJIL GCDHDDNNKIG)
	{
		return default(OOADFNEFKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x245E710", Offset = "0x245D710", VA = "0x18245E710")]
	public static void PNFIDHDAEFI(this FDIABGHMJIL FDGBHFMGIPL, uint JLONMCLLNAD, bool IEFEKELPEOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x245E540", Offset = "0x245D540", VA = "0x18245E540")]
	public static uint HIFGPLGLGBN(this FDIABGHMJIL FDKCNEJMANN, bool IEFEKELPEOP = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class EFMHAFOCCMK
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class NPKKFEELKPI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public NPKKFEELKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3C179A0", Offset = "0x3C169A0", VA = "0x183C179A0")]
		internal void <GetByteEnumDelegates>b__0(FDIABGHMJIL b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x3C17A10", Offset = "0x3C16A10", VA = "0x183C17A10")]
		internal T <GetByteEnumDelegates>b__1(FDIABGHMJIL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class MMLOJHKDMEM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public MMLOJHKDMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x3C17690", Offset = "0x3C16690", VA = "0x183C17690")]
		internal void <GetSByteEnumDelegates>b__0(FDIABGHMJIL b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3C17700", Offset = "0x3C16700", VA = "0x183C17700")]
		internal T <GetSByteEnumDelegates>b__1(FDIABGHMJIL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class AECKHHPJEPP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public AECKHHPJEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x3C070D0", Offset = "0x3C060D0", VA = "0x183C070D0")]
		internal void <GetShortEnumDelegates>b__0(FDIABGHMJIL b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x3C07140", Offset = "0x3C06140", VA = "0x183C07140")]
		internal T <GetShortEnumDelegates>b__1(FDIABGHMJIL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class DNGGPCEEEAN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public DNGGPCEEEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A110", Offset = "0x3C09110", VA = "0x183C0A110")]
		internal void <GetUShortEnumDelegates>b__0(FDIABGHMJIL b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A180", Offset = "0x3C09180", VA = "0x183C0A180")]
		internal T <GetUShortEnumDelegates>b__1(FDIABGHMJIL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class HDFFGBCJDKI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public HDFFGBCJDKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3C17220", Offset = "0x3C16220", VA = "0x183C17220")]
		internal void <GetIntEnumDelegates>b__0(FDIABGHMJIL b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3C17280", Offset = "0x3C16280", VA = "0x183C17280")]
		internal T <GetIntEnumDelegates>b__1(FDIABGHMJIL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class JOGHGLAPGCN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public JOGHGLAPGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x3C172E0", Offset = "0x3C162E0", VA = "0x183C172E0")]
		internal void <GetUIntEnumDelegates>b__0(FDIABGHMJIL b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3C17340", Offset = "0x3C16340", VA = "0x183C17340")]
		internal T <GetUIntEnumDelegates>b__1(FDIABGHMJIL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F603B0", Offset = "0x2F5F3B0", VA = "0x182F603B0")]
	public static void NAGAFFHAKDJ<T>(T PPBBNEGBIFF, T HGPCJMNKPMC, out global::OFHDFIEHCNF<T> ALJOPLCOGLN, out global::IBIKOKBFELK<T> JDBMDGCLNLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2F60260", Offset = "0x2F5F260", VA = "0x182F60260")]
	private static void HHOPAPAPHFK<T>(T PPBBNEGBIFF, T HGPCJMNKPMC, out global::OFHDFIEHCNF<T> ALJOPLCOGLN, out global::IBIKOKBFELK<T> JDBMDGCLNLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2F60260", Offset = "0x2F5F260", VA = "0x182F60260")]
	private static void MIEMNACFLHL<T>(T PPBBNEGBIFF, T HGPCJMNKPMC, out global::OFHDFIEHCNF<T> ALJOPLCOGLN, out global::IBIKOKBFELK<T> JDBMDGCLNLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2F60110", Offset = "0x2F5F110", VA = "0x182F60110")]
	private static void EEMPFKPHIAP<T>(T PPBBNEGBIFF, T HGPCJMNKPMC, out global::OFHDFIEHCNF<T> ALJOPLCOGLN, out global::IBIKOKBFELK<T> JDBMDGCLNLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2F60110", Offset = "0x2F5F110", VA = "0x182F60110")]
	private static void HLPEMILFAEE<T>(T PPBBNEGBIFF, T HGPCJMNKPMC, out global::OFHDFIEHCNF<T> ALJOPLCOGLN, out global::IBIKOKBFELK<T> JDBMDGCLNLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2F605A0", Offset = "0x2F5F5A0", VA = "0x182F605A0")]
	private static void NMNLEKJFBCG<T>(T PPBBNEGBIFF, T HGPCJMNKPMC, out global::OFHDFIEHCNF<T> ALJOPLCOGLN, out global::IBIKOKBFELK<T> JDBMDGCLNLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2F605A0", Offset = "0x2F5F5A0", VA = "0x182F605A0")]
	private static void NHHEJPBBBEE<T>(T PPBBNEGBIFF, T HGPCJMNKPMC, out global::OFHDFIEHCNF<T> ALJOPLCOGLN, out global::IBIKOKBFELK<T> JDBMDGCLNLB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public abstract class MMIMACGGFBI : HNBAIDHJJFO, HLHBDIEKOND
{
	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x25E88C0", Offset = "0x25E78C0", VA = "0x1825E88C0", Slot = "4")]
	private void HGOKHNDBKKN(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void GHDGBJDEMIE(DPMGMIHGDHM BIPGBCJBJEE);

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	protected MMIMACGGFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DBPJPAFHGNL(typeof(LocalPoseData))]
public sealed class HJLFMANHCFA : MMIMACGGFBI
{
	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x22DE1E0", Offset = "0x22DD1E0", VA = "0x1822DE1E0", Slot = "5")]
	protected override void GHDGBJDEMIE(DPMGMIHGDHM BIPGBCJBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	public HJLFMANHCFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class IENHCMAHPFK : global::PDCKMMONLNF<AuthoredParentData, HIEPCEPLNDC, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x22E1490", Offset = "0x22E0490", VA = "0x1822E1490", Slot = "14")]
	protected override EntityQueryDesc BEIGBHOMDEA(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x780EA0", Offset = "0x77FEA0", VA = "0x180780EA0", Slot = "15")]
	protected override EntityQueryDesc DBJNGMNBFFA(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x22E1450", Offset = "0x22E0450", VA = "0x1822E1450", Slot = "16")]
	protected override EntityQueryDesc AFKPCKOLMIG(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x22E1510", Offset = "0x22E0510", VA = "0x1822E1510", Slot = "17")]
	protected override EntityQueryDesc PLPHJMIHJEO(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x22E1550", Offset = "0x22E0550", VA = "0x1822E1550")]
	public IENHCMAHPFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x22E14D0", Offset = "0x22E04D0", VA = "0x1822E14D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[DOKDCAPODCB(PBFEFLGCHAA.Connectables)]
	public class UpdateConnectableVisuals : HEODJEKIBCE, JLLBLNFOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		private struct LAHLCOCPOBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public EOEFHMABDFK BFJMCAAKMNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public float3 IPACGOANALG;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x576F450", Offset = "0x576E450", VA = "0x18576F450")]
			public LAHLCOCPOBA(EOEFHMABDFK BFJMCAAKMNM, float3 IPACGOANALG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x576F430", Offset = "0x576E430", VA = "0x18576F430")]
			public void BOOMLLPLBBD(out EOEFHMABDFK BFJMCAAKMNM, out float3 IPACGOANALG)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct MEOMIMHFHOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public NativeList<LAHLCOCPOBA> childrenWithoutCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public NativeList<LAHLCOCPOBA> childrenWithCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public BufferFromEntity<AuthoredChildrenData> childBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public ComponentDataFromEntity<FODDPEEHKIJ> stateArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public NativeList<LAHLCOCPOBA> parentWithoutCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public NativeList<LAHLCOCPOBA> parentWithCom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			public MEOMIMHFHOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
			internal void <UpdateModifiedVisuals>b__2(FODDPEEHKIJ state, WorldPoseData pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
			internal void <UpdateModifiedVisuals>b__3(FODDPEEHKIJ state, WorldPoseData pose, NCJBKACLIIO com)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
			internal void <UpdateModifiedVisuals>b__4(Entity entity, WorldPoseData pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
			internal void <UpdateModifiedVisuals>b__5(Entity entity, WorldPoseData pose, NCJBKACLIIO com)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct CGPGCCILLOD : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			private struct KANKPEJGPNA
			{
				[Cpp2IlInjected.Token(Token = "0x2000097")]
				[NoAlias]
				public struct ADGKGEIKJAO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E8")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<FODDPEEHKIJ>.Runtime KPCPFKKLLJD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001E9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIKCHPDPCGN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<FODDPEEHKIJ> IMKENLBIBEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> LLAKDFODGLM;

				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x576F350", Offset = "0x576E350", VA = "0x18576F350")]
				public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x576F3B0", Offset = "0x576E3B0", VA = "0x18576F3B0")]
				public ADGKGEIKJAO CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(ADGKGEIKJAO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public NativeList<LAHLCOCPOBA> CJDIHDPNENH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			private KANKPEJGPNA OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KANKPEJGPNA.ADGKGEIKJAO* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x576E580", Offset = "0x576D580", VA = "0x18576E580")]
			internal void ENEEDINPEMO(FODDPEEHKIJ LKOJKOJNBBK, WorldPoseData IIKEDDINAOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x22CC6F0", Offset = "0x22CB6F0", VA = "0x1822CC6F0", Slot = "5")]
			public void ReadFromDisplayClass(ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0x576E620", Offset = "0x576D620", VA = "0x18576E620", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x576E6D0", Offset = "0x576D6D0", VA = "0x18576E6D0")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref KANKPEJGPNA.ADGKGEIKJAO HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x576E4F0", Offset = "0x576D4F0", VA = "0x18576E4F0")]
			public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL, ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct PAEBKAKIMOL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private struct HCEBHEKPMMC
			{
				[Cpp2IlInjected.Token(Token = "0x200009A")]
				[NoAlias]
				public struct BCDECNHPKJO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001F0")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<FODDPEEHKIJ>.Runtime KPCPFKKLLJD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001F1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIKCHPDPCGN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40001F2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<NCJBKACLIIO>.Runtime NCOHMCKBNCM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<FODDPEEHKIJ> IMKENLBIBEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001EE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> LLAKDFODGLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<NCJBKACLIIO> JIFEGJCGAOP;

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x576ED50", Offset = "0x576DD50", VA = "0x18576ED50")]
				public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x576EDD0", Offset = "0x576DDD0", VA = "0x18576EDD0")]
				public BCDECNHPKJO CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(BCDECNHPKJO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public NativeList<LAHLCOCPOBA> BMKOIJCHJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			private HCEBHEKPMMC OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HCEBHEKPMMC.BCDECNHPKJO* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x576F970", Offset = "0x576E970", VA = "0x18576F970")]
			internal void ENEEDINPEMO(FODDPEEHKIJ LKOJKOJNBBK, WorldPoseData IIKEDDINAOH, NCJBKACLIIO AFCLNNBHHGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x22DBBB0", Offset = "0x22DABB0", VA = "0x1822DBBB0", Slot = "5")]
			public void ReadFromDisplayClass(ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x576FA20", Offset = "0x576EA20", VA = "0x18576FA20", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x576FAF0", Offset = "0x576EAF0", VA = "0x18576FAF0")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref HCEBHEKPMMC.BCDECNHPKJO HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x576F930", Offset = "0x576E930", VA = "0x18576F930")]
			public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL, ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct FECFPPAHKOE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009C")]
			private struct AMEMKNMPJHA
			{
				[Cpp2IlInjected.Token(Token = "0x200009D")]
				[NoAlias]
				public struct LHEOPDLMPIF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001FA")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001FB")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIKCHPDPCGN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> LLAKDFODGLM;

				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(RVA = "0x576E410", Offset = "0x576D410", VA = "0x18576E410")]
				public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(RVA = "0x576E470", Offset = "0x576D470", VA = "0x18576E470")]
				public LHEOPDLMPIF CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(LHEOPDLMPIF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public BufferFromEntity<AuthoredChildrenData> JNILFEIFCKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			[ReadOnly]
			public ComponentDataFromEntity<FODDPEEHKIJ> IIPBKEIFHPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public NativeList<LAHLCOCPOBA> ILPKLEJDFGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private AMEMKNMPJHA OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AMEMKNMPJHA.LHEOPDLMPIF* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x576E890", Offset = "0x576D890", VA = "0x18576E890")]
			internal void ENEEDINPEMO(Entity CLCJGDKEGGN, WorldPoseData IIKEDDINAOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x576EB20", Offset = "0x576DB20", VA = "0x18576EB20", Slot = "5")]
			public void ReadFromDisplayClass(ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x576E9C0", Offset = "0x576D9C0", VA = "0x18576E9C0", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x576EA60", Offset = "0x576DA60", VA = "0x18576EA60")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref AMEMKNMPJHA.LHEOPDLMPIF HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x576E800", Offset = "0x576D800", VA = "0x18576E800")]
			public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL, ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct KAFJNCHHEBB : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009F")]
			private struct IACIEGJDENN
			{
				[Cpp2IlInjected.Token(Token = "0x20000A0")]
				[NoAlias]
				public struct BNHNODDINEI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000204")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000205")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIKCHPDPCGN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000206")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<NCJBKACLIIO>.Runtime NCOHMCKBNCM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000201")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> LLAKDFODGLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<NCJBKACLIIO> JIFEGJCGAOP;

				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(RVA = "0x576EE70", Offset = "0x576DE70", VA = "0x18576EE70")]
				public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x576EEF0", Offset = "0x576DEF0", VA = "0x18576EEF0")]
				public BNHNODDINEI CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(BNHNODDINEI);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public BufferFromEntity<AuthoredChildrenData> JNILFEIFCKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			[ReadOnly]
			public ComponentDataFromEntity<FODDPEEHKIJ> IIPBKEIFHPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public NativeList<LAHLCOCPOBA> AHMEDNDLOMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private IACIEGJDENN OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IACIEGJDENN.BNHNODDINEI* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x576EFD0", Offset = "0x576DFD0", VA = "0x18576EFD0")]
			internal void ENEEDINPEMO(Entity CLCJGDKEGGN, WorldPoseData IIKEDDINAOH, NCJBKACLIIO AFCLNNBHHGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x576F320", Offset = "0x576E320", VA = "0x18576F320", Slot = "5")]
			public void ReadFromDisplayClass(ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x576F120", Offset = "0x576E120", VA = "0x18576F120", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x576F1F0", Offset = "0x576E1F0", VA = "0x18576F1F0")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref IACIEGJDENN.BNHNODDINEI HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x576EF90", Offset = "0x576DF90", VA = "0x18576EF90")]
			public void AIMCPLKOAEL(UpdateConnectableVisuals MNFLHJKJICL, ref MEOMIMHFHOL BMLBBBFJKKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private EntityQuery IDNEFECFEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private EntityQuery NEFPODPIMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private EntityQuery OGAHFFFGOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private EntityQuery PMGNCNPDPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private EntityQuery DAKIAPMIOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private EntityQuery CPFNEMMJKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private global::HIFNABHKLBE<EOEFHMABDFK, HLNNPEHJABK> JMMPEOIPKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private FBKDAMAOBBF GEJDGLGPOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private EntityQuery LAMNNLNMKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private EntityQuery DPFICMBNECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private EntityQuery AMGCCFKOONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private EntityQuery LMIPHIDNIAE;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		internal global::HIFNABHKLBE<EOEFHMABDFK, HLNNPEHJABK> HBLNLBDICNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x609670", Offset = "0x608670", VA = "0x180609670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x5777090", Offset = "0x5776090", VA = "0x185777090", Slot = "14")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5777300", Offset = "0x5776300", VA = "0x185777300", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x5777430", Offset = "0x5776430", VA = "0x185777430", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x5776720", Offset = "0x5775720", VA = "0x185776720")]
		private void NGLEKANCDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x57776A0", Offset = "0x57766A0", VA = "0x1857776A0")]
		private void PGOGEPPKJBM(NativeArray<FODDPEEHKIJ> CHBNOKGPMFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x5775BB0", Offset = "0x5774BB0", VA = "0x185775BB0")]
		private void ACDPDONICLL(NativeArray<Entity> JCPIJGJJGII, NativeArray<AuthoredParentData> HFNNBDEEIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x57773E0", Offset = "0x57763E0", VA = "0x1857773E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x57761A0", Offset = "0x57751A0", VA = "0x1857761A0")]
		[CompilerGenerated]
		private HLNNPEHJABK CKMIHDJMEFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x5777220", Offset = "0x5776220", VA = "0x185777220", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x57764C0", Offset = "0x57754C0", VA = "0x1857764C0")]
		public static EntityQuery FNFMPELPNNF(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x5776270", Offset = "0x5775270", VA = "0x185776270")]
		public static EntityQuery EKHFJKNDACM(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x5775F70", Offset = "0x5774F70", VA = "0x185775F70")]
		public static EntityQuery AKACNBHPHNL(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x5776E60", Offset = "0x5775E60", VA = "0x185776E60")]
		public static EntityQuery NGPMAMIFFOO(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct EOEFHMABDFK : global::CKDCIHLAPNJ<EOEFHMABDFK>, GHELMGKGIIN, IEquatable<EOEFHMABDFK>
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public int KBBNJEDOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x91EAC0", Offset = "0x91DAC0", VA = "0x18091EAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public int ICOAIKCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8A44E0", Offset = "0x8A34E0", VA = "0x1808A44E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8F82D0", Offset = "0x8F72D0", VA = "0x1808F82D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x245AC80", Offset = "0x2459C80", VA = "0x18245AC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x245ACC0", Offset = "0x2459CC0", VA = "0x18245ACC0", Slot = "8")]
	public bool Equals(EOEFHMABDFK IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x245AD10", Offset = "0x2459D10", VA = "0x18245AD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct FODDPEEHKIJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public EOEFHMABDFK BFJMCAAKMNM;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class FKIGDAOGCEP : HEODJEKIBCE, JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private ObjectEmbodimentService PIKHCAFAOHP;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x245BF80", Offset = "0x245AF80", VA = "0x18245BF80", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x245BFE0", Offset = "0x245AFE0", VA = "0x18245BFE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x245C010", Offset = "0x245B010", VA = "0x18245C010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public FKIGDAOGCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class DAOOMKALOAB : HEODJEKIBCE, JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private EntityQuery PJEOOKGFEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private EntityQuery NIKCGENAELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private EntityQuery JGOOAMLGPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private EntityQuery OOLJMNBGKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private ObjectEmbodimentService IANIKFPAFBO;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int OBJKPBJHGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x24565D0", Offset = "0x24555D0", VA = "0x1824565D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public int FAICENAGFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2455DC0", Offset = "0x2454DC0", VA = "0x182455DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2456570", Offset = "0x2455570", VA = "0x182456570", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x24565E0", Offset = "0x24555E0", VA = "0x1824565E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2456790", Offset = "0x2455790", VA = "0x182456790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2455F30", Offset = "0x2454F30", VA = "0x182455F30")]
	protected void JCHLAACDNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2456250", Offset = "0x2455250", VA = "0x182456250")]
	protected void LDMBKIOJEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2456160", Offset = "0x2455160", VA = "0x182456160")]
	private bool JHBMEHMGEGC(EntityQuery FHCACFJLPLH, out NativeArray<Entity> AFOGFGIBNGF, out NativeArray<BBGEOMDADMJ> PHCNLGFIAMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x24564F0", Offset = "0x24554F0", VA = "0x1824564F0")]
	public global::JKLCOILHKCM<Entity> NFOPHMOMLHH(Allocator LKNIKCJFBFH)
	{
		return default(global::JKLCOILHKCM<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2456530", Offset = "0x2455530", VA = "0x182456530")]
	public global::JKLCOILHKCM<Entity> NHDPHPBOFJK(Allocator LKNIKCJFBFH)
	{
		return default(global::JKLCOILHKCM<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x2455CE0", Offset = "0x2454CE0", VA = "0x182455CE0")]
	public bool EDPDBDEDKMP(Allocator LKNIKCJFBFH, out global::JKLCOILHKCM<Entity> INGBFIDDJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x2455E40", Offset = "0x2454E40", VA = "0x182455E40")]
	public bool GFPEMECKFMF(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x2455EB0", Offset = "0x2454EB0", VA = "0x182455EB0")]
	public PHJBPPLEHIN HBKJFAEDLFN(Entity CLCJGDKEGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x2455DD0", Offset = "0x2454DD0", VA = "0x182455DD0")]
	public bool FGIFIJDGKBN(Entity CLCJGDKEGGN, out KLKONKKFEIM INGBFIDDJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x2455D70", Offset = "0x2454D70", VA = "0x182455D70")]
	public void EIBCIMIDLBI(Entity CLCJGDKEGGN, KLKONKKFEIM INGBFIDDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x2456480", Offset = "0x2455480", VA = "0x182456480")]
	public bool LHHNEBNIEBG(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public DAOOMKALOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KLKONKKFEIM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public PHJBPPLEHIN INGBFIDDJOP;

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KLKONKKFEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x71A660", Offset = "0x719660", VA = "0x18071A660")]
	public KLKONKKFEIM(PHJBPPLEHIN INGBFIDDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(APKLCCIMPNN))]
public class EFPOIEDCDEM : HEODJEKIBCE
{
	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public EFPOIEDCDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct LLHKPPBKIID : ISystemStateComponentData, IComponentData, IEquatable<LLHKPPBKIID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public float3 PMKCDABEGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public float3 HNAGEOGPAFP;

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x25E5510", Offset = "0x25E4510", VA = "0x1825E5510", Slot = "4")]
	public bool Equals(LLHKPPBKIID IJDAJAEAAKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class ODIKDGGGNGA : HEODJEKIBCE, JLLBLNFOFFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct OJLCFHAMOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public ODIKDGGGNGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public OJLCFHAMOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HJEBJCHIFII : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		private struct MKIKLLBHBMD
		{
			[Cpp2IlInjected.Token(Token = "0x20000AC")]
			public struct ECAFAPMAFGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400021F")]
				public LambdaParameterValueProvider_Entity.Runtime KEKAJCDGBBB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DDJMNFNHILH;

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x22DBBC0", Offset = "0x22DABC0", VA = "0x1822DBBC0")]
			public void AIMCPLKOAEL(ODIKDGGGNGA MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x22DBBD0", Offset = "0x22DABD0", VA = "0x1822DBBD0")]
			public ECAFAPMAFGP CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(ECAFAPMAFGP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public ODIKDGGGNGA HHHPDLBJBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public EntityCommandBuffer PFPDJCDPJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private MKIKLLBHBMD OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MKIKLLBHBMD.ECAFAPMAFGP* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x25E4710", Offset = "0x25E3710", VA = "0x1825E4710")]
		internal void ENEEDINPEMO(Entity MKAEFGDNMHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x25E07D0", Offset = "0x25DF7D0", VA = "0x1825E07D0", Slot = "5")]
		public void ReadFromDisplayClass(ref OJLCFHAMOFL BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x25E0800", Offset = "0x25DF800", VA = "0x1825E0800", Slot = "6")]
		public void WriteToDisplayClass(ref OJLCFHAMOFL BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x25E4800", Offset = "0x25E3800", VA = "0x1825E4800", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x25E4860", Offset = "0x25E3860", VA = "0x1825E4860")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, ref MKIKLLBHBMD.ECAFAPMAFGP HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x25E46D0", Offset = "0x25E36D0", VA = "0x1825E46D0")]
		public void AIMCPLKOAEL(ODIKDGGGNGA MNFLHJKJICL, ref OJLCFHAMOFL BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x25E4670", Offset = "0x25E3670", VA = "0x1825E4670")]
		public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private AGHMBCKDBFL KBPJKKBELLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private FOLFFNLGEBO NKBCKMKPIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private EntityQuery KPGALKHFHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private ProfilerMarker DIBMHEGKAPK;

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x25EC5A0", Offset = "0x25EB5A0", VA = "0x1825EC5A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x25EC1B0", Offset = "0x25EB1B0", VA = "0x1825EC1B0", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x25EC600", Offset = "0x25EB600", VA = "0x1825EC600", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public ODIKDGGGNGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x25EC3A0", Offset = "0x25EB3A0", VA = "0x1825EC3A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x25EC210", Offset = "0x25EB210", VA = "0x1825EC210")]
	public static EntityQuery OIOOGDAIDCI(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct PNDIGOPDKPM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public FPCCMOMDDEG BFJMCAAKMNM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0")]
	public static PNDIGOPDKPM BNLFJABIBKP(in FPCCMOMDDEG OJCDDFJHDAL)
	{
		return default(PNDIGOPDKPM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0")]
	public static FPCCMOMDDEG BNLFJABIBKP(in PNDIGOPDKPM LEBPHBKNPMB)
	{
		return default(FPCCMOMDDEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[AJHJJBJAJKN(typeof(FOLFFNLGEBO), new string[] { })]
public sealed class MANELILDJPE : FOLFFNLGEBO, BKMMLEGBFNN, ICFGAFHALNE, JLLBLNFOFFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private const int BLJHOFPJHPH = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private RaycastHit[] KLHFHHMEABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private Type[] IDODGBKAIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private global::DAMIDBMLOOO<FPCCMOMDDEG, BoxCollider> MHGJECLNBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private Scene EGFKPLNKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private PhysicsScene DNOMJKHIKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private LNBNALGBLNP PCCGLMCDMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private GameObject DOJHMGHFEFN;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int NMPKODJNJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x25E6810", Offset = "0x25E5810", VA = "0x1825E6810", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x25E6850", Offset = "0x25E5850", VA = "0x1825E6850", Slot = "10")]
	public void LDGKFGFMALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x25E6D40", Offset = "0x25E5D40", VA = "0x1825E6D40", Slot = "11")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x25E6010", Offset = "0x25E5010", VA = "0x1825E6010", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x25E60D0", Offset = "0x25E50D0", VA = "0x1825E60D0", Slot = "5")]
	public FPCCMOMDDEG FADDPAAALDF(Entity CLCJGDKEGGN)
	{
		return default(FPCCMOMDDEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x25E5E10", Offset = "0x25E4E10", VA = "0x1825E5E10", Slot = "6")]
	public void CLBNHFHMNFM(NativeArray<FPCCMOMDDEG> PHCNLGFIAMJ, NativeArray<LLHKPPBKIID> CPMOCNNLOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x25E6770", Offset = "0x25E5770", VA = "0x1825E6770", Slot = "7")]
	public void HPOGJIGPDHM(FPCCMOMDDEG BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x25E6C50", Offset = "0x25E5C50", VA = "0x1825E6C50", Slot = "8")]
	public bool NBDMKKGOJFP(FPCCMOMDDEG BFJMCAAKMNM, out Collider PIGJAIJJEON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x25E6210", Offset = "0x25E5210", VA = "0x1825E6210")]
	public bool GGOGBMKFGCH(in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, float KEOEBHPOCHG, Allocator LKNIKCJFBFH, out NativeArray<Entity> AFOGFGIBNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x25E6CF0", Offset = "0x25E5CF0", VA = "0x1825E6CF0")]
	private void NCNKJFJLFDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AB280", Offset = "0x8AA280", VA = "0x1808AB280")]
	private void BBOBMJJIGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x25E6AB0", Offset = "0x25E5AB0", VA = "0x1825E6AB0")]
	private void LFKOHPEJDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x9D45D0", Offset = "0x9D35D0", VA = "0x1809D45D0")]
	private void GDLMJABDAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x25E6DF0", Offset = "0x25E5DF0", VA = "0x1825E6DF0")]
	private BoxCollider OJBLNOIBKAK(Entity CLCJGDKEGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x25E5D90", Offset = "0x25E4D90", VA = "0x1825E5D90")]
	private void CCOIBFJIACL(BoxCollider KIKKGCGPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x25E6C10", Offset = "0x25E5C10", VA = "0x1825E6C10")]
	[Conditional("UNITY_EDITOR")]
	private void MJLGFLAEPON(GameObject PKGBHIMGLPM, Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x25E6550", Offset = "0x25E5550", VA = "0x1825E6550")]
	private void HLHNJHPDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x25E6420", Offset = "0x25E5420", VA = "0x1825E6420")]
	private void GJHJAFPJEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x25E5D80", Offset = "0x25E4D80", VA = "0x1825E5D80")]
	private void AKLBIHMOCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x25E5D40", Offset = "0x25E4D40", VA = "0x1825E5D40")]
	private void AKDOBCEOKEE(Scene BNNOCIDHDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public MANELILDJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x25E6200", Offset = "0x25E5200", VA = "0x1825E6200", Slot = "9")]
	private bool GFKNOOGJGPP(in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, float KEOEBHPOCHG, Allocator LKNIKCJFBFH, out NativeArray<Entity> AFOGFGIBNGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class AGHMBCKDBFL : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	public AGHMBCKDBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class PJCKOKPEOCN : HEODJEKIBCE, JLLBLNFOFFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct IKKPNGDICNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public PJCKOKPEOCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public IKKPNGDICNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__0(Entity e, PNDIGOPDKPM ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BKJIHKMNMIF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		private struct LOAHJPGPMKB
		{
			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			public struct EAJPBJOCHOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public LambdaParameterValueProvider_Entity.Runtime KEKAJCDGBBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public LambdaParameterValueProvider_IComponentData<PNDIGOPDKPM>.Runtime KDJGJELEEKN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DDJMNFNHILH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<PNDIGOPDKPM> MNCHJBFMDHF;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x25E55F0", Offset = "0x25E45F0", VA = "0x1825E55F0")]
			public void AIMCPLKOAEL(PJCKOKPEOCN MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x25E5650", Offset = "0x25E4650", VA = "0x1825E5650")]
			public EAJPBJOCHOK CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(EAJPBJOCHOK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public PJCKOKPEOCN HHHPDLBJBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public EntityCommandBuffer PFPDJCDPJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private LOAHJPGPMKB OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LOAHJPGPMKB.EAJPBJOCHOK* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x25E0580", Offset = "0x25DF580", VA = "0x1825E0580")]
		internal void ENEEDINPEMO(Entity MKAEFGDNMHM, PNDIGOPDKPM AKAHDNMPMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x25E07D0", Offset = "0x25DF7D0", VA = "0x1825E07D0", Slot = "5")]
		public void ReadFromDisplayClass(ref IKKPNGDICNO BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x25E0800", Offset = "0x25DF800", VA = "0x1825E0800", Slot = "6")]
		public void WriteToDisplayClass(ref IKKPNGDICNO BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x25E0680", Offset = "0x25DF680", VA = "0x1825E0680", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x25E0720", Offset = "0x25DF720", VA = "0x1825E0720")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, ref LOAHJPGPMKB.EAJPBJOCHOK HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x25E04F0", Offset = "0x25DF4F0", VA = "0x1825E04F0")]
		public void AIMCPLKOAEL(PJCKOKPEOCN MNFLHJKJICL, ref IKKPNGDICNO BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x25E0490", Offset = "0x25DF490", VA = "0x1825E0490")]
		public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private AGHMBCKDBFL KBPJKKBELLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private FOLFFNLGEBO NKBCKMKPIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private EntityQuery JBPKHKIAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private ProfilerMarker IBPNLCMHLNP;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x25F07A0", Offset = "0x25EF7A0", VA = "0x1825F07A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x25F03B0", Offset = "0x25EF3B0", VA = "0x1825F03B0", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x25F0800", Offset = "0x25EF800", VA = "0x1825F0800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public PJCKOKPEOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x25F05A0", Offset = "0x25EF5A0", VA = "0x1825F05A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x25F0410", Offset = "0x25EF410", VA = "0x1825F0410")]
	public static EntityQuery OFCNDNODEPN(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[DOKDCAPODCB(PBFEFLGCHAA.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : HEODJEKIBCE, JLLBLNFOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		private struct KCBKEPNHNJG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public DJGBCAKLMIB BDOHHFJFLIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public NativeHashMap<Entity, OBILJNMGGGG> AFOGFGIBNGF;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x22CCED0", Offset = "0x22CBED0", VA = "0x1822CCED0")]
			public KCBKEPNHNJG(int FANLILHFAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x22CCE60", Offset = "0x22CBE60", VA = "0x1822CCE60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[BurstCompile]
		private struct FHCBODMBIBC : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000245")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CNMGENACEBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> JPNCKGMLPJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000247")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> FIMEHIKCFDB;

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x22CB580", Offset = "0x22CA580", VA = "0x1822CB580", Slot = "4")]
			public void Execute(int IIHEDPBOLFE, TransformAccess BCLIDGMJFFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[BurstCompile]
		private struct GMOBDDBCOBE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CNMGENACEBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> FIMEHIKCFDB;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x22CC260", Offset = "0x22CB260", VA = "0x1822CC260", Slot = "4")]
			public void Execute(int IIHEDPBOLFE, TransformAccess BCLIDGMJFFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private FOLFFNLGEBO NKBCKMKPIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private EntityQuery LAJKICAPHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private EntityQuery FJEICGOKIHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private EntityQuery PMNJFIGOBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private EntityQuery AHGHLOJMHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private EntityQuery KDKJGOOKNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private JobHandle CPPGBIMJPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private KCBKEPNHNJG OKOIAEALAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private KCBKEPNHNJG EOGANGOPJDO;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x22D2C80", Offset = "0x22D1C80", VA = "0x1822D2C80", Slot = "14")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x22D2CE0", Offset = "0x22D1CE0", VA = "0x1822D2CE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x22D2F20", Offset = "0x22D1F20", VA = "0x1822D2F20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x22D2F30", Offset = "0x22D1F30", VA = "0x1822D2F30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x22D29F0", Offset = "0x22D19F0", VA = "0x1822D29F0")]
		private void LNCBINAJJCG(EntityQuery FHCACFJLPLH, out (global::JKLCOILHKCM<PNDIGOPDKPM> handles, global::JKLCOILHKCM<LLHKPPBKIID> bounds) JEJGBICCBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x22D3790", Offset = "0x22D2790", VA = "0x1822D3790")]
		private void PPFKNHNHOGD((global::JKLCOILHKCM<PNDIGOPDKPM> handles, global::JKLCOILHKCM<LLHKPPBKIID> bounds) JEJGBICCBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x22D27A0", Offset = "0x22D17A0", VA = "0x1822D27A0")]
		private void CELPFPLFMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x22D2640", Offset = "0x22D1640", VA = "0x1822D2640")]
		private void AJKIHJCIKCB(EntityQuery FHCACFJLPLH, out (global::JKLCOILHKCM<Entity> entities, global::JKLCOILHKCM<PNDIGOPDKPM> handles) JEJGBICCBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x22D23E0", Offset = "0x22D13E0", VA = "0x1822D23E0")]
		private void ABLMOKKCCLC((global::JKLCOILHKCM<Entity> entities, global::JKLCOILHKCM<PNDIGOPDKPM> handles) JEJGBICCBLN, KCBKEPNHNJG BCEODFDILJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x22D28A0", Offset = "0x22D18A0", VA = "0x1822D28A0")]
		private JobHandle JAKEKBEHJIP(KCBKEPNHNJG BCEODFDILJK, ComponentDataFromEntity<WorldPoseData> CNMGENACEBM, ComponentDataFromEntity<WorldUniformScaleData> FIMEHIKCFDB, ComponentDataFromEntity<WorldDeformableScaleData> JPNCKGMLPJF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x22D2B50", Offset = "0x22D1B50", VA = "0x1822D2B50")]
		private JobHandle NJLNGALEJDE(KCBKEPNHNJG BCEODFDILJK, ComponentDataFromEntity<WorldPoseData> CNMGENACEBM, ComponentDataFromEntity<WorldUniformScaleData> FIMEHIKCFDB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[AJHJJBJAJKN(typeof(JAIAOMAFFHB), new string[] { })]
public sealed class NFNPENHJOKM : JAIAOMAFFHB, JLLBLNFOFFK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct HJJHOEBFCBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public float FHGEGKGNIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public uint IOAPHBNDBDJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private BKMMLEGBFNN PIJAIKBNBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private ICFGODIOHFN MMAHGNNLEFF;

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x25E9C20", Offset = "0x25E8C20", VA = "0x1825E9C20", Slot = "5")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x25E9710", Offset = "0x25E8710", VA = "0x1825E9710")]
	public bool GGOGBMKFGCH(in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, float KEOEBHPOCHG, out KNHNAPFHING BJHFMHDLOIO, out Entity KNDKCBPGNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x25E9B00", Offset = "0x25E8B00", VA = "0x1825E9B00")]
	public static bool KGGCMMJGADM(in Span<KNHNAPFHING> EMKHGGNLNFO, float KEOEBHPOCHG, out int IIHEDPBOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x25E9BF0", Offset = "0x25E8BF0", VA = "0x1825E9BF0")]
	public static float NFFLIOKNBMD(float FHGEGKGNIPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public NFNPENHJOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x25E9C80", Offset = "0x25E8C80", VA = "0x1825E9C80", Slot = "4")]
	private bool OKALBOILINL(in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, float KEOEBHPOCHG, out KNHNAPFHING BJHFMHDLOIO, out Entity KNDKCBPGNFG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct NPHAOCFKLJD : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[DOKDCAPODCB(PBFEFLGCHAA.Physics)]
	public class SplineLocalBoundsSystem : HEODJEKIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[BurstCompile]
		private struct NHNCNNBMCNN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			[ReadOnly]
			public NativeArray<Entity> IPHGHMAPOHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> IHKPNBDCLLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			[ReadOnly]
			public ComponentDataFromEntity<LLHKPPBKIID> KOOIHCNPNCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			[WriteOnly]
			public NativeHashMap<Entity, OBILJNMGGGG>.ParallelWriter KPFMHJDAKBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter FHIPNEJONFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter LEGICCFLMPK;

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x576F880", Offset = "0x576E880", VA = "0x18576F880", Slot = "4")]
			public void Execute(int IIHEDPBOLFE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[BurstCompile]
		private struct GOPODGANEDI : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			[ReadOnly]
			public NativeArray<Entity> KCBDIIIIHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> PPJLAKNGBHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> IHKPNBDCLLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LLHKPPBKIID> OEACCFGEBDA;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x576EB50", Offset = "0x576DB50", VA = "0x18576EB50", Slot = "4")]
			public void Execute(int IIHEDPBOLFE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private EntityQuery NECHOAHGGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private EntityQuery PLIDPEPHMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private EntityQuery PCGMGAFAFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private EntityQuery OMNKNOKMBPE;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x22D9050", Offset = "0x22D8050", VA = "0x1822D9050", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x22D91F0", Offset = "0x22D81F0", VA = "0x1822D91F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x22D8C10", Offset = "0x22D7C10", VA = "0x1822D8C10")]
		private JobHandle HHMDLOLHOPA(global::JKLCOILHKCM<Entity> DNAEDFOPGEJ, int BPGPLFOLHKN, JobHandle FPLJAFOBFPB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x22D8CE0", Offset = "0x22D7CE0", VA = "0x1822D8CE0")]
		private JobHandle HHMDLOLHOPA(NativeArray<Entity> CFGFPOOJIPD, int BPGPLFOLHKN, [Optional] JobHandle FPLJAFOBFPB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x22D8FC0", Offset = "0x22D7FC0", VA = "0x1822D8FC0")]
		private global::JKLCOILHKCM<Entity> NDFEKJOHPGK(EntityQuery FHCACFJLPLH)
		{
			return default(global::JKLCOILHKCM<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x22D8440", Offset = "0x22D7440", VA = "0x1822D8440")]
		private (global::AFFGCLHKPJN<Entity>, global::AFFGCLHKPJN<Entity>) BEDDMBBBCMK(global::JKLCOILHKCM<Entity> EJJLFGKAKPJ)
		{
			return default((global::AFFGCLHKPJN<Entity>, global::AFFGCLHKPJN<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x22D8B90", Offset = "0x22D7B90", VA = "0x1822D8B90")]
		private void GLPCMHKCKJO(out NativeArray<Entity> AFOGFGIBNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x22D9730", Offset = "0x22D8730", VA = "0x1822D9730")]
		private void PKKEIDENMDL(NativeList<Entity> AFOGFGIBNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x22D97B0", Offset = "0x22D87B0", VA = "0x1822D97B0")]
		private void PKKEIDENMDL(NativeArray<Entity> AFOGFGIBNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x22D8EA0", Offset = "0x22D7EA0", VA = "0x1822D8EA0")]
		private void MBAFNDFIDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private static void OCDIGHNNBJO(int IGAANFDKHFL, int PFJPDACOEMM, int EBIJLAGGJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x22D8810", Offset = "0x22D7810", VA = "0x1822D8810")]
		private static LLHKPPBKIID CGNCJPEILHO(NativeArray<Entity> IMCMLEBDNEN, ComponentDataFromEntity<SplinePointData> IHKPNBDCLLA)
		{
			return default(LLHKPPBKIID);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[AJHJJBJAJKN(typeof(ICFGODIOHFN), new string[] { })]
public sealed class AHJCNLOKPJF : ICFGODIOHFN, JLLBLNFOFFK
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[BurstCompile]
	private struct MAJLPNIOGKH : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		[ReadOnly]
		public NativeArray<Entity> AFOGFGIBNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		[ReadOnly]
		public float3 FFFKCCJGKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		[ReadOnly]
		public float3 ABEABAHLFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> BMBNJDCAMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> DGAPNOALIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> PPJLAKNGBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> IHKPNBDCLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		[WriteOnly]
		public NativeArray<KNHNAPFHING> LOHMNPACGDC;

		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private static readonly KNHNAPFHING NFMOJNOOOAM;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x24609E0", Offset = "0x245F9E0", VA = "0x1824609E0", Slot = "4")]
		public void Execute(int IIHEDPBOLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x2460FE0", Offset = "0x245FFE0", VA = "0x182460FE0")]
		private static float3 KFCNJABJEKJ(in float4x4 BEPNEODPHKP, in float3 BKLFBAMHBAG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x2460D10", Offset = "0x245FD10", VA = "0x182460D10")]
		private static float3 GACICIPDNFI(in float4x4 BEPNEODPHKP, in float3 COCNKFFEBDI)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2460EE0", Offset = "0x245FEE0", VA = "0x182460EE0")]
		private static float3 HJOOFBHPOLD(in float4x4 BEPNEODPHKP, in float3 BKLFBAMHBAG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x24600B0", Offset = "0x245F0B0", VA = "0x1824600B0")]
		private static float3 DCAHOBMKPIE(in float4x4 BEPNEODPHKP, in float3 COCNKFFEBDI)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x24610A0", Offset = "0x24600A0", VA = "0x1824610A0")]
		private bool NHFPMLODEGP(in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, in NativeArray<Entity> BIIAKAJHNDM, out float3 BJHFMHDLOIO, out float3 IFEFNGAGKNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x24602E0", Offset = "0x245F2E0", VA = "0x1824602E0")]
		public static bool EPPOLFMEGOI(in float3 AOFBBPICCGA, in float3 NFNIPDEOPCE, in float3 AAAEHBMMIMD, in float3 AALBBBKIOPK, float BPJLIDPKEEA, float EIFJIIDPDIF, out float JBJIMKKMMPN, out float3 DGMBKMBCJJI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private EntityManager EFLHIHFKEDM;

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x244BBE0", Offset = "0x244ABE0", VA = "0x18244BBE0", Slot = "5")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x244B9D0", Offset = "0x244A9D0", VA = "0x18244B9D0")]
	public void GGOGBMKFGCH(in NativeArray<Entity> AFOGFGIBNGF, in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, in NativeArray<KNHNAPFHING> DBNAJDFPCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AHJCNLOKPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x244B9D0", Offset = "0x244A9D0", VA = "0x18244B9D0", Slot = "4")]
	private void KMAMOGHCLLJ(in NativeArray<Entity> AFOGFGIBNGF, in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, in NativeArray<KNHNAPFHING> DBNAJDFPCBF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct GBNNAFMENDA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[DOKDCAPODCB(PBFEFLGCHAA.Lifecycle)]
	public class DestroyLocalObjects : HEODJEKIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private bool NJLKFAFJNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private EntityQuery ICBIGONCPAF;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x22C8E40", Offset = "0x22C7E40", VA = "0x1822C8E40")]
		public bool HALBOCCMDNK(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x22C8EE0", Offset = "0x22C7EE0", VA = "0x1822C8EE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x22C8F60", Offset = "0x22C7F60", VA = "0x1822C8F60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x101CC40", Offset = "0x101BC40", VA = "0x18101CC40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[DOKDCAPODCB(PBFEFLGCHAA.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : HEODJEKIBCE, JLLBLNFOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private GJHAFFNOPCK DILLFDMAIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private ONNFHGLOINK DMBMIAHPMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private EDGAKEAHJHK LKOJKOJNBBK;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		protected abstract ComputePropertyDifferences BNHJNHHEHAE
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x22C9940", Offset = "0x22C8940", VA = "0x1822C9940", Slot = "14")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x22C99F0", Offset = "0x22C89F0", VA = "0x1822C99F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private void DACFPIDFDBI(Entity CLCJGDKEGGN, LEPNJELBIPF POJMBOCFKCO, FOHAFCOAAJF EDJOONFFAPI, OACDCJOBFGL CLLAJKPCNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[DOKDCAPODCB(PBFEFLGCHAA.Callbacks)]
	public abstract class PropertyEventCallbacks : HEODJEKIBCE, JLLBLNFOFFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private PropertyEventCallbacksService ADHLHDNNJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private EDGAKEAHJHK LKOJKOJNBBK;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x22D70E0", Offset = "0x22D60E0", VA = "0x1822D70E0", Slot = "14")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x22D7160", Offset = "0x22D6160", VA = "0x1822D7160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public abstract class GFEBIFMBKJM : HEODJEKIBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private List<(EntityQuery, ComponentType)> DJBJNOPKDAM;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x245C160", Offset = "0x245B160", VA = "0x18245C160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x245C330", Offset = "0x245B330", VA = "0x18245C330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x245A090", Offset = "0x2459090", VA = "0x18245A090")]
	protected GFEBIFMBKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PHNCFENELLA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public int KBBNJEDOENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public int ICOAIKCLAGF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x25F0390", Offset = "0x25EF390", VA = "0x1825F0390")]
	public static Entity BNLFJABIBKP(PHNCFENELLA JEJGBICCBLN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x25F0390", Offset = "0x25EF390", VA = "0x1825F0390")]
	public static PHNCFENELLA BNLFJABIBKP(Entity CLCJGDKEGGN)
	{
		return default(PHNCFENELLA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct HMKFFGEIBBL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct EFCGLBFOCAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public readonly ComponentType OHBFPBMFEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public readonly NativeList<int> BKMGCALIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public readonly NativeList<int> CJCIFICIHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public readonly NativeArray<Entity> AFOGFGIBNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public readonly NativeArray<Entity> HCEENNDJLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public readonly NativeArray<byte> KDOMAPKLCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public readonly NativeArray<byte> KFPPFLMHIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly int OCEDJCJBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public readonly int IAMOAFPDKOL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool DHNNELJKGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2459AE0", Offset = "0x2458AE0", VA = "0x182459AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x2459EE0", Offset = "0x2458EE0", VA = "0x182459EE0")]
	public EFCGLBFOCAL(ComponentType OHBFPBMFEHG, NativeList<int> BKMGCALIDIC, NativeList<int> CJCIFICIHDI, NativeArray<Entity> AFOGFGIBNGF, NativeArray<Entity> HCEENNDJLJO, NativeArray<byte> KDOMAPKLCCO, NativeArray<byte> KFPPFLMHIFD, int OCEDJCJBLNH, int IAMOAFPDKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x2459B50", Offset = "0x2458B50", VA = "0x182459B50")]
	private JHBOMEIKHGC CDNMILOIKHC(NativeArray<byte> DNAEDFOPGEJ, int IIHEDPBOLFE)
	{
		return default(JHBOMEIKHGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	private T CDNMILOIKHC<T>(NativeArray<byte> DNAEDFOPGEJ, int IIHEDPBOLFE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x2459E90", Offset = "0x2458E90", VA = "0x182459E90")]
	public JHBOMEIKHGC PCNLIBFBOCF(int IIHEDPBOLFE)
	{
		return default(JHBOMEIKHGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	public T PCNLIBFBOCF<T>(int IIHEDPBOLFE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x2459E40", Offset = "0x2458E40", VA = "0x182459E40")]
	public JHBOMEIKHGC JBFNPJLOCAM(int IIHEDPBOLFE)
	{
		return default(JHBOMEIKHGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	public T JBFNPJLOCAM<T>(int IIHEDPBOLFE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x2459D60", Offset = "0x2458D60", VA = "0x182459D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct NCMOIMHGIPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public readonly EntityQuery FHCACFJLPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public readonly NativeArray<ICGHLHCPCJL> BIPGBCJBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public readonly ComponentType OHBFPBMFEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public readonly int OCEDJCJBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public readonly int IAMOAFPDKOL;

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x25E96E0", Offset = "0x25E86E0", VA = "0x1825E96E0")]
	public NCMOIMHGIPL(ComponentType OHBFPBMFEHG, int OCEDJCJBLNH, int IAMOAFPDKOL, EntityQuery FHCACFJLPLH, NativeArray<ICGHLHCPCJL> BIPGBCJBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x25E9690", Offset = "0x25E8690", VA = "0x1825E9690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct EMFIFPIMEND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public int IIHEDPBOLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public int DLCBOJPHOFF;

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x76ED30", Offset = "0x76DD30", VA = "0x18076ED30")]
	public EMFIFPIMEND(int IIHEDPBOLFE, int DLCBOJPHOFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct ICGHLHCPCJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public readonly int KDGOCEAMMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public readonly int CCDDIFMMPAN;

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x76ED30", Offset = "0x76DD30", VA = "0x18076ED30")]
	public ICGHLHCPCJL(int KDGOCEAMMLM, int CCDDIFMMPAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct OACDCJOBFGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly IHCHEEIIPON LGBAJKGIPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly int OCEDJCJBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private unsafe readonly byte* KDOMAPKLCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private unsafe readonly byte* KFPPFLMHIFD;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x25EBB10", Offset = "0x25EAB10", VA = "0x1825EBB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IHCHEEIIPON EEBBOAEJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500")]
		get
		{
			return default(IHCHEEIIPON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x25EBC00", Offset = "0x25EAC00", VA = "0x1825EBC00")]
	public JHBOMEIKHGC IGBCNAFDIFL(Type GLKKDGLKBMK)
	{
		return default(JHBOMEIKHGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x25EBB20", Offset = "0x25EAB20", VA = "0x1825EBB20")]
	public JHBOMEIKHGC GBMJPFBIKHD(Type GLKKDGLKBMK)
	{
		return default(JHBOMEIKHGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x20C4730", Offset = "0x20C3730", VA = "0x1820C4730")]
	public T IGBCNAFDIFL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x20C4710", Offset = "0x20C3710", VA = "0x1820C4710")]
	public T GBMJPFBIKHD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x25EBCE0", Offset = "0x25EACE0", VA = "0x1825EBCE0")]
	public unsafe OACDCJOBFGL(IHCHEEIIPON LGBAJKGIPMA, int CCDDIFMMPAN, byte* KDOMAPKLCCO, byte* KFPPFLMHIFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class DMLAAAIAOPO
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] PNDPEFPMGMC;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[DefaultMember("Item")]
internal class DHMGKPCDAGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly Dictionary<ComponentType, NCMOIMHGIPL> BGOCEDFJLON;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public NCMOIMHGIPL AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x2458DF0", Offset = "0x2457DF0", VA = "0x182458DF0")]
		get
		{
			return default(NCMOIMHGIPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x2458E70", Offset = "0x2457E70", VA = "0x182458E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2458EC0", Offset = "0x2457EC0", VA = "0x182458EC0")]
	public DHMGKPCDAGM(GDEFGFJPJEE CBJNPEBBDJA, LOBJLOAJGBA NMFPNEPNNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x2458970", Offset = "0x2457970", VA = "0x182458970")]
	public Dictionary<ComponentType, NCMOIMHGIPL>.Enumerator GMHPDHEDPBP()
	{
		return default(Dictionary<ComponentType, NCMOIMHGIPL>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x24587F0", Offset = "0x24577F0", VA = "0x1824587F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2458A00", Offset = "0x2457A00", VA = "0x182458A00")]
	private void IFLLOIKIDHH(IEnumerable<OIINEGGMHHI> IJAEEGIEEAG, EntityManager EFLHIHFKEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x2458740", Offset = "0x2457740", VA = "0x182458740")]
	private static int AKDEJCIAPDJ(OIINEGGMHHI FBFPPNOCINM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x2458490", Offset = "0x2457490", VA = "0x182458490")]
	private static NativeArray<ICGHLHCPCJL> AAGLJBKKDKD(OIINEGGMHHI FBFPPNOCINM, Allocator LKNIKCJFBFH = Allocator.Persistent)
	{
		return default(NativeArray<ICGHLHCPCJL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal interface EDGAKEAHJHK
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	World MIKMLLKGKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OMONEGKDCBI(out NativeArray<int> HBFAHJEPIGF, Allocator LKNIKCJFBFH);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIAOMDHDHCB(ComponentType OHBFPBMFEHG, out EFCGLBFOCAL JNAFCEALGAJ, out NCMOIMHGIPL IACKKMEKEAC);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIAOMDHDHCB(ComponentType OHBFPBMFEHG, out EFCGLBFOCAL JNAFCEALGAJ);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EFCGLBFOCAL BPLEIBNANCJ(ComponentType OHBFPBMFEHG);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FFLKJIBPLHN DAOMCGDPGKC();

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KHAGPEGBMGN(JobHandle IHEGNLMLNLI);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal interface ACNMABKOGMM
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	World MIKMLLKGKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	DHMGKPCDAGM HHGEOLCOGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	KFDBFKFHPMI FFAKLEHACGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	NativeMultiHashMap<Entity, OACDCJOBFGL> DPNECKFGDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	JobHandle PLMHAMKEJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GICBDFIFCOH();

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MCOHOPDDOPF();

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JMCMFEMJEIK(ComponentType OHBFPBMFEHG, in EFCGLBFOCAL FOKFDLBOBAL);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LFLMJMHDKCM(DAGBJECOPFG FMMJPPJOKHJ, out Entity DOJHMGHFEFN);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[DOKDCAPODCB(PBFEFLGCHAA.PropertyChanges)]
	[AJHJJBJAJKN(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : JLLBLNFOFFK, HLHBDIEKOND, ACNMABKOGMM, EDGAKEAHJHK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private GDEFGFJPJEE CBJNPEBBDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private ObjectPrefabCreationService LMDAFICOHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private DNEKLGPFBJJ PLFMGNDCBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private DHMGKPCDAGM BGOCEDFJLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private KFDBFKFHPMI NGLCDIGJHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private BDKBIAAKEAG NAOEFCLELEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private List<EFCGLBFOCAL> PHIEOHAKHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private NativeMultiHashMap<Entity, OACDCJOBFGL> NPIOMLFKOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private NativeHashMap<int, int> PFAKPJBGBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private JobHandle JNLFJGFDCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private JobHandle PMCIICHDHDI;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool DHNNELJKGKA
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x22D4F60", Offset = "0x22D3F60", VA = "0x1822D4F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private World NPEKFHCNNOL
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x22D56D0", Offset = "0x22D46D0", VA = "0x1822D56D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private DHMGKPCDAGM BJAHLABMKIO
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		private KFDBFKFHPMI FAOGBCNHKFD
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		private NativeMultiHashMap<Entity, OACDCJOBFGL> DMEAJCMPOIF
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0xF57AC0", Offset = "0xF56AC0", VA = "0x180F57AC0", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, OACDCJOBFGL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		private JobHandle EONOLMEAJGK
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x8E6DD0", Offset = "0x8E5DD0", VA = "0x1808E6DD0", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x8E6E80", Offset = "0x8E5E80", VA = "0x1808E6E80", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private World PJMLIKJNHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x22D5370", Offset = "0x22D4370", VA = "0x1822D5370", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x22D5B20", Offset = "0x22D4B20", VA = "0x1822D5B20", Slot = "13")]
		private void MKHCHKHNCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x22D5130", Offset = "0x22D4130", VA = "0x1822D5130", Slot = "12")]
		private void DGJCPDMINEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x22D52A0", Offset = "0x22D42A0", VA = "0x1822D52A0", Slot = "14")]
		private void EDJPIEIKANO(ComponentType OHBFPBMFEHG, in EFCGLBFOCAL FOKFDLBOBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x22D4F40", Offset = "0x22D3F40", VA = "0x1822D4F40", Slot = "15")]
		private bool BMLOAOEMFGL(DAGBJECOPFG FMMJPPJOKHJ, out Entity DOJHMGHFEFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x22D5640", Offset = "0x22D4640", VA = "0x1822D5640", Slot = "17")]
		private bool ENLICMHODBD(out NativeArray<int> HBFAHJEPIGF, Allocator LKNIKCJFBFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x22D53D0", Offset = "0x22D43D0", VA = "0x1822D53D0", Slot = "18")]
		private bool ELBLHCKLDNO(ComponentType OHBFPBMFEHG, out EFCGLBFOCAL JNAFCEALGAJ, out NCMOIMHGIPL IACKKMEKEAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x22D5530", Offset = "0x22D4530", VA = "0x1822D5530", Slot = "19")]
		private bool ELBLHCKLDNO(ComponentType OHBFPBMFEHG, out EFCGLBFOCAL JNAFCEALGAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x22D5BA0", Offset = "0x22D4BA0", VA = "0x1822D5BA0", Slot = "20")]
		private EFCGLBFOCAL OMPFCIBCIPE(ComponentType OHBFPBMFEHG)
		{
			return default(EFCGLBFOCAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x22D5AE0", Offset = "0x22D4AE0", VA = "0x1822D5AE0", Slot = "21")]
		private FFLKJIBPLHN MIOGIMMNLHL()
		{
			return default(FFLKJIBPLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x22D5880", Offset = "0x22D4880", VA = "0x1822D5880", Slot = "22")]
		private void LGHKCMMAALE(JobHandle IHEGNLMLNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x22D5B30", Offset = "0x22D4B30", VA = "0x1822D5B30", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x22D5CD0", Offset = "0x22D4CD0", VA = "0x1822D5CD0", Slot = "5")]
		public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x22D51E0", Offset = "0x22D41E0", VA = "0x1822D51E0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x22D58C0", Offset = "0x22D48C0", VA = "0x1822D58C0")]
		private void MCOHOPDDOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x22D4F70", Offset = "0x22D3F70", VA = "0x1822D4F70")]
		private bool CFCIOCIIBJC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x22D5730", Offset = "0x22D4730", VA = "0x1822D5730")]
		private int FLNOLILEAJO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x22D5EC0", Offset = "0x22D4EC0", VA = "0x1822D5EC0")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct FFLKJIBPLHN
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public struct AIFNFHEOKLC : IEnumerator<OACDCJOBFGL>, IEnumerator, IDisposable, IEnumerable<OACDCJOBFGL>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private readonly NativeMultiHashMap<Entity, OACDCJOBFGL> KINLBAPNNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private readonly Entity CLCJGDKEGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private NativeMultiHashMapIterator<Entity> FNFHLBIHJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private OACDCJOBFGL KFPPFLMHIFD;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public OACDCJOBFGL EINNBBEGEGD
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0xBFBF40", Offset = "0xBFAF40", VA = "0x180BFBF40", Slot = "4")]
			get
			{
				return default(OACDCJOBFGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x244BEA0", Offset = "0x244AEA0", VA = "0x18244BEA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x244BEF0", Offset = "0x244AEF0", VA = "0x18244BEF0")]
		internal AIFNFHEOKLC(NativeMultiHashMap<Entity, OACDCJOBFGL> KINLBAPNNKI, Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x244BC80", Offset = "0x244AC80", VA = "0x18244BC80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x244BC50", Offset = "0x244AC50", VA = "0x18244BC50")]
		public AIFNFHEOKLC GMHPDHEDPBP()
		{
			return default(AIFNFHEOKLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x244BD40", Offset = "0x244AD40", VA = "0x18244BD40", Slot = "9")]
		private IEnumerator<OACDCJOBFGL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x244BDF0", Offset = "0x244ADF0", VA = "0x18244BDF0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private readonly ACNMABKOGMM LKOJKOJNBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private readonly JobHandle EIIGJKKCPJM;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int BAGNPAIINDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x245BDE0", Offset = "0x245ADE0", VA = "0x18245BDE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool LNHKEACDENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x245BD00", Offset = "0x245AD00", VA = "0x18245BD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x245BED0", Offset = "0x245AED0", VA = "0x18245BED0")]
	public FFLKJIBPLHN(ACNMABKOGMM LKOJKOJNBBK, JobHandle EIIGJKKCPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x245BAB0", Offset = "0x245AAB0", VA = "0x18245BAB0")]
	public bool FFPCFCEKEGC(Allocator LKNIKCJFBFH, out NativeKeyValueArrays<Entity, OACDCJOBFGL> HCBFPGACPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x245B960", Offset = "0x245A960", VA = "0x18245B960")]
	public bool DPGLENIMJHF(Allocator LKNIKCJFBFH, out (NativeArray<Entity> entities, int uniqueCount) HCBFPGACPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x245BBF0", Offset = "0x245ABF0", VA = "0x18245BBF0")]
	public AIFNFHEOKLC JPMCEPJLKHA(Entity CLCJGDKEGGN)
	{
		return default(AIFNFHEOKLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[DefaultMember("Item")]
internal class KFDBFKFHPMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly List<NCMOIMHGIPL> DMCFFMAPNPG;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public NCMOIMHGIPL AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x22E8F80", Offset = "0x22E7F80", VA = "0x1822E8F80")]
		get
		{
			return default(NCMOIMHGIPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x22E9010", Offset = "0x22E8010", VA = "0x1822E9010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x22E9050", Offset = "0x22E8050", VA = "0x1822E9050")]
	public KFDBFKFHPMI(DHMGKPCDAGM BGOCEDFJLON, GDEFGFJPJEE CBJNPEBBDJA, LOBJLOAJGBA NMFPNEPNNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x22E8C00", Offset = "0x22E7C00", VA = "0x1822E8C00")]
	public List<NCMOIMHGIPL>.Enumerator GMHPDHEDPBP()
	{
		return default(List<NCMOIMHGIPL>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x22E8A80", Offset = "0x22E7A80", VA = "0x1822E8A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x22E8C80", Offset = "0x22E7C80", VA = "0x1822E8C80")]
	private void IFLLOIKIDHH(DHMGKPCDAGM BGOCEDFJLON, EntityManager EFLHIHFKEDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class BDKBIAAKEAG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly ObjectPrefabCreationService LMDAFICOHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private readonly global::LCJIKJFODKN<OIINEGGMHHI> FKBOOGEEFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly World INFHBCMIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly EntityManager EFLHIHFKEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private NativeHashMap<int, Entity> NAOEFCLELEL;

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x244F980", Offset = "0x244E980", VA = "0x18244F980")]
	public BDKBIAAKEAG(ObjectPrefabCreationService LMDAFICOHNG, GDEFGFJPJEE CBJNPEBBDJA, LOBJLOAJGBA NMFPNEPNNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x244EA30", Offset = "0x244DA30", VA = "0x18244EA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x244F920", Offset = "0x244E920", VA = "0x18244F920")]
	public bool PKDLPKBFEHI(DAGBJECOPFG FMMJPPJOKHJ, out Entity DOJHMGHFEFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x244EA90", Offset = "0x244DA90", VA = "0x18244EA90")]
	private void HCACHKJLDFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x244E350", Offset = "0x244D350", VA = "0x18244E350")]
	private EntityArchetype ACBIGCBOHNC(EntityArchetype GBNKGMLHIIM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x244F3E0", Offset = "0x244E3E0", VA = "0x18244F3E0")]
	public static void NOFLPPPFAJM(EntityManager OAAKHOOJOIO, EntityManager CBANNNBOFKL, NativeArray<Entity> NGFPBEGJKHE, NativeArray<EntityArchetype> HMFCJDNIHKJ, [Optional] NativeArray<Entity> CBPDKLGMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x244F070", Offset = "0x244E070", VA = "0x18244F070")]
	[Conditional("DEBUG_BUILD")]
	private static void IHDNMKLPLDE(NativeArray<EntityArchetype> MDANCMHCAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x244E850", Offset = "0x244D850", VA = "0x18244E850")]
	private static string ALHMIFEGFAE(EntityArchetype CPEAGKNFJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x244F2A0", Offset = "0x244E2A0", VA = "0x18244F2A0")]
	[CompilerGenerated]
	internal static void MCGIAHBAOCJ(ref Span<ComponentType> PLPBODJOKMA, ComponentType JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x244F780", Offset = "0x244E780", VA = "0x18244F780")]
	[CompilerGenerated]
	internal static void PIABNAEPBIC(Span<ComponentType> DNAEDFOPGEJ, ref Span<ComponentType> PLPBODJOKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x244F1D0", Offset = "0x244E1D0", VA = "0x18244F1D0")]
	[CompilerGenerated]
	internal static void LHPMGDEPJAN(Span<ComponentType> DNAEDFOPGEJ, ref Span<ComponentType> PLPBODJOKMA, ComponentType GDFPKHFLADF)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[DOKDCAPODCB(PBFEFLGCHAA.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : HEODJEKIBCE, JLLBLNFOFFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private struct HDMDFDKFBNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public BHFJFIGJMCP dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			public HDMDFDKFBNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct LAJFNPLMJLO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			[ReadOnly]
			public NativeArray<byte> KFPPFLMHIFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			[ReadOnly]
			public NativeList<int> BKMGCALIDIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			[ReadOnly]
			public NativeArray<Entity> HCEENNDJLJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public int OCEDJCJBLNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public BHFJFIGJMCP FLDLFKJNEFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public ComponentType OHBFPBMFEHG;

			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0x25E4DC0", Offset = "0x25E3DC0", VA = "0x1825E4DC0")]
			internal void ENEEDINPEMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x25E4F70", Offset = "0x25E3F70", VA = "0x1825E4F70", Slot = "5")]
			public void ReadFromDisplayClass(ref HDMDFDKFBNF BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x25E4F60", Offset = "0x25E3F60", VA = "0x1825E4F60", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x25E4DA0", Offset = "0x25E3DA0", VA = "0x1825E4DA0")]
			public void AIMCPLKOAEL(ApplyPropertyDifferences MNFLHJKJICL, ref HDMDFDKFBNF BMLBBBFJKKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private EDGAKEAHJHK LKOJKOJNBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private JobHandle JNLFJGFDCFK;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x25DF740", Offset = "0x25DE740", VA = "0x1825DF740")]
		public void BNBCPKDPKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x25DFA70", Offset = "0x25DEA70", VA = "0x1825DFA70", Slot = "14")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x25DFAD0", Offset = "0x25DEAD0", VA = "0x1825DFAD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x25DF750", Offset = "0x25DE750", VA = "0x1825DF750")]
		private bool JPFFBLHDJIP(JobHandle FPLJAFOBFPB, int KICCJKJLKLA, out JobHandle HPEMENGINOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[DOKDCAPODCB(PBFEFLGCHAA.PropertyChanges)]
	public abstract class ComputePropertyDifferences : HEODJEKIBCE, JLLBLNFOFFK, HLHBDIEKOND
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[BurstCompile]
		internal struct EHOHLCHJIFA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[ReadOnly]
			public NativeArray<byte> LIICMANLKDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			[ReadOnly]
			public NativeArray<byte> LKFDCNAMJOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			[ReadOnly]
			public NativeArray<ICGHLHCPCJL> NIMHCIPCJEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			[WriteOnly]
			public NativeList<EMFIFPIMEND>.ParallelWriter LMOKCFIICLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public int LNAFDIPOFBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			public int ILGIDOLNHDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public ProfilerMarker GEODGLDHIKA;

			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x22C9150", Offset = "0x22C8150", VA = "0x1822C9150", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x22C90C0", Offset = "0x22C80C0", VA = "0x1822C90C0")]
			private unsafe int BBAEKOFMPDB(byte* FONMBJNPDBI, byte* LIHCFPMBOOM)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[BurstCompile]
		internal struct JFGLFODFCCL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			[WriteOnly]
			public NativeList<int> BKMGCALIDIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			[WriteOnly]
			public NativeList<int> NAGEIADKFBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			[ReadOnly]
			public NativeList<EMFIFPIMEND> CACLLPEMAPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public ProfilerMarker GEODGLDHIKA;

			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x22CCDA0", Offset = "0x22CBDA0", VA = "0x1822CCDA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[BurstCompile]
		internal struct MDIPOCFLPMJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			[WriteOnly]
			public NativeArray<byte> GCBIINEDAAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			[ReadOnly]
			public BHFJFIGJMCP OLDGIDKPDOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public int OCEDJCJBLNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public ProfilerMarker GEODGLDHIKA;

			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x22CD3C0", Offset = "0x22CC3C0", VA = "0x1822CD3C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[BurstCompile]
		internal struct GDACNEKKLNE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, OACDCJOBFGL> JCEPEPFIOLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[ReadOnly]
			public NativeArray<byte> KDOMAPKLCCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			[ReadOnly]
			public NativeArray<byte> KFPPFLMHIFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			[ReadOnly]
			public NativeArray<ICGHLHCPCJL> BKACEKFMKHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			[ReadOnly]
			public NativeList<int> CJCIFICIHDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			[ReadOnly]
			public NativeList<int> BKMGCALIDIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public int NLHIJKOGNGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public int IAMOAFPDKOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			public ProfilerMarker GEODGLDHIKA;

			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x22CBEE0", Offset = "0x22CAEE0", VA = "0x1822CBEE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static readonly ProfilerMarker LFFALPNJPKL;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private static readonly ProfilerMarker BCMFCPKFCJC;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private static readonly ProfilerMarker PAHCKMLAPAP;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private static readonly ProfilerMarker HHCGKKDPCDD;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static readonly ProfilerMarker LDICOHAMMDH;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private static readonly ProfilerMarker JNILNBCLKOH;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private static readonly ProfilerMarker PLCFOJCMLJI;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private static readonly ProfilerMarker KHFKKBMEAMK;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private static readonly ProfilerMarker LMJCEEPKFLF;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private static readonly ProfilerMarker GPADMPBJMKF;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private static readonly ProfilerMarker NEEDKCCEPFB;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private static readonly ProfilerMarker PONMNGENHCM;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private static readonly ProfilerMarker BEPNIPLOIAD;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private static readonly ProfilerMarker JKGKAHBNFIM;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly ProfilerMarker OCKLNEJKHJP;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private static readonly ProfilerMarker OIGJIIBFAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private ACNMABKOGMM LKOJKOJNBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private ApplyPropertyDifferences EKLGDDLHGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private EntityQuery KAJONHOALIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private EntityQuery EPFDNPFGPFB;

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		protected abstract ApplyPropertyDifferences JCPNKCPAHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		internal World MIKMLLKGKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x25E3080", Offset = "0x25E2080", VA = "0x1825E3080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x25E1C20", Offset = "0x25E0C20", VA = "0x1825E1C20")]
		internal NCMOIMHGIPL HAPIAPEIKMO(ComponentType OHBFPBMFEHG)
		{
			return default(NCMOIMHGIPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x25E3200", Offset = "0x25E2200", VA = "0x1825E3200", Slot = "14")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "15")]
		public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x25E3260", Offset = "0x25E2260", VA = "0x1825E3260", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x25E33B0", Offset = "0x25E23B0", VA = "0x1825E33B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x25E3360", Offset = "0x25E2360", VA = "0x1825E3360", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x25E34D0", Offset = "0x25E24D0", VA = "0x1825E34D0")]
		private void PMCMOHJJNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x25E14D0", Offset = "0x25E04D0", VA = "0x1825E14D0")]
		private void CMFIMELICHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x25E15C0", Offset = "0x25E05C0", VA = "0x1825E15C0")]
		internal void DFBLMKEGBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x25E2E70", Offset = "0x25E1E70", VA = "0x1825E2E70")]
		private void LCBAAENGJDM(NativeArray<Entity> NGFPBEGJKHE, NativeArray<RRObjectPrefabData> NBDMCOKJCIP, ref NativeArray<Entity> BPDFJBJBBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x25E2A60", Offset = "0x25E1A60", VA = "0x1825E2A60")]
		internal void JBOEDKOGDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x25E0E40", Offset = "0x25DFE40", VA = "0x1825E0E40")]
		internal void CHFEBEBOJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x25E1CC0", Offset = "0x25E0CC0", VA = "0x1825E1CC0")]
		private void HFGNOCFIMPO(NCMOIMHGIPL IACKKMEKEAC, bool GGNHFCPJEPC, ref JobHandle KADLIJMAKBN, ref JobHandle CLOCCHHNHCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x25E1FB0", Offset = "0x25E0FB0", VA = "0x1825E1FB0")]
		internal bool HKJECCMHPPJ(in NCMOIMHGIPL LIHCFPMBOOM, out JobHandle BFJMCAAKMNM, out EFCGLBFOCAL IHOHLJAMAHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x25E1FE0", Offset = "0x25E0FE0", VA = "0x1825E1FE0")]
		private bool HKJECCMHPPJ(in NCMOIMHGIPL LIHCFPMBOOM, bool GGNHFCPJEPC, out JobHandle BFJMCAAKMNM, out EFCGLBFOCAL IHOHLJAMAHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x25E0CA0", Offset = "0x25DFCA0", VA = "0x1825E0CA0")]
		internal (NativeList<int>, NativeList<int>) ALEKHJJHGNM(NativeList<EMFIFPIMEND> CACLLPEMAPK, int FANLILHFAFO, JobHandle FPLJAFOBFPB, out JobHandle IHEGNLMLNLI, Allocator LKNIKCJFBFH = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x25E29C0", Offset = "0x25E19C0", VA = "0x1825E29C0")]
		internal static NativeArray<Entity> IDAMDGMKNHM(EntityQuery FHCACFJLPLH, out JobHandle ALCJKGDEMBN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x25E1BA0", Offset = "0x25E0BA0", VA = "0x1825E1BA0")]
		internal static NativeArray<byte> FIOOMDCFBDD(int FCLFFFPNPCK, out JobHandle BMOPMIENPCB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x25E2D20", Offset = "0x25E1D20", VA = "0x1825E2D20")]
		internal static NativeArray<byte> KBCCOKPBMGJ(EntityQuery FHCACFJLPLH, int KICCJKJLKLA, out JobHandle BMOPMIENPCB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x25E30D0", Offset = "0x25E20D0", VA = "0x1825E30D0")]
		internal static NativeArray<Entity> NDFEKJOHPGK(EntityQuery FHCACFJLPLH, out JobHandle CNCICMOMIEI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x25E0AB0", Offset = "0x25DFAB0", VA = "0x1825E0AB0")]
		internal NativeArray<byte> ACFBJCBCAED(NativeArray<Entity> AFOGFGIBNGF, NCMOIMHGIPL IACKKMEKEAC, JobHandle FPLJAFOBFPB, out JobHandle IHEGNLMLNLI, Allocator LKNIKCJFBFH = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x25E2830", Offset = "0x25E1830", VA = "0x1825E2830")]
		internal JobHandle ICJKILDGEKK(in EFCGLBFOCAL JEJGBICCBLN, in NCMOIMHGIPL IACKKMEKEAC, NativeMultiHashMap<Entity, OACDCJOBFGL> JCEPEPFIOLM, JobHandle FPLJAFOBFPB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x22C6470", Offset = "0x22C5470", VA = "0x1822C6470")]
		private JobHandle ACKCDFAFLIG(JobHandle JBIAPGFJHFB, JobHandle ELCICLFIJJK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x22C6470", Offset = "0x22C5470", VA = "0x1822C6470")]
		private JobHandle ACKCDFAFLIG(JobHandle JBIAPGFJHFB, JobHandle ELCICLFIJJK, JobHandle KIDGKBFNECH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class DEPMJKCBLDJ : HEODJEKIBCE, JLLBLNFOFFK
{
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery JDAACHFBBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private EntityQuery BKEJNNBICJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private GDJOKFELAEK INCCOGEEFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2457690", Offset = "0x2456690", VA = "0x182457690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2457630", Offset = "0x2456630", VA = "0x182457630", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2457430", Offset = "0x2456430", VA = "0x182457430")]
	private static void NIPPKBCBLKB(EntityQuery FHCACFJLPLH, EntityManager EFLHIHFKEDM, GDJOKFELAEK IJIAKELOEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x24572D0", Offset = "0x24562D0", VA = "0x1824572D0")]
	private static void LIBDHJOBJPM(BDIHMGAJDCO KIKNDHMFIHG, GDJOKFELAEK IJIAKELOEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x24576E0", Offset = "0x24566E0", VA = "0x1824576E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2457880", Offset = "0x2456880", VA = "0x182457880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x24577B0", Offset = "0x24567B0", VA = "0x1824577B0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2457890", Offset = "0x2456890", VA = "0x182457890")]
	private void PKNMOEKEGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public DEPMJKCBLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct BDIHMGAJDCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public MEFBGEPNGJL KNFBLBBIBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private global::LBFIEJNKNNI<PJDAPMMBGBM> NIHLPAOGOIP;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public PJDAPMMBGBM HINFJBKLGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x244E2C0", Offset = "0x244D2C0", VA = "0x18244E2C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x244E300", Offset = "0x244D300", VA = "0x18244E300")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class AFNGOAODDAF<UserTag, StateTag> : HEODJEKIBCE, JLLBLNFOFFK where UserTag : struct, IComponentData where StateTag : struct, ISystemStateComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery HBJAGCJHPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery AEMOEEKMODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery IAFDGFNBKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private EntityQuery BICGNBDLIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery ENGKFHDHMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private EntityQuery NIBNKBBGKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private EntityQuery DBDJIADNMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected JCEIMFBPPLF GFBGKAODCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x30A6570", Offset = "0x30A5570", VA = "0x1830A6570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected virtual bool AMHIMMHAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	protected virtual bool PLGFEIMIHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x30A67C0", Offset = "0x30A57C0", VA = "0x1830A67C0", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x30A68C0", Offset = "0x30A58C0", VA = "0x1830A68C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x30A6BE0", Offset = "0x30A5BE0", VA = "0x1830A6BE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected abstract void PGMMJKGDGEP(in NOAFJMJDOFI HDKELLGGHEC);

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	protected abstract void NNNEBFMBBAI(in NOAFJMJDOFI HDKELLGGHEC);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	protected abstract void PGMMJKGDGEP(in MEFBGEPNGJL KNFBLBBIBPG);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	protected abstract void LKHFOFNIKOO();

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	protected abstract void OKMBBAAHBLE();

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	protected abstract void LMDDODCFKBJ();

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x25F5E90", Offset = "0x25F4E90", VA = "0x1825F5E90")]
	private void FGPLLLOHHGI(Entity CLCJGDKEGGN, in BDIHMGAJDCO KIKNDHMFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x30A65C0", Offset = "0x30A55C0", VA = "0x1830A65C0")]
	private void DKLKAPEPDMI(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x30A6820", Offset = "0x30A5820", VA = "0x1830A6820")]
	private void OMMGHJCOHAH(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x25F71C0", Offset = "0x25F61C0", VA = "0x1825F71C0")]
	protected AFNGOAODDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x25F6000", Offset = "0x25F5000", VA = "0x1825F6000", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class BHLCFNKENLD : global::FLBHNEFLPJG<OKHJCMKPFGH>
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	protected override HHINIDCODHG EFFMADGGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x9C3CE0", Offset = "0x9C2CE0", VA = "0x1809C3CE0", Slot = "23")]
		get
		{
			return default(HHINIDCODHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	protected override bool PLGFEIMIHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2452650", Offset = "0x2451650", VA = "0x182452650")]
	public BHLCFNKENLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2452610", Offset = "0x2451610", VA = "0x182452610", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class APKJLCEKJEA : global::FLBHNEFLPJG<OKHJCMKPFGH>
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	protected override HHINIDCODHG EFFMADGGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x612E80", Offset = "0x611E80", VA = "0x180612E80", Slot = "23")]
		get
		{
			return default(HHINIDCODHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	protected override bool AMHIMMHAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x244DCE0", Offset = "0x244CCE0", VA = "0x18244DCE0")]
	public APKJLCEKJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x244DCA0", Offset = "0x244CCA0", VA = "0x18244DCA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct GJPAGEGKCBF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class FLBHNEFLPJG<Tag> : global::AFNGOAODDAF<Tag, GJPAGEGKCBF> where Tag : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	protected abstract HHINIDCODHG EFFMADGGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x448B040", Offset = "0x448A040", VA = "0x18448B040", Slot = "17")]
	protected override void PGMMJKGDGEP(in NOAFJMJDOFI HDKELLGGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x448AE40", Offset = "0x4489E40", VA = "0x18448AE40", Slot = "18")]
	protected override void NNNEBFMBBAI(in NOAFJMJDOFI HDKELLGGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x448AF30", Offset = "0x4489F30", VA = "0x18448AF30", Slot = "19")]
	protected override void PGMMJKGDGEP(in MEFBGEPNGJL KNFBLBBIBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x448ACE0", Offset = "0x4489CE0", VA = "0x18448ACE0", Slot = "20")]
	protected override void LKHFOFNIKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x448AEC0", Offset = "0x4489EC0", VA = "0x18448AEC0", Slot = "21")]
	protected override void OKMBBAAHBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x448AD50", Offset = "0x4489D50", VA = "0x18448AD50", Slot = "22")]
	protected override void LMDDODCFKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x200DC00", Offset = "0x200CC00", VA = "0x18200DC00")]
	protected FLBHNEFLPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4AA0", Offset = "0x1CC3AA0", VA = "0x181CC4AA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class JNGAABHFLAC : global::PDKCMCHLJEB<DHPBIDOIKPE>
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	protected override BPJNBOAKIPC EFFMADGGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4D0", Offset = "0x6C94D0", VA = "0x1806CA4D0", Slot = "23")]
		get
		{
			return default(BPJNBOAKIPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected override bool PLGFEIMIHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x22E7F70", Offset = "0x22E6F70", VA = "0x1822E7F70")]
	public JNGAABHFLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x22E7F30", Offset = "0x22E6F30", VA = "0x1822E7F30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public struct MLPGAOEJAAK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class PDKCMCHLJEB<Tag> : global::AFNGOAODDAF<Tag, MLPGAOEJAAK> where Tag : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected abstract BPJNBOAKIPC EFFMADGGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x37F3290", Offset = "0x37F2290", VA = "0x1837F3290", Slot = "19")]
	protected override void PGMMJKGDGEP(in MEFBGEPNGJL KNFBLBBIBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x37F31A0", Offset = "0x37F21A0", VA = "0x1837F31A0", Slot = "18")]
	protected override void NNNEBFMBBAI(in NOAFJMJDOFI HDKELLGGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x37F33A0", Offset = "0x37F23A0", VA = "0x1837F33A0", Slot = "17")]
	protected override void PGMMJKGDGEP(in NOAFJMJDOFI HDKELLGGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x37F3040", Offset = "0x37F2040", VA = "0x1837F3040", Slot = "20")]
	protected override void LKHFOFNIKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x37F3220", Offset = "0x37F2220", VA = "0x1837F3220", Slot = "21")]
	protected override void OKMBBAAHBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x37F30B0", Offset = "0x37F20B0", VA = "0x1837F30B0", Slot = "22")]
	protected override void LMDDODCFKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x200DC00", Offset = "0x200CC00", VA = "0x18200DC00")]
	protected PDKCMCHLJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4AA0", Offset = "0x1CC3AA0", VA = "0x181CC4AA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class JHILICDLEIA : global::PDKCMCHLJEB<DHPBIDOIKPE>
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	protected override BPJNBOAKIPC EFFMADGGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x6CA030", Offset = "0x6C9030", VA = "0x1806CA030", Slot = "23")]
		get
		{
			return default(BPJNBOAKIPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected override bool AMHIMMHAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE0", Offset = "0x5E4FE0", VA = "0x1805E5FE0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x22DC790", Offset = "0x22DB790", VA = "0x1822DC790")]
	public JHILICDLEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x22DC750", Offset = "0x22DB750", VA = "0x1822DC750", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class KCGDIJLKEDD : HEODJEKIBCE, JLLBLNFOFFK
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct IOAHECADGHB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		private struct NBOMIGLAHAP
		{
			[Cpp2IlInjected.Token(Token = "0x20000EC")]
			public struct OPFHHIPPNMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002FE")]
				public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002FF")]
				public LambdaParameterValueProvider_IComponentData<BDIHMGAJDCO>.Runtime PPGECEMAIKF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<BDIHMGAJDCO> POKHOLCOIOL;

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x22F11D0", Offset = "0x22F01D0", VA = "0x1822F11D0")]
			public void AIMCPLKOAEL(KCGDIJLKEDD MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x22F1230", Offset = "0x22F0230", VA = "0x1822F1230")]
			public OPFHHIPPNMB CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(OPFHHIPPNMB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public KCGDIJLKEDD OIGJAFMLHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private NBOMIGLAHAP OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NBOMIGLAHAP.OPFHHIPPNMB* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x22E5970", Offset = "0x22E4970", VA = "0x1822E5970")]
		public void ENEEDINPEMO(Entity CLCJGDKEGGN, [In] ref BDIHMGAJDCO KIKNDHMFIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x22E5990", Offset = "0x22E4990", VA = "0x1822E5990", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x22E5A30", Offset = "0x22E4A30", VA = "0x1822E5A30")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, ref NBOMIGLAHAP.OPFHHIPPNMB HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x22E58F0", Offset = "0x22E48F0", VA = "0x1822E58F0")]
		public void AIMCPLKOAEL(KCGDIJLKEDD MNFLHJKJICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x22E5890", Offset = "0x22E4890", VA = "0x1822E5890")]
		public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private EntityHierarchyChildren DGKOICOAPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private EntityQuery GGLDHOHNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private ProfilerMarker JIOEAJOEKKF;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private JCEIMFBPPLF GFBGKAODCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x22E8200", Offset = "0x22E7200", VA = "0x1822E8200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x22E8670", Offset = "0x22E7670", VA = "0x1822E8670", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x22E8940", Offset = "0x22E7940", VA = "0x1822E8940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x22E8660", Offset = "0x22E7660", VA = "0x1822E8660")]
	private void IIAEJOMOJEO(Entity CLCJGDKEGGN, in BDIHMGAJDCO KIKNDHMFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x22E83E0", Offset = "0x22E73E0", VA = "0x1822E83E0")]
	private void FGPLLLOHHGI(Entity CLCJGDKEGGN, in BDIHMGAJDCO KIKNDHMFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x22E8250", Offset = "0x22E7250", VA = "0x1822E8250")]
	private void BJDCHCDDIDN(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x22E86F0", Offset = "0x22E76F0", VA = "0x1822E86F0")]
	private void OMMGHJCOHAH(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public KCGDIJLKEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x22E8660", Offset = "0x22E7660", VA = "0x1822E8660")]
	[CompilerGenerated]
	private void OFFMKNAGGDL(Entity CLCJGDKEGGN, in BDIHMGAJDCO KIKNDHMFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x22E8770", Offset = "0x22E7770", VA = "0x1822E8770", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x22E8500", Offset = "0x22E7500", VA = "0x1822E8500")]
	public static EntityQuery HEILFODPENB(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public abstract class BFCGNIDPPED : IBKFNGKFFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	protected readonly KOHKPOMNCDA DOMFNFDEEKP;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected AANBNAJPLKI JPJOKGKJCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x244FD80", Offset = "0x244ED80", VA = "0x18244FD80")]
		get
		{
			return default(AANBNAJPLKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	protected Entity HFANCMABCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2451960", Offset = "0x2450960", VA = "0x182451960")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	protected NPGLNNOGMJJ CNENPJIDLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected LPPOJAOPNMP FALFHKCLHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x24503E0", Offset = "0x244F3E0", VA = "0x1824503E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	protected IHJGKBGCMLD DMOJLFMKCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2450520", Offset = "0x244F520", VA = "0x182450520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	protected INJCNOHDGPO JPDGOBOCCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x24513F0", Offset = "0x24503F0", VA = "0x1824513F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private OHJKLNPKNGO IKIPDODJIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x244FDF0", Offset = "0x244EDF0", VA = "0x18244FDF0", Slot = "12")]
		get
		{
			return default(OHJKLNPKNGO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2451A70", Offset = "0x2450A70", VA = "0x182451A70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private GameObject AAENDOHOECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2450390", Offset = "0x244F390", VA = "0x182450390", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private Matrix4x4 PDONICLLHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2451740", Offset = "0x2450740", VA = "0x182451740", Slot = "14")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private Vector3 HODGHHFCCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x2450B60", Offset = "0x244FB60", VA = "0x182450B60", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2450430", Offset = "0x244F430", VA = "0x182450430", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private Quaternion BGNDNJKMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x2451650", Offset = "0x2450650", VA = "0x182451650", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x244FBA0", Offset = "0x244EBA0", VA = "0x18244FBA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private Vector3 NDAFLAOJBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x24502A0", Offset = "0x244F2A0", VA = "0x1824502A0", Slot = "16")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x244FC90", Offset = "0x244EC90", VA = "0x18244FC90", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private Matrix4x4 HHECKANDOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x24505A0", Offset = "0x244F5A0", VA = "0x1824505A0", Slot = "15")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private Vector3 OODEBKBGLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2451980", Offset = "0x2450980", VA = "0x182451980", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2451560", Offset = "0x2450560", VA = "0x182451560", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private Quaternion CDGFKIDEKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2450C50", Offset = "0x244FC50", VA = "0x182450C50", Slot = "10")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2451470", Offset = "0x2450470", VA = "0x182451470", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private Vector3 IAAONAGKCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2450D40", Offset = "0x244FD40", VA = "0x182450D40", Slot = "18")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private Vector3 NEANGNODNJH
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x24500E0", Offset = "0x244F0E0", VA = "0x1824500E0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x24506E0", Offset = "0x244F6E0", VA = "0x1824506E0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private Vector3 NEKBLFIHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2451230", Offset = "0x2450230", VA = "0x182451230", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2450FF0", Offset = "0x244FFF0", VA = "0x182450FF0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private Vector3 BHHFNKFOGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2450E30", Offset = "0x244FE30", VA = "0x182450E30", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x2450920", Offset = "0x244F920", VA = "0x182450920", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D90", Offset = "0x6F7D90", VA = "0x1806F8D90")]
	protected BFCGNIDPPED(KOHKPOMNCDA DNAFLODIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x244FA70", Offset = "0x244EA70", VA = "0x18244FA70")]
	protected OHJKLNPKNGO AMDMBCDOPIK()
	{
		return default(OHJKLNPKNGO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x244FDC0", Offset = "0x244EDC0", VA = "0x18244FDC0")]
	public static OHJKLNPKNGO BNLFJABIBKP(BFCGNIDPPED JBJIMKKMMPN)
	{
		return default(OHJKLNPKNGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class LOBCILAOJME : BFCGNIDPPED, PJDAPMMBGBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private const string DGJODKOKMGE = "RenderContainerWrapper";

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public OHJKLNPKNGO FKKKBEMGBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x244FDC0", Offset = "0x244EDC0", VA = "0x18244FDC0", Slot = "26")]
		get
		{
			return default(OHJKLNPKNGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FJANIAGBDEE EGIKMEJLMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x6B0390", Offset = "0x6AF390", VA = "0x1806B0390", Slot = "27")]
		get
		{
			return default(FJANIAGBDEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x25E5740", Offset = "0x25E4740", VA = "0x1825E5740")]
	public LOBCILAOJME(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x25E56D0", Offset = "0x25E46D0", VA = "0x1825E56D0", Slot = "28")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class IPJBBLCKAMO : CAFEAMKECCK, BGLGILFDBGJ, FIPHIHDJACL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct KAFLJGCCAPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public int pointCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public bool preventInvertedCreation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public Vector3 prevTangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public SplinePointData currPointData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public SplinePointData nextPointData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public IPJBBLCKAMO <>4__this;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private NativeList<EIJPBBOPKEB> HILEHNIHBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private bool NKEPHGEFBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private bool FHGEDDLGLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private float CPAJFCDCEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private int GICGAIGBALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private bool LIIPNKDCICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private int IDBGBJKEDJD;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private HAKGILMIHPD DPPKFKFHHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x22E5C50", Offset = "0x22E4C50", VA = "0x1822E5C50")]
		get
		{
			return default(HAKGILMIHPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	private bool GABABMFKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x610820", Offset = "0x60F820", VA = "0x180610820", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private bool DFIBPKKHKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x610810", Offset = "0x60F810", VA = "0x180610810", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private float PPKNMHOKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x15E7660", Offset = "0x15E6660", VA = "0x1815E7660", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private int JLNAMOAPKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x6108D0", Offset = "0x60F8D0", VA = "0x1806108D0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private bool BDDGABECGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A090", Offset = "0x1C19090", VA = "0x181C1A090", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private int FKEDJFFMNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x680620", Offset = "0x67F620", VA = "0x180680620", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x22E6880", Offset = "0x22E5880", VA = "0x1822E6880")]
	public IPJBBLCKAMO(KOHKPOMNCDA DNAFLODIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x22E64D0", Offset = "0x22E54D0", VA = "0x1822E64D0", Slot = "33")]
	public override void LNGAPHKLFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x22E6130", Offset = "0x22E5130", VA = "0x1822E6130", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x22E6190", Offset = "0x22E5190", VA = "0x1822E6190", Slot = "40")]
	private NativeArray<EIJPBBOPKEB> KKCEHPIEGLK()
	{
		return default(NativeArray<EIJPBBOPKEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x22E6610", Offset = "0x22E5610", VA = "0x1822E6610")]
	private static Vector3 NOHGMODDFJL(int COLBFKBEOEI, int IGPNEJKPGGL, bool DOCKEHCHAKB, in Vector3 INEBIJPHHFH, in SplinePointData LFNPMLGOHIL, in SplinePointData FJPEJNHGOKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x22E5E40", Offset = "0x22E4E40", VA = "0x1822E5E40")]
	private static Quaternion DCJCMLLCIHB(int COLBFKBEOEI, int IGPNEJKPGGL, bool DOCKEHCHAKB, ref Vector3 INEBIJPHHFH, in SplinePointData LFNPMLGOHIL, in SplinePointData FJPEJNHGOKC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x22E5CE0", Offset = "0x22E4CE0", VA = "0x1822E5CE0")]
	[CompilerGenerated]
	private void CPKABDCNIAA(int COLBFKBEOEI, ref KAFLJGCCAPJ P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class ENJNOLMKGPI : CAFEAMKECCK, HFONKDLLEBD, FIPHIHDJACL
{
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private static readonly Dictionary<HHBAPNOMDDB, JBDPINCBEOM> HMJDHHAHAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private JBDPINCBEOM PEPADDNLHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool GICLCFNELEH;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private NPHCIOCCNKC PJIHNBLFMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x245AA20", Offset = "0x2459A20", VA = "0x18245AA20")]
		get
		{
			return default(NPHCIOCCNKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private JBDPINCBEOM PLKIKILEOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x740CD0", Offset = "0x73FCD0", VA = "0x180740CD0", Slot = "34")]
		get
		{
			return default(JBDPINCBEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private bool PNPEDELDPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0130", Offset = "0x7AF130", VA = "0x1807B0130", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x2453FE0", Offset = "0x2452FE0", VA = "0x182453FE0")]
	public ENJNOLMKGPI(KOHKPOMNCDA DNAFLODIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x245A7A0", Offset = "0x24597A0", VA = "0x18245A7A0", Slot = "33")]
	public override void LNGAPHKLFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public abstract class CAFEAMKECCK : BFCGNIDPPED, FIPHIHDJACL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private float MFEIFOGMNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private Vector3 NHLHIGJELOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private LLEFMMLFJCB FOLDJHLDNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private IIMLDMJEFLJ GOGIHNMALAL;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	protected EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x2453F80", Offset = "0x2452F80", VA = "0x182453F80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected GDEFGFJPJEE NGCBAEGEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x2453D90", Offset = "0x2452D90", VA = "0x182453D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	protected PHHIOCMBCOD NOINFEGLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x2453D30", Offset = "0x2452D30", VA = "0x182453D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	protected ShapeConfigData EIDOCDADKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x2453E10", Offset = "0x2452E10", VA = "0x182453E10")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected HKLMJGHLKLG HBDDHCMAEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x2453C60", Offset = "0x2452C60", VA = "0x182453C60")]
		get
		{
			return default(HKLMJGHLKLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private OHJKLNPKNGO NCGLGABBDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x244FDC0", Offset = "0x244EDC0", VA = "0x18244FDC0", Slot = "26")]
		get
		{
			return default(OHJKLNPKNGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private float GGOJEGHNACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xE5D8C0", Offset = "0xE5C8C0", VA = "0x180E5D8C0", Slot = "27")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Vector3 KGFDFCELFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xF6DB70", Offset = "0xF6CB70", VA = "0x180F6DB70", Slot = "28")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private LLEFMMLFJCB BKHPDEEDEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x6107E0", Offset = "0x60F7E0", VA = "0x1806107E0", Slot = "29")]
		get
		{
			return default(LLEFMMLFJCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private IIMLDMJEFLJ LJHHAHABLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x6360F0", Offset = "0x6350F0", VA = "0x1806360F0", Slot = "30")]
		get
		{
			return default(IIMLDMJEFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2453FE0", Offset = "0x2452FE0", VA = "0x182453FE0")]
	protected CAFEAMKECCK(KOHKPOMNCDA DNAFLODIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "32")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x2453EB0", Offset = "0x2452EB0", VA = "0x182453EB0", Slot = "33")]
	public virtual void LNGAPHKLFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public class LBFPOHBOKCM : HEODJEKIBCE, JLLBLNFOFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private EntityQuery GGAADOFIBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private EntityQuery FJKEHMOHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private EntityQuery LAFDPPAFCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private GDJOKFELAEK INCCOGEEFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x22EB770", Offset = "0x22EA770", VA = "0x1822EB770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x22EB6F0", Offset = "0x22EA6F0", VA = "0x1822EB6F0", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x22EB7C0", Offset = "0x22EA7C0", VA = "0x1822EB7C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x22EBA40", Offset = "0x22EAA40", VA = "0x1822EBA40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x22EAFD0", Offset = "0x22E9FD0", VA = "0x1822EAFD0")]
	private void AJAIAKDJBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x22EB4C0", Offset = "0x22EA4C0", VA = "0x1822EB4C0")]
	private void NGDGMFPHLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x22EB200", Offset = "0x22EA200", VA = "0x1822EB200")]
	private void IBIJHKGKLAA(EntityQuery FHCACFJLPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x22EB270", Offset = "0x22EA270", VA = "0x1822EB270")]
	private MEFBGEPNGJL KDBBPAACGKL(Entity CLCJGDKEGGN)
	{
		return default(MEFBGEPNGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public LBFPOHBOKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public struct JDALGFCHBAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public MEFBGEPNGJL KNFBLBBIBPG;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class JCACEEJCKLD : global::GEABODDDOAB<PrimitiveShapeData, LHFOFNJELCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private EntityQuery OJPIMFNKOAO;

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x22E69E0", Offset = "0x22E59E0", VA = "0x1822E69E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x22E6900", Offset = "0x22E5900", VA = "0x1822E6900", Slot = "15")]
	protected override void HAMBDGLDBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x22E6A90", Offset = "0x22E5A90", VA = "0x1822E6A90")]
	public JCACEEJCKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x22E69A0", Offset = "0x22E59A0", VA = "0x1822E69A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[AlwaysUpdateSystem]
public abstract class GEABODDDOAB<ShapeComponentData, ShapeRenderHandleStateData> : HEODJEKIBCE, JLLBLNFOFFK where ShapeComponentData : struct, IComponentData where ShapeRenderHandleStateData : struct, KICGBGAHIHF
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private struct INMELJMANBG : PCPHPFBIEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[ReadOnly]
		public ArchetypeChunkComponentType<JDALGFCHBAC> DDPLMLNAAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public ArchetypeChunkComponentType<ShapeRenderHandleStateData> FHKAKIOPNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[WriteOnly]
		public NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> MFFDBOECHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public GDJOKFELAEK IJIAKELOEFA;

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x4045C60", Offset = "0x4044C60", VA = "0x184045C60", Slot = "4")]
		public void CMCBIJDGDOF(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private struct NJIHKOLEKBN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		[ReadOnly]
		public ArchetypeChunkComponentType<ShapeRenderHandleStateData> NIOFCJJEIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> JJJGGGECNKP;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x4046320", Offset = "0x4045320", VA = "0x184046320", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private struct JJJPNEJLEJO : PCPHPFBIEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[ReadOnly]
		public ArchetypeChunkComponentType<ShapeRenderHandleStateData> AKDFKNHIOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[WriteOnly]
		public NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> JFCNCDDPPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public GDJOKFELAEK IJIAKELOEFA;

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x40461B0", Offset = "0x40451B0", VA = "0x1840461B0", Slot = "4")]
		public void CMCBIJDGDOF(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private static readonly ProfilerMarker OLBENLCNPCG;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private static readonly ProfilerMarker LFEDOMCBIND;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private static readonly ProfilerMarker KCLEPKIANAA;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private static readonly ProfilerMarker PGLCBENHJOC;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private static readonly ProfilerMarker CJFGGCBGLKI;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private static readonly ProfilerMarker LDMFINEANHJ;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private static readonly ProfilerMarker NJOCDGDMING;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private static readonly ProfilerMarker IAOICJMHMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private EntityQuery PLLDPJMALFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private EntityQuery EBNPNNGPBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private EntityQuery OHMCFCMKDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private EntityQuery JOEFCADNLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private EntityQuery PHHAPGCPCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private EntityQuery PEEMPCJBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private EntityQuery HLPGBGGHLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private EntityQuery EENNMGFJPEO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private const int NCCPJFICDMM = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private int KGGBFODFIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private HashSet<MEFBGEPNGJL> LHMMLJGAACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private Queue<MEFBGEPNGJL> GOCDKEJINNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	protected PBNGMJECOGA BILODKHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	protected NPGLNNOGMJJ IPPOOBMDIMG;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	protected GDJOKFELAEK INCCOGEEFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x403FB00", Offset = "0x403EB00", VA = "0x18403FB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x403F810", Offset = "0x403E810", VA = "0x18403F810", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x403FB50", Offset = "0x403EB50", VA = "0x18403FB50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x40404B0", Offset = "0x403F4B0", VA = "0x1840404B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x4040470", Offset = "0x403F470", VA = "0x184040470", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x403D3F0", Offset = "0x403C3F0", VA = "0x18403D3F0")]
	private void FFBJMICNLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x403C3D0", Offset = "0x403B3D0", VA = "0x18403C3D0")]
	private NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> CCOODFKHPEF(EntityQuery FHCACFJLPLH)
	{
		return default(NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x403E0C0", Offset = "0x403D0C0", VA = "0x18403E0C0", Slot = "15")]
	protected virtual void HAMBDGLDBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x403E720", Offset = "0x403D720", VA = "0x18403E720")]
	private void HKMHDLBGKED(NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> GJINHMJKHEJ, NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> FGNABBNIEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x403EEF0", Offset = "0x403DEF0", VA = "0x18403EEF0")]
	private void MCNMIFONICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x403F9A0", Offset = "0x403E9A0", VA = "0x18403F9A0")]
	protected (NativeArray<ShapeRenderHandleStateData>, JobHandle) OGBFPOGONNF(EntityQuery FHCACFJLPLH)
	{
		return default((NativeArray<ShapeRenderHandleStateData>, JobHandle));
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x403DCE0", Offset = "0x403CCE0", VA = "0x18403DCE0")]
	protected void GNAFMMDJMAA((NativeArray<ShapeRenderHandleStateData> shapeHandles, JobHandle job) JEJGBICCBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x403F3D0", Offset = "0x403E3D0", VA = "0x18403F3D0")]
	private NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> MPEDFLDPGMF(EntityQuery FHCACFJLPLH)
	{
		return default(NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x403ED70", Offset = "0x403DD70", VA = "0x18403ED70")]
	private NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> IGBFEMIHIOA(EntityQuery FHCACFJLPLH, out JobHandle IHEGNLMLNLI)
	{
		return default(NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x403C8A0", Offset = "0x403B8A0", VA = "0x18403C8A0")]
	private void CLMEBCDCMKP(NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> DBDJIADNMHB, JobHandle IHEGNLMLNLI, ProfilerMarker KJDDCNNNJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x403CB80", Offset = "0x403BB80", VA = "0x18403CB80")]
	private NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG> EHEBLEBBCEI(EntityQuery FHCACFJLPLH)
	{
		return default(NativeHashMap<MEFBGEPNGJL, OBILJNMGGGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x4040BA0", Offset = "0x403FBA0", VA = "0x184040BA0")]
	protected GEABODDDOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x25F6000", Offset = "0x25F5000", VA = "0x1825F6000", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface KICGBGAHIHF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	MEFBGEPNGJL ECEIAGGABOI
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	NOAFJMJDOFI BEIICALACGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNGAPHKLFPJ();

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEDMOJHLJAK(KOHKPOMNCDA FCJPDBMFAED);

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBOGAHLNIAE();

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFFJEEGEKND(MEFBGEPNGJL KNFBLBBIBPG, GDJOKFELAEK IJIAKELOEFA);

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NLIABFBEEDH(GDJOKFELAEK IJIAKELOEFA);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct LHFOFNJELCD : KICGBGAHIHF, ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private global::LBFIEJNKNNI<ENJNOLMKGPI> EDHGOOGGCOE;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public MEFBGEPNGJL ECEIAGGABOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x22F10A0", Offset = "0x22F00A0", VA = "0x1822F10A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MEFBGEPNGJL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x22F0E40", Offset = "0x22EFE40", VA = "0x1822F0E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public NOAFJMJDOFI BEIICALACGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x22F0E30", Offset = "0x22EFE30", VA = "0x1822F0E30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NOAFJMJDOFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x22F1030", Offset = "0x22F0030", VA = "0x1822F1030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x22F0F40", Offset = "0x22EFF40", VA = "0x1822F0F40", Slot = "7")]
	public void HEDMOJHLJAK(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x22F0FC0", Offset = "0x22EFFC0", VA = "0x1822F0FC0", Slot = "8")]
	public void KBOGAHLNIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x22F1040", Offset = "0x22F0040", VA = "0x1822F1040", Slot = "6")]
	public void LNGAPHKLFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x22F0E50", Offset = "0x22EFE50", VA = "0x1822F0E50", Slot = "9")]
	public void EFFJEEGEKND(MEFBGEPNGJL KNFBLBBIBPG, GDJOKFELAEK IJIAKELOEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x22F10B0", Offset = "0x22F00B0", VA = "0x1822F10B0", Slot = "10")]
	public void NLIABFBEEDH(GDJOKFELAEK IJIAKELOEFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public struct CFEDGFOIEMN : KICGBGAHIHF, ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private global::LBFIEJNKNNI<IPJBBLCKAMO> IIALJCHDFMP;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public MEFBGEPNGJL ECEIAGGABOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x22F10A0", Offset = "0x22F00A0", VA = "0x1822F10A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MEFBGEPNGJL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x22F0E40", Offset = "0x22EFE40", VA = "0x1822F0E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public NOAFJMJDOFI BEIICALACGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x22F0E30", Offset = "0x22EFE30", VA = "0x1822F0E30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NOAFJMJDOFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x22F1030", Offset = "0x22F0030", VA = "0x1822F1030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x24542E0", Offset = "0x24532E0", VA = "0x1824542E0", Slot = "7")]
	public void HEDMOJHLJAK(KOHKPOMNCDA FCJPDBMFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x2454360", Offset = "0x2453360", VA = "0x182454360", Slot = "8")]
	public void KBOGAHLNIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x24543D0", Offset = "0x24533D0", VA = "0x1824543D0", Slot = "6")]
	public void LNGAPHKLFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x24541F0", Offset = "0x24531F0", VA = "0x1824541F0", Slot = "9")]
	public void EFFJEEGEKND(MEFBGEPNGJL KNFBLBBIBPG, GDJOKFELAEK IJIAKELOEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x2454430", Offset = "0x2453430", VA = "0x182454430", Slot = "10")]
	public void NLIABFBEEDH(GDJOKFELAEK IJIAKELOEFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class OHFDJEHNBBG : global::GEABODDDOAB<SplineData, CFEDGFOIEMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private EntityQuery CMPBMCKPMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private EntityQuery NOKKDLPNFIB;

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x25ECAC0", Offset = "0x25EBAC0", VA = "0x1825ECAC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x25EC980", Offset = "0x25EB980", VA = "0x1825EC980", Slot = "15")]
	protected override void HAMBDGLDBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x25ECBD0", Offset = "0x25EBBD0", VA = "0x1825ECBD0")]
	public OHFDJEHNBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x25ECA80", Offset = "0x25EBA80", VA = "0x1825ECA80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public class DDFGJHCADGD : OHAOLCPCNLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct PKCFNIIPBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public PKCFNIIPBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct JBDFCIEJELM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private struct KLPCBHDAKBB
		{
			[Cpp2IlInjected.Token(Token = "0x2000102")]
			[NoAlias]
			public struct BMDIICCCIIP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000350")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime JNGHDIABPAP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> OGJLGKOCABA;

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x245FCB0", Offset = "0x245ECB0", VA = "0x18245FCB0")]
			public void AIMCPLKOAEL(DDFGJHCADGD MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x245FD00", Offset = "0x245ED00", VA = "0x18245FD00")]
			public BMDIICCCIIP CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(BMDIICCCIIP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public NativeArray<int> DNAEDFOPGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private KLPCBHDAKBB OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KLPCBHDAKBB.BMDIICCCIIP* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MELNLEGNIJC;

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x245FAA0", Offset = "0x245EAA0", VA = "0x18245FAA0")]
		internal void ENEEDINPEMO(ref AuthoredLocalPoseData PPPDBPLCNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x22CC6F0", Offset = "0x22CB6F0", VA = "0x1822CC6F0", Slot = "5")]
		public void ReadFromDisplayClass(ref PKCFNIIPBLF BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x22CC700", Offset = "0x22CB700", VA = "0x1822CC700", Slot = "6")]
		public void WriteToDisplayClass(ref PKCFNIIPBLF BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x245FBA0", Offset = "0x245EBA0", VA = "0x18245FBA0", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x245FC20", Offset = "0x245EC20", VA = "0x18245FC20")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref KLPCBHDAKBB.BMDIICCCIIP HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x245FA20", Offset = "0x245EA20", VA = "0x18245FA20")]
		public void AIMCPLKOAEL(DDFGJHCADGD MNFLHJKJICL, ref PKCFNIIPBLF BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x245F9C0", Offset = "0x245E9C0", VA = "0x18245F9C0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private EntityQuery GGLDHOHNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private ProfilerMarker JIOEAJOEKKF;

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x24570D0", Offset = "0x24560D0", VA = "0x1824570D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public DDFGJHCADGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x2456EF0", Offset = "0x2455EF0", VA = "0x182456EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x2456DC0", Offset = "0x2455DC0", VA = "0x182456DC0")]
	public static EntityQuery HEILFODPENB(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public class DCOFONOICPD : OHAOLCPCNLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct CJJJFHLEGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public CJJJFHLEGDL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct CKJNFAGAJCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public CJJJFHLEGDL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public CKJNFAGAJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LODLBKFCHMI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		private struct IPPOEJGIOLN
		{
			[Cpp2IlInjected.Token(Token = "0x2000108")]
			[NoAlias]
			public struct ABCOEIFGJCD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400035E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400035F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime BFMGCGLGODB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> AOIGMLHOAHE;

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x245F8E0", Offset = "0x245E8E0", VA = "0x18245F8E0")]
			public void AIMCPLKOAEL(DCOFONOICPD MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x245F940", Offset = "0x245E940", VA = "0x18245F940")]
			public ABCOEIFGJCD CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(ABCOEIFGJCD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public EntityManager EFLHIHFKEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public NativeList<Entity> JBOPECNIDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private IPPOEJGIOLN OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IPPOEJGIOLN.ABCOEIFGJCD* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MELNLEGNIJC;

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x245FEA0", Offset = "0x245EEA0", VA = "0x18245FEA0")]
		internal void ENEEDINPEMO(Entity CLCJGDKEGGN, SplinePointData EAKNLHDPPEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x2460090", Offset = "0x245F090", VA = "0x182460090", Slot = "5")]
		public void ReadFromDisplayClass(ref CKJNFAGAJCG BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x24600A0", Offset = "0x245F0A0", VA = "0x1824600A0", Slot = "6")]
		public void WriteToDisplayClass(ref CKJNFAGAJCG BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x245FF20", Offset = "0x245EF20", VA = "0x18245FF20", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x245FFC0", Offset = "0x245EFC0", VA = "0x18245FFC0")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref IPPOEJGIOLN.ABCOEIFGJCD HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x245FE10", Offset = "0x245EE10", VA = "0x18245FE10")]
		public void AIMCPLKOAEL(DCOFONOICPD MNFLHJKJICL, ref CKJNFAGAJCG BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x245FDB0", Offset = "0x245EDB0", VA = "0x18245FDB0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private EntityQuery GGLDHOHNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private ProfilerMarker JIOEAJOEKKF;

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x2456B20", Offset = "0x2455B20", VA = "0x182456B20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public DCOFONOICPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x2456940", Offset = "0x2455940", VA = "0x182456940", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x2456810", Offset = "0x2455810", VA = "0x182456810")]
	public static EntityQuery HEILFODPENB(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class HMDDDELJFLA : OHAOLCPCNLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery FHMBBANLMMA;

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x22DE8B0", Offset = "0x22DD8B0", VA = "0x1822DE8B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x22DE930", Offset = "0x22DD930", VA = "0x1822DE930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public HMDDDELJFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public class KHNJKIGBFPG : OHAOLCPCNLC, JLLBLNFOFFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct EAMOGBPOKFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public NativeHashMap<LEPNJELBIPF, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public EAMOGBPOKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CKIBPMLIGNE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		private struct HHHGCMNBCIM
		{
			[Cpp2IlInjected.Token(Token = "0x200010E")]
			public struct EKIKDNPGMDK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime DLJHHEBGAFA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CCFIAGNLMMD;

			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x22DE100", Offset = "0x22DD100", VA = "0x1822DE100")]
			public void AIMCPLKOAEL(KHNJKIGBFPG MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x22DE160", Offset = "0x22DD160", VA = "0x1822DE160")]
			public EKIKDNPGMDK CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(EKIKDNPGMDK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public NativeHashMap<LEPNJELBIPF, Entity> KINLBAPNNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private HHHGCMNBCIM OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HHHGCMNBCIM.EKIKDNPGMDK* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x22DB400", Offset = "0x22DA400", VA = "0x1822DB400")]
		internal void ENEEDINPEMO(Entity CLCJGDKEGGN, ObjectNetworkIdComponentData BPJIFLDBDMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x22CC6F0", Offset = "0x22CB6F0", VA = "0x1822CC6F0", Slot = "5")]
		public void ReadFromDisplayClass(ref EAMOGBPOKFE BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x22CC700", Offset = "0x22CB700", VA = "0x1822CC700", Slot = "6")]
		public void WriteToDisplayClass(ref EAMOGBPOKFE BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x22DB480", Offset = "0x22DA480", VA = "0x1822DB480", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x22DB520", Offset = "0x22DA520", VA = "0x1822DB520")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, ref HHHGCMNBCIM.EKIKDNPGMDK HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x22DB370", Offset = "0x22DA370", VA = "0x1822DB370")]
		public void AIMCPLKOAEL(KHNJKIGBFPG MNFLHJKJICL, ref EAMOGBPOKFE BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x22DB310", Offset = "0x22DA310", VA = "0x1822DB310")]
		public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private ObjectNetworkToLocalMapService KMJAKBJOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private EntityQuery GGLDHOHNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private ProfilerMarker JIOEAJOEKKF;

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x22E9AE0", Offset = "0x22E8AE0", VA = "0x1822E9AE0", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x22E9CF0", Offset = "0x22E8CF0", VA = "0x1822E9CF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public KHNJKIGBFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x22E9B40", Offset = "0x22E8B40", VA = "0x1822E9B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x22E99B0", Offset = "0x22E89B0", VA = "0x1822E99B0")]
	public static EntityQuery HEILFODPENB(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[DOKDCAPODCB(PBFEFLGCHAA.Embodiment)]
	public class PostLoadInitializeEmbodiment : HEODJEKIBCE, JLLBLNFOFFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private struct AFPNBOMLAFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public NativeHashMap<Entity, LEPNJELBIPF> networkIds;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			public AFPNBOMLAFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
			internal void <AppendRoots>b__0(Entity entity, ObjectNetworkIdComponentData component, int entityInQueryIndex)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private struct OCMOMFNBLIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, LEPNJELBIPF> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public ComponentDataFromEntity<ParentData> parentsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdByEntity;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
			public OCMOMFNBLIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
			internal void <AppendDescendants>b__0(Entity entity, ObjectNetworkIdComponentData component, int entityInQueryIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct HMIPNDLNJIG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000113")]
			private struct EOCFOJEFCHI
			{
				[Cpp2IlInjected.Token(Token = "0x2000114")]
				[NoAlias]
				public struct GBMJGCLOMDC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000382")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000383")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HPGMAMBDPHC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000384")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime AKMILDHALJN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> EFGLFANMDHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex DIJCKMAOLNL;

				[Cpp2IlInjected.Token(Token = "0x60007C9")]
				[Cpp2IlInjected.Address(RVA = "0x22C9280", Offset = "0x22C8280", VA = "0x1822C9280")]
				public void AIMCPLKOAEL(PostLoadInitializeEmbodiment MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007CA")]
				[Cpp2IlInjected.Address(RVA = "0x22C92F0", Offset = "0x22C82F0", VA = "0x1822C92F0")]
				public GBMJGCLOMDC CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(GBMJGCLOMDC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public NativeHashMap<Entity, LEPNJELBIPF> MMECBELODKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private EOCFOJEFCHI OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe EOCFOJEFCHI.GBMJGCLOMDC* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MELNLEGNIJC;

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x22CC4E0", Offset = "0x22CB4E0", VA = "0x1822CC4E0")]
			internal void ENEEDINPEMO(Entity CLCJGDKEGGN, ObjectNetworkIdComponentData LIHCFPMBOOM, int IIHNJJHBKJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C3")]
			[Cpp2IlInjected.Address(RVA = "0x22CC6F0", Offset = "0x22CB6F0", VA = "0x1822CC6F0", Slot = "5")]
			public void ReadFromDisplayClass(ref AFPNBOMLAFE BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0x22CC700", Offset = "0x22CB700", VA = "0x1822CC700", Slot = "6")]
			public void WriteToDisplayClass(ref AFPNBOMLAFE BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0x22CC540", Offset = "0x22CB540", VA = "0x1822CC540", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0x22CC630", Offset = "0x22CB630", VA = "0x1822CC630")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref EOCFOJEFCHI.GBMJGCLOMDC HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x22CC440", Offset = "0x22CB440", VA = "0x1822CC440")]
			public void AIMCPLKOAEL(PostLoadInitializeEmbodiment MNFLHJKJICL, ref AFPNBOMLAFE BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x22CC3E0", Offset = "0x22CB3E0", VA = "0x1822CC3E0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct CIJPFLMGBKG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			private struct HMNIMGGLFMM
			{
				[Cpp2IlInjected.Token(Token = "0x2000117")]
				[NoAlias]
				public struct BHNJGIFGDOH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400038F")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000390")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HPGMAMBDPHC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000391")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime AKMILDHALJN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400038C")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400038D")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> EFGLFANMDHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400038E")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex DIJCKMAOLNL;

				[Cpp2IlInjected.Token(Token = "0x60007D3")]
				[Cpp2IlInjected.Address(RVA = "0x22CC710", Offset = "0x22CB710", VA = "0x1822CC710")]
				public void AIMCPLKOAEL(PostLoadInitializeEmbodiment MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007D4")]
				[Cpp2IlInjected.Address(RVA = "0x22CC780", Offset = "0x22CB780", VA = "0x1822CC780")]
				public BHNJGIFGDOH CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(BHNJGIFGDOH);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public NativeHashMap<Entity, LEPNJELBIPF> MMECBELODKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public ComponentDataFromEntity<ParentData> OFDOECFJMOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> AIHCFHHOOBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			private HMNIMGGLFMM OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HMNIMGGLFMM.BHNJGIFGDOH* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x400038A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

			[Cpp2IlInjected.Token(Token = "0x400038B")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MELNLEGNIJC;

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x22C5B30", Offset = "0x22C4B30", VA = "0x1822C5B30")]
			internal void ENEEDINPEMO(Entity CLCJGDKEGGN, ObjectNetworkIdComponentData LIHCFPMBOOM, int IIHNJJHBKJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0x22C5CF0", Offset = "0x22C4CF0", VA = "0x1822C5CF0")]
			internal void NJGAOGBCMKA(Entity CLCJGDKEGGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x22C5DB0", Offset = "0x22C4DB0", VA = "0x1822C5DB0", Slot = "5")]
			public void ReadFromDisplayClass(ref OCMOMFNBLIJ BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x22C5DE0", Offset = "0x22C4DE0", VA = "0x1822C5DE0", Slot = "6")]
			public void WriteToDisplayClass(ref OCMOMFNBLIJ BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x22C5B40", Offset = "0x22C4B40", VA = "0x1822C5B40", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x22C5C30", Offset = "0x22C4C30", VA = "0x1822C5C30")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref HMNIMGGLFMM.BHNJGIFGDOH HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x22C5A90", Offset = "0x22C4A90", VA = "0x1822C5A90")]
			public void AIMCPLKOAEL(PostLoadInitializeEmbodiment MNFLHJKJICL, ref OCMOMFNBLIJ BMLBBBFJKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x22C5A30", Offset = "0x22C4A30", VA = "0x1822C5A30")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery PJEOOKGFEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private PBNGMJECOGA BILODKHEIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private INJCNOHDGPO BDOHHFJFLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery FLPNBLLLEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private ProfilerMarker MHNDFDKGNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private EntityQuery OPGCMGABGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private ProfilerMarker DKDHAPOOJJJ;

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x22D41F0", Offset = "0x22D31F0", VA = "0x1822D41F0", Slot = "14")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x22D4870", Offset = "0x22D3870", VA = "0x1822D4870", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x22D48F0", Offset = "0x22D38F0", VA = "0x1822D48F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x22D3BB0", Offset = "0x22D2BB0", VA = "0x1822D3BB0")]
		private void FEMGCODBKNN(NativeArray<LEPNJELBIPF> MMECBELODKL, NativeArray<ADBCDDKGBBC> AHKLHIJLAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x22D3EF0", Offset = "0x22D2EF0", VA = "0x1822D3EF0")]
		private void IAENHMFEKAJ(NativeHashMap<Entity, LEPNJELBIPF> MMECBELODKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x22D4050", Offset = "0x22D3050", VA = "0x1822D4050")]
		private void IMADGGMLNAF(NativeHashMap<Entity, LEPNJELBIPF> MMECBELODKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x22D4410", Offset = "0x22D3410", VA = "0x1822D4410")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void OHEMPCMMHHP(NativeArray<LEPNJELBIPF> MMECBELODKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private static void BGIDCMDKHGF(NativeArray<LEPNJELBIPF> MMECBELODKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x22D4590", Offset = "0x22D3590", VA = "0x1822D4590", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x22D39F0", Offset = "0x22D29F0", VA = "0x1822D39F0")]
		public static EntityQuery DAKDEJPBKGH(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x22D4280", Offset = "0x22D3280", VA = "0x1822D4280")]
		public static EntityQuery ODJOODNJCLH(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public class MAMNLHEECIG : HEODJEKIBCE, JLLBLNFOFFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct JDMLAILAKCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public NativeHashMap<LEPNJELBIPF, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public JDMLAILAKCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct ODBGFJFIGJM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct BIHBFDGLPOO
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			[NoAlias]
			public struct EFHOCGMBCEJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400039E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400039F")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime AKMILDHALJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003A0")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime DLJHHEBGAFA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex DIJCKMAOLNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CCFIAGNLMMD;

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x25E0360", Offset = "0x25DF360", VA = "0x1825E0360")]
			public void AIMCPLKOAEL(MAMNLHEECIG MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x25E03D0", Offset = "0x25DF3D0", VA = "0x1825E03D0")]
			public EFHOCGMBCEJ CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(EFHOCGMBCEJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public NativeHashMap<LEPNJELBIPF, Entity> KINLBAPNNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private BIHBFDGLPOO OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BIHBFDGLPOO.EFHOCGMBCEJ* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MELNLEGNIJC;

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x25EBF60", Offset = "0x25EAF60", VA = "0x1825EBF60")]
		internal void ENEEDINPEMO(Entity CLCJGDKEGGN, int IIHNJJHBKJL, ref ObjectNetworkIdComponentData BPJIFLDBDMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x22CC6F0", Offset = "0x22CB6F0", VA = "0x1822CC6F0", Slot = "5")]
		public void ReadFromDisplayClass(ref JDMLAILAKCO BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x22CC700", Offset = "0x22CB700", VA = "0x1822CC700", Slot = "6")]
		public void WriteToDisplayClass(ref JDMLAILAKCO BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x25EBFF0", Offset = "0x25EAFF0", VA = "0x1825EBFF0", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x25EC0E0", Offset = "0x25EB0E0", VA = "0x1825EC0E0")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref BIHBFDGLPOO.EFHOCGMBCEJ HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x25EBEC0", Offset = "0x25EAEC0", VA = "0x1825EBEC0")]
		public void AIMCPLKOAEL(MAMNLHEECIG MNFLHJKJICL, ref JDMLAILAKCO BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x25EBE60", Offset = "0x25EAE60", VA = "0x1825EBE60")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private ObjectNetworkToLocalMapService KMJAKBJOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EntityQuery GGLDHOHNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private ProfilerMarker JIOEAJOEKKF;

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x25E5970", Offset = "0x25E4970", VA = "0x1825E5970", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x25E5BB0", Offset = "0x25E4BB0", VA = "0x1825E5BB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public MAMNLHEECIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x25E59D0", Offset = "0x25E49D0", VA = "0x1825E59D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x25E5840", Offset = "0x25E4840", VA = "0x1825E5840")]
	public static EntityQuery HEILFODPENB(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public class OKKGBHGJFIN : HEODJEKIBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private EntityQuery PJEOOKGFEGF;

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x25EDD30", Offset = "0x25ECD30", VA = "0x1825EDD30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x25EDDB0", Offset = "0x25ECDB0", VA = "0x1825EDDB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public OKKGBHGJFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public class IALODPIJKHN : HEODJEKIBCE, JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x22E0D70", Offset = "0x22DFD70", VA = "0x1822E0D70", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x22E0DD0", Offset = "0x22DFDD0", VA = "0x1822E0DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x22E06A0", Offset = "0x22DF6A0", VA = "0x1822E06A0")]
	private void BDKDMGAOJIH(NativeList<EntityArchetype> MDANCMHCAMG, NativeHashMap<int, OBILJNMGGGG> NCHIOGJGPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x22E0870", Offset = "0x22DF870", VA = "0x1822E0870")]
	private void DHHHLHKMIAE(NativeHashMap<int, OBILJNMGGGG> NCHIOGJGPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public IALODPIJKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x22E0560", Offset = "0x22DF560", VA = "0x1822E0560")]
	[CompilerGenerated]
	internal static Span<int> AFGNLMEEBJD(EntityArchetype CPEAGKNFJFE)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[DOKDCAPODCB(PBFEFLGCHAA.Serialization)]
	public class PreSerializeRemoveEntities : HEODJEKIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private static LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery EPFDNPFGPFB;

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x22D4C90", Offset = "0x22D3C90", VA = "0x1822D4C90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x22D4EB0", Offset = "0x22D3EB0", VA = "0x1822D4EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(MDLGMJDJCNF))]
public sealed class LMIOPHIAIOF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public LMIOPHIAIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(MDLGMJDJCNF))]
[UpdateAfter(typeof(LMIOPHIAIOF))]
public sealed class AEELKELEMIA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public AEELKELEMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[ExecuteAlways]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(OELKHDELMBL))]
public sealed class AGEHCLJLGIC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public AGEHCLJLGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[ExecuteAlways]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(PFLDJNCJBHH))]
public sealed class DGFJHCJLKOI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public DGFJHCJLKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
[ExecuteAlways]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(BKDGPEGPEMF))]
public sealed class APKLCCIMPNN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public APKLCCIMPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(DOPKKIMPBNG))]
public sealed class OLLCOBLPAEJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public OLLCOBLPAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public sealed class HFPPAPLEJNE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public HFPPAPLEJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(NDBIJHILLBK))]
public sealed class JMIFGHAHEAD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public JMIFGHAHEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public sealed class HIEOEELOHKH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public HIEOEELOHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public class BGJCOMLOHGP : global::PDCKMMONLNF<ParentData, BIFLGOGGJAG, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x2452510", Offset = "0x2451510", VA = "0x182452510", Slot = "14")]
	protected override EntityQueryDesc BEIGBHOMDEA(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x780EA0", Offset = "0x77FEA0", VA = "0x180780EA0", Slot = "15")]
	protected override EntityQueryDesc DBJNGMNBFFA(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x24524D0", Offset = "0x24514D0", VA = "0x1824524D0", Slot = "16")]
	protected override EntityQueryDesc AFKPCKOLMIG(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x2452590", Offset = "0x2451590", VA = "0x182452590", Slot = "17")]
	protected override EntityQueryDesc PLPHJMIHJEO(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x24525D0", Offset = "0x24515D0", VA = "0x1824525D0")]
	public BGJCOMLOHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x2452550", Offset = "0x2451550", VA = "0x182452550", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public abstract class PDCKMMONLNF<ParentData, PreviousParentData, ChildrenData> : DCFPPMHCPFJ where ParentData : struct, IComponentData, NACFKHNICAJ where PreviousParentData : struct, IComponentData, NACFKHNICAJ where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, NACFKHNICAJ
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[BurstCompile]
	private struct AICFNHIAMKB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public NativeMultiHashMap<Entity, Entity>.ParallelWriter JCHEKIPJNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public NativeMultiHashMap<Entity, Entity>.ParallelWriter KJODDDLMBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public NativeHashMap<Entity, int>.ParallelWriter DCBLMEHELMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public ArchetypeChunkComponentType<PreviousParentData> GKAEPDHLICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		[ReadOnly]
		public ArchetypeChunkComponentType<ParentData> FDJAHADHFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		[ReadOnly]
		public ArchetypeChunkEntityType GONGDDLLNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public uint PHPEDMFPHKI;

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x37E7480", Offset = "0x37E6480", VA = "0x1837E7480", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[BurstCompile]
	private struct NNFAEEFDHNH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		[ReadOnly]
		public NativeHashMap<Entity, int> DCBLMEHELMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> MENMDOIFODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public NativeList<Entity> NBOGFJPIBBB;

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x37EE720", Offset = "0x37ED720", VA = "0x1837EE720", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[BurstCompile]
	private struct IBIHBLCKICF : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		[ReadOnly]
		public NativeMultiHashMap<Entity, Entity> JCHEKIPJNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		[ReadOnly]
		public NativeMultiHashMap<Entity, Entity> KJODDDLMBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		[ReadOnly]
		public NativeHashMap<Entity, int> DCBLMEHELMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public BufferFromEntity<ChildrenData> MENMDOIFODK;

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x37EB5B0", Offset = "0x37EA5B0", VA = "0x1837EB5B0")]
		private int NPBOOACBCMN(DynamicBuffer<ChildrenData> DGKOICOAPAE, Entity CLCJGDKEGGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x37EB140", Offset = "0x37EA140", VA = "0x1837EB140")]
		private void BNCBCCAJBBC(Entity ACNNFDIAAFM, DynamicBuffer<ChildrenData> DGKOICOAPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x37EB7B0", Offset = "0x37EA7B0", VA = "0x1837EB7B0")]
		private void OIIGOHGNFFO(Entity ACNNFDIAAFM, DynamicBuffer<ChildrenData> DGKOICOAPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x37EB290", Offset = "0x37EA290", VA = "0x1837EB290", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[BurstCompile]
	private struct GLFGHCAGFOG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public NativeArray<Entity> AJKGBNMNEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public NativeList<Entity> GMNMBFINLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public BufferFromEntity<ChildrenData> MENMDOIFODK;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x37E8FB0", Offset = "0x37E7FB0", VA = "0x1837E8FB0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	protected EntityQuery DFOALJBCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	protected EntityQuery MDOHLDJBOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	protected EntityQuery AMEGHCEGJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	protected EntityQuery FOCJLCJADGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected ProfilerMarker MOJALHJHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	protected ProfilerMarker FFODFAPBJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected ProfilerMarker MNNAPKACKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	protected ProfilerMarker PCNHKMDKBHG;

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x37F2C70", Offset = "0x37F1C70", VA = "0x1837F2C70")]
	public PDCKMMONLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x37F2570", Offset = "0x37F1570", VA = "0x1837F2570")]
	private int NPBOOACBCMN(DynamicBuffer<ChildrenData> DGKOICOAPAE, Entity CLCJGDKEGGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x37F1440", Offset = "0x37F0440", VA = "0x1837F1440")]
	private void HBPBPAKDHAD(Entity FPCIICAAKEP, Entity KHMFOPNAGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x780EA0", Offset = "0x77FEA0", VA = "0x180780EA0", Slot = "14")]
	protected virtual EntityQueryDesc BEIGBHOMDEA(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x780EA0", Offset = "0x77FEA0", VA = "0x180780EA0", Slot = "15")]
	protected virtual EntityQueryDesc DBJNGMNBFFA(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x780EA0", Offset = "0x77FEA0", VA = "0x180780EA0", Slot = "16")]
	protected virtual EntityQueryDesc AFKPCKOLMIG(EntityQueryDesc FHCACFJLPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected abstract EntityQueryDesc PLPHJMIHJEO(EntityQueryDesc FHCACFJLPLH);

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x37F2670", Offset = "0x37F1670", VA = "0x1837F2670", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x37F2290", Offset = "0x37F1290", VA = "0x1837F2290")]
	private void NOOPJJCMFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x37F15B0", Offset = "0x37F05B0", VA = "0x1837F15B0")]
	private void NGNINLLIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x37F1DE0", Offset = "0x37F0DE0", VA = "0x1837F1DE0")]
	private void NLFGNJODCNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x37F0FA0", Offset = "0x37EFFA0", VA = "0x1837F0FA0")]
	private void BBNHNBKOBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0x37F2BB0", Offset = "0x37F1BB0", VA = "0x1837F2BB0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle JGHDOILELPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x25F6000", Offset = "0x25F5000", VA = "0x1825F6000", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[DOKDCAPODCB(PBFEFLGCHAA.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : HEODJEKIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[BurstCompile]
		private struct EPPGIIELKAP : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private const float PEHGHEIOABO = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> BAEIBILFPDL;

			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0x22C96C0", Offset = "0x22C86C0", VA = "0x1822C96C0", Slot = "4")]
			public void Execute(int IIHEDPBOLFE, TransformAccess BCLIDGMJFFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0x22C98F0", Offset = "0x22C88F0", VA = "0x1822C98F0")]
			private bool PPDCGIDJHEP(float3 NJCJINFAHGL, float3 GDKBIPOIHPF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0x22C98B0", Offset = "0x22C88B0", VA = "0x1822C98B0")]
			private bool IGNLAGBEGOC(quaternion NJCJINFAHGL, quaternion GDKBIPOIHPF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0x22C93F0", Offset = "0x22C83F0", VA = "0x1822C93F0")]
			private static bool BPDLGPGEDDD(float3 KKHMNCLOHHK, float3 GMPKOOIGMDG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x22C93B0", Offset = "0x22C83B0", VA = "0x1822C93B0")]
			private static bool BPDLGPGEDDD(quaternion EPLBIHGPPPN, quaternion PLMIDHOPDAL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0x22C98E0", Offset = "0x22C88E0", VA = "0x1822C98E0")]
			private static bool MIEMKKJJLJA(float NNAJOINAJDJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0x22C9670", Offset = "0x22C8670", VA = "0x1822C9670")]
			private static float DPLKJCIECEC(quaternion HDGOKGPFJPO, quaternion EPOMOCMLCGM)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[BurstCompile]
		private struct FDOEFLFBMDO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> BGGPNDGNLMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> AIJFLPAOCHK;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x22CB3A0", Offset = "0x22CA3A0", VA = "0x1822CB3A0", Slot = "4")]
			public void Execute(int IIHEDPBOLFE, TransformAccess BCLIDGMJFFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private const string FNOKPGFDMJG = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private const string HKMOOPKHHBP = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private const string NDKDPKDDDHM = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private static readonly ProfilerMarker OBHOJNOGNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private RegisterTransforms FENKFJGPPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TransformAccessArray OHALHDJKION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private GDEFGFJPJEE CBJNPEBBDJA;

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x22C7E10", Offset = "0x22C6E10", VA = "0x1822C7E10")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x22C7E70", Offset = "0x22C6E70", VA = "0x1822C7E70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x22C7EE0", Offset = "0x22C6EE0", VA = "0x1822C7EE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x22C7F50", Offset = "0x22C6F50", VA = "0x1822C7F50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[DOKDCAPODCB(PBFEFLGCHAA.TransformSyncing)]
	public class RegisterTransforms : HEODJEKIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct AGFHAPKFIEF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000135")]
			private struct ADLAGAFELLG
			{
				[Cpp2IlInjected.Token(Token = "0x2000136")]
				public struct EAAFBPNADND
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003DE")]
					public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003DF")]
					public LambdaParameterValueProvider_IComponentData<EIFMLBKMBLE>.Runtime BEKPMHCAABN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003E0")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime MDMGPJDNJJE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003DB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003DC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<EIFMLBKMBLE> ALBNOFEALAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003DD")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> IOOIDJIBGKC;

				[Cpp2IlInjected.Token(Token = "0x6000849")]
				[Cpp2IlInjected.Address(RVA = "0x22C4D30", Offset = "0x22C3D30", VA = "0x1822C4D30")]
				public void AIMCPLKOAEL(RegisterTransforms MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600084A")]
				[Cpp2IlInjected.Address(RVA = "0x22C4DB0", Offset = "0x22C3DB0", VA = "0x1822C4DB0")]
				public EAAFBPNADND CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(EAAFBPNADND);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private ADLAGAFELLG OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ADLAGAFELLG.EAAFBPNADND* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OFCOOEOPHJO;

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x22C4F20", Offset = "0x22C3F20", VA = "0x1822C4F20")]
			internal void ENEEDINPEMO(Entity CLCJGDKEGGN, EIFMLBKMBLE JECAFEIBOGA, Transform BCLIDGMJFFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x22C5000", Offset = "0x22C4000", VA = "0x1822C5000", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0x22C5090", Offset = "0x22C4090", VA = "0x1822C5090")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, ref ADLAGAFELLG.EAAFBPNADND HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x22C4F10", Offset = "0x22C3F10", VA = "0x1822C4F10")]
			public void AIMCPLKOAEL(RegisterTransforms MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x22C4EB0", Offset = "0x22C3EB0", VA = "0x1822C4EB0")]
			public unsafe static void ACCFGJHPDCO(ArchetypeChunkIterator* FECFCIOFAHJ, void* COJAKLHGGGK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000137")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct AIPEOAMEEDC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000138")]
			private struct OPBGBAJCFGJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000139")]
				[NoAlias]
				public struct DNIKLCOLBHJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003E5")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003E6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<EIFMLBKMBLE>.Runtime BEKPMHCAABN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003E3")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003E4")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<EIFMLBKMBLE> ALBNOFEALAP;

				[Cpp2IlInjected.Token(Token = "0x600084F")]
				[Cpp2IlInjected.Address(RVA = "0x22C57C0", Offset = "0x22C47C0", VA = "0x1822C57C0")]
				public void AIMCPLKOAEL(RegisterTransforms MNFLHJKJICL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000850")]
				[Cpp2IlInjected.Address(RVA = "0x22CD480", Offset = "0x22CC480", VA = "0x1822CD480")]
				public DNIKLCOLBHJ CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
				{
					return default(DNIKLCOLBHJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private OPBGBAJCFGJ OIHDHEHKCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe OPBGBAJCFGJ.DNIKLCOLBHJ* AEMLDHKJAAG;

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x22C5820", Offset = "0x22C4820", VA = "0x1822C5820")]
			internal void ENEEDINPEMO(Entity CLCJGDKEGGN, EIFMLBKMBLE JECAFEIBOGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x22C58E0", Offset = "0x22C48E0", VA = "0x1822C58E0", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x22C5980", Offset = "0x22C4980", VA = "0x1822C5980")]
			public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref OPBGBAJCFGJ.DNIKLCOLBHJ HILFNGGNOLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0x22C57C0", Offset = "0x22C47C0", VA = "0x1822C57C0")]
			public void AIMCPLKOAEL(RegisterTransforms MNFLHJKJICL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private LNNMEGDIHNO IIBNCANNEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private DJGBCAKLMIB LNGPLKPGIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery GIDPKBAHKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private EntityQuery HEJNOBDNEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery GIGBLPHBJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery JODJOMAGGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private ProfilerMarker DNMHEAPNIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery AHPGBNJKMFG;

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public DJGBCAKLMIB ALJJAKDGNCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x8FC690", Offset = "0x8FB690", VA = "0x1808FC690")]
			get
			{
				return default(DJGBCAKLMIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x22D7C80", Offset = "0x22D6C80", VA = "0x1822D7C80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x22D7E10", Offset = "0x22D6E10", VA = "0x1822D7E10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x22D7E20", Offset = "0x22D6E20", VA = "0x1822D7E20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x22D82C0", Offset = "0x22D72C0", VA = "0x1822D82C0")]
		private void PACLGINNHMB(NativeArray<Entity> AFOGFGIBNGF, DJGBCAKLMIB DCJMLCKFPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x22D7190", Offset = "0x22D6190", VA = "0x1822D7190")]
		[BurstCompile]
		internal static void AHHKBNDHHOD(NativeArray<EIFMLBKMBLE> KLNJKJHLFJA, ComponentDataFromEntity<EIFMLBKMBLE> NNJBOGDFMJN, DJGBCAKLMIB DCJMLCKFPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private static void HNOALAGGKDF(Transform BCLIDGMJFFC, Entity CLCJGDKEGGN, int IIHEDPBOLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private static void OCANNFHNNDK(Entity CLCJGDKEGGN, int IIHEDPBOLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private static void BHHAMJIALBG(int IIHEDPBOLFE, DJGBCAKLMIB DCJMLCKFPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x22D75B0", Offset = "0x22D65B0", VA = "0x1822D75B0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void HEKJFIDPNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x22D7940", Offset = "0x22D6940", VA = "0x1822D7940", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x22D7450", Offset = "0x22D6450", VA = "0x1822D7450")]
		public static EntityQuery BJJAENHEAPD(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x22D77B0", Offset = "0x22D67B0", VA = "0x1822D77B0")]
		public static EntityQuery MGDODBCBCKA(ComponentSystemBase MNFLHJKJICL)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[DOKDCAPODCB(PBFEFLGCHAA.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : HEODJEKIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x200013B")]
		[BurstCompile]
		private struct GMHDKJNLKJO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> BAEIBILFPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x22CC130", Offset = "0x22CB130", VA = "0x1822CC130", Slot = "4")]
			public void Execute(int IIHEDPBOLFE, TransformAccess BCLIDGMJFFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200013C")]
		[BurstCompile]
		private struct CPMMFEPPBBG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> BGGPNDGNLMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0x22C5E10", Offset = "0x22C4E10", VA = "0x1822C5E10", Slot = "4")]
			public void Execute(int IIHEDPBOLFE, TransformAccess BCLIDGMJFFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200013D")]
		[BurstCompile]
		private struct KMDLFGBACKD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> BGGPNDGNLMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> AIJFLPAOCHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			[ReadOnly]
			public NativeArray<Entity> AFOGFGIBNGF;

			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0x22CCF70", Offset = "0x22CBF70", VA = "0x1822CCF70", Slot = "4")]
			public void Execute(int IIHEDPBOLFE, TransformAccess BCLIDGMJFFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private const string FNOKPGFDMJG = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private const string HKMOOPKHHBP = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private const string NDKDPKDDDHM = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly LOBJLOAJGBA OHHIPKBNKHI;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly LOBJLOAJGBA GHLPAPAEKKB;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly LOBJLOAJGBA BELFLPIOMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private EADGIEGJJEJ FENKFJGPPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private JobHandle GNNHLLGBDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery IABMLPHOCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private EntityQuery KAKEDKPNGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private EntityQuery BBBIIAEMGHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private TransformAccessArray JHHOEOEONHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TransformAccessArray KHKIDHILONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TransformAccessArray OGCIBJBDDJE;

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x22C8450", Offset = "0x22C7450", VA = "0x1822C8450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x22C8660", Offset = "0x22C7660", VA = "0x1822C8660", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A50", Offset = "0x8F5A50", VA = "0x1808F6A50")]
		internal JobHandle PGDEJGBPBIM()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x22C86A0", Offset = "0x22C76A0", VA = "0x1822C86A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x22C82C0", Offset = "0x22C72C0", VA = "0x1822C82C0")]
		private NativeArray<Entity> GDDGFKLDJIG(NativeArray<EIFMLBKMBLE> BKMGCALIDIC, NativeList<Entity> NGFPBEGJKHE, TransformAccessArray ANDKILIGIEC, TransformAccessArray EHLJCMFMAFE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public class AKBGOFJIOLG : HEODJEKIBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private DBDEDJGCBGE ILGKHHBEJKJ;

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x244C270", Offset = "0x244B270", VA = "0x18244C270", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x244C2D0", Offset = "0x244B2D0", VA = "0x18244C2D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x244C000", Offset = "0x244B000", VA = "0x18244C000")]
	private static void DFDJGDCEILL(EntityManager EFLHIHFKEDM, Entity CLCJGDKEGGN, Entity ACNNFDIAAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x244C190", Offset = "0x244B190", VA = "0x18244C190")]
	private static Transform IEDINKEFEBC(EntityManager EFLHIHFKEDM, Entity CLCJGDKEGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000861")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public AKBGOFJIOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000862")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public class GJLCGEPDLGF : HEODJEKIBCE, JLLBLNFOFFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct BDDFOHLKCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public NativeList<CCHFFBLEBPJ> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public NativeList<CCHFFBLEBPJ> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public NativeList<Entity> oldParents;

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		public BDDFOHLKCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, BIFLGOGGJAG previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EA0", Offset = "0x22C3EA0", VA = "0x1822C4EA0")]
		internal void <OnUpdate>b__2(Entity entity)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct NCOGIAPKCHM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		private struct IANOJEGLAMK
		{
			[Cpp2IlInjected.Token(Token = "0x2000143")]
			[NoAlias]
			public struct KNGDMLNIHDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400040D")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400040E")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime MPKNHLPBAJM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> ALDAMHAFIJK;

			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0x22E10D0", Offset = "0x22E00D0", VA = "0x1822E10D0")]
			public void AIMCPLKOAEL(GJLCGEPDLGF MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x22E1130", Offset = "0x22E0130", VA = "0x1822E1130")]
			public KNGDMLNIHDM CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(KNGDMLNIHDM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public NativeList<CCHFFBLEBPJ> HFNNBDEEIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private IANOJEGLAMK OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IANOJEGLAMK.KNGDMLNIHDM* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x22F1340", Offset = "0x22F0340", VA = "0x1822F1340")]
		internal void ENEEDINPEMO(Entity CLCJGDKEGGN, ParentData KFPPFLMHIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x22CC6F0", Offset = "0x22CB6F0", VA = "0x1822CC6F0", Slot = "5")]
		public void ReadFromDisplayClass(ref BDDFOHLKCLI BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x22F13D0", Offset = "0x22F03D0", VA = "0x1822F13D0", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x22F1470", Offset = "0x22F0470", VA = "0x1822F1470")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref IANOJEGLAMK.KNGDMLNIHDM HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x22F12B0", Offset = "0x22F02B0", VA = "0x1822F12B0")]
		public void AIMCPLKOAEL(GJLCGEPDLGF MNFLHJKJICL, ref BDDFOHLKCLI BMLBBBFJKKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct GBCMOKFPGEH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct ACPOPIGLAOL
		{
			[Cpp2IlInjected.Token(Token = "0x2000146")]
			[NoAlias]
			public struct HBINMLKEIHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000415")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000416")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime MPKNHLPBAJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000417")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<BIFLGOGGJAG>.Runtime ABOMBHDMELE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> ALDAMHAFIJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<BIFLGOGGJAG> HCDHEOBKINO;

			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0x22DA800", Offset = "0x22D9800", VA = "0x1822DA800")]
			public void AIMCPLKOAEL(GJLCGEPDLGF MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x22DA880", Offset = "0x22D9880", VA = "0x1822DA880")]
			public HBINMLKEIHB CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(HBINMLKEIHB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public NativeList<CCHFFBLEBPJ> MHKDHMOMDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private ACPOPIGLAOL OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ACPOPIGLAOL.HBINMLKEIHB* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x22DB970", Offset = "0x22DA970", VA = "0x1822DB970")]
		internal void ENEEDINPEMO(Entity CLCJGDKEGGN, ParentData KFPPFLMHIFD, BIFLGOGGJAG KDOMAPKLCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x22DBBB0", Offset = "0x22DABB0", VA = "0x1822DBBB0", Slot = "5")]
		public void ReadFromDisplayClass(ref BDDFOHLKCLI BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x22DBA10", Offset = "0x22DAA10", VA = "0x1822DBA10", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x22DBAE0", Offset = "0x22DAAE0", VA = "0x1822DBAE0")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref ACPOPIGLAOL.HBINMLKEIHB HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x22DB930", Offset = "0x22DA930", VA = "0x1822DB930")]
		public void AIMCPLKOAEL(GJLCGEPDLGF MNFLHJKJICL, ref BDDFOHLKCLI BMLBBBFJKKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct IOPOOJGAAJO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000148")]
		private struct GJGGGNAJJME
		{
			[Cpp2IlInjected.Token(Token = "0x2000149")]
			[NoAlias]
			public struct MAOKENOIBNJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041C")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ODLAFNDAGMJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity GAAIFCBCBOD;

			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0x22DBBC0", Offset = "0x22DABC0", VA = "0x1822DBBC0")]
			public void AIMCPLKOAEL(GJLCGEPDLGF MNFLHJKJICL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0x22DBBD0", Offset = "0x22DABD0", VA = "0x1822DBBD0")]
			public MAOKENOIBNJ CNBGCNMEKJH(ref ArchetypeChunk CPMIJGFFFGO, int FCHOGNKCLDF, int BFGPAMDLJGF)
			{
				return default(MAOKENOIBNJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public NativeList<Entity> FDEAGCNFGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private GJGGGNAJJME OIHDHEHKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GJGGGNAJJME.MAOKENOIBNJ* AEMLDHKJAAG;

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x22E5B20", Offset = "0x22E4B20", VA = "0x1822E5B20")]
		internal void ENEEDINPEMO(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x22E5C40", Offset = "0x22E4C40", VA = "0x1822E5C40", Slot = "5")]
		public void ReadFromDisplayClass(ref BDDFOHLKCLI BMLBBBFJKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x22E5B70", Offset = "0x22E4B70", VA = "0x1822E5B70", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int CIAPAADGBLF, int NOHIKJOCMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x22E5BD0", Offset = "0x22E4BD0", VA = "0x1822E5BD0")]
		public void NHEJIMEDJFI(ref ArchetypeChunk BLGAELJLCIM, [NoAlias] ref GJGGGNAJJME.MAOKENOIBNJ HILFNGGNOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x22E5AE0", Offset = "0x22E4AE0", VA = "0x1822E5AE0")]
		public void AIMCPLKOAEL(GJLCGEPDLGF MNFLHJKJICL, ref BDDFOHLKCLI BMLBBBFJKKA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private DNEKLGPFBJJ PLFMGNDCBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private EntityQuery NBKIKCKEMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private EntityQuery JEJBFMNADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private EntityQuery PCHCFNMBCPH;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	internal NativeList<CCHFFBLEBPJ> JOLFDKJMFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<CCHFFBLEBPJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x8E83C0", Offset = "0x8E73C0", VA = "0x1808E83C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	internal NativeList<CCHFFBLEBPJ> GMFCAJJJNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FF0", Offset = "0x5E4FF0", VA = "0x1805E5FF0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<CCHFFBLEBPJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DE0", Offset = "0x8E5DE0", VA = "0x1808E6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	internal NativeList<Entity> LKHJBJICDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x8E83B0", Offset = "0x8E73B0", VA = "0x1808E83B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x8E83D0", Offset = "0x8E73D0", VA = "0x1808E83D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x245F080", Offset = "0x245E080", VA = "0x18245F080", Slot = "14")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x245F120", Offset = "0x245E120", VA = "0x18245F120", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x245F130", Offset = "0x245E130", VA = "0x18245F130", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x245EAF0", Offset = "0x245DAF0", VA = "0x18245EAF0")]
	private void GOBNLGGIJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x245ED60", Offset = "0x245DD60", VA = "0x18245ED60")]
	private void LNFINCFCIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x245F1C0", Offset = "0x245E1C0", VA = "0x18245F1C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public GJLCGEPDLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x24567B0", Offset = "0x24557B0", VA = "0x1824567B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x245E8C0", Offset = "0x245D8C0", VA = "0x18245E8C0")]
	public static EntityQuery CJAHEANIBOE(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x245EE80", Offset = "0x245DE80", VA = "0x18245EE80")]
	public static EntityQuery LOHNDKHDOFK(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x245EBA0", Offset = "0x245DBA0", VA = "0x18245EBA0")]
	public static EntityQuery HBIKKKCIIAJ(ComponentSystemBase MNFLHJKJICL)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[DOKDCAPODCB(PBFEFLGCHAA.TransformSyncing)]
	public class L2PToL2WHierarchy : DCFPPMHCPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x200014B")]
		[BurstCompile]
		private struct FIGMCFGBNHP : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> MAKEFOFJIJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> ILHMAPJFIHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> MJCNFAKKJHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> AMDEENIBFDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			public ArchetypeChunkComponentType<LocalToWorldData> NKCDEIFMGHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> JELMKGGCMLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public uint PHPEDMFPHKI;

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x22CBAF0", Offset = "0x22CAAF0", VA = "0x1822CBAF0")]
			[Conditional("DEBUG_BUILD")]
			private void NPPNAJIBFBC(Entity CLCJGDKEGGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x22CB760", Offset = "0x22CA760", VA = "0x1822CB760", Slot = "4")]
			public void Execute(ArchetypeChunk BLGAELJLCIM, int IIHEDPBOLFE, int KFLKHMMICFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x22CBA40", Offset = "0x22CAA40", VA = "0x1822CBA40")]
			private bool FNOEPDJHNIA(ArchetypeChunk BLGAELJLCIM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x22CBB90", Offset = "0x22CAB90", VA = "0x1822CBB90")]
			private void PGMCGGIDCPJ(float4x4 FEIBBKJBMEG, Entity CLCJGDKEGGN, bool KAJPOJFKMOK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private EntityQuery LOIBGNGMJOP;

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x22CD070", Offset = "0x22CC070", VA = "0x1822CD070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x22CD170", Offset = "0x22CC170", VA = "0x1822CD170", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle JGHDOILELPH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public class OEBDNIEEBFL : DCFPPMHCPFJ
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[BurstCompile]
	private struct OKKLLIBNCNL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> MAKEFOFJIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public ArchetypeChunkComponentType<LocalToWorldData> NKCDEIFMGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public uint PHPEDMFPHKI;

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x25EDE40", Offset = "0x25ECE40", VA = "0x1825EDE40", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int IIHEDPBOLFE, int KFLKHMMICFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x25EDF50", Offset = "0x25ECF50", VA = "0x1825EDF50")]
		public bool FNOEPDJHNIA(ArchetypeChunk BLGAELJLCIM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private EntityQuery LOIBGNGMJOP;

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x25EC780", Offset = "0x25EB780", VA = "0x1825EC780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x25EC880", Offset = "0x25EB880", VA = "0x1825EC880", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle JGHDOILELPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public OEBDNIEEBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public class KCDOKNODIKK : DCFPPMHCPFJ
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[BurstCompile]
	private struct NIJOMAKBIBM : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> MOAPNIDCIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public ArchetypeChunkComponentType<WorldPoseData> KAANFJGIEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> KNGIHBPEEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> EFGHNEOKFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public uint PHPEDMFPHKI;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x22F1870", Offset = "0x22F0870", VA = "0x1822F1870", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int IIHEDPBOLFE, int KFLKHMMICFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x22F1C10", Offset = "0x22F0C10", VA = "0x1822F1C10")]
		public bool FNOEPDJHNIA(ArchetypeChunk BLGAELJLCIM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private EntityQuery BDOHHFJFLIM;

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x22E7FB0", Offset = "0x22E6FB0", VA = "0x1822E7FB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x22E80A0", Offset = "0x22E70A0", VA = "0x1822E80A0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle JGHDOILELPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public KCDOKNODIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public class PBMEFFDIIFI : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[BurstCompile]
	private struct BDPLHMAIKND : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> GBAAFHLIOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> HCMGDBOFJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> EAMOLHICHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public ArchetypeChunkComponentType<LocalToParentData> DGIMIKMMMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public uint PHPEDMFPHKI;

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x25DFDE0", Offset = "0x25DEDE0", VA = "0x1825DFDE0", Slot = "4")]
		public void Execute(ArchetypeChunk BLGAELJLCIM, int IIHEDPBOLFE, int KFLKHMMICFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x25E0290", Offset = "0x25DF290", VA = "0x1825E0290")]
		public bool FNOEPDJHNIA(ArchetypeChunk BLGAELJLCIM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private EntityQuery BDOHHFJFLIM;

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0x25F0120", Offset = "0x25EF120", VA = "0x1825F0120", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x25F0230", Offset = "0x25EF230", VA = "0x1825F0230", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle JGHDOILELPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0")]
	public PBMEFFDIIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[NAOOJGDIFNC(DIAOBOKGPEM.Game)]
public class MBOJFCBEPKK : NBDAPPGFLGM
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Type BEFIHIFGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x25E7300", Offset = "0x25E6300", VA = "0x1825E7300", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Type[] HGKJCPCIDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x25E6EE0", Offset = "0x25E5EE0", VA = "0x1825E6EE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public MBOJFCBEPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[NAOOJGDIFNC(DIAOBOKGPEM.Loading)]
public class AKAMGFLLEHK : NBDAPPGFLGM
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public Type BEFIHIFGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x612E80", Offset = "0x611E80", VA = "0x180612E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Type[] HGKJCPCIDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x244BF20", Offset = "0x244AF20", VA = "0x18244BF20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AKAMGFLLEHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
public sealed class DFEAPGMMJIK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008AE")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public DFEAPGMMJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(DFEAPGMMJIK))]
public sealed class DCLDLNCMNEO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008B0")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public DCLDLNCMNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(DFEAPGMMJIK))]
[UpdateAfter(typeof(DCLDLNCMNEO))]
public sealed class CCNMIHFOHMJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public CCNMIHFOHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[NAOOJGDIFNC(DIAOBOKGPEM.Saving)]
public class AKKCHIDKGFH : NBDAPPGFLGM
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Type BEFIHIFGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x612E80", Offset = "0x611E80", VA = "0x180612E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Type[] HGKJCPCIDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x244C6A0", Offset = "0x244B6A0", VA = "0x18244C6A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AKKCHIDKGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
public sealed class IKBMIHCLLIH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public IKBMIHCLLIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[NAOOJGDIFNC(DIAOBOKGPEM.Simulation)]
public class IJGENPKNIMA : NBDAPPGFLGM
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Type BEFIHIFGLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x22E3F30", Offset = "0x22E2F30", VA = "0x1822E3F30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Type[] HGKJCPCIDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x22E3D10", Offset = "0x22E2D10", VA = "0x1822E3D10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public IJGENPKNIMA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[AJHJJBJAJKN(typeof(FBKDAMAOBBF), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.Connectables, new string[] { "Callbacks" })]
	internal class ConnectableService : FBKDAMAOBBF, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		[CompilerGenerated]
		private sealed class IKPNPOOFDNK : IEnumerable<KOHKPOMNCDA>, IEnumerable, IEnumerator<KOHKPOMNCDA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private KOHKPOMNCDA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			private KOHKPOMNCDA localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public KOHKPOMNCDA <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000128")]
			private KOHKPOMNCDA System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008E0")]
				[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KOHKPOMNCDA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000129")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008E2")]
				[Cpp2IlInjected.Address(RVA = "0x22CCBE0", Offset = "0x22CBBE0", VA = "0x1822CCBE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0xA0E7D0", Offset = "0xA0D7D0", VA = "0x180A0E7D0")]
			[DebuggerHidden]
			public IKPNPOOFDNK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0x22CCC30", Offset = "0x22CBC30", VA = "0x1822CCC30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DD")]
			[Cpp2IlInjected.Address(RVA = "0x22CC840", Offset = "0x22CB840", VA = "0x1822CC840", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x22CCD20", Offset = "0x22CBD20", VA = "0x1822CCD20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x22CCD60", Offset = "0x22CBD60", VA = "0x1822CCD60")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E1")]
			[Cpp2IlInjected.Address(RVA = "0x22CCB90", Offset = "0x22CBB90", VA = "0x1822CCB90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0x22CCAE0", Offset = "0x22CBAE0", VA = "0x1822CCAE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KOHKPOMNCDA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0x22CCAE0", Offset = "0x22CBAE0", VA = "0x1822CCAE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private const string POFACCADNOC = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private static readonly LOBJLOAJGBA NPHGPPMKMOJ;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public const int KPIBBBBNPCO = 0;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public const int KOLEPGHPDAD = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private INJCNOHDGPO BDOHHFJFLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private GDEFGFJPJEE BICCGEMNLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private global::IEPFFDMNABG<AuthoredParentData, HIEPCEPLNDC, NEOAGFCCEKH, AuthoredChildrenData> GPKGADENIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private global::PFPLEKPHCDD<Entity> LFFILKGNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private global::PFPLEKPHCDD<float3> ECFIEPLDIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private global::PFPLEKPHCDD<quaternion> LFLKKGPJJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private global::PFPLEKPHCDD<Entity> ACNNFDIAAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private global::PFPLEKPHCDD<float3> OOJHNKALAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private global::PFPLEKPHCDD<quaternion> LOMDKHFBCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private PropertyEventCallbacksService BDHLJDNMEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private HashSet<Entity> OJIFOPCFFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private HashSet<Entity> NNOIHGJIDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private EntityQuery DNKNDDHELJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private bool NJLKFAFJNJO;

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public Func<HLNNPEHJABK> LAEOOBEHGDM
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0x670AB0", Offset = "0x66FAB0", VA = "0x180670AB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0x672980", Offset = "0x671980", VA = "0x180672980", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<KOHKPOMNCDA, KOHKPOMNCDA> INAIPMEFKAB
		{
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0x22C63D0", Offset = "0x22C53D0", VA = "0x1822C63D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0x22C7270", Offset = "0x22C6270", VA = "0x1822C7270", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<KOHKPOMNCDA, KOHKPOMNCDA> FJMDOIGIKEI
		{
			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0x22C6E10", Offset = "0x22C5E10", VA = "0x1822C6E10", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008BF")]
			[Cpp2IlInjected.Address(RVA = "0x22C7010", Offset = "0x22C6010", VA = "0x1822C7010", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<KOHKPOMNCDA, KOHKPOMNCDA, KOHKPOMNCDA> AILGAOKLGIM
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x22C7310", Offset = "0x22C6310", VA = "0x1822C7310", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0x22C6C00", Offset = "0x22C5C00", VA = "0x1822C6C00", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<KOHKPOMNCDA> DPEKHECCBKD
		{
			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0x22C6330", Offset = "0x22C5330", VA = "0x1822C6330", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0x22C7AC0", Offset = "0x22C6AC0", VA = "0x1822C7AC0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x22C7440", Offset = "0x22C6440", VA = "0x1822C7440", Slot = "22")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x22C7580", Offset = "0x22C6580", VA = "0x1822C7580", Slot = "23")]
		public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x22C6830", Offset = "0x22C5830", VA = "0x1822C6830", Slot = "24")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x22C6480", Offset = "0x22C5480", VA = "0x1822C6480")]
		private void CKHICNAIDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x22C6AB0", Offset = "0x22C5AB0", VA = "0x1822C6AB0")]
		private void FAIGHPBCDAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x22C5F60", Offset = "0x22C4F60", VA = "0x1822C5F60")]
		private void BIFGGLDMPOC(Entity CLCJGDKEGGN, IHCHEEIIPON FANBLFBADKJ, JHBOMEIKHGC GDKBIPOIHPF, JHBOMEIKHGC NJCJINFAHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x22C64E0", Offset = "0x22C54E0", VA = "0x1822C64E0")]
		private void CLIGOFPNGKP(Entity CLCJGDKEGGN, IHCHEEIIPON FANBLFBADKJ, JHBOMEIKHGC GDKBIPOIHPF, JHBOMEIKHGC NJCJINFAHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x22C6470", Offset = "0x22C5470", VA = "0x1822C6470", Slot = "14")]
		public KOHKPOMNCDA CJCEMANELLK(KOHKPOMNCDA FCJPDBMFAED, int AMGCKKAIKEJ)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xFB8300", Offset = "0xFB7300", VA = "0x180FB8300", Slot = "15")]
		public Color DLMPAALBGHG(KOHKPOMNCDA FCJPDBMFAED, int AMGCKKAIKEJ)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x22C6760", Offset = "0x22C5760", VA = "0x1822C6760", Slot = "16")]
		public void DGGJLEKFKFN(KOHKPOMNCDA FCJPDBMFAED, KOHKPOMNCDA IPGLPMPKCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x22C5EC0", Offset = "0x22C4EC0", VA = "0x1822C5EC0", Slot = "17")]
		public KOHKPOMNCDA AMDMBCDOPIK(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x22C6110", Offset = "0x22C5110", VA = "0x1822C6110", Slot = "20")]
		public void BLICECLLGAG(KOHKPOMNCDA FCJPDBMFAED, Vector3 HBMJFACHDEO, Quaternion BECEJEHOLKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x22C6EB0", Offset = "0x22C5EB0", VA = "0x1822C6EB0", Slot = "25")]
		public (Vector3, Quaternion) GHEPKAMAIKE(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x22C7B60", Offset = "0x22C6B60", VA = "0x1822C7B60", Slot = "26")]
		public (Vector3, Quaternion) PMCIMNFOGHC(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x22C70B0", Offset = "0x22C60B0", VA = "0x1822C70B0", Slot = "21")]
		public (Vector3, Quaternion, bool) KHPAMCIPIDF(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x22C73B0", Offset = "0x22C63B0", VA = "0x1822C73B0", Slot = "18")]
		[IteratorStateMachine(typeof(IKPNPOOFDNK))]
		public IEnumerable<KOHKPOMNCDA> MOMIIJGOAKH(KOHKPOMNCDA FCJPDBMFAED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x22C6540", Offset = "0x22C5540", VA = "0x1822C6540", Slot = "19")]
		public KOHKPOMNCDA CPDDCBADJAO(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x22C6CA0", Offset = "0x22C5CA0", VA = "0x1822C6CA0", Slot = "27")]
		public void FGIAMLJJIIA(ref List<KOHKPOMNCDA> HKLPHEJENOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x22C6660", Offset = "0x22C5660", VA = "0x1822C6660")]
		private Entity CPDDCBADJAO(Entity CLCJGDKEGGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x22C7D70", Offset = "0x22C6D70", VA = "0x1822C7D70")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[AJHJJBJAJKN(typeof(EntityHierarchyChildren), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.HierarchySystems)]
	internal sealed class EntityHierarchyChildren : JLLBLNFOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private GDEFGFJPJEE BICCGEMNLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private ANFBMLMNOPH DJBJNOPKDAM;

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		private EntityManager OLPNKMBFBCG
		{
			[Cpp2IlInjected.Token(Token = "0x60008E5")]
			[Cpp2IlInjected.Address(RVA = "0x22CA760", Offset = "0x22C9760", VA = "0x1822CA760")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x22CA7B0", Offset = "0x22C97B0", VA = "0x1822CA7B0", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x22CA0E0", Offset = "0x22C90E0", VA = "0x1822CA0E0")]
		internal void AOOPKKGFCEI(Entity ACNNFDIAAFM, Entity GPFGJIGIKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x22CA470", Offset = "0x22C9470", VA = "0x1822CA470")]
		internal void IGPHMFAADEA(Entity ACNNFDIAAFM, Entity GPFGJIGIKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x22CA2A0", Offset = "0x22C92A0", VA = "0x1822CA2A0")]
		private int GIJLAHIOKLE(Entity ACNNFDIAAFM, Entity GPFGJIGIKFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x22CA020", Offset = "0x22C9020", VA = "0x1822CA020")]
		internal DynamicBuffer<ChildrenData> AFLLEGMKHFH(Entity CLCJGDKEGGN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x22CA240", Offset = "0x22C9240", VA = "0x1822CA240")]
		public NativeArray<Entity> FNOHBPONLMH(Entity CLCJGDKEGGN, Allocator LKNIKCJFBFH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x22CA540", Offset = "0x22C9540", VA = "0x1822CA540")]
		public bool KNAONKENKAK(Entity CLCJGDKEGGN, Allocator LKNIKCJFBFH, out NativeArray<Entity> KOOAFCDPKMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x22CA620", Offset = "0x22C9620", VA = "0x1822CA620")]
		public NativeArray<Entity> MBPMJKHANBD(Entity CLCJGDKEGGN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x22CA830", Offset = "0x22C9830", VA = "0x1822CA830")]
		public Entity OAJJPFNHHFL(Entity CLCJGDKEGGN, int IIHEDPBOLFE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x22CA380", Offset = "0x22C9380", VA = "0x1822CA380")]
		public int HPLFBALIGMC(Entity CLCJGDKEGGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[DOKDCAPODCB(PBFEFLGCHAA.HierarchySystems)]
	[AJHJJBJAJKN(typeof(EntityHierarchyEvents), new string[] { })]
	internal sealed class EntityHierarchyEvents : JLLBLNFOFFK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private GDEFGFJPJEE BICCGEMNLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private ObjectEmbodimentService INGBFIDDJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private ObjectLifecycleService HEPCCGNPEJA;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x22CAAA0", Offset = "0x22C9AA0", VA = "0x1822CAAA0", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x22CA990", Offset = "0x22C9990", VA = "0x1822CA990", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private void ADFAOACIMEH(AANBNAJPLKI INGBFIDDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private void MEKBANHNCNK(AANBNAJPLKI INGBFIDDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
		private void MJBELKNCEJH(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[DOKDCAPODCB(PBFEFLGCHAA.HierarchySystems)]
	[AJHJJBJAJKN(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : JLLBLNFOFFK, HLHBDIEKOND
	{
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private INJCNOHDGPO BDOHHFJFLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private global::PFPLEKPHCDD<Entity> KIMANJPEJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private PropertyChangeNetworkRouter OCFJCIBMEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private global::IEPFFDMNABG<ParentData, BIFLGOGGJAG, FCDGKDPFLOF, ChildrenData> GPKGADENIIH;

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x22CB1F0", Offset = "0x22CA1F0", VA = "0x1822CB1F0", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x22CB270", Offset = "0x22CA270", VA = "0x1822CB270", Slot = "5")]
		public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x22CAE70", Offset = "0x22C9E70", VA = "0x1822CAE70")]
		public Entity AMDMBCDOPIK(Entity CLCJGDKEGGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x22CAEC0", Offset = "0x22C9EC0", VA = "0x1822CAEC0")]
		public bool DGGJLEKFKFN(Entity CLCJGDKEGGN, Entity LGIBIGENFOC, bool FBEEIDPLMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x22CAF60", Offset = "0x22C9F60", VA = "0x1822CAF60")]
		private bool HEGBIOPKOFC(Entity CLCJGDKEGGN, Entity LGIBIGENFOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[KBDAHOGMDPL(typeof(GDEFGFJPJEE))]
[AJHJJBJAJKN(typeof(ANFBMLMNOPH), new string[] { })]
internal sealed class ANFBMLMNOPH : JLLBLNFOFFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class MJHEKPNJKMC : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public ANFBMLMNOPH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000913")]
			[Cpp2IlInjected.Address(RVA = "0xF86930", Offset = "0xF85930", VA = "0x180F86930", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x2461600", Offset = "0x2460600", VA = "0x182461600", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x22DEC20", Offset = "0x22DDC20", VA = "0x1822DEC20")]
		[DebuggerHidden]
		public MJHEKPNJKMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2461460", Offset = "0x2460460", VA = "0x182461460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x24615B0", Offset = "0x24605B0", VA = "0x1824615B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2461500", Offset = "0x2460500", VA = "0x182461500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2461500", Offset = "0x2460500", VA = "0x182461500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class GMGDOGMMFBP : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public ANFBMLMNOPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xF86930", Offset = "0xF85930", VA = "0x180F86930", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0x245F790", Offset = "0x245E790", VA = "0x18245F790", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x22DEC20", Offset = "0x22DDC20", VA = "0x1822DEC20")]
		[DebuggerHidden]
		public GMGDOGMMFBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x245F7E0", Offset = "0x245E7E0", VA = "0x18245F7E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x245F4D0", Offset = "0x245E4D0", VA = "0x18245F4D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x245F890", Offset = "0x245E890", VA = "0x18245F890")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x245F740", Offset = "0x245E740", VA = "0x18245F740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x245F690", Offset = "0x245E690", VA = "0x18245F690", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x245F690", Offset = "0x245E690", VA = "0x18245F690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class NIAPKPEIHGE : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public ANFBMLMNOPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xF86930", Offset = "0xF85930", VA = "0x180F86930", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0x2461C10", Offset = "0x2460C10", VA = "0x182461C10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x22DEC20", Offset = "0x22DDC20", VA = "0x1822DEC20")]
		[DebuggerHidden]
		public NIAPKPEIHGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2461C60", Offset = "0x2460C60", VA = "0x182461C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2461860", Offset = "0x2460860", VA = "0x182461860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2461D60", Offset = "0x2460D60", VA = "0x182461D60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x2461DA0", Offset = "0x2460DA0", VA = "0x182461DA0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x2461BC0", Offset = "0x2460BC0", VA = "0x182461BC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2461B10", Offset = "0x2460B10", VA = "0x182461B10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2461B10", Offset = "0x2460B10", VA = "0x182461B10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private EntityHierarchyParents HEPFDPEAIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityHierarchyChildren DGKOICOAPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private EntityQuery DNKNDDHELJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private bool NJLKFAFJNJO;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x244D630", Offset = "0x244C630", VA = "0x18244D630")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x244D7B0", Offset = "0x244C7B0", VA = "0x18244D7B0", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x244D300", Offset = "0x244C300", VA = "0x18244D300", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x244D0D0", Offset = "0x244C0D0", VA = "0x18244D0D0")]
	public bool CPDCGLLJNJD(Entity CLCJGDKEGGN, Entity IIJHPNIJLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x244D320", Offset = "0x244C320", VA = "0x18244D320")]
	public bool FAOGFIGEGKJ(Entity CLCJGDKEGGN, Entity IIJHPNIJLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x244D680", Offset = "0x244C680", VA = "0x18244D680")]
	public IEnumerable<Entity> NLFHAONJPJD(Entity CLCJGDKEGGN, bool BDFHGDMNBNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x244D590", Offset = "0x244C590", VA = "0x18244D590")]
	[IteratorStateMachine(typeof(MJHEKPNJKMC))]
	private IEnumerable<Entity> MILGFHIGONN(Entity CLCJGDKEGGN, bool BDFHGDMNBNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x244CEE0", Offset = "0x244BEE0", VA = "0x18244CEE0")]
	public bool BBAIDIENPKA(Entity CLCJGDKEGGN, Entity GPFGJIGIKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x244D570", Offset = "0x244C570", VA = "0x18244D570")]
	public bool JOMKOGLPFKL(Entity CLCJGDKEGGN, Entity DEKOLLLDDAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x244CFA0", Offset = "0x244BFA0", VA = "0x18244CFA0")]
	public IEnumerable<Entity> BGCIPFHEMCN(Entity CLCJGDKEGGN, bool BDFHGDMNBNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x244D4D0", Offset = "0x244C4D0", VA = "0x18244D4D0")]
	[IteratorStateMachine(typeof(GMGDOGMMFBP))]
	private IEnumerable<Entity> JBANCGMNGFP(Entity CLCJGDKEGGN, bool BDFHGDMNBNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x244D450", Offset = "0x244C450", VA = "0x18244D450")]
	[IteratorStateMachine(typeof(NIAPKPEIHGE))]
	private IEnumerable<Entity> GHDHPOBCGMM(Entity CLCJGDKEGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x244D270", Offset = "0x244C270", VA = "0x18244D270")]
	public Entity CPDDCBADJAO(Entity CLCJGDKEGGN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x244D400", Offset = "0x244C400", VA = "0x18244D400")]
	public NativeArray<Entity> FGIAMLJJIIA()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x244D8C0", Offset = "0x244C8C0", VA = "0x18244D8C0")]
	public bool ODLGFFKEGJI(Entity DEKOLLLDDAM, Entity PGJCGJKNAPB, out Entity MIBLCIFEPBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public ANFBMLMNOPH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[DOKDCAPODCB(PBFEFLGCHAA.HierarchySystems)]
	public struct ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2443380", Offset = "0x2442380", VA = "0x182443380")]
		public static void GICBDFIFCOH<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(CAJHOBCLJCD HNBMHDKILBK, global::KBDGAEOCIJO<Entity> JPOEBAHCHNJ, out global::IEPFFDMNABG<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> JCNBDFEDDLE) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, NACFKHNICAJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, NACFKHNICAJ, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x22D23B0", Offset = "0x22D13B0", VA = "0x1822D23B0")]
		public static bool LAAPKIDBLIF(AANBNAJPLKI NHKKBKKOJJM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public struct IEPFFDMNABG<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, NACFKHNICAJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, NACFKHNICAJ, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private static readonly LOBJLOAJGBA NMFPNEPNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private readonly global::PFPLEKPHCDD<Entity> KIMANJPEJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly NACHGIEDHED KJNNLNBEGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly PNEIOOPEEOE ACNNFDIAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly EntityManager EFLHIHFKEDM;

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0x25152A0", Offset = "0x25142A0", VA = "0x1825152A0")]
	public IEPFFDMNABG(CAJHOBCLJCD HNBMHDKILBK, global::KBDGAEOCIJO<Entity> JPOEBAHCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092E")]
	[Cpp2IlInjected.Address(RVA = "0x2514D60", Offset = "0x2513D60", VA = "0x182514D60")]
	private bool LNIFOMHOKKL(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600092F")]
	[Cpp2IlInjected.Address(RVA = "0x25146F0", Offset = "0x25136F0", VA = "0x1825146F0")]
	private bool DAMOOPNMHEJ(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x25141F0", Offset = "0x25131F0", VA = "0x1825141F0")]
	public bool CAOLJHBDODK(Entity CLCJGDKEGGN, in Entity LGIBIGENFOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	private static void DBLANBHMGNA(Entity CLCJGDKEGGN, Entity LGIBIGENFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000932")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	private static void AFPOMLENCJB(Entity CLCJGDKEGGN, Entity LGIBIGENFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000933")]
	[Cpp2IlInjected.Address(RVA = "0x2514550", Offset = "0x2513550", VA = "0x182514550")]
	private bool CPDCGLLJNJD(Entity CLCJGDKEGGN, Entity IIJHPNIJLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0x2513BA0", Offset = "0x2512BA0", VA = "0x182513BA0")]
	private void BGNJEDFFCLP(Entity CLCJGDKEGGN, in Entity JKLPNJODLAC, in Entity LGIBIGENFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000935")]
	[Cpp2IlInjected.Address(RVA = "0x2514740", Offset = "0x2513740", VA = "0x182514740")]
	private void DLADJMHLNGG(Entity CLCJGDKEGGN, in Entity JKLPNJODLAC, in Entity LGIBIGENFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000936")]
	[Cpp2IlInjected.Address(RVA = "0x2514E20", Offset = "0x2513E20", VA = "0x182514E20")]
	private bool PEGHAJGAEFG(DIABEAIBJML MKDJPDCNEDI, in LEPNJELBIPF ONOOFJNHFMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x2514B20", Offset = "0x2513B20", VA = "0x182514B20")]
	private void IKMBIONFCOF(Entity ACNNFDIAAFM, Entity GPFGJIGIKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2513C90", Offset = "0x2512C90", VA = "0x182513C90")]
	private void BIMNJABIABE(Entity ACNNFDIAAFM, Entity GPFGJIGIKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	private void BHHAMJIALBG(Entity CLCJGDKEGGN, Entity JKLPNJODLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	private void HNOALAGGKDF(Entity CLCJGDKEGGN, Entity LGIBIGENFOC)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[AJHJJBJAJKN(typeof(TransformOwnershipPhase), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x2000166")]
		public enum OHACOAMJDFC
		{
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x2000167")]
		public struct EHANDKPICKD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private OHACOAMJDFC JBLDGKDDOGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private readonly TransformOwnershipPhase ACNNFDIAAFM;

			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0x576E7C0", Offset = "0x576D7C0", VA = "0x18576E7C0")]
			public EHANDKPICKD(TransformOwnershipPhase ACNNFDIAAFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0x576E7A0", Offset = "0x576D7A0", VA = "0x18576E7A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public OHACOAMJDFC JHMHMMIEKDN;

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public OHACOAMJDFC IJBOPELMDNO
		{
			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0x5E5ED0", Offset = "0x5E4ED0", VA = "0x1805E5ED0")]
			get
			{
				return default(OHACOAMJDFC);
			}
			[Cpp2IlInjected.Token(Token = "0x600093D")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EE0", Offset = "0x5E4EE0", VA = "0x1805E5EE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public bool OBJLGLEPHCL
		{
			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0x9C3310", Offset = "0x9C2310", VA = "0x1809C3310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		public bool CNMKJOAINHH
		{
			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0x9BCBB0", Offset = "0x9BBBB0", VA = "0x1809BCBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x5770190", Offset = "0x576F190", VA = "0x185770190")]
		public EHANDKPICKD PFDNKHBDLIL()
		{
			return default(EHANDKPICKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
public class AGOAAFMBOMJ : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly AGOAAFMBOMJ CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x244B8D0", Offset = "0x244A8D0", VA = "0x18244B8D0", Slot = "4")]
	public bool Equals(LinkedEntityGroup JIOINDMBNBK, LinkedEntityGroup AOEDNBDEECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x244B8F0", Offset = "0x244A8F0", VA = "0x18244B8F0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup MDAEAKFNGDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AGOAAFMBOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public struct BBGEOMDADMJ : global::CKDCIHLAPNJ<BBGEOMDADMJ>, GHELMGKGIIN, IEquatable<BBGEOMDADMJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly BBGEOMDADMJ LDPEBGGGOAP;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public int KBBNJEDOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x91EAC0", Offset = "0x91DAC0", VA = "0x18091EAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public int ICOAIKCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x8A44E0", Offset = "0x8A34E0", VA = "0x1808A44E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x8F82D0", Offset = "0x8F72D0", VA = "0x1808F82D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool NFKGIEPPODC
	{
		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x244DD20", Offset = "0x244CD20", VA = "0x18244DD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x244DD60", Offset = "0x244CD60", VA = "0x18244DD60", Slot = "8")]
	public bool Equals(BBGEOMDADMJ IJDAJAEAAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x244DDB0", Offset = "0x244CDB0", VA = "0x18244DDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public struct MBMBNJBINEE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public BBGEOMDADMJ BFJMCAAKMNM;
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct MEDGHPKAJDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private const int NJKGJBPLMFF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private readonly Stack<HashSet<object>> GBDKGBJKNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::DAMIDBMLOOO<BBGEOMDADMJ, HashSet<object>> JAABHFFEADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private EntityManager EFLHIHFKEDM;

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x25E79F0", Offset = "0x25E69F0", VA = "0x1825E79F0")]
	public MEDGHPKAJDK(EntityManager EFLHIHFKEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x25E7690", Offset = "0x25E6690", VA = "0x1825E7690")]
	public void HDDMGGPKOMP(Entity CLCJGDKEGGN, object KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x25E7540", Offset = "0x25E6540", VA = "0x1825E7540")]
	public bool HCAHFLNKCDN(Entity CLCJGDKEGGN, object KGJPBGICHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x25E7910", Offset = "0x25E6910", VA = "0x1825E7910")]
	public bool PFFPPMPEKLJ(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x25E7950", Offset = "0x25E6950", VA = "0x1825E7950")]
	public bool PFFPPMPEKLJ(BBGEOMDADMJ BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x25E7360", Offset = "0x25E6360", VA = "0x1825E7360")]
	public bool CKEPOEKMENG(Entity CLCJGDKEGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x25E7430", Offset = "0x25E6430", VA = "0x1825E7430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x25E7770", Offset = "0x25E6770", VA = "0x1825E7770")]
	private void KDMLJLMOAJM(HashSet<object> KLPGNMMNBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x25E7850", Offset = "0x25E6850", VA = "0x1825E7850")]
	private bool NOIIOBDDGKA(Entity CLCJGDKEGGN, out BBGEOMDADMJ BFJMCAAKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x25E7470", Offset = "0x25E6470", VA = "0x1825E7470")]
	private void GBBGBCLBLNP(Entity CLCJGDKEGGN, BBGEOMDADMJ BFJMCAAKMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x25E74E0", Offset = "0x25E64E0", VA = "0x1825E74E0")]
	private bool GMCKADBCLAL(BBGEOMDADMJ LFLGAHKDIMI, out HashSet<object> KLPGNMMNBOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x25E77D0", Offset = "0x25E67D0", VA = "0x1825E77D0")]
	private HashSet<object> LEKPLNNLJIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[AJHJJBJAJKN(typeof(DNEKLGPFBJJ), new string[] { })]
internal sealed class DNEKLGPFBJJ
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action HCHAHJMJING
	{
		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x24596B0", Offset = "0x24586B0", VA = "0x1824596B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x2459750", Offset = "0x2458750", VA = "0x182459750")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x13B2C10", Offset = "0x13B1C10", VA = "0x1813B2C10")]
	public void NMIPJLJPHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DNEKLGPFBJJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[AJHJJBJAJKN(typeof(ObjectEmbodimentService), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.Embodiment)]
	internal sealed class ObjectEmbodimentService : LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private readonly Dictionary<LEPNJELBIPF, PHJBPPLEHIN> MIHHNPELDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private GDEFGFJPJEE BICCGEMNLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private INJCNOHDGPO BDOHHFJFLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private PBNGMJECOGA BILODKHEIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private DAOOMKALOAB AHPGGHJEFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private MEDGHPKAJDK AKNEHJIKICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private EntityHierarchyChildren DGKOICOAPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private ObjectLifecycleService HEPCCGNPEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TransformOwnershipPhase JHMHMMIEKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private bool NJLKFAFJNJO;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		private EntityManager OLPNKMBFBCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x22CF9A0", Offset = "0x22CE9A0", VA = "0x1822CF9A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public int OBJKPBJHGBM
		{
			[Cpp2IlInjected.Token(Token = "0x600096A")]
			[Cpp2IlInjected.Address(RVA = "0x22D0070", Offset = "0x22CF070", VA = "0x1822D0070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public int FAICENAGFBF
		{
			[Cpp2IlInjected.Token(Token = "0x600096B")]
			[Cpp2IlInjected.Address(RVA = "0x22CE4A0", Offset = "0x22CD4A0", VA = "0x1822CE4A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<AANBNAJPLKI> BCKGGOMHAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0x22D0510", Offset = "0x22CF510", VA = "0x1822D0510")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0x22CDBE0", Offset = "0x22CCBE0", VA = "0x1822CDBE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<AANBNAJPLKI> CAMJCDFHGLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x22D05B0", Offset = "0x22CF5B0", VA = "0x1822D05B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x22CEE70", Offset = "0x22CDE70", VA = "0x1822CEE70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x22CF610", Offset = "0x22CE610", VA = "0x1822CF610", Slot = "4")]
		public void LDGKFGFMALP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x22CFAC0", Offset = "0x22CEAC0", VA = "0x1822CFAC0", Slot = "5")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x22D03E0", Offset = "0x22CF3E0", VA = "0x1822D03E0", Slot = "6")]
		public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x22CE240", Offset = "0x22CD240", VA = "0x1822CE240", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x22CFEA0", Offset = "0x22CEEA0", VA = "0x1822CFEA0")]
		public bool OBIHMALIAPP(Entity CLCJGDKEGGN, Allocator LKNIKCJFBFH, out NativeList<Entity> KJNMOAEIIAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x22D0090", Offset = "0x22CF090", VA = "0x1822D0090")]
		public global::JKLCOILHKCM<Entity> OBPGFFEBENA(Allocator LKNIKCJFBFH)
		{
			return default(global::JKLCOILHKCM<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x22CE720", Offset = "0x22CD720", VA = "0x1822CE720")]
		public bool GFPEMECKFMF(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x22CE610", Offset = "0x22CD610", VA = "0x1822CE610")]
		public bool FGIFIJDGKBN(Entity CLCJGDKEGGN, out PHJBPPLEHIN INGBFIDDJOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x22CE680", Offset = "0x22CD680", VA = "0x1822CE680")]
		private bool FGIFIJDGKBN(Transform BCLIDGMJFFC, out PHJBPPLEHIN INGBFIDDJOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x22CDBC0", Offset = "0x22CCBC0", VA = "0x1822CDBC0")]
		internal bool BOFDBOPLNCC(Entity CLCJGDKEGGN, out KLKONKKFEIM INGBFIDDJOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x22CE410", Offset = "0x22CD410", VA = "0x1822CE410")]
		private void EIBCIMIDLBI(Entity CLCJGDKEGGN, PHJBPPLEHIN INGBFIDDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x22CF620", Offset = "0x22CE620", VA = "0x1822CF620")]
		private bool LHHNEBNIEBG(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x22CE830", Offset = "0x22CD830", VA = "0x1822CE830")]
		public void HCCDLMMPDLB(LEPNJELBIPF POJMBOCFKCO, PHJBPPLEHIN BOGFGFMBOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x22CF8E0", Offset = "0x22CE8E0", VA = "0x1822CF8E0")]
		public bool MICGNMEAHFB(Entity CLCJGDKEGGN, object KGJPBGICHFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x22CDA00", Offset = "0x22CCA00", VA = "0x1822CDA00")]
		public bool BDIFMCBODED(KOHKPOMNCDA FCJPDBMFAED, object KGJPBGICHFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x22CDAD0", Offset = "0x22CCAD0", VA = "0x1822CDAD0")]
		public bool BDIFMCBODED(Entity CLCJGDKEGGN, [Optional] object KGJPBGICHFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x22CD550", Offset = "0x22CC550", VA = "0x1822CD550")]
		public bool BDIFMCBODED(PHJBPPLEHIN NHKKBKKOJJM, object KGJPBGICHFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x22CE740", Offset = "0x22CD740", VA = "0x1822CE740")]
		public bool HBOLAEKKJIO(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x22CE7F0", Offset = "0x22CD7F0", VA = "0x1822CE7F0")]
		public bool HBOLAEKKJIO(PHJBPPLEHIN INGBFIDDJOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x22CD570", Offset = "0x22CC570", VA = "0x1822CD570")]
		public bool BDIFMCBODED(PHJBPPLEHIN INGBFIDDJOP, [Optional] object KGJPBGICHFN, bool MJIEEJJMIKK = false, bool EGHGJJPKADM = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x22CFCA0", Offset = "0x22CECA0", VA = "0x1822CFCA0")]
		public Transform NOMJMALOIDD(Entity CLCJGDKEGGN, [Optional] object KGJPBGICHFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x22CDC80", Offset = "0x22CCC80", VA = "0x1822CDC80")]
		public bool CEGPBCBCDIN(Entity CLCJGDKEGGN, out Transform BCLIDGMJFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x22CF9F0", Offset = "0x22CE9F0", VA = "0x1822CF9F0")]
		public PHJBPPLEHIN NGDCLNMLMAP(Entity CLCJGDKEGGN, [Optional] object KGJPBGICHFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x22CDF70", Offset = "0x22CCF70", VA = "0x1822CDF70")]
		public void DILGBHLLKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x22CF2F0", Offset = "0x22CE2F0", VA = "0x1822CF2F0")]
		public void KINPEOECEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x22CF640", Offset = "0x22CE640", VA = "0x1822CF640")]
		private void MEKGMLNMPKH(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x22CD500", Offset = "0x22CC500", VA = "0x1822CD500")]
		public PHJBPPLEHIN BDGKHCLLEOF(Entity CLCJGDKEGGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x22CEA40", Offset = "0x22CDA40", VA = "0x1822CEA40")]
		public void HDDMGGPKOMP(Entity CLCJGDKEGGN, object KGJPBGICHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x22CE820", Offset = "0x22CD820", VA = "0x1822CE820")]
		public bool HCAHFLNKCDN(Entity CLCJGDKEGGN, object KGJPBGICHFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x22CDEF0", Offset = "0x22CCEF0", VA = "0x1822CDEF0")]
		public bool CKEPOEKMENG(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x22D0650", Offset = "0x22CF650", VA = "0x1822D0650")]
		public bool PFFPPMPEKLJ(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x22D0660", Offset = "0x22CF660", VA = "0x1822D0660")]
		public bool PFFPPMPEKLJ(BBGEOMDADMJ BFJMCAAKMNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x22CE4C0", Offset = "0x22CD4C0", VA = "0x1822CE4C0")]
		private void EKMLLNLKCND(bool HILFNAAFBBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x22CE380", Offset = "0x22CD380", VA = "0x1822CE380")]
		private bool EELMLAFOKOC(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x22CDF00", Offset = "0x22CCF00", VA = "0x1822CDF00")]
		private PHJBPPLEHIN DHDIGFNHEIB(Entity CLCJGDKEGGN, object KGJPBGICHFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x22CDD50", Offset = "0x22CCD50", VA = "0x1822CDD50")]
		private PHJBPPLEHIN CIBIKKBJANK(Entity CLCJGDKEGGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x22CEF10", Offset = "0x22CDF10", VA = "0x1822CEF10")]
		private (Vector3, Quaternion, Vector3) ICDMMMPMOKH(Entity CLCJGDKEGGN)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x22D02F0", Offset = "0x22CF2F0", VA = "0x1822D02F0")]
		private void ONBBFNPPLJG(Entity CLCJGDKEGGN, DAGBJECOPFG FMMJPPJOKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x22CF150", Offset = "0x22CE150", VA = "0x1822CF150")]
		private void KEIBKBELDDM(KOHKPOMNCDA FCJPDBMFAED, PHJBPPLEHIN BOGFGFMBOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x22CEA50", Offset = "0x22CDA50", VA = "0x1822CEA50")]
		private void HEDFGHEIALI(PHJBPPLEHIN INGBFIDDJOP, Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x22D00D0", Offset = "0x22CF0D0", VA = "0x1822D00D0")]
		private void ODHMDAIGDOK(Entity CLCJGDKEGGN, PHJBPPLEHIN INGBFIDDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x22CE960", Offset = "0x22CD960", VA = "0x1822CE960")]
		private void HDAJNOEBOJP(Entity CLCJGDKEGGN, Transform BCLIDGMJFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x22CF120", Offset = "0x22CE120", VA = "0x1822CF120")]
		private KOHKPOMNCDA JKDIGGONOOM(Entity CLCJGDKEGGN)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x22D06C0", Offset = "0x22CF6C0", VA = "0x1822D06C0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x22CE190", Offset = "0x22CD190", VA = "0x1822CE190")]
		[CompilerGenerated]
		private void DLLEKBDMMOD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal static class IGGLLHAMFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x22E1590", Offset = "0x22E0590", VA = "0x1822E1590")]
	public static PHJBPPLEHIN NGDCLNMLMAP(this ObjectEmbodimentService PIKHCAFAOHP, KOHKPOMNCDA FCJPDBMFAED, [Optional] object KGJPBGICHFN)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[DOKDCAPODCB(PBFEFLGCHAA.Lifecycle)]
	[AJHJJBJAJKN(typeof(ObjectLifecycleService), new string[] { })]
	internal sealed class ObjectLifecycleService : JLLBLNFOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private GDEFGFJPJEE CBJNPEBBDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private ObjectEmbodimentService INGBFIDDJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private ObjectNetworkToLocalMapService KMJAKBJOIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityHierarchyChildren DGKOICOAPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ANFBMLMNOPH DJBJNOPKDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityHierarchyParents HEPFDPEAIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private FLOMMEIHADG OBMJBAOOPLF;

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		private EntityManager OLPNKMBFBCG
		{
			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x22D12F0", Offset = "0x22D02F0", VA = "0x1822D12F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<Entity, DAGBJECOPFG> LNCEKBPPJPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x22D0F90", Offset = "0x22CFF90", VA = "0x1822D0F90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x22D1460", Offset = "0x22D0460", VA = "0x1822D1460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<Entity> LEAEOMEIGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x22D1500", Offset = "0x22D0500", VA = "0x1822D1500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600099A")]
			[Cpp2IlInjected.Address(RVA = "0x22D0AA0", Offset = "0x22CFAA0", VA = "0x1822D0AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x22D1340", Offset = "0x22D0340", VA = "0x1822D1340", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x22D0A20", Offset = "0x22CFA20", VA = "0x1822D0A20")]
		public bool EFMFIFBCNEK(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x22D09C0", Offset = "0x22CF9C0", VA = "0x1822D09C0")]
		internal void EDOGCAFMHIF(Entity CLCJGDKEGGN, DAGBJECOPFG FMMJPPJOKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x22D0930", Offset = "0x22CF930", VA = "0x1822D0930")]
		public void DJOODIHFILB(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x22D0BE0", Offset = "0x22CFBE0", VA = "0x1822D0BE0")]
		public void IOLIAPLKMKF(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x22D0730", Offset = "0x22CF730", VA = "0x1822D0730")]
		private bool BMBFNKNBLNE(Entity CLCJGDKEGGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x22D0B40", Offset = "0x22CFB40", VA = "0x1822D0B40")]
		public void IIELMNGPPGF(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x22D12C0", Offset = "0x22D02C0", VA = "0x1822D12C0")]
		private void MHONPJDLENI(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x22D0D80", Offset = "0x22CFD80", VA = "0x1822D0D80")]
		private void KMHHOBONLPN(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x22D0C20", Offset = "0x22CFC20", VA = "0x1822D0C20")]
		private void JBIFPKBJENO(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x22D1030", Offset = "0x22D0030", VA = "0x1822D1030")]
		private void LHJPIPCOLFI(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[AJHJJBJAJKN(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.Embodiment)]
	internal sealed class ObjectNetworkToLocalMapService : JLLBLNFOFFK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private NativeHashMap<LEPNJELBIPF, Entity> DJCCHGLAJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private GDEFGFJPJEE CBJNPEBBDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private NPGLNNOGMJJ IPPOOBMDIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private EntityManager EFLHIHFKEDM;

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		internal NativeHashMap<LEPNJELBIPF, Entity> ONAKFCIIKAB
		{
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0x8F6A40", Offset = "0x8F5A40", VA = "0x1808F6A40")]
			get
			{
				return default(NativeHashMap<LEPNJELBIPF, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x22D1A70", Offset = "0x22D0A70", VA = "0x1822D1A70", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x22D1740", Offset = "0x22D0740", VA = "0x1822D1740", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x22D1A10", Offset = "0x22D0A10", VA = "0x1822D1A10")]
		public void MCOHOPDDOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x22D1830", Offset = "0x22D0830", VA = "0x1822D1830")]
		private KOHKPOMNCDA JKDIGGONOOM(Entity CLCJGDKEGGN)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x22D1860", Offset = "0x22D0860", VA = "0x1822D1860")]
		public KOHKPOMNCDA KMPFPHIPBGN(LEPNJELBIPF POJMBOCFKCO)
		{
			return default(KOHKPOMNCDA);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x22D15F0", Offset = "0x22D05F0", VA = "0x1822D15F0")]
		public LEPNJELBIPF BEPHKEGICMG(KOHKPOMNCDA FCJPDBMFAED)
		{
			return default(LEPNJELBIPF);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x22D17A0", Offset = "0x22D07A0", VA = "0x1822D17A0")]
		public void IEHKGPJAFFG(Entity CLCJGDKEGGN, LEPNJELBIPF POJMBOCFKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x22D1680", Offset = "0x22D0680", VA = "0x1822D1680")]
		public void DJJPKAJGFMI(Entity CLCJGDKEGGN, LEPNJELBIPF POJMBOCFKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x22D16E0", Offset = "0x22D06E0", VA = "0x1822D16E0")]
		public void DKJAOIHFCGG(Entity CLCJGDKEGGN, LEPNJELBIPF POJMBOCFKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x22D1940", Offset = "0x22D0940", VA = "0x1822D1940")]
		public void LAOCFGKPEFG(Entity CLCJGDKEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[DOKDCAPODCB(PBFEFLGCHAA.Prefabs)]
	[KBDAHOGMDPL(typeof(GDEFGFJPJEE))]
	[AJHJJBJAJKN(typeof(ObjectPrefabCreationService), new string[] { })]
	internal sealed class ObjectPrefabCreationService : LEAOBDOHKAG, ICFGAFHALNE, JLLBLNFOFFK, HLHBDIEKOND, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private GDEFGFJPJEE BICCGEMNLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private EHLHIDEMKGD IMKPBHPMIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private NPENDFHJAMB PCEDOAJPCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private ObjectNetworkToLocalMapService KMJAKBJOIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private ObjectLifecycleService HEPCCGNPEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private LENLHGELBJE LMDAFICOHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private DHEFEACOKOG FEEDEFAGFIM;

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public int LNGJEDOBDDD
		{
			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0x22D2340", Offset = "0x22D1340", VA = "0x1822D2340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "4")]
		public void LDGKFGFMALP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x22D20B0", Offset = "0x22D10B0", VA = "0x1822D20B0", Slot = "5")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x22D2290", Offset = "0x22D1290", VA = "0x1822D2290", Slot = "6")]
		public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x22D1D00", Offset = "0x22D0D00", VA = "0x1822D1D00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x22D1FF0", Offset = "0x22D0FF0", VA = "0x1822D1FF0")]
		private void PLIDHPCOPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x22D1BF0", Offset = "0x22D0BF0", VA = "0x1822D1BF0")]
		public void BBNLPGMHHMN(bool MJIEEJJMIKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x22D1FF0", Offset = "0x22D0FF0", VA = "0x1822D1FF0")]
		private void IILMPHAMECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x22D1BB0", Offset = "0x22D0BB0", VA = "0x1822D1BB0")]
		public Entity GFIIDEDDJDP(DAGBJECOPFG FMMJPPJOKHJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x22D1EC0", Offset = "0x22D0EC0", VA = "0x1822D1EC0")]
		public Entity GFIIDEDDJDP(DAGBJECOPFG FMMJPPJOKHJ, LEPNJELBIPF POJMBOCFKCO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x22D1B90", Offset = "0x22D0B90", VA = "0x1822D1B90")]
		public Entity ADKCLGNHFKO(DAGBJECOPFG FMMJPPJOKHJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x22D21F0", Offset = "0x22D11F0", VA = "0x1822D21F0")]
		public Entity NOOPGDGEFHO(LEPNJELBIPF POJMBOCFKCO, DAGBJECOPFG FMMJPPJOKHJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x22D1BB0", Offset = "0x22D0BB0", VA = "0x1822D1BB0")]
		public Entity AJLJIKOPIAK(DAGBJECOPFG FMMJPPJOKHJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x22D2070", Offset = "0x22D1070", VA = "0x1822D2070")]
		public Entity LMNIFMEEHLB()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x22D2020", Offset = "0x22D1020", VA = "0x1822D2020")]
		public Entity JLMKOLAGOCN(HHBAPNOMDDB GLKKDGLKBMK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x22D1CB0", Offset = "0x22D0CB0", VA = "0x1822D1CB0")]
		public Entity BCMPONPKHEH(DGJNFBKJHDF GLKKDGLKBMK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x22D1F60", Offset = "0x22D0F60", VA = "0x1822D1F60")]
		public NativeArray<(KOHKPOMNCDA, KOHKPOMNCDA)> GFIIDEDDJDP(NativeArray<KOHKPOMNCDA> HPLGMMOLONA, Allocator LKNIKCJFBFH)
		{
			return default(NativeArray<(KOHKPOMNCDA, KOHKPOMNCDA)>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x22D2320", Offset = "0x22D1320", VA = "0x1822D2320")]
		public IEnumerable<DAGBJECOPFG> PCFJHPAGPEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x22D1FD0", Offset = "0x22D0FD0", VA = "0x1822D1FD0")]
		public EntityArchetype HGKPBAHOLGG(DAGBJECOPFG FMMJPPJOKHJ)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x22D1FB0", Offset = "0x22D0FB0", VA = "0x1822D1FB0")]
		public Entity GHFJJHKCFBD(DAGBJECOPFG FMMJPPJOKHJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x22D1DB0", Offset = "0x22D0DB0", VA = "0x1822D1DB0")]
		private Entity FCMOMKEGIAC(DAGBJECOPFG FMMJPPJOKHJ, LEPNJELBIPF POJMBOCFKCO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ObjectPrefabCreationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal class LENLHGELBJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class HNHGFDJICIH : IEnumerable<(HHBAPNOMDDB, DAGBJECOPFG)>, IEnumerable, IEnumerator<(HHBAPNOMDDB, DAGBJECOPFG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private (HHBAPNOMDDB primitiveType, DAGBJECOPFG prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public LENLHGELBJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		private (HHBAPNOMDDB, DAGBJECOPFG) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0xF86930", Offset = "0xF85930", VA = "0x180F86930", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((HHBAPNOMDDB, DAGBJECOPFG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x22DEBD0", Offset = "0x22DDBD0", VA = "0x1822DEBD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x22DEC20", Offset = "0x22DDC20", VA = "0x1822DEC20")]
		[DebuggerHidden]
		public HNHGFDJICIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x22DE9F0", Offset = "0x22DD9F0", VA = "0x1822DE9F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x22DEB80", Offset = "0x22DDB80", VA = "0x1822DEB80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x22DEAE0", Offset = "0x22DDAE0", VA = "0x1822DEAE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(HHBAPNOMDDB, DAGBJECOPFG)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x22DEAE0", Offset = "0x22DDAE0", VA = "0x1822DEAE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private readonly World BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private readonly Dictionary<DAGBJECOPFG, Entity> LMDAFICOHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private readonly Dictionary<DAGBJECOPFG, EntityArchetype> MDANCMHCAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly Dictionary<HHBAPNOMDDB, DAGBJECOPFG> DLKNAIGJALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private readonly Dictionary<DGJNFBKJHDF, DAGBJECOPFG> BKCEIDNKHMF;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x14BDFF0", Offset = "0x14BCFF0", VA = "0x1814BDFF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x22EFA20", Offset = "0x22EEA20", VA = "0x1822EFA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x22F0440", Offset = "0x22EF440", VA = "0x1822F0440")]
	public LENLHGELBJE(World BICCGEMNLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x22EF590", Offset = "0x22EE590", VA = "0x1822EF590")]
	private void JGPFGJOMHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x22EBE00", Offset = "0x22EAE00", VA = "0x1822EBE00")]
	private void ACBDLIIKAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x22EFB00", Offset = "0x22EEB00", VA = "0x1822EFB00")]
	private void PKPPKCBHCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x22EF4B0", Offset = "0x22EE4B0", VA = "0x1822EF4B0")]
	private NEJDHDHACEE INGDHFGJFNK()
	{
		return default(NEJDHDHACEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x3483920", Offset = "0x3482920", VA = "0x183483920")]
	private void HKMBMJNHPGM<T>(DAGBJECOPFG FMMJPPJOKHJ, NEJDHDHACEE GDAAIMGFJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x22EEFA0", Offset = "0x22EDFA0", VA = "0x1822EEFA0")]
	private void HKMBMJNHPGM(DAGBJECOPFG FMMJPPJOKHJ, NEJDHDHACEE GDAAIMGFJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x22ED830", Offset = "0x22EC830", VA = "0x1822ED830")]
	public void BBNLPGMHHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x22EEF40", Offset = "0x22EDF40", VA = "0x1822EEF40")]
	public EntityArchetype HGKPBAHOLGG(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x22EF520", Offset = "0x22EE520", VA = "0x1822EF520")]
	[IteratorStateMachine(typeof(HNHGFDJICIH))]
	private IEnumerable<(HHBAPNOMDDB, DAGBJECOPFG)> IPOCCBFILGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x22EEAB0", Offset = "0x22EDAB0", VA = "0x1822EEAB0")]
	public Entity GFIIDEDDJDP(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x22EEEE0", Offset = "0x22EDEE0", VA = "0x1822EEEE0")]
	public DAGBJECOPFG GPKCJONBIJA(DGJNFBKJHDF GLKKDGLKBMK)
	{
		return default(DAGBJECOPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x22EEE80", Offset = "0x22EDE80", VA = "0x1822EEE80")]
	public DAGBJECOPFG GPKCJONBIJA(HHBAPNOMDDB GLKKDGLKBMK)
	{
		return default(DAGBJECOPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x22EED40", Offset = "0x22EDD40", VA = "0x1822EED40")]
	private Entity GKGGMGEMEBL()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x22EF7C0", Offset = "0x22EE7C0", VA = "0x1822EF7C0")]
	private Entity LJIMJLBGEPH()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x22EE570", Offset = "0x22ED570", VA = "0x1822EE570")]
	private Entity DCBMODNNLCN()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x22EE480", Offset = "0x22ED480", VA = "0x1822EE480")]
	private Entity CKIFNOGKEPH()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x22EF750", Offset = "0x22EE750", VA = "0x1822EF750")]
	private Entity LAENMHAIKDL()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x22EE610", Offset = "0x22ED610", VA = "0x1822EE610")]
	private Entity DNEPKKEIHLP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x22EEC10", Offset = "0x22EDC10", VA = "0x1822EEC10")]
	private Entity GJOGMCPHFPJ(HHBAPNOMDDB PEPADDNLHDC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x22EEDE0", Offset = "0x22EDDE0", VA = "0x1822EEDE0")]
	private Entity GMMDMGLIANI(DGJNFBKJHDF GLKKDGLKBMK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x22EF270", Offset = "0x22EE270", VA = "0x1822EF270")]
	private Entity ICBDEPDAHNK()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x22EF6B0", Offset = "0x22EE6B0", VA = "0x1822EF6B0")]
	private void KJKKPICGNHG(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x22EF280", Offset = "0x22EE280", VA = "0x1822EF280")]
	private void INCMOCLDBID(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x22EE750", Offset = "0x22ED750", VA = "0x1822EE750")]
	private void DONCMPGNKFI(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x22ED690", Offset = "0x22EC690", VA = "0x1822ED690")]
	private Entity AJLJIKOPIAK(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x22EF5B0", Offset = "0x22EE5B0", VA = "0x1822EF5B0")]
	private Entity JMOFDKCLABD(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x3484460", Offset = "0x3483460", VA = "0x183484460")]
	private void OOKFDACILAM<T>(Entity CLCJGDKEGGN, T JNLOLNFALGF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x22ED600", Offset = "0x22EC600", VA = "0x1822ED600")]
	private Entity ADKCLGNHFKO(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x22EFA70", Offset = "0x22EEA70", VA = "0x1822EFA70")]
	private Entity PBHCAEJBJOO()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x22EF920", Offset = "0x22EE920", VA = "0x1822EF920")]
	private Entity OGEJANIFOHF()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x22EF960", Offset = "0x22EE960", VA = "0x1822EF960")]
	private Entity OKFKHFLIHLP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x22EF860", Offset = "0x22EE860", VA = "0x1822EF860")]
	private Entity NCCLJLBOMIG()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x22EF060", Offset = "0x22EE060", VA = "0x1822EF060")]
	private void IACMGLDGBJB(Entity CLCJGDKEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x22EE930", Offset = "0x22ED930", VA = "0x1822EE930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x22EFAB0", Offset = "0x22EEAB0", VA = "0x1822EFAB0")]
	public IEnumerable<DAGBJECOPFG> PCFJHPAGPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x22EEBB0", Offset = "0x22EDBB0", VA = "0x1822EEBB0")]
	public Entity GHFJJHKCFBD(DAGBJECOPFG FMMJPPJOKHJ)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[AJHJJBJAJKN(typeof(PropertyEventCallbacksService), new string[] { })]
	[DOKDCAPODCB(PBFEFLGCHAA.Callbacks)]
	public class PropertyEventCallbacksService : JLLBLNFOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		private struct OLKHPNCJHFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			public AGLHAMPKGHG PCMFICPIFCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			public Type GLKKDGLKBMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public int CCDDIFMMPAN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		private struct NAKPICAJPHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public OLKHPNCJHFD[] BIPGBCJBJEE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000177")]
		public delegate void AGLHAMPKGHG(Entity CLCJGDKEGGN, IHCHEEIIPON FANBLFBADKJ, JHBOMEIKHGC GDKBIPOIHPF, JHBOMEIKHGC NJCJINFAHGL);

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private static readonly LOBJLOAJGBA NMFPNEPNNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private readonly Dictionary<IHCHEEIIPON, AGLHAMPKGHG> LCKLHIPGJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private readonly Dictionary<int, NAKPICAJPHO> CCLPEEAJHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private ONNFHGLOINK BIPGBCJBJEE;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action ALGKKILMJDC
		{
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0x22D5FD0", Offset = "0x22D4FD0", VA = "0x1822D5FD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0x22D6150", Offset = "0x22D5150", VA = "0x1822D6150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action PBACBOFIMOL
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0x22D5F30", Offset = "0x22D4F30", VA = "0x1822D5F30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0x22D61F0", Offset = "0x22D51F0", VA = "0x1822D61F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x22D6F90", Offset = "0x22D5F90", VA = "0x1822D6F90", Slot = "4")]
		public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x22D6290", Offset = "0x22D5290", VA = "0x1822D6290")]
		public void HCCDLMMPDLB(IHCHEEIIPON FANBLFBADKJ, AGLHAMPKGHG PCMFICPIFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x22D6400", Offset = "0x22D5400", VA = "0x1822D6400")]
		public void ILAEOHFEJHN(IHCHEEIIPON FANBLFBADKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x22D64E0", Offset = "0x22D54E0", VA = "0x1822D64E0")]
		internal void IPCHABHAMHC(EDGAKEAHJHK LKOJKOJNBBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x22D6720", Offset = "0x22D5720", VA = "0x1822D6720")]
		private void JKMEMKOFCML(EDGAKEAHJHK LKOJKOJNBBK, int KICCJKJLKLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x22D6D60", Offset = "0x22D5D60", VA = "0x1822D6D60")]
		private void NBLAMDJFBCE(FOHAFCOAAJF EDJOONFFAPI, ENCFKNPILEO FBPPOIAOPNL, OLKHPNCJHFD HBCAHJCPCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x22D6C10", Offset = "0x22D5C10", VA = "0x1822D6C10")]
		private NAKPICAJPHO LDIDICNLOHE(FOHAFCOAAJF EDJOONFFAPI, ENCFKNPILEO FBPPOIAOPNL)
		{
			return default(NAKPICAJPHO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x22D6070", Offset = "0x22D5070", VA = "0x1822D6070")]
		private OLKHPNCJHFD EAJOAKILEKD(NAKPICAJPHO IACKKMEKEAC, FOHAFCOAAJF EDJOONFFAPI, ENCFKNPILEO FBPPOIAOPNL)
		{
			return default(OLKHPNCJHFD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x22D7040", Offset = "0x22D6040", VA = "0x1822D7040")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[AJHJJBJAJKN(typeof(EKJPKEGGEPL), new string[] { })]
public class JDKLGCKLMKM : JLLBLNFOFFK, HLHBDIEKOND, EKJPKEGGEPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class IEJPKKCODPK : IEnumerable<BCAIICIPIPG>, IEnumerable, IEnumerator<BCAIICIPIPG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private BCAIICIPIPG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public JDKLGCKLMKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private HAKGILMIHPD spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public HAKGILMIHPD <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		private BCAIICIPIPG System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A23")]
			[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(BCAIICIPIPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x22E1400", Offset = "0x22E0400", VA = "0x1822E1400", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7D0", Offset = "0xA0D7D0", VA = "0x180A0E7D0")]
		[DebuggerHidden]
		public IEJPKKCODPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x22E11B0", Offset = "0x22E01B0", VA = "0x1822E11B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x22E13B0", Offset = "0x22E03B0", VA = "0x1822E13B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x22E1300", Offset = "0x22E0300", VA = "0x1822E1300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BCAIICIPIPG> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x22E1300", Offset = "0x22E0300", VA = "0x1822E1300", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private PBIPDKNMPEO LBHDAFOOBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private ObjectPrefabCreationService LMDAFICOHNG;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private EntityManager OLPNKMBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x22E76B0", Offset = "0x22E66B0", VA = "0x1822E76B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private PHHIOCMBCOD NOINFEGLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x22E6B90", Offset = "0x22E5B90", VA = "0x1822E6B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x22E7750", Offset = "0x22E6750", VA = "0x1822E7750", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x22E78F0", Offset = "0x22E68F0", VA = "0x1822E78F0", Slot = "5")]
	public void ONDODEKDAFD(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x22E6CE0", Offset = "0x22E5CE0", VA = "0x1822E6CE0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x22E73F0", Offset = "0x22E63F0", VA = "0x1822E73F0")]
	private void LIDDCEPJHJN(Entity LGFHNHKPPLC, in JHBOMEIKHGC LONPLGOFNDA, in JHBOMEIKHGC CACEPBECNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x22E7620", Offset = "0x22E6620", VA = "0x1822E7620", Slot = "12")]
	public HAKGILMIHPD LMNIFMEEHLB()
	{
		return default(HAKGILMIHPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x22E6E20", Offset = "0x22E5E20", VA = "0x1822E6E20", Slot = "6")]
	public BCAIICIPIPG HNJGEHJOOKC(HAKGILMIHPD APJCEDCLHME, [Optional] Vector3? IPACGOANALG, [Optional] Quaternion? DJCGMNLFLIO, [Optional] Vector3? HNIGCGIKFFA)
	{
		return default(BCAIICIPIPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x22E7700", Offset = "0x22E6700", VA = "0x1822E7700", Slot = "13")]
	public BCAIICIPIPG NFEJPENGFNH(HAKGILMIHPD APJCEDCLHME, int IIHEDPBOLFE, [Optional] Vector3? IPACGOANALG, [Optional] Quaternion? DJCGMNLFLIO, [Optional] Vector3? HNIGCGIKFFA)
	{
		return default(BCAIICIPIPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x22E77D0", Offset = "0x22E67D0", VA = "0x1822E77D0", Slot = "7")]
	public BCAIICIPIPG OAIKJDGAHLG(HAKGILMIHPD APJCEDCLHME, int IIHEDPBOLFE)
	{
		return default(BCAIICIPIPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x22E6C50", Offset = "0x22E5C50", VA = "0x1822E6C50", Slot = "14")]
	public void DJLGMPGIHNK(HAKGILMIHPD APJCEDCLHME, BCAIICIPIPG PJAFDIPMCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x22E79B0", Offset = "0x22E69B0", VA = "0x1822E79B0", Slot = "8")]
	public void PHNNIGJMPEG(HAKGILMIHPD APJCEDCLHME, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x22E71D0", Offset = "0x22E61D0", VA = "0x1822E71D0", Slot = "15")]
	public void KKFOKJPCCFI(HAKGILMIHPD APJCEDCLHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x22E6AF0", Offset = "0x22E5AF0", VA = "0x1822E6AF0", Slot = "9")]
	public int BCLNIGMGPKG(HAKGILMIHPD APJCEDCLHME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x22E7360", Offset = "0x22E6360", VA = "0x1822E7360", Slot = "10")]
	[IteratorStateMachine(typeof(IEJPKKCODPK))]
	public IEnumerable<BCAIICIPIPG> LCACAAIKNNJ(HAKGILMIHPD APJCEDCLHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x22E7140", Offset = "0x22E6140", VA = "0x1822E7140")]
	private bool KKBJOLNPFAL(HAKGILMIHPD APJCEDCLHME, out NativeArray<Entity> DGKOICOAPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x22E6D70", Offset = "0x22E5D70", VA = "0x1822E6D70")]
	private NativeArray<Entity> HEIOHMPDCPI(HAKGILMIHPD APJCEDCLHME)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public JDKLGCKLMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[AJHJJBJAJKN(typeof(AEIBKDJMAOL), new string[] { })]
internal sealed class AEIBKDJMAOL : JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private GDEFGFJPJEE BICCGEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private TransformOwnershipPhase KOCJCDHCNAO;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private IEPEPKBAJCN NGCBAEGEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x244B6D0", Offset = "0x244A6D0", VA = "0x18244B6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x244B850", Offset = "0x244A850", VA = "0x18244B850", Slot = "4")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x244B720", Offset = "0x244A720", VA = "0x18244B720")]
	public void LHOBKPMPBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x244B490", Offset = "0x244A490", VA = "0x18244B490")]
	public void DDGNFDKIGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AEIBKDJMAOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[DefaultMember("Item")]
public struct NOIOPDLIFLL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private T[] JEJGBICCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private int BPGPLFOLHKN;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x8A44B0", Offset = "0x8A34B0", VA = "0x1808A44B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x2179A60", Offset = "0x2178A60", VA = "0x182179A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Span<T> CHAELBBCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x26F7720", Offset = "0x26F6720", VA = "0x1826F7720")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool LNHKEACDENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xBBA190", Offset = "0xBB9190", VA = "0x180BBA190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x26F77C0", Offset = "0x26F67C0", VA = "0x1826F77C0")]
	public NOIOPDLIFLL(int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x26F7670", Offset = "0x26F6670", VA = "0x1826F7670")]
	public int HDJBEKJPMMO(T JNLOLNFALGF, int HNIIDPMJKFI, int FBKJALIBHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x26F75B0", Offset = "0x26F65B0", VA = "0x1826F75B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[DefaultMember("Item")]
public struct AMCHCACJNKI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private global::NOIOPDLIFLL<T> JEJGBICCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private int BPGPLFOLHKN;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public T AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x451B980", Offset = "0x451A980", VA = "0x18451B980")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public int PFBDFFJNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x5E5ED0", Offset = "0x5E4ED0", VA = "0x1805E5ED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x451BF40", Offset = "0x451AF40", VA = "0x18451BF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public int OHMIEBEANAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x451B6A0", Offset = "0x451A6A0", VA = "0x18451B6A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x451AEA0", Offset = "0x4519EA0", VA = "0x18451AEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool LNHKEACDENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x451C0E0", Offset = "0x451B0E0", VA = "0x18451C0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Span<T> CHAELBBCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x451BE70", Offset = "0x451AE70", VA = "0x18451BE70")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x451C630", Offset = "0x451B630", VA = "0x18451C630")]
	public AMCHCACJNKI(int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x451B310", Offset = "0x451A310", VA = "0x18451B310")]
	public T DNAPBFPIECF(int IIHEDPBOLFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x451BC90", Offset = "0x451AC90", VA = "0x18451BC90")]
	public void LFEEBAHHPIK(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x451BB30", Offset = "0x451AB30", VA = "0x18451BB30")]
	public void KOGFHBHDNKN(Span<T> DMCFFMAPNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x451C4C0", Offset = "0x451B4C0", VA = "0x18451C4C0")]
	public void PPCBFHPPBHE(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x451C120", Offset = "0x451B120", VA = "0x18451C120")]
	private void NFNNMELDPNK(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x451B760", Offset = "0x451A760", VA = "0x18451B760")]
	public void HHLMDLEANMN(Span<T> OOEEMCHEMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x451B920", Offset = "0x451A920", VA = "0x18451B920")]
	public void HKPICNAJIKC(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x451B100", Offset = "0x451A100", VA = "0x18451B100")]
	public void DKOLINGLJKF(int HLNHMDLJFNN, int MOCOMOOJDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x451BD00", Offset = "0x451AD00", VA = "0x18451BD00")]
	public void LPJGPILEEAO(int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x451C2C0", Offset = "0x451B2C0", VA = "0x18451C2C0")]
	public void PFILIDLDHOE(int HLNHMDLJFNN, int MOCOMOOJDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x451B520", Offset = "0x451A520", VA = "0x18451B520")]
	public void FDFHGOANEEH(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x451B5E0", Offset = "0x451A5E0", VA = "0x18451B5E0")]
	public void GNEOBEIJMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x451B6D0", Offset = "0x451A6D0", VA = "0x18451B6D0")]
	public int HDJBEKJPMMO(T JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x451B4C0", Offset = "0x451A4C0", VA = "0x18451B4C0")]
	public bool FAFGFNINKJO(T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x451B360", Offset = "0x451A360", VA = "0x18451B360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x451C5D0", Offset = "0x451B5D0", VA = "0x18451C5D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x451AEF0", Offset = "0x4519EF0", VA = "0x18451AEF0")]
	public static Span<T> BNLFJABIBKP(global::AMCHCACJNKI<T> DMCFFMAPNPG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x451BD60", Offset = "0x451AD60", VA = "0x18451BD60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void MAGGFPKDEIH(int JNLOLNFALGF, int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void MGMMFJBKHJK(int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x451BF90", Offset = "0x451AF90", VA = "0x18451BF90")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void MGMMFJBKHJK(int BPGPLFOLHKN, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x451BA20", Offset = "0x451AA20", VA = "0x18451BA20")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void KNGEADNBJCH(int JNLOLNFALGF, int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x451AF60", Offset = "0x4519F60", VA = "0x18451AF60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void DDHCLJAGDIB(int HLNHMDLJFNN, int MOCOMOOJDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x451B3B0", Offset = "0x451A3B0", VA = "0x18451B3B0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void EIJGEIEAFDO(int JNLOLNFALGF, int BPGPLFOLHKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public struct DJGBCAKLMIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private const int PKNGMBEKKMJ = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private NativeList<Entity> AFOGFGIBNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private TransformAccessArray BDOHHFJFLIM;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int HJCHDLKJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x2459190", Offset = "0x2458190", VA = "0x182459190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public NativeList<Entity> DAIGBJINOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xB54810", Offset = "0xB53810", VA = "0x180B54810")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public TransformAccessArray AHMFFFANKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x24592E0", Offset = "0x24582E0", VA = "0x1824592E0")]
	public DJGBCAKLMIB(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x2459140", Offset = "0x2458140", VA = "0x182459140")]
	public Entity MIMHNJENPFN(int IIHEDPBOLFE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2459130", Offset = "0x2458130", VA = "0x182459130")]
	public Transform IEDINKEFEBC(int IIHEDPBOLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2458FB0", Offset = "0x2457FB0", VA = "0x182458FB0")]
	public void CONMIHOMDPL(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x24591A0", Offset = "0x24581A0", VA = "0x1824591A0")]
	public void PAPGLMGIAJH(int OBIONPKHBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2459210", Offset = "0x2458210", VA = "0x182459210")]
	public int PPCBFHPPBHE(Transform BCLIDGMJFFC, Entity CLCJGDKEGGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x24590B0", Offset = "0x24580B0", VA = "0x1824590B0")]
	public int HKPICNAJIKC(int IIHEDPBOLFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2459040", Offset = "0x2458040", VA = "0x182459040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x2459000", Offset = "0x2458000", VA = "0x182459000")]
	private void DAMNAKBFECK(int KGFMGFMCGGM = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class ALGKAKMLBBF
{
	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	public static void OKOOBBGMCIM(in Vector3 IPACGOANALG, in Quaternion DJCGMNLFLIO, in Vector3 HNIGCGIKFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	public static void PLMJJDANLDN(in Vector3 BLGOFDKLMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	public static void OKDIIHDBCOH(in Quaternion DJCGMNLFLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	public static void GNHEIJPBJPG(in Vector3 OGGGCLAKCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	public static void OJJCAKCOBCP(in Vector3 OGGGCLAKCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	public static void IPKGKJMJECF(in float MAPAIJEJCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x244C920", Offset = "0x244B920", VA = "0x18244C920")]
	[Conditional("DEBUG_BUILD")]
	public static void AJBBMPMOCNB(in float3 JNLOLNFALGF, string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80")]
	[Conditional("DEBUG_BUILD")]
	public static void HNCELLDJHBG(in float JNLOLNFALGF, string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x244CA50", Offset = "0x244BA50", VA = "0x18244CA50")]
	[Conditional("DEBUG_BUILD")]
	public static void HNCELLDJHBG(in Vector3 JNLOLNFALGF, string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x244C9C0", Offset = "0x244B9C0", VA = "0x18244C9C0")]
	[Conditional("DEBUG_BUILD")]
	public static void HNCELLDJHBG(in Quaternion JNLOLNFALGF, string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x244CAF0", Offset = "0x244BAF0", VA = "0x18244CAF0")]
	[Conditional("DEBUG_BUILD")]
	public static void JKIMBNNFIFN(in float JNLOLNFALGF, string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x244CB00", Offset = "0x244BB00", VA = "0x18244CB00")]
	[Conditional("DEBUG_BUILD")]
	public static void JKIMBNNFIFN(in Vector3 JNLOLNFALGF, string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x244CBA0", Offset = "0x244BBA0", VA = "0x18244CBA0")]
	[Conditional("DEBUG_BUILD")]
	public static void JKIMBNNFIFN(in Quaternion JNLOLNFALGF, string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public ALGKAKMLBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public struct CCHFFBLEBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public Entity CLCJGDKEGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public Entity ACNNFDIAAFM;

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0xDB5450", Offset = "0xDB4450", VA = "0x180DB5450")]
	public CCHFFBLEBPJ(Entity CLCJGDKEGGN, Entity ACNNFDIAAFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2454090", Offset = "0x2453090", VA = "0x182454090")]
	public static CCHFFBLEBPJ BNLFJABIBKP((Entity entity, Entity parent) INEHEKAAELB)
	{
		return default(CCHFFBLEBPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x24540C0", Offset = "0x24530C0", VA = "0x1824540C0")]
	public void BOOMLLPLBBD(out Entity CLCJGDKEGGN, out Entity ACNNFDIAAFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
public struct LBFIEJNKNNI<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private GCHandle BFJMCAAKMNM;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool FHHLFEMDIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x244CCF0", Offset = "0x244BCF0", VA = "0x18244CCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public T GFNFCEIHNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x27BD2B0", Offset = "0x27BC2B0", VA = "0x1827BD2B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x27BD350", Offset = "0x27BC350", VA = "0x1827BD350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x27BD410", Offset = "0x27BC410", VA = "0x1827BD410")]
	public LBFIEJNKNNI(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x27BD280", Offset = "0x27BC280", VA = "0x1827BD280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(IKBMIHCLLIH))]
public sealed class CHJLEDAHPHC : OKKGBHGJFIN
{
	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public CHJLEDAHPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(CHJLEDAHPHC))]
[UpdateInGroup(typeof(IKBMIHCLLIH))]
public sealed class GAALFKBAGNB : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x245C100", Offset = "0x245B100", VA = "0x18245C100")]
	public GAALFKBAGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(GAALFKBAGNB))]
[UpdateInGroup(typeof(IKBMIHCLLIH))]
public sealed class ACLPMCHNFAD : IALODPIJKHN
{
	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public ACLPMCHNFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(CCNMIHFOHMJ))]
public class OAEDPGGJPEL : DCOFONOICPD
{
	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public OAEDPGGJPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x25EBD00", Offset = "0x25EAD00", VA = "0x1825EBD00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(CCNMIHFOHMJ))]
public class ANPAMHAIKDE : HMDDDELJFLA
{
	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public ANPAMHAIKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(CCNMIHFOHMJ))]
public class JGLNPPJHCMP : DDFGJHCADGD
{
	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public JGLNPPJHCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x22E7E50", Offset = "0x22E6E50", VA = "0x1822E7E50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(DCLDLNCMNEO))]
public sealed class HBKOFHDAKHM : BGJCOMLOHGP
{
	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x22DCD40", Offset = "0x22DBD40", VA = "0x1822DCD40")]
	public HBKOFHDAKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x22DCD30", Offset = "0x22DBD30", VA = "0x1822DCD30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(HIEOEELOHKH))]
public class FLOMMEIHADG : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x245C030", Offset = "0x245B030", VA = "0x18245C030")]
	public FLOMMEIHADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(FLOMMEIHADG))]
[UpdateInGroup(typeof(HIEOEELOHKH))]
public class NHEKMCAKJHK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public NHEKMCAKJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(HFPPAPLEJNE))]
public class EIMJJADKCDP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public EIMJJADKCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(EIMJJADKCDP))]
[UpdateInGroup(typeof(HFPPAPLEJNE))]
public class DKGKPAFPFCF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public DKGKPAFPFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(DKGKPAFPFCF))]
[UpdateBefore(typeof(EEBLENFIINC))]
public sealed class DBDEDJGCBGE : GJLCGEPDLGF
{
	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public DBDEDJGCBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x24567B0", Offset = "0x24557B0", VA = "0x1824567B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(DKGKPAFPFCF))]
public sealed class EEBLENFIINC : BGJCOMLOHGP
{
	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x24525D0", Offset = "0x24515D0", VA = "0x1824525D0")]
	public EEBLENFIINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x2452550", Offset = "0x2451550", VA = "0x182452550", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(NHEKMCAKJHK))]
public sealed class ILCFNOKAACJ : IENHCMAHPFK
{
	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x22E1550", Offset = "0x22E0550", VA = "0x1822E1550")]
	public ILCFNOKAACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x22E14D0", Offset = "0x22E04D0", VA = "0x1822E14D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(NHEKMCAKJHK))]
public sealed class EADGIEGJJEJ : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x2459800", Offset = "0x2458800", VA = "0x182459800")]
	public EADGIEGJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x24597F0", Offset = "0x24587F0", VA = "0x1824597F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(EADGIEGJJEJ))]
[UpdateInGroup(typeof(NHEKMCAKJHK))]
public sealed class GKIAMNFIFJH : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x22DBBE0", Offset = "0x22DABE0", VA = "0x1822DBBE0")]
	public GKIAMNFIFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(JMIFGHAHEAD))]
public class EEFLBLFCBMJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public EEFLBLFCBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(JMIFGHAHEAD))]
public class ICAGAIOEHFK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public ICAGAIOEHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[ExecuteAlways]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(JMIFGHAHEAD))]
[UpdateAfter(typeof(EEFLBLFCBMJ))]
public sealed class MDOEFBGADHB : DAOOMKALOAB
{
	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public MDOEFBGADHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[AlwaysUpdateSystem]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(ICAGAIOEHFK))]
public sealed class KLNCCKOAHLG : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000155")]
	protected override ApplyPropertyDifferences JCPNKCPAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x22EAE50", Offset = "0x22E9E50", VA = "0x1822EAE50", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x22EAEA0", Offset = "0x22E9EA0", VA = "0x1822EAEA0")]
	public KLNCCKOAHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(ICAGAIOEHFK))]
[UpdateAfter(typeof(KLNCCKOAHLG))]
public sealed class HDHKNHNAEPB : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x22DCD50", Offset = "0x22DBD50", VA = "0x1822DCD50")]
	public HDHKNHNAEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(KLNCCKOAHLG))]
[UpdateInGroup(typeof(ICAGAIOEHFK))]
public sealed class GPNGJJBHNBN : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public GPNGJJBHNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(GPNGJJBHNBN))]
[UpdateInGroup(typeof(ICAGAIOEHFK))]
public sealed class DADAANKBKHH : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x17000156")]
	protected override ComputePropertyDifferences BNHJNHHEHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x24554A0", Offset = "0x24544A0", VA = "0x1824554A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x24554F0", Offset = "0x24544F0", VA = "0x1824554F0")]
	public DADAANKBKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(DADAANKBKHH))]
[UpdateInGroup(typeof(ICAGAIOEHFK))]
public sealed class EIFNJJGJKAK : GFEBIFMBKJM
{
	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x245A090", Offset = "0x2459090", VA = "0x18245A090")]
	public EIFNJJGJKAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(EEFLBLFCBMJ))]
public sealed class LNNMEGDIHNO : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x25E5590", Offset = "0x25E4590", VA = "0x1825E5590")]
	public LNNMEGDIHNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(EEFLBLFCBMJ))]
public sealed class EJENHLNMDPN : AKBGOFJIOLG
{
	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public EJENHLNMDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(HFPPAPLEJNE))]
public class KDCJODCNLJI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public KDCJODCNLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(HFPPAPLEJNE))]
[UpdateAfter(typeof(KDCJODCNLJI))]
public sealed class FNLBDECPKIN : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x245C0A0", Offset = "0x245B0A0", VA = "0x18245C0A0")]
	public FNLBDECPKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x245C090", Offset = "0x245B090", VA = "0x18245C090", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(HFPPAPLEJNE))]
[UpdateAfter(typeof(KDCJODCNLJI))]
public sealed class DMEHIFMGECK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public DMEHIFMGECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(DMEHIFMGECK))]
public sealed class BDPAPJAEFHB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public BDPAPJAEFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[ILJNJGIAJDG]
[ExecuteAlways]
[UpdateInGroup(typeof(DMEHIFMGECK))]
[UpdateAfter(typeof(BDPAPJAEFHB))]
public sealed class EKJFOKLAGDL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public EKJFOKLAGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(EKJFOKLAGDL))]
public sealed class HGDOOBFLLLK : ODIKDGGGNGA
{
	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public HGDOOBFLLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0F0", Offset = "0x22DD0F0", VA = "0x1822DE0F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(HGDOOBFLLLK))]
[UpdateInGroup(typeof(EKJFOKLAGDL))]
public sealed class GFKKDPNGMPJ : PJCKOKPEOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public GFKKDPNGMPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x245D2B0", Offset = "0x245C2B0", VA = "0x18245D2B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(EKJFOKLAGDL))]
[UpdateAfter(typeof(GFKKDPNGMPJ))]
public sealed class PBMNKPBJKJA : AGHMBCKDBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public PBMNKPBJKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(PBMNKPBJKJA))]
[UpdateInGroup(typeof(EKJFOKLAGDL))]
public class MOMNOEGBKDF : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x25E8920", Offset = "0x25E7920", VA = "0x1825E8920")]
	public MOMNOEGBKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(BDPAPJAEFHB))]
public sealed class APIGJGDCMDI : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x244DC40", Offset = "0x244CC40", VA = "0x18244DC40")]
	public APIGJGDCMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KDCJODCNLJI))]
public sealed class FGCPHABOEPL : PBMEFFDIIFI
{
	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public FGCPHABOEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(FGCPHABOEPL))]
[UpdateInGroup(typeof(KDCJODCNLJI))]
public sealed class NJANFBFKPCL : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x25EB8B0", Offset = "0x25EA8B0", VA = "0x1825EB8B0")]
	public NJANFBFKPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KDCJODCNLJI))]
[UpdateAfter(typeof(FGCPHABOEPL))]
public sealed class AMOICBFIDGE : OEBDNIEEBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public AMOICBFIDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(NJANFBFKPCL))]
[UpdateAfter(typeof(AMOICBFIDGE))]
[UpdateInGroup(typeof(KDCJODCNLJI))]
public sealed class EJCAGNPOGNI : KCDOKNODIKK
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public EJCAGNPOGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[ExecuteAlways]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(PresentationSystemGroup))]
public sealed class KAGBBIADBCD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x22DE0E0", Offset = "0x22DD0E0", VA = "0x1822DE0E0")]
	public KAGBBIADBCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class FHGPOKBDBAK : LBFPOHBOKCM
{
	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x245BF00", Offset = "0x245AF00", VA = "0x18245BF00")]
	public FHGPOKBDBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KAGBBIADBCD))]
[UpdateAfter(typeof(FHGPOKBDBAK))]
public sealed class HFHLGANJAKF : DEPMJKCBLDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x22DE080", Offset = "0x22DD080", VA = "0x1822DE080")]
	public HFHLGANJAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
[AlwaysUpdateSystem]
[ILJNJGIAJDG]
[UpdateAfter(typeof(FHGPOKBDBAK))]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class ECPMBKNODBO : JCACEEJCKLD
{
	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x24598D0", Offset = "0x24588D0", VA = "0x1824598D0")]
	public ECPMBKNODBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x24598C0", Offset = "0x24588C0", VA = "0x1824598C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
[AlwaysUpdateSystem]
[ILJNJGIAJDG]
[UpdateAfter(typeof(FHGPOKBDBAK))]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class OLFDHOHOBLG : OHFDJEHNBBG
{
	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x25ECBD0", Offset = "0x25EBBD0", VA = "0x1825ECBD0")]
	public OLFDHOHOBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x25ECA80", Offset = "0x25EBA80", VA = "0x1825ECA80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class GIIGMHKDKKK : KCGDIJLKEDD
{
	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public GIIGMHKDKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x245E500", Offset = "0x245D500", VA = "0x18245E500", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class GODAKBENPHC : BHLCFNKENLD
{
	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x22DBEF0", Offset = "0x22DAEF0", VA = "0x1822DBEF0")]
	public GODAKBENPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x22DBEE0", Offset = "0x22DAEE0", VA = "0x1822DBEE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class CMPIHPIKIKE : APKJLCEKJEA
{
	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x244DCE0", Offset = "0x244CCE0", VA = "0x18244DCE0")]
	public CMPIHPIKIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x244DCA0", Offset = "0x244CCA0", VA = "0x18244DCA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class FHPLDGBADMN : JNGAABHFLAC
{
	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x245BF70", Offset = "0x245AF70", VA = "0x18245BF70")]
	public FHPLDGBADMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x245BF60", Offset = "0x245AF60", VA = "0x18245BF60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(KAGBBIADBCD))]
public sealed class GPICNIBGPGH : JHILICDLEIA
{
	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x22DC790", Offset = "0x22DB790", VA = "0x1822DC790")]
	public GPICNIBGPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x22DC750", Offset = "0x22DB750", VA = "0x1822DC750", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(AEELKELEMIA))]
public class OEGGJFHCDKG : KHNJKIGBFPG
{
	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public OEGGJFHCDKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x25EC970", Offset = "0x25EB970", VA = "0x1825EC970", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(LMIOPHIAIOF))]
public sealed class ODCGOHNEHEJ : MAMNLHEECIG
{
	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0")]
	public ODCGOHNEHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x25EC1A0", Offset = "0x25EB1A0", VA = "0x1825EC1A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(ODCGOHNEHEJ))]
[UpdateInGroup(typeof(LMIOPHIAIOF))]
public class MAGFNDGFNDM : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x25E57E0", Offset = "0x25E47E0", VA = "0x1825E57E0")]
	public MAGFNDGFNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x25E57D0", Offset = "0x25E47D0", VA = "0x1825E57D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[ILJNJGIAJDG]
[AlwaysUpdateSystem]
[UpdateInGroup(typeof(LMIOPHIAIOF))]
[UpdateAfter(typeof(MAGFNDGFNDM))]
public sealed class NOMOMJEILEB : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	protected override ApplyPropertyDifferences JCPNKCPAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x25EB910", Offset = "0x25EA910", VA = "0x1825EB910", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x25EB960", Offset = "0x25EA960", VA = "0x1825EB960")]
	public NOMOMJEILEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x7496E0", Offset = "0x7486E0", VA = "0x1807496E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
[ILJNJGIAJDG]
[UpdateAfter(typeof(NOMOMJEILEB))]
[UpdateInGroup(typeof(LMIOPHIAIOF))]
public sealed class KPIPBOCCPBC : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x22EAF70", Offset = "0x22E9F70", VA = "0x1822EAF70")]
	public KPIPBOCCPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[ILJNJGIAJDG]
[UpdateInGroup(typeof(LMIOPHIAIOF))]
[UpdateAfter(typeof(NOMOMJEILEB))]
public sealed class HGBPJFPDIJL : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x22DC9C0", Offset = "0x22DB9C0", VA = "0x1822DC9C0")]
	public HGBPJFPDIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x22C82B0", Offset = "0x22C72B0", VA = "0x1822C82B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
[AJHJJBJAJKN(typeof(BKMMLEGBFNN), new string[] { })]
public sealed class KFNIPGPHNIC : BKMMLEGBFNN, JLLBLNFOFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private FOLFFNLGEBO NKBCKMKPIJP;

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x22E9530", Offset = "0x22E8530", VA = "0x1822E9530", Slot = "5")]
	public void NOIDMFIGJOK(CAJHOBCLJCD HNBMHDKILBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x22E9450", Offset = "0x22E8450", VA = "0x1822E9450")]
	public bool GGOGBMKFGCH(in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, float KEOEBHPOCHG, Allocator LKNIKCJFBFH, out NativeArray<Entity> AFOGFGIBNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KFNIPGPHNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x22E9450", Offset = "0x22E8450", VA = "0x1822E9450", Slot = "4")]
	private bool GFKNOOGJGPP(in float3 JMEGKKAALJI, in float3 CMMBIAPMMCO, float KEOEBHPOCHG, Allocator LKNIKCJFBFH, out NativeArray<Entity> AFOGFGIBNGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[MHFLLNJDCAI(typeof(AuthoredLocalPoseData))]
public sealed class EGGGNNJIPKB : PLLNPPABKJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x2459F40", Offset = "0x2458F40", VA = "0x182459F40", Slot = "8")]
	protected override bool EJPKJFPDJFG(ReadOnlySpan<AuthoredLocalPoseData> OOEEMCHEMCH, HDKJKHCKAFP PEEOAAMJPAN, out ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2459FC0", Offset = "0x2458FC0", VA = "0x182459FC0", Slot = "9")]
	protected override bool GKMEJJHJMGG(int GDLEDDNCPGJ, Span<AuthoredLocalPoseData> OOEEMCHEMCH, in ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x245A080", Offset = "0x2459080", VA = "0x18245A080")]
	public EGGGNNJIPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[MHFLLNJDCAI(typeof(LocalPoseData))]
public sealed class GNNNIBNIIEP : JHJNFNNFCBL
{
	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x22DBD90", Offset = "0x22DAD90", VA = "0x1822DBD90", Slot = "8")]
	protected override bool EJPKJFPDJFG(ReadOnlySpan<LocalPoseData> OOEEMCHEMCH, HDKJKHCKAFP PEEOAAMJPAN, out ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x22DBE10", Offset = "0x22DAE10", VA = "0x1822DBE10", Slot = "9")]
	protected override bool GKMEJJHJMGG(int GDLEDDNCPGJ, Span<LocalPoseData> OOEEMCHEMCH, in ReadOnlySpan<byte> OBPMMCCMALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x22DBED0", Offset = "0x22DAED0", VA = "0x1822DBED0")]
	public GNNNIBNIIEP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[Preserve]
	internal class _RRAssemblyIndex : AICCCLPHIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF3")]
		[Cpp2IlInjected.Address(RVA = "0x22D9F20", Offset = "0x22D8F20", VA = "0x1822D9F20", Slot = "6")]
		public sealed override void HBKENJIDLCO(POJOABKEJAJ PCMFICPIFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x22D9920", Offset = "0x22D8920", VA = "0x1822D9920", Slot = "4")]
		public sealed override void CIJCLICMJID()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
internal class EMGOMFDEAOD : ContainerPropertyBag<KLKONKKFEIM>
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	private class PPAFMOONEPP : Property<KLKONKKFEIM, PHJBPPLEHIN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public override string CNNFDLMHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF6")]
			[Cpp2IlInjected.Address(RVA = "0x2462340", Offset = "0x2461340", VA = "0x182462340", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public override bool HANJBFPBIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF7")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EC0", Offset = "0x5E4EC0", VA = "0x1805E5EC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x2462300", Offset = "0x2461300", VA = "0x182462300")]
		public PPAFMOONEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x24622B0", Offset = "0x24612B0", VA = "0x1824622B0", Slot = "11")]
		public override PHJBPPLEHIN GetValue(ref KLKONKKFEIM KIKNDHMFIHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x24622D0", Offset = "0x24612D0", VA = "0x1824622D0", Slot = "12")]
		public override void SetValue(ref KLKONKKFEIM KIKNDHMFIHG, PHJBPPLEHIN JNLOLNFALGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x245A6F0", Offset = "0x24596F0", VA = "0x18245A6F0")]
	public EMGOMFDEAOD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x576FC20", Offset = "0x576EC20", VA = "0x18576FC20")]
		[Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x245A100", Offset = "0x2459100", VA = "0x18245A100")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x245A200", Offset = "0x2459200", VA = "0x18245A200")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20001C2")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
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
