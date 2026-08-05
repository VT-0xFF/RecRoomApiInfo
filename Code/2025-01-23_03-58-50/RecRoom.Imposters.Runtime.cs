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
	private readonly struct IFOMOJHAFMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JENHFNOJPID OEGDOIECPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FEFBPCBFNHA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
		public IFOMOJHAFMG(JENHFNOJPID LOBAONFAKPG, string CANHCNAPBAJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct GDKHKNIHJKN : IAsyncStateMachine
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
		public IFOMOJHAFMG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D080", Offset = "0x6F7B880", VA = "0x186F7D080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D440", Offset = "0x6F7BC40", VA = "0x186F7D440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider PENIBOGOEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DIOBCJNAFIC<IFOMOJHAFMG, GameObject> MALKNEHALNO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BJLNGGPCMBA EGPJBIANAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DIOBCJNAFIC<IFOMOJHAFMG, GameObject> IPKJMFPJNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BF80", Offset = "0x6F7A780", VA = "0x186F7BF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int FBAGIJLMKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BB00", Offset = "0x6F7A300", VA = "0x186F7BB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BB50", Offset = "0x6F7A350", VA = "0x186F7BB50", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BDF0", Offset = "0x6F7A5F0", VA = "0x186F7BDF0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BE60", Offset = "0x6F7A660", VA = "0x186F7BE60")]
	[AsyncStateMachine(typeof(GDKHKNIHJKN))]
	private Task<GameObject> PHGFMKNIICD(IFOMOJHAFMG FJOMPEHBBGA, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BC30", Offset = "0x6F7A430", VA = "0x186F7BC30")]
	public Task<GameObject> LoadItemAsync(JENHFNOJPID LOBAONFAKPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C0E0", Offset = "0x6F7A8E0", VA = "0x186F7C0E0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EMIFEIPDGMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JENHFNOJPID CFKDIDFJINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture PCBEOIDFFMN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
		public EMIFEIPDGMB(JENHFNOJPID IEKOCNNGHMK, Texture NOCDIJBAKKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum GMPMHKHKIKL
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
	private class ABKFBIEHPHJ : JNPENALPLEJ<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AMPGFPAGEJL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public ABKFBIEHPHJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F77E70", Offset = "0x6F76670", VA = "0x186F77E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F78660", Offset = "0x6F76E60", VA = "0x186F78660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly JENHFNOJPID IEKOCNNGHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FFJDHDDBCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BFCIJLHNEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken ALKEMFHOMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D GKINMJLKALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject HCBGGDECDLP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override AKLEHMINLPM<Texture2D> GGPFDBFAEBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F77B20", Offset = "0x6F76320", VA = "0x186F77B20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> DINENAACBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F77CA0", Offset = "0x6F764A0", VA = "0x186F77CA0")]
		public ABKFBIEHPHJ(JENHFNOJPID IEKOCNNGHMK, RenderTexture FFJDHDDBCKI, ImposterRenderConfig BFCIJLHNEAM, CancellationToken ALKEMFHOMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F77BB0", Offset = "0x6F763B0", VA = "0x186F77BB0")]
		[AsyncStateMachine(typeof(AMPGFPAGEJL))]
		private Task<Texture2D> KLHHCLOIPAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F77B80", Offset = "0x6F76380", VA = "0x186F77B80", Slot = "10")]
		protected override void JBCFBIMMJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F77AA0", Offset = "0x6F762A0", VA = "0x186F77AA0")]
		private static void EICALPCNHCM(GameObject HCBGGDECDLP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GGALPCPICGD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6F7D4B0", Offset = "0x6F7BCB0", VA = "0x186F7D4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
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
	[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private GMPMHKHKIKL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[HIDMLHMKHPD("size", GMPMHKHKIKL.Custom)]
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
	private static int BOFNAPNFJFL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture DEJEGJCGCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PCFDAELHKEJ<GameObject> NEPGNBLODIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private DGGJLAPANLP LCMIDHOHDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OENGEKBIAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MGNFCCKNAGM<Texture2D> GEHPPFKFOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JENHFNOJPID AFCAOEJLJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture HLBKBCDDAMM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int ENOPCGIAGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EC50", Offset = "0x6F7D450", VA = "0x186F7EC50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ECA0", Offset = "0x6F7D4A0", VA = "0x186F7ECA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture NFKONIKNGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E240", Offset = "0x6F7CA40", VA = "0x186F7E240")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BB250", Offset = "0x8B9A50", VA = "0x1808BB250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JENHFNOJPID CFKDIDFJINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5D30", VA = "0x1808B7530")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E650", Offset = "0x6F7CE50", VA = "0x186F7E650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool EPDLJHFBIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B1C800", Offset = "0x1B1B000", VA = "0x181B1C800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int BGGEGOEDDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E5B0", Offset = "0x6F7CDB0", VA = "0x186F7E5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E220", Offset = "0x6F7CA20", VA = "0x186F7E220")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E830", Offset = "0x6F7D030", VA = "0x186F7E830")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E7B0", Offset = "0x6F7CFB0", VA = "0x186F7E7B0")]
	private void LKBAJOACACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EB20", Offset = "0x6F7D320", VA = "0x186F7EB20")]
	public void Set(JENHFNOJPID HJPJOBJFFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EB30", Offset = "0x6F7D330", VA = "0x186F7EB30")]
	public void Set(Texture NOCDIJBAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EB40", Offset = "0x6F7D340", VA = "0x186F7EB40")]
	public void Set(EMIFEIPDGMB INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E230", Offset = "0x6F7CA30", VA = "0x186F7E230")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E930", Offset = "0x6F7D130", VA = "0x186F7E930")]
	public void SetInternal(JENHFNOJPID HJPJOBJFFKG, [Optional] Texture BLEAKEGECMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E920", Offset = "0x6F7D120", VA = "0x186F7E920")]
	public void SetCustomSize(int CFCNOIBBLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C1910", Offset = "0x8C0110", VA = "0x1808C1910")]
	public void SetAntiAliasing(int DLMAGAIPPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E420", Offset = "0x6F7CC20", VA = "0x186F7E420")]
	[AsyncStateMachine(typeof(GGALPCPICGD))]
	private void EEBBBDGHEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E4D0", Offset = "0x6F7CCD0", VA = "0x186F7E4D0")]
	private void EFIKHFNLFMB(Texture NOCDIJBAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EBD0", Offset = "0x6F7D3D0", VA = "0x186F7EBD0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, GDEMBBDANBF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float NDJIBJJALPL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	public void PrepareImposter(CJKLECJLEBD OFGFBCNFINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E1E0", Offset = "0x6F7C9E0", VA = "0x186F7E1E0")]
	public void SetReferencePoint(Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DFF0", Offset = "0x6F7C7F0", VA = "0x186F7DFF0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E1C0", Offset = "0x6F7C9C0", VA = "0x186F7E1C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x19C0660", Offset = "0x19BEE60", VA = "0x1819C0660")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GDKECMJKPJA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static GDKECMJKPJA PJLBKCMACJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float KCLFAPCGPGM;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x251B480", Offset = "0x2519C80", VA = "0x18251B480")]
	public GDKECMJKPJA(float EIPGFKGMIKC)
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
		[Cpp2IlInjected.Address(RVA = "0x6F7F560", Offset = "0x6F7DD60", VA = "0x186F7F560", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
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
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MFEJIBEDCHM = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int NJIFEOHGFDL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> MABLJJDIAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool HFFIGDGFLCK;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EEC0", Offset = "0x6F7D6C0", VA = "0x186F7EEC0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EDC0", Offset = "0x6F7D5C0", VA = "0x186F7EDC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F100", Offset = "0x6F7D900", VA = "0x186F7F100")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JENHFNOJPID
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string MEFODPMAJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GDKECMJKPJA GDKECMJKPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DEAMAMEJFMH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> FKODNOEAHJP(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAPEIAJBKIH(JENHFNOJPID LIHCAHPMPHD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKBKOMEMNLK();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDKHGIBLAAB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NNAGDPNCGDO(uint? ELHHAGDPHIM, [Out] MGNFCCKNAGM<Texture2D> MLJDCDNMLOI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KFIFFJMNLLK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F190", Offset = "0x6F7D990", VA = "0x186F7F190")]
	public static bool NJKIMFNENKG(JENHFNOJPID DADFMMNNEJD, JENHFNOJPID DLMGMPKGBFC)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, GDEMBBDANBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6F786D0", Offset = "0x6F76ED0", VA = "0x186F786D0", Slot = "4")]
		public void PrepareImposter(CJKLECJLEBD OFGFBCNFINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GDEMBBDANBF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(CJKLECJLEBD OFGFBCNFINC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KBFJLFKIPAE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DONFCPCFFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NGPMIDKBHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BJLNGGPCMBA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKEEPHHJCIJ(params Type[] HNDDCEOKKGP);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JAKEDJEALEB(GameObject CBJCLOIGING, Transform NCCLECGLDAO, bool AANEPCNFJMF = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JAKEDJEALEB<T>(T CBJCLOIGING, Transform NCCLECGLDAO, bool AANEPCNFJMF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JAKEDJEALEB<T>(GameObject CBJCLOIGING, Transform NCCLECGLDAO, bool AANEPCNFJMF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject JAKEDJEALEB(GameObject CBJCLOIGING, Transform NCCLECGLDAO, CJKLECJLEBD OFGFBCNFINC, bool AANEPCNFJMF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FHEEPIPJHLB : IDisposable, BJLNGGPCMBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LOEKGAEMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> JDGNMBOEEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform ANHODFOANHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> BJEOHJKKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DBNJKNOKNKB;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C5F0", Offset = "0x6F7ADF0", VA = "0x186F7C5F0")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	public static void NJDIOBPBJFD(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CB90", Offset = "0x6F7B390", VA = "0x186F7CB90")]
	[UnityEngine.Scripting.Preserve]
	public FHEEPIPJHLB([NDCFMLCHJCI(null)] KBFJLFKIPAE HNFEFKCPLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C120", Offset = "0x6F7A920", VA = "0x186F7C120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C5A0", Offset = "0x6F7ADA0", VA = "0x186F7C5A0", Slot = "5")]
	public void MKEEPHHJCIJ(params Type[] HNDDCEOKKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C400", Offset = "0x6F7AC00", VA = "0x186F7C400", Slot = "6")]
	public GameObject JAKEDJEALEB(GameObject CBJCLOIGING, Transform NCCLECGLDAO, bool AANEPCNFJMF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3064270", Offset = "0x3062A70", VA = "0x183064270", Slot = "7")]
	public T JAKEDJEALEB<T>(T CBJCLOIGING, Transform NCCLECGLDAO, bool AANEPCNFJMF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x30648E0", Offset = "0x30630E0", VA = "0x1830648E0", Slot = "8")]
	public T JAKEDJEALEB<T>(GameObject CBJCLOIGING, Transform NCCLECGLDAO, bool AANEPCNFJMF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C370", Offset = "0x6F7AB70", VA = "0x186F7C370", Slot = "9")]
	public GameObject JAKEDJEALEB(GameObject CBJCLOIGING, Transform NCCLECGLDAO, CJKLECJLEBD OFGFBCNFINC, bool AANEPCNFJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3064300", Offset = "0x3062B00", VA = "0x183064300", Slot = "10")]
	public T JAKEDJEALEB<T>(GameObject CBJCLOIGING, Transform NCCLECGLDAO, CJKLECJLEBD OFGFBCNFINC, bool AANEPCNFJMF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3064360", Offset = "0x3062B60", VA = "0x183064360")]
	private T JAKEDJEALEB<T>(GameObject CBJCLOIGING, Transform NCCLECGLDAO, CJKLECJLEBD OFGFBCNFINC, bool AANEPCNFJMF, [Out] GameObject BKBAEJMEIDF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3064930", Offset = "0x3063130", VA = "0x183064930")]
	private T MPJMMKGMJPO<T>(GameObject PBJIFBOBIOP, CJKLECJLEBD OFGFBCNFINC, bool AANEPCNFJMF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C490", Offset = "0x6F7AC90", VA = "0x186F7C490")]
	private void KAJMNHLDKHD(Component FGOJHDGPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C6E0", Offset = "0x6F7AEE0", VA = "0x186F7C6E0")]
	private void PBBNNJEODMK(Component FGOJHDGPHCJ, CJKLECJLEBD OFGFBCNFINC, bool AANEPCNFJMF, bool MJONPNLLFBO, [Optional] Type OGONMCOPBFM, [Optional] Type ONBMGJNOMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C200", Offset = "0x6F7AA00", VA = "0x186F7C200")]
	private void FHEDKLCBHCI(GameObject PBJIFBOBIOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CJKLECJLEBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> NKDGKFOHKCD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E66880", Offset = "0x2E65080", VA = "0x182E66880")]
	public CJKLECJLEBD KLHHFEENEBM<T>(T LOHOEKHEACH)
	{
		return default(CJKLECJLEBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E65FA0", Offset = "0x2E647A0", VA = "0x182E65FA0")]
	public T EFGCOGNKKLM<T>(T DFEJJOPGBKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E660B0", Offset = "0x2E648B0", VA = "0x182E660B0")]
	public bool GKNHABNOIHP<T>([Out] T LOHOEKHEACH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LIAOECMHEOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool AMHKJHCJEPN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x251B6A0", Offset = "0x2519EA0", VA = "0x18251B6A0")]
	public LIAOECMHEOI(bool ABHIOFFCNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ACKEJFHBPDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool KMFKEGKJPEI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F77E60", Offset = "0x6F76660", VA = "0x186F77E60")]
	public ACKEJFHBPDA(bool JAFIBEIFLGF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, GDEMBBDANBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F2A0", Offset = "0x6F7DAA0", VA = "0x186F7F2A0", Slot = "4")]
		public void PrepareImposter(CJKLECJLEBD OFGFBCNFINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
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
		public Bounds CDKEAJPAACJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F7DE60", Offset = "0x6F7C660", VA = "0x186F7DE60")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DE20", Offset = "0x6F7C620", VA = "0x186F7DE20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DDE0", Offset = "0x6F7C5E0", VA = "0x186F7DDE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DCF0", Offset = "0x6F7C4F0", VA = "0x186F7DCF0")]
		private void JBMGIOBAIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
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
				[Cpp2IlInjected.Address(RVA = "0x6F7F280", Offset = "0x6F7DA80", VA = "0x186F7F280")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7F270", Offset = "0x6F7DA70", VA = "0x186F7F270")]
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
		[HIDMLHMKHPD("frameCameraToImposterBounds", true)]
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
		[HIDMLHMKHPD("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x6F7ED20", Offset = "0x6F7D520", VA = "0x186F7ED20")]
		public void KHGAAKCLADJ(Vector3 PJKGBAIBAOB, Quaternion DNPGNJKAIAO, float DBAPACGFDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ED50", Offset = "0x6F7D550", VA = "0x186F7ED50")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class DEFKMCMLAOI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 DEOABDDECNM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> KBACJNKMJLG;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> DKOHCJOELCG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera CFIIIKLELJL;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> EMNGEIIDIFH;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> MNCKOFMENOC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode DIJMPKMCOPK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color IKHDPBEFECN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color GMCILJIGCJB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color LFLIMDHIDMB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap DMKEGGNAKAA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool GLBLEOGMLIC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> NKKFOHOEIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F79E40", Offset = "0x6F78640", VA = "0x186F79E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> CMBPJHBFKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F79D10", Offset = "0x6F78510", VA = "0x186F79D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LFBLHCCMPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A1B0", Offset = "0x6F789B0", VA = "0x186F7A1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F7ABF0", Offset = "0x6F793F0", VA = "0x186F7ABF0")]
	public static void PBNDKEOJACO(Vector3 HDMBLKDKHHE, Quaternion HFFBKCHPFOP, ImposterRenderConfig LKHHFCKMEFF, bool BOFCMJMGFBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F79E90", Offset = "0x6F78690", VA = "0x186F79E90")]
	private static void JHFNBHBCBAK(Vector3 HDMBLKDKHHE, Quaternion HFFBKCHPFOP, URPLight KEDHHJNMFEM, ImposterRenderConfig.LightConfig JOCIEAFLFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F79D60", Offset = "0x6F78560", VA = "0x186F79D60")]
	public static void JFEMIEJIIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F78B00", Offset = "0x6F77300", VA = "0x186F78B00")]
	private static void BGPJCILNDIO(int DONENLADOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A4F0", Offset = "0x6F78CF0", VA = "0x186F7A4F0")]
	public static void MIKEKGAFKKC(ImposterRenderConfig LKHHFCKMEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A400", Offset = "0x6F78C00", VA = "0x186F7A400")]
	public static void LOFPEICJBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F78F30", Offset = "0x6F77730", VA = "0x186F78F30")]
	public static void DDFPEAHFCJK(GameObject GMEJGJLAICL, RenderTexture FFJDHDDBCKI, ImposterRenderConfig LKHHFCKMEFF, GDKECMJKPJA NBFPGOEIFHA, [Optional] Vector3? JIHGILCHBFK, [Optional] Vector3? MDDNOHLHFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F79270", Offset = "0x6F77A70", VA = "0x186F79270")]
	private static void DFKCNJIHNGE(GameObject GMEJGJLAICL, RenderTexture FFJDHDDBCKI, ImposterRenderConfig LKHHFCKMEFF, GDKECMJKPJA NBFPGOEIFHA, Vector3 JIHGILCHBFK, Vector3 MDDNOHLHFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F78820", Offset = "0x6F77020", VA = "0x186F78820")]
	private static void AANKKHNEAGI(GameObject GMEJGJLAICL, Vector3 CNGCAPCOIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F799A0", Offset = "0x6F781A0", VA = "0x186F799A0")]
	public static void GEMDEEOJDBM(Bounds DCLIOIELJBN, ImposterRenderConfig LKHHFCKMEFF, [Out] Vector3 KFIDOLGJLIM, [Out] Quaternion MLEGKHMKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A6C0", Offset = "0x6F78EC0", VA = "0x186F7A6C0")]
	private static void MJPMIBBLNNP(GameObject CBJCLOIGING, ImposterRenderConfig LKHHFCKMEFF, GDKECMJKPJA NBFPGOEIFHA, [Out] Vector3 KFIDOLGJLIM, [Out] Quaternion MLEGKHMKFFC, [Out] float AMGADEBPPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F798D0", Offset = "0x6F780D0", VA = "0x186F798D0")]
	public static RenderTexture FAMJHALEJJM(int NNLGEFDHEAN, int AKHNFOHBNBN, RenderTextureFormat AENEDEDOEJK = RenderTextureFormat.ARGB32, string FFGIKNMJJHD = "[ImposterRendering]Preview")
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
		public struct FIKEJHIKDAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CGKMABONNJI DIAAJKPMBJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject PBOLEPJFDIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture NFKONIKNGKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig DICICCMDBOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public GDKECMJKPJA GDKECMJKPJA;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6F7CFD0", Offset = "0x6F7B7D0", VA = "0x186F7CFD0")]
			public FIKEJHIKDAJ(CGKMABONNJI GPMIEMJMELH, GameObject BJGIHKDMHGD, RenderTexture FFJDHDDBCKI, ImposterRenderConfig BFCIJLHNEAM, GDKECMJKPJA NBFPGOEIFHA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static DIOBCJNAFIC<FIKEJHIKDAJ, RenderTexture> BIIMPGGEDFF;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<FIKEJHIKDAJ> AGBAFKMAFGB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int AIMAEPALHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B570", Offset = "0x6F79D70", VA = "0x186F7B570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B6A0", Offset = "0x6F79EA0", VA = "0x186F7B6A0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GMEJGJLAICL, RenderTexture FFJDHDDBCKI, ImposterRenderConfig LKHHFCKMEFF, GDKECMJKPJA NBFPGOEIFHA, CancellationToken ALKEMFHOMCA, bool EFDPMGDMHPO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B0C0", Offset = "0x6F798C0", VA = "0x186F7B0C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B600", Offset = "0x6F79E00", VA = "0x186F7B600", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B2D0", Offset = "0x6F79AD0", VA = "0x186F7B2D0")]
		private static Task<RenderTexture> HACPMHFMOOE(FIKEJHIKDAJ IJKKCMDJHHO, CancellationToken ALKEMFHOMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BAC0", Offset = "0x6F7A2C0", VA = "0x186F7BAC0")]
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
