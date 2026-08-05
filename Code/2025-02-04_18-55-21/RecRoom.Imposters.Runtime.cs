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
	private readonly struct EBAGIEGOONE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly CNLPFPHBEFK OBCJPJHAEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string CKOJFIPAENM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
		public EBAGIEGOONE(CNLPFPHBEFK HAFBCKEHEAH, string GCKAADIMNCI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct BMOPNKMJAKE : IAsyncStateMachine
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
		public EBAGIEGOONE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72A9E40", Offset = "0x72A8C40", VA = "0x1872A9E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72AA200", Offset = "0x72A9000", VA = "0x1872AA200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FOEHEJOEPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FMGEGMGJJKP<EBAGIEGOONE, GameObject> HFODIMLDHCC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FNHKFEBNPNE FAOFJBAODHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FMGEGMGJJKP<EBAGIEGOONE, GameObject> KEGKOKEGIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72AB6B0", Offset = "0x72AA4B0", VA = "0x1872AB6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HNKIANOEDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72AB4A0", Offset = "0x72AA2A0", VA = "0x1872AB4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72AB2A0", Offset = "0x72AA0A0", VA = "0x1872AB2A0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72AB810", Offset = "0x72AA610", VA = "0x1872AB810", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72AB380", Offset = "0x72AA180", VA = "0x1872AB380")]
	[AsyncStateMachine(typeof(BMOPNKMJAKE))]
	private Task<GameObject> HJEDOGPHCLH(EBAGIEGOONE PNJPGCAFMII, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72AB4F0", Offset = "0x72AA2F0", VA = "0x1872AB4F0")]
	public Task<GameObject> LoadItemAsync(CNLPFPHBEFK HAFBCKEHEAH, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72AB880", Offset = "0x72AA680", VA = "0x1872AB880")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OBKLGBOKIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CNLPFPHBEFK KPNKBGHLFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture FDCLHEHIJLM;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
		public OBKLGBOKIKF(CNLPFPHBEFK MDHPOFAGDME, Texture CEMDCHNHEAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum OAFLGEEADIB
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
	private class DHILEOPAEHA : GLJKIHHGNCC<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct KLIHCCAAMEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public DHILEOPAEHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72B0530", Offset = "0x72AF330", VA = "0x1872B0530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x72B0D20", Offset = "0x72AFB20", VA = "0x1872B0D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly CNLPFPHBEFK MDHPOFAGDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FAHFACFBLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig CDOIDPGJOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken FEHCANHDGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D JPJPFCNHOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject ACFPFDLKODG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MNHDJBCOCND<Texture2D> LPMMFMGBDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x72AA3F0", Offset = "0x72A91F0", VA = "0x1872AA3F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> DDHOPGNGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72AA5C0", Offset = "0x72A93C0", VA = "0x1872AA5C0")]
		public DHILEOPAEHA(CNLPFPHBEFK MDHPOFAGDME, RenderTexture FAHFACFBLGC, ImposterRenderConfig CDOIDPGJOGH, CancellationToken FEHCANHDGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72AA4D0", Offset = "0x72A92D0", VA = "0x1872AA4D0")]
		[AsyncStateMachine(typeof(KLIHCCAAMEP))]
		private Task<Texture2D> KBHHDEEOILA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72AA3C0", Offset = "0x72A91C0", VA = "0x1872AA3C0", Slot = "10")]
		protected override void AIOLEOBNKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72AA450", Offset = "0x72A9250", VA = "0x1872AA450")]
		private static void FOBJJOEALFD(GameObject ACFPFDLKODG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NLJBMPGMING : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x72B0DD0", Offset = "0x72AFBD0", VA = "0x1872B0DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
	[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private OAFLGEEADIB size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[POFEBHABCEJ("size", OAFLGEEADIB.Custom)]
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
	private static int JJJGLCOOIOO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture EHBCJELHAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PAMKCGLALDO<GameObject> EGOCDBLJMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NAEGINDHOLH LBIMMFIPPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource PCBNIHHNEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MEPEJIIMKOI<Texture2D> PENPFBMLPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private CNLPFPHBEFK HELFOHKIJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture IALNCDDHLGL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MJKCIFKOMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72AFFE0", Offset = "0x72AEDE0", VA = "0x1872AFFE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72B0030", Offset = "0x72AEE30", VA = "0x1872B0030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture ACONHIJMKID
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72AF860", Offset = "0x72AE660", VA = "0x1872AF860")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F4410", Offset = "0x8F3210", VA = "0x1808F4410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private CNLPFPHBEFK KPNKBGHLFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72AF650", Offset = "0x72AE450", VA = "0x1872AF650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LFOJBLCJDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1EDADF0", Offset = "0x1ED9BF0", VA = "0x181EDADF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int NENGNELPCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72AFB20", Offset = "0x72AE920", VA = "0x1872AFB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72AF630", Offset = "0x72AE430", VA = "0x1872AF630")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72AFBC0", Offset = "0x72AE9C0", VA = "0x1872AFBC0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72AF5B0", Offset = "0x72AE3B0", VA = "0x1872AF5B0")]
	private void AKJLMEKGKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72AFF00", Offset = "0x72AED00", VA = "0x1872AFF00")]
	public void Set(CNLPFPHBEFK DCDLLDJLIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72AFEF0", Offset = "0x72AECF0", VA = "0x1872AFEF0")]
	public void Set(Texture CEMDCHNHEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72AFEB0", Offset = "0x72AECB0", VA = "0x1872AFEB0")]
	public void Set(OBKLGBOKIKF IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72AF640", Offset = "0x72AE440", VA = "0x1872AF640")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72AFCC0", Offset = "0x72AEAC0", VA = "0x1872AFCC0")]
	public void SetInternal(CNLPFPHBEFK DCDLLDJLIPF, [Optional] Texture PGEIJHGPKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72AFCB0", Offset = "0x72AEAB0", VA = "0x1872AFCB0")]
	public void SetCustomSize(int DNKEJHDCION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8F9750", Offset = "0x8F8550", VA = "0x1808F9750")]
	public void SetAntiAliasing(int BIPGHJGGEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72AF7B0", Offset = "0x72AE5B0", VA = "0x1872AF7B0")]
	[AsyncStateMachine(typeof(NLJBMPGMING))]
	private void FDIMLGFJEDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72AFA40", Offset = "0x72AE840", VA = "0x1872AFA40")]
	private void JKEACPHACKD(Texture CEMDCHNHEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72AFF60", Offset = "0x72AED60", VA = "0x1872AFF60")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HFFMANBEPIC
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float IHKGPFEJMJP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	public void PrepareImposter(LLCKMIAMDLC KODPGCABALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72AF570", Offset = "0x72AE370", VA = "0x1872AF570")]
	public void SetReferencePoint(Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72AF380", Offset = "0x72AE180", VA = "0x1872AF380")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72AF550", Offset = "0x72AE350", VA = "0x1872AF550")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C2ED50", Offset = "0x1C2DB50", VA = "0x181C2ED50")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ONMEMJJAGPG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static ONMEMJJAGPG DBNHJGJEABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float DDGIAJJNBJG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27220B0", Offset = "0x2720EB0", VA = "0x1827220B0")]
	public ONMEMJJAGPG(float NNOOPKBMIDE)
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
		[Cpp2IlInjected.Address(RVA = "0x72B1910", Offset = "0x72B0710", VA = "0x1872B1910", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
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
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int IKICAAHKFND = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int IMHOJLEJLJH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> AMKJGCCJBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool LMHEHHBAAID;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72B0250", Offset = "0x72AF050", VA = "0x1872B0250")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72B0150", Offset = "0x72AEF50", VA = "0x1872B0150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72B04A0", Offset = "0x72AF2A0", VA = "0x1872B04A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CNLPFPHBEFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string GBBIMMDNFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ONMEMJJAGPG ONMEMJJAGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HKMJOJMNMOF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ODGGPFPBBLC(CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCIFHBLANLI(CNLPFPHBEFK LHMPMCLNOPG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEBOHEPFAOC();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMIAAAACLHL();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IDDPGOENCPJ(uint? JNPBJGPPCEH, [Out] MEPEJIIMKOI<Texture2D> KEOILHJIBGC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DIEBAJHNFKB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72AA780", Offset = "0x72A9580", VA = "0x1872AA780")]
	public static bool HGEJGPIJAFE(CNLPFPHBEFK MDMIBEJELLI, CNLPFPHBEFK BEDGGBFGEKO)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, HFFMANBEPIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72AA270", Offset = "0x72A9070", VA = "0x1872AA270", Slot = "4")]
		public void PrepareImposter(LLCKMIAMDLC KODPGCABALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HFFMANBEPIC
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LLCKMIAMDLC KODPGCABALO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FNOHBKBMCNP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DMIBLOJADOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> IJPPDJHLGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FNHKFEBNPNE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEDJCELIMLA(params Type[] GJNPANOLMDL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NABEFBGBEDA(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, bool KBLEJHNDDAE = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T NABEFBGBEDA<T>(T MFDHKPDFMNP, Transform IFAMCPHMKIP, bool KBLEJHNDDAE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T NABEFBGBEDA<T>(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, bool KBLEJHNDDAE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject NABEFBGBEDA(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, LLCKMIAMDLC KODPGCABALO, bool KBLEJHNDDAE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FGGBPAKKGBH : IDisposable, FNHKFEBNPNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> HKFPFGJJJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> GNJDPMIGAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform ILKDHMNLJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> OEJBBDGEIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LMEMPEIOAHB;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72AEB50", Offset = "0x72AD950", VA = "0x1872AEB50")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	public static void PIKBCINMJOC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72AEC40", Offset = "0x72ADA40", VA = "0x1872AEC40")]
	[UnityEngine.Scripting.Preserve]
	public FGGBPAKKGBH([MHFJPMCEEAM(null)] FNOHBKBMCNP GJNEGGEMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72AE790", Offset = "0x72AD590", VA = "0x1872AE790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72AE870", Offset = "0x72AD670", VA = "0x1872AE870", Slot = "5")]
	public void JEDJCELIMLA(params Type[] GJNPANOLMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72AEA30", Offset = "0x72AD830", VA = "0x1872AEA30", Slot = "6")]
	public GameObject NABEFBGBEDA(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, bool KBLEJHNDDAE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3299FA0", Offset = "0x3298DA0", VA = "0x183299FA0", Slot = "7")]
	public T NABEFBGBEDA<T>(T MFDHKPDFMNP, Transform IFAMCPHMKIP, bool KBLEJHNDDAE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3299F50", Offset = "0x3298D50", VA = "0x183299F50", Slot = "8")]
	public T NABEFBGBEDA<T>(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, bool KBLEJHNDDAE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72AEAC0", Offset = "0x72AD8C0", VA = "0x1872AEAC0", Slot = "9")]
	public GameObject NABEFBGBEDA(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, LLCKMIAMDLC KODPGCABALO, bool KBLEJHNDDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x329A030", Offset = "0x3298E30", VA = "0x18329A030", Slot = "10")]
	public T NABEFBGBEDA<T>(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, LLCKMIAMDLC KODPGCABALO, bool KBLEJHNDDAE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x329A090", Offset = "0x3298E90", VA = "0x18329A090")]
	private T NABEFBGBEDA<T>(GameObject MFDHKPDFMNP, Transform IFAMCPHMKIP, LLCKMIAMDLC KODPGCABALO, bool KBLEJHNDDAE, [Out] GameObject LBNAJAFGMHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3299AB0", Offset = "0x32988B0", VA = "0x183299AB0")]
	private T BKKEBDPMDED<T>(GameObject IHNPMPCJPIK, LLCKMIAMDLC KODPGCABALO, bool KBLEJHNDDAE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72AE680", Offset = "0x72AD480", VA = "0x1872AE680")]
	private void DALADEEFFCN(Component MMJIAOCMCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72AE1D0", Offset = "0x72ACFD0", VA = "0x1872AE1D0")]
	private void AJPAJCPACDM(Component MMJIAOCMCPI, LLCKMIAMDLC KODPGCABALO, bool KBLEJHNDDAE, bool AEEPDJABLEN, [Optional] Type FHAAGDJODOC, [Optional] Type PLNPDBHDHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72AE8C0", Offset = "0x72AD6C0", VA = "0x1872AE8C0")]
	private void MIAFOAOBJOA(GameObject IHNPMPCJPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LLCKMIAMDLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> JNIACIJDIPF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x33ACF90", Offset = "0x33ABD90", VA = "0x1833ACF90")]
	public LLCKMIAMDLC DJKOKNNCNMK<T>(T BLNBINBNALE)
	{
		return default(LLCKMIAMDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x33ACE80", Offset = "0x33ABC80", VA = "0x1833ACE80")]
	public T ANFJBBFMPMK<T>(T KBHDDKCAINE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x33AD6C0", Offset = "0x33AC4C0", VA = "0x1833AD6C0")]
	public bool KFIFLGLFIGE<T>([Out] T BLNBINBNALE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JBJHJAEMJGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool DKMDPOODBBL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x271F930", Offset = "0x271E730", VA = "0x18271F930")]
	public JBJHJAEMJGM(bool JMGCJJGNMOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LLEFNEDCLCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool PKGMEJEJDKC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72B0D90", Offset = "0x72AFB90", VA = "0x1872B0D90")]
	public LLEFNEDCLCE(bool JNCAAHGPELB)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, HFFMANBEPIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x72B1650", Offset = "0x72B0450", VA = "0x1872B1650", Slot = "4")]
		public void PrepareImposter(LLCKMIAMDLC KODPGCABALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
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
		public Bounds DOCLLIJHDLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x72AF1F0", Offset = "0x72ADFF0", VA = "0x1872AF1F0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72AF1B0", Offset = "0x72ADFB0", VA = "0x1872AF1B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72AF170", Offset = "0x72ADF70", VA = "0x1872AF170")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72AF080", Offset = "0x72ADE80", VA = "0x1872AF080")]
		private void IOELKDGGPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
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
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x72B0DB0", Offset = "0x72AFBB0", VA = "0x1872B0DB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x72B0DA0", Offset = "0x72AFBA0", VA = "0x1872B0DA0")]
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
		[POFEBHABCEJ("frameCameraToImposterBounds", true)]
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
		[POFEBHABCEJ("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72B00B0", Offset = "0x72AEEB0", VA = "0x1872B00B0")]
		public void FPEGANOFFCG(Vector3 NOIGPPOELEH, Quaternion OBOIEGONGBE, float GHIKNJGIMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72B00E0", Offset = "0x72AEEE0", VA = "0x1872B00E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class EMAPEMKDNEL
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 GPOHLJKGBDI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> NGMDNNFMOFG;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> GKBKOLIKMIO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera DFIFGDGOHPE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> FNHKLGEKINO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> JJFMGMAGHOF;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode HMHHKOIOBHO;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color CBODNIKNHNO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color DNMOGHAEMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color IKHODOBLDGH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap IBEONAPJPDK;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool GFEKDDOGHAN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> NCIECOMAGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72AC0D0", Offset = "0x72AAED0", VA = "0x1872AC0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> LEILIKBPEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72ACAC0", Offset = "0x72AB8C0", VA = "0x1872ACAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera JHKEAGCGEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x72ACBE0", Offset = "0x72AB9E0", VA = "0x1872ACBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72AD360", Offset = "0x72AC160", VA = "0x1872AD360")]
	public static void OONHAGPPMKK(Vector3 NGKHHBDNOBI, Quaternion KKBMICFBPNM, ImposterRenderConfig INDNHGCEMMB, bool NAGBNKFJBHI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72AC120", Offset = "0x72AAF20", VA = "0x1872AC120")]
	private static void FLHGEJBOHIK(Vector3 NGKHHBDNOBI, Quaternion KKBMICFBPNM, URPLight ODAAOILCDMF, ImposterRenderConfig.LightConfig HDEJHLHBKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72AC440", Offset = "0x72AB240", VA = "0x1872AC440")]
	public static void JJLCCHJNEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72ABCA0", Offset = "0x72AAAA0", VA = "0x1872ABCA0")]
	private static void EACKJFGOGNP(int LKLOIPOABIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72AC520", Offset = "0x72AB320", VA = "0x1872AC520")]
	public static void LGMBKLBAPOE(ImposterRenderConfig INDNHGCEMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72AC6F0", Offset = "0x72AB4F0", VA = "0x1872AC6F0")]
	public static void MJPBDEEFMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72ADC60", Offset = "0x72ACA60", VA = "0x1872ADC60")]
	public static void PPPFBBHFNON(GameObject FLLNBGKCJLB, RenderTexture FAHFACFBLGC, ImposterRenderConfig INDNHGCEMMB, ONMEMJJAGPG PCAGPCDACAF, [Optional] Vector3? LFPKKKNHCPG, [Optional] Vector3? ENABHELIKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72AD600", Offset = "0x72AC400", VA = "0x1872AD600")]
	private static void PHAMDHGCOPN(GameObject FLLNBGKCJLB, RenderTexture FAHFACFBLGC, ImposterRenderConfig INDNHGCEMMB, ONMEMJJAGPG PCAGPCDACAF, Vector3 LFPKKKNHCPG, Vector3 ENABHELIKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72AC7E0", Offset = "0x72AB5E0", VA = "0x1872AC7E0")]
	private static void NDJMLJBEEKK(GameObject FLLNBGKCJLB, Vector3 OKECOOOCABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72AB930", Offset = "0x72AA730", VA = "0x1872AB930")]
	public static void BBGBHPFACJJ(Bounds BPMFDEDKLKK, ImposterRenderConfig INDNHGCEMMB, [Out] Vector3 PBEGOAICODC, [Out] Quaternion POAEHMOIJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x72ACE30", Offset = "0x72ABC30", VA = "0x1872ACE30")]
	private static void OOMNNLHKFNL(GameObject MFDHKPDFMNP, ImposterRenderConfig INDNHGCEMMB, ONMEMJJAGPG PCAGPCDACAF, [Out] Vector3 PBEGOAICODC, [Out] Quaternion POAEHMOIJEN, [Out] float CFBFMBKOOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72ACB10", Offset = "0x72AB910", VA = "0x1872ACB10")]
	public static RenderTexture OCCEEPMEBED(int EOFEIMAHCKE, int BKMKGMAPJDF, RenderTextureFormat IKCALPFNNBN = RenderTextureFormat.ARGB32, string ECNCGODGJPB = "[ImposterRendering]Preview")
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
		public struct EBEAJOEPEMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public IFLNFKMEDGB CIFLMIIGODN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject AMHEADEJDEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture ACONHIJMKID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig LMBNKEHKAIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public ONMEMJJAGPG ONMEMJJAGPG;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x72AB8C0", Offset = "0x72AA6C0", VA = "0x1872AB8C0")]
			public EBEAJOEPEMD(IFLNFKMEDGB BODJEGHPNME, GameObject PGBFCAEMEOG, RenderTexture FAHFACFBLGC, ImposterRenderConfig CDOIDPGJOGH, ONMEMJJAGPG PCAGPCDACAF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static FMGEGMGJJKP<EBEAJOEPEMD, RenderTexture> ECFDGJIAKPL;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<EBEAJOEPEMD> OBKJBPNPOFC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MNBGKMGBEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x72AAD10", Offset = "0x72A9B10", VA = "0x1872AAD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72AAE40", Offset = "0x72A9C40", VA = "0x1872AAE40")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FLLNBGKCJLB, RenderTexture FAHFACFBLGC, ImposterRenderConfig INDNHGCEMMB, ONMEMJJAGPG PCAGPCDACAF, CancellationToken FEHCANHDGHE, bool KPAHMEOCDNC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x72AAB00", Offset = "0x72A9900", VA = "0x1872AAB00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x72AADA0", Offset = "0x72A9BA0", VA = "0x1872AADA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x72AA860", Offset = "0x72A9660", VA = "0x1872AA860")]
		private static Task<RenderTexture> AGGCOIHAOJD(EBEAJOEPEMD EEDAFGPDFNB, CancellationToken FEHCANHDGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72AB260", Offset = "0x72AA060", VA = "0x1872AB260")]
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
