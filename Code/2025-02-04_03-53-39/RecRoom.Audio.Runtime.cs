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
using RecRoom.Configs;
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class COKBIKPDDNK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x70C2F80", Offset = "0x70C1D80", VA = "0x1870C2F80")]
	public static void LDHBFFBEFJO(this AudioSource EPFFNODPGHD, AudioRolloff MFABKAOJNOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MLAMNJEDMMH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x70C3150", Offset = "0x70C1F50", VA = "0x1870C3150")]
	public static float IHMLOGIGMMO(float LJNACJIKODB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70C3110", Offset = "0x70C1F10", VA = "0x1870C3110")]
	public static float GONNBJLDHFD(float MDDPJGCBHIG)
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
		[Cpp2IlInjected.Address(RVA = "0x70C2BC0", Offset = "0x70C19C0", VA = "0x1870C2BC0")]
		public float FKJHCNPEGGA(float MOMMLAAEHOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70C2E90", Offset = "0x70C1C90", VA = "0x1870C2E90")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OPAPMNAKPOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HEICJGAFMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, NNDGLBEAKFC> KOINFPMJAHH();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, NNDGLBEAKFC> COKILBDDMIL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, BKGNFOOPMPO)> PIGOFAIIOMF();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKGNFOOPMPO IMFBAPBDGJM();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup OEBLAPBCCPN(MJDOLEANDII JHAFGNCABCE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup NPPOFEDFMNC(BKGNFOOPMPO ILPJLKBPBGN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource IGJNMNEJKDO(RecRoomAudioClip GOHLIPHBGDD, Transform MJPIDCIGDJG, [Optional] AudioRolloff ILADIILGDBF, [Optional] Action<SFXAudioSource> NECICDHDNOO, [Optional] BKGNFOOPMPO? JHAFGNCABCE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LAPBDOELOAD(SFXAudioSource DDFCFMDFJAM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource AGLLCDKCEBM(RecRoomAudioClip[] AHPCHNCCAHN, bool OECEPOFPAJP = false, float GELNLNFJMIJ = 1f, [Optional] Action<SFXAudioSource> NECICDHDNOO, [Optional] BKGNFOOPMPO? JHAFGNCABCE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource GBJLKGJEFKK(RecRoomAudioClip[] AHPCHNCCAHN, Transform MJPIDCIGDJG, [Optional] AudioRolloff ILADIILGDBF, bool OECEPOFPAJP = false, [Optional] Action<SFXAudioSource> NECICDHDNOO, [Optional] BKGNFOOPMPO? JHAFGNCABCE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource MCPLFIBOMHD(RecRoomAudioClip FGJBMMDMFLJ, Vector3 OHIOLMDNDJK, bool OILFNIHGCHN, [Optional] AudioRolloff ILADIILGDBF, [Optional] Action<SFXAudioSource> NECICDHDNOO, [Optional] BKGNFOOPMPO? JHAFGNCABCE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource DNCBJAKKHOJ(RecRoomAudioClip DABGBJPJOPF, [Optional] Action<SFXAudioSource> NECICDHDNOO, [Optional] BKGNFOOPMPO? JHAFGNCABCE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CPMKHKOAIIG DNFHBGFLHKN(SFXAudioSource DDFCFMDFJAM, float EJJNBGNLINM, float ENFBFHBOFDG);
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
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x70C3940", Offset = "0x70C2740", VA = "0x1870C3940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x70C3990", Offset = "0x70C2790", VA = "0x1870C3990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70C38F0", Offset = "0x70C26F0", VA = "0x1870C38F0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x70C3900", Offset = "0x70C2700", VA = "0x1870C3900")]
		public RecRoomAudioClip(AudioClip DABGBJPJOPF)
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
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70C3830", Offset = "0x70C2630", VA = "0x1870C3830")]
		public bool OPAHMCJAABN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA79E30", Offset = "0xA78C30", VA = "0x180A79E30")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		protected SFXTrack.NMMKFBKCALJ trackType;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x70C2B90", Offset = "0x70C1990", VA = "0x1870C2B90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public SFXTrack.NMMKFBKCALJ TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8F8F70", Offset = "0x8F7D70", VA = "0x1808F8F70")]
			get
			{
				return default(SFXTrack.NMMKFBKCALJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70C28F0", Offset = "0x70C16F0", VA = "0x1870C28F0")]
		protected void KCOPPENMFHM(string GCKAADIMNCI, SFXTrack.NMMKFBKCALJ NBPAACEJJJD, Guid OGOMDMBFOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70C2A80", Offset = "0x70C1880", VA = "0x1870C2A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70C29A0", Offset = "0x70C17A0", VA = "0x1870C29A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70C2AD0", Offset = "0x70C18D0", VA = "0x1870C2AD0")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAC8300", Offset = "0xAC7100", VA = "0x180AC8300", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70C3A20", Offset = "0x70C2820", VA = "0x1870C3A20")]
		public void KCOPPENMFHM(string GCKAADIMNCI, SFXTrack.NMMKFBKCALJ NBPAACEJJJD, Guid OGOMDMBFOMG, float FFNPMINHFAC, AssetReference LOLNIOCHIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70C2AD0", Offset = "0x70C18D0", VA = "0x1870C2AD0")]
		public RuntimeAddressableSFXTrack()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SFXTracklistRuntimeConfig : SingletonScriptableObject<SFXTracklistRuntimeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PAAPPKCBKBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public PAAPPKCBKBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x70C37D0", Offset = "0x70C25D0", VA = "0x1870C37D0")]
			internal PJFNLCNJIGJ<Guid>.LPBLOPHGOAI KOLDHFDCLHO(RuntimeAddressableSFXTrack track)
			{
				return default(PJFNLCNJIGJ<Guid>.LPBLOPHGOAI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private PJFNLCNJIGJ<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x70C5790", Offset = "0x70C4590", VA = "0x1870C5790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PJFNLCNJIGJ<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x70C5600", Offset = "0x70C4400", VA = "0x1870C5600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70C51F0", Offset = "0x70C3FF0", VA = "0x1870C51F0")]
		public MEPEJIIMKOI<AudioClip> LEEBBBDKNJN(Guid JAGJODIJCAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70C54C0", Offset = "0x70C42C0", VA = "0x1870C54C0")]
		private MEPEJIIMKOI<AudioClip> LEEBBBDKNJN(AssetReference AIALJCELCJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70C5560", Offset = "0x70C4360", VA = "0x1870C5560")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXAudioSource : MonoBehaviour, LPEMEIDPDGH.JGGNCPIPDKE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct JKHEPOEGJDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public float? AEDDGGIFMKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public float? LHFJHEPBLEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Vector3 CNKHDOIHKGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public Transform PLKAGDJFBJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AudioRolloff LHAFFJMFFNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float JMGFCFAOHLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public float FELOHKLMDOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public MJDOLEANDII? FPJKACOHHAM;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public float PDKGACLMFCA
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x70C3090", Offset = "0x70C1E90", VA = "0x1870C3090")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public MJDOLEANDII CMHCCKCGMEI
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x70C3040", Offset = "0x70C1E40", VA = "0x1870C3040")]
				get
				{
					return default(MJDOLEANDII);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct OJEHDIJNEFA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public JKHEPOEGJDM playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x70C31B0", Offset = "0x70C1FB0", VA = "0x1870C31B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x70C3770", Offset = "0x70C2570", VA = "0x1870C3770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BHCPDNEIBHE : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public BHCPDNEIBHE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x70C2EB0", Offset = "0x70C1CB0", VA = "0x1870C2EB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x70C2F30", Offset = "0x70C1D30", VA = "0x1870C2F30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Action<SFXAudioSource> IBNEMCKNIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private NAEGINDHOLH KKNHCDAJAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DPIEDOFFLCF IBMDEBLFLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OPAPMNAKPOD IKMMAPNMJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float GJCHCKECJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float FBKBAHCGBJK;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string LGDHEEKIBBP = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Transform PLKAGDJFBJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int GHBELHLBLHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x70C50D0", Offset = "0x70C3ED0", VA = "0x1870C50D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool NEOMLEGGNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x70C51B0", Offset = "0x70C3FB0", VA = "0x1870C51B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KENAPMPGGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x70C5190", Offset = "0x70C3F90", VA = "0x1870C5190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float AEDDGGIFMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x70C51D0", Offset = "0x70C3FD0", VA = "0x1870C51D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float NHMJPOCMCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70C50F0", Offset = "0x70C3EF0", VA = "0x1870C50F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70C3AF0", Offset = "0x70C28F0", VA = "0x1870C3AF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70C4350", Offset = "0x70C3150", VA = "0x1870C4350")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70C5010", Offset = "0x70C3E10", VA = "0x1870C5010")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x70C4FF0", Offset = "0x70C3DF0", VA = "0x1870C4FF0")]
		public void UpdateVolume(float KECENIEPANK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70C4DE0", Offset = "0x70C3BE0", VA = "0x1870C4DE0")]
		public void UpdatePitch(float BCFLCOGNOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x70C4D40", Offset = "0x70C3B40", VA = "0x1870C4D40")]
		public void UpdateDopplerLevel(float CKCFFGOCINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70C4F50", Offset = "0x70C3D50", VA = "0x1870C4F50")]
		public void UpdateSpatialBlend(float ECOMHCABEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x70C4C70", Offset = "0x70C3A70", VA = "0x1870C4C70")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70C4630", Offset = "0x70C3430", VA = "0x1870C4630")]
		public void Play(AudioClip DABGBJPJOPF, float KECENIEPANK, Vector3 OHIOLMDNDJK, float PADPHNDCGJE, float AHAMMKAJFBD, AudioRolloff MFABKAOJNOP, [Optional] Action<SFXAudioSource> HLBDLNJNDNK, [Optional] BKGNFOOPMPO? JHAFGNCABCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70C44E0", Offset = "0x70C32E0", VA = "0x1870C44E0")]
		[AsyncStateMachine(typeof(OJEHDIJNEFA))]
		public Task PlayAsync(AudioClip DABGBJPJOPF, JKHEPOEGJDM IMOCAAJCFPK, CancellationToken FEHCANHDGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x70C3BF0", Offset = "0x70C29F0", VA = "0x1870C3BF0")]
		private void LOIIIDMJEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70C4300", Offset = "0x70C3100", VA = "0x1870C4300")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70C4CA0", Offset = "0x70C3AA0", VA = "0x1870C4CA0")]
		public void Scrub(float LEAPIIAHEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70C4D00", Offset = "0x70C3B00", VA = "0x1870C4D00")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x70C4BA0", Offset = "0x70C39A0", VA = "0x1870C4BA0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x70C4B20", Offset = "0x70C3920", VA = "0x1870C4B20")]
		[IteratorStateMachine(typeof(BHCPDNEIBHE))]
		public IEnumerator<HLGDLHCLDFE> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x70C3BE0", Offset = "0x70C29E0", VA = "0x1870C3BE0", Slot = "4")]
		private void EPNCEBFNCNE(bool BNMEJFFHBGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
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
