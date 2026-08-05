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
	private readonly struct GDCOOKBAOKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BMGDFPOFMOM GNCNKBDKAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string NCDEOLGHIJE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
		public GDCOOKBAOKO(BMGDFPOFMOM AJJPDODBNKP, string IBGPAEEEKNO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct HPHHCDHFOJK : IAsyncStateMachine
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
		public GDCOOKBAOKO queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E01170", Offset = "0x6E00570", VA = "0x186E01170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E01530", Offset = "0x6E00930", VA = "0x186E01530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider KBPNDCLOJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PEKJCFNHGBA<GDCOOKBAOKO, GameObject> PAEGBPPHAIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GLKLJFBMKJH PCGDIGDMHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PEKJCFNHGBA<GDCOOKBAOKO, GameObject> KEIJMPBOICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E00690", Offset = "0x6DFFA90", VA = "0x186E00690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HFIDFMGKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E00470", Offset = "0x6DFF870", VA = "0x186E00470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E00270", Offset = "0x6DFF670", VA = "0x186E00270", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E007F0", Offset = "0x6DFFBF0", VA = "0x186E007F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E00350", Offset = "0x6DFF750", VA = "0x186E00350")]
	[AsyncStateMachine(typeof(HPHHCDHFOJK))]
	private Task<GameObject> ELMGOABFLKL(GDCOOKBAOKO JEKCOLFDBKK, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E004C0", Offset = "0x6DFF8C0", VA = "0x186E004C0")]
	public Task<GameObject> LoadItemAsync(BMGDFPOFMOM AJJPDODBNKP, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E00860", Offset = "0x6DFFC60", VA = "0x186E00860")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class LNMLIFNDAFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BMGDFPOFMOM HBCHACHPHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture FCDPELFMJDL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
		public LNMLIFNDAFE(BMGDFPOFMOM FEOPAKFCMHL, Texture NAKFIPIKBBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum JPNFJDKAABP
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
	private class PIGABFEFLCL : MDPHLEPHNGE<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct FEDGNLAHJDD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PIGABFEFLCL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6E008A0", Offset = "0x6DFFCA0", VA = "0x186E008A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6E01090", Offset = "0x6E00490", VA = "0x186E01090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BMGDFPOFMOM FEOPAKFCMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BAHOLLCLDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig FKGBNHJADNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken NBBCMDKGJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D CPDIODAKOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject EGINAANCAIF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MJGAHFINLMO<Texture2D> GAFMPDKNOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6E05290", Offset = "0x6E04690", VA = "0x186E05290", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> DNFJJDIKMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E052F0", Offset = "0x6E046F0", VA = "0x186E052F0")]
		public PIGABFEFLCL(BMGDFPOFMOM FEOPAKFCMHL, RenderTexture BAHOLLCLDKG, ImposterRenderConfig FKGBNHJADNH, CancellationToken NBBCMDKGJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E05170", Offset = "0x6E04570", VA = "0x186E05170")]
		[AsyncStateMachine(typeof(FEDGNLAHJDD))]
		private Task<Texture2D> ENJPEJCCDIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E05260", Offset = "0x6E04660", VA = "0x186E05260", Slot = "10")]
		protected override void JHLJDCFNHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E050F0", Offset = "0x6E044F0", VA = "0x186E050F0")]
		private static void DBGHJABOMIC(GameObject EGINAANCAIF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AGOKPDOFAFM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6DFEED0", Offset = "0x6DFE2D0", VA = "0x186DFEED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
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
	[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private JPNFJDKAABP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[EPNICGNCAPF("size", JPNFJDKAABP.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int KBMHJGFGMLE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture ABEGNCLEPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MOILIIFOJBA<GameObject> ANOMJBMEJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private OIBEFKNOBGF ILHPNGCKBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource INALIICJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GHMLKDLFDEG<Texture2D> LHCFLAADKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BMGDFPOFMOM BKHEEHGJOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture AEOMPNCCEGO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LGAGFPAKNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E024F0", Offset = "0x6E018F0", VA = "0x186E024F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E02540", Offset = "0x6E01940", VA = "0x186E02540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture FMAMHJNDFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E01C60", Offset = "0x6E01060", VA = "0x186E01C60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA40", Offset = "0x8ACE40", VA = "0x1808ADA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BMGDFPOFMOM HBCHACHPHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB00", Offset = "0x8ABF00", VA = "0x1808ACB00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E01EC0", Offset = "0x6E012C0", VA = "0x186E01EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool COBBMPJJJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1A5A350", Offset = "0x1A59750", VA = "0x181A5A350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int LDIGPLLOGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E01BD0", Offset = "0x6E00FD0", VA = "0x186E01BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E01AD0", Offset = "0x6E00ED0", VA = "0x186E01AD0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E020D0", Offset = "0x6E014D0", VA = "0x186E020D0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E01E40", Offset = "0x6E01240", VA = "0x186E01E40")]
	private void FMCLLJJAKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E02410", Offset = "0x6E01810", VA = "0x186E02410")]
	public void Set(BMGDFPOFMOM KCDCMJGPOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E02400", Offset = "0x6E01800", VA = "0x186E02400")]
	public void Set(Texture NAKFIPIKBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E023C0", Offset = "0x6E017C0", VA = "0x186E023C0")]
	public void Set(LNMLIFNDAFE EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E01BC0", Offset = "0x6E00FC0", VA = "0x186E01BC0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E021D0", Offset = "0x6E015D0", VA = "0x186E021D0")]
	public void SetInternal(BMGDFPOFMOM KCDCMJGPOJM, [Optional] Texture KJIONINAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E021C0", Offset = "0x6E015C0", VA = "0x186E021C0")]
	public void SetCustomSize(int NMIMFPKFIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8A0", Offset = "0x8ACCA0", VA = "0x1808AD8A0")]
	public void SetAntiAliasing(int FACJDIBFLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E02020", Offset = "0x6E01420", VA = "0x186E02020")]
	[AsyncStateMachine(typeof(AGOKPDOFAFM))]
	private void NDOKDAMDCBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E01AE0", Offset = "0x6E00EE0", VA = "0x186E01AE0")]
	private void BINNCGGIFLN(Texture NAKFIPIKBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E02470", Offset = "0x6E01870", VA = "0x186E02470")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LDMDPHDHBFO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float PDMPJDCKCHD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	public void PrepareImposter(EMJCENFDLGK BJGOCALJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E01A90", Offset = "0x6E00E90", VA = "0x186E01A90")]
	public void SetReferencePoint(Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E018A0", Offset = "0x6E00CA0", VA = "0x186E018A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E01A70", Offset = "0x6E00E70", VA = "0x186E01A70")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x18D50F0", Offset = "0x18D44F0", VA = "0x1818D50F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NCHEMONPJIN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static NCHEMONPJIN KAMMIAJFDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float JFJMAEPFNLG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x23E7010", Offset = "0x23E6410", VA = "0x1823E7010")]
	public NCHEMONPJIN(float JNAINHCEICD)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E05760", Offset = "0x6E04B60", VA = "0x186E05760", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
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
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int HJJPLMNMJGB = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int AIOCOAPEDGK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> GBAOBMMEPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool FJHDCGAOJLH;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E02740", Offset = "0x6E01B40", VA = "0x186E02740")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E02640", Offset = "0x6E01A40", VA = "0x186E02640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E02990", Offset = "0x6E01D90", VA = "0x186E02990")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BMGDFPOFMOM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DJHLGIGGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NCHEMONPJIN NCHEMONPJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MKCIKFPCAJC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DPFBEFJAALJ(CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FDELDPDKIIG(BMGDFPOFMOM KNLMODPGFOA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKOFBIBGNBF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGGPFGBJBKN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BMNFIOCOKKK(uint? KMPEBFALCDF, [Out] GHMLKDLFDEG<Texture2D> GGLGOKJCHFK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NJAFDPDMACP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E05010", Offset = "0x6E04410", VA = "0x186E05010")]
	public static bool DELKGOOOJLD(BMGDFPOFMOM LIEFBAJMOGO, BMGDFPOFMOM PNLPJIDENLP)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, LDMDPHDHBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DFF710", Offset = "0x6DFEB10", VA = "0x186DFF710", Slot = "4")]
		public void PrepareImposter(EMJCENFDLGK BJGOCALJFKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LDMDPHDHBFO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EMJCENFDLGK BJGOCALJFKP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LCGJJKKELDB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> AAMAKAJGCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BMDIAEOAIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GLKLJFBMKJH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OANKBAMEOHB(params Type[] GJPEPGIOJEJ);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KLKDJJJBABC(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, bool ADADFGPJIJF = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KLKDJJJBABC<T>(T HMDADBIJECG, Transform DEDHJMDEEIE, bool ADADFGPJIJF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T KLKDJJJBABC<T>(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, bool ADADFGPJIJF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject KLKDJJJBABC(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, EMJCENFDLGK BJGOCALJFKP, bool ADADFGPJIJF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AFBHMPMAMNI : IDisposable, GLKLJFBMKJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> MKFLNLHCAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> BPKOLEAPFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform KOHBPFMDADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> AAAEIHNDICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CBEJIKHGKJD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE330", Offset = "0x6DFD730", VA = "0x186DFE330")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	public static void MHNICLDHNFP(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DFEA90", Offset = "0x6DFDE90", VA = "0x186DFEA90")]
	[UnityEngine.Scripting.Preserve]
	public AFBHMPMAMNI([CCLHMIDBCEM(null)] LCGJJKKELDB FFOLMFJGBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE020", Offset = "0x6DFD420", VA = "0x186DFE020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE420", Offset = "0x6DFD820", VA = "0x186DFE420", Slot = "5")]
	public void OANKBAMEOHB(params Type[] GJPEPGIOJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE210", Offset = "0x6DFD610", VA = "0x186DFE210", Slot = "6")]
	public GameObject KLKDJJJBABC(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, bool ADADFGPJIJF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35880A0", Offset = "0x35874A0", VA = "0x1835880A0", Slot = "7")]
	public T KLKDJJJBABC<T>(T HMDADBIJECG, Transform DEDHJMDEEIE, bool ADADFGPJIJF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3588050", Offset = "0x3587450", VA = "0x183588050", Slot = "8")]
	public T KLKDJJJBABC<T>(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, bool ADADFGPJIJF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE2A0", Offset = "0x6DFD6A0", VA = "0x186DFE2A0", Slot = "9")]
	public GameObject KLKDJJJBABC(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, EMJCENFDLGK BJGOCALJFKP, bool ADADFGPJIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3587A70", Offset = "0x3586E70", VA = "0x183587A70", Slot = "10")]
	public T KLKDJJJBABC<T>(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, EMJCENFDLGK BJGOCALJFKP, bool ADADFGPJIJF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3587AD0", Offset = "0x3586ED0", VA = "0x183587AD0")]
	private T KLKDJJJBABC<T>(GameObject HMDADBIJECG, Transform DEDHJMDEEIE, EMJCENFDLGK BJGOCALJFKP, bool ADADFGPJIJF, [Out] GameObject JLDIIJFIKDI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x35875D0", Offset = "0x35869D0", VA = "0x1835875D0")]
	private T IEIBDLFEEAG<T>(GameObject BCDDMHHPJBD, EMJCENFDLGK BJGOCALJFKP, bool ADADFGPJIJF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE100", Offset = "0x6DFD500", VA = "0x186DFE100")]
	private void IPBKMAJAHJH(Component GKPPNECBJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE5E0", Offset = "0x6DFD9E0", VA = "0x186DFE5E0")]
	private void PFLFGEJHPNJ(Component GKPPNECBJFF, EMJCENFDLGK BJGOCALJFKP, bool ADADFGPJIJF, bool GCCCPDLHKDC, [Optional] Type IBOGDHOLBKA, [Optional] Type IKAOELFDBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6DFE470", Offset = "0x6DFD870", VA = "0x186DFE470")]
	private void PBOKLHHLGBJ(GameObject BCDDMHHPJBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EMJCENFDLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> BCNBCDFMADJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3EC0", Offset = "0x2CD32C0", VA = "0x182CD3EC0")]
	public EMJCENFDLGK MCAKFOHFDBM<T>(T LKOOAODEDEM)
	{
		return default(EMJCENFDLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD35D0", Offset = "0x2CD29D0", VA = "0x182CD35D0")]
	public T CADKKGPFCDD<T>(T BMLEAJPEFAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD36E0", Offset = "0x2CD2AE0", VA = "0x182CD36E0")]
	public bool FAKKNFFMHEG<T>([Out] T LKOOAODEDEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EPGNNOALOOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool MHLOEGECNIJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23E8990", Offset = "0x23E7D90", VA = "0x1823E8990")]
	public EPGNNOALOOO(bool PBFEACAANJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LMGEAENFNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool NHJOBOLBBFE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E04F90", Offset = "0x6E04390", VA = "0x186E04F90")]
	public LMGEAENFNIJ(bool KEOICPJEDBJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, LDMDPHDHBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E054B0", Offset = "0x6E048B0", VA = "0x186E054B0", Slot = "4")]
		public void PrepareImposter(EMJCENFDLGK BJGOCALJFKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
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
		public Bounds BFMGLMBEBII
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6E01710", Offset = "0x6E00B10", VA = "0x186E01710")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E016D0", Offset = "0x6E00AD0", VA = "0x186E016D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E01690", Offset = "0x6E00A90", VA = "0x186E01690")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E015A0", Offset = "0x6E009A0", VA = "0x186E015A0")]
		private void HLCANFNLAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
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
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6E04FB0", Offset = "0x6E043B0", VA = "0x186E04FB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E04FA0", Offset = "0x6E043A0", VA = "0x186E04FA0")]
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
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E025B0", Offset = "0x6E019B0", VA = "0x186E025B0")]
		public void HLBHJDPKEFB(Vector3 HEILLAOEIGM, Quaternion OBKAKPFLPEG, float GCKJHKBJOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E025E0", Offset = "0x6E019E0", VA = "0x186E025E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KBMFFPELHPA
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly Vector3 JKOAOLFHAFF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<URPLight> AAEBMOIKPKB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly List<Light> DJKBHLDJJEB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Camera HCKFOALAPEM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<Renderer> BBDIGOKGJCN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly List<ImposterBoundsOverride> OEKOEPAPKGO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static AmbientMode LFPAIILHIDC;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color LCLMFONMMHO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color BJDEPAGPLPF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Color FJGOLEEFMAK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static Cubemap EIABEHKFLEJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static bool BIHPMIOBNKJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> ACOMAOHGAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E03B60", Offset = "0x6E02F60", VA = "0x186E03B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> KKBAAEHPJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E038E0", Offset = "0x6E02CE0", VA = "0x186E038E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera ODFNBLJOBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E03930", Offset = "0x6E02D30", VA = "0x186E03930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E03ED0", Offset = "0x6E032D0", VA = "0x186E03ED0")]
	public static void LMAINLHNPJE(Vector3 FLEHFAJDAMO, Quaternion PDDEIKDOHHA, ImposterRenderConfig IFPKGMPMJPB, bool NLCOABKNGJI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E03BB0", Offset = "0x6E02FB0", VA = "0x186E03BB0")]
	private static void JNGKCJACEGC(Vector3 FLEHFAJDAMO, Quaternion PDDEIKDOHHA, URPLight LHJLBNIIHHA, ImposterRenderConfig.LightConfig GEFFGJBAJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E03540", Offset = "0x6E02940", VA = "0x186E03540")]
	public static void DOANACFGIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E02A20", Offset = "0x6E01E20", VA = "0x186E02A20")]
	private static void AAKHNPMCDPC(int CMFMMJDIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E04160", Offset = "0x6E03560", VA = "0x186E04160")]
	public static void MKAHNCIKMIP(ImposterRenderConfig IFPKGMPMJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E04960", Offset = "0x6E03D60", VA = "0x186E04960")]
	public static void NIBLLLDNHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E04A40", Offset = "0x6E03E40", VA = "0x186E04A40")]
	public static void OICFKIOGEHF(GameObject CJJGDIDMJIE, RenderTexture BAHOLLCLDKG, ImposterRenderConfig IFPKGMPMJPB, NCHEMONPJIN FKBNMPCEGPG, [Optional] Vector3? OAEIDPFAKKG, [Optional] Vector3? OGLIPCDOHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E02F10", Offset = "0x6E02310", VA = "0x186E02F10")]
	private static void DGMNHFADMHB(GameObject CJJGDIDMJIE, RenderTexture BAHOLLCLDKG, ImposterRenderConfig IFPKGMPMJPB, NCHEMONPJIN FKBNMPCEGPG, Vector3 OAEIDPFAKKG, Vector3 OGLIPCDOHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E03620", Offset = "0x6E02A20", VA = "0x186E03620")]
	private static void EMNCCKBCBCG(GameObject CJJGDIDMJIE, Vector3 OCILILOOCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E04310", Offset = "0x6E03710", VA = "0x186E04310")]
	private static void MKJHDNMEDAJ(GameObject HMDADBIJECG, ImposterRenderConfig IFPKGMPMJPB, NCHEMONPJIN FKBNMPCEGPG, [Out] Vector3 JOEJMEEKACJ, [Out] Quaternion PBDLHAJAFHK, [Out] float DKBLKBKEPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E02E40", Offset = "0x6E02240", VA = "0x186E02E40")]
	public static RenderTexture BOEBJFINDHM(int MPCPDNDCONE, int GHAMDAHJBAG, RenderTextureFormat BIFHNMDIJFJ = RenderTextureFormat.ARGB32, string GDNDOOKLBLL = "[ImposterRendering]Preview")
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
		public struct GNCINOIANEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public NEDBBCCLALH KDONECDDKMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GameObject CEGFCHDIIHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RenderTexture FMAMHJNDFLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ImposterRenderConfig NCLFBAKEIOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public NCHEMONPJIN NCHEMONPJIN;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6E01100", Offset = "0x6E00500", VA = "0x186E01100")]
			public GNCINOIANEG(NEDBBCCLALH DNDANBIPKHK, GameObject IJMFEBEIKLP, RenderTexture BAHOLLCLDKG, ImposterRenderConfig FKGBNHJADNH, NCHEMONPJIN FKBNMPCEGPG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static PEKJCFNHGBA<GNCINOIANEG, RenderTexture> FDIHALBOEJI;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly List<GNCINOIANEG> IMILIAGIJDK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int IPHGGMBLLAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6DFFD10", Offset = "0x6DFF110", VA = "0x186DFFD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6DFFE30", Offset = "0x6DFF230", VA = "0x186DFFE30")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CJJGDIDMJIE, RenderTexture BAHOLLCLDKG, ImposterRenderConfig IFPKGMPMJPB, NCHEMONPJIN FKBNMPCEGPG, CancellationToken NBBCMDKGJKI, bool MMPJKJJDCJD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6DFF860", Offset = "0x6DFEC60", VA = "0x186DFF860", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6DFFDA0", Offset = "0x6DFF1A0", VA = "0x186DFFDA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6DFFA70", Offset = "0x6DFEE70", VA = "0x186DFFA70")]
		private static Task<RenderTexture> HCGMPNNLELH(GNCINOIANEG BGEOPBKMOMM, CancellationToken NBBCMDKGJKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E00230", Offset = "0x6DFF630", VA = "0x186E00230")]
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
