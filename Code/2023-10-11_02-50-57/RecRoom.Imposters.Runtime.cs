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
	private readonly struct GCBJONEJGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NFJEPDCIHBD ABCNIBLNOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string JDBNGHCMKPA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1EC0", Offset = "0x7F0CC0", VA = "0x1807F1EC0")]
		public GCBJONEJGNA(NFJEPDCIHBD FCMPCGGPPNI, string JOOJCKANKDG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KGIANAMCGKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public GCBJONEJGNA queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8980", Offset = "0x5CE7780", VA = "0x185CE8980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8D20", Offset = "0x5CE7B20", VA = "0x185CE8D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider LDJDMBAIACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CMOGGAAGIAM<GCBJONEJGNA, GameObject> MMKFCLMADCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MGBJKFOIHHJ LMJAPHLIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private CMOGGAAGIAM<GCBJONEJGNA, GameObject> GBNIBOJBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4250", Offset = "0x5CE3050", VA = "0x185CE4250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KEBHKIIMAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CE43B0", Offset = "0x5CE31B0", VA = "0x185CE43B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4190", Offset = "0x5CE2F90", VA = "0x185CE4190", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CE45E0", Offset = "0x5CE33E0", VA = "0x185CE45E0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4650", Offset = "0x5CE3450", VA = "0x185CE4650")]
	[AsyncStateMachine(typeof(KGIANAMCGKD))]
	private Task<GameObject> POMEJLNENJJ(GCBJONEJGNA LBFOGLDEJKD, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4400", Offset = "0x5CE3200", VA = "0x185CE4400")]
	public Task<GameObject> LoadItemAsync(NFJEPDCIHBD FCMPCGGPPNI, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4770", Offset = "0x5CE3570", VA = "0x185CE4770")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BAGJCEGHNBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NFJEPDCIHBD CALOCCGIFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HNBLFPDIOFJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
		public BAGJCEGHNBH(NFJEPDCIHBD LPAKLLJJGBI, Texture DJCEAPNKDHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MBMPOCEMCDJ
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
	private class PGCLHHKHJIF : DMPKAHEOBML<Texture>, FBNFCIJAKIE, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct ELCLEGJJLNA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public PGCLHHKHJIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CE47B0", Offset = "0x5CE35B0", VA = "0x185CE47B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5CE4FC0", Offset = "0x5CE3DC0", VA = "0x185CE4FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NFJEPDCIHBD LPAKLLJJGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FJCMOHCCIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig PGECOGDGBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken BIBHFGFDEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject DCEFDPMCKAO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BOOMHLJDOCA<Texture> DCMOKMIAIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CE9D30", Offset = "0x5CE8B30", VA = "0x185CE9D30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> GEFJLIOPGBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9E80", Offset = "0x5CE8C80", VA = "0x185CE9E80")]
		public PGCLHHKHJIF(NFJEPDCIHBD LPAKLLJJGBI, RenderTexture FJCMOHCCIMC, ImposterRenderConfig PGECOGDGBIJ, CancellationToken BIBHFGFDEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9D90", Offset = "0x5CE8B90", VA = "0x185CE9D90")]
		[AsyncStateMachine(typeof(ELCLEGJJLNA))]
		private Task<Texture> GFKAAJJFBDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9D20", Offset = "0x5CE8B20", VA = "0x185CE9D20", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9CA0", Offset = "0x5CE8AA0", VA = "0x185CE9CA0")]
		private static void CIPMGHIKJLI(GameObject DCEFDPMCKAO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HBODEDDIGFH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5CE7010", Offset = "0x5CE5E10", VA = "0x185CE7010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x841FE0", Offset = "0x840DE0", VA = "0x180841FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Header("General")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	[SerializeField]
	private MBMPOCEMCDJ size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ELGPBFENPIK("size", MBMPOCEMCDJ.Custom)]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
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
	private static int OHMPPJLAFKL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture OBFCAEDHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AKPJMAMFPHG<GameObject> NJDPFKECMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BJEHAIIHJME EEJIOGLONMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource PEGEFBHNLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DMPKAHEOBML<Texture> EKMNNBCHIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NFJEPDCIHBD KIAGPLFGCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DMDGABGLHLA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int FHBNGIKDLBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8480", Offset = "0x5CE7280", VA = "0x185CE8480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE84D0", Offset = "0x5CE72D0", VA = "0x185CE84D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture HILGHNNEOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7A80", Offset = "0x5CE6880", VA = "0x185CE7A80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x768570", Offset = "0x767370", VA = "0x180768570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NFJEPDCIHBD CALOCCGIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x764C10", Offset = "0x763A10", VA = "0x180764C10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7E70", Offset = "0x5CE6C70", VA = "0x185CE7E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KEPHCNBAMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4EC8A50", Offset = "0x4EC7850", VA = "0x184EC8A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int FNHFIKHGKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7D20", Offset = "0x5CE6B20", VA = "0x185CE7D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7A70", Offset = "0x5CE6870", VA = "0x185CE7A70")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8050", Offset = "0x5CE6E50", VA = "0x185CE8050")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7FD0", Offset = "0x5CE6DD0", VA = "0x185CE7FD0")]
	private void OPCBKOOGLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8360", Offset = "0x5CE7160", VA = "0x185CE8360")]
	public void Set(NFJEPDCIHBD HHBPKNBIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8350", Offset = "0x5CE7150", VA = "0x185CE8350")]
	public void Set(Texture DJCEAPNKDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8370", Offset = "0x5CE7170", VA = "0x185CE8370")]
	public void Set(BAGJCEGHNBH GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7C30", Offset = "0x5CE6A30", VA = "0x185CE7C30")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8150", Offset = "0x5CE6F50", VA = "0x185CE8150")]
	public void SetInternal(NFJEPDCIHBD HHBPKNBIADE, [Optional] Texture CMPOAFNFCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8140", Offset = "0x5CE6F40", VA = "0x185CE8140")]
	public void SetCustomSize(int EHBIGLLBFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7685A0", Offset = "0x7673A0", VA = "0x1807685A0")]
	public void SetAntiAliasing(int DILCIADONGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7DC0", Offset = "0x5CE6BC0", VA = "0x185CE7DC0")]
	[AsyncStateMachine(typeof(HBODEDDIGFH))]
	private void KMDFNLCEHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7C40", Offset = "0x5CE6A40", VA = "0x185CE7C40")]
	private void DMKNNEBCJJN(Texture DJCEAPNKDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8400", Offset = "0x5CE7200", VA = "0x185CE8400")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, MIBFKPHMHGG
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float BGPNJCLGGKM = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public void PrepareImposter(OIDPNBHGLEG FJDDANGEILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7A30", Offset = "0x5CE6830", VA = "0x185CE7A30")]
	public void SetReferencePoint(Vector3 ELHIODNHAHA, Quaternion FIIPDOPILCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7830", Offset = "0x5CE6630", VA = "0x185CE7830")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7A10", Offset = "0x5CE6810", VA = "0x185CE7A10")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x12E7A90", Offset = "0x12E6890", VA = "0x1812E7A90")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LMIICEPHGLB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static LMIICEPHGLB NMBALOFIALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float HDPEFHJOBPE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1EF5060", Offset = "0x1EF3E60", VA = "0x181EF5060")]
	public LMIICEPHGLB(float ALPGMJKECCH)
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
		[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int ABLDNMICOPH = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int FGMOOPECLLO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> FKPDBOIMACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool IPEDJOOKBNN;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5CE86B0", Offset = "0x5CE74B0", VA = "0x185CE86B0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CE85B0", Offset = "0x5CE73B0", VA = "0x185CE85B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CE88F0", Offset = "0x5CE76F0", VA = "0x185CE88F0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NFJEPDCIHBD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string JKFBOLLLPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LMIICEPHGLB LMIICEPHGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DLNBEOMIDIP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NDCDNLCDEBK(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HJEGGAICAPE(NFJEPDCIHBD MFMJJEFODHB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLNAKABJPEJ();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KIFGPBCIKIK();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BKGELOGOIAJ([Out] DMPKAHEOBML<Texture> LPNEIMNHHHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GIDBDHGOBGH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5030", Offset = "0x5CE3E30", VA = "0x185CE5030")]
	public static bool HJOCBJHCAPP(NFJEPDCIHBD LODINIGLPBH, NFJEPDCIHBD BMLPJOCKONK)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, MIBFKPHMHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3740", Offset = "0x5CE2540", VA = "0x185CE3740", Slot = "4")]
		public void PrepareImposter(OIDPNBHGLEG FJDDANGEILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MIBFKPHMHGG
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(OIDPNBHGLEG FJDDANGEILG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MHGGOEPCPIC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KBKHDEECJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HKIFOCJCFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MGBJKFOIHHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject BMBNLLGLLDC(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, bool JIFLIAPHCOB = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BMBNLLGLLDC<T>(T MCMNAIINBFO, Transform LBLLNFOEKNE, bool JIFLIAPHCOB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T BMBNLLGLLDC<T>(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, bool JIFLIAPHCOB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject BMBNLLGLLDC(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, OIDPNBHGLEG FJDDANGEILG, bool JIFLIAPHCOB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KOODBIJGCLM : IDisposable, MGBJKFOIHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> EHGGKGICHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BAAJBFLJGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform PIKAPMEDFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> HJAAPBDCFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> AIBFBKPIIJM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96F0", Offset = "0x5CE84F0", VA = "0x185CE96F0")]
	[GAPOPKHLLNB(OGJCEJIMIKL.None)]
	public static void NHJLANHPGEE(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE97F0", Offset = "0x5CE85F0", VA = "0x185CE97F0")]
	[Preserve]
	public KOODBIJGCLM([NMBHAKGIBHG(null)] MHGGOEPCPIC PAHNJJLJAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8EB0", Offset = "0x5CE7CB0", VA = "0x185CE8EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8D90", Offset = "0x5CE7B90", VA = "0x185CE8D90", Slot = "5")]
	public GameObject BMBNLLGLLDC(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, bool JIFLIAPHCOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2402020", Offset = "0x2400E20", VA = "0x182402020", Slot = "6")]
	public T BMBNLLGLLDC<T>(T MCMNAIINBFO, Transform LBLLNFOEKNE, bool JIFLIAPHCOB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2401FF0", Offset = "0x2400DF0", VA = "0x182401FF0", Slot = "7")]
	public T BMBNLLGLLDC<T>(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, bool JIFLIAPHCOB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8E20", Offset = "0x5CE7C20", VA = "0x185CE8E20", Slot = "8")]
	public GameObject BMBNLLGLLDC(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, OIDPNBHGLEG FJDDANGEILG, bool JIFLIAPHCOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2402600", Offset = "0x2401400", VA = "0x182402600", Slot = "9")]
	public T BMBNLLGLLDC<T>(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, OIDPNBHGLEG FJDDANGEILG, bool JIFLIAPHCOB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2402090", Offset = "0x2400E90", VA = "0x182402090")]
	private T BMBNLLGLLDC<T>(GameObject MCMNAIINBFO, Transform LBLLNFOEKNE, OIDPNBHGLEG FJDDANGEILG, bool JIFLIAPHCOB, [Out] GameObject BBCMAJLBONL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2402640", Offset = "0x2401440", VA = "0x182402640")]
	private T OCFINFCHGML<T>(GameObject DEGGPBGPMDB, OIDPNBHGLEG FJDDANGEILG, bool JIFLIAPHCOB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CE95E0", Offset = "0x5CE83E0", VA = "0x185CE95E0")]
	private void LEGHODMNJFD(Component PMEJDDFHMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9100", Offset = "0x5CE7F00", VA = "0x185CE9100")]
	private void IOMOFAFPHMM(Component PMEJDDFHMDG, OIDPNBHGLEG FJDDANGEILG, bool JIFLIAPHCOB, bool GEJMMHLOOFP, [Optional] Type MPGLFNBFBAB, [Optional] Type MCEEACBHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8F90", Offset = "0x5CE7D90", VA = "0x185CE8F90")]
	private void GCMAOOAMEDB(GameObject DEGGPBGPMDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OIDPNBHGLEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> NHBAIELFHJA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24F1FD0", Offset = "0x24F0DD0", VA = "0x1824F1FD0")]
	public OIDPNBHGLEG KLJMIKDFPBF<T>(T AJABFMGOKIC)
	{
		return default(OIDPNBHGLEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24F2700", Offset = "0x24F1500", VA = "0x1824F2700")]
	public T OMJIHOMPBMI<T>(T HEDIGKLLBHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24F1800", Offset = "0x24F0600", VA = "0x1824F1800")]
	public bool COFEFJFFGMK<T>([Out] T AJABFMGOKIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FDNHFFLMJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool KJOFLMCILBF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xB2E170", Offset = "0xB2CF70", VA = "0x180B2E170")]
	public FDNHFFLMJFH(bool PIFPBIONDLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HGHJPPBFNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool BGOJOGMMPIM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7820", Offset = "0x5CE6620", VA = "0x185CE7820")]
	public HGHJPPBFNMG(bool LPELEHAENLE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, MIBFKPHMHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA000", Offset = "0x5CE8E00", VA = "0x185CEA000", Slot = "4")]
		public void PrepareImposter(OIDPNBHGLEG FJDDANGEILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5CE9C80", Offset = "0x5CE8A80", VA = "0x185CE9C80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5CE9C70", Offset = "0x5CE8A70", VA = "0x185CE9C70")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8550", Offset = "0x5CE7350", VA = "0x185CE8550")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GNMBEDPAJCN
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<URPLight> GAKLOOJKEFM;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Vector3 COCLCDNBBIP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 IICDFMHACPI;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static Camera ABCCNLJOOBK;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> GMDICGAEDOL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode JIHGIJDLMLP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color OPBEINDCJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color FMMBDEIFJFK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color EIFGFAPHJOM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap DLNMKJGCHKD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool MCELOHGOOEN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera MONHHOMKHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6080", Offset = "0x5CE4E80", VA = "0x185CE6080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6290", Offset = "0x5CE5090", VA = "0x185CE6290")]
	public static void JKKOFGOKNMP(Vector3 FDLNLDJCBGH, Quaternion DIEIGDLBHCD, ImposterRenderConfig DMOEEKNCAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CE59F0", Offset = "0x5CE47F0", VA = "0x185CE59F0")]
	private static void FCGOAGGGKBF(Vector3 FDLNLDJCBGH, Quaternion DIEIGDLBHCD, URPLight LPKAGGKELME, ImposterRenderConfig.LightConfig NICCIDCBMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5910", Offset = "0x5CE4710", VA = "0x185CE5910")]
	public static void ELMGOCIPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CE53C0", Offset = "0x5CE41C0", VA = "0x185CE53C0")]
	private static void CHPGEIALEFF(int BEBCOEKCDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5EC0", Offset = "0x5CE4CC0", VA = "0x185CE5EC0")]
	public static void HCLCLOHAIBF(ImposterRenderConfig DMOEEKNCAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5D20", Offset = "0x5CE4B20", VA = "0x185CE5D20")]
	public static void FNEAJPLIHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5740", Offset = "0x5CE4540", VA = "0x185CE5740")]
	public static void DHBGKOKOAPN(GameObject AOOANLHIBPD, RenderTexture FJCMOHCCIMC, ImposterRenderConfig DMOEEKNCAEN, LMIICEPHGLB KJDBNAMBBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE68B0", Offset = "0x5CE56B0", VA = "0x185CE68B0")]
	private static void OIENCOPNEOE(GameObject AOOANLHIBPD, RenderTexture FJCMOHCCIMC, ImposterRenderConfig DMOEEKNCAEN, LMIICEPHGLB KJDBNAMBBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5120", Offset = "0x5CE3F20", VA = "0x185CE5120")]
	private static void AANGGJHDHAE(GameObject AOOANLHIBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6500", Offset = "0x5CE5300", VA = "0x185CE6500")]
	public static void NKGJJHDNJJC(GameObject MCMNAIINBFO, Vector3 OEOJKFOFOKH, Vector3 POAOLNIGILJ, float PABCCIKEEGI, LMIICEPHGLB KJDBNAMBBPM, [Out] Vector3 BEPDAGGEIDH, [Out] Quaternion PMFKBNBLKCO, [Out] float OHDLNKMEIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5E10", Offset = "0x5CE4C10", VA = "0x185CE5E10")]
	public static RenderTexture GCJDOJOPFGG(int OONLFMDCHML, int ADIMMNOIADA, RenderTextureFormat KFLIIANGBGC = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct HDCMLHMDKDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public PFGLJDAMMPM FAEMDIEHBIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject BMJIEENGJMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture HILGHNNEOGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig KCFLAIJKOGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public LMIICEPHGLB LMIICEPHGLB;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5CE77B0", Offset = "0x5CE65B0", VA = "0x185CE77B0")]
			public HDCMLHMDKDC(PFGLJDAMMPM FPDKNAOCMNH, GameObject DEIENPIDAAF, RenderTexture FJCMOHCCIMC, ImposterRenderConfig PGECOGDGBIJ, LMIICEPHGLB KJDBNAMBBPM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static CMOGGAAGIAM<HDCMLHMDKDC, RenderTexture> ECPFDLNNAFB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<HDCMLHMDKDC> IJEGALNBNAC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int FPHKAHOOADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5CE3A80", Offset = "0x5CE2880", VA = "0x185CE3A80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3D30", Offset = "0x5CE2B30", VA = "0x185CE3D30")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject AOOANLHIBPD, RenderTexture FJCMOHCCIMC, ImposterRenderConfig DMOEEKNCAEN, LMIICEPHGLB KJDBNAMBBPM, CancellationToken BIBHFGFDEGJ, bool IKMFLENPKHN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3890", Offset = "0x5CE2690", VA = "0x185CE3890", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3C90", Offset = "0x5CE2A90", VA = "0x185CE3C90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3AF0", Offset = "0x5CE28F0", VA = "0x185CE3AF0")]
		private static Task<RenderTexture> FPHMNMGAPOA(HDCMLHMDKDC OPDOOELHJHB, CancellationToken BIBHFGFDEGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4150", Offset = "0x5CE2F50", VA = "0x185CE4150")]
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
