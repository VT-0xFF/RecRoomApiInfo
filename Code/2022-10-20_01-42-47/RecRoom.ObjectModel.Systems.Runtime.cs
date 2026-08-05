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
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
[DefaultMember("Item")]
public sealed class JGJHEAOPGME<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class GBIGHOGHPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::JGJHEAOPGME<T> GJPLAEOKFJB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] DHLMDDOAPMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public GBIGHOGHPEM(global::JGJHEAOPGME<T> GJPLAEOKFJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JAIOGPNDHLB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::JGJHEAOPGME<T> <>4__this;

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
		public JAIOGPNDHLB(int <>1__state)
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
	private const int GKCEFICFLBH = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> LFMMPPEBOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int CHMAOLJMIAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T MGJNMHFDFJH
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
	private bool EFLLLAPDHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JIPGMKBKOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool IEPILJLJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KEHBMLJLDDD
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
	public int MNCJKLLDCNE
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
	public JGJHEAOPGME(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public JGJHEAOPGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void HEMGPKDBBCO(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void GEPHADMCPNH(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] JEAKIKGHNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void NLFEHPHFDHE(NativeArray<T> DEJEDNNJILK, int AGJLGNIMOFB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::JGJHEAOPGME<>.JAIOGPNDHLB))]
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
	public int FKENAIAHEAH(T GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool AKJLIPOIGHF(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void OOJBCJGOOPE(int GDBOCMJFLPN, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void DFDPHHKCJAP(int GDBOCMJFLPN, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void KFAOHMONGMK(int GDBOCMJFLPN, int LBACAALGKLG, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int MPGOCOIHIGI(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T PBNKPOHJMOI(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void DEMOOPIFEAO(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void PJGLHCABIJC(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void CIEHCDKIDPP(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int NKHPNAKGHAD(int IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int PKHHAPBEOGG(int IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void AGMEFFIEGAJ(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void DFHIAMPIJMA(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T CGDEAHEHCMG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T BFABFGGPDGG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void OGKDPNNMGEE(int AIPHGHFENPJ, IReadOnlyCollection<T> FLHDOCMLBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void EEEDNKEJIMM(int AIPHGHFENPJ, int DHBJDMINJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void BIDHJKJAKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void IOCBCFGGGMF(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void FKIAPFJCOHA(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void GIBODEFMDLL(int LBACAALGKLG, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T BDKBGKOIIKM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T AFMOCBFFKLG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[NAOJPPNIGOE]
public static class HLHFCCFHJJE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x282B260", Offset = "0x282A060", VA = "0x18282B260")]
	static HLHFCCFHJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x23743E0", Offset = "0x23731E0", VA = "0x1823743E0")]
	public static void KLHMDOLPFPN<T>(T ICAAAENIBKC, ref T PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x282B230", Offset = "0x282A030", VA = "0x18282B230")]
	public static void KLHMDOLPFPN(FixedString32 ICAAAENIBKC, ref string PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x282B150", Offset = "0x2829F50", VA = "0x18282B150")]
	public static void KLHMDOLPFPN(string ICAAAENIBKC, ref FixedString32 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x282B0C0", Offset = "0x2829EC0", VA = "0x18282B0C0")]
	public static void KLHMDOLPFPN(FixedString64 ICAAAENIBKC, ref string PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x282B0F0", Offset = "0x2829EF0", VA = "0x18282B0F0")]
	public static void KLHMDOLPFPN(string ICAAAENIBKC, ref FixedString64 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21BB890", Offset = "0x21BA690", VA = "0x1821BB890")]
	public static void KLHMDOLPFPN(MAPAFAEKPLB ICAAAENIBKC, ref Vector3 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x282AFF0", Offset = "0x2829DF0", VA = "0x18282AFF0")]
	public static void KLHMDOLPFPN(Vector3 ICAAAENIBKC, ref MAPAFAEKPLB PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21BB6C0", Offset = "0x21BA4C0", VA = "0x1821BB6C0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref Vector4 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x282B050", Offset = "0x2829E50", VA = "0x18282B050")]
	public static void KLHMDOLPFPN(Vector4 ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x21BB6C0", Offset = "0x21BA4C0", VA = "0x1821BB6C0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref Quaternion PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x282B050", Offset = "0x2829E50", VA = "0x18282B050")]
	public static void KLHMDOLPFPN(Quaternion ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x282B190", Offset = "0x2829F90", VA = "0x18282B190")]
	public static void KLHMDOLPFPN(MAPAFAEKPLB ICAAAENIBKC, ref float3 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x282AFF0", Offset = "0x2829DF0", VA = "0x18282AFF0")]
	public static void KLHMDOLPFPN(float3 ICAAAENIBKC, ref MAPAFAEKPLB PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x282AF90", Offset = "0x2829D90", VA = "0x18282AF90")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref float4 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x282B050", Offset = "0x2829E50", VA = "0x18282B050")]
	public static void KLHMDOLPFPN(float4 ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x282AF90", Offset = "0x2829D90", VA = "0x18282AF90")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref quaternion PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x282B1C0", Offset = "0x2829FC0", VA = "0x18282B1C0")]
	public static void KLHMDOLPFPN(quaternion ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x282AF50", Offset = "0x2829D50", VA = "0x18282AF50")]
	public static void KLHMDOLPFPN(Entity ICAAAENIBKC, ref EAGBNLPLMDM PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x282AFD0", Offset = "0x2829DD0", VA = "0x18282AFD0")]
	public static void KLHMDOLPFPN(EAGBNLPLMDM ICAAAENIBKC, ref Entity PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CIHFPOEPMJE]
public class BCACDHDIFBD : ComponentSystem, FDFFINEAOHD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FFPEBHHNJFF AFNMECPECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DBE0", Offset = "0x2C2C9E0", VA = "0x182C2DBE0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	public BCACDHDIFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CreateAssetMenu]
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
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2862E50", Offset = "0x2861C50", VA = "0x182862E50")]
		public static ObjectModelConfigAsset KAFDHDNKOOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xD12960", Offset = "0xD11760", VA = "0x180D12960")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[IFBLAMOEMKH(CMGBDLINHMB.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[IFBLAMOEMKH(CMGBDLINHMB.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public const int JHKNBKMIJJL = 0;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private static readonly CGJHBFGPOOL LEOCGNJBNFD;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x360B7E0", Offset = "0x360A5E0", VA = "0x18360B7E0")]
			public static NMEJDFJAOOA PFOPLNMMKLA(int MNMNCDHLGJH)
			{
				return default(NMEJDFJAOOA);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x360B650", Offset = "0x360A450", VA = "0x18360B650")]
			public static int LFKBGMJBMBB(GameObject BFJMKCMPBKG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x360B5D0", Offset = "0x360A3D0", VA = "0x18360B5D0")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void JIPGEOIILEP(PMMHBDBEGAM ADGJAILKBPO, int MNMNCDHLGJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static ELODGKLHEKG BGLEKJNFDOI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static DDMIOFGHMGI BHLMCOMCAMI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static ELODGKLHEKG EFMLHEELPHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2864070", Offset = "0x2862E70", VA = "0x182864070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x28635A0", Offset = "0x28623A0", VA = "0x1828635A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DDMIOFGHMGI HODIGNDEBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2864480", Offset = "0x2863280", VA = "0x182864480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2862EF0", Offset = "0x2861CF0", VA = "0x182862EF0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool MDOCPLGNBCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2863F10", Offset = "0x2862D10", VA = "0x182863F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static EEDGKMIDAFH ELOFBPOOINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2863130", Offset = "0x2861F30", VA = "0x182863130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static BFIAFBHOKLF GMAGOKAFPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2863870", Offset = "0x2862670", VA = "0x182863870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LBPAJLMGMFA CPAHMDPHOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x28638F0", Offset = "0x28626F0", VA = "0x1828638F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CBIPFLGDJEF OFOEMMHFELK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2864400", Offset = "0x2863200", VA = "0x182864400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HFHHBKPAPIM HCLFBFBADHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x28631B0", Offset = "0x2861FB0", VA = "0x1828631B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static bool EDGBECOMPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2863E30", Offset = "0x2862C30", VA = "0x182863E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool GMLOKFCDNDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2863680", Offset = "0x2862480", VA = "0x182863680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2863D90", Offset = "0x2862B90", VA = "0x182863D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool LOJJPMJMIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x28643A0", Offset = "0x28631A0", VA = "0x1828643A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2864200", Offset = "0x2863000", VA = "0x182864200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool BPFJNFDNOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28645A0", Offset = "0x28633A0", VA = "0x1828645A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2863D30", Offset = "0x2862B30", VA = "0x182863D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2863AA0", Offset = "0x28628A0", VA = "0x182863AA0")]
		public static PMMHBDBEGAM GJELMEFNGNA(GameObject BFJMKCMPBKG)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2864260", Offset = "0x2863060", VA = "0x182864260")]
		public static bool NICGPJNPJBA(ByteString OFOCCMMPKKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2863480", Offset = "0x2862280", VA = "0x182863480")]
		public static FEMMDHLANDH DKMHCFMKGGH(NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(FEMMDHLANDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2863230", Offset = "0x2862030", VA = "0x182863230")]
		public static (ByteString, IDisposable) DGAMFOBEJMM()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2863C00", Offset = "0x2862A00", VA = "0x182863C00")]
		public static (ByteString, IDisposable) HDNBNFDBMMB(IEnumerable<PMMHBDBEGAM> NKMHMLMDMOP)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28640D0", Offset = "0x2862ED0", VA = "0x1828640D0")]
		public static bool LBJNANMCLGI(GameObject BFJMKCMPBKG, out NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2863970", Offset = "0x2862770", VA = "0x182863970")]
		public static bool GEMFNDMEEJL(GameObject BFJMKCMPBKG, out bool OBANFJOJHJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28642C0", Offset = "0x28630C0", VA = "0x1828642C0")]
		private static DDMIOFGHMGI NKHKIKEOPBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2863360", Offset = "0x2862160", VA = "0x182863360")]
		private static bool DHBLOAHEADB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HGOFHAOIHFG
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x282AC50", Offset = "0x2829A50", VA = "0x18282AC50")]
	public static GIALAGJINEB PJHBAIJLMNC(GameObject BFJMKCMPBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x282AA50", Offset = "0x2829850", VA = "0x18282AA50")]
	public static GIALAGJINEB PJHBAIJLMNC(GameObject BFJMKCMPBKG, NMEJDFJAOOA DBGIPPEDJIM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DisembodiedObjectView : MonoBehaviour, IODDBDKJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public PMMHBDBEGAM JJEJMCOPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(PMMHBDBEGAM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1AD64E0", Offset = "0x1AD52E0", VA = "0x181AD64E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, GIALAGJINEB, IODDBDKJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const string OJHHLHMINPH = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KGMBEEPIDCF PBHDPEJBGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PMMHBDBEGAM JBKJOONHJLG;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public PMMHBDBEGAM JJEJMCOPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x676E30", VA = "0x180678030", Slot = "11")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public FEMMDHLANDH MDKCEMLOLDO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2C3DA20", Offset = "0x2C3C820", VA = "0x182C3DA20", Slot = "4")]
			get
			{
				return default(FEMMDHLANDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EEDGKMIDAFH ELOFBPOOINO
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D060", Offset = "0x2C3BE60", VA = "0x182C3D060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private DDPHBMAAHDP IKBMNLNHFOK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D0B0", Offset = "0x2C3BEB0", VA = "0x182C3D0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public KGMBEEPIDCF FMNNHJPPEJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x677D90", Offset = "0x676B90", VA = "0x180677D90", Slot = "5")]
			get
			{
				return default(KGMBEEPIDCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BHCFKCKKCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6723D0", Offset = "0x6711D0", VA = "0x1806723D0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8DC1D0", Offset = "0x8DAFD0", VA = "0x1808DC1D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CPGENINLLKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2C3D980", Offset = "0x2C3C780", VA = "0x182C3D980")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2C3DA50", Offset = "0x2C3C850", VA = "0x182C3DA50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2C3CF60", Offset = "0x2C3BD60", VA = "0x182C3CF60")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D710", Offset = "0x2C3C510", VA = "0x182C3D710", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D330", Offset = "0x2C3C130", VA = "0x182C3D330", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D680", Offset = "0x2C3C480", VA = "0x182C3D680", Slot = "8")]
		public void OnEmbody(EHIDJEIAFME HADAJAKADAH, PMMHBDBEGAM JBKJOONHJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D700", Offset = "0x2C3C500", VA = "0x182C3D700", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D450", Offset = "0x2C3C250", VA = "0x182C3D450", Slot = "10")]
		public void OnDisembody(bool KPMBBBPBAKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D830", Offset = "0x2C3C630", VA = "0x182C3D830")]
		private void PFPDCNMEFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D270", Offset = "0x2C3C070", VA = "0x182C3D270")]
		private void GDCFJBLAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2C3D130", Offset = "0x2C3BF30", VA = "0x182C3D130")]
		private void FKLGBDDBJBJ(bool MAGLHKOAFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xDC4FC0", Offset = "0xDC3DC0", VA = "0x180DC4FC0", Slot = "7")]
		private GameObject LAGCEEBLEDM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[IFBLAMOEMKH(CMGBDLINHMB.Registration)]
	public sealed class TransformEntity : MonoBehaviour, IODDBDKJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private CBLLNBPHCKJ prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PMMHBDBEGAM ADGJAILKBPO;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CBLLNBPHCKJ KCIEHLAFPHK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x6579D0", VA = "0x180658BD0")]
			get
			{
				return default(CBLLNBPHCKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6FB410", Offset = "0x6FA210", VA = "0x1806FB410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public PMMHBDBEGAM JJEJMCOPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC02A40", Offset = "0xC01840", VA = "0x180C02A40", Slot = "4")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity MINMLEDGPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal CBIPFLGDJEF OFOEMMHFELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal DDPHBMAAHDP LLJLHOBLFJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x28773D0", Offset = "0x28761D0", VA = "0x1828773D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28773C0", Offset = "0x28761C0", VA = "0x1828773C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28777C0", Offset = "0x28765C0", VA = "0x1828777C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28774E0", Offset = "0x28762E0", VA = "0x1828774E0")]
		internal void ILMEFAAGLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2877440", Offset = "0x2876240", VA = "0x182877440")]
		private bool HDNEEALHHIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28778B0", Offset = "0x28766B0", VA = "0x1828778B0")]
		private void NEKOIANILKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x28777C0", Offset = "0x28765C0", VA = "0x1828777C0")]
		internal void LKKBDAMJBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x28778D0", Offset = "0x28766D0", VA = "0x1828778D0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x28779B0", Offset = "0x28767B0", VA = "0x1828779B0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[EBJHGMECDNA(typeof(DDMIOFGHMGI), new string[] { })]
public class AOMGPGIGOPG : OAKPEHJFEOH, DDMIOFGHMGI, HECIIBPMLDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private AJDCMAAKGND FJKJAKKFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EEDGKMIDAFH JLJNFPKFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public MIBPANHFFGK MJDHCGHFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x872170", Offset = "0x870F70", VA = "0x180872170", Slot = "18")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AJDCMAAKGND AFNMECPECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IJONKAEAEBK GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761940", VA = "0x180762B40", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GMLOKFCDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C29110", Offset = "0x2C27F10", VA = "0x182C29110", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C29420", Offset = "0x2C28220", VA = "0x182C29420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C294F0", Offset = "0x2C282F0", VA = "0x182C294F0", Slot = "19")]
	public void KEACOMCKNJG(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2C294E0", Offset = "0x2C282E0", VA = "0x182C294E0")]
	private void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C29290", Offset = "0x2C28090", VA = "0x182C29290")]
	private void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C290B0", Offset = "0x2C27EB0", VA = "0x182C290B0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C29320", Offset = "0x2C28120", VA = "0x182C29320", Slot = "7")]
	public void HJFKJCGGCHL(ByteString JANIFNADDOP, FIIDIKCOABM IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C28FD0", Offset = "0x2C27DD0", VA = "0x182C28FD0", Slot = "4")]
	public ByteString DGAMFOBEJMM(out IDisposable AEPEDHEDMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C291F0", Offset = "0x2C27FF0", VA = "0x182C291F0", Slot = "5")]
	public void HFLDMAMBPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C28D80", Offset = "0x2C27B80", VA = "0x182C28D80", Slot = "6")]
	public void BFNLLBCKDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C294B0", Offset = "0x2C282B0", VA = "0x182C294B0", Slot = "9")]
	public void JIIFFIDEOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C28DF0", Offset = "0x2C27BF0", VA = "0x182C28DF0", Slot = "8")]
	public void BKCJFNGCBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C29180", Offset = "0x2C27F80", VA = "0x182C29180", Slot = "10")]
	public void GMLAJKAIPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C295D0", Offset = "0x2C283D0", VA = "0x182C295D0", Slot = "11")]
	public void NBAPLGNMALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C294A0", Offset = "0x2C282A0", VA = "0x182C294A0", Slot = "12")]
	public void HLFKKGKEHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C294B0", Offset = "0x2C282B0", VA = "0x182C294B0")]
	private void JEFLCDJFCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C28EE0", Offset = "0x2C27CE0", VA = "0x182C28EE0")]
	public static AOMGPGIGOPG DAKLFHBAJIH(AJDCMAAKGND FJKJAKKFINM, HNBJONKGAEL IDKBHBKJHPJ = HNBJONKGAEL.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private static void EAKJLDOOHJN(AJDCMAAKGND FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private static void GNNLGEBIEFN(AJDCMAAKGND FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public AOMGPGIGOPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NLMGFEDBPGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x283B540", Offset = "0x283A340", VA = "0x18283B540")]
	public static FEMMDHLANDH PACACJLKIEO(this DDMIOFGHMGI BHLMCOMCAMI, NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x283B240", Offset = "0x283A040", VA = "0x18283B240")]
	public static DJFJGAJKGKD GEAJKNPCODP(this DDMIOFGHMGI BHLMCOMCAMI)
	{
		return default(DJFJGAJKGKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x283B360", Offset = "0x283A160", VA = "0x18283B360")]
	public static PMMHBDBEGAM GJELMEFNGNA(this DDMIOFGHMGI BHLMCOMCAMI, Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x283B410", Offset = "0x283A210", VA = "0x18283B410")]
	public static PMMHBDBEGAM GJELMEFNGNA(this DDMIOFGHMGI BHLMCOMCAMI, NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x283B120", Offset = "0x2839F20", VA = "0x18283B120")]
	public static NMEJDFJAOOA GAGENPHPDNI(this DDMIOFGHMGI BHLMCOMCAMI, PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(NMEJDFJAOOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Flags]
public enum HNBJONKGAEL
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class PLGEJPKBGNG<T> : global::ABNAOGMKEDJ<T>, global::ALFHNNMHDGP<NMEJDFJAOOA, T>, global::HCIKOPDBING<NMEJDFJAOOA>, FJCEHGNCBHG, IDisposable, AEFHEEDIBGN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::HCIKOPDBING<Entity> HLOAMKBCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate MDIMLNIMDAB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3177DA0", Offset = "0x3176BA0", VA = "0x183177DA0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3173330", Offset = "0x3172130", VA = "0x183173330", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public COLPHKAFOHI ABFPPGPBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x31751A0", Offset = "0x3173FA0", VA = "0x1831751A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KPNMHAONEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3174750", Offset = "0x3173550", VA = "0x183174750", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ABBPJBEDAOI DLIKAHDJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3175550", Offset = "0x3174350", VA = "0x183175550", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xEA8650", Offset = "0xEA7450", VA = "0x180EA8650", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3174880", Offset = "0x3173680", VA = "0x183174880", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event global::NICCPCBLAIH<NMEJDFJAOOA> CDKLADNMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x31752F0", Offset = "0x31740F0", VA = "0x1831752F0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3177EA0", Offset = "0x3176CA0", VA = "0x183177EA0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x317A630", Offset = "0x3179430", VA = "0x18317A630")]
	public PLGEJPKBGNG(global::HCIKOPDBING<Entity> HLOAMKBCFBD, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3173850", Offset = "0x3172650", VA = "0x183173850")]
	private Entity ANJHDLDNACK(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x31735D0", Offset = "0x31723D0", VA = "0x1831735D0")]
	private NMEJDFJAOOA ANJHDLDNACK(Entity GEEFHDFLBEH)
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x31742A0", Offset = "0x31730A0", VA = "0x1831742A0", Slot = "4")]
	public T BOPAOPJOHPG(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3179CA0", Offset = "0x3178AA0", VA = "0x183179CA0")]
	public bool PIGMJENILDA(NMEJDFJAOOA DBGIPPEDJIM, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3174C00", Offset = "0x3173A00", VA = "0x183174C00")]
	public bool FEOKGJFDCCA(NMEJDFJAOOA DBGIPPEDJIM, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x31734B0", Offset = "0x31722B0", VA = "0x1831734B0", Slot = "9")]
	public bool AEBBOEKMPNE(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31750A0", Offset = "0x3173EA0", VA = "0x1831750A0", Slot = "26")]
	public object FLHIMLEJDFE(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x31786B0", Offset = "0x31774B0", VA = "0x1831786B0")]
	public bool NBGPFIAMPKG(NMEJDFJAOOA DBGIPPEDJIM, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3174230", Offset = "0x3173030", VA = "0x183174230")]
	public void BOPAOPJOHPG(NMEJDFJAOOA DBGIPPEDJIM, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3179C20", Offset = "0x3178A20", VA = "0x183179C20")]
	public bool PIGMJENILDA(NMEJDFJAOOA DBGIPPEDJIM, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3174FC0", Offset = "0x3173DC0", VA = "0x183174FC0")]
	public bool FEOKGJFDCCA(NMEJDFJAOOA DBGIPPEDJIM, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3175EC0", Offset = "0x3174CC0", VA = "0x183175EC0", Slot = "21")]
	public void ICJPMMDCBBM(GMPBHDKHOML EMCMEEJENIP, [Optional] object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3175EF0", Offset = "0x3174CF0", VA = "0x183175EF0", Slot = "15")]
	public void ICJPMMDCBBM(NMEJDFJAOOA CCJNKBLKLDJ, FFKLAMKJFED EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3176570", Offset = "0x3175370", VA = "0x183176570", Slot = "14")]
	public bool JACHHKBDHDB(NMEJDFJAOOA PLPKOODJAKN, NMEJDFJAOOA ICAAAENIBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2434050", Offset = "0x2432E50", VA = "0x182434050", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x317A450", Offset = "0x3179250", VA = "0x18317A450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x31746B0", Offset = "0x31734B0", VA = "0x1831746B0")]
	public string DJJBAGBAKMA(in MJADMLMEADH OGIKPKOLMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3176630", Offset = "0x3175430", VA = "0x183176630")]
	private void JEEDOHDMNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3175A80", Offset = "0x3174880", VA = "0x183175A80")]
	private void HPEMFBKDMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3178F60", Offset = "0x3177D60", VA = "0x183178F60")]
	private void OOPGOCHNLEL(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3178950", Offset = "0x3177750", VA = "0x183178950")]
	private void NFDEOPKAPOI(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3177940", Offset = "0x3176740", VA = "0x183177940")]
	[Conditional("DEBUG_BUILD")]
	private static void JPOLNLNMBAE(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM, string JLHBKPIPBGO, string NFDEPNCPAAF, [CallerMemberName] string NNNOJJMLEJC = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x312FA80", Offset = "0x312E880", VA = "0x18312FA80", Slot = "5")]
	private bool PPEIKBCIMKI(NMEJDFJAOOA CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0230", Offset = "0x2DDF030", VA = "0x182DE0230", Slot = "6")]
	private bool OBPBBKFDOHC(NMEJDFJAOOA CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE04D0", Offset = "0x2DDF2D0", VA = "0x182DE04D0", Slot = "23")]
	private string FPCADNMOMEL(in MJADMLMEADH IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FEE480", Offset = "0x2FED280", VA = "0x182FEE480", Slot = "10")]
	private bool NEAKLMKNCOA(NMEJDFJAOOA CCJNKBLKLDJ, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FEE800", Offset = "0x2FED600", VA = "0x182FEE800", Slot = "11")]
	private void KLMFLIMPFDG(NMEJDFJAOOA CCJNKBLKLDJ, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3179BF0", Offset = "0x31789F0", VA = "0x183179BF0", Slot = "12")]
	private bool PDKGBKGOCBI(NMEJDFJAOOA CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x276D240", Offset = "0x276C040", VA = "0x18276D240", Slot = "13")]
	private bool FIDMHDJBIOF(NMEJDFJAOOA CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class JEBFFIPPOIH<T> : global::IHEHHPCDJON<T>, global::ALFHNNMHDGP<PMMHBDBEGAM, T>, global::HCIKOPDBING<PMMHBDBEGAM>, FJCEHGNCBHG, IDisposable, EMNNOKKNGJD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::HCIKOPDBING<Entity> HLOAMKBCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate MDIMLNIMDAB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string CKOMIBKPPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3A09410", Offset = "0x3A08210", VA = "0x183A09410", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3A029F0", Offset = "0x3A017F0", VA = "0x183A029F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public COLPHKAFOHI ABFPPGPBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3A05D80", Offset = "0x3A04B80", VA = "0x183A05D80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KPNMHAONEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3A04A30", Offset = "0x3A03830", VA = "0x183A04A30", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ABBPJBEDAOI DLIKAHDJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A06520", Offset = "0x3A05320", VA = "0x183A06520", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x32C5460", Offset = "0x32C4260", VA = "0x1832C5460", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A04AC0", Offset = "0x3A038C0", VA = "0x183A04AC0", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::NICCPCBLAIH<PMMHBDBEGAM> CDKLADNMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A061E0", Offset = "0x3A04FE0", VA = "0x183A061E0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3A097C0", Offset = "0x3A085C0", VA = "0x183A097C0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x317A630", Offset = "0x3179430", VA = "0x18317A630")]
	public JEBFFIPPOIH(global::HCIKOPDBING<Entity> HLOAMKBCFBD, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xFB7C40", Offset = "0xFB6A40", VA = "0x180FB7C40")]
	private Entity ANJHDLDNACK(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x32C0BD0", Offset = "0x32BF9D0", VA = "0x1832C0BD0")]
	private PMMHBDBEGAM ANJHDLDNACK(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A03030", Offset = "0x3A01E30", VA = "0x183A03030", Slot = "4")]
	public T BOPAOPJOHPG(PMMHBDBEGAM ADGJAILKBPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D580", Offset = "0x3A0C380", VA = "0x183A0D580")]
	public bool PIGMJENILDA(PMMHBDBEGAM ADGJAILKBPO, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A05810", Offset = "0x3A04610", VA = "0x183A05810")]
	public bool FEOKGJFDCCA(PMMHBDBEGAM ADGJAILKBPO, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A02F90", Offset = "0x3A01D90", VA = "0x183A02F90", Slot = "9")]
	public bool AEBBOEKMPNE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A05AC0", Offset = "0x3A048C0", VA = "0x183A05AC0", Slot = "25")]
	public object FLHIMLEJDFE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A099D0", Offset = "0x3A087D0", VA = "0x183A099D0")]
	public bool NBGPFIAMPKG(PMMHBDBEGAM ADGJAILKBPO, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A03CE0", Offset = "0x3A02AE0", VA = "0x183A03CE0")]
	public void BOPAOPJOHPG(PMMHBDBEGAM ADGJAILKBPO, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D810", Offset = "0x3A0C610", VA = "0x183A0D810")]
	public bool PIGMJENILDA(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A05270", Offset = "0x3A04070", VA = "0x183A05270")]
	public bool FEOKGJFDCCA(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3175EC0", Offset = "0x3174CC0", VA = "0x183175EC0", Slot = "21")]
	public void ICJPMMDCBBM(GMPBHDKHOML EMCMEEJENIP, [Optional] object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A07790", Offset = "0x3A06590", VA = "0x183A07790", Slot = "15")]
	public void ICJPMMDCBBM(PMMHBDBEGAM CCJNKBLKLDJ, FFKLAMKJFED EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A07F20", Offset = "0x3A06D20", VA = "0x183A07F20", Slot = "14")]
	public bool JACHHKBDHDB(PMMHBDBEGAM PLPKOODJAKN, PMMHBDBEGAM ICAAAENIBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A089A0", Offset = "0x3A077A0", VA = "0x183A089A0")]
	private void JEEDOHDMNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A07010", Offset = "0x3A05E10", VA = "0x183A07010")]
	private void HPEMFBKDMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BEA0", Offset = "0x3A0ACA0", VA = "0x183A0BEA0")]
	private void OOPGOCHNLEL(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A0AC80", Offset = "0x3A09A80", VA = "0x183A0AC80")]
	private void NFDEOPKAPOI(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x32C2000", Offset = "0x32C0E00", VA = "0x1832C2000", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3A0DE20", Offset = "0x3A0CC20", VA = "0x183A0DE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x32C2070", Offset = "0x32C0E70", VA = "0x1832C2070", Slot = "5")]
	private bool PPNEGJFMBIG(PMMHBDBEGAM CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x32C1E30", Offset = "0x32C0C30", VA = "0x1832C1E30", Slot = "6")]
	private bool DILFBGCJNPO(PMMHBDBEGAM CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1FD42E0", Offset = "0x1FD30E0", VA = "0x181FD42E0", Slot = "10")]
	private bool FOPKGOLPICI(PMMHBDBEGAM CCJNKBLKLDJ, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x32C1DF0", Offset = "0x32C0BF0", VA = "0x1832C1DF0", Slot = "11")]
	private void CLFJPJOHFLN(PMMHBDBEGAM CCJNKBLKLDJ, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x32C0C00", Offset = "0x32BFA00", VA = "0x1832C0C00", Slot = "12")]
	private bool BKBNACBCEKH(PMMHBDBEGAM CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x32C1DB0", Offset = "0x32C0BB0", VA = "0x1832C1DB0", Slot = "13")]
	private bool CFCCOPIDEGA(PMMHBDBEGAM CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BGDMNMCCMEA : IDisposable, FCMCKNEAHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> IJGJHLABOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2834DE0", Offset = "0x2833BE0", VA = "0x182834DE0")]
	public BGDMNMCCMEA(NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DDB0", Offset = "0x2C2CBB0", VA = "0x182C2DDB0", Slot = "6")]
	public PMMHBDBEGAM LOPGGIPACEB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DE00", Offset = "0x2C2CC00", VA = "0x182C2DE00", Slot = "7")]
	public Entity LOPGGIPACEB(Entity GEEFHDFLBEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DD10", Offset = "0x2C2CB10", VA = "0x182C2DD10", Slot = "8")]
	public IEnumerable<PMMHBDBEGAM> LOPGGIPACEB(IEnumerable<PMMHBDBEGAM> NKMHMLMDMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DCB0", Offset = "0x2C2CAB0", VA = "0x182C2DCB0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string BMODMKCBMOD = "Remap";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly CGJHBFGPOOL PDDKNMFMJJE;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int OOPKEADKOMM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static FCMCKNEAHLO EJEJEGHNJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GJHJIKOKLHN;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> IJGJHLABOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2872610", Offset = "0x2871410", VA = "0x182872610")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static bool KCEMFBBKHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2872890", Offset = "0x2871690", VA = "0x182872890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2872830", Offset = "0x2871630", VA = "0x182872830")]
		public static SerializationRemapScope HJFBIOMPHCC()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2872C40", Offset = "0x2871A40", VA = "0x182872C40")]
		public SerializationRemapScope(FCMCKNEAHLO EENEGLPEEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2872720", Offset = "0x2871520", VA = "0x182872720", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2872A50", Offset = "0x2871850", VA = "0x182872A50")]
		public static PMMHBDBEGAM LOPGGIPACEB(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2872920", Offset = "0x2871720", VA = "0x182872920")]
		public static Entity LOPGGIPACEB(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[EBJHGMECDNA(typeof(IIBEBFFOKJL), new string[] { })]
public class OCMPGHBIMFF : IIBEBFFOKJL
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x283BF00", Offset = "0x283AD00", VA = "0x18283BF00", Slot = "5")]
	public void JFDBCBPNEOB(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x283C0C0", Offset = "0x283AEC0", VA = "0x18283C0C0", Slot = "6")]
	public void MBNNIDDPDHD(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x283BFE0", Offset = "0x283ADE0", VA = "0x18283BFE0", Slot = "7")]
	public void LCIAGECPLHB(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x283BDF0", Offset = "0x283ABF0", VA = "0x18283BDF0", Slot = "4")]
	public IDisposable JDMAFJDBIBL(object GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OCMPGHBIMFF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization)]
	[BPIBJJPJLCE(EEJHBIOBFFI.Application)]
	[EBJHGMECDNA(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal struct KFLLPAHAEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public KFLLPAHAEEL(string KIHDPCDCOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public void JACHHKBDHDB(EntityManager KIHDPCDCOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public void ICKDJJKFGLI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public KFLLPAHAEEL FNIGECDGEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KFLLPAHAEEL DBKAECNFAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KFLLPAHAEEL ONMLJOIBOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KFLLPAHAEEL KGNOJPDHANN;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AB00", Offset = "0x2C39900", VA = "0x182C3AB00")]
		public DebugWorldsService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AAC0", Offset = "0x2C398C0", VA = "0x182C3AAC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[EBJHGMECDNA(typeof(GKHHEJLDBHG), new string[] { })]
public class JINAIKLGNJK : GKHHEJLDBHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private bool OLEICDNJIKK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool GMLOKFCDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2830A30", Offset = "0x282F830", VA = "0x182830A30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<bool> BNMEEFBEKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28308F0", Offset = "0x282F6F0", VA = "0x1828308F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2830990", Offset = "0x282F790", VA = "0x182830990", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public JINAIKLGNJK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization, new string[] { "Timing" })]
	[EBJHGMECDNA(typeof(NEKBEAHJEHF), new string[] { })]
	[LFOIMLBAPLC(typeof(SerializationService))]
	[JAPBKNDOGGF(typeof(PKDAIMBJGBM))]
	internal class SerializationService : NEKBEAHJEHF, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const string AJJLNOEBKLI = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly CGJHBFGPOOL IMLOALHAGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private DDMIOFGHMGI BHLMCOMCAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private KFOEJBPDGJE CBNJNNIOIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private GKHHEJLDBHG PMDPJJKFBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private OKJLDANCMCA BFHLJMMPIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private SerializationRemapScope AEPEDHEDMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HDOIPKADCBB EMOEAFOOMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool? JNGDEDPKOCO;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool IPBKBIPNEBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x80AE20", Offset = "0x809C20", VA = "0x18080AE20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x1E14150", Offset = "0x1E12F50", VA = "0x181E14150", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public OKJLDANCMCA GDFHIAHBADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x28738B0", Offset = "0x28726B0", VA = "0x1828738B0", Slot = "11")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28743F0", Offset = "0x28731F0", VA = "0x1828743F0")]
		public static bool NICGPJNPJBA(ByteString OFOCCMMPKKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x675F40", VA = "0x180677140")]
		public void ENDOHEJKOHJ(KFOEJBPDGJE MPCCHNGMGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2874520", Offset = "0x2873320", VA = "0x182874520", Slot = "4")]
		public void PNIPCIGLEJN(bool JBAGPIKPAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2873150", Offset = "0x2871F50", VA = "0x182873150", Slot = "5")]
		public ByteString DGAMFOBEJMM(out IDisposable AEPEDHEDMKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2872F40", Offset = "0x2871D40", VA = "0x182872F40", Slot = "14")]
		public ByteString DGAMFOBEJMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2873970", Offset = "0x2872770", VA = "0x182873970", Slot = "7")]
		public bool HJFKJCGGCHL(ByteString FOEBAOOBLLE, FIIDIKCOABM IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2874120", Offset = "0x2872F20", VA = "0x182874120")]
		private bool NBKHPGGLIHK(ByteString FOEBAOOBLLE, FIIDIKCOABM IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2872CD0", Offset = "0x2871AD0", VA = "0x182872CD0", Slot = "8")]
		public bool BKCJFNGCBCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2872D80", Offset = "0x2871B80", VA = "0x182872D80", Slot = "6")]
		public void CNJFHELJLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2873510", Offset = "0x2872310", VA = "0x182873510", Slot = "9")]
		public bool GMLAJKAIPOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2873E90", Offset = "0x2872C90", VA = "0x182873E90", Slot = "10")]
		public bool NBAPLGNMALE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2873CA0", Offset = "0x2872AA0", VA = "0x182873CA0")]
		public bool MMOICLPGKEH(OKJLDANCMCA.GCFCGEAFACN.CHNPPDJGDNC PAKEAHNPOIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2873230", Offset = "0x2872030", VA = "0x182873230")]
		private bool DMJJLNOKELC(ByteString FOEBAOOBLLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2873BE0", Offset = "0x28729E0", VA = "0x182873BE0")]
		private void MMAGGEBNBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2873B80", Offset = "0x2872980", VA = "0x182873B80")]
		private ByteString MAMBKODCLGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2873790", Offset = "0x2872590", VA = "0x182873790")]
		private ByteString HBCCKENAPKC(ByteString OFOCCMMPKKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2874340", Offset = "0x2873140", VA = "0x182874340")]
		private OKJLDANCMCA.GCFCGEAFACN.CHNPPDJGDNC NEIODFJCEMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x28739B0", Offset = "0x28727B0", VA = "0x1828739B0")]
		private void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x28734D0", Offset = "0x28722D0", VA = "0x1828734D0")]
		private void FCMNIGJBIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EBJHGMECDNA(typeof(PKDAIMBJGBM), new string[] { })]
[LFOIMLBAPLC(typeof(HDOIPKADCBB))]
internal class HDOIPKADCBB : PKDAIMBJGBM
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action BFNLLBCKDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x282A480", Offset = "0x2829280", VA = "0x18282A480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x282A2F0", Offset = "0x28290F0", VA = "0x18282A2F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<FCMCKNEAHLO> BPONCGIEBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x282A520", Offset = "0x2829320", VA = "0x18282A520", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x282A5C0", Offset = "0x28293C0", VA = "0x18282A5C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FOPGIPKMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x282A070", Offset = "0x2828E70", VA = "0x18282A070", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x282A110", Offset = "0x2828F10", VA = "0x18282A110", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action COINHAMMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x282A250", Offset = "0x2829050", VA = "0x18282A250", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x282A1B0", Offset = "0x2828FB0", VA = "0x18282A1B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FCMCKNEAHLO> JJFNHBNBCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x282A390", Offset = "0x2829190", VA = "0x18282A390", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x282A660", Offset = "0x2829460", VA = "0x18282A660", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0xF6D250", Offset = "0xF6C050", VA = "0x180F6D250")]
	public void PIGAGAELBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xF6CC80", Offset = "0xF6BA80", VA = "0x180F6CC80")]
	public void CIAGNPLALDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x11FDF10", Offset = "0x11FCD10", VA = "0x1811FDF10")]
	public void EFEJPAIAAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x282A020", Offset = "0x2828E20", VA = "0x18282A020")]
	public void ALBKGGMPMOC(FCMCKNEAHLO EJEJEGHNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x282A430", Offset = "0x2829230", VA = "0x18282A430")]
	public void KFCLMAMBJOK(FCMCKNEAHLO EJEJEGHNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public HDOIPKADCBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[EBJHGMECDNA(typeof(AOAMPDCFJGB), new string[] { })]
public class IDOLLILKDHO : FDFFINEAOHD, AOAMPDCFJGB
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly ProfilerMarker KIIIAPAGLNM;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly ProfilerMarker JHKAEHBMPCA;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly ProfilerMarker GBBPEDCPGHL;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly ProfilerMarker FGJPMONHLNN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ProfilerMarker MGHLBJHBPLL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly ProfilerMarker MPLLODHNIEL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly ProfilerMarker LPLKIDNMNDJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ProfilerMarker KICBMHNCMGI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly ProfilerMarker DGDHODOGGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EHIDJEIAFME CANCHCAFIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private GKHHEJLDBHG GPMKOKBNMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private TransformOwnershipPhase EAFMNNJDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private PGLNEDJDCBK HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x282C780", Offset = "0x282B580", VA = "0x18282C780", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x282C420", Offset = "0x282B220", VA = "0x18282C420", Slot = "12")]
	public void BDKHMFMCKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x282C540", Offset = "0x282B340", VA = "0x18282C540", Slot = "6")]
	public void EOCBAKHJMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x282CCD0", Offset = "0x282BAD0", VA = "0x18282CCD0", Slot = "5")]
	public void OEOHKCEFKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x282C850", Offset = "0x282B650", VA = "0x18282C850", Slot = "7")]
	public void ICCPPCIFMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x282CB20", Offset = "0x282B920", VA = "0x18282CB20", Slot = "8")]
	public void MLLCJLEMGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x282CE80", Offset = "0x282BC80", VA = "0x18282CE80", Slot = "9")]
	public void PGLCPONIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x282CA00", Offset = "0x282B800", VA = "0x18282CA00", Slot = "10")]
	public void LMBOMCOLOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x282C6F0", Offset = "0x282B4F0", VA = "0x18282C6F0", Slot = "11")]
	public void FPGOANAJIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public IDOLLILKDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[EBJHGMECDNA(typeof(EHIDJEIAFME), new string[] { })]
public class OGEMFIKMOPN : EHIDJEIAFME, IDisposable, DFDLCPDHDGP
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private PGLNEDJDCBK HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public PGLNEDJDCBK NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x283C200", Offset = "0x283B000", VA = "0x18283C200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x283C560", Offset = "0x283B360", VA = "0x18283C560", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6718D0", Offset = "0x6706D0", VA = "0x1806718D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x283C5A0", Offset = "0x283B3A0", VA = "0x18283C5A0", Slot = "10")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x283C220", Offset = "0x283B020", VA = "0x18283C220")]
	private void DAKLFHBAJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x283C330", Offset = "0x283B130", VA = "0x18283C330", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x283C580", Offset = "0x283B380", VA = "0x18283C580", Slot = "8")]
	public ComponentSystemBase IDMEFHDLGGA(Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OGEMFIKMOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[JAPBKNDOGGF(typeof(ODMPAIDMGCI))]
[EBJHGMECDNA(typeof(NAPHDGPNDCH), new string[] { })]
public sealed class NCLHCLNIFGK : NAPHDGPNDCH, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GGLLCOLGDHJ : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x36035D0", Offset = "0x36023D0", VA = "0x1836035D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9DE010", Offset = "0x9DCE10", VA = "0x1809DE010")]
		[DebuggerHidden]
		public GGLLCOLGDHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x36032C0", Offset = "0x36020C0", VA = "0x1836032C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3603590", Offset = "0x3602390", VA = "0x183603590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x36034F0", Offset = "0x36022F0", VA = "0x1836034F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x36034F0", Offset = "0x36022F0", VA = "0x1836034F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DNKAAMBGEFF KNPJEFPACPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<string, PKIFOJFOFHC> PHKFDNECCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<int, NCDGLNOPNGL> DMILEGDMGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly List<EMNNOKKNGJD> FADJGCICDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private ODMPAIDMGCI GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NCDGLNOPNGL FHAGMECFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2839460", Offset = "0x2838260", VA = "0x182839460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public List<EMNNOKKNGJD> BOGKNNCHPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28399F0", Offset = "0x28387F0", VA = "0x1828399F0", Slot = "8")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2839A50", Offset = "0x2838850", VA = "0x182839A50", Slot = "9")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2839510", Offset = "0x2838310", VA = "0x182839510", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x28395D0", Offset = "0x28383D0", VA = "0x1828395D0", Slot = "6")]
	public bool EJLFOMONOPL(EMNNOKKNGJD HLOAMKBCFBD, out NCDGLNOPNGL DEIPGHEFMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2839660", Offset = "0x2838460", VA = "0x182839660")]
	private void FOCPGJGONGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2839250", Offset = "0x2838050", VA = "0x182839250")]
	private void APBHIJLNDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2839E50", Offset = "0x2838C50", VA = "0x182839E50")]
	private PKIFOJFOFHC LPFOILFAPFC(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2839460", Offset = "0x2838260", VA = "0x182839460")]
	private PKIFOJFOFHC BKPMIANNEJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2839B00", Offset = "0x2838900", VA = "0x182839B00")]
	private PKIFOJFOFHC LBDCBPBHNLB(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2839F90", Offset = "0x2838D90", VA = "0x182839F90")]
	private PKIFOJFOFHC OFOHMPAICFE(string KCGMDGFIHOJ, string MKDOEIGPNGM, [Optional] PKIFOJFOFHC IIIKGDMPMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2839560", Offset = "0x2838360", VA = "0x182839560")]
	[IteratorStateMachine(typeof(GGLLCOLGDHJ))]
	private IEnumerable<(string, string)> EJBCDJMKBBP(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x28394C0", Offset = "0x28382C0", VA = "0x1828394C0")]
	private bool CDFGJLPMPCC(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2839D70", Offset = "0x2838B70", VA = "0x182839D70")]
	private DNKAAMBGEFF LBOIIOKBPNJ(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2839F40", Offset = "0x2838D40", VA = "0x182839F40")]
	private DNKAAMBGEFF MKACELIKLKJ(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2839A70", Offset = "0x2838870", VA = "0x182839A70")]
	private DNKAAMBGEFF LAHFFPPDBFL(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x31DD870", Offset = "0x31DC670", VA = "0x1831DD870")]
	private T PPKNOAEFHAP<T>(EMNNOKKNGJD HLOAMKBCFBD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x28393F0", Offset = "0x28381F0", VA = "0x1828393F0")]
	private FieldInfo BGIHODPKJOL(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x283A0A0", Offset = "0x2838EA0", VA = "0x18283A0A0")]
	public NCLHCLNIFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2839EB0", Offset = "0x2838CB0", VA = "0x182839EB0")]
	[CompilerGenerated]
	private int MDCDJBFGPDN(EMNNOKKNGJD BMPDKJEHGIN, EMNNOKKNGJD BMMLDIMMAAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PKIFOJFOFHC : NCDGLNOPNGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly string ILLEEGLFOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly PKIFOJFOFHC IIIKGDMPMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly List<PKIFOJFOFHC> DLDFJOLGLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly List<EMNNOKKNGJD> GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public string NJKFNDEJKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NCDGLNOPNGL CPANCPIMLED
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<NCDGLNOPNGL> LFOFBANACAI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IEnumerable<EMNNOKKNGJD> LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2868180", Offset = "0x2866F80", VA = "0x182868180")]
	public PKIFOJFOFHC(string BEMAPDNKPAD, PKIFOJFOFHC ADECAOLBLPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[EBJHGMECDNA(typeof(HFHHBKPAPIM), new string[] { })]
public class FJOBIMGBAGC : HFHHBKPAPIM, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private EntityHierarchyParents OBEJKCLINIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EntityHierarchyChildren FALFIAAPAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private FGBIJEJJFBL MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private ObjectEmbodimentService DNCNJICBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public global::IHEHHPCDJON<PMMHBDBEGAM> JPFILNDPPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D380", VA = "0x18065E580", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A0", Offset = "0x65D3A0", VA = "0x18065E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AAE0", Offset = "0x1F998E0", VA = "0x181F9AAE0", Slot = "13")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2825FE0", Offset = "0x2824DE0", VA = "0x182825FE0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2826180", Offset = "0x2824F80", VA = "0x182826180", Slot = "15")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x19E5CC0", Offset = "0x19E4AC0", VA = "0x1819E5CC0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2825D40", Offset = "0x2824B40", VA = "0x182825D40")]
	private PMMHBDBEGAM AHLIDNNPJGI(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2825E00", Offset = "0x2824C00", VA = "0x182825E00", Slot = "18")]
	public PMMHBDBEGAM DCBCGPDHMLI(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2826620", Offset = "0x2825420", VA = "0x182826620", Slot = "19")]
	public void PPDLNFBKINL(ref List<PMMHBDBEGAM> PNCPJCEBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2826480", Offset = "0x2825280", VA = "0x182826480", Slot = "20")]
	public IEnumerable<PMMHBDBEGAM> NJHHOCACKHJ(PMMHBDBEGAM ADGJAILKBPO, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2826410", Offset = "0x2825210", VA = "0x182826410", Slot = "21")]
	public PMMHBDBEGAM NFFPNEMPLNO(PMMHBDBEGAM ADGJAILKBPO, int AIPHGHFENPJ)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2825E60", Offset = "0x2824C60", VA = "0x182825E60", Slot = "22")]
	public int EPCJNDKBFAD(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2825FB0", Offset = "0x2824DB0", VA = "0x182825FB0", Slot = "7")]
	public int HDHNEFAFOAJ(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x28260E0", Offset = "0x2824EE0", VA = "0x1828260E0", Slot = "8")]
	public CAOGEMEHCPI HNFHCHPIHGD(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2826550", Offset = "0x2825350", VA = "0x182826550", Slot = "23")]
	public IEnumerable<PMMHBDBEGAM> OEMKFPIEJOP(PMMHBDBEGAM ADGJAILKBPO, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2826340", Offset = "0x2825140", VA = "0x182826340", Slot = "11")]
	public PMMHBDBEGAM NDOCFECCKPD(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2826270", Offset = "0x2825070", VA = "0x182826270", Slot = "12")]
	public bool MKDAEBPAGML(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC, out PMMHBDBEGAM CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2825D70", Offset = "0x2824B70", VA = "0x182825D70", Slot = "4")]
	public PMMHBDBEGAM AILCCJELIAN(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2825DD0", Offset = "0x2824BD0", VA = "0x182825DD0", Slot = "10")]
	public bool BEBDCGNEJPP(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2825F50", Offset = "0x2824D50", VA = "0x182825F50", Slot = "24")]
	public bool FLMGCLJOAAP(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM NIPKJIJGCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2825F80", Offset = "0x2824D80", VA = "0x182825F80", Slot = "9")]
	public bool GOENCLMLMME(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM PJCDGLCJFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2826150", Offset = "0x2824F50", VA = "0x182826150", Slot = "5")]
	public bool JCGFFABNCHF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM ADECAOLBLPJ, bool CAMPEPOCDEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2825F20", Offset = "0x2824D20", VA = "0x182825F20", Slot = "6")]
	public bool FKEELJGEBOF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM ADECAOLBLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public FJOBIMGBAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(CMEEFJNDPID), new string[] { })]
internal class CMEEFJNDPID : FDFFINEAOHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<int, MFLHDAEOBPP> JHBFHOMOMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GNLAPDIIDJD GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C305B0", Offset = "0x2C2F3B0", VA = "0x182C305B0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C30460", Offset = "0x2C2F260", VA = "0x182C30460", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C30100", Offset = "0x2C2EF00", VA = "0x182C30100")]
	public MFLHDAEOBPP ABLADMHFHAN(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C30310", Offset = "0x2C2F110", VA = "0x182C30310")]
	public MFLHDAEOBPP ABLADMHFHAN(JLCDNMLCNEN ABEODFEGJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C30600", Offset = "0x2C2F400", VA = "0x182C30600")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C30720", Offset = "0x2C2F520", VA = "0x182C30720")]
	public CMEEFJNDPID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MFLHDAEOBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private NativeList<MIFKFPHADFM> EJGHENKOJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeList<FDCGJNDCDCD> AOAOEICHLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<MIFKFPHADFM> NFIMDAGFELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<MIFKFPHADFM> EGCAEICEBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0")]
		get
		{
			return default(NativeList<MIFKFPHADFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<FDCGJNDCDCD> BMKLKAAONKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC02A40", Offset = "0xC01840", VA = "0x180C02A40")]
		get
		{
			return default(NativeList<FDCGJNDCDCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<MIFKFPHADFM> LCLCNLCOLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xFAA700", Offset = "0xFA9500", VA = "0x180FAA700")]
		get
		{
			return default(NativeList<MIFKFPHADFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F67F0", Offset = "0x7F55F0", VA = "0x1807F67F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NMLHCBNDABE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x28389F0", Offset = "0x28377F0", VA = "0x1828389F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2838A80", Offset = "0x2837880", VA = "0x182838A80")]
	public MFLHDAEOBPP(Allocator JEOILJEOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2838980", Offset = "0x2837780", VA = "0x182838980")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2838890", Offset = "0x2837690", VA = "0x182838890")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x28386C0", Offset = "0x28374C0", VA = "0x1828386C0")]
	public void HEFJCCLOLGO(Entity GEEFHDFLBEH, Entity POICJGPACMK, Entity JDMCICBCFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[LFOIMLBAPLC(typeof(BBNANJDJDKF))]
[EBJHGMECDNA(typeof(LBPAJLMGMFA), new string[] { })]
public class BBNANJDJDKF : FDFFINEAOHD, IDisposable, LBPAJLMGMFA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private enum INAFJKBPCEO
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct OAGDPOPOBDF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly INAFJKBPCEO CPLIIAMHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly BBNANJDJDKF FPFLBEGAJEB;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x36097A0", Offset = "0x36085A0", VA = "0x1836097A0")]
		public OAGDPOPOBDF(BBNANJDJDKF FPFLBEGAJEB, bool NGKHKIFAGPC, uint JKGBPKEJAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3609770", Offset = "0x3608570", VA = "0x183609770", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PNNNHCANNGD
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct AJCNCDCKOAB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private readonly PNNNHCANNGD EHDENJOEBEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private readonly bool BPIFNHNEEBD;

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x35FF1C0", Offset = "0x35FDFC0", VA = "0x1835FF1C0")]
			public AJCNCDCKOAB(PNNNHCANNGD EHDENJOEBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x35FF190", Offset = "0x35FDF90", VA = "0x1835FF190", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public struct DOAEDIHIIDP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private readonly PNNNHCANNGD EHDENJOEBEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private readonly bool BPIFNHNEEBD;

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x36012F0", Offset = "0x36000F0", VA = "0x1836012F0")]
			public DOAEDIHIIDP(PNNNHCANNGD EHDENJOEBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x35FF190", Offset = "0x35FDF90", VA = "0x1835FF190", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly BBNANJDJDKF OPAAEBMKPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private bool MBDMKKDGNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private int MBNNEEAGIFH;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x360B040", Offset = "0x3609E40", VA = "0x18360B040")]
		public PNNNHCANNGD(BBNANJDJDKF OPAAEBMKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x360B010", Offset = "0x3609E10", VA = "0x18360B010")]
		public bool HMALHJBFIIP(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x360AFC0", Offset = "0x3609DC0", VA = "0x18360AFC0")]
		public DOAEDIHIIDP FNMAGCAMFPK()
		{
			return default(DOAEDIHIIDP);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x360AF70", Offset = "0x3609D70", VA = "0x18360AF70")]
		public AJCNCDCKOAB ABFMMCMGHGO()
		{
			return default(AJCNCDCKOAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CICGAJDCBAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public BBNANJDJDKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public CICGAJDCBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x35FFA60", Offset = "0x35FE860", VA = "0x1835FFA60")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class HOJHEDFHLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public BBNANJDJDKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HOJHEDFHLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3604430", Offset = "0x3603230", VA = "0x183604430")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AIKAHALICHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public AIKAHALICHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x35FF160", Offset = "0x35FDF60", VA = "0x1835FF160")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly UndoAction DBFLOLENENK;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly RedoAction GFIEGPGNDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AJAOFNBLAEO PPHDMDBEFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private ActionBuffer GCCMPHNKPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private ActionBuffer HHJLGKKPKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private KDMAIHKHEJC FDMIOBNNFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private TransformOwnershipPhase EAFMNNJDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private OMEALIIIEBE HKLMDPOAHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private INAFJKBPCEO BEACHIEJLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private PNNNHCANNGD EHDENJOEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private uint LNCJKCEPMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private uint IFPFCIKMOGE;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	private PNNNHCANNGD DICJHKJIJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6570B0", Offset = "0x655EB0", VA = "0x1806570B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool IELLIODAPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C980", Offset = "0x2C2B780", VA = "0x182C2C980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ILEGIBFBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C2CAE0", Offset = "0x2C2B8E0", VA = "0x182C2CAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool BACABGEDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C420", Offset = "0x2C2B220", VA = "0x182C2C420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int INCFKNAHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C2CC00", Offset = "0x2C2BA00", VA = "0x182C2CC00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int HCNKINHMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C2BF90", Offset = "0x2C2AD90", VA = "0x182C2BF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private bool MJOAJNDMFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C2DAE0", Offset = "0x2C2C8E0", VA = "0x182C2DAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private bool PJMIIPMPHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C2BEE0", Offset = "0x2C2ACE0", VA = "0x182C2BEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FMOJPHEMMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x840B80", Offset = "0x83F980", VA = "0x180840B80", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x703630", Offset = "0x702430", VA = "0x180703630", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private ActionBuffer DBNCPCPCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C9E0", Offset = "0x2C2B7E0", VA = "0x182C2C9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action FAKJDHABAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C2D790", Offset = "0x2C2C590", VA = "0x182C2D790", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C2BE40", Offset = "0x2C2AC40", VA = "0x182C2BE40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action DMBICFDMLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C2CDA0", Offset = "0x2C2BBA0", VA = "0x182C2CDA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C2BEF0", Offset = "0x2C2ACF0", VA = "0x182C2BEF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C530", Offset = "0x2C2B330", VA = "0x182C2C530", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BFE0", Offset = "0x2C2ADE0", VA = "0x182C2BFE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BBC0", Offset = "0x2C2A9C0", VA = "0x182C2BBC0", Slot = "14")]
	public IDisposable AJCNPDBBLIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CE40", Offset = "0x2C2BC40", VA = "0x182C2CE40", Slot = "9")]
	public IDisposable KEPOHAOMOBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BD80", Offset = "0x2C2AB80", VA = "0x182C2BD80", Slot = "6")]
	public UndoAction BBALAJBEALO()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DA20", Offset = "0x2C2C820", VA = "0x182C2DA20", Slot = "15")]
	public RedoAction PFKEPJGCIIA()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D570", Offset = "0x2C2C370", VA = "0x182C2D570", Slot = "16")]
	public UndoAction NLLJNOLHHMN()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D900", Offset = "0x2C2C700", VA = "0x182C2D900", Slot = "7")]
	public RedoAction PFKEPJGCIIA(UndoAction MCOKHJALNGG)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D630", Offset = "0x2C2C430", VA = "0x182C2D630", Slot = "8")]
	public UndoAction NLLJNOLHHMN(RedoAction MCOKHJALNGG)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CBA0", Offset = "0x2C2B9A0", VA = "0x182C2CBA0")]
	public bool JFPKNALJNDC(DIBKGKEHLCJ JCCOIDOODME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C9F0", Offset = "0x2C2B7F0", VA = "0x182C2C9F0", Slot = "17")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C470", Offset = "0x2C2B270", VA = "0x182C2C470")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D830", Offset = "0x2C2C630", VA = "0x182C2D830")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CCC0", Offset = "0x2C2BAC0", VA = "0x182C2CCC0")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D750", Offset = "0x2C2C550", VA = "0x182C2D750")]
	private void NNGDKFKGMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D4B0", Offset = "0x2C2C2B0", VA = "0x182C2D4B0")]
	private void NIMADPCBEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C910", Offset = "0x2C2B710", VA = "0x182C2C910")]
	private void IBAEKFOLKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CEA0", Offset = "0x2C2BCA0", VA = "0x182C2CEA0")]
	private DNOIGEFBDOI MLMOINDGNGJ()
	{
		return default(DNOIGEFBDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CBE0", Offset = "0x2C2B9E0", VA = "0x182C2CBE0")]
	private uint JIKCNGKHDPO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D4F0", Offset = "0x2C2C2F0", VA = "0x182C2D4F0")]
	private bool NKGHIOOOGEE(out DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C320", Offset = "0x2C2B120", VA = "0x182C2C320")]
	private bool GJMFNEDBEBJ(out DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C2C0", Offset = "0x2C2B0C0", VA = "0x182C2C2C0")]
	private RedoAction GEFPBOMIEMC(DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D510", Offset = "0x2C2C310", VA = "0x182C2D510")]
	private UndoAction NKGPADIEHKE(DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D0C0", Offset = "0x2C2BEC0", VA = "0x182C2D0C0")]
	private DNOIGEFBDOI MNKKCLEBONM(DNOIGEFBDOI CGKOOFFNHKL, ActionBuffer PNPICJPKOOO, bool NGKHKIFAGPC)
	{
		return default(DNOIGEFBDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C340", Offset = "0x2C2B140", VA = "0x182C2C340")]
	private void GKPICFMHNIB(Action CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x25D6BE0", Offset = "0x25D59E0", VA = "0x1825D6BE0")]
	private T GKPICFMHNIB<T>(Func<T> CLLGAPDCKOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CD70", Offset = "0x2C2BB70", VA = "0x182C2CD70")]
	private OAGDPOPOBDF JPAKMGAOJKH(bool NGKHKIFAGPC, uint JKGBPKEJAFA)
	{
		return default(OAGDPOPOBDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DBC0", Offset = "0x2C2C9C0", VA = "0x182C2DBC0")]
	public BBNANJDJDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C110", Offset = "0x2C2AF10", VA = "0x182C2C110")]
	[CompilerGenerated]
	private UndoAction EFENJMFOEMJ()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C7A0", Offset = "0x2C2B5A0", VA = "0x182C2C7A0")]
	[CompilerGenerated]
	private RedoAction HJCBNPKGOOM()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BC20", Offset = "0x2C2AA20", VA = "0x182C2BC20")]
	[CompilerGenerated]
	private UndoAction AMDOEENGPLP()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ALOABDNNCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private NativeArray<byte> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x6579D0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2834DE0", Offset = "0x2833BE0", VA = "0x182834DE0")]
	public ALOABDNNCOH(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C27B20", Offset = "0x2C26920", VA = "0x182C27B20")]
	public static ALOABDNNCOH PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	public T ICHDBDEGGEB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	public NativeArray<T> EKHBPDLBOLE<T>(int GKPOMAIMOAK, Allocator JEOILJEOOOI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	public NativeArray<T> KIDLKJHGFME<T>(Allocator JEOILJEOOOI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DFNLOEACJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private NativeArray<byte> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x6579D0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2834DE0", Offset = "0x2833BE0", VA = "0x182834DE0")]
	public DFNLOEACJNA(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C37DA0", Offset = "0x2C36BA0", VA = "0x182C37DA0")]
	public static DFNLOEACJNA PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x24A0090", Offset = "0x249EE90", VA = "0x1824A0090")]
	public T ICHDBDEGGEB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	public NativeArray<T> EKHBPDLBOLE<T>(int GKPOMAIMOAK, Allocator JEOILJEOOOI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class LADBHLGEIAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private NativeArray<byte> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x6579D0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2834DE0", Offset = "0x2833BE0", VA = "0x182834DE0")]
	public LADBHLGEIAG(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2834D80", Offset = "0x2833B80", VA = "0x182834D80")]
	public static LADBHLGEIAG PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x255C810", Offset = "0x255B610", VA = "0x18255C810")]
	public void KLNDOHCMIPB<T>(in T IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x255C710", Offset = "0x255B510", VA = "0x18255C710")]
	public void JBAHKNIGOHH<T>(NativeArray<T> ICAAAENIBKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	public void KGBDFBDIBBA<T>(NativeArray<T> IGJPNMBCJPK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FIKHFBIOBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2825980", Offset = "0x2824780", VA = "0x182825980")]
	public static Span<byte> IDMCGBAPNDN(this NativeArray<byte> DEJEDNNJILK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2825B10", Offset = "0x2824910", VA = "0x182825B10")]
	public static ReadOnlySpan<byte> OKENLMHDDLL(this NativeArray<byte> DEJEDNNJILK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2825900", Offset = "0x2824700", VA = "0x182825900")]
	public static NativeArray<byte> DPOLEKKKHDH(this NativeArray<byte> DEJEDNNJILK, int FOACNEHDHLI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2825A90", Offset = "0x2824890", VA = "0x182825A90")]
	public static NativeArray<byte> OJEJJAOBCPK(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2C67360", Offset = "0x2C66160", VA = "0x182C67360")]
	public static NativeArray<byte> OJEJJAOBCPK<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2825890", Offset = "0x2824690", VA = "0x182825890")]
	public static NativeArray<byte> DHJIGDKLEJD(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2C65DC0", Offset = "0x2C64BC0", VA = "0x182C65DC0")]
	public static NativeArray<byte> DHJIGDKLEJD<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2825A10", Offset = "0x2824810", VA = "0x182825A10")]
	public static NativeArray<byte> JNBHMLCCDDP(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2C65E20", Offset = "0x2C64C20", VA = "0x182C65E20")]
	public static NativeArray<byte> JNBHMLCCDDP<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class OGDIBALDCID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private NativeList<byte> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2834DE0", Offset = "0x2833BE0", VA = "0x182834DE0")]
	public OGDIBALDCID(NativeList<byte> LPDILHBGHIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x283C1A0", Offset = "0x283AFA0", VA = "0x18283C1A0")]
	public static OGDIBALDCID PAAEKNCKHBI(NativeList<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	public void KLNDOHCMIPB<T>(in T IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	public void JBAHKNIGOHH<T>(NativeArray<T> IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	public void KGBDFBDIBBA<T>(NativeArray<T> IGJPNMBCJPK) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	[EBJHGMECDNA(typeof(PropertyChangeNetworkRouter), new string[] { })]
	public class PropertyChangeNetworkRouter : DFDLCPDHDGP, FDFFINEAOHD, GMPBHDKHOML, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private AJAOFNBLAEO MGGGHPDHPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DOAILCELKFK MLMFBHHJDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private GKJELINCFGM GMKKBMEMHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private KPOGCKFKBHN LDKIDFGEOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private FNGBJBLKAGG OOCIDKJPIOF;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AJAOFNBLAEO FOPMCHJHEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x286E620", Offset = "0x286D420", VA = "0x18286E620")]
		public AJAOFNBLAEO.FLKBEGGKJAK EMJANLIPHLL()
		{
			return default(AJAOFNBLAEO.FLKBEGGKJAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x286E7D0", Offset = "0x286D5D0", VA = "0x18286E7D0", Slot = "4")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x286E640", Offset = "0x286D440", VA = "0x18286E640", Slot = "5")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x286E6F0", Offset = "0x286D4F0", VA = "0x18286E6F0")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x286E090", Offset = "0x286CE90", VA = "0x18286E090")]
		public void BBALAJBEALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x286E1C0", Offset = "0x286CFC0", VA = "0x18286E1C0")]
		private void CDNHMDGGJND(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x286E850", Offset = "0x286D650", VA = "0x18286E850")]
		private void PMHJCCMIPME(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x286E710", Offset = "0x286D510", VA = "0x18286E710")]
		private void JGHIEEKMOGH(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x286E600", Offset = "0x286D400", VA = "0x18286E600")]
		private void EIOFHIIOEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x286E830", Offset = "0x286D630", VA = "0x18286E830")]
		private void OFHHJDAAEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x286E4F0", Offset = "0x286D2F0", VA = "0x18286E4F0")]
		private void DBNOLHGKCJK(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x39E2BB0", Offset = "0x39E19B0", VA = "0x1839E2BB0", Slot = "6")]
		private void CPJJPHAHFBM<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, object NAHJDDBGMOA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x286E5E0", Offset = "0x286D3E0", VA = "0x18286E5E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[EBJHGMECDNA(typeof(EHEEEHIAJEK), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class EHEEEHIAJEK : FDFFINEAOHD, CDAFEBOKDJF
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly GMMEMAKMEGH CELOJELHLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private GNLAPDIIDJD GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private BBNANJDJDKF OPAAEBMKPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PropertyChangeNetworkRouter DOCHMGEDDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private JLCDNMLCNEN FKKCKLABEMK;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C980", Offset = "0x2C3B780", VA = "0x182C3C980", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CBA0", Offset = "0x2C3B9A0", VA = "0x182C3CBA0", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C8A0", Offset = "0x2C3B6A0", VA = "0x182C3C8A0")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CD80", Offset = "0x2C3BB80", VA = "0x182C3CD80")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH NBLOFIBAGPM, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CA60", Offset = "0x2C3B860", VA = "0x182C3CA60")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C7F0", Offset = "0x2C3B5F0", VA = "0x182C3C7F0")]
	private void GNAEPMLLAHH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CCA0", Offset = "0x2C3BAA0", VA = "0x182C3CCA0")]
	public void NNLLHPJFGFJ(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH NBLOFIBAGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C6D0", Offset = "0x2C3B4D0", VA = "0x182C3C6D0")]
	private void FOIPNFGCADH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CE10", Offset = "0x2C3BC10", VA = "0x182C3CE10")]
	public EHEEEHIAJEK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[DebuggerTypeProxy(typeof(CDHPABBFADE))]
	[IFBLAMOEMKH(CMGBDLINHMB.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		internal class CDHPABBFADE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private readonly ActionBuffer CLABEIKAHOI;

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public int MNCJKLLDCNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x35FF850", Offset = "0x35FE650", VA = "0x1835FF850")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public PNOAMILFIOA[] EKMFDNHBMAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x35FF8A0", Offset = "0x35FE6A0", VA = "0x1835FF8A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
			public CDHPABBFADE(ActionBuffer NGHDPLBLION)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x35FF970", Offset = "0x35FE770", VA = "0x1835FF970")]
			[CompilerGenerated]
			private PNOAMILFIOA POCDMFGJEKO(DNOIGEFBDOI CGKOOFFNHKL)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		internal class PNOAMILFIOA : GMPBHDKHOML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private readonly ActionBuffer CLABEIKAHOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private readonly DNOIGEFBDOI CGKOOFFNHKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<(FNGBJBLKAGG, string, object)> EMOEAFOOMOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private DFNLOEACJNA ANKKMEDLEHC;

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public int MNCJKLLDCNE
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x360B3C0", Offset = "0x360A1C0", VA = "0x18360B3C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public List<(FNGBJBLKAGG, string, object)> NHKMBMIHGFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x360B510", Offset = "0x360A310", VA = "0x18360B510")]
			public PNOAMILFIOA(ActionBuffer NGHDPLBLION, DNOIGEFBDOI CGKOOFFNHKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x360B410", Offset = "0x360A210", VA = "0x18360B410")]
			private string MNNGHMGNCLK(FNGBJBLKAGG OOCIDKJPIOF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x360B080", Offset = "0x3609E80", VA = "0x18360B080")]
			private void ENJHCNHMIBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x292DA10", Offset = "0x292C810", VA = "0x18292DA10", Slot = "4")]
			public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeList<byte> MMEEGBIBNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Stack<DNOIGEFBDOI> MNEJHIAAOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly KANEHMFPCBA PCOFEBKMEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly PFMJKBAICGE DOPKECBLDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GKJELINCFGM GMKKBMEMHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly bool LFNJOLCMBEF;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public MIDCJAGGIEB MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2C29B70", Offset = "0x2C28970", VA = "0x182C29B70")]
			get
			{
				return default(MIDCJAGGIEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2C29B30", Offset = "0x2C28930", VA = "0x182C29B30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2C2A390", Offset = "0x2C29190", VA = "0x182C2A390")]
		public ActionBuffer(PFMJKBAICGE DOPKECBLDKN, GKJELINCFGM GMKKBMEMHOP, bool LFNJOLCMBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2C29640", Offset = "0x2C28440", VA = "0x182C29640")]
		public bool AOHIPLPKOPI(out DNOIGEFBDOI CGKOOFFNHKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2C29BB0", Offset = "0x2C289B0", VA = "0x182C29BB0")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2C296D0", Offset = "0x2C284D0", VA = "0x182C296D0")]
		public DNOIGEFBDOI BBALAJBEALO(PCCDBOGEHKL EMOEAFOOMOP, OMEALIIIEBE HKLMDPOAHBO, uint MACLFOOLELI)
		{
			return default(DNOIGEFBDOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2C2A310", Offset = "0x2C29110", VA = "0x182C2A310")]
		public bool PGPNAAAHLHB(uint MACLFOOLELI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2C29EB0", Offset = "0x2C28CB0", VA = "0x182C29EB0")]
		public bool NLOBGHHGCBK(uint MACLFOOLELI, out DNOIGEFBDOI MCOKHJALNGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2C29810", Offset = "0x2C28610", VA = "0x182C29810")]
		public void BICGJHKILCF(DNOIGEFBDOI MCOKHJALNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2C29C20", Offset = "0x2C28A20", VA = "0x182C29C20")]
		[Conditional("DEBUG_BUILD")]
		private void LICEHBBBAGP(DNOIGEFBDOI MCOKHJALNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2C29D60", Offset = "0x2C28B60", VA = "0x182C29D60")]
		private void MNKKCLEBONM(DNOIGEFBDOI CPFNLJNHLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2C2A0A0", Offset = "0x2C28EA0", VA = "0x182C2A0A0")]
		private void NNPIEJGEBCL(DFNLOEACJNA PNAPLCCMKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2C29980", Offset = "0x2C28780", VA = "0x182C29980")]
		private void DFGKMIHFNDC(DNOIGEFBDOI CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2C29A50", Offset = "0x2C28850", VA = "0x182C29A50")]
		private DFNLOEACJNA GMMABANMJAE(DNOIGEFBDOI CGKOOFFNHKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2C299E0", Offset = "0x2C287E0", VA = "0x182C299E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal class KANEHMFPCBA : GMPBHDKHOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NMEJDFJAOOA JBKJOONHJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private DFNLOEACJNA NBEICHBHPDD;

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6576E0", Offset = "0x6564E0", VA = "0x1806576E0")]
	public KANEHMFPCBA(PFMJKBAICGE DOPKECBLDKN, GKJELINCFGM GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2545C00", Offset = "0x2544A00", VA = "0x182545C00", Slot = "4")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> OEIAJJJNONB, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2830CF0", Offset = "0x282FAF0", VA = "0x182830CF0")]
	public void ICJPMMDCBBM(FNGBJBLKAGG OOCIDKJPIOF, ref DFNLOEACJNA PNAPLCCMKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class AJAOFNBLAEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct FLKBEGGKJAK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly AJAOFNBLAEO ADECAOLBLPJ;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3602790", Offset = "0x3601590", VA = "0x183602790")]
		public FLKBEGGKJAK(AJAOFNBLAEO ADECAOLBLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3602770", Offset = "0x3601570", VA = "0x183602770", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected PCCDBOGEHKL EMOEAFOOMOP;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public PCCDBOGEHKL NHKMBMIHGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2C276D0", Offset = "0x2C264D0", VA = "0x182C276D0")]
		get
		{
			return default(PCCDBOGEHKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool IDBIMIDLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2C277F0", Offset = "0x2C265F0", VA = "0x182C277F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2C27990", Offset = "0x2C26790", VA = "0x182C27990")]
	public AJAOFNBLAEO(PCCDBOGEHKL.NJDDOFJAKLO FLLNAFOKHKF = PCCDBOGEHKL.NJDDOFJAKLO.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2C276C0", Offset = "0x2C264C0", VA = "0x182C276C0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2C275D0", Offset = "0x2C263D0", VA = "0x182C275D0")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2C27900", Offset = "0x2C26700", VA = "0x182C27900")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2C27710", Offset = "0x2C26510", VA = "0x182C27710")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2C274A0", Offset = "0x2C262A0", VA = "0x182C274A0")]
	public void EIOFHIIOEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2C27800", Offset = "0x2C26600", VA = "0x182C27800")]
	public void OFHHJDAAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2C27490", Offset = "0x2C26290", VA = "0x182C27490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2C275A0", Offset = "0x2C263A0", VA = "0x182C275A0")]
	public FLKBEGGKJAK EMJANLIPHLL()
	{
		return default(FLKBEGGKJAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FNGBJBLKAGG : IComparable<FNGBJBLKAGG>, IEquatable<FNGBJBLKAGG>
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static readonly FNGBJBLKAGG JHKNBKMIJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NMEJDFJAOOA JBKJOONHJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public JLCDNMLCNEN ABEODFEGJBP;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x26689E0", Offset = "0x26677E0", VA = "0x1826689E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x676E50", VA = "0x180678050")]
	public FNGBJBLKAGG(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x28276E0", Offset = "0x28264E0", VA = "0x1828276E0")]
	public void CIELANHJLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2827730", Offset = "0x2826530", VA = "0x182827730", Slot = "4")]
	public int CompareTo(FNGBJBLKAGG HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x28278F0", Offset = "0x28266F0", VA = "0x1828278F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2827770", Offset = "0x2826570", VA = "0x182827770", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2827810", Offset = "0x2826610", VA = "0x182827810", Slot = "5")]
	public bool Equals(FNGBJBLKAGG HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x28276F0", Offset = "0x28264F0", VA = "0x1828276F0")]
	public static bool CJJJLAGEFIA(FNGBJBLKAGG AIAIDPGGDMM, FNGBJBLKAGG PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x28278A0", Offset = "0x28266A0", VA = "0x1828278A0")]
	public static bool HNHKEOFMCPG(FNGBJBLKAGG AIAIDPGGDMM, FNGBJBLKAGG PHPKEGMGOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2827860", Offset = "0x2826660", VA = "0x182827860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class GMMEMAKMEGH : FFKLAMKJFED
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NMEJDFJAOOA JBKJOONHJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private BBNANJDJDKF OPAAEBMKPAD;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x28293E0", Offset = "0x28281E0", VA = "0x1828293E0")]
	public void FMDFEBBBNGL(NMEJDFJAOOA JBKJOONHJLG, PFMJKBAICGE DOPKECBLDKN, BBNANJDJDKF OPAAEBMKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x28294F0", Offset = "0x28282F0", VA = "0x1828294F0", Slot = "4")]
	private void JIBFDNGLIKM(FJCEHGNCBHG HLOAMKBCFBD, in MJADMLMEADH IGJPNMBCJPK, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public GMMEMAKMEGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CEGIDICONDL
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E900", Offset = "0x2C2D700", VA = "0x182C2E900")]
	public static void PMHJCCMIPME(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E6A0", Offset = "0x2C2D4A0", VA = "0x182C2E6A0")]
	public static void DFCNCGBBNCO(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E810", Offset = "0x2C2D610", VA = "0x182C2E810")]
	public static void JGHIEEKMOGH(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E760", Offset = "0x2C2D560", VA = "0x182C2E760")]
	public static void DPKALFJIABE(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E8B0", Offset = "0x2C2D6B0", VA = "0x182C2E8B0")]
	public static EGINIKJHFLB OCMFIABCIME(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
		return default(EGINIKJHFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x25EE360", Offset = "0x25ED160", VA = "0x1825EE360")]
	public static T JDBCMJCKMFA<T>(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x25EE330", Offset = "0x25ED130", VA = "0x1825EE330")]
	public static T JDBCMJCKMFA<T>(ref DFNLOEACJNA JANIFNADDOP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E860", Offset = "0x2C2D660", VA = "0x182C2E860")]
	public static EGINIKJHFLB OCMFIABCIME(ref DFNLOEACJNA JANIFNADDOP)
	{
		return default(EGINIKJHFLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PCCDBOGEHKL : IEnumerable<FNGBJBLKAGG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum NJDDOFJAKLO
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private struct JHIJODPMNDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly PCCDBOGEHKL LPDILHBGHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly OMEALIIIEBE HKLMDPOAHBO;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3606B50", Offset = "0x3605950", VA = "0x183606B50")]
		public JHIJODPMNDK(PCCDBOGEHKL LPDILHBGHIJ, OMEALIIIEBE HKLMDPOAHBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3606820", Offset = "0x3605620", VA = "0x183606820")]
		public void OHOPKGJFIIG(NativeList<byte> KCFDLMABGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3606350", Offset = "0x3605150", VA = "0x183606350")]
		private void DIDCFOHFPIO(FNGBJBLKAGG OOCIDKJPIOF, ref LADBHLGEIAG LOBIAKACGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3606AC0", Offset = "0x36058C0", VA = "0x183606AC0")]
		private void OPFBMFPCDAI(FNGBJBLKAGG OOCIDKJPIOF, ref LADBHLGEIAG LOBIAKACGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3606260", Offset = "0x3605060", VA = "0x183606260")]
		private NativeArray<byte> DGGBLLIKJKE(NativeList<byte> KCFDLMABGLC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x36063A0", Offset = "0x36051A0", VA = "0x1836063A0")]
		private NativeArray<byte> DPFFEOIDPFJ(NativeList<byte> KCFDLMABGLC, int GKPOMAIMOAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3606490", Offset = "0x3605290", VA = "0x183606490")]
		private int FFCFNADCOCO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x36066C0", Offset = "0x36054C0", VA = "0x1836066C0")]
		private bool HNHCDLDCBKL(FNGBJBLKAGG OOCIDKJPIOF, out NativeArray<byte> JGJDDPHHAJI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct AHPENAOMGDJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private NativeList<byte> JANIFNADDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private PCCDBOGEHKL LPDILHBGHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly FNGBJBLKAGG IKPEGPHMIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly int FOACNEHDHLI;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x35FF0C0", Offset = "0x35FDEC0", VA = "0x1835FF0C0")]
		internal AHPENAOMGDJ(PCCDBOGEHKL LPDILHBGHIJ, FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x35FEE40", Offset = "0x35FDC40", VA = "0x1835FEE40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x35FEED0", Offset = "0x35FDCD0", VA = "0x1835FEED0")]
		public void MNMMOHPJBAG(NativeArray<byte> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x35FEE70", Offset = "0x35FDC70", VA = "0x1835FEE70")]
		public void LOAAJLCEDOJ(NativeArray<byte> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x35FF0B0", Offset = "0x35FDEB0", VA = "0x1835FF0B0")]
		public void OPFBMFPCDAI(in MJADMLMEADH IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x25076C0", Offset = "0x25064C0", VA = "0x1825076C0")]
		public void OPFBMFPCDAI<T>(T IGJPNMBCJPK) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x35FEF90", Offset = "0x35FDD90", VA = "0x1835FEF90")]
		private void OIBAELPIFGF(int IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x35FF000", Offset = "0x35FDE00", VA = "0x1835FF000")]
		private void OIBAELPIFGF(in MJADMLMEADH IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x35FEF30", Offset = "0x35FDD30", VA = "0x1835FEF30")]
		private unsafe void OIBAELPIFGF(void* JKEHENDBNEL, int GKPOMAIMOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x35FEED0", Offset = "0x35FDCD0", VA = "0x1835FEED0")]
		private void OIBAELPIFGF(NativeArray<byte> ICAAAENIBKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct FLIPDAJLJCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private PCCDBOGEHKL LPDILHBGHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private NativeArray<byte> JANIFNADDOP;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3602730", Offset = "0x3601530", VA = "0x183602730")]
		internal FLIPDAJLJCG(PCCDBOGEHKL LPDILHBGHIJ, NativeArray<byte> JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3602470", Offset = "0x3601270", VA = "0x183602470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3602480", Offset = "0x3601280", VA = "0x183602480")]
		public NativeArray<byte> EKHBPDLBOLE(int GKPOMAIMOAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3602640", Offset = "0x3601440", VA = "0x183602640")]
		public NativeArray<byte> KIDLKJHGFME()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x250BB60", Offset = "0x250A960", VA = "0x18250BB60")]
		public T ICHDBDEGGEB<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3602540", Offset = "0x3601340", VA = "0x183602540")]
		public void ICHDBDEGGEB(in ECNLJAAGJFG IGJPNMBCJPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct KGGCAOCDBPP : IEnumerator<FNGBJBLKAGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly NativeArray<FNGBJBLKAGG> DEJEDNNJILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int AIPHGHFENPJ;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public FNGBJBLKAGG MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x3607290", Offset = "0x3606090", VA = "0x183607290", Slot = "4")]
			get
			{
				return default(FNGBJBLKAGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x3607250", Offset = "0x3606050", VA = "0x183607250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2C22EA0", Offset = "0x2C21CA0", VA = "0x182C22EA0")]
		internal KGGCAOCDBPP(NativeArray<FNGBJBLKAGG> ICAAAENIBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x36071A0", Offset = "0x3605FA0", VA = "0x1836071A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3607210", Offset = "0x3606010", VA = "0x183607210", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct BICHFACMBJK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private const int DKADNKFJDKJ = 0;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private const int IOOEBBLHIFL = 1;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private const int PFMHMNGIHBF = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NativeArray<int> JANIFNADDOP;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public int LPNHFLONAAC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x35FF560", Offset = "0x35FE360", VA = "0x1835FF560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x35FF620", Offset = "0x35FE420", VA = "0x1835FF620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public NJDDOFJAKLO MHCBPJALCOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x35FF5D0", Offset = "0x35FE3D0", VA = "0x1835FF5D0")]
			get
			{
				return default(NJDDOFJAKLO);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x35FF610", Offset = "0x35FE410", VA = "0x1835FF610")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool IDBIMIDLBJF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x35FF600", Offset = "0x35FE400", VA = "0x1835FF600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x35FF5B0", Offset = "0x35FE3B0", VA = "0x1835FF5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool LCHHGMADKKG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x35FF630", Offset = "0x35FE430", VA = "0x1835FF630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x35FF5E0", Offset = "0x35FE3E0", VA = "0x1835FF5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x35FF680", Offset = "0x35FE480", VA = "0x1835FF680")]
		public BICHFACMBJK(NJDDOFJAKLO FLLNAFOKHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x35FF530", Offset = "0x35FE330", VA = "0x1835FF530")]
		private int BOPAOPJOHPG(int LBACAALGKLG, int ADAGEIIBOOC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x35FF640", Offset = "0x35FE440", VA = "0x1835FF640")]
		private void PIGMJENILDA(int LBACAALGKLG, int IGJPNMBCJPK, int ADAGEIIBOOC = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x35FF570", Offset = "0x35FE370", VA = "0x1835FF570", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private const int ECAOKMMBJDB = -1;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private const int LFMBNNMLIHP = 0;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly FNGBJBLKAGG CIGDCEBOJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private NativeHashMap<FNGBJBLKAGG, int> JLJODCBLLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NativeList<FNGBJBLKAGG> EMOEAFOOMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private NativeList<int> NDAADHJDJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private NativeList<byte> FCLBNFFJEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NativeList<byte> JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private BICHFACMBJK PJGALDPNBKH;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool IDBIMIDLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2866AA0", Offset = "0x28658A0", VA = "0x182866AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool NMLHCBNDABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2866A40", Offset = "0x2865840", VA = "0x182866A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LPNHFLONAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2866660", Offset = "0x2865460", VA = "0x182866660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int FDLFNBJLCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2866A60", Offset = "0x2865860", VA = "0x182866A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2866760", Offset = "0x2865560", VA = "0x182866760")]
	public static PCCDBOGEHKL DAKLFHBAJIH(NJDDOFJAKLO FLLNAFOKHKF = NJDDOFJAKLO.Last, int MBPNGLLEBOJ = 16, int DJJPPHBDPJF = 256)
	{
		return default(PCCDBOGEHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2867160", Offset = "0x2865F60", VA = "0x182867160")]
	private PCCDBOGEHKL(NJDDOFJAKLO FLLNAFOKHKF, int MBPNGLLEBOJ, int DJJPPHBDPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x28667A0", Offset = "0x28655A0", VA = "0x1828667A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x28665D0", Offset = "0x28653D0", VA = "0x1828665D0")]
	public AHPENAOMGDJ CDNHMDGGJND(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(AHPENAOMGDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2866AB0", Offset = "0x28658B0", VA = "0x182866AB0")]
	public FLIPDAJLJCG KHOGOOFJPNF(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(FLIPDAJLJCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2866D80", Offset = "0x2865B80", VA = "0x182866D80")]
	public bool MJGILDABEFF(FNGBJBLKAGG IKPEGPHMIII, out FLIPDAJLJCG KKJNDEPMACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2866B40", Offset = "0x2865940", VA = "0x182866B40")]
	public bool LMPMKEPAAAO(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2866480", Offset = "0x2865280", VA = "0x182866480")]
	public bool AFAPKFKLOPA(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x2866F70", Offset = "0x2865D70", VA = "0x182866F70")]
	public void OEICDAKEGLC(NativeList<byte> KCFDLMABGLC, OMEALIIIEBE HKLMDPOAHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x2C19DE0", Offset = "0x2C18BE0", VA = "0x182C19DE0")]
	public T FMDMOKNGPIL<T>(FNGBJBLKAGG IKPEGPHMIII) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2866970", Offset = "0x2865770", VA = "0x182866970")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2866550", Offset = "0x2865350", VA = "0x182866550")]
	public KGGCAOCDBPP BALJJOIEHDJ()
	{
		return default(KGGCAOCDBPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2866B90", Offset = "0x2865990", VA = "0x182866B90")]
	private void MCFOLNMELLB(FNGBJBLKAGG IKPEGPHMIII, int FOACNEHDHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2866670", Offset = "0x2865470", VA = "0x182866670")]
	private void CIELANHJLDB(int GKNKFNJFDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2866880", Offset = "0x2865680", VA = "0x182866880")]
	private void FMBEEPJHKAK(FNGBJBLKAGG IKPEGPHMIII, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x309A5C0", Offset = "0x30993C0", VA = "0x18309A5C0")]
	private static T FMDMOKNGPIL<T>(NativeArray<byte> DEJEDNNJILK, int LBACAALGKLG = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x28670A0", Offset = "0x2865EA0", VA = "0x1828670A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2867060", Offset = "0x2865E60", VA = "0x182867060", Slot = "4")]
	private IEnumerator<FNGBJBLKAGG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal abstract class LBBEJFMFHLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private uint CLHKJFCIEDM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public abstract uint GLCFMPLCBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x9487A0", Offset = "0x9475A0", VA = "0x1809487A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2834E10", Offset = "0x2833C10", VA = "0x182834E10")]
	public NMEJDFJAOOA GAPONIFMOKO()
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2834E60", Offset = "0x2833C60", VA = "0x182834E60")]
	public void LHCAAPHDADA(NMEJDFJAOOA BHJEHPEEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xF3EEE0", Offset = "0xF3DCE0", VA = "0x180F3EEE0", Slot = "6")]
	public virtual void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	protected LBBEJFMFHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[EBJHGMECDNA(typeof(ADONFIKCCKK), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal sealed class ADONFIKCCKK : LBBEJFMFHLN, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private uint BCGICHENIFM;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public override uint GLCFMPLCBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C26290", Offset = "0x2C25090", VA = "0x182C26290", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C26240", Offset = "0x2C25040", VA = "0x182C26240")]
	private void FIDHMGDKEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C261E0", Offset = "0x2C24FE0", VA = "0x182C261E0", Slot = "6")]
	public override void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	public ADONFIKCCKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[EBJHGMECDNA(typeof(HOLDGPOECHF), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal sealed class HOLDGPOECHF : LBBEJFMFHLN
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public override uint GLCFMPLCBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65CF70", VA = "0x18065E170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public HOLDGPOECHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[JAPBKNDOGGF(typeof(ObjectEmbodimentService))]
[JAPBKNDOGGF(typeof(ObjectNetworkToLocalMapService))]
[JAPBKNDOGGF(typeof(CLDGLLOBFOG))]
[EBJHGMECDNA(typeof(GALJPCEPKLP), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class GALJPCEPKLP : FDFFINEAOHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private AOAMPDCFJGB BECAEADJGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ObjectEmbodimentService DNCNJICBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private CLDGLLOBFOG MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EnableComponentSystemsInScope LONAHEEOECC;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x2828460", Offset = "0x2827260", VA = "0x182828460")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x28284B0", Offset = "0x28272B0", VA = "0x1828284B0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x28281B0", Offset = "0x2826FB0", VA = "0x1828281B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private void ODFDNIMGHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2828060", Offset = "0x2826E60", VA = "0x182828060")]
	private void BBOJCHACFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public GALJPCEPKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(CLDGLLOBFOG), new string[] { })]
internal sealed class CLDGLLOBFOG : BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private EntityQuery JPMMLGEJNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private EntityQuery ABBKLHAPGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private EntityQuery HELHJFODOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private EntityQuery BCEHNLIAOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private EntityQuery BGNODAFLBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FA40", Offset = "0x2C2E840", VA = "0x182C2FA40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EntityQuery FDBIBPLOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xFAA700", Offset = "0xFA9500", VA = "0x180FAA700")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EntityQuery CNOAPBHNMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9C2A30", Offset = "0x9C1830", VA = "0x1809C2A30")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EntityQuery HCHPCGPFAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AC970", Offset = "0x7AB770", VA = "0x1807AC970")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EntityQuery JNPBIGEPDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FFA0", Offset = "0x2C2EDA0", VA = "0x182C2FFA0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int PNKDFLFLNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FF80", Offset = "0x2C2ED80", VA = "0x182C2FF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int BONIDMJCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C300E0", Offset = "0x2C2EEE0", VA = "0x182C300E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int CKNCNGDFGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C30020", Offset = "0x2C2EE20", VA = "0x182C30020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int BOLFPJPMFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FB30", Offset = "0x2C2E930", VA = "0x182C2FB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int BOLPGKAGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C2F6D0", Offset = "0x2C2E4D0", VA = "0x182C2F6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FB50", Offset = "0x2C2E950", VA = "0x182C2FB50", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FC70", Offset = "0x2C2EA70", VA = "0x182C2FC70", Slot = "6")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F9E0", Offset = "0x2C2E7E0", VA = "0x182C2F9E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F940", Offset = "0x2C2E740", VA = "0x182C2F940")]
	public CAOGEMEHCPI DAAPCIDKLDP()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F6F0", Offset = "0x2C2E4F0", VA = "0x182C2F6F0")]
	public CAOGEMEHCPI BIIJNFGAHFG()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FA90", Offset = "0x2C2E890", VA = "0x182C2FA90")]
	public CAOGEMEHCPI GGENMNLMPAD()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F7E0", Offset = "0x2C2E5E0", VA = "0x182C2F7E0")]
	public PDCBPHNLNBN BPHEMGAFBAH(PMMHBDBEGAM JBKJOONHJLG)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F890", Offset = "0x2C2E690", VA = "0x182C2F890")]
	public PDCBPHNLNBN BPHEMGAFBAH(Entity GEEFHDFLBEH)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FBC0", Offset = "0x2C2E9C0", VA = "0x182C2FBC0")]
	public CBLLNBPHCKJ KEOMIGEONAO(Entity GEEFHDFLBEH)
	{
		return default(CBLLNBPHCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C30040", Offset = "0x2C2EE40", VA = "0x182C30040")]
	private CAOGEMEHCPI PFOKOGKMFHO(EntityQuery JFPFDEFJDBP)
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x19A57C0", Offset = "0x19A45C0", VA = "0x1819A57C0")]
	public CLDGLLOBFOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[EBJHGMECDNA(typeof(CBIPFLGDJEF), new string[] { })]
public class EAGKPAGKLLG : FDFFINEAOHD, CBIPFLGDJEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private EEDGKMIDAFH JLJNFPKFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ObjectLifecycleService NEINDNLHEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private ObjectEmbodimentService DNCNJICBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private ObjectNetworkToLocalMapService DNGOCFEOHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private CLDGLLOBFOG MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public int PNKDFLFLNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C4F0", Offset = "0x2C3B2F0", VA = "0x182C3C4F0", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int BONIDMJCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C620", Offset = "0x2C3B420", VA = "0x182C3C620", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int CKNCNGDFGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C5F0", Offset = "0x2C3B3F0", VA = "0x182C3C5F0", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int BOLFPJPMFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B900", Offset = "0x2C3A700", VA = "0x182C3B900", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int BOLPGKAGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AF40", Offset = "0x2C39D40", VA = "0x182C3AF40", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int HJDHFKEEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C0F0", Offset = "0x2C3AEF0", VA = "0x182C3C0F0", Slot = "43")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int AKKJDCEMEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C3C3A0", Offset = "0x2C3B1A0", VA = "0x182C3C3A0", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<PMMHBDBEGAM, CBLLNBPHCKJ> PENFFKIPBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C3BF80", Offset = "0x2C3AD80", VA = "0x182C3BF80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B500", Offset = "0x2C3A300", VA = "0x182C3B500", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<PMMHBDBEGAM> NNDDOAEECDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C3BEC0", Offset = "0x2C3ACC0", VA = "0x182C3BEC0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C3B860", Offset = "0x2C3A660", VA = "0x182C3B860", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B9B0", Offset = "0x2C3A7B0", VA = "0x182C3B9B0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B360", Offset = "0x2C3A160", VA = "0x182C3B360", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C110", Offset = "0x2C3AF10", VA = "0x182C3C110")]
	private void LCDPHGCPODA(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B470", Offset = "0x2C3A270", VA = "0x182C3B470")]
	private void ECCCDPILENL(Entity GEEFHDFLBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AF20", Offset = "0x2C39D20", VA = "0x182C3AF20")]
	internal PMMHBDBEGAM AHLIDNNPJGI(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B290", Offset = "0x2C3A090", VA = "0x182C3B290", Slot = "39")]
	public CAOGEMEHCPI DAAPCIDKLDP()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AFC0", Offset = "0x2C39DC0", VA = "0x182C3AFC0", Slot = "40")]
	public CAOGEMEHCPI BIIJNFGAHFG()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B770", Offset = "0x2C3A570", VA = "0x182C3B770", Slot = "41")]
	public CAOGEMEHCPI GGENMNLMPAD()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B0D0", Offset = "0x2C39ED0", VA = "0x182C3B0D0", Slot = "10")]
	public PDCBPHNLNBN BPHEMGAFBAH(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C020", Offset = "0x2C3AE20", VA = "0x182C3C020", Slot = "11")]
	public CBLLNBPHCKJ KEOMIGEONAO(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(CBLLNBPHCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AEF0", Offset = "0x2C39CF0", VA = "0x182C3AEF0", Slot = "32")]
	public bool AEBBOEKMPNE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AEA0", Offset = "0x2C39CA0", VA = "0x182C3AEA0", Slot = "28")]
	public void ACKFNLGGLJE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B220", Offset = "0x2C3A020", VA = "0x182C3B220", Slot = "29")]
	public void CHMNDPKCMOJ(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C470", Offset = "0x2C3B270", VA = "0x182C3C470", Slot = "30")]
	public void NONGHDEHHOE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B930", Offset = "0x2C3A730", VA = "0x182C3B930", Slot = "22")]
	public FEMMDHLANDH HFJOEDICIOL(CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C2E0", Offset = "0x2C3B0E0", VA = "0x182C3C2E0", Slot = "23")]
	public FEMMDHLANDH MHKAFBIPHPF(CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C520", Offset = "0x2C3B320", VA = "0x182C3C520", Slot = "24")]
	public FEMMDHLANDH PACACJLKIEO(NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B6D0", Offset = "0x2C3A4D0", VA = "0x182C3B6D0", Slot = "25")]
	public DJFJGAJKGKD GEAJKNPCODP()
	{
		return default(DJFJGAJKGKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C3BC10", Offset = "0x2C3AA10", VA = "0x182C3BC10", Slot = "42")]
	public MIABGLBICKE IHEGMFIAJED(EFCIKLEKING NKICFHCCMMH)
	{
		return default(MIABGLBICKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B5A0", Offset = "0x2C3A3A0", VA = "0x182C3B5A0", Slot = "26")]
	public POGPGKFDCLE FECCIBCHBLN()
	{
		return default(POGPGKFDCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C3C0", Offset = "0x2C3B1C0", VA = "0x182C3C3C0", Slot = "27")]
	public DJFHIDPOABC NOBCDOCLECL(FEJKANODFOG NKICFHCCMMH)
	{
		return default(DJFHIDPOABC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C650", Offset = "0x2C3B450", VA = "0x182C3C650", Slot = "12")]
	public void PJHBAIJLMNC(NMEJDFJAOOA DBGIPPEDJIM, GIALAGJINEB FGEIHINONNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C1D0", Offset = "0x2C3AFD0", VA = "0x182C3C1D0", Slot = "13")]
	public FEMMDHLANDH LFOFKHPGLIF(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B1D0", Offset = "0x2C39FD0", VA = "0x182C3B1D0", Slot = "14")]
	public bool CECLHLMOAFB(PMMHBDBEGAM ADGJAILKBPO, out GIALAGJINEB BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C4A0", Offset = "0x2C3B2A0", VA = "0x182C3C4A0", Slot = "45")]
	public Transform OFFKLJGCIOM(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B650", Offset = "0x2C3A450", VA = "0x182C3B650", Slot = "16")]
	public bool FPFNOLCEKGF(PMMHBDBEGAM ADGJAILKBPO, out Transform BCHADNCHEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B190", Offset = "0x2C39F90", VA = "0x182C3B190", Slot = "17")]
	public bool CDOIOEBAIAC(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AFA0", Offset = "0x2C39DA0", VA = "0x182C3AFA0")]
	public bool BHOEHOJGMNO(GIALAGJINEB IGJPNMBCJPK, [Optional] object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AF70", Offset = "0x2C39D70", VA = "0x182C3AF70", Slot = "46")]
	public bool BHOEHOJGMNO(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2C3BBA0", Offset = "0x2C3A9A0", VA = "0x182C3BBA0", Slot = "47")]
	public void HKEPNALNJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2C3BCB0", Offset = "0x2C3AAB0", VA = "0x182C3BCB0", Slot = "15")]
	public void IIHMCLDDPGI(GIALAGJINEB CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C360", Offset = "0x2C3B160", VA = "0x182C3C360", Slot = "48")]
	public void NIMKLNCMIKA(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B340", Offset = "0x2C3A140", VA = "0x182C3B340", Slot = "18")]
	public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B270", Offset = "0x2C3A070", VA = "0x182C3B270", Slot = "19")]
	public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2C3BF60", Offset = "0x2C3AD60", VA = "0x182C3BF60", Slot = "49")]
	public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C1B0", Offset = "0x2C3AFB0", VA = "0x182C3C1B0", Slot = "50")]
	public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3BBC0", Offset = "0x2C3A9C0", VA = "0x182C3BBC0", Slot = "31")]
	public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
	{
		return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B6A0", Offset = "0x2C3A4A0", VA = "0x182C3B6A0", Slot = "21")]
	public NMEJDFJAOOA GAGENPHPDNI(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B820", Offset = "0x2C3A620", VA = "0x182C3B820", Slot = "20")]
	public PMMHBDBEGAM GJELMEFNGNA(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public EAGKPAGKLLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(JGLKPBCBPCD), new string[] { })]
internal sealed class JGLKPBCBPCD : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private CLDGLLOBFOG MAPPBNAKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2830040", Offset = "0x282EE40", VA = "0x182830040", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2830560", Offset = "0x282F360", VA = "0x182830560")]
	public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
	{
		return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2830660", Offset = "0x282F460", VA = "0x182830660")]
	private void PGEFBEAPHNN(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x28300D0", Offset = "0x282EED0", VA = "0x1828300D0")]
	private void HJMHHOHEACI(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB, int GFIKNFBJKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x282FEB0", Offset = "0x282ECB0", VA = "0x18282FEB0")]
	private void EKHJMELAAHL(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB, int GFIKNFBJKNP, NOBHGMEMAKH GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x282FB80", Offset = "0x282E980", VA = "0x18282FB80")]
	private NativeMultiHashMap<int, (PMMHBDBEGAM, PMMHBDBEGAM)> CCCJOFIOKGC(Allocator JEOILJEOOOI, NativeArray<PMMHBDBEGAM> CGGBICHOEDC, out NativeArray<(PMMHBDBEGAM src, PMMHBDBEGAM dst)> DCMEPDOGCMK)
	{
		return default(NativeMultiHashMap<int, (PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public JGLKPBCBPCD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics, new string[] { "Callbacks" })]
	[EBJHGMECDNA(typeof(DOFEFFJAEBG), new string[] { })]
	public class PhysicsService : FDFFINEAOHD, CDAFEBOKDJF, DOFEFFJAEBG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private const string NGJFDPMAJJK = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly CGJHBFGPOOL OHFHPDHGMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private KNJHNLNIBIP MFJHDOKFILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private PropertyEventCallbacksService OBJALHMPDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private global::ONBLNDNGCOE<AGIBDFHOBNC> NABMMLICENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<PMMHBDBEGAM, AGIBDFHOBNC> LKKOAGECGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x286BC90", Offset = "0x286AA90", VA = "0x18286BC90", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x286BD30", Offset = "0x286AB30", VA = "0x18286BD30", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x286BFF0", Offset = "0x286ADF0", VA = "0x18286BFF0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x286C110", Offset = "0x286AF10", VA = "0x18286C110", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x286BDD0", Offset = "0x286ABD0", VA = "0x18286BDD0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x286BF30", Offset = "0x286AD30", VA = "0x18286BF30", Slot = "8")]
		public void EGOGCMBFKGF(PMMHBDBEGAM ADGJAILKBPO, Vector3 BOMEDIENHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x286C530", Offset = "0x286B330", VA = "0x18286C530", Slot = "9")]
		public bool MJEKGLFLNDP(PMMHBDBEGAM ADGJAILKBPO, out Collider JDJCJCADDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x286C3B0", Offset = "0x286B1B0", VA = "0x18286C3B0")]
		private void LEIMCIGPFAK(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x286C470", Offset = "0x286B270", VA = "0x18286C470", Slot = "10")]
		public void MHGCCIIFFLE(PMMHBDBEGAM ADGJAILKBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PhysicsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
[EBJHGMECDNA(typeof(GNLAPDIIDJD), new string[] { })]
[JAPBKNDOGGF(typeof(ADBFMIBHACH))]
public class AGLAMIGKINP : GNLAPDIIDJD, IEnumerable<EGNDHFFDDFH>, IEnumerable, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<(Type, string), int> OMMBLPLAPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private ADBFMIBHACH GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private HJJIPEEBILL KCINBNOPKJE;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2C27270", Offset = "0x2C26070", VA = "0x182C27270", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public EGNDHFFDDFH MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2C272E0", Offset = "0x2C260E0", VA = "0x182C272E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public EGNDHFFDDFH MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2C272E0", Offset = "0x2C260E0", VA = "0x182C272E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2C27290", Offset = "0x2C26090", VA = "0x182C27290", Slot = "11")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2C26E60", Offset = "0x2C25C60", VA = "0x182C26E60", Slot = "12")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "13")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B40", Offset = "0x2C25940", VA = "0x182C26B40")]
	private void AEEMLNFIALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1627500", Offset = "0x1626300", VA = "0x181627500")]
	private string MPJCBKINOFO(string BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2C27190", Offset = "0x2C25F90", VA = "0x182C27190", Slot = "7")]
	public EGNDHFFDDFH HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2C26EE0", Offset = "0x2C25CE0", VA = "0x182C26EE0")]
	private bool HINDNOFJKBF(Type CJJNIEGEMMA, string BEMAPDNKPAD, out EGNDHFFDDFH KOPJKHIOCNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2C27300", Offset = "0x2C26100", VA = "0x182C27300", Slot = "8")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2C26E40", Offset = "0x2C25C40", VA = "0x182C26E40", Slot = "9")]
	public IEnumerator<EGNDHFFDDFH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2C26E40", Offset = "0x2C25C40", VA = "0x182C26E40", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2C27410", Offset = "0x2C26210", VA = "0x182C27410")]
	public AGLAMIGKINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[DefaultMember("Item")]
public interface OMEALIIIEBE
{
	[Cpp2IlInjected.Token(Token = "0x17000089")]
	int MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMJKEHCEABE(JLCDNMLCNEN FCDKMJOKGIE, out int MNKEEJPGFOP);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
[EBJHGMECDNA(typeof(OMEALIIIEBE), new string[] { })]
[JAPBKNDOGGF(typeof(GKJELINCFGM))]
public class MOHCPMJFOKI : FDFFINEAOHD, CDAFEBOKDJF, OMEALIIIEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<JLCDNMLCNEN, int> IPOKFIMAEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2838E80", Offset = "0x2837C80", VA = "0x182838E80", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2839160", Offset = "0x2837F60", VA = "0x182839160", Slot = "6")]
	public bool MMJKEHCEABE(JLCDNMLCNEN FCDKMJOKGIE, out int MNKEEJPGFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2838E20", Offset = "0x2837C20", VA = "0x182838E20", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2838EE0", Offset = "0x2837CE0", VA = "0x182838EE0", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2838EF0", Offset = "0x2837CF0", VA = "0x182838EF0")]
	private void LFFDHDOPOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x28391D0", Offset = "0x2837FD0", VA = "0x1828391D0")]
	public MOHCPMJFOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[JAPBKNDOGGF(typeof(GNLAPDIIDJD))]
[EBJHGMECDNA(typeof(GKJELINCFGM), new string[] { })]
[DefaultMember("Item")]
public class CGONEFNHILL : GKJELINCFGM, IEnumerable<AEFHEEDIBGN>, IEnumerable, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, GMPBHDKHOML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private GNLAPDIIDJD KOJFMENALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private AEFHEEDIBGN[] NBOEFHBOIKI;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2C2F580", Offset = "0x2C2E380", VA = "0x182C2F580", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public AEFHEEDIBGN MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2C2F590", Offset = "0x2C2E390", VA = "0x182C2F590", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AEFHEEDIBGN MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2C2F590", Offset = "0x2C2E390", VA = "0x182C2F590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "10")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F190", Offset = "0x2C2DF90", VA = "0x182C2F190", Slot = "11")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "12")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F450", Offset = "0x2C2E250", VA = "0x182C2F450", Slot = "6")]
	public AEFHEEDIBGN HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F5D0", Offset = "0x2C2E3D0", VA = "0x182C2F5D0", Slot = "7")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F0B0", Offset = "0x2C2DEB0", VA = "0x182C2F0B0", Slot = "8")]
	public IEnumerator<AEFHEEDIBGN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F6A0", Offset = "0x2C2E4A0", VA = "0x182C2F6A0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x20B1A10", Offset = "0x20B0810", VA = "0x1820B1A10", Slot = "13")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EF70", Offset = "0x2C2DD70", VA = "0x182C2EF70", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public CGONEFNHILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F590", Offset = "0x2C2E390", VA = "0x182C2F590")]
	[CompilerGenerated]
	private AEFHEEDIBGN IGLPAHEFELC(int HLAPKJLCEDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[EBJHGMECDNA(typeof(ODMPAIDMGCI), new string[] { })]
[DefaultMember("Item")]
[JAPBKNDOGGF(typeof(GNLAPDIIDJD))]
public class GGHCOKGNGOO : ODMPAIDMGCI, IEnumerable<EMNNOKKNGJD>, IEnumerable, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, GMPBHDKHOML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GNLAPDIIDJD KOJFMENALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EMNNOKKNGJD[] NBOEFHBOIKI;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2828A20", Offset = "0x2827820", VA = "0x182828A20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EMNNOKKNGJD MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x28285E0", Offset = "0x28273E0", VA = "0x1828285E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EMNNOKKNGJD MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x28285E0", Offset = "0x28273E0", VA = "0x1828285E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "9")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2828880", Offset = "0x2827680", VA = "0x182828880", Slot = "10")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2828A70", Offset = "0x2827870", VA = "0x182828A70", Slot = "11")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x28285F0", Offset = "0x28273F0", VA = "0x1828285F0")]
	private EMNNOKKNGJD CPBKPKLOJMD(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2828900", Offset = "0x2827700", VA = "0x182828900", Slot = "6")]
	public EMNNOKKNGJD HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2828CD0", Offset = "0x2827AD0", VA = "0x182828CD0", Slot = "15")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2828770", Offset = "0x2827570", VA = "0x182828770", Slot = "7")]
	public IEnumerator<EMNNOKKNGJD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2828770", Offset = "0x2827570", VA = "0x182828770", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x235CE90", Offset = "0x235BC90", VA = "0x18235CE90", Slot = "12")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x28286D0", Offset = "0x28274D0", VA = "0x1828286D0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public GGHCOKGNGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x28285E0", Offset = "0x28273E0", VA = "0x1828285E0")]
	[CompilerGenerated]
	private EMNNOKKNGJD ABGGFBEDOBE(int HLAPKJLCEDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(ADBFMIBHACH), new string[] { })]
internal class ADBFMIBHACH : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private GNLAPDIIDJD KOJFMENALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private ODMPAIDMGCI OLJNNGMFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private GKJELINCFGM EGIBEGMAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private global::IGNGPODGPHC<NOBHGMEMAKH> NKEPAMLDENG;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HJJIPEEBILL CHLPOINJLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D370", VA = "0x18065E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D390", VA = "0x18065E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2C253D0", Offset = "0x2C241D0", VA = "0x182C253D0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2C25500", Offset = "0x2C24300", VA = "0x182C25500")]
	private void HMAJIKOHHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x20212E0", Offset = "0x20200E0", VA = "0x1820212E0")]
	public T EPMJKFNKDLP<T>() where T : NOBHGMEMAKH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2C25300", Offset = "0x2C24100", VA = "0x182C25300")]
	public EGNDHFFDDFH GMMNBLBMMPB(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public global::ONBLNDNGCOE<T> GMMNBLBMMPB<T>(IDOKMGKMFNA BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2C255F0", Offset = "0x2C243F0", VA = "0x182C255F0")]
	public EMNNOKKNGJD OMLLLFEDHJG(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2021310", Offset = "0x2020110", VA = "0x182021310")]
	public global::JEBFFIPPOIH<T> OMLLLFEDHJG<T>(IDOKMGKMFNA BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2C25230", Offset = "0x2C24030", VA = "0x182C25230")]
	public AEFHEEDIBGN EMKLPEKGEPH(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	public global::PLGEJPKBGNG<T> EMKLPEKGEPH<T>(IDOKMGKMFNA BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ADBFMIBHACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class EMAOGJDPBOP
{
	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2F920", Offset = "0x1F2E720", VA = "0x181F2F920")]
	public static global::ONBLNDNGCOE<T> GMMNBLBMMPB<T>(this ADBFMIBHACH EHACOOBMGCP, global::NBBJGEJPPKL<T> BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	public static global::JEBFFIPPOIH<T> OMLLLFEDHJG<T>(this ADBFMIBHACH EHACOOBMGCP, global::NBBJGEJPPKL<T> BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	public static global::PLGEJPKBGNG<T> EMKLPEKGEPH<T>(this ADBFMIBHACH EHACOOBMGCP, global::NBBJGEJPPKL<T> BEMAPDNKPAD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[EBJHGMECDNA(typeof(OCLNFBFGOOC), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class OCLNFBFGOOC : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private PFMJKBAICGE DOPKECBLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private JLCDNMLCNEN[] JEGGLKCLIJM;

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x283BB60", Offset = "0x283A960", VA = "0x18283BB60", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x283BA40", Offset = "0x283A840", VA = "0x18283BA40")]
	public void FKLGBDDBJBJ(NMEJDFJAOOA DBGIPPEDJIM, bool MAGLHKOAFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OCLNFBFGOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[EBJHGMECDNA(typeof(LBLGPHMGKFA), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public sealed class LBLGPHMGKFA : FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class IHAMDNKGAMG : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5E0", Offset = "0x9DC3E0", VA = "0x1809DD5E0")]
		[DebuggerHidden]
		public IHAMDNKGAMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3604A20", Offset = "0x3603820", VA = "0x183604A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3604670", Offset = "0x3603470", VA = "0x183604670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3604AA0", Offset = "0x36038A0", VA = "0x183604AA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x36049E0", Offset = "0x36037E0", VA = "0x1836049E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3604950", Offset = "0x3603750", VA = "0x183604950", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3604950", Offset = "0x3603750", VA = "0x183604950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private const string NHCIPBOBODG = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly Dictionary<SerializableGuid, BFFEIPJHCFH> LAFMBKIIGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<SerializableGuid> DOPICACJAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly Dictionary<SerializableGuid, GameObject> JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private ODMPAIDMGCI GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private PKDAIMBJGBM MIFANJIIOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private DFDDJEKPLDJ ECAHBHLDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private global::IHEHHPCDJON<BFFEIPJHCFH> FLHKKEEAGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private GameObject FECBBILGDKA;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2835C50", Offset = "0x2834A50", VA = "0x182835C50", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2835E80", Offset = "0x2834C80", VA = "0x182835E80", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2835110", Offset = "0x2833F10", VA = "0x182835110", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2835D70", Offset = "0x2834B70", VA = "0x182835D70")]
	private void KBHLNDOADGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x28352B0", Offset = "0x28340B0", VA = "0x1828352B0")]
	internal void ECILECGFMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2834F30", Offset = "0x2833D30", VA = "0x182834F30")]
	private void CGKODKCKODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2835D80", Offset = "0x2834B80", VA = "0x182835D80")]
	private void KDDGLAAKJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2834EE0", Offset = "0x2833CE0", VA = "0x182834EE0")]
	[IteratorStateMachine(typeof(IHAMDNKGAMG))]
	private IEnumerable<RRCustomPropTag> ANMBLEBPGJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x28361F0", Offset = "0x2834FF0", VA = "0x1828361F0")]
	private void PPFNHMEHPFK(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x28360B0", Offset = "0x2834EB0", VA = "0x1828360B0")]
	private void PJHBAIJLMNC(SerializableGuid AJPBBJHOAOB, GameObject BFJMKCMPBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x28358C0", Offset = "0x28346C0", VA = "0x1828358C0")]
	private void GPFDDAHKJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x28356E0", Offset = "0x28344E0", VA = "0x1828356E0")]
	private bool GGBFCLPHGOL(BFFEIPJHCFH CFEEPLDMJBH, Transform ADECAOLBLPJ, out GameObject HFEGMKMMHDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2835D20", Offset = "0x2834B20", VA = "0x182835D20")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2836670", Offset = "0x2835470", VA = "0x182836670")]
	public LBLGPHMGKFA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public SerializableGuid JBDHDOEDCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2870E30", Offset = "0x286FC30", VA = "0x182870E30")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xDC3F40", Offset = "0xDC2D40", VA = "0x180DC3F40")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[EBJHGMECDNA(typeof(BFIAFBHOKLF), new string[] { })]
public class IOJAIHLOPHA : FDFFINEAOHD, CDAFEBOKDJF, BFIAFBHOKLF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private HFHHBKPAPIM ALAACDKEEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private COOKMJFPBMI GPLMNCJOFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private PropertyEventCallbacksService OBJALHMPDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private LocalPlayerScopeSystem BDDGLOLJIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int EFANBPJHNAH;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool EDGBECOMPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x282EFC0", Offset = "0x282DDC0", VA = "0x18282EFC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PMMHBDBEGAM LKMLFJFEBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x282EE90", Offset = "0x282DC90", VA = "0x18282EE90", Slot = "9")]
		get
		{
			return default(PMMHBDBEGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x282E800", Offset = "0x282D600", VA = "0x18282E800", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public FEMMDHLANDH JBJKLMKLHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x282E8D0", Offset = "0x282D6D0", VA = "0x18282E8D0", Slot = "11")]
		get
		{
			return default(FEMMDHLANDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x282E800", Offset = "0x282D600", VA = "0x18282E800", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public FEMMDHLANDH PNIDHCNENFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x282F480", Offset = "0x282E280", VA = "0x18282F480", Slot = "13")]
		get
		{
			return default(FEMMDHLANDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private uint JBAKEFOCCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x282E820", Offset = "0x282D620", VA = "0x18282E820")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event OJPGCAPGDDC JOAFAFDLHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x282E640", Offset = "0x282D440", VA = "0x18282E640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x282F540", Offset = "0x282E340", VA = "0x18282F540", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x282EDC0", Offset = "0x282DBC0", VA = "0x18282EDC0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x282F2E0", Offset = "0x282E0E0", VA = "0x18282F2E0", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x282EA50", Offset = "0x282D850", VA = "0x18282EA50", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x282F0E0", Offset = "0x282DEE0", VA = "0x18282F0E0")]
	private void KAPLCEIDAGN(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x282F6E0", Offset = "0x282E4E0", VA = "0x18282F6E0", Slot = "14")]
	public PMMHBDBEGAM NDOCFECCKPD(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x282F5E0", Offset = "0x282E3E0", VA = "0x18282F5E0", Slot = "15")]
	public bool MKDAEBPAGML(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC, out PMMHBDBEGAM CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x282E6E0", Offset = "0x282D4E0", VA = "0x18282E6E0", Slot = "16")]
	public void CCAIPLKNAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x282EB00", Offset = "0x282D900", VA = "0x18282EB00", Slot = "17")]
	public void FGMIMAHOJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x282E910", Offset = "0x282D710", VA = "0x18282E910", Slot = "18")]
	public bool DAKLMMCBBPP(PMMHBDBEGAM MCOKHJALNGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x282EB20", Offset = "0x282D920", VA = "0x18282EB20")]
	private void GENGBJFCHLO(PMMHBDBEGAM OKOHPFKFJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public IOJAIHLOPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[EBJHGMECDNA(typeof(EIANDBIEFDL), new string[] { })]
public class IIKMDNJBDND : FDFFINEAOHD, EIANDBIEFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x282E290", Offset = "0x282D090", VA = "0x18282E290", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x282E310", Offset = "0x282D110", VA = "0x18282E310", Slot = "5")]
	public void NBAKEOIBLIK(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x237AB60", Offset = "0x2379960", VA = "0x18237AB60")]
	private void PIGMJENILDA<T>(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public IIKMDNJBDND()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[IFBLAMOEMKH(CMGBDLINHMB.RenderEffects)]
	[EBJHGMECDNA(typeof(MMBKMNPPHBO), new string[] { })]
	public class SelectionService : FDFFINEAOHD, MMBKMNPPHBO
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2872540", Offset = "0x2871340", VA = "0x182872540", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x28724D0", Offset = "0x28712D0", VA = "0x1828724D0", Slot = "5")]
		public void EOAAHJFAPLD(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2872460", Offset = "0x2871260", VA = "0x182872460", Slot = "6")]
		public void ADKFGLBEHNJ(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x237AB60", Offset = "0x2379960", VA = "0x18237AB60")]
		private void PIGMJENILDA<T>(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public SelectionService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization, new string[] { "Timing" })]
	[EBJHGMECDNA(typeof(WorldSerialization), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	internal sealed class WorldSerialization : FDFFINEAOHD, KFOEJBPDGJE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const string AJJLNOEBKLI = "Timing";

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly CGJHBFGPOOL IMLOALHAGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private FFPEBHHNJFF FJKJAKKFINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private AOAMPDCFJGB BECAEADJGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private SerializationService MIFANJIIOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private HDOIPKADCBB EMOEAFOOMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CLDGLLOBFOG MAPPBNAKEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private DebugWorldsService GPMCBBBGNCC;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private OKJLDANCMCA GDFHIAHBADI
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xB7B360", Offset = "0xB7A160", VA = "0x180B7B360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2882410", Offset = "0x2881210", VA = "0x182882410", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF OIDEMDEBBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2882100", Offset = "0x2880F00", VA = "0x182882100", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2882010", Offset = "0x2880E10", VA = "0x182882010", Slot = "6")]
		public bool DNGEMHOMPML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2881BF0", Offset = "0x28809F0", VA = "0x182881BF0", Slot = "5")]
		public ByteString CCMIFLHPNMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x2882540", Offset = "0x2881340", VA = "0x182882540")]
		private void IPCEHEDJHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2882560", Offset = "0x2881360", VA = "0x182882560")]
		private void JJNPPBKAHKI(BGDMNMCCMEA EJEJEGHNJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x28826D0", Offset = "0x28814D0", VA = "0x1828826D0")]
		private void LLEPKDOKEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2882130", Offset = "0x2880F30", VA = "0x182882130")]
		private void EJCNAFIENPL(FCMCKNEAHLO EJEJEGHNJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2882630", Offset = "0x2881430", VA = "0x182882630")]
		private BGDMNMCCMEA KJCCHBMKBGB(EntityManager BHDOHAJMONK, EntityManager LGGPCBMPJIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(BHBAMFCLELG), new string[] { })]
public class BHBAMFCLELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Dictionary<FEJKANODFOG, string> ALEBIABAGDJ;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DE10", Offset = "0x2C2CC10", VA = "0x182C2DE10")]
	public GameObject EFFOEIOONDP(FEJKANODFOG GKODFJAPBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DEE0", Offset = "0x2C2CCE0", VA = "0x182C2DEE0")]
	public BHBAMFCLELG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[EBJHGMECDNA(typeof(DDPHBMAAHDP), new string[] { })]
	[LFOIMLBAPLC(typeof(TransformService))]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing)]
	public class TransformService : DDPHBMAAHDP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private HFHHBKPAPIM ALAACDKEEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TransformOwnershipPhase NLIPLDKFGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private global::ONBLNDNGCOE<Entity> ADECAOLBLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private ObjectEmbodimentService KFHKDGFGKJJ;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x28785E0", Offset = "0x28773E0", VA = "0x1828785E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private DFDDJEKPLDJ KAAPDHONNOL
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x2877F00", Offset = "0x2876D00", VA = "0x182877F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2879840", Offset = "0x2878640", VA = "0x182879840", Slot = "33")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x287ACC0", Offset = "0x2879AC0", VA = "0x18287ACC0", Slot = "34")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2878540", Offset = "0x2877340", VA = "0x182878540", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x287A1C0", Offset = "0x2878FC0", VA = "0x18287A1C0", Slot = "36")]
		public bool IOHJIAHINHM(Transform BCHADNCHEKP, out PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2877CC0", Offset = "0x2876AC0", VA = "0x182877CC0", Slot = "37")]
		public Transform AGDAIJOCIIH(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2878990", Offset = "0x2877790", VA = "0x182878990", Slot = "31")]
		public bool FPFNOLCEKGF(Entity GEEFHDFLBEH, out Transform BCHADNCHEKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2879690", Offset = "0x2878490", VA = "0x182879690")]
		private void HENEKLJDAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2878630", Offset = "0x2877430", VA = "0x182878630", Slot = "30")]
		public void ENFIJGJBBJC(Entity GEEFHDFLBEH, out Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2878A80", Offset = "0x2877880", VA = "0x182878A80", Slot = "4")]
		public void GDCFJBLAEFP(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x287A370", Offset = "0x2879170", VA = "0x18287A370")]
		public void JEGCOBOINFI(Entity GEEFHDFLBEH, Vector3 LHHNEMEAJHG, Quaternion FBGPAJBMOPM, Vector3 GBBNBELINHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x287BC80", Offset = "0x287AA80", VA = "0x18287BC80")]
		public void NGNDAEDIDAG(Entity GEEFHDFLBEH, Vector3 LHHNEMEAJHG, Quaternion FBGPAJBMOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2877FC0", Offset = "0x2876DC0", VA = "0x182877FC0", Slot = "28")]
		public void CLBIJEMJFKN(Entity GEEFHDFLBEH, out Matrix4x4 BCODGFOGAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x287AF40", Offset = "0x2879D40", VA = "0x18287AF40")]
		public void LNHEHKAHOPF(Entity GEEFHDFLBEH, in Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x28793B0", Offset = "0x28781B0", VA = "0x1828793B0")]
		public void GOHBEINHDHC(Entity GEEFHDFLBEH, in Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2879D70", Offset = "0x2878B70", VA = "0x182879D70")]
		public void HMFCIDKHEJF(Entity GEEFHDFLBEH, in Matrix4x4 MBJIIIDIGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x287C650", Offset = "0x287B450", VA = "0x18287C650", Slot = "5")]
		public void PDEOAGACCIA(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x287BA80", Offset = "0x287A880", VA = "0x18287BA80", Slot = "6")]
		public Vector3 MENJJILCEHP(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2878280", Offset = "0x2877080", VA = "0x182878280", Slot = "7")]
		public void DICBINCKBKB(Entity GEEFHDFLBEH, Quaternion IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x28796B0", Offset = "0x28784B0", VA = "0x1828796B0", Slot = "8")]
		public Quaternion HFMCOFNJPOM(Entity GEEFHDFLBEH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2878780", Offset = "0x2877580", VA = "0x182878780", Slot = "13")]
		public void FJBCKGJLCCJ(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2877BB0", Offset = "0x28769B0", VA = "0x182877BB0", Slot = "12")]
		public Vector3 ADKCLDGGKHN(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2877D80", Offset = "0x2876B80", VA = "0x182877D80")]
		public void CAPNDLGCLCP(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x28797A0", Offset = "0x28785A0", VA = "0x1828797A0")]
		private Vector3 HFOHMELCAED(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2879310", Offset = "0x2878110", VA = "0x182879310", Slot = "15")]
		public float GLBJOAHKOIN(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2878880", Offset = "0x2877680", VA = "0x182878880", Slot = "14")]
		public void FLDLJJGDOIN(Entity GEEFHDFLBEH, float IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x287A570", Offset = "0x2879370", VA = "0x18287A570")]
		private float KAGCJCCHFLP(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x287BD90", Offset = "0x287AB90", VA = "0x18287BD90")]
		public void NLIANMKJJCD(Entity GEEFHDFLBEH, float BIOIOGONEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2877E20", Offset = "0x2876C20", VA = "0x182877E20", Slot = "17")]
		public Vector3 CCONMBLCOJG(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x287A440", Offset = "0x2879240", VA = "0x18287A440", Slot = "16")]
		public void JOAFHOOPBPB(Entity GEEFHDFLBEH, Vector3 GBIIEKALBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x287C520", Offset = "0x287B320", VA = "0x18287C520")]
		private Vector3 OOIEPNCLMGM(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x287C770", Offset = "0x287B570", VA = "0x18287C770")]
		public void PMEJAEPCJDL(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x28794E0", Offset = "0x28782E0", VA = "0x1828794E0")]
		[Conditional("DEBUG_BUILD")]
		private void HBGIOGJMJCJ(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x287A020", Offset = "0x2878E20", VA = "0x18287A020", Slot = "9")]
		public void IGIMCPAJODD(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x28780B0", Offset = "0x2876EB0", VA = "0x1828780B0", Slot = "10")]
		public void DFMLGPGOEDO(Entity GEEFHDFLBEH, out Vector3 EIIEKPIPEEF, out Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2877A80", Offset = "0x2876880", VA = "0x182877A80", Slot = "11")]
		public void ABEECJHILAL(Entity GEEFHDFLBEH, out Vector3 EIIEKPIPEEF, out Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2878C70", Offset = "0x2877A70", VA = "0x182878C70", Slot = "38")]
		public void GEPKONEEJLH(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2878380", Offset = "0x2877180", VA = "0x182878380")]
		public void DNJDKAOKGCC(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x287BF00", Offset = "0x287AD00", VA = "0x18287BF00", Slot = "18")]
		public void OFKNBPADOEM(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2877FD0", Offset = "0x2876DD0", VA = "0x182877FD0", Slot = "19")]
		public Vector3 CLFJCLPAKBH(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x287C130", Offset = "0x287AF30", VA = "0x18287C130", Slot = "20")]
		public void OHEACAODJHG(Entity GEEFHDFLBEH, Quaternion IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2879F30", Offset = "0x2878D30", VA = "0x182879F30", Slot = "21")]
		public Quaternion HPOEHICNFDK(Entity GEEFHDFLBEH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x287B300", Offset = "0x287A100", VA = "0x18287B300", Slot = "23")]
		public void LPJGJCPGHDM(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x287BB90", Offset = "0x287A990", VA = "0x18287BB90", Slot = "22")]
		public Vector3 NDKBPDMGFLI(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x287B760", Offset = "0x287A560", VA = "0x18287B760", Slot = "24")]
		public void MCOFOPEKKHL(Entity GEEFHDFLBEH, float NOGNCKMINCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2878E90", Offset = "0x2877C90", VA = "0x182878E90", Slot = "25")]
		public float GIPJABDAFPD(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x287A850", Offset = "0x2879650", VA = "0x18287A850", Slot = "26")]
		public void KGIMIHGFFKJ(Entity GEEFHDFLBEH, Vector3 HLJBHGNEKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x287AE00", Offset = "0x2879C00", VA = "0x18287AE00", Slot = "27")]
		public Vector3 LHBMJKPGAEL(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2879940", Offset = "0x2878740", VA = "0x182879940", Slot = "32")]
		public void HLDLPBDPLCI(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x287A790", Offset = "0x2879590", VA = "0x18287A790")]
		private void KCGHDKMLABK(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x287A660", Offset = "0x2879460", VA = "0x18287A660")]
		private void KCGHDKMLABK(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2878200", Offset = "0x2877000", VA = "0x182878200")]
		private CBEDOBDLKDB DFMLGPGOEDO(Entity GEEFHDFLBEH)
		{
			return default(CBEDOBDLKDB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x287BE20", Offset = "0x287AC20", VA = "0x18287BE20")]
		private bool OEKEPNLPDKP(Entity GEEFHDFLBEH, out Entity ADECAOLBLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x287C370", Offset = "0x287B170", VA = "0x18287C370")]
		private void OHEIMGGEINO(Entity GEEFHDFLBEH, out Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2878FB0", Offset = "0x2877DB0", VA = "0x182878FB0")]
		public void GJOIDGHOKGE(Entity GEEFHDFLBEH, out Matrix4x4 MBJIIIDIGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x287ADF0", Offset = "0x2879BF0", VA = "0x18287ADF0", Slot = "29")]
		private void KJADEHNJKGD(Entity GEEFHDFLBEH, in Matrix4x4 BCODGFOGAPK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(KPOGCKFKBHN), new string[] { })]
public class KPOGCKFKBHN
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct KPAELHCBEAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private readonly KPOGCKFKBHN ADECAOLBLPJ;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x36075F0", Offset = "0x36063F0", VA = "0x1836075F0")]
		public KPAELHCBEAM(KPOGCKFKBHN ADECAOLBLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x36075D0", Offset = "0x36063D0", VA = "0x1836075D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int KCHJKGPLKKO;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool LEONOJPKKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xFD3550", Offset = "0xFD2350", VA = "0x180FD3550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action DMGKGMNLMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2834870", Offset = "0x2833670", VA = "0x182834870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x28347D0", Offset = "0x28335D0", VA = "0x1828347D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x28347A0", Offset = "0x28335A0", VA = "0x1828347A0")]
	public KPAELHCBEAM EMJANLIPHLL()
	{
		return default(KPAELHCBEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x17E9C90", Offset = "0x17E8A90", VA = "0x1817E9C90")]
	public void EIOFHIIOEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2834910", Offset = "0x2833710", VA = "0x182834910")]
	public void OFHHJDAAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KPOGCKFKBHN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[EBJHGMECDNA(typeof(EnableComponentSystemsInScope), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
	[JAPBKNDOGGF(typeof(EHIDJEIAFME))]
	public class EnableComponentSystemsInScope : FDFFINEAOHD, NHJNEKFPLIJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private World HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private NativeArray<int> DAJONPKEEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private NativeArray<int> NDAADHJDJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int JKGBPKEJAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private EEJHBIOBFFI MGGPFLNEAJJ;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DED0", Offset = "0x2C3CCD0", VA = "0x182C3DED0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DB30", Offset = "0x2C3C930", VA = "0x182C3DB30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E030", Offset = "0x2C3CE30", VA = "0x182C3E030", Slot = "5")]
		public void JOAFAFDLHBM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DC80", Offset = "0x2C3CA80", VA = "0x182C3DC80")]
		public void FDGIICJJLJE(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E560", Offset = "0x2C3D360", VA = "0x182C3E560")]
		private void LLAMLFGGEPA(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E6B0", Offset = "0x2C3D4B0", VA = "0x182C3E6B0")]
		private void LMKNIIFIMNG(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DBC0", Offset = "0x2C3C9C0", VA = "0x182C3DBC0")]
		private void EPINLCBCGAP(int FOACNEHDHLI, int CBNJCJLIEMJ, bool JBAGPIKPAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E820", Offset = "0x2C3D620", VA = "0x182C3E820")]
		private int PDBNPGHGLHE(EEJHBIOBFFI PBOJAOCFJPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E0A0", Offset = "0x2C3CEA0", VA = "0x182C3E0A0")]
		private bool KICPHIFHCNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DDF0", Offset = "0x2C3CBF0", VA = "0x182C3DDF0")]
		private void HDGEFIDHCGK(NativeArray<int> PNDAKPENJKM, NativeArray<int> LGLGGCHFNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DAF0", Offset = "0x2C3C8F0", VA = "0x182C3DAF0")]
		private void CPBEAMDOLJN(NativeArray<int> PNDAKPENJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2C3DF80", Offset = "0x2C3CD80", VA = "0x182C3DF80")]
		private void IECNCFOJGPG(NativeArray<int> LGLGGCHFNDI, NativeArray<int> PNDAKPENJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E890", Offset = "0x2C3D690", VA = "0x182C3E890")]
		public EnableComponentSystemsInScope()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[EBJHGMECDNA(typeof(ANEHAPKAFCD), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public class ANEHAPKAFCD : HECIIBPMLDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class HLNEBDOHNJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public FFPEBHHNJFF services;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HLNEBDOHNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3604370", Offset = "0x3603170", VA = "0x183604370")]
		internal void <InitPhase>b__1(FDFFINEAOHD svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x36043D0", Offset = "0x36031D0", VA = "0x1836043D0")]
		internal void <InitPhase>b__2(CDAFEBOKDJF svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private EHIDJEIAFME CANCHCAFIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private PGLNEDJDCBK HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public MIBPANHFFGK MJDHCGHFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x872170", Offset = "0x870F70", VA = "0x180872170", Slot = "4")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2C289F0", Offset = "0x2C277F0", VA = "0x182C289F0", Slot = "5")]
	public void KEACOMCKNJG(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2C288C0", Offset = "0x2C276C0", VA = "0x182C288C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ANEHAPKAFCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DefaultMember("Item")]
public class NCKDDKEMJGP<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public DynamicBuffer<From> CLABEIKAHOI;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	public NCKDDKEMJGP(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public class PGBBKILBNAD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public List<From> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3160C90", Offset = "0x315FA90", VA = "0x183160C90", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x3160CF0", Offset = "0x315FAF0", VA = "0x183160CF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x3160C60", Offset = "0x315FA60", VA = "0x183160C60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761940", VA = "0x180762B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x711170", Offset = "0x70FF70", VA = "0x180711170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3160BD0", Offset = "0x315F9D0", VA = "0x183160BD0")]
	public PGBBKILBNAD(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL, bool EFNCJMHMODB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x3160820", Offset = "0x315F620", VA = "0x183160820", Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x27701B0", Offset = "0x276EFB0", VA = "0x1827701B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x3160880", Offset = "0x315F680", VA = "0x183160880", Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x31608E0", Offset = "0x315F6E0", VA = "0x1831608E0", Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x31609F0", Offset = "0x315F7F0", VA = "0x1831609F0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3160A60", Offset = "0x315F860", VA = "0x183160A60", Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3160AC0", Offset = "0x315F8C0", VA = "0x183160AC0", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x3160B70", Offset = "0x315F970", VA = "0x183160B70", Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x3160B40", Offset = "0x315F940", VA = "0x183160B40", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x26F7FC0", Offset = "0x26F6DC0", VA = "0x1826F7FC0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
public class KNDIDAPDONF<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeArray<From> DEJEDNNJILK;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x317FDC0", Offset = "0x317EBC0", VA = "0x18317FDC0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x317FE10", Offset = "0x317EC10", VA = "0x18317FE10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x317FD80", Offset = "0x317EB80", VA = "0x18317FD80", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x676E20", VA = "0x180678020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x28F0A60", Offset = "0x28EF860", VA = "0x1828F0A60")]
	public KNDIDAPDONF(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x317F990", Offset = "0x317E790", VA = "0x18317F990", Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x317F9D0", Offset = "0x317E7D0", VA = "0x18317F9D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x317FA10", Offset = "0x317E810", VA = "0x18317FA10", Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x317FAD0", Offset = "0x317E8D0", VA = "0x18317FAD0", Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x317FB90", Offset = "0x317E990", VA = "0x18317FB90", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x317FC50", Offset = "0x317EA50", VA = "0x18317FC50", Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x317FCC0", Offset = "0x317EAC0", VA = "0x18317FCC0", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x317FD40", Offset = "0x317EB40", VA = "0x18317FD40", Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x317FD00", Offset = "0x317EB00", VA = "0x18317FD00", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1E72AA0", Offset = "0x1E718A0", VA = "0x181E72AA0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[DefaultMember("Item")]
public class LLBGABNCGEJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly Func<From, To> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Func<To, From> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeList<From> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public To MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	public LLBGABNCGEJ(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class NBEPJKAFHML
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public const string MNAGNEHNCEE = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public const string MPECDOEEIGK = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public const string MMGGLJBDGDG = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public const string CFIMOCOJMOE = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public const string BDLELEHKMNJ = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public const string NJHPMBPGDDO = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public const string LDNLNLAAHDN = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class IOGKAJICPOH
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class IJICCCLBHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public FFPEBHHNJFF services;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public IJICCCLBHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x3605180", Offset = "0x3603F80", VA = "0x183605180")]
		internal void <InitServices>b__1(FDFFINEAOHD svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x36051E0", Offset = "0x3603FE0", VA = "0x1836051E0")]
		internal void <InitServices>b__2(CDAFEBOKDJF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x282E3F0", Offset = "0x282D1F0", VA = "0x18282E3F0")]
	public static void JIBLLCBPHAA(this PGLNEDJDCBK HADAJAKADAH, FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x23F6940", Offset = "0x23F5740", VA = "0x1823F6940")]
	public static void AEFBIIJCLFD<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x23F6F80", Offset = "0x23F5D80", VA = "0x1823F6F80")]
	public static void MJOOJNAOFOC<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x23F69B0", Offset = "0x23F57B0", VA = "0x1823F69B0")]
	public static void BHGNGPPJFFM<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x23F6B60", Offset = "0x23F5960", VA = "0x1823F6B60")]
	public static void EOBOHMBELMH<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x23F6D10", Offset = "0x23F5B10", VA = "0x1823F6D10")]
	public static void HNBFGOPBLKN<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x23F6EC0", Offset = "0x23F5CC0", VA = "0x1823F6EC0")]
	private static void IDDAEDDBEDN<T>(object CHJMLFMLCJF, Action<T> MBOOMOIFJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class BKHFLJJOFIO
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class CIJOCBAKOBP
{
	[Cpp2IlInjected.Token(Token = "0x6000457")]
	public static bool HDCJELIGLFP<T>(ref T BMPDKJEHGIN, ref T BMMLDIMMAAK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class AKFJIKPOECJ
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class ACKFBCCPEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ACKFBCCPEHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2C27A50", Offset = "0x2C26850", VA = "0x182C27A50")]
	public static string NOGDNDDIJIP(Transform BCHADNCHEKP, Transform MCOKHJALNGG)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[IFBLAMOEMKH(CMGBDLINHMB.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x28747F0", Offset = "0x28735F0", VA = "0x1828747F0")]
		public static void ADPJAIEJIPK(this AJDCMAAKGND FJKJAKKFINM, HNBJONKGAEL IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2874F40", Offset = "0x2873D40", VA = "0x182874F40")]
		public static void MJAGDEDIGFF(this AJDCMAAKGND FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x28746E0", Offset = "0x28734E0", VA = "0x1828746E0")]
		public static void ADPJAIEJIPK(this AJDCMAAKGND FJKJAKKFINM, [Optional] string[] NHEECPNNGOE, [Optional] string[] BCGBBPKGNDB, [Optional] string[] ELPAIOJMBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2874E90", Offset = "0x2873C90", VA = "0x182874E90")]
		public static void HIILFCBENND(this AJDCMAAKGND FJKJAKKFINM, params string[] EONPIJDEEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2874DE0", Offset = "0x2873BE0", VA = "0x182874DE0")]
		public static void EIENEIBFFPP(this AJDCMAAKGND FJKJAKKFINM, params string[] EONPIJDEEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2874BE0", Offset = "0x28739E0", VA = "0x182874BE0")]
		private static string[] DOBIMILCEFD(HNBJONKGAEL IDKBHBKJHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2874A20", Offset = "0x2873820", VA = "0x182874A20")]
		private static bool BLKLDHBOHAG(HNBJONKGAEL IDKBHBKJHPJ, out string[] BCCBKDAADNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00")]
		private static bool LEEDEPDGAPN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class MLBHKFFBLLH : LBLNCNBBMIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly MethodInfo GOMGLHMMBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Type[] KMLLOCJHKPB;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2838D70", Offset = "0x2837B70", VA = "0x182838D70")]
	public MLBHKFFBLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action EHLKLCIKDHM();

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2838B80", Offset = "0x2837980", VA = "0x182838B80")]
	public MethodInfo EPIONIGHEEB(Action CGKOOFFNHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2838BC0", Offset = "0x28379C0", VA = "0x182838BC0", Slot = "4")]
	public void PJHBAIJLMNC(Type NKICFHCCMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class PKCAMOGFFFG : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private enum NBFCGEIILFL
	{

	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2868060", Offset = "0x2866E60", VA = "0x182868060", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BJCNAIMNHPD<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x28680F0", Offset = "0x2866EF0", VA = "0x1828680F0")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2836F50", Offset = "0x2835D50", VA = "0x182836F50")]
	protected PKCAMOGFFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class NDKHFJCHDBL : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x283A210", Offset = "0x2839010", VA = "0x18283A210", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void DCHPHCIDLGC<T>() where T : KCJNPCKFNOM;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x283A2A0", Offset = "0x28390A0", VA = "0x18283A2A0")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2836F50", Offset = "0x2835D50", VA = "0x182836F50")]
	protected NDKHFJCHDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class LICOIIFNCGA : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2836E30", Offset = "0x2835C30", VA = "0x182836E30", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EJLHODOHNCH<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2836EC0", Offset = "0x2835CC0", VA = "0x182836EC0")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2836F50", Offset = "0x2835D50", VA = "0x182836F50")]
	protected LICOIIFNCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[EBJHGMECDNA(typeof(EEDGKMIDAFH), new string[] { })]
public class NIDJLFGOJGK : EEDGKMIDAFH, HECIIBPMLDM, NHJNEKFPLIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private FFPEBHHNJFF FJKJAKKFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private AOAMPDCFJGB BECAEADJGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private DDMIOFGHMGI BHLMCOMCAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private HFHHBKPAPIM ALAACDKEEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private DDPHBMAAHDP JKOOEKEEBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private NEKBEAHJEHF MIFANJIIOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private ELFIPEDOAPI ABCMOBMIIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GKHHEJLDBHG GPMKOKBNMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private ODMPAIDMGCI GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private BPHIPABMBKD KPHHOAEPKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private NKGHFOCFECH BALPJAJPMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private BFIAFBHOKLF KKJNDEPMACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private LBPAJLMGMFA OPAAEBMKPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private DOFEFFJAEBG GIINIEFOJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private EIANDBIEFDL EFHJAGIMGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private MMBKMNPPHBO BPCACFGHGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private LIACDBEGOKA OPGPMBODILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public FFPEBHHNJFF AFNMECPECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IJONKAEAEBK GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EHIDJEIAFME NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public AOAMPDCFJGB KHNOEBOIBMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public DDMIOFGHMGI HODIGNDEBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CBIPFLGDJEF OFOEMMHFELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D370", VA = "0x18065E570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public HFHHBKPAPIM HCLFBFBADHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D380", VA = "0x18065E580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public DDPHBMAAHDP LLJLHOBLFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x655ED0", VA = "0x1806570D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public NEKBEAHJEHF ENPNLKBHPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x66D760", Offset = "0x66C560", VA = "0x18066D760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public ELFIPEDOAPI NFMMDNGOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6570B0", Offset = "0x655EB0", VA = "0x1806570B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GKHHEJLDBHG PFJBMLEAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x66D770", Offset = "0x66C570", VA = "0x18066D770", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public ODMPAIDMGCI LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x66D780", Offset = "0x66C580", VA = "0x18066D780", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BPHIPABMBKD ACECADJDOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x66D700", Offset = "0x66C500", VA = "0x18066D700", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NKGHFOCFECH IJPKIJCIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x66D710", Offset = "0x66C510", VA = "0x18066D710", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public BFIAFBHOKLF GMAGOKAFPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6936D0", Offset = "0x6924D0", VA = "0x1806936D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public LBPAJLMGMFA CPAHMDPHOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x65DD80", Offset = "0x65CB80", VA = "0x18065DD80", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DOFEFFJAEBG IGCBBCBKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x65DE20", Offset = "0x65CC20", VA = "0x18065DE20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public EIANDBIEFDL MEPAMLDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x6936A0", Offset = "0x6924A0", VA = "0x1806936A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public MMBKMNPPHBO JELINFEJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x66D720", Offset = "0x66C520", VA = "0x18066D720", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public LIACDBEGOKA HOBOELBHFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x66D730", Offset = "0x66C530", VA = "0x18066D730", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public MIBPANHFFGK MJDHCGHFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x67DAA0", Offset = "0x67C8A0", VA = "0x18067DAA0", Slot = "21")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x283A3C0", Offset = "0x28391C0", VA = "0x18283A3C0", Slot = "22")]
	public void KEACOMCKNJG(FFPEBHHNJFF OIDEMDEBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x283A390", Offset = "0x2839190", VA = "0x18283A390", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x283A3A0", Offset = "0x28391A0", VA = "0x18283A3A0", Slot = "23")]
	public void JOAFAFDLHBM(FFPEBHHNJFF OIDEMDEBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public NIDJLFGOJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[DefaultMember("Item")]
public class PPONMINLDEP : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JEEFNHOFEFA : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public PPONMINLDEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x66D790", Offset = "0x66C590", VA = "0x18066D790", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x3605820", Offset = "0x3604620", VA = "0x183605820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A000", VA = "0x18065B200")]
		[DebuggerHidden]
		public JEEFNHOFEFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3605670", Offset = "0x3604470", VA = "0x183605670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x36057E0", Offset = "0x36045E0", VA = "0x1836057E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	protected const ulong DEMMEADCPJL = 1uL;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	protected const ulong MJBKKMOHDOD = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	protected const int KGOEHDPKCJP = 8;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	protected const int NNDEKIHAIIL = 6;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public const int NLLLGGCLIPE = 64;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	protected const int OKOEIFKEDOH = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly List<ulong> OAMKHBKCHHA;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x6579D0", VA = "0x180658BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6FB410", Offset = "0x6FA210", VA = "0x1806FB410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int OFOJBFDCABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x672C90", Offset = "0x671A90", VA = "0x180672C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6FB320", Offset = "0x6FA120", VA = "0x1806FB320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2868D50", Offset = "0x2867B50", VA = "0x182868D50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x28684A0", Offset = "0x28672A0", VA = "0x1828684A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2869150", Offset = "0x2867F50", VA = "0x182869150")]
	public PPONMINLDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x28691D0", Offset = "0x2867FD0", VA = "0x1828691D0")]
	public PPONMINLDEP(int AIGDDFDNOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x28683C0", Offset = "0x28671C0", VA = "0x1828683C0")]
	public bool EDEOOALDLJB(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2868DF0", Offset = "0x2867BF0", VA = "0x182868DF0")]
	public bool KGJNCFBHIBI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2868FD0", Offset = "0x2867DD0", VA = "0x182868FD0")]
	public bool OHAHAJGPFNC(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2869140", Offset = "0x2867F40", VA = "0x182869140")]
	public bool PPICPACFBLI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2868BA0", Offset = "0x28679A0", VA = "0x182868BA0")]
	public void JGFIDBHEAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2868EE0", Offset = "0x2867CE0", VA = "0x182868EE0")]
	public void OAHEOEBHHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2869050", Offset = "0x2867E50", VA = "0x182869050")]
	public void PIGMJENILDA(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2868AA0", Offset = "0x28678A0", VA = "0x182868AA0")]
	public void IIOELKEIHEG(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2868810", Offset = "0x2867610", VA = "0x182868810")]
	public bool FLEBLELMNAN(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2868C30", Offset = "0x2867A30", VA = "0x182868C30")]
	public void KDOMIKFMFKI(int LBACAALGKLG, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2868650", Offset = "0x2867450", VA = "0x182868650")]
	public void EPIIJGJJGPF(int DOOFIFHOCKH, int JBFIBBGJOJJ, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2868980", Offset = "0x2867780", VA = "0x182868980")]
	public int HEFJCCLOLGO(int KOHJDBBJEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2868910", Offset = "0x2867710", VA = "0x182868910")]
	public int HEFJCCLOLGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2868A50", Offset = "0x2867850", VA = "0x182868A50")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x28688A0", Offset = "0x28676A0", VA = "0x1828688A0", Slot = "4")]
	[IteratorStateMachine(typeof(JEEFNHOFEFA))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x28688A0", Offset = "0x28676A0", VA = "0x1828688A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NACIFLLMCPL<T> : global::DEKKGELEEDA<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	protected global::ADPPKKLLOAG<T> NHGODJCEDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	protected global::AEIJCHDEEMK<T> HEEJCHPDFDL;

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x158F160", Offset = "0x158DF60", VA = "0x18158F160")]
	public NACIFLLMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4A00", Offset = "0x1FC3800", VA = "0x181FC4A00")]
	public NACIFLLMCPL(global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FC46C0", Offset = "0x1FC34C0", VA = "0x181FC46C0", Slot = "11")]
	public override T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4310", Offset = "0x1FC3110", VA = "0x181FC4310", Slot = "12")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class CLBPJFGNMHN
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x20C0B70", Offset = "0x20BF970", VA = "0x1820C0B70")]
	public static JLCDNMLCNEN PJHBAIJLMNC<T>(this KJJHEOCLACN GMKKBMEMHOP, global::NBBJGEJPPKL<T> BEMAPDNKPAD, global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL) where T : struct
	{
		return default(JLCDNMLCNEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class DJACPONAHMA<T> : global::NACIFLLMCPL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x4571450", Offset = "0x4570250", VA = "0x184571450")]
	public DJACPONAHMA(T OCIAEJCLHLN, T GEOHKIDILGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public sealed class NCLKMOCKEDG<T> : global::DEKKGELEEDA<T> where T : struct, KCJNPCKFNOM
{
	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1920", Offset = "0x2DE0720", VA = "0x182DE1920", Slot = "11")]
	public override T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2DE18C0", Offset = "0x2DE06C0", VA = "0x182DE18C0", Slot = "12")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x227D5F0", Offset = "0x227C3F0", VA = "0x18227D5F0")]
	public NCLKMOCKEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public abstract class GBBOPLOPEEF : PPMKAONFAIG
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract Type HCCKNPIKABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO, in ECNLJAAGJFG IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, in MJADMLMEADH IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ICJPMMDCBBM(LIEODINBDBP IONGKOPBOLO, JIOPCPMKLHK EMCMEEJENIP, [Optional] object NAHJDDBGMOA);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	protected GBBOPLOPEEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class DEKKGELEEDA<T> : GBBOPLOPEEF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public override Type HCCKNPIKABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x26F97E0", Offset = "0x26F85E0", VA = "0x1826F97E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO);

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x26FA210", Offset = "0x26F9010", VA = "0x1826FA210", Slot = "8")]
	public override void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO, in ECNLJAAGJFG MCOKHJALNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x26F8BC0", Offset = "0x26F79C0", VA = "0x1826F8BC0", Slot = "9")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, in MJADMLMEADH IKPEGPHMIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x26FAB70", Offset = "0x26F9970", VA = "0x1826FAB70", Slot = "10")]
	public override void ICJPMMDCBBM(LIEODINBDBP IONGKOPBOLO, JIOPCPMKLHK EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1AC62E0", Offset = "0x1AC50E0", VA = "0x181AC62E0")]
	protected DEKKGELEEDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class FBGKEJBNGOK
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class HOOIBEGJHHG
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class IEPGJEEIGBK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
			public IEPGJEEIGBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x17B0B80", Offset = "0x17AF980", VA = "0x1817B0B80")]
			internal void <RegisterFixedString>b__0(LIEODINBDBP p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x17B0DF0", Offset = "0x17AFBF0", VA = "0x1817B0DF0")]
			internal T <RegisterFixedString>b__1(LIEODINBDBP p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x36045B0", Offset = "0x36033B0", VA = "0x1836045B0")]
		public static void FKHONKNHOOA(CHKDLDDGMPK NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x2515060", Offset = "0x2513E60", VA = "0x182515060")]
		private static void NOIBEAIHDLK<T>(CHKDLDDGMPK NIGMPMDPOOJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x2514FD0", Offset = "0x2513DD0", VA = "0x182514FD0")]
		private static void DCJPAFAMHDK<T>(LIEODINBDBP JOLHNMOCKDJ, T HFMHCLGICNJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x2514980", Offset = "0x2513780", VA = "0x182514980")]
		private static T BJAEKAJKDLH<T>(LIEODINBDBP JOLHNMOCKDJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public HOOIBEGJHHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class LODMJJFLPCO : PKCAMOGFFFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CHKDLDDGMPK NIGMPMDPOOJ;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x2516130", Offset = "0x2514F30", VA = "0x182516130", Slot = "6")]
		public override void BJCNAIMNHPD<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x3608F50", Offset = "0x3607D50", VA = "0x183608F50")]
		public static void JFALGCMELEE(CHKDLDDGMPK NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x3608FE0", Offset = "0x3607DE0", VA = "0x183608FE0")]
		public LODMJJFLPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C40540", Offset = "0x2C3F340", VA = "0x182C40540")]
	public static void CNHPCJEGFKL(CHKDLDDGMPK NIGMPMDPOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AC70", Offset = "0x2C59A70", VA = "0x182C5AC70")]
	public static void CNAHKNDDACG<T>(CHKDLDDGMPK NIGMPMDPOOJ, global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C5AD00", Offset = "0x2C59B00", VA = "0x182C5AD00")]
	public static void FAGHPJDNCAK<T>(CHKDLDDGMPK CFPIMFIOLEF) where T : struct, KCJNPCKFNOM
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
public interface CHKDLDDGMPK : global::OBFHJMKGHOD<CHKDLDDGMPK>
{
	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJHBAIJLMNC(Type NKICFHCCMMH, PPMKAONFAIG CFPIMFIOLEF);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNMEGLCAMII(Type NKICFHCCMMH, out PPMKAONFAIG CFPIMFIOLEF);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DPPLDJKKNOC
{
	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A9C0", Offset = "0x2C397C0", VA = "0x182C3A9C0")]
	public static void PJHBAIJLMNC(this CHKDLDDGMPK FPFLBEGAJEB, PPMKAONFAIG CFPIMFIOLEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[EBJHGMECDNA(typeof(KJJHEOCLACN), new string[] { })]
public sealed class GMOBIMICHHB : KJJHEOCLACN, global::OBFHJMKGHOD<KJJHEOCLACN>, DFDLCPDHDGP, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly Dictionary<JLCDNMLCNEN, PPMKAONFAIG> NIGMPMDPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private CHKDLDDGMPK BIFJGDEEJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool ELCPFKDMBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761940", VA = "0x180762B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x711170", Offset = "0x70FF70", VA = "0x180711170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2829E10", Offset = "0x2828C10", VA = "0x182829E10")]
	public GMOBIMICHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2829D50", Offset = "0x2828B50", VA = "0x182829D50")]
	public GMOBIMICHHB(Dictionary<JLCDNMLCNEN, PPMKAONFAIG> NIGMPMDPOOJ, bool CFBDLDCFAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x28296E0", Offset = "0x28284E0", VA = "0x1828296E0", Slot = "7")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2829610", Offset = "0x2828410", VA = "0x182829610", Slot = "8")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2829690", Offset = "0x2828490", VA = "0x182829690", Slot = "9")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2829C80", Offset = "0x2828A80", VA = "0x182829C80", Slot = "4")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2829B10", Offset = "0x2828910", VA = "0x182829B10", Slot = "5")]
	public void PJHBAIJLMNC(JLCDNMLCNEN FCDKMJOKGIE, PPMKAONFAIG CFPIMFIOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2829740", Offset = "0x2828540", VA = "0x182829740")]
	[Conditional("DEBUG_BUILD")]
	private void KMADGIFDFIH(JLCDNMLCNEN FCDKMJOKGIE, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2829880", Offset = "0x2828680", VA = "0x182829880", Slot = "6")]
	public bool KNMEGLCAMII(JLCDNMLCNEN FCDKMJOKGIE, out PPMKAONFAIG CFPIMFIOLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2829A30", Offset = "0x2828830", VA = "0x182829A30", Slot = "10")]
	public KJJHEOCLACN NFHKLFECJLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[EBJHGMECDNA(typeof(CHKDLDDGMPK), new string[] { })]
public sealed class FLHLECHEOIJ : DFDLCPDHDGP, CHKDLDDGMPK, global::OBFHJMKGHOD<CHKDLDDGMPK>
{
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Dictionary<Type, PPMKAONFAIG> NIGMPMDPOOJ;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool ELCPFKDMBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6718D0", Offset = "0x6706D0", VA = "0x1806718D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x693000", Offset = "0x691E00", VA = "0x180693000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2827340", Offset = "0x2826140", VA = "0x182827340")]
	public FLHLECHEOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2827280", Offset = "0x2826080", VA = "0x182827280")]
	public FLHLECHEOIJ(Dictionary<Type, PPMKAONFAIG> NIGMPMDPOOJ, bool CFBDLDCFAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2826F00", Offset = "0x2825D00", VA = "0x182826F00", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2827120", Offset = "0x2825F20", VA = "0x182827120", Slot = "5")]
	public void PJHBAIJLMNC(Type NKICFHCCMMH, PPMKAONFAIG CFPIMFIOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2826F60", Offset = "0x2825D60", VA = "0x182826F60", Slot = "6")]
	public bool KNMEGLCAMII(Type NKICFHCCMMH, out PPMKAONFAIG CFPIMFIOLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2827040", Offset = "0x2825E40", VA = "0x182827040", Slot = "7")]
	public CHKDLDDGMPK NFHKLFECJLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[EBJHGMECDNA(typeof(ANCDIMIFACP), new string[] { })]
internal sealed class IHNICGPMMOD : ANCDIMIFACP, DFDLCPDHDGP, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private readonly Dictionary<JLCDNMLCNEN, DOGACPAEELJ> LJPDJMMJGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x282E0E0", Offset = "0x282CEE0", VA = "0x18282E0E0", Slot = "6")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x282E080", Offset = "0x282CE80", VA = "0x18282E080", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x282E1A0", Offset = "0x282CFA0", VA = "0x18282E1A0", Slot = "4")]
	public void PJHBAIJLMNC(JLCDNMLCNEN ABEODFEGJBP, Type KICHMDFNHJN, DOGACPAEELJ OEINDPCLNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x282E130", Offset = "0x282CF30", VA = "0x18282E130", Slot = "5")]
	public bool NKPEADBAMEJ(JLCDNMLCNEN ABEODFEGJBP, out DOGACPAEELJ OEINDPCLNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x282DEF0", Offset = "0x282CCF0", VA = "0x18282DEF0")]
	[Conditional("DEBUG_BUILD")]
	private void HBPBOKBOOKK(JLCDNMLCNEN ABEODFEGJBP, Type KICHMDFNHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x282E210", Offset = "0x282D010", VA = "0x18282E210")]
	public IHNICGPMMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[EBJHGMECDNA(typeof(PCFOCDMILKJ), new string[] { })]
[JAPBKNDOGGF(typeof(GKJELINCFGM))]
internal sealed class FHIOIFIIDCJ : PCFOCDMILKJ, BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private readonly PPONMINLDEP JFPMOMMEDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private readonly Dictionary<NMEJDFJAOOA, int> OCDJPBMHOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private readonly Stack<int> NFMFOGHBEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private GKJELINCFGM GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private CBIPFLGDJEF NBLKNAFAMEM;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private int BBJPEJLDKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2825740", Offset = "0x2824540", VA = "0x182825740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool DEFKNPLGKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x722540", Offset = "0x721340", VA = "0x180722540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8E8210", Offset = "0x8E7010", VA = "0x1808E8210", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2825190", Offset = "0x2823F90", VA = "0x182825190", Slot = "6")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2825340", Offset = "0x2824140", VA = "0x182825340", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2825470", Offset = "0x2824270", VA = "0x182825470", Slot = "8")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x28252A0", Offset = "0x28240A0", VA = "0x1828252A0")]
	private void EHKNKBCLFJE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x28253C0", Offset = "0x28241C0", VA = "0x1828253C0", Slot = "4")]
	public bool JKMNJDNCGFM(NMEJDFJAOOA DBGIPPEDJIM, JLCDNMLCNEN HLOAMKBCFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2825520", Offset = "0x2824320", VA = "0x182825520", Slot = "5")]
	public void NCKAKJEMCHK(NMEJDFJAOOA DBGIPPEDJIM, Span<JLCDNMLCNEN> GMKKBMEMHOP, bool IFINFNLHHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2825190", Offset = "0x2823F90", VA = "0x182825190", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2825790", Offset = "0x2824590", VA = "0x182825790")]
	public FHIOIFIIDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class DIFANBBCPAA
{
	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2C37EC0", Offset = "0x2C36CC0", VA = "0x182C37EC0")]
	public static void ADGGKAPKBFK(this LIEODINBDBP IONGKOPBOLO, ReadOnlyMemory<byte> HFNFJCAIOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x24A3560", Offset = "0x24A2360", VA = "0x1824A3560")]
	public static void FJGIJIFMICL<T>(this LIEODINBDBP IONGKOPBOLO, in T IGJPNMBCJPK) where T : struct, KCJNPCKFNOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x24A3690", Offset = "0x24A2490", VA = "0x1824A3690")]
	public static T INFOCGEPMKK<T>(this LIEODINBDBP IONGKOPBOLO) where T : struct, KCJNPCKFNOM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2C37F40", Offset = "0x2C36D40", VA = "0x182C37F40")]
	public static void FJGIJIFMICL(this LIEODINBDBP IONGKOPBOLO, AHHBCIFGLKD MKJJIEOPNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2C37F70", Offset = "0x2C36D70", VA = "0x182C37F70")]
	public static AHHBCIFGLKD IHHICDGMLOH(this LIEODINBDBP IONGKOPBOLO)
	{
		return default(AHHBCIFGLKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2C380C0", Offset = "0x2C36EC0", VA = "0x182C380C0")]
	public static void PDMBADLPGPD(this LIEODINBDBP MLMFBHHJDGG, uint KDILLIFJBAB, bool IKEEKKBIKHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2C37FA0", Offset = "0x2C36DA0", VA = "0x182C37FA0")]
	public static uint IJJMPDCGMOF(this LIEODINBDBP ANKKMEDLEHC, bool IKEEKKBIKHE = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class JDFCCEAHJKH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class MCMDIKCOCPL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public MCMDIKCOCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2E49640", Offset = "0x2E48440", VA = "0x182E49640")]
		internal void <GetByteEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2E496B0", Offset = "0x2E484B0", VA = "0x182E496B0")]
		internal T <GetByteEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class PODBDOJNCKI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public PODBDOJNCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x35EE880", Offset = "0x35ED680", VA = "0x1835EE880")]
		internal void <GetSByteEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x35EE8F0", Offset = "0x35ED6F0", VA = "0x1835EE8F0")]
		internal T <GetSByteEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class DPJDMLFJDBK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public DPJDMLFJDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x359D680", Offset = "0x359C480", VA = "0x18359D680")]
		internal void <GetShortEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x359D6F0", Offset = "0x359C4F0", VA = "0x18359D6F0")]
		internal T <GetShortEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class DDDLHDLIJED<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public DDDLHDLIJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x26F6E20", Offset = "0x26F5C20", VA = "0x1826F6E20")]
		internal void <GetUShortEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x26F6E90", Offset = "0x26F5C90", VA = "0x1826F6E90")]
		internal T <GetUShortEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class MDNDOBPABLL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public MDNDOBPABLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x2E4CA70", Offset = "0x2E4B870", VA = "0x182E4CA70")]
		internal void <GetIntEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2E4CAD0", Offset = "0x2E4B8D0", VA = "0x182E4CAD0")]
		internal T <GetIntEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class EKJHNAHJOMP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public EKJHNAHJOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6430", Offset = "0x1AD5230", VA = "0x181AD6430")]
		internal void <GetUIntEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6490", Offset = "0x1AD5290", VA = "0x181AD6490")]
		internal T <GetUIntEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2407D00", Offset = "0x2406B00", VA = "0x182407D00")]
	public static void JFLMAPNOFGN<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2407A60", Offset = "0x2406860", VA = "0x182407A60")]
	private static void BLMDOAOIMHH<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2407A60", Offset = "0x2406860", VA = "0x182407A60")]
	private static void POPMCBJMLJP<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x2407910", Offset = "0x2406710", VA = "0x182407910")]
	private static void MIOBCDGBBAN<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x2407910", Offset = "0x2406710", VA = "0x182407910")]
	private static void AOFHIEHMIOC<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x2407BB0", Offset = "0x24069B0", VA = "0x182407BB0")]
	private static void JGHCKDJLCEC<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2407BB0", Offset = "0x24069B0", VA = "0x182407BB0")]
	private static void IINAIGGFAAD<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public abstract class CPJOAFBACJL : BOLFBGCGJHF, CDAFEBOKDJF
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2C30B90", Offset = "0x2C2F990", VA = "0x182C30B90", Slot = "4")]
	private void LKONOPAGGKI(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LECGAABEIOL(KJJHEOCLACN GMKKBMEMHOP);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	protected CPJOAFBACJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[AGGLFMPJHMG(typeof(LocalPoseData))]
public sealed class BLHLFHAGAIK : CPJOAFBACJL
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E2E0", Offset = "0x2C2D0E0", VA = "0x182C2E2E0", Slot = "5")]
	protected override void LECGAABEIOL(KJJHEOCLACN GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
	public BLHLFHAGAIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[InternalBufferCapacity(1)]
internal struct LNHLLFKMJJK : ISystemStateBufferElementData, IBufferElementData, IEquatable<LNHLLFKMJJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public HDIMMDIONOF MIGDJNOKMHC;

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2829F40", Offset = "0x2828D40", VA = "0x182829F40", Slot = "4")]
	public bool Equals(LNHLLFKMJJK HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x735E40", VA = "0x180737040")]
	public static LNHLLFKMJJK PAAEKNCKHBI(HDIMMDIONOF MIGDJNOKMHC)
	{
		return default(LNHLLFKMJJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[InternalBufferCapacity(4)]
internal struct BCGNKDMNODC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public HDIMMDIONOF MIGDJNOKMHC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x735E40", VA = "0x180737040")]
	public static BCGNKDMNODC PAAEKNCKHBI(HDIMMDIONOF MIGDJNOKMHC)
	{
		return default(BCGNKDMNODC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal struct HDIMMDIONOF : global::OCGKPONDJPA<HDIMMDIONOF>, GPAFGALANDE, IEquatable<HDIMMDIONOF>
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707C20", VA = "0x180708E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707B90", VA = "0x180708D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x85F7F0", Offset = "0x85E5F0", VA = "0x18085F7F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xD8A100", Offset = "0xD88F00", VA = "0x180D8A100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2829F90", Offset = "0x2828D90", VA = "0x182829F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2829F40", Offset = "0x2828D40", VA = "0x182829F40", Slot = "8")]
	public bool Equals(HDIMMDIONOF HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2829FD0", Offset = "0x2828DD0", VA = "0x182829FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class FPEBBPOHPPF : ParentSystemBase<AuthoredParentData, HDLOBHOIHNH, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2827F90", Offset = "0x2826D90", VA = "0x182827F90", Slot = "14")]
	protected override EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7014B0", VA = "0x1807026B0", Slot = "15")]
	protected override EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2827F50", Offset = "0x2826D50", VA = "0x182827F50", Slot = "16")]
	protected override EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2827F10", Offset = "0x2826D10", VA = "0x182827F10", Slot = "17")]
	protected override EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2828010", Offset = "0x2826E10", VA = "0x182828010")]
	public FPEBBPOHPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2827FD0", Offset = "0x2826DD0", VA = "0x182827FD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[IFBLAMOEMKH(CMGBDLINHMB.Connectables)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public class UpdateConnectableVisuals : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		private struct DAOGBIHJNFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public HDIMMDIONOF MIGDJNOKMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public float3 EIIEKPIPEEF;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x3600990", Offset = "0x35FF790", VA = "0x183600990")]
			public DAOGBIHJNFE(HDIMMDIONOF MIGDJNOKMHC, float3 EIIEKPIPEEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x3600970", Offset = "0x35FF770", VA = "0x183600970")]
			public void PIELOEDOOJA(out HDIMMDIONOF MIGDJNOKMHC, out float3 EIIEKPIPEEF)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private struct MAJDNBHGGKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public NativeList<DAOGBIHJNFE> list;

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public MAJDNBHGGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<BCGNKDMNODC> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private struct IDCMJDPABOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public NativeList<DAOGBIHJNFE> list;

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public IDCMJDPABOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<LNHLLFKMJJK> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private struct HFPHMGCFMCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public NativeList<DAOGBIHJNFE> list;

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public HFPHMGCFMCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in CAJJCLKLGOM com, in DynamicBuffer<LNHLLFKMJJK> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LHPEMGIFDKN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A3")]
			private struct KLCIBDBGDKE
			{
				[Cpp2IlInjected.Token(Token = "0x20000A4")]
				public struct ODNGCGDEBMO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000223")]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000224")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NOGDCLGMIGC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000225")]
					public LambdaParameterValueProvider_DynamicBuffer<BCGNKDMNODC>.Runtime HCNFGDNKKKK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000220")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000221")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> AJGIAIHDKCO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000222")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<BCGNKDMNODC> CKDIABANJOC;

				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x3607550", Offset = "0x3606350", VA = "0x183607550")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0x3607490", Offset = "0x3606290", VA = "0x183607490")]
				public ODNGCGDEBMO LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(ODNGCGDEBMO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public UpdateConnectableVisuals OGFKLGAJDGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public NativeList<DAOGBIHJNFE> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private KLCIBDBGDKE JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KLCIBDBGDKE.ODNGCGDEBMO* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x36079D0", Offset = "0x36067D0", VA = "0x1836079D0")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, WorldPoseData JFKBEONBDEB, in DynamicBuffer<BCGNKDMNODC> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x3607C10", Offset = "0x3606A10", VA = "0x183607C10", Slot = "5")]
			public void ReadFromDisplayClass(ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x3607C40", Offset = "0x3606A40", VA = "0x183607C40", Slot = "6")]
			public void WriteToDisplayClass(ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x3607700", Offset = "0x3606500", VA = "0x183607700", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x3607890", Offset = "0x3606690", VA = "0x183607890")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref KLCIBDBGDKE.ODNGCGDEBMO PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x3607850", Offset = "0x3606650", VA = "0x183607850")]
			public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ, ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x36077E0", Offset = "0x36065E0", VA = "0x1836077E0")]
			public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct ENDBCHEICFA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A6")]
			private struct KDBKHHONECG
			{
				[Cpp2IlInjected.Token(Token = "0x20000A7")]
				[NoAlias]
				public struct CLJCBBMJEAI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400022B")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NOGDCLGMIGC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400022C")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK>.Runtime HCNFGDNKKKK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000229")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> AJGIAIHDKCO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400022A")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK> CKDIABANJOC;

				[Cpp2IlInjected.Token(Token = "0x6000595")]
				[Cpp2IlInjected.Address(RVA = "0x3606F10", Offset = "0x3605D10", VA = "0x183606F10")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000596")]
				[Cpp2IlInjected.Address(RVA = "0x3606E70", Offset = "0x3605C70", VA = "0x183606E70")]
				public CLJCBBMJEAI LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(CLJCBBMJEAI);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public NativeList<DAOGBIHJNFE> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			private KDBKHHONECG JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KDBKHHONECG.CLJCBBMJEAI* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x3601FC0", Offset = "0x3600DC0", VA = "0x183601FC0")]
			internal void POIJCEOICMD(in WorldPoseData JFKBEONBDEB, in DynamicBuffer<LNHLLFKMJJK> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x3601180", Offset = "0x35FFF80", VA = "0x183601180", Slot = "5")]
			public void ReadFromDisplayClass(ref IDCMJDPABOF CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x3601D80", Offset = "0x3600B80", VA = "0x183601D80", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x3601EF0", Offset = "0x3600CF0", VA = "0x183601EF0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref KDBKHHONECG.CLJCBBMJEAI PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x3601E50", Offset = "0x3600C50", VA = "0x183601E50")]
			public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ, ref IDCMJDPABOF CBENCAHNLAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct IIBJIOOCOBL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A9")]
			private struct NBEECHMBMMD
			{
				[Cpp2IlInjected.Token(Token = "0x20000AA")]
				[NoAlias]
				public struct AEMNPDNKMCB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000233")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NOGDCLGMIGC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000234")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<CAJJCLKLGOM>.Runtime PDGFBALHOAP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000235")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK>.Runtime HCNFGDNKKKK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000230")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> AJGIAIHDKCO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000231")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<CAJJCLKLGOM> PFFOLDMEOOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<LNHLLFKMJJK> CKDIABANJOC;

				[Cpp2IlInjected.Token(Token = "0x600059C")]
				[Cpp2IlInjected.Address(RVA = "0x3609390", Offset = "0x3608190", VA = "0x183609390")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0x36092C0", Offset = "0x36080C0", VA = "0x1836092C0")]
				public AEMNPDNKMCB LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(AEMNPDNKMCB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			public NativeList<DAOGBIHJNFE> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private NBEECHMBMMD JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NBEECHMBMMD.AEMNPDNKMCB* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x3604CD0", Offset = "0x3603AD0", VA = "0x183604CD0")]
			internal void POIJCEOICMD(in WorldPoseData JFKBEONBDEB, in CAJJCLKLGOM LCODFDEFNPG, in DynamicBuffer<LNHLLFKMJJK> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x3601180", Offset = "0x35FFF80", VA = "0x183601180", Slot = "5")]
			public void ReadFromDisplayClass(ref HFPHMGCFMCO CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x3604AF0", Offset = "0x36038F0", VA = "0x183604AF0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x3604BB0", Offset = "0x36039B0", VA = "0x183604BB0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref NBEECHMBMMD.AEMNPDNKMCB PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x3604B70", Offset = "0x3603970", VA = "0x183604B70")]
			public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ, ref HFPHMGCFMCO CBENCAHNLAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private EntityQuery DHJICPEOEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private EntityQuery LKEANLPNLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private EntityQuery MKGEPDNHDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private EntityQuery HINGOOJNECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private EntityQuery OJEDGKDPNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private EntityQuery LOKLOJOMFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private EntityQuery MCDIDIBLHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private EntityQuery LMCBNGAADFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private EntityQuery BDLIIGOHHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private EntityQuery GGKKMBAOJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private global::OPFKIBDDGAC<HDIMMDIONOF, ODDCBCICFNM> EOGGCJMEACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private JLCJAEGDOGE CFPCEBNDHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private BFIAFBHOKLF KKJNDEPMACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private LEFOFMICAIA PEMCBJCDENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private EntityQuery BOKIIBPIGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private ProfilerMarker PPNHEPGICAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private EntityQuery DGANBMPFBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private EntityQuery AOLEJCLKADJ;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x287E690", Offset = "0x287D490", VA = "0x18287E690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x287D2E0", Offset = "0x287C0E0", VA = "0x18287D2E0")]
		internal ODDCBCICFNM DBLMFLLDADB(HDIMMDIONOF MIGDJNOKMHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x287E370", Offset = "0x287D170", VA = "0x18287E370", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x287FEE0", Offset = "0x287ECE0", VA = "0x18287FEE0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x2880070", Offset = "0x287EE70", VA = "0x182880070", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x287FCA0", Offset = "0x287EAA0", VA = "0x18287FCA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x287CC90", Offset = "0x287BA90", VA = "0x18287CC90")]
		private void AMGJKIINAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x287D190", Offset = "0x287BF90", VA = "0x18287D190")]
		private void BGLGGKOKAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x287F5C0", Offset = "0x287E3C0", VA = "0x18287F5C0")]
		private void KLKFABFKPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x28800B0", Offset = "0x287EEB0", VA = "0x1828800B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x287EE90", Offset = "0x287DC90", VA = "0x18287EE90")]
		private void JBCFLHJDAGD(EntityQuery BCEJPCNJJCE, EntityQuery JEGEKBCLIDO, EntityQuery GDFDIGMMCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x287CBC0", Offset = "0x287B9C0", VA = "0x18287CBC0")]
		private void AKJLIPOIGHF(EntityQuery GDFDIGMMCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x287E430", Offset = "0x287D230", VA = "0x18287E430")]
		private void HLKMKDJBMNE(global::OHBAMBCHLEK<Entity> PFHHBJBMJNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x28809B0", Offset = "0x287F7B0", VA = "0x1828809B0")]
		private void POCPHLCGLHH(global::OHBAMBCHLEK<Entity> CDCMOCAOHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x287E110", Offset = "0x287CF10", VA = "0x18287E110")]
		private void FKDOMINAOPC(global::OHBAMBCHLEK<Entity> OIJFDMIKPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x287D7E0", Offset = "0x287C5E0", VA = "0x18287D7E0")]
		private void DLKDNGDBFPE(NativeList<HDIMMDIONOF> CGLIDIBELOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x287D950", Offset = "0x287C750", VA = "0x18287D950")]
		private NativeList<HDIMMDIONOF> EHCMIFOEHDA(NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(NativeList<HDIMMDIONOF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2880380", Offset = "0x287F180", VA = "0x182880380")]
		private void PFLKGFHEELP(NativeArray<Entity> FBMJMNCDHDM, NativeList<HDIMMDIONOF> CGLIDIBELOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x287E6D0", Offset = "0x287D4D0", VA = "0x18287E6D0")]
		private void IFKFOBFCAHC(NativeArray<Entity> BFNKKPHBOMC, NativeArray<Entity> DPOBAKHBGJO, NativeList<HDIMMDIONOF> NFMFOGHBEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x287D330", Offset = "0x287C130", VA = "0x18287D330")]
		private void DCPFKPHFGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x287DFD0", Offset = "0x287CDD0", VA = "0x18287DFD0")]
		private global::AFBJNMJHLIH<DAOGBIHJNFE> FDHHLJMLGBG(EntityQuery JFPFDEFJDBP, Func<NativeList<DAOGBIHJNFE>, JobHandle> PJIHFBPLBLO)
		{
			return default(global::AFBJNMJHLIH<DAOGBIHJNFE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x287CDA0", Offset = "0x287BBA0", VA = "0x18287CDA0")]
		private JobHandle BADABDFPCNL(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x287DE90", Offset = "0x287CC90", VA = "0x18287DE90")]
		private JobHandle EKOHHILIPNF(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x287F970", Offset = "0x287E770", VA = "0x18287F970")]
		private JobHandle MGHJLADJONE(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x287C930", Offset = "0x287B730", VA = "0x18287C930")]
		private void AKCJIAKBIJA(global::AFBJNMJHLIH<DAOGBIHJNFE> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x287EC00", Offset = "0x287DA00", VA = "0x18287EC00")]
		private void IGPOMOKCBNF(global::AFBJNMJHLIH<DAOGBIHJNFE> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x287E230", Offset = "0x287D030", VA = "0x18287E230")]
		private bool GOJFDMOJAKO(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x287E290", Offset = "0x287D090", VA = "0x18287E290")]
		private NativeArray<Entity> GPCOJPDJHCG(Entity GEEFHDFLBEH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x28801C0", Offset = "0x287EFC0", VA = "0x1828801C0")]
		private HDIMMDIONOF PANOFCIBOHH(NativeList<HDIMMDIONOF> NFMFOGHBEPK)
		{
			return default(HDIMMDIONOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x287F2C0", Offset = "0x287E0C0", VA = "0x18287F2C0")]
		private void JLABOBGJOHB(HDIMMDIONOF MIGDJNOKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x28672D0", Offset = "0x28660D0", VA = "0x1828672D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x287FAA0", Offset = "0x287E8A0", VA = "0x18287FAA0")]
		public static EntityQuery NGOKAPGAKBC(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x287CF30", Offset = "0x287BD30", VA = "0x18287CF30")]
		public static EntityQuery BEACGJJJMMJ(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x287F350", Offset = "0x287E150", VA = "0x18287F350")]
		public static EntityQuery KACGELCIFII(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class JGNGJMNAFKA : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private ObjectEmbodimentService KFHKDGFGKJJ;

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2830840", Offset = "0x282F640", VA = "0x182830840", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x28308A0", Offset = "0x282F6A0", VA = "0x1828308A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x28308D0", Offset = "0x282F6D0", VA = "0x1828308D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	protected JGNGJMNAFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class FBGPKGAHMCA : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private EntityQuery JEDIHPJPGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private EntityQuery JAEMJPPGJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private EntityQuery LCANOIDKHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private EntityQuery MOOHGBALNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private ObjectEmbodimentService NDHAELBFJCF;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public int HJDHFKEEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C425E0", Offset = "0x2C413E0", VA = "0x182C425E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int AKKJDCEMEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C428C0", Offset = "0x2C416C0", VA = "0x182C428C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C42490", Offset = "0x2C41290", VA = "0x182C42490", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C428D0", Offset = "0x2C416D0", VA = "0x182C428D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C42AC0", Offset = "0x2C418C0", VA = "0x182C42AC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C425F0", Offset = "0x2C413F0", VA = "0x182C425F0")]
	protected void LCIEOJEPMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C41FE0", Offset = "0x2C40DE0", VA = "0x182C41FE0")]
	protected void BCMMENNOOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C424F0", Offset = "0x2C412F0", VA = "0x182C424F0")]
	private bool KJBCNCCLGDG(EntityQuery JFPFDEFJDBP, out NativeArray<Entity> FBMJMNCDHDM, out NativeArray<EMPKMDMEDJP> AGFPEFOAJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C42320", Offset = "0x2C41120", VA = "0x182C42320")]
	public global::OHBAMBCHLEK<Entity> DJEDMHNKNKM(Allocator JEOILJEOOOI)
	{
		return default(global::OHBAMBCHLEK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C423E0", Offset = "0x2C411E0", VA = "0x182C423E0")]
	public global::OHBAMBCHLEK<Entity> FEEJMBLMDJL(Allocator JEOILJEOOOI)
	{
		return default(global::OHBAMBCHLEK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C42360", Offset = "0x2C41160", VA = "0x182C42360")]
	public bool EBCBHCDIKAJ(Allocator JEOILJEOOOI, out global::OHBAMBCHLEK<Entity> DNCNJICBAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C42250", Offset = "0x2C41050", VA = "0x182C42250")]
	public bool CDOIOEBAIAC(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C42420", Offset = "0x2C41220", VA = "0x182C42420")]
	public GIALAGJINEB GMGIMGJFJIG(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C422B0", Offset = "0x2C410B0", VA = "0x182C422B0")]
	public bool CECLHLMOAFB(Entity GEEFHDFLBEH, out HDIAJFLHONH DNCNJICBAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C41FA0", Offset = "0x2C40DA0", VA = "0x182C41FA0")]
	public void AOPNOMOLIPC(Entity GEEFHDFLBEH, HDIAJFLHONH DNCNJICBAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C42860", Offset = "0x2C41660", VA = "0x182C42860")]
	public bool MEEOHNLDHKG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public FBGPKGAHMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class HDIAJFLHONH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public GIALAGJINEB DNCNJICBAHE;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public HDIAJFLHONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
	public HDIAJFLHONH(GIALAGJINEB DNCNJICBAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class AEKANGFCDAO : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private EntityQuery IKPKMFGJGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private IJONKAEAEBK NFACINHMFIO;

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C26740", Offset = "0x2C25540", VA = "0x182C26740", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C26790", Offset = "0x2C25590", VA = "0x182C26790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C26850", Offset = "0x2C25650", VA = "0x182C26850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x2022550", Offset = "0x2021350", VA = "0x182022550")]
	private bool KJBCNCCLGDG<TComponentData>(EntityQuery JFPFDEFJDBP, out NativeArray<Entity> FBMJMNCDHDM, out NativeArray<TComponentData> CGPLPFBCOHF) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C266D0", Offset = "0x2C254D0", VA = "0x182C266D0")]
	public GIALAGJINEB GMGIMGJFJIG(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public AEKANGFCDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[IFBLAMOEMKH(CMGBDLINHMB.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private EntityQuery FHLFFMDFBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private EntityQuery NJEIDEGDHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private EntityQuery OLGKCFEPIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x2875420", Offset = "0x2874220", VA = "0x182875420", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x2875470", Offset = "0x2874270", VA = "0x182875470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x28755E0", Offset = "0x28743E0", VA = "0x1828755E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x28750D0", Offset = "0x2873ED0", VA = "0x1828750D0")]
		private void ENDJPLBKPHO(EntityQuery JFPFDEFJDBP, bool CJONJKNGENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMAGEIGMADI))]
public class FLHBJAPMFOE : IKEIJDHBAML
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public FLHBJAPMFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
public abstract class KKPNBIDGCGE : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private CMEEFJNDPID OAACGCFNLFM;

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x2834200", Offset = "0x2833000", VA = "0x182834200", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2834260", Offset = "0x2833060", VA = "0x182834260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	protected KKPNBIDGCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class NIENIENGCDI : IKEIJDHBAML, CDAFEBOKDJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct KDOOAAPMPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NativeList<MIFKFPHADFM> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public NativeList<FDCGJNDCDCD> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public NativeList<MIFKFPHADFM> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public KDOOAAPMPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, HHCGCCCMOPE previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__2(Entity entity, HHCGCCCMOPE previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct OMIFHIDJDJH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		private struct JGCFLCKJLMG
		{
			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			[NoAlias]
			public struct CJKCAPBAJNG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime KABOPAPBNNB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> LMJMEJIPPCK;

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x3606200", Offset = "0x3605000", VA = "0x183606200")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x3606180", Offset = "0x3604F80", VA = "0x183606180")]
			public CJKCAPBAJNG LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(CJKCAPBAJNG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public NativeList<MIFKFPHADFM> EJGHENKOJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private JGCFLCKJLMG JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JGCFLCKJLMG.CJKCAPBAJNG* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x360A310", Offset = "0x3609110", VA = "0x18360A310")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ParentData MGGGHPDHPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x3601180", Offset = "0x35FFF80", VA = "0x183601180", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x360A130", Offset = "0x3608F30", VA = "0x18360A130", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x360A260", Offset = "0x3609060", VA = "0x18360A260")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JGCFLCKJLMG.CJKCAPBAJNG PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x360A1D0", Offset = "0x3608FD0", VA = "0x18360A1D0")]
		public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ, ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct CNCDGCENJNB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		private struct HOLILIMPEPD
		{
			[Cpp2IlInjected.Token(Token = "0x20000B9")]
			[NoAlias]
			public struct OCBILNBJBML
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000259")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400025A")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime KABOPAPBNNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400025B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE>.Runtime IOOBKKDKNIM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> LMJMEJIPPCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE> BBMMEHFCFGH;

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x3604530", Offset = "0x3603330", VA = "0x183604530")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x3604490", Offset = "0x3603290", VA = "0x183604490")]
			public OCBILNBJBML LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(OCBILNBJBML);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public NativeList<FDCGJNDCDCD> AOAOEICHLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private HOLILIMPEPD JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HOLILIMPEPD.OCBILNBJBML* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x35FFE00", Offset = "0x35FEC00", VA = "0x1835FFE00")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ParentData MGGGHPDHPFB, HHCGCCCMOPE HFLCHCKFKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x35FFEC0", Offset = "0x35FECC0", VA = "0x1835FFEC0", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x35FFC10", Offset = "0x35FEA10", VA = "0x1835FFC10", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x35FFD20", Offset = "0x35FEB20", VA = "0x1835FFD20")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref HOLILIMPEPD.OCBILNBJBML PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x35FFCE0", Offset = "0x35FEAE0", VA = "0x1835FFCE0")]
		public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ, ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct NLFHHEBNEHB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private struct KAOAJFMCLOO
		{
			[Cpp2IlInjected.Token(Token = "0x20000BC")]
			[NoAlias]
			public struct MHJPNNPCLFK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE>.Runtime IOOBKKDKNIM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<HHCGCCCMOPE> BBMMEHFCFGH;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x3606E10", Offset = "0x3605C10", VA = "0x183606E10")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x3606D90", Offset = "0x3605B90", VA = "0x183606D90")]
			public MHJPNNPCLFK LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MHJPNNPCLFK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public NativeList<MIFKFPHADFM> NFIMDAGFELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private KAOAJFMCLOO JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KAOAJFMCLOO.MHJPNNPCLFK* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x3609600", Offset = "0x3608400", VA = "0x183609600")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, HHCGCCCMOPE HFLCHCKFKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x3609680", Offset = "0x3608480", VA = "0x183609680", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x3609420", Offset = "0x3608220", VA = "0x183609420", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x3609550", Offset = "0x3608350", VA = "0x183609550")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref KAOAJFMCLOO.MHJPNNPCLFK PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x36094C0", Offset = "0x36082C0", VA = "0x1836094C0")]
		public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ, ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private MFLHDAEOBPP JLGDDMFNKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private EntityQuery PEPHMBJGIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private EntityQuery GPKOHCPPELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private EntityQuery JOMHNLJLCKH;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x283AAF0", Offset = "0x28398F0", VA = "0x18283AAF0", Slot = "14")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x283AE60", Offset = "0x2839C60", VA = "0x18283AE60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public NIENIENGCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x283AE00", Offset = "0x2839C00", VA = "0x18283AE00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x283A890", Offset = "0x2839690", VA = "0x18283A890")]
	public static EntityQuery HJIOGFGIOPK(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x283ABD0", Offset = "0x28399D0", VA = "0x18283ABD0")]
	public static EntityQuery OFEBIIBCALM(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x283A690", Offset = "0x2839490", VA = "0x18283A690")]
	public static EntityQuery FMJJEMBGJDL(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class LFLBNLDBEKG : ParentSystemBase<ParentData, HHCGCCCMOPE, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x2836D70", Offset = "0x2835B70", VA = "0x182836D70", Slot = "14")]
	protected override EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7014B0", VA = "0x1807026B0", Slot = "15")]
	protected override EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2836D30", Offset = "0x2835B30", VA = "0x182836D30", Slot = "16")]
	protected override EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2836CF0", Offset = "0x2835AF0", VA = "0x182836CF0", Slot = "17")]
	protected override EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2836DF0", Offset = "0x2835BF0", VA = "0x182836DF0")]
	public LFLBNLDBEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2836DB0", Offset = "0x2835BB0", VA = "0x182836DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : DBEHBMCDNIE where ParentData : struct, IComponentData, LJBPPGAHFFJ where PreviousParentData : struct, IComponentData, LJBPPGAHFFJ where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, LJBPPGAHFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[BurstCompile]
		private struct PONKHBDJFMP : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter LGLGJICGDIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter KAEFBIEAHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			public NativeHashMap<Entity, int>.ParallelWriter LKILBOGDEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			public ArchetypeChunkComponentType<PreviousParentData> IIAEBCGKKEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> PGHIPBBDPPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			[ReadOnly]
			public ArchetypeChunkEntityType DLIGLBABHFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			public uint AEPGONMKGBO;

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x2BF2CF0", Offset = "0x2BF1AF0", VA = "0x182BF2CF0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[BurstCompile]
		private struct GEMJCKJFEBC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			[ReadOnly]
			public NativeHashMap<Entity, int> LKILBOGDEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> EMOHOBKNIOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			public NativeList<Entity> KEACBGMPABP;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x2308C60", Offset = "0x2307A60", VA = "0x182308C60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		[BurstCompile]
		private struct GEEOIALOAMJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> LGLGJICGDIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> KAEFBIEAHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			[ReadOnly]
			public NativeHashMap<Entity, int> LKILBOGDEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			public BufferFromEntity<ChildrenData> EMOHOBKNIOB;

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x23078B0", Offset = "0x23066B0", VA = "0x1823078B0")]
			private int KAFCAMPBMAK(DynamicBuffer<ChildrenData> FALFIAAPAEL, Entity GEEFHDFLBEH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2307750", Offset = "0x2306550", VA = "0x182307750")]
			private void GGDHNAHHAOK(Entity ADECAOLBLPJ, DynamicBuffer<ChildrenData> FALFIAAPAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x2307C00", Offset = "0x2306A00", VA = "0x182307C00")]
			private void LLJMGCBHJMB(Entity ADECAOLBLPJ, DynamicBuffer<ChildrenData> FALFIAAPAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x2307330", Offset = "0x2306130", VA = "0x182307330", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[BurstCompile]
		private struct MEEINAIJODP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			public NativeArray<Entity> GLLJFEKGHFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			public NativeList<Entity> NEAKJMIFMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public BufferFromEntity<ChildrenData> EMOHOBKNIOB;

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x2E4D230", Offset = "0x2E4C030", VA = "0x182E4D230", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		protected EntityQuery DJOOGAALAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		protected EntityQuery NFIJMBBEFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		protected EntityQuery HJKBACBKGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		protected EntityQuery MAMPFFHAMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		protected ProfilerMarker JBGNHGGIFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		protected ProfilerMarker FOIFMNENJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		protected ProfilerMarker EHGOOOIKIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		protected ProfilerMarker NKJJFFCGELJ;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD290", Offset = "0x2BFC090", VA = "0x182BFD290")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC8F0", Offset = "0x2BFB6F0", VA = "0x182BFC8F0")]
		private int KAFCAMPBMAK(DynamicBuffer<ChildrenData> FALFIAAPAEL, Entity GEEFHDFLBEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC630", Offset = "0x2BFB430", VA = "0x182BFC630")]
		private void HAEJNAPBJEK(Entity AIANMNKPJDO, Entity ICOEFFELKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7014B0", VA = "0x1807026B0", Slot = "14")]
		protected virtual EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7014B0", VA = "0x1807026B0", Slot = "15")]
		protected virtual EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7014B0", VA = "0x1807026B0", Slot = "16")]
		protected virtual EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP);

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCC90", Offset = "0x2BFBA90", VA = "0x182BFCC90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCAD0", Offset = "0x2BFB8D0", VA = "0x182BFCAD0")]
		private void KFFENDCIJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC290", Offset = "0x2BFB090", VA = "0x182BFC290")]
		private void EDOBDLADANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB210", Offset = "0x2BFA010", VA = "0x182BFB210")]
		private void AJNECNOFGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBBF0", Offset = "0x2BFA9F0", VA = "0x182BFBBF0")]
		private void DIBNIDMHLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD1D0", Offset = "0x2BFBFD0", VA = "0x182BFD1D0", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x17BD330", Offset = "0x17BC130", VA = "0x1817BD330", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[AlwaysUpdateSystem]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.RenderEffects)]
	public abstract class PropagateTagsBase<TRootTag, TDescendantTag, TRootSystemTag> : IKEIJDHBAML, CDAFEBOKDJF where TRootTag : struct, IComponentData where TDescendantTag : struct, IComponentData where TRootSystemTag : struct, ISystemStateComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		private struct AGNHJPPPNED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public global::AFBJNMJHLIH<Entity> MMHAHCJBHGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			public global::AFBJNMJHLIH<Entity> HPHEMDOFNNP;

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x23C1680", Offset = "0x23C0480", VA = "0x1823C1680")]
			public AGNHJPPPNED(NativeList<Entity> MMHAHCJBHGK, NativeList<Entity> HPHEMDOFNNP, JobHandle AADBABLKHJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x23C11F0", Offset = "0x23BFFF0", VA = "0x1823C11F0")]
			public JobHandle IBPCJLOGNIJ(JobHandle GINKINFGNEP)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x23C1370", Offset = "0x23C0170", VA = "0x1823C1370")]
			public void ICKDJJKFGLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[BurstCompile]
		private struct MANBCFEMMMC : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000C6")]
			[Flags]
			public enum JKKPLNLGLBI
			{
				[Cpp2IlInjected.Token(Token = "0x400028D")]
				ReadParentFromArray = 1,
				[Cpp2IlInjected.Token(Token = "0x400028E")]
				FetchParentFromEntity = 2,
				[Cpp2IlInjected.Token(Token = "0x400028F")]
				AncestorTagValue = 4,
				[Cpp2IlInjected.Token(Token = "0x4000290")]
				ConstNoAncestorTag = 0,
				[Cpp2IlInjected.Token(Token = "0x4000291")]
				ConstHasAncestorTag = 4
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			[WriteOnly]
			public NativeList<Entity> PFFFDGGJNNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			[WriteOnly]
			public NativeList<Entity> PPIJMDDCAPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			[ReadOnly]
			public NativeArray<Entity> MBFIPMKAEEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000285")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> ALANNIIDHOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			[ReadOnly]
			public ComponentDataFromEntity<TRootTag> OMPKNGGDAOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			[ReadOnly]
			public ComponentDataFromEntity<TDescendantTag> PDHIELHHNIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> DOIFFICECOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			public int BJNNEGIPGIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			public int BGIAACHOOGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private JKKPLNLGLBI JMJCIMAHPFC;

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x2E42550", Offset = "0x2E41350", VA = "0x182E42550", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x2E42EA0", Offset = "0x2E41CA0", VA = "0x182E42EA0")]
			private void GJJCPKFPJDJ(Entity GEEFHDFLBEH, bool DHIBJIHPGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x2E438C0", Offset = "0x2E426C0", VA = "0x182E438C0")]
			private void IJHEEAOHCEG(Entity GEEFHDFLBEH, bool DHIBJIHPGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x2E41C60", Offset = "0x2E40A60", VA = "0x182E41C60")]
			public AGNHJPPPNED ABHIGKNBIPJ(NativeArray<Entity> PNCPJCEBIDF, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x2E42A10", Offset = "0x2E41810", VA = "0x182E42A10")]
			public AGNHJPPPNED GHIBFNJEHGI(NativeArray<Entity> PNCPJCEBIDF, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x2E42110", Offset = "0x2E40F10", VA = "0x182E42110")]
			public AGNHJPPPNED CPCMEDGJJJN(NativeList<MIFKFPHADFM> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x2E43AF0", Offset = "0x2E428F0", VA = "0x182E43AF0")]
			public AGNHJPPPNED LPLFIDJHJFJ(NativeList<MIFKFPHADFM> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x2E41D50", Offset = "0x2E40B50", VA = "0x182E41D50")]
			public AGNHJPPPNED CMFGMGFGOBH(NativeList<FDCGJNDCDCD> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x27EC2E0", Offset = "0x27EB0E0", VA = "0x1827EC2E0")]
			private AGNHJPPPNED HBPLCHGJNEG<T>(NativeList<T> LPDILHBGHIJ, int OJMDGHDFJIL, int CACEIMFJAFJ, JKKPLNLGLBI CIJCIMPGNPO, JobHandle GINKINFGNEP) where T : struct
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x2E431C0", Offset = "0x2E41FC0", VA = "0x182E431C0")]
			private AGNHJPPPNED HBPLCHGJNEG(NativeArray<Entity> FBMJMNCDHDM, int OJMDGHDFJIL, int CACEIMFJAFJ, JKKPLNLGLBI CIJCIMPGNPO, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private EntityQuery GLHIIMDAKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private EntityQuery LKOHBDGDHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private MFLHDAEOBPP MCFBCIDCFAP;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C280", Offset = "0x2F5B080", VA = "0x182F5C280", Slot = "14")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C3D0", Offset = "0x2F5B1D0", VA = "0x182F5C3D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2F5DCC0", Offset = "0x2F5CAC0", VA = "0x182F5DCC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C360", Offset = "0x2F5B160", VA = "0x182F5C360")]
		private void LCPKFCMPMKO(NativeArray<Entity> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2F5E7A0", Offset = "0x2F5D5A0", VA = "0x182F5E7A0")]
		private void POMGPNKGHPB(NativeArray<Entity> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2F5BCA0", Offset = "0x2F5AAA0", VA = "0x182F5BCA0")]
		private void GLNCJCIJIBI(AGNHJPPPNED NGJPGCIKGJJ, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2F5BA60", Offset = "0x2F5A860", VA = "0x182F5BA60")]
		private void GLNCJCIJIBI(global::AFBJNMJHLIH<Entity> LBNDFDCLDFN, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2F5BE20", Offset = "0x2F5AC20", VA = "0x182F5BE20")]
		private void GNHEPKEENCP(AGNHJPPPNED NGJPGCIKGJJ, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2F5BD00", Offset = "0x2F5AB00", VA = "0x182F5BD00")]
		private void GNHEPKEENCP(global::AFBJNMJHLIH<Entity> LBNDFDCLDFN, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2F5B8E0", Offset = "0x2F5A6E0", VA = "0x182F5B8E0")]
		private bool DDDCGGOHCCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2F5E880", Offset = "0x2F5D680", VA = "0x182F5E880")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x17BD330", Offset = "0x17BC130", VA = "0x1817BD330", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
public class KLGOENHKPJC : IKEIJDHBAML, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct IAHDCCHPIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public KLGOENHKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public IAHDCCHPIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OMNKGEPLMCG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		private struct DJLDJBNGFAG
		{
			[Cpp2IlInjected.Token(Token = "0x20000CB")]
			public struct MOBCKLINCAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029E")]
				public LambdaParameterValueProvider_Entity.Runtime NNNEIBCDMHK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAMDCKLNGJB;

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x36012E0", Offset = "0x36000E0", VA = "0x1836012E0")]
			public void LONPEHHIFCO(KLGOENHKPJC OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x36012D0", Offset = "0x36000D0", VA = "0x1836012D0")]
			public MOBCKLINCAK LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MOBCKLINCAK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public KLGOENHKPJC OGFKLGAJDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public EntityCommandBuffer DKBBKMLPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private DJLDJBNGFAG JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DJLDJBNGFAG.MOBCKLINCAK* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x360A500", Offset = "0x3609300", VA = "0x18360A500")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x3602E30", Offset = "0x3601C30", VA = "0x183602E30", Slot = "5")]
		public void ReadFromDisplayClass(ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x3602E60", Offset = "0x3601C60", VA = "0x183602E60", Slot = "6")]
		public void WriteToDisplayClass(ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x360A390", Offset = "0x3609190", VA = "0x18360A390", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x360A490", Offset = "0x3609290", VA = "0x18360A490")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref DJLDJBNGFAG.MOBCKLINCAK PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x360A450", Offset = "0x3609250", VA = "0x18360A450")]
		public void LONPEHHIFCO(KLGOENHKPJC OJEDNGBIKHJ, ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x360A3E0", Offset = "0x36091E0", VA = "0x18360A3E0")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private OPIMGAOPDNP IEBLHHMEHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private KNJHNLNIBIP LJDEGJIIHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private EntityQuery CJLGOGEHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private ProfilerMarker PNOEOGONAOK;

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2834590", Offset = "0x2833390", VA = "0x182834590", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2834450", Offset = "0x2833250", VA = "0x182834450", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x28345F0", Offset = "0x28333F0", VA = "0x1828345F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public KLGOENHKPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x28344B0", Offset = "0x28332B0", VA = "0x1828344B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2834280", Offset = "0x2833080", VA = "0x182834280")]
	public static EntityQuery DJJPMPNEMLM(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct JLKFGGHMAGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public NCGEEIAJEOJ MIGDJNOKMHC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
	public static JLKFGGHMAGN PAAEKNCKHBI(in NCGEEIAJEOJ PMFKMFEMMLL)
	{
		return default(JLKFGGHMAGN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
	public static NCGEEIAJEOJ PAAEKNCKHBI(in JLKFGGHMAGN EJIKNKJOMGE)
	{
		return default(NCGEEIAJEOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class OPIMGAOPDNP : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0")]
	public OPIMGAOPDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[AlwaysUpdateSystem]
[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
public class LIICBMDDEGK : IKEIJDHBAML, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct AKNNNKDPIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public LIICBMDDEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public AKNNNKDPIDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__0(Entity e, JLKFGGHMAGN ch)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct FNBILDILKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public LIICBMDDEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public FNBILDILKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnStopRunning>b__0(Entity e, JLKFGGHMAGN ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HDILDIBMMFF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		private struct NMLINPPPECO
		{
			[Cpp2IlInjected.Token(Token = "0x20000D3")]
			public struct MHFMMOIBIIB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B1")]
				public LambdaParameterValueProvider_Entity.Runtime NNNEIBCDMHK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002B2")]
				public LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN>.Runtime HGNBDPOMEEO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAMDCKLNGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN> BPNCNKJCBKJ;

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x3609710", Offset = "0x3608510", VA = "0x183609710")]
			public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x3609690", Offset = "0x3608490", VA = "0x183609690")]
			public MHFMMOIBIIB LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MHFMMOIBIIB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public LIICBMDDEGK OGFKLGAJDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public EntityCommandBuffer DKBBKMLPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private NMLINPPPECO JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NMLINPPPECO.MHFMMOIBIIB* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x3603AF0", Offset = "0x36028F0", VA = "0x183603AF0")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG, JLKFGGHMAGN DDEDCJNEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x3602E30", Offset = "0x3601C30", VA = "0x183602E30", Slot = "5")]
		public void ReadFromDisplayClass(ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3602E60", Offset = "0x3601C60", VA = "0x183602E60", Slot = "6")]
		public void WriteToDisplayClass(ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x36038A0", Offset = "0x36026A0", VA = "0x1836038A0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x3603A40", Offset = "0x3602840", VA = "0x183603A40")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref NMLINPPPECO.MHFMMOIBIIB PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x36039B0", Offset = "0x36027B0", VA = "0x1836039B0")]
		public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ, ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x3603940", Offset = "0x3602740", VA = "0x183603940")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FPBOKPJKAED : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		private struct HBMIEJLNNIO
		{
			[Cpp2IlInjected.Token(Token = "0x20000D6")]
			public struct EFMILKILIAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BA")]
				public LambdaParameterValueProvider_Entity.Runtime NNNEIBCDMHK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				public LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN>.Runtime HGNBDPOMEEO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GAMDCKLNGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JLKFGGHMAGN> BPNCNKJCBKJ;

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x3603840", Offset = "0x3602640", VA = "0x183603840")]
			public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x36037C0", Offset = "0x36025C0", VA = "0x1836037C0")]
			public EFMILKILIAD LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(EFMILKILIAD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public LIICBMDDEGK OGFKLGAJDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public EntityCommandBuffer DKBBKMLPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private HBMIEJLNNIO JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HBMIEJLNNIO.EFMILKILIAD* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x3602DA0", Offset = "0x3601BA0", VA = "0x183602DA0")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG, JLKFGGHMAGN DDEDCJNEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x3602E30", Offset = "0x3601C30", VA = "0x183602E30", Slot = "5")]
		public void ReadFromDisplayClass(ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x3602E60", Offset = "0x3601C60", VA = "0x183602E60", Slot = "6")]
		public void WriteToDisplayClass(ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x3602B50", Offset = "0x3601950", VA = "0x183602B50", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x3602CF0", Offset = "0x3601AF0", VA = "0x183602CF0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref HBMIEJLNNIO.EFMILKILIAD PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x3602C60", Offset = "0x3601A60", VA = "0x183602C60")]
		public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ, ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x3602BF0", Offset = "0x36019F0", VA = "0x183602BF0")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private OPIMGAOPDNP IEBLHHMEHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private KNJHNLNIBIP LJDEGJIIHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private EntityQuery BCHHFMJGEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private ProfilerMarker MPJNLAAFNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private EntityQuery NDAGCLCGEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private ProfilerMarker LEGMFMODAFF;

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2837580", Offset = "0x2836380", VA = "0x182837580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x28370C0", Offset = "0x2835EC0", VA = "0x1828370C0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x2837740", Offset = "0x2836540", VA = "0x182837740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x28375E0", Offset = "0x28363E0", VA = "0x1828375E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public LIICBMDDEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x28372F0", Offset = "0x28360F0", VA = "0x1828372F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2837120", Offset = "0x2835F20", VA = "0x182837120")]
	public static EntityQuery OCKMBBOCGBB(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x2836F60", Offset = "0x2835D60", VA = "0x182836F60")]
	public static EntityQuery ABBNPOOIDCD(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		private struct EODFPBLFDAC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public OCGCGAIFBCP JKOOEKEEBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeHashMap<Entity, NOAPHGCLLPE> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x3602150", Offset = "0x3600F50", VA = "0x183602150")]
			public EODFPBLFDAC(int CHMDLBBFMNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x36020D0", Offset = "0x3600ED0", VA = "0x1836020D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		[BurstCompile]
		private struct GMLIDOBPOBJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> MEMMPBDNNLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF;

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x3603620", Offset = "0x3602420", VA = "0x183603620", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[BurstCompile]
		private struct CDDINBANFKP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF;

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x35FF700", Offset = "0x35FE500", VA = "0x1835FF700", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private KNJHNLNIBIP LJDEGJIIHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private EntityQuery FIDKDOPGOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery MCPGOBGPBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery POLHGANDILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery KINEGBHPHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private EntityQuery OEEJLMIMECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private JobHandle HIHNNPBLPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private EODFPBLFDAC ADGNOGNDDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private EODFPBLFDAC OMACGAGIGDP;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x286AED0", Offset = "0x2869CD0", VA = "0x18286AED0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x286B0B0", Offset = "0x2869EB0", VA = "0x18286B0B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x286ABA0", Offset = "0x28699A0", VA = "0x18286ABA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x286B370", Offset = "0x286A170", VA = "0x18286B370", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x286AA50", Offset = "0x2869850", VA = "0x18286AA50")]
		private void DHPGCLJNPJK(EntityQuery JFPFDEFJDBP, out (global::OHBAMBCHLEK<JLKFGGHMAGN> handles, global::OHBAMBCHLEK<NMNILGJABIA> bounds) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x286A7F0", Offset = "0x28695F0", VA = "0x18286A7F0")]
		private void DHKMNNMGPIP((global::OHBAMBCHLEK<JLKFGGHMAGN> handles, global::OHBAMBCHLEK<NMNILGJABIA> bounds) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x286ABA0", Offset = "0x28699A0", VA = "0x18286ABA0")]
		private void DLKGHKOHLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x286AF30", Offset = "0x2869D30", VA = "0x18286AF30")]
		private void LPGHLJOJNNO(EntityQuery JFPFDEFJDBP, out (global::OHBAMBCHLEK<Entity> entities, global::OHBAMBCHLEK<JLKFGGHMAGN> handles) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x286ABE0", Offset = "0x28699E0", VA = "0x18286ABE0")]
		private void FKCBBLHJAGG((global::OHBAMBCHLEK<Entity> entities, global::OHBAMBCHLEK<JLKFGGHMAGN> handles) JANIFNADDOP, EODFPBLFDAC MLBCCNCBNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x286A690", Offset = "0x2869490", VA = "0x18286A690")]
		private JobHandle AJCBDGEMENL(EODFPBLFDAC MLBCCNCBNHG, ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ, ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF, ComponentDataFromEntity<WorldDeformableScaleData> MEMMPBDNNLF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x286BB10", Offset = "0x286A910", VA = "0x18286BB10")]
		private JobHandle PNAGBJKIAEM(EODFPBLFDAC MLBCCNCBNHG, ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ, ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct ANELNBAODPG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics)]
	public class SplineLocalBoundsSystem : IKEIJDHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[BurstCompile]
		private struct ALNJHHOHGKN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			[ReadOnly]
			public NativeArray<Entity> BPAIPDBBMKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[ReadOnly]
			public ComponentDataFromEntity<NMNILGJABIA> GLPJJILGBMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			[WriteOnly]
			public NativeHashMap<Entity, NOAPHGCLLPE>.ParallelWriter EGCEADMKGDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter NGHNAKHFJLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter CCMPNPBLPBI;

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x35FF210", Offset = "0x35FE010", VA = "0x1835FF210", Slot = "4")]
			public void Execute(int AIPHGHFENPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[BurstCompile]
		private struct HIPBCIEBIFN : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			[ReadOnly]
			public NativeArray<Entity> DNFMACODOBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> DFBLOLNPNMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<NMNILGJABIA> OLNDMCHODOK;

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x3604130", Offset = "0x3602F30", VA = "0x183604130", Slot = "4")]
			public void Execute(int AIPHGHFENPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private EntityQuery NBKMKNDMGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private EntityQuery NFEBOEPJBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery OMPBDFCDNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private EntityQuery MAHGBGIGFIP;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x2876AC0", Offset = "0x28758C0", VA = "0x182876AC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2876CD0", Offset = "0x2875AD0", VA = "0x182876CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x28761F0", Offset = "0x2874FF0", VA = "0x1828761F0")]
		private JobHandle IFMKCBJGODA(global::OHBAMBCHLEK<Entity> DEJEDNNJILK, int GKPOMAIMOAK, JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2876040", Offset = "0x2874E40", VA = "0x182876040")]
		private JobHandle IFMKCBJGODA(NativeArray<Entity> CBMKCDPBEFL, int GKPOMAIMOAK, [Optional] JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2875FC0", Offset = "0x2874DC0", VA = "0x182875FC0")]
		private global::OHBAMBCHLEK<Entity> IABHOJFHKFJ(EntityQuery JFPFDEFJDBP)
		{
			return default(global::OHBAMBCHLEK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x28765F0", Offset = "0x28753F0", VA = "0x1828765F0")]
		private (global::AFBJNMJHLIH<Entity>, global::AFBJNMJHLIH<Entity>) KGNGLHHBOIF(global::OHBAMBCHLEK<Entity> IHHKNLGEIBC)
		{
			return default((global::AFBJNMJHLIH<Entity>, global::AFBJNMJHLIH<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2876A40", Offset = "0x2875840", VA = "0x182876A40")]
		private void MDFBNLLMBAL(out NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x2875F30", Offset = "0x2874D30", VA = "0x182875F30")]
		private void GADDBAKKCIJ(NativeList<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x2875E60", Offset = "0x2874C60", VA = "0x182875E60")]
		private void GADDBAKKCIJ(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x2877250", Offset = "0x2876050", VA = "0x182877250")]
		private void PADOHENKGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private static void BDDEIBJJOOM(int JDBHHBAPLEC, int EBEKBFLPPDI, int JLFOKLBEGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x28762D0", Offset = "0x28750D0", VA = "0x1828762D0")]
		private static NMNILGJABIA KGMOBBJGBFA(NativeArray<Entity> BJFBKLCPENG, ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI)
		{
			return default(NMNILGJABIA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal struct KFACGEHEJME : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[IFBLAMOEMKH(CMGBDLINHMB.Lifecycle)]
	public class DestroyLocalObjects : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private EntityQuery LBFBIMKMJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x2C294E0", Offset = "0x2C282E0", VA = "0x182C294E0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x2C3ACF0", Offset = "0x2C39AF0", VA = "0x182C3ACF0")]
		public bool LGKONKIAJFF(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2C3ADA0", Offset = "0x2C39BA0", VA = "0x182C3ADA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AE40", Offset = "0x2C39C40", VA = "0x182C3AE40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AE40", Offset = "0x2C39C40", VA = "0x182C3AE40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AE30", Offset = "0x2C39C30", VA = "0x182C3AE30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2C3ABE0", Offset = "0x2C399E0", VA = "0x182C3ABE0")]
		private void EGJEFCCBJMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private GENGCCLJKNG ODPIFDMCMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private GNLAPDIIDJD PBHPBFOABAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private ENNNNIELFIE PBHDPEJBGCP;

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		protected abstract ComputePropertyDifferences PLIOAOLEJFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E8A0", Offset = "0x2C3D6A0", VA = "0x182C3E8A0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x2C3E980", Offset = "0x2C3D780", VA = "0x182C3E980", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private void NDIGJPFLJCC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM, EGNDHFFDDFH KOPJKHIOCNP, OJINANPDCIH NLBBBEBMOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[IFBLAMOEMKH(CMGBDLINHMB.Callbacks)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public abstract class PropertyEventCallbacks : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private PropertyEventCallbacksService AMENCMGDIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private ENNNNIELFIE PBHDPEJBGCP;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2870D90", Offset = "0x286FB90", VA = "0x182870D90", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2870E10", Offset = "0x286FC10", VA = "0x182870E10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[IFBLAMOEMKH(CMGBDLINHMB.NetworkSend)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public abstract class TransmitNetworkDataSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private ELFIPEDOAPI ABCMOBMIIII;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x287C890", Offset = "0x287B690", VA = "0x18287C890", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x287C8E0", Offset = "0x287B6E0", VA = "0x18287C8E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class AssignPlayerIdsSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private EntityQuery DGODDAHBCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private EntityQuery JBEOGAIFCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[ReadOnly]
		private EntityQuery EBIFBEJLAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private EntityQuery MPBFJGPNEKF;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public Entity EKAMJAPOMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x2C2AE00", Offset = "0x2C29C00", VA = "0x182C2AE00")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2C2B4B0", Offset = "0x2C2A2B0", VA = "0x182C2B4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2C2AE40", Offset = "0x2C29C40", VA = "0x182C2AE40", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B620", Offset = "0x2C2A420", VA = "0x182C2B620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B730", Offset = "0x2C2A530", VA = "0x182C2B730", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B3B0", Offset = "0x2C2A1B0", VA = "0x182C2B3B0")]
		private void LJCCOJCHEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2C2ABB0", Offset = "0x2C299B0", VA = "0x182C2ABB0")]
		private void BMCHDCHCPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2C2AE90", Offset = "0x2C29C90", VA = "0x182C2AE90")]
		private void ILJGDNMJKHN(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2C2ACF0", Offset = "0x2C29AF0", VA = "0x182C2ACF0")]
		private void DMHGNPDJMNM(NativeArray<Entity> FBMJMNCDHDM, int DLAMHLJBGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B1E0", Offset = "0x2C29FE0", VA = "0x182C2B1E0")]
		private void LFHDCJBBCEF(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B510", Offset = "0x2C2A310", VA = "0x182C2B510", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal static class HLAPFDOEBDD
{
	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x282ADF0", Offset = "0x2829BF0", VA = "0x18282ADF0")]
	public static bool DKPJLCCLCBP(this SystemBase CHJMLFMLCJF, out Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x282AE80", Offset = "0x2829C80", VA = "0x18282AE80")]
	public static Entity LLGPMPGENGG(this SystemBase CHJMLFMLCJF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x282AED0", Offset = "0x2829CD0", VA = "0x18282AED0")]
	public static bool OMPMAIGNFHI(this SystemBase CHJMLFMLCJF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class ClearScopeOnLocalPlayerChangeSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private EntityQuery LLPPGDLKPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private BFIAFBHOKLF PDKGNHLLFLM;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C30BF0", Offset = "0x2C2F9F0", VA = "0x182C30BF0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C30C40", Offset = "0x2C2FA40", VA = "0x182C30C40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C30D00", Offset = "0x2C2FB00", VA = "0x182C30D00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class LocalPlayerScopeSystem : ScopeSystemBase<BLHDIOPAIBE>, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private const string HPBFOFBCDNL = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EIANDBIEFDL EFHJAGIMGON;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public PMMHBDBEGAM EPGKNIGBDIO
		{
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x2838540", Offset = "0x2837340", VA = "0x182838540")]
			get
			{
				return default(PMMHBDBEGAM);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x2837EE0", Offset = "0x2836CE0", VA = "0x182837EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private Entity LMAFPGJBCOD
		{
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x2837A50", Offset = "0x2836850", VA = "0x182837A50")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x2837910", Offset = "0x2836710", VA = "0x182837910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public PMMHBDBEGAM GFMJMLPAANG
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x28384B0", Offset = "0x28372B0", VA = "0x1828384B0")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private Entity JFIFMEDJPFH
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x2838000", Offset = "0x2836E00", VA = "0x182838000")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		private Entity EKAMJAPOMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x282AE80", Offset = "0x2829C80", VA = "0x18282AE80")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public bool OMPMAIGNFHI
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x282AED0", Offset = "0x2829CD0", VA = "0x18282AED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x214FA00", Offset = "0x214E800", VA = "0x18214FA00")]
		private bool KNMEGLCAMII<T>(out T IGJPNMBCJPK) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2837E70", Offset = "0x2836C70", VA = "0x182837E70", Slot = "15")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2837D20", Offset = "0x2836B20", VA = "0x182837D20", Slot = "14")]
		protected override void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2838390", Offset = "0x2837190", VA = "0x182838390")]
		private void OADCKFPFFGH(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2838060", Offset = "0x2836E60", VA = "0x182838060")]
		private void NFALKLLLDCK(Entity GEEFHDFLBEH, Entity EFBHGFLNMOL, Entity NMGCEMAHJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2837B90", Offset = "0x2836990", VA = "0x182837B90")]
		public bool EICFBDDCOOP(PMMHBDBEGAM JPPNMPGJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2837AB0", Offset = "0x28368B0", VA = "0x182837AB0")]
		public static bool EICFBDDCOOP(PMMHBDBEGAM LGMOGODIBPP, PMMHBDBEGAM JPPNMPGJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2837A20", Offset = "0x2836820", VA = "0x182837A20")]
		private static bool DAAPIBBOKEK(PMMHBDBEGAM LGMOGODIBPP, PMMHBDBEGAM KEHNEFAKJHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2838620", Offset = "0x2837420", VA = "0x182838620")]
		protected LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2838470", Offset = "0x2837270", VA = "0x182838470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class CreateContainerPivotOnEnterScopeSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private EntityQuery CMMFELFHKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private EntityQuery CPOPPALLOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C37A80", Offset = "0x2C36880", VA = "0x182C37A80", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C37C20", Offset = "0x2C36A20", VA = "0x182C37C20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C37D10", Offset = "0x2C36B10", VA = "0x182C37D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x28811B0", Offset = "0x287FFB0", VA = "0x1828811B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C37680", Offset = "0x2C36480", VA = "0x182C37680")]
		private void AGAHNEENAIJ(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C37AD0", Offset = "0x2C368D0", VA = "0x182C37AD0")]
		private NativeArray<Entity> LNJBOOCCPIP(int KOHJDBBJEKM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C37570", Offset = "0x2C36370", VA = "0x182C37570")]
		private void AFILCMPMJKA(NativeArray<Entity> GAHODJODMJJ, NativeArray<Entity> EINOFMLPJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class HideRemotePivotsNotInScope : IKEIJDHBAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private EntityQuery DAIJJFFLMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private EntityQuery FDHGHMAJGBH;

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x282BCF0", Offset = "0x282AAF0", VA = "0x18282BCF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x282BDE0", Offset = "0x282ABE0", VA = "0x18282BDE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal static class AECBFKJNNGA
{
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public const string AACNNCACGNO = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2022280", Offset = "0x2021080", VA = "0x182022280")]
	public static NativeArray<T> HBPLCHGJNEG<T>(NativeArray<Entity> FBMJMNCDHDM, EntityManager LKEHNCAJHHL) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C26460", Offset = "0x2C25260", VA = "0x182C26460")]
	public static void LAEFBOJIAPA(EntityQuery JFPFDEFJDBP, EntityManager LKEHNCAJHHL, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C265A0", Offset = "0x2C253A0", VA = "0x182C265A0")]
	public static void NEMIIJCJFIP(NativeArray<Entity> GAHODJODMJJ, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C26330", Offset = "0x2C25130", VA = "0x182C26330")]
	public static void CJHLMFNABNI(NativeArray<Entity> GAHODJODMJJ, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class UpdateContainerPivotOnExitScopeSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private EntityQuery KOGECCAAMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private EntityQuery CPOPPALLOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TransformService JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2881020", Offset = "0x287FE20", VA = "0x182881020", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x28810B0", Offset = "0x287FEB0", VA = "0x1828810B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x28811F0", Offset = "0x287FFF0", VA = "0x1828811F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x28811B0", Offset = "0x287FFB0", VA = "0x1828811B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x28814C0", Offset = "0x28802C0", VA = "0x1828814C0")]
		private void PECPIDEHGKO(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2880A80", Offset = "0x287F880", VA = "0x182880A80")]
		private void EFKFBMCBMDD(NativeArray<Entity> GAHODJODMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2881210", Offset = "0x2880010", VA = "0x182881210")]
		private void PBOECKKHLJF(NativeArray<Entity> EINOFMLPJHG, NativeArray<LocalPoseData> JGADCCMGEIF, NativeArray<LocalPoseData> HFODADOKCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2880B90", Offset = "0x287F990", VA = "0x182880B90")]
		private void FDKBODHDOJB(NativeArray<LocalPoseData> HFODADOKCEH, NativeArray<Entity> EINOFMLPJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal class PostGameplayOnScopeChange : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private EntityQuery LLPPGDLKPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private EntityQuery PPOBNDMKLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x286C690", Offset = "0x286B490", VA = "0x18286C690", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x286C780", Offset = "0x286B580", VA = "0x18286C780", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x286C8D0", Offset = "0x286B6D0", VA = "0x18286C8D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x286C700", Offset = "0x286B500", VA = "0x18286C700")]
		private void HIHNOHBHBBE(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	internal abstract class PreventDisembodiedScopesSystem : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private EntityQuery IDJABCMMDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private EntityHierarchyParents OBEJKCLINIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private BFIAFBHOKLF PDKGNHLLFLM;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x286DD70", Offset = "0x286CB70", VA = "0x18286DD70", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x286DF90", Offset = "0x286CD90", VA = "0x18286DF90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x286E030", Offset = "0x286CE30", VA = "0x18286E030", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x286DE00", Offset = "0x286CC00", VA = "0x18286DE00")]
		private void MNFFEEFIGII(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class RemotePlayerScopeSystem : ScopeSystemBase<HEMEHLBJFKC>
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2872300", Offset = "0x2871100", VA = "0x182872300", Slot = "14")]
		protected override void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2872420", Offset = "0x2871220", VA = "0x182872420")]
		protected RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x28723E0", Offset = "0x28711E0", VA = "0x1828723E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[IFBLAMOEMKH(CMGBDLINHMB.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : IKEIJDHBAML where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private EntityQuery EGICKNMHNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private EntityQuery AHNEKGJOFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private EntityQuery JOCMBLHEFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private EntityQuery JMBBDNFBMCE;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x312CCC0", Offset = "0x312BAC0", VA = "0x18312CCC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x312CEC0", Offset = "0x312BCC0", VA = "0x18312CEC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x312CE90", Offset = "0x312BC90", VA = "0x18312CE90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x312BAD0", Offset = "0x312A8D0", VA = "0x18312BAD0")]
		private void HCGMHFGHPIN(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x312C310", Offset = "0x312B110", VA = "0x18312C310")]
		private void KDNOANLPMGP(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x312B690", Offset = "0x312A490", VA = "0x18312B690")]
		private void GOHGPJKLGME(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ);

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x2F5E880", Offset = "0x2F5D680", VA = "0x182F5E880")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x17BD330", Offset = "0x17BC130", VA = "0x1817BD330", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class DHBELNJEOID
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C37E00", Offset = "0x2C36C00", VA = "0x182C37E00")]
	public static EntityQuery NJIBEHKJADN(SystemBase BFAGCHAFHGP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public abstract class COFDLBBLFME : IKEIJDHBAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private List<(EntityQuery, ComponentType)> MAPPBNAKEFG;

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C307A0", Offset = "0x2C2F5A0", VA = "0x182C307A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C309A0", Offset = "0x2C2F7A0", VA = "0x182C309A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C30AF0", Offset = "0x2C2F8F0", VA = "0x182C30AF0")]
	protected COFDLBBLFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct AOEOIHKBMAM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public int KIJOKCLKDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public int FOEMNAHJKFC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C28D60", Offset = "0x2C27B60", VA = "0x182C28D60")]
	public static Entity PAAEKNCKHBI(AOEOIHKBMAM JANIFNADDOP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C28D60", Offset = "0x2C27B60", VA = "0x182C28D60")]
	public static AOEOIHKBMAM PAAEKNCKHBI(Entity GEEFHDFLBEH)
	{
		return default(AOEOIHKBMAM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct PKIJMDIMCFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public struct KGFPMIPOKMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public readonly ComponentType MOBCJNJMMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public readonly NativeList<int> LGLGGCHFNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public readonly NativeList<int> BIFPHOBHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public readonly NativeArray<Entity> FBMJMNCDHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public readonly NativeArray<Entity> IBIIGMBFOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public readonly NativeArray<byte> HFLCHCKFKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public readonly NativeArray<byte> MGGGHPDHPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public readonly int KCCDKALEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public readonly int NADGDGHIKPA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool EPOFMKLFDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x28315F0", Offset = "0x28303F0", VA = "0x1828315F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x2831840", Offset = "0x2830640", VA = "0x182831840")]
	public KGFPMIPOKMG(ComponentType MOBCJNJMMEJ, NativeList<int> LGLGGCHFNDI, NativeList<int> BIFPHOBHALN, NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> IBIIGMBFOIM, NativeArray<byte> HFLCHCKFKDH, NativeArray<byte> MGGGHPDHPFB, int KCCDKALEDML, int NADGDGHIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2831710", Offset = "0x2830510", VA = "0x182831710")]
	private MJADMLMEADH PNJDJJFNFLF(NativeArray<byte> DEJEDNNJILK, int AIPHGHFENPJ)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	private T PNJDJJFNFLF<T>(NativeArray<byte> DEJEDNNJILK, int AIPHGHFENPJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x2831670", Offset = "0x2830470", VA = "0x182831670")]
	public MJADMLMEADH GKPDOKJPEED(int AIPHGHFENPJ)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	public T GKPDOKJPEED<T>(int AIPHGHFENPJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x28316C0", Offset = "0x28304C0", VA = "0x1828316C0")]
	public MJADMLMEADH OEIHOJFDKCP(int AIPHGHFENPJ)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	public T OEIHOJFDKCP<T>(int AIPHGHFENPJ) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x2831510", Offset = "0x2830310", VA = "0x182831510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public struct OOPIHDDHHBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public readonly EntityQuery JFPFDEFJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public readonly NativeArray<BCDDMNDBEPL> GMKKBMEMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public readonly ComponentType MOBCJNJMMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public readonly int KCCDKALEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public readonly int NADGDGHIKPA;

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x283D280", Offset = "0x283C080", VA = "0x18283D280")]
	public OOPIHDDHHBC(ComponentType MOBCJNJMMEJ, int KCCDKALEDML, int NADGDGHIKPA, EntityQuery JFPFDEFJDBP, NativeArray<BCDDMNDBEPL> GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x283D230", Offset = "0x283C030", VA = "0x18283D230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct LPFMODCHECN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public int AIPHGHFENPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public int AKFBHCBICCK;

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x676E50", VA = "0x180678050")]
	public LPFMODCHECN(int AIPHGHFENPJ, int AKFBHCBICCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct BCDDMNDBEPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly int LBACAALGKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly int MNKEEJPGFOP;

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x676E50", VA = "0x180678050")]
	public BCDDMNDBEPL(int LBACAALGKLG, int MNKEEJPGFOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct OJINANPDCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private readonly JLCDNMLCNEN FCDKMJOKGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly int KCCDKALEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private unsafe readonly byte* HFLCHCKFKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private unsafe readonly byte* MGGGHPDHPFB;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x283D030", Offset = "0x283BE30", VA = "0x18283D030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public JLCDNMLCNEN MELPOBPKFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707C20", VA = "0x180708E20")]
		get
		{
			return default(JLCDNMLCNEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x283CF40", Offset = "0x283BD40", VA = "0x18283CF40")]
	public MJADMLMEADH HDCMLBDCJJA(Type NKICFHCCMMH)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x283CE50", Offset = "0x283BC50", VA = "0x18283CE50")]
	public MJADMLMEADH GFNEMCGEDBG(Type NKICFHCCMMH)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2C15350", Offset = "0x2C14150", VA = "0x182C15350")]
	public T HDCMLBDCJJA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2C15330", Offset = "0x2C14130", VA = "0x182C15330")]
	public T GFNEMCGEDBG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x283D040", Offset = "0x283BE40", VA = "0x18283D040")]
	public unsafe OJINANPDCIH(JLCDNMLCNEN FCDKMJOKGIE, int MNKEEJPGFOP, byte* HFLCHCKFKDH, byte* MGGGHPDHPFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public static class ABKHAGPBKLD
{
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] EJEHGEPFBHN;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[DefaultMember("Item")]
internal class KHMLGNFANIM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly Dictionary<ComponentType, OOPIHDDHHBC> OGMAGPEPNJD;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OOPIHDDHHBC MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2833BC0", Offset = "0x28329C0", VA = "0x182833BC0")]
		get
		{
			return default(OOPIHDDHHBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2833520", Offset = "0x2832320", VA = "0x182833520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x2833C50", Offset = "0x2832A50", VA = "0x182833C50")]
	public KHMLGNFANIM(EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2833240", Offset = "0x2832040", VA = "0x182833240")]
	public Dictionary<ComponentType, OOPIHDDHHBC>.Enumerator BALJJOIEHDJ()
	{
		return default(Dictionary<ComponentType, OOPIHDDHHBC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x28332D0", Offset = "0x28320D0", VA = "0x1828332D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x2833570", Offset = "0x2832370", VA = "0x182833570")]
	private void HPONDOAJJHH(IEnumerable<NOBHGMEMAKH> OIAKNBEOLFI, EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x2833470", Offset = "0x2832270", VA = "0x182833470")]
	private static int ENPKMHCCDBP(NOBHGMEMAKH NKEPAMLDENG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2833970", Offset = "0x2832770", VA = "0x182833970")]
	private static NativeArray<BCDDMNDBEPL> JMPOIHCJABA(NOBHGMEMAKH NKEPAMLDENG, Allocator JEOILJEOOOI = Allocator.Persistent)
	{
		return default(NativeArray<BCDDMNDBEPL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal interface ENNNNIELFIE
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	World EKGNNGCIOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BNOGEFCJAHA(out NativeArray<int> GIFGJKHKEEO, Allocator JEOILJEOOOI);

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNONBKCFIBM(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM, out OOPIHDDHHBC OHDDMIOPOFC);

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CNONBKCFIBM(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM);

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGFPMIPOKMG LLEEHJNOAAG(ComponentType MOBCJNJMMEJ);

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDJKLEJHIMN PNHJFEJPCLI();

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBLEDCNCJNE(JobHandle AADBABLKHJM);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal interface OOGJNFIJHKM
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	World EKGNNGCIOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	KHMLGNFANIM MIENOIKPNME
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	FLHBGDILJIB FADKFKBHKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	NativeMultiHashMap<Entity, OJINANPDCIH> PHCMCBBDLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	JobHandle PADNOHKIAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ENJHCNHMIBP();

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IIOELKEIHEG();

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBLEDHIOMOJ(ComponentType MOBCJNJMMEJ, in KGFPMIPOKMG CKIPEJKPEDD);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MDJGBAHBHDF(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA);
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal struct IDJKLEJHIMN
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public struct IKALGBFDLKF : IEnumerator<OJINANPDCIH>, IEnumerator, IDisposable, IEnumerable<OJINANPDCIH>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private readonly NativeMultiHashMap<Entity, OJINANPDCIH> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private readonly Entity GEEFHDFLBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private NativeMultiHashMapIterator<Entity> LDCEDIKEFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private OJINANPDCIH MGGGHPDHPFB;

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public OJINANPDCIH MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xBCDFE0", Offset = "0xBCCDE0", VA = "0x180BCDFE0", Slot = "4")]
			get
			{
				return default(OJINANPDCIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x3605480", Offset = "0x3604280", VA = "0x183605480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x36054D0", Offset = "0x36042D0", VA = "0x1836054D0")]
		internal IKALGBFDLKF(NativeMultiHashMap<Entity, OJINANPDCIH> AHGHAANFJKO, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x3605270", Offset = "0x3604070", VA = "0x183605270", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x3605240", Offset = "0x3604040", VA = "0x183605240")]
		public IKALGBFDLKF BALJJOIEHDJ()
		{
			return default(IKALGBFDLKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x3605340", Offset = "0x3604140", VA = "0x183605340", Slot = "9")]
		private IEnumerator<OJINANPDCIH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x36053E0", Offset = "0x36041E0", VA = "0x1836053E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly OOGJNFIJHKM PBHDPEJBGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly JobHandle LDGJAMKHEKK;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public int NNCFHMJODME
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x282C330", Offset = "0x282B130", VA = "0x18282C330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x282C250", Offset = "0x282B050", VA = "0x18282C250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x1E76DC0", Offset = "0x1E75BC0", VA = "0x181E76DC0")]
	public IDJKLEJHIMN(OOGJNFIJHKM PBHDPEJBGCP, JobHandle LDGJAMKHEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x282BFA0", Offset = "0x282ADA0", VA = "0x18282BFA0")]
	public bool LFPECKBHFGD(Allocator JEOILJEOOOI, out NativeKeyValueArrays<Entity, OJINANPDCIH> BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x282C0E0", Offset = "0x282AEE0", VA = "0x18282C0E0")]
	public bool OHNDCDIKBDP(Allocator JEOILJEOOOI, out (NativeArray<Entity> entities, int uniqueCount) BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x282BE80", Offset = "0x282AC80", VA = "0x18282BE80")]
	public IKALGBFDLKF JADCFAPLAGP(Entity GEEFHDFLBEH)
	{
		return default(IKALGBFDLKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[DefaultMember("Item")]
internal class FLHBGDILJIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly List<OOPIHDDHHBC> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public OOPIHDDHHBC MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2826D90", Offset = "0x2825B90", VA = "0x182826D90")]
		get
		{
			return default(OOPIHDDHHBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2826A40", Offset = "0x2825840", VA = "0x182826A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x2826E20", Offset = "0x2825C20", VA = "0x182826E20")]
	public FLHBGDILJIB(KHMLGNFANIM OGMAGPEPNJD, EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2826850", Offset = "0x2825650", VA = "0x182826850")]
	public List<OOPIHDDHHBC>.Enumerator BALJJOIEHDJ()
	{
		return default(List<OOPIHDDHHBC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x28268D0", Offset = "0x28256D0", VA = "0x1828268D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x2826A80", Offset = "0x2825880", VA = "0x182826A80")]
	private void HPONDOAJJHH(KHMLGNFANIM OGMAGPEPNJD, EntityManager LKEHNCAJHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class KHFNLIHOAGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private readonly global::IGNGPODGPHC<NOBHGMEMAKH> KCINBNOPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly World IBLOHKEKNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private NativeHashMap<int, Entity> CMAOMHCKFPP;

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2833150", Offset = "0x2831F50", VA = "0x182833150")]
	public KHFNLIHOAGK(ObjectInstantiationService JOIDICOJLFD, EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2831E00", Offset = "0x2830C00", VA = "0x182831E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x28330F0", Offset = "0x2831EF0", VA = "0x1828330F0")]
	public bool PAOEPCHIOGM(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x28324E0", Offset = "0x28312E0", VA = "0x1828324E0")]
	private void HNFMJBMJBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2831FB0", Offset = "0x2830DB0", VA = "0x182831FB0")]
	private EntityArchetype GKNJFAJHABG(EntityArchetype OOHCFEPBGBM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2832B80", Offset = "0x2831980", VA = "0x182832B80")]
	public static void NCGALFHGLGH(EntityManager BHDOHAJMONK, EntityManager LGGPCBMPJIM, NativeArray<Entity> ILCJJBCCAGM, NativeArray<EntityArchetype> BKODCBPDBIK, [Optional] NativeArray<Entity> ONMAHEPEOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x28318A0", Offset = "0x28306A0", VA = "0x1828318A0")]
	[Conditional("DEBUG_BUILD")]
	private static void ACPJOHFDGIN(NativeArray<EntityArchetype> PCOKMHJEFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x2831A10", Offset = "0x2830810", VA = "0x182831A10")]
	private static string DJJBAGBAKMA(EntityArchetype CEINJAHAPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x2832FB0", Offset = "0x2831DB0", VA = "0x182832FB0")]
	[CompilerGenerated]
	internal static void NKMGFOJCFAM(ref Span<ComponentType> KNAJFGDPKPI, ComponentType IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2831C50", Offset = "0x2830A50", VA = "0x182831C50")]
	[CompilerGenerated]
	internal static void DMGAMDDOCDE(Span<ComponentType> DEJEDNNJILK, ref Span<ComponentType> KNAJFGDPKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x2831ED0", Offset = "0x2830CD0", VA = "0x182831ED0")]
	[CompilerGenerated]
	internal static void EPDINGLADHB(Span<ComponentType> DEJEDNNJILK, ref Span<ComponentType> KNAJFGDPKPI, ComponentType EGABNOLNFHL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : IKEIJDHBAML, FDFFINEAOHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private struct OCDBFAEFGHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public NANEHBACIAB dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public OCDBFAEFGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct BGCOJNMGLJI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeArray<byte> MGGGHPDHPFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			[ReadOnly]
			public NativeList<int> LGLGGCHFNDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			[ReadOnly]
			public NativeArray<Entity> IBIIGMBFOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public int KCCDKALEDML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public NANEHBACIAB AMMLAKHCLPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public ComponentType MOBCJNJMMEJ;

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x35FF310", Offset = "0x35FE110", VA = "0x1835FF310")]
			internal void POIJCEOICMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x35FF4F0", Offset = "0x35FE2F0", VA = "0x1835FF4F0", Slot = "5")]
			public void ReadFromDisplayClass(ref OCDBFAEFGHA CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x35FF2E0", Offset = "0x35FE0E0", VA = "0x1835FF2E0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x35FF2F0", Offset = "0x35FE0F0", VA = "0x1835FF2F0")]
			public void LONPEHHIFCO(ApplyPropertyDifferences OJEDNGBIKHJ, ref OCDBFAEFGHA CBENCAHNLAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private ENNNNIELFIE PBHDPEJBGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private JobHandle FIOOOJDOILM;

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2C2A870", Offset = "0x2C29670", VA = "0x182C2A870")]
		public void NBKICENBLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2C2A4D0", Offset = "0x2C292D0", VA = "0x182C2A4D0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2C2A880", Offset = "0x2C29680", VA = "0x182C2A880", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2C2A530", Offset = "0x2C29330", VA = "0x182C2A530")]
		private bool LEJMLOLKJEH(JobHandle GINKINFGNEP, int DBMJEOKPFJK, out JobHandle HGFNJFOEEBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	public abstract class ComputePropertyDifferences : IKEIJDHBAML, FDFFINEAOHD, CDAFEBOKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		[BurstCompile]
		internal struct JFBEBAGCFEB : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			[ReadOnly]
			public NativeArray<byte> EJDBONNMMDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			[ReadOnly]
			public NativeArray<byte> NCIKCPKLKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			[ReadOnly]
			public NativeArray<BCDDMNDBEPL> LBNDLOLGMOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			[WriteOnly]
			public NativeList<LPFMODCHECN>.ParallelWriter EKMDPNPLADF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public int GEPNPGHOBIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public int GLIHDHAEEAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x3605FB0", Offset = "0x3604DB0", VA = "0x183605FB0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x36060F0", Offset = "0x3604EF0", VA = "0x1836060F0")]
			private unsafe int MCFODCBHGPN(byte* AELLFIOGOHK, byte* AFOPPLDIMJL)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000106")]
		[BurstCompile]
		internal struct ILMKIIPAAMK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			[WriteOnly]
			public NativeList<int> LGLGGCHFNDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			[WriteOnly]
			public NativeList<int> AJIAONFFBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			public NativeList<LPFMODCHECN> NKIDNGPMNIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x36054F0", Offset = "0x36042F0", VA = "0x1836054F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[BurstCompile]
		internal struct FNIFCNLMEHC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[WriteOnly]
			public NativeArray<byte> BOCOGMLMHBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			[ReadOnly]
			public NANEHBACIAB KLJAIKAEOLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public int KCCDKALEDML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x3602A90", Offset = "0x3601890", VA = "0x183602A90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		internal struct FEFJBCDDGMN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, OJINANPDCIH> ABCKJKCJCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			[ReadOnly]
			public NativeArray<byte> HFLCHCKFKDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			[ReadOnly]
			public NativeArray<byte> MGGGHPDHPFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			[ReadOnly]
			public NativeArray<BCDDMNDBEPL> FDGKFNNIPCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			[ReadOnly]
			public NativeList<int> BIFPHOBHALN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			[ReadOnly]
			public NativeList<int> LGLGGCHFNDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public int IDGLNJOODCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public int NADGDGHIKPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public ProfilerMarker LKNPEOPBCGM;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x36021F0", Offset = "0x3600FF0", VA = "0x1836021F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private static readonly ProfilerMarker HFFLPBGKLCB;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private static readonly ProfilerMarker LHCPPGHLFHL;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private static readonly ProfilerMarker GDFHFKNOPJG;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private static readonly ProfilerMarker BDCKOLMOJAM;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private static readonly ProfilerMarker LNJKEENAKOC;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static readonly ProfilerMarker MHAPLOBPLDG;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private static readonly ProfilerMarker MGMAGANFCLL;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private static readonly ProfilerMarker KGBMPNKIBFB;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private static readonly ProfilerMarker EJAHOKMFGKK;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private static readonly ProfilerMarker ICEKLAOGBOF;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private static readonly ProfilerMarker LCGCFHENCCK;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static readonly ProfilerMarker LLPDGBKLMIM;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private static readonly ProfilerMarker HBJCPEAJCBO;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private static readonly ProfilerMarker KCDINPDGCHE;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private static readonly ProfilerMarker LNKJBOMHCHC;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private static readonly ProfilerMarker HGFOBFEGEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private OOGJNFIJHKM PBHDPEJBGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private ApplyPropertyDifferences IFIIKHCNKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private EntityQuery PHLPAFIELFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private EntityQuery AJFALAKCPBE;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		protected abstract ApplyPropertyDifferences ENAAOEAAPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		internal World EKGNNGCIOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2C32500", Offset = "0x2C31300", VA = "0x182C32500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2C32550", Offset = "0x2C31350", VA = "0x182C32550")]
		internal OOPIHDDHHBC JPFLOFLDECE(ComponentType MOBCJNJMMEJ)
		{
			return default(OOPIHDDHHBC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2C322F0", Offset = "0x2C310F0", VA = "0x182C322F0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "15")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2C33A00", Offset = "0x2C32800", VA = "0x182C33A00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2C33B80", Offset = "0x2C32980", VA = "0x182C33B80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2C33B30", Offset = "0x2C32930", VA = "0x182C33B30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2C32050", Offset = "0x2C30E50", VA = "0x182C32050")]
		private void HBHPPBAOFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2C32440", Offset = "0x2C31240", VA = "0x182C32440")]
		private void INCMDNPILLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2C319E0", Offset = "0x2C307E0", VA = "0x182C319E0")]
		internal void GMIGFAPKFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2C32BD0", Offset = "0x2C319D0", VA = "0x182C32BD0")]
		private void NFCNLMCJHOB(NativeArray<Entity> ILCJJBCCAGM, NativeArray<RRObjectPrefabData> JKOPBJFEFEF, ref NativeArray<Entity> KDHNBJIDPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2C336D0", Offset = "0x2C324D0", VA = "0x182C336D0")]
		internal void OKKCHMJBCGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2C32F90", Offset = "0x2C31D90", VA = "0x182C32F90")]
		internal void OBCFLPAOMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2C325F0", Offset = "0x2C313F0", VA = "0x182C325F0")]
		private void KABEHEPCGAC(OOPIHDDHHBC OHDDMIOPOFC, bool HMEODMGMEGG, ref JobHandle AIDIOJAAFGP, ref JobHandle KAPIJFGKJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2C30DD0", Offset = "0x2C2FBD0", VA = "0x182C30DD0")]
		internal bool ACHLGFKIAJI(in OOPIHDDHHBC AFOPPLDIMJL, out JobHandle MIGDJNOKMHC, out KGFPMIPOKMG NJDBLKNAIHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2C30E00", Offset = "0x2C2FC00", VA = "0x182C30E00")]
		private bool ACHLGFKIAJI(in OOPIHDDHHBC AFOPPLDIMJL, bool HMEODMGMEGG, out JobHandle MIGDJNOKMHC, out KGFPMIPOKMG NJDBLKNAIHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2C32A10", Offset = "0x2C31810", VA = "0x182C32A10")]
		internal (NativeList<int>, NativeList<int>) NAOECJJCONG(NativeList<LPFMODCHECN> NKIDNGPMNIO, int CHMDLBBFMNF, JobHandle GINKINFGNEP, out JobHandle AADBABLKHJM, Allocator JEOILJEOOOI = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2C328E0", Offset = "0x2C316E0", VA = "0x182C328E0")]
		internal static NativeArray<Entity> MKPDAOMPGOI(EntityQuery JFPFDEFJDBP, out JobHandle FMGGAIEOAAJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2C32990", Offset = "0x2C31790", VA = "0x182C32990")]
		internal static NativeArray<byte> MPCBBJPLGID(int HFAIGCGNPJJ, out JobHandle AMJGBAPIFCG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2C33CA0", Offset = "0x2C32AA0", VA = "0x182C33CA0")]
		internal static NativeArray<byte> PCMGJIFBGKI(EntityQuery JFPFDEFJDBP, int DBMJEOKPFJK, out JobHandle AMJGBAPIFCG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2C32340", Offset = "0x2C31140", VA = "0x182C32340")]
		internal static NativeArray<Entity> IABHOJFHKFJ(EntityQuery JFPFDEFJDBP, out JobHandle DJHMNGMPAKO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2C317B0", Offset = "0x2C305B0", VA = "0x182C317B0")]
		internal NativeArray<byte> DGBMLKNPFDC(NativeArray<Entity> FBMJMNCDHDM, OOPIHDDHHBC OHDDMIOPOFC, JobHandle GINKINFGNEP, out JobHandle AADBABLKHJM, Allocator JEOILJEOOOI = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2C32E00", Offset = "0x2C31C00", VA = "0x182C32E00")]
		internal JobHandle NOHHIGNKGIH(in KGFPMIPOKMG JANIFNADDOP, in OOPIHDDHHBC OHDDMIOPOFC, NativeMultiHashMap<Entity, OJINANPDCIH> ABCKJKCJCPN, JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFB680", Offset = "0x1FFA480", VA = "0x181FFB680")]
		private JobHandle ABNCHJEOCEL(JobHandle DAIGLJEOPBB, JobHandle NJEDBKEAGEL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x1FFB680", Offset = "0x1FFA480", VA = "0x181FFB680")]
		private JobHandle ABNCHJEOCEL(JobHandle DAIGLJEOPBB, JobHandle NJEDBKEAGEL, JobHandle GOLOIKHJMLE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal abstract class HONFBOGIPMF : PropagateTagsBase<global::GHPEDNEJKIN, global::EILCDGAAILO, HONFBOGIPMF.JBNNOCDHICP>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public struct JBNNOCDHICP : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x282BC80", Offset = "0x282AA80", VA = "0x18282BC80")]
	protected HONFBOGIPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x282BC40", Offset = "0x282AA40", VA = "0x18282BC40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal abstract class JCNKOHLNAFM : PropagateTagsBase<GGDHNMAPAGC, global::DBMDLLBHCCH, JCNKOHLNAFM.ICDCINMBABM>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public struct ICDCINMBABM : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x282F890", Offset = "0x282E690", VA = "0x18282F890")]
	protected JCNKOHLNAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x282F850", Offset = "0x282E650", VA = "0x18282F850", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public class OHMOPMJJDKB : IKMBABCDPGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct NBGBOCPANJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public NBGBOCPANJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DDIHMJEEMOL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct MLMMHHHANLA
		{
			[Cpp2IlInjected.Token(Token = "0x2000111")]
			[NoAlias]
			public struct MANHBOFMDNE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000382")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime ENILDBPKNCE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> BCIMJMKNBHB;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x3609270", Offset = "0x3608070", VA = "0x183609270")]
			public void LONPEHHIFCO(OHMOPMJJDKB OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x3609220", Offset = "0x3608020", VA = "0x183609220")]
			public MANHBOFMDNE LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(MANHBOFMDNE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public NativeArray<int> DEJEDNNJILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private MLMMHHHANLA JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MLMMHHHANLA.MANHBOFMDNE* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x36010B0", Offset = "0x35FFEB0", VA = "0x1836010B0")]
		internal void POIJCEOICMD(ref AuthoredLocalPoseData AFCNGEGHGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x3601180", Offset = "0x35FFF80", VA = "0x183601180", Slot = "5")]
		public void ReadFromDisplayClass(ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x29311E0", Offset = "0x292FFE0", VA = "0x1829311E0", Slot = "6")]
		public void WriteToDisplayClass(ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x3600EB0", Offset = "0x35FFCB0", VA = "0x183600EB0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x3601020", Offset = "0x35FFE20", VA = "0x183601020")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref MLMMHHHANLA.MANHBOFMDNE PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x3600FA0", Offset = "0x35FFDA0", VA = "0x183600FA0")]
		public void LONPEHHIFCO(OHMOPMJJDKB OJEDNGBIKHJ, ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x3600F30", Offset = "0x35FFD30", VA = "0x183600F30")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x283CA80", Offset = "0x283B880", VA = "0x18283CA80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public OHMOPMJJDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x283C850", Offset = "0x283B650", VA = "0x18283C850", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x283C6F0", Offset = "0x283B4F0", VA = "0x18283C6F0")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public class PFEBNMLDBNN : IKMBABCDPGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct NJCMAMLFFDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public NJCMAMLFFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OCONCNFPECJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		private struct ADBCNNNDBIF
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			[NoAlias]
			public struct LPAMGAOACHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400038F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime JOAIOBDGKIN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> BEMKKGLAMNI;

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x35FEDE0", Offset = "0x35FDBE0", VA = "0x1835FEDE0")]
			public void LONPEHHIFCO(PFEBNMLDBNN OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x35FED60", Offset = "0x35FDB60", VA = "0x1835FED60")]
			public LPAMGAOACHH LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(LPAMGAOACHH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public NativeList<Entity> OPCIALJIHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private ADBCNNNDBIF JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ADBCNNNDBIF.LPAMGAOACHH* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x3609A70", Offset = "0x3608870", VA = "0x183609A70")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, SplinePointData EFCGBFLJIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x3609AF0", Offset = "0x36088F0", VA = "0x183609AF0", Slot = "5")]
		public void ReadFromDisplayClass(ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x3609B00", Offset = "0x3608900", VA = "0x183609B00", Slot = "6")]
		public void WriteToDisplayClass(ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x3609800", Offset = "0x3608600", VA = "0x183609800", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x36099A0", Offset = "0x36087A0", VA = "0x1836099A0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref ADBCNNNDBIF.LPAMGAOACHH PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x3609910", Offset = "0x3608710", VA = "0x183609910")]
		public void LONPEHHIFCO(PFEBNMLDBNN OJEDNGBIKHJ, ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x36098A0", Offset = "0x36086A0", VA = "0x1836098A0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x2867820", Offset = "0x2866620", VA = "0x182867820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public PFEBNMLDBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x28675F0", Offset = "0x28663F0", VA = "0x1828675F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x2867490", Offset = "0x2866290", VA = "0x182867490")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public class OJGBHFKCJPI : IKMBABCDPGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private EntityQuery FNAJLFPJAMF;

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x283CD00", Offset = "0x283BB00", VA = "0x18283CD00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x283CD90", Offset = "0x283BB90", VA = "0x18283CD90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public OJGBHFKCJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public class FPDBMMINPKE : IKMBABCDPGL, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct NCDNPKIEBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public NativeHashMap<NMEJDFJAOOA, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public NCDNPKIEBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FMIFEIFJMHK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct LAPBODDGOML
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct NLJBKLBFFEL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400039C")]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400039D")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HKIKOLJKOJO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> NCMBEACEFPL;

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x36076A0", Offset = "0x36064A0", VA = "0x1836076A0")]
			public void LONPEHHIFCO(FPDBMMINPKE OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x3607620", Offset = "0x3606420", VA = "0x183607620")]
			public NLJBKLBFFEL LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(NLJBKLBFFEL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public NativeHashMap<NMEJDFJAOOA, Entity> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private LAPBODDGOML JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LAPBODDGOML.NLJBKLBFFEL* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x3602A10", Offset = "0x3601810", VA = "0x183602A10")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData KBDGPLALJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x3601180", Offset = "0x35FFF80", VA = "0x183601180", Slot = "5")]
		public void ReadFromDisplayClass(ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x29311E0", Offset = "0x292FFE0", VA = "0x1829311E0", Slot = "6")]
		public void WriteToDisplayClass(ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x36027C0", Offset = "0x36015C0", VA = "0x1836027C0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x3602960", Offset = "0x3601760", VA = "0x183602960")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref LAPBODDGOML.NLJBKLBFFEL PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x36028D0", Offset = "0x36016D0", VA = "0x1836028D0")]
		public void LONPEHHIFCO(FPDBMMINPKE OJEDNGBIKHJ, ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x3602860", Offset = "0x3601660", VA = "0x183602860")]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private ObjectNetworkToLocalMapService DNGOCFEOHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x2827B70", Offset = "0x2826970", VA = "0x182827B70", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x2827DD0", Offset = "0x2826BD0", VA = "0x182827DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public FPDBMMINPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x2827BD0", Offset = "0x28269D0", VA = "0x182827BD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2827A10", Offset = "0x2826810", VA = "0x182827A10")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	public class PostLoadInitializeEmbodiment : IKEIJDHBAML, FDFFINEAOHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[CompilerGenerated]
		private struct NOBGLALBIFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public NativeList<NMEJDFJAOOA> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public BufferFromEntity<ChildrenData> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public ComponentDataFromEntity<SerializedEmbodiedData> embodiedFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdFromEntity;

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
			public NOBGLALBIFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
			internal void <AddEmbodiedTopologically>b__0(Entity entity, ObjectNetworkIdComponentData component)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct DDBFAFGDOKI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000120")]
			private struct JJJMBMHAJFM
			{
				[Cpp2IlInjected.Token(Token = "0x2000121")]
				[NoAlias]
				public struct BIBGDKACDOE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003B5")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003B6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime LJPEGFFCJJB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> LPKJKPMAGGP;

				[Cpp2IlInjected.Token(Token = "0x60007C4")]
				[Cpp2IlInjected.Address(RVA = "0x3606C10", Offset = "0x3605A10", VA = "0x183606C10")]
				public void LONPEHHIFCO(PostLoadInitializeEmbodiment OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007C5")]
				[Cpp2IlInjected.Address(RVA = "0x3606B90", Offset = "0x3605990", VA = "0x183606B90")]
				public BIBGDKACDOE LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(BIBGDKACDOE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public NativeList<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public NativeList<NMEJDFJAOOA> FCIMMLKHDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public BufferFromEntity<ChildrenData> GMMBHFBGHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public ComponentDataFromEntity<SerializedEmbodiedData> EGEINCHHHIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> ICMCNPOMNAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private JJJMBMHAJFM JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JJJMBMHAJFM.BIBGDKACDOE* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x3600DE0", Offset = "0x35FFBE0", VA = "0x183600DE0")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData AFOPPLDIMJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x36009B0", Offset = "0x35FF7B0", VA = "0x1836009B0")]
			internal void AHPPNJDCFGE(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData AFOPPLDIMJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x3600BD0", Offset = "0x35FF9D0", VA = "0x183600BD0")]
			internal void MHKDKCMMGOB(Entity GEEFHDFLBEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x3600E10", Offset = "0x35FFC10", VA = "0x183600E10", Slot = "5")]
			public void ReadFromDisplayClass(ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x3600E60", Offset = "0x35FFC60", VA = "0x183600E60", Slot = "6")]
			public void WriteToDisplayClass(ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x3600A30", Offset = "0x35FF830", VA = "0x183600A30", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0x3600D30", Offset = "0x35FFB30", VA = "0x183600D30")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JJJMBMHAJFM.BIBGDKACDOE PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x3600B40", Offset = "0x35FF940", VA = "0x183600B40")]
			public void LONPEHHIFCO(PostLoadInitializeEmbodiment OJEDNGBIKHJ, ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C3")]
			[Cpp2IlInjected.Address(RVA = "0x3600AD0", Offset = "0x35FF8D0", VA = "0x183600AD0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private EntityQuery JEDIHPJPGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery FICAHAEACNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private ProfilerMarker PBHBLBOAIEH;

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x286D040", Offset = "0x286BE40", VA = "0x18286D040", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x286D910", Offset = "0x286C710", VA = "0x18286D910", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x286D9A0", Offset = "0x286C7A0", VA = "0x18286D9A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x286D460", Offset = "0x286C260", VA = "0x18286D460")]
		private void IDNMGGHJMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x286D0F0", Offset = "0x286BEF0", VA = "0x18286D0F0")]
		private NativeArray<AHCKAEEHFIB> HKPBMMABDCH(NativeArray<NMEJDFJAOOA> FCIMMLKHDCA)
		{
			return default(NativeArray<AHCKAEEHFIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x286CBF0", Offset = "0x286B9F0", VA = "0x18286CBF0")]
		private void DJDHPKIOLBP(NativeList<Entity> FBMJMNCDHDM, NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x286CA00", Offset = "0x286B800", VA = "0x18286CA00")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BPIIJFOCCLI(NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private static void BBKLLPAMBEI(NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x286D7D0", Offset = "0x286C5D0", VA = "0x18286D7D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x286CE40", Offset = "0x286BC40", VA = "0x18286CE40")]
		public static EntityQuery FGDPGIDECFK(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public class LCICNAGLPHM : IKEIJDHBAML, FDFFINEAOHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct JPBFPLOPAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public NativeHashMap<NMEJDFJAOOA, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		public JPBFPLOPAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x35FF200", Offset = "0x35FE000", VA = "0x1835FF200")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct EMNNMNEAMOI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		private struct JLKLPEALCDA
		{
			[Cpp2IlInjected.Token(Token = "0x2000126")]
			[NoAlias]
			public struct KDNLOCBNAPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003C3")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40003C4")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime OPJHNHKMNMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003C5")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HKIKOLJKOJO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex IHDKDECCAIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> NCMBEACEFPL;

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x3606D20", Offset = "0x3605B20", VA = "0x183606D20")]
			public void LONPEHHIFCO(LCICNAGLPHM OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x3606C70", Offset = "0x3605A70", VA = "0x183606C70")]
			public KDNLOCBNAPC LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
			{
				return default(KDNLOCBNAPC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public NativeHashMap<NMEJDFJAOOA, Entity> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private JLKLPEALCDA JIIIPLOBHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JLKLPEALCDA.KDNLOCBNAPC* GDDJOKMGGGD;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CGIFCEPIHJC;

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x3601CF0", Offset = "0x3600AF0", VA = "0x183601CF0")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, int GHHKILHNDGM, ref ObjectNetworkIdComponentData KBDGPLALJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x3601180", Offset = "0x35FFF80", VA = "0x183601180", Slot = "5")]
		public void ReadFromDisplayClass(ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x29311E0", Offset = "0x292FFE0", VA = "0x1829311E0", Slot = "6")]
		public void WriteToDisplayClass(ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x3601A20", Offset = "0x3600820", VA = "0x183601A20", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x3601C20", Offset = "0x3600A20", VA = "0x183601C20")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JLKLPEALCDA.KDNLOCBNAPC PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x3601B80", Offset = "0x3600980", VA = "0x183601B80")]
		public void LONPEHHIFCO(LCICNAGLPHM OJEDNGBIKHJ, ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x3601B10", Offset = "0x3600910", VA = "0x183601B10")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private ObjectNetworkToLocalMapService DNGOCFEOHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private EntityQuery DAEHIDPLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private ProfilerMarker HBPLALPJEHI;

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x28368F0", Offset = "0x28356F0", VA = "0x1828368F0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x2836B80", Offset = "0x2835980", VA = "0x182836B80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public LCICNAGLPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2836950", Offset = "0x2835750", VA = "0x182836950", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2836790", Offset = "0x2835590", VA = "0x182836790")]
	public static EntityQuery FBLNOBNCHGN(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public class PLPPACFFCAP : IKEIJDHBAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private EntityQuery JEDIHPJPGKK;

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x2868280", Offset = "0x2867080", VA = "0x182868280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x2868310", Offset = "0x2867110", VA = "0x182868310", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public PLPPACFFCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public class AMAAPGIIJHF : IKEIJDHBAML, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C28390", Offset = "0x2C27190", VA = "0x182C28390", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C28530", Offset = "0x2C27330", VA = "0x182C28530", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C28180", Offset = "0x2C26F80", VA = "0x182C28180")]
	private void FFOKAPOGCOP(NativeList<EntityArchetype> PCOKMHJEFGC, NativeHashMap<int, NOAPHGCLLPE> CEAADNHDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C27B80", Offset = "0x2C26980", VA = "0x182C27B80")]
	private void AFHJJEPEJLJ(NativeHashMap<int, NOAPHGCLLPE> CEAADNHDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public AMAAPGIIJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C283F0", Offset = "0x2C271F0", VA = "0x182C283F0")]
	[CompilerGenerated]
	internal static Span<int> IGCPCFNHMGP(EntityArchetype CEINJAHAPJN)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[IFBLAMOEMKH(CMGBDLINHMB.Serialization)]
	public class PreSerializeRemoveEntities : IKEIJDHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery AJFALAKCPBE;

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x286DA90", Offset = "0x286C890", VA = "0x18286DA90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x286DCE0", Offset = "0x286CAE0", VA = "0x18286DCE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(NGBOFDOMIKJ))]
internal sealed class MAINBLDADFG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public MAINBLDADFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(ILHIKHAIJNM))]
internal sealed class CNPNLBBJAOK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public CNPNLBBJAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(BINCJPPOHMK))]
internal sealed class PMAGEIGMADI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public PMAGEIGMADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(FNPHKNFELIE))]
internal sealed class HODOFLBPGBO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public HODOFLBPGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(KAHDFHOCEMC))]
internal sealed class MNIPDJHOGDG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public MNIPDJHOGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KIABADAKEGB))]
internal sealed class PMDCPHBIDCC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public PMDCPHBIDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(HEEHHHHFPDD))]
internal sealed class KBAINBIJCDH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public KBAINBIJCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANCFDIJGMDO))]
internal sealed class BOKPOOFDOKN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public BOKPOOFDOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[CIHFPOEPMJE]
[ExecuteAlways]
[UpdateInGroup(typeof(LKLKPHFEOKG))]
internal sealed class DNGIILCGBEO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public DNGIILCGBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(LKLKPHFEOKG))]
[UpdateAfter(typeof(DNGIILCGBEO))]
internal sealed class CDBKMKJLKKC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public CDBKMKJLKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000135")]
		[BurstCompile]
		private struct IIPNAIJDHIF : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private const float AHIMGNBOEJC = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> GPCFFPMNMLM;

			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x3604F30", Offset = "0x3603D30", VA = "0x183604F30", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x3605130", Offset = "0x3603F30", VA = "0x183605130")]
			private bool OEJCMGLLIOO(float3 HFFCNNKMKHP, float3 BEIKMLIBFDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x36050F0", Offset = "0x3603EF0", VA = "0x1836050F0")]
			private bool NPFGHMKIMNJ(quaternion HFFCNNKMKHP, quaternion BEIKMLIBFDO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000136")]
		[BurstCompile]
		private struct KFFLJJOOPHA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> ELPMACOFDGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> GMEGLFBPIDK;

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x3606F80", Offset = "0x3605D80", VA = "0x183606F80", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private const string NHFDFKOOOOF = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private const string CBDDNPHPNBI = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string KABICPHJLAF = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private static readonly CGJHBFGPOOL MKLINGFHCIM;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private static readonly CGJHBFGPOOL BPEILADNFEG;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly CGJHBFGPOOL FIKEHMDLMKE;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static readonly ProfilerMarker EELFJGIGFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private BEPDNGBBFFI KMDLECCOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C36380", Offset = "0x2C35180", VA = "0x182C36380", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C363F0", Offset = "0x2C351F0", VA = "0x182C363F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C36420", Offset = "0x2C35220", VA = "0x182C36420", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing)]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	public class RegisterTransforms : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct PJOACMEEDMC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200013A")]
			private struct DJDPHGMGJMA
			{
				[Cpp2IlInjected.Token(Token = "0x200013B")]
				public struct CKMANEENGDF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003ED")]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003EE")]
					public LambdaParameterValueProvider_IComponentData<INDEJLDCMLL>.Runtime JPCBBCIAMNI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003EF")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime FAIKLINAJOF;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003EA")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003EB")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<INDEJLDCMLL> JKAAIMKLMDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003EC")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> JCDIDPCDLIJ;

				[Cpp2IlInjected.Token(Token = "0x600081E")]
				[Cpp2IlInjected.Address(RVA = "0x3601250", Offset = "0x3600050", VA = "0x183601250")]
				public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600081F")]
				[Cpp2IlInjected.Address(RVA = "0x3601190", Offset = "0x35FFF90", VA = "0x183601190")]
				public CKMANEENGDF LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(CKMANEENGDF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private DJDPHGMGJMA JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DJDPHGMGJMA.CKMANEENGDF* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate MLOPHBJNPOC;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x360AE70", Offset = "0x3609C70", VA = "0x18360AE70")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, INDEJLDCMLL AGJLGNIMOFB, Transform BCHADNCHEKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x360AC20", Offset = "0x3609A20", VA = "0x18360AC20", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x360AD90", Offset = "0x3609B90", VA = "0x18360AD90")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref DJDPHGMGJMA.CKMANEENGDF PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x360AD80", Offset = "0x3609B80", VA = "0x18360AD80")]
			public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x360AD10", Offset = "0x3609B10", VA = "0x18360AD10")]
			public unsafe static void JKIELGCPKMB(ArchetypeChunkIterator* NNDIHLBOJOE, void* LPGHNKKMKEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200013C")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct CPBEDJELIGE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200013D")]
			private struct EEBIJFAKLBA
			{
				[Cpp2IlInjected.Token(Token = "0x200013E")]
				[NoAlias]
				public struct MGHMNDLNIIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003F4")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime HALLIGBLEIM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003F5")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<INDEJLDCMLL>.Runtime JPCBBCIAMNI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F2")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity NKIKBEMOMMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003F3")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<INDEJLDCMLL> JKAAIMKLMDE;

				[Cpp2IlInjected.Token(Token = "0x6000824")]
				[Cpp2IlInjected.Address(RVA = "0x35FFF60", Offset = "0x35FED60", VA = "0x1835FFF60")]
				public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000825")]
				[Cpp2IlInjected.Address(RVA = "0x3601570", Offset = "0x3600370", VA = "0x183601570")]
				public MGHMNDLNIIC LANFGEJCGNO(ref ArchetypeChunk HGOFDOMMHHF, int ENILEKHNCCI, int DHIBBJNMIPC)
				{
					return default(MGHMNDLNIIC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private EEBIJFAKLBA JIIIPLOBHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe EEBIJFAKLBA.MGHMNDLNIIC* GDDJOKMGGGD;

			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x3600070", Offset = "0x35FEE70", VA = "0x183600070")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, INDEJLDCMLL AGJLGNIMOFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x35FFED0", Offset = "0x35FECD0", VA = "0x1835FFED0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x35FFFC0", Offset = "0x35FEDC0", VA = "0x1835FFFC0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref EEBIJFAKLBA.MGHMNDLNIIC PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x35FFF60", Offset = "0x35FED60", VA = "0x1835FFF60")]
			public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private KPIOIDPOAPF CAIOPLIIMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private BEPDNGBBFFI KMDLECCOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery NDMNKFHMCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private EntityQuery JKELFFGDBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private EntityQuery HPCILLJOCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private EntityQuery DDEINPBMMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery FLHELAMPBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private ProfilerMarker LCDJLPNKIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private EntityQuery AAINMHLOKDI;

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x28714A0", Offset = "0x28702A0", VA = "0x1828714A0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2871D80", Offset = "0x2870B80", VA = "0x182871D80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2871FA0", Offset = "0x2870DA0", VA = "0x182871FA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2872080", Offset = "0x2870E80", VA = "0x182872080")]
		private void PPELDHCHHMJ(EntityQuery JFPFDEFJDBP, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x28714F0", Offset = "0x28702F0", VA = "0x1828714F0")]
		private void IOJMOKCIKNO(EntityQuery JFPFDEFJDBP, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2871F50", Offset = "0x2870D50", VA = "0x182871F50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2870EB0", Offset = "0x286FCB0", VA = "0x182870EB0")]
		private void CPKICJNHJPO(NativeArray<Entity> FBMJMNCDHDM, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2870FF0", Offset = "0x286FDF0", VA = "0x182870FF0")]
		[BurstCompile]
		internal static void FAELDAKLBND(NativeArray<INDEJLDCMLL> GIOJGEAAIGM, ComponentDataFromEntity<INDEJLDCMLL> KBPACPMPIMI, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private static void NIDLIBPLDNN(Transform BCHADNCHEKP, Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private static void NPJCMGIJMNE(Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private static void CPDILHHAHEB(int AIPHGHFENPJ, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2871920", Offset = "0x2870720", VA = "0x182871920")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void OPLEJMMLBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2871B00", Offset = "0x2870900", VA = "0x182871B00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2871300", Offset = "0x2870100", VA = "0x182871300")]
		public static EntityQuery GODINDNLLMP(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2871750", Offset = "0x2870550", VA = "0x182871750")]
		public static EntityQuery NJKKLDIFDNH(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[MEHANEDMMGM(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : IKEIJDHBAML, FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		[BurstCompile]
		private struct CLACACONJLJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> GPCFFPMNMLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x35FFAC0", Offset = "0x35FE8C0", VA = "0x1835FFAC0", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000141")]
		[BurstCompile]
		private struct JCEDPFPGCOO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ELPMACOFDGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x36055D0", Offset = "0x36043D0", VA = "0x1836055D0", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000142")]
		[BurstCompile]
		private struct IICPLHBHFEF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ELPMACOFDGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> GMEGLFBPIDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			[ReadOnly]
			public NativeArray<Entity> FBMJMNCDHDM;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x3604E30", Offset = "0x3603C30", VA = "0x183604E30", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private const string NHFDFKOOOOF = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private const string CBDDNPHPNBI = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private const string KABICPHJLAF = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private static readonly CGJHBFGPOOL MKLINGFHCIM;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private static readonly CGJHBFGPOOL BPEILADNFEG;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private static readonly CGJHBFGPOOL FIKEHMDLMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private BEPDNGBBFFI KMDLECCOEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private JobHandle BCHMEFEMADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private EntityQuery EFJEBABOMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private EntityQuery HJAKPLOEGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private EntityQuery MJIKGPBIFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TransformAccessArray GGLKPEACCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TransformAccessArray LIHDEBMOAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TransformAccessArray FPBDBLCKLAP;

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2C368B0", Offset = "0x2C356B0", VA = "0x182C368B0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x2C36A80", Offset = "0x2C35880", VA = "0x182C36A80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2C36C50", Offset = "0x2C35A50", VA = "0x182C36C50", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2C36CE0", Offset = "0x2C35AE0", VA = "0x182C36CE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xC02A40", Offset = "0xC01840", VA = "0x180C02A40")]
		internal JobHandle GEIIGNLGFLC()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2C36D10", Offset = "0x2C35B10", VA = "0x182C36D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2C36900", Offset = "0x2C35700", VA = "0x182C36900")]
		private NativeArray<Entity> NHEOCOGPCFH(NativeArray<INDEJLDCMLL> LGLGGCHFNDI, NativeList<Entity> ILCJJBCCAGM, TransformAccessArray FECNFHOPJJE, TransformAccessArray NAMIGGEMGEK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public class ADBJNMLEGAN : IKEIJDHBAML, CDAFEBOKDJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private CMEEFJNDPID OAACGCFNLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private MFLHDAEOBPP IMFCFJELJOA;

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x2C257C0", Offset = "0x2C245C0", VA = "0x182C257C0", Slot = "14")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AA0", Offset = "0x2C248A0", VA = "0x182C25AA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x2C258C0", Offset = "0x2C246C0", VA = "0x182C258C0")]
	private static void LONBOHKOAAL(EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH, Entity ADECAOLBLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x2C256C0", Offset = "0x2C244C0", VA = "0x182C256C0")]
	private static Transform AGDAIJOCIIH(EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public ADBJNMLEGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[IFBLAMOEMKH(CMGBDLINHMB.TransformSyncing)]
	public class L2PToL2WHierarchy : IKEIJDHBAML
	{
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		[BurstCompile]
		private struct JEHIBCPBPMB : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> ADIINOLLBBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> GKPACHGNFLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> ALANNIIDHOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> GIOOLDCFFAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public ArchetypeChunkComponentType<LocalToWorldData> GFBOPBKNLLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> GABAHDLHLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public uint AEPGONMKGBO;

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0x3605B50", Offset = "0x3604950", VA = "0x183605B50")]
			[Conditional("DEBUG_BUILD")]
			private void FHMJJINLJDI(Entity GEEFHDFLBEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x3605870", Offset = "0x3604670", VA = "0x183605870", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x3605C20", Offset = "0x3604A20", VA = "0x183605C20")]
			private void NHEIJOMNPLK(float4x4 NJANOBLLHHA, Entity GEEFHDFLBEH, bool LNFKOFMNKEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private EntityQuery KCHNAHKCDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private EntityQuery KNEGHICNEHB;

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x2834930", Offset = "0x2833730", VA = "0x182834930", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x2834A50", Offset = "0x2833850", VA = "0x182834A50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
public class KFLEDGAOGNG : DBEHBMCDNIE
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[BurstCompile]
	private struct ACFDEOCKIGP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> ADIINOLLBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public ArchetypeChunkComponentType<LocalToWorldData> GFBOPBKNLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public uint AEPGONMKGBO;

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x35FEB70", Offset = "0x35FD970", VA = "0x1835FEB70", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x35FEC70", Offset = "0x35FDA70", VA = "0x1835FEC70")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private EntityQuery KCHNAHKCDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x28311E0", Offset = "0x282FFE0", VA = "0x1828311E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2831310", Offset = "0x2830110", VA = "0x182831310", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public KFLEDGAOGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public class JDGKDHAHBBO : DBEHBMCDNIE
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[BurstCompile]
	private struct EHBNHDHMMAE : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> IJHPKNLIJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public ArchetypeChunkComponentType<WorldPoseData> OMPLHMDAKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> ACNCLNFGPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> BFHMONPABJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public uint AEPGONMKGBO;

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x36015F0", Offset = "0x36003F0", VA = "0x1836015F0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x36019A0", Offset = "0x36007A0", VA = "0x1836019A0")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private EntityQuery JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x282F900", Offset = "0x282E700", VA = "0x18282F900", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x282FA10", Offset = "0x282E810", VA = "0x18282FA10", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public JDGKDHAHBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public class KIJDBALHHDP : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[BurstCompile]
	private struct CPHELAJIMLM : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> PDFJLIDONJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> BEIEHFAKLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> ECMMBBKJIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public ArchetypeChunkComponentType<LocalToParentData> FOPCECKNIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public uint AEPGONMKGBO;

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x3600150", Offset = "0x35FEF50", VA = "0x183600150", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x3600890", Offset = "0x35FF690", VA = "0x183600890")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private EntityQuery JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x2833F60", Offset = "0x2832D60", VA = "0x182833F60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x2834090", Offset = "0x2832E90", VA = "0x182834090", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0")]
	public KIJDBALHHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class FJKACBADHOD : PropagateTagsBase<global::FHJAIHIHEFP, global::LGPDLCPKLCK, FJKACBADHOD.MFEFNLPKLJK>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	public struct MFEFNLPKLJK : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2825CD0", Offset = "0x2824AD0", VA = "0x182825CD0")]
	protected FJKACBADHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2825C90", Offset = "0x2824A90", VA = "0x182825C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[AAFIHLNHDHN(LBGCMANLNFC.Game)]
public class PFFJFKNCGNH : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x2867AE0", Offset = "0x28668E0", VA = "0x182867AE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x2867B50", Offset = "0x2866950", VA = "0x182867B50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public PFFJFKNCGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[AAFIHLNHDHN(LBGCMANLNFC.Loading)]
public class BPIHAHBKMAO : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65CF70", VA = "0x18065E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x2C2E590", Offset = "0x2C2D390", VA = "0x182C2E590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public BPIHAHBKMAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public sealed class OHBEPLANKDB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public OHBEPLANKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(OHBEPLANKDB))]
public sealed class CNDMKJANPBA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public CNDMKJANPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(OHBEPLANKDB))]
[UpdateAfter(typeof(CNDMKJANPBA))]
public sealed class EADAPMIJCBG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public EADAPMIJCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[AAFIHLNHDHN(LBGCMANLNFC.Saving)]
public class OMIDCKKPCGF : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65CF70", VA = "0x18065E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x283D0E0", Offset = "0x283BEE0", VA = "0x18283D0E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000863")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OMIDCKKPCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
public sealed class EHOCPENPMLI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public EHOCPENPMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[AAFIHLNHDHN(LBGCMANLNFC.Simulation)]
public class BBGLFICDIOD : EEDDFLCIHPA
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Type PHILEHBIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B7A0", Offset = "0x2C2A5A0", VA = "0x182C2B7A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B810", Offset = "0x2C2A610", VA = "0x182C2B810", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public BBGLFICDIOD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[IFBLAMOEMKH(CMGBDLINHMB.Prefabs)]
	[JAPBKNDOGGF(typeof(EHIDJEIAFME))]
	[EBJHGMECDNA(typeof(ObjectPrefabs), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
	internal class ObjectPrefabs : MKHGKLCBKJA, FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		[CompilerGenerated]
		private sealed class MCGFPAMHCAG : IEnumerable<(FEJKANODFOG, CBLLNBPHCKJ)>, IEnumerable, IEnumerator<(FEJKANODFOG, CBLLNBPHCKJ)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			private (FEJKANODFOG primitiveType, CBLLNBPHCKJ prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			private (FEJKANODFOG, CBLLNBPHCKJ) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000884")]
				[Cpp2IlInjected.Address(RVA = "0x210B480", Offset = "0x210A280", VA = "0x18210B480", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((FEJKANODFOG, CBLLNBPHCKJ));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000886")]
				[Cpp2IlInjected.Address(RVA = "0x36091D0", Offset = "0x3607FD0", VA = "0x1836091D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x3603290", Offset = "0x3602090", VA = "0x183603290")]
			[DebuggerHidden]
			public MCGFPAMHCAG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0x3608FF0", Offset = "0x3607DF0", VA = "0x183608FF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x3609190", Offset = "0x3607F90", VA = "0x183609190", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x36090F0", Offset = "0x3607EF0", VA = "0x1836090F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(FEJKANODFOG, CBLLNBPHCKJ)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x36090F0", Offset = "0x3607EF0", VA = "0x1836090F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private readonly Dictionary<CBLLNBPHCKJ, Entity> JOIDICOJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private readonly Dictionary<CBLLNBPHCKJ, EntityArchetype> PCOKMHJEFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private readonly Dictionary<FEJKANODFOG, CBLLNBPHCKJ> NLNEHKJGGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private readonly Dictionary<EFCIKLEKING, CBLLNBPHCKJ> MGPDLKOBGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private DLKHAAIDMDD EAIMAINFOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private World HADAJAKADAH;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0x28655A0", Offset = "0x28643A0", VA = "0x1828655A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public GCGDMFPPNPN FCKIDLDDAFK
		{
			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x2113790", Offset = "0x2112590", VA = "0x182113790")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x2865190", Offset = "0x2863F90", VA = "0x182865190", Slot = "6")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x2864D90", Offset = "0x2863B90", VA = "0x182864D90", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x2865FF0", Offset = "0x2864DF0", VA = "0x182865FF0")]
		internal IEnumerable<Type> OEDOHBCLBMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x2865120", Offset = "0x2863F20", VA = "0x182865120")]
		internal BKMFLCIMEEJ HBMJOEAILCE(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x28650C0", Offset = "0x2863EC0", VA = "0x1828650C0")]
		public EntityArchetype FFEHPLPHBKO(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x2865A40", Offset = "0x2864840", VA = "0x182865A40", Slot = "4")]
		[IteratorStateMachine(typeof(MCGFPAMHCAG))]
		public IEnumerable<(FEJKANODFOG, CBLLNBPHCKJ)> LMEBMBJEMGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x28655F0", Offset = "0x28643F0", VA = "0x1828655F0")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x28657C0", Offset = "0x28645C0", VA = "0x1828657C0")]
		public CBLLNBPHCKJ KEOMIGEONAO(EFCIKLEKING NKICFHCCMMH)
		{
			return default(CBLLNBPHCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x2865760", Offset = "0x2864560", VA = "0x182865760")]
		public CBLLNBPHCKJ KEOMIGEONAO(FEJKANODFOG NKICFHCCMMH)
		{
			return default(CBLLNBPHCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x2866020", Offset = "0x2864E20", VA = "0x182866020")]
		public IEnumerable<CBLLNBPHCKJ> PDKEFKCBICH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2865700", Offset = "0x2864500", VA = "0x182865700")]
		public Entity IOLGMDLDDIN(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x2865C10", Offset = "0x2864A10", VA = "0x182865C10")]
		private void MNFFEOCLIEH(BKMFLCIMEEJ HPFLFGLJAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2865820", Offset = "0x2864620", VA = "0x182865820")]
		internal void LHGLALOAHCC(CBLLNBPHCKJ GFIKNFBJKNP, AMFJBNENFOE IIHOIPENPMG, EHGHKOOKADN POGEIAMADJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2865AB0", Offset = "0x28648B0", VA = "0x182865AB0")]
		private void MMDBJIABBFK(CBLLNBPHCKJ GFIKNFBJKNP, AMFJBNENFOE CGPLPFBCOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2864C70", Offset = "0x2863A70", VA = "0x182864C70")]
		internal Entity AIOJPOPMMMF(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x28660C0", Offset = "0x2864EC0", VA = "0x1828660C0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal class DLKHAAIDMDD : GCGDMFPPNPN
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public AMFJBNENFOE LGJENDFKIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2C38270", Offset = "0x2C37070", VA = "0x182C38270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public AMFJBNENFOE OAEAENIOOID
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2C38570", Offset = "0x2C37370", VA = "0x182C38570", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public AMFJBNENFOE JOCENFLBGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2C386C0", Offset = "0x2C374C0", VA = "0x182C386C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public AMFJBNENFOE IMJLAOKPEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2C38730", Offset = "0x2C37530", VA = "0x182C38730", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public AMFJBNENFOE DPGICPLHHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x2C385E0", Offset = "0x2C373E0", VA = "0x182C385E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public AMFJBNENFOE PHENHNFCBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2C38340", Offset = "0x2C37140", VA = "0x182C38340", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public AMFJBNENFOE OLMDPKCBJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2C38420", Offset = "0x2C37220", VA = "0x182C38420", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public AMFJBNENFOE LFKFPFBGCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2C38650", Offset = "0x2C37450", VA = "0x182C38650", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public AMFJBNENFOE MJDPGHDIINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2C38490", Offset = "0x2C37290", VA = "0x182C38490", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public AMFJBNENFOE PDGMPBFKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2C383B0", Offset = "0x2C371B0", VA = "0x182C383B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public AMFJBNENFOE HAIAIHGAAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2C382D0", Offset = "0x2C370D0", VA = "0x182C382D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public AMFJBNENFOE CPBAJJIFKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2C38500", Offset = "0x2C37300", VA = "0x182C38500", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x2C387A0", Offset = "0x2C375A0", VA = "0x182C387A0")]
	public DLKHAAIDMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[EBJHGMECDNA(typeof(BEPDNGBBFFI), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
internal sealed class BEPDNGBBFFI : DFDLCPDHDGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private OCGCGAIFBCP MJPMAIINMJI;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public OCGCGAIFBCP HKAJEAEBCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x1E77EB0", Offset = "0x1E76CB0", VA = "0x181E77EB0")]
		get
		{
			return default(OCGCGAIFBCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DC60", Offset = "0x2C2CA60", VA = "0x182C2DC60", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DC50", Offset = "0x2C2CA50", VA = "0x182C2DC50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public BEPDNGBBFFI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[EBJHGMECDNA(typeof(TransformOwnershipPhase), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.PhotonRoom)]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		public enum MLCNOFLLEIM
		{
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x200015D")]
		public struct CLMGIJDALIL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private MLCNOFLLEIM OIDAMDBPCLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private readonly TransformOwnershipPhase ADECAOLBLPJ;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x35FFBC0", Offset = "0x35FE9C0", VA = "0x1835FFBC0")]
			public CLMGIJDALIL(TransformOwnershipPhase ADECAOLBLPJ, MLCNOFLLEIM KDNCNAFJOGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x35FFBA0", Offset = "0x35FE9A0", VA = "0x1835FFBA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public MLCNOFLLEIM KDNCNAFJOGD;

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public MLCNOFLLEIM AOLPLBAILPC
		{
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x655E40", VA = "0x180657040")]
			get
			{
				return default(MLCNOFLLEIM);
			}
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x677F30", Offset = "0x676D30", VA = "0x180677F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool CBAABLKMGNA
		{
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x28779C0", Offset = "0x28767C0", VA = "0x1828779C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public bool HIIFNADKFDK
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x1399430", Offset = "0x1398230", VA = "0x181399430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x2877A00", Offset = "0x2876800", VA = "0x182877A00")]
		public CLMGIJDALIL POFMOHBMMAH()
		{
			return default(CLMGIJDALIL);
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x28779D0", Offset = "0x28767D0", VA = "0x1828779D0")]
		public CLMGIJDALIL LOCJGLBKDKE()
		{
			return default(CLMGIJDALIL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
[EBJHGMECDNA(typeof(LIACDBEGOKA), new string[] { })]
public class CFPONONCGHH : FDFFINEAOHD, LIACDBEGOKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2ED60", Offset = "0x2C2DB60", VA = "0x182C2ED60", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EDE0", Offset = "0x2C2DBE0", VA = "0x182C2EDE0", Slot = "5")]
	public bool ILHNLLKCKAB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EA00", Offset = "0x2C2D800", VA = "0x182C2EA00", Slot = "6")]
	public bool AOLBOGHMBHA(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EEA0", Offset = "0x2C2DCA0", VA = "0x182C2EEA0", Slot = "7")]
	public Guid MOIDJDIBHBB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EAF0", Offset = "0x2C2D8F0", VA = "0x182C2EAF0", Slot = "8")]
	public void BIKJHANLAHD(PMMHBDBEGAM ADGJAILKBPO, Guid ELBCBEIBJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EE40", Offset = "0x2C2DC40", VA = "0x182C2EE40", Slot = "9")]
	public void MLGEPCENHDG(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public CFPONONCGHH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[EBJHGMECDNA(typeof(JLCJAEGDOGE), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.Connectables, new string[] { "Callbacks" })]
	internal class ConnectableService : JLCJAEGDOGE, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		[CompilerGenerated]
		private sealed class OFDNGLGGDAP : IEnumerable<PMMHBDBEGAM>, IEnumerable, IEnumerator<PMMHBDBEGAM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private PMMHBDBEGAM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private PMMHBDBEGAM localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public PMMHBDBEGAM <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700010C")]
			private PMMHBDBEGAM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008D0")]
				[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(PMMHBDBEGAM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008D2")]
				[Cpp2IlInjected.Address(RVA = "0x3609F70", Offset = "0x3608D70", VA = "0x183609F70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0x9DE010", Offset = "0x9DCE10", VA = "0x1809DE010")]
			[DebuggerHidden]
			public OFDNGLGGDAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0x3609FC0", Offset = "0x3608DC0", VA = "0x183609FC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0x3609B10", Offset = "0x3608910", VA = "0x183609B10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008CE")]
			[Cpp2IlInjected.Address(RVA = "0x360A090", Offset = "0x3608E90", VA = "0x18360A090")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CF")]
			[Cpp2IlInjected.Address(RVA = "0x360A0E0", Offset = "0x3608EE0", VA = "0x18360A0E0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x3609F30", Offset = "0x3608D30", VA = "0x183609F30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x3609E80", Offset = "0x3608C80", VA = "0x183609E80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PMMHBDBEGAM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x3609E80", Offset = "0x3608C80", VA = "0x183609E80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private const string NGJFDPMAJJK = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private static readonly CGJHBFGPOOL OHFHPDHGMLC;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public const int JCOCKGOINEB = 0;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public const int EEHIPFHEGAP = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private PropertyEventCallbacksService OBJALHMPDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private global::NNBBLOFFBOH<AuthoredParentData, HDLOBHOIHNH, BAODGLPKBEK, AuthoredChildrenData> NHFJEOKEMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private global::ONBLNDNGCOE<Entity> NAFDIGNBMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private global::ONBLNDNGCOE<float3> MJBDIBLDIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private global::ONBLNDNGCOE<quaternion> BJCEANOAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private global::ONBLNDNGCOE<Entity> ADECAOLBLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private global::ONBLNDNGCOE<float3> LHHNEMEAJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private global::ONBLNDNGCOE<quaternion> FBGPAJBMOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private HashSet<Entity> KMIFGBJDAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private HashSet<Entity> LEGGAOCFHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private EntityQuery NPAEJDGHJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public Func<ODDCBCICFNM> EDJMPJLFAKE
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x66D740", Offset = "0x66C540", VA = "0x18066D740", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0x68EDC0", Offset = "0x68DBC0", VA = "0x18068EDC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM> MEOPOOCHEFC
		{
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x2C34E80", Offset = "0x2C33C80", VA = "0x182C34E80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x2C350E0", Offset = "0x2C33EE0", VA = "0x182C350E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM> GPBFDMJOLDA
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C34550", Offset = "0x2C33350", VA = "0x182C34550", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x2C35A00", Offset = "0x2C34800", VA = "0x182C35A00", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM, PMMHBDBEGAM> KABKMNGALNG
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0x2C35D10", Offset = "0x2C34B10", VA = "0x182C35D10", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0x2C35C70", Offset = "0x2C34A70", VA = "0x182C35C70", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<PMMHBDBEGAM> FCKEPJEGAEI
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x2C35DB0", Offset = "0x2C34BB0", VA = "0x182C35DB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0x2C353E0", Offset = "0x2C341E0", VA = "0x182C353E0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C35180", Offset = "0x2C33F80", VA = "0x182C35180", Slot = "23")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C35510", Offset = "0x2C34310", VA = "0x182C35510", Slot = "24")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C34AF0", Offset = "0x2C338F0", VA = "0x182C34AF0", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C34870", Offset = "0x2C33670", VA = "0x182C34870")]
		private void DDHFANMADGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C343E0", Offset = "0x2C331E0", VA = "0x182C343E0")]
		private void BGIGHDKDABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C34F20", Offset = "0x2C33D20", VA = "0x182C34F20")]
		private void FAKMPPADCJM(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C34A90", Offset = "0x2C33890", VA = "0x182C34A90")]
		private void DOLAONIGMDJ(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x1FFB680", Offset = "0x1FFA480", VA = "0x181FFB680", Slot = "14")]
		public PMMHBDBEGAM BBBMNFOODKF(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x128C450", Offset = "0x128B250", VA = "0x18128C450", Slot = "15")]
		public Color EHCGLGLIIHP(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C34CA0", Offset = "0x2C33AA0", VA = "0x182C34CA0", Slot = "16")]
		public float3 EDBIPCCLEHA(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C35300", Offset = "0x2C34100", VA = "0x182C35300", Slot = "17")]
		public bool JCGFFABNCHF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM FKDHOLGPOMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C34330", Offset = "0x2C33130", VA = "0x182C34330", Slot = "18")]
		public PMMHBDBEGAM AILCCJELIAN(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C35E50", Offset = "0x2C34C50", VA = "0x182C35E50", Slot = "21")]
		public void PKDJCLPCGDK(PMMHBDBEGAM ADGJAILKBPO, Vector3 ONIGPANBOIK, Quaternion INKFPMJDIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C34190", Offset = "0x2C32F90", VA = "0x182C34190", Slot = "26")]
		public (Vector3, Quaternion) ABEECJHILAL(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C348D0", Offset = "0x2C336D0", VA = "0x182C348D0", Slot = "27")]
		public (Vector3, Quaternion) DFMLGPGOEDO(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C35AA0", Offset = "0x2C348A0", VA = "0x182C35AA0", Slot = "22")]
		public (Vector3, Quaternion, bool) LAGGPCHAALA(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C35480", Offset = "0x2C34280", VA = "0x182C35480", Slot = "19")]
		[IteratorStateMachine(typeof(OFDNGLGGDAP))]
		public IEnumerable<PMMHBDBEGAM> KICEPBHGBMN(PMMHBDBEGAM ADGJAILKBPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C34710", Offset = "0x2C33510", VA = "0x182C34710", Slot = "20")]
		public PMMHBDBEGAM DCBCGPDHMLI(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C36070", Offset = "0x2C34E70", VA = "0x182C36070", Slot = "28")]
		public void PPDLNFBKINL(ref List<PMMHBDBEGAM> PNCPJCEBIDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C345F0", Offset = "0x2C333F0", VA = "0x182C345F0")]
		private Entity DCBCGPDHMLI(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C362D0", Offset = "0x2C350D0", VA = "0x182C362D0")]
		public ConnectableService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public struct EMPKMDMEDJP : global::OCGKPONDJPA<EMPKMDMEDJP>, GPAFGALANDE, IEquatable<EMPKMDMEDJP>
{
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly EMPKMDMEDJP JHKNBKMIJJL;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707C20", VA = "0x180708E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707B90", VA = "0x180708D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x85F7F0", Offset = "0x85E5F0", VA = "0x18085F7F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xD8A100", Offset = "0xD88F00", VA = "0x180D8A100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C3CED0", Offset = "0x2C3BCD0", VA = "0x182C3CED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CE80", Offset = "0x2C3BC80", VA = "0x182C3CE80", Slot = "8")]
	public bool Equals(EMPKMDMEDJP HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CF10", Offset = "0x2C3BD10", VA = "0x182C3CF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
public struct NOHNMMEJGLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public EMPKMDMEDJP MIGDJNOKMHC;
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct IEEGJNHOIPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private const int EBIBIOGKCAO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private readonly Stack<HashSet<object>> NFMFOGHBEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private global::OPFKIBDDGAC<EMPKMDMEDJP, HashSet<object>> BNCBNBFPBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x282DC60", Offset = "0x282CA60", VA = "0x18282DC60")]
	public IEEGJNHOIPN(EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x282D7D0", Offset = "0x282C5D0", VA = "0x18282D7D0")]
	public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x282D650", Offset = "0x282C450", VA = "0x18282D650")]
	public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x282D9B0", Offset = "0x282C7B0", VA = "0x18282D9B0")]
	public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x282D9F0", Offset = "0x282C7F0", VA = "0x18282D9F0")]
	public bool JAGDJCPMKBG(EMPKMDMEDJP MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E2")]
	[Cpp2IlInjected.Address(RVA = "0x282DA90", Offset = "0x282C890", VA = "0x18282DA90")]
	public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x282D8D0", Offset = "0x282C6D0", VA = "0x18282D8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x282DB70", Offset = "0x282C970", VA = "0x18282DB70")]
	private void NKCCEGIINBM(HashSet<object> ILPGJLCJEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x282D580", Offset = "0x282C380", VA = "0x18282D580")]
	private bool CLAJAHGNDCP(Entity GEEFHDFLBEH, out EMPKMDMEDJP MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x282DBE0", Offset = "0x282C9E0", VA = "0x18282DBE0")]
	private void ONNCBMCEBOI(Entity GEEFHDFLBEH, EMPKMDMEDJP MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x282D520", Offset = "0x282C320", VA = "0x18282D520")]
	private bool BJEHCIFKJPO(EMPKMDMEDJP FHNOFBNPNEA, out HashSet<object> ILPGJLCJEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x282D910", Offset = "0x282C710", VA = "0x18282D910")]
	private HashSet<object> IGNPALKHEKJ()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	[EBJHGMECDNA(typeof(ObjectEmbodimentService), new string[] { })]
	internal sealed class ObjectEmbodimentService : BGLOBCKLOCO, DFDLCPDHDGP, FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private readonly Dictionary<NMEJDFJAOOA, GIALAGJINEB> LEFBOBIDMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private IJONKAEAEBK NFACINHMFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private PKDAIMBJGBM MIFANJIIOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private FBGPKGAHMCA MMOBPIBHCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private IEEGJNHOIPN EGOIANHHAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private EntityHierarchyChildren FALFIAAPAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TransformOwnershipPhase KDNCNAFJOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x283EBB0", Offset = "0x283D9B0", VA = "0x18283EBB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public int HJDHFKEEIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x283F960", Offset = "0x283E760", VA = "0x18283F960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public int AKKJDCEMEPC
		{
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x2840630", Offset = "0x283F430", VA = "0x182840630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<FEMMDHLANDH> HOEKIBHIEBB
		{
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0x283FEB0", Offset = "0x283ECB0", VA = "0x18283FEB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(RVA = "0x2840650", Offset = "0x283F450", VA = "0x182840650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<FEMMDHLANDH> PKHHOODAJLP
		{
			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0x283D350", Offset = "0x283C150", VA = "0x18283D350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0x283F260", Offset = "0x283E060", VA = "0x18283F260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x283F710", Offset = "0x283E510", VA = "0x18283F710", Slot = "4")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x283EE80", Offset = "0x283DC80", VA = "0x18283EE80", Slot = "5")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x283F720", Offset = "0x283E520", VA = "0x18283F720", Slot = "6")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x283E9D0", Offset = "0x283D7D0", VA = "0x18283E9D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x283FA80", Offset = "0x283E880", VA = "0x18283FA80")]
		public bool MBFENICDONN(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI, out NativeList<Entity> FEGJPLALHAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x283E0C0", Offset = "0x283CEC0", VA = "0x18283E0C0")]
		public global::OHBAMBCHLEK<Entity> CAKLBPIABDK(Allocator JEOILJEOOOI)
		{
			return default(global::OHBAMBCHLEK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x283E100", Offset = "0x283CF00", VA = "0x18283E100")]
		public bool CDOIOEBAIAC(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x283E1D0", Offset = "0x283CFD0", VA = "0x18283E1D0")]
		public bool CECLHLMOAFB(Entity GEEFHDFLBEH, out GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x283E120", Offset = "0x283CF20", VA = "0x18283E120")]
		private bool CECLHLMOAFB(Transform BCHADNCHEKP, out GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x283F380", Offset = "0x283E180", VA = "0x18283F380")]
		internal bool IFBJDDLJDKH(Entity GEEFHDFLBEH, out HDIAJFLHONH DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x283D2B0", Offset = "0x283C0B0", VA = "0x18283D2B0")]
		private void AOPNOMOLIPC(Entity GEEFHDFLBEH, GIALAGJINEB DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x283FC70", Offset = "0x283EA70", VA = "0x18283FC70")]
		private bool MEEOHNLDHKG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x2840CB0", Offset = "0x283FAB0", VA = "0x182840CB0")]
		public void PJHBAIJLMNC(NMEJDFJAOOA DBGIPPEDJIM, GIALAGJINEB FGEIHINONNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x283E240", Offset = "0x283D040", VA = "0x18283E240")]
		public bool CGFONLINMHA(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x283D3F0", Offset = "0x283C1F0", VA = "0x18283D3F0")]
		public bool BHOEHOJGMNO(PMMHBDBEGAM ADGJAILKBPO, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x283DCD0", Offset = "0x283CAD0", VA = "0x18283DCD0")]
		public bool BHOEHOJGMNO(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x283D870", Offset = "0x283C670", VA = "0x18283D870")]
		public bool BHOEHOJGMNO(GIALAGJINEB LFIMBOIOPFD, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x28401A0", Offset = "0x283EFA0", VA = "0x1828401A0")]
		public bool NIMKLNCMIKA(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2840600", Offset = "0x283F400", VA = "0x182840600")]
		public bool NIMKLNCMIKA(GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x283D890", Offset = "0x283C690", VA = "0x18283D890")]
		public bool BHOEHOJGMNO(GIALAGJINEB DNCNJICBAHE, [Optional] object MKDOEIGPNGM, bool EFJKFNKFDIO = false, bool NEGBKBLGNAB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x28406F0", Offset = "0x283F4F0", VA = "0x1828406F0")]
		public Transform OFFKLJGCIOM(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x283ECE0", Offset = "0x283DAE0", VA = "0x18283ECE0")]
		public bool FPFNOLCEKGF(Entity GEEFHDFLBEH, out Transform BCHADNCHEKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x283F990", Offset = "0x283E790", VA = "0x18283F990")]
		public GIALAGJINEB LFOFKHPGLIF(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x283F060", Offset = "0x283DE60", VA = "0x18283F060")]
		public void HKEPNALNJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x283DD20", Offset = "0x283CB20", VA = "0x18283DD20")]
		public void CAANKKMCLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x283F400", Offset = "0x283E200", VA = "0x18283F400")]
		private void JCMLAECOIFB(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x283F330", Offset = "0x283E130", VA = "0x18283F330")]
		public GIALAGJINEB HOAGOKEBLHG(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x283E780", Offset = "0x283D580", VA = "0x18283E780")]
		public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x283E6B0", Offset = "0x283D4B0", VA = "0x18283E6B0")]
		public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x283F980", Offset = "0x283E780", VA = "0x18283F980")]
		public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x283F3B0", Offset = "0x283E1B0", VA = "0x18283F3B0")]
		public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x283F3A0", Offset = "0x283E1A0", VA = "0x18283F3A0")]
		public bool JAGDJCPMKBG(EMPKMDMEDJP MIGDJNOKMHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x283E6C0", Offset = "0x283D4C0", VA = "0x18283E6C0")]
		private void CLPLDICPPAA(bool BDEMLJAFCKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x283FC90", Offset = "0x283EA90", VA = "0x18283FC90")]
		private bool MFHKGCFEGBK(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x283F8F0", Offset = "0x283E6F0", VA = "0x18283F8F0")]
		private GIALAGJINEB KJMFLPPNFBI(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x283FD20", Offset = "0x283EB20", VA = "0x18283FD20")]
		private GIALAGJINEB MPPPPPDCDEK(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x28408E0", Offset = "0x283F6E0", VA = "0x1828408E0")]
		private (Vector3, Quaternion, Vector3) PCNHGAJFKOM(Entity GEEFHDFLBEH)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2840DE0", Offset = "0x283FBE0", VA = "0x182840DE0")]
		private void PNLNEOCBNMO(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2840B00", Offset = "0x283F900", VA = "0x182840B00")]
		private void PIOCBLOBICC(PMMHBDBEGAM ADGJAILKBPO, GIALAGJINEB FGEIHINONNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x283FF50", Offset = "0x283ED50", VA = "0x18283FF50")]
		private void NABOMLEGBEG(GIALAGJINEB DNCNJICBAHE, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x283E790", Offset = "0x283D590", VA = "0x18283E790")]
		private void DMCLGDJIJOA(Entity GEEFHDFLBEH, GIALAGJINEB DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x283EC00", Offset = "0x283DA00", VA = "0x18283EC00")]
		private void FCNAKMLEAJB(Entity GEEFHDFLBEH, Transform BCHADNCHEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x283F300", Offset = "0x283E100", VA = "0x18283F300")]
		private PMMHBDBEGAM HNAKNLCBGOJ(Entity GEEFHDFLBEH)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x28412A0", Offset = "0x28400A0", VA = "0x1828412A0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x283EDB0", Offset = "0x283DBB0", VA = "0x18283EDB0")]
		[CompilerGenerated]
		private void GGDOECEHMDE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal static class DBCLMMKJJBA
{
	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0x2C37D80", Offset = "0x2C36B80", VA = "0x182C37D80")]
	public static GIALAGJINEB LFOFKHPGLIF(this ObjectEmbodimentService KFHKDGFGKJJ, PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[EBJHGMECDNA(typeof(EntityHierarchyChildren), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	internal sealed class EntityHierarchyChildren : FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private FGBIJEJJFBL MAPPBNAKEFG;

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0x2C3F070", Offset = "0x2C3DE70", VA = "0x182C3F070")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F1B0", Offset = "0x2C3DFB0", VA = "0x182C3F1B0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F590", Offset = "0x2C3E390", VA = "0x182C3F590")]
		internal void LPGPGLILELA(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F710", Offset = "0x2C3E510", VA = "0x182C3F710")]
		internal void MAEAMPCOPIO(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FAB0", Offset = "0x2C3E8B0", VA = "0x182C3FAB0")]
		private int NGIIJLPJFKN(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F230", Offset = "0x2C3E030", VA = "0x182C3F230")]
		internal DynamicBuffer<ChildrenData> IBBBKOHNJEB(Entity GEEFHDFLBEH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F300", Offset = "0x2C3E100", VA = "0x182C3F300")]
		internal DynamicBuffer<ChildrenData> INNICMNBKHH(Entity GEEFHDFLBEH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F7E0", Offset = "0x2C3E5E0", VA = "0x182C3F7E0")]
		public NativeArray<Entity> MMEBCOLEPOK(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F3D0", Offset = "0x2C3E1D0", VA = "0x182C3F3D0")]
		public bool JHKJHDCPCPH(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI, out NativeArray<Entity> GDEADEABPNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x2C3EF40", Offset = "0x2C3DD40", VA = "0x182C3EF40")]
		public NativeArray<Entity> DOINHDHLNBE(Entity GEEFHDFLBEH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F9A0", Offset = "0x2C3E7A0", VA = "0x182C3F9A0")]
		public Entity NFFPNEMPLNO(Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F0C0", Offset = "0x2C3DEC0", VA = "0x182C3F0C0")]
		public int HDHNEFAFOAJ(Entity GEEFHDFLBEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[EBJHGMECDNA(typeof(EntityHierarchyEvents), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	internal sealed class EntityHierarchyEvents : FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private ObjectEmbodimentService DNCNJICBAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FD40", Offset = "0x2C3EB40", VA = "0x182C3FD40", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FBF0", Offset = "0x2C3E9F0", VA = "0x182C3FBF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private void HIHKANDABHD(FEMMDHLANDH DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private void OOCJGKPDIGM(FEMMDHLANDH DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private void EHKNKBCLFJE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	[EBJHGMECDNA(typeof(EntityHierarchyParents), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	internal sealed class EntityHierarchyParents : FDFFINEAOHD, CDAFEBOKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private DDPHBMAAHDP JKOOEKEEBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private global::ONBLNDNGCOE<Entity> HLOAMKBCFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private PropertyChangeNetworkRouter DOCHMGEDDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private global::NNBBLOFFBOH<ParentData, HHCGCCCMOPE, KKLIIHKDOLM, ChildrenData> NHFJEOKEMOJ;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2C402D0", Offset = "0x2C3F0D0", VA = "0x182C402D0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2C403F0", Offset = "0x2C3F1F0", VA = "0x182C403F0", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2C40040", Offset = "0x2C3EE40", VA = "0x182C40040")]
		public Entity AILCCJELIAN(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2C40270", Offset = "0x2C3F070", VA = "0x182C40270")]
		public bool FKEELJGEBOF(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x2C40350", Offset = "0x2C3F150", VA = "0x182C40350")]
		public bool JCGFFABNCHF(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ, bool CAMPEPOCDEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x2C40090", Offset = "0x2C3EE90", VA = "0x182C40090")]
		private bool DMPHBHLECHG(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[EBJHGMECDNA(typeof(FGBIJEJJFBL), new string[] { })]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
internal sealed class FGBIJEJJFBL : FDFFINEAOHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class KHFHHBDLGJP : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public FGBIJEJJFBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0x210B480", Offset = "0x210A280", VA = "0x18210B480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0x3607440", Offset = "0x3606240", VA = "0x183607440", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x3603290", Offset = "0x3602090", VA = "0x183603290")]
		[DebuggerHidden]
		public KHFHHBDLGJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x36072B0", Offset = "0x36060B0", VA = "0x1836072B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x3607400", Offset = "0x3606200", VA = "0x183607400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x3607350", Offset = "0x3606150", VA = "0x183607350", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x3607350", Offset = "0x3606150", VA = "0x183607350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class GCOAHNELPOE : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public FGBIJEJJFBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0x210B480", Offset = "0x210A280", VA = "0x18210B480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0x3603160", Offset = "0x3601F60", VA = "0x183603160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x3603290", Offset = "0x3602090", VA = "0x183603290")]
		[DebuggerHidden]
		public GCOAHNELPOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x36031B0", Offset = "0x3601FB0", VA = "0x1836031B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x3602EA0", Offset = "0x3601CA0", VA = "0x183602EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x3603240", Offset = "0x3602040", VA = "0x183603240")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x3603120", Offset = "0x3601F20", VA = "0x183603120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x3603070", Offset = "0x3601E70", VA = "0x183603070", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x3603070", Offset = "0x3601E70", VA = "0x183603070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class HFALFENBENM : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FGBIJEJJFBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0x210B480", Offset = "0x210A280", VA = "0x18210B480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x3603F70", Offset = "0x3602D70", VA = "0x183603F70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x3603290", Offset = "0x3602090", VA = "0x183603290")]
		[DebuggerHidden]
		public HFALFENBENM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x3603FC0", Offset = "0x3602DC0", VA = "0x183603FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x3603B80", Offset = "0x3602980", VA = "0x183603B80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x3604090", Offset = "0x3602E90", VA = "0x183604090")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x36040E0", Offset = "0x3602EE0", VA = "0x1836040E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x3603F30", Offset = "0x3602D30", VA = "0x183603F30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x3603E80", Offset = "0x3602C80", VA = "0x183603E80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x3603E80", Offset = "0x3602C80", VA = "0x183603E80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private EntityHierarchyParents OBEJKCLINIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private EntityHierarchyChildren FALFIAAPAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery NPAEJDGHJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2C42FB0", Offset = "0x2C41DB0", VA = "0x182C42FB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093D")]
	[Cpp2IlInjected.Address(RVA = "0x2C431A0", Offset = "0x2C41FA0", VA = "0x182C431A0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2C42F90", Offset = "0x2C41D90", VA = "0x182C42F90", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2C42B50", Offset = "0x2C41950", VA = "0x182C42B50")]
	public bool BEBDCGNEJPP(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x2C42D20", Offset = "0x2C41B20", VA = "0x182C42D20")]
	public bool BKLGLKDLCLG(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2C43600", Offset = "0x2C42400", VA = "0x182C43600")]
	public IEnumerable<Entity> NJHHOCACKHJ(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x2C43300", Offset = "0x2C42100", VA = "0x182C43300")]
	[IteratorStateMachine(typeof(KHFHHBDLGJP))]
	private IEnumerable<Entity> JFPEENCJEGK(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2C430A0", Offset = "0x2C41EA0", VA = "0x182C430A0")]
	public bool FLMGCLJOAAP(Entity GEEFHDFLBEH, Entity NIPKJIJGCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x2C43180", Offset = "0x2C41F80", VA = "0x182C43180")]
	public bool GOENCLMLMME(Entity GEEFHDFLBEH, Entity PJCDGLCJFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2C43710", Offset = "0x2C42510", VA = "0x182C43710")]
	public IEnumerable<Entity> OEMKFPIEJOP(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2C43000", Offset = "0x2C41E00", VA = "0x182C43000")]
	[IteratorStateMachine(typeof(GCOAHNELPOE))]
	private IEnumerable<Entity> FBIGMHMMJEL(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2C42F10", Offset = "0x2C41D10", VA = "0x182C42F10")]
	[IteratorStateMachine(typeof(HFALFENBENM))]
	private IEnumerable<Entity> DFAOJBFPFIP(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x2C42E30", Offset = "0x2C41C30", VA = "0x182C42E30")]
	public Entity DCBCGPDHMLI(Entity GEEFHDFLBEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x2C43820", Offset = "0x2C42620", VA = "0x182C43820")]
	public NativeArray<Entity> PPDLNFBKINL()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x2C433A0", Offset = "0x2C421A0", VA = "0x182C433A0")]
	public bool MKDAEBPAGML(Entity PJCDGLCJFAM, Entity EJPDMNHPBOC, out Entity CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public FGBIJEJJFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal static class HGHIJDIADBD
{
	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x282A7F0", Offset = "0x28295F0", VA = "0x18282A7F0")]
	public static void JHDCICGDBOE(NativeArray<Entity> OBEJKCLINIG, NativeArray<Entity> FALFIAAPAEL, EntityManager LKEHNCAJHHL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[IFBLAMOEMKH(CMGBDLINHMB.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x30A5A70", Offset = "0x30A4870", VA = "0x1830A5A70")]
		public static void ENJHCNHMIBP<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(FFPEBHHNJFF FJKJAKKFINM, global::NBBJGEJPPKL<Entity> JLHBKPIPBGO, out global::NNBBLOFFBOH<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> PAOPFHIHHOM) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, LJBPPGAHFFJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, LJBPPGAHFFJ, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x2869310", Offset = "0x2868110", VA = "0x182869310")]
		public static bool AJJHCHEFKLC(FEMMDHLANDH LFIMBOIOPFD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
public class NNBBLOFFBOH<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, LJBPPGAHFFJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, LJBPPGAHFFJ, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private static readonly CGJHBFGPOOL LEOCGNJBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private readonly EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private readonly global::ONBLNDNGCOE<Entity> HLOAMKBCFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly CLDGLLOBFOG DBBEFAPFBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly AEFHEEDIBGN ADECAOLBLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly MFLHDAEOBPP IMFCFJELJOA;

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA19A0", Offset = "0x2CA07A0", VA = "0x182CA19A0")]
	public NNBBLOFFBOH(FFPEBHHNJFF FJKJAKKFINM, global::NBBJGEJPPKL<Entity> JLHBKPIPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1290", Offset = "0x2CA0090", VA = "0x182CA1290")]
	private bool PLEKBFHCCPD(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA07D0", Offset = "0x2C9F5D0", VA = "0x182CA07D0")]
	private bool HPNGKKCNHEG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0B60", Offset = "0x2C9F960", VA = "0x182CA0B60")]
	public bool KKFDIADEDKB(Entity GEEFHDFLBEH, in Entity JDMCICBCFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private static void KPJGGNLILMC(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private static void FHBPHLLELDP(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x2CA04E0", Offset = "0x2C9F2E0", VA = "0x182CA04E0")]
	private bool BEBDCGNEJPP(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x2CA05C0", Offset = "0x2C9F3C0", VA = "0x182CA05C0")]
	private void FHIFJDEGHPP(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0820", Offset = "0x2C9F620", VA = "0x182CA0820")]
	private void JCMJBKEMIAG(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0D90", Offset = "0x2C9FB90", VA = "0x182CA0D90")]
	private bool LPNAJKOBPJM(IKKLLNPBAHK NDCABLNNFKI, in NMEJDFJAOOA HOAPGBAADBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2CA06A0", Offset = "0x2C9F4A0", VA = "0x182CA06A0")]
	private void FIGNIJGDPHJ(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1170", Offset = "0x2C9FF70", VA = "0x182CA1170")]
	private void NKNHNPFFGPO(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private void CPDILHHAHEB(Entity GEEFHDFLBEH, Entity POICJGPACMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	private void NIDLIBPLDNN(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[EBJHGMECDNA(typeof(ObjectInstantiationService), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Prefabs)]
	internal sealed class ObjectInstantiationService : FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private HOLDGPOECHF DOBDPEFBFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private ADONFIKCCKK ANKEDBGLNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private ObjectNetworkToLocalMapService DNGOCFEOHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private ObjectLifecycleService NEINDNLHEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private ObjectPrefabs JOIDICOJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private JGLKPBCBPCD BKOBBOPLKAF;

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public int PNKDFLFLNMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0x2841750", Offset = "0x2840550", VA = "0x182841750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x2841360", Offset = "0x2840160", VA = "0x182841360", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x28414C0", Offset = "0x28402C0", VA = "0x1828414C0")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x2841540", Offset = "0x2840340", VA = "0x182841540")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP, NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x2841640", Offset = "0x2840440", VA = "0x182841640")]
		public Entity MHKAFBIPHPF(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x2841770", Offset = "0x2840570", VA = "0x182841770")]
		public Entity PACACJLKIEO(NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x2841350", Offset = "0x2840150", VA = "0x182841350")]
		public Entity HFJOEDICIOL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x2841320", Offset = "0x2840120", VA = "0x182841320")]
		public Entity FECCIBCHBLN()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x2841710", Offset = "0x2840510", VA = "0x182841710")]
		public Entity NOBCDOCLECL(FEJKANODFOG NKICFHCCMMH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x28415E0", Offset = "0x28403E0", VA = "0x1828415E0")]
		public Entity IHEGMFIAJED(EFCIKLEKING NKICFHCCMMH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x2841470", Offset = "0x2840270", VA = "0x182841470")]
		public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
		{
			return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x2841810", Offset = "0x2840610", VA = "0x182841810")]
		public IEnumerable<CBLLNBPHCKJ> PDKEFKCBICH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x2841330", Offset = "0x2840130", VA = "0x182841330")]
		public EntityArchetype FFEHPLPHBKO(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2841620", Offset = "0x2840420", VA = "0x182841620")]
		public Entity IOLGMDLDDIN(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x2841660", Offset = "0x2840460", VA = "0x182841660")]
		private Entity NDGGKFMBDOG(CBLLNBPHCKJ GFIKNFBJKNP, NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[EBJHGMECDNA(typeof(KNJHNLNIBIP), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.Physics)]
	public sealed class PhysicsSceneColliderService : KNJHNLNIBIP, IELCPLOPIMJ, DFDLCPDHDGP, FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private const string JIILKFCDDFC = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private const int NPFCCJEHOFB = -1;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private const int HKFAFMJLFBC = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private PKDAIMBJGBM MIFANJIIOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private Collider[] DBPEFBBOHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private RaycastHit[] CBGLGEGNBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private global::OPFKIBDDGAC<NCGEEIAJEOJ, BoxCollider> FFHHLJJGJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private Scene DBCGBCALMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private PhysicsScene OKKMKGAJAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private GameObject AAICEAICAMA;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public int KHIICLPNKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x2869360", Offset = "0x2868160", VA = "0x182869360", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x286A300", Offset = "0x2869100", VA = "0x18286A300", Slot = "9")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x2869C60", Offset = "0x2868A60", VA = "0x182869C60", Slot = "10")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x28696E0", Offset = "0x28684E0", VA = "0x1828696E0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x28693A0", Offset = "0x28681A0", VA = "0x1828693A0", Slot = "4")]
		public NCGEEIAJEOJ ANGLAMGMPLO(Entity GEEFHDFLBEH)
		{
			return default(NCGEEIAJEOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x28697E0", Offset = "0x28685E0", VA = "0x1828697E0", Slot = "5")]
		public void EKKHEBFMCND(NativeArray<NCGEEIAJEOJ> AGFPEFOAJDF, NativeArray<NMNILGJABIA> HEICMLFEKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x2869610", Offset = "0x2868410", VA = "0x182869610", Slot = "6")]
		public void DHBLDBLJOBK(NCGEEIAJEOJ MIGDJNOKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x2869DA0", Offset = "0x2868BA0", VA = "0x182869DA0", Slot = "7")]
		public bool IAJFOCJNBCA(NCGEEIAJEOJ MIGDJNOKMHC, out Collider JDJCJCADDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x2869E40", Offset = "0x2868C40", VA = "0x182869E40")]
		public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x2869A00", Offset = "0x2868800", VA = "0x182869A00")]
		private void GHANMEIKHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0xC3B3B0", Offset = "0xC3A1B0", VA = "0x180C3B3B0")]
		private void LKLIONOAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x286A470", Offset = "0x2869270", VA = "0x18286A470")]
		private void KCGIMLCGKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xF6DFC0", Offset = "0xF6CDC0", VA = "0x180F6DFC0")]
		private void LJFJDLJMDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x28694F0", Offset = "0x28682F0", VA = "0x1828694F0")]
		private BoxCollider BILPPOGKOPN(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x2869D20", Offset = "0x2868B20", VA = "0x182869D20")]
		private void HHCGJADMOEJ(BoxCollider AGOKDHIHIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x286A150", Offset = "0x2868F50", VA = "0x18286A150")]
		[Conditional("UNITY_EDITOR")]
		private void IGOHFKMBNPC(GameObject BFJMKCMPBKG, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x286A190", Offset = "0x2868F90", VA = "0x18286A190")]
		private void JMHGIBDONMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x286A500", Offset = "0x2869300", VA = "0x18286A500")]
		private void MLCJNMBAIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x2869A50", Offset = "0x2868850", VA = "0x182869A50")]
		private void GOMKMNLDGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x286A610", Offset = "0x2869410", VA = "0x18286A610")]
		private void OOIJGHCNGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x28699F0", Offset = "0x28687F0", VA = "0x1828699F0")]
		private void FFAGAJBIINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x286A4C0", Offset = "0x28692C0", VA = "0x18286A4C0")]
		private void MHJIMLLCPKK(Scene LKJDNOKNMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2869350", Offset = "0x2868150", VA = "0x182869350", Slot = "8")]
		private bool AIPCIMOHECK(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[EBJHGMECDNA(typeof(NKGHFOCFECH), new string[] { })]
public sealed class GMCCOMDABLK : NKGHFOCFECH, FDFFINEAOHD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	private struct OKDMOHDNODB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public float ACDBJHBECNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public uint NDFNJFAPKCG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private IELCPLOPIMJ MDCHDMDOFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private ILPNMBANAND DOGGJPFEOPM;

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2828EB0", Offset = "0x2827CB0", VA = "0x182828EB0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2828F20", Offset = "0x2827D20", VA = "0x182828F20")]
	public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, out LAGADACOOOP PEIHFKCOJDK, out Entity GOCCFAICBMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2828DB0", Offset = "0x2827BB0", VA = "0x182828DB0")]
	public static bool GJAKEOAPIFJ(in Span<LAGADACOOOP> ENFPPCCMHCG, float JEIPODGPOFH, out int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x28293A0", Offset = "0x28281A0", VA = "0x1828293A0")]
	public static float MMELGNPDJMN(float ACDBJHBECNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public GMCCOMDABLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2828DA0", Offset = "0x2827BA0", VA = "0x182828DA0", Slot = "4")]
	private bool EPIBGFALCPB(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, out LAGADACOOOP PEIHFKCOJDK, out Entity GOCCFAICBMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[EBJHGMECDNA(typeof(ILPNMBANAND), new string[] { })]
public sealed class FNEJDFJNBNC : ILPNMBANAND, FDFFINEAOHD
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[BurstCompile]
	private struct LMBAEKFAPPD : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		[ReadOnly]
		public NativeArray<Entity> FBMJMNCDHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		[ReadOnly]
		public float3 HKLGJBALGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		[ReadOnly]
		public float3 LIMDOIGEJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> DCIHBCMAMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> PJFDNFCKIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> DFBLOLNPNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		[WriteOnly]
		public NativeArray<LAGADACOOOP> FHNGOIIKONC;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private static readonly LAGADACOOOP COKEECJOHCL;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x3607D50", Offset = "0x3606B50", VA = "0x183607D50", Slot = "4")]
		public void Execute(int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x3607C80", Offset = "0x3606A80", VA = "0x183607C80")]
		private static float3 EPBEPIAADBN(in float4x4 JDJKNCCKKMA, in float3 JOLHNMOCKDJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x3608030", Offset = "0x3606E30", VA = "0x183608030")]
		private static float3 KHIMFCKDMNI(in float4x4 JDJKNCCKKMA, in float3 NAGBPGCPEDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x36088C0", Offset = "0x36076C0", VA = "0x1836088C0")]
		private static float3 LOOFFKKDFMB(in float4x4 JDJKNCCKKMA, in float3 JOLHNMOCKDJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x3608CC0", Offset = "0x3607AC0", VA = "0x183608CC0")]
		private static float3 NFEOPCKOOAA(in float4x4 JDJKNCCKKMA, in float3 NAGBPGCPEDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x36089C0", Offset = "0x36077C0", VA = "0x1836089C0")]
		private bool MOMMEFDGJGO(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<Entity> CNEMJNCMMKA, out float3 PEIHFKCOJDK, out float3 BJLFJKGMNHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x36081F0", Offset = "0x3606FF0", VA = "0x1836081F0")]
		public static bool KJBDHLGAJIO(in float3 EENGOCNGPNB, in float3 DCOMCKGCKBH, in float3 PAOFDIIDBMK, in float3 JCOAFPHKEFN, float IADELNJNICE, float GIDFBHLFDCN, out float MGEGOIPHNMM, out float3 JLKDEHPMNLG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2827420", Offset = "0x2826220", VA = "0x182827420", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x28274A0", Offset = "0x28262A0", VA = "0x1828274A0")]
	public void IGDPCCPOHMI(in NativeArray<Entity> FBMJMNCDHDM, in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<LAGADACOOOP> CLHAIOKMEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public FNEJDFJNBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x28274A0", Offset = "0x28262A0", VA = "0x1828274A0", Slot = "4")]
	private void IMFKKNMDJCL(in NativeArray<Entity> FBMJMNCDHDM, in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<LAGADACOOOP> CLHAIOKMEPP)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Lifecycle)]
	[EBJHGMECDNA(typeof(ObjectLifecycleService), new string[] { })]
	internal sealed class ObjectLifecycleService : FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private ObjectEmbodimentService DNCNJICBAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private ObjectNetworkToLocalMapService DNGOCFEOHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private EntityHierarchyChildren FALFIAAPAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private FGBIJEJJFBL MAPPBNAKEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EntityHierarchyParents OBEJKCLINIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private FOLBJCBGIIH OLOICGJGAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x2841E70", Offset = "0x2840C70", VA = "0x182841E70")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Entity, CBLLNBPHCKJ> PENFFKIPBOK
		{
			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x28421D0", Offset = "0x2840FD0", VA = "0x1828421D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x2841DD0", Offset = "0x2840BD0", VA = "0x182841DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Entity> NNDDOAEECDO
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x28420C0", Offset = "0x2840EC0", VA = "0x1828420C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x2841EC0", Offset = "0x2840CC0", VA = "0x182841EC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2841F60", Offset = "0x2840D60", VA = "0x182841F60", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0xFB9C40", Offset = "0xFB8A40", VA = "0x180FB9C40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2841A20", Offset = "0x2840820", VA = "0x182841A20")]
		public bool AEBBOEKMPNE(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x28423C0", Offset = "0x28411C0", VA = "0x1828423C0")]
		internal void MDCLCNEPJCC(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2841CC0", Offset = "0x2840AC0", VA = "0x182841CC0")]
		public void CHMNDPKCMOJ(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2841880", Offset = "0x2840680", VA = "0x182841880")]
		public void ACKFNLGGLJE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2842270", Offset = "0x2841070", VA = "0x182842270")]
		private bool KNCDHIHBFDG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2842680", Offset = "0x2841480", VA = "0x182842680")]
		public void NONGHDEHHOE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2841DA0", Offset = "0x2840BA0", VA = "0x182841DA0")]
		private void ELCHMDLCCOO(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2842420", Offset = "0x2841220", VA = "0x182842420")]
		private void MLDIKEFLBDK(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2841A90", Offset = "0x2840890", VA = "0x182841A90")]
		public void ANPFAIODGJP(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2842160", Offset = "0x2840F60", VA = "0x182842160")]
		private void IOMGEBLBJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2842760", Offset = "0x2841560", VA = "0x182842760")]
		private void PFBEKIDPBBJ(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[IFBLAMOEMKH(CMGBDLINHMB.Embodiment)]
	[EBJHGMECDNA(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : FDFFINEAOHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private NativeHashMap<NMEJDFJAOOA, Entity> CJKCJJEOEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private CBIPFLGDJEF NBLKNAFAMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private EntityManager LKEHNCAJHHL;

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		internal NativeHashMap<NMEJDFJAOOA, Entity> OIPFJLJMGIK
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0")]
			get
			{
				return default(NativeHashMap<NMEJDFJAOOA, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x2864A20", Offset = "0x2863820", VA = "0x182864A20", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x28647C0", Offset = "0x28635C0", VA = "0x1828647C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x2864B20", Offset = "0x2863920", VA = "0x182864B20")]
		private PMMHBDBEGAM HNAKNLCBGOJ(Entity GEEFHDFLBEH)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2864940", Offset = "0x2863740", VA = "0x182864940")]
		public PMMHBDBEGAM GJELMEFNGNA(NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x28648B0", Offset = "0x28636B0", VA = "0x1828648B0")]
		public NMEJDFJAOOA GAGENPHPDNI(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(NMEJDFJAOOA);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x2864820", Offset = "0x2863620", VA = "0x182864820")]
		public void EJEGPNOCOKC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x2864700", Offset = "0x2863500", VA = "0x182864700")]
		public void ABMEIFNFFHC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x2864760", Offset = "0x2863560", VA = "0x182864760")]
		public void CDADDOFNGMF(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x2864B50", Offset = "0x2863950", VA = "0x182864B50")]
		public void JPHKACHFAFL(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[IFBLAMOEMKH(CMGBDLINHMB.Callbacks)]
	[EBJHGMECDNA(typeof(PropertyEventCallbacksService), new string[] { })]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	public class PropertyEventCallbacksService : FDFFINEAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x2000179")]
		private struct DCHLEFALAMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public PDEHMHFLINN GKAOJENLDLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public Type NKICFHCCMMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public int MNKEEJPGFOP;
		}

		[Cpp2IlInjected.Token(Token = "0x200017A")]
		private struct PMOFFFGGJHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public DCHLEFALAMC[] GMKKBMEMHOP;
		}

		[Cpp2IlInjected.Token(Token = "0x200017B")]
		public delegate void PDEHMHFLINN(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP);

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private readonly Dictionary<JLCDNMLCNEN, PDEHMHFLINN> LMCPFDKFLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly Dictionary<int, PMOFFFGGJHG> OGKAHIOEBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private GNLAPDIIDJD GMKKBMEMHOP;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action DLAHLFPKNNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x28708F0", Offset = "0x286F6F0", VA = "0x1828708F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x286FF00", Offset = "0x286ED00", VA = "0x18286FF00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action JHLJECICLDM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0x2870220", Offset = "0x286F020", VA = "0x182870220")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x286FA90", Offset = "0x286E890", VA = "0x18286FA90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x286FEB0", Offset = "0x286ECB0", VA = "0x18286FEB0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x2870990", Offset = "0x286F790", VA = "0x182870990")]
		public void PJHBAIJLMNC(JLCDNMLCNEN ABEODFEGJBP, PDEHMHFLINN GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x286FDC0", Offset = "0x286EBC0", VA = "0x18286FDC0")]
		public void GGCGIGPFIFL(JLCDNMLCNEN ABEODFEGJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x286FB30", Offset = "0x286E930", VA = "0x18286FB30")]
		internal void FHDIKKJPLIH(ENNNNIELFIE PBHDPEJBGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x28703B0", Offset = "0x286F1B0", VA = "0x1828703B0")]
		private void OIBABOHHOLL(ENNNNIELFIE PBHDPEJBGCP, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x286FFA0", Offset = "0x286EDA0", VA = "0x18286FFA0")]
		private void MDLNEFCJMKP(EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ, DCHLEFALAMC JNJBGLDKDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x2870B00", Offset = "0x286F900", VA = "0x182870B00")]
		private PMOFFFGGJHG PKOKBHBEBMA(EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ)
		{
			return default(PMOFFFGGJHG);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x28702C0", Offset = "0x286F0C0", VA = "0x1828702C0")]
		private DCHLEFALAMC NEENEBAPNFF(PMOFFFGGJHG OHDDMIOPOFC, EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ)
		{
			return default(DCHLEFALAMC);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x2870CD0", Offset = "0x286FAD0", VA = "0x182870CD0")]
		public PropertyEventCallbacksService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[LFOIMLBAPLC(typeof(PropertyDiffStateService))]
	[EBJHGMECDNA(typeof(OOGJNFIJHKM), new string[] { })]
	[IFBLAMOEMKH(CMGBDLINHMB.PropertyChanges)]
	internal class PropertyDiffStateService : FDFFINEAOHD, CDAFEBOKDJF, OOGJNFIJHKM, ENNNNIELFIE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private readonly List<KGFPMIPOKMG> CMONDGCDAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private EHIDJEIAFME CANCHCAFIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private ObjectInstantiationService JOIDICOJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private KHMLGNFANIM OGMAGPEPNJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private FLHBGDILJIB MOLNMFIKIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private KHFNLIHOAGK CMAOMHCKFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private NativeMultiHashMap<Entity, OJINANPDCIH> OBKNHCLLMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private NativeHashMap<int, int> KGFFLOAPJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private JobHandle FIOOOJDOILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private JobHandle CHHFKDPPCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private bool NNFHDNBGFFL;

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public bool EPOFMKLFDDF
		{
			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0x286F010", Offset = "0x286DE10", VA = "0x18286F010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		private World CDCACCPAOCG
		{
			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0x286E9D0", Offset = "0x286D7D0", VA = "0x18286E9D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		private KHMLGNFANIM LDGABFOLHPO
		{
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		private FLHBGDILJIB AEBPELGCMAE
		{
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private NativeMultiHashMap<Entity, OJINANPDCIH> KIMKKCDAMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0xF41BC0", Offset = "0xF409C0", VA = "0x180F41BC0", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, OJINANPDCIH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		private JobHandle KGPNKIOBFAK
		{
			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC970", Offset = "0x7AB770", VA = "0x1807AC970", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xE17EB0", Offset = "0xE16CB0", VA = "0x180E17EB0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		private World FHMGFHBGODL
		{
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0x286F870", Offset = "0x286E670", VA = "0x18286F870", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0x286F470", Offset = "0x286E270", VA = "0x18286F470", Slot = "13")]
		private void KAGLHGCNNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x286EF40", Offset = "0x286DD40", VA = "0x18286EF40", Slot = "12")]
		private bool EJMMANHCLCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x286F8D0", Offset = "0x286E6D0", VA = "0x18286F8D0", Slot = "14")]
		private void OILCIAOINAE(ComponentType MOBCJNJMMEJ, in KGFPMIPOKMG CKIPEJKPEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x286EA30", Offset = "0x286D830", VA = "0x18286EA30", Slot = "15")]
		private bool BDCPHGNPOML(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x286EE30", Offset = "0x286DC30", VA = "0x18286EE30", Slot = "17")]
		private bool DGCDCNDHLEP(out NativeArray<int> GIFGJKHKEEO, Allocator JEOILJEOOOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x286ECC0", Offset = "0x286DAC0", VA = "0x18286ECC0", Slot = "18")]
		private bool CDGHKHDPJDF(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM, out OOPIHDDHHBC OHDDMIOPOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x286EB90", Offset = "0x286D990", VA = "0x18286EB90", Slot = "19")]
		private bool CDGHKHDPJDF(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x286F020", Offset = "0x286DE20", VA = "0x18286F020", Slot = "20")]
		private KGFPMIPOKMG FOCBFEBAJIA(ComponentType MOBCJNJMMEJ)
		{
			return default(KGFPMIPOKMG);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x286F430", Offset = "0x286E230", VA = "0x18286F430", Slot = "21")]
		private IDJKLEJHIMN JJLGELLAIAH()
		{
			return default(IDJKLEJHIMN);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x286F480", Offset = "0x286E280", VA = "0x18286F480", Slot = "22")]
		private void KFPANNFHALE(JobHandle AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0x286F110", Offset = "0x286DF10", VA = "0x18286F110", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x286F4C0", Offset = "0x286E2C0", VA = "0x18286F4C0", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x286EED0", Offset = "0x286DCD0", VA = "0x18286EED0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x286F180", Offset = "0x286DF80", VA = "0x18286F180")]
		private void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x286F650", Offset = "0x286E450", VA = "0x18286F650")]
		private bool KPPCAAEGNKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x286EA50", Offset = "0x286D850", VA = "0x18286EA50")]
		private int BKKNNDPJILH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x286FA10", Offset = "0x286E810", VA = "0x18286FA10")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[EBJHGMECDNA(typeof(BPHIPABMBKD), new string[] { })]
public class DNANFJBCKGI : FDFFINEAOHD, CDAFEBOKDJF, BPHIPABMBKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class DPHJPJNOBMC : IEnumerable<KBKPPGIKIHI>, IEnumerable, IEnumerator<KBKPPGIKIHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private KBKPPGIKIHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public DNANFJBCKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private GINMLCILJIO spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public GINMLCILJIO <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		private KBKPPGIKIHI System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KBKPPGIKIHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x3601520", Offset = "0x3600320", VA = "0x183601520", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x9DE010", Offset = "0x9DCE10", VA = "0x1809DE010")]
		[DebuggerHidden]
		public DPHJPJNOBMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x3601330", Offset = "0x3600130", VA = "0x183601330", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x36014E0", Offset = "0x36002E0", VA = "0x1836014E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x3601430", Offset = "0x3600230", VA = "0x183601430", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KBKPPGIKIHI> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x3601430", Offset = "0x3600230", VA = "0x183601430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private BKDDNHHHPLM ELCOJELDKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private ObjectInstantiationService JOIDICOJLFD;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2C39E30", Offset = "0x2C38C30", VA = "0x182C39E30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2C39970", Offset = "0x2C38770", VA = "0x182C39970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A140", Offset = "0x2C38F40", VA = "0x182C3A140", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A530", Offset = "0x2C39330", VA = "0x182C3A530", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x2C39AE0", Offset = "0x2C388E0", VA = "0x182C39AE0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x2C39B90", Offset = "0x2C38990", VA = "0x182C39B90")]
	private void EICDFLNDJBL(Entity GOLAIHPPLOC, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A010", Offset = "0x2C38E10", VA = "0x182C3A010", Slot = "12")]
	public GINMLCILJIO FECCIBCHBLN()
	{
		return default(GINMLCILJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A1B0", Offset = "0x2C38FB0", VA = "0x182C3A1B0", Slot = "6")]
	public KBKPPGIKIHI IJFDDHEFOFO(GINMLCILJIO FHFFEBCPBGH, [Optional] Vector3? EIIEKPIPEEF, [Optional] Quaternion? DCNMMHNEEEM, [Optional] Vector3? AONBKNJBIIA)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A460", Offset = "0x2C39260", VA = "0x182C3A460", Slot = "13")]
	public KBKPPGIKIHI JMLJEPFIPII(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ, [Optional] Vector3? EIIEKPIPEEF, [Optional] Quaternion? DCNMMHNEEEM, [Optional] Vector3? AONBKNJBIIA)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A6C0", Offset = "0x2C394C0", VA = "0x182C3A6C0", Slot = "7")]
	public KBKPPGIKIHI NJFFFBEOAPH(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A0B0", Offset = "0x2C38EB0", VA = "0x182C3A0B0", Slot = "14")]
	public void FPKPDGILOEA(GINMLCILJIO FHFFEBCPBGH, KBKPPGIKIHI IJKNBPEODEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A7D0", Offset = "0x2C395D0", VA = "0x182C3A7D0", Slot = "8")]
	public void NJOOFBGDBOP(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x2C39E80", Offset = "0x2C38C80", VA = "0x182C39E80", Slot = "15")]
	public void FBLDKFMNKLA(GINMLCILJIO FHFFEBCPBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A630", Offset = "0x2C39430", VA = "0x182C3A630", Slot = "9")]
	public int NDMAOJDGOIJ(GINMLCILJIO FHFFEBCPBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A4A0", Offset = "0x2C392A0", VA = "0x182C3A4A0", Slot = "10")]
	[IteratorStateMachine(typeof(DPHJPJNOBMC))]
	public IEnumerable<KBKPPGIKIHI> JONBNEOMLDM(GINMLCILJIO FHFFEBCPBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x2C398F0", Offset = "0x2C386F0", VA = "0x182C398F0")]
	private bool CEMJEJEEHLM(GINMLCILJIO FHFFEBCPBGH, out NativeArray<Entity> FALFIAAPAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x2C39A30", Offset = "0x2C38830", VA = "0x182C39A30")]
	private NativeArray<Entity> DDIENHKLDME(GINMLCILJIO FHFFEBCPBGH)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public DNANFJBCKGI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[IFBLAMOEMKH(CMGBDLINHMB.ComponentSystemTypes)]
	[JAPBKNDOGGF(typeof(GALJPCEPKLP))]
	[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
	[EBJHGMECDNA(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : FDFFINEAOHD, CDAFEBOKDJF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private static readonly CGJHBFGPOOL LEOCGNJBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private EHIDJEIAFME HADAJAKADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private CLDGLLOBFOG MAPPBNAKEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private Entity GEEFHDFLBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private AMFJBNENFOE CGPLPFBCOHF;

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0x2875920", Offset = "0x2874720", VA = "0x182875920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public Entity MINMLEDGPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x2875860", Offset = "0x2874660", VA = "0x182875860")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		public T BOPAOPJOHPG<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		public void PIGMJENILDA<T>(T IGJPNMBCJPK) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x28758B0", Offset = "0x28746B0", VA = "0x1828758B0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2875930", Offset = "0x2874730", VA = "0x182875930", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2875930", Offset = "0x2874730", VA = "0x182875930")]
		private void POCLKGKAOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2875730", Offset = "0x2874530", VA = "0x182875730", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2875B80", Offset = "0x2874980", VA = "0x182875B80")]
		private void NAHHLBGMLLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x2875BE0", Offset = "0x28749E0", VA = "0x182875BE0")]
		private AMFJBNENFOE NCHIKKFEHMO()
		{
			return default(AMFJBNENFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private static void GGNCAOJPKHM(int KOHJDBBJEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
		private static void EIHGDBDAHDH(Type NKICFHCCMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2875AA0", Offset = "0x28748A0", VA = "0x182875AA0")]
		private static void LOJMGLBFGPE(Type NKICFHCCMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct GBEAIPCECGN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[BPIBJJPJLCE(EEJHBIOBFFI.LoadInstance)]
[EBJHGMECDNA(typeof(KDMAIHKHEJC), new string[] { })]
internal sealed class KDMAIHKHEJC : FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private EHIDJEIAFME HADAJAKADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private TransformOwnershipPhase EAFMNNJDDKC;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private PGLNEDJDCBK NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x2830DC0", Offset = "0x282FBC0", VA = "0x182830DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x2830F00", Offset = "0x282FD00", VA = "0x182830F00", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x2830E10", Offset = "0x282FC10", VA = "0x182830E10")]
	public void CHDHGKDAAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x2830F80", Offset = "0x282FD80", VA = "0x182830F80")]
	public void IBCENBBDMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KDMAIHKHEJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[DefaultMember("Item")]
public struct MFEBELNBKCH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private T[] JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private int GKPOMAIMOAK;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x85F7C0", Offset = "0x85E5C0", VA = "0x18085F7C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D850", Offset = "0x2E4C650", VA = "0x182E4D850")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Span<T> MPPABPEGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x2E4D640", Offset = "0x2E4C440", VA = "0x182E4D640")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D00", Offset = "0x8C4B00", VA = "0x1808C5D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D890", Offset = "0x2E4C690", VA = "0x182E4D890")]
	public MFEBELNBKCH(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D7A0", Offset = "0x2E4C5A0", VA = "0x182E4D7A0")]
	public int FKENAIAHEAH(T IGJPNMBCJPK, int FOACNEHDHLI, int KOHJDBBJEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D6E0", Offset = "0x2E4C4E0", VA = "0x182E4D6E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[DefaultMember("Item")]
public struct EEHAAMAOJOL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private global::MFEBELNBKCH<T> JANIFNADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private int GKPOMAIMOAK;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5090", Offset = "0x1AC3E90", VA = "0x181AC5090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x655E40", VA = "0x180657040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5490", Offset = "0x1AC4290", VA = "0x181AC5490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5120", Offset = "0x1AC3F20", VA = "0x181AC5120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5150", Offset = "0x1AC3F50", VA = "0x181AC5150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC53E0", Offset = "0x1AC41E0", VA = "0x181AC53E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Span<T> MPPABPEGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3C20", Offset = "0x1AC2A20", VA = "0x181AC3C20")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x1AC55C0", Offset = "0x1AC43C0", VA = "0x181AC55C0")]
	public EEHAAMAOJOL(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4D00", Offset = "0x1AC3B00", VA = "0x181AC4D00")]
	public T IGMIKAKFNBO(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x1AC5420", Offset = "0x1AC4220", VA = "0x181AC5420")]
	public void OMAKEOAANBD(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4360", Offset = "0x1AC3160", VA = "0x181AC4360")]
	public void FFDHMAEECPB(Span<T> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4830", Offset = "0x1AC3630", VA = "0x181AC4830")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x1AC41E0", Offset = "0x1AC2FE0", VA = "0x181AC41E0")]
	private void EEGKOIJBHKM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x1AC51A0", Offset = "0x1AC3FA0", VA = "0x181AC51A0")]
	public void MBOIAEPEMME(Span<T> JJDMEICMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4940", Offset = "0x1AC3740", VA = "0x181AC4940")]
	public void HGIANMDOCHF(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4AE0", Offset = "0x1AC38E0", VA = "0x181AC4AE0")]
	public void IAAJAJFGFOI(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x1AC45C0", Offset = "0x1AC33C0", VA = "0x181AC45C0")]
	public void GEPHADMCPNH(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4620", Offset = "0x1AC3420", VA = "0x181AC4620")]
	public void GIBODEFMDLL(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x1AC3E30", Offset = "0x1AC2C30", VA = "0x181AC3E30")]
	public void BGHIEJLNECC(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x1AC3D70", Offset = "0x1AC2B70", VA = "0x181AC3D70")]
	public void BBOHILHOBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x1AC44D0", Offset = "0x1AC32D0", VA = "0x181AC44D0")]
	public int FKENAIAHEAH(T IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4560", Offset = "0x1AC3360", VA = "0x181AC4560")]
	public bool FKLGFCOHCLF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4190", Offset = "0x1AC2F90", VA = "0x181AC4190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x1AC5550", Offset = "0x1AC4350", VA = "0x181AC5550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x1AC54E0", Offset = "0x1AC42E0", VA = "0x181AC54E0")]
	public static Span<T> PAAEKNCKHBI(global::EEHAAMAOJOL<T> LPDILHBGHIJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x1AC49A0", Offset = "0x1AC37A0", VA = "0x181AC49A0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HNMIBHLBDII(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void DCNMPGGEHFJ(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4030", Offset = "0x1AC2E30", VA = "0x181AC4030")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void DCNMPGGEHFJ(int GKPOMAIMOAK, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4F50", Offset = "0x1AC3D50", VA = "0x181AC4F50")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JFHKONJONGN(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4D50", Offset = "0x1AC3B50", VA = "0x181AC4D50")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void IKHHFLADOBF(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x1AC3EF0", Offset = "0x1AC2CF0", VA = "0x181AC3EF0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void BNEPCCGICDC(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public struct OCGCGAIFBCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private const int GCKDIBNBCAH = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private NativeList<Entity> FBMJMNCDHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private TransformAccessArray JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x283B8F0", Offset = "0x283A6F0", VA = "0x18283B8F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NativeList<Entity> FKGLBEIKFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xD48F40", Offset = "0xD47D40", VA = "0x180D48F40")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public TransformAccessArray MIBENKEEEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x283B9C0", Offset = "0x283A7C0", VA = "0x18283B9C0")]
	public OCGCGAIFBCP(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x283B710", Offset = "0x283A510", VA = "0x18283B710")]
	public Entity FHABAEEIJEG(int AIPHGHFENPJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x283B680", Offset = "0x283A480", VA = "0x18283B680")]
	public Transform AGDAIJOCIIH(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x283B970", Offset = "0x283A770", VA = "0x18283B970")]
	public void OCPJNJBCKID(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x283B900", Offset = "0x283A700", VA = "0x18283B900")]
	public void KAJJOIIPMBP(int ALHAMICPFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x283B7A0", Offset = "0x283A5A0", VA = "0x18283B7A0")]
	public int HEFJCCLOLGO(Transform BCHADNCHEKP, Entity GEEFHDFLBEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x283B870", Offset = "0x283A670", VA = "0x18283B870")]
	public int HGIANMDOCHF(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x283B690", Offset = "0x283A490", VA = "0x18283B690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x283B760", Offset = "0x283A560", VA = "0x18283B760")]
	private void FNBNOKMLGIF(int DCJPACPBNKG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class KGDDGEFLMIG : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly KGDDGEFLMIG FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x2831410", Offset = "0x2830210", VA = "0x182831410", Slot = "4")]
	public bool Equals(LinkedEntityGroup KNMKEOOODCL, LinkedEntityGroup EMKKILCIAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2831430", Offset = "0x2830230", VA = "0x182831430", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup CCPIHKCBGHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public KGDDGEFLMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class IGLJAEKGNEC
{
	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void LNDIKNLGIEH(in Vector3 EIIEKPIPEEF, in Quaternion DCNMMHNEEEM, in Vector3 AONBKNJBIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void NHIEEINNCGK(in Vector3 FKJNMOFLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void DNCOFNHLFPC(in Quaternion DCNMMHNEEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BMHDOAFDPBP(in Vector3 FBANICEIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void MDDHPCEHPAL(in Vector3 FBANICEIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void JCHLNHFKDOP(in float PJFFAKJCJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x282DD40", Offset = "0x282CB40", VA = "0x18282DD40")]
	[Conditional("DEBUG_BUILD")]
	public static void AGDNCCDMFDB(in float3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in float IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x282DE20", Offset = "0x282CC20", VA = "0x18282DE20")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in Vector3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x282DDF0", Offset = "0x282CBF0", VA = "0x18282DDF0")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in Quaternion IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x282DEB0", Offset = "0x282CCB0", VA = "0x18282DEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in float IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x282DE70", Offset = "0x282CC70", VA = "0x18282DE70")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in Vector3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x282DEC0", Offset = "0x282CCC0", VA = "0x18282DEC0")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in Quaternion IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public IGLJAEKGNEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public struct FDCGJNDCDCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public Entity GEEFHDFLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Entity POICJGPACMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Entity JDMCICBCFIJ;

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x2C42B40", Offset = "0x2C41940", VA = "0x182C42B40")]
	public FDCGJNDCDCD(Entity GEEFHDFLBEH, Entity POICJGPACMK, Entity JDMCICBCFIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2C42AE0", Offset = "0x2C418E0", VA = "0x182C42AE0")]
	public static FDCGJNDCDCD PAAEKNCKHBI((Entity entity, Entity oldParent, Entity newParent) HBFAFBABGFI)
	{
		return default(FDCGJNDCDCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2C42B20", Offset = "0x2C41920", VA = "0x182C42B20")]
	public void PIELOEDOOJA(out Entity GEEFHDFLBEH, out Entity POICJGPACMK, out Entity JDMCICBCFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public struct MIFKFPHADFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public Entity GEEFHDFLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public Entity ADECAOLBLPJ;

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xD8EF70", Offset = "0xD8DD70", VA = "0x180D8EF70")]
	public MIFKFPHADFM(Entity GEEFHDFLBEH, Entity ADECAOLBLPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x2838B40", Offset = "0x2837940", VA = "0x182838B40")]
	public static MIFKFPHADFM PAAEKNCKHBI((Entity entity, Entity parent) HBFAFBABGFI)
	{
		return default(MIFKFPHADFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x2838B70", Offset = "0x2837970", VA = "0x182838B70")]
	public void PIELOEDOOJA(out Entity GEEFHDFLBEH, out Entity ADECAOLBLPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
public struct FIGGIAMEMEL<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private GCHandle MIGDJNOKMHC;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool PDJPNKJGJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x26689E0", Offset = "0x26677E0", VA = "0x1826689E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x2668A20", Offset = "0x2667820", VA = "0x182668A20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x2668920", Offset = "0x2667720", VA = "0x182668920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x2668AC0", Offset = "0x26678C0", VA = "0x182668AC0")]
	public FIGGIAMEMEL(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x26689F0", Offset = "0x26677F0", VA = "0x1826689F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[EBJHGMECDNA(typeof(IELCPLOPIMJ), new string[] { })]
public sealed class HENNBGFOJIG : IELCPLOPIMJ, FDFFINEAOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private KNJHNLNIBIP LJDEGJIIHEO;

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x282A7A0", Offset = "0x28295A0", VA = "0x18282A7A0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x282A700", Offset = "0x2829500", VA = "0x18282A700")]
	public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public HENNBGFOJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x282A700", Offset = "0x2829500", VA = "0x18282A700", Slot = "4")]
	private bool AIPCIMOHECK(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EHOCPENPMLI))]
public sealed class GMIMCOGLPJE : PLPPACFFCAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public GMIMCOGLPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EHOCPENPMLI))]
[UpdateAfter(typeof(GMIMCOGLPJE))]
public sealed class IJOIPEJPICK : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x282E380", Offset = "0x282D180", VA = "0x18282E380")]
	public IJOIPEJPICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(IJOIPEJPICK))]
[UpdateInGroup(typeof(EHOCPENPMLI))]
public sealed class CLFNFKBCGBM : AMAAPGIIJHF
{
	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public CLFNFKBCGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EADAPMIJCBG))]
public class LCBHOHHGHKC : PFEBNMLDBNN
{
	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public LCBHOHHGHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x2836780", Offset = "0x2835580", VA = "0x182836780", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EADAPMIJCBG))]
public class GMEILMIGPCC : OJGBHFKCJPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public GMEILMIGPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(EADAPMIJCBG))]
public class INIBCJCKAJO : OHMOPMJJDKB
{
	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public INIBCJCKAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x282E3E0", Offset = "0x282D1E0", VA = "0x18282E3E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(CNDMKJANPBA))]
public sealed class CECHAALAEKE : LFLBNLDBEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E690", Offset = "0x2C2D490", VA = "0x182C2E690")]
	public CECHAALAEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E680", Offset = "0x2C2D480", VA = "0x182C2E680", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(CDBKMKJLKKC))]
internal class CKKALKMOKJO : FPDBMMINPKE
{
	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public CKKALKMOKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F6C0", Offset = "0x2C2E4C0", VA = "0x182C2F6C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(DNGIILCGBEO))]
internal sealed class FKMLGBNBFBP : LCICNAGLPHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public FKMLGBNBFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x2826840", Offset = "0x2825640", VA = "0x182826840", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(FKMLGBNBFBP))]
[UpdateInGroup(typeof(DNGIILCGBEO))]
internal class BKGKPEPJGBD : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E280", Offset = "0x2C2D080", VA = "0x182C2E280")]
	public BKGKPEPJGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E270", Offset = "0x2C2D070", VA = "0x182C2E270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[AlwaysUpdateSystem]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(DNGIILCGBEO))]
[UpdateAfter(typeof(BKGKPEPJGBD))]
internal sealed class JJDKNFOLILB : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	protected override ApplyPropertyDifferences ENAAOEAAPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x2830A90", Offset = "0x282F890", VA = "0x182830A90", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x2830AE0", Offset = "0x282F8E0", VA = "0x182830AE0")]
	public JJDKNFOLILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(JJDKNFOLILB))]
[UpdateInGroup(typeof(DNGIILCGBEO))]
internal sealed class GEBOIHKOPFE : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x2828580", Offset = "0x2827380", VA = "0x182828580")]
	public GEBOIHKOPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(DNGIILCGBEO))]
[UpdateAfter(typeof(JJDKNFOLILB))]
internal sealed class AMECLKKDJMI : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public AMECLKKDJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class GACJCKKDMNG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public GACJCKKDMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class ECEGKIHDGFD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public ECEGKIHDGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
[UpdateAfter(typeof(GACJCKKDMNG))]
internal sealed class NENDFNPOJPJ : FBGPKGAHMCA
{
	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public NENDFNPOJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateAfter(typeof(NENDFNPOJPJ))]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal sealed class MLBONNHEEBM : AEKANGFCDAO
{
	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public MLBONNHEEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class NGBLKHHEAGD : SetInactiveEmbodiedObjectsWithHiddenTag
{
	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x283A330", Offset = "0x2839130", VA = "0x18283A330")]
	public NGBLKHHEAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
[UpdateAfter(typeof(NENDFNPOJPJ))]
internal sealed class EOBDBGNACIJ : KKPNBIDGCGE
{
	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public EOBDBGNACIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KBAINBIJCDH))]
internal class ONKALMKAIOC : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x283D1D0", Offset = "0x283BFD0", VA = "0x18283D1D0")]
	public ONKALMKAIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[AlwaysUpdateSystem]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
internal sealed class KIHDPJGMJJH : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	protected override ApplyPropertyDifferences ENAAOEAAPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x2833EB0", Offset = "0x2832CB0", VA = "0x182833EB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x2833F00", Offset = "0x2832D00", VA = "0x182833F00")]
	public KIHDPJGMJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
[UpdateAfter(typeof(KIHDPJGMJJH))]
internal sealed class OIMLEGBPLFN : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x283CCA0", Offset = "0x283BAA0", VA = "0x18283CCA0")]
	public OIMLEGBPLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(KIHDPJGMJJH))]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
internal sealed class ICCDPIAHMDJ : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public ICCDPIAHMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
[UpdateAfter(typeof(ICCDPIAHMDJ))]
internal sealed class HAPKDLHLLNK : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	protected override ComputePropertyDifferences PLIOAOLEJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2829E90", Offset = "0x2828C90", VA = "0x182829E90", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x2829EE0", Offset = "0x2828CE0", VA = "0x182829EE0")]
	public HAPKDLHLLNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ECEGKIHDGFD))]
[UpdateAfter(typeof(HAPKDLHLLNK))]
internal sealed class LBMJPGBICJG : COFDLBBLFME
{
	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x2836770", Offset = "0x2835570", VA = "0x182836770")]
	public LBMJPGBICJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GACJCKKDMNG))]
internal sealed class KPIOIDPOAPF : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x2834740", Offset = "0x2833540", VA = "0x182834740")]
	public KPIOIDPOAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GACJCKKDMNG))]
internal sealed class LIAPPGHFBHP : ADBJNMLEGAN
{
	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public LIAPPGHFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
internal class GALCAOICMCH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public GALCAOICMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
[UpdateAfter(typeof(GALCAOICMCH))]
internal sealed class PEAAFEMGPGI : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x2867430", Offset = "0x2866230", VA = "0x182867430")]
	public PEAAFEMGPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x28672D0", Offset = "0x28660D0", VA = "0x1828672D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateAfter(typeof(GALCAOICMCH))]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
internal sealed class PPDBMLODJIJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public PPDBMLODJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PPDBMLODJIJ))]
internal sealed class MEJEFNLMBKN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public MEJEFNLMBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
[ExecuteAlways]
[CIHFPOEPMJE]
[UpdateAfter(typeof(MEJEFNLMBKN))]
[UpdateInGroup(typeof(PPDBMLODJIJ))]
internal sealed class KADFNFOEOAP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public KADFNFOEOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KADFNFOEOAP))]
internal sealed class ANMEJHAGKIA : KLGOENHKPJC
{
	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public ANMEJHAGKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2C28CF0", Offset = "0x2C27AF0", VA = "0x182C28CF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(ANMEJHAGKIA))]
[UpdateInGroup(typeof(KADFNFOEOAP))]
internal sealed class PPMEIMCCAOK : LIICBMDDEGK
{
	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public PPMEIMCCAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x28683B0", Offset = "0x28671B0", VA = "0x1828683B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(PPMEIMCCAOK))]
[UpdateInGroup(typeof(KADFNFOEOAP))]
internal sealed class DBCHEHOIOIP : OPIMGAOPDNP
{
	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public DBCHEHOIOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(KADFNFOEOAP))]
[UpdateAfter(typeof(DBCHEHOIOIP))]
internal class EECKJDEKOJB : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C670", Offset = "0x2C3B470", VA = "0x182C3C670")]
	public EECKJDEKOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(MEJEFNLMBKN))]
internal sealed class ANPNHPCAMFO : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2C28D00", Offset = "0x2C27B00", VA = "0x182C28D00")]
	public ANPNHPCAMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GALCAOICMCH))]
internal sealed class OOKIAPDOEHI : KIJDBALHHDP
{
	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0")]
	public OOKIAPDOEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GALCAOICMCH))]
[UpdateAfter(typeof(OOKIAPDOEHI))]
internal sealed class DPONPGEEDIB : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A960", Offset = "0x2C39760", VA = "0x182C3A960")]
	public DPONPGEEDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(OOKIAPDOEHI))]
[UpdateInGroup(typeof(GALCAOICMCH))]
internal sealed class GFIPLMLCHMO : KFLEDGAOGNG
{
	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public GFIPLMLCHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(GALCAOICMCH))]
[UpdateAfter(typeof(GFIPLMLCHMO))]
[UpdateAfter(typeof(DPONPGEEDIB))]
internal sealed class IBPAJMPFBFI : JDGKDHAHBBO
{
	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public IBPAJMPFBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PMDCPHBIDCC))]
internal class POGFIDCHONA : TransmitNetworkDataSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public POGFIDCHONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(MAINBLDADFG))]
internal sealed class JLDJFEGGDEB : PostGameplayOnScopeChange
{
	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x2830B40", Offset = "0x282F940", VA = "0x182830B40")]
	public JLDJFEGGDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class FOLBJCBGIIH : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x28279B0", Offset = "0x28267B0", VA = "0x1828279B0")]
	public FOLBJCBGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
[UpdateAfter(typeof(FOLBJCBGIIH))]
internal class PJIMJKALPBO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public PJIMJKALPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(PJIMJKALPBO))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class ANGAHLPODJB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public ANGAHLPODJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
[UpdateAfter(typeof(PJIMJKALPBO))]
internal sealed class FLPLKEOOONA : UpdateContainerPivotOnExitScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x28273C0", Offset = "0x28261C0", VA = "0x1828273C0")]
	public FLPLKEOOONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(ANGAHLPODJB))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class KJAMHHLDILO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public KJAMHHLDILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(KJAMHHLDILO))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class FBNOFIPNOAF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public FBNOFIPNOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(PJIMJKALPBO))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class APNEBBLNJPL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public APNEBBLNJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[CIHFPOEPMJE]
[UpdateAfter(typeof(APNEBBLNJPL))]
[UpdateInGroup(typeof(BOKPOOFDOKN))]
internal class PENDCJNCAKL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2828050", Offset = "0x2826E50", VA = "0x182828050")]
	public PENDCJNCAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PENDCJNCAKL))]
internal class COIHLHAIHGH : JCNKOHLNAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x2C30B80", Offset = "0x2C2F980", VA = "0x182C30B80")]
	public COIHLHAIHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2C30B70", Offset = "0x2C2F970", VA = "0x182C30B70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PENDCJNCAKL))]
internal class ILPLPCIBBLN : HONFBOGIPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x282BC80", Offset = "0x282AA80", VA = "0x18282BC80")]
	public ILPLPCIBBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x282BC40", Offset = "0x282AA40", VA = "0x18282BC40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PENDCJNCAKL))]
internal class GEECICKCDBG : FJKACBADHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x2825CD0", Offset = "0x2824AD0", VA = "0x182825CD0")]
	public GEECICKCDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x2825C90", Offset = "0x2824A90", VA = "0x182825C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class BNNCLJEALME : ClearScopeOnLocalPlayerChangeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E530", Offset = "0x2C2D330", VA = "0x182C2E530")]
	public BNNCLJEALME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class JAMJMHEDCEK : PreventDisembodiedScopesSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x282F7F0", Offset = "0x282E5F0", VA = "0x18282F7F0")]
	public JAMJMHEDCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class OLNOAPMHJBG : LocalPlayerScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x283D060", Offset = "0x283BE60", VA = "0x18283D060")]
	public OLNOAPMHJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2838470", Offset = "0x2837270", VA = "0x182838470", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
internal sealed class NJEIHAGLBFJ : RemotePlayerScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x283B110", Offset = "0x2839F10", VA = "0x18283B110")]
	public NJEIHAGLBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x283B100", Offset = "0x2839F00", VA = "0x18283B100", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
[UpdateAfter(typeof(OLNOAPMHJBG))]
internal sealed class MDAJDPGBJDN : CreateContainerPivotOnEnterScopeSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2838660", Offset = "0x2837460", VA = "0x182838660")]
	public MDAJDPGBJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(APNEBBLNJPL))]
[UpdateAfter(typeof(OLNOAPMHJBG))]
internal sealed class FJKAGFHOPBN : HideRemotePivotsNotInScope
{
	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0xD88FA0", Offset = "0xD87DA0", VA = "0x180D88FA0")]
	public FJKAGFHOPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(FBNOFIPNOAF))]
internal sealed class AELKEOLNOPE : NIENIENGCDI
{
	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x28293D0", Offset = "0x28281D0", VA = "0x1828293D0")]
	public AELKEOLNOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B30", Offset = "0x2C25930", VA = "0x182C26B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(FBNOFIPNOAF))]
[UpdateAfter(typeof(AELKEOLNOPE))]
internal sealed class OJKNBAKPKML : LFLBNLDBEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2836DF0", Offset = "0x2835BF0", VA = "0x182836DF0")]
	public OJKNBAKPKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x2836DB0", Offset = "0x2835BB0", VA = "0x182836DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANGAHLPODJB))]
internal sealed class PAGPIOFHJHL : FPEBBPOHPPF
{
	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x2866470", Offset = "0x2865270", VA = "0x182866470")]
	public PAGPIOFHJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B03")]
	[Cpp2IlInjected.Address(RVA = "0x2866460", Offset = "0x2865260", VA = "0x182866460", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANGAHLPODJB))]
internal sealed class HHFIOBDONHP : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x282AD90", Offset = "0x2829B90", VA = "0x18282AD90")]
	public HHFIOBDONHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x282AD80", Offset = "0x2829B80", VA = "0x18282AD80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(ANGAHLPODJB))]
[UpdateAfter(typeof(HHFIOBDONHP))]
internal sealed class BJBDOLOLDMK : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E210", Offset = "0x2C2D010", VA = "0x182C2E210")]
	public BJBDOLOLDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[CIHFPOEPMJE]
[UpdateInGroup(typeof(PJIMJKALPBO))]
internal sealed class LOCFIPGKIGE : AssignPlayerIdsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x28378B0", Offset = "0x28366B0", VA = "0x1828378B0")]
	public LOCFIPGKIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x28378A0", Offset = "0x28366A0", VA = "0x1828378A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[FLIEEAHPEDE(typeof(AuthoredLocalPoseData))]
public sealed class KAEFPHLHLJO : BEDDJBOFBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x2830C60", Offset = "0x282FA60", VA = "0x182830C60", Slot = "8")]
	protected override bool IPBMAHBFOKM(ReadOnlySpan<AuthoredLocalPoseData> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x2830BA0", Offset = "0x282F9A0", VA = "0x182830BA0", Slot = "9")]
	protected override bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<AuthoredLocalPoseData> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x2830CE0", Offset = "0x282FAE0", VA = "0x182830CE0")]
	public KAEFPHLHLJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[FLIEEAHPEDE(typeof(LocalPoseData))]
public sealed class KHPALNDLCHF : PPFAMFIEDDM
{
	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x2833E20", Offset = "0x2832C20", VA = "0x182833E20", Slot = "8")]
	protected override bool IPBMAHBFOKM(ReadOnlySpan<LocalPoseData> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x2833D60", Offset = "0x2832B60", VA = "0x182833D60", Slot = "9")]
	protected override bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<LocalPoseData> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x2833EA0", Offset = "0x2832CA0", VA = "0x182833EA0")]
	public KHPALNDLCHF()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[Preserve]
	internal class _RRAssemblyIndex : ICKAPGKMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657940", VA = "0x180658B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x2882B70", Offset = "0x2881970", VA = "0x182882B70", Slot = "6")]
		public sealed override void ADPJAIEJIPK(BDNCAKHHJCI GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x2883750", Offset = "0x2882550", VA = "0x182883750", Slot = "4")]
		public sealed override void GEKIOEINPME()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x2C24A90", Offset = "0x2C23890", VA = "0x182C24A90")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x2C24BA0", Offset = "0x2C239A0", VA = "0x182C24BA0")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001D2")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
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
