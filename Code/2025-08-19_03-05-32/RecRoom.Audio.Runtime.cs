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
using RecNet;
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Build;
using RecRoom.Configs;
using RecRoom.Core;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Pools;
using RecRoom.DataLayer.Audio;
using RecRoom.DataStructures;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.NoEngine.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class OUGKWDJIUJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83A6790", Offset = "0x83A5590", VA = "0x1883A6790")]
		public static void ALZADJVJERN(this AudioSource a, AudioRolloff b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class YEOYKXEMUFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83A8D20", Offset = "0x83A7B20", VA = "0x1883A8D20")]
		public static float CHEEKPDWQOB(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83A8D80", Offset = "0x83A7B80", VA = "0x1883A8D80")]
		public static float DAZMXJTXDLT(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83A8DC0", Offset = "0x83A7BC0", VA = "0x1883A8DC0")]
		public static float SUDLJYXNXWI(float[] a)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowSerialization]
	public enum AudioPriority : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		MaxPriority = 0,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Music_2D = 5,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		SFX_2D = 15,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Voice_AI = 50,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Voice_2D = 100,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Ambient_2D = 115,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Default = 128,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LowestPriority = 255
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float ORXSENRUNNJ = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83A5E30", Offset = "0x83A4C30", VA = "0x1883A5E30")]
		public float UQBBNPJXCQL(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83A6100", Offset = "0x83A4F00", VA = "0x1883A6100")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int CEASFLDOETE = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private AIICZIUCQBN<float> XZMXJDATRZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int UBFUAZVEHGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float CUBPPJKUJFN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int WZDWPLYCSUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC5360", VA = "0x180AC6560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83A6530", Offset = "0x83A5330", VA = "0x1883A6530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float XSHVHYVEUHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x83A64A0", Offset = "0x83A52A0", VA = "0x1883A64A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DDRXEHAXWBO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83A6470", Offset = "0x83A5270", VA = "0x1883A6470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDD7560", Offset = "0xDD6360", VA = "0x180DD7560")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool IDBAGAAVTOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x83A6120", Offset = "0x83A4F20", VA = "0x1883A6120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83A6390", Offset = "0x83A5190", VA = "0x1883A6390")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83A61A0", Offset = "0x83A4FA0", VA = "0x1883A61A0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83A63E0", Offset = "0x83A51E0", VA = "0x1883A63E0")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DGOHPZRIVBN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int EPCMLZDOCQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Dictionary<string, EnumChoiceData> BLYVJVZWIUY();

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Dictionary<string, EnumChoiceData> YXMZXJLPUOM();

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IList<(string, ChannelAndSubChannel)> CUFVVIWWOYS();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ChannelAndSubChannel FCEGHICYBZC();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AudioMixerGroup FZBRVEEYUSL(Channel a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		AudioMixerGroup HEXBRURZWGR(ChannelAndSubChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		SFXAudioSource IUHEJOSOQKB(RecRoomAudioClip a, Transform b, [Optional] AudioRolloff c, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GTQMYPHDWPA(SFXAudioSource a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SFXAudioSource KFTBGGIZUHN(RecRoomAudioClip[] a, bool b = false, float c = 1f, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SFXAudioSource NNSHMJWEFWM(RecRoomAudioClip[] a, Transform b, [Optional] AudioRolloff c, bool d = false, [Optional] Action<SFXAudioSource> e, [Optional] ChannelAndSubChannel? f);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SFXAudioSource NRBSUXMHJKV(RecRoomAudioClip a, Vector3 b, [Optional] AudioRolloff c, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e, bool f = false, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		SFXAudioSource ZNILLEIKRFY(RecRoomAudioClip a, [Optional] Action<SFXAudioSource> b, [Optional] ChannelAndSubChannel? c, bool d = false);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83A65C0", Offset = "0x83A53C0", VA = "0x1883A65C0", Slot = "12")]
		ObjectPool.PooledObject<SFXAudioSource> VLASRQWQUVO(bool a)
		{
			return default(ObjectPool.PooledObject<SFXAudioSource>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ObjectPool.PooledObject<SFXAudioSource> VJKLUEAWEKW();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectPool.PooledObject<SFXAudioSource> KRIHJASKMRH();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DLHIAPQRHVO UQJEMWKDJSA(SFXAudioSource a, float b, float c);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Volume")]
		[SerializeField]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Header("Pitch")]
		[Range(0f, 2f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x83A6A30", Offset = "0x83A5830", VA = "0x1883A6A30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x83A6A80", Offset = "0x83A5880", VA = "0x1883A6A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83A69E0", Offset = "0x83A57E0", VA = "0x1883A69E0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83A69F0", Offset = "0x83A57F0", VA = "0x1883A69F0")]
		public RecRoomAudioClip(AudioClip clip)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83A6920", Offset = "0x83A5720", VA = "0x1883A6920")]
		public bool HasValidClip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		protected SFXTrack.AudioType trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x251CF80", Offset = "0x251BD80", VA = "0x18251CF80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SFXTrack.AudioType TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			get
			{
				return default(SFXTrack.AudioType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83A5BC0", Offset = "0x83A49C0", VA = "0x1883A5BC0")]
		protected void DEGKCMGWNME(string a, SFXTrack.AudioType b, Guid c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D30", Offset = "0x83A4B30", VA = "0x1883A5D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83A5C60", Offset = "0x83A4A60", VA = "0x1883A5C60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D80", Offset = "0x83A4B80", VA = "0x1883A5D80")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD79AB0", Offset = "0xD788B0", VA = "0x180D79AB0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83A6B10", Offset = "0x83A5910", VA = "0x1883A6B10")]
		public void EditorSetValues(string friendlyName, SFXTrack.AudioType trackType, Guid guid, float clipLengthSeconds, AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D80", Offset = "0x83A4B80", VA = "0x1883A5D80")]
		public RuntimeAddressableSFXTrack()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXTracklistRuntimeConfig : SingletonScriptableObject<SFXTracklistRuntimeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ZLLAWYXLGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int PDEUKCYXEDE;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZLLAWYXLGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83A8E20", Offset = "0x83A7C20", VA = "0x1883A8E20")]
			internal JQLAYDRHQZL<Guid>.Pair MSYNUYGGBDT(RuntimeAddressableSFXTrack a)
			{
				return default(JQLAYDRHQZL<Guid>.Pair);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JQLAYDRHQZL<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x83A86E0", Offset = "0x83A74E0", VA = "0x1883A86E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JQLAYDRHQZL<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x83A8560", Offset = "0x83A7360", VA = "0x1883A8560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83A8190", Offset = "0x83A6F90", VA = "0x1883A8190")]
		public NMFGCGLVGPZ<AudioClip> LoadClip(Guid clipId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83A8440", Offset = "0x83A7240", VA = "0x1883A8440")]
		private NMFGCGLVGPZ<AudioClip> MBVDQSIGCIB(AssetReference a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83A84D0", Offset = "0x83A72D0", VA = "0x1883A84D0")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, JBYRPIRPYES.QOVOHOBUPRZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct PlayParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? Volume;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? VolumeScalar;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Vector3 Point;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Transform FollowTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AudioRolloff AudioRolloff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float PitchShift;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float PitchVariation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Channel? Channel;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public float INBJATLIUCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x83A6850", Offset = "0x83A5650", VA = "0x1883A6850")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Channel HQIINSMXCCY
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x83A68D0", Offset = "0x83A56D0", VA = "0x1883A68D0")]
				get
				{
					return default(Channel);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <PlayAsync>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public PlayParams playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83A8710", Offset = "0x83A7510", VA = "0x1883A8710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83A8CC0", Offset = "0x83A7AC0", VA = "0x1883A8CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MVJCEFQUQSJ : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public SFXAudioSource WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public MVJCEFQUQSJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83A6710", Offset = "0x83A5510", VA = "0x1883A6710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83A66D0", Offset = "0x83A54D0", VA = "0x1883A66D0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Action<SFXAudioSource> KEEIWNTTGIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private SGMUANPBQKN KOJZFWERRDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool PBBHQPHLQCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private YEADHGPVUSS RSDIYKGQPTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DGOHPZRIVBN ENXYRCMHYBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool? KZDGTFRCYKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float YPGWQKHPGGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float IQVZBJWBHLA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string AGVNRAIMOKZ = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform LLHIHEHNMNB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AudioSource TOOTLGCHSLY
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool JNJHFRWYTTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x83A7E50", Offset = "0x83A6C50", VA = "0x1883A7E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int UYHJZLEMRVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x83A8070", Offset = "0x83A6E70", VA = "0x1883A8070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NNUJYZTGGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x83A8150", Offset = "0x83A6F50", VA = "0x1883A8150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool NXDLZJBYGWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x83A8130", Offset = "0x83A6F30", VA = "0x1883A8130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OBHZZSCJXSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x83A8170", Offset = "0x83A6F70", VA = "0x1883A8170")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float LQQKQKIAEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83A8090", Offset = "0x83A6E90", VA = "0x1883A8090")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83A6BE0", Offset = "0x83A59E0", VA = "0x1883A6BE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83A6D20", Offset = "0x83A5B20", VA = "0x1883A6D20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83A7D70", Offset = "0x83A6B70", VA = "0x1883A7D70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83A7D50", Offset = "0x83A6B50", VA = "0x1883A7D50")]
		public void UpdateVolume(float volume)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83A7B50", Offset = "0x83A6950", VA = "0x1883A7B50")]
		public void UpdatePitch(float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83A7AB0", Offset = "0x83A68B0", VA = "0x1883A7AB0")]
		public void UpdateDopplerLevel(float dopplerLevel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83A7CB0", Offset = "0x83A6AB0", VA = "0x1883A7CB0")]
		public void UpdateSpatialBlend(float spatialBlend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83A7550", Offset = "0x83A6350", VA = "0x1883A7550")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83A7000", Offset = "0x83A5E00", VA = "0x1883A7000")]
		public void Play(AudioClip clip, float volume, Vector3 point, float pitchVariation, float pitchShift, AudioRolloff rolloff, [Optional] Action<SFXAudioSource> onAudioSourceReleaseCallback, [Optional] ChannelAndSubChannel? channel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83A6EB0", Offset = "0x83A5CB0", VA = "0x1883A6EB0")]
		[AsyncStateMachine(typeof(<PlayAsync>d__38))]
		public Task PlayAsync(AudioClip clip, PlayParams playParams, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83A7620", Offset = "0x83A6420", VA = "0x1883A7620")]
		private void UXCTWQRKVIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83A6CD0", Offset = "0x83A5AD0", VA = "0x1883A6CD0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83A7580", Offset = "0x83A6380", VA = "0x1883A7580")]
		public void Scrub(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83A75E0", Offset = "0x83A63E0", VA = "0x1883A75E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83A7470", Offset = "0x83A6270", VA = "0x1883A7470")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83A7400", Offset = "0x83A6200", VA = "0x1883A7400")]
		[IteratorStateMachine(typeof(MVJCEFQUQSJ))]
		public IEnumerator<IMKAVQMVTAL> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83A6BD0", Offset = "0x83A59D0", VA = "0x1883A6BD0", Slot = "4")]
		private void ARBBRUCXDOZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
