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
	private readonly struct APEKJGDCEAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NGCIPJABEMC FFMJGIJPPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string DAHGILMMGEE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
		public APEKJGDCEAC(NGCIPJABEMC LNGNLHLHOKB, string AHKKKFOPOCC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KLCOJDLDIDP : IAsyncStateMachine
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
		public APEKJGDCEAC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE980", Offset = "0x7FDD180", VA = "0x187FDE980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDED40", Offset = "0x7FDD540", VA = "0x187FDED40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider NGIEILHPGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ONELANNAINO<APEKJGDCEAC, GameObject> PHCOBLEKPCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CMDEOOJFOID LEMPKDLCFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ONELANNAINO<APEKJGDCEAC, GameObject> BKJGCAHNPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC6C0", Offset = "0x7FDAEC0", VA = "0x187FDC6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BLPPNACONMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC600", Offset = "0x7FDAE00", VA = "0x187FDC600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC240", Offset = "0x7FDAA40", VA = "0x187FDC240", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC650", Offset = "0x7FDAE50", VA = "0x187FDC650", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC320", Offset = "0x7FDAB20", VA = "0x187FDC320")]
	[AsyncStateMachine(typeof(KLCOJDLDIDP))]
	private Task<GameObject> LABEFLGCLOI(APEKJGDCEAC LOIBODHBIEF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC440", Offset = "0x7FDAC40", VA = "0x187FDC440")]
	public Task<GameObject> LoadItemAsync(NGCIPJABEMC LNGNLHLHOKB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC820", Offset = "0x7FDB020", VA = "0x187FDC820")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NFCDEMOFHBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NGCIPJABEMC DABEEMHHOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture IKEIPNLMNGG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
		public NFCDEMOFHBL(NGCIPJABEMC CNBDELOCOLO, Texture AILALHOICPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum JLDPHKCEHIA
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
	private class JBHHCIOLGAJ : HHNPEBFGDLG<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct EIAOGDHEOCK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JBHHCIOLGAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7FDC860", Offset = "0x7FDB060", VA = "0x187FDC860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7FDD050", Offset = "0x7FDB850", VA = "0x187FDD050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NGCIPJABEMC CNBDELOCOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture OIIOPEDHLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BDMHEEDPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GMEAHOBHMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D IOOBGHJJJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject DJPPKJFCEFE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override BFIFKPBFBML<Texture2D> ABKCGBMDPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7FDE5E0", Offset = "0x7FDCDE0", VA = "0x187FDE5E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> HINMCAAKHDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE7B0", Offset = "0x7FDCFB0", VA = "0x187FDE7B0")]
		public JBHHCIOLGAJ(NGCIPJABEMC CNBDELOCOLO, RenderTexture OIIOPEDHLGG, ImposterRenderConfig BDMHEEDPKJJ, CancellationToken GMEAHOBHMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE6C0", Offset = "0x7FDCEC0", VA = "0x187FDE6C0")]
		[AsyncStateMachine(typeof(EIAOGDHEOCK))]
		private Task<Texture2D> PPBFPOPKFLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE5B0", Offset = "0x7FDCDB0", VA = "0x187FDE5B0", Slot = "10")]
		protected override void CLFGCPOKFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE640", Offset = "0x7FDCE40", VA = "0x187FDE640")]
		private static void JDNBBPBMPGA(GameObject DJPPKJFCEFE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LKEBDGDLOFK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7FDEE90", Offset = "0x7FDD690", VA = "0x187FDEE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
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
	[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private JLDPHKCEHIA size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[IKNPDEEBCLA("size", JLDPHKCEHIA.Custom)]
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
	private static int ADEOKHENAGP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture AFHBMFOICMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AJKOAGNOMOK<GameObject> LGCOOIHGLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private JLFAJMGNMDK NELFGFMKICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource JKCICFOHGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private OBKOLGEFKBC<Texture2D> NBLAFJBEGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NGCIPJABEMC LPIKDOLEJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture ABPENLNDDLO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EEKAGKIAKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE080", Offset = "0x7FDC880", VA = "0x187FDE080")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE0D0", Offset = "0x7FDC8D0", VA = "0x187FDE0D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture BBPOMABBNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD710", Offset = "0x7FDBF10", VA = "0x187FDD710")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NGCIPJABEMC DABEEMHHOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD980", Offset = "0x7FDC180", VA = "0x187FDD980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool HEJJNEEOHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22A4930", Offset = "0x22A3130", VA = "0x1822A4930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int CBLNPHAIBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FDDBD0", Offset = "0x7FDC3D0", VA = "0x187FDDBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD970", Offset = "0x7FDC170", VA = "0x187FDD970")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDC60", Offset = "0x7FDC460", VA = "0x187FDDC60")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD8F0", Offset = "0x7FDC0F0", VA = "0x187FDD8F0")]
	private void AJDMKKIDLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDF50", Offset = "0x7FDC750", VA = "0x187FDDF50")]
	public void Set(NGCIPJABEMC MKOJEAPIHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDF60", Offset = "0x7FDC760", VA = "0x187FDDF60")]
	public void Set(Texture AILALHOICPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDF70", Offset = "0x7FDC770", VA = "0x187FDDF70")]
	public void Set(NFCDEMOFHBL MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDAE0", Offset = "0x7FDC2E0", VA = "0x187FDDAE0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDD60", Offset = "0x7FDC560", VA = "0x187FDDD60")]
	public void SetInternal(NGCIPJABEMC MKOJEAPIHJN, [Optional] Texture FKDDEEFLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDD50", Offset = "0x7FDC550", VA = "0x187FDDD50")]
	public void SetCustomSize(int DDMFDNCDIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
	public void SetAntiAliasing(int IHMIIAFCLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD660", Offset = "0x7FDBE60", VA = "0x187FDD660")]
	[AsyncStateMachine(typeof(LKEBDGDLOFK))]
	private void AADLNOKIPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDAF0", Offset = "0x7FDC2F0", VA = "0x187FDDAF0")]
	private void MAOENHKFIBD(Texture AILALHOICPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE000", Offset = "0x7FDC800", VA = "0x187FDE000")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, OFJNEEGJEJA
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float BEPBKOLFAOD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void PrepareImposter(ADHDPLDJNHL JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD620", Offset = "0x7FDBE20", VA = "0x187FDD620")]
	public void SetReferencePoint(Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD430", Offset = "0x7FDBC30", VA = "0x187FDD430")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD600", Offset = "0x7FDBE00", VA = "0x187FDD600")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D920", Offset = "0x1F4C120", VA = "0x181F4D920")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PIJGPJHNNNL
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static PIJGPJHNNNL HGILBJLOKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float JDALNHLPLEE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA980", Offset = "0x2AA9180", VA = "0x182AAA980")]
	public PIJGPJHNNNL(float KNGAPHIOHFC)
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
		[Cpp2IlInjected.Address(RVA = "0x7FE2180", Offset = "0x7FE0980", VA = "0x187FE2180", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
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
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int DJIFHOGHEPG = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int CCDKHBJLAPK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> CAOOPFHIELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool HGOPICHOFDI;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE2E0", Offset = "0x7FDCAE0", VA = "0x187FDE2E0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE1E0", Offset = "0x7FDC9E0", VA = "0x187FDE1E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE520", Offset = "0x7FDCD20", VA = "0x187FDE520")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NGCIPJABEMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string EAPCLKOCJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PIJGPJHNNNL PIJGPJHNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BNIIFGOLBKC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DNDLCIEEKAM(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EPKDMMPEPBE(NGCIPJABEMC KEKEFPAJGHD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCMAKKBJMCA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FLAHPPMJJOP();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ACINGLAHACC(uint? DAEDBFCNCCI, [Out] OBKOLGEFKBC<Texture2D> GJOADFJJMCN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LJHJPMFDLJP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEDB0", Offset = "0x7FDD5B0", VA = "0x187FDEDB0")]
	public static bool BAOGKOEGNON(NGCIPJABEMC EPPBHFBPGKA, NGCIPJABEMC KKNMCOHEIOK)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, OFJNEEGJEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA1E0", Offset = "0x7FD89E0", VA = "0x187FDA1E0", Slot = "4")]
		public void PrepareImposter(ADHDPLDJNHL JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OFJNEEGJEJA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ADHDPLDJNHL JCPNJLMMOLN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FNGEJBAELGE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> FGNNDCGKDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> JFDJONEFNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CMDEOOJFOID
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEDCMJKFFLI(params Type[] OHACBPOGLEI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DCLKADGIPEA(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, bool PHLAMBLPBMK = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DCLKADGIPEA<T>(T OJKJJCNLKLJ, Transform MJNLMOPPION, bool PHLAMBLPBMK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DCLKADGIPEA<T>(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, bool PHLAMBLPBMK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject DCLKADGIPEA(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DEEMFAKBDPA : IDisposable, CMDEOOJFOID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BCFDHCGHHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> HCILIHPJJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform PKKMAHEENLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> IBJJCAKKLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PBENDCGNPKP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA5B0", Offset = "0x7FD8DB0", VA = "0x187FDA5B0")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	public static void BGEJLCAAPFF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB3F0", Offset = "0x7FD9BF0", VA = "0x187FDB3F0")]
	[UnityEngine.Scripting.Preserve]
	public DEEMFAKBDPA([FAPODKMFODF(null)] FNGEJBAELGE LELPHKOKBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA7C0", Offset = "0x7FD8FC0", VA = "0x187FDA7C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA330", Offset = "0x7FD8B30", VA = "0x187FDA330", Slot = "5")]
	public void AEDCMJKFFLI(params Type[] OHACBPOGLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA730", Offset = "0x7FD8F30", VA = "0x187FDA730", Slot = "6")]
	public GameObject DCLKADGIPEA(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, bool PHLAMBLPBMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37F60E0", Offset = "0x37F48E0", VA = "0x1837F60E0", Slot = "7")]
	public T DCLKADGIPEA<T>(T OJKJJCNLKLJ, Transform MJNLMOPPION, bool PHLAMBLPBMK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37F6170", Offset = "0x37F4970", VA = "0x1837F6170", Slot = "8")]
	public T DCLKADGIPEA<T>(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, bool PHLAMBLPBMK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA6A0", Offset = "0x7FD8EA0", VA = "0x187FDA6A0", Slot = "9")]
	public GameObject DCLKADGIPEA(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37F6740", Offset = "0x37F4F40", VA = "0x1837F6740", Slot = "10")]
	public T DCLKADGIPEA<T>(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37F61C0", Offset = "0x37F49C0", VA = "0x1837F61C0")]
	private T DCLKADGIPEA<T>(GameObject OJKJJCNLKLJ, Transform MJNLMOPPION, ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK, [Out] GameObject EIIOBLBKKNP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37F5DF0", Offset = "0x37F45F0", VA = "0x1837F5DF0")]
	private T AJOJEJJNJJN<T>(GameObject EMOLHEPHCGI, ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA380", Offset = "0x7FD8B80", VA = "0x187FDA380")]
	private void BFBEHACADAP(ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA9B0", Offset = "0x7FD91B0", VA = "0x187FDA9B0")]
	private void EKIOEALMCFI(ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA8A0", Offset = "0x7FD90A0", VA = "0x187FDA8A0")]
	private void EICEJGILMLF(Component EIBGHDHLJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDABE0", Offset = "0x7FD93E0", VA = "0x187FDABE0")]
	private void EKIOEALMCFI(Component EIBGHDHLJMO, ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK, bool GOFBMEAABIC, [Optional] Type NKIPHIMPLPJ, [Optional] Type PMGOIHNIGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAFC0", Offset = "0x7FD97C0", VA = "0x187FDAFC0")]
	private void KNFLDJPEALB(Component EIBGHDHLJMO, ADHDPLDJNHL JCPNJLMMOLN, bool PHLAMBLPBMK, bool GOFBMEAABIC, [Optional] Type NKIPHIMPLPJ, [Optional] Type PMGOIHNIGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAE50", Offset = "0x7FD9650", VA = "0x187FDAE50")]
	private void KFMLIGELFHL(GameObject EMOLHEPHCGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ADHDPLDJNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> GMACFHMCMII;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x41E2960", Offset = "0x41E1160", VA = "0x1841E2960")]
	public ADHDPLDJNHL NNLOAAEAPBJ<T>(T KMLIAFGPJHD)
	{
		return default(ADHDPLDJNHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x41E2080", Offset = "0x41E0880", VA = "0x1841E2080")]
	public T CEJDCFFPPDB<T>(T GJPLADDCFJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x41E2190", Offset = "0x41E0990", VA = "0x1841E2190")]
	public bool CLCEOBPBAJN<T>([Out] T KMLIAFGPJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA190", Offset = "0x7FD8990", VA = "0x187FDA190")]
	public void CGGBONADGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NLDPIKADHKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool HNELCPKKGAK;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2AA99A0", Offset = "0x2AA81A0", VA = "0x182AA99A0")]
	public NLDPIKADHKK(bool AOMNPLLJIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KJGADOKPOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool GFBNKLBAANM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE970", Offset = "0x7FDD170", VA = "0x187FDE970")]
	public KJGADOKPOJL(bool OKDPNIJPBNL)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, OFJNEEGJEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1ED0", Offset = "0x7FE06D0", VA = "0x187FE1ED0", Slot = "4")]
		public void PrepareImposter(ADHDPLDJNHL JCPNJLMMOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
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
		public Bounds JFBJCMODGGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7FDD2A0", Offset = "0x7FDBAA0", VA = "0x187FDD2A0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD260", Offset = "0x7FDBA60", VA = "0x187FDD260")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD220", Offset = "0x7FDBA20", VA = "0x187FDD220")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD130", Offset = "0x7FDB930", VA = "0x187FDD130")]
		private void COJPHMBLELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FDF6E0", Offset = "0x7FDDEE0", VA = "0x187FDF6E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7FDF6D0", Offset = "0x7FDDED0", VA = "0x187FDF6D0")]
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
		[IKNPDEEBCLA("frameCameraToImposterBounds", true)]
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
		[IKNPDEEBCLA("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDE140", Offset = "0x7FDC940", VA = "0x187FDE140")]
		public void OOMHOLBHBCN(Vector3 NHEHGCMBBBI, Quaternion PANOFOPKLJF, float EGAIEBCIAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE170", Offset = "0x7FDC970", VA = "0x187FDE170")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class OCKNDEPHDOC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 KKKFFHCCHEN;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> GJEJJMDLKGO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> CPACGOCMDMG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera ECJMKPKIFHF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> PIGNPKJGMPF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> CLBOGDPNCCF;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode GPHHHCCPNBO;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color BOIDGCOGGDF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color OHLDGMBLDJG;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color AJAHNPMGAOI;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap BHKGICENEAL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool BBDGHBHAGLA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> ABBFPFJFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0300", Offset = "0x7FDEB00", VA = "0x187FE0300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> DNAKAGMGPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0DB0", Offset = "0x7FDF5B0", VA = "0x187FE0DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera CFINDEMBIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0350", Offset = "0x7FDEB50", VA = "0x187FE0350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FE19F0", Offset = "0x7FE01F0", VA = "0x187FE19F0")]
	public static void NIHGKMJOLFO(Vector3 EKDGODIJBKN, Quaternion OHCLODOKGIC, ImposterRenderConfig BCICDIIBFPJ, bool BLOAFOIAPJG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0580", Offset = "0x7FDED80", VA = "0x187FE0580")]
	private static void IGOHHKBPGIA(Vector3 EKDGODIJBKN, Quaternion OHCLODOKGIC, URPLight MCHOLFPBOBB, ImposterRenderConfig.LightConfig HMCKBAFAKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF7D0", Offset = "0x7FDDFD0", VA = "0x187FDF7D0")]
	public static void ALNEIDOJODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0E00", Offset = "0x7FDF600", VA = "0x187FE0E00")]
	private static void LGIBIOPLPML(int POCKNKAMBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1840", Offset = "0x7FE0040", VA = "0x187FE1840")]
	public static void MOPFHCLFNNP(ImposterRenderConfig BCICDIIBFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF8B0", Offset = "0x7FDE0B0", VA = "0x187FDF8B0")]
	public static void BOFKOMFMFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFFC0", Offset = "0x7FDE7C0", VA = "0x187FDFFC0")]
	public static void FHBNGKGNDBH(GameObject CJLDHAAIOIJ, RenderTexture OIIOPEDHLGG, ImposterRenderConfig BCICDIIBFPJ, PIJGPJHNNNL HAOJHLGHEMO, [Optional] Vector3? MMDHMOFKEBE, [Optional] Vector3? KNGIHAJBFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF990", Offset = "0x7FDE190", VA = "0x187FDF990")]
	private static void DMENKIFBDAM(GameObject CJLDHAAIOIJ, RenderTexture OIIOPEDHLGG, ImposterRenderConfig BCICDIIBFPJ, PIJGPJHNNNL HAOJHLGHEMO, Vector3 MMDHMOFKEBE, Vector3 KNGIHAJBFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1210", Offset = "0x7FDFA10", VA = "0x187FE1210")]
	private static void LMHHOHFHCDA(GameObject CJLDHAAIOIJ, Vector3 BFIBAAEPDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE14D0", Offset = "0x7FDFCD0", VA = "0x187FE14D0")]
	public static void MLJNMIBFBGG(Bounds KFPBJIIJBJN, ImposterRenderConfig BCICDIIBFPJ, [Out] Vector3 MDOHKBAKEDM, [Out] Quaternion EBJFMIHDPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE08A0", Offset = "0x7FDF0A0", VA = "0x187FE08A0")]
	private static void JPKCDILEFAA(GameObject OJKJJCNLKLJ, ImposterRenderConfig BCICDIIBFPJ, PIJGPJHNNNL HAOJHLGHEMO, [Out] Vector3 MDOHKBAKEDM, [Out] Quaternion EBJFMIHDPGK, [Out] float PCBHCJPHPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF700", Offset = "0x7FDDF00", VA = "0x187FDF700")]
	public static RenderTexture AHPNACFNDPO(int GPMLECINMDG, int DMFNFGGJFBG, RenderTextureFormat HKOGDKBPFKC = RenderTextureFormat.ARGB32, string CADCNDMKJIE = "[ImposterRendering]Preview")
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
		public struct FJGHOJAMAJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public JEFMKEBHJKM JDJNKKPPELF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject NGFILJDGJMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture BBPOMABBNDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig NJOFAKNHANP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public PIJGPJHNNNL PIJGPJHNNNL;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7FDD0C0", Offset = "0x7FDB8C0", VA = "0x187FDD0C0")]
			public FJGHOJAMAJO(JEFMKEBHJKM BHNDIAAKONA, GameObject BAPCMIJBFDN, RenderTexture OIIOPEDHLGG, ImposterRenderConfig BDMHEEDPKJJ, PIJGPJHNNNL HAOJHLGHEMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static ONELANNAINO<FJGHOJAMAJO, RenderTexture> EHAKPIGLCOO;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<FJGHOJAMAJO> DNDGANNFJJJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int LBFGDHOMANA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7FDBCE0", Offset = "0x7FDA4E0", VA = "0x187FDBCE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBE00", Offset = "0x7FDA600", VA = "0x187FDBE00")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CJLDHAAIOIJ, RenderTexture OIIOPEDHLGG, ImposterRenderConfig BCICDIIBFPJ, PIJGPJHNNNL HAOJHLGHEMO, CancellationToken GMEAHOBHMAD, bool FBAPIBABBOC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBAD0", Offset = "0x7FDA2D0", VA = "0x187FDBAD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBD70", Offset = "0x7FDA570", VA = "0x187FDBD70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB830", Offset = "0x7FDA030", VA = "0x187FDB830")]
		private static Task<RenderTexture> AFFAALKBMHH(FJGHOJAMAJO DHPCGIMBEBP, CancellationToken GMEAHOBHMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC200", Offset = "0x7FDAA00", VA = "0x187FDC200")]
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
