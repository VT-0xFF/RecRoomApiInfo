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
	private readonly struct BFKOBDKNAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly PLMPDIPHNIM ONPLEIGBKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string NGJMKJKOLJJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
		public BFKOBDKNAFJ(PLMPDIPHNIM PKDHPJLNBAB, string CPEMDJPLCHA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ODDCJJGMLCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public BFKOBDKNAFJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69F5390", Offset = "0x69F3F90", VA = "0x1869F5390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69F5730", Offset = "0x69F4330", VA = "0x1869F5730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FNKHFCAJKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DDNFDBHENGF<BFKOBDKNAFJ, GameObject> LFBAJFBGBLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BDKGLOKLABI OKPICLINDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DDNFDBHENGF<BFKOBDKNAFJ, GameObject> MJJCNBGHHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69F2A60", Offset = "0x69F1660", VA = "0x1869F2A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int IPEDHJCFKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69F2BC0", Offset = "0x69F17C0", VA = "0x1869F2BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69F2650", Offset = "0x69F1250", VA = "0x1869F2650", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69F29F0", Offset = "0x69F15F0", VA = "0x1869F29F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69F28D0", Offset = "0x69F14D0", VA = "0x1869F28D0")]
	[AsyncStateMachine(typeof(ODDCJJGMLCB))]
	private Task<GameObject> OJJCDDBIEOB(BFKOBDKNAFJ CDMKNDFEGHC, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69F2710", Offset = "0x69F1310", VA = "0x1869F2710")]
	public Task<GameObject> LoadItemAsync(PLMPDIPHNIM PKDHPJLNBAB, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69F2C10", Offset = "0x69F1810", VA = "0x1869F2C10")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HPNNEBPFJMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PLMPDIPHNIM MEKEONMDFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture BCLPPNAMJPC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
		public HPNNEBPFJMJ(PLMPDIPHNIM GHAHMDBEKAD, Texture CCJNIFOFHAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum FDHIBNBHDFC
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
	private class JCHKICCNOFG : BKNNFBEIGPP<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct CEFNDKCMPBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public JCHKICCNOFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69F1260", Offset = "0x69EFE60", VA = "0x1869F1260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69F1A60", Offset = "0x69F0660", VA = "0x1869F1A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly PLMPDIPHNIM GHAHMDBEKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LJFIIEDOBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig NNIOKMHAMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken PPKBAEMFIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject DMFANOKKMPD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override AMIFHJEHCND<Texture> HCAJJBHGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69F4FD0", Offset = "0x69F3BD0", VA = "0x1869F4FD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> MPHKHCCKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69F51A0", Offset = "0x69F3DA0", VA = "0x1869F51A0")]
		public JCHKICCNOFG(PLMPDIPHNIM GHAHMDBEKAD, RenderTexture LJFIIEDOBMH, ImposterRenderConfig NNIOKMHAMCI, CancellationToken PPKBAEMFIMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69F50B0", Offset = "0x69F3CB0", VA = "0x1869F50B0")]
		[AsyncStateMachine(typeof(CEFNDKCMPBL))]
		private Task<Texture> PKMGGPIEKCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69F4FC0", Offset = "0x69F3BC0", VA = "0x1869F4FC0", Slot = "10")]
		protected override void GECMKKIMMEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69F5030", Offset = "0x69F3C30", VA = "0x1869F5030")]
		private static void NAAAANJFDGJ(GameObject DMFANOKKMPD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ODIJHNOHPLN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69F57A0", Offset = "0x69F43A0", VA = "0x1869F57A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private FDHIBNBHDFC size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[MIPPFGOLFDM("size", FDHIBNBHDFC.Custom)]
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
	private static int POEDJBAMDHA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture HBFFDHAOOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LLENODIAMIN<GameObject> MEHCFFJONOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private OECOIGMFBKH HEDILEOLCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource GJNGFDIEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MOKKMPAFINF<Texture> JBEDIMKEBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private PLMPDIPHNIM DICPPCIABBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture ACABPDAMIEB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int DDBEBDIMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69F4A80", Offset = "0x69F3680", VA = "0x1869F4A80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69F4AD0", Offset = "0x69F36D0", VA = "0x1869F4AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture AMJAKKOPIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69F4280", Offset = "0x69F2E80", VA = "0x1869F4280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86A0F0", Offset = "0x868CF0", VA = "0x18086A0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private PLMPDIPHNIM MEKEONMDFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86B520", Offset = "0x86A120", VA = "0x18086B520")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69F4060", Offset = "0x69F2C60", VA = "0x1869F4060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool ODIKLFKLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1596980", Offset = "0x1595580", VA = "0x181596980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int PEKMBHPOKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69F45D0", Offset = "0x69F31D0", VA = "0x1869F45D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69F4050", Offset = "0x69F2C50", VA = "0x1869F4050")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69F44E0", Offset = "0x69F30E0", VA = "0x1869F44E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69F4460", Offset = "0x69F3060", VA = "0x1869F4460")]
	private void NKOFHGPGKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69F49A0", Offset = "0x69F35A0", VA = "0x1869F49A0")]
	public void Set(PLMPDIPHNIM NGAPFJBIHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69F4950", Offset = "0x69F3550", VA = "0x1869F4950")]
	public void Set(Texture CCJNIFOFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69F4960", Offset = "0x69F3560", VA = "0x1869F4960")]
	public void Set(HPNNEBPFJMJ IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69F41C0", Offset = "0x69F2DC0", VA = "0x1869F41C0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69F4760", Offset = "0x69F3360", VA = "0x1869F4760")]
	public void SetInternal(PLMPDIPHNIM NGAPFJBIHEM, [Optional] Texture LBJBKFGNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69F4750", Offset = "0x69F3350", VA = "0x1869F4750")]
	public void SetCustomSize(int AIDPFKOEONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86A110", Offset = "0x868D10", VA = "0x18086A110")]
	public void SetAntiAliasing(int BEEJLHJMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69F41D0", Offset = "0x69F2DD0", VA = "0x1869F41D0")]
	[AsyncStateMachine(typeof(ODIJHNOHPLN))]
	private void IHPEFBLPCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69F4670", Offset = "0x69F3270", VA = "0x1869F4670")]
	private void PNMHGOGEDLK(Texture CCJNIFOFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69F4A00", Offset = "0x69F3600", VA = "0x1869F4A00")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, FILPEEINLME
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float PPJDMFAAAAD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
	public void PrepareImposter(KCPIDOOEAEH AINJPEDDNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69F4010", Offset = "0x69F2C10", VA = "0x1869F4010")]
	public void SetReferencePoint(Vector3 PNBKCIFAGHL, Quaternion DIBEOMGKEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69F3E10", Offset = "0x69F2A10", VA = "0x1869F3E10")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69F3FF0", Offset = "0x69F2BF0", VA = "0x1869F3FF0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x160A3D0", Offset = "0x1608FD0", VA = "0x18160A3D0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ACNGFHFPIGK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static ACNGFHFPIGK KBPEEIMODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float IBAHJHOPMML;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x217EA20", Offset = "0x217D620", VA = "0x18217EA20")]
	public ACNGFHFPIGK(float HFJHIEIABAA)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int CGEHLABALEE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int FKMDEHMABPB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> PACHGCHAEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool PBBAGJIBALL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69F4CE0", Offset = "0x69F38E0", VA = "0x1869F4CE0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69F4BE0", Offset = "0x69F37E0", VA = "0x1869F4BE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69F4F30", Offset = "0x69F3B30", VA = "0x1869F4F30")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PLMPDIPHNIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DACIONJBION
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ACNGFHFPIGK ACNGFHFPIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MKGKBIAMDJO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> EIMKHKKIIFE(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EGNNJGEHJMM(PLMPDIPHNIM HEIGABGMPLJ);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDGMBCCNKNB();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCCOKONNKFL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JFHNIDECJNL([Out] MOKKMPAFINF<Texture> BBLNDCFJFHC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DFKGDOMOMPL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69F1C20", Offset = "0x69F0820", VA = "0x1869F1C20")]
	public static bool OOCIEGLEADI(PLMPDIPHNIM HLLHDKHPCBL, PLMPDIPHNIM FPAHADMHJMI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, FILPEEINLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69F1AD0", Offset = "0x69F06D0", VA = "0x1869F1AD0", Slot = "4")]
		public void PrepareImposter(KCPIDOOEAEH AINJPEDDNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FILPEEINLME
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KCPIDOOEAEH AINJPEDDNEM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IGEMPBGLMIF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> GEFBBCPNCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> DGICJCHIEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BDKGLOKLABI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INFMGKEOEPP(params Type[] LGOHKICJGNF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NLGAANAJHDM(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, bool HGBINFGCLHP = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T NLGAANAJHDM<T>(T GKHPLJIBDDP, Transform DELFIACNBGK, bool HGBINFGCLHP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T NLGAANAJHDM<T>(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, bool HGBINFGCLHP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject NLGAANAJHDM(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, KCPIDOOEAEH AINJPEDDNEM, bool HGBINFGCLHP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IPEKDCBDCOO : IDisposable, BDKGLOKLABI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> GEGCDHFPHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> APHNOCJHOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform FOMIJLODPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> DFCNGLDKBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JJNBAJFEBDD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69F35E0", Offset = "0x69F21E0", VA = "0x1869F35E0")]
	[DHOHFCLMOGD(IDHBAGABJJA.None)]
	public static void NOFLNPHPAAG(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69F36D0", Offset = "0x69F22D0", VA = "0x1869F36D0")]
	[Preserve]
	public IPEKDCBDCOO([POJODGKFIMO(null)] IGEMPBGLMIF LNBGGOKEFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69F2C50", Offset = "0x69F1850", VA = "0x1869F2C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69F3360", Offset = "0x69F1F60", VA = "0x1869F3360", Slot = "5")]
	public void INFMGKEOEPP(params Type[] LGOHKICJGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69F3550", Offset = "0x69F2150", VA = "0x1869F3550", Slot = "6")]
	public GameObject NLGAANAJHDM(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, bool HGBINFGCLHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B88BF0", Offset = "0x2B877F0", VA = "0x182B88BF0", Slot = "7")]
	public T NLGAANAJHDM<T>(T GKHPLJIBDDP, Transform DELFIACNBGK, bool HGBINFGCLHP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B88620", Offset = "0x2B87220", VA = "0x182B88620", Slot = "8")]
	public T NLGAANAJHDM<T>(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, bool HGBINFGCLHP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69F34C0", Offset = "0x69F20C0", VA = "0x1869F34C0", Slot = "9")]
	public GameObject NLGAANAJHDM(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, KCPIDOOEAEH AINJPEDDNEM, bool HGBINFGCLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B88C80", Offset = "0x2B87880", VA = "0x182B88C80", Slot = "10")]
	public T NLGAANAJHDM<T>(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, KCPIDOOEAEH AINJPEDDNEM, bool HGBINFGCLHP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B88670", Offset = "0x2B87270", VA = "0x182B88670")]
	private T NLGAANAJHDM<T>(GameObject GKHPLJIBDDP, Transform DELFIACNBGK, KCPIDOOEAEH AINJPEDDNEM, bool HGBINFGCLHP, [Out] GameObject MPFCHFOCIHC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B88180", Offset = "0x2B86D80", VA = "0x182B88180")]
	private T KFAEMDCCKCB<T>(GameObject OJCNPGOLEHK, KCPIDOOEAEH AINJPEDDNEM, bool HGBINFGCLHP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69F33B0", Offset = "0x69F1FB0", VA = "0x1869F33B0")]
	private void MHIIOJDBPFA(Component BFLHJMMHBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69F2D30", Offset = "0x69F1930", VA = "0x1869F2D30")]
	private void GKAOEPHMGCL(Component BFLHJMMHBCN, KCPIDOOEAEH AINJPEDDNEM, bool HGBINFGCLHP, bool MBIHNNKAJKO, [Optional] Type IOGDKFCDCHH, [Optional] Type JPFJEGPKBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69F31F0", Offset = "0x69F1DF0", VA = "0x1869F31F0")]
	private void IMCDGKANCFA(GameObject OJCNPGOLEHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KCPIDOOEAEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> EKEEBDGKAGO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9BF0", Offset = "0x2BE87F0", VA = "0x182BE9BF0")]
	public KCPIDOOEAEH IJGOPKKNHAN<T>(T DOAHPPOKENP)
	{
		return default(KCPIDOOEAEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAB00", Offset = "0x2BE9700", VA = "0x182BEAB00")]
	public T OIPGNBHOLEB<T>(T APDNGABBFBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA320", Offset = "0x2BE8F20", VA = "0x182BEA320")]
	public bool LPJAHGPAPEL<T>([Out] T DOAHPPOKENP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HFGOLLOLFJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool LHBGDFKGMNM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x217CC00", Offset = "0x217B800", VA = "0x18217CC00")]
	public HFGOLLOLFJI(bool DFOIEOPGMFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PIBPJBPCBGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool BNNNPDGLAHK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69F6010", Offset = "0x69F4C10", VA = "0x1869F6010")]
	public PIBPJBPCBGC(bool HOHCKHLNFHE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, FILPEEINLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69F6020", Offset = "0x69F4C20", VA = "0x1869F6020", Slot = "4")]
		public void PrepareImposter(KCPIDOOEAEH AINJPEDDNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds FICHJICIKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x69F3C80", Offset = "0x69F2880", VA = "0x1869F3C80")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69F3C40", Offset = "0x69F2840", VA = "0x1869F3C40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69F3C00", Offset = "0x69F2800", VA = "0x1869F3C00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69F3B10", Offset = "0x69F2710", VA = "0x1869F3B10")]
		private void IFNAMDDFPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
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
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x69F5370", Offset = "0x69F3F70", VA = "0x1869F5370")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x69F5360", Offset = "0x69F3F60", VA = "0x1869F5360")]
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

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69F4B50", Offset = "0x69F3750", VA = "0x1869F4B50")]
		public void IDHJHIDAKIE(Vector3 ANMNNJMLCOB, Quaternion FGPFIBOPLGC, float NOJPOBDDOEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69F4B80", Offset = "0x69F3780", VA = "0x1869F4B80")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BJOEALAOLNP
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 OFOMMCGMHLM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> KLHAEOCKMDP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> BOKHEGMFLNC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera LMEOEILAHGL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> FCILJOOJDNP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> MKMJMMBNEAH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode KDOKGLBABKF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color ECPMGDJPACM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color KIPGIPENMJP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color JMAHNJEMNGD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap CGDHBGBKKHJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool NJCKPPABEGO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> MHIEODGFHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69F0300", Offset = "0x69EEF00", VA = "0x1869F0300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> NPHBLNDDPII
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69F06C0", Offset = "0x69EF2C0", VA = "0x1869F06C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera HLBJAPOCLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69EEEE0", Offset = "0x69EDAE0", VA = "0x1869EEEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69F0420", Offset = "0x69EF020", VA = "0x1869F0420")]
	public static void LFHJOPMOPIB(Vector3 DGKIPLCCKMF, Quaternion DGFEJGGBMML, ImposterRenderConfig CPJOFLAMJLA, bool PKGFPBCACBL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69EF560", Offset = "0x69EE160", VA = "0x1869EF560")]
	private static void CMLCFPCLKLP(Vector3 DGKIPLCCKMF, Quaternion DGFEJGGBMML, URPLight EMKNACKNGJM, ImposterRenderConfig.LightConfig LJGNNIMAFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69EF890", Offset = "0x69EE490", VA = "0x1869EF890")]
	public static void FEAGNFNAOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69EF130", Offset = "0x69EDD30", VA = "0x1869EF130")]
	private static void CKLLNMKDGNJ(int JFHNIHCBADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69F0E70", Offset = "0x69EFA70", VA = "0x1869F0E70")]
	public static void OLDECKADJCA(ImposterRenderConfig CPJOFLAMJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69F0710", Offset = "0x69EF310", VA = "0x1869F0710")]
	public static void NJPONGHDKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69EF970", Offset = "0x69EE570", VA = "0x1869EF970")]
	public static void HGAEPPMFKLN(GameObject GDPNBFIEOGK, RenderTexture LJFIIEDOBMH, ImposterRenderConfig CPJOFLAMJLA, ACNGFHFPIGK NKMNJPJOENL, [Optional] Vector3? KMHIFBEIBHB, [Optional] Vector3? FJFFLJCKGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69EFCB0", Offset = "0x69EE8B0", VA = "0x1869EFCB0")]
	private static void KEJAMJIDCAN(GameObject GDPNBFIEOGK, RenderTexture LJFIIEDOBMH, ImposterRenderConfig CPJOFLAMJLA, ACNGFHFPIGK NKMNJPJOENL, Vector3 KMHIFBEIBHB, Vector3 FJFFLJCKGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69EEBF0", Offset = "0x69ED7F0", VA = "0x1869EEBF0")]
	private static void ADGLJHNAIMF(GameObject GDPNBFIEOGK, Vector3 MBCHBBCIGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69F0800", Offset = "0x69EF400", VA = "0x1869F0800")]
	private static void OBBLCMOJIEI(GameObject GKHPLJIBDDP, ImposterRenderConfig CPJOFLAMJLA, ACNGFHFPIGK NKMNJPJOENL, [Out] Vector3 APCCFHCOHDC, [Out] Quaternion ADLBEPOMAKD, [Out] float OMGJMEFBLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69F0350", Offset = "0x69EEF50", VA = "0x1869F0350")]
	public static RenderTexture LBAMKMBFBEH(int KPOPMJPAOEJ, int DMHGGENLNJL, RenderTextureFormat HCFPFEPBAJC = RenderTextureFormat.ARGB32, string MIMNMNPDPLP = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct PCEIFEKEGPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public KLIFOCPDGIA PEPLALJCMAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject JMOCEBHPHBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture AMJAKKOPIHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig JMEHEMEHBHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ACNGFHFPIGK ACNGFHFPIGK;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x69F5FA0", Offset = "0x69F4BA0", VA = "0x1869F5FA0")]
			public PCEIFEKEGPK(KLIFOCPDGIA DHNJBCEHKAL, GameObject DNLDHDCOKNJ, RenderTexture LJFIIEDOBMH, ImposterRenderConfig NNIOKMHAMCI, ACNGFHFPIGK NKMNJPJOENL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static DDNFDBHENGF<PCEIFEKEGPK, RenderTexture> HANABFMDNFM;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<PCEIFEKEGPK> IKBHDPGPAOC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int JEIKLIIJBLM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69F20E0", Offset = "0x69F0CE0", VA = "0x1869F20E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69F21F0", Offset = "0x69F0DF0", VA = "0x1869F21F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GDPNBFIEOGK, RenderTexture LJFIIEDOBMH, ImposterRenderConfig CPJOFLAMJLA, ACNGFHFPIGK NKMNJPJOENL, CancellationToken PPKBAEMFIMG, bool FAOMAAOOANE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69F1D00", Offset = "0x69F0900", VA = "0x1869F1D00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69F2150", Offset = "0x69F0D50", VA = "0x1869F2150", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69F1EF0", Offset = "0x69F0AF0", VA = "0x1869F1EF0")]
		private static Task<RenderTexture> JPEELELNBLL(PCEIFEKEGPK BADLNJEAEBH, CancellationToken PPKBAEMFIMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69F2610", Offset = "0x69F1210", VA = "0x1869F2610")]
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
