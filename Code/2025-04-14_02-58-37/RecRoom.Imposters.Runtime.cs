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
	private readonly struct FFAEPJIAJCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly LJCKONKDGGE BJMJPHAHJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string EOBMKMINNFJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
		public FFAEPJIAJCG(LJCKONKDGGE NHCMOEDLEPA, string HNBKFLJPFAC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct LHPMHKHMICM : IAsyncStateMachine
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
		public FFAEPJIAJCG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7945B10", Offset = "0x7944510", VA = "0x187945B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7945ED0", Offset = "0x79448D0", VA = "0x187945ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider MHLCFMMJOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ODMCGKBIDML<FFAEPJIAJCG, GameObject> JGAIFHDJAGO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FCFJLFAEDNP KBPMDCDPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ODMCGKBIDML<FFAEPJIAJCG, GameObject> IAOAGLMLPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7942F50", Offset = "0x7941950", VA = "0x187942F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int NJKIADALEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7942D00", Offset = "0x7941700", VA = "0x187942D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7942D50", Offset = "0x7941750", VA = "0x187942D50", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7943280", Offset = "0x7941C80", VA = "0x187943280", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7942E30", Offset = "0x7941830", VA = "0x187942E30")]
	[AsyncStateMachine(typeof(LHPMHKHMICM))]
	private Task<GameObject> CNIMIGIIMFF(FFAEPJIAJCG JEONDMONKHP, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79430B0", Offset = "0x7941AB0", VA = "0x1879430B0")]
	public Task<GameObject> LoadItemAsync(LJCKONKDGGE NHCMOEDLEPA, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79432F0", Offset = "0x7941CF0", VA = "0x1879432F0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NLJPAOFIIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LJCKONKDGGE KCLNCDHDMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture KEPCJJCBHEJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
		public NLJPAOFIIMM(LJCKONKDGGE JPBPNJMKNKK, Texture IACCMECBPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AOCMHGJEGCM
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
	private class EOPKEDCECCB : NPLKCODGFBP<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct MNPDKCINMEE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EOPKEDCECCB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7948700", Offset = "0x7947100", VA = "0x187948700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7948EF0", Offset = "0x79478F0", VA = "0x187948EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LJCKONKDGGE JPBPNJMKNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture CAFFLIBCCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig DEBFPGAAEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken BJEPDCCBCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D ACAOIKBCNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject MHNBKFFKKAP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override ECHAPNAJEJF<Texture2D> OGFOLAGDOLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7943330", Offset = "0x7941D30", VA = "0x187943330", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> BBNIIHNELDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7943530", Offset = "0x7941F30", VA = "0x187943530")]
		public EOPKEDCECCB(LJCKONKDGGE JPBPNJMKNKK, RenderTexture CAFFLIBCCFD, ImposterRenderConfig DEBFPGAAEFC, CancellationToken BJEPDCCBCHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7943410", Offset = "0x7941E10", VA = "0x187943410")]
		[AsyncStateMachine(typeof(MNPDKCINMEE))]
		private Task<Texture2D> JAOHGEGCIGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7943500", Offset = "0x7941F00", VA = "0x187943500", Slot = "10")]
		protected override void MMDAGHKNPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7943390", Offset = "0x7941D90", VA = "0x187943390")]
		private static void HFODACPCPBH(GameObject MHNBKFFKKAP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BBHIGDPEEMM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7941920", Offset = "0x7940320", VA = "0x187941920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
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
	[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private AOCMHGJEGCM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[FGDKCCGIKGN("size", AOCMHGJEGCM.Custom)]
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
	private static int MAGFLDBLLCJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture LFCNHPJKMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private BJCPIOCOJFP<GameObject> NANPFGIGOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FDJPMDOFNPO EBGMDMIPBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource DBBALKKKOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private PHLGPCMBMIF<Texture2D> NJJPLANAEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private LJCKONKDGGE BIICIJEFBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture BKEALLJIKKA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int CJJCAENENHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7944640", Offset = "0x7943040", VA = "0x187944640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7944690", Offset = "0x7943090", VA = "0x187944690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture IIKCINPKDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7943CC0", Offset = "0x79426C0", VA = "0x187943CC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9AED80", Offset = "0x9AD780", VA = "0x1809AED80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LJCKONKDGGE KCLNCDHDMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4C0", Offset = "0x9AAEC0", VA = "0x1809AC4C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7943F50", Offset = "0x7942950", VA = "0x187943F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DGLDLBEIEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2084E20", Offset = "0x2083820", VA = "0x182084E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DPJJJMHKBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x79440B0", Offset = "0x7942AB0", VA = "0x1879440B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7943C20", Offset = "0x7942620", VA = "0x187943C20")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7944140", Offset = "0x7942B40", VA = "0x187944140")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7943C40", Offset = "0x7942640", VA = "0x187943C40")]
	private void DJFKOIEHHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7944560", Offset = "0x7942F60", VA = "0x187944560")]
	public void Set(LJCKONKDGGE JJDFOEKPBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7944510", Offset = "0x7942F10", VA = "0x187944510")]
	public void Set(Texture IACCMECBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7944520", Offset = "0x7942F20", VA = "0x187944520")]
	public void Set(NLJPAOFIIMM PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7943C30", Offset = "0x7942630", VA = "0x187943C30")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7944320", Offset = "0x7942D20", VA = "0x187944320")]
	public void SetInternal(LJCKONKDGGE JJDFOEKPBHF, [Optional] Texture KENNCGKPEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7944310", Offset = "0x7942D10", VA = "0x187944310")]
	public void SetCustomSize(int MKGFLOGNDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9B6FE0", Offset = "0x9B59E0", VA = "0x1809B6FE0")]
	public void SetAntiAliasing(int ODAPMEDMAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7943EA0", Offset = "0x79428A0", VA = "0x187943EA0")]
	[AsyncStateMachine(typeof(BBHIGDPEEMM))]
	private void HGANHEDKNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7944230", Offset = "0x7942C30", VA = "0x187944230")]
	private void PGJFCIGGPBN(Texture IACCMECBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79445C0", Offset = "0x7942FC0", VA = "0x1879445C0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, BEJEMKPGPLL
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float IFFLHPMNPIO = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public void PrepareImposter(GHJHNJMLEAJ KHABEFHMCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7943BE0", Offset = "0x79425E0", VA = "0x187943BE0")]
	public void SetReferencePoint(Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79439F0", Offset = "0x79423F0", VA = "0x1879439F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7943BC0", Offset = "0x79425C0", VA = "0x187943BC0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1D67800", Offset = "0x1D66200", VA = "0x181D67800")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BOADLMAKKAN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static BOADLMAKKAN GMDMBNOAPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float HJDFPKBMMKI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28857F0", Offset = "0x28841F0", VA = "0x1828857F0")]
	public BOADLMAKKAN(float EKMPKDGKLIF)
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
		[Cpp2IlInjected.Address(RVA = "0x7949210", Offset = "0x7947C10", VA = "0x187949210", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
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
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MKNPPCNJABP = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BGLJHKBEGLD = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> CENIGKGEKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool FOOGBFDPAOJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79448A0", Offset = "0x79432A0", VA = "0x1879448A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79447A0", Offset = "0x79431A0", VA = "0x1879447A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7944AE0", Offset = "0x79434E0", VA = "0x187944AE0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LJCKONKDGGE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DLGOLOFHJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BOADLMAKKAN BOADLMAKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EDIMFHEBGFB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> IOMJHINCGBI(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ECJCMODFAJM(LJCKONKDGGE OLKLGHOAKNE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPADBHIMNCG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEPLLIGNFLB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PDKIJAJAFCL(uint? EINJOHNMEFN, [Out] PHLGPCMBMIF<Texture2D> HHKFFKKNHMI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LBPHCCCLIAH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7945A30", Offset = "0x7944430", VA = "0x187945A30")]
	public static bool CJLKIJNLOMI(LJCKONKDGGE NGJKMAGNIDH, LJCKONKDGGE PFDMCLMNOAE)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, BEJEMKPGPLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79421A0", Offset = "0x7940BA0", VA = "0x1879421A0", Slot = "4")]
		public void PrepareImposter(GHJHNJMLEAJ KHABEFHMCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BEJEMKPGPLL
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GHJHNJMLEAJ KHABEFHMCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KDEDCEKDFKF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> MENEKBBMDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BJEDMBGBKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FCFJLFAEDNP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKADBOLFOJK(params Type[] FCKODCBNOHD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject CGAEPOIJHDC(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, bool PHEECAFBPND = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T CGAEPOIJHDC<T>(T DEMHLIAEAHH, Transform HGBJMKAPAJA, bool PHEECAFBPND = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T CGAEPOIJHDC<T>(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, bool PHEECAFBPND = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject CGAEPOIJHDC(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, GHJHNJMLEAJ KHABEFHMCBM, bool PHEECAFBPND);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KKLIFACLGKB : IDisposable, FCFJLFAEDNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> PJJEFBBBLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> BHPKFNNEHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform FICEINJDBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> EHLJOMJNBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PGEBCGKLMOH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x79453F0", Offset = "0x7943DF0", VA = "0x1879453F0")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	public static void LMIBOGDHNKD(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79455F0", Offset = "0x7943FF0", VA = "0x1879455F0")]
	[UnityEngine.Scripting.Preserve]
	public KKLIFACLGKB([GJJKIKPKKBJ(null)] KDEDCEKDFKF NADNHDLHKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79452C0", Offset = "0x7943CC0", VA = "0x1879452C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79453A0", Offset = "0x7943DA0", VA = "0x1879453A0", Slot = "5")]
	public void FKADBOLFOJK(params Type[] FCKODCBNOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x79451A0", Offset = "0x7943BA0", VA = "0x1879451A0", Slot = "6")]
	public GameObject CGAEPOIJHDC(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, bool PHEECAFBPND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3716050", Offset = "0x3714A50", VA = "0x183716050", Slot = "7")]
	public T CGAEPOIJHDC<T>(T DEMHLIAEAHH, Transform HGBJMKAPAJA, bool PHEECAFBPND = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37160E0", Offset = "0x3714AE0", VA = "0x1837160E0", Slot = "8")]
	public T CGAEPOIJHDC<T>(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, bool PHEECAFBPND = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7945230", Offset = "0x7943C30", VA = "0x187945230", Slot = "9")]
	public GameObject CGAEPOIJHDC(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, GHJHNJMLEAJ KHABEFHMCBM, bool PHEECAFBPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3715A70", Offset = "0x3714470", VA = "0x183715A70", Slot = "10")]
	public T CGAEPOIJHDC<T>(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, GHJHNJMLEAJ KHABEFHMCBM, bool PHEECAFBPND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3715AD0", Offset = "0x37144D0", VA = "0x183715AD0")]
	private T CGAEPOIJHDC<T>(GameObject DEMHLIAEAHH, Transform HGBJMKAPAJA, GHJHNJMLEAJ KHABEFHMCBM, bool PHEECAFBPND, [Out] GameObject AIEFLAKFHGD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3716130", Offset = "0x3714B30", VA = "0x183716130")]
	private T COGBGJEFHNJ<T>(GameObject IHDAMAGFMLN, GHJHNJMLEAJ KHABEFHMCBM, bool PHEECAFBPND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x79454E0", Offset = "0x7943EE0", VA = "0x1879454E0")]
	private void PLFGAOBKNPM(Component ANAFMCCHAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7944CF0", Offset = "0x79436F0", VA = "0x187944CF0")]
	private void BIKPPEKLDMI(Component ANAFMCCHAKO, GHJHNJMLEAJ KHABEFHMCBM, bool PHEECAFBPND, bool KAOCMOALELC, [Optional] Type FHPPAKJCIKO, [Optional] Type KKKDILKMOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7944B80", Offset = "0x7943580", VA = "0x187944B80")]
	private void APFOJFNGDAB(GameObject IHDAMAGFMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GHJHNJMLEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> LPMNLMMMLDD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x363B600", Offset = "0x363A000", VA = "0x18363B600")]
	public GHJHNJMLEAJ PMHEFKOCJCJ<T>(T KJDJPGMAMEM)
	{
		return default(GHJHNJMLEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x363AD20", Offset = "0x3639720", VA = "0x18363AD20")]
	public T BLCCCENAIKI<T>(T LPJIMLBFHAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x363AE30", Offset = "0x3639830", VA = "0x18363AE30")]
	public bool EHJIJKOKNAC<T>([Out] T KJDJPGMAMEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DMJLKHNFOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool OMKKNBKHCKN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2883870", Offset = "0x2882270", VA = "0x182883870")]
	public DMJLKHNFOFF(bool PHHHFNBMMOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JIDDBGEOONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool FFGOPLGDPKB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7944B70", Offset = "0x7943570", VA = "0x187944B70")]
	public JIDDBGEOONC(bool OOIEKNIAPLD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, BEJEMKPGPLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7948F60", Offset = "0x7947960", VA = "0x187948F60", Slot = "4")]
		public void PrepareImposter(GHJHNJMLEAJ KHABEFHMCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
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
		public Bounds PPOJHBOHLNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7943860", Offset = "0x7942260", VA = "0x187943860")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7943820", Offset = "0x7942220", VA = "0x187943820")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x79437E0", Offset = "0x79421E0", VA = "0x1879437E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x79436F0", Offset = "0x79420F0", VA = "0x1879436F0")]
		private void KCLLNAEGDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
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
				[Cpp2IlInjected.Address(RVA = "0x79486E0", Offset = "0x79470E0", VA = "0x1879486E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x79486D0", Offset = "0x79470D0", VA = "0x1879486D0")]
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
		[FGDKCCGIKGN("frameCameraToImposterBounds", true)]
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
		[FGDKCCGIKGN("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x7944700", Offset = "0x7943100", VA = "0x187944700")]
		public void HAODEMJMGLL(Vector3 APEAKJLPDIC, Quaternion KMMPLIACPPK, float HMMIKGGFNIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7944730", Offset = "0x7943130", VA = "0x187944730")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class LPLMHOBOBKD
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 LEKELCOGICM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> PKIOKKBJPFB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> JAILDJKAJDI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera AIEFFBHCIMB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> NKJANCNCDPE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> EMPGNKJJAAD;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode PMNAKKLGMFJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color APBKIJFOIMG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color PMBEOFEPBMC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color PADKNENCIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap EDOAIFNPGCN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool IFJOEHHDIGK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> IFCODGLGFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7948240", Offset = "0x7946C40", VA = "0x187948240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> IGMECBFOMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7947CC0", Offset = "0x79466C0", VA = "0x187947CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera NKHGJJIDJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7948290", Offset = "0x7946C90", VA = "0x187948290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79474F0", Offset = "0x7945EF0", VA = "0x1879474F0")]
	public static void DIFKFLBLJGJ(Vector3 DAONFMNDHBG, Quaternion JJNPMDFCPPM, ImposterRenderConfig GAMPAGJJHPC, bool JJLAILHNGLB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7946DC0", Offset = "0x79457C0", VA = "0x187946DC0")]
	private static void DEKOHCFIBKH(Vector3 DAONFMNDHBG, Quaternion JJNPMDFCPPM, URPLight CPFEECEEFGG, ImposterRenderConfig.LightConfig DABMKALCKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7947D10", Offset = "0x7946710", VA = "0x187947D10")]
	public static void MAFLOPJGKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x79470E0", Offset = "0x7945AE0", VA = "0x1879470E0")]
	private static void DFDLMDJNAMM(int FHJAJFGCGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7947780", Offset = "0x7946180", VA = "0x187947780")]
	public static void DJGAAEDPOGE(ImposterRenderConfig GAMPAGJJHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7947DF0", Offset = "0x79467F0", VA = "0x187947DF0")]
	public static void MBIKCHGDAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7945F40", Offset = "0x7944940", VA = "0x187945F40")]
	public static void ACHGKPMHMLK(GameObject LNPOLHEEKGK, RenderTexture CAFFLIBCCFD, ImposterRenderConfig GAMPAGJJHPC, BOADLMAKKAN OFBHIIPEEJI, [Optional] Vector3? OMFKJOGCMPL, [Optional] Vector3? KPBAFNOMLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7946790", Offset = "0x7945190", VA = "0x187946790")]
	private static void CDELILPBJLF(GameObject LNPOLHEEKGK, RenderTexture CAFFLIBCCFD, ImposterRenderConfig GAMPAGJJHPC, BOADLMAKKAN OFBHIIPEEJI, Vector3 OMFKJOGCMPL, Vector3 KPBAFNOMLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7947A00", Offset = "0x7946400", VA = "0x187947A00")]
	private static void ILCEIMBLDFO(GameObject LNPOLHEEKGK, Vector3 GMNGBNPEEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7947ED0", Offset = "0x79468D0", VA = "0x187947ED0")]
	public static void MJNMNFIGMCF(Bounds EDAJJFACCKD, ImposterRenderConfig GAMPAGJJHPC, [Out] Vector3 MHJGJHOBOEC, [Out] Quaternion LFJBNLEGJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7946280", Offset = "0x7944C80", VA = "0x187946280")]
	private static void CCHDJDCFEFE(GameObject DEMHLIAEAHH, ImposterRenderConfig GAMPAGJJHPC, BOADLMAKKAN OFBHIIPEEJI, [Out] Vector3 MHJGJHOBOEC, [Out] Quaternion LFJBNLEGJCJ, [Out] float IKPGGPGEDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7947930", Offset = "0x7946330", VA = "0x187947930")]
	public static RenderTexture HLKCLGMFLJO(int FGPAPCDJLPO, int BLEOEDKKBIM, RenderTextureFormat GKPIBGBGJLP = RenderTextureFormat.ARGB32, string GFAJMMKPGDA = "[ImposterRendering]Preview")
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
		public struct AHBDJLKCGIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public BLCIPFELIOL KCBHNJKKDIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject KAIBDKKMIHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture IIKCINPKDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig OPGPDJGAMGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public BOADLMAKKAN BOADLMAKKAN;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x79418B0", Offset = "0x79402B0", VA = "0x1879418B0")]
			public AHBDJLKCGIO(BLCIPFELIOL NEMOMCDJPID, GameObject MAMHFDCJGIO, RenderTexture CAFFLIBCCFD, ImposterRenderConfig DEBFPGAAEFC, BOADLMAKKAN OFBHIIPEEJI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static ODMCGKBIDML<AHBDJLKCGIO, RenderTexture> GMOGEHMIHNE;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<AHBDJLKCGIO> LNHJELJBGCN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MIJAEPMNOME
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7942500", Offset = "0x7940F00", VA = "0x187942500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x79428C0", Offset = "0x79412C0", VA = "0x1879428C0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LNPOLHEEKGK, RenderTexture CAFFLIBCCFD, ImposterRenderConfig GAMPAGJJHPC, BOADLMAKKAN OFBHIIPEEJI, CancellationToken BJEPDCCBCHJ, bool GCKKJHAJOJK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x79422F0", Offset = "0x7940CF0", VA = "0x1879422F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7942830", Offset = "0x7941230", VA = "0x187942830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7942590", Offset = "0x7940F90", VA = "0x187942590")]
		private static Task<RenderTexture> LDIMIAEDMMJ(AHBDJLKCGIO ABMJLKFEFBI, CancellationToken BJEPDCCBCHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7942CC0", Offset = "0x79416C0", VA = "0x187942CC0")]
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
