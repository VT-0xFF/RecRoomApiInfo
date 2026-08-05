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
	[Cpp2IlInjected.Address(RVA = "0x2A01A80", Offset = "0x2A00A80", VA = "0x182A01A80")]
	static HLHFCCFHJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x254B8E0", Offset = "0x254A8E0", VA = "0x18254B8E0")]
	public static void KLHMDOLPFPN<T>(T ICAAAENIBKC, ref T PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A01A50", Offset = "0x2A00A50", VA = "0x182A01A50")]
	public static void KLHMDOLPFPN(FixedString32 ICAAAENIBKC, ref string PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A01970", Offset = "0x2A00970", VA = "0x182A01970")]
	public static void KLHMDOLPFPN(string ICAAAENIBKC, ref FixedString32 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A018E0", Offset = "0x2A008E0", VA = "0x182A018E0")]
	public static void KLHMDOLPFPN(FixedString64 ICAAAENIBKC, ref string PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A01910", Offset = "0x2A00910", VA = "0x182A01910")]
	public static void KLHMDOLPFPN(string ICAAAENIBKC, ref FixedString64 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2392DA0", Offset = "0x2391DA0", VA = "0x182392DA0")]
	public static void KLHMDOLPFPN(MAPAFAEKPLB ICAAAENIBKC, ref Vector3 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A01810", Offset = "0x2A00810", VA = "0x182A01810")]
	public static void KLHMDOLPFPN(Vector3 ICAAAENIBKC, ref MAPAFAEKPLB PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2392BD0", Offset = "0x2391BD0", VA = "0x182392BD0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref Vector4 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A01870", Offset = "0x2A00870", VA = "0x182A01870")]
	public static void KLHMDOLPFPN(Vector4 ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2392BD0", Offset = "0x2391BD0", VA = "0x182392BD0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref Quaternion PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A01870", Offset = "0x2A00870", VA = "0x182A01870")]
	public static void KLHMDOLPFPN(Quaternion ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A019B0", Offset = "0x2A009B0", VA = "0x182A019B0")]
	public static void KLHMDOLPFPN(MAPAFAEKPLB ICAAAENIBKC, ref float3 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A01810", Offset = "0x2A00810", VA = "0x182A01810")]
	public static void KLHMDOLPFPN(float3 ICAAAENIBKC, ref MAPAFAEKPLB PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A017B0", Offset = "0x2A007B0", VA = "0x182A017B0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref float4 PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A01870", Offset = "0x2A00870", VA = "0x182A01870")]
	public static void KLHMDOLPFPN(float4 ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A017B0", Offset = "0x2A007B0", VA = "0x182A017B0")]
	public static void KLHMDOLPFPN(JJGHECIKHGN ICAAAENIBKC, ref quaternion PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A019E0", Offset = "0x2A009E0", VA = "0x182A019E0")]
	public static void KLHMDOLPFPN(quaternion ICAAAENIBKC, ref JJGHECIKHGN PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A01770", Offset = "0x2A00770", VA = "0x182A01770")]
	public static void KLHMDOLPFPN(Entity ICAAAENIBKC, ref EAGBNLPLMDM PLPKOODJAKN, KLBODNIPMJE NGGOKHONBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A017F0", Offset = "0x2A007F0", VA = "0x182A017F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x657130", VA = "0x180658130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x6981C0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E03470", Offset = "0x2E02470", VA = "0x182E03470", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
	public BCACDHDIFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2A39640", Offset = "0x2A38640", VA = "0x182A39640")]
		public static ObjectModelConfigAsset KAFDHDNKOOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xEED600", Offset = "0xEEC600", VA = "0x180EED600")]
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
			[Cpp2IlInjected.Address(RVA = "0x37E08A0", Offset = "0x37DF8A0", VA = "0x1837E08A0")]
			public static NMEJDFJAOOA PFOPLNMMKLA(int MNMNCDHLGJH)
			{
				return default(NMEJDFJAOOA);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x37E0710", Offset = "0x37DF710", VA = "0x1837E0710")]
			public static int LFKBGMJBMBB(GameObject BFJMKCMPBKG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x37E0690", Offset = "0x37DF690", VA = "0x1837E0690")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A3A860", Offset = "0x2A39860", VA = "0x182A3A860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2A39D90", Offset = "0x2A38D90", VA = "0x182A39D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DDMIOFGHMGI HODIGNDEBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2A3AC70", Offset = "0x2A39C70", VA = "0x182A3AC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2A396E0", Offset = "0x2A386E0", VA = "0x182A396E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool MDOCPLGNBCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A700", Offset = "0x2A39700", VA = "0x182A3A700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static EEDGKMIDAFH ELOFBPOOINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2A39920", Offset = "0x2A38920", VA = "0x182A39920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static BFIAFBHOKLF GMAGOKAFPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A060", Offset = "0x2A39060", VA = "0x182A3A060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LBPAJLMGMFA CPAHMDPHOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A0E0", Offset = "0x2A390E0", VA = "0x182A3A0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CBIPFLGDJEF OFOEMMHFELK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2A3ABF0", Offset = "0x2A39BF0", VA = "0x182A3ABF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HFHHBKPAPIM HCLFBFBADHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2A399A0", Offset = "0x2A389A0", VA = "0x182A399A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static bool EDGBECOMPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A620", Offset = "0x2A39620", VA = "0x182A3A620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool GMLOKFCDNDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2A39E70", Offset = "0x2A38E70", VA = "0x182A39E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A580", Offset = "0x2A39580", VA = "0x182A3A580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool LOJJPMJMIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2A3AB90", Offset = "0x2A39B90", VA = "0x182A3AB90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A9F0", Offset = "0x2A399F0", VA = "0x182A3A9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool BPFJNFDNOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2A3AD90", Offset = "0x2A39D90", VA = "0x182A3AD90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2A3A520", Offset = "0x2A39520", VA = "0x182A3A520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A290", Offset = "0x2A39290", VA = "0x182A3A290")]
		public static PMMHBDBEGAM GJELMEFNGNA(GameObject BFJMKCMPBKG)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AA50", Offset = "0x2A39A50", VA = "0x182A3AA50")]
		public static bool NICGPJNPJBA(ByteString OFOCCMMPKKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A39C70", Offset = "0x2A38C70", VA = "0x182A39C70")]
		public static FEMMDHLANDH DKMHCFMKGGH(NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(FEMMDHLANDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A39A20", Offset = "0x2A38A20", VA = "0x182A39A20")]
		public static (ByteString, IDisposable) DGAMFOBEJMM()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A3F0", Offset = "0x2A393F0", VA = "0x182A3A3F0")]
		public static (ByteString, IDisposable) HDNBNFDBMMB(IEnumerable<PMMHBDBEGAM> NKMHMLMDMOP)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A8C0", Offset = "0x2A398C0", VA = "0x182A3A8C0")]
		public static bool LBJNANMCLGI(GameObject BFJMKCMPBKG, out NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2A3A160", Offset = "0x2A39160", VA = "0x182A3A160")]
		public static bool GEMFNDMEEJL(GameObject BFJMKCMPBKG, out bool OBANFJOJHJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AAB0", Offset = "0x2A39AB0", VA = "0x182A3AAB0")]
		private static DDMIOFGHMGI NKHKIKEOPBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A39B50", Offset = "0x2A38B50", VA = "0x182A39B50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A01470", Offset = "0x2A00470", VA = "0x182A01470")]
	public static GIALAGJINEB PJHBAIJLMNC(GameObject BFJMKCMPBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A01270", Offset = "0x2A00270", VA = "0x182A01270")]
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(PMMHBDBEGAM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1CAEB90", Offset = "0x1CADB90", VA = "0x181CAEB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
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
			[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677030", VA = "0x180678030", Slot = "11")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public FEMMDHLANDH MDKCEMLOLDO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2E132B0", Offset = "0x2E122B0", VA = "0x182E132B0", Slot = "4")]
			get
			{
				return default(FEMMDHLANDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EEDGKMIDAFH ELOFBPOOINO
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2E128F0", Offset = "0x2E118F0", VA = "0x182E128F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private DDPHBMAAHDP IKBMNLNHFOK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2E12940", Offset = "0x2E11940", VA = "0x182E12940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public KGMBEEPIDCF FMNNHJPPEJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x677D90", Offset = "0x676D90", VA = "0x180677D90", Slot = "5")]
			get
			{
				return default(KGMBEEPIDCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BHCFKCKKCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6723D0", Offset = "0x6713D0", VA = "0x1806723D0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x77E1D0", Offset = "0x77D1D0", VA = "0x18077E1D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CPGENINLLKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2E13210", Offset = "0x2E12210", VA = "0x182E13210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2E132E0", Offset = "0x2E122E0", VA = "0x182E132E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2E127F0", Offset = "0x2E117F0", VA = "0x182E127F0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2E12FA0", Offset = "0x2E11FA0", VA = "0x182E12FA0", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2E12BC0", Offset = "0x2E11BC0", VA = "0x182E12BC0", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2E12F10", Offset = "0x2E11F10", VA = "0x182E12F10", Slot = "8")]
		public void OnEmbody(EHIDJEIAFME HADAJAKADAH, PMMHBDBEGAM JBKJOONHJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2E12F90", Offset = "0x2E11F90", VA = "0x182E12F90", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2E12CE0", Offset = "0x2E11CE0", VA = "0x182E12CE0", Slot = "10")]
		public void OnDisembody(bool KPMBBBPBAKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2E130C0", Offset = "0x2E120C0", VA = "0x182E130C0")]
		private void PFPDCNMEFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2E12B00", Offset = "0x2E11B00", VA = "0x182E12B00")]
		private void GDCFJBLAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2E129C0", Offset = "0x2E119C0", VA = "0x182E129C0")]
		private void FKLGBDDBJBJ(bool MAGLHKOAFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xF9E4D0", Offset = "0xF9D4D0", VA = "0x180F9E4D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
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
			[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x657BD0", VA = "0x180658BD0")]
			get
			{
				return default(CBLLNBPHCKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6FB410", Offset = "0x6FA410", VA = "0x1806FB410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public PMMHBDBEGAM JJEJMCOPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCB1FA0", Offset = "0xCB0FA0", VA = "0x180CB1FA0", Slot = "4")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity MINMLEDGPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal CBIPFLGDJEF OFOEMMHFELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal DDPHBMAAHDP LLJLHOBLFJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2A4DBC0", Offset = "0x2A4CBC0", VA = "0x182A4DBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DBB0", Offset = "0x2A4CBB0", VA = "0x182A4DBB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DFB0", Offset = "0x2A4CFB0", VA = "0x182A4DFB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DCD0", Offset = "0x2A4CCD0", VA = "0x182A4DCD0")]
		internal void ILMEFAAGLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DC30", Offset = "0x2A4CC30", VA = "0x182A4DC30")]
		private bool HDNEEALHHIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E0A0", Offset = "0x2A4D0A0", VA = "0x182A4E0A0")]
		private void NEKOIANILKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DFB0", Offset = "0x2A4CFB0", VA = "0x182A4DFB0")]
		internal void LKKBDAMJBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E0C0", Offset = "0x2A4D0C0", VA = "0x182A4E0C0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E1A0", Offset = "0x2A4D1A0", VA = "0x182A4E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2F60", Offset = "0x8C1F60", VA = "0x1808C2F60", Slot = "18")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AJDCMAAKGND AFNMECPECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IJONKAEAEBK GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EEDGKMIDAFH ELOFBPOOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761B40", VA = "0x180762B40", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GMLOKFCDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE9A0", Offset = "0x2DFD9A0", VA = "0x182DFE9A0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DFECB0", Offset = "0x2DFDCB0", VA = "0x182DFECB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2DFED80", Offset = "0x2DFDD80", VA = "0x182DFED80", Slot = "19")]
	public void KEACOMCKNJG(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2DFED70", Offset = "0x2DFDD70", VA = "0x182DFED70")]
	private void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEB20", Offset = "0x2DFDB20", VA = "0x182DFEB20")]
	private void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	private void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE940", Offset = "0x2DFD940", VA = "0x182DFE940", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEBB0", Offset = "0x2DFDBB0", VA = "0x182DFEBB0", Slot = "7")]
	public void HJFKJCGGCHL(ByteString JANIFNADDOP, FIIDIKCOABM IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE860", Offset = "0x2DFD860", VA = "0x182DFE860", Slot = "4")]
	public ByteString DGAMFOBEJMM(out IDisposable AEPEDHEDMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEA80", Offset = "0x2DFDA80", VA = "0x182DFEA80", Slot = "5")]
	public void HFLDMAMBPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE610", Offset = "0x2DFD610", VA = "0x182DFE610", Slot = "6")]
	public void BFNLLBCKDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DFED40", Offset = "0x2DFDD40", VA = "0x182DFED40", Slot = "9")]
	public void JIIFFIDEOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE680", Offset = "0x2DFD680", VA = "0x182DFE680", Slot = "8")]
	public void BKCJFNGCBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEA10", Offset = "0x2DFDA10", VA = "0x182DFEA10", Slot = "10")]
	public void GMLAJKAIPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEE60", Offset = "0x2DFDE60", VA = "0x182DFEE60", Slot = "11")]
	public void NBAPLGNMALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DFED30", Offset = "0x2DFDD30", VA = "0x182DFED30", Slot = "12")]
	public void HLFKKGKEHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DFED40", Offset = "0x2DFDD40", VA = "0x182DFED40")]
	private void JEFLCDJFCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE770", Offset = "0x2DFD770", VA = "0x182DFE770")]
	public static AOMGPGIGOPG DAKLFHBAJIH(AJDCMAAKGND FJKJAKKFINM, HNBJONKGAEL IDKBHBKJHPJ = HNBJONKGAEL.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	private static void EAKJLDOOHJN(AJDCMAAKGND FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	private static void GNNLGEBIEFN(AJDCMAAKGND FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public AOMGPGIGOPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NLMGFEDBPGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2A11D30", Offset = "0x2A10D30", VA = "0x182A11D30")]
	public static FEMMDHLANDH PACACJLKIEO(this DDMIOFGHMGI BHLMCOMCAMI, NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2A11A30", Offset = "0x2A10A30", VA = "0x182A11A30")]
	public static DJFJGAJKGKD GEAJKNPCODP(this DDMIOFGHMGI BHLMCOMCAMI)
	{
		return default(DJFJGAJKGKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A11B50", Offset = "0x2A10B50", VA = "0x182A11B50")]
	public static PMMHBDBEGAM GJELMEFNGNA(this DDMIOFGHMGI BHLMCOMCAMI, Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A11C00", Offset = "0x2A10C00", VA = "0x182A11C00")]
	public static PMMHBDBEGAM GJELMEFNGNA(this DDMIOFGHMGI BHLMCOMCAMI, NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A11910", Offset = "0x2A10910", VA = "0x182A11910")]
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
		[Cpp2IlInjected.Address(RVA = "0x334CF20", Offset = "0x334BF20", VA = "0x18334CF20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x33484B0", Offset = "0x33474B0", VA = "0x1833484B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public COLPHKAFOHI ABFPPGPBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x334A320", Offset = "0x3349320", VA = "0x18334A320", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KPNMHAONEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x33498D0", Offset = "0x33488D0", VA = "0x1833498D0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ABBPJBEDAOI DLIKAHDJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x334A6D0", Offset = "0x33496D0", VA = "0x18334A6D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1081A90", Offset = "0x1080A90", VA = "0x181081A90", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3349A00", Offset = "0x3348A00", VA = "0x183349A00", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event global::NICCPCBLAIH<NMEJDFJAOOA> CDKLADNMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x334A470", Offset = "0x3349470", VA = "0x18334A470", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x334D020", Offset = "0x334C020", VA = "0x18334D020", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x334F7B0", Offset = "0x334E7B0", VA = "0x18334F7B0")]
	public PLGEJPKBGNG(global::HCIKOPDBING<Entity> HLOAMKBCFBD, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x33489D0", Offset = "0x33479D0", VA = "0x1833489D0")]
	private Entity ANJHDLDNACK(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3348750", Offset = "0x3347750", VA = "0x183348750")]
	private NMEJDFJAOOA ANJHDLDNACK(Entity GEEFHDFLBEH)
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3349420", Offset = "0x3348420", VA = "0x183349420", Slot = "4")]
	public T BOPAOPJOHPG(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x334EE20", Offset = "0x334DE20", VA = "0x18334EE20")]
	public bool PIGMJENILDA(NMEJDFJAOOA DBGIPPEDJIM, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3349D80", Offset = "0x3348D80", VA = "0x183349D80")]
	public bool FEOKGJFDCCA(NMEJDFJAOOA DBGIPPEDJIM, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3348630", Offset = "0x3347630", VA = "0x183348630", Slot = "9")]
	public bool AEBBOEKMPNE(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x334A220", Offset = "0x3349220", VA = "0x18334A220", Slot = "26")]
	public object FLHIMLEJDFE(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x334D830", Offset = "0x334C830", VA = "0x18334D830")]
	public bool NBGPFIAMPKG(NMEJDFJAOOA DBGIPPEDJIM, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x33493B0", Offset = "0x33483B0", VA = "0x1833493B0")]
	public void BOPAOPJOHPG(NMEJDFJAOOA DBGIPPEDJIM, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x334EDA0", Offset = "0x334DDA0", VA = "0x18334EDA0")]
	public bool PIGMJENILDA(NMEJDFJAOOA DBGIPPEDJIM, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x334A140", Offset = "0x3349140", VA = "0x18334A140")]
	public bool FEOKGJFDCCA(NMEJDFJAOOA DBGIPPEDJIM, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x334B040", Offset = "0x334A040", VA = "0x18334B040", Slot = "21")]
	public void ICJPMMDCBBM(GMPBHDKHOML EMCMEEJENIP, [Optional] object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x334B070", Offset = "0x334A070", VA = "0x18334B070", Slot = "15")]
	public void ICJPMMDCBBM(NMEJDFJAOOA CCJNKBLKLDJ, FFKLAMKJFED EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x334B6F0", Offset = "0x334A6F0", VA = "0x18334B6F0", Slot = "14")]
	public bool JACHHKBDHDB(NMEJDFJAOOA PLPKOODJAKN, NMEJDFJAOOA ICAAAENIBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x260B540", Offset = "0x260A540", VA = "0x18260B540", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x334F5D0", Offset = "0x334E5D0", VA = "0x18334F5D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3349830", Offset = "0x3348830", VA = "0x183349830")]
	public string DJJBAGBAKMA(in MJADMLMEADH OGIKPKOLMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x334B7B0", Offset = "0x334A7B0", VA = "0x18334B7B0")]
	private void JEEDOHDMNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x334AC00", Offset = "0x3349C00", VA = "0x18334AC00")]
	private void HPEMFBKDMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x334E0E0", Offset = "0x334D0E0", VA = "0x18334E0E0")]
	private void OOPGOCHNLEL(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x334DAD0", Offset = "0x334CAD0", VA = "0x18334DAD0")]
	private void NFDEOPKAPOI(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x334CAC0", Offset = "0x334BAC0", VA = "0x18334CAC0")]
	[Conditional("DEBUG_BUILD")]
	private static void JPOLNLNMBAE(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM, string JLHBKPIPBGO, string NFDEPNCPAAF, [CallerMemberName] string NNNOJJMLEJC = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3304EF0", Offset = "0x3303EF0", VA = "0x183304EF0", Slot = "5")]
	private bool PPEIKBCIMKI(NMEJDFJAOOA CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5A80", Offset = "0x2FB4A80", VA = "0x182FB5A80", Slot = "6")]
	private bool OBPBBKFDOHC(NMEJDFJAOOA CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5D20", Offset = "0x2FB4D20", VA = "0x182FB5D20", Slot = "23")]
	private string FPCADNMOMEL(in MJADMLMEADH IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x31C39B0", Offset = "0x31C29B0", VA = "0x1831C39B0", Slot = "10")]
	private bool NEAKLMKNCOA(NMEJDFJAOOA CCJNKBLKLDJ, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x31C3D30", Offset = "0x31C2D30", VA = "0x1831C3D30", Slot = "11")]
	private void KLMFLIMPFDG(NMEJDFJAOOA CCJNKBLKLDJ, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x334ED70", Offset = "0x334DD70", VA = "0x18334ED70", Slot = "12")]
	private bool PDKGBKGOCBI(NMEJDFJAOOA CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2943A70", Offset = "0x2942A70", VA = "0x182943A70", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BC7FC0", Offset = "0x3BC6FC0", VA = "0x183BC7FC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Type JOGKEEGNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3BC15A0", Offset = "0x3BC05A0", VA = "0x183BC15A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public COLPHKAFOHI ABFPPGPBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4930", Offset = "0x3BC3930", VA = "0x183BC4930", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KPNMHAONEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3BC35E0", Offset = "0x3BC25E0", VA = "0x183BC35E0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ABBPJBEDAOI DLIKAHDJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3BC50D0", Offset = "0x3BC40D0", VA = "0x183BC50D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x349A560", Offset = "0x3499560", VA = "0x18349A560", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3670", Offset = "0x3BC2670", VA = "0x183BC3670", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::NICCPCBLAIH<PMMHBDBEGAM> CDKLADNMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4D90", Offset = "0x3BC3D90", VA = "0x183BC4D90", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8370", Offset = "0x3BC7370", VA = "0x183BC8370", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x334F7B0", Offset = "0x334E7B0", VA = "0x18334F7B0")]
	public JEBFFIPPOIH(global::HCIKOPDBING<Entity> HLOAMKBCFBD, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1190F90", Offset = "0x118FF90", VA = "0x181190F90")]
	private Entity ANJHDLDNACK(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3495CD0", Offset = "0x3494CD0", VA = "0x183495CD0")]
	private PMMHBDBEGAM ANJHDLDNACK(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1BE0", Offset = "0x3BC0BE0", VA = "0x183BC1BE0", Slot = "4")]
	public T BOPAOPJOHPG(PMMHBDBEGAM ADGJAILKBPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC130", Offset = "0x3BCB130", VA = "0x183BCC130")]
	public bool PIGMJENILDA(PMMHBDBEGAM ADGJAILKBPO, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3BC43C0", Offset = "0x3BC33C0", VA = "0x183BC43C0")]
	public bool FEOKGJFDCCA(PMMHBDBEGAM ADGJAILKBPO, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1B40", Offset = "0x3BC0B40", VA = "0x183BC1B40", Slot = "9")]
	public bool AEBBOEKMPNE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4670", Offset = "0x3BC3670", VA = "0x183BC4670", Slot = "25")]
	public object FLHIMLEJDFE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8580", Offset = "0x3BC7580", VA = "0x183BC8580")]
	public bool NBGPFIAMPKG(PMMHBDBEGAM ADGJAILKBPO, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2890", Offset = "0x3BC1890", VA = "0x183BC2890")]
	public void BOPAOPJOHPG(PMMHBDBEGAM ADGJAILKBPO, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC3C0", Offset = "0x3BCB3C0", VA = "0x183BCC3C0")]
	public bool PIGMJENILDA(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3E20", Offset = "0x3BC2E20", VA = "0x183BC3E20")]
	public bool FEOKGJFDCCA(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x334B040", Offset = "0x334A040", VA = "0x18334B040", Slot = "21")]
	public void ICJPMMDCBBM(GMPBHDKHOML EMCMEEJENIP, [Optional] object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6340", Offset = "0x3BC5340", VA = "0x183BC6340", Slot = "15")]
	public void ICJPMMDCBBM(PMMHBDBEGAM CCJNKBLKLDJ, FFKLAMKJFED EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6AD0", Offset = "0x3BC5AD0", VA = "0x183BC6AD0", Slot = "14")]
	public bool JACHHKBDHDB(PMMHBDBEGAM PLPKOODJAKN, PMMHBDBEGAM ICAAAENIBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7550", Offset = "0x3BC6550", VA = "0x183BC7550")]
	private void JEEDOHDMNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5BC0", Offset = "0x3BC4BC0", VA = "0x183BC5BC0")]
	private void HPEMFBKDMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAA50", Offset = "0x3BC9A50", VA = "0x183BCAA50")]
	private void OOPGOCHNLEL(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9830", Offset = "0x3BC8830", VA = "0x183BC9830")]
	private void NFDEOPKAPOI(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3497100", Offset = "0x3496100", VA = "0x183497100", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC9D0", Offset = "0x3BCB9D0", VA = "0x183BCC9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3497170", Offset = "0x3496170", VA = "0x183497170", Slot = "5")]
	private bool PPNEGJFMBIG(PMMHBDBEGAM CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3496F30", Offset = "0x3495F30", VA = "0x183496F30", Slot = "6")]
	private bool DILFBGCJNPO(PMMHBDBEGAM CCJNKBLKLDJ, in T LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x21ABE30", Offset = "0x21AAE30", VA = "0x1821ABE30", Slot = "10")]
	private bool FOPKGOLPICI(PMMHBDBEGAM CCJNKBLKLDJ, in object LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3496EF0", Offset = "0x3495EF0", VA = "0x183496EF0", Slot = "11")]
	private void CLFJPJOHFLN(PMMHBDBEGAM CCJNKBLKLDJ, in ECNLJAAGJFG IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3495D00", Offset = "0x3494D00", VA = "0x183495D00", Slot = "12")]
	private bool BKBNACBCEKH(PMMHBDBEGAM CCJNKBLKLDJ, in MJADMLMEADH LNHLJHKJGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3496EB0", Offset = "0x3495EB0", VA = "0x183496EB0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0xD85AF0", Offset = "0xD84AF0", VA = "0x180D85AF0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xD8B490", Offset = "0xD8A490", VA = "0x180D8B490")]
	public BGDMNMCCMEA(NativeArray<EntityRemapUtility.EntityRemapInfo> GLNDINKCGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2E03640", Offset = "0x2E02640", VA = "0x182E03640", Slot = "6")]
	public PMMHBDBEGAM LOPGGIPACEB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2E03690", Offset = "0x2E02690", VA = "0x182E03690", Slot = "7")]
	public Entity LOPGGIPACEB(Entity GEEFHDFLBEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2E035A0", Offset = "0x2E025A0", VA = "0x182E035A0", Slot = "8")]
	public IEnumerable<PMMHBDBEGAM> LOPGGIPACEB(IEnumerable<PMMHBDBEGAM> NKMHMLMDMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2E03540", Offset = "0x2E02540", VA = "0x182E03540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A48E00", Offset = "0x2A47E00", VA = "0x182A48E00")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static bool KCEMFBBKHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2A49080", Offset = "0x2A48080", VA = "0x182A49080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A49020", Offset = "0x2A48020", VA = "0x182A49020")]
		public static SerializationRemapScope HJFBIOMPHCC()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A49430", Offset = "0x2A48430", VA = "0x182A49430")]
		public SerializationRemapScope(FCMCKNEAHLO EENEGLPEEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2A48F10", Offset = "0x2A47F10", VA = "0x182A48F10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2A49240", Offset = "0x2A48240", VA = "0x182A49240")]
		public static PMMHBDBEGAM LOPGGIPACEB(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A49110", Offset = "0x2A48110", VA = "0x182A49110")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A126F0", Offset = "0x2A116F0", VA = "0x182A126F0", Slot = "5")]
	public void JFDBCBPNEOB(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2A128B0", Offset = "0x2A118B0", VA = "0x182A128B0", Slot = "6")]
	public void MBNNIDDPDHD(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A127D0", Offset = "0x2A117D0", VA = "0x182A127D0", Slot = "7")]
	public void LCIAGECPLHB(object GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2A125E0", Offset = "0x2A115E0", VA = "0x182A125E0", Slot = "4")]
	public IDisposable JDMAFJDBIBL(object GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
			public KFLLPAHAEEL(string KIHDPCDCOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
			public void JACHHKBDHDB(EntityManager KIHDPCDCOMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E10390", Offset = "0x2E0F390", VA = "0x182E10390")]
		public DebugWorldsService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2E10350", Offset = "0x2E0F350", VA = "0x182E10350", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A250", VA = "0x18065B250", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2A07250", Offset = "0x2A06250", VA = "0x182A07250", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<bool> BNMEEFBEKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A07110", Offset = "0x2A06110", VA = "0x182A07110", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A071B0", Offset = "0x2A061B0", VA = "0x182A071B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x8217D0", Offset = "0x8207D0", VA = "0x1808217D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x1FEC2C0", Offset = "0x1FEB2C0", VA = "0x181FEC2C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public OKJLDANCMCA GDFHIAHBADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A0A0", Offset = "0x2A490A0", VA = "0x182A4A0A0", Slot = "11")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2A4ABE0", Offset = "0x2A49BE0", VA = "0x182A4ABE0")]
		public static bool NICGPJNPJBA(ByteString OFOCCMMPKKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x676140", VA = "0x180677140")]
		public void ENDOHEJKOHJ(KFOEJBPDGJE MPCCHNGMGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4AD10", Offset = "0x2A49D10", VA = "0x182A4AD10", Slot = "4")]
		public void PNIPCIGLEJN(bool JBAGPIKPAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2A49940", Offset = "0x2A48940", VA = "0x182A49940", Slot = "5")]
		public ByteString DGAMFOBEJMM(out IDisposable AEPEDHEDMKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2A49730", Offset = "0x2A48730", VA = "0x182A49730", Slot = "14")]
		public ByteString DGAMFOBEJMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A160", Offset = "0x2A49160", VA = "0x182A4A160", Slot = "7")]
		public bool HJFKJCGGCHL(ByteString FOEBAOOBLLE, FIIDIKCOABM IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A910", Offset = "0x2A49910", VA = "0x182A4A910")]
		private bool NBKHPGGLIHK(ByteString FOEBAOOBLLE, FIIDIKCOABM IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2A494C0", Offset = "0x2A484C0", VA = "0x182A494C0", Slot = "8")]
		public bool BKCJFNGCBCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2A49570", Offset = "0x2A48570", VA = "0x182A49570", Slot = "6")]
		public void CNJFHELJLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2A49D00", Offset = "0x2A48D00", VA = "0x182A49D00", Slot = "9")]
		public bool GMLAJKAIPOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A680", Offset = "0x2A49680", VA = "0x182A4A680", Slot = "10")]
		public bool NBAPLGNMALE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A490", Offset = "0x2A49490", VA = "0x182A4A490")]
		public bool MMOICLPGKEH(OKJLDANCMCA.GCFCGEAFACN.CHNPPDJGDNC PAKEAHNPOIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2A49A20", Offset = "0x2A48A20", VA = "0x182A49A20")]
		private bool DMJJLNOKELC(ByteString FOEBAOOBLLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A3D0", Offset = "0x2A493D0", VA = "0x182A4A3D0")]
		private void MMAGGEBNBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A370", Offset = "0x2A49370", VA = "0x182A4A370")]
		private ByteString MAMBKODCLGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2A49F80", Offset = "0x2A48F80", VA = "0x182A49F80")]
		private ByteString HBCCKENAPKC(ByteString OFOCCMMPKKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2A4AB30", Offset = "0x2A49B30", VA = "0x182A4AB30")]
		private OKJLDANCMCA.GCFCGEAFACN.CHNPPDJGDNC NEIODFJCEMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2A4A1A0", Offset = "0x2A491A0", VA = "0x182A4A1A0")]
		private void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2A49CC0", Offset = "0x2A48CC0", VA = "0x182A49CC0")]
		private void FCMNIGJBIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A00CA0", Offset = "0x29FFCA0", VA = "0x182A00CA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2A00B10", Offset = "0x29FFB10", VA = "0x182A00B10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action<FCMCKNEAHLO> BPONCGIEBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2A00D40", Offset = "0x29FFD40", VA = "0x182A00D40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2A00DE0", Offset = "0x29FFDE0", VA = "0x182A00DE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FOPGIPKMGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2A00890", Offset = "0x29FF890", VA = "0x182A00890", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2A00930", Offset = "0x29FF930", VA = "0x182A00930", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action COINHAMMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2A00A70", Offset = "0x29FFA70", VA = "0x182A00A70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2A009D0", Offset = "0x29FF9D0", VA = "0x182A009D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FCMCKNEAHLO> JJFNHBNBCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2A00BB0", Offset = "0x29FFBB0", VA = "0x182A00BB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2A00E80", Offset = "0x29FFE80", VA = "0x182A00E80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x11465F0", Offset = "0x11455F0", VA = "0x1811465F0")]
	public void PIGAGAELBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1146020", Offset = "0x1145020", VA = "0x181146020")]
	public void CIAGNPLALDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x13D6B30", Offset = "0x13D5B30", VA = "0x1813D6B30")]
	public void EFEJPAIAAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2A00840", Offset = "0x29FF840", VA = "0x182A00840")]
	public void ALBKGGMPMOC(FCMCKNEAHLO EJEJEGHNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2A00C50", Offset = "0x29FFC50", VA = "0x182A00C50")]
	public void KFCLMAMBJOK(FCMCKNEAHLO EJEJEGHNJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A02FA0", Offset = "0x2A01FA0", VA = "0x182A02FA0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2A02C40", Offset = "0x2A01C40", VA = "0x182A02C40", Slot = "12")]
	public void BDKHMFMCKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2A02D60", Offset = "0x2A01D60", VA = "0x182A02D60", Slot = "6")]
	public void EOCBAKHJMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2A034F0", Offset = "0x2A024F0", VA = "0x182A034F0", Slot = "5")]
	public void OEOHKCEFKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2A03070", Offset = "0x2A02070", VA = "0x182A03070", Slot = "7")]
	public void ICCPPCIFMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2A03340", Offset = "0x2A02340", VA = "0x182A03340", Slot = "8")]
	public void MLLCJLEMGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2A036A0", Offset = "0x2A026A0", VA = "0x182A036A0", Slot = "9")]
	public void PGLCPONIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2A03220", Offset = "0x2A02220", VA = "0x182A03220", Slot = "10")]
	public void LMBOMCOLOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A02F10", Offset = "0x2A01F10", VA = "0x182A02F10", Slot = "11")]
	public void FPGOANAJIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2A129F0", Offset = "0x2A119F0", VA = "0x182A129F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public EntityManager JPGBDDHMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2A12D50", Offset = "0x2A11D50", VA = "0x182A12D50", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6718D0", Offset = "0x6708D0", VA = "0x1806718D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2A12D90", Offset = "0x2A11D90", VA = "0x182A12D90", Slot = "10")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2A12A10", Offset = "0x2A11A10", VA = "0x182A12A10")]
	private void DAKLFHBAJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2A12B20", Offset = "0x2A11B20", VA = "0x182A12B20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2A12D70", Offset = "0x2A11D70", VA = "0x182A12D70", Slot = "8")]
	public ComponentSystemBase IDMEFHDLGGA(Type NKICFHCCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D8690", Offset = "0x37D7690", VA = "0x1837D8690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B20", Offset = "0xAB1B20", VA = "0x180AB2B20")]
		[DebuggerHidden]
		public GGLLCOLGDHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x37D8380", Offset = "0x37D7380", VA = "0x1837D8380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x37D8650", Offset = "0x37D7650", VA = "0x1837D8650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x37D85B0", Offset = "0x37D75B0", VA = "0x1837D85B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x37D85B0", Offset = "0x37D75B0", VA = "0x1837D85B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A0FC50", Offset = "0x2A0EC50", VA = "0x182A0FC50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public List<EMNNOKKNGJD> BOGKNNCHPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2A101E0", Offset = "0x2A0F1E0", VA = "0x182A101E0", Slot = "8")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2A10240", Offset = "0x2A0F240", VA = "0x182A10240", Slot = "9")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FD00", Offset = "0x2A0ED00", VA = "0x182A0FD00", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FDC0", Offset = "0x2A0EDC0", VA = "0x182A0FDC0", Slot = "6")]
	public bool EJLFOMONOPL(EMNNOKKNGJD HLOAMKBCFBD, out NCDGLNOPNGL DEIPGHEFMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FE50", Offset = "0x2A0EE50", VA = "0x182A0FE50")]
	private void FOCPGJGONGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FA40", Offset = "0x2A0EA40", VA = "0x182A0FA40")]
	private void APBHIJLNDJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2A10640", Offset = "0x2A0F640", VA = "0x182A10640")]
	private PKIFOJFOFHC LPFOILFAPFC(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FC50", Offset = "0x2A0EC50", VA = "0x182A0FC50")]
	private PKIFOJFOFHC BKPMIANNEJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2A102F0", Offset = "0x2A0F2F0", VA = "0x182A102F0")]
	private PKIFOJFOFHC LBDCBPBHNLB(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2A10780", Offset = "0x2A0F780", VA = "0x182A10780")]
	private PKIFOJFOFHC OFOHMPAICFE(string KCGMDGFIHOJ, string MKDOEIGPNGM, [Optional] PKIFOJFOFHC IIIKGDMPMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FD50", Offset = "0x2A0ED50", VA = "0x182A0FD50")]
	[IteratorStateMachine(typeof(GGLLCOLGDHJ))]
	private IEnumerable<(string, string)> EJBCDJMKBBP(string LMDHPGELNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FCB0", Offset = "0x2A0ECB0", VA = "0x182A0FCB0")]
	private bool CDFGJLPMPCC(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2A10560", Offset = "0x2A0F560", VA = "0x182A10560")]
	private DNKAAMBGEFF LBOIIOKBPNJ(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2A10730", Offset = "0x2A0F730", VA = "0x182A10730")]
	private DNKAAMBGEFF MKACELIKLKJ(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2A10260", Offset = "0x2A0F260", VA = "0x182A10260")]
	private DNKAAMBGEFF LAHFFPPDBFL(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x33B29F0", Offset = "0x33B19F0", VA = "0x1833B29F0")]
	private T PPKNOAEFHAP<T>(EMNNOKKNGJD HLOAMKBCFBD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FBE0", Offset = "0x2A0EBE0", VA = "0x182A0FBE0")]
	private FieldInfo BGIHODPKJOL(EMNNOKKNGJD HLOAMKBCFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2A10890", Offset = "0x2A0F890", VA = "0x182A10890")]
	public NCLHCLNIFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2A106A0", Offset = "0x2A0F6A0", VA = "0x182A106A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NCDGLNOPNGL CPANCPIMLED
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<NCDGLNOPNGL> LFOFBANACAI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IEnumerable<EMNNOKKNGJD> LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E970", Offset = "0x2A3D970", VA = "0x182A3E970")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D580", VA = "0x18065E580", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A0", Offset = "0x65D5A0", VA = "0x18065E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2172BF0", Offset = "0x2171BF0", VA = "0x182172BF0", Slot = "13")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x29FC800", Offset = "0x29FB800", VA = "0x1829FC800", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x29FC9A0", Offset = "0x29FB9A0", VA = "0x1829FC9A0", Slot = "15")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8274B0", Offset = "0x8264B0", VA = "0x1808274B0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x29FC560", Offset = "0x29FB560", VA = "0x1829FC560")]
	private PMMHBDBEGAM AHLIDNNPJGI(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x29FC620", Offset = "0x29FB620", VA = "0x1829FC620", Slot = "18")]
	public PMMHBDBEGAM DCBCGPDHMLI(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x29FCE40", Offset = "0x29FBE40", VA = "0x1829FCE40", Slot = "19")]
	public void PPDLNFBKINL(ref List<PMMHBDBEGAM> PNCPJCEBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x29FCCA0", Offset = "0x29FBCA0", VA = "0x1829FCCA0", Slot = "20")]
	public IEnumerable<PMMHBDBEGAM> NJHHOCACKHJ(PMMHBDBEGAM ADGJAILKBPO, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x29FCC30", Offset = "0x29FBC30", VA = "0x1829FCC30", Slot = "21")]
	public PMMHBDBEGAM NFFPNEMPLNO(PMMHBDBEGAM ADGJAILKBPO, int AIPHGHFENPJ)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x29FC680", Offset = "0x29FB680", VA = "0x1829FC680", Slot = "22")]
	public int EPCJNDKBFAD(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x29FC7D0", Offset = "0x29FB7D0", VA = "0x1829FC7D0", Slot = "7")]
	public int HDHNEFAFOAJ(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x29FC900", Offset = "0x29FB900", VA = "0x1829FC900", Slot = "8")]
	public CAOGEMEHCPI HNFHCHPIHGD(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x29FCD70", Offset = "0x29FBD70", VA = "0x1829FCD70", Slot = "23")]
	public IEnumerable<PMMHBDBEGAM> OEMKFPIEJOP(PMMHBDBEGAM ADGJAILKBPO, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x29FCB60", Offset = "0x29FBB60", VA = "0x1829FCB60", Slot = "11")]
	public PMMHBDBEGAM NDOCFECCKPD(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x29FCA90", Offset = "0x29FBA90", VA = "0x1829FCA90", Slot = "12")]
	public bool MKDAEBPAGML(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC, out PMMHBDBEGAM CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x29FC590", Offset = "0x29FB590", VA = "0x1829FC590", Slot = "4")]
	public PMMHBDBEGAM AILCCJELIAN(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x29FC5F0", Offset = "0x29FB5F0", VA = "0x1829FC5F0", Slot = "10")]
	public bool BEBDCGNEJPP(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x29FC770", Offset = "0x29FB770", VA = "0x1829FC770", Slot = "24")]
	public bool FLMGCLJOAAP(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM NIPKJIJGCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x29FC7A0", Offset = "0x29FB7A0", VA = "0x1829FC7A0", Slot = "9")]
	public bool GOENCLMLMME(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM PJCDGLCJFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x29FC970", Offset = "0x29FB970", VA = "0x1829FC970", Slot = "5")]
	public bool JCGFFABNCHF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM ADECAOLBLPJ, bool CAMPEPOCDEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x29FC740", Offset = "0x29FB740", VA = "0x1829FC740", Slot = "6")]
	public bool FKEELJGEBOF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM ADECAOLBLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E05E40", Offset = "0x2E04E40", VA = "0x182E05E40", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E05CF0", Offset = "0x2E04CF0", VA = "0x182E05CF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E05990", Offset = "0x2E04990", VA = "0x182E05990")]
	public MFLHDAEOBPP ABLADMHFHAN(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E05BA0", Offset = "0x2E04BA0", VA = "0x182E05BA0")]
	public MFLHDAEOBPP ABLADMHFHAN(JLCDNMLCNEN ABEODFEGJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E05E90", Offset = "0x2E04E90", VA = "0x182E05E90")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2E05FB0", Offset = "0x2E04FB0", VA = "0x182E05FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD85AF0", Offset = "0xD84AF0", VA = "0x180D85AF0")]
		get
		{
			return default(NativeList<MIFKFPHADFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<FDCGJNDCDCD> BMKLKAAONKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xCB1FA0", Offset = "0xCB0FA0", VA = "0x180CB1FA0")]
		get
		{
			return default(NativeList<FDCGJNDCDCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<MIFKFPHADFM> LCLCNLCOLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1183A50", Offset = "0x1182A50", VA = "0x181183A50")]
		get
		{
			return default(NativeList<MIFKFPHADFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x80D1F0", Offset = "0x80C1F0", VA = "0x18080D1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NMLHCBNDABE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A0F1E0", Offset = "0x2A0E1E0", VA = "0x182A0F1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F270", Offset = "0x2A0E270", VA = "0x182A0F270")]
	public MFLHDAEOBPP(Allocator JEOILJEOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F170", Offset = "0x2A0E170", VA = "0x182A0F170")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F080", Offset = "0x2A0E080", VA = "0x182A0F080")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A0EEB0", Offset = "0x2A0DEB0", VA = "0x182A0EEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DE860", Offset = "0x37DD860", VA = "0x1837DE860")]
		public OAGDPOPOBDF(BBNANJDJDKF FPFLBEGAJEB, bool NGKHKIFAGPC, uint JKGBPKEJAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x37DE830", Offset = "0x37DD830", VA = "0x1837DE830", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D4280", Offset = "0x37D3280", VA = "0x1837D4280")]
			public AJCNCDCKOAB(PNNNHCANNGD EHDENJOEBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x37D4250", Offset = "0x37D3250", VA = "0x1837D4250", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D63B0", Offset = "0x37D53B0", VA = "0x1837D63B0")]
			public DOAEDIHIIDP(PNNNHCANNGD EHDENJOEBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x37D4250", Offset = "0x37D3250", VA = "0x1837D4250", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37E0100", Offset = "0x37DF100", VA = "0x1837E0100")]
		public PNNNHCANNGD(BBNANJDJDKF OPAAEBMKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x37E00D0", Offset = "0x37DF0D0", VA = "0x1837E00D0")]
		public bool HMALHJBFIIP(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x37E0080", Offset = "0x37DF080", VA = "0x1837E0080")]
		public DOAEDIHIIDP FNMAGCAMFPK()
		{
			return default(DOAEDIHIIDP);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x37E0030", Offset = "0x37DF030", VA = "0x1837E0030")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public CICGAJDCBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x37D4B20", Offset = "0x37D3B20", VA = "0x1837D4B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public HOJHEDFHLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x37D94F0", Offset = "0x37D84F0", VA = "0x1837D94F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public AIKAHALICHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x37D4220", Offset = "0x37D3220", VA = "0x1837D4220")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570B0", Offset = "0x6560B0", VA = "0x1806570B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool IELLIODAPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2E02210", Offset = "0x2E01210", VA = "0x182E02210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ILEGIBFBKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2E02370", Offset = "0x2E01370", VA = "0x182E02370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool BACABGEDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2E01CB0", Offset = "0x2E00CB0", VA = "0x182E01CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int INCFKNAHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2E02490", Offset = "0x2E01490", VA = "0x182E02490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int HCNKINHMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2E01820", Offset = "0x2E00820", VA = "0x182E01820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private bool MJOAJNDMFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2E03370", Offset = "0x2E02370", VA = "0x182E03370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private bool PJMIIPMPHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2E01770", Offset = "0x2E00770", VA = "0x182E01770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FMOJPHEMMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x873160", Offset = "0x872160", VA = "0x180873160", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x703630", Offset = "0x702630", VA = "0x180703630", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private ActionBuffer DBNCPCPCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E02270", Offset = "0x2E01270", VA = "0x182E02270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action FAKJDHABAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2E03020", Offset = "0x2E02020", VA = "0x182E03020", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2E016D0", Offset = "0x2E006D0", VA = "0x182E016D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action DMBICFDMLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E02630", Offset = "0x2E01630", VA = "0x182E02630")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2E01780", Offset = "0x2E00780", VA = "0x182E01780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2E01DC0", Offset = "0x2E00DC0", VA = "0x182E01DC0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2E01870", Offset = "0x2E00870", VA = "0x182E01870", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2E01450", Offset = "0x2E00450", VA = "0x182E01450", Slot = "14")]
	public IDisposable AJCNPDBBLIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2E026D0", Offset = "0x2E016D0", VA = "0x182E026D0", Slot = "9")]
	public IDisposable KEPOHAOMOBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2E01610", Offset = "0x2E00610", VA = "0x182E01610", Slot = "6")]
	public UndoAction BBALAJBEALO()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2E032B0", Offset = "0x2E022B0", VA = "0x182E032B0", Slot = "15")]
	public RedoAction PFKEPJGCIIA()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2E02E00", Offset = "0x2E01E00", VA = "0x182E02E00", Slot = "16")]
	public UndoAction NLLJNOLHHMN()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2E03190", Offset = "0x2E02190", VA = "0x182E03190", Slot = "7")]
	public RedoAction PFKEPJGCIIA(UndoAction MCOKHJALNGG)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2E02EC0", Offset = "0x2E01EC0", VA = "0x182E02EC0", Slot = "8")]
	public UndoAction NLLJNOLHHMN(RedoAction MCOKHJALNGG)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2E02430", Offset = "0x2E01430", VA = "0x182E02430")]
	public bool JFPKNALJNDC(DIBKGKEHLCJ JCCOIDOODME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E02280", Offset = "0x2E01280", VA = "0x182E02280", Slot = "17")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E01D00", Offset = "0x2E00D00", VA = "0x182E01D00")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2E030C0", Offset = "0x2E020C0", VA = "0x182E030C0")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2E02550", Offset = "0x2E01550", VA = "0x182E02550")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E02FE0", Offset = "0x2E01FE0", VA = "0x182E02FE0")]
	private void NNGDKFKGMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2E02D40", Offset = "0x2E01D40", VA = "0x182E02D40")]
	private void NIMADPCBEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E021A0", Offset = "0x2E011A0", VA = "0x182E021A0")]
	private void IBAEKFOLKBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2E02730", Offset = "0x2E01730", VA = "0x182E02730")]
	private DNOIGEFBDOI MLMOINDGNGJ()
	{
		return default(DNOIGEFBDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2E02470", Offset = "0x2E01470", VA = "0x182E02470")]
	private uint JIKCNGKHDPO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E02D80", Offset = "0x2E01D80", VA = "0x182E02D80")]
	private bool NKGHIOOOGEE(out DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E01BB0", Offset = "0x2E00BB0", VA = "0x182E01BB0")]
	private bool GJMFNEDBEBJ(out DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E01B50", Offset = "0x2E00B50", VA = "0x182E01B50")]
	private RedoAction GEFPBOMIEMC(DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2E02DA0", Offset = "0x2E01DA0", VA = "0x182E02DA0")]
	private UndoAction NKGPADIEHKE(DNOIGEFBDOI CGKOOFFNHKL)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E02950", Offset = "0x2E01950", VA = "0x182E02950")]
	private DNOIGEFBDOI MNKKCLEBONM(DNOIGEFBDOI CGKOOFFNHKL, ActionBuffer PNPICJPKOOO, bool NGKHKIFAGPC)
	{
		return default(DNOIGEFBDOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2E01BD0", Offset = "0x2E00BD0", VA = "0x182E01BD0")]
	private void GKPICFMHNIB(Action CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x27AD4F0", Offset = "0x27AC4F0", VA = "0x1827AD4F0")]
	private T GKPICFMHNIB<T>(Func<T> CLLGAPDCKOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E02600", Offset = "0x2E01600", VA = "0x182E02600")]
	private OAGDPOPOBDF JPAKMGAOJKH(bool NGKHKIFAGPC, uint JKGBPKEJAFA)
	{
		return default(OAGDPOPOBDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2E03450", Offset = "0x2E02450", VA = "0x182E03450")]
	public BBNANJDJDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E019A0", Offset = "0x2E009A0", VA = "0x182E019A0")]
	[CompilerGenerated]
	private UndoAction EFENJMFOEMJ()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E02030", Offset = "0x2E01030", VA = "0x182E02030")]
	[CompilerGenerated]
	private RedoAction HJCBNPKGOOM()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E014B0", Offset = "0x2E004B0", VA = "0x182E014B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x657BD0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xD8B490", Offset = "0xD8A490", VA = "0x180D8B490")]
	public ALOABDNNCOH(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD3B0", Offset = "0x2DFC3B0", VA = "0x182DFD3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x657BD0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xD8B490", Offset = "0xD8A490", VA = "0x180D8B490")]
	public DFNLOEACJNA(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D630", Offset = "0x2E0C630", VA = "0x182E0D630")]
	public static DFNLOEACJNA PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2677500", Offset = "0x2676500", VA = "0x182677500")]
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
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x657BD0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xD8B490", Offset = "0xD8A490", VA = "0x180D8B490")]
	public LADBHLGEIAG(NativeArray<byte> DEJEDNNJILK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B5A0", Offset = "0x2A0A5A0", VA = "0x182A0B5A0")]
	public static LADBHLGEIAG PAAEKNCKHBI(NativeArray<byte> DEJEDNNJILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2733190", Offset = "0x2732190", VA = "0x182733190")]
	public void KLNDOHCMIPB<T>(in T IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2733090", Offset = "0x2732090", VA = "0x182733090")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FC1A0", Offset = "0x29FB1A0", VA = "0x1829FC1A0")]
	public static Span<byte> IDMCGBAPNDN(this NativeArray<byte> DEJEDNNJILK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x29FC330", Offset = "0x29FB330", VA = "0x1829FC330")]
	public static ReadOnlySpan<byte> OKENLMHDDLL(this NativeArray<byte> DEJEDNNJILK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x29FC120", Offset = "0x29FB120", VA = "0x1829FC120")]
	public static NativeArray<byte> DPOLEKKKHDH(this NativeArray<byte> DEJEDNNJILK, int FOACNEHDHLI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x29FC2B0", Offset = "0x29FB2B0", VA = "0x1829FC2B0")]
	public static NativeArray<byte> OJEJJAOBCPK(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2E3CBF0", Offset = "0x2E3BBF0", VA = "0x182E3CBF0")]
	public static NativeArray<byte> OJEJJAOBCPK<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x29FC0B0", Offset = "0x29FB0B0", VA = "0x1829FC0B0")]
	public static NativeArray<byte> DHJIGDKLEJD(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B650", Offset = "0x2E3A650", VA = "0x182E3B650")]
	public static NativeArray<byte> DHJIGDKLEJD<T>(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x29FC230", Offset = "0x29FB230", VA = "0x1829FC230")]
	public static NativeArray<byte> JNBHMLCCDDP(this NativeArray<byte> DEJEDNNJILK, int KOHJDBBJEKM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3B6B0", Offset = "0x2E3A6B0", VA = "0x182E3B6B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xD8B490", Offset = "0xD8A490", VA = "0x180D8B490")]
	public OGDIBALDCID(NativeList<byte> LPDILHBGHIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2A12990", Offset = "0x2A11990", VA = "0x182A12990")]
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
			[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2A44E10", Offset = "0x2A43E10", VA = "0x182A44E10")]
		public AJAOFNBLAEO.FLKBEGGKJAK EMJANLIPHLL()
		{
			return default(AJAOFNBLAEO.FLKBEGGKJAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2A44FC0", Offset = "0x2A43FC0", VA = "0x182A44FC0", Slot = "4")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2A44E30", Offset = "0x2A43E30", VA = "0x182A44E30", Slot = "5")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2A44EE0", Offset = "0x2A43EE0", VA = "0x182A44EE0")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2A44880", Offset = "0x2A43880", VA = "0x182A44880")]
		public void BBALAJBEALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2A449B0", Offset = "0x2A439B0", VA = "0x182A449B0")]
		private void CDNHMDGGJND(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2A45040", Offset = "0x2A44040", VA = "0x182A45040")]
		private void PMHJCCMIPME(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2A44F00", Offset = "0x2A43F00", VA = "0x182A44F00")]
		private void JGHIEEKMOGH(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2A44DF0", Offset = "0x2A43DF0", VA = "0x182A44DF0")]
		private void EIOFHIIOEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2A45020", Offset = "0x2A44020", VA = "0x182A45020")]
		private void OFHHJDAAEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2A44CE0", Offset = "0x2A43CE0", VA = "0x182A44CE0")]
		private void DBNOLHGKCJK(FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3BA1760", Offset = "0x3BA0760", VA = "0x183BA1760", Slot = "6")]
		private void CPJJPHAHFBM<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, object NAHJDDBGMOA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2A44DD0", Offset = "0x2A43DD0", VA = "0x182A44DD0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E12210", Offset = "0x2E11210", VA = "0x182E12210", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2E12430", Offset = "0x2E11430", VA = "0x182E12430", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2E12130", Offset = "0x2E11130", VA = "0x182E12130")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2E12610", Offset = "0x2E11610", VA = "0x182E12610")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH NBLOFIBAGPM, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2E122F0", Offset = "0x2E112F0", VA = "0x182E122F0")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2E12080", Offset = "0x2E11080", VA = "0x182E12080")]
	private void GNAEPMLLAHH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2E12530", Offset = "0x2E11530", VA = "0x182E12530")]
	public void NNLLHPJFGFJ(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH NBLOFIBAGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2E11F60", Offset = "0x2E10F60", VA = "0x182E11F60")]
	private void FOIPNFGCADH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2E126A0", Offset = "0x2E116A0", VA = "0x182E126A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37D4910", Offset = "0x37D3910", VA = "0x1837D4910")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public PNOAMILFIOA[] EKMFDNHBMAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x37D4960", Offset = "0x37D3960", VA = "0x1837D4960")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656F40", VA = "0x180657F40")]
			public CDHPABBFADE(ActionBuffer NGHDPLBLION)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x37D4A30", Offset = "0x37D3A30", VA = "0x1837D4A30")]
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
				[Cpp2IlInjected.Address(RVA = "0x37E0480", Offset = "0x37DF480", VA = "0x1837E0480")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public List<(FNGBJBLKAGG, string, object)> NHKMBMIHGFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x37E05D0", Offset = "0x37DF5D0", VA = "0x1837E05D0")]
			public PNOAMILFIOA(ActionBuffer NGHDPLBLION, DNOIGEFBDOI CGKOOFFNHKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x37E04D0", Offset = "0x37DF4D0", VA = "0x1837E04D0")]
			private string MNNGHMGNCLK(FNGBJBLKAGG OOCIDKJPIOF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x37E0140", Offset = "0x37DF140", VA = "0x1837E0140")]
			private void ENJHCNHMIBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2B041B0", Offset = "0x2B031B0", VA = "0x182B041B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DFF400", Offset = "0x2DFE400", VA = "0x182DFF400")]
			get
			{
				return default(MIDCJAGGIEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int MNCJKLLDCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2DFF3C0", Offset = "0x2DFE3C0", VA = "0x182DFF3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFC20", Offset = "0x2DFEC20", VA = "0x182DFFC20")]
		public ActionBuffer(PFMJKBAICGE DOPKECBLDKN, GKJELINCFGM GMKKBMEMHOP, bool LFNJOLCMBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEED0", Offset = "0x2DFDED0", VA = "0x182DFEED0")]
		public bool AOHIPLPKOPI(out DNOIGEFBDOI CGKOOFFNHKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF440", Offset = "0x2DFE440", VA = "0x182DFF440")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEF60", Offset = "0x2DFDF60", VA = "0x182DFEF60")]
		public DNOIGEFBDOI BBALAJBEALO(PCCDBOGEHKL EMOEAFOOMOP, OMEALIIIEBE HKLMDPOAHBO, uint MACLFOOLELI)
		{
			return default(DNOIGEFBDOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFBA0", Offset = "0x2DFEBA0", VA = "0x182DFFBA0")]
		public bool PGPNAAAHLHB(uint MACLFOOLELI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF740", Offset = "0x2DFE740", VA = "0x182DFF740")]
		public bool NLOBGHHGCBK(uint MACLFOOLELI, out DNOIGEFBDOI MCOKHJALNGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF0A0", Offset = "0x2DFE0A0", VA = "0x182DFF0A0")]
		public void BICGJHKILCF(DNOIGEFBDOI MCOKHJALNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF4B0", Offset = "0x2DFE4B0", VA = "0x182DFF4B0")]
		[Conditional("DEBUG_BUILD")]
		private void LICEHBBBAGP(DNOIGEFBDOI MCOKHJALNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF5F0", Offset = "0x2DFE5F0", VA = "0x182DFF5F0")]
		private void MNKKCLEBONM(DNOIGEFBDOI CPFNLJNHLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF930", Offset = "0x2DFE930", VA = "0x182DFF930")]
		private void NNPIEJGEBCL(DFNLOEACJNA PNAPLCCMKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF210", Offset = "0x2DFE210", VA = "0x182DFF210")]
		private void DFGKMIHFNDC(DNOIGEFBDOI CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF2E0", Offset = "0x2DFE2E0", VA = "0x182DFF2E0")]
		private DFNLOEACJNA GMMABANMJAE(DNOIGEFBDOI CGKOOFFNHKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF270", Offset = "0x2DFE270", VA = "0x182DFF270", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6576E0", Offset = "0x6566E0", VA = "0x1806576E0")]
	public KANEHMFPCBA(PFMJKBAICGE DOPKECBLDKN, GKJELINCFGM GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x271C580", Offset = "0x271B580", VA = "0x18271C580", Slot = "4")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> OEIAJJJNONB, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A07510", Offset = "0x2A06510", VA = "0x182A07510")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D7850", Offset = "0x37D6850", VA = "0x1837D7850")]
		public FLKBEGGKJAK(AJAOFNBLAEO ADECAOLBLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x37D7830", Offset = "0x37D6830", VA = "0x1837D7830", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DFCF60", Offset = "0x2DFBF60", VA = "0x182DFCF60")]
		get
		{
			return default(PCCDBOGEHKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool IDBIMIDLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD080", Offset = "0x2DFC080", VA = "0x182DFD080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD220", Offset = "0x2DFC220", VA = "0x182DFD220")]
	public AJAOFNBLAEO(PCCDBOGEHKL.NJDDOFJAKLO FLLNAFOKHKF = PCCDBOGEHKL.NJDDOFJAKLO.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCF50", Offset = "0x2DFBF50", VA = "0x182DFCF50")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCE60", Offset = "0x2DFBE60", VA = "0x182DFCE60")]
	public void HFJOEDICIOL(NMEJDFJAOOA JBKJOONHJLG, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD190", Offset = "0x2DFC190", VA = "0x182DFD190")]
	public void OJNKHPLKBCO(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCFA0", Offset = "0x2DFBFA0", VA = "0x182DFCFA0")]
	public void JMHFDEONHGH(NMEJDFJAOOA JBKJOONHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCD30", Offset = "0x2DFBD30", VA = "0x182DFCD30")]
	public void EIOFHIIOEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD090", Offset = "0x2DFC090", VA = "0x182DFD090")]
	public void OFHHJDAAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCD20", Offset = "0x2DFBD20", VA = "0x182DFCD20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCE30", Offset = "0x2DFBE30", VA = "0x182DFCE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x283F2D0", Offset = "0x283E2D0", VA = "0x18283F2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x677050", VA = "0x180678050")]
	public FNGBJBLKAGG(NMEJDFJAOOA JBKJOONHJLG, JLCDNMLCNEN ABEODFEGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x29FDF00", Offset = "0x29FCF00", VA = "0x1829FDF00")]
	public void CIELANHJLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x29FDF50", Offset = "0x29FCF50", VA = "0x1829FDF50", Slot = "4")]
	public int CompareTo(FNGBJBLKAGG HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x29FE110", Offset = "0x29FD110", VA = "0x1829FE110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x29FDF90", Offset = "0x29FCF90", VA = "0x1829FDF90", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x29FE030", Offset = "0x29FD030", VA = "0x1829FE030", Slot = "5")]
	public bool Equals(FNGBJBLKAGG HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x29FDF10", Offset = "0x29FCF10", VA = "0x1829FDF10")]
	public static bool CJJJLAGEFIA(FNGBJBLKAGG AIAIDPGGDMM, FNGBJBLKAGG PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x29FE0C0", Offset = "0x29FD0C0", VA = "0x1829FE0C0")]
	public static bool HNHKEOFMCPG(FNGBJBLKAGG AIAIDPGGDMM, FNGBJBLKAGG PHPKEGMGOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x29FE080", Offset = "0x29FD080", VA = "0x1829FE080", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFC00", Offset = "0x29FEC00", VA = "0x1829FFC00")]
	public void FMDFEBBBNGL(NMEJDFJAOOA JBKJOONHJLG, PFMJKBAICGE DOPKECBLDKN, BBNANJDJDKF OPAAEBMKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x29FFD10", Offset = "0x29FED10", VA = "0x1829FFD10", Slot = "4")]
	private void JIBFDNGLIKM(FJCEHGNCBHG HLOAMKBCFBD, in MJADMLMEADH IGJPNMBCJPK, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public GMMEMAKMEGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CEGIDICONDL
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2E04190", Offset = "0x2E03190", VA = "0x182E04190")]
	public static void PMHJCCMIPME(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF, EGINIKJHFLB NNGDKGHPHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2E03F30", Offset = "0x2E02F30", VA = "0x182E03F30")]
	public static void DFCNCGBBNCO(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2E040A0", Offset = "0x2E030A0", VA = "0x182E040A0")]
	public static void JGHIEEKMOGH(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2E03FF0", Offset = "0x2E02FF0", VA = "0x182E03FF0")]
	public static void DPKALFJIABE(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2E04140", Offset = "0x2E03140", VA = "0x182E04140")]
	public static EGINIKJHFLB OCMFIABCIME(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF)
	{
		return default(EGINIKJHFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x27C4C50", Offset = "0x27C3C50", VA = "0x1827C4C50")]
	public static T JDBCMJCKMFA<T>(PCCDBOGEHKL EMOEAFOOMOP, FNGBJBLKAGG OOCIDKJPIOF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x27C4C20", Offset = "0x27C3C20", VA = "0x1827C4C20")]
	public static T JDBCMJCKMFA<T>(ref DFNLOEACJNA JANIFNADDOP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2E040F0", Offset = "0x2E030F0", VA = "0x182E040F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DBC10", Offset = "0x37DAC10", VA = "0x1837DBC10")]
		public JHIJODPMNDK(PCCDBOGEHKL LPDILHBGHIJ, OMEALIIIEBE HKLMDPOAHBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x37DB8E0", Offset = "0x37DA8E0", VA = "0x1837DB8E0")]
		public void OHOPKGJFIIG(NativeList<byte> KCFDLMABGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x37DB410", Offset = "0x37DA410", VA = "0x1837DB410")]
		private void DIDCFOHFPIO(FNGBJBLKAGG OOCIDKJPIOF, ref LADBHLGEIAG LOBIAKACGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x37DBB80", Offset = "0x37DAB80", VA = "0x1837DBB80")]
		private void OPFBMFPCDAI(FNGBJBLKAGG OOCIDKJPIOF, ref LADBHLGEIAG LOBIAKACGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x37DB320", Offset = "0x37DA320", VA = "0x1837DB320")]
		private NativeArray<byte> DGGBLLIKJKE(NativeList<byte> KCFDLMABGLC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x37DB460", Offset = "0x37DA460", VA = "0x1837DB460")]
		private NativeArray<byte> DPFFEOIDPFJ(NativeList<byte> KCFDLMABGLC, int GKPOMAIMOAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x37DB550", Offset = "0x37DA550", VA = "0x1837DB550")]
		private int FFCFNADCOCO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x37DB780", Offset = "0x37DA780", VA = "0x1837DB780")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D4180", Offset = "0x37D3180", VA = "0x1837D4180")]
		internal AHPENAOMGDJ(PCCDBOGEHKL LPDILHBGHIJ, FNGBJBLKAGG IKPEGPHMIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x37D3F00", Offset = "0x37D2F00", VA = "0x1837D3F00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x37D3F90", Offset = "0x37D2F90", VA = "0x1837D3F90")]
		public void MNMMOHPJBAG(NativeArray<byte> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x37D3F30", Offset = "0x37D2F30", VA = "0x1837D3F30")]
		public void LOAAJLCEDOJ(NativeArray<byte> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x37D4170", Offset = "0x37D3170", VA = "0x1837D4170")]
		public void OPFBMFPCDAI(in MJADMLMEADH IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x26DEB30", Offset = "0x26DDB30", VA = "0x1826DEB30")]
		public void OPFBMFPCDAI<T>(T IGJPNMBCJPK) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x37D4050", Offset = "0x37D3050", VA = "0x1837D4050")]
		private void OIBAELPIFGF(int IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x37D40C0", Offset = "0x37D30C0", VA = "0x1837D40C0")]
		private void OIBAELPIFGF(in MJADMLMEADH IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x37D3FF0", Offset = "0x37D2FF0", VA = "0x1837D3FF0")]
		private unsafe void OIBAELPIFGF(void* JKEHENDBNEL, int GKPOMAIMOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x37D3F90", Offset = "0x37D2F90", VA = "0x1837D3F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D77F0", Offset = "0x37D67F0", VA = "0x1837D77F0")]
		internal FLIPDAJLJCG(PCCDBOGEHKL LPDILHBGHIJ, NativeArray<byte> JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x37D7530", Offset = "0x37D6530", VA = "0x1837D7530", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x37D7540", Offset = "0x37D6540", VA = "0x1837D7540")]
		public NativeArray<byte> EKHBPDLBOLE(int GKPOMAIMOAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x37D7700", Offset = "0x37D6700", VA = "0x1837D7700")]
		public NativeArray<byte> KIDLKJHGFME()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x26E2FD0", Offset = "0x26E1FD0", VA = "0x1826E2FD0")]
		public T ICHDBDEGGEB<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x37D7600", Offset = "0x37D6600", VA = "0x1837D7600")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DC350", Offset = "0x37DB350", VA = "0x1837DC350", Slot = "4")]
			get
			{
				return default(FNGBJBLKAGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x37DC310", Offset = "0x37DB310", VA = "0x1837DC310", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8730", Offset = "0x2DF7730", VA = "0x182DF8730")]
		internal KGGCAOCDBPP(NativeArray<FNGBJBLKAGG> ICAAAENIBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x37DC260", Offset = "0x37DB260", VA = "0x1837DC260", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x37DC2D0", Offset = "0x37DB2D0", VA = "0x1837DC2D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D4620", Offset = "0x37D3620", VA = "0x1837D4620")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x37D46E0", Offset = "0x37D36E0", VA = "0x1837D46E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public NJDDOFJAKLO MHCBPJALCOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x37D4690", Offset = "0x37D3690", VA = "0x1837D4690")]
			get
			{
				return default(NJDDOFJAKLO);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x37D46D0", Offset = "0x37D36D0", VA = "0x1837D46D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool IDBIMIDLBJF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x37D46C0", Offset = "0x37D36C0", VA = "0x1837D46C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x37D4670", Offset = "0x37D3670", VA = "0x1837D4670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool LCHHGMADKKG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x37D46F0", Offset = "0x37D36F0", VA = "0x1837D46F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x37D46A0", Offset = "0x37D36A0", VA = "0x1837D46A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x37D4740", Offset = "0x37D3740", VA = "0x1837D4740")]
		public BICHFACMBJK(NJDDOFJAKLO FLLNAFOKHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x37D45F0", Offset = "0x37D35F0", VA = "0x1837D45F0")]
		private int BOPAOPJOHPG(int LBACAALGKLG, int ADAGEIIBOOC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x37D4700", Offset = "0x37D3700", VA = "0x1837D4700")]
		private void PIGMJENILDA(int LBACAALGKLG, int IGJPNMBCJPK, int ADAGEIIBOOC = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x37D4630", Offset = "0x37D3630", VA = "0x1837D4630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A3D290", Offset = "0x2A3C290", VA = "0x182A3D290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool NMLHCBNDABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D230", Offset = "0x2A3C230", VA = "0x182A3D230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LPNHFLONAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2A3CE50", Offset = "0x2A3BE50", VA = "0x182A3CE50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int FDLFNBJLCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D250", Offset = "0x2A3C250", VA = "0x182A3D250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CF50", Offset = "0x2A3BF50", VA = "0x182A3CF50")]
	public static PCCDBOGEHKL DAKLFHBAJIH(NJDDOFJAKLO FLLNAFOKHKF = NJDDOFJAKLO.Last, int MBPNGLLEBOJ = 16, int DJJPPHBDPJF = 256)
	{
		return default(PCCDBOGEHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D950", Offset = "0x2A3C950", VA = "0x182A3D950")]
	private PCCDBOGEHKL(NJDDOFJAKLO FLLNAFOKHKF, int MBPNGLLEBOJ, int DJJPPHBDPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CF90", Offset = "0x2A3BF90", VA = "0x182A3CF90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CDC0", Offset = "0x2A3BDC0", VA = "0x182A3CDC0")]
	public AHPENAOMGDJ CDNHMDGGJND(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(AHPENAOMGDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D2A0", Offset = "0x2A3C2A0", VA = "0x182A3D2A0")]
	public FLIPDAJLJCG KHOGOOFJPNF(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(FLIPDAJLJCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D570", Offset = "0x2A3C570", VA = "0x182A3D570")]
	public bool MJGILDABEFF(FNGBJBLKAGG IKPEGPHMIII, out FLIPDAJLJCG KKJNDEPMACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D330", Offset = "0x2A3C330", VA = "0x182A3D330")]
	public bool LMPMKEPAAAO(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CC70", Offset = "0x2A3BC70", VA = "0x182A3CC70")]
	public bool AFAPKFKLOPA(FNGBJBLKAGG IKPEGPHMIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D760", Offset = "0x2A3C760", VA = "0x182A3D760")]
	public void OEICDAKEGLC(NativeList<byte> KCFDLMABGLC, OMEALIIIEBE HKLMDPOAHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x2DEF680", Offset = "0x2DEE680", VA = "0x182DEF680")]
	public T FMDMOKNGPIL<T>(FNGBJBLKAGG IKPEGPHMIII) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D160", Offset = "0x2A3C160", VA = "0x182A3D160")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CD40", Offset = "0x2A3BD40", VA = "0x182A3CD40")]
	public KGGCAOCDBPP BALJJOIEHDJ()
	{
		return default(KGGCAOCDBPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D380", Offset = "0x2A3C380", VA = "0x182A3D380")]
	private void MCFOLNMELLB(FNGBJBLKAGG IKPEGPHMIII, int FOACNEHDHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CE60", Offset = "0x2A3BE60", VA = "0x182A3CE60")]
	private void CIELANHJLDB(int GKNKFNJFDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D070", Offset = "0x2A3C070", VA = "0x182A3D070")]
	private void FMBEEPJHKAK(FNGBJBLKAGG IKPEGPHMIII, int FOACNEHDHLI, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x326FAB0", Offset = "0x326EAB0", VA = "0x18326FAB0")]
	private static T FMDMOKNGPIL<T>(NativeArray<byte> DEJEDNNJILK, int LBACAALGKLG = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D890", Offset = "0x2A3C890", VA = "0x182A3D890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D850", Offset = "0x2A3C850", VA = "0x182A3D850", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x9DFFF0", Offset = "0x9DEFF0", VA = "0x1809DFFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B600", Offset = "0x2A0A600", VA = "0x182A0B600")]
	public NMEJDFJAOOA GAPONIFMOKO()
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B650", Offset = "0x2A0A650", VA = "0x182A0B650")]
	public void LHCAAPHDADA(NMEJDFJAOOA BHJEHPEEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x11182A0", Offset = "0x11172A0", VA = "0x1811182A0", Slot = "6")]
	public virtual void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x656010", VA = "0x180657010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBB20", Offset = "0x2DFAB20", VA = "0x182DFBB20", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBAD0", Offset = "0x2DFAAD0", VA = "0x182DFBAD0")]
	private void FIDHMGDKEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBA70", Offset = "0x2DFAA70", VA = "0x182DFBA70", Slot = "6")]
	public override void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65D170", VA = "0x18065E170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x29FEC80", Offset = "0x29FDC80", VA = "0x1829FEC80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x29FECD0", Offset = "0x29FDCD0", VA = "0x1829FECD0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x29FE9D0", Offset = "0x29FD9D0", VA = "0x1829FE9D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	private void ODFDNIMGHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x29FE880", Offset = "0x29FD880", VA = "0x1829FE880")]
	private void BBOJCHACFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E052D0", Offset = "0x2E042D0", VA = "0x182E052D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EntityQuery FDBIBPLOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1183A50", Offset = "0x1182A50", VA = "0x181183A50")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EntityQuery CNOAPBHNMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA975B0", Offset = "0xA965B0", VA = "0x180A975B0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EntityQuery HCHPCGPFAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3370", Offset = "0x7C2370", VA = "0x1807C3370")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EntityQuery JNPBIGEPDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2E05830", Offset = "0x2E04830", VA = "0x182E05830")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int PNKDFLFLNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2E05810", Offset = "0x2E04810", VA = "0x182E05810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int BONIDMJCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2E05970", Offset = "0x2E04970", VA = "0x182E05970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int CKNCNGDFGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E058B0", Offset = "0x2E048B0", VA = "0x182E058B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int BOLFPJPMFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2E053C0", Offset = "0x2E043C0", VA = "0x182E053C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int BOLPGKAGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2E04F60", Offset = "0x2E03F60", VA = "0x182E04F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E053E0", Offset = "0x2E043E0", VA = "0x182E053E0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E05500", Offset = "0x2E04500", VA = "0x182E05500", Slot = "6")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2E05270", Offset = "0x2E04270", VA = "0x182E05270", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2E051D0", Offset = "0x2E041D0", VA = "0x182E051D0")]
	public CAOGEMEHCPI DAAPCIDKLDP()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E04F80", Offset = "0x2E03F80", VA = "0x182E04F80")]
	public CAOGEMEHCPI BIIJNFGAHFG()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2E05320", Offset = "0x2E04320", VA = "0x182E05320")]
	public CAOGEMEHCPI GGENMNLMPAD()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E05070", Offset = "0x2E04070", VA = "0x182E05070")]
	public PDCBPHNLNBN BPHEMGAFBAH(PMMHBDBEGAM JBKJOONHJLG)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2E05120", Offset = "0x2E04120", VA = "0x182E05120")]
	public PDCBPHNLNBN BPHEMGAFBAH(Entity GEEFHDFLBEH)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2E05450", Offset = "0x2E04450", VA = "0x182E05450")]
	public CBLLNBPHCKJ KEOMIGEONAO(Entity GEEFHDFLBEH)
	{
		return default(CBLLNBPHCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2E058D0", Offset = "0x2E048D0", VA = "0x182E058D0")]
	private CAOGEMEHCPI PFOKOGKMFHO(EntityQuery JFPFDEFJDBP)
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1B7DF20", Offset = "0x1B7CF20", VA = "0x181B7DF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public int PNKDFLFLNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2E11D80", Offset = "0x2E10D80", VA = "0x182E11D80", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int BONIDMJCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x2E11EB0", Offset = "0x2E10EB0", VA = "0x182E11EB0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int CKNCNGDFGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2E11E80", Offset = "0x2E10E80", VA = "0x182E11E80", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int BOLFPJPMFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2E11190", Offset = "0x2E10190", VA = "0x182E11190", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int BOLPGKAGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2E107D0", Offset = "0x2E0F7D0", VA = "0x182E107D0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int HJDHFKEEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E11980", Offset = "0x2E10980", VA = "0x182E11980", Slot = "43")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int AKKJDCEMEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2E11C30", Offset = "0x2E10C30", VA = "0x182E11C30", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<PMMHBDBEGAM, CBLLNBPHCKJ> PENFFKIPBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2E11810", Offset = "0x2E10810", VA = "0x182E11810", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E10D90", Offset = "0x2E0FD90", VA = "0x182E10D90", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<PMMHBDBEGAM> NNDDOAEECDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2E11750", Offset = "0x2E10750", VA = "0x182E11750", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2E110F0", Offset = "0x2E100F0", VA = "0x182E110F0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2E11240", Offset = "0x2E10240", VA = "0x182E11240", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E10BF0", Offset = "0x2E0FBF0", VA = "0x182E10BF0", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2E119A0", Offset = "0x2E109A0", VA = "0x182E119A0")]
	private void LCDPHGCPODA(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E10D00", Offset = "0x2E0FD00", VA = "0x182E10D00")]
	private void ECCCDPILENL(Entity GEEFHDFLBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E107B0", Offset = "0x2E0F7B0", VA = "0x182E107B0")]
	internal PMMHBDBEGAM AHLIDNNPJGI(Entity GEEFHDFLBEH)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E10B20", Offset = "0x2E0FB20", VA = "0x182E10B20", Slot = "39")]
	public CAOGEMEHCPI DAAPCIDKLDP()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E10850", Offset = "0x2E0F850", VA = "0x182E10850", Slot = "40")]
	public CAOGEMEHCPI BIIJNFGAHFG()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2E11000", Offset = "0x2E10000", VA = "0x182E11000", Slot = "41")]
	public CAOGEMEHCPI GGENMNLMPAD()
	{
		return default(CAOGEMEHCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E10960", Offset = "0x2E0F960", VA = "0x182E10960", Slot = "10")]
	public PDCBPHNLNBN BPHEMGAFBAH(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(PDCBPHNLNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E118B0", Offset = "0x2E108B0", VA = "0x182E118B0", Slot = "11")]
	public CBLLNBPHCKJ KEOMIGEONAO(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(CBLLNBPHCKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E10780", Offset = "0x2E0F780", VA = "0x182E10780", Slot = "32")]
	public bool AEBBOEKMPNE(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E10730", Offset = "0x2E0F730", VA = "0x182E10730", Slot = "28")]
	public void ACKFNLGGLJE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E10AB0", Offset = "0x2E0FAB0", VA = "0x182E10AB0", Slot = "29")]
	public void CHMNDPKCMOJ(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2E11D00", Offset = "0x2E10D00", VA = "0x182E11D00", Slot = "30")]
	public void NONGHDEHHOE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2E111C0", Offset = "0x2E101C0", VA = "0x182E111C0", Slot = "22")]
	public FEMMDHLANDH HFJOEDICIOL(CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E11B70", Offset = "0x2E10B70", VA = "0x182E11B70", Slot = "23")]
	public FEMMDHLANDH MHKAFBIPHPF(CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E11DB0", Offset = "0x2E10DB0", VA = "0x182E11DB0", Slot = "24")]
	public FEMMDHLANDH PACACJLKIEO(NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2E10F60", Offset = "0x2E0FF60", VA = "0x182E10F60", Slot = "25")]
	public DJFJGAJKGKD GEAJKNPCODP()
	{
		return default(DJFJGAJKGKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E114A0", Offset = "0x2E104A0", VA = "0x182E114A0", Slot = "42")]
	public MIABGLBICKE IHEGMFIAJED(EFCIKLEKING NKICFHCCMMH)
	{
		return default(MIABGLBICKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E10E30", Offset = "0x2E0FE30", VA = "0x182E10E30", Slot = "26")]
	public POGPGKFDCLE FECCIBCHBLN()
	{
		return default(POGPGKFDCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E11C50", Offset = "0x2E10C50", VA = "0x182E11C50", Slot = "27")]
	public DJFHIDPOABC NOBCDOCLECL(FEJKANODFOG NKICFHCCMMH)
	{
		return default(DJFHIDPOABC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2E11EE0", Offset = "0x2E10EE0", VA = "0x182E11EE0", Slot = "12")]
	public void PJHBAIJLMNC(NMEJDFJAOOA DBGIPPEDJIM, GIALAGJINEB FGEIHINONNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E11A60", Offset = "0x2E10A60", VA = "0x182E11A60", Slot = "13")]
	public FEMMDHLANDH LFOFKHPGLIF(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return default(FEMMDHLANDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2E10A60", Offset = "0x2E0FA60", VA = "0x182E10A60", Slot = "14")]
	public bool CECLHLMOAFB(PMMHBDBEGAM ADGJAILKBPO, out GIALAGJINEB BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2E11D30", Offset = "0x2E10D30", VA = "0x182E11D30", Slot = "45")]
	public Transform OFFKLJGCIOM(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2E10EE0", Offset = "0x2E0FEE0", VA = "0x182E10EE0", Slot = "16")]
	public bool FPFNOLCEKGF(PMMHBDBEGAM ADGJAILKBPO, out Transform BCHADNCHEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2E10A20", Offset = "0x2E0FA20", VA = "0x182E10A20", Slot = "17")]
	public bool CDOIOEBAIAC(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2E10830", Offset = "0x2E0F830", VA = "0x182E10830")]
	public bool BHOEHOJGMNO(GIALAGJINEB IGJPNMBCJPK, [Optional] object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2E10800", Offset = "0x2E0F800", VA = "0x182E10800", Slot = "46")]
	public bool BHOEHOJGMNO(PMMHBDBEGAM ADGJAILKBPO, [Optional] object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2E11430", Offset = "0x2E10430", VA = "0x182E11430", Slot = "47")]
	public void HKEPNALNJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2E11540", Offset = "0x2E10540", VA = "0x182E11540", Slot = "15")]
	public void IIHMCLDDPGI(GIALAGJINEB CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2E11BF0", Offset = "0x2E10BF0", VA = "0x182E11BF0", Slot = "48")]
	public void NIMKLNCMIKA(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2E10BD0", Offset = "0x2E0FBD0", VA = "0x182E10BD0", Slot = "18")]
	public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2E10B00", Offset = "0x2E0FB00", VA = "0x182E10B00", Slot = "19")]
	public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2E117F0", Offset = "0x2E107F0", VA = "0x182E117F0", Slot = "49")]
	public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2E11A40", Offset = "0x2E10A40", VA = "0x182E11A40", Slot = "50")]
	public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2E11450", Offset = "0x2E10450", VA = "0x182E11450", Slot = "31")]
	public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
	{
		return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2E10F30", Offset = "0x2E0FF30", VA = "0x182E10F30", Slot = "21")]
	public NMEJDFJAOOA GAGENPHPDNI(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(NMEJDFJAOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2E110B0", Offset = "0x2E100B0", VA = "0x182E110B0", Slot = "20")]
	public PMMHBDBEGAM GJELMEFNGNA(NMEJDFJAOOA DBGIPPEDJIM)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A06860", Offset = "0x2A05860", VA = "0x182A06860", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2A06D80", Offset = "0x2A05D80", VA = "0x182A06D80")]
	public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
	{
		return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2A06E80", Offset = "0x2A05E80", VA = "0x182A06E80")]
	private void PGEFBEAPHNN(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2A068F0", Offset = "0x2A058F0", VA = "0x182A068F0")]
	private void HJMHHOHEACI(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB, int GFIKNFBJKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2A066D0", Offset = "0x2A056D0", VA = "0x182A066D0")]
	private void EKHJMELAAHL(NativeMultiHashMap<int, (PMMHBDBEGAM src, PMMHBDBEGAM dst)> GOPJGHNHLNB, int GFIKNFBJKNP, NOBHGMEMAKH GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2A063A0", Offset = "0x2A053A0", VA = "0x182A063A0")]
	private NativeMultiHashMap<int, (PMMHBDBEGAM, PMMHBDBEGAM)> CCCJOFIOKGC(Allocator JEOILJEOOOI, NativeArray<PMMHBDBEGAM> CGGBICHOEDC, out NativeArray<(PMMHBDBEGAM src, PMMHBDBEGAM dst)> DCMEPDOGCMK)
	{
		return default(NativeMultiHashMap<int, (PMMHBDBEGAM, PMMHBDBEGAM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A42480", Offset = "0x2A41480", VA = "0x182A42480", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2A42520", Offset = "0x2A41520", VA = "0x182A42520", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2A427E0", Offset = "0x2A417E0", VA = "0x182A427E0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2A42900", Offset = "0x2A41900", VA = "0x182A42900", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2A425C0", Offset = "0x2A415C0", VA = "0x182A425C0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2A42720", Offset = "0x2A41720", VA = "0x182A42720", Slot = "8")]
		public void EGOGCMBFKGF(PMMHBDBEGAM ADGJAILKBPO, Vector3 BOMEDIENHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2A42D20", Offset = "0x2A41D20", VA = "0x182A42D20", Slot = "9")]
		public bool MJEKGLFLNDP(PMMHBDBEGAM ADGJAILKBPO, out Collider JDJCJCADDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2A42BA0", Offset = "0x2A41BA0", VA = "0x182A42BA0")]
		private void LEIMCIGPFAK(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2A42C60", Offset = "0x2A41C60", VA = "0x182A42C60", Slot = "10")]
		public void MHGCCIIFFLE(PMMHBDBEGAM ADGJAILKBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DFCB00", Offset = "0x2DFBB00", VA = "0x182DFCB00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public EGNDHFFDDFH MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2DFCB70", Offset = "0x2DFBB70", VA = "0x182DFCB70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public EGNDHFFDDFH MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2DFCB70", Offset = "0x2DFBB70", VA = "0x182DFCB70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCB20", Offset = "0x2DFBB20", VA = "0x182DFCB20", Slot = "11")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC6F0", Offset = "0x2DFB6F0", VA = "0x182DFC6F0", Slot = "12")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "13")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC3D0", Offset = "0x2DFB3D0", VA = "0x182DFC3D0")]
	private void AEEMLNFIALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x17FF8C0", Offset = "0x17FE8C0", VA = "0x1817FF8C0")]
	private string MPJCBKINOFO(string BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCA20", Offset = "0x2DFBA20", VA = "0x182DFCA20", Slot = "7")]
	public EGNDHFFDDFH HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC770", Offset = "0x2DFB770", VA = "0x182DFC770")]
	private bool HINDNOFJKBF(Type CJJNIEGEMMA, string BEMAPDNKPAD, out EGNDHFFDDFH KOPJKHIOCNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCB90", Offset = "0x2DFBB90", VA = "0x182DFCB90", Slot = "8")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC6D0", Offset = "0x2DFB6D0", VA = "0x182DFC6D0", Slot = "9")]
	public IEnumerator<EGNDHFFDDFH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC6D0", Offset = "0x2DFB6D0", VA = "0x182DFC6D0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCCA0", Offset = "0x2DFBCA0", VA = "0x182DFCCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A0F670", Offset = "0x2A0E670", VA = "0x182A0F670", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F950", Offset = "0x2A0E950", VA = "0x182A0F950", Slot = "6")]
	public bool MMJKEHCEABE(JLCDNMLCNEN FCDKMJOKGIE, out int MNKEEJPGFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F610", Offset = "0x2A0E610", VA = "0x182A0F610", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F6D0", Offset = "0x2A0E6D0", VA = "0x182A0F6D0", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F6E0", Offset = "0x2A0E6E0", VA = "0x182A0F6E0")]
	private void LFFDHDOPOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F9C0", Offset = "0x2A0E9C0", VA = "0x182A0F9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E04E10", Offset = "0x2E03E10", VA = "0x182E04E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public AEFHEEDIBGN MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2E04E20", Offset = "0x2E03E20", VA = "0x182E04E20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AEFHEEDIBGN MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2E04E20", Offset = "0x2E03E20", VA = "0x182E04E20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "10")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2E04A20", Offset = "0x2E03A20", VA = "0x182E04A20", Slot = "11")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "12")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2E04CE0", Offset = "0x2E03CE0", VA = "0x182E04CE0", Slot = "6")]
	public AEFHEEDIBGN HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2E04E60", Offset = "0x2E03E60", VA = "0x182E04E60", Slot = "7")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2E04940", Offset = "0x2E03940", VA = "0x182E04940", Slot = "8")]
	public IEnumerator<AEFHEEDIBGN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2E04F30", Offset = "0x2E03F30", VA = "0x182E04F30", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2289560", Offset = "0x2288560", VA = "0x182289560", Slot = "13")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2E04800", Offset = "0x2E03800", VA = "0x182E04800", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public CGONEFNHILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2E04E20", Offset = "0x2E03E20", VA = "0x182E04E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x29FF240", Offset = "0x29FE240", VA = "0x1829FF240", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EMNNOKKNGJD MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x29FEE00", Offset = "0x29FDE00", VA = "0x1829FEE00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EMNNOKKNGJD MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x29FEE00", Offset = "0x29FDE00", VA = "0x1829FEE00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "9")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x29FF0A0", Offset = "0x29FE0A0", VA = "0x1829FF0A0", Slot = "10")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x29FF290", Offset = "0x29FE290", VA = "0x1829FF290", Slot = "11")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x29FEE10", Offset = "0x29FDE10", VA = "0x1829FEE10")]
	private EMNNOKKNGJD CPBKPKLOJMD(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x29FF120", Offset = "0x29FE120", VA = "0x1829FF120", Slot = "6")]
	public EMNNOKKNGJD HJBBEPHEFOJ(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x29FF4F0", Offset = "0x29FE4F0", VA = "0x1829FF4F0", Slot = "15")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA JLHBKPIPBGO)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x29FEF90", Offset = "0x29FDF90", VA = "0x1829FEF90", Slot = "7")]
	public IEnumerator<EMNNOKKNGJD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x29FEF90", Offset = "0x29FDF90", VA = "0x1829FEF90", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2534390", Offset = "0x2533390", VA = "0x182534390", Slot = "12")]
	public void LMHMPAODLPN<TKey, T>(global::ALFHNNMHDGP<TKey, T> HLOAMKBCFBD, [Optional] object NAHJDDBGMOA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x29FEEF0", Offset = "0x29FDEF0", VA = "0x1829FEEF0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public GGHCOKGNGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x29FEE00", Offset = "0x29FDE00", VA = "0x1829FEE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D570", VA = "0x18065E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x65E590", Offset = "0x65D590", VA = "0x18065E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2DFAC60", Offset = "0x2DF9C60", VA = "0x182DFAC60", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2DFAD90", Offset = "0x2DF9D90", VA = "0x182DFAD90")]
	private void HMAJIKOHHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x21F8E30", Offset = "0x21F7E30", VA = "0x1821F8E30")]
	public T EPMJKFNKDLP<T>() where T : NOBHGMEMAKH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2DFAB90", Offset = "0x2DF9B90", VA = "0x182DFAB90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DFAE80", Offset = "0x2DF9E80", VA = "0x182DFAE80")]
	public EMNNOKKNGJD OMLLLFEDHJG(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x21F8E60", Offset = "0x21F7E60", VA = "0x1821F8E60")]
	public global::JEBFFIPPOIH<T> OMLLLFEDHJG<T>(IDOKMGKMFNA BEMAPDNKPAD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2DFAAC0", Offset = "0x2DF9AC0", VA = "0x182DFAAC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ADBFMIBHACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class EMAOGJDPBOP
{
	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x2107A30", Offset = "0x2106A30", VA = "0x182107A30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A12350", Offset = "0x2A11350", VA = "0x182A12350", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2A12230", Offset = "0x2A11230", VA = "0x182A12230")]
	public void FKLGBDDBJBJ(NMEJDFJAOOA DBGIPPEDJIM, bool MAGLHKOAFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E90", Offset = "0x8E2E90", VA = "0x1808E3E90")]
		[DebuggerHidden]
		public IHAMDNKGAMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x37D9AE0", Offset = "0x37D8AE0", VA = "0x1837D9AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x37D9730", Offset = "0x37D8730", VA = "0x1837D9730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x37D9B60", Offset = "0x37D8B60", VA = "0x1837D9B60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x37D9AA0", Offset = "0x37D8AA0", VA = "0x1837D9AA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x37D9A10", Offset = "0x37D8A10", VA = "0x1837D9A10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x37D9A10", Offset = "0x37D8A10", VA = "0x1837D9A10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0C440", Offset = "0x2A0B440", VA = "0x182A0C440", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C670", Offset = "0x2A0B670", VA = "0x182A0C670", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B900", Offset = "0x2A0A900", VA = "0x182A0B900", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C560", Offset = "0x2A0B560", VA = "0x182A0C560")]
	private void KBHLNDOADGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BAA0", Offset = "0x2A0AAA0", VA = "0x182A0BAA0")]
	internal void ECILECGFMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B720", Offset = "0x2A0A720", VA = "0x182A0B720")]
	private void CGKODKCKODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C570", Offset = "0x2A0B570", VA = "0x182A0C570")]
	private void KDDGLAAKJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B6D0", Offset = "0x2A0A6D0", VA = "0x182A0B6D0")]
	[IteratorStateMachine(typeof(IHAMDNKGAMG))]
	private IEnumerable<RRCustomPropTag> ANMBLEBPGJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C9E0", Offset = "0x2A0B9E0", VA = "0x182A0C9E0")]
	private void PPFNHMEHPFK(PMMHBDBEGAM ADGJAILKBPO, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C8A0", Offset = "0x2A0B8A0", VA = "0x182A0C8A0")]
	private void PJHBAIJLMNC(SerializableGuid AJPBBJHOAOB, GameObject BFJMKCMPBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C0B0", Offset = "0x2A0B0B0", VA = "0x182A0C0B0")]
	private void GPFDDAHKJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BED0", Offset = "0x2A0AED0", VA = "0x182A0BED0")]
	private bool GGBFCLPHGOL(BFFEIPJHCFH CFEEPLDMJBH, Transform ADECAOLBLPJ, out GameObject HFEGMKMMHDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2A0C510", Offset = "0x2A0B510", VA = "0x182A0C510")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CE60", Offset = "0x2A0BE60", VA = "0x182A0CE60")]
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2A47620", Offset = "0x2A46620", VA = "0x182A47620")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A057E0", Offset = "0x2A047E0", VA = "0x182A057E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PMMHBDBEGAM LKMLFJFEBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2A056B0", Offset = "0x2A046B0", VA = "0x182A056B0", Slot = "9")]
		get
		{
			return default(PMMHBDBEGAM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2A05020", Offset = "0x2A04020", VA = "0x182A05020", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public FEMMDHLANDH JBJKLMKLHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x2A050F0", Offset = "0x2A040F0", VA = "0x182A050F0", Slot = "11")]
		get
		{
			return default(FEMMDHLANDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x2A05020", Offset = "0x2A04020", VA = "0x182A05020", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public FEMMDHLANDH PNIDHCNENFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x2A05CA0", Offset = "0x2A04CA0", VA = "0x182A05CA0", Slot = "13")]
		get
		{
			return default(FEMMDHLANDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private uint JBAKEFOCCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x2A05040", Offset = "0x2A04040", VA = "0x182A05040")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event OJPGCAPGDDC JOAFAFDLHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2A04E60", Offset = "0x2A03E60", VA = "0x182A04E60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2A05D60", Offset = "0x2A04D60", VA = "0x182A05D60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2A055E0", Offset = "0x2A045E0", VA = "0x182A055E0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2A05B00", Offset = "0x2A04B00", VA = "0x182A05B00", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2A05270", Offset = "0x2A04270", VA = "0x182A05270", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2A05900", Offset = "0x2A04900", VA = "0x182A05900")]
	private void KAPLCEIDAGN(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2A05F00", Offset = "0x2A04F00", VA = "0x182A05F00", Slot = "14")]
	public PMMHBDBEGAM NDOCFECCKPD(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC)
	{
		return default(PMMHBDBEGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2A05E00", Offset = "0x2A04E00", VA = "0x182A05E00", Slot = "15")]
	public bool MKDAEBPAGML(PMMHBDBEGAM PJCDGLCJFAM, PMMHBDBEGAM EJPDMNHPBOC, out PMMHBDBEGAM CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2A04F00", Offset = "0x2A03F00", VA = "0x182A04F00", Slot = "16")]
	public void CCAIPLKNAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2A05320", Offset = "0x2A04320", VA = "0x182A05320", Slot = "17")]
	public void FGMIMAHOJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2A05130", Offset = "0x2A04130", VA = "0x182A05130", Slot = "18")]
	public bool DAKLMMCBBPP(PMMHBDBEGAM MCOKHJALNGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2A05340", Offset = "0x2A04340", VA = "0x182A05340")]
	private void GENGBJFCHLO(PMMHBDBEGAM OKOHPFKFJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A04AB0", Offset = "0x2A03AB0", VA = "0x182A04AB0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2A04B30", Offset = "0x2A03B30", VA = "0x182A04B30", Slot = "5")]
	public void NBAKEOIBLIK(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2552060", Offset = "0x2551060", VA = "0x182552060")]
	private void PIGMJENILDA<T>(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A48D30", Offset = "0x2A47D30", VA = "0x182A48D30", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2A48CC0", Offset = "0x2A47CC0", VA = "0x182A48CC0", Slot = "5")]
		public void EOAAHJFAPLD(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2A48C50", Offset = "0x2A47C50", VA = "0x182A48C50", Slot = "6")]
		public void ADKFGLBEHNJ(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2552060", Offset = "0x2551060", VA = "0x182552060")]
		private void PIGMJENILDA<T>(PMMHBDBEGAM JBKJOONHJLG, bool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7180", Offset = "0xCD6180", VA = "0x180CD7180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2A58BF0", Offset = "0x2A57BF0", VA = "0x182A58BF0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF OIDEMDEBBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2A588E0", Offset = "0x2A578E0", VA = "0x182A588E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A587F0", Offset = "0x2A577F0", VA = "0x182A587F0", Slot = "6")]
		public bool DNGEMHOMPML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A583D0", Offset = "0x2A573D0", VA = "0x182A583D0", Slot = "5")]
		public ByteString CCMIFLHPNMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A58D20", Offset = "0x2A57D20", VA = "0x182A58D20")]
		private void IPCEHEDJHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A58D40", Offset = "0x2A57D40", VA = "0x182A58D40")]
		private void JJNPPBKAHKI(BGDMNMCCMEA EJEJEGHNJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A58EB0", Offset = "0x2A57EB0", VA = "0x182A58EB0")]
		private void LLEPKDOKEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2A58910", Offset = "0x2A57910", VA = "0x182A58910")]
		private void EJCNAFIENPL(FCMCKNEAHLO EJEJEGHNJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A58E10", Offset = "0x2A57E10", VA = "0x182A58E10")]
		private BGDMNMCCMEA KJCCHBMKBGB(EntityManager BHDOHAJMONK, EntityManager LGGPCBMPJIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E036A0", Offset = "0x2E026A0", VA = "0x182E036A0")]
	public GameObject EFFOEIOONDP(FEJKANODFOG GKODFJAPBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E03770", Offset = "0x2E02770", VA = "0x182E03770")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4EDC0", Offset = "0x2A4DDC0", VA = "0x182A4EDC0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private DFDDJEKPLDJ KAAPDHONNOL
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x2A4E6E0", Offset = "0x2A4D6E0", VA = "0x182A4E6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A50020", Offset = "0x2A4F020", VA = "0x182A50020", Slot = "33")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A514A0", Offset = "0x2A504A0", VA = "0x182A514A0", Slot = "34")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A4ED20", Offset = "0x2A4DD20", VA = "0x182A4ED20", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A509A0", Offset = "0x2A4F9A0", VA = "0x182A509A0", Slot = "36")]
		public bool IOHJIAHINHM(Transform BCHADNCHEKP, out PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E4A0", Offset = "0x2A4D4A0", VA = "0x182A4E4A0", Slot = "37")]
		public Transform AGDAIJOCIIH(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F170", Offset = "0x2A4E170", VA = "0x182A4F170", Slot = "31")]
		public bool FPFNOLCEKGF(Entity GEEFHDFLBEH, out Transform BCHADNCHEKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FE70", Offset = "0x2A4EE70", VA = "0x182A4FE70")]
		private void HENEKLJDAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EE10", Offset = "0x2A4DE10", VA = "0x182A4EE10", Slot = "30")]
		public void ENFIJGJBBJC(Entity GEEFHDFLBEH, out Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F260", Offset = "0x2A4E260", VA = "0x182A4F260", Slot = "4")]
		public void GDCFJBLAEFP(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A50B50", Offset = "0x2A4FB50", VA = "0x182A50B50")]
		public void JEGCOBOINFI(Entity GEEFHDFLBEH, Vector3 LHHNEMEAJHG, Quaternion FBGPAJBMOPM, Vector3 GBBNBELINHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A52460", Offset = "0x2A51460", VA = "0x182A52460")]
		public void NGNDAEDIDAG(Entity GEEFHDFLBEH, Vector3 LHHNEMEAJHG, Quaternion FBGPAJBMOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E7A0", Offset = "0x2A4D7A0", VA = "0x182A4E7A0", Slot = "28")]
		public void CLBIJEMJFKN(Entity GEEFHDFLBEH, out Matrix4x4 BCODGFOGAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A51720", Offset = "0x2A50720", VA = "0x182A51720")]
		public void LNHEHKAHOPF(Entity GEEFHDFLBEH, in Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FB90", Offset = "0x2A4EB90", VA = "0x182A4FB90")]
		public void GOHBEINHDHC(Entity GEEFHDFLBEH, in Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A50550", Offset = "0x2A4F550", VA = "0x182A50550")]
		public void HMFCIDKHEJF(Entity GEEFHDFLBEH, in Matrix4x4 MBJIIIDIGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A52E30", Offset = "0x2A51E30", VA = "0x182A52E30", Slot = "5")]
		public void PDEOAGACCIA(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A52260", Offset = "0x2A51260", VA = "0x182A52260", Slot = "6")]
		public Vector3 MENJJILCEHP(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EA60", Offset = "0x2A4DA60", VA = "0x182A4EA60", Slot = "7")]
		public void DICBINCKBKB(Entity GEEFHDFLBEH, Quaternion IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FE90", Offset = "0x2A4EE90", VA = "0x182A4FE90", Slot = "8")]
		public Quaternion HFMCOFNJPOM(Entity GEEFHDFLBEH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EF60", Offset = "0x2A4DF60", VA = "0x182A4EF60", Slot = "13")]
		public void FJBCKGJLCCJ(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E390", Offset = "0x2A4D390", VA = "0x182A4E390", Slot = "12")]
		public Vector3 ADKCLDGGKHN(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E560", Offset = "0x2A4D560", VA = "0x182A4E560")]
		public void CAPNDLGCLCP(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FF80", Offset = "0x2A4EF80", VA = "0x182A4FF80")]
		private Vector3 HFOHMELCAED(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FAF0", Offset = "0x2A4EAF0", VA = "0x182A4FAF0", Slot = "15")]
		public float GLBJOAHKOIN(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F060", Offset = "0x2A4E060", VA = "0x182A4F060", Slot = "14")]
		public void FLDLJJGDOIN(Entity GEEFHDFLBEH, float IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A50D50", Offset = "0x2A4FD50", VA = "0x182A50D50")]
		private float KAGCJCCHFLP(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A52570", Offset = "0x2A51570", VA = "0x182A52570")]
		public void NLIANMKJJCD(Entity GEEFHDFLBEH, float BIOIOGONEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E600", Offset = "0x2A4D600", VA = "0x182A4E600", Slot = "17")]
		public Vector3 CCONMBLCOJG(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A50C20", Offset = "0x2A4FC20", VA = "0x182A50C20", Slot = "16")]
		public void JOAFHOOPBPB(Entity GEEFHDFLBEH, Vector3 GBIIEKALBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A52D00", Offset = "0x2A51D00", VA = "0x182A52D00")]
		private Vector3 OOIEPNCLMGM(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A52F50", Offset = "0x2A51F50", VA = "0x182A52F50")]
		public void PMEJAEPCJDL(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FCC0", Offset = "0x2A4ECC0", VA = "0x182A4FCC0")]
		[Conditional("DEBUG_BUILD")]
		private void HBGIOGJMJCJ(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A50800", Offset = "0x2A4F800", VA = "0x182A50800", Slot = "9")]
		public void IGIMCPAJODD(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E890", Offset = "0x2A4D890", VA = "0x182A4E890", Slot = "10")]
		public void DFMLGPGOEDO(Entity GEEFHDFLBEH, out Vector3 EIIEKPIPEEF, out Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E260", Offset = "0x2A4D260", VA = "0x182A4E260", Slot = "11")]
		public void ABEECJHILAL(Entity GEEFHDFLBEH, out Vector3 EIIEKPIPEEF, out Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F450", Offset = "0x2A4E450", VA = "0x182A4F450", Slot = "38")]
		public void GEPKONEEJLH(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EB60", Offset = "0x2A4DB60", VA = "0x182A4EB60")]
		public void DNJDKAOKGCC(Entity GEEFHDFLBEH, Vector3 EIIEKPIPEEF, Quaternion DCNMMHNEEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A526E0", Offset = "0x2A516E0", VA = "0x182A526E0", Slot = "18")]
		public void OFKNBPADOEM(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E7B0", Offset = "0x2A4D7B0", VA = "0x182A4E7B0", Slot = "19")]
		public Vector3 CLFJCLPAKBH(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A52910", Offset = "0x2A51910", VA = "0x182A52910", Slot = "20")]
		public void OHEACAODJHG(Entity GEEFHDFLBEH, Quaternion IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A50710", Offset = "0x2A4F710", VA = "0x182A50710", Slot = "21")]
		public Quaternion HPOEHICNFDK(Entity GEEFHDFLBEH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A51AE0", Offset = "0x2A50AE0", VA = "0x182A51AE0", Slot = "23")]
		public void LPJGJCPGHDM(Entity GEEFHDFLBEH, Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A52370", Offset = "0x2A51370", VA = "0x182A52370", Slot = "22")]
		public Vector3 NDKBPDMGFLI(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A51F40", Offset = "0x2A50F40", VA = "0x182A51F40", Slot = "24")]
		public void MCOFOPEKKHL(Entity GEEFHDFLBEH, float NOGNCKMINCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F670", Offset = "0x2A4E670", VA = "0x182A4F670", Slot = "25")]
		public float GIPJABDAFPD(Entity GEEFHDFLBEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A51030", Offset = "0x2A50030", VA = "0x182A51030", Slot = "26")]
		public void KGIMIHGFFKJ(Entity GEEFHDFLBEH, Vector3 HLJBHGNEKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A515E0", Offset = "0x2A505E0", VA = "0x182A515E0", Slot = "27")]
		public Vector3 LHBMJKPGAEL(Entity GEEFHDFLBEH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A50120", Offset = "0x2A4F120", VA = "0x182A50120", Slot = "32")]
		public void HLDLPBDPLCI(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A50F70", Offset = "0x2A4FF70", VA = "0x182A50F70")]
		private void KCGHDKMLABK(Entity GEEFHDFLBEH, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A50E40", Offset = "0x2A4FE40", VA = "0x182A50E40")]
		private void KCGHDKMLABK(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E9E0", Offset = "0x2A4D9E0", VA = "0x182A4E9E0")]
		private CBEDOBDLKDB DFMLGPGOEDO(Entity GEEFHDFLBEH)
		{
			return default(CBEDOBDLKDB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A52600", Offset = "0x2A51600", VA = "0x182A52600")]
		private bool OEKEPNLPDKP(Entity GEEFHDFLBEH, out Entity ADECAOLBLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A52B50", Offset = "0x2A51B50", VA = "0x182A52B50")]
		private void OHEIMGGEINO(Entity GEEFHDFLBEH, out Matrix4x4 INCBGLDKNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A4F790", Offset = "0x2A4E790", VA = "0x182A4F790")]
		public void GJOIDGHOKGE(Entity GEEFHDFLBEH, out Matrix4x4 MBJIIIDIGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A515D0", Offset = "0x2A505D0", VA = "0x182A515D0", Slot = "29")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DC6B0", Offset = "0x37DB6B0", VA = "0x1837DC6B0")]
		public KPAELHCBEAM(KPOGCKFKBHN ADECAOLBLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x37DC690", Offset = "0x37DB690", VA = "0x1837DC690", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x11AC890", Offset = "0x11AB890", VA = "0x1811AC890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action DMGKGMNLMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B090", Offset = "0x2A0A090", VA = "0x182A0B090")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A0AFF0", Offset = "0x2A09FF0", VA = "0x182A0AFF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AFC0", Offset = "0x2A09FC0", VA = "0x182A0AFC0")]
	public KPAELHCBEAM EMJANLIPHLL()
	{
		return default(KPAELHCBEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x19C2360", Offset = "0x19C1360", VA = "0x1819C2360")]
	public void EIOFHIIOEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B130", Offset = "0x2A0A130", VA = "0x182A0B130")]
	public void OFHHJDAAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E13760", Offset = "0x2E12760", VA = "0x182E13760", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E133C0", Offset = "0x2E123C0", VA = "0x182E133C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E138C0", Offset = "0x2E128C0", VA = "0x182E138C0", Slot = "5")]
		public void JOAFAFDLHBM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E13510", Offset = "0x2E12510", VA = "0x182E13510")]
		public void FDGIICJJLJE(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2E13DF0", Offset = "0x2E12DF0", VA = "0x182E13DF0")]
		private void LLAMLFGGEPA(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E13F40", Offset = "0x2E12F40", VA = "0x182E13F40")]
		private void LMKNIIFIMNG(EEJHBIOBFFI PBOJAOCFJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2E13450", Offset = "0x2E12450", VA = "0x182E13450")]
		private void EPINLCBCGAP(int FOACNEHDHLI, int CBNJCJLIEMJ, bool JBAGPIKPAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E140B0", Offset = "0x2E130B0", VA = "0x182E140B0")]
		private int PDBNPGHGLHE(EEJHBIOBFFI PBOJAOCFJPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E13930", Offset = "0x2E12930", VA = "0x182E13930")]
		private bool KICPHIFHCNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E13680", Offset = "0x2E12680", VA = "0x182E13680")]
		private void HDGEFIDHCGK(NativeArray<int> PNDAKPENJKM, NativeArray<int> LGLGGCHFNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E13380", Offset = "0x2E12380", VA = "0x182E13380")]
		private void CPBEAMDOLJN(NativeArray<int> PNDAKPENJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E13810", Offset = "0x2E12810", VA = "0x182E13810")]
		private void IECNCFOJGPG(NativeArray<int> LGLGGCHFNDI, NativeArray<int> PNDAKPENJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2E14120", Offset = "0x2E13120", VA = "0x182E14120")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public HLNEBDOHNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x37D9430", Offset = "0x37D8430", VA = "0x1837D9430")]
		internal void <InitPhase>b__1(FDFFINEAOHD svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x37D9490", Offset = "0x37D8490", VA = "0x1837D9490")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2F60", Offset = "0x8C1F60", VA = "0x1808C2F60", Slot = "4")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE280", Offset = "0x2DFD280", VA = "0x182DFE280", Slot = "5")]
	public void KEACOMCKNJG(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE150", Offset = "0x2DFD150", VA = "0x182DFE150", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3336100", Offset = "0x3335100", VA = "0x183336100", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x3336160", Offset = "0x3335160", VA = "0x183336160", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x33360D0", Offset = "0x33350D0", VA = "0x1833360D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761B40", VA = "0x180762B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x711170", Offset = "0x710170", VA = "0x180711170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3336040", Offset = "0x3335040", VA = "0x183336040")]
	public PGBBKILBNAD(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL, bool EFNCJMHMODB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x3335C90", Offset = "0x3334C90", VA = "0x183335C90", Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x29469E0", Offset = "0x29459E0", VA = "0x1829469E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x3335CF0", Offset = "0x3334CF0", VA = "0x183335CF0", Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3335D50", Offset = "0x3334D50", VA = "0x183335D50", Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x3335E60", Offset = "0x3334E60", VA = "0x183335E60", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x3335ED0", Offset = "0x3334ED0", VA = "0x183335ED0", Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3335F30", Offset = "0x3334F30", VA = "0x183335F30", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x3335FE0", Offset = "0x3334FE0", VA = "0x183335FE0", Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x3335FB0", Offset = "0x3334FB0", VA = "0x183335FB0", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x28CE820", Offset = "0x28CD820", VA = "0x1828CE820", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x3354F40", Offset = "0x3353F40", VA = "0x183354F40", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x3354F90", Offset = "0x3353F90", VA = "0x183354F90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x3354F00", Offset = "0x3353F00", VA = "0x183354F00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x677020", VA = "0x180678020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7200", Offset = "0x2AC6200", VA = "0x182AC7200")]
	public KNDIDAPDONF(Func<From, To> DMOLCMIDIPC, Func<To, From> NKGCIMMLMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x3354B10", Offset = "0x3353B10", VA = "0x183354B10", Slot = "11")]
	public void Add(To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x3354B50", Offset = "0x3353B50", VA = "0x183354B50", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x3354B90", Offset = "0x3353B90", VA = "0x183354B90", Slot = "13")]
	public bool Contains(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3354C50", Offset = "0x3353C50", VA = "0x183354C50", Slot = "14")]
	public void CopyTo(To[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3354D10", Offset = "0x3353D10", VA = "0x183354D10", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x3354DD0", Offset = "0x3353DD0", VA = "0x183354DD0", Slot = "6")]
	public int IndexOf(To GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x3354E40", Offset = "0x3353E40", VA = "0x183354E40", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, To GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3354EC0", Offset = "0x3353EC0", VA = "0x183354EC0", Slot = "15")]
	public bool Remove(To GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x3354E80", Offset = "0x3353E80", VA = "0x183354E80", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x204ABE0", Offset = "0x2049BE0", VA = "0x18204ABE0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public IJICCCLBHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x37DA240", Offset = "0x37D9240", VA = "0x1837DA240")]
		internal void <InitServices>b__1(FDFFINEAOHD svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x37DA2A0", Offset = "0x37D92A0", VA = "0x1837DA2A0")]
		internal void <InitServices>b__2(CDAFEBOKDJF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2A04C10", Offset = "0x2A03C10", VA = "0x182A04C10")]
	public static void JIBLLCBPHAA(this PGLNEDJDCBK HADAJAKADAH, FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x25CDE30", Offset = "0x25CCE30", VA = "0x1825CDE30")]
	public static void AEFBIIJCLFD<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x25CE470", Offset = "0x25CD470", VA = "0x1825CE470")]
	public static void MJOOJNAOFOC<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x25CDEA0", Offset = "0x25CCEA0", VA = "0x1825CDEA0")]
	public static void BHGNGPPJFFM<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x25CE050", Offset = "0x25CD050", VA = "0x1825CE050")]
	public static void EOBOHMBELMH<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x25CE200", Offset = "0x25CD200", VA = "0x1825CE200")]
	public static void HNBFGOPBLKN<T>(this PGLNEDJDCBK HADAJAKADAH, Action<T> MBOOMOIFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x25CE3B0", Offset = "0x25CD3B0", VA = "0x1825CE3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public ACKFBCCPEHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD2E0", Offset = "0x2DFC2E0", VA = "0x182DFD2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4AFE0", Offset = "0x2A49FE0", VA = "0x182A4AFE0")]
		public static void ADPJAIEJIPK(this AJDCMAAKGND FJKJAKKFINM, HNBJONKGAEL IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B730", Offset = "0x2A4A730", VA = "0x182A4B730")]
		public static void MJAGDEDIGFF(this AJDCMAAKGND FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2A4AED0", Offset = "0x2A49ED0", VA = "0x182A4AED0")]
		public static void ADPJAIEJIPK(this AJDCMAAKGND FJKJAKKFINM, [Optional] string[] NHEECPNNGOE, [Optional] string[] BCGBBPKGNDB, [Optional] string[] ELPAIOJMBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B680", Offset = "0x2A4A680", VA = "0x182A4B680")]
		public static void HIILFCBENND(this AJDCMAAKGND FJKJAKKFINM, params string[] EONPIJDEEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B5D0", Offset = "0x2A4A5D0", VA = "0x182A4B5D0")]
		public static void EIENEIBFFPP(this AJDCMAAKGND FJKJAKKFINM, params string[] EONPIJDEEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B3D0", Offset = "0x2A4A3D0", VA = "0x182A4B3D0")]
		private static string[] DOBIMILCEFD(HNBJONKGAEL IDKBHBKJHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B210", Offset = "0x2A4A210", VA = "0x182A4B210")]
		private static bool BLKLDHBOHAG(HNBJONKGAEL IDKBHBKJHPJ, out string[] BCCBKDAADNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659D00", VA = "0x18065AD00")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0F560", Offset = "0x2A0E560", VA = "0x182A0F560")]
	public MLBHKFFBLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action EHLKLCIKDHM();

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F370", Offset = "0x2A0E370", VA = "0x182A0F370")]
	public MethodInfo EPIONIGHEEB(Action CGKOOFFNHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F3B0", Offset = "0x2A0E3B0", VA = "0x182A0F3B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A3E850", Offset = "0x2A3D850", VA = "0x182A3E850", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BJCNAIMNHPD<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E8E0", Offset = "0x2A3D8E0", VA = "0x182A3E8E0")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D740", Offset = "0x2A0C740", VA = "0x182A0D740")]
	protected PKCAMOGFFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class NDKHFJCHDBL : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2A10A00", Offset = "0x2A0FA00", VA = "0x182A10A00", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void DCHPHCIDLGC<T>() where T : KCJNPCKFNOM;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2A10A90", Offset = "0x2A0FA90", VA = "0x182A10A90")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D740", Offset = "0x2A0C740", VA = "0x182A0D740")]
	protected NDKHFJCHDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class LICOIIFNCGA : MLBHKFFBLLH
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D620", Offset = "0x2A0C620", VA = "0x182A0D620", Slot = "5")]
	public override Action EHLKLCIKDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EJLHODOHNCH<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D6B0", Offset = "0x2A0C6B0", VA = "0x182A0D6B0")]
	[Preserve]
	public void NGDCICJKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D740", Offset = "0x2A0C740", VA = "0x182A0D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IJONKAEAEBK GNIOAJCHNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EHIDJEIAFME NFGMALDPBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public AOAMPDCFJGB KHNOEBOIBMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public DDMIOFGHMGI HODIGNDEBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CBIPFLGDJEF OFOEMMHFELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x65E570", Offset = "0x65D570", VA = "0x18065E570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public HFHHBKPAPIM HCLFBFBADHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x65E580", Offset = "0x65D580", VA = "0x18065E580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public DDPHBMAAHDP LLJLHOBLFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x6560D0", VA = "0x1806570D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public NEKBEAHJEHF ENPNLKBHPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x66D760", Offset = "0x66C760", VA = "0x18066D760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public ELFIPEDOAPI NFMMDNGOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6570B0", Offset = "0x6560B0", VA = "0x1806570B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GKHHEJLDBHG PFJBMLEAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x66D770", Offset = "0x66C770", VA = "0x18066D770", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public ODMPAIDMGCI LBNDLOLGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x66D780", Offset = "0x66C780", VA = "0x18066D780", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BPHIPABMBKD ACECADJDOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x66D700", Offset = "0x66C700", VA = "0x18066D700", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NKGHFOCFECH IJPKIJCIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x66D710", Offset = "0x66C710", VA = "0x18066D710", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public BFIAFBHOKLF GMAGOKAFPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6936D0", Offset = "0x6926D0", VA = "0x1806936D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public LBPAJLMGMFA CPAHMDPHOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x65DD80", Offset = "0x65CD80", VA = "0x18065DD80", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DOFEFFJAEBG IGCBBCBKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x65DE20", Offset = "0x65CE20", VA = "0x18065DE20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public EIANDBIEFDL MEPAMLDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x6936A0", Offset = "0x6926A0", VA = "0x1806936A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public MMBKMNPPHBO JELINFEJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x66D720", Offset = "0x66C720", VA = "0x18066D720", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public LIACDBEGOKA HOBOELBHFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x66D730", Offset = "0x66C730", VA = "0x18066D730", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public MIBPANHFFGK MJDHCGHFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x67DAA0", Offset = "0x67CAA0", VA = "0x18067DAA0", Slot = "21")]
		get
		{
			return default(MIBPANHFFGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2A10BB0", Offset = "0x2A0FBB0", VA = "0x182A10BB0", Slot = "22")]
	public void KEACOMCKNJG(FFPEBHHNJFF OIDEMDEBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2A10B80", Offset = "0x2A0FB80", VA = "0x182A10B80", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2A10B90", Offset = "0x2A0FB90", VA = "0x182A10B90", Slot = "23")]
	public void JOAFAFDLHBM(FFPEBHHNJFF OIDEMDEBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D790", Offset = "0x66C790", VA = "0x18066D790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DA8E0", Offset = "0x37D98E0", VA = "0x1837DA8E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x65B200", Offset = "0x65A200", VA = "0x18065B200")]
		[DebuggerHidden]
		public JEEFNHOFEFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x37DA730", Offset = "0x37D9730", VA = "0x1837DA730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x37DA8A0", Offset = "0x37D98A0", VA = "0x1837DA8A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x657BD0", VA = "0x180658BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6FB410", Offset = "0x6FA410", VA = "0x1806FB410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int OFOJBFDCABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x672C90", Offset = "0x671C90", VA = "0x180672C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6FB320", Offset = "0x6FA320", VA = "0x1806FB320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2A3F540", Offset = "0x2A3E540", VA = "0x182A3F540")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EC90", Offset = "0x2A3DC90", VA = "0x182A3EC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F940", Offset = "0x2A3E940", VA = "0x182A3F940")]
	public PPONMINLDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F9C0", Offset = "0x2A3E9C0", VA = "0x182A3F9C0")]
	public PPONMINLDEP(int AIGDDFDNOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3EBB0", Offset = "0x2A3DBB0", VA = "0x182A3EBB0")]
	public bool EDEOOALDLJB(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F5E0", Offset = "0x2A3E5E0", VA = "0x182A3F5E0")]
	public bool KGJNCFBHIBI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F7C0", Offset = "0x2A3E7C0", VA = "0x182A3F7C0")]
	public bool OHAHAJGPFNC(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F930", Offset = "0x2A3E930", VA = "0x182A3F930")]
	public bool PPICPACFBLI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F390", Offset = "0x2A3E390", VA = "0x182A3F390")]
	public void JGFIDBHEAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F6D0", Offset = "0x2A3E6D0", VA = "0x182A3F6D0")]
	public void OAHEOEBHHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F840", Offset = "0x2A3E840", VA = "0x182A3F840")]
	public void PIGMJENILDA(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F290", Offset = "0x2A3E290", VA = "0x182A3F290")]
	public void IIOELKEIHEG(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F000", Offset = "0x2A3E000", VA = "0x182A3F000")]
	public bool FLEBLELMNAN(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F420", Offset = "0x2A3E420", VA = "0x182A3F420")]
	public void KDOMIKFMFKI(int LBACAALGKLG, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A3EE40", Offset = "0x2A3DE40", VA = "0x182A3EE40")]
	public void EPIIJGJJGPF(int DOOFIFHOCKH, int JBFIBBGJOJJ, int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F170", Offset = "0x2A3E170", VA = "0x182A3F170")]
	public int HEFJCCLOLGO(int KOHJDBBJEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F100", Offset = "0x2A3E100", VA = "0x182A3F100")]
	public int HEFJCCLOLGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F240", Offset = "0x2A3E240", VA = "0x182A3F240")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F090", Offset = "0x2A3E090", VA = "0x182A3F090", Slot = "4")]
	[IteratorStateMachine(typeof(JEEFNHOFEFA))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F090", Offset = "0x2A3E090", VA = "0x182A3F090", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1767530", Offset = "0x1766530", VA = "0x181767530")]
	public NACIFLLMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x219CB10", Offset = "0x219BB10", VA = "0x18219CB10")]
	public NACIFLLMCPL(global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x219C7D0", Offset = "0x219B7D0", VA = "0x18219C7D0", Slot = "11")]
	public override T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x219C420", Offset = "0x219B420", VA = "0x18219C420", Slot = "12")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class CLBPJFGNMHN
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x22986C0", Offset = "0x22976C0", VA = "0x1822986C0")]
	public static JLCDNMLCNEN PJHBAIJLMNC<T>(this KJJHEOCLACN GMKKBMEMHOP, global::NBBJGEJPPKL<T> BEMAPDNKPAD, global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL) where T : struct
	{
		return default(JLCDNMLCNEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class DJACPONAHMA<T> : global::NACIFLLMCPL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x4674530", Offset = "0x4673530", VA = "0x184674530")]
	public DJACPONAHMA(T OCIAEJCLHLN, T GEOHKIDILGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public sealed class NCLKMOCKEDG<T> : global::DEKKGELEEDA<T> where T : struct, KCJNPCKFNOM
{
	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7170", Offset = "0x2FB6170", VA = "0x182FB7170", Slot = "11")]
	public override T HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7110", Offset = "0x2FB6110", VA = "0x182FB7110", Slot = "12")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2454B00", Offset = "0x2453B00", VA = "0x182454B00")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D0040", Offset = "0x28CF040", VA = "0x1828D0040", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x28D0A70", Offset = "0x28CFA70", VA = "0x1828D0A70", Slot = "8")]
	public override void HJFKJCGGCHL(LIEODINBDBP IONGKOPBOLO, in ECNLJAAGJFG MCOKHJALNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x28CF420", Offset = "0x28CE420", VA = "0x1828CF420", Slot = "9")]
	public override void DGAMFOBEJMM(LIEODINBDBP IONGKOPBOLO, in MJADMLMEADH IKPEGPHMIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x28D13D0", Offset = "0x28D03D0", VA = "0x1828D13D0", Slot = "10")]
	public override void ICJPMMDCBBM(LIEODINBDBP IONGKOPBOLO, JIOPCPMKLHK EMCMEEJENIP, object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C9E990", Offset = "0x1C9D990", VA = "0x181C9E990")]
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
			[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
			public IEPGJEEIGBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x1989250", Offset = "0x1988250", VA = "0x181989250")]
			internal void <RegisterFixedString>b__0(LIEODINBDBP p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x19894C0", Offset = "0x19884C0", VA = "0x1819894C0")]
			internal T <RegisterFixedString>b__1(LIEODINBDBP p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x37D9670", Offset = "0x37D8670", VA = "0x1837D9670")]
		public static void FKHONKNHOOA(CHKDLDDGMPK NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x26EC4D0", Offset = "0x26EB4D0", VA = "0x1826EC4D0")]
		private static void NOIBEAIHDLK<T>(CHKDLDDGMPK NIGMPMDPOOJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x26EC440", Offset = "0x26EB440", VA = "0x1826EC440")]
		private static void DCJPAFAMHDK<T>(LIEODINBDBP JOLHNMOCKDJ, T HFMHCLGICNJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x26EBDF0", Offset = "0x26EADF0", VA = "0x1826EBDF0")]
		private static T BJAEKAJKDLH<T>(LIEODINBDBP JOLHNMOCKDJ, int GEOHKIDILGK) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x26ED5A0", Offset = "0x26EC5A0", VA = "0x1826ED5A0", Slot = "6")]
		public override void BJCNAIMNHPD<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x37DE010", Offset = "0x37DD010", VA = "0x1837DE010")]
		public static void JFALGCMELEE(CHKDLDDGMPK NIGMPMDPOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x37DE0A0", Offset = "0x37DD0A0", VA = "0x1837DE0A0")]
		public LODMJJFLPCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2E15DD0", Offset = "0x2E14DD0", VA = "0x182E15DD0")]
	public static void CNHPCJEGFKL(CHKDLDDGMPK NIGMPMDPOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2E30500", Offset = "0x2E2F500", VA = "0x182E30500")]
	public static void CNAHKNDDACG<T>(CHKDLDDGMPK NIGMPMDPOOJ, global::ADPPKKLLOAG<T> NHGODJCEDDK, global::AEIJCHDEEMK<T> HEEJCHPDFDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2E30590", Offset = "0x2E2F590", VA = "0x182E30590")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E10250", Offset = "0x2E0F250", VA = "0x182E10250")]
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
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761B40", VA = "0x180762B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x711170", Offset = "0x710170", VA = "0x180711170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A00630", Offset = "0x29FF630", VA = "0x182A00630")]
	public GMOBIMICHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A00570", Offset = "0x29FF570", VA = "0x182A00570")]
	public GMOBIMICHHB(Dictionary<JLCDNMLCNEN, PPMKAONFAIG> NIGMPMDPOOJ, bool CFBDLDCFAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x29FFF00", Offset = "0x29FEF00", VA = "0x1829FFF00", Slot = "7")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x29FFE30", Offset = "0x29FEE30", VA = "0x1829FFE30", Slot = "8")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x29FFEB0", Offset = "0x29FEEB0", VA = "0x1829FFEB0", Slot = "9")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2A004A0", Offset = "0x29FF4A0", VA = "0x182A004A0", Slot = "4")]
	public JLCDNMLCNEN PNBEDJJEPEI(IDOKMGKMFNA BEMAPDNKPAD)
	{
		return default(JLCDNMLCNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2A00330", Offset = "0x29FF330", VA = "0x182A00330", Slot = "5")]
	public void PJHBAIJLMNC(JLCDNMLCNEN FCDKMJOKGIE, PPMKAONFAIG CFPIMFIOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x29FFF60", Offset = "0x29FEF60", VA = "0x1829FFF60")]
	[Conditional("DEBUG_BUILD")]
	private void KMADGIFDFIH(JLCDNMLCNEN FCDKMJOKGIE, Type NKICFHCCMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2A000A0", Offset = "0x29FF0A0", VA = "0x182A000A0", Slot = "6")]
	public bool KNMEGLCAMII(JLCDNMLCNEN FCDKMJOKGIE, out PPMKAONFAIG CFPIMFIOLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2A00250", Offset = "0x29FF250", VA = "0x182A00250", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6718D0", Offset = "0x6708D0", VA = "0x1806718D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x693000", Offset = "0x692000", VA = "0x180693000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x29FDB60", Offset = "0x29FCB60", VA = "0x1829FDB60")]
	public FLHLECHEOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x29FDAA0", Offset = "0x29FCAA0", VA = "0x1829FDAA0")]
	public FLHLECHEOIJ(Dictionary<Type, PPMKAONFAIG> NIGMPMDPOOJ, bool CFBDLDCFAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x29FD720", Offset = "0x29FC720", VA = "0x1829FD720", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x29FD940", Offset = "0x29FC940", VA = "0x1829FD940", Slot = "5")]
	public void PJHBAIJLMNC(Type NKICFHCCMMH, PPMKAONFAIG CFPIMFIOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x29FD780", Offset = "0x29FC780", VA = "0x1829FD780", Slot = "6")]
	public bool KNMEGLCAMII(Type NKICFHCCMMH, out PPMKAONFAIG CFPIMFIOLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x29FD860", Offset = "0x29FC860", VA = "0x1829FD860", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A04900", Offset = "0x2A03900", VA = "0x182A04900", Slot = "6")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2A048A0", Offset = "0x2A038A0", VA = "0x182A048A0", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2A049C0", Offset = "0x2A039C0", VA = "0x182A049C0", Slot = "4")]
	public void PJHBAIJLMNC(JLCDNMLCNEN ABEODFEGJBP, Type KICHMDFNHJN, DOGACPAEELJ OEINDPCLNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2A04950", Offset = "0x2A03950", VA = "0x182A04950", Slot = "5")]
	public bool NKPEADBAMEJ(JLCDNMLCNEN ABEODFEGJBP, out DOGACPAEELJ OEINDPCLNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2A04710", Offset = "0x2A03710", VA = "0x182A04710")]
	[Conditional("DEBUG_BUILD")]
	private void HBPBOKBOOKK(JLCDNMLCNEN ABEODFEGJBP, Type KICHMDFNHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2A04A30", Offset = "0x2A03A30", VA = "0x182A04A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x29FBF60", Offset = "0x29FAF60", VA = "0x1829FBF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool DEFKNPLGKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x722540", Offset = "0x721540", VA = "0x180722540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x9656A0", Offset = "0x9646A0", VA = "0x1809656A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x29FB9B0", Offset = "0x29FA9B0", VA = "0x1829FB9B0", Slot = "6")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x29FBB60", Offset = "0x29FAB60", VA = "0x1829FBB60", Slot = "7")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x29FBC90", Offset = "0x29FAC90", VA = "0x1829FBC90", Slot = "8")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x29FBAC0", Offset = "0x29FAAC0", VA = "0x1829FBAC0")]
	private void EHKNKBCLFJE(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x29FBBE0", Offset = "0x29FABE0", VA = "0x1829FBBE0", Slot = "4")]
	public bool JKMNJDNCGFM(NMEJDFJAOOA DBGIPPEDJIM, JLCDNMLCNEN HLOAMKBCFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x29FBD40", Offset = "0x29FAD40", VA = "0x1829FBD40", Slot = "5")]
	public void NCKAKJEMCHK(NMEJDFJAOOA DBGIPPEDJIM, Span<JLCDNMLCNEN> GMKKBMEMHOP, bool IFINFNLHHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x29FB9B0", Offset = "0x29FA9B0", VA = "0x1829FB9B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x29FBFB0", Offset = "0x29FAFB0", VA = "0x1829FBFB0")]
	public FHIOIFIIDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class DIFANBBCPAA
{
	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D750", Offset = "0x2E0C750", VA = "0x182E0D750")]
	public static void ADGGKAPKBFK(this LIEODINBDBP IONGKOPBOLO, ReadOnlyMemory<byte> HFNFJCAIOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x267A9D0", Offset = "0x26799D0", VA = "0x18267A9D0")]
	public static void FJGIJIFMICL<T>(this LIEODINBDBP IONGKOPBOLO, in T IGJPNMBCJPK) where T : struct, KCJNPCKFNOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x267AB00", Offset = "0x2679B00", VA = "0x18267AB00")]
	public static T INFOCGEPMKK<T>(this LIEODINBDBP IONGKOPBOLO) where T : struct, KCJNPCKFNOM
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D7D0", Offset = "0x2E0C7D0", VA = "0x182E0D7D0")]
	public static void FJGIJIFMICL(this LIEODINBDBP IONGKOPBOLO, AHHBCIFGLKD MKJJIEOPNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D800", Offset = "0x2E0C800", VA = "0x182E0D800")]
	public static AHHBCIFGLKD IHHICDGMLOH(this LIEODINBDBP IONGKOPBOLO)
	{
		return default(AHHBCIFGLKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D950", Offset = "0x2E0C950", VA = "0x182E0D950")]
	public static void PDMBADLPGPD(this LIEODINBDBP MLMFBHHJDGG, uint KDILLIFJBAB, bool IKEEKKBIKHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D830", Offset = "0x2E0C830", VA = "0x182E0D830")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public MCMDIKCOCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x301EE90", Offset = "0x301DE90", VA = "0x18301EE90")]
		internal void <GetByteEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x301EF00", Offset = "0x301DF00", VA = "0x18301EF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public PODBDOJNCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x37C3940", Offset = "0x37C2940", VA = "0x1837C3940")]
		internal void <GetSByteEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x37C39B0", Offset = "0x37C29B0", VA = "0x1837C39B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public DPJDMLFJDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x3772750", Offset = "0x3771750", VA = "0x183772750")]
		internal void <GetShortEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x37727C0", Offset = "0x37717C0", VA = "0x1837727C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public DDDLHDLIJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x28CD680", Offset = "0x28CC680", VA = "0x1828CD680")]
		internal void <GetUShortEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x28CD6F0", Offset = "0x28CC6F0", VA = "0x1828CD6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public MDNDOBPABLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x30222C0", Offset = "0x30212C0", VA = "0x1830222C0")]
		internal void <GetIntEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3022320", Offset = "0x3021320", VA = "0x183022320")]
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
		[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
		public EKJHNAHJOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEAE0", Offset = "0x1CADAE0", VA = "0x181CAEAE0")]
		internal void <GetUIntEnumDelegates>b__0(LIEODINBDBP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEB40", Offset = "0x1CADB40", VA = "0x181CAEB40")]
		internal T <GetUIntEnumDelegates>b__1(LIEODINBDBP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x25DF1F0", Offset = "0x25DE1F0", VA = "0x1825DF1F0")]
	public static void JFLMAPNOFGN<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x25DEF50", Offset = "0x25DDF50", VA = "0x1825DEF50")]
	private static void BLMDOAOIMHH<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x25DEF50", Offset = "0x25DDF50", VA = "0x1825DEF50")]
	private static void POPMCBJMLJP<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x25DEE00", Offset = "0x25DDE00", VA = "0x1825DEE00")]
	private static void MIOBCDGBBAN<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x25DEE00", Offset = "0x25DDE00", VA = "0x1825DEE00")]
	private static void AOFHIEHMIOC<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x25DF0A0", Offset = "0x25DE0A0", VA = "0x1825DF0A0")]
	private static void JGHCKDJLCEC<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x25DF0A0", Offset = "0x25DE0A0", VA = "0x1825DF0A0")]
	private static void IINAIGGFAAD<T>(T OCIAEJCLHLN, T GEOHKIDILGK, out global::ADPPKKLLOAG<T> FMDAEJMJOEP, out global::AEIJCHDEEMK<T> GLCIHANPKJM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public abstract class CPJOAFBACJL : BOLFBGCGJHF, CDAFEBOKDJF
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2E06420", Offset = "0x2E05420", VA = "0x182E06420", Slot = "4")]
	private void LKONOPAGGKI(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LECGAABEIOL(KJJHEOCLACN GMKKBMEMHOP);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
	protected CPJOAFBACJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[AGGLFMPJHMG(typeof(LocalPoseData))]
public sealed class BLHLFHAGAIK : CPJOAFBACJL
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2E03B70", Offset = "0x2E02B70", VA = "0x182E03B70", Slot = "5")]
	protected override void LECGAABEIOL(KJJHEOCLACN GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A00760", Offset = "0x29FF760", VA = "0x182A00760", Slot = "4")]
	public bool Equals(LNHLLFKMJJK HNOJKNGFFBE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x736040", VA = "0x180737040")]
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
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x736040", VA = "0x180737040")]
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
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707D90", VA = "0x180708D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8B0600", Offset = "0x8AF600", VA = "0x1808B0600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xEAA480", Offset = "0xEA9480", VA = "0x180EAA480", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2A007B0", Offset = "0x29FF7B0", VA = "0x182A007B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2A00760", Offset = "0x29FF760", VA = "0x182A00760", Slot = "8")]
	public bool Equals(HDIMMDIONOF HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2A007F0", Offset = "0x29FF7F0", VA = "0x182A007F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class FPEBBPOHPPF : ParentSystemBase<AuthoredParentData, HDLOBHOIHNH, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x29FE7B0", Offset = "0x29FD7B0", VA = "0x1829FE7B0", Slot = "14")]
	protected override EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7016B0", VA = "0x1807026B0", Slot = "15")]
	protected override EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x29FE770", Offset = "0x29FD770", VA = "0x1829FE770", Slot = "16")]
	protected override EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x29FE730", Offset = "0x29FD730", VA = "0x1829FE730", Slot = "17")]
	protected override EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x29FE830", Offset = "0x29FD830", VA = "0x1829FE830")]
	public FPEBBPOHPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x29FE7F0", Offset = "0x29FD7F0", VA = "0x1829FE7F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D5A50", Offset = "0x37D4A50", VA = "0x1837D5A50")]
			public DAOGBIHJNFE(HDIMMDIONOF MIGDJNOKMHC, float3 EIIEKPIPEEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x37D5A30", Offset = "0x37D4A30", VA = "0x1837D5A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
			public MAJDNBHGGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
			public IDCMJDPABOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
			public HFPHMGCFMCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37DC610", Offset = "0x37DB610", VA = "0x1837DC610")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600058F")]
				[Cpp2IlInjected.Address(RVA = "0x37DC550", Offset = "0x37DB550", VA = "0x1837DC550")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DCA90", Offset = "0x37DBA90", VA = "0x1837DCA90")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, WorldPoseData JFKBEONBDEB, in DynamicBuffer<BCGNKDMNODC> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x37DCCD0", Offset = "0x37DBCD0", VA = "0x1837DCCD0", Slot = "5")]
			public void ReadFromDisplayClass(ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x37DCD00", Offset = "0x37DBD00", VA = "0x1837DCD00", Slot = "6")]
			public void WriteToDisplayClass(ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x37DC7C0", Offset = "0x37DB7C0", VA = "0x1837DC7C0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x37DC950", Offset = "0x37DB950", VA = "0x1837DC950")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref KLCIBDBGDKE.ODNGCGDEBMO PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x37DC910", Offset = "0x37DB910", VA = "0x1837DC910")]
			public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ, ref MAJDNBHGGKI CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x37DC8A0", Offset = "0x37DB8A0", VA = "0x1837DC8A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37DBFD0", Offset = "0x37DAFD0", VA = "0x1837DBFD0")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000596")]
				[Cpp2IlInjected.Address(RVA = "0x37DBF30", Offset = "0x37DAF30", VA = "0x1837DBF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D7080", Offset = "0x37D6080", VA = "0x1837D7080")]
			internal void POIJCEOICMD(in WorldPoseData JFKBEONBDEB, in DynamicBuffer<LNHLLFKMJJK> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x37D6240", Offset = "0x37D5240", VA = "0x1837D6240", Slot = "5")]
			public void ReadFromDisplayClass(ref IDCMJDPABOF CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x37D6E40", Offset = "0x37D5E40", VA = "0x1837D6E40", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x37D6FB0", Offset = "0x37D5FB0", VA = "0x1837D6FB0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref KDBKHHONECG.CLJCBBMJEAI PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x37D6F10", Offset = "0x37D5F10", VA = "0x1837D6F10")]
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
				[Cpp2IlInjected.Address(RVA = "0x37DE450", Offset = "0x37DD450", VA = "0x1837DE450")]
				public void LONPEHHIFCO(UpdateConnectableVisuals OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600059D")]
				[Cpp2IlInjected.Address(RVA = "0x37DE380", Offset = "0x37DD380", VA = "0x1837DE380")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D9D90", Offset = "0x37D8D90", VA = "0x1837D9D90")]
			internal void POIJCEOICMD(in WorldPoseData JFKBEONBDEB, in CAJJCLKLGOM LCODFDEFNPG, in DynamicBuffer<LNHLLFKMJJK> PBHDPEJBGCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x37D6240", Offset = "0x37D5240", VA = "0x1837D6240", Slot = "5")]
			public void ReadFromDisplayClass(ref HFPHMGCFMCO CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x37D9BB0", Offset = "0x37D8BB0", VA = "0x1837D9BB0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x37D9C70", Offset = "0x37D8C70", VA = "0x1837D9C70")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref NBEECHMBMMD.AEMNPDNKMCB PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x37D9C30", Offset = "0x37D8C30", VA = "0x1837D9C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A54E70", Offset = "0x2A53E70", VA = "0x182A54E70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2A53AC0", Offset = "0x2A52AC0", VA = "0x182A53AC0")]
		internal ODDCBCICFNM DBLMFLLDADB(HDIMMDIONOF MIGDJNOKMHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x2A54B50", Offset = "0x2A53B50", VA = "0x182A54B50", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x2A566C0", Offset = "0x2A556C0", VA = "0x182A566C0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x2A56850", Offset = "0x2A55850", VA = "0x182A56850", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2A56480", Offset = "0x2A55480", VA = "0x182A56480", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2A53470", Offset = "0x2A52470", VA = "0x182A53470")]
		private void AMGJKIINAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2A53970", Offset = "0x2A52970", VA = "0x182A53970")]
		private void BGLGGKOKAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2A55DA0", Offset = "0x2A54DA0", VA = "0x182A55DA0")]
		private void KLKFABFKPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2A56890", Offset = "0x2A55890", VA = "0x182A56890", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2A55670", Offset = "0x2A54670", VA = "0x182A55670")]
		private void JBCFLHJDAGD(EntityQuery BCEJPCNJJCE, EntityQuery JEGEKBCLIDO, EntityQuery GDFDIGMMCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2A533A0", Offset = "0x2A523A0", VA = "0x182A533A0")]
		private void AKJLIPOIGHF(EntityQuery GDFDIGMMCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2A54C10", Offset = "0x2A53C10", VA = "0x182A54C10")]
		private void HLKMKDJBMNE(global::OHBAMBCHLEK<Entity> PFHHBJBMJNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2A57190", Offset = "0x2A56190", VA = "0x182A57190")]
		private void POCPHLCGLHH(global::OHBAMBCHLEK<Entity> CDCMOCAOHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2A548F0", Offset = "0x2A538F0", VA = "0x182A548F0")]
		private void FKDOMINAOPC(global::OHBAMBCHLEK<Entity> OIJFDMIKPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2A53FC0", Offset = "0x2A52FC0", VA = "0x182A53FC0")]
		private void DLKDNGDBFPE(NativeList<HDIMMDIONOF> CGLIDIBELOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2A54130", Offset = "0x2A53130", VA = "0x182A54130")]
		private NativeList<HDIMMDIONOF> EHCMIFOEHDA(NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(NativeList<HDIMMDIONOF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2A56B60", Offset = "0x2A55B60", VA = "0x182A56B60")]
		private void PFLKGFHEELP(NativeArray<Entity> FBMJMNCDHDM, NativeList<HDIMMDIONOF> CGLIDIBELOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2A54EB0", Offset = "0x2A53EB0", VA = "0x182A54EB0")]
		private void IFKFOBFCAHC(NativeArray<Entity> BFNKKPHBOMC, NativeArray<Entity> DPOBAKHBGJO, NativeList<HDIMMDIONOF> NFMFOGHBEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2A53B10", Offset = "0x2A52B10", VA = "0x182A53B10")]
		private void DCPFKPHFGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2A547B0", Offset = "0x2A537B0", VA = "0x182A547B0")]
		private global::AFBJNMJHLIH<DAOGBIHJNFE> FDHHLJMLGBG(EntityQuery JFPFDEFJDBP, Func<NativeList<DAOGBIHJNFE>, JobHandle> PJIHFBPLBLO)
		{
			return default(global::AFBJNMJHLIH<DAOGBIHJNFE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2A53580", Offset = "0x2A52580", VA = "0x182A53580")]
		private JobHandle BADABDFPCNL(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2A54670", Offset = "0x2A53670", VA = "0x182A54670")]
		private JobHandle EKOHHILIPNF(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x2A56150", Offset = "0x2A55150", VA = "0x182A56150")]
		private JobHandle MGHJLADJONE(NativeList<DAOGBIHJNFE> LPDILHBGHIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x2A53110", Offset = "0x2A52110", VA = "0x182A53110")]
		private void AKCJIAKBIJA(global::AFBJNMJHLIH<DAOGBIHJNFE> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2A553E0", Offset = "0x2A543E0", VA = "0x182A553E0")]
		private void IGPOMOKCBNF(global::AFBJNMJHLIH<DAOGBIHJNFE> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2A54A10", Offset = "0x2A53A10", VA = "0x182A54A10")]
		private bool GOJFDMOJAKO(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x2A54A70", Offset = "0x2A53A70", VA = "0x182A54A70")]
		private NativeArray<Entity> GPCOJPDJHCG(Entity GEEFHDFLBEH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x2A569A0", Offset = "0x2A559A0", VA = "0x182A569A0")]
		private HDIMMDIONOF PANOFCIBOHH(NativeList<HDIMMDIONOF> NFMFOGHBEPK)
		{
			return default(HDIMMDIONOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x2A55AA0", Offset = "0x2A54AA0", VA = "0x182A55AA0")]
		private void JLABOBGJOHB(HDIMMDIONOF MIGDJNOKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DAC0", Offset = "0x2A3CAC0", VA = "0x182A3DAC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x2A56280", Offset = "0x2A55280", VA = "0x182A56280")]
		public static EntityQuery NGOKAPGAKBC(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2A53710", Offset = "0x2A52710", VA = "0x182A53710")]
		public static EntityQuery BEACGJJJMMJ(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2A55B30", Offset = "0x2A54B30", VA = "0x182A55B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A07060", Offset = "0x2A06060", VA = "0x182A07060", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2A070C0", Offset = "0x2A060C0", VA = "0x182A070C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A060F0", VA = "0x182A070F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	protected JGNGJMNAFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E17E70", Offset = "0x2E16E70", VA = "0x182E17E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int AKKJDCEMEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x2E18150", Offset = "0x2E17150", VA = "0x182E18150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E17D20", Offset = "0x2E16D20", VA = "0x182E17D20", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E18160", Offset = "0x2E17160", VA = "0x182E18160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E18350", Offset = "0x2E17350", VA = "0x182E18350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x2E17E80", Offset = "0x2E16E80", VA = "0x182E17E80")]
	protected void LCIEOJEPMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E17870", Offset = "0x2E16870", VA = "0x182E17870")]
	protected void BCMMENNOOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E17D80", Offset = "0x2E16D80", VA = "0x182E17D80")]
	private bool KJBCNCCLGDG(EntityQuery JFPFDEFJDBP, out NativeArray<Entity> FBMJMNCDHDM, out NativeArray<EMPKMDMEDJP> AGFPEFOAJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x2E17BB0", Offset = "0x2E16BB0", VA = "0x182E17BB0")]
	public global::OHBAMBCHLEK<Entity> DJEDMHNKNKM(Allocator JEOILJEOOOI)
	{
		return default(global::OHBAMBCHLEK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E17C70", Offset = "0x2E16C70", VA = "0x182E17C70")]
	public global::OHBAMBCHLEK<Entity> FEEJMBLMDJL(Allocator JEOILJEOOOI)
	{
		return default(global::OHBAMBCHLEK<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2E17BF0", Offset = "0x2E16BF0", VA = "0x182E17BF0")]
	public bool EBCBHCDIKAJ(Allocator JEOILJEOOOI, out global::OHBAMBCHLEK<Entity> DNCNJICBAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E17AE0", Offset = "0x2E16AE0", VA = "0x182E17AE0")]
	public bool CDOIOEBAIAC(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E17CB0", Offset = "0x2E16CB0", VA = "0x182E17CB0")]
	public GIALAGJINEB GMGIMGJFJIG(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E17B40", Offset = "0x2E16B40", VA = "0x182E17B40")]
	public bool CECLHLMOAFB(Entity GEEFHDFLBEH, out HDIAJFLHONH DNCNJICBAHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E17830", Offset = "0x2E16830", VA = "0x182E17830")]
	public void AOPNOMOLIPC(Entity GEEFHDFLBEH, HDIAJFLHONH DNCNJICBAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E180F0", Offset = "0x2E170F0", VA = "0x182E180F0")]
	public bool MEEOHNLDHKG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public FBGPKGAHMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public HDIAJFLHONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656F40", VA = "0x180657F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DFBFD0", Offset = "0x2DFAFD0", VA = "0x182DFBFD0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC020", Offset = "0x2DFB020", VA = "0x182DFC020", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC0E0", Offset = "0x2DFB0E0", VA = "0x182DFC0E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x21FA0A0", Offset = "0x21F90A0", VA = "0x1821FA0A0")]
	private bool KJBCNCCLGDG<TComponentData>(EntityQuery JFPFDEFJDBP, out NativeArray<Entity> FBMJMNCDHDM, out NativeArray<TComponentData> CGPLPFBCOHF) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBF60", Offset = "0x2DFAF60", VA = "0x182DFBF60")]
	public GIALAGJINEB GMGIMGJFJIG(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public AEKANGFCDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4BC10", Offset = "0x2A4AC10", VA = "0x182A4BC10", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BC60", Offset = "0x2A4AC60", VA = "0x182A4BC60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BDD0", Offset = "0x2A4ADD0", VA = "0x182A4BDD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B8C0", Offset = "0x2A4A8C0", VA = "0x182A4B8C0")]
		private void ENDJPLBKPHO(EntityQuery JFPFDEFJDBP, bool CJONJKNGENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public FLHBJAPMFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0AA20", Offset = "0x2A09A20", VA = "0x182A0AA20", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AA80", Offset = "0x2A09A80", VA = "0x182A0AA80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	protected KKPNBIDGCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public KDOOAAPMPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, HHCGCCCMOPE previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DB2C0", Offset = "0x37DA2C0", VA = "0x1837DB2C0")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x37DB240", Offset = "0x37DA240", VA = "0x1837DB240")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DF3D0", Offset = "0x37DE3D0", VA = "0x1837DF3D0")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ParentData MGGGHPDHPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x37D6240", Offset = "0x37D5240", VA = "0x1837D6240", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x37DF1F0", Offset = "0x37DE1F0", VA = "0x1837DF1F0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x37DF320", Offset = "0x37DE320", VA = "0x1837DF320")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JGCFLCKJLMG.CJKCAPBAJNG PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x37DF290", Offset = "0x37DE290", VA = "0x1837DF290")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D95F0", Offset = "0x37D85F0", VA = "0x1837D95F0")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x37D9550", Offset = "0x37D8550", VA = "0x1837D9550")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D4EC0", Offset = "0x37D3EC0", VA = "0x1837D4EC0")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ParentData MGGGHPDHPFB, HHCGCCCMOPE HFLCHCKFKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x37D4F80", Offset = "0x37D3F80", VA = "0x1837D4F80", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x37D4CD0", Offset = "0x37D3CD0", VA = "0x1837D4CD0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x37D4DE0", Offset = "0x37D3DE0", VA = "0x1837D4DE0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref HOLILIMPEPD.OCBILNBJBML PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x37D4DA0", Offset = "0x37D3DA0", VA = "0x1837D4DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DBED0", Offset = "0x37DAED0", VA = "0x1837DBED0")]
			public void LONPEHHIFCO(NIENIENGCDI OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x37DBE50", Offset = "0x37DAE50", VA = "0x1837DBE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DE6C0", Offset = "0x37DD6C0", VA = "0x1837DE6C0")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, HHCGCCCMOPE HFLCHCKFKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x37DE740", Offset = "0x37DD740", VA = "0x1837DE740", Slot = "5")]
		public void ReadFromDisplayClass(ref KDOOAAPMPDF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x37DE4E0", Offset = "0x37DD4E0", VA = "0x1837DE4E0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x37DE610", Offset = "0x37DD610", VA = "0x1837DE610")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref KAOAJFMCLOO.MHJPNNPCLFK PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x37DE580", Offset = "0x37DD580", VA = "0x1837DE580")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A112E0", Offset = "0x2A102E0", VA = "0x182A112E0", Slot = "14")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A11650", Offset = "0x2A10650", VA = "0x182A11650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public NIENIENGCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A115F0", Offset = "0x2A105F0", VA = "0x182A115F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A11080", Offset = "0x2A10080", VA = "0x182A11080")]
	public static EntityQuery HJIOGFGIOPK(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A113C0", Offset = "0x2A103C0", VA = "0x182A113C0")]
	public static EntityQuery OFEBIIBCALM(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A10E80", Offset = "0x2A0FE80", VA = "0x182A10E80")]
	public static EntityQuery FMJJEMBGJDL(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class LFLBNLDBEKG : ParentSystemBase<ParentData, HHCGCCCMOPE, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D560", Offset = "0x2A0C560", VA = "0x182A0D560", Slot = "14")]
	protected override EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7016B0", VA = "0x1807026B0", Slot = "15")]
	protected override EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D520", Offset = "0x2A0C520", VA = "0x182A0D520", Slot = "16")]
	protected override EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D4E0", Offset = "0x2A0C4E0", VA = "0x182A0D4E0", Slot = "17")]
	protected override EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D5E0", Offset = "0x2A0C5E0", VA = "0x182A0D5E0")]
	public LFLBNLDBEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D5A0", Offset = "0x2A0C5A0", VA = "0x182A0D5A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DC85A0", Offset = "0x2DC75A0", VA = "0x182DC85A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x24E0160", Offset = "0x24DF160", VA = "0x1824E0160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x24DEDB0", Offset = "0x24DDDB0", VA = "0x1824DEDB0")]
			private int KAFCAMPBMAK(DynamicBuffer<ChildrenData> FALFIAAPAEL, Entity GEEFHDFLBEH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x24DEC50", Offset = "0x24DDC50", VA = "0x1824DEC50")]
			private void GGDHNAHHAOK(Entity ADECAOLBLPJ, DynamicBuffer<ChildrenData> FALFIAAPAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x24DF100", Offset = "0x24DE100", VA = "0x1824DF100")]
			private void LLJMGCBHJMB(Entity ADECAOLBLPJ, DynamicBuffer<ChildrenData> FALFIAAPAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x24DE830", Offset = "0x24DD830", VA = "0x1824DE830", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3022A80", Offset = "0x3021A80", VA = "0x183022A80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DD2B30", Offset = "0x2DD1B30", VA = "0x182DD2B30")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2190", Offset = "0x2DD1190", VA = "0x182DD2190")]
		private int KAFCAMPBMAK(DynamicBuffer<ChildrenData> FALFIAAPAEL, Entity GEEFHDFLBEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1ED0", Offset = "0x2DD0ED0", VA = "0x182DD1ED0")]
		private void HAEJNAPBJEK(Entity AIANMNKPJDO, Entity ICOEFFELKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7016B0", VA = "0x1807026B0", Slot = "14")]
		protected virtual EntityQueryDesc FHCFGNAAFIG(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7016B0", VA = "0x1807026B0", Slot = "15")]
		protected virtual EntityQueryDesc IPMOKDFPBAM(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x7026B0", Offset = "0x7016B0", VA = "0x1807026B0", Slot = "16")]
		protected virtual EntityQueryDesc CIPEILLLGGF(EntityQueryDesc JFPFDEFJDBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc CFKGJLNMGMM(EntityQueryDesc JFPFDEFJDBP);

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2530", Offset = "0x2DD1530", VA = "0x182DD2530", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2370", Offset = "0x2DD1370", VA = "0x182DD2370")]
		private void KFFENDCIJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1B30", Offset = "0x2DD0B30", VA = "0x182DD1B30")]
		private void EDOBDLADANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD0AB0", Offset = "0x2DCFAB0", VA = "0x182DD0AB0")]
		private void AJNECNOFGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1490", Offset = "0x2DD0490", VA = "0x182DD1490")]
		private void DIBNIDMHLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2A70", Offset = "0x2DD1A70", VA = "0x182DD2A70", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x1995A00", Offset = "0x1994A00", VA = "0x181995A00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2598B70", Offset = "0x2597B70", VA = "0x182598B70")]
			public AGNHJPPPNED(NativeList<Entity> MMHAHCJBHGK, NativeList<Entity> HPHEMDOFNNP, JobHandle AADBABLKHJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x25986E0", Offset = "0x25976E0", VA = "0x1825986E0")]
			public JobHandle IBPCJLOGNIJ(JobHandle GINKINFGNEP)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x2598860", Offset = "0x2597860", VA = "0x182598860")]
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
			[Cpp2IlInjected.Address(RVA = "0x3017DA0", Offset = "0x3016DA0", VA = "0x183017DA0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x30186F0", Offset = "0x30176F0", VA = "0x1830186F0")]
			private void GJJCPKFPJDJ(Entity GEEFHDFLBEH, bool DHIBJIHPGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x3019110", Offset = "0x3018110", VA = "0x183019110")]
			private void IJHEEAOHCEG(Entity GEEFHDFLBEH, bool DHIBJIHPGLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x30174B0", Offset = "0x30164B0", VA = "0x1830174B0")]
			public AGNHJPPPNED ABHIGKNBIPJ(NativeArray<Entity> PNCPJCEBIDF, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x3018260", Offset = "0x3017260", VA = "0x183018260")]
			public AGNHJPPPNED GHIBFNJEHGI(NativeArray<Entity> PNCPJCEBIDF, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x3017960", Offset = "0x3016960", VA = "0x183017960")]
			public AGNHJPPPNED CPCMEDGJJJN(NativeList<MIFKFPHADFM> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x3019340", Offset = "0x3018340", VA = "0x183019340")]
			public AGNHJPPPNED LPLFIDJHJFJ(NativeList<MIFKFPHADFM> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x30175A0", Offset = "0x30165A0", VA = "0x1830175A0")]
			public AGNHJPPPNED CMFGMGFGOBH(NativeList<FDCGJNDCDCD> LPDILHBGHIJ, JobHandle GINKINFGNEP)
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x29C2B00", Offset = "0x29C1B00", VA = "0x1829C2B00")]
			private AGNHJPPPNED HBPLCHGJNEG<T>(NativeList<T> LPDILHBGHIJ, int OJMDGHDFJIL, int CACEIMFJAFJ, JKKPLNLGLBI CIJCIMPGNPO, JobHandle GINKINFGNEP) where T : struct
			{
				return default(AGNHJPPPNED);
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x3018A10", Offset = "0x3017A10", VA = "0x183018A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3131A80", Offset = "0x3130A80", VA = "0x183131A80", Slot = "14")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x3131BD0", Offset = "0x3130BD0", VA = "0x183131BD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x31334C0", Offset = "0x31324C0", VA = "0x1831334C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3131B60", Offset = "0x3130B60", VA = "0x183131B60")]
		private void LCPKFCMPMKO(NativeArray<Entity> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x3133FA0", Offset = "0x3132FA0", VA = "0x183133FA0")]
		private void POMGPNKGHPB(NativeArray<Entity> LPDILHBGHIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x31314A0", Offset = "0x31304A0", VA = "0x1831314A0")]
		private void GLNCJCIJIBI(AGNHJPPPNED NGJPGCIKGJJ, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x3131260", Offset = "0x3130260", VA = "0x183131260")]
		private void GLNCJCIJIBI(global::AFBJNMJHLIH<Entity> LBNDFDCLDFN, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x3131620", Offset = "0x3130620", VA = "0x183131620")]
		private void GNHEPKEENCP(AGNHJPPPNED NGJPGCIKGJJ, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x3131500", Offset = "0x3130500", VA = "0x183131500")]
		private void GNHEPKEENCP(global::AFBJNMJHLIH<Entity> LBNDFDCLDFN, string CFMCAGCMNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x31310E0", Offset = "0x31300E0", VA = "0x1831310E0")]
		private bool DDDCGGOHCCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x3134080", Offset = "0x3133080", VA = "0x183134080")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x1995A00", Offset = "0x1994A00", VA = "0x181995A00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public IAHDCCHPIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D63A0", Offset = "0x37D53A0", VA = "0x1837D63A0")]
			public void LONPEHHIFCO(KLGOENHKPJC OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x37D6390", Offset = "0x37D5390", VA = "0x1837D6390")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DF5C0", Offset = "0x37DE5C0", VA = "0x1837DF5C0")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x37D7EF0", Offset = "0x37D6EF0", VA = "0x1837D7EF0", Slot = "5")]
		public void ReadFromDisplayClass(ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x37D7F20", Offset = "0x37D6F20", VA = "0x1837D7F20", Slot = "6")]
		public void WriteToDisplayClass(ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x37DF450", Offset = "0x37DE450", VA = "0x1837DF450", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x37DF550", Offset = "0x37DE550", VA = "0x1837DF550")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref DJLDJBNGFAG.MOBCKLINCAK PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x37DF510", Offset = "0x37DE510", VA = "0x1837DF510")]
		public void LONPEHHIFCO(KLGOENHKPJC OJEDNGBIKHJ, ref IAHDCCHPIKF CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x37DF4A0", Offset = "0x37DE4A0", VA = "0x1837DF4A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0ADB0", Offset = "0x2A09DB0", VA = "0x182A0ADB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AC70", Offset = "0x2A09C70", VA = "0x182A0AC70", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AE10", Offset = "0x2A09E10", VA = "0x182A0AE10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public KLGOENHKPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x2A0ACD0", Offset = "0x2A09CD0", VA = "0x182A0ACD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2A0AAA0", Offset = "0x2A09AA0", VA = "0x182A0AAA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x656000", VA = "0x180657000")]
	public static JLKFGGHMAGN PAAEKNCKHBI(in NCGEEIAJEOJ PMFKMFEMMLL)
	{
		return default(JLKFGGHMAGN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x656000", VA = "0x180657000")]
	public static NCGEEIAJEOJ PAAEKNCKHBI(in JLKFGGHMAGN EJIKNKJOMGE)
	{
		return default(NCGEEIAJEOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class OPIMGAOPDNP : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
	public OPIMGAOPDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public AKNNNKDPIDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public FNBILDILKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DE7D0", Offset = "0x37DD7D0", VA = "0x1837DE7D0")]
			public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x37DE750", Offset = "0x37DD750", VA = "0x1837DE750")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D8BB0", Offset = "0x37D7BB0", VA = "0x1837D8BB0")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG, JLKFGGHMAGN DDEDCJNEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x37D7EF0", Offset = "0x37D6EF0", VA = "0x1837D7EF0", Slot = "5")]
		public void ReadFromDisplayClass(ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x37D7F20", Offset = "0x37D6F20", VA = "0x1837D7F20", Slot = "6")]
		public void WriteToDisplayClass(ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x37D8960", Offset = "0x37D7960", VA = "0x1837D8960", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x37D8B00", Offset = "0x37D7B00", VA = "0x1837D8B00")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref NMLINPPPECO.MHFMMOIBIIB PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x37D8A70", Offset = "0x37D7A70", VA = "0x1837D8A70")]
		public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ, ref AKNNNKDPIDM CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x37D8A00", Offset = "0x37D7A00", VA = "0x1837D8A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D8900", Offset = "0x37D7900", VA = "0x1837D8900")]
			public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x37D8880", Offset = "0x37D7880", VA = "0x1837D8880")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D7E60", Offset = "0x37D6E60", VA = "0x1837D7E60")]
		internal void POIJCEOICMD(Entity BKGIODDNKLG, JLKFGGHMAGN DDEDCJNEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x37D7EF0", Offset = "0x37D6EF0", VA = "0x1837D7EF0", Slot = "5")]
		public void ReadFromDisplayClass(ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x37D7F20", Offset = "0x37D6F20", VA = "0x1837D7F20", Slot = "6")]
		public void WriteToDisplayClass(ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x37D7C10", Offset = "0x37D6C10", VA = "0x1837D7C10", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x37D7DB0", Offset = "0x37D6DB0", VA = "0x1837D7DB0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref HBMIEJLNNIO.EFMILKILIAD PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x37D7D20", Offset = "0x37D6D20", VA = "0x1837D7D20")]
		public void LONPEHHIFCO(LIICBMDDEGK OJEDNGBIKHJ, ref FNBILDILKJH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x37D7CB0", Offset = "0x37D6CB0", VA = "0x1837D7CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0DD70", Offset = "0x2A0CD70", VA = "0x182A0DD70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D8B0", Offset = "0x2A0C8B0", VA = "0x182A0D8B0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DF30", Offset = "0x2A0CF30", VA = "0x182A0DF30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DDD0", Offset = "0x2A0CDD0", VA = "0x182A0DDD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public LIICBMDDEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0DAE0", Offset = "0x2A0CAE0", VA = "0x182A0DAE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D910", Offset = "0x2A0C910", VA = "0x182A0D910")]
	public static EntityQuery OCKMBBOCGBB(ComponentSystemBase OJEDNGBIKHJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D750", Offset = "0x2A0C750", VA = "0x182A0D750")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D7210", Offset = "0x37D6210", VA = "0x1837D7210")]
			public EODFPBLFDAC(int CHMDLBBFMNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x37D7190", Offset = "0x37D6190", VA = "0x1837D7190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D86E0", Offset = "0x37D76E0", VA = "0x1837D86E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D47C0", Offset = "0x37D37C0", VA = "0x1837D47C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A416C0", Offset = "0x2A406C0", VA = "0x182A416C0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x2A418A0", Offset = "0x2A408A0", VA = "0x182A418A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x2A41390", Offset = "0x2A40390", VA = "0x182A41390", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x2A41B60", Offset = "0x2A40B60", VA = "0x182A41B60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x2A41240", Offset = "0x2A40240", VA = "0x182A41240")]
		private void DHPGCLJNPJK(EntityQuery JFPFDEFJDBP, out (global::OHBAMBCHLEK<JLKFGGHMAGN> handles, global::OHBAMBCHLEK<NMNILGJABIA> bounds) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x2A40FE0", Offset = "0x2A3FFE0", VA = "0x182A40FE0")]
		private void DHKMNNMGPIP((global::OHBAMBCHLEK<JLKFGGHMAGN> handles, global::OHBAMBCHLEK<NMNILGJABIA> bounds) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x2A41390", Offset = "0x2A40390", VA = "0x182A41390")]
		private void DLKGHKOHLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x2A41720", Offset = "0x2A40720", VA = "0x182A41720")]
		private void LPGHLJOJNNO(EntityQuery JFPFDEFJDBP, out (global::OHBAMBCHLEK<Entity> entities, global::OHBAMBCHLEK<JLKFGGHMAGN> handles) JANIFNADDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x2A413D0", Offset = "0x2A403D0", VA = "0x182A413D0")]
		private void FKCBBLHJAGG((global::OHBAMBCHLEK<Entity> entities, global::OHBAMBCHLEK<JLKFGGHMAGN> handles) JANIFNADDOP, EODFPBLFDAC MLBCCNCBNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2A40E80", Offset = "0x2A3FE80", VA = "0x182A40E80")]
		private JobHandle AJCBDGEMENL(EODFPBLFDAC MLBCCNCBNHG, ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ, ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF, ComponentDataFromEntity<WorldDeformableScaleData> MEMMPBDNNLF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x2A42300", Offset = "0x2A41300", VA = "0x182A42300")]
		private JobHandle PNAGBJKIAEM(EODFPBLFDAC MLBCCNCBNHG, ComponentDataFromEntity<WorldPoseData> JCMAMKNNHFJ, ComponentDataFromEntity<WorldUniformScaleData> EKMFODGHLNF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D42D0", Offset = "0x37D32D0", VA = "0x1837D42D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D91F0", Offset = "0x37D81F0", VA = "0x1837D91F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4D2B0", Offset = "0x2A4C2B0", VA = "0x182A4D2B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D4C0", Offset = "0x2A4C4C0", VA = "0x182A4D4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C9E0", Offset = "0x2A4B9E0", VA = "0x182A4C9E0")]
		private JobHandle IFMKCBJGODA(global::OHBAMBCHLEK<Entity> DEJEDNNJILK, int GKPOMAIMOAK, JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C830", Offset = "0x2A4B830", VA = "0x182A4C830")]
		private JobHandle IFMKCBJGODA(NativeArray<Entity> CBMKCDPBEFL, int GKPOMAIMOAK, [Optional] JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C7B0", Offset = "0x2A4B7B0", VA = "0x182A4C7B0")]
		private global::OHBAMBCHLEK<Entity> IABHOJFHKFJ(EntityQuery JFPFDEFJDBP)
		{
			return default(global::OHBAMBCHLEK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CDE0", Offset = "0x2A4BDE0", VA = "0x182A4CDE0")]
		private (global::AFBJNMJHLIH<Entity>, global::AFBJNMJHLIH<Entity>) KGNGLHHBOIF(global::OHBAMBCHLEK<Entity> IHHKNLGEIBC)
		{
			return default((global::AFBJNMJHLIH<Entity>, global::AFBJNMJHLIH<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2A4D230", Offset = "0x2A4C230", VA = "0x182A4D230")]
		private void MDFBNLLMBAL(out NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C720", Offset = "0x2A4B720", VA = "0x182A4C720")]
		private void GADDBAKKCIJ(NativeList<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C650", Offset = "0x2A4B650", VA = "0x182A4C650")]
		private void GADDBAKKCIJ(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DA40", Offset = "0x2A4CA40", VA = "0x182A4DA40")]
		private void PADOHENKGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private static void BDDEIBJJOOM(int JDBHHBAPLEC, int EBEKBFLPPDI, int JLFOKLBEGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x2A4CAC0", Offset = "0x2A4BAC0", VA = "0x182A4CAC0")]
		private static NMNILGJABIA KGMOBBJGBFA(NativeArray<Entity> BJFBKLCPENG, ComponentDataFromEntity<SplinePointData> LLKJCPKBMGI)
		{
			return default(NMNILGJABIA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DFED70", Offset = "0x2DFDD70", VA = "0x182DFED70", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x2E10580", Offset = "0x2E0F580", VA = "0x182E10580")]
		public bool LGKONKIAJFF(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2E10630", Offset = "0x2E0F630", VA = "0x182E10630", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x2E106D0", Offset = "0x2E0F6D0", VA = "0x182E106D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2E106D0", Offset = "0x2E0F6D0", VA = "0x182E106D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2E106C0", Offset = "0x2E0F6C0", VA = "0x182E106C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2E10470", Offset = "0x2E0F470", VA = "0x182E10470")]
		private void EGJEFCCBJMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E14130", Offset = "0x2E13130", VA = "0x182E14130", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x2E14210", Offset = "0x2E13210", VA = "0x182E14210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private void NDIGJPFLJCC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM, EGNDHFFDDFH KOPJKHIOCNP, OJINANPDCIH NLBBBEBMOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A47580", Offset = "0x2A46580", VA = "0x182A47580", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2A47600", Offset = "0x2A46600", VA = "0x182A47600", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A53070", Offset = "0x2A52070", VA = "0x182A53070", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x2A530C0", Offset = "0x2A520C0", VA = "0x182A530C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2E00690", Offset = "0x2DFF690", VA = "0x182E00690")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x2E00D40", Offset = "0x2DFFD40", VA = "0x182E00D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2E006D0", Offset = "0x2DFF6D0", VA = "0x182E006D0", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2E00EB0", Offset = "0x2DFFEB0", VA = "0x182E00EB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2E00FC0", Offset = "0x2DFFFC0", VA = "0x182E00FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2E00C40", Offset = "0x2DFFC40", VA = "0x182E00C40")]
		private void LJCCOJCHEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2E00440", Offset = "0x2DFF440", VA = "0x182E00440")]
		private void BMCHDCHCPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2E00720", Offset = "0x2DFF720", VA = "0x182E00720")]
		private void ILJGDNMJKHN(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2E00580", Offset = "0x2DFF580", VA = "0x182E00580")]
		private void DMHGNPDJMNM(NativeArray<Entity> FBMJMNCDHDM, int DLAMHLJBGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2E00A70", Offset = "0x2DFFA70", VA = "0x182E00A70")]
		private void LFHDCJBBCEF(NativeArray<Entity> FBMJMNCDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x2E00DA0", Offset = "0x2DFFDA0", VA = "0x182E00DA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal static class HLAPFDOEBDD
{
	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2A01610", Offset = "0x2A00610", VA = "0x182A01610")]
	public static bool DKPJLCCLCBP(this SystemBase CHJMLFMLCJF, out Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x2A016A0", Offset = "0x2A006A0", VA = "0x182A016A0")]
	public static Entity LLGPMPGENGG(this SystemBase CHJMLFMLCJF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x2A016F0", Offset = "0x2A006F0", VA = "0x182A016F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E06480", Offset = "0x2E05480", VA = "0x182E06480", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x2E064D0", Offset = "0x2E054D0", VA = "0x182E064D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2E06590", Offset = "0x2E05590", VA = "0x182E06590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A0ED30", Offset = "0x2A0DD30", VA = "0x182A0ED30")]
			get
			{
				return default(PMMHBDBEGAM);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E6D0", Offset = "0x2A0D6D0", VA = "0x182A0E6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private Entity LMAFPGJBCOD
		{
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E240", Offset = "0x2A0D240", VA = "0x182A0E240")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E100", Offset = "0x2A0D100", VA = "0x182A0E100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public PMMHBDBEGAM GFMJMLPAANG
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A0ECA0", Offset = "0x2A0DCA0", VA = "0x182A0ECA0")]
			get
			{
				return default(PMMHBDBEGAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private Entity JFIFMEDJPFH
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E7F0", Offset = "0x2A0D7F0", VA = "0x182A0E7F0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		private Entity EKAMJAPOMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A016A0", Offset = "0x2A006A0", VA = "0x182A016A0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public bool OMPMAIGNFHI
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A016F0", Offset = "0x2A006F0", VA = "0x182A016F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x233FAD0", Offset = "0x233EAD0", VA = "0x18233FAD0")]
		private bool KNMEGLCAMII<T>(out T IGJPNMBCJPK) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E660", Offset = "0x2A0D660", VA = "0x182A0E660", Slot = "15")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E510", Offset = "0x2A0D510", VA = "0x182A0E510", Slot = "14")]
		protected override void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EB80", Offset = "0x2A0DB80", VA = "0x182A0EB80")]
		private void OADCKFPFFGH(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E850", Offset = "0x2A0D850", VA = "0x182A0E850")]
		private void NFALKLLLDCK(Entity GEEFHDFLBEH, Entity EFBHGFLNMOL, Entity NMGCEMAHJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E380", Offset = "0x2A0D380", VA = "0x182A0E380")]
		public bool EICFBDDCOOP(PMMHBDBEGAM JPPNMPGJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E2A0", Offset = "0x2A0D2A0", VA = "0x182A0E2A0")]
		public static bool EICFBDDCOOP(PMMHBDBEGAM LGMOGODIBPP, PMMHBDBEGAM JPPNMPGJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E210", Offset = "0x2A0D210", VA = "0x182A0E210")]
		private static bool DAAPIBBOKEK(PMMHBDBEGAM LGMOGODIBPP, PMMHBDBEGAM KEHNEFAKJHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EE10", Offset = "0x2A0DE10", VA = "0x182A0EE10")]
		protected LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A0EC60", Offset = "0x2A0DC60", VA = "0x182A0EC60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0D310", Offset = "0x2E0C310", VA = "0x182E0D310", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D4B0", Offset = "0x2E0C4B0", VA = "0x182E0D4B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D5A0", Offset = "0x2E0C5A0", VA = "0x182E0D5A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A57990", Offset = "0x2A56990", VA = "0x182A57990", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2E0CF10", Offset = "0x2E0BF10", VA = "0x182E0CF10")]
		private void AGAHNEENAIJ(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D360", Offset = "0x2E0C360", VA = "0x182E0D360")]
		private NativeArray<Entity> LNJBOOCCPIP(int KOHJDBBJEKM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2E0CE00", Offset = "0x2E0BE00", VA = "0x182E0CE00")]
		private void AFILCMPMJKA(NativeArray<Entity> GAHODJODMJJ, NativeArray<Entity> EINOFMLPJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A02510", Offset = "0x2A01510", VA = "0x182A02510", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A02600", Offset = "0x2A01600", VA = "0x182A02600", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x21F9DD0", Offset = "0x21F8DD0", VA = "0x1821F9DD0")]
	public static NativeArray<T> HBPLCHGJNEG<T>(NativeArray<Entity> FBMJMNCDHDM, EntityManager LKEHNCAJHHL) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBCF0", Offset = "0x2DFACF0", VA = "0x182DFBCF0")]
	public static void LAEFBOJIAPA(EntityQuery JFPFDEFJDBP, EntityManager LKEHNCAJHHL, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBE30", Offset = "0x2DFAE30", VA = "0x182DFBE30")]
	public static void NEMIIJCJFIP(NativeArray<Entity> GAHODJODMJJ, CBIPFLGDJEF NBLKNAFAMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBBC0", Offset = "0x2DFABC0", VA = "0x182DFBBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A57800", Offset = "0x2A56800", VA = "0x182A57800", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A57890", Offset = "0x2A56890", VA = "0x182A57890", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A579D0", Offset = "0x2A569D0", VA = "0x182A579D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A57990", Offset = "0x2A56990", VA = "0x182A57990", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A57CA0", Offset = "0x2A56CA0", VA = "0x182A57CA0")]
		private void PECPIDEHGKO(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A57260", Offset = "0x2A56260", VA = "0x182A57260")]
		private void EFKFBMCBMDD(NativeArray<Entity> GAHODJODMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A579F0", Offset = "0x2A569F0", VA = "0x182A579F0")]
		private void PBOECKKHLJF(NativeArray<Entity> EINOFMLPJHG, NativeArray<LocalPoseData> JGADCCMGEIF, NativeArray<LocalPoseData> HFODADOKCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A57370", Offset = "0x2A56370", VA = "0x182A57370")]
		private void FDKBODHDOJB(NativeArray<LocalPoseData> HFODADOKCEH, NativeArray<Entity> EINOFMLPJHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A42E80", Offset = "0x2A41E80", VA = "0x182A42E80", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A42F70", Offset = "0x2A41F70", VA = "0x182A42F70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A430C0", Offset = "0x2A420C0", VA = "0x182A430C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A42EF0", Offset = "0x2A41EF0", VA = "0x182A42EF0")]
		private void HIHNOHBHBBE(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A44560", Offset = "0x2A43560", VA = "0x182A44560", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A44780", Offset = "0x2A43780", VA = "0x182A44780", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A44820", Offset = "0x2A43820", VA = "0x182A44820", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A445F0", Offset = "0x2A435F0", VA = "0x182A445F0")]
		private void MNFFEEFIGII(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A48AF0", Offset = "0x2A47AF0", VA = "0x182A48AF0", Slot = "14")]
		protected override void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A48C10", Offset = "0x2A47C10", VA = "0x182A48C10")]
		protected RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A48BD0", Offset = "0x2A47BD0", VA = "0x182A48BD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3302130", Offset = "0x3301130", VA = "0x183302130", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x3302330", Offset = "0x3301330", VA = "0x183302330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x3302300", Offset = "0x3301300", VA = "0x183302300", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x3300F40", Offset = "0x32FFF40", VA = "0x183300F40")]
		private void HCGMHFGHPIN(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x3301780", Offset = "0x3300780", VA = "0x183301780")]
		private void KDNOANLPMGP(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x3300B00", Offset = "0x32FFB00", VA = "0x183300B00")]
		private void GOHGPJKLGME(EntityQuery JFPFDEFJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void FCMLMOOEAFE(NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> PEIGICHCMDH, NativeArray<Entity> AEAHADNONNJ);

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x3134080", Offset = "0x3133080", VA = "0x183134080")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x1995A00", Offset = "0x1994A00", VA = "0x181995A00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class DHBELNJEOID
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D690", Offset = "0x2E0C690", VA = "0x182E0D690")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E06030", Offset = "0x2E05030", VA = "0x182E06030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E06230", Offset = "0x2E05230", VA = "0x182E06230", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E06380", Offset = "0x2E05380", VA = "0x182E06380")]
	protected COFDLBBLFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DFE5F0", Offset = "0x2DFD5F0", VA = "0x182DFE5F0")]
	public static Entity PAAEKNCKHBI(AOEOIHKBMAM JANIFNADDOP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE5F0", Offset = "0x2DFD5F0", VA = "0x182DFE5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A07E10", Offset = "0x2A06E10", VA = "0x182A07E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A08060", Offset = "0x2A07060", VA = "0x182A08060")]
	public KGFPMIPOKMG(ComponentType MOBCJNJMMEJ, NativeList<int> LGLGGCHFNDI, NativeList<int> BIFPHOBHALN, NativeArray<Entity> FBMJMNCDHDM, NativeArray<Entity> IBIIGMBFOIM, NativeArray<byte> HFLCHCKFKDH, NativeArray<byte> MGGGHPDHPFB, int KCCDKALEDML, int NADGDGHIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A07F30", Offset = "0x2A06F30", VA = "0x182A07F30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A07E90", Offset = "0x2A06E90", VA = "0x182A07E90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A07EE0", Offset = "0x2A06EE0", VA = "0x182A07EE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A07D30", Offset = "0x2A06D30", VA = "0x182A07D30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A13A70", Offset = "0x2A12A70", VA = "0x182A13A70")]
	public OOPIHDDHHBC(ComponentType MOBCJNJMMEJ, int KCCDKALEDML, int NADGDGHIKPA, EntityQuery JFPFDEFJDBP, NativeArray<BCDDMNDBEPL> GMKKBMEMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x2A13A20", Offset = "0x2A12A20", VA = "0x182A13A20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x677050", VA = "0x180678050")]
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
	[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x677050", VA = "0x180678050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A13820", Offset = "0x2A12820", VA = "0x182A13820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public JLCDNMLCNEN MELPOBPKFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20")]
		get
		{
			return default(JLCDNMLCNEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2A13730", Offset = "0x2A12730", VA = "0x182A13730")]
	public MJADMLMEADH HDCMLBDCJJA(Type NKICFHCCMMH)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2A13640", Offset = "0x2A12640", VA = "0x182A13640")]
	public MJADMLMEADH GFNEMCGEDBG(Type NKICFHCCMMH)
	{
		return default(MJADMLMEADH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2DEABF0", Offset = "0x2DE9BF0", VA = "0x182DEABF0")]
	public T HDCMLBDCJJA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEABD0", Offset = "0x2DE9BD0", VA = "0x182DEABD0")]
	public T GFNEMCGEDBG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2A13830", Offset = "0x2A12830", VA = "0x182A13830")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A0A3E0", Offset = "0x2A093E0", VA = "0x182A0A3E0")]
		get
		{
			return default(OOPIHDDHHBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2A09D40", Offset = "0x2A08D40", VA = "0x182A09D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A470", Offset = "0x2A09470", VA = "0x182A0A470")]
	public KHMLGNFANIM(EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2A09A60", Offset = "0x2A08A60", VA = "0x182A09A60")]
	public Dictionary<ComponentType, OOPIHDDHHBC>.Enumerator BALJJOIEHDJ()
	{
		return default(Dictionary<ComponentType, OOPIHDDHHBC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x2A09AF0", Offset = "0x2A08AF0", VA = "0x182A09AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x2A09D90", Offset = "0x2A08D90", VA = "0x182A09D90")]
	private void HPONDOAJJHH(IEnumerable<NOBHGMEMAKH> OIAKNBEOLFI, EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x2A09C90", Offset = "0x2A08C90", VA = "0x182A09C90")]
	private static int ENPKMHCCDBP(NOBHGMEMAKH NKEPAMLDENG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A190", Offset = "0x2A09190", VA = "0x182A0A190")]
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
			[Cpp2IlInjected.Address(RVA = "0xD779B0", Offset = "0xD769B0", VA = "0x180D779B0", Slot = "4")]
			get
			{
				return default(OJINANPDCIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x37DA540", Offset = "0x37D9540", VA = "0x1837DA540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x37DA590", Offset = "0x37D9590", VA = "0x1837DA590")]
		internal IKALGBFDLKF(NativeMultiHashMap<Entity, OJINANPDCIH> AHGHAANFJKO, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x37DA330", Offset = "0x37D9330", VA = "0x1837DA330", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x37DA300", Offset = "0x37D9300", VA = "0x1837DA300")]
		public IKALGBFDLKF BALJJOIEHDJ()
		{
			return default(IKALGBFDLKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x37DA400", Offset = "0x37D9400", VA = "0x1837DA400", Slot = "9")]
		private IEnumerator<OJINANPDCIH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x37DA4A0", Offset = "0x37D94A0", VA = "0x1837DA4A0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A02B50", Offset = "0x2A01B50", VA = "0x182A02B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x2A02A70", Offset = "0x2A01A70", VA = "0x182A02A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x204EF20", Offset = "0x204DF20", VA = "0x18204EF20")]
	public IDJKLEJHIMN(OOGJNFIJHKM PBHDPEJBGCP, JobHandle LDGJAMKHEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2A027C0", Offset = "0x2A017C0", VA = "0x182A027C0")]
	public bool LFPECKBHFGD(Allocator JEOILJEOOOI, out NativeKeyValueArrays<Entity, OJINANPDCIH> BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2A02900", Offset = "0x2A01900", VA = "0x182A02900")]
	public bool OHNDCDIKBDP(Allocator JEOILJEOOOI, out (NativeArray<Entity> entities, int uniqueCount) BBLJKOEKFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x2A026A0", Offset = "0x2A016A0", VA = "0x182A026A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29FD5B0", Offset = "0x29FC5B0", VA = "0x1829FD5B0")]
		get
		{
			return default(OOPIHDDHHBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x29FD260", Offset = "0x29FC260", VA = "0x1829FD260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x29FD640", Offset = "0x29FC640", VA = "0x1829FD640")]
	public FLHBGDILJIB(KHMLGNFANIM OGMAGPEPNJD, EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x29FD070", Offset = "0x29FC070", VA = "0x1829FD070")]
	public List<OOPIHDDHHBC>.Enumerator BALJJOIEHDJ()
	{
		return default(List<OOPIHDDHHBC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x29FD0F0", Offset = "0x29FC0F0", VA = "0x1829FD0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x29FD2A0", Offset = "0x29FC2A0", VA = "0x1829FD2A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A09970", Offset = "0x2A08970", VA = "0x182A09970")]
	public KHFNLIHOAGK(ObjectInstantiationService JOIDICOJLFD, EHIDJEIAFME CANCHCAFIPH, CGJHBFGPOOL LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2A08620", Offset = "0x2A07620", VA = "0x182A08620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2A09910", Offset = "0x2A08910", VA = "0x182A09910")]
	public bool PAOEPCHIOGM(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x2A08D00", Offset = "0x2A07D00", VA = "0x182A08D00")]
	private void HNFMJBMJBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2A087D0", Offset = "0x2A077D0", VA = "0x182A087D0")]
	private EntityArchetype GKNJFAJHABG(EntityArchetype OOHCFEPBGBM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2A093A0", Offset = "0x2A083A0", VA = "0x182A093A0")]
	public static void NCGALFHGLGH(EntityManager BHDOHAJMONK, EntityManager LGGPCBMPJIM, NativeArray<Entity> ILCJJBCCAGM, NativeArray<EntityArchetype> BKODCBPDBIK, [Optional] NativeArray<Entity> ONMAHEPEOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x2A080C0", Offset = "0x2A070C0", VA = "0x182A080C0")]
	[Conditional("DEBUG_BUILD")]
	private static void ACPJOHFDGIN(NativeArray<EntityArchetype> PCOKMHJEFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x2A08230", Offset = "0x2A07230", VA = "0x182A08230")]
	private static string DJJBAGBAKMA(EntityArchetype CEINJAHAPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x2A097D0", Offset = "0x2A087D0", VA = "0x182A097D0")]
	[CompilerGenerated]
	internal static void NKMGFOJCFAM(ref Span<ComponentType> KNAJFGDPKPI, ComponentType IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2A08470", Offset = "0x2A07470", VA = "0x182A08470")]
	[CompilerGenerated]
	internal static void DMGAMDDOCDE(Span<ComponentType> DEJEDNNJILK, ref Span<ComponentType> KNAJFGDPKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x2A086F0", Offset = "0x2A076F0", VA = "0x182A086F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
			public OCDBFAEFGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D43D0", Offset = "0x37D33D0", VA = "0x1837D43D0")]
			internal void POIJCEOICMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x37D45B0", Offset = "0x37D35B0", VA = "0x1837D45B0", Slot = "5")]
			public void ReadFromDisplayClass(ref OCDBFAEFGHA CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x37D43A0", Offset = "0x37D33A0", VA = "0x1837D43A0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x37D43B0", Offset = "0x37D33B0", VA = "0x1837D43B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E00100", Offset = "0x2DFF100", VA = "0x182E00100")]
		public void NBKICENBLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFD60", Offset = "0x2DFED60", VA = "0x182DFFD60", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2E00110", Offset = "0x2DFF110", VA = "0x182E00110", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFDC0", Offset = "0x2DFEDC0", VA = "0x182DFFDC0")]
		private bool LEJMLOLKJEH(JobHandle GINKINFGNEP, int DBMJEOKPFJK, out JobHandle HGFNJFOEEBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DB070", Offset = "0x37DA070", VA = "0x1837DB070", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x37DB1B0", Offset = "0x37DA1B0", VA = "0x1837DB1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DA5B0", Offset = "0x37D95B0", VA = "0x1837DA5B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D7B50", Offset = "0x37D6B50", VA = "0x1837D7B50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D72B0", Offset = "0x37D62B0", VA = "0x1837D72B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2E07D90", Offset = "0x2E06D90", VA = "0x182E07D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2E07DE0", Offset = "0x2E06DE0", VA = "0x182E07DE0")]
		internal OOPIHDDHHBC JPFLOFLDECE(ComponentType MOBCJNJMMEJ)
		{
			return default(OOPIHDDHHBC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2E07B80", Offset = "0x2E06B80", VA = "0x182E07B80", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "15")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2E09290", Offset = "0x2E08290", VA = "0x182E09290", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2E09410", Offset = "0x2E08410", VA = "0x182E09410", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2E093C0", Offset = "0x2E083C0", VA = "0x182E093C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2E078E0", Offset = "0x2E068E0", VA = "0x182E078E0")]
		private void HBHPPBAOFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2E07CD0", Offset = "0x2E06CD0", VA = "0x182E07CD0")]
		private void INCMDNPILLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2E07270", Offset = "0x2E06270", VA = "0x182E07270")]
		internal void GMIGFAPKFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2E08460", Offset = "0x2E07460", VA = "0x182E08460")]
		private void NFCNLMCJHOB(NativeArray<Entity> ILCJJBCCAGM, NativeArray<RRObjectPrefabData> JKOPBJFEFEF, ref NativeArray<Entity> KDHNBJIDPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2E08F60", Offset = "0x2E07F60", VA = "0x182E08F60")]
		internal void OKKCHMJBCGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2E08820", Offset = "0x2E07820", VA = "0x182E08820")]
		internal void OBCFLPAOMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2E07E80", Offset = "0x2E06E80", VA = "0x182E07E80")]
		private void KABEHEPCGAC(OOPIHDDHHBC OHDDMIOPOFC, bool HMEODMGMEGG, ref JobHandle AIDIOJAAFGP, ref JobHandle KAPIJFGKJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2E06660", Offset = "0x2E05660", VA = "0x182E06660")]
		internal bool ACHLGFKIAJI(in OOPIHDDHHBC AFOPPLDIMJL, out JobHandle MIGDJNOKMHC, out KGFPMIPOKMG NJDBLKNAIHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2E06690", Offset = "0x2E05690", VA = "0x182E06690")]
		private bool ACHLGFKIAJI(in OOPIHDDHHBC AFOPPLDIMJL, bool HMEODMGMEGG, out JobHandle MIGDJNOKMHC, out KGFPMIPOKMG NJDBLKNAIHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2E082A0", Offset = "0x2E072A0", VA = "0x182E082A0")]
		internal (NativeList<int>, NativeList<int>) NAOECJJCONG(NativeList<LPFMODCHECN> NKIDNGPMNIO, int CHMDLBBFMNF, JobHandle GINKINFGNEP, out JobHandle AADBABLKHJM, Allocator JEOILJEOOOI = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2E08170", Offset = "0x2E07170", VA = "0x182E08170")]
		internal static NativeArray<Entity> MKPDAOMPGOI(EntityQuery JFPFDEFJDBP, out JobHandle FMGGAIEOAAJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2E08220", Offset = "0x2E07220", VA = "0x182E08220")]
		internal static NativeArray<byte> MPCBBJPLGID(int HFAIGCGNPJJ, out JobHandle AMJGBAPIFCG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2E09530", Offset = "0x2E08530", VA = "0x182E09530")]
		internal static NativeArray<byte> PCMGJIFBGKI(EntityQuery JFPFDEFJDBP, int DBMJEOKPFJK, out JobHandle AMJGBAPIFCG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2E07BD0", Offset = "0x2E06BD0", VA = "0x182E07BD0")]
		internal static NativeArray<Entity> IABHOJFHKFJ(EntityQuery JFPFDEFJDBP, out JobHandle DJHMNGMPAKO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2E07040", Offset = "0x2E06040", VA = "0x182E07040")]
		internal NativeArray<byte> DGBMLKNPFDC(NativeArray<Entity> FBMJMNCDHDM, OOPIHDDHHBC OHDDMIOPOFC, JobHandle GINKINFGNEP, out JobHandle AADBABLKHJM, Allocator JEOILJEOOOI = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2E08690", Offset = "0x2E07690", VA = "0x182E08690")]
		internal JobHandle NOHHIGNKGIH(in KGFPMIPOKMG JANIFNADDOP, in OOPIHDDHHBC OHDDMIOPOFC, NativeMultiHashMap<Entity, OJINANPDCIH> ABCKJKCJCPN, JobHandle GINKINFGNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x21D31D0", Offset = "0x21D21D0", VA = "0x1821D31D0")]
		private JobHandle ABNCHJEOCEL(JobHandle DAIGLJEOPBB, JobHandle NJEDBKEAGEL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x21D31D0", Offset = "0x21D21D0", VA = "0x1821D31D0")]
		private JobHandle ABNCHJEOCEL(JobHandle DAIGLJEOPBB, JobHandle NJEDBKEAGEL, JobHandle GOLOIKHJMLE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A024A0", Offset = "0x2A014A0", VA = "0x182A024A0")]
	protected HONFBOGIPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x2A02460", Offset = "0x2A01460", VA = "0x182A02460", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A060B0", Offset = "0x2A050B0", VA = "0x182A060B0")]
	protected JCNKOHLNAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x2A06070", Offset = "0x2A05070", VA = "0x182A06070", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public NBGBOCPANJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DE330", Offset = "0x37DD330", VA = "0x1837DE330")]
			public void LONPEHHIFCO(OHMOPMJJDKB OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x37DE2E0", Offset = "0x37DD2E0", VA = "0x1837DE2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D6170", Offset = "0x37D5170", VA = "0x1837D6170")]
		internal void POIJCEOICMD(ref AuthoredLocalPoseData AFCNGEGHGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x37D6240", Offset = "0x37D5240", VA = "0x1837D6240", Slot = "5")]
		public void ReadFromDisplayClass(ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2B07980", Offset = "0x2B06980", VA = "0x182B07980", Slot = "6")]
		public void WriteToDisplayClass(ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x37D5F70", Offset = "0x37D4F70", VA = "0x1837D5F70", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x37D60E0", Offset = "0x37D50E0", VA = "0x1837D60E0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref MLMMHHHANLA.MANHBOFMDNE PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x37D6060", Offset = "0x37D5060", VA = "0x1837D6060")]
		public void LONPEHHIFCO(OHMOPMJJDKB OJEDNGBIKHJ, ref NBGBOCPANJL CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x37D5FF0", Offset = "0x37D4FF0", VA = "0x1837D5FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A13270", Offset = "0x2A12270", VA = "0x182A13270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public OHMOPMJJDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x2A13040", Offset = "0x2A12040", VA = "0x182A13040", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x2A12EE0", Offset = "0x2A11EE0", VA = "0x182A12EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public NJCMAMLFFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D3EA0", Offset = "0x37D2EA0", VA = "0x1837D3EA0")]
			public void LONPEHHIFCO(PFEBNMLDBNN OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x37D3E20", Offset = "0x37D2E20", VA = "0x1837D3E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DEB30", Offset = "0x37DDB30", VA = "0x1837DEB30")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, SplinePointData EFCGBFLJIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x37DEBB0", Offset = "0x37DDBB0", VA = "0x1837DEBB0", Slot = "5")]
		public void ReadFromDisplayClass(ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x37DEBC0", Offset = "0x37DDBC0", VA = "0x1837DEBC0", Slot = "6")]
		public void WriteToDisplayClass(ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x37DE8C0", Offset = "0x37DD8C0", VA = "0x1837DE8C0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x37DEA60", Offset = "0x37DDA60", VA = "0x1837DEA60")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref ADBCNNNDBIF.LPAMGAOACHH PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x37DE9D0", Offset = "0x37DD9D0", VA = "0x1837DE9D0")]
		public void LONPEHHIFCO(PFEBNMLDBNN OJEDNGBIKHJ, ref NJCMAMLFFDH CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x37DE960", Offset = "0x37DD960", VA = "0x1837DE960")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A3E010", Offset = "0x2A3D010", VA = "0x182A3E010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public PFEBNMLDBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DDE0", Offset = "0x2A3CDE0", VA = "0x182A3DDE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DC80", Offset = "0x2A3CC80", VA = "0x182A3DC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A134F0", Offset = "0x2A124F0", VA = "0x182A134F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x2A13580", Offset = "0x2A12580", VA = "0x182A13580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public OJGBHFKCJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public NCDNPKIEBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DC760", Offset = "0x37DB760", VA = "0x1837DC760")]
			public void LONPEHHIFCO(FPDBMMINPKE OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x37DC6E0", Offset = "0x37DB6E0", VA = "0x1837DC6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D7AD0", Offset = "0x37D6AD0", VA = "0x1837D7AD0")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData KBDGPLALJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x37D6240", Offset = "0x37D5240", VA = "0x1837D6240", Slot = "5")]
		public void ReadFromDisplayClass(ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B07980", Offset = "0x2B06980", VA = "0x182B07980", Slot = "6")]
		public void WriteToDisplayClass(ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x37D7880", Offset = "0x37D6880", VA = "0x1837D7880", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x37D7A20", Offset = "0x37D6A20", VA = "0x1837D7A20")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref LAPBODDGOML.NLJBKLBFFEL PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x37D7990", Offset = "0x37D6990", VA = "0x1837D7990")]
		public void LONPEHHIFCO(FPDBMMINPKE OJEDNGBIKHJ, ref NCDNPKIEBHN CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x37D7920", Offset = "0x37D6920", VA = "0x1837D7920")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE390", Offset = "0x29FD390", VA = "0x1829FE390", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x29FE5F0", Offset = "0x29FD5F0", VA = "0x1829FE5F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public FPDBMMINPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x29FE3F0", Offset = "0x29FD3F0", VA = "0x1829FE3F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x29FE230", Offset = "0x29FD230", VA = "0x1829FE230")]
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
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
			public NOBGLALBIFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37DBCD0", Offset = "0x37DACD0", VA = "0x1837DBCD0")]
				public void LONPEHHIFCO(PostLoadInitializeEmbodiment OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007C5")]
				[Cpp2IlInjected.Address(RVA = "0x37DBC50", Offset = "0x37DAC50", VA = "0x1837DBC50")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D5EA0", Offset = "0x37D4EA0", VA = "0x1837D5EA0")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData AFOPPLDIMJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x37D5A70", Offset = "0x37D4A70", VA = "0x1837D5A70")]
			internal void AHPPNJDCFGE(Entity GEEFHDFLBEH, ObjectNetworkIdComponentData AFOPPLDIMJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x37D5C90", Offset = "0x37D4C90", VA = "0x1837D5C90")]
			internal void MHKDKCMMGOB(Entity GEEFHDFLBEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x37D5ED0", Offset = "0x37D4ED0", VA = "0x1837D5ED0", Slot = "5")]
			public void ReadFromDisplayClass(ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x37D5F20", Offset = "0x37D4F20", VA = "0x1837D5F20", Slot = "6")]
			public void WriteToDisplayClass(ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x37D5AF0", Offset = "0x37D4AF0", VA = "0x1837D5AF0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0x37D5DF0", Offset = "0x37D4DF0", VA = "0x1837D5DF0")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JJJMBMHAJFM.BIBGDKACDOE PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x37D5C00", Offset = "0x37D4C00", VA = "0x1837D5C00")]
			public void LONPEHHIFCO(PostLoadInitializeEmbodiment OJEDNGBIKHJ, ref NOBGLALBIFH CBENCAHNLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C3")]
			[Cpp2IlInjected.Address(RVA = "0x37D5B90", Offset = "0x37D4B90", VA = "0x1837D5B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A43830", Offset = "0x2A42830", VA = "0x182A43830", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x2A44100", Offset = "0x2A43100", VA = "0x182A44100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A44190", Offset = "0x2A43190", VA = "0x182A44190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A43C50", Offset = "0x2A42C50", VA = "0x182A43C50")]
		private void IDNMGGHJMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A438E0", Offset = "0x2A428E0", VA = "0x182A438E0")]
		private NativeArray<AHCKAEEHFIB> HKPBMMABDCH(NativeArray<NMEJDFJAOOA> FCIMMLKHDCA)
		{
			return default(NativeArray<AHCKAEEHFIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A433E0", Offset = "0x2A423E0", VA = "0x182A433E0")]
		private void DJDHPKIOLBP(NativeList<Entity> FBMJMNCDHDM, NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A431F0", Offset = "0x2A421F0", VA = "0x182A431F0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BPIIJFOCCLI(NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private static void BBKLLPAMBEI(NativeList<NMEJDFJAOOA> FCIMMLKHDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A43FC0", Offset = "0x2A42FC0", VA = "0x182A43FC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A43630", Offset = "0x2A42630", VA = "0x182A43630")]
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
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		public JPBFPLOPAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x37D42C0", Offset = "0x37D32C0", VA = "0x1837D42C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DBDE0", Offset = "0x37DADE0", VA = "0x1837DBDE0")]
			public void LONPEHHIFCO(LCICNAGLPHM OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x37DBD30", Offset = "0x37DAD30", VA = "0x1837DBD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D6DB0", Offset = "0x37D5DB0", VA = "0x1837D6DB0")]
		internal void POIJCEOICMD(Entity GEEFHDFLBEH, int GHHKILHNDGM, ref ObjectNetworkIdComponentData KBDGPLALJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x37D6240", Offset = "0x37D5240", VA = "0x1837D6240", Slot = "5")]
		public void ReadFromDisplayClass(ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B07980", Offset = "0x2B06980", VA = "0x182B07980", Slot = "6")]
		public void WriteToDisplayClass(ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x37D6AE0", Offset = "0x37D5AE0", VA = "0x1837D6AE0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x37D6CE0", Offset = "0x37D5CE0", VA = "0x1837D6CE0")]
		public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref JLKLPEALCDA.KDNLOCBNAPC PFILCCGGCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x37D6C40", Offset = "0x37D5C40", VA = "0x1837D6C40")]
		public void LONPEHHIFCO(LCICNAGLPHM OJEDNGBIKHJ, ref JPBFPLOPAFO CBENCAHNLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x37D6BD0", Offset = "0x37D5BD0", VA = "0x1837D6BD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0D0E0", Offset = "0x2A0C0E0", VA = "0x182A0D0E0", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D370", Offset = "0x2A0C370", VA = "0x182A0D370", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public LCICNAGLPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D140", Offset = "0x2A0C140", VA = "0x182A0D140", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CF80", Offset = "0x2A0BF80", VA = "0x182A0CF80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A3EA70", Offset = "0x2A3DA70", VA = "0x182A3EA70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A3EB00", Offset = "0x2A3DB00", VA = "0x182A3EB00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public PLPPACFFCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DFDC20", Offset = "0x2DFCC20", VA = "0x182DFDC20", Slot = "14")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDDC0", Offset = "0x2DFCDC0", VA = "0x182DFDDC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDA10", Offset = "0x2DFCA10", VA = "0x182DFDA10")]
	private void FFOKAPOGCOP(NativeList<EntityArchetype> PCOKMHJEFGC, NativeHashMap<int, NOAPHGCLLPE> CEAADNHDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD410", Offset = "0x2DFC410", VA = "0x182DFD410")]
	private void AFHJJEPEJLJ(NativeHashMap<int, NOAPHGCLLPE> CEAADNHDBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public AMAAPGIIJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDC80", Offset = "0x2DFCC80", VA = "0x182DFDC80")]
	[CompilerGenerated]
	internal static Span<int> IGCPCFNHMGP(EntityArchetype CEINJAHAPJN)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A44280", Offset = "0x2A43280", VA = "0x182A44280", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A444D0", Offset = "0x2A434D0", VA = "0x182A444D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public MAINBLDADFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public CNPNLBBJAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public PMAGEIGMADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public HODOFLBPGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public MNIPDJHOGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public PMDCPHBIDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public KBAINBIJCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public BOKPOOFDOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public DNGIILCGBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public CDBKMKJLKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D9FF0", Offset = "0x37D8FF0", VA = "0x1837D9FF0", Slot = "4")]
			public void Execute(int AIPHGHFENPJ, TransformAccess BCHADNCHEKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x37DA1F0", Offset = "0x37D91F0", VA = "0x1837DA1F0")]
			private bool OEJCMGLLIOO(float3 HFFCNNKMKHP, float3 BEIKMLIBFDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x37DA1B0", Offset = "0x37D91B0", VA = "0x1837DA1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DC040", Offset = "0x37DB040", VA = "0x1837DC040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0BC10", Offset = "0x2E0AC10", VA = "0x182E0BC10", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BC80", Offset = "0x2E0AC80", VA = "0x182E0BC80", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BCB0", Offset = "0x2E0ACB0", VA = "0x182E0BCB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x37D6310", Offset = "0x37D5310", VA = "0x1837D6310")]
				public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600081F")]
				[Cpp2IlInjected.Address(RVA = "0x37D6250", Offset = "0x37D5250", VA = "0x1837D6250")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DFF30", Offset = "0x37DEF30", VA = "0x1837DFF30")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, INDEJLDCMLL AGJLGNIMOFB, Transform BCHADNCHEKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x37DFCE0", Offset = "0x37DECE0", VA = "0x1837DFCE0", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x37DFE50", Offset = "0x37DEE50", VA = "0x1837DFE50")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, ref DJDPHGMGJMA.CKMANEENGDF PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x37DFE40", Offset = "0x37DEE40", VA = "0x1837DFE40")]
			public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x37DFDD0", Offset = "0x37DEDD0", VA = "0x1837DFDD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37D5020", Offset = "0x37D4020", VA = "0x1837D5020")]
				public void LONPEHHIFCO(RegisterTransforms OJEDNGBIKHJ)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000825")]
				[Cpp2IlInjected.Address(RVA = "0x37D6630", Offset = "0x37D5630", VA = "0x1837D6630")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D5130", Offset = "0x37D4130", VA = "0x1837D5130")]
			internal void POIJCEOICMD(Entity GEEFHDFLBEH, INDEJLDCMLL AGJLGNIMOFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x37D4F90", Offset = "0x37D3F90", VA = "0x1837D4F90", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int EFPAICPDPKD, int AEJOLEHEPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x37D5080", Offset = "0x37D4080", VA = "0x1837D5080")]
			public void PJKBGHCAGGI(ref ArchetypeChunk LJGMJGKCAEK, [NoAlias] ref EEBIJFAKLBA.MGHMNDLNIIC PFILCCGGCIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x37D5020", Offset = "0x37D4020", VA = "0x1837D5020")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A47C90", Offset = "0x2A46C90", VA = "0x182A47C90", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2A48570", Offset = "0x2A47570", VA = "0x182A48570", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2A48790", Offset = "0x2A47790", VA = "0x182A48790", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2A48870", Offset = "0x2A47870", VA = "0x182A48870")]
		private void PPELDHCHHMJ(EntityQuery JFPFDEFJDBP, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2A47CE0", Offset = "0x2A46CE0", VA = "0x182A47CE0")]
		private void IOJMOKCIKNO(EntityQuery JFPFDEFJDBP, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2A48740", Offset = "0x2A47740", VA = "0x182A48740", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2A476A0", Offset = "0x2A466A0", VA = "0x182A476A0")]
		private void CPKICJNHJPO(NativeArray<Entity> FBMJMNCDHDM, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2A477E0", Offset = "0x2A467E0", VA = "0x182A477E0")]
		[BurstCompile]
		internal static void FAELDAKLBND(NativeArray<INDEJLDCMLL> GIOJGEAAIGM, ComponentDataFromEntity<INDEJLDCMLL> KBPACPMPIMI, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private static void NIDLIBPLDNN(Transform BCHADNCHEKP, Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private static void NPJCMGIJMNE(Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private static void CPDILHHAHEB(int AIPHGHFENPJ, OCGCGAIFBCP OPDKJCOGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2A48110", Offset = "0x2A47110", VA = "0x182A48110")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void OPLEJMMLBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2A482F0", Offset = "0x2A472F0", VA = "0x182A482F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2A47AF0", Offset = "0x2A46AF0", VA = "0x182A47AF0")]
		public static EntityQuery GODINDNLLMP(ComponentSystemBase OJEDNGBIKHJ)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2A47F40", Offset = "0x2A46F40", VA = "0x182A47F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D4B80", Offset = "0x37D3B80", VA = "0x1837D4B80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DA690", Offset = "0x37D9690", VA = "0x1837DA690", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D9EF0", Offset = "0x37D8EF0", VA = "0x1837D9EF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0C140", Offset = "0x2E0B140", VA = "0x182E0C140", Slot = "14")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C310", Offset = "0x2E0B310", VA = "0x182E0C310", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C4E0", Offset = "0x2E0B4E0", VA = "0x182E0C4E0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C570", Offset = "0x2E0B570", VA = "0x182E0C570", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xCB1FA0", Offset = "0xCB0FA0", VA = "0x180CB1FA0")]
		internal JobHandle GEIIGNLGFLC()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C5A0", Offset = "0x2E0B5A0", VA = "0x182E0C5A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C190", Offset = "0x2E0B190", VA = "0x182E0C190")]
		private NativeArray<Entity> NHEOCOGPCFH(NativeArray<INDEJLDCMLL> LGLGGCHFNDI, NativeList<Entity> ILCJJBCCAGM, TransformAccessArray FECNFHOPJJE, TransformAccessArray NAMIGGEMGEK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DFB050", Offset = "0x2DFA050", VA = "0x182DFB050", Slot = "14")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB330", Offset = "0x2DFA330", VA = "0x182DFB330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB150", Offset = "0x2DFA150", VA = "0x182DFB150")]
	private static void LONBOHKOAAL(EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH, Entity ADECAOLBLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x2DFAF50", Offset = "0x2DF9F50", VA = "0x182DFAF50")]
	private static Transform AGDAIJOCIIH(EntityManager LKEHNCAJHHL, Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public ADBJNMLEGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DAC10", Offset = "0x37D9C10", VA = "0x1837DAC10")]
			[Conditional("DEBUG_BUILD")]
			private void FHMJJINLJDI(Entity GEEFHDFLBEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x37DA930", Offset = "0x37D9930", VA = "0x1837DA930", Slot = "4")]
			public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x37DACE0", Offset = "0x37D9CE0", VA = "0x1837DACE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A0B150", Offset = "0x2A0A150", VA = "0x182A0B150", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B270", Offset = "0x2A0A270", VA = "0x182A0B270", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D3C30", Offset = "0x37D2C30", VA = "0x1837D3C30", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x37D3D30", Offset = "0x37D2D30", VA = "0x1837D3D30")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private EntityQuery KCHNAHKCDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2A07A00", Offset = "0x2A06A00", VA = "0x182A07A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2A07B30", Offset = "0x2A06B30", VA = "0x182A07B30", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public KFLEDGAOGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D66B0", Offset = "0x37D56B0", VA = "0x1837D66B0", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x37D6A60", Offset = "0x37D5A60", VA = "0x1837D6A60")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private EntityQuery JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x2A06120", Offset = "0x2A05120", VA = "0x182A06120", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x2A06230", Offset = "0x2A05230", VA = "0x182A06230", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public JDGKDHAHBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D5210", Offset = "0x37D4210", VA = "0x1837D5210", Slot = "4")]
		public void Execute(ArchetypeChunk LJGMJGKCAEK, int AIPHGHFENPJ, int KIKLLBCKFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x37D5950", Offset = "0x37D4950", VA = "0x1837D5950")]
		public bool HDCJELIGLFP(ArchetypeChunk LJGMJGKCAEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private EntityQuery JKOOEKEEBJG;

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A780", Offset = "0x2A09780", VA = "0x182A0A780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A8B0", Offset = "0x2A098B0", VA = "0x182A0A8B0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle BKEKMFHAHMB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
	public KIJDBALHHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FC4F0", Offset = "0x29FB4F0", VA = "0x1829FC4F0")]
	protected FJKACBADHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x29FC4B0", Offset = "0x29FB4B0", VA = "0x1829FC4B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A3E2D0", Offset = "0x2A3D2D0", VA = "0x182A3E2D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E340", Offset = "0x2A3D340", VA = "0x182A3E340", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65D170", VA = "0x18065E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x2E03E20", Offset = "0x2E02E20", VA = "0x182E03E20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public BPIHAHBKMAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public sealed class OHBEPLANKDB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public OHBEPLANKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public CNDMKJANPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public EADAPMIJCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x65E170", Offset = "0x65D170", VA = "0x18065E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x2A138D0", Offset = "0x2A128D0", VA = "0x182A138D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000863")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public OMIDCKKPCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
public sealed class EHOCPENPMLI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public EHOCPENPMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E01030", Offset = "0x2E00030", VA = "0x182E01030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Type[] PPFMGJPFHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x2E010A0", Offset = "0x2E000A0", VA = "0x182E010A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x22E2FD0", Offset = "0x22E1FD0", VA = "0x1822E2FD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x37DE290", Offset = "0x37DD290", VA = "0x1837DE290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x37D8350", Offset = "0x37D7350", VA = "0x1837D8350")]
			[DebuggerHidden]
			public MCGFPAMHCAG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0x37DE0B0", Offset = "0x37DD0B0", VA = "0x1837DE0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x37DE250", Offset = "0x37DD250", VA = "0x1837DE250", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x37DE1B0", Offset = "0x37DD1B0", VA = "0x1837DE1B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(FEJKANODFOG, CBLLNBPHCKJ)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x37DE1B0", Offset = "0x37DD1B0", VA = "0x1837DE1B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A3BD90", Offset = "0x2A3AD90", VA = "0x182A3BD90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public GCGDMFPPNPN FCKIDLDDAFK
		{
			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x22EB2D0", Offset = "0x22EA2D0", VA = "0x1822EB2D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B980", Offset = "0x2A3A980", VA = "0x182A3B980", Slot = "6")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B580", Offset = "0x2A3A580", VA = "0x182A3B580", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C7E0", Offset = "0x2A3B7E0", VA = "0x182A3C7E0")]
		internal IEnumerable<Type> OEDOHBCLBMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B910", Offset = "0x2A3A910", VA = "0x182A3B910")]
		internal BKMFLCIMEEJ HBMJOEAILCE(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B8B0", Offset = "0x2A3A8B0", VA = "0x182A3B8B0")]
		public EntityArchetype FFEHPLPHBKO(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C230", Offset = "0x2A3B230", VA = "0x182A3C230", Slot = "4")]
		[IteratorStateMachine(typeof(MCGFPAMHCAG))]
		public IEnumerable<(FEJKANODFOG, CBLLNBPHCKJ)> LMEBMBJEMGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x2A3BDE0", Offset = "0x2A3ADE0", VA = "0x182A3BDE0")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x2A3BFB0", Offset = "0x2A3AFB0", VA = "0x182A3BFB0")]
		public CBLLNBPHCKJ KEOMIGEONAO(EFCIKLEKING NKICFHCCMMH)
		{
			return default(CBLLNBPHCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x2A3BF50", Offset = "0x2A3AF50", VA = "0x182A3BF50")]
		public CBLLNBPHCKJ KEOMIGEONAO(FEJKANODFOG NKICFHCCMMH)
		{
			return default(CBLLNBPHCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C810", Offset = "0x2A3B810", VA = "0x182A3C810")]
		public IEnumerable<CBLLNBPHCKJ> PDKEFKCBICH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2A3BEF0", Offset = "0x2A3AEF0", VA = "0x182A3BEF0")]
		public Entity IOLGMDLDDIN(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C400", Offset = "0x2A3B400", VA = "0x182A3C400")]
		private void MNFFEOCLIEH(BKMFLCIMEEJ HPFLFGLJAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C010", Offset = "0x2A3B010", VA = "0x182A3C010")]
		internal void LHGLALOAHCC(CBLLNBPHCKJ GFIKNFBJKNP, AMFJBNENFOE IIHOIPENPMG, EHGHKOOKADN POGEIAMADJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C2A0", Offset = "0x2A3B2A0", VA = "0x182A3C2A0")]
		private void MMDBJIABBFK(CBLLNBPHCKJ GFIKNFBJKNP, AMFJBNENFOE CGPLPFBCOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B460", Offset = "0x2A3A460", VA = "0x182A3B460")]
		internal Entity AIOJPOPMMMF(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C8B0", Offset = "0x2A3B8B0", VA = "0x182A3C8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DB00", Offset = "0x2E0CB00", VA = "0x182E0DB00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DE00", Offset = "0x2E0CE00", VA = "0x182E0DE00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DF50", Offset = "0x2E0CF50", VA = "0x182E0DF50", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DFC0", Offset = "0x2E0CFC0", VA = "0x182E0DFC0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DE70", Offset = "0x2E0CE70", VA = "0x182E0DE70", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DBD0", Offset = "0x2E0CBD0", VA = "0x182E0DBD0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DCB0", Offset = "0x2E0CCB0", VA = "0x182E0DCB0", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DEE0", Offset = "0x2E0CEE0", VA = "0x182E0DEE0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DD20", Offset = "0x2E0CD20", VA = "0x182E0DD20", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DC40", Offset = "0x2E0CC40", VA = "0x182E0DC40", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DB60", Offset = "0x2E0CB60", VA = "0x182E0DB60", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0DD90", Offset = "0x2E0CD90", VA = "0x182E0DD90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(AMFJBNENFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E030", Offset = "0x2E0D030", VA = "0x182E0E030")]
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
		[Cpp2IlInjected.Address(RVA = "0x204FFC0", Offset = "0x204EFC0", VA = "0x18204FFC0")]
		get
		{
			return default(OCGCGAIFBCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x2E034F0", Offset = "0x2E024F0", VA = "0x182E034F0", Slot = "4")]
	public void JMKABNNGGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x2E034E0", Offset = "0x2E024E0", VA = "0x182E034E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D4C80", Offset = "0x37D3C80", VA = "0x1837D4C80")]
			public CLMGIJDALIL(TransformOwnershipPhase ADECAOLBLPJ, MLCNOFLLEIM KDNCNAFJOGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x37D4C60", Offset = "0x37D3C60", VA = "0x1837D4C60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x656040", VA = "0x180657040")]
			get
			{
				return default(MLCNOFLLEIM);
			}
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x677F30", Offset = "0x676F30", VA = "0x180677F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool CBAABLKMGNA
		{
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0xBFA860", Offset = "0xBF9860", VA = "0x180BFA860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public bool HIIFNADKFDK
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x1571870", Offset = "0x1570870", VA = "0x181571870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E1E0", Offset = "0x2A4D1E0", VA = "0x182A4E1E0")]
		public CLMGIJDALIL POFMOHBMMAH()
		{
			return default(CLMGIJDALIL);
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E1B0", Offset = "0x2A4D1B0", VA = "0x182A4E1B0")]
		public CLMGIJDALIL LOCJGLBKDKE()
		{
			return default(CLMGIJDALIL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E045F0", Offset = "0x2E035F0", VA = "0x182E045F0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E04670", Offset = "0x2E03670", VA = "0x182E04670", Slot = "5")]
	public bool ILHNLLKCKAB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E04290", Offset = "0x2E03290", VA = "0x182E04290", Slot = "6")]
	public bool AOLBOGHMBHA(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E04730", Offset = "0x2E03730", VA = "0x182E04730", Slot = "7")]
	public Guid MOIDJDIBHBB(PMMHBDBEGAM ADGJAILKBPO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x2E04380", Offset = "0x2E03380", VA = "0x182E04380", Slot = "8")]
	public void BIKJHANLAHD(PMMHBDBEGAM ADGJAILKBPO, Guid ELBCBEIBJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E046D0", Offset = "0x2E036D0", VA = "0x182E046D0", Slot = "9")]
	public void MLGEPCENHDG(PMMHBDBEGAM ADGJAILKBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x37DF030", Offset = "0x37DE030", VA = "0x1837DF030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB2B20", Offset = "0xAB1B20", VA = "0x180AB2B20")]
			[DebuggerHidden]
			public OFDNGLGGDAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0x37DF080", Offset = "0x37DE080", VA = "0x1837DF080", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0x37DEBD0", Offset = "0x37DDBD0", VA = "0x1837DEBD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008CE")]
			[Cpp2IlInjected.Address(RVA = "0x37DF150", Offset = "0x37DE150", VA = "0x1837DF150")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008CF")]
			[Cpp2IlInjected.Address(RVA = "0x37DF1A0", Offset = "0x37DE1A0", VA = "0x1837DF1A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x37DEFF0", Offset = "0x37DDFF0", VA = "0x1837DEFF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x37DEF40", Offset = "0x37DDF40", VA = "0x1837DEF40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PMMHBDBEGAM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x37DEF40", Offset = "0x37DDF40", VA = "0x1837DEF40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D740", Offset = "0x66C740", VA = "0x18066D740", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0x68EDC0", Offset = "0x68DDC0", VA = "0x18068EDC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM> MEOPOOCHEFC
		{
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x2E0A710", Offset = "0x2E09710", VA = "0x182E0A710", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x2E0A970", Offset = "0x2E09970", VA = "0x182E0A970", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM> GPBFDMJOLDA
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x2E09DE0", Offset = "0x2E08DE0", VA = "0x182E09DE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x2E0B290", Offset = "0x2E0A290", VA = "0x182E0B290", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<PMMHBDBEGAM, PMMHBDBEGAM, PMMHBDBEGAM> KABKMNGALNG
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0x2E0B5A0", Offset = "0x2E0A5A0", VA = "0x182E0B5A0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0x2E0B500", Offset = "0x2E0A500", VA = "0x182E0B500", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<PMMHBDBEGAM> FCKEPJEGAEI
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x2E0B640", Offset = "0x2E0A640", VA = "0x182E0B640", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AC70", Offset = "0x2E09C70", VA = "0x182E0AC70", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AA10", Offset = "0x2E09A10", VA = "0x182E0AA10", Slot = "23")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x2E0ADA0", Offset = "0x2E09DA0", VA = "0x182E0ADA0", Slot = "24")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A380", Offset = "0x2E09380", VA = "0x182E0A380", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A100", Offset = "0x2E09100", VA = "0x182E0A100")]
		private void DDHFANMADGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E09C70", Offset = "0x2E08C70", VA = "0x182E09C70")]
		private void BGIGHDKDABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A7B0", Offset = "0x2E097B0", VA = "0x182E0A7B0")]
		private void FAKMPPADCJM(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A320", Offset = "0x2E09320", VA = "0x182E0A320")]
		private void DOLAONIGMDJ(Entity GEEFHDFLBEH, JLCDNMLCNEN ABEODFEGJBP, MJADMLMEADH BEIKMLIBFDO, MJADMLMEADH HFFCNNKMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x21D31D0", Offset = "0x21D21D0", VA = "0x1821D31D0", Slot = "14")]
		public PMMHBDBEGAM BBBMNFOODKF(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x1464D80", Offset = "0x1463D80", VA = "0x181464D80", Slot = "15")]
		public Color EHCGLGLIIHP(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A530", Offset = "0x2E09530", VA = "0x182E0A530", Slot = "16")]
		public float3 EDBIPCCLEHA(PMMHBDBEGAM ADGJAILKBPO, int IHIBPPDLLME)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AB90", Offset = "0x2E09B90", VA = "0x182E0AB90", Slot = "17")]
		public bool JCGFFABNCHF(PMMHBDBEGAM ADGJAILKBPO, PMMHBDBEGAM FKDHOLGPOMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2E09BC0", Offset = "0x2E08BC0", VA = "0x182E09BC0", Slot = "18")]
		public PMMHBDBEGAM AILCCJELIAN(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B6E0", Offset = "0x2E0A6E0", VA = "0x182E0B6E0", Slot = "21")]
		public void PKDJCLPCGDK(PMMHBDBEGAM ADGJAILKBPO, Vector3 ONIGPANBOIK, Quaternion INKFPMJDIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2E09A20", Offset = "0x2E08A20", VA = "0x182E09A20", Slot = "26")]
		public (Vector3, Quaternion) ABEECJHILAL(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A160", Offset = "0x2E09160", VA = "0x182E0A160", Slot = "27")]
		public (Vector3, Quaternion) DFMLGPGOEDO(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B330", Offset = "0x2E0A330", VA = "0x182E0B330", Slot = "22")]
		public (Vector3, Quaternion, bool) LAGGPCHAALA(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AD10", Offset = "0x2E09D10", VA = "0x182E0AD10", Slot = "19")]
		[IteratorStateMachine(typeof(OFDNGLGGDAP))]
		public IEnumerable<PMMHBDBEGAM> KICEPBHGBMN(PMMHBDBEGAM ADGJAILKBPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2E09FA0", Offset = "0x2E08FA0", VA = "0x182E09FA0", Slot = "20")]
		public PMMHBDBEGAM DCBCGPDHMLI(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B900", Offset = "0x2E0A900", VA = "0x182E0B900", Slot = "28")]
		public void PPDLNFBKINL(ref List<PMMHBDBEGAM> PNCPJCEBIDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2E09E80", Offset = "0x2E08E80", VA = "0x182E09E80")]
		private Entity DCBCGPDHMLI(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BB60", Offset = "0x2E0AB60", VA = "0x182E0BB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707D90", VA = "0x180708D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B0600", Offset = "0x8AF600", VA = "0x1808B0600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xEAA480", Offset = "0xEA9480", VA = "0x180EAA480", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public bool PPICPACFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2E12760", Offset = "0x2E11760", VA = "0x182E12760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E12710", Offset = "0x2E11710", VA = "0x182E12710", Slot = "8")]
	public bool Equals(EMPKMDMEDJP HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E127A0", Offset = "0x2E117A0", VA = "0x182E127A0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A04480", Offset = "0x2A03480", VA = "0x182A04480")]
	public IEEGJNHOIPN(EntityManager LKEHNCAJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A03FF0", Offset = "0x2A02FF0", VA = "0x182A03FF0")]
	public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A03E70", Offset = "0x2A02E70", VA = "0x182A03E70")]
	public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A041D0", Offset = "0x2A031D0", VA = "0x182A041D0")]
	public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A04210", Offset = "0x2A03210", VA = "0x182A04210")]
	public bool JAGDJCPMKBG(EMPKMDMEDJP MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A042B0", Offset = "0x2A032B0", VA = "0x182A042B0")]
	public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A040F0", Offset = "0x2A030F0", VA = "0x182A040F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A04390", Offset = "0x2A03390", VA = "0x182A04390")]
	private void NKCCEGIINBM(HashSet<object> ILPGJLCJEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A03DA0", Offset = "0x2A02DA0", VA = "0x182A03DA0")]
	private bool CLAJAHGNDCP(Entity GEEFHDFLBEH, out EMPKMDMEDJP MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A04400", Offset = "0x2A03400", VA = "0x182A04400")]
	private void ONNCBMCEBOI(Entity GEEFHDFLBEH, EMPKMDMEDJP MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A03D40", Offset = "0x2A02D40", VA = "0x182A03D40")]
	private bool BJEHCIFKJPO(EMPKMDMEDJP FHNOFBNPNEA, out HashSet<object> ILPGJLCJEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A04130", Offset = "0x2A03130", VA = "0x182A04130")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A153A0", Offset = "0x2A143A0", VA = "0x182A153A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public int HJDHFKEEIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x2A16150", Offset = "0x2A15150", VA = "0x182A16150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public int AKKJDCEMEPC
		{
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x2A16E20", Offset = "0x2A15E20", VA = "0x182A16E20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<FEMMDHLANDH> HOEKIBHIEBB
		{
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0x2A166A0", Offset = "0x2A156A0", VA = "0x182A166A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(RVA = "0x2A16E40", Offset = "0x2A15E40", VA = "0x182A16E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<FEMMDHLANDH> PKHHOODAJLP
		{
			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0x2A13B40", Offset = "0x2A12B40", VA = "0x182A13B40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0x2A15A50", Offset = "0x2A14A50", VA = "0x182A15A50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A15F00", Offset = "0x2A14F00", VA = "0x182A15F00", Slot = "4")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A15670", Offset = "0x2A14670", VA = "0x182A15670", Slot = "5")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A15F10", Offset = "0x2A14F10", VA = "0x182A15F10", Slot = "6")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A151C0", Offset = "0x2A141C0", VA = "0x182A151C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A16270", Offset = "0x2A15270", VA = "0x182A16270")]
		public bool MBFENICDONN(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI, out NativeList<Entity> FEGJPLALHAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A148B0", Offset = "0x2A138B0", VA = "0x182A148B0")]
		public global::OHBAMBCHLEK<Entity> CAKLBPIABDK(Allocator JEOILJEOOOI)
		{
			return default(global::OHBAMBCHLEK<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A148F0", Offset = "0x2A138F0", VA = "0x182A148F0")]
		public bool CDOIOEBAIAC(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A149C0", Offset = "0x2A139C0", VA = "0x182A149C0")]
		public bool CECLHLMOAFB(Entity GEEFHDFLBEH, out GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A14910", Offset = "0x2A13910", VA = "0x182A14910")]
		private bool CECLHLMOAFB(Transform BCHADNCHEKP, out GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A15B70", Offset = "0x2A14B70", VA = "0x182A15B70")]
		internal bool IFBJDDLJDKH(Entity GEEFHDFLBEH, out HDIAJFLHONH DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A13AA0", Offset = "0x2A12AA0", VA = "0x182A13AA0")]
		private void AOPNOMOLIPC(Entity GEEFHDFLBEH, GIALAGJINEB DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A16460", Offset = "0x2A15460", VA = "0x182A16460")]
		private bool MEEOHNLDHKG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A174A0", Offset = "0x2A164A0", VA = "0x182A174A0")]
		public void PJHBAIJLMNC(NMEJDFJAOOA DBGIPPEDJIM, GIALAGJINEB FGEIHINONNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A14A30", Offset = "0x2A13A30", VA = "0x182A14A30")]
		public bool CGFONLINMHA(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A13BE0", Offset = "0x2A12BE0", VA = "0x182A13BE0")]
		public bool BHOEHOJGMNO(PMMHBDBEGAM ADGJAILKBPO, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A144C0", Offset = "0x2A134C0", VA = "0x182A144C0")]
		public bool BHOEHOJGMNO(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2A14060", Offset = "0x2A13060", VA = "0x182A14060")]
		public bool BHOEHOJGMNO(GIALAGJINEB LFIMBOIOPFD, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2A16990", Offset = "0x2A15990", VA = "0x182A16990")]
		public bool NIMKLNCMIKA(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2A16DF0", Offset = "0x2A15DF0", VA = "0x182A16DF0")]
		public bool NIMKLNCMIKA(GIALAGJINEB DNCNJICBAHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2A14080", Offset = "0x2A13080", VA = "0x182A14080")]
		public bool BHOEHOJGMNO(GIALAGJINEB DNCNJICBAHE, [Optional] object MKDOEIGPNGM, bool EFJKFNKFDIO = false, bool NEGBKBLGNAB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2A16EE0", Offset = "0x2A15EE0", VA = "0x182A16EE0")]
		public Transform OFFKLJGCIOM(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x2A154D0", Offset = "0x2A144D0", VA = "0x182A154D0")]
		public bool FPFNOLCEKGF(Entity GEEFHDFLBEH, out Transform BCHADNCHEKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x2A16180", Offset = "0x2A15180", VA = "0x182A16180")]
		public GIALAGJINEB LFOFKHPGLIF(Entity GEEFHDFLBEH, [Optional] object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x2A15850", Offset = "0x2A14850", VA = "0x182A15850")]
		public void HKEPNALNJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2A14510", Offset = "0x2A13510", VA = "0x182A14510")]
		public void CAANKKMCLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x2A15BF0", Offset = "0x2A14BF0", VA = "0x182A15BF0")]
		private void JCMLAECOIFB(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x2A15B20", Offset = "0x2A14B20", VA = "0x182A15B20")]
		public GIALAGJINEB HOAGOKEBLHG(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x2A14F70", Offset = "0x2A13F70", VA = "0x182A14F70")]
		public void DHLJLJAEDMC(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2A14EA0", Offset = "0x2A13EA0", VA = "0x182A14EA0")]
		public bool CLPAMGAJDJM(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2A16170", Offset = "0x2A15170", VA = "0x182A16170")]
		public bool LEGPMMJHLCL(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2A15BA0", Offset = "0x2A14BA0", VA = "0x182A15BA0")]
		public bool JAGDJCPMKBG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2A15B90", Offset = "0x2A14B90", VA = "0x182A15B90")]
		public bool JAGDJCPMKBG(EMPKMDMEDJP MIGDJNOKMHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2A14EB0", Offset = "0x2A13EB0", VA = "0x182A14EB0")]
		private void CLPLDICPPAA(bool BDEMLJAFCKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2A16480", Offset = "0x2A15480", VA = "0x182A16480")]
		private bool MFHKGCFEGBK(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2A160E0", Offset = "0x2A150E0", VA = "0x182A160E0")]
		private GIALAGJINEB KJMFLPPNFBI(Entity GEEFHDFLBEH, object MKDOEIGPNGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2A16510", Offset = "0x2A15510", VA = "0x182A16510")]
		private GIALAGJINEB MPPPPPDCDEK(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2A170D0", Offset = "0x2A160D0", VA = "0x182A170D0")]
		private (Vector3, Quaternion, Vector3) PCNHGAJFKOM(Entity GEEFHDFLBEH)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2A175D0", Offset = "0x2A165D0", VA = "0x182A175D0")]
		private void PNLNEOCBNMO(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2A172F0", Offset = "0x2A162F0", VA = "0x182A172F0")]
		private void PIOCBLOBICC(PMMHBDBEGAM ADGJAILKBPO, GIALAGJINEB FGEIHINONNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2A16740", Offset = "0x2A15740", VA = "0x182A16740")]
		private void NABOMLEGBEG(GIALAGJINEB DNCNJICBAHE, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2A14F80", Offset = "0x2A13F80", VA = "0x182A14F80")]
		private void DMCLGDJIJOA(Entity GEEFHDFLBEH, GIALAGJINEB DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2A153F0", Offset = "0x2A143F0", VA = "0x182A153F0")]
		private void FCNAKMLEAJB(Entity GEEFHDFLBEH, Transform BCHADNCHEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2A15AF0", Offset = "0x2A14AF0", VA = "0x182A15AF0")]
		private PMMHBDBEGAM HNAKNLCBGOJ(Entity GEEFHDFLBEH)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2A17A90", Offset = "0x2A16A90", VA = "0x182A17A90")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2A155A0", Offset = "0x2A145A0", VA = "0x182A155A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E0D610", Offset = "0x2E0C610", VA = "0x182E0D610")]
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
			[Cpp2IlInjected.Address(RVA = "0x2E14900", Offset = "0x2E13900", VA = "0x182E14900")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x2E14A40", Offset = "0x2E13A40", VA = "0x182E14A40", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2E14E20", Offset = "0x2E13E20", VA = "0x182E14E20")]
		internal void LPGPGLILELA(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2E14FA0", Offset = "0x2E13FA0", VA = "0x182E14FA0")]
		internal void MAEAMPCOPIO(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2E15340", Offset = "0x2E14340", VA = "0x182E15340")]
		private int NGIIJLPJFKN(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2E14AC0", Offset = "0x2E13AC0", VA = "0x182E14AC0")]
		internal DynamicBuffer<ChildrenData> IBBBKOHNJEB(Entity GEEFHDFLBEH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x2E14B90", Offset = "0x2E13B90", VA = "0x182E14B90")]
		internal DynamicBuffer<ChildrenData> INNICMNBKHH(Entity GEEFHDFLBEH)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2E15070", Offset = "0x2E14070", VA = "0x182E15070")]
		public NativeArray<Entity> MMEBCOLEPOK(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x2E14C60", Offset = "0x2E13C60", VA = "0x182E14C60")]
		public bool JHKJHDCPCPH(Entity GEEFHDFLBEH, Allocator JEOILJEOOOI, out NativeArray<Entity> GDEADEABPNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x2E147D0", Offset = "0x2E137D0", VA = "0x182E147D0")]
		public NativeArray<Entity> DOINHDHLNBE(Entity GEEFHDFLBEH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2E15230", Offset = "0x2E14230", VA = "0x182E15230")]
		public Entity NFFPNEMPLNO(Entity GEEFHDFLBEH, int AIPHGHFENPJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2E14950", Offset = "0x2E13950", VA = "0x182E14950")]
		public int HDHNEFAFOAJ(Entity GEEFHDFLBEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E155D0", Offset = "0x2E145D0", VA = "0x182E155D0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2E15480", Offset = "0x2E14480", VA = "0x182E15480", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private void HIHKANDABHD(FEMMDHLANDH DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private void OOCJGKPDIGM(FEMMDHLANDH DNCNJICBAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private void EHKNKBCLFJE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E15B60", Offset = "0x2E14B60", VA = "0x182E15B60", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2E15C80", Offset = "0x2E14C80", VA = "0x182E15C80", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2E158D0", Offset = "0x2E148D0", VA = "0x182E158D0")]
		public Entity AILCCJELIAN(Entity GEEFHDFLBEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2E15B00", Offset = "0x2E14B00", VA = "0x182E15B00")]
		public bool FKEELJGEBOF(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x2E15BE0", Offset = "0x2E14BE0", VA = "0x182E15BE0")]
		public bool JCGFFABNCHF(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ, bool CAMPEPOCDEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x2E15920", Offset = "0x2E14920", VA = "0x182E15920")]
		private bool DMPHBHLECHG(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x22E2FD0", Offset = "0x22E1FD0", VA = "0x1822E2FD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x37DC500", Offset = "0x37DB500", VA = "0x1837DC500", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x37D8350", Offset = "0x37D7350", VA = "0x1837D8350")]
		[DebuggerHidden]
		public KHFHHBDLGJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x37DC370", Offset = "0x37DB370", VA = "0x1837DC370", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x37DC4C0", Offset = "0x37DB4C0", VA = "0x1837DC4C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x37DC410", Offset = "0x37DB410", VA = "0x1837DC410", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x37DC410", Offset = "0x37DB410", VA = "0x1837DC410", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x22E2FD0", Offset = "0x22E1FD0", VA = "0x1822E2FD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D8220", Offset = "0x37D7220", VA = "0x1837D8220", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x37D8350", Offset = "0x37D7350", VA = "0x1837D8350")]
		[DebuggerHidden]
		public GCOAHNELPOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x37D8270", Offset = "0x37D7270", VA = "0x1837D8270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x37D7F60", Offset = "0x37D6F60", VA = "0x1837D7F60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x37D8300", Offset = "0x37D7300", VA = "0x1837D8300")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x37D81E0", Offset = "0x37D71E0", VA = "0x1837D81E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x37D8130", Offset = "0x37D7130", VA = "0x1837D8130", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x37D8130", Offset = "0x37D7130", VA = "0x1837D8130", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x22E2FD0", Offset = "0x22E1FD0", VA = "0x1822E2FD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D9030", Offset = "0x37D8030", VA = "0x1837D9030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x37D8350", Offset = "0x37D7350", VA = "0x1837D8350")]
		[DebuggerHidden]
		public HFALFENBENM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x37D9080", Offset = "0x37D8080", VA = "0x1837D9080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x37D8C40", Offset = "0x37D7C40", VA = "0x1837D8C40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x37D9150", Offset = "0x37D8150", VA = "0x1837D9150")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x37D91A0", Offset = "0x37D81A0", VA = "0x1837D91A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x37D8FF0", Offset = "0x37D7FF0", VA = "0x1837D8FF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x37D8F40", Offset = "0x37D7F40", VA = "0x1837D8F40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x37D8F40", Offset = "0x37D7F40", VA = "0x1837D8F40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E18840", Offset = "0x2E17840", VA = "0x182E18840")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093D")]
	[Cpp2IlInjected.Address(RVA = "0x2E18A30", Offset = "0x2E17A30", VA = "0x182E18A30", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2E18820", Offset = "0x2E17820", VA = "0x182E18820", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2E183E0", Offset = "0x2E173E0", VA = "0x182E183E0")]
	public bool BEBDCGNEJPP(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x2E185B0", Offset = "0x2E175B0", VA = "0x182E185B0")]
	public bool BKLGLKDLCLG(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2E18E90", Offset = "0x2E17E90", VA = "0x182E18E90")]
	public IEnumerable<Entity> NJHHOCACKHJ(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x2E18B90", Offset = "0x2E17B90", VA = "0x182E18B90")]
	[IteratorStateMachine(typeof(KHFHHBDLGJP))]
	private IEnumerable<Entity> JFPEENCJEGK(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2E18930", Offset = "0x2E17930", VA = "0x182E18930")]
	public bool FLMGCLJOAAP(Entity GEEFHDFLBEH, Entity NIPKJIJGCKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x2E18A10", Offset = "0x2E17A10", VA = "0x182E18A10")]
	public bool GOENCLMLMME(Entity GEEFHDFLBEH, Entity PJCDGLCJFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2E18FA0", Offset = "0x2E17FA0", VA = "0x182E18FA0")]
	public IEnumerable<Entity> OEMKFPIEJOP(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2E18890", Offset = "0x2E17890", VA = "0x182E18890")]
	[IteratorStateMachine(typeof(GCOAHNELPOE))]
	private IEnumerable<Entity> FBIGMHMMJEL(Entity GEEFHDFLBEH, bool OKPOHGGKLOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2E187A0", Offset = "0x2E177A0", VA = "0x182E187A0")]
	[IteratorStateMachine(typeof(HFALFENBENM))]
	private IEnumerable<Entity> DFAOJBFPFIP(Entity GEEFHDFLBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x2E186C0", Offset = "0x2E176C0", VA = "0x182E186C0")]
	public Entity DCBCGPDHMLI(Entity GEEFHDFLBEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x2E190B0", Offset = "0x2E180B0", VA = "0x182E190B0")]
	public NativeArray<Entity> PPDLNFBKINL()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x2E18C30", Offset = "0x2E17C30", VA = "0x182E18C30")]
	public bool MKDAEBPAGML(Entity PJCDGLCJFAM, Entity EJPDMNHPBOC, out Entity CHCJBMDJNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public FGBIJEJJFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal static class HGHIJDIADBD
{
	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x2A01010", Offset = "0x2A00010", VA = "0x182A01010")]
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
		[Cpp2IlInjected.Address(RVA = "0x327AF60", Offset = "0x3279F60", VA = "0x18327AF60")]
		public static void ENJHCNHMIBP<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(FFPEBHHNJFF FJKJAKKFINM, global::NBBJGEJPPKL<Entity> JLHBKPIPBGO, out global::NNBBLOFFBOH<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> PAOPFHIHHOM) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, LJBPPGAHFFJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, LJBPPGAHFFJ, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FB00", Offset = "0x2A3EB00", VA = "0x182A3FB00")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E77210", Offset = "0x2E76210", VA = "0x182E77210")]
	public NNBBLOFFBOH(FFPEBHHNJFF FJKJAKKFINM, global::NBBJGEJPPKL<Entity> JLHBKPIPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x2E76B00", Offset = "0x2E75B00", VA = "0x182E76B00")]
	private bool PLEKBFHCCPD(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x2E76040", Offset = "0x2E75040", VA = "0x182E76040")]
	private bool HPNGKKCNHEG(Entity GEEFHDFLBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x2E763D0", Offset = "0x2E753D0", VA = "0x182E763D0")]
	public bool KKFDIADEDKB(Entity GEEFHDFLBEH, in Entity JDMCICBCFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	private static void KPJGGNLILMC(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	private static void FHBPHLLELDP(Entity GEEFHDFLBEH, Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x2E75D50", Offset = "0x2E74D50", VA = "0x182E75D50")]
	private bool BEBDCGNEJPP(Entity GEEFHDFLBEH, Entity FMEILHGLAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x2E75E30", Offset = "0x2E74E30", VA = "0x182E75E30")]
	private void FHIFJDEGHPP(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2E76090", Offset = "0x2E75090", VA = "0x182E76090")]
	private void JCMJBKEMIAG(Entity GEEFHDFLBEH, in Entity POICJGPACMK, in Entity JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x2E76600", Offset = "0x2E75600", VA = "0x182E76600")]
	private bool LPNAJKOBPJM(IKKLLNPBAHK NDCABLNNFKI, in NMEJDFJAOOA HOAPGBAADBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2E75F10", Offset = "0x2E74F10", VA = "0x182E75F10")]
	private void FIGNIJGDPHJ(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x2E769E0", Offset = "0x2E759E0", VA = "0x182E769E0")]
	private void NKNHNPFFGPO(Entity ADECAOLBLPJ, Entity NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	private void CPDILHHAHEB(Entity GEEFHDFLBEH, Entity POICJGPACMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A17F40", Offset = "0x2A16F40", VA = "0x182A17F40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x2A17B50", Offset = "0x2A16B50", VA = "0x182A17B50", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x2A17CB0", Offset = "0x2A16CB0", VA = "0x182A17CB0")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x2A17D30", Offset = "0x2A16D30", VA = "0x182A17D30")]
		public Entity HPGBMGMHAGL(CBLLNBPHCKJ GFIKNFBJKNP, NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x2A17E30", Offset = "0x2A16E30", VA = "0x182A17E30")]
		public Entity MHKAFBIPHPF(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x2A17F60", Offset = "0x2A16F60", VA = "0x182A17F60")]
		public Entity PACACJLKIEO(NMEJDFJAOOA DBGIPPEDJIM, CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0x2A17B40", Offset = "0x2A16B40", VA = "0x182A17B40")]
		public Entity HFJOEDICIOL(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x2A17B10", Offset = "0x2A16B10", VA = "0x182A17B10")]
		public Entity FECCIBCHBLN()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x2A17F00", Offset = "0x2A16F00", VA = "0x182A17F00")]
		public Entity NOBCDOCLECL(FEJKANODFOG NKICFHCCMMH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x2A17DD0", Offset = "0x2A16DD0", VA = "0x182A17DD0")]
		public Entity IHEGMFIAJED(EFCIKLEKING NKICFHCCMMH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x2A17C60", Offset = "0x2A16C60", VA = "0x182A17C60")]
		public NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)> HPGBMGMHAGL(NativeArray<PMMHBDBEGAM> CGGBICHOEDC, Allocator JEOILJEOOOI)
		{
			return default(NativeArray<(PMMHBDBEGAM, PMMHBDBEGAM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x2A18000", Offset = "0x2A17000", VA = "0x182A18000")]
		public IEnumerable<CBLLNBPHCKJ> PDKEFKCBICH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x2A17B20", Offset = "0x2A16B20", VA = "0x182A17B20")]
		public EntityArchetype FFEHPLPHBKO(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2A17E10", Offset = "0x2A16E10", VA = "0x182A17E10")]
		public Entity IOLGMDLDDIN(CBLLNBPHCKJ GFIKNFBJKNP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x2A17E50", Offset = "0x2A16E50", VA = "0x182A17E50")]
		private Entity NDGGKFMBDOG(CBLLNBPHCKJ GFIKNFBJKNP, NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A3FB50", Offset = "0x2A3EB50", VA = "0x182A3FB50", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x2A40AF0", Offset = "0x2A3FAF0", VA = "0x182A40AF0", Slot = "9")]
		public void JMKABNNGGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x2A40450", Offset = "0x2A3F450", VA = "0x182A40450", Slot = "10")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FED0", Offset = "0x2A3EED0", VA = "0x182A3FED0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FB90", Offset = "0x2A3EB90", VA = "0x182A3FB90", Slot = "4")]
		public NCGEEIAJEOJ ANGLAMGMPLO(Entity GEEFHDFLBEH)
		{
			return default(NCGEEIAJEOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FFD0", Offset = "0x2A3EFD0", VA = "0x182A3FFD0", Slot = "5")]
		public void EKKHEBFMCND(NativeArray<NCGEEIAJEOJ> AGFPEFOAJDF, NativeArray<NMNILGJABIA> HEICMLFEKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FE00", Offset = "0x2A3EE00", VA = "0x182A3FE00", Slot = "6")]
		public void DHBLDBLJOBK(NCGEEIAJEOJ MIGDJNOKMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x2A40590", Offset = "0x2A3F590", VA = "0x182A40590", Slot = "7")]
		public bool IAJFOCJNBCA(NCGEEIAJEOJ MIGDJNOKMHC, out Collider JDJCJCADDGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x2A40630", Offset = "0x2A3F630", VA = "0x182A40630")]
		public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x2A401F0", Offset = "0x2A3F1F0", VA = "0x182A401F0")]
		private void GHANMEIKHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0xCBA960", Offset = "0xCB9960", VA = "0x180CBA960")]
		private void LKLIONOAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x2A40C60", Offset = "0x2A3FC60", VA = "0x182A40C60")]
		private void KCGIMLCGKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x1147360", Offset = "0x1146360", VA = "0x181147360")]
		private void LJFJDLJMDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FCE0", Offset = "0x2A3ECE0", VA = "0x182A3FCE0")]
		private BoxCollider BILPPOGKOPN(Entity GEEFHDFLBEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x2A40510", Offset = "0x2A3F510", VA = "0x182A40510")]
		private void HHCGJADMOEJ(BoxCollider AGOKDHIHIOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2A40940", Offset = "0x2A3F940", VA = "0x182A40940")]
		[Conditional("UNITY_EDITOR")]
		private void IGOHFKMBNPC(GameObject BFJMKCMPBKG, Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2A40980", Offset = "0x2A3F980", VA = "0x182A40980")]
		private void JMHGIBDONMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x2A40CF0", Offset = "0x2A3FCF0", VA = "0x182A40CF0")]
		private void MLCJNMBAIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x2A40240", Offset = "0x2A3F240", VA = "0x182A40240")]
		private void GOMKMNLDGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2A40E00", Offset = "0x2A3FE00", VA = "0x182A40E00")]
		private void OOIJGHCNGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2A401E0", Offset = "0x2A3F1E0", VA = "0x182A401E0")]
		private void FFAGAJBIINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x2A40CB0", Offset = "0x2A3FCB0", VA = "0x182A40CB0")]
		private void MHJIMLLCPKK(Scene LKJDNOKNMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FB40", Offset = "0x2A3EB40", VA = "0x182A3FB40", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FF6D0", Offset = "0x29FE6D0", VA = "0x1829FF6D0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x29FF740", Offset = "0x29FE740", VA = "0x1829FF740")]
	public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, out LAGADACOOOP PEIHFKCOJDK, out Entity GOCCFAICBMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x29FF5D0", Offset = "0x29FE5D0", VA = "0x1829FF5D0")]
	public static bool GJAKEOAPIFJ(in Span<LAGADACOOOP> ENFPPCCMHCG, float JEIPODGPOFH, out int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x29FFBC0", Offset = "0x29FEBC0", VA = "0x1829FFBC0")]
	public static float MMELGNPDJMN(float ACDBJHBECNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public GMCCOMDABLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x29FF5C0", Offset = "0x29FE5C0", VA = "0x1829FF5C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37DCE10", Offset = "0x37DBE10", VA = "0x1837DCE10", Slot = "4")]
		public void Execute(int AIPHGHFENPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x37DCD40", Offset = "0x37DBD40", VA = "0x1837DCD40")]
		private static float3 EPBEPIAADBN(in float4x4 JDJKNCCKKMA, in float3 JOLHNMOCKDJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x37DD0F0", Offset = "0x37DC0F0", VA = "0x1837DD0F0")]
		private static float3 KHIMFCKDMNI(in float4x4 JDJKNCCKKMA, in float3 NAGBPGCPEDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x37DD980", Offset = "0x37DC980", VA = "0x1837DD980")]
		private static float3 LOOFFKKDFMB(in float4x4 JDJKNCCKKMA, in float3 JOLHNMOCKDJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x37DDD80", Offset = "0x37DCD80", VA = "0x1837DDD80")]
		private static float3 NFEOPCKOOAA(in float4x4 JDJKNCCKKMA, in float3 NAGBPGCPEDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x37DDA80", Offset = "0x37DCA80", VA = "0x1837DDA80")]
		private bool MOMMEFDGJGO(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<Entity> CNEMJNCMMKA, out float3 PEIHFKCOJDK, out float3 BJLFJKGMNHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x37DD2B0", Offset = "0x37DC2B0", VA = "0x1837DD2B0")]
		public static bool KJBDHLGAJIO(in float3 EENGOCNGPNB, in float3 DCOMCKGCKBH, in float3 PAOFDIIDBMK, in float3 JCOAFPHKEFN, float IADELNJNICE, float GIDFBHLFDCN, out float MGEGOIPHNMM, out float3 JLKDEHPMNLG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private EntityManager LKEHNCAJHHL;

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x29FDC40", Offset = "0x29FCC40", VA = "0x1829FDC40", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x29FDCC0", Offset = "0x29FCCC0", VA = "0x1829FDCC0")]
	public void IGDPCCPOHMI(in NativeArray<Entity> FBMJMNCDHDM, in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, in NativeArray<LAGADACOOOP> CLHAIOKMEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public FNEJDFJNBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x29FDCC0", Offset = "0x29FCCC0", VA = "0x1829FDCC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A18660", Offset = "0x2A17660", VA = "0x182A18660")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Entity, CBLLNBPHCKJ> PENFFKIPBOK
		{
			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x2A189C0", Offset = "0x2A179C0", VA = "0x182A189C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x2A185C0", Offset = "0x2A175C0", VA = "0x182A185C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Entity> NNDDOAEECDO
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x2A188B0", Offset = "0x2A178B0", VA = "0x182A188B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x2A186B0", Offset = "0x2A176B0", VA = "0x182A186B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A18750", Offset = "0x2A17750", VA = "0x182A18750", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x1192F90", Offset = "0x1191F90", VA = "0x181192F90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A18210", Offset = "0x2A17210", VA = "0x182A18210")]
		public bool AEBBOEKMPNE(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A18BB0", Offset = "0x2A17BB0", VA = "0x182A18BB0")]
		internal void MDCLCNEPJCC(Entity GEEFHDFLBEH, CBLLNBPHCKJ GFIKNFBJKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A184B0", Offset = "0x2A174B0", VA = "0x182A184B0")]
		public void CHMNDPKCMOJ(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A18070", Offset = "0x2A17070", VA = "0x182A18070")]
		public void ACKFNLGGLJE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A18A60", Offset = "0x2A17A60", VA = "0x182A18A60")]
		private bool KNCDHIHBFDG(Entity GEEFHDFLBEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A18E70", Offset = "0x2A17E70", VA = "0x182A18E70")]
		public void NONGHDEHHOE(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A18590", Offset = "0x2A17590", VA = "0x182A18590")]
		private void ELCHMDLCCOO(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A18C10", Offset = "0x2A17C10", VA = "0x182A18C10")]
		private void MLDIKEFLBDK(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A18280", Offset = "0x2A17280", VA = "0x182A18280")]
		public void ANPFAIODGJP(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A18950", Offset = "0x2A17950", VA = "0x182A18950")]
		private void IOMGEBLBJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A18F50", Offset = "0x2A17F50", VA = "0x182A18F50")]
		private void PFBEKIDPBBJ(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD85AF0", Offset = "0xD84AF0", VA = "0x180D85AF0")]
			get
			{
				return default(NativeHashMap<NMEJDFJAOOA, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B210", Offset = "0x2A3A210", VA = "0x182A3B210", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AFB0", Offset = "0x2A39FB0", VA = "0x182A3AFB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B310", Offset = "0x2A3A310", VA = "0x182A3B310")]
		private PMMHBDBEGAM HNAKNLCBGOJ(Entity GEEFHDFLBEH)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B130", Offset = "0x2A3A130", VA = "0x182A3B130")]
		public PMMHBDBEGAM GJELMEFNGNA(NMEJDFJAOOA DBGIPPEDJIM)
		{
			return default(PMMHBDBEGAM);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B0A0", Offset = "0x2A3A0A0", VA = "0x182A3B0A0")]
		public NMEJDFJAOOA GAGENPHPDNI(PMMHBDBEGAM ADGJAILKBPO)
		{
			return default(NMEJDFJAOOA);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B010", Offset = "0x2A3A010", VA = "0x182A3B010")]
		public void EJEGPNOCOKC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AEF0", Offset = "0x2A39EF0", VA = "0x182A3AEF0")]
		public void ABMEIFNFFHC(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A3AF50", Offset = "0x2A39F50", VA = "0x182A3AF50")]
		public void CDADDOFNGMF(Entity GEEFHDFLBEH, NMEJDFJAOOA DBGIPPEDJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A3B340", Offset = "0x2A3A340", VA = "0x182A3B340")]
		public void JPHKACHFAFL(Entity GEEFHDFLBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A470E0", Offset = "0x2A460E0", VA = "0x182A470E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A466F0", Offset = "0x2A456F0", VA = "0x182A466F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action JHLJECICLDM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A46A10", Offset = "0x2A45A10", VA = "0x182A46A10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2A46280", Offset = "0x2A45280", VA = "0x182A46280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A466A0", Offset = "0x2A456A0", VA = "0x182A466A0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A47180", Offset = "0x2A46180", VA = "0x182A47180")]
		public void PJHBAIJLMNC(JLCDNMLCNEN ABEODFEGJBP, PDEHMHFLINN GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A465B0", Offset = "0x2A455B0", VA = "0x182A465B0")]
		public void GGCGIGPFIFL(JLCDNMLCNEN ABEODFEGJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A46320", Offset = "0x2A45320", VA = "0x182A46320")]
		internal void FHDIKKJPLIH(ENNNNIELFIE PBHDPEJBGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A46BA0", Offset = "0x2A45BA0", VA = "0x182A46BA0")]
		private void OIBABOHHOLL(ENNNNIELFIE PBHDPEJBGCP, int DBMJEOKPFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A46790", Offset = "0x2A45790", VA = "0x182A46790")]
		private void MDLNEFCJMKP(EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ, DCHLEFALAMC JNJBGLDKDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A472F0", Offset = "0x2A462F0", VA = "0x182A472F0")]
		private PMOFFFGGJHG PKOKBHBEBMA(EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ)
		{
			return default(PMOFFFGGJHG);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A46AB0", Offset = "0x2A45AB0", VA = "0x182A46AB0")]
		private DCHLEFALAMC NEENEBAPNFF(PMOFFFGGJHG OHDDMIOPOFC, EGNDHFFDDFH KOPJKHIOCNP, COLPHKAFOHI ODHHBKJCCIJ)
		{
			return default(DCHLEFALAMC);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A474C0", Offset = "0x2A464C0", VA = "0x182A474C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A45800", Offset = "0x2A44800", VA = "0x182A45800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		private World CDCACCPAOCG
		{
			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0x2A451C0", Offset = "0x2A441C0", VA = "0x182A451C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		private KHMLGNFANIM LDGABFOLHPO
		{
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6708E0", VA = "0x1806718E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		private FLHBGDILJIB AEBPELGCMAE
		{
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C6F0", VA = "0x18066D6F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private NativeMultiHashMap<Entity, OJINANPDCIH> KIMKKCDAMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0x111AF70", Offset = "0x1119F70", VA = "0x18111AF70", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, OJINANPDCIH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		private JobHandle KGPNKIOBFAK
		{
			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x7C3370", Offset = "0x7C2370", VA = "0x1807C3370", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xFF1320", Offset = "0xFF0320", VA = "0x180FF1320", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		private World FHMGFHBGODL
		{
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0x2A46060", Offset = "0x2A45060", VA = "0x182A46060", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A45C60", Offset = "0x2A44C60", VA = "0x182A45C60", Slot = "13")]
		private void KAGLHGCNNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A45730", Offset = "0x2A44730", VA = "0x182A45730", Slot = "12")]
		private bool EJMMANHCLCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A460C0", Offset = "0x2A450C0", VA = "0x182A460C0", Slot = "14")]
		private void OILCIAOINAE(ComponentType MOBCJNJMMEJ, in KGFPMIPOKMG CKIPEJKPEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A45220", Offset = "0x2A44220", VA = "0x182A45220", Slot = "15")]
		private bool BDCPHGNPOML(CBLLNBPHCKJ GFIKNFBJKNP, out Entity AAICEAICAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A45620", Offset = "0x2A44620", VA = "0x182A45620", Slot = "17")]
		private bool DGCDCNDHLEP(out NativeArray<int> GIFGJKHKEEO, Allocator JEOILJEOOOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A454B0", Offset = "0x2A444B0", VA = "0x182A454B0", Slot = "18")]
		private bool CDGHKHDPJDF(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM, out OOPIHDDHHBC OHDDMIOPOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A45380", Offset = "0x2A44380", VA = "0x182A45380", Slot = "19")]
		private bool CDGHKHDPJDF(ComponentType MOBCJNJMMEJ, out KGFPMIPOKMG MKHGMKDNJMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A45810", Offset = "0x2A44810", VA = "0x182A45810", Slot = "20")]
		private KGFPMIPOKMG FOCBFEBAJIA(ComponentType MOBCJNJMMEJ)
		{
			return default(KGFPMIPOKMG);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A45C20", Offset = "0x2A44C20", VA = "0x182A45C20", Slot = "21")]
		private IDJKLEJHIMN JJLGELLAIAH()
		{
			return default(IDJKLEJHIMN);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A45C70", Offset = "0x2A44C70", VA = "0x182A45C70", Slot = "22")]
		private void KFPANNFHALE(JobHandle AADBABLKHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A45900", Offset = "0x2A44900", VA = "0x182A45900", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A45CB0", Offset = "0x2A44CB0", VA = "0x182A45CB0", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A456C0", Offset = "0x2A446C0", VA = "0x182A456C0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A45970", Offset = "0x2A44970", VA = "0x182A45970")]
		private void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A45E40", Offset = "0x2A44E40", VA = "0x182A45E40")]
		private bool KPPCAAEGNKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A45240", Offset = "0x2A44240", VA = "0x182A45240")]
		private int BKKNNDPJILH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A46200", Offset = "0x2A45200", VA = "0x182A46200")]
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
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677040", VA = "0x180678040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x37D65E0", Offset = "0x37D55E0", VA = "0x1837D65E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B20", Offset = "0xAB1B20", VA = "0x180AB2B20")]
		[DebuggerHidden]
		public DPHJPJNOBMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x37D63F0", Offset = "0x37D53F0", VA = "0x1837D63F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x37D65A0", Offset = "0x37D55A0", VA = "0x1837D65A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x37D64F0", Offset = "0x37D54F0", VA = "0x1837D64F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KBKPPGIKIHI> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x37D64F0", Offset = "0x37D54F0", VA = "0x1837D64F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E0F6C0", Offset = "0x2E0E6C0", VA = "0x182E0F6C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private DFDDJEKPLDJ KAAPDHONNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2E0F200", Offset = "0x2E0E200", VA = "0x182E0F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F9D0", Offset = "0x2E0E9D0", VA = "0x182E0F9D0", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FDC0", Offset = "0x2E0EDC0", VA = "0x182E0FDC0", Slot = "5")]
	public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F370", Offset = "0x2E0E370", VA = "0x182E0F370", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F420", Offset = "0x2E0E420", VA = "0x182E0F420")]
	private void EICDFLNDJBL(Entity GOLAIHPPLOC, in MJADMLMEADH HOCFNKFJGFI, in MJADMLMEADH LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F8A0", Offset = "0x2E0E8A0", VA = "0x182E0F8A0", Slot = "12")]
	public GINMLCILJIO FECCIBCHBLN()
	{
		return default(GINMLCILJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FA40", Offset = "0x2E0EA40", VA = "0x182E0FA40", Slot = "6")]
	public KBKPPGIKIHI IJFDDHEFOFO(GINMLCILJIO FHFFEBCPBGH, [Optional] Vector3? EIIEKPIPEEF, [Optional] Quaternion? DCNMMHNEEEM, [Optional] Vector3? AONBKNJBIIA)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FCF0", Offset = "0x2E0ECF0", VA = "0x182E0FCF0", Slot = "13")]
	public KBKPPGIKIHI JMLJEPFIPII(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ, [Optional] Vector3? EIIEKPIPEEF, [Optional] Quaternion? DCNMMHNEEEM, [Optional] Vector3? AONBKNJBIIA)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FF50", Offset = "0x2E0EF50", VA = "0x182E0FF50", Slot = "7")]
	public KBKPPGIKIHI NJFFFBEOAPH(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ)
	{
		return default(KBKPPGIKIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F940", Offset = "0x2E0E940", VA = "0x182E0F940", Slot = "14")]
	public void FPKPDGILOEA(GINMLCILJIO FHFFEBCPBGH, KBKPPGIKIHI IJKNBPEODEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2E10060", Offset = "0x2E0F060", VA = "0x182E10060", Slot = "8")]
	public void NJOOFBGDBOP(GINMLCILJIO FHFFEBCPBGH, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F710", Offset = "0x2E0E710", VA = "0x182E0F710", Slot = "15")]
	public void FBLDKFMNKLA(GINMLCILJIO FHFFEBCPBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FEC0", Offset = "0x2E0EEC0", VA = "0x182E0FEC0", Slot = "9")]
	public int NDMAOJDGOIJ(GINMLCILJIO FHFFEBCPBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FD30", Offset = "0x2E0ED30", VA = "0x182E0FD30", Slot = "10")]
	[IteratorStateMachine(typeof(DPHJPJNOBMC))]
	public IEnumerable<KBKPPGIKIHI> JONBNEOMLDM(GINMLCILJIO FHFFEBCPBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F180", Offset = "0x2E0E180", VA = "0x182E0F180")]
	private bool CEMJEJEEHLM(GINMLCILJIO FHFFEBCPBGH, out NativeArray<Entity> FALFIAAPAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F2C0", Offset = "0x2E0E2C0", VA = "0x182E0F2C0")]
	private NativeArray<Entity> DDIENHKLDME(GINMLCILJIO FHFFEBCPBGH)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A4C110", Offset = "0x2A4B110", VA = "0x182A4C110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public Entity MINMLEDGPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x657120", VA = "0x180658120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		private EntityManager JPGBDDHMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x2A4C050", Offset = "0x2A4B050", VA = "0x182A4C050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A4C0A0", Offset = "0x2A4B0A0", VA = "0x182A4C0A0", Slot = "4")]
		public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C120", Offset = "0x2A4B120", VA = "0x182A4C120", Slot = "5")]
		public void KIKMHMJJNMB(FFPEBHHNJFF FJKJAKKFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C120", Offset = "0x2A4B120", VA = "0x182A4C120")]
		private void POCLKGKAOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2A4BF20", Offset = "0x2A4AF20", VA = "0x182A4BF20", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C370", Offset = "0x2A4B370", VA = "0x182A4C370")]
		private void NAHHLBGMLLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C3D0", Offset = "0x2A4B3D0", VA = "0x182A4C3D0")]
		private AMFJBNENFOE NCHIKKFEHMO()
		{
			return default(AMFJBNENFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private static void GGNCAOJPKHM(int KOHJDBBJEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
		private static void EIHGDBDAHDH(Type NKICFHCCMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2A4C290", Offset = "0x2A4B290", VA = "0x182A4C290")]
		private static void LOJMGLBFGPE(Type NKICFHCCMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A075E0", Offset = "0x2A065E0", VA = "0x182A075E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x2A07720", Offset = "0x2A06720", VA = "0x182A07720", Slot = "4")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x2A07630", Offset = "0x2A06630", VA = "0x182A07630")]
	public void CHDHGKDAAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x2A077A0", Offset = "0x2A067A0", VA = "0x182A077A0")]
	public void IBCENBBDMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x771170", Offset = "0x770170", VA = "0x180771170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x30230A0", Offset = "0x30220A0", VA = "0x1830230A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Span<T> MPPABPEGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x3022E90", Offset = "0x3021E90", VA = "0x183022E90")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x929A20", Offset = "0x928A20", VA = "0x180929A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x30230E0", Offset = "0x30220E0", VA = "0x1830230E0")]
	public MFEBELNBKCH(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x3022FF0", Offset = "0x3021FF0", VA = "0x183022FF0")]
	public int FKENAIAHEAH(T IGJPNMBCJPK, int FOACNEHDHLI, int KOHJDBBJEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x3022F30", Offset = "0x3021F30", VA = "0x183022F30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C9D740", Offset = "0x1C9C740", VA = "0x181C9D740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public int OIABCDOLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x656040", VA = "0x180657040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x1C9DB40", Offset = "0x1C9CB40", VA = "0x181C9DB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D7D0", Offset = "0x1C9C7D0", VA = "0x181C9D7D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D800", Offset = "0x1C9C800", VA = "0x181C9D800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x1C9DA90", Offset = "0x1C9CA90", VA = "0x181C9DA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Span<T> MPPABPEGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C2D0", Offset = "0x1C9B2D0", VA = "0x181C9C2D0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x1C9DC70", Offset = "0x1C9CC70", VA = "0x181C9DC70")]
	public EEHAAMAOJOL(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D3B0", Offset = "0x1C9C3B0", VA = "0x181C9D3B0")]
	public T IGMIKAKFNBO(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x1C9DAD0", Offset = "0x1C9CAD0", VA = "0x181C9DAD0")]
	public void OMAKEOAANBD(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CA10", Offset = "0x1C9BA10", VA = "0x181C9CA10")]
	public void FFDHMAEECPB(Span<T> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CEE0", Offset = "0x1C9BEE0", VA = "0x181C9CEE0")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C890", Offset = "0x1C9B890", VA = "0x181C9C890")]
	private void EEGKOIJBHKM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D850", Offset = "0x1C9C850", VA = "0x181C9D850")]
	public void MBOIAEPEMME(Span<T> JJDMEICMPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CFF0", Offset = "0x1C9BFF0", VA = "0x181C9CFF0")]
	public void HGIANMDOCHF(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D190", Offset = "0x1C9C190", VA = "0x181C9D190")]
	public void IAAJAJFGFOI(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CC70", Offset = "0x1C9BC70", VA = "0x181C9CC70")]
	public void GEPHADMCPNH(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CCD0", Offset = "0x1C9BCD0", VA = "0x181C9CCD0")]
	public void GIBODEFMDLL(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C4E0", Offset = "0x1C9B4E0", VA = "0x181C9C4E0")]
	public void BGHIEJLNECC(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C420", Offset = "0x1C9B420", VA = "0x181C9C420")]
	public void BBOHILHOBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CB80", Offset = "0x1C9BB80", VA = "0x181C9CB80")]
	public int FKENAIAHEAH(T IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CC10", Offset = "0x1C9BC10", VA = "0x181C9CC10")]
	public bool FKLGFCOHCLF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C840", Offset = "0x1C9B840", VA = "0x181C9C840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x1C9DC00", Offset = "0x1C9CC00", VA = "0x181C9DC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x1C9DB90", Offset = "0x1C9CB90", VA = "0x181C9DB90")]
	public static Span<T> PAAEKNCKHBI(global::EEHAAMAOJOL<T> LPDILHBGHIJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D050", Offset = "0x1C9C050", VA = "0x181C9D050")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HNMIBHLBDII(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void DCNMPGGEHFJ(int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C6E0", Offset = "0x1C9B6E0", VA = "0x181C9C6E0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void DCNMPGGEHFJ(int GKPOMAIMOAK, int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D600", Offset = "0x1C9C600", VA = "0x181C9D600")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JFHKONJONGN(int IGJPNMBCJPK, int GKPOMAIMOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x1C9D400", Offset = "0x1C9C400", VA = "0x181C9D400")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void IKHHFLADOBF(int JONKDKCHFBO, int CBNJCJLIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C5A0", Offset = "0x1C9B5A0", VA = "0x181C9C5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A120E0", Offset = "0x2A110E0", VA = "0x182A120E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NativeList<Entity> FKGLBEIKFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xCE8B70", Offset = "0xCE7B70", VA = "0x180CE8B70")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public TransformAccessArray MIBENKEEEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x657AC0", VA = "0x180658AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2A121B0", Offset = "0x2A111B0", VA = "0x182A121B0")]
	public OCGCGAIFBCP(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x2A11F00", Offset = "0x2A10F00", VA = "0x182A11F00")]
	public Entity FHABAEEIJEG(int AIPHGHFENPJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2A11E70", Offset = "0x2A10E70", VA = "0x182A11E70")]
	public Transform AGDAIJOCIIH(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2A12160", Offset = "0x2A11160", VA = "0x182A12160")]
	public void OCPJNJBCKID(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2A120F0", Offset = "0x2A110F0", VA = "0x182A120F0")]
	public void KAJJOIIPMBP(int ALHAMICPFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x2A11F90", Offset = "0x2A10F90", VA = "0x182A11F90")]
	public int HEFJCCLOLGO(Transform BCHADNCHEKP, Entity GEEFHDFLBEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2A12060", Offset = "0x2A11060", VA = "0x182A12060")]
	public int HGIANMDOCHF(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x2A11E80", Offset = "0x2A10E80", VA = "0x182A11E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2A11F50", Offset = "0x2A10F50", VA = "0x182A11F50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A07C30", Offset = "0x2A06C30", VA = "0x182A07C30", Slot = "4")]
	public bool Equals(LinkedEntityGroup KNMKEOOODCL, LinkedEntityGroup EMKKILCIAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2A07C50", Offset = "0x2A06C50", VA = "0x182A07C50", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup CCPIHKCBGHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public KGDDGEFLMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class IGLJAEKGNEC
{
	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void LNDIKNLGIEH(in Vector3 EIIEKPIPEEF, in Quaternion DCNMMHNEEEM, in Vector3 AONBKNJBIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void NHIEEINNCGK(in Vector3 FKJNMOFLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void DNCOFNHLFPC(in Quaternion DCNMMHNEEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BMHDOAFDPBP(in Vector3 FBANICEIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void MDDHPCEHPAL(in Vector3 FBANICEIJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void JCHLNHFKDOP(in float PJFFAKJCJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2A04560", Offset = "0x2A03560", VA = "0x182A04560")]
	[Conditional("DEBUG_BUILD")]
	public static void AGDNCCDMFDB(in float3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in float IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2A04640", Offset = "0x2A03640", VA = "0x182A04640")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in Vector3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x2A04610", Offset = "0x2A03610", VA = "0x182A04610")]
	[Conditional("DEBUG_BUILD")]
	public static void HMLGFDEPALE(in Quaternion IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2A046D0", Offset = "0x2A036D0", VA = "0x182A046D0")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in float IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x2A04690", Offset = "0x2A03690", VA = "0x182A04690")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in Vector3 IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x2A046E0", Offset = "0x2A036E0", VA = "0x182A046E0")]
	[Conditional("DEBUG_BUILD")]
	public static void MLIDCAALEIK(in Quaternion IGJPNMBCJPK, string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E183D0", Offset = "0x2E173D0", VA = "0x182E183D0")]
	public FDCGJNDCDCD(Entity GEEFHDFLBEH, Entity POICJGPACMK, Entity JDMCICBCFIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2E18370", Offset = "0x2E17370", VA = "0x182E18370")]
	public static FDCGJNDCDCD PAAEKNCKHBI((Entity entity, Entity oldParent, Entity newParent) HBFAFBABGFI)
	{
		return default(FDCGJNDCDCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2E183B0", Offset = "0x2E173B0", VA = "0x182E183B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xF68720", Offset = "0xF67720", VA = "0x180F68720")]
	public MIFKFPHADFM(Entity GEEFHDFLBEH, Entity ADECAOLBLPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F330", Offset = "0x2A0E330", VA = "0x182A0F330")]
	public static MIFKFPHADFM PAAEKNCKHBI((Entity entity, Entity parent) HBFAFBABGFI)
	{
		return default(MIFKFPHADFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F360", Offset = "0x2A0E360", VA = "0x182A0F360")]
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
		[Cpp2IlInjected.Address(RVA = "0x283F2D0", Offset = "0x283E2D0", VA = "0x18283F2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x283F310", Offset = "0x283E310", VA = "0x18283F310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x283F210", Offset = "0x283E210", VA = "0x18283F210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x283F3B0", Offset = "0x283E3B0", VA = "0x18283F3B0")]
	public FIGGIAMEMEL(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x283F2E0", Offset = "0x283E2E0", VA = "0x18283F2E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A00FC0", Offset = "0x29FFFC0", VA = "0x182A00FC0", Slot = "5")]
	public void HGPEDDFLHFM(FFPEBHHNJFF FJKJAKKFINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x2A00F20", Offset = "0x29FFF20", VA = "0x182A00F20")]
	public bool IGDPCCPOHMI(in float3 BEAAOFALHFJ, in float3 LJGBEFMGJKC, float JEIPODGPOFH, Allocator JEOILJEOOOI, out NativeArray<Entity> FBMJMNCDHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public HENNBGFOJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x2A00F20", Offset = "0x29FFF20", VA = "0x182A00F20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public GMIMCOGLPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A04BA0", Offset = "0x2A03BA0", VA = "0x182A04BA0")]
	public IJOIPEJPICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public CLFNFKBCGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public LCBHOHHGHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CF70", Offset = "0x2A0BF70", VA = "0x182A0CF70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public GMEILMIGPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public INIBCJCKAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x2A04C00", Offset = "0x2A03C00", VA = "0x182A04C00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E03F20", Offset = "0x2E02F20", VA = "0x182E03F20")]
	public CECHAALAEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x2E03F10", Offset = "0x2E02F10", VA = "0x182E03F10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public CKKALKMOKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x2E04F50", Offset = "0x2E03F50", VA = "0x182E04F50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public FKMLGBNBFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x29FD060", Offset = "0x29FC060", VA = "0x1829FD060", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E03B10", Offset = "0x2E02B10", VA = "0x182E03B10")]
	public BKGKPEPJGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x2E03B00", Offset = "0x2E02B00", VA = "0x182E03B00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A072B0", Offset = "0x2A062B0", VA = "0x182A072B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x2A07300", Offset = "0x2A06300", VA = "0x182A07300")]
	public JJDKNFOLILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FEDA0", Offset = "0x29FDDA0", VA = "0x1829FEDA0")]
	public GEBOIHKOPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public AMECLKKDJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public GACJCKKDMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public ECEGKIHDGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public NENDFNPOJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public MLBONNHEEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A10B20", Offset = "0x2A0FB20", VA = "0x182A10B20")]
	public NGBLKHHEAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public EOBDBGNACIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A139C0", Offset = "0x2A129C0", VA = "0x182A139C0")]
	public ONKALMKAIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A0A6D0", Offset = "0x2A096D0", VA = "0x182A0A6D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A720", Offset = "0x2A09720", VA = "0x182A0A720")]
	public KIHDPJGMJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A13490", Offset = "0x2A12490", VA = "0x182A13490")]
	public OIMLEGBPLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public ICCDPIAHMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A006B0", Offset = "0x29FF6B0", VA = "0x182A006B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x2A00700", Offset = "0x29FF700", VA = "0x182A00700")]
	public HAPKDLHLLNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0CF60", Offset = "0x2A0BF60", VA = "0x182A0CF60")]
	public LBMJPGBICJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0AF60", Offset = "0x2A09F60", VA = "0x182A0AF60")]
	public KPIOIDPOAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public LIAPPGHFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public GALCAOICMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A3DC20", Offset = "0x2A3CC20", VA = "0x182A3DC20")]
	public PEAAFEMGPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x2A3DAC0", Offset = "0x2A3CAC0", VA = "0x182A3DAC0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public PPDBMLODJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public MEJEFNLMBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public KADFNFOEOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public ANMEJHAGKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE580", Offset = "0x2DFD580", VA = "0x182DFE580", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public PPMEIMCCAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x2A3EBA0", Offset = "0x2A3DBA0", VA = "0x182A3EBA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public DBCHEHOIOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E11F00", Offset = "0x2E10F00", VA = "0x182E11F00")]
	public EECKJDEKOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DFE590", Offset = "0x2DFD590", VA = "0x182DFE590")]
	public ANPNHPCAMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
	public OOKIAPDOEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E101F0", Offset = "0x2E0F1F0", VA = "0x182E101F0")]
	public DPONPGEEDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public GFIPLMLCHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public IBPAJMPFBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public POGFIDCHONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A07360", Offset = "0x2A06360", VA = "0x182A07360")]
	public JLDJFEGGDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE1D0", Offset = "0x29FD1D0", VA = "0x1829FE1D0")]
	public FOLBJCBGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public PJIMJKALPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public ANGAHLPODJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FDBE0", Offset = "0x29FCBE0", VA = "0x1829FDBE0")]
	public FLPLKEOOONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public KJAMHHLDILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public FBNOFIPNOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public APNEBBLNJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FE870", Offset = "0x29FD870", VA = "0x1829FE870")]
	public PENDCJNCAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E06410", Offset = "0x2E05410", VA = "0x182E06410")]
	public COIHLHAIHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2E06400", Offset = "0x2E05400", VA = "0x182E06400", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A024A0", Offset = "0x2A014A0", VA = "0x182A024A0")]
	public ILPLPCIBBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x2A02460", Offset = "0x2A01460", VA = "0x182A02460", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FC4F0", Offset = "0x29FB4F0", VA = "0x1829FC4F0")]
	public GEECICKCDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x29FC4B0", Offset = "0x29FB4B0", VA = "0x1829FC4B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E03DC0", Offset = "0x2E02DC0", VA = "0x182E03DC0")]
	public BNNCLJEALME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A06010", Offset = "0x2A05010", VA = "0x182A06010")]
	public JAMJMHEDCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A13850", Offset = "0x2A12850", VA = "0x182A13850")]
	public OLNOAPMHJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2A0EC60", Offset = "0x2A0DC60", VA = "0x182A0EC60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A11900", Offset = "0x2A10900", VA = "0x182A11900")]
	public NJEIHAGLBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2A118F0", Offset = "0x2A108F0", VA = "0x182A118F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0EE50", Offset = "0x2A0DE50", VA = "0x182A0EE50")]
	public MDAJDPGBJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF627A0", Offset = "0xF617A0", VA = "0x180F627A0")]
	public FJKAGFHOPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29FFBF0", Offset = "0x29FEBF0", VA = "0x1829FFBF0")]
	public AELKEOLNOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC3C0", Offset = "0x2DFB3C0", VA = "0x182DFC3C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0D5E0", Offset = "0x2A0C5E0", VA = "0x182A0D5E0")]
	public OJKNBAKPKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D5A0", Offset = "0x2A0C5A0", VA = "0x182A0D5A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A3CC60", Offset = "0x2A3BC60", VA = "0x182A3CC60")]
	public PAGPIOFHJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B03")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CC50", Offset = "0x2A3BC50", VA = "0x182A3CC50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A015B0", Offset = "0x2A005B0", VA = "0x182A015B0")]
	public HHFIOBDONHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x2A015A0", Offset = "0x2A005A0", VA = "0x182A015A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E03AA0", Offset = "0x2E02AA0", VA = "0x182E03AA0")]
	public BJBDOLOLDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A0E0A0", Offset = "0x2A0D0A0", VA = "0x182A0E0A0")]
	public LOCFIPGKIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E090", Offset = "0x2A0D090", VA = "0x182A0E090", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[FLIEEAHPEDE(typeof(AuthoredLocalPoseData))]
public sealed class KAEFPHLHLJO : BEDDJBOFBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x2A07480", Offset = "0x2A06480", VA = "0x182A07480", Slot = "8")]
	protected override bool IPBMAHBFOKM(ReadOnlySpan<AuthoredLocalPoseData> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x2A073C0", Offset = "0x2A063C0", VA = "0x182A073C0", Slot = "9")]
	protected override bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<AuthoredLocalPoseData> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x2A07500", Offset = "0x2A06500", VA = "0x182A07500")]
	public KAEFPHLHLJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[FLIEEAHPEDE(typeof(LocalPoseData))]
public sealed class KHPALNDLCHF : PPFAMFIEDDM
{
	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A640", Offset = "0x2A09640", VA = "0x182A0A640", Slot = "8")]
	protected override bool IPBMAHBFOKM(ReadOnlySpan<LocalPoseData> JJDMEICMPFG, KLBODNIPMJE NGGOKHONBCG, out ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A580", Offset = "0x2A09580", VA = "0x182A0A580", Slot = "9")]
	protected override bool FPMCHDMPDKB(int JKGBPKEJAFA, Span<LocalPoseData> JJDMEICMPFG, in ReadOnlySpan<byte> OFOCCMMPKKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A6C0", Offset = "0x2A096C0", VA = "0x182A0A6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B40", Offset = "0x657B40", VA = "0x180658B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x2A59350", Offset = "0x2A58350", VA = "0x182A59350", Slot = "6")]
		public sealed override void ADPJAIEJIPK(BDNCAKHHJCI GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x2A59F30", Offset = "0x2A58F30", VA = "0x182A59F30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x2DFA320", Offset = "0x2DF9320", VA = "0x182DFA320")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x2DFA430", Offset = "0x2DF9430", VA = "0x182DFA430")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
