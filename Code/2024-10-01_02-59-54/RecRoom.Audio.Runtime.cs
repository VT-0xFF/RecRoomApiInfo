using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Audio;
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JEAHHFCKOLO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C577B0", Offset = "0x6C56BB0", VA = "0x186C577B0")]
	public static void ABLGAKHPKOI(this AudioSource EPIFFPFGCOE, AudioRolloff CKGCACHCDOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BIJPMBGLPNG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C57070", Offset = "0x6C56470", VA = "0x186C57070")]
	public static float HAIKMMEFPOF(float PDAMGBFELON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C57030", Offset = "0x6C56430", VA = "0x186C57030")]
	public static float BCBPEKEKPGF(float KMMHJHMPPJI)
	{
		return default(float);
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C56D50", Offset = "0x6C56150", VA = "0x186C56D50")]
		public float HKPPEAANJEG(float EDLJJAHNKDN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C57010", Offset = "0x6C56410", VA = "0x186C57010")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CGAHONIEELN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int FDFEMEAILBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, LDCIFMJMAPN> KHNKJAHJKGM();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, KDAOKDKJOPC)> FPGPNFPBLPK();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup APPDLGGANED(LILEDBDJILP DKMFNPFKINH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup GHGFCNHDALF(KDAOKDKJOPC GNLKLDCKJAM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource ELNLIIDFFDP(RecRoomAudioClip GMELNMBMGJM, Transform KCLEDILKPJE, [Optional] AudioRolloff ALDLOKJNPKD, [Optional] Action<SFXAudioSource> CJGBFDJBCFL, [Optional] KDAOKDKJOPC? DKMFNPFKINH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIODDPKFMLG(SFXAudioSource ONFCGEKHMKB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource HIOJFMDKHHC(RecRoomAudioClip[] JAIMGACCKJD, bool CCODAGOJBLK = false, float PEIEPFDFCPO = 1f, [Optional] Action<SFXAudioSource> CJGBFDJBCFL, [Optional] KDAOKDKJOPC? DKMFNPFKINH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource ELLKFCPHGFG(RecRoomAudioClip[] JAIMGACCKJD, Transform KCLEDILKPJE, [Optional] AudioRolloff ALDLOKJNPKD, bool CCODAGOJBLK = false, [Optional] Action<SFXAudioSource> CJGBFDJBCFL, [Optional] KDAOKDKJOPC? DKMFNPFKINH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource FNEDAGOCPNG(RecRoomAudioClip JFMAAHMLJKK, Vector3 HDGFJIGDDLF, bool BHJPGKELPOP, [Optional] AudioRolloff ALDLOKJNPKD, [Optional] Action<SFXAudioSource> CJGBFDJBCFL, [Optional] KDAOKDKJOPC? DKMFNPFKINH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource PPLJJPKMGHK(RecRoomAudioClip GKKOBCIDJDL, [Optional] Action<SFXAudioSource> CJGBFDJBCFL, [Optional] KDAOKDKJOPC? DKMFNPFKINH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GJOIDBBGEPO BJBPLNKPCFP(SFXAudioSource ONFCGEKHMKB, float ENNMKDAFNAP, float HBCBOLHLONH);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Pitch")]
		[Range(0f, 2f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6C57A50", Offset = "0x6C56E50", VA = "0x186C57A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C57AA0", Offset = "0x6C56EA0", VA = "0x186C57AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C57A00", Offset = "0x6C56E00", VA = "0x186C57A00")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C57A10", Offset = "0x6C56E10", VA = "0x186C57A10")]
		public RecRoomAudioClip(AudioClip GKKOBCIDJDL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C57940", Offset = "0x6C56D40", VA = "0x186C57940")]
		public bool IICGIBDKALG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA79810", Offset = "0xA78C10", VA = "0x180A79810")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SFXAudioSource : MonoBehaviour, OBMKGOLDKGA.NDLNBGPAGMH
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct DJMABKABKBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public float? JFJFOCCNOAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public float? NKCIBIMFJBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Vector3 NIKPLLMLIBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform KJAJGOELPGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AudioRolloff MEGDJJBLCKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float BDALCFHEANG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float KENKBCGKABO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public LILEDBDJILP? NGBPPGCLIIM;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float KJAFJOLFGCH
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x6C570D0", Offset = "0x6C564D0", VA = "0x186C570D0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public LILEDBDJILP JFHCOBEFDFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6C57150", Offset = "0x6C56550", VA = "0x186C57150")]
				get
				{
					return default(LILEDBDJILP);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct JBCIANNAPBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public DJMABKABKBA playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6C571A0", Offset = "0x6C565A0", VA = "0x186C571A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6C57750", Offset = "0x6C56B50", VA = "0x186C57750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class NFPAOCKIJCI : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private BGFGBHFIDBJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
			[DebuggerHidden]
			public NFPAOCKIJCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6C57870", Offset = "0x6C56C70", VA = "0x186C57870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6C578F0", Offset = "0x6C56CF0", VA = "0x186C578F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Action<SFXAudioSource> ODBPAPHMFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LMEMMAHKEDK FNAEBHEFJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CCENJGFOMNL BMCLCHOIPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CGAHONIEELN EBJCEBLBMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float AMKMMPHMHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float BOCMBNHGBKM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string HEDNIDJHMGC = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform KJAJGOELPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GNJBDANMFJL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C590F0", Offset = "0x6C584F0", VA = "0x186C590F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NPGLEAPIDKN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C591D0", Offset = "0x6C585D0", VA = "0x186C591D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ICLHAILEIKF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6C591B0", Offset = "0x6C585B0", VA = "0x186C591B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float JFJFOCCNOAB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6C591F0", Offset = "0x6C585F0", VA = "0x186C591F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float LFLGBCFNFKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6C59110", Offset = "0x6C58510", VA = "0x186C59110")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C57B30", Offset = "0x6C56F30", VA = "0x186C57B30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C58380", Offset = "0x6C57780", VA = "0x186C58380")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C59030", Offset = "0x6C58430", VA = "0x186C59030")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C59010", Offset = "0x6C58410", VA = "0x186C59010")]
		public void UpdateVolume(float IMKCANIECGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C58E10", Offset = "0x6C58210", VA = "0x186C58E10")]
		public void UpdatePitch(float IPIEKJGFNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C58D70", Offset = "0x6C58170", VA = "0x186C58D70")]
		public void UpdateDopplerLevel(float LEFNIAMBKGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C58F70", Offset = "0x6C58370", VA = "0x186C58F70")]
		public void UpdateSpatialBlend(float POAGIBIGAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C58CA0", Offset = "0x6C580A0", VA = "0x186C58CA0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C58660", Offset = "0x6C57A60", VA = "0x186C58660")]
		public void Play(AudioClip GKKOBCIDJDL, float IMKCANIECGG, Vector3 HDGFJIGDDLF, float JIMDELIDDKA, float BFANGANIJEN, AudioRolloff CKGCACHCDOH, [Optional] Action<SFXAudioSource> PIFMCKAOLOK, [Optional] KDAOKDKJOPC? DKMFNPFKINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C58510", Offset = "0x6C57910", VA = "0x186C58510")]
		[AsyncStateMachine(typeof(JBCIANNAPBA))]
		public Task PlayAsync(AudioClip GKKOBCIDJDL, DJMABKABKBA AFGCECAHPPI, CancellationToken EEHACKMODLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C57C30", Offset = "0x6C57030", VA = "0x186C57C30")]
		private void IHBGACPFANB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C58330", Offset = "0x6C57730", VA = "0x186C58330")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C58CD0", Offset = "0x6C580D0", VA = "0x186C58CD0")]
		public void Scrub(float LBFLJPCMBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C58D30", Offset = "0x6C58130", VA = "0x186C58D30")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C58BD0", Offset = "0x6C57FD0", VA = "0x186C58BD0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C58B50", Offset = "0x6C57F50", VA = "0x186C58B50")]
		[IteratorStateMachine(typeof(NFPAOCKIJCI))]
		public IEnumerator<BGFGBHFIDBJ> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C57C20", Offset = "0x6C57020", VA = "0x186C57C20", Slot = "4")]
		private void DAFIGIGODDO(bool MEFHKNCMBDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public SFXAudioSource()
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
