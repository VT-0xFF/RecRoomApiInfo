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
	private readonly struct NHNHKENCOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JPALMODANJN NCHBPPIEMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HMHLPEAAEHB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862A10", VA = "0x180863610")]
		public NHNHKENCOEN(JPALMODANJN HBOKIGLFJEO, string KCIJHFLPMLP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DEFGLKKNCDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NHNHKENCOEN queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x601C7D0", Offset = "0x601BBD0", VA = "0x18601C7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x601CB70", Offset = "0x601BF70", VA = "0x18601CB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider MPPMOAGICHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BDCFIAJLFPB<NHNHKENCOEN, GameObject> MHNFPNFLPAM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EFFMMHMOAJO IEDDILMBECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x792A30", Offset = "0x791E30", VA = "0x180792A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private BDCFIAJLFPB<NHNHKENCOEN, GameObject> JBGEMNEHPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x601DEA0", Offset = "0x601D2A0", VA = "0x18601DEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int PMEEOPEMMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x601DD90", Offset = "0x601D190", VA = "0x18601DD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x601DDE0", Offset = "0x601D1E0", VA = "0x18601DDE0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x601E300", Offset = "0x601D700", VA = "0x18601E300", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x601E000", Offset = "0x601D400", VA = "0x18601E000")]
	[AsyncStateMachine(typeof(DEFGLKKNCDK))]
	private Task<GameObject> IDDMFNIMBDE(NHNHKENCOEN NFBALEDMKOM, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x601E120", Offset = "0x601D520", VA = "0x18601E120")]
	public Task<GameObject> LoadItemAsync(JPALMODANJN HBOKIGLFJEO, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x601E370", Offset = "0x601D770", VA = "0x18601E370")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KDBFALHIEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JPALMODANJN MNDEABGKOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture CPGNLJMENKH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7999C0", Offset = "0x798DC0", VA = "0x1807999C0")]
		public KDBFALHIEKI(JPALMODANJN HGLFDAEJPNF, Texture PGJDHNNPIMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum CKLLFOJJLBO
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
	private class LFEHIJCPOMB : KGDNCOOHBFB<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct KLCOHGDAJFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LFEHIJCPOMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x601F8C0", Offset = "0x601ECC0", VA = "0x18601F8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x60200D0", Offset = "0x601F4D0", VA = "0x1860200D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly JPALMODANJN HGLFDAEJPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture ADPLFLHFILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig HDBGIGBBCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken HHHPDCGPCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject LJNKKEHPEHJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override BIDJOPNIEEO<Texture> PEGKPMIADNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6020230", Offset = "0x601F630", VA = "0x186020230", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> BNHODFLCFCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6020320", Offset = "0x601F720", VA = "0x186020320")]
		public LFEHIJCPOMB(JPALMODANJN HGLFDAEJPNF, RenderTexture ADPLFLHFILB, ImposterRenderConfig HDBGIGBBCEF, CancellationToken HHHPDCGPCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6020140", Offset = "0x601F540", VA = "0x186020140")]
		[AsyncStateMachine(typeof(KLCOHGDAJFG))]
		private Task<Texture> ACOJGBKFHEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6020310", Offset = "0x601F710", VA = "0x186020310", Slot = "10")]
		protected override void MAGIBGLJIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6020290", Offset = "0x601F690", VA = "0x186020290")]
		private static void DNCJIFGLMHM(GameObject LJNKKEHPEHJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DHKBNFEKLHM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x601CBE0", Offset = "0x601BFE0", VA = "0x18601CBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x92DFC0", Offset = "0x92D3C0", VA = "0x18092DFC0", Slot = "5")]
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
	[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private CKLLFOJJLBO size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[HKPCFEIAMKE("size", CKLLFOJJLBO.Custom)]
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
	private static int NJGHEIIIKLA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture OFBIFBKGAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OECDLKFMDEK<GameObject> KHKMIJMCGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NHJNJBGGLID LKBBGJOGOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource BPEHJEDJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ILOEBLPKELJ<Texture> GJIHHCBHBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JPALMODANJN PJCIEKKJBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture CKKLIHCLMIE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LPOFAJGFCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x601F3B0", Offset = "0x601E7B0", VA = "0x18601F3B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x601F400", Offset = "0x601E800", VA = "0x18601F400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture OKNFDLKFHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x601EB20", Offset = "0x601DF20", VA = "0x18601EB20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x793EA0", Offset = "0x7932A0", VA = "0x180793EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JPALMODANJN MNDEABGKOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x792F70", Offset = "0x792370", VA = "0x180792F70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x601E9C0", Offset = "0x601DDC0", VA = "0x18601E9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool GGAIAOCGFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x517C490", Offset = "0x517B890", VA = "0x18517C490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int CPEBGDDMBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x601ECD0", Offset = "0x601E0D0", VA = "0x18601ECD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x601E9A0", Offset = "0x601DDA0", VA = "0x18601E9A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x601EF80", Offset = "0x601E380", VA = "0x18601EF80")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x601EE50", Offset = "0x601E250", VA = "0x18601EE50")]
	private void JGEFBFMPMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x601F290", Offset = "0x601E690", VA = "0x18601F290")]
	public void Set(JPALMODANJN MGOONFBMEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x601F280", Offset = "0x601E680", VA = "0x18601F280")]
	public void Set(Texture PGJDHNNPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x601F2A0", Offset = "0x601E6A0", VA = "0x18601F2A0")]
	public void Set(KDBFALHIEKI PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x601E9B0", Offset = "0x601DDB0", VA = "0x18601E9B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x601F080", Offset = "0x601E480", VA = "0x18601F080")]
	public void SetInternal(JPALMODANJN MGOONFBMEAM, [Optional] Texture CAPKPDJDIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x601F070", Offset = "0x601E470", VA = "0x18601F070")]
	public void SetCustomSize(int OAGDJNMGECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79AAD0", Offset = "0x799ED0", VA = "0x18079AAD0")]
	public void SetAntiAliasing(int PGODAFINDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x601EED0", Offset = "0x601E2D0", VA = "0x18601EED0")]
	[AsyncStateMachine(typeof(DHKBNFEKLHM))]
	private void NIPLNEJLHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x601ED70", Offset = "0x601E170", VA = "0x18601ED70")]
	private void GJIKMNDMLHJ(Texture PGJDHNNPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x601F330", Offset = "0x601E730", VA = "0x18601F330")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ICPIFFAEFGA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float LLHCKKJHANC = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "4")]
	public void PrepareImposter(CMMINNNOHEF LALAKJLPIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x601E960", Offset = "0x601DD60", VA = "0x18601E960")]
	public void SetReferencePoint(Vector3 OHOMLOMNFJE, Quaternion MCGHOJEKKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x601E760", Offset = "0x601DB60", VA = "0x18601E760")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x601E940", Offset = "0x601DD40", VA = "0x18601E940")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13BA690", Offset = "0x13B9A90", VA = "0x1813BA690")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FLEDHMLPEFH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static FLEDHMLPEFH DBPADPKEIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float ELEMCLBLIEC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x212CF10", Offset = "0x212C310", VA = "0x18212CF10")]
	public FLEDHMLPEFH(float OBKINKKNHLP)
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
		[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int FPIJOELCGMM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MDFICLACMCN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> JBODEMOIIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool IGJGFPFHADG;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x601F5E0", Offset = "0x601E9E0", VA = "0x18601F5E0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x601F4E0", Offset = "0x601E8E0", VA = "0x18601F4E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x601F820", Offset = "0x601EC20", VA = "0x18601F820")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JPALMODANJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string BPLHJAIPMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FLEDHMLPEFH FLEDHMLPEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EBGNPGMGDJG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> OJGOBEABBDA(CancellationToken HHHPDCGPCML);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LEFHJBCKJHC(JPALMODANJN JLCJEDAFKJL);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPIGCLGKKGD();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGHGOOBIEEF();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JMMLBIDPCDL([Out] ILOEBLPKELJ<Texture> EHDIGIKLMFO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DKJGICOJGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x601D3A0", Offset = "0x601C7A0", VA = "0x18601D3A0")]
	public static bool KMLKHDHDDFP(JPALMODANJN EMNDGKDNBCK, JPALMODANJN NIBJGKANDNN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, ICPIFFAEFGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x601C680", Offset = "0x601BA80", VA = "0x18601C680", Slot = "4")]
		public void PrepareImposter(CMMINNNOHEF LALAKJLPIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ICPIFFAEFGA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(CMMINNNOHEF LALAKJLPIGH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FPKFDJODIMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> IOGMLDKMMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GFEKMHGOOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EFFMMHMOAJO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject GHFCGDIHMIB(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, bool JNMMKCNKAFI = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T GHFCGDIHMIB<T>(T PCKAKIJCIKM, Transform AOGBEAODJPP, bool JNMMKCNKAFI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T GHFCGDIHMIB<T>(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, bool JNMMKCNKAFI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject GHFCGDIHMIB(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, CMMINNNOHEF LALAKJLPIGH, bool JNMMKCNKAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PPEPOFGKHJB : IDisposable, EFFMMHMOAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> LCBIHDILIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BBHCBANIEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform ELEHLDIHLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> PNEAFILNGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PMLOMFCFBMP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6022700", Offset = "0x6021B00", VA = "0x186022700")]
	[ABIGJEDBLLA(BMBIBJGPNHE.None)]
	public static void FHPLDDBGBEB(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6023080", Offset = "0x6022480", VA = "0x186023080")]
	[Preserve]
	public PPEPOFGKHJB([AKCMIAONCHN(null)] FPKFDJODIMJ BCLCIGNADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6022620", Offset = "0x6021A20", VA = "0x186022620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6022800", Offset = "0x6021C00", VA = "0x186022800", Slot = "5")]
	public GameObject GHFCGDIHMIB(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, bool JNMMKCNKAFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27A1880", Offset = "0x27A0C80", VA = "0x1827A1880", Slot = "6")]
	public T GHFCGDIHMIB<T>(T PCKAKIJCIKM, Transform AOGBEAODJPP, bool JNMMKCNKAFI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x27A12E0", Offset = "0x27A06E0", VA = "0x1827A12E0", Slot = "7")]
	public T GHFCGDIHMIB<T>(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, bool JNMMKCNKAFI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6022890", Offset = "0x6021C90", VA = "0x186022890", Slot = "8")]
	public GameObject GHFCGDIHMIB(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, CMMINNNOHEF LALAKJLPIGH, bool JNMMKCNKAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27A18F0", Offset = "0x27A0CF0", VA = "0x1827A18F0", Slot = "9")]
	public T GHFCGDIHMIB<T>(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, CMMINNNOHEF LALAKJLPIGH, bool JNMMKCNKAFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27A1310", Offset = "0x27A0710", VA = "0x1827A1310")]
	private T GHFCGDIHMIB<T>(GameObject PCKAKIJCIKM, Transform AOGBEAODJPP, CMMINNNOHEF LALAKJLPIGH, bool JNMMKCNKAFI, [Out] GameObject OLDNFJKBOPE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27A1930", Offset = "0x27A0D30", VA = "0x1827A1930")]
	private T LDFBBGDPDOG<T>(GameObject IFGJJHCIEPA, CMMINNNOHEF LALAKJLPIGH, bool JNMMKCNKAFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6022E00", Offset = "0x6022200", VA = "0x186022E00")]
	private void JOAFKDCJJAD(Component GHPJMKBNPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6022920", Offset = "0x6021D20", VA = "0x186022920")]
	private void IEEPJIIAOLB(Component GHPJMKBNPML, CMMINNNOHEF LALAKJLPIGH, bool JNMMKCNKAFI, bool FJGEFFFGLFB, [Optional] Type ICJJLCEBEDK, [Optional] Type OFNPPAJLPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6022F10", Offset = "0x6022310", VA = "0x186022F10")]
	private void PMFDNPDDJFI(GameObject IFGJJHCIEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CMMINNNOHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> HPBNDOGDCKG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2461480", Offset = "0x2460880", VA = "0x182461480")]
	public CMMINNNOHEF NIEAIDPCAEB<T>(T BMIEANJFKHF)
	{
		return default(CMMINNNOHEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2461370", Offset = "0x2460770", VA = "0x182461370")]
	public T LBFOALNGCEO<T>(T MINBGACMFMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2460BA0", Offset = "0x245FFA0", VA = "0x182460BA0")]
	public bool KBIKFGCAMJG<T>([Out] T BMIEANJFKHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FFIGHNKKDOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool EEFPICCKFIJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xC213A0", Offset = "0xC207A0", VA = "0x180C213A0")]
	public FFIGHNKKDOG(bool NLPCKDCDCGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JAFBBAILIDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool JFJLNPPEGMC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x601F8B0", Offset = "0x601ECB0", VA = "0x18601F8B0")]
	public JAFBBAILIDP(bool EKMKNCHICHO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, ICPIFFAEFGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x60234C0", Offset = "0x60228C0", VA = "0x1860234C0", Slot = "4")]
		public void PrepareImposter(CMMINNNOHEF LALAKJLPIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
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
		public Bounds EKJPGNLMNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x601E5D0", Offset = "0x601D9D0", VA = "0x18601E5D0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x601E590", Offset = "0x601D990", VA = "0x18601E590")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x601E550", Offset = "0x601D950", VA = "0x18601E550")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x601E460", Offset = "0x601D860", VA = "0x18601E460")]
		private void AKCFCIIFPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
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
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x6022600", Offset = "0x6021A00", VA = "0x186022600")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x60225F0", Offset = "0x60219F0", VA = "0x1860225F0")]
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
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
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
		[Cpp2IlInjected.Address(RVA = "0x601F480", Offset = "0x601E880", VA = "0x18601F480")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LNKLCDMALHO
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> AGFIOLGIMMA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 CCKBEBIMJFO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 DNNGFKDMCOI;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera KDODMIIKIAI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> NGIGNENFPAN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> LDABLBIKBFM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode BMICCHFPPAC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color NLFIJKLDEGF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color HMLGNIGIANA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color LKPFHIEMBAF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap HPBGFFOPJJL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool FMIJFCOKBMN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera AMJBNJNBEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6020A60", Offset = "0x601FE60", VA = "0x186020A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60207F0", Offset = "0x601FBF0", VA = "0x1860207F0")]
	public static void BIBDAEKKOPF(Vector3 AACLCBGJBBE, Quaternion MANEHKCONCD, ImposterRenderConfig CLHLPFOCOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60204C0", Offset = "0x601F8C0", VA = "0x1860204C0")]
	private static void AHFCCGOPEAO(Vector3 AACLCBGJBBE, Quaternion MANEHKCONCD, URPLight AEMMMFBJOIB, ImposterRenderConfig.LightConfig MDIFAGJCNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6020E40", Offset = "0x6020240", VA = "0x186020E40")]
	public static void EICMHJLEDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6020F20", Offset = "0x6020320", VA = "0x186020F20")]
	private static void HNCLEEPKHDP(int FDBJFFEOKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6022240", Offset = "0x6021640", VA = "0x186022240")]
	public static void PPJIBIOBMKF(ImposterRenderConfig CLHLPFOCOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6021930", Offset = "0x6020D30", VA = "0x186021930")]
	public static void KKBFLDKHIAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6020C70", Offset = "0x6020070", VA = "0x186020C70")]
	public static void EGAIKGJNADG(GameObject CGJLNBEJAJA, RenderTexture ADPLFLHFILB, ImposterRenderConfig CLHLPFOCOJE, FLEDHMLPEFH MKAHBFNFCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60212A0", Offset = "0x60206A0", VA = "0x1860212A0")]
	private static void ICHDMNDGEGA(GameObject CGJLNBEJAJA, RenderTexture ADPLFLHFILB, ImposterRenderConfig CLHLPFOCOJE, FLEDHMLPEFH MKAHBFNFCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6021A20", Offset = "0x6020E20", VA = "0x186021A20")]
	private static void MGFAEMMGFMM(GameObject CGJLNBEJAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6021CC0", Offset = "0x60210C0", VA = "0x186021CC0")]
	public static void NAMDKNJGIPI(GameObject PCKAKIJCIKM, Vector3 FDIMFENKBCB, Vector3 MMCOKOCAODK, float MGNAKHBIPFP, FLEDHMLPEFH MKAHBFNFCOF, [Out] Vector3 KDBHENPENPL, [Out] Quaternion CFLDIKNGJLC, [Out] float CBPPNGFGHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6021880", Offset = "0x6020C80", VA = "0x186021880")]
	public static RenderTexture IFNMGMBFIJJ(int DJKBPBOJAEA, int BKCPECMOHLE, RenderTextureFormat NBMOIMOKFPB = RenderTextureFormat.ARGB32)
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
		public struct FCNNJLFLEDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public EJJODCOIBAE FGMMGIBIIIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject LMPPHILEMAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture OKNFDLKFHIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig PKBJMCAIGFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public FLEDHMLPEFH FLEDHMLPEFH;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x601E3B0", Offset = "0x601D7B0", VA = "0x18601E3B0")]
			public FCNNJLFLEDD(EJJODCOIBAE EMJJOLLBABB, GameObject JPMEOCALCNC, RenderTexture ADPLFLHFILB, ImposterRenderConfig HDBGIGBBCEF, FLEDHMLPEFH MKAHBFNFCOF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static BDCFIAJLFPB<FCNNJLFLEDD, RenderTexture> MDJILGCMGIG;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<FCNNJLFLEDD> HPDPJDJJNAG;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int HCKBGLIAEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x601D680", Offset = "0x601CA80", VA = "0x18601D680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x601D930", Offset = "0x601CD30", VA = "0x18601D930")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CGJLNBEJAJA, RenderTexture ADPLFLHFILB, ImposterRenderConfig CLHLPFOCOJE, FLEDHMLPEFH MKAHBFNFCOF, CancellationToken HHHPDCGPCML, bool IMKCCOCHNGK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x601D490", Offset = "0x601C890", VA = "0x18601D490", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x601D890", Offset = "0x601CC90", VA = "0x18601D890", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x601D6F0", Offset = "0x601CAF0", VA = "0x18601D6F0")]
		private static Task<RenderTexture> CAPAGIGLGIE(FCNNJLFLEDD LGHJONEGAHP, CancellationToken HHHPDCGPCML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x601DD50", Offset = "0x601D150", VA = "0x18601DD50")]
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
