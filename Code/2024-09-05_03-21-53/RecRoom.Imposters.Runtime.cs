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
	private readonly struct DKDPCAONBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ABJJAAPMGEJ PPIGPJGDDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FMLDLBGKEMP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
		public DKDPCAONBAI(ABJJAAPMGEJ PDLMNDNKLCF, string NONBFLPFCDB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct PIKIECMAKED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public DKDPCAONBAI queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0530", Offset = "0x6BCEF30", VA = "0x186BD0530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD08D0", Offset = "0x6BCF2D0", VA = "0x186BD08D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FGNMNGHGHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CHNHCNFMMGJ<DKDPCAONBAI, GameObject> BJABPONMLHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MCIFENLNHFJ APFOFEGLOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private CHNHCNFMMGJ<DKDPCAONBAI, GameObject> HFBILOLHCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD710", Offset = "0x6BCC110", VA = "0x186BCD710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KMEIDKCJBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD6C0", Offset = "0x6BCC0C0", VA = "0x186BCD6C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD5E0", Offset = "0x6BCBFE0", VA = "0x186BCD5E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDA40", Offset = "0x6BCC440", VA = "0x186BCDA40", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD4C0", Offset = "0x6BCBEC0", VA = "0x186BCD4C0")]
	[AsyncStateMachine(typeof(PIKIECMAKED))]
	private Task<GameObject> AONEFPLGAGP(DKDPCAONBAI FGNEIOHMCIE, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BCD870", Offset = "0x6BCC270", VA = "0x186BCD870")]
	public Task<GameObject> LoadItemAsync(ABJJAAPMGEJ PDLMNDNKLCF, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDAB0", Offset = "0x6BCC4B0", VA = "0x186BCDAB0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class JFNLMHLPPKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ABJJAAPMGEJ NFBJCHPNCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture IGLHHDIKCOD;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88B090", Offset = "0x889A90", VA = "0x18088B090")]
		public JFNLMHLPPKD(ABJJAAPMGEJ FFOMLMEOJKF, Texture GOIIACIDIEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum BENGMMABJII
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
	private class LEOMAJBOAJA : IEFFLHNIJHO<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct HDCNDMFIAJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LEOMAJBOAJA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6BCDAF0", Offset = "0x6BCC4F0", VA = "0x186BCDAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6BCE2F0", Offset = "0x6BCCCF0", VA = "0x186BCE2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ABJJAAPMGEJ FFOMLMEOJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture NKCIJEBEOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig DJLMJKGNCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken OGJIGALEPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject APLDAPNBEDM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override CAPIMDIPLHM<Texture> PECHBLFLADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6BD00F0", Offset = "0x6BCEAF0", VA = "0x186BD00F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> CGJICAOBAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BD02C0", Offset = "0x6BCECC0", VA = "0x186BD02C0")]
		public LEOMAJBOAJA(ABJJAAPMGEJ FFOMLMEOJKF, RenderTexture NKCIJEBEOAF, ImposterRenderConfig DJLMJKGNCEA, CancellationToken OGJIGALEPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0150", Offset = "0x6BCEB50", VA = "0x186BD0150")]
		[AsyncStateMachine(typeof(HDCNDMFIAJA))]
		private Task<Texture> JMNDFLBKHFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BD00E0", Offset = "0x6BCEAE0", VA = "0x186BD00E0", Slot = "10")]
		protected override void CMHPCCIKJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0240", Offset = "0x6BCEC40", VA = "0x186BD0240")]
		private static void OFLENKHANKK(GameObject APLDAPNBEDM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KEKBKAPJEDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF8E0", Offset = "0x6BCE2E0", VA = "0x186BCF8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	[SerializeField]
	private BENGMMABJII size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[BENIALBDKBI("size", BENGMMABJII.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
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
	private static int FNOGIJEOOGH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture LJKMFHMIAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OHNBPBPBAPA<GameObject> IFHKKFHEDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private EOKLDMPJAPL OCEKDNHCKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource HKMLILDBOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FGDPIAEELFA<Texture> ELJNLMHPPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ABJJAAPMGEJ DEBICOPCBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DBPPPJELGBI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int DMGDCFJFNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF2C0", Offset = "0x6BCDCC0", VA = "0x186BCF2C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF310", Offset = "0x6BCDD10", VA = "0x186BCF310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture NKHKIFEBKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE8B0", Offset = "0x6BCD2B0", VA = "0x186BCE8B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x886990", Offset = "0x885390", VA = "0x180886990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ABJJAAPMGEJ NFBJCHPNCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x886020", Offset = "0x884A20", VA = "0x180886020")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BCECB0", Offset = "0x6BCD6B0", VA = "0x186BCECB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool HMCHPBMGNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x17D1BF0", Offset = "0x17D05F0", VA = "0x1817D1BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int CFKMHGMKKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BCEB70", Offset = "0x6BCD570", VA = "0x186BCEB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE890", Offset = "0x6BCD290", VA = "0x186BCE890")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEE90", Offset = "0x6BCD890", VA = "0x186BCEE90")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEE10", Offset = "0x6BCD810", VA = "0x186BCEE10")]
	private void KBPMAFOKLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF1A0", Offset = "0x6BCDBA0", VA = "0x186BCF1A0")]
	public void Set(ABJJAAPMGEJ NJMFGDJFDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF190", Offset = "0x6BCDB90", VA = "0x186BCF190")]
	public void Set(Texture GOIIACIDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF1B0", Offset = "0x6BCDBB0", VA = "0x186BCF1B0")]
	public void Set(JFNLMHLPPKD CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE8A0", Offset = "0x6BCD2A0", VA = "0x186BCE8A0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEF90", Offset = "0x6BCD990", VA = "0x186BCEF90")]
	public void SetInternal(ABJJAAPMGEJ NJMFGDJFDJK, [Optional] Texture BFFFFAGCMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEF80", Offset = "0x6BCD980", VA = "0x186BCEF80")]
	public void SetCustomSize(int FIKENNNFIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x886980", Offset = "0x885380", VA = "0x180886980")]
	public void SetAntiAliasing(int HJOCBLKKLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEC00", Offset = "0x6BCD600", VA = "0x186BCEC00")]
	[AsyncStateMachine(typeof(KEKBKAPJEDB))]
	private void JCEGDHMIMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEA90", Offset = "0x6BCD490", VA = "0x186BCEA90")]
	private void FNKLMDFFDPN(Texture GOIIACIDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF240", Offset = "0x6BCDC40", VA = "0x186BCF240")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, JJBGFOMOEAO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float IIDPANHEOBP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void PrepareImposter(FBAAENJIDID APDNBDIKMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE850", Offset = "0x6BCD250", VA = "0x186BCE850")]
	public void SetReferencePoint(Vector3 IFAKEDNBGGM, Quaternion CHAHMPCNOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE660", Offset = "0x6BCD060", VA = "0x186BCE660")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE830", Offset = "0x6BCD230", VA = "0x186BCE830")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1789470", Offset = "0x1787E70", VA = "0x181789470")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DHGBGBEHMKK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DHGBGBEHMKK BFGHAFLEBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float CNMPCJEPHGC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x225E750", Offset = "0x225D150", VA = "0x18225E750")]
	public DHGBGBEHMKK(float CGDLECIHJLB)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0C20", Offset = "0x6BCF620", VA = "0x186BD0C20", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
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
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int KKCFNEFLOKD = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int JLBHPCDLACA = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> FDOCKOIGHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool NPCLMJJIDJA;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF510", Offset = "0x6BCDF10", VA = "0x186BCF510")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF410", Offset = "0x6BCDE10", VA = "0x186BCF410")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF760", Offset = "0x6BCE160", VA = "0x186BCF760")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ABJJAAPMGEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KCNINHECCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DHGBGBEHMKK DHGBGBEHMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GCIKNGIEKAB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DGCMCNHPCKF(CancellationToken OGJIGALEPCA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BMABGLGEFGI(ABJJAAPMGEJ AIPFCMFLDKG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMJNCNOLHEF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKJOMNJNNJE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool APKCFPFNNNF([Out] FGDPIAEELFA<Texture> BEMAGJEMJAK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JNIACMONGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF7F0", Offset = "0x6BCE1F0", VA = "0x186BCF7F0")]
	public static bool GIOLNGCLOKF(ABJJAAPMGEJ ILBCGKBEJFO, ABJJAAPMGEJ LOOPOPEEBLB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, JJBGFOMOEAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC9D0", Offset = "0x6BCB3D0", VA = "0x186BCC9D0", Slot = "4")]
		public void PrepareImposter(FBAAENJIDID APDNBDIKMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JJBGFOMOEAO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(FBAAENJIDID APDNBDIKMDG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface INKIGBPHHKK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> OOPCLIHGHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> APCGDGLMFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MCIFENLNHFJ
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMLCMKIDDNG(params Type[] DLOMGBIBNCN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DHKACAHDGPC(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, bool GCFCOPCODNB = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DHKACAHDGPC<T>(T FNDDMGMPCAM, Transform DLPGBMPJIIG, bool GCFCOPCODNB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DHKACAHDGPC<T>(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, bool GCFCOPCODNB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject DHKACAHDGPC(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, FBAAENJIDID APDNBDIKMDG, bool GCFCOPCODNB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class COCCFIBOCED : IDisposable, MCIFENLNHFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> OIKGCDJLFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> GPACFLFHLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform CCHDNCKNAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> JFEJDNNKPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PNHEINGJHCD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC380", Offset = "0x6BCAD80", VA = "0x186BCC380")]
	[POCMGODEOKB.GGOFPJDKHFE]
	public static void MEDHEEHHIJF(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC590", Offset = "0x6BCAF90", VA = "0x186BCC590")]
	[UnityEngine.Scripting.Preserve]
	public COCCFIBOCED([CNNDHKODGDP(null)] INKIGBPHHKK FOJPPEHKCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC250", Offset = "0x6BCAC50", VA = "0x186BCC250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC330", Offset = "0x6BCAD30", VA = "0x186BCC330", Slot = "5")]
	public void JMLCMKIDDNG(params Type[] DLOMGBIBNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC130", Offset = "0x6BCAB30", VA = "0x186BCC130", Slot = "6")]
	public GameObject DHKACAHDGPC(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, bool GCFCOPCODNB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AC87B0", Offset = "0x2AC71B0", VA = "0x182AC87B0", Slot = "7")]
	public T DHKACAHDGPC<T>(T FNDDMGMPCAM, Transform DLPGBMPJIIG, bool GCFCOPCODNB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8840", Offset = "0x2AC7240", VA = "0x182AC8840", Slot = "8")]
	public T DHKACAHDGPC<T>(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, bool GCFCOPCODNB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC1C0", Offset = "0x6BCABC0", VA = "0x186BCC1C0", Slot = "9")]
	public GameObject DHKACAHDGPC(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, FBAAENJIDID APDNBDIKMDG, bool GCFCOPCODNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8750", Offset = "0x2AC7150", VA = "0x182AC8750", Slot = "10")]
	public T DHKACAHDGPC<T>(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, FBAAENJIDID APDNBDIKMDG, bool GCFCOPCODNB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8890", Offset = "0x2AC7290", VA = "0x182AC8890")]
	private T DHKACAHDGPC<T>(GameObject FNDDMGMPCAM, Transform DLPGBMPJIIG, FBAAENJIDID APDNBDIKMDG, bool GCFCOPCODNB, [Out] GameObject DOOHLHJCFPJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AC8E10", Offset = "0x2AC7810", VA = "0x182AC8E10")]
	private T DKNFOBENEEL<T>(GameObject EABKFLBGOGN, FBAAENJIDID APDNBDIKMDG, bool GCFCOPCODNB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC480", Offset = "0x6BCAE80", VA = "0x186BCC480")]
	private void MLEDJCANGOM(Component PHMJIJLHMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBB10", Offset = "0x6BCA510", VA = "0x186BCBB10")]
	private void AICJIOKOJGB(Component PHMJIJLHMJK, FBAAENJIDID APDNBDIKMDG, bool GCFCOPCODNB, bool FIDKDEAOLJH, [Optional] Type AKPKOJNHFGC, [Optional] Type PGPCEOHKIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBFC0", Offset = "0x6BCA9C0", VA = "0x186BCBFC0")]
	private void BHOKAADLGCH(GameObject EABKFLBGOGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FBAAENJIDID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> FPKIIBOINJJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2C5E990", Offset = "0x2C5D390", VA = "0x182C5E990")]
	public FBAAENJIDID IDPEEMDPGBG<T>(T GAHIJCDIHGH)
	{
		return default(FBAAENJIDID);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F8A0", Offset = "0x2C5E2A0", VA = "0x182C5F8A0")]
	public T PHNOCPFLPNG<T>(T PEMAOEALEHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F0C0", Offset = "0x2C5DAC0", VA = "0x182C5F0C0")]
	public bool MJGHNDKEOOO<T>([Out] T GAHIJCDIHGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MDOIIJNJNGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool LEJFCKJPAKD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x225C3B0", Offset = "0x225ADB0", VA = "0x18225C3B0")]
	public MDOIIJNJNGN(bool DPNBBDGGHAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OHEDBNMDAAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LODDFKMADMC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0520", Offset = "0x6BCEF20", VA = "0x186BD0520")]
	public OHEDBNMDAAM(bool FLCIBKGLDII)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, JJBGFOMOEAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0940", Offset = "0x6BCF340", VA = "0x186BD0940", Slot = "4")]
		public void PrepareImposter(FBAAENJIDID APDNBDIKMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds NENBPDDIEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6BCE4D0", Offset = "0x6BCCED0", VA = "0x186BCE4D0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE490", Offset = "0x6BCCE90", VA = "0x186BCE490")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE450", Offset = "0x6BCCE50", VA = "0x186BCE450")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BCE360", Offset = "0x6BCCD60", VA = "0x186BCE360")]
		private void AELMEPELNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
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
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6BD0490", Offset = "0x6BCEE90", VA = "0x186BD0490")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6BD0480", Offset = "0x6BCEE80", VA = "0x186BD0480")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF380", Offset = "0x6BCDD80", VA = "0x186BCF380")]
		public void IKKDIIPJBCN(Vector3 BGIIONJGOMH, Quaternion AGBPDGGGLAE, float DBLMMEOCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BCF3B0", Offset = "0x6BCDDB0", VA = "0x186BCF3B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CMFMBAHGMLL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 DAJNCCABIGI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> AFLHFAPLDHD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> OEGODOGGNGF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera NDCGIPDGOBM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> EGNBLMELJOH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> COEBHAGMKOP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode LMKNJCFMPIL;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color PFCCFEBLCJM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color BHGGJFMIKKM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color DFNKMNPGCLD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap KODOKEPOOBC;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool LMLKGFAJHJK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> OANMHABJDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC95A0", Offset = "0x6BC7FA0", VA = "0x186BC95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> OIEBIBHBJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BC99E0", Offset = "0x6BC83E0", VA = "0x186BC99E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera HPFAIPALMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9CF0", Offset = "0x6BC86F0", VA = "0x186BC9CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA550", Offset = "0x6BC8F50", VA = "0x186BCA550")]
	public static void KIMBFMBGLJE(Vector3 GMHKCMJEANF, Quaternion MDIIDFGBJHD, ImposterRenderConfig JLKCMHDCEEK, bool INAOKKJLHHI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BC96C0", Offset = "0x6BC80C0", VA = "0x186BC96C0")]
	private static void FLPHKJALLEF(Vector3 GMHKCMJEANF, Quaternion MDIIDFGBJHD, URPLight MDOCCGJAFJA, ImposterRenderConfig.LightConfig KELKPHIODGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB4E0", Offset = "0x6BC9EE0", VA = "0x186BCB4E0")]
	public static void PBHDCIMJEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BCAF10", Offset = "0x6BC9910", VA = "0x186BCAF10")]
	private static void MJLGLCOEHML(int BNKMACBDJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB330", Offset = "0x6BC9D30", VA = "0x186BCB330")]
	public static void OLDAODBGMEE(ImposterRenderConfig JLKCMHDCEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA7E0", Offset = "0x6BC91E0", VA = "0x186BCA7E0")]
	public static void KPJOOBCCBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB5C0", Offset = "0x6BC9FC0", VA = "0x186BCB5C0")]
	public static void POHKDNBKPNC(GameObject KCCBKBHOPCA, RenderTexture NKCIJEBEOAF, ImposterRenderConfig JLKCMHDCEEK, DHGBGBEHMKK JIKLKLJGJFN, [Optional] Vector3? GJDENDOIFAD, [Optional] Vector3? AFFNMMPHLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9F20", Offset = "0x6BC8920", VA = "0x186BC9F20")]
	private static void KDGANLINHMP(GameObject KCCBKBHOPCA, RenderTexture NKCIJEBEOAF, ImposterRenderConfig JLKCMHDCEEK, DHGBGBEHMKK JIKLKLJGJFN, Vector3 GJDENDOIFAD, Vector3 AFFNMMPHLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9A30", Offset = "0x6BC8430", VA = "0x186BC9A30")]
	private static void JCOLBBEBAAP(GameObject KCCBKBHOPCA, Vector3 KMONBCKGPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCA8C0", Offset = "0x6BC92C0", VA = "0x186BCA8C0")]
	private static void MIJHAIJCJMI(GameObject FNDDMGMPCAM, ImposterRenderConfig JLKCMHDCEEK, DHGBGBEHMKK JIKLKLJGJFN, [Out] Vector3 EKBGPAPCLAE, [Out] Quaternion DBOLLCABODI, [Out] float GNFAMCHEIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC95F0", Offset = "0x6BC7FF0", VA = "0x186BC95F0")]
	public static RenderTexture FFPEFLBKAOC(int PBCKEPEIHHM, int NAEEKHAHIML, RenderTextureFormat CJLNMCEFAGN = RenderTextureFormat.ARGB32, string GEEKDDIGCGP = "[ImposterRendering]Preview")
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
		public struct MPGEOKBLPDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EOBCPEOLCKN EIBMDIEMJBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject CKILMELMIKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture NKHKIFEBKJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig ELAKDLCLJHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public DHGBGBEHMKK DHGBGBEHMKK;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6BD04B0", Offset = "0x6BCEEB0", VA = "0x186BD04B0")]
			public MPGEOKBLPDP(EOBCPEOLCKN ICGLPDPDDBB, GameObject EGGOLOLPAJD, RenderTexture NKCIJEBEOAF, ImposterRenderConfig DJLMJKGNCEA, DHGBGBEHMKK JIKLKLJGJFN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static CHNHCNFMMGJ<MPGEOKBLPDP, RenderTexture> PAABJJJCNOH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<MPGEOKBLPDP> HPGNJAFLLKN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int ANPPNHKDNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6BCCB60", Offset = "0x6BCB560", VA = "0x186BCCB60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD080", Offset = "0x6BCBA80", VA = "0x186BCD080")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KCCBKBHOPCA, RenderTexture NKCIJEBEOAF, ImposterRenderConfig JLKCMHDCEEK, DHGBGBEHMKK JIKLKLJGJFN, CancellationToken OGJIGALEPCA, bool BOKKPOGPBOD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCBF0", Offset = "0x6BCB5F0", VA = "0x186BCCBF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCFF0", Offset = "0x6BCB9F0", VA = "0x186BCCFF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6BCCE00", Offset = "0x6BCB800", VA = "0x186BCCE00")]
		private static Task<RenderTexture> FBBIAJHPGBK(MPGEOKBLPDP OHDPCCKENPM, CancellationToken OGJIGALEPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD480", Offset = "0x6BCBE80", VA = "0x186BCD480")]
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
