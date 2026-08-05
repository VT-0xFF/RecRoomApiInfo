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
public enum IOJBEIFOIEC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GNKCJGEKCON
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	LowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	HighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LoudspeakerHighPitch = 22
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CEMBHHGJDMD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Ambience
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FAKDDMFOCPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly CEMBHHGJDMD JJAEBPIDMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string JNHBANFNBFG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A920", Offset = "0x6E99120", VA = "0x186E9A920")]
	public FAKDDMFOCPL(CEMBHHGJDMD FCBFBFKCDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A9C0", Offset = "0x6E991C0", VA = "0x186E9A9C0")]
	public FAKDDMFOCPL(CEMBHHGJDMD FCBFBFKCDAA, string OHHNMCPNDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A890", Offset = "0x6E99090", VA = "0x186E9A890")]
	public bool OJECPBNNBAA(CEMBHHGJDMD CHHEFEPBKLH, string EDPCOKAFBPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FBPLJCMFNCD
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KCALFCEEGCH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CHJEDMPNOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, PPEGNJHNDOM> NEJMFAAIAGA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, FAKDDMFOCPL)> MNMNKDBLLBJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup FGOBJGCHONM(CEMBHHGJDMD FCBFBFKCDAA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup AJILNJIMAMF(FAKDDMFOCPL GJHKAEBAOOB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource CLGNEILCHBH(RecRoomAudioClip ELAKMPHOHLG, Transform GGFMJJGPBON, [Optional] AudioRolloff BPLNDDLPFMJ, [Optional] Action<SFXAudioSource> PDCNJPFPFPN, [Optional] FAKDDMFOCPL? FCBFBFKCDAA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEDJPOAFAGJ(SFXAudioSource BLIPIGKEKEJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource HOCHIBCDLKK(RecRoomAudioClip[] FJMKMBCODDI, bool DODDKHIKKJF = false, float BNBCABNPJNP = 1f, [Optional] Action<SFXAudioSource> PDCNJPFPFPN, [Optional] FAKDDMFOCPL? FCBFBFKCDAA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource ENMLJMCIEAM(RecRoomAudioClip[] FJMKMBCODDI, Transform GGFMJJGPBON, [Optional] AudioRolloff BPLNDDLPFMJ, bool DODDKHIKKJF = false, [Optional] Action<SFXAudioSource> PDCNJPFPFPN, [Optional] FAKDDMFOCPL? FCBFBFKCDAA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource GMFLOJGBEPJ(RecRoomAudioClip DDNPFCOEBDA, Vector3 PKBCOAILGDK, bool LHFEMOAFDFL, [Optional] AudioRolloff BPLNDDLPFMJ, [Optional] Action<SFXAudioSource> PDCNJPFPFPN, [Optional] FAKDDMFOCPL? FCBFBFKCDAA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource FJJFCDBKDLB(RecRoomAudioClip LCEKOAMKFJP, [Optional] Action<SFXAudioSource> PDCNJPFPFPN, [Optional] FAKDDMFOCPL? FCBFBFKCDAA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MAFNBIAMDKA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AC00", Offset = "0x6E99400", VA = "0x186E9AC00")]
	public static float FHDFKPKPILH(float KGKLIGIICOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E9AC50", Offset = "0x6E99450", VA = "0x186E9AC50")]
	public static float FHKFAOAAOKC(float IPCLBGHEPAD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AMINMMEAIOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E9A510", Offset = "0x6E98D10", VA = "0x186E9A510")]
	public static void ANAMHKHJFJF(this AudioSource KHNOKGADGKH, AudioRolloff FMLPHDHDCLF)
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A5D0", Offset = "0x6E98DD0", VA = "0x186E9A5D0")]
		public float JNHDGKBJMCO(float AEEIFGNFLPK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E9A870", Offset = "0x6E99070", VA = "0x186E9A870")]
		public AudioRolloff()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Header("Pitch")]
		[Range(0f, 0f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6E9ADC0", Offset = "0x6E995C0", VA = "0x186E9ADC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E9AE00", Offset = "0x6E99600", VA = "0x186E9AE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AD50", Offset = "0x6E99550", VA = "0x186E9AD50")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AD70", Offset = "0x6E99570", VA = "0x186E9AD70")]
		public RecRoomAudioClip(AudioClip LCEKOAMKFJP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AC80", Offset = "0x6E99480", VA = "0x186E9AC80")]
		public bool ENCCJOIMHAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9176C0", Offset = "0x915EC0", VA = "0x1809176C0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, OONIIOJGNNG.HMMBKGCDFEH
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct LEBBNIJMCHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? HOEHNJGEIEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? PCPDEIDFOPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Vector3 MOJHGIDCOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Transform IDHFMJLKEMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AudioRolloff OBGHJAOIHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float IMBILIPKDLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float EBMCLHLMKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public CEMBHHGJDMD? JJAEBPIDMDD;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float DCJICHDJONA
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6E9AB70", Offset = "0x6E99370", VA = "0x186E9AB70")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public CEMBHHGJDMD JFLAMKEDPJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6E9AB20", Offset = "0x6E99320", VA = "0x186E9AB20")]
				get
				{
					return default(CEMBHHGJDMD);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AJFJBPJMBOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public LEBBNIJMCHM playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private float <pitch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public AJFJBPJMBOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E99EE0", Offset = "0x6E986E0", VA = "0x186E99EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JLDKIFAIJNJ : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private EPHOKNIGMNK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public JLDKIFAIJNJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9AA30", Offset = "0x6E99230", VA = "0x186E9AA30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9AAE0", Offset = "0x6E992E0", VA = "0x186E9AAE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> KMEEEEJAPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private KIPKMCKINOD LFDKDBINCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private LDOHJBCKEED JJMBKAONKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KCALFCEEGCH OLKKENMHDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float GDHJNENLCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float HLMBAODKGJD;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string ANNHIBKEBGL = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform IDHFMJLKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int AEGALMBOHPM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C530", Offset = "0x6E9AD30", VA = "0x186E9C530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HDPDOIBILKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C620", Offset = "0x6E9AE20", VA = "0x186E9C620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CNEAJCGMLEG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C600", Offset = "0x6E9AE00", VA = "0x186E9C600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float HOEHNJGEIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C640", Offset = "0x6E9AE40", VA = "0x186E9C640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float GEFINMLLHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E9C550", Offset = "0x6E9AD50", VA = "0x186E9C550")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B620", Offset = "0x6E99E20", VA = "0x186E9B620")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B740", Offset = "0x6E99F40", VA = "0x186E9B740")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C400", Offset = "0x6E9AC00", VA = "0x186E9C400")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C3E0", Offset = "0x6E9ABE0", VA = "0x186E9C3E0")]
		public void UpdateVolume(float IBBAGHDLFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C1C0", Offset = "0x6E9A9C0", VA = "0x186E9C1C0")]
		public void UpdatePitch(float CODEFJJMLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C120", Offset = "0x6E9A920", VA = "0x186E9C120")]
		public void UpdateDopplerLevel(float FOINKKCCGNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C340", Offset = "0x6E9AB40", VA = "0x186E9C340")]
		public void UpdateSpatialBlend(float PPCABEEOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C040", Offset = "0x6E9A840", VA = "0x186E9C040")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E9BA90", Offset = "0x6E9A290", VA = "0x186E9BA90")]
		public void Play(AudioClip LCEKOAMKFJP, float IBBAGHDLFPC, Vector3 PKBCOAILGDK, float OJGOANIFBNJ, float MDBKIILNNFJ, AudioRolloff FMLPHDHDCLF, [Optional] Action<SFXAudioSource> FNBHPDCBKMC, [Optional] FAKDDMFOCPL? FCBFBFKCDAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B8D0", Offset = "0x6E9A0D0", VA = "0x186E9B8D0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AJFJBPJMBOI))]
		public Task PlayAsync(AudioClip LCEKOAMKFJP, LEBBNIJMCHM AKHHJMGEOBB, CancellationToken NNLBJPBEHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AE80", Offset = "0x6E99680", VA = "0x186E9AE80")]
		private void ADGMDDLMFNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B6F0", Offset = "0x6E99EF0", VA = "0x186E9B6F0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C070", Offset = "0x6E9A870", VA = "0x186E9C070")]
		public void Scrub(float MJLKABMFGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C0E0", Offset = "0x6E9A8E0", VA = "0x186E9C0E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E9BF50", Offset = "0x6E9A750", VA = "0x186E9BF50")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E9BEE0", Offset = "0x6E9A6E0", VA = "0x186E9BEE0")]
		[IteratorStateMachine(typeof(JLDKIFAIJNJ))]
		public IEnumerator<EPHOKNIGMNK> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E9B6E0", Offset = "0x6E99EE0", VA = "0x186E9B6E0", Slot = "4")]
		private void LALKNANBLJG(bool LLMANHIAOLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C4D0", Offset = "0x6E9ACD0", VA = "0x186E9C4D0")]
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
