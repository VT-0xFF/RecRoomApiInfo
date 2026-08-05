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
	private readonly struct CBDDHGGJOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KJMEOFICADJ GCEAMIMFMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string PBLHAHKJEEF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82CA80", Offset = "0x82BE80", VA = "0x18082CA80")]
		public CBDDHGGJOKP(KJMEOFICADJ CNOFKKEJPBM, string CEFKDFHJEPL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FKNHDFHGEPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CBDDHGGJOKP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B890", Offset = "0x5E1AC90", VA = "0x185E1B890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BC30", Offset = "0x5E1B030", VA = "0x185E1BC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider GMGAENLPHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NPLEEFFCEBE<CBDDHGGJOKP, GameObject> JPNGAOIKGFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JGNAFIAOIHL ODMCEGCKFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NPLEEFFCEBE<CBDDHGGJOKP, GameObject> INAHOCJDDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B680", Offset = "0x5E1AA80", VA = "0x185E1B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int DBIBIJCFJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B330", Offset = "0x5E1A730", VA = "0x185E1B330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B270", Offset = "0x5E1A670", VA = "0x185E1B270", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B7E0", Offset = "0x5E1ABE0", VA = "0x185E1B7E0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B380", Offset = "0x5E1A780", VA = "0x185E1B380")]
	[AsyncStateMachine(typeof(FKNHDFHGEPO))]
	private Task<GameObject> LNKCDBAGIAH(CBDDHGGJOKP EAKHGPLBLME, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B4A0", Offset = "0x5E1A8A0", VA = "0x185E1B4A0")]
	public Task<GameObject> LoadItemAsync(KJMEOFICADJ CNOFKKEJPBM, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B850", Offset = "0x5E1AC50", VA = "0x185E1B850")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FPFOKHIODJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KJMEOFICADJ GGKGCAJDMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture MCKDHFIAJPK;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77CB20", Offset = "0x77BF20", VA = "0x18077CB20")]
		public FPFOKHIODJN(KJMEOFICADJ MIDMAJMILMP, Texture FHDJNDAFDEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AMEDAAEOLNB
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
	private class GGAOKJOJEBO : OBCMOPCNEDJ<Texture>, IEDPNBJPIEH, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IDMPPPBEAAC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GGAOKJOJEBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E1E220", Offset = "0x5E1D620", VA = "0x185E1E220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5E1EA30", Offset = "0x5E1DE30", VA = "0x185E1EA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KJMEOFICADJ MIDMAJMILMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture CJAFPNGJCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MDKJKKILOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken EANFAKGANNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject MJDBAGJFNIA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CJNEKNCGBDK<Texture> MKHHKJAEINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E1DED0", Offset = "0x5E1D2D0", VA = "0x185E1DED0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> CGHMHGKHODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E0A0", Offset = "0x5E1D4A0", VA = "0x185E1E0A0")]
		public GGAOKJOJEBO(KJMEOFICADJ MIDMAJMILMP, RenderTexture CJAFPNGJCPP, ImposterRenderConfig MDKJKKILOHN, CancellationToken EANFAKGANNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DFB0", Offset = "0x5E1D3B0", VA = "0x185E1DFB0")]
		[AsyncStateMachine(typeof(IDMPPPBEAAC))]
		private Task<Texture> MIGKAHBHGGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DEC0", Offset = "0x5E1D2C0", VA = "0x185E1DEC0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DF30", Offset = "0x5E1D330", VA = "0x185E1DF30")]
		private static void LLOAHFDIIEA(GameObject MJDBAGJFNIA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JDEAOPJJNNN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5E1FEF0", Offset = "0x5E1F2F0", VA = "0x185E1FEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F66E0", Offset = "0x7F5AE0", VA = "0x1807F66E0", Slot = "5")]
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
	[SerializeField]
	[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private AMEDAAEOLNB size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[EHJLCGPCADH("size", AMEDAAEOLNB.Custom)]
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
	private static int BACMJHIKDDI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture CEKFPFHNMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private GDDOOGFBLLO<GameObject> DBKNKMMMOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BLKLMCIOEEC JBNJIOCPPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource FNCADPJKBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private OBCMOPCNEDJ<Texture> AGNFLBONAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private KJMEOFICADJ KFECFEKDDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture KLBHPMFCBFD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MFLGKPEJPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F9F0", Offset = "0x5E1EDF0", VA = "0x185E1F9F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FA40", Offset = "0x5E1EE40", VA = "0x185E1FA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KBHJHAOFMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F500", Offset = "0x5E1E900", VA = "0x185E1F500")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KJMEOFICADJ GGKGCAJDMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7782D0", Offset = "0x7776D0", VA = "0x1807782D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F080", Offset = "0x5E1E480", VA = "0x185E1F080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LFEHOAMONGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FE53B0", Offset = "0x4FE47B0", VA = "0x184FE53B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int JDEJMEDEPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F1E0", Offset = "0x5E1E5E0", VA = "0x185E1F1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EFE0", Offset = "0x5E1E3E0", VA = "0x185E1EFE0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F410", Offset = "0x5E1E810", VA = "0x185E1F410")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EFF0", Offset = "0x5E1E3F0", VA = "0x185E1EFF0")]
	private void COIBLODGHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F8D0", Offset = "0x5E1ECD0", VA = "0x185E1F8D0")]
	public void Set(KJMEOFICADJ NOCHNPBBCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F8C0", Offset = "0x5E1ECC0", VA = "0x185E1F8C0")]
	public void Set(Texture FHDJNDAFDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F8E0", Offset = "0x5E1ECE0", VA = "0x185E1F8E0")]
	public void Set(FPFOKHIODJN NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F070", Offset = "0x5E1E470", VA = "0x185E1F070")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F6C0", Offset = "0x5E1EAC0", VA = "0x185E1F6C0")]
	public void SetInternal(KJMEOFICADJ NOCHNPBBCGN, [Optional] Texture FBGHKPDGNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F6B0", Offset = "0x5E1EAB0", VA = "0x185E1F6B0")]
	public void SetCustomSize(int DJILMIINIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x775A70", Offset = "0x774E70", VA = "0x180775A70")]
	public void SetAntiAliasing(int DCFBDEFEDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F280", Offset = "0x5E1E680", VA = "0x185E1F280")]
	[AsyncStateMachine(typeof(JDEAOPJJNNN))]
	private void MOFJDPBDFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F330", Offset = "0x5E1E730", VA = "0x185E1F330")]
	private void NMDNLOGNNCJ(Texture FHDJNDAFDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F970", Offset = "0x5E1ED70", VA = "0x185E1F970")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, OJFHILBGKAA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float GIKJPFLFFFM = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
	public void PrepareImposter(AKJGEFEPNDL NNBNMFFCBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EFA0", Offset = "0x5E1E3A0", VA = "0x185E1EFA0")]
	public void SetReferencePoint(Vector3 GOPGKDKAOFI, Quaternion MKPFBAOBFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EDA0", Offset = "0x5E1E1A0", VA = "0x185E1EDA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EF80", Offset = "0x5E1E380", VA = "0x185E1EF80")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x136D8C0", Offset = "0x136CCC0", VA = "0x18136D8C0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KEKEBJLNMLL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static KEKEBJLNMLL ILNNDEOOPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float CICIHLIAKJM;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x201FB40", Offset = "0x201EF40", VA = "0x18201FB40")]
	public KEKEBJLNMLL(float FGIOBCNLCLO)
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
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int HHEMIANIFED = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int JLKJLGCMLGO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> AOBPLJBAJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool BHNLFCHLMMK;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FC20", Offset = "0x5E1F020", VA = "0x185E1FC20")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FB20", Offset = "0x5E1EF20", VA = "0x185E1FB20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FE60", Offset = "0x5E1F260", VA = "0x185E1FE60")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KJMEOFICADJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string OIINEGLJAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KEKEBJLNMLL KEKEBJLNMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JAIJPCNHJEL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GNBNBLMCGJH(CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JPJPDIEKGCK(KJMEOFICADJ LFMLAKDHEFO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFLAADCBFFB();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNIMHNDFDFH();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JAMJDBGLHHG([Out] OBCMOPCNEDJ<Texture> NHDNAKIMDPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FMFKLLDCDIL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DDD0", Offset = "0x5E1D1D0", VA = "0x185E1DDD0")]
	public static bool FJHONLHOHKO(KJMEOFICADJ HBBENHOFNLG, KJMEOFICADJ OEMKHDIBHOG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, OJFHILBGKAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A7B0", Offset = "0x5E19BB0", VA = "0x185E1A7B0", Slot = "4")]
		public void PrepareImposter(AKJGEFEPNDL NNBNMFFCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OJFHILBGKAA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(AKJGEFEPNDL NNBNMFFCBEB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LEKAAJIKLHP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> BJADEFEJDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BKAJGPBHONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JGNAFIAOIHL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject KKGMCOOBHPM(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, bool OKLAAJFNJLF = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KKGMCOOBHPM<T>(T EJNEOMHIMNM, Transform ECLIMLPEPIL, bool OKLAAJFNJLF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KKGMCOOBHPM<T>(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, bool OKLAAJFNJLF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject KKGMCOOBHPM(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, AKJGEFEPNDL NNBNMFFCBEB, bool OKLAAJFNJLF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JEFCINNILDN : IDisposable, JGNAFIAOIHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> AEPABIANACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> IJIMOCGAKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform NLKJAFFGBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> OOOIJMODMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> OFPGINBEPHK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E20FF0", Offset = "0x5E203F0", VA = "0x185E20FF0")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	public static void KLOPPCLPFPI(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E210F0", Offset = "0x5E204F0", VA = "0x185E210F0")]
	[Preserve]
	public JEFCINNILDN([MJHHGJKKIMK(null)] LEKAAJIKLHP FMNNPFJGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E20CE0", Offset = "0x5E200E0", VA = "0x185E20CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E20ED0", Offset = "0x5E202D0", VA = "0x185E20ED0", Slot = "5")]
	public GameObject KKGMCOOBHPM(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, bool OKLAAJFNJLF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x255BDC0", Offset = "0x255B1C0", VA = "0x18255BDC0", Slot = "6")]
	public T KKGMCOOBHPM<T>(T EJNEOMHIMNM, Transform ECLIMLPEPIL, bool OKLAAJFNJLF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x255BE70", Offset = "0x255B270", VA = "0x18255BE70", Slot = "7")]
	public T KKGMCOOBHPM<T>(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, bool OKLAAJFNJLF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E20F60", Offset = "0x5E20360", VA = "0x185E20F60", Slot = "8")]
	public GameObject KKGMCOOBHPM(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, AKJGEFEPNDL NNBNMFFCBEB, bool OKLAAJFNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x255BE30", Offset = "0x255B230", VA = "0x18255BE30", Slot = "9")]
	public T KKGMCOOBHPM<T>(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, AKJGEFEPNDL NNBNMFFCBEB, bool OKLAAJFNJLF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x255B850", Offset = "0x255AC50", VA = "0x18255B850")]
	private T KKGMCOOBHPM<T>(GameObject EJNEOMHIMNM, Transform ECLIMLPEPIL, AKJGEFEPNDL NNBNMFFCBEB, bool OKLAAJFNJLF, [Out] GameObject BIPGEJNNPCO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x255B3B0", Offset = "0x255A7B0", VA = "0x18255B3B0")]
	private T EANGMHHAHIK<T>(GameObject PLLPJJEOIKJ, AKJGEFEPNDL NNBNMFFCBEB, bool OKLAAJFNJLF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E20DC0", Offset = "0x5E201C0", VA = "0x185E20DC0")]
	private void FGMDNFALMAA(Component AIKEEEBGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E20800", Offset = "0x5E1FC00", VA = "0x185E20800")]
	private void DKMABGJCCJB(Component AIKEEEBGAIM, AKJGEFEPNDL NNBNMFFCBEB, bool OKLAAJFNJLF, bool HKDCNMJIMFI, [Optional] Type EJJIHGMNCHB, [Optional] Type DLHMDHLOBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E20690", Offset = "0x5E1FA90", VA = "0x185E20690")]
	private void BJKJEGOMEPI(GameObject PLLPJJEOIKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AKJGEFEPNDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> PMBJGPCHBBB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B35E50", Offset = "0x2B35250", VA = "0x182B35E50")]
	public AKJGEFEPNDL HPDCNGOHBJP<T>(T AAMHEMAACEE)
	{
		return default(AKJGEFEPNDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B35D40", Offset = "0x2B35140", VA = "0x182B35D40")]
	public T EHGHEBAOCHM<T>(T IEKAHKGFLJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B36580", Offset = "0x2B35980", VA = "0x182B36580")]
	public bool OKOBFFKLADD<T>([Out] T AAMHEMAACEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JACOJHDENKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool NMGFILIFCCK;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xBDD970", Offset = "0xBDCD70", VA = "0x180BDD970")]
	public JACOJHDENKO(bool IJNLBIPLOAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LILABHJIGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool GEIAGJADBHC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E21570", Offset = "0x5E20970", VA = "0x185E21570")]
	public LILABHJIGKE(bool MCOJHKOLJMA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, OJFHILBGKAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E215B0", Offset = "0x5E209B0", VA = "0x185E215B0", Slot = "4")]
		public void PrepareImposter(AKJGEFEPNDL NNBNMFFCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
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
		public Bounds FLOPKNENLIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5E1EC10", Offset = "0x5E1E010", VA = "0x185E1EC10")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EAE0", Offset = "0x5E1DEE0", VA = "0x185E1EAE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EAA0", Offset = "0x5E1DEA0", VA = "0x185E1EAA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EB20", Offset = "0x5E1DF20", VA = "0x185E1EB20")]
		private void PBMPJGKLGJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5E21590", Offset = "0x5E20990", VA = "0x185E21590")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5E21580", Offset = "0x5E20980", VA = "0x185E21580")]
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
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FAC0", Offset = "0x5E1EEC0", VA = "0x185E1FAC0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FLOLPDPAKJI
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> EGJNJAFHLDK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 HMAOIGNGAJM;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 BPHKABCNING;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera HNDHBOOCKPN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> LAAHGCFIBFN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> FNHAJJONLGD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode NNADEOBANMC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color MDBMECKJAPP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color OIJEKFKJMPB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color NKFBKPHBGAG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap MEFJOAIBFGM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool AGODHKGFGMF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera FAOJOCDOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C440", Offset = "0x5E1B840", VA = "0x185E1C440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D970", Offset = "0x5E1CD70", VA = "0x185E1D970")]
	public static void PEKBIPJDHEK(Vector3 HNGHCGFPNOJ, Quaternion GFPAGIOEOEK, ImposterRenderConfig DEGLCCBCCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C110", Offset = "0x5E1B510", VA = "0x185E1C110")]
	private static void CLNNKDEGGBG(Vector3 HNGHCGFPNOJ, Quaternion GFPAGIOEOEK, URPLight AEABFECCEFI, ImposterRenderConfig.LightConfig NLKJPBKNFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BCA0", Offset = "0x5E1B0A0", VA = "0x185E1BCA0")]
	public static void BJDJLJBGAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CEA0", Offset = "0x5E1C2A0", VA = "0x185E1CEA0")]
	private static void IBJMPHMFAFO(int DANGLMOAJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C650", Offset = "0x5E1BA50", VA = "0x185E1C650")]
	public static void DCIDJFGNIEE(ImposterRenderConfig DEGLCCBCCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C020", Offset = "0x5E1B420", VA = "0x185E1C020")]
	public static void CGPNBHDKALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D7A0", Offset = "0x5E1CBA0", VA = "0x185E1D7A0")]
	public static void OPBINLNFNFE(GameObject DHICIFFODHF, RenderTexture CJAFPNGJCPP, ImposterRenderConfig DEGLCCBCCJF, KEKEBJLNMLL PFOOEMDHIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C810", Offset = "0x5E1BC10", VA = "0x185E1C810")]
	private static void EOGFJAEGOLK(GameObject DHICIFFODHF, RenderTexture CJAFPNGJCPP, ImposterRenderConfig DEGLCCBCCJF, KEKEBJLNMLL PFOOEMDHIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BD80", Offset = "0x5E1B180", VA = "0x185E1BD80")]
	private static void CAGGJHIKCAE(GameObject DHICIFFODHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D220", Offset = "0x5E1C620", VA = "0x185E1D220")]
	public static void MBMLHAKEJMJ(GameObject EJNEOMHIMNM, Vector3 IMNAFMJPPKE, Vector3 FHJBBJGNFKG, float LCHFGHLBLGC, KEKEBJLNMLL PFOOEMDHIAE, [Out] Vector3 PEEMPCEIBJB, [Out] Quaternion BABCOPHJMOH, [Out] float IBPJACHIKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CDF0", Offset = "0x5E1C1F0", VA = "0x185E1CDF0")]
	public static RenderTexture GGPALPDHMJN(int DFNBDEKAJAM, int DLFGMNCCFOK, RenderTextureFormat GIAELHONAOK = RenderTextureFormat.ARGB32)
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
		public struct DLIKNFNDNOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public JOBBEGCJNAJ COOHMGCNGOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject CFNKBBCBEGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture KBHJHAOFMKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig JBOFNNBHKHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public KEKEBJLNMLL KEKEBJLNMLL;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E1A900", Offset = "0x5E19D00", VA = "0x185E1A900")]
			public DLIKNFNDNOP(JOBBEGCJNAJ AHLFODDIBHC, GameObject HCNHALBKKCD, RenderTexture CJAFPNGJCPP, ImposterRenderConfig MDKJKKILOHN, KEKEBJLNMLL PFOOEMDHIAE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static NPLEEFFCEBE<DLIKNFNDNOP, RenderTexture> COLIAAKONLB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<DLIKNFNDNOP> JOIDFICGCBP;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int GNEAGBOMCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E1AD00", Offset = "0x5E1A100", VA = "0x185E1AD00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AE10", Offset = "0x5E1A210", VA = "0x185E1AE10")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DHICIFFODHF, RenderTexture CJAFPNGJCPP, ImposterRenderConfig DEGLCCBCCJF, KEKEBJLNMLL PFOOEMDHIAE, CancellationToken EANFAKGANNH, bool DBEHIGBAAAE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A970", Offset = "0x5E19D70", VA = "0x185E1A970", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AD70", Offset = "0x5E1A170", VA = "0x185E1AD70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AB60", Offset = "0x5E19F60", VA = "0x185E1AB60")]
		private static Task<RenderTexture> FKHMFMPOLGA(DLIKNFNDNOP CFDHBMEDFLF, CancellationToken EANFAKGANNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B230", Offset = "0x5E1A630", VA = "0x185E1B230")]
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
