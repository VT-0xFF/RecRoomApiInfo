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
	private readonly struct OGJMNLAJGJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FPAHCFEDGHI BJACGCLLCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string IEGAFNEHLJP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
		public OGJMNLAJGJF(FPAHCFEDGHI DCNIGJDLMHK, string FHFNMMNBNEA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct JBLMBNKCGEM : IAsyncStateMachine
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
		public OGJMNLAJGJF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E15790", Offset = "0x6E14B90", VA = "0x186E15790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E15B50", Offset = "0x6E14F50", VA = "0x186E15B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider PGIOPMLKKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ABDOPOACKOD<OGJMNLAJGJF, GameObject> DKBJCDLJMMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ACJHIJPGFNF PLGABLPGCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ABDOPOACKOD<OGJMNLAJGJF, GameObject> AJADCEILBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E121E0", Offset = "0x6E115E0", VA = "0x186E121E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BNGMHGELBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E12630", Offset = "0x6E11A30", VA = "0x186E12630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E12100", Offset = "0x6E11500", VA = "0x186E12100", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E12680", Offset = "0x6E11A80", VA = "0x186E12680", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E12340", Offset = "0x6E11740", VA = "0x186E12340")]
	[AsyncStateMachine(typeof(JBLMBNKCGEM))]
	private Task<GameObject> LCLIDFNLADL(OGJMNLAJGJF PDMFABIBGCF, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E12460", Offset = "0x6E11860", VA = "0x186E12460")]
	public Task<GameObject> LoadItemAsync(FPAHCFEDGHI DCNIGJDLMHK, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E126F0", Offset = "0x6E11AF0", VA = "0x186E126F0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BOFMIMAHGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FPAHCFEDGHI JAEIGJHDGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture EBPDEDEIAHJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
		public BOFMIMAHGHA(FPAHCFEDGHI JLBLKLADGJH, Texture KDKJOONKNHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum OFIFBMDEKDM
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
	private class HOMOECLMBJH : DIJLOMONMJJ<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct FAPDOJHEFMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HOMOECLMBJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6E12730", Offset = "0x6E11B30", VA = "0x186E12730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6E12F20", Offset = "0x6E12320", VA = "0x186E12F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly FPAHCFEDGHI JLBLKLADGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture KFJIEAHMGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IHHLAJEDFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken EEHACKMODLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D HDAEGCPHLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject OACHEMDDDKO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MIJNEIJMPHL<Texture2D> CAPCGENPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6E13130", Offset = "0x6E12530", VA = "0x186E13130", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> CJJDGCHAJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E13190", Offset = "0x6E12590", VA = "0x186E13190")]
		public HOMOECLMBJH(FPAHCFEDGHI JLBLKLADGJH, RenderTexture KFJIEAHMGBG, ImposterRenderConfig IHHLAJEDFGJ, CancellationToken EEHACKMODLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E12F90", Offset = "0x6E12390", VA = "0x186E12F90")]
		[AsyncStateMachine(typeof(FAPDOJHEFMN))]
		private Task<Texture2D> AJBCOFOLMHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E13100", Offset = "0x6E12500", VA = "0x186E13100", Slot = "10")]
		protected override void DHDLBJOGNLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E13080", Offset = "0x6E12480", VA = "0x186E13080")]
		private static void CCJAFPKFOKD(GameObject OACHEMDDDKO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CFDLMIFACAD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6E0E7F0", Offset = "0x6E0DBF0", VA = "0x186E0E7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
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
	[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private OFIFBMDEKDM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[DAFFMLLPHJC("size", OFIFBMDEKDM.Custom)]
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
	private static int FNJCNNCNFHF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture HCDBDOBHHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DDPHNHKFHAK<GameObject> MHOAMIEPKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private LMEMMAHKEDK LCEDEIKLNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource INFCCFLIMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FLIAEPPCPCN<Texture2D> HODNBBCIKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private FPAHCFEDGHI GCICELKDBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DGHOHGBDLHN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int FGCJKBDBFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E15260", Offset = "0x6E14660", VA = "0x186E15260")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E152B0", Offset = "0x6E146B0", VA = "0x186E152B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture MMPBGODNKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E14C50", Offset = "0x6E14050", VA = "0x186E14C50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A92F0", VA = "0x1808A9EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private FPAHCFEDGHI JAEIGJHDGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC00", Offset = "0x8AD000", VA = "0x1808ADC00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E14900", Offset = "0x6E13D00", VA = "0x186E14900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PIDOKFIFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D950", Offset = "0x1A8CD50", VA = "0x181A8D950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int JNAAJFAAKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E14B40", Offset = "0x6E13F40", VA = "0x186E14B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E148E0", Offset = "0x6E13CE0", VA = "0x186E148E0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E14E30", Offset = "0x6E14230", VA = "0x186E14E30")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E14BD0", Offset = "0x6E13FD0", VA = "0x186E14BD0")]
	private void MHKGMAMCOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E15140", Offset = "0x6E14540", VA = "0x186E15140")]
	public void Set(FPAHCFEDGHI GMGLKEEDDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E15130", Offset = "0x6E14530", VA = "0x186E15130")]
	public void Set(Texture KDKJOONKNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E15150", Offset = "0x6E14550", VA = "0x186E15150")]
	public void Set(BOFMIMAHGHA LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E148F0", Offset = "0x6E13CF0", VA = "0x186E148F0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E14F30", Offset = "0x6E14330", VA = "0x186E14F30")]
	public void SetInternal(FPAHCFEDGHI GMGLKEEDDGB, [Optional] Texture DALBDFJMHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E14F20", Offset = "0x6E14320", VA = "0x186E14F20")]
	public void SetCustomSize(int LJGFOFJOKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9D30", Offset = "0x8A9130", VA = "0x1808A9D30")]
	public void SetAntiAliasing(int PLLDEKOAEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E14830", Offset = "0x6E13C30", VA = "0x186E14830")]
	[AsyncStateMachine(typeof(CFDLMIFACAD))]
	private void ANDGHJHCMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E14A60", Offset = "0x6E13E60", VA = "0x186E14A60")]
	private void HBBBNMGCDMP(Texture KDKJOONKNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E151E0", Offset = "0x6E145E0", VA = "0x186E151E0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ONAHBJJEAIF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float HMOACPEPDBI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public void PrepareImposter(PAMFHMIBEOE AFAEKDPMCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E147F0", Offset = "0x6E13BF0", VA = "0x186E147F0")]
	public void SetReferencePoint(Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E14600", Offset = "0x6E13A00", VA = "0x186E14600")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E147D0", Offset = "0x6E13BD0", VA = "0x186E147D0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1905C30", Offset = "0x1905030", VA = "0x181905C30")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PKJMAMEGDAF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static PKJMAMEGDAF ICHAGBAABOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float IABNLKHPIJO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x23EC8B0", Offset = "0x23EBCB0", VA = "0x1823EC8B0")]
	public PKJMAMEGDAF(float FNCFOJICHFP)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E15F60", Offset = "0x6E15360", VA = "0x186E15F60", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
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
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int NCPEOFKGOKC = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int GKBDJDFPADA = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> IHBOJCMJDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool IPLNCJHOLCN;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E154B0", Offset = "0x6E148B0", VA = "0x186E154B0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E153B0", Offset = "0x6E147B0", VA = "0x186E153B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E15700", Offset = "0x6E14B00", VA = "0x186E15700")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FPAHCFEDGHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KNFKPBCOJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PKJMAMEGDAF PKJMAMEGDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OMBMBAFGDJK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> PAEDHIEIJKP(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKGKJCJPFMK(FPAHCFEDGHI OCKBFCIKBEN);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IICLBPCCMOL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJOJOPGIEJN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GFMPHCDCDAP(uint? JPCIIPKIEBM, [Out] FLIAEPPCPCN<Texture2D> COPMCPKPFBC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IKMGNHNHLCG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E14210", Offset = "0x6E13610", VA = "0x186E14210")]
	public static bool PNLPANELNGL(FPAHCFEDGHI AGKLNFKEFFJ, FPAHCFEDGHI MMAPHGFIFJL)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, ONAHBJJEAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E115A0", Offset = "0x6E109A0", VA = "0x186E115A0", Slot = "4")]
		public void PrepareImposter(PAMFHMIBEOE AFAEKDPMCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ONAHBJJEAIF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PAMFHMIBEOE AFAEKDPMCFB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OGPFNHFOFJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> GPACNJGBGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> KCCOAKLPFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ACJHIJPGFNF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILBCCFENEGJ(params Type[] PKLDGANLKGL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JDBBCBJICMH(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, bool GFJDGBOEJDD = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JDBBCBJICMH<T>(T PJJHJGOPMNC, Transform IIOPLDELPHL, bool GFJDGBOEJDD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JDBBCBJICMH<T>(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, bool GFJDGBOEJDD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject JDBBCBJICMH(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, PAMFHMIBEOE AFAEKDPMCFB, bool GFJDGBOEJDD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IDJKEPEHOJI : IDisposable, ACJHIJPGFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> HBOILENMAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> MOOGMFGAADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform BAPFHOJMFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> GDHMPHOMKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DGIALGBENEH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E13CD0", Offset = "0x6E130D0", VA = "0x186E13CD0")]
	[FHFMOACGLML.PCGBCKINAAE]
	public static void MBGCLLCDEMF(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E13DD0", Offset = "0x6E131D0", VA = "0x186E13DD0")]
	[UnityEngine.Scripting.Preserve]
	public IDJKEPEHOJI([ACGOIOBGIEE(null)] OGPFNHFOFJH JKNIAJDMFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E13350", Offset = "0x6E12750", VA = "0x186E13350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E13B60", Offset = "0x6E12F60", VA = "0x186E13B60", Slot = "5")]
	public void ILBCCFENEGJ(params Type[] PKLDGANLKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E13C40", Offset = "0x6E13040", VA = "0x186E13C40", Slot = "6")]
	public GameObject JDBBCBJICMH(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, bool GFJDGBOEJDD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E96830", Offset = "0x2E95C30", VA = "0x182E96830", Slot = "7")]
	public T JDBBCBJICMH<T>(T PJJHJGOPMNC, Transform IIOPLDELPHL, bool GFJDGBOEJDD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E968C0", Offset = "0x2E95CC0", VA = "0x182E968C0", Slot = "8")]
	public T JDBBCBJICMH<T>(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, bool GFJDGBOEJDD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E13BB0", Offset = "0x6E12FB0", VA = "0x186E13BB0", Slot = "9")]
	public GameObject JDBBCBJICMH(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, PAMFHMIBEOE AFAEKDPMCFB, bool GFJDGBOEJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E96910", Offset = "0x2E95D10", VA = "0x182E96910", Slot = "10")]
	public T JDBBCBJICMH<T>(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, PAMFHMIBEOE AFAEKDPMCFB, bool GFJDGBOEJDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E962B0", Offset = "0x2E956B0", VA = "0x182E962B0")]
	private T JDBBCBJICMH<T>(GameObject PJJHJGOPMNC, Transform IIOPLDELPHL, PAMFHMIBEOE AFAEKDPMCFB, bool GFJDGBOEJDD, [Out] GameObject DHIFGDICOPG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E96970", Offset = "0x2E95D70", VA = "0x182E96970")]
	private T PFDNGNPINHP<T>(GameObject JPONDMDOHLN, PAMFHMIBEOE AFAEKDPMCFB, bool GFJDGBOEJDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E13430", Offset = "0x6E12830", VA = "0x186E13430")]
	private void EAPJNEMAIIK(Component FCNHHPDOLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E13540", Offset = "0x6E12940", VA = "0x186E13540")]
	private void GGBODCALALF(Component FCNHHPDOLNN, PAMFHMIBEOE AFAEKDPMCFB, bool GFJDGBOEJDD, bool NILKDHDHIHO, [Optional] Type EMCLCECNHIJ, [Optional] Type BDIEKAPDDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E139F0", Offset = "0x6E12DF0", VA = "0x186E139F0")]
	private void GNHEIKLEODO(GameObject JPONDMDOHLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PAMFHMIBEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> EAHPIAACOHC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3002820", Offset = "0x3001C20", VA = "0x183002820")]
	public PAMFHMIBEOE JOJCHNFNPDL<T>(T EADNLDLKAFO)
	{
		return default(PAMFHMIBEOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3002710", Offset = "0x3001B10", VA = "0x183002710")]
	public T JEMJOLBMCNL<T>(T JGBDACMOCCC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3001F30", Offset = "0x3001330", VA = "0x183001F30")]
	public bool CPMADEOKHEK<T>([Out] T EADNLDLKAFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BIKMJOGMGNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GIOPACIPBNE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23EC4C0", Offset = "0x23EB8C0", VA = "0x1823EC4C0")]
	public BIKMJOGMGNG(bool BNIELPFFEHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PLHKHLGBDNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool PCBDLNDHAMO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E15CA0", Offset = "0x6E150A0", VA = "0x186E15CA0")]
	public PLHKHLGBDNA(bool GGFEFELDAOB)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, ONAHBJJEAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E15CB0", Offset = "0x6E150B0", VA = "0x186E15CB0", Slot = "4")]
		public void PrepareImposter(PAMFHMIBEOE AFAEKDPMCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
		public Bounds DHMOABEJOFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6E14470", Offset = "0x6E13870", VA = "0x186E14470")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E14430", Offset = "0x6E13830", VA = "0x186E14430")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E143F0", Offset = "0x6E137F0", VA = "0x186E143F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E14300", Offset = "0x6E13700", VA = "0x186E14300")]
		private void MPKIBCPIEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E15BD0", Offset = "0x6E14FD0", VA = "0x186E15BD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E15BC0", Offset = "0x6E14FC0", VA = "0x186E15BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E15320", Offset = "0x6E14720", VA = "0x186E15320")]
		public void IAEIOABAJPP(Vector3 EJCEKDDOAJO, Quaternion IHFEDPFHMGJ, float PBFFKFIGFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E15350", Offset = "0x6E14750", VA = "0x186E15350")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CJFFBOAAGKM
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly Vector3 BALAPBHDIBO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<URPLight> PJDPLAMOMDP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly List<Light> OBIACDPIFNL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Camera CDBJGNDBCJB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<Renderer> EOCELLNLHNH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly List<ImposterBoundsOverride> LLCCHALEPBH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static AmbientMode IOLJNDFBOHO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color KIDPGIMMHMF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color HJGFIMPBLHB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Color LMBJNLDPOIF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static Cubemap OKLAMPDPIDF;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static bool ENFMOFMDAAJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> NAEFKHJAFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E10AF0", Offset = "0x6E0FEF0", VA = "0x186E10AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> JFBPNKHEDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E10C10", Offset = "0x6E10010", VA = "0x186E10C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera IDGJIJPKFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E0FCE0", Offset = "0x6E0F0E0", VA = "0x186E0FCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E10230", Offset = "0x6E0F630", VA = "0x186E10230")]
	public static void KKINOHJNMGA(Vector3 IBBBAHOIPMM, Quaternion NNMALGFKKPK, ImposterRenderConfig GAIMJEFECMK, bool NCDBJHBGPBC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E0FF10", Offset = "0x6E0F310", VA = "0x186E0FF10")]
	private static void IMHMJPGNHJC(Vector3 IBBBAHOIPMM, Quaternion NNMALGFKKPK, URPLight PKBMBLPFDMC, ImposterRenderConfig.LightConfig PMKLINIMPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F030", Offset = "0x6E0E430", VA = "0x186E0F030")]
	public static void AFFEDCPIJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F8C0", Offset = "0x6E0ECC0", VA = "0x186E0F8C0")]
	private static void FAMFOIBBOJC(int CGNKGJPHLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F710", Offset = "0x6E0EB10", VA = "0x186E0F710")]
	public static void CPLGDCMLOJI(ImposterRenderConfig GAIMJEFECMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E10C60", Offset = "0x6E10060", VA = "0x186E10C60")]
	public static void OHHKHPBIMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F3D0", Offset = "0x6E0E7D0", VA = "0x186E0F3D0")]
	public static void BEBFCIEMOHC(GameObject ACCHLMHAAEK, RenderTexture KFJIEAHMGBG, ImposterRenderConfig GAIMJEFECMK, PKJMAMEGDAF IKIFJPHLGFO, [Optional] Vector3? NAPBBAFNIOL, [Optional] Vector3? KDBFDHNKNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E104C0", Offset = "0x6E0F8C0", VA = "0x186E104C0")]
	private static void KLCGFCDKIBA(GameObject ACCHLMHAAEK, RenderTexture KFJIEAHMGBG, ImposterRenderConfig GAIMJEFECMK, PKJMAMEGDAF IKIFJPHLGFO, Vector3 NAPBBAFNIOL, Vector3 KDBFDHNKNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F110", Offset = "0x6E0E510", VA = "0x186E0F110")]
	private static void AHPPHBLIACB(GameObject ACCHLMHAAEK, Vector3 GKEGCHEBEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E10D40", Offset = "0x6E10140", VA = "0x186E10D40")]
	private static void OMLOKNAAHFL(GameObject PJJHJGOPMNC, ImposterRenderConfig GAIMJEFECMK, PKJMAMEGDAF IKIFJPHLGFO, [Out] Vector3 PGKCNOBAHOO, [Out] Quaternion FKHIKDLIGKE, [Out] float DJPDLCJLBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E10B40", Offset = "0x6E0FF40", VA = "0x186E10B40")]
	public static RenderTexture NNODCFIENHP(int ODBPFGKPHPK, int HDEGPKKBOJG, RenderTextureFormat BJFFNJGHPDD = RenderTextureFormat.ARGB32, string CPJLOKGJNCF = "[ImposterRendering]Preview")
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
		public struct MDICKIIGGBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public PMBKNNIBFAH DHGLJHJPHNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GameObject MGPNIEEIKBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RenderTexture MMPBGODNKAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ImposterRenderConfig NADCJCECIAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public PKJMAMEGDAF PKJMAMEGDAF;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6E15BF0", Offset = "0x6E14FF0", VA = "0x186E15BF0")]
			public MDICKIIGGBF(PMBKNNIBFAH COBENJPHIFN, GameObject NNKPOGAGGGJ, RenderTexture KFJIEAHMGBG, ImposterRenderConfig IHHLAJEDFGJ, PKJMAMEGDAF IKIFJPHLGFO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ABDOPOACKOD<MDICKIIGGBF, RenderTexture> IOFGLNADHIO;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly List<MDICKIIGGBF> GFELEANPGOJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int CKKOFJMCLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6E11BA0", Offset = "0x6E10FA0", VA = "0x186E11BA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E11CC0", Offset = "0x6E110C0", VA = "0x186E11CC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ACCHLMHAAEK, RenderTexture KFJIEAHMGBG, ImposterRenderConfig GAIMJEFECMK, PKJMAMEGDAF IKIFJPHLGFO, CancellationToken EEHACKMODLA, bool HEMJOAMIEDJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E116F0", Offset = "0x6E10AF0", VA = "0x186E116F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E11C30", Offset = "0x6E11030", VA = "0x186E11C30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E11900", Offset = "0x6E10D00", VA = "0x186E11900")]
		private static Task<RenderTexture> DPNIFLJEBAN(MDICKIIGGBF HKADJCKGABN, CancellationToken EEHACKMODLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E120C0", Offset = "0x6E114C0", VA = "0x186E120C0")]
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
