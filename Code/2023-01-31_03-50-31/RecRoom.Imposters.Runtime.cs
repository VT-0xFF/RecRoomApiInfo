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
	private readonly struct ODADDDANONN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NHLNPJPMLFA MKKGLKGNJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string GDINNMGOBPM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDAC5C0", Offset = "0xDAB3C0", VA = "0x180DAC5C0")]
		public ODADDDANONN(NHLNPJPMLFA HFICFKCMFGB, string HCLELAHKMCM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct IGMFCJKHOOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public ODADDDANONN queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x20EE2D0", Offset = "0x20ED0D0", VA = "0x1820EE2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x20EE610", Offset = "0x20ED410", VA = "0x1820EE610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider CIACOJLJOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::FMDELPMLIIP<ODADDDANONN, GameObject> HJCOCGBAHDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HKELJJJKLJG JLCMEDBPLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::FMDELPMLIIP<ODADDDANONN, GameObject> EKOGPMHPOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x20EC460", Offset = "0x20EB260", VA = "0x1820EC460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int ECGCBDKICOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x20EC670", Offset = "0x20EB470", VA = "0x1820EC670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20EC5C0", Offset = "0x20EB3C0", VA = "0x1820EC5C0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20EC9E0", Offset = "0x20EB7E0", VA = "0x1820EC9E0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x20EC6C0", Offset = "0x20EB4C0", VA = "0x1820EC6C0")]
	[AsyncStateMachine(typeof(IGMFCJKHOOI))]
	private Task<GameObject> JPPGBEMJIIN(ODADDDANONN HIHCEPOKDHO, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x20EC810", Offset = "0x20EB610", VA = "0x1820EC810")]
	public Task<GameObject> LoadItemAsync(NHLNPJPMLFA HFICFKCMFGB, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x20ECA50", Offset = "0x20EB850", VA = "0x1820ECA50")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class JNGOGBNECEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public NHLNPJPMLFA KCDLEMBLGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture EDIIDDNIPHM;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B2C40", Offset = "0x6B1A40", VA = "0x1806B2C40")]
		public JNGOGBNECEN(NHLNPJPMLFA IECNMCAJNAO, Texture OLCMNMBHAKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PLICCELEAOM
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
	private class KKENBFGIIPL : global::DMMEEHPGKIP<Texture>, FECLEKCPFKC, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IDECCILMMIM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public KKENBFGIIPL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x20ECBA0", Offset = "0x20EB9A0", VA = "0x1820ECBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x20ED2A0", Offset = "0x20EC0A0", VA = "0x1820ED2A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly NHLNPJPMLFA IECNMCAJNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture PDDLJOCHIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig JBEOMNDDOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken NIEOBBGKEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject HGOBKCKBLKI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CCBLCAIHLNA FGFGGHKHEGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x20EFC30", Offset = "0x20EEA30", VA = "0x1820EFC30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::MMBCCHGMCHN<Texture> DCCGELIINBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x20EFBD0", Offset = "0x20EE9D0", VA = "0x1820EFBD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task PJLPMOENIBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> CLLIFJEHONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x20EFDF0", Offset = "0x20EEBF0", VA = "0x1820EFDF0")]
		public KKENBFGIIPL(NHLNPJPMLFA IECNMCAJNAO, RenderTexture PDDLJOCHIHI, ImposterRenderConfig JBEOMNDDOCO, CancellationToken NIEOBBGKEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x20EFC40", Offset = "0x20EEA40", VA = "0x1820EFC40")]
		[AsyncStateMachine(typeof(IDECCILMMIM))]
		private Task<Texture> IHJPPDIBOKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x20EFC20", Offset = "0x20EEA20", VA = "0x1820EFC20", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x20EFD60", Offset = "0x20EEB60", VA = "0x1820EFD60")]
		private static void MFJDODOHMAM(GameObject HGOBKCKBLKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DDPDILIEHMB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x20EB3A0", Offset = "0x20EA1A0", VA = "0x1820EB3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x775510", Offset = "0x774310", VA = "0x180775510", Slot = "5")]
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
	[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private PLICCELEAOM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[NPKFCCIFOGK("size", 0)]
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
	private RenderTexture DIKJFIFAKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::AMIHAOIHCDH<GameObject> MBFKBKIDPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private JEMCAFGLPLG GLHHAIKGKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource ANGOLJLDKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::DMMEEHPGKIP<Texture> PDKEOFLMHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NHLNPJPMLFA CMPCKKHFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture BHGCCADDLLH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture AINHCLOJPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x20EE990", Offset = "0x20ED790", VA = "0x1820EE990")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x73C1F0", Offset = "0x73AFF0", VA = "0x18073C1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private NHLNPJPMLFA KCDLEMBLGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77D700", Offset = "0x77C500", VA = "0x18077D700")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x20EEB00", Offset = "0x20ED900", VA = "0x1820EEB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool LNPAADJOLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13BAA50", Offset = "0x13B9850", VA = "0x1813BAA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int EFPHCHKKBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x20EE880", Offset = "0x20ED680", VA = "0x1820EE880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x20EE870", Offset = "0x20ED670", VA = "0x1820EE870")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20EEC50", Offset = "0x20EDA50", VA = "0x1820EEC50")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20EEE10", Offset = "0x20EDC10", VA = "0x1820EEE10")]
	private void PKKKBJEGFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x20EF0D0", Offset = "0x20EDED0", VA = "0x1820EF0D0")]
	public void Set(NHLNPJPMLFA HIOGMEKGDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20EF120", Offset = "0x20EDF20", VA = "0x1820EF120")]
	public void Set(Texture OLCMNMBHAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20EF0E0", Offset = "0x20EDEE0", VA = "0x1820EF0E0")]
	public void Set(JNGOGBNECEN DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x20EE890", Offset = "0x20ED690", VA = "0x1820EE890")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x20EEEB0", Offset = "0x20EDCB0", VA = "0x1820EEEB0")]
	public void SetInternal(NHLNPJPMLFA HIOGMEKGDKM, [Optional] Texture PGGHIOMMKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x20EEEA0", Offset = "0x20EDCA0", VA = "0x1820EEEA0")]
	public void SetCustomSize(int KNLDCGJCJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x73C470", Offset = "0x73B270", VA = "0x18073C470")]
	public void SetAntiAliasing(int HGMFDHNKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x20EED40", Offset = "0x20EDB40", VA = "0x1820EED40")]
	[AsyncStateMachine(typeof(DDPDILIEHMB))]
	private void PEKDIPDMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x20EE8A0", Offset = "0x20ED6A0", VA = "0x1820EE8A0")]
	private void FGEDAAEPAKM(Texture OLCMNMBHAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x20EF130", Offset = "0x20EDF30", VA = "0x1820EF130")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, EIOGPNBODKM
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float DFEEICIFEFJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
	public void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x20EE830", Offset = "0x20ED630", VA = "0x1820EE830")]
	public void SetReferencePoint(Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20EE6A0", Offset = "0x20ED4A0", VA = "0x1820EE6A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x20EE800", Offset = "0x20ED600", VA = "0x1820EE800")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9A20", Offset = "0x1DE8820", VA = "0x181DE9A20")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IHDKPOEEKBM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static IHDKPOEEKBM AMJOFGCMDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float ECFJNEAIHAM;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8F65C0", Offset = "0x8F53C0", VA = "0x1808F65C0")]
	public IHDKPOEEKBM(float HCBPHPMFPJB)
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
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int BNDKFKFCGLB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int KHBHJLFGAAG = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> CMBPDPJJLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool EFDFGPNHODF;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x20EF2E0", Offset = "0x20EE0E0", VA = "0x1820EF2E0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x20EF1F0", Offset = "0x20EDFF0", VA = "0x1820EF1F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x20EF520", Offset = "0x20EE320", VA = "0x1820EF520")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NHLNPJPMLFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string KAAOCMOPGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IHDKPOEEKBM IHDKPOEEKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DGOHFGPHBHG;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NMHAFOAECDH(CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKHEBADIFPK(NHLNPJPMLFA KICLNADFIEK);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGAJNLEMAII();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCGEOFBCHGD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OCHJJCNBBGJ(out global::DMMEEHPGKIP<Texture> ECDFGMENLEA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HACJODBKGPD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20ECAC0", Offset = "0x20EB8C0", VA = "0x1820ECAC0")]
	public static bool GDIPLPJJOLI(NHLNPJPMLFA LAGLEHPKMDH, NHLNPJPMLFA GCNIOGGHPPA)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, EIOGPNBODKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x20EB240", Offset = "0x20EA040", VA = "0x1820EB240", Slot = "4")]
		public void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EIOGPNBODKM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IJDGDANDEMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NPGHLJCICFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> MPNOGFNPBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HKELJJJKLJG
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFAMMMBMLFC(params Type[] ELKKGBGGKPO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFJIDCBOMBL(params Type[] ELKKGBGGKPO);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IDMDOFLEHHL : IDisposable, HKELJJJKLJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> HAJFEKAEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> CIJPHDCEOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform IAGGJPDEEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> MHCPLNOMIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CHFCKOKDPDF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x20ED710", Offset = "0x20EC510", VA = "0x1820ED710")]
	[EJICMPGFCBP(CIKEJIGJNLD.None)]
	public static void MCFDGBFIIAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x20EDE90", Offset = "0x20ECC90", VA = "0x1820EDE90")]
	[Preserve]
	public IDMDOFLEHHL([ELDNEOCBGIN(null)] IJDGDANDEMG PEOIOCGBCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x20ED450", Offset = "0x20EC250", VA = "0x1820ED450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x20ED5A0", Offset = "0x20EC3A0", VA = "0x1820ED5A0", Slot = "5")]
	public void JFAMMMBMLFC(params Type[] ELKKGBGGKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x20ED550", Offset = "0x20EC350", VA = "0x1820ED550", Slot = "6")]
	public void HFJIDCBOMBL(params Type[] ELKKGBGGKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20ED5F0", Offset = "0x20EC3F0", VA = "0x1820ED5F0", Slot = "7")]
	public GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x369DF00", Offset = "0x369CD00", VA = "0x18369DF00", Slot = "8")]
	public T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x369DFC0", Offset = "0x369CDC0", VA = "0x18369DFC0", Slot = "9")]
	public T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20ED680", Offset = "0x20EC480", VA = "0x1820ED680", Slot = "10")]
	public GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x369DF70", Offset = "0x369CD70", VA = "0x18369DF70", Slot = "11")]
	public T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x369D940", Offset = "0x369C740", VA = "0x18369D940", Slot = "12")]
	public T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x369D9D0", Offset = "0x369C7D0", VA = "0x18369D9D0")]
	private T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN, out GameObject LDLLIAHIJOC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x369D3E0", Offset = "0x369C1E0", VA = "0x18369D3E0")]
	private T HFNPAMLMIBL<T>(GameObject NCAOMIEGHPA, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x20ED810", Offset = "0x20EC610", VA = "0x1820ED810")]
	private void OJJEOBIECKM(Component KMJCJNGOPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x20ED940", Offset = "0x20EC740", VA = "0x1820ED940")]
	private void OPNJKBLGAKB(Component KMJCJNGOPHM, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN, bool GJJACLLNMMJ, [Optional] Type DDDHOEGHJCI, [Optional] Type BAEFBFCLGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20ED2F0", Offset = "0x20EC0F0", VA = "0x1820ED2F0")]
	private void BLGHLJALFDD(GameObject NCAOMIEGHPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ANFKOBHJBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> BEOMPJGIPAF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3600FB0", Offset = "0x35FFDB0", VA = "0x183600FB0")]
	public ANFKOBHJBDA FAFPJPFNCCD<T>(T ONHHPHCFHJN)
	{
		return default(ANFKOBHJBDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3600E90", Offset = "0x35FFC90", VA = "0x183600E90")]
	public T CIGAFCHFFML<T>(T PGBDPKDFJME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36016E0", Offset = "0x36004E0", VA = "0x1836016E0")]
	public bool MDMOKHFDALA<T>(out T ONHHPHCFHJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FONKMOIHLCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool KJGCEEBHHGN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6D010", VA = "0x180A6E210")]
	public FONKMOIHLCA(bool JPALJPBPKCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PJAJINMHKOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool DNOOOGKJMJP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x20EFFC0", Offset = "0x20EEDC0", VA = "0x1820EFFC0")]
	public PJAJINMHKOH(bool FLCBDDCGHLF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, EIOGPNBODKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x20F2150", Offset = "0x20F0F50", VA = "0x1820F2150", Slot = "4")]
		public void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x20EFFA0", Offset = "0x20EEDA0", VA = "0x1820EFFA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x20EFF90", Offset = "0x20EED90", VA = "0x1820EFF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x20EF1B0", Offset = "0x20EDFB0", VA = "0x1820EF1B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PMDLMNFEKDE
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> DPLIEKILMJB;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 OGNBLIKFMOJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 LFAPJFIGMAI;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera IIOHPLDADAL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string GHLKBJKGPMD = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const DAHFCCFBOLK LOPPPHEJBCG = DAHFCCFBOLK.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> HAJJCDEGFAO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode FAPIMBDHMIN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color HIJCNNMINDN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color POIIIFGHDBP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color LAGBLLMIFPB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap DBPNFFJACAL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool ELDPALHJFFM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera IPGCEJBAAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x20F0170", Offset = "0x20EEF70", VA = "0x1820F0170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x20F12C0", Offset = "0x20F00C0", VA = "0x1820F12C0")]
	public static void LKJNKCPHFHK(Vector3 LAKLOBEJDAI, Quaternion AEEBOLOKJJC, ImposterRenderConfig ILLGLKOBHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x20F0FB0", Offset = "0x20EFDB0", VA = "0x1820F0FB0")]
	private static void LCPKKPMPKAO(Vector3 LAKLOBEJDAI, Quaternion AEEBOLOKJJC, URPLight FCEBMPIPALJ, ImposterRenderConfig.LightConfig JCFPCJHANDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x20F06F0", Offset = "0x20EF4F0", VA = "0x1820F06F0")]
	public static void IGKDCODBPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x20F18F0", Offset = "0x20F06F0", VA = "0x1820F18F0")]
	private static void OKNHKOLKIIH(int DLFEMGDIGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x20F0570", Offset = "0x20EF370", VA = "0x1820F0570")]
	public static void GODCKKEBKDP(ImposterRenderConfig ILLGLKOBHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x20F1540", Offset = "0x20F0340", VA = "0x1820F1540")]
	public static void MEHNMGOMLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x20F03A0", Offset = "0x20EF1A0", VA = "0x1820F03A0")]
	public static void CDLHOPBGENM(GameObject GAPLDMNMIKA, RenderTexture PDDLJOCHIHI, ImposterRenderConfig ILLGLKOBHMD, IHDKPOEEKBM MLJMGIEPDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x20F07E0", Offset = "0x20EF5E0", VA = "0x1820F07E0")]
	private static void JNLEGCEEGDB(GameObject GAPLDMNMIKA, RenderTexture PDDLJOCHIHI, ImposterRenderConfig ILLGLKOBHMD, IHDKPOEEKBM MLJMGIEPDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x20F1640", Offset = "0x20F0440", VA = "0x1820F1640")]
	private static void MHCIOLFKEIF(GameObject GAPLDMNMIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x20EFFD0", Offset = "0x20EEDD0", VA = "0x1820EFFD0")]
	public static void BDKEKMGDAHB(List<Renderer> DJELLLDCBJI, List<Material> MJFLJMJJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x20F1CC0", Offset = "0x20F0AC0", VA = "0x1820F1CC0")]
	public static void PLHNFLONECK(GameObject GLJOCEFKOFB, Vector3 LKIOECLOHGG, Vector3 EOKPOCBFDID, float MDDBACJHGLE, IHDKPOEEKBM MLJMGIEPDEF, out Vector3 HFHGBNKDHOF, out Quaternion DPBOMEHKHON, out float GBOPOJGLIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x20F0F10", Offset = "0x20EFD10", VA = "0x1820F0F10")]
	public static RenderTexture KEKKIAHHLLL(int LBHCEBCJMEF, int MMPBKAKMEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x20F0CE0", Offset = "0x20EFAE0", VA = "0x1820F0CE0")]
	public static void KEDAAHEODIG()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct PPLHCHFEBDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public HGIFEALIPIB NOFEKBFPLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject DIILDKICCDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture AINHCLOJPJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig HOCDEMDOHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public IHDKPOEEKBM IHDKPOEEKBM;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x20F20E0", Offset = "0x20F0EE0", VA = "0x1820F20E0")]
			public PPLHCHFEBDH(HGIFEALIPIB HNFKIAKOCJI, GameObject LCAKFMIKAHF, RenderTexture PDDLJOCHIHI, ImposterRenderConfig JBEOMNDDOCO, IHDKPOEEKBM MLJMGIEPDEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::FMDELPMLIIP<PPLHCHFEBDH, RenderTexture> MIKHNCEFLEJ;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<PPLHCHFEBDH> GIMJGKAEOFN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int CAFGCCELAIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x20EBD20", Offset = "0x20EAB20", VA = "0x1820EBD20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x20EC000", Offset = "0x20EAE00", VA = "0x1820EC000")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GAPLDMNMIKA, RenderTexture PDDLJOCHIHI, ImposterRenderConfig ILLGLKOBHMD, IHDKPOEEKBM MLJMGIEPDEF, CancellationToken NIEOBBGKEFJ, bool HGEENIHMGNN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x20EBB30", Offset = "0x20EA930", VA = "0x1820EBB30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x20EBF60", Offset = "0x20EAD60", VA = "0x1820EBF60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x20EBD90", Offset = "0x20EAB90", VA = "0x1820EBD90")]
		private static Task<RenderTexture> OHPHPDKNJDF(PPLHCHFEBDH CHKABKNGDMP, CancellationToken NIEOBBGKEFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x20EC3F0", Offset = "0x20EB1F0", VA = "0x1820EC3F0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x20EF8F0", Offset = "0x20EE6F0", VA = "0x1820EF8F0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x20EF5A0", Offset = "0x20EE3A0", VA = "0x1820EF5A0")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
