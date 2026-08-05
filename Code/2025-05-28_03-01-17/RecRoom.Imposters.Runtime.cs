using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct CKKHOGAHKJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly IOBMIKPKHHO PAKLGDPBNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string KPDIBFFPHNB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
		public CKKHOGAHKJC(IOBMIKPKHHO AKONDNAAMCK, string DCBGPPPDNMF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct OLMPJDIOJIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CKKHOGAHKJC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDEF0", Offset = "0x7DDCCF0", VA = "0x187DDDEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE2B0", Offset = "0x7DDD0B0", VA = "0x187DDE2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider GCOJJPPOIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NBMBIHHMOFK<CKKHOGAHKJC, GameObject> BIDPFFPMPFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FOEOKIIEPPN JHEKJCADEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NBMBIHHMOFK<CKKHOGAHKJC, GameObject> OBNEBNNJIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7440", Offset = "0x7DD6240", VA = "0x187DD7440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int APMLBNGJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7080", Offset = "0x7DD5E80", VA = "0x187DD7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6FA0", Offset = "0x7DD5DA0", VA = "0x187DD6FA0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DD73D0", Offset = "0x7DD61D0", VA = "0x187DD73D0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DD72B0", Offset = "0x7DD60B0", VA = "0x187DD72B0")]
	[AsyncStateMachine(typeof(OLMPJDIOJIA))]
	private Task<GameObject> NIKOIFHOMKI(CKKHOGAHKJC KAPKBDDDCGA, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DD70D0", Offset = "0x7DD5ED0", VA = "0x187DD70D0")]
	public Task<GameObject> LoadItemAsync(IOBMIKPKHHO AKONDNAAMCK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DD75A0", Offset = "0x7DD63A0", VA = "0x187DD75A0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EJOPBGGEAEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IOBMIKPKHHO ECEDPEDDPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture LEDJLJNOILM;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
		public EJOPBGGEAEB(IOBMIKPKHHO MEEIAOHKKPD, Texture FBFLLKLGAIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum KEINAGKFNDN
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class GDHCPCAJEEC : AHEBAANNNJJ<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IMAIIPFOHCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GDHCPCAJEEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7DDC020", Offset = "0x7DDAE20", VA = "0x187DDC020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7DDC820", Offset = "0x7DDB620", VA = "0x187DDC820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IOBMIKPKHHO MEEIAOHKKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture NBNEPGNAKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig CNHBHBBECPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GHKBKDKNIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D BCDOAGJLNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject NJKEFKMJPKD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override HMBEFKLHMDK<Texture2D> APMAEOAMGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7DDB400", Offset = "0x7DDA200", VA = "0x187DDB400", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> AMOBKEDPMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB600", Offset = "0x7DDA400", VA = "0x187DDB600")]
		public GDHCPCAJEEC(IOBMIKPKHHO MEEIAOHKKPD, RenderTexture NBNEPGNAKNI, ImposterRenderConfig CNHBHBBECPK, CancellationToken GHKBKDKNIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB4E0", Offset = "0x7DDA2E0", VA = "0x187DDB4E0")]
		[AsyncStateMachine(typeof(IMAIIPFOHCD))]
		private Task<Texture2D> LMPEILIOJCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB5D0", Offset = "0x7DDA3D0", VA = "0x187DDB5D0", Slot = "10")]
		protected override void LPJFLBHHFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB460", Offset = "0x7DDA260", VA = "0x187DDB460")]
		private static void EMCNAEOJEAF(GameObject NJKEFKMJPKD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HDNODFAGHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB7C0", Offset = "0x7DDA5C0", VA = "0x187DDB7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private KEINAGKFNDN size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[KJBPBAHEFKJ("size", KEINAGKFNDN.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int FHMDCDDFKKD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture KIDOBAEEOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DDOIJMFMBLE<GameObject> CCAFPBBGNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private OJJOHCMLHDB MFJHGHLENJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource FMNLCBJFAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private EHIFMMNJMNN<Texture2D> ICICEPOJJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private IOBMIKPKHHO BMLBHAGANKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture OMNFECNHJHG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int ALBILFDMFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD800", Offset = "0x7DDC600", VA = "0x187DDD800")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD850", Offset = "0x7DDC650", VA = "0x187DDD850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PJALCBFANKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DDCDE0", Offset = "0x7DDBBE0", VA = "0x187DDCDE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBF0", Offset = "0xA0D9F0", VA = "0x180A0EBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IOBMIKPKHHO ECEDPEDDPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DDCFC0", Offset = "0x7DDBDC0", VA = "0x187DDCFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool MHMAIOHGEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x21EA720", Offset = "0x21E9520", VA = "0x1821EA720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int HMHONHIFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD420", Offset = "0x7DDC220", VA = "0x187DDD420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCDC0", Offset = "0x7DDBBC0", VA = "0x187DDCDC0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD2B0", Offset = "0x7DDC0B0", VA = "0x187DDD2B0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD3A0", Offset = "0x7DDC1A0", VA = "0x187DDD3A0")]
	private void PIOOCAMEAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD720", Offset = "0x7DDC520", VA = "0x187DDD720")]
	public void Set(IOBMIKPKHHO KKGMLPLDIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD6D0", Offset = "0x7DDC4D0", VA = "0x187DDD6D0")]
	public void Set(Texture FBFLLKLGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD6E0", Offset = "0x7DDC4E0", VA = "0x187DDD6E0")]
	public void Set(EJOPBGGEAEB OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCDD0", Offset = "0x7DDBBD0", VA = "0x187DDCDD0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD4D0", Offset = "0x7DDC2D0", VA = "0x187DDD4D0")]
	public void SetInternal(IOBMIKPKHHO KKGMLPLDIHM, [Optional] Texture MJEFMFJCBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD4C0", Offset = "0x7DDC2C0", VA = "0x187DDD4C0")]
	public void SetCustomSize(int IEIKICMALKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11510", VA = "0x180A12710")]
	public void SetAntiAliasing(int NBJBMLHNEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD120", Offset = "0x7DDBF20", VA = "0x187DDD120")]
	[AsyncStateMachine(typeof(HDNODFAGHFH))]
	private void HFJEMFGAMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD1D0", Offset = "0x7DDBFD0", VA = "0x187DDD1D0")]
	private void JHMPCKIEDFI(Texture FBFLLKLGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD780", Offset = "0x7DDC580", VA = "0x187DDD780")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, FAELEEOPIMD
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float CGDLLNEEKEL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void PrepareImposter(LCGJGAHNIDK CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCD80", Offset = "0x7DDBB80", VA = "0x187DDCD80")]
	public void SetReferencePoint(Vector3 IMPLDPKOJAO, Quaternion MEPKHADFMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCB90", Offset = "0x7DDB990", VA = "0x187DDCB90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCD60", Offset = "0x7DDBB60", VA = "0x187DDCD60")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB5A0", Offset = "0x1EBA3A0", VA = "0x181EBB5A0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LHPEOBFDFAG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static LHPEOBFDFAG ENALEMOLPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float CILGJFIIKDK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A26660", Offset = "0x2A25460", VA = "0x182A26660")]
	public LHPEOBFDFAG(float NCEOIGDILPB)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE5E0", Offset = "0x7DDD3E0", VA = "0x187DDE5E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int ACAEPNDMMCG = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int NHOHPAHENBE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> ALGNHJPPLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool EMDDEHBAKCC;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDA70", Offset = "0x7DDC870", VA = "0x187DDDA70")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD970", Offset = "0x7DDC770", VA = "0x187DDD970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DDDCB0", Offset = "0x7DDCAB0", VA = "0x187DDDCB0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IOBMIKPKHHO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string NIELEGFCAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LHPEOBFDFAG LHPEOBFDFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NIDAAFFLFNO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> BMENBNOKFMG(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDNHLJEGIDF(IOBMIKPKHHO HBLONCAMFLG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EGNOODNDDPH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEMDOJPCNCJ();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FAJDPGBIHPJ(uint? HHGPCIAHELC, [Out] EHIFMMNJMNN<Texture2D> JLMMBNCOAGE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MKLNGLHBHFB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDE00", Offset = "0x7DDCC00", VA = "0x187DDDE00")]
	public static bool MHOPBFFNJJN(IOBMIKPKHHO GDIJEDCKAPN, IOBMIKPKHHO AODJLBPOOLD)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, FAELEEOPIMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6410", Offset = "0x7DD5210", VA = "0x187DD6410", Slot = "4")]
		public void PrepareImposter(LCGJGAHNIDK CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FAELEEOPIMD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LCGJGAHNIDK CNCKIIIBBGO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IEINHAKHNCP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> COHMCMNMBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HBJAFLLPCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FOEOKIIEPPN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMLFKPLIFHI(params Type[] NFNFGIJKBCF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject EOMPPPMPDKF(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, bool ANHCOFCHCCK = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T EOMPPPMPDKF<T>(T OHJAGGPLIGB, Transform BOGJJGPKPIJ, bool ANHCOFCHCCK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T EOMPPPMPDKF<T>(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, bool ANHCOFCHCCK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject EOMPPPMPDKF(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ECDHBDFAKEP : IDisposable, FOEOKIIEPPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> MDFPKECJBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> DCDMJDHJELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform ODLNOBPFOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> OLMOCAHDPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HNFNCFOJNDK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8110", Offset = "0x7DD6F10", VA = "0x187DD8110")]
	[ENKLKENGHAE.AANPNKKBMFF]
	public static void JKEPFALEAEN(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DD86B0", Offset = "0x7DD74B0", VA = "0x187DD86B0")]
	[UnityEngine.Scripting.Preserve]
	public ECDHBDFAKEP([LCNEJNNIOGA(null)] IEINHAKHNCP DECDPLCIABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7860", Offset = "0x7DD6660", VA = "0x187DD7860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7810", Offset = "0x7DD6610", VA = "0x187DD7810", Slot = "5")]
	public void DMLFKPLIFHI(params Type[] NFNFGIJKBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7940", Offset = "0x7DD6740", VA = "0x187DD7940", Slot = "6")]
	public GameObject EOMPPPMPDKF(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, bool ANHCOFCHCCK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3774BA0", Offset = "0x37739A0", VA = "0x183774BA0", Slot = "7")]
	public T EOMPPPMPDKF<T>(T OHJAGGPLIGB, Transform BOGJJGPKPIJ, bool ANHCOFCHCCK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3775210", Offset = "0x3774010", VA = "0x183775210", Slot = "8")]
	public T EOMPPPMPDKF<T>(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, bool ANHCOFCHCCK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DD79D0", Offset = "0x7DD67D0", VA = "0x187DD79D0", Slot = "9")]
	public GameObject EOMPPPMPDKF(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37751B0", Offset = "0x3773FB0", VA = "0x1837751B0", Slot = "10")]
	public T EOMPPPMPDKF<T>(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3774C30", Offset = "0x3773A30", VA = "0x183774C30")]
	private T EOMPPPMPDKF<T>(GameObject OHJAGGPLIGB, Transform BOGJJGPKPIJ, LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK, [Out] GameObject MBDPGJJJADJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3775260", Offset = "0x3774060", VA = "0x183775260")]
	private T PBEOOMOFOOH<T>(GameObject MMMAEDGEACA, LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD75E0", Offset = "0x7DD63E0", VA = "0x187DD75E0")]
	private void BIBDAPGPBLI(LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8480", Offset = "0x7DD7280", VA = "0x187DD8480")]
	private void OBNFBKBAIAB(LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7BD0", Offset = "0x7DD69D0", VA = "0x187DD7BD0")]
	private void FOIMNLPCGOG(Component OFNOAHMACNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8210", Offset = "0x7DD7010", VA = "0x187DD8210")]
	private void OBNFBKBAIAB(Component OFNOAHMACNB, LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK, bool ENLCLNKIFDG, [Optional] Type JAIGKPCCIJO, [Optional] Type DBKLJNMBKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7CE0", Offset = "0x7DD6AE0", VA = "0x187DD7CE0")]
	private void GIPPLGCNEJC(Component OFNOAHMACNB, LCGJGAHNIDK CNCKIIIBBGO, bool ANHCOFCHCCK, bool ENLCLNKIFDG, [Optional] Type JAIGKPCCIJO, [Optional] Type DBKLJNMBKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7A60", Offset = "0x7DD6860", VA = "0x187DD7A60")]
	private void FGPOFNKHKHH(GameObject MMMAEDGEACA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LCGJGAHNIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> LOFGGPKLGEH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x39E68B0", Offset = "0x39E56B0", VA = "0x1839E68B0")]
	public LCGJGAHNIDK KDAEEABIJCL<T>(T ALMAMKPPHMK)
	{
		return default(LCGJGAHNIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x39E6FE0", Offset = "0x39E5DE0", VA = "0x1839E6FE0")]
	public T MBFFDPKOBBN<T>(T LDGCNLHOBMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x39E60E0", Offset = "0x39E4EE0", VA = "0x1839E60E0")]
	public bool EDIACBOJIPL<T>([Out] T ALMAMKPPHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDD40", Offset = "0x7DDCB40", VA = "0x187DDDD40")]
	public void CCLJDABAPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NHAFEKCGIBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool OAPDBMBCAHM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2A25C90", Offset = "0x2A24A90", VA = "0x182A25C90")]
	public NHAFEKCGIBK(bool BAEOBLLKNHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HHEEKMEPGOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool GDPCBNHJFJE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC010", Offset = "0x7DDAE10", VA = "0x187DDC010")]
	public HHEEKMEPGOK(bool DCODPEKHMFE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, FAELEEOPIMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE320", Offset = "0x7DDD120", VA = "0x187DDE320", Slot = "4")]
		public void PrepareImposter(LCGJGAHNIDK CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds AJJGDAHHDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7DDCA00", Offset = "0x7DDB800", VA = "0x187DDCA00")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC8D0", Offset = "0x7DDB6D0", VA = "0x187DDC8D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC890", Offset = "0x7DDB690", VA = "0x187DDC890")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC910", Offset = "0x7DDB710", VA = "0x187DDC910")]
		private void PKDNMFDIFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7DDDDE0", Offset = "0x7DDCBE0", VA = "0x187DDDDE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7DDDDD0", Offset = "0x7DDCBD0", VA = "0x187DDDDD0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[KJBPBAHEFKJ("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[KJBPBAHEFKJ("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD8D0", Offset = "0x7DDC6D0", VA = "0x187DDD8D0")]
		public void AECBJGKHBGL(Vector3 DECBDDCBGEP, Quaternion NFPGEKEEJAD, float ALPANGEOPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD900", Offset = "0x7DDC700", VA = "0x187DDD900")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FLIDENGGJJC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 LNKKIIBNJOL;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> HOOOJHLOBAA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> EDDGJKPKNJH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera EPGIAAHODEJ;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> KOFLLIDBGKK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> JBJNCDJPIAK;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode EPKNIGDFMHC;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color FNMADOBHAPB;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color FOJPNLPGMEI;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color FNDLENJMIBK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap IBGOJMELEJC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool KCDFPBPJLNK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> CMDEBKDCPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7DD99E0", Offset = "0x7DD87E0", VA = "0x187DD99E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> NCFCCOFJHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA8E0", Offset = "0x7DD96E0", VA = "0x187DDA8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GPPJJCOMJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9000", Offset = "0x7DD7E00", VA = "0x187DD9000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9250", Offset = "0x7DD8050", VA = "0x187DD9250")]
	public static void FCPLJIOKPDD(Vector3 CJKLJGHDCBN, Quaternion MNJAPAFMCGB, ImposterRenderConfig PBDDFCGCEOA, bool OEFNMKDJNDK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7DD96C0", Offset = "0x7DD84C0", VA = "0x187DD96C0")]
	private static void GBKLNMOFJDI(Vector3 CJKLJGHDCBN, Quaternion MNJAPAFMCGB, URPLight HGFHEGJDCBA, ImposterRenderConfig.LightConfig FPALGJAILAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA800", Offset = "0x7DD9600", VA = "0x187DDA800")]
	public static void MDAMCOMBHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA3D0", Offset = "0x7DD91D0", VA = "0x187DDA3D0")]
	private static void JJPAFJBPMHK(int LOFCPEDHFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DD94F0", Offset = "0x7DD82F0", VA = "0x187DD94F0")]
	public static void FIONCDBNGHJ(ImposterRenderConfig PBDDFCGCEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8F10", Offset = "0x7DD7D10", VA = "0x187DD8F10")]
	public static void CNDLHOFAHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9A30", Offset = "0x7DD8830", VA = "0x187DD9A30")]
	public static void HENHGNKANLN(GameObject FFKLFBCLKDO, RenderTexture NBNEPGNAKNI, ImposterRenderConfig PBDDFCGCEOA, LHPEOBFDFAG GLDPDHPOCLK, [Optional] Vector3? MKCHDJLKBAF, [Optional] Vector3? ALCAKACPHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9D70", Offset = "0x7DD8B70", VA = "0x187DD9D70")]
	private static void JFLFFOAJEEO(GameObject FFKLFBCLKDO, RenderTexture NBNEPGNAKNI, ImposterRenderConfig PBDDFCGCEOA, LHPEOBFDFAG GLDPDHPOCLK, Vector3 MKCHDJLKBAF, Vector3 ALCAKACPHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8C30", Offset = "0x7DD7A30", VA = "0x187DD8C30")]
	private static void BNHNJMGKLND(GameObject FFKLFBCLKDO, Vector3 FACKCAEJGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAE60", Offset = "0x7DD9C60", VA = "0x187DDAE60")]
	public static void PGCDMMHIKPP(Bounds PLPLCEMJLHP, ImposterRenderConfig PBDDFCGCEOA, [Out] Vector3 FDIDOBKLENJ, [Out] Quaternion KBNDMDIADBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA930", Offset = "0x7DD9730", VA = "0x187DDA930")]
	private static void PDIMNDNFJFD(GameObject OHJAGGPLIGB, ImposterRenderConfig PBDDFCGCEOA, LHPEOBFDFAG GLDPDHPOCLK, [Out] Vector3 FDIDOBKLENJ, [Out] Quaternion KBNDMDIADBB, [Out] float LHAIKGEJJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8B60", Offset = "0x7DD7960", VA = "0x187DD8B60")]
	public static RenderTexture BLPIFBHIKBM(int LFMBACGFNNA, int OCGMIFIKGJN, RenderTextureFormat HONGJHADKJH = RenderTextureFormat.ARGB32, string IGDFGICFICH = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct FCGKEJPJCBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public OJGPCEPDLBJ JMKHJBFPMNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject IEEGNIOPIHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture PJALCBFANKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig HKJELKJFIJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public LHPEOBFDFAG LHPEOBFDFAG;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7DD8AF0", Offset = "0x7DD78F0", VA = "0x187DD8AF0")]
			public FCGKEJPJCBL(OJGPCEPDLBJ MEHDPIFMILF, GameObject LGJINFGBCGO, RenderTexture NBNEPGNAKNI, ImposterRenderConfig CNHBHBBECPK, LHPEOBFDFAG GLDPDHPOCLK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static NBMBIHHMOFK<FCGKEJPJCBL, RenderTexture> AGOOKFIPDMB;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<FCGKEJPJCBL> CBLMHOJNCIJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int PJOJNPIMFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7DD6560", Offset = "0x7DD5360", VA = "0x187DD6560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6B40", Offset = "0x7DD5940", VA = "0x187DD6B40")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FFKLFBCLKDO, RenderTexture NBNEPGNAKNI, ImposterRenderConfig PBDDFCGCEOA, LHPEOBFDFAG GLDPDHPOCLK, CancellationToken GHKBKDKNIOM, bool GFADLCFIHJM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7DD65F0", Offset = "0x7DD53F0", VA = "0x187DD65F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6AA0", Offset = "0x7DD58A0", VA = "0x187DD6AA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6800", Offset = "0x7DD5600", VA = "0x187DD6800")]
		private static Task<RenderTexture> INMMDGAGLDI(FCGKEJPJCBL CFEMBCGEMHL, CancellationToken GHKBKDKNIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6F60", Offset = "0x7DD5D60", VA = "0x187DD6F60")]
		public DeferredImposterRenderer()
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
