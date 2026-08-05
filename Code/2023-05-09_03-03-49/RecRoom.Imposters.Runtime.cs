using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
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
	private readonly struct NNBECEFHPGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ODMDLFGHNND NFIAEAKHFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string ADHOEHCIAKH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC33810", Offset = "0xC32210", VA = "0x180C33810")]
		public NNBECEFHPGB(ODMDLFGHNND MGEHOPGOPOA, string AKMIILGDJDF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FBIBGNOHNHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NNBECEFHPGB queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8250", Offset = "0x1CF6C50", VA = "0x181CF8250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8590", Offset = "0x1CF6F90", VA = "0x181CF8590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider CMOLFEONBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::CGBPKHNPMDG<NNBECEFHPGB, GameObject> DJLPDOCFMEJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EAMOCJELKNB BEABMBEDKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::CGBPKHNPMDG<NNBECEFHPGB, GameObject> GPHEGNNEPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7D80", Offset = "0x1CF6780", VA = "0x181CF7D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int GEOIADPGPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1CF80B0", Offset = "0x1CF6AB0", VA = "0x181CF80B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7B80", Offset = "0x1CF6580", VA = "0x181CF7B80", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8100", Offset = "0x1CF6B00", VA = "0x181CF8100", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7C30", Offset = "0x1CF6630", VA = "0x181CF7C30")]
	[AsyncStateMachine(typeof(FBIBGNOHNHM))]
	private Task<GameObject> BECCFILIGAG(NNBECEFHPGB NNJKHOIMIME, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7EE0", Offset = "0x1CF68E0", VA = "0x181CF7EE0")]
	public Task<GameObject> LoadItemAsync(ODMDLFGHNND MGEHOPGOPOA, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8170", Offset = "0x1CF6B70", VA = "0x181CF8170")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class JPKCIPIPFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ODMDLFGHNND FOMGAOFFKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture OMDJHBKHLPK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84CDF0", Offset = "0x84B7F0", VA = "0x18084CDF0")]
		public JPKCIPIPFNN(ODMDLFGHNND LHCNPBCCPON, Texture FFPBBECLOCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ABMABOBJNLH
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class OCFOLBNPGBL : global::CMDAMFNAEHI<Texture>, KOAFDOGMAPI, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct HCCFCDKKKHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public OCFOLBNPGBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1CF85E0", Offset = "0x1CF6FE0", VA = "0x181CF85E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF8CE0", Offset = "0x1CF76E0", VA = "0x181CF8CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly ODMDLFGHNND LHCNPBCCPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture HLPCLJNMDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig PLKDGLIGGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken FAPLHFKLMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject ABEIHAHKPEN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OFEHPCFKLFI GMECCKJOKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1CFC6E0", Offset = "0x1CFB0E0", VA = "0x181CFC6E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::DJAOLOOILHN<Texture> LKJCOMJKBMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1CFC600", Offset = "0x1CFB000", VA = "0x181CFC600", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task PGDLACEFEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> FNAPLPLPCMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1CFC6F0", Offset = "0x1CFB0F0", VA = "0x181CFC6F0")]
		public OCFOLBNPGBL(ODMDLFGHNND LHCNPBCCPON, RenderTexture HLPCLJNMDJF, ImposterRenderConfig PLKDGLIGGBD, CancellationToken FAPLHFKLMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1CFC4D0", Offset = "0x1CFAED0", VA = "0x181CFC4D0")]
		[AsyncStateMachine(typeof(HCCFCDKKKHH))]
		private Task<Texture> ADEBPHBNBMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1CFC5F0", Offset = "0x1CFAFF0", VA = "0x181CFC5F0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1CFC650", Offset = "0x1CFB050", VA = "0x181CFC650")]
		private static void MMNNJEOIDFC(GameObject ABEIHAHKPEN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CJLGOGFIOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF6960", Offset = "0x1CF5360", VA = "0x181CF6960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x93AE70", Offset = "0x939870", VA = "0x18093AE70", Slot = "5")]
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
	[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private ABMABOBJNLH size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[EAIPBFEGLOF("size", 0)]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private RenderTexture PNEAHDNOGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::HHPFOELKKHI<GameObject> OOOLPIIEFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FNGFMMGLOOC AFGOKLCCGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource PHAHKIOMFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::CMDAMFNAEHI<Texture> JAMMDHBEBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private ODMDLFGHNND FGGEEFLFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture IECLIFBJGBG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture OADGIGPOHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9310", Offset = "0x1CF7D10", VA = "0x181CF9310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x878100", Offset = "0x876B00", VA = "0x180878100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private ODMDLFGHNND FOMGAOFFKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1CF90C0", Offset = "0x1CF7AC0", VA = "0x181CF90C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PGJDEEAGFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1191430", Offset = "0x118FE30", VA = "0x181191430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int GDGCKOICGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9210", Offset = "0x1CF7C10", VA = "0x181CF9210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1CF90A0", Offset = "0x1CF7AA0", VA = "0x181CF90A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9480", Offset = "0x1CF7E80", VA = "0x181CF9480")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9010", Offset = "0x1CF7A10", VA = "0x181CF9010")]
	private void ALPICOFMLHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1CF97A0", Offset = "0x1CF81A0", VA = "0x181CF97A0")]
	public void Set(ODMDLFGHNND GAPKKLHFJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1CF97B0", Offset = "0x1CF81B0", VA = "0x181CF97B0")]
	public void Set(Texture FFPBBECLOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1CF97C0", Offset = "0x1CF81C0", VA = "0x181CF97C0")]
	public void Set(JPKCIPIPFNN MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1CF90B0", Offset = "0x1CF7AB0", VA = "0x181CF90B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9580", Offset = "0x1CF7F80", VA = "0x181CF9580")]
	public void SetInternal(ODMDLFGHNND GAPKKLHFJOC, [Optional] Texture JCOFPNODMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9570", Offset = "0x1CF7F70", VA = "0x181CF9570")]
	public void SetCustomSize(int JILEAMEKJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8EDEE0", Offset = "0x8EC8E0", VA = "0x1808EDEE0")]
	public void SetAntiAliasing(int AFLBJOIMJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8F40", Offset = "0x1CF7940", VA = "0x181CF8F40")]
	[AsyncStateMachine(typeof(CJLGOGFIOOK))]
	private void AAIHIMOCPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9220", Offset = "0x1CF7C20", VA = "0x181CF9220")]
	private void NFDCACBMNLK(Texture FFPBBECLOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9800", Offset = "0x1CF8200", VA = "0x181CF9800")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, PIKEECFDMPG
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float JMAFFDBHNHJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "4")]
	public void PrepareImposter(MFCFHNOJFDK PJBJFAJEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8F00", Offset = "0x1CF7900", VA = "0x181CF8F00")]
	public void SetReferencePoint(Vector3 OPILFLDGFGA, Quaternion PLKNLINIEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8D70", Offset = "0x1CF7770", VA = "0x181CF8D70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8ED0", Offset = "0x1CF78D0", VA = "0x181CF8ED0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x19C7B20", Offset = "0x19C6520", VA = "0x1819C7B20")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IACGIKCOBBI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static IACGIKCOBBI PIJOJHMAHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float KNPFDKOHOCN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x855300", Offset = "0x853D00", VA = "0x180855300")]
	public IACGIKCOBBI(float HOGGPPOCOKF)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int CCILKJGICEH = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int KHDKBJDNLIA = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> DNOHDNLENJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool JJHEOKOCCOA;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1CF99B0", Offset = "0x1CF83B0", VA = "0x181CF99B0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1CF98C0", Offset = "0x1CF82C0", VA = "0x181CF98C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9BF0", Offset = "0x1CF85F0", VA = "0x181CF9BF0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ODMDLFGHNND
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string OONGEPCMFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IACGIKCOBBI IACGIKCOBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IEHEHENFBFE;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> PCMPMJDIBID(CancellationToken FAPLHFKLMOL);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JGENFHMDEEO(ODMDLFGHNND EHBPAFKHADK);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFEGHPFLNHL();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMMEJPLMFKN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ICBMALMGBGA(out global::CMDAMFNAEHI<Texture> MHMKLOBCNJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NNKHDDLIOOH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC3E0", Offset = "0x1CFADE0", VA = "0x181CFC3E0")]
	public static bool JCPJHPPAIFD(ODMDLFGHNND OALLPLGCAKG, ODMDLFGHNND MIPCCENDGAL)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, PIKEECFDMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1CF70F0", Offset = "0x1CF5AF0", VA = "0x181CF70F0", Slot = "4")]
		public void PrepareImposter(MFCFHNOJFDK PJBJFAJEGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PIKEECFDMPG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(MFCFHNOJFDK PJBJFAJEGCC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KFAAMCHDGCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> DJKJCDCLEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> FIDNDMKPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EAMOCJELKNB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFBLHNPDHFM(params Type[] AEENEACHPOE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPJLMHCBPKD(params Type[] AEENEACHPOE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject JPCFDADIABH(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, bool OBHCHFICBGO = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JPCFDADIABH<T>(T INOMEBNKFPO, Transform EOBFGLJBCIJ, bool OBHCHFICBGO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T JPCFDADIABH<T>(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, bool OBHCHFICBGO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JPCFDADIABH(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T JPCFDADIABH<T>(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T JPCFDADIABH<T>(T INOMEBNKFPO, Transform EOBFGLJBCIJ, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PGAABHGDLJG : IDisposable, EAMOCJELKNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> GGIEJCHDNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> ICFJAELMIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform NPDCILAFFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> IDKJFGNKBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> FHGOJKJEPLN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC890", Offset = "0x1CFB290", VA = "0x181CFC890")]
	[MBJLKJLIAAH(JDACKNHLALI.None)]
	public static void AECLFLMFJEA(DPALDOJEBJE GCADPHBJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD420", Offset = "0x1CFBE20", VA = "0x181CFD420")]
	[Preserve]
	public PGAABHGDLJG([PDHOKDIGCJO(null)] KFAAMCHDGCC KJOMGLCOOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC9D0", Offset = "0x1CFB3D0", VA = "0x181CFC9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD020", Offset = "0x1CFBA20", VA = "0x181CFD020", Slot = "5")]
	public void HFBLHNPDHFM(params Type[] AEENEACHPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC980", Offset = "0x1CFB380", VA = "0x181CFC980", Slot = "6")]
	public void CPJLMHCBPKD(params Type[] AEENEACHPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD1A0", Offset = "0x1CFBBA0", VA = "0x181CFD1A0", Slot = "7")]
	public GameObject JPCFDADIABH(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, bool OBHCHFICBGO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x393C4F0", Offset = "0x393AEF0", VA = "0x18393C4F0", Slot = "8")]
	public T JPCFDADIABH<T>(T INOMEBNKFPO, Transform EOBFGLJBCIJ, bool OBHCHFICBGO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x393C4C0", Offset = "0x393AEC0", VA = "0x18393C4C0", Slot = "9")]
	public T JPCFDADIABH<T>(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, bool OBHCHFICBGO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD230", Offset = "0x1CFBC30", VA = "0x181CFD230", Slot = "10")]
	public GameObject JPCFDADIABH(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x393C560", Offset = "0x393AF60", VA = "0x18393C560", Slot = "11")]
	public T JPCFDADIABH<T>(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x393C5B0", Offset = "0x393AFB0", VA = "0x18393C5B0", Slot = "12")]
	public T JPCFDADIABH<T>(T INOMEBNKFPO, Transform EOBFGLJBCIJ, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x393C640", Offset = "0x393B040", VA = "0x18393C640")]
	private T JPCFDADIABH<T>(GameObject INOMEBNKFPO, Transform EOBFGLJBCIJ, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO, out GameObject OLNCNPJOAFA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x393BF60", Offset = "0x393A960", VA = "0x18393BF60")]
	private T GJBEKAPFDHF<T>(GameObject OJBDJCCAFCN, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD070", Offset = "0x1CFBA70", VA = "0x181CFD070")]
	private void JJFNIINJMKF(Component DHGNJCDIFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCAD0", Offset = "0x1CFB4D0", VA = "0x181CFCAD0")]
	private void GOGGPBJECJO(Component DHGNJCDIFDM, MFCFHNOJFDK PJBJFAJEGCC, bool OBHCHFICBGO, bool IBDPFEKABNP, [Optional] Type EAAAPKMPPCE, [Optional] Type JHHAHNAELKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD2C0", Offset = "0x1CFBCC0", VA = "0x181CFD2C0")]
	private void MOLFLDJAIEG(GameObject OJBDJCCAFCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MFCFHNOJFDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> GKCCJCLAPAC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37CFCF0", Offset = "0x37CE6F0", VA = "0x1837CFCF0")]
	public MFCFHNOJFDK CKIEIOOCMAM<T>(T AKINJEPHEED)
	{
		return default(MFCFHNOJFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37CFAF0", Offset = "0x37CE4F0", VA = "0x1837CFAF0")]
	public T ABMJNALEGDK<T>(T NEHANGBEOBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37D02E0", Offset = "0x37CECE0", VA = "0x1837D02E0")]
	public bool MDMJPHIOICO<T>(out T AKINJEPHEED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JGHNNPFGCJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool NBLBJJLJNJM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x870400", Offset = "0x86EE00", VA = "0x180870400")]
	public JGHNNPFGCJD(bool PBEMEBMEBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NPEPCFCHIJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool EFOEOFNMGBH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC4C0", Offset = "0x1CFAEC0", VA = "0x181CFC4C0")]
	public NPEPCFCHIJC(bool LKHLLEOEDCN)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, PIKEECFDMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1CFD860", Offset = "0x1CFC260", VA = "0x181CFD860", Slot = "4")]
		public void PrepareImposter(MFCFHNOJFDK PJBJFAJEGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x1CFBD90", Offset = "0x1CFA790", VA = "0x181CFBD90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1CFBD80", Offset = "0x1CFA780", VA = "0x181CFBD80")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9880", Offset = "0x1CF8280", VA = "0x181CF9880")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KLBOJLIGKFF
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> AGBPPHLOLCD;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 COMOEEFBCMP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 IOOKKKMJBAC;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera EEOHDHKKAKN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string ADCADAFPKPE = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const DBBAPMFNEML GJMMDMCLLBE = DBBAPMFNEML.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> DHLCMCIMBAK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode NKHACIJBOGP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color AIGMLEEDEGF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color NFDHPJLMHNO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color AOLFFDBBINI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap HBKKCDCJIIO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool MKAFCFECGNG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera BECBEKAIFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1CFAEB0", Offset = "0x1CF98B0", VA = "0x181CFAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9D10", Offset = "0x1CF8710", VA = "0x181CF9D10")]
	public static void ALIJIHLNAOA(Vector3 ICOELANDBFJ, Quaternion MNFJILGKOBJ, ImposterRenderConfig FILIOBKKGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAAB0", Offset = "0x1CF94B0", VA = "0x181CFAAB0")]
	private static void HKFAECFDJBA(Vector3 ICOELANDBFJ, Quaternion MNFJILGKOBJ, URPLight FMMMELIILON, ImposterRenderConfig.LightConfig HHNKCDAKELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1CFADC0", Offset = "0x1CF97C0", VA = "0x181CFADC0")]
	public static void IHANNGKKJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB530", Offset = "0x1CF9F30", VA = "0x181CFB530")]
	private static void NNFEAKBNOJF(int DJBGPLJMKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA160", Offset = "0x1CF8B60", VA = "0x181CFA160")]
	public static void FJIJIHHOOIL(ImposterRenderConfig FILIOBKKGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB900", Offset = "0x1CFA300", VA = "0x181CFB900")]
	public static void PGONDIPMOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9F90", Offset = "0x1CF8990", VA = "0x181CF9F90")]
	public static void CJBOKFHKPNN(GameObject GDENCNOLHIH, RenderTexture HLPCLJNMDJF, ImposterRenderConfig FILIOBKKGKA, IACGIKCOBBI BFNGJHCEFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA2E0", Offset = "0x1CF8CE0", VA = "0x181CFA2E0")]
	private static void FNDICAGFAMB(GameObject GDENCNOLHIH, RenderTexture HLPCLJNMDJF, ImposterRenderConfig FILIOBKKGKA, IACGIKCOBBI BFNGJHCEFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB0E0", Offset = "0x1CF9AE0", VA = "0x181CFB0E0")]
	private static void LCNPKGOJDIJ(GameObject GDENCNOLHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB390", Offset = "0x1CF9D90", VA = "0x181CFB390")]
	public static void LEIOMOCJCJJ(List<Renderer> DOBJOIIJDEE, List<Material> MNLPPLOCDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA7E0", Offset = "0x1CF91E0", VA = "0x181CFA7E0")]
	public static void GPMGDAFECHL(GameObject INOMEBNKFPO, Vector3 MOOEFGDELIK, Vector3 PAHBJNCCCPE, float CBICGBOHDAK, IACGIKCOBBI BFNGJHCEFBN, out Vector3 OAHFMAGLDCC, out Quaternion MJJGKHICOMG, out float DIBDHEJNFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9C70", Offset = "0x1CF8670", VA = "0x181CF9C70")]
	public static RenderTexture AJNGCJHCNKO(int ALOPIDFKKAE, int NKGGLAGGPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBA00", Offset = "0x1CFA400", VA = "0x181CFBA00")]
	public static void PMDPGIKLFKD()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct ENGBEDPFHPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public DGKGHLNCFMM MCCAMMAMPAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject HHCGPJFIONO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture OADGIGPOHNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig BCIMNACNJOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public IACGIKCOBBI IACGIKCOBBI;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1CF81E0", Offset = "0x1CF6BE0", VA = "0x181CF81E0")]
			public ENGBEDPFHPG(DGKGHLNCFMM GJNBJOAMMAA, GameObject FBMKDICLDNA, RenderTexture HLPCLJNMDJF, ImposterRenderConfig PLKDGLIGGBD, IACGIKCOBBI BFNGJHCEFBN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::CGBPKHNPMDG<ENGBEDPFHPG, RenderTexture> NGHMCKDMKAG;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<ENGBEDPFHPG> HKGDKJKBMMJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int AOKPLIPPLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1CF7610", Offset = "0x1CF6010", VA = "0x181CF7610")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7720", Offset = "0x1CF6120", VA = "0x181CF7720")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GDENCNOLHIH, RenderTexture HLPCLJNMDJF, ImposterRenderConfig FILIOBKKGKA, IACGIKCOBBI BFNGJHCEFBN, CancellationToken FAPLHFKLMOL, bool DMAEJFCNPIK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7250", Offset = "0x1CF5C50", VA = "0x181CF7250", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7680", Offset = "0x1CF6080", VA = "0x181CF7680", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7440", Offset = "0x1CF5E40", VA = "0x181CF7440")]
		private static Task<RenderTexture> IOICBKIEDBE(ENGBEDPFHPG LFNEFALJFMC, CancellationToken FAPLHFKLMOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7B10", Offset = "0x1CF6510", VA = "0x181CF7B10")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBDB0", Offset = "0x1CFA7B0", VA = "0x181CFBDB0")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBEC0", Offset = "0x1CFA8C0", VA = "0x181CFBEC0")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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
